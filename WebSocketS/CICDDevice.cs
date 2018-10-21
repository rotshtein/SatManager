//#define CICD_SIMULATOR 
using CICD;
using Google.Protobuf;
using log4net;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace WebSocketS
{
    class CICDDevice : Device
    {
        #region Members
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        bool configureFE_Status = false;
        Thread startThread = null;
        Thread monitorThread = null;
        bool runMonitor = false;

        #region protobuf stractures
        FEConfStatusChanged feStatus = null;
        bool feStatusEeceived = false;
        SWFE_state_changed swState = null;
        bool swStateReceived = false;
        HWFE_state_changed hwState = null;
        bool hwStateReceived = false;
        MonitoringReport monitorReport = null;
        bool monitorReportReceived = false;
        CicStatus cisStatus = null;
        bool cisStatusReceived = false;
        #endregion

        bool gotAck = false;
        bool gotNack = false;
        string lastCommand = "";
        bool isRunning = false;
        int Sequence = 0;
        bool isConfigured = false;
        

#if CICD_SIMULATOR
        Process process = null;
#endif
        bool isRunnign = false;
        bool isSeperating = false;
        #endregion Members

        #region ctor
        public CICDDevice(Uri WebSocketUrl, IguiInterface Gui) : base(WebSocketUrl, Gui)
        {
            log.Debug("Cicd device initialized. [" + WebSocketUrl.ToString() + "]");
        }
        #endregion

        public void Start(string Inputfilename, float FeinHz, float Fchz, float Usefulbwhz, float Gaindb, float cncarrierdb, string sampleFile, Uri output1_url, Uri output2_url)
        {
            startThread = new Thread(
                unused => 
                    StartThread(Inputfilename,
                              FeinHz, Fchz, Usefulbwhz, Gaindb, cncarrierdb,
                              sampleFile, output1_url, output2_url));
            startThread.Start();
            StartMonitor();
        }

 
        public override void MonitorThread()
        {
            log.Debug("Monitor theard started");
            while (runMonitor)
            {
                try
                {
                    if (monitorReportReceived)
                    {
                        monitorReportReceived = false;
                    }
                    else
                    {
                        getReport();
                        Thread.Sleep(200);
                    }
                }
                catch (Exception ex)
                {
                    log.Error("Error during monitoring", ex);
                }
            }
        }

        public void StartThread(string Inputfilename, float FeinHz, float Fchz, float Usefulbwhz, float Gaindb, float cncarrierdb, string sampleFile, Uri output1_url, Uri output2_url)
        {
            log.Debug("Cicd device start");
#if CICD_SIMULATOR
            /* 
             * Start legobits from a predefine location using a predefined file with fix address.
             * The file send 2 streams of ESC++ (553) streams to 127.0.0.1:5001 and udp://127.0.0.1:5002
             * 
            */
            try
            {
                if (process != null)
                {
                    process.Kill();
                    process = null;
                }

                process.StartInfo.FileName = Properties.Settings.Default.LegpBits;
                process.StartInfo.Arguments = Properties.Settings.Default.LegoFile;

                process.Start();
            }
            catch(Exception ex)
            {
                gui.ShowMessage("Failed to start CICD Simulator");
                log.Error("Failed to start CICD Simulator", ex);
                return false;
            }
            gui.ShowMessage("CICD Simulator is running");
            return true;
#else
            try
            {
                if (!string.IsNullOrEmpty(Inputfilename))
                {
                    configureSWFE(FeinHz, Fchz, Usefulbwhz, Gaindb, Inputfilename);

                    bool AckReceived = WaitForReceive(ref gotAck, 5000);
                    if (!AckReceived)
                    {
                        throw new Exception("Failed to receive configureSWFE");
                    }

                    bool StatusReportReceived = WaitForReceive(ref feStatusEeceived, 5000);
                    if (!StatusReportReceived)
                    {
                        throw new Exception("Failed to configureSWFE");
                    }
                }
                else
                {
                    configureHWFE(FeinHz, Fchz, Usefulbwhz, Gaindb);

                    bool AckReceived = WaitForReceive(ref gotAck, 5000);
                    if (!AckReceived)
                    {
                        throw new Exception("Failed to receive configureSWFE");
                    }

                    bool ConfigureReceived = WaitForReceive(ref hwStateReceived, 5000);
                    if (!ConfigureReceived)
                    {
                        throw new Exception("Failed to configureHWFE");
                    }
                }
                identifyAndSeparate(output1_url, output2_url, cncarrierdb);
                bool IdentifyReceived = WaitForReceive(ref gotAck, 5000);
                if (!IdentifyReceived)
                {
                    throw new Exception("Failed to identifyAndSeparate - Didn't get Ack");
                }
                /* Wait for 
                 * - either get an error message if no CICD is detected
                 * - or get the identification report message and then separation status update,
                 * and then the separator will start and report its status at each step. When started, 
                 * you can also request a status report at any time
                */
                bool MonitorReportReceived = WaitForReceive(ref monitorReportReceived, 1000);
                /*if (!MonitorReportReceived)
                {
                    throw new Exception("Failed start seperation using identifyAndSeparate command");
                }*/
            }
            catch (Exception e)
            {
                log.Error("CICD error during start", e);
                isConfigured =  false;
            }
            isConfigured =  true; ;
#endif
        }

        #region Public Proto Commands
        public bool configureSWFE(float FeinHz, float Fchz, float Usefulbwhz, float Gaindb, string InputFilename)
        {
            try
            {
                configure_SWFE csw = new configure_SWFE
                {
                    Filename = InputFilename,
                    Inputsignaltype = InputType.Complex,
                    Inputsignalsubtypefromfile = SubType.TypeFloat,
                    Feinhz = FeinHz * 1000,
                    Fchz = Fchz,
                    Usefulbwhz = Usefulbwhz * 1000000,
                    Gaindb = Gaindb,
                    Wideband = false,
                };

                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.ConfigureSwfe, MessageData = MessageExtensions.ToByteString(csw) };
                lastCommand = "configure_SWFE";
                Send(h);
                log.Debug("configureSWFE sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("configureHWFE failed", ex);
            }
            return false;
        }

        public bool configureHWFE(float FeinHz, float Fchz, float Usefulbwhz, float Gaindb)
        {
            try
            {
                configure_HWFE chw = new configure_HWFE
                {
                    Feinhz = FeinHz,
                    Fchz = Fchz,
                    Usefulbwhz = Usefulbwhz,
                    Gaindb = Gaindb,
                    Wideband = false,
                };

                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.ConfigureHwfe, MessageData = MessageExtensions.ToByteString(chw) };
                lastCommand = "configure_HWFE";
                Send(h);
                log.Debug("configureHWFE sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("configureHWFE failed", ex);
            }
            return false;
        }

        public bool startFE()
        {
            try
            {
                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.StartFe };
                Send(h);
                lastCommand = "startFE";
                log.Debug("startFE sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("startFE failed", ex);
            }
            return false;
        }

        private bool stopFE()
        {
            try
            {

                if (startThread != null && startThread.IsAlive)
                {
                    startThread.Abort();
                    startThread = null;
                }

                startThread = null;
                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.StopFe };
                Send(h);
                lastCommand = "stopFE";
                log.Debug("stopFE sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("stopFE failed", ex);
            }
            return false;
        }

        private bool stopCICD()
        {
            isConfigured = false;
            runMonitor = false;
            try
            {
                if (startThread != null && startThread.IsAlive)
                {
                    startThread.Abort();
                    startThread = null;
                }

                startThread = null;
                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.Stop };
                Send(h);
                lastCommand = "stop";
                log.Debug("Stop sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("Stop failed", ex);
            }
            return false;
        }

        public bool identify(float Carrierdb)
        {
            try
            {
                Identify id = new Identify
                {
                    Cncarrierdb = Carrierdb
                };

                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.Identify, MessageData = MessageExtensions.ToByteString(id) };
                Send(h);
                lastCommand = "identify";
                log.Debug("identify sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("identify failed", ex);
            }
            return false;
        }

        public bool identifyAndSeparate(Uri Output1url, Uri Output2url, float Carrierdb)
        {
            try
            {
                IdentifyAndSeparate id = new IdentifyAndSeparate
                {
                    Cncarrierdb = Carrierdb,
                    Output1Url = Output1url.Host.ToString() + ":" + Output1url.Port.ToString(),
                    Output2Url = Output2url.Host.ToString() + ":" + Output2url.Port.ToString(),
                    Output = outputType.ToUdp,

                };
                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.IdentifyAndSeparate, MessageData = MessageExtensions.ToByteString(id) };
                Send(h);
                lastCommand = "Identify And Separate";
                log.Debug("IdentifyAndSeparate sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("IdentifyAndSeparate failed", ex);
            }
            return false;
        }

        public bool getReport()
        {
            try
            {
                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.RequestMonitoringReport };
                Send(h);
                lastCommand = "getReporte";
                log.Debug("getReport sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("getReport failed", ex);
            }
            return false;
        }
        #endregion Proto Commands

        #region public Properties
        public bool IsSeperating()
        {
#if CICD_SIMULATOR
            if (process == null)
            {
                return false;
            }
            return !process.HasExited;
#else
            return isSeperating;
#endif
        }

        public bool IsConfigured { get { return isConfigured; } }
        #endregion

        #region Web socket communication


        bool WaitForReceive(ref bool flag, int miliSeconds)
        {
            DateTime start = DateTime.Now;
            //while ((DateTime.Now - start).TotalMilliseconds < miliSeconds)
            while ((miliSeconds-= 10) > 0)
            {
                if (flag)
                {
                    return true;
                }
                Thread.Sleep(10);
            }
            return false;
        }

        void Send(Header h)
        {
            gotAck = false;
            gotNack = false;
            gui.ShowMessage("Command " + Enum.GetName(typeof(OPCODE),h.Opcode) + " sent");
            log.Debug("Command " + Enum.GetName(typeof(OPCODE), h.Opcode) + " sent");
            switch (h.Opcode)
            {
                case OPCODE.RequestMonitoringReport:
                case OPCODE.IdentifyAndSeparate:
                    monitorReportReceived = false;
                    break;

                case OPCODE.ConfigureHwfe:
                    hwStateReceived = false;
                    feStatusEeceived = false;
                    break;

                case OPCODE.ConfigureSwfe:
                    swStateReceived = false;
                    feStatusEeceived = false;
                    break;

                case OPCODE.StartFe:
                    feStatusEeceived = false;
                    break;
            }
            client.Send(MessageExtensions.ToByteArray(h));
        }
        #endregion Web socket communication

        #region override methods
        public override void OnReceive(Client sender, byte[] data)
        {
            try
            {
                Header h = Header.Parser.ParseFrom(data);
                if (h != null)
                {
                    switch (h.Opcode)
                    {
                        case OPCODE.Ack:
                            gotAck = true;
                            gui.ShowMessage("CICD: " + lastCommand + " pass");
                            break;

                        case OPCODE.Nack:
                            gotNack = true;
                            gui.ShowMessage("CICD: " + lastCommand + " failed");
                            log.Warn("got Nack from the server");
                            break;


                        case OPCODE.FeConfstatusChanged:
                            feStatus = FEConfStatusChanged.Parser.ParseFrom(h.MessageData);
                            feStatusEeceived = true;
                            break;

                        case OPCODE.SwfeStateChanged:
                            swState = SWFE_state_changed.Parser.ParseFrom(h.MessageData);
                            configureFE_Status = swState.ReturnCode == SWFE_state.SwfeRunning;
                            //gui.ShowMessage("CICD: SwfeStateChanged status is " + this.isRunnign.ToString());
                            swStateReceived = true;
                            break;

                        case OPCODE.HwfeStateChanged:
                            HWFE_state_changed hwState = HWFE_state_changed.Parser.ParseFrom(h.MessageData);
                            configureFE_Status = hwState.ReturnCode != 0;
                            //gui.ShowMessage("CICD: HwfeStateChanged status is " + this.isRunnign.ToString());
                            hwStateReceived = true;
                            break;

                        case OPCODE.MonitoringReport:
                            monitorReport = MonitoringReport.Parser.ParseFrom(h.MessageData);
                            monitorReportReceived = true;
                            isRunnign = monitorReport.FEstatus;
                            isSeperating = monitorReport.SeparationState;

                            gui.UpdateCicdCounter(monitorReport.NbDecodedFrames1, monitorReport.NbDecodedFrames2,
                                                  monitorReport.NbErrorFrames1, monitorReport.NbErrorFrames2);
                            break;

                        case OPCODE.IdentificationReport:
                            cisStatus = CicStatus.Parser.ParseFrom(h.MessageData);
                            cisStatusReceived = true;
                            break;
                        default:
                            break;
                    }
                }
            }


            catch (Exception e)
            {
                log.Error("Failed in parse proto message", e);
            }
        }

        public override Task<bool> Stop()
        {
#if CICD_SIMULATOR
             /*
             * Stop the legobits if it is running
             * 
             */

                            if (process != null)
            {
                process.Kill();
                log.Debug("Killing the CICD simulator");
            }
            else
            {
                log.Debug("Try to illing the CICD simulator when process is null");
            }

#else
            try
            {
                if (stopCICD())
                {
                    gui.ShowMessage("CICD is stopping");
                }
                else
                {
                    gui.ShowMessage("CICD : Got error while tring to stop");
                    return Task.FromResult(false);
                }
                StopMonitor();
            }
            catch (Exception ex)
            {
                log.Error("Failed to stop CICD", ex);
                return Task.FromResult(false);
            }
#endif
            return Task.FromResult(true);
        }

        public override bool IsRunnign()
        {
        #if CICD_SIMULATOR
            if (process == null)
            {
                return false;
            }
            return !process.HasExited;
        #else
            return isRunning;
        #endif
        }
        #endregion
    }
}
