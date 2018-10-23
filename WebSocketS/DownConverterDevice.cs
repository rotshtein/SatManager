using System;
using Lbc4000SnmpDriver;
using Lbc4000Logger;
using System.Net;
using log4net;
using System.Reflection;
using System.Threading;

namespace WebSocketS
{
    class DownConverterDevice : Device
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        private Lbc4000 _device;

        public DownConverterDevice(IPAddress ipAddress, Uri webSocketServer, IguiInterface gui)
            : base(webSocketServer, gui)
        {
            _device = Lbc4000.GetDevice(ipAddress);
        }

        public override bool IsRunnign()
        {
            return _device.TestConnection();
        }

        public override void MonitorThread()
        {
            log.Debug("Down Converter monitor theard started");
            while (runMonitor)
            {
                try
                {
                    Thread.Sleep(200);
                }
                catch (Exception ex)
                {
                    log.Error("Error during monitoring", ex);
                }
            }
        }

        public override void OnReceive(Client sender, byte[] data)
        {
            throw new NotImplementedException();
        }


        public override bool Stop()
        {
            if (_device != null)
            {
                _device.Dispose();
            }
            return true;
        }
    }
}
