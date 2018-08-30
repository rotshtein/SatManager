using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CicManagerLib
{
    class DownConverterHandler : NetworkDevice, IDisposable
    {
        public event EventHandler<ConfigurationUpdateEventArgs> OnDownConverterConfigurationUpdateReceived = delegate { };

        public BackgroundWorker _worker;

        public DownConverterHandler()
        {
            // Start status polling
            _worker = new BackgroundWorker { WorkerSupportsCancellation = true };
            _worker.DoWork += (sender, args) =>
            {
                var worker = sender as BackgroundWorker;
                var lastKeepAliveCheck = DateTime.Now;
                var lastKeepAlive = DateTime.Now;
                var status = new DownConverterStatusEventArgs();

                while (!worker.CancellationPending)
                {
                    Thread.Sleep(100);

                    var now = DateTime.Now;

                    if ((now - lastKeepAliveCheck).TotalSeconds > 5)
                    {
                        using (var target = new UdpTarget(IPAddress.Parse(DeviceIp)))
                        {
                            try
                            {
                                var pdu = Pdu.GetPdu(new VbCollection(new[] { new Vb(new Oid("1.3.6.1.2.1.1.1.0")) }));
                                var param = new AgentParameters(SnmpVersion.Ver2, new OctetString("public"));
                                var result = target.Request(pdu, param) as SnmpV2Packet;
                                if (result != null && result.Pdu.ErrorStatus == 0)
                                {
                                    lastKeepAlive = DateTime.Now;
                                    if (!status.IsAlive)
                                    {
                                        status.IsAlive = true;
                                        UpdateDeviceStatus(status);
                                    }
                                }
                            }
                            catch { }
                        }

                        lastKeepAliveCheck = now;
                    }

                    if ((now - lastKeepAlive).TotalSeconds > 30)
                    {
                        if (status.IsAlive)
                        {
                            status.IsAlive = false;
                            UpdateDeviceStatus(status);
                        }
                    }
                }
            };
            _worker.RunWorkerAsync();
        }

        internal void ConfigureCarrier(CarrierInformation configuration)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (_worker != null)
            {
                _worker.CancelAsync();
                _worker = null;
            }
        }
    }

    public class DownConverterStatusEventArgs : EventArgs
    {
        public bool IsAlive { get; set; }
    }
}
