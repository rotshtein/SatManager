using CygnusProto;
using log4net;
using System;
using System.Threading.Tasks;
using Google.Protobuf;
using System.Reflection;

namespace WebSocketS 
{
    class CygnusDevice : Device
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        bool gotAck = false;
        bool gotNack = false;
        string lasrCommand = "";
        bool isRunning = false;

        public CygnusDevice(Uri WebSocketUrl, IguiInterface Gui) : base(WebSocketUrl, Gui)
        {

        }

        public bool Start(Uri Orion_url, Uri input1_url, Uri input2_url, int Port1 , int Port2)
        {
            try
            {
                lasrCommand = "Start Command";
                StartCommand sc = new StartCommand
                {
                    BoxUrl = Orion_url.ToString(),
                    E1Port1 = Port1,
                    E1Port2 = Port2,
                    Input1Url = input1_url.ToString(),
                    Input2Url = input2_url.ToString()
                };
                Header h = new Header { Sequence = 0, Opcode = OPCODE.StartCmd, MessageData = MessageExtensions.ToByteString(sc) };
                Send(MessageExtensions.ToByteArray(h));
                log.Debug("Cygnus started");
                isRunning = true;
            }
            catch (Exception e)
            {
                log.Error("Cygnus error during auto start", e);
                isRunning = false;
            }
            return isRunning;
        }

        public override async Task<bool> Stop()
        {
            try
            {
                Header h = new Header { Sequence = 0, Opcode = OPCODE.StopCmd };
                Send(MessageExtensions.ToByteArray(h));
                lasrCommand = "Stop Command";
                log.Debug("Cygnus stoped");
                isRunning = false;
                return true;
            }
            catch (Exception e)
            {
                log.Error("Failed to stop", e);
            }
            return false;
        }

        public override bool IsRunnign()
        {
            return isRunning;
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
                            gui.ShowMessage("Cygnus: " + lasrCommand + " pass");
                            break;

                        case OPCODE.Nack:
                            gotNack = false;
                            gui.ShowMessage("Cygnus: " + lasrCommand + " failed");
                            log.Warn("got Nack from the server");
                            break;

                        case OPCODE.StatusMessage:
                            StatusMessage sm = StatusMessage.Parser.ParseFrom(h.MessageData);
                            if (sm != null)
                            {
                                gui.ShowMessage("Cygnus:" + sm.Message);
                            }
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
