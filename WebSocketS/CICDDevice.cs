//#define CICD_SIMULATOR 
using CICD;
using Google.Protobuf;
using log4net;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;

namespace WebSocketS
{
    class CICDDevice : Device
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        bool gotAck = false;
        bool gotNack = false;
        string lasrCommand = "";
        bool isRunning = false;
        int Sequence = 0;
#if CICD_SIMULATOR
        Process process = null;
#endif


        #region Monitoring info
        bool isRunnign = false;


        bool separationState;       // true: separation in process
        double nbSymbSeparated;       // total number of separated symbols
        double nbDataInBuffer;       // number of data in input buffer
        double nbDataOutBuffer1;       // number of data in ouput buffer 1
        double nbDataOutBuffer2;       // number of data in ouput buffer 2
        double nbDataOutBuffer3;       // number of data in ouput buffer 3
        double nbDataOutBuffer4;       // number of data in ouput buffer 4

        bool synchroState1;       // true: FEC decoder of channel 1 locked
        bool synchroState2;       // true: FEC decoder of channel 2 locked
        double nbDecodedFrames1;       // number of decoded FEC frames of channel 1
        double nbDecodedFrames2;       // number of decoded FEC frames of channel 2
        double nbErrorFrames1;       // number of erroneous FEC frames of channel 1
        double nbErrorFrames2;       // number of erroneous FEC frames of channel 2 
#endregion

        public CICDDevice(Uri WebSocketUrl, IguiInterface Gui) : base(WebSocketUrl, Gui)
        {

        }

        public bool Start(float FeinHz, float Fchz, float Usefulbwhz, float Gaindb, float cncarrierdb, string sampleFile, Uri output1_url, Uri output2_url)
        {
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
                configureHWFE(FeinHz, Fchz, Usefulbwhz, Gaindb);

                // Wait for ???????

                startFE();  // Do i need this?

                // Wait for ???????

                identifyAndSeparate(output1_url, output2_url, cncarrierdb);

            }
            catch (Exception e)
            {
                log.Error("CICD error during start [from file]", e);
                return false;
            }
            return true; ;
#endif
        }

#region Proto Commands
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
                lasrCommand = "configure_HWFE";
                Send(MessageExtensions.ToByteArray(h));
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
                Send(MessageExtensions.ToByteArray(h));
                lasrCommand = "startFE";
                log.Debug("startFE sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("startFE failed", ex);
            }
            return false;
        }

        public bool stopFE()
        {
            try
            {
                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.StopFe };
                Send(MessageExtensions.ToByteArray(h));
                lasrCommand = "stopFE";
                log.Debug("stopFE sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("stopFE failed", ex);
            }
            return false;
        }

        public bool stopCICD()
        {
            try
            {
                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.Stop };
                Send(MessageExtensions.ToByteArray(h));
                lasrCommand = "stop";
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
                Send(MessageExtensions.ToByteArray(h));
                lasrCommand = "identify";
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
                    Output1Url = Output1url.ToString(),
                    Output2Url = Output2url.ToString()
                };

                Header h = new Header { Sequence = Sequence++, Opcode = OPCODE.Identify, MessageData = MessageExtensions.ToByteString(id) };
                Send(MessageExtensions.ToByteArray(h));
                lasrCommand = "Identify And Separate";
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
                Send(MessageExtensions.ToByteArray(h));
                lasrCommand = "getReporte";
                log.Debug("getReport sent");
                return true;
            }
            catch (Exception ex)
            {
                log.Error("getReport failed", ex);
            }
            return false;
        }

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
                            gui.ShowMessage("CICD: " + lasrCommand + " pass");
                            break;

                        case OPCODE.Nack:
                            gotNack = false;
                            gui.ShowMessage("CICD: " + lasrCommand + " failed");
                            log.Warn("got Nack from the server");
                            break;

                        case OPCODE.HwfeStateChanged:
                            HWFE_state_changed state = HWFE_state_changed.Parser.ParseFrom(h.MessageData);
                            isRunnign = state.ReturnCode == HWFE_state.HwfeRunning;
                            gui.ShowMessage("CICD: HwfeStateChanged status is " + this.isRunnign.ToString());
                            break;

                        case OPCODE.MonitoringReport:
                            MonitoringReport mr = MonitoringReport.Parser.ParseFrom(h.MessageData);
                            this.separationState = mr.SeparationState;
                            this.nbSymbSeparated = mr.NbSymbSeparated;
                            this.nbDataInBuffer = mr.NbDataInBuffer;
                            this.nbDataOutBuffer1 = mr.NbDataOutBuffer1;
                            this.nbDataOutBuffer2 = mr.NbDataOutBuffer2;
                            this.nbDataOutBuffer3 = mr.NbDataOutBuffer3;
                            this.nbDataOutBuffer4 = mr.NbDataOutBuffer4;

                            this.synchroState1 = mr.SynchroState1;
                            this.synchroState2 = mr.SynchroState2;
                            this.nbDecodedFrames1 = mr.NbDecodedFrames1;
                            this.nbDecodedFrames2 = mr.NbDecodedFrames2;
                            this.nbErrorFrames1 = mr.NbErrorFrames1;
                            this.nbErrorFrames2 = mr.NbErrorFrames2;

                            gui.ShowMessage("CICD: HwfeStateChanged separationState is " + this.separationState.ToString());
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

#endregion

        public override async Task<bool> Stop()
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
            if (stopCICD())
            {
                gui.ShowMessage("CICD is stopping");
            }
            else
            {
                gui.ShowMessage("CICD : Got error while tring to stop");
                return false;
            }
#endif
            return true;
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

        void Send(byte[] buffer)
        {
            gotAck = false;
            gotNack = false;
            client.Send(buffer);
        }

        bool GotAck { get { return gotAck; } }
        bool GotNack { get { return gotNack; } }
    }
}
