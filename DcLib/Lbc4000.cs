using System;
using System.Threading;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using Lbc4000Logger;
using Lbc4000SnmpDriver.Configuration;
using SnmpSharpNet;
using Conv4000Mib;
using Conv4000Mib.conv4000.conv4000Objects.conv4000Config.conv4000ConvAOutput;
using Conv4000Mib.conv4000.conv4000Objects.conv4000Config.conv4000ConvBOutput;
using Conv4000Mib.conv4000.conv4000Objects.conv4000Config.conv4000SpectrumInversionMode;
using Conv4000Mib.conv4000.conv4000Objects.conv4000Faults.conv4000CurrentFaults;
using System.ComponentModel;
using System.Collections.Concurrent;
using Lbc4000SnmpDriver.Enums;

namespace Lbc4000SnmpDriver
{
    public class Lbc4000
    {
        #region private fields

        private BackgroundWorker _sender;
        private BackgroundWorker _receiver;
        private static List<Lbc4000> _deviceList;
        private SnmpV2Packet _result;
        private readonly ConcurrentQueue<Pdu[]> _commands = new ConcurrentQueue<Pdu[]>();
        private Logger _logger;

        #endregion private fields

        #region public properties
        public bool PortAInstalled
        {
            get; private set;
        }

        public bool PortBInstalled
        {
            get; private set;
        }
        public Lbc4000Status Status
        {
            get; private set;
        }

        public IPAddress HostName
        {
            get; private set;
        }

        public string WriteCommunity
        {
            get; private set;
        }

        public string ReadCommunity
        {
            get; private set;
        }

        public int Port
        {
            get; private set;
        }

        public int Retry
        {
            get; private set;
        }

        public int Timeout
        {
            get; private set;
        }

        public int UpdateInterval
        {
            get; private set;
        }

        public bool DataAvailable
        {
            get; private set;
        }

        #endregion public properties

        #region construction and creation of instances

        private Lbc4000(IPAddress ipAddress, string writeCommunity, string readCommunity, int port, int retry, int timeout, int updateInterval = 1000)
        {
            HostName = ipAddress;
            ReadCommunity = readCommunity;
            WriteCommunity = writeCommunity;
            Port = port;
            Retry = retry;
            Timeout = timeout;
            UpdateInterval = updateInterval;
            _logger = Logger.GetLogger();
        }

        public static Lbc4000 GetDevice(IPAddress ipAddress, string writeCommunity="private", string readCommunity="public", int port=161, int retry=3, int timeout=1000, int updateInterval = 1000)
        {
            if (_deviceList == null)
                _deviceList = new List<Lbc4000>();
            foreach (var dev in _deviceList)
                if (dev.HostName == ipAddress)
                    //throw new Exception("Device already exists!"); // TODO: or return existing device?
                    return dev;

            var newInstance = new Lbc4000(ipAddress, writeCommunity, readCommunity, port, retry, timeout, updateInterval);
            _deviceList.Add(newInstance);
            return newInstance;
        }

        #endregion construction and creation of instances

        #region public methods

        public void Run()
        {
            using (var target = new UdpTarget(HostName, Port, Timeout, Retry))
            {
                PortAInstalled = GetPortAInstalled(target);
                PortBInstalled = GetPortBInstalled(target);
            }
            RunConfigurationLoop();
            RunSetCommands();
        }

        public bool Connect()
        {
            return TestConnection();
        }

        public bool TestConnection()
        {
            // TODO: change from ping to an SNMP message specific for LBC4000
            var pingger = new Ping();
            var pingOptions = new PingOptions();
            pingOptions.DontFragment = true;
            string data = "TestingLbc4000DownConverter";
            byte[] dataBuffer = Encoding.ASCII.GetBytes(data);
            var reply = pingger.Send(HostName, Timeout, dataBuffer, pingOptions);
            if (reply.Status == IPStatus.Success)
                return true;
            _logger.WriteMessage(String.Format("Device {0} is not reachable", HostName), DebugLevel.DEBUG);
            return false;
        }

