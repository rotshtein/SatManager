#define CICD_SIMULATOR 
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
        Process process = null;

        public CICDDevice(Uri WebSocketUrl, IguiInterface Gui) : base(WebSocketUrl, Gui)
        {

        }

        public bool Start(float cncarrierdb, string sampleFile, Uri output1_url, Uri output2_url)
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
                lasrCommand = "Start from File Command";
                IdentifyAndSeparate sff = new IdentifyAndSeparate
                {
                    Cncarrierdb = cncarrierdb,
                    FileName = sampleFile,
                    Output = outputType.ToUdp,
                    Output1Url = output1_url.ToString(),
                    Output2Url = output2_url.ToString()
                };
                Header h = new Header { Sequence = 0, Opcode = OPCODE.IdentifyAndSeparate, MessageData = MessageExtensions.ToByteString(sff) };
                Send(MessageExtensions.ToByteArray(h));
                log.Debug("CICD started [from file]");
                isRunning = true;
            }
            catch (Exception e)
            {
                log.Error("CICD error during start [from file]", e);
                isRunning = false;
            }
            return isRunning;
#endif
        }

        public override async Task<bool> Stop()
        {
            /*
             * Stop the legobits if it is running
             * 
             */
            gui.ShowMessage("CICD Simulator is stopping");
#if CICD_SIMULATOR
            if (process != null)
            {
                process.Kill();
                log.Debug("Killing the CICD simulator");
            }
            else
            {
                log.Debug("Try to illing the CICD simulator when process is null");
            }
            return true;
#else
            try
            {
                Header h = new Header { Sequence = 0, Opcode = OPCODE.Stop };
                Send(MessageExtensions.ToByteArray(h));
                lasrCommand = "Stop Command";
                log.Debug("CICD stoped");
                isRunning = false;
                return true;
            }
            catch (Exception e)
            {
                log.Error("Failed to stop", e);
            }
            return false;
#endif
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
            //return isRunning;
#endif
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

                       
                    }
                }
            }


            catch (Exception e)
            {
                log.Error("Failed in parse proto message", e);
            }
        }

        void Send(byte[] buffer)
        {
            gotAck = false;
            gotNack = false;
            client.Send(buffer);
        }
    }
}