        public bool Dispose()
        {
            try
            {
                if (_sender != null)
                    _sender.CancelAsync();
                if (_receiver != null)
                    _receiver.CancelAsync();
            }
            catch (Exception e)
            {
                _logger.WriteMessage(e.Message, DebugLevel.ERROR);
                return false;
            }
            _logger.WriteMessage("Device disposed successfully", DebugLevel.DEBUG);
            return true;
        }

        #endregion pubcic methods

        #region private methods

        private void TestBackgroundWorkersUdpTarget()
        {
            // only used for testing
            var t1 = new UdpTarget(HostName, Port, Timeout, Retry);
            var t2 = new UdpTarget(HostName, Port, Timeout, Retry);

            var w1 = new BackgroundWorker { WorkerSupportsCancellation = true };
            var w2 = new BackgroundWorker { WorkerSupportsCancellation = true };

            w1.DoWork += (sender1, e1) =>
            {
                while (true)
                {
                    var pdu = Pdu.GetPdu();
                    var param = new AgentParameters(SnmpVersion.Ver2, new OctetString("public"));
                    try
                    {
                        var response = t1.Request(pdu, param);
                        _logger.WriteMessage("worker1 Fired!", DebugLevel.DEBUG);
                    }
                    catch (Exception ex) { _logger.WriteMessage(ex.Message, DebugLevel.ERROR); }
                }
            };

            w1.DoWork += (sender2, e2) =>
            {
                while (true)
                {

                    var pdu = Pdu.SetPdu();
                    var param = new AgentParameters(SnmpVersion.Ver2, new OctetString("private"));
                    try
                    {
                        var response = t2.Request(pdu, param);
                        _logger.WriteMessage("worker2 Fired!", DebugLevel.DEBUG);
                    }
                    catch (Exception ex) { _logger.WriteMessage(ex.Message, DebugLevel.ERROR); }
                }
            };

            w1.RunWorkerAsync();
            w2.RunWorkerAsync();
        }

        private void RunSetCommands()
        {
            // This runs all the time and waits for SET requesets to be appended to _commands.
            _sender = new BackgroundWorker { WorkerSupportsCancellation = true, WorkerReportsProgress = true };
            _sender.DoWork += (sender, e) =>
            {
                _logger.WriteMessage("Sending worker started", DebugLevel.DEBUG);
                var worker = sender as BackgroundWorker;
                while (!worker.CancellationPending)
                {
                    try
                    {
                        using (var target = new UdpTarget(HostName, Port, Timeout, Retry))
                        {
                            while (_commands.TryDequeue(out Pdu[] pdus))
                            {
                                foreach (var pdu in pdus)
                                {
                                    try
                                    {
                                        var param = new AgentParameters(SnmpVersion.Ver2, new OctetString(WriteCommunity));
                                        var result = target.Request(pdu, param);
                                        if (result == null)
                                        {
                                            _logger.WriteMessage("Send command result is null", DebugLevel.ERROR);
                                        }
                                        else if (result.Pdu.ErrorStatus != 0)
                                        {
                                            _logger.WriteMessage(String.Format("{0} raised error number: {1} - {2}", result.Pdu.RequestId, result.Pdu.ErrorIndex, ((PduErrorStatus)result.Pdu.ErrorIndex).ToString()), DebugLevel.ERROR);
                                        }
                                        else
                                        {
                                            worker.ReportProgress(0);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        _logger.WriteMessage(ex.Message, DebugLevel.ERROR);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.WriteMessage(ex.Message, DebugLevel.ERROR);
                    }
                }
            };

            _sender.RunWorkerAsync();
        }

        private void RunConfigurationLoop()
        {
            _receiver = new BackgroundWorker { WorkerSupportsCancellation = true };
            _receiver.DoWork += (sender, e) =>
            {
                var worker = sender as BackgroundWorker;
                _logger.WriteMessage("Receiving worker started", DebugLevel.DEBUG);
                using (var target = new UdpTarget(HostName, Port, Timeout, Retry))
                {
                    while (!worker.CancellationPending)
                    {
                        if (GetCurrentInformation(target))
                        {
                            worker.ReportProgress(1);
                            _logger.WriteMessage("Got information successfully!", DebugLevel.DEBUG);
                        }
                        else
                        {
                            worker.ReportProgress(0);
                            _logger.WriteMessage("Couldn't get information.", DebugLevel.ERROR);
                        }
                        Thread.Sleep(UpdateInterval);
                    }
                }
            };

            _receiver.RunWorkerAsync();
        }

        private bool ParseCurrentInformation()
        {
            if (_result == null) return false;

            var vbList = _result.Pdu.VbList;
            var portA = new PortAConfiguration((Integer32)vbList[1].Value,  //frequency
                                               (Integer32)vbList[2].Value,  //mute
                                               (Integer32)vbList[3].Value,  //mute configure
                                               (Integer32)vbList[4].Value,  //attenuator
                                               (Integer32)vbList[5].Value,  //slope
                                               (Integer32)vbList[7].Value); //inverse

            var portB = new PortBConfiguration((Integer32)vbList[9].Value,  //frequency
                                               (Integer32)vbList[10].Value, //mute
                                               (Integer32)vbList[11].Value, //mute configure
                                               (Integer32)vbList[12].Value, //attenuator
                                               (Integer32)vbList[13].Value, //slope
                                               (Integer32)vbList[14].Value);//inverse

            _logger.WriteAsIs(portA.ToString());
            _logger.WriteAsIs(portB.ToString());

            var faults = new FaultList((Integer32)vbList[15].Value,
                                       (Integer32)vbList[16].Value,
                                       (Integer32)vbList[17].Value,
                                       (Integer32)vbList[18].Value,
                                       (Integer32)vbList[19].Value,
                                       (Integer32)vbList[20].Value,
                                       (Integer32)vbList[21].Value,
                                       (Integer32)vbList[22].Value,
                                       (Integer32)vbList[23].Value,
                                       (Integer32)vbList[24].Value,
                                       (Integer32)vbList[25].Value,
                                       (Integer32)vbList[26].Value,
                                       (Integer32)vbList[27].Value);
            Status = new Lbc4000Status(portA, portB, faults);
            return true;
        }

        private bool GetCurrentInformation(UdpTarget target)
        {
            try
            {
                if (GetAllConfigurationPdu(target))
                {
                    ParseCurrentInformation();
                    return true;
                }
                else
                {
                    _logger.WriteMessage("GetAllconfigurationPdu", DebugLevel.ERROR);
                }
            }
            catch (Exception ex)
            {
                _logger.WriteMessage(ex.Message, DebugLevel.ERROR);
            }
            finally
            {
                _result = null;
            }
            return false;
        }

        private Vb CreateVb(string oid)
        {
            return new Vb(new Oid(oid));
        }

        private Vb CreateVb<T>(string oid, T value)
        {
            if (value.GetType() == typeof(int))
                return new Vb(new Oid(oid), new Integer32(value.ToString()));
            else if (value.GetType() == typeof(uint))
                return new Vb(new Oid(oid), new Gauge32(value.ToString()));
            else if (value.GetType() == typeof(PhysicalAddress))
                return new Vb(new Oid(oid), new OctetString((value as PhysicalAddress).GetAddressBytes()));
            else if (value.GetType() == typeof(IPAddress))
                return new Vb(new Oid(oid), new OctetString((value as IPAddress).GetAddressBytes()));
            else if (value.GetType() == typeof(bool))
                return new Vb(new Oid(oid), new Integer32(value.ToString().ToLower() == "true" ? 1 : 0));
            else
                return new Vb(new Oid(oid), new OctetString(value.ToString()));
        }

        #endregion private methods

        #region SNMP Gets

        private bool GetAllConfigurationPdu(UdpTarget target)
        {
            VbCollection vbCollection = new VbCollection();
            vbCollection.Add(conv4000ConvAInstalled.Default.oid);                        //0
            vbCollection.Add(conv4000ConvAFrequency.Default.oid);                        //1
            vbCollection.Add(conv4000ConvAMute.Default.oid);                             //2
            vbCollection.Add(conv4000ConvAConfigMuteMode.Default.oid);                   //3
            vbCollection.Add(conv4000ConvAAttenuator.Default.oid);                       //4
            vbCollection.Add(conv4000ConvASlope.Default.oid);                            //5
            vbCollection.Add(conv4000ConvAAttenuationOffset.Default.oid);                //6
            vbCollection.Add(conv4000convASpectrumInversion.Default.oid);                //7
            vbCollection.Add(conv4000ConvBInstalled.Default.oid);                        //8
            vbCollection.Add(conv4000ConvBFrequency.Default.oid);                        //9
            vbCollection.Add(conv4000ConvBMute.Default.oid);                             //10
            vbCollection.Add(conv4000ConvBConfigMuteMode.Default.oid);                   //11
            vbCollection.Add(conv4000ConvBAttenuator.Default.oid);                       //12
            vbCollection.Add(conv4000ConvBSlope.Default.oid);                            //13
            vbCollection.Add(conv4000convBSpectrumInversion.Default.oid);                //14
            vbCollection.Add(conv4000PSA12VFault.Default.oid);                           //15
            vbCollection.Add(conv4000PSA08VFault.Default.oid);                           //16
            vbCollection.Add(conv4000PSA05VFault.Default.oid);                           //17
            vbCollection.Add(conv4000PSB12VFault.Default.oid);                           //18
            vbCollection.Add(conv4000PSB08VFault.Default.oid);                           //19
            vbCollection.Add(conv4000PSB05VFault.Default.oid);                           //20
            vbCollection.Add(conv4000ConvARFLOFault.Default.oid);                        //21
            vbCollection.Add(conv4000ConvAIFLOFault.Default.oid);                        //22
            vbCollection.Add(conv4000ConvATempFault.Default.oid);                        //23
            vbCollection.Add(conv4000ConvBIFLOFault.Default.oid);                        //24
            vbCollection.Add(conv4000ConvBRFLOFault.Default.oid);                        //25
            vbCollection.Add(conv4000ConvBTempFault.Default.oid);                        //26
            vbCollection.Add(conv4000ExternalRefFault.Default.oid);                      //27
            try
            {
                var pdu = Pdu.GetPdu(vbCollection);
                var param = new AgentParameters(SnmpVersion.Ver2, new OctetString(pdu.Type == PduType.Get ? ReadCommunity : WriteCommunity));
                var response = target.Request(pdu, param);
                if (!(response is SnmpV2Packet)) return false;                                      // not a valid packet
                if (response.Pdu.ErrorStatus != 0) return false;                                    // an error occured
                _result = (SnmpV2Packet)response;
                _logger.WriteMessage("Got results successfully.", DebugLevel.DEBUG);
                return true;
            }
            catch
            {
                _logger.WriteMessage("An error occured in GetConfigurationPdu.", DebugLevel.ERROR);
                return false;
            }
        }

        public bool GetPortAInstalled(UdpTarget target)
        {
            try
            {
                var pdu = Pdu.GetPdu(new VbCollection { CreateVb(conv4000ConvAInstalled.Default.oid) });
                var param = new AgentParameters(SnmpVersion.Ver2, new OctetString(pdu.Type == PduType.Get ? ReadCommunity : WriteCommunity));
                var response = target.Request(pdu, param);
                if (!(response is SnmpV2Packet)) return false;
                if (response.Pdu.ErrorStatus != 0) return false;
                return (Integer32)response.Pdu.VbList[0].Value == 1 ? true : false;
            }
            catch (Exception ex)
            {
                _logger.WriteMessage(ex.Message, DebugLevel.ERROR);
                return false;
            }
        }

        public bool GetPortBInstalled(UdpTarget target)
        {
            try
            {
                var pdu = Pdu.GetPdu(new VbCollection { CreateVb(conv4000ConvBInstalled.Default.oid) });
                var param = new AgentParameters(SnmpVersion.Ver2, new OctetString(pdu.Type == PduType.Get ? ReadCommunity : WriteCommunity));
                var response = target.Request(pdu, param);
                if (!(response is SnmpV2Packet)) return false;
                if (response.Pdu.ErrorStatus != 0) return false;
                return (Integer32)response.Pdu.VbList[0].Value == 1 ? true : false;
            }
            catch (Exception ex)
            {
                _logger.WriteMessage(ex.Message, DebugLevel.ERROR);
                return false;
            }
        }

        #endregion SNMP Gets

        #region SNMP Sets

        public void AddConfigureAllCommand(PortAConfiguration portA, PortBConfiguration portB)
        {
            if (PortAInstalled)
            {
                _logger.WriteMessage("Port A installed!", DebugLevel.DEBUG);
                var PortAConfigurationCommand = CreatePortAConfigurationCommand(portA);
                AddCommand(PortAConfigurationCommand);
                _logger.WriteMessage("Added port A configuration command.", DebugLevel.DEBUG);
            }
            else _logger.WriteMessage("Port A not installed", DebugLevel.DEBUG);

            if (PortBInstalled)
            {
                _logger.WriteMessage("Port B installed!", DebugLevel.DEBUG);
                var PortBConfigurationCommand = CreatePortBConfigurationCommand(portB);
                AddCommand(PortBConfigurationCommand);
                _logger.WriteMessage("Added port B confiugration command.", DebugLevel.DEBUG);
            }
            else _logger.WriteMessage("Port B not installed", DebugLevel.DEBUG);
        }

        public Pdu CreatePortAConfigurationCommand(PortAConfiguration portAConfiguration)
        {
            var oidList = new List<SnmpOid>();
            if (portAConfiguration != null)
            {
                _logger.WriteAsIs("Confiugration to download - \r\n" + portAConfiguration.ToString());
                oidList.AddRange(new[] { conv4000ConvAFrequency.Default.oid,
                                         conv4000ConvAMute.Default.oid,
                                         conv4000ConvAConfigMuteMode.Default.oid,
                                         conv4000ConvAAttenuator.Default.oid,
                                         conv4000ConvASlope.Default.oid,
                                         conv4000convASpectrumInversion.Default.oid});
                var vbCollection = new VbCollection(new[] {
                                                         CreateVb(oidList[0], portAConfiguration.Frequency),
                                                         CreateVb(oidList[1], portAConfiguration.Mute),
                                                         CreateVb(oidList[2], portAConfiguration.ConfigMute),
                                                         CreateVb(oidList[3], portAConfiguration.Attenuation),
                                                         CreateVb(oidList[4], portAConfiguration.Slope),
                                                         CreateVb(oidList[5], portAConfiguration.Inverse)
                });
                return Pdu.SetPdu(vbCollection);
            }
            return null;
        }

        public Pdu[] CreatePortAConfigurationCommands(PortAConfiguration portAConfiguration)
        {
            if (!PortAInstalled) return null;
            var oidList = new List<SnmpOid>();
            var pdus = new Pdu[7];
            if (portAConfiguration != null)
            {
                _logger.WriteAsIs("Confiugration to download - \r\n" + portAConfiguration.ToString());
                oidList.AddRange(new[] { conv4000ConvAFrequency.Default.oid,
                                         conv4000ConvAMute.Default.oid,
                                         conv4000ConvAConfigMuteMode.Default.oid,   
                                         conv4000ConvAAttenuator.Default.oid,
                                         conv4000ConvASlope.Default.oid,
                                         conv4000convASpectrumInversion.Default.oid});
                var vbCollection = new VbCollection();
                vbCollection.Add(CreateVb(oidList[0], portAConfiguration.Frequency));
                vbCollection.Add(CreateVb(oidList[1], portAConfiguration.Mute));
                vbCollection.Add(CreateVb(oidList[2], portAConfiguration.ConfigMute));
                vbCollection.Add(CreateVb(oidList[3], portAConfiguration.Attenuation));
                vbCollection.Add(CreateVb(oidList[4], portAConfiguration.Slope));
                vbCollection.Add(CreateVb(oidList[5], portAConfiguration.Inverse));
                var counter = 0;
                foreach (var vb in vbCollection)
                {
                    pdus[counter] = Pdu.SetPdu(new VbCollection(new[] { vb }));
                    counter += 1;
                }
                return pdus;
            }
            return null;
        }

        public Pdu CreatePortBConfigurationCommand(PortBConfiguration portBConfiguration)
        {
            if (!PortBInstalled) return null;
            var oidList = new List<SnmpOid>();
            if (portBConfiguration != null)
            {
                _logger.WriteAsIs("Confiugration to download - \r\n" + portBConfiguration.ToString());
                oidList.AddRange(new[] { conv4000ConvBFrequency.Default.oid,
                                         conv4000ConvBMute.Default.oid,
                                         conv4000ConvBConfigMuteMode.Default.oid,
                                         conv4000ConvBAttenuator.Default.oid,
                                         conv4000ConvBSlope.Default.oid,
                                         conv4000convBSpectrumInversion.Default.oid});
                var vbCollection = new VbCollection(new[] {
                                                         CreateVb(oidList[0], portBConfiguration.Frequency),
                                                         CreateVb(oidList[1], portBConfiguration.Mute),
                                                         CreateVb(oidList[2], portBConfiguration.ConfigMute),
                                                         CreateVb(oidList[3], portBConfiguration.Attenuation),
                                                         CreateVb(oidList[4], portBConfiguration.Slope),
                                                         CreateVb(oidList[5], portBConfiguration.Inverse)
                });
                return Pdu.SetPdu(vbCollection);
            }
            return null;
        }

        public Pdu[] CreatePortBConfigurationCommands(PortBConfiguration portBConfiguration)
        {
            var oidList = new List<SnmpOid>();
            var pdus = new Pdu[6];
            if (portBConfiguration != null)
            {
                _logger.WriteAsIs("Confiugration to download - \r\n" + portBConfiguration.ToString());
                oidList.AddRange(new[] { conv4000ConvBFrequency.Default.oid,
                                         conv4000ConvBMute.Default.oid,
                                         conv4000ConvBConfigMuteMode.Default.oid,
                                         conv4000ConvBAttenuator.Default.oid,
                                         conv4000ConvBSlope.Default.oid,
                                         conv4000convBSpectrumInversion.Default.oid});
                var vbCollection = new VbCollection();
                vbCollection.Add(CreateVb(oidList[0], portBConfiguration.Frequency));
                vbCollection.Add(CreateVb(oidList[1], portBConfiguration.Mute));
                vbCollection.Add(CreateVb(oidList[2], portBConfiguration.ConfigMute));
                vbCollection.Add(CreateVb(oidList[3], portBConfiguration.Attenuation));
                vbCollection.Add(CreateVb(oidList[4], portBConfiguration.Slope));
                vbCollection.Add(CreateVb(oidList[5], portBConfiguration.Inverse));
                var counter = 0;
                foreach (var vb in vbCollection)
                {
                    pdus[counter] = Pdu.SetPdu(new VbCollection(new[] { vb }));
                    counter += 1;
                }
                return pdus;
            }
            return null;
        }

        public void AddCommand(Pdu command)
        {
            _commands.Enqueue(new[] { command });
        }

        #endregion SNMP Sets
    }
}
