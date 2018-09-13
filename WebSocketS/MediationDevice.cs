using log4net;
using MedcicProto;
using System;
using System.Reflection;
using System.Threading.Tasks;
using Google.Protobuf;

namespace WebSocketS
{
    class MediationDevice : Device
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        bool gotAck = false;
        bool gotNack = false;
        string lasrCommand = "";
        bool isRunning = false;

        public MediationDevice(Uri WebSocketUrl, IguiInterface Gui) : base (WebSocketUrl, Gui)
        {

        }

        public async Task<bool> Start(Uri input1_url, Uri input2_url, Uri output1_url, Uri output2_url)
        {
            try
            {
                lasrCommand = "Start Command";
                AutomaticStartCommand asc = new AutomaticStartCommand
                {
                    Input1Url = input1_url.ToString(),
                    Input2Url = input2_url.ToString(),
                    Output1Url = output1_url.ToString(),
                    Output2Url = output2_url.ToString()
                };

                Header h = new Header { Sequence = 0, Opcode = OPCODE.AutoStartCmd, MessageData = MessageExtensions.ToByteString(asc) };
                Send(MessageExtensions.ToByteArray(h));
                log.Debug("Mediation started");
                isRunning = true;
            }
            catch (Exception e)
            {
                log.Error("Mediation error during auto start", e);
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
                log.Debug("Mediation stoped");
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
                            gui.ShowMessage("Mediation: " + lasrCommand + " pass");
                            break;

                        case OPCODE.Nack:
                            gotNack = false;
                            gui.ShowMessage("Mediation: " + lasrCommand + " failed");
                            log.Warn("got Nack from the server");
                            break;

                        case OPCODE.StatusMessage:
                            StatusMessage sm = StatusMessage.Parser.ParseFrom(h.MessageData);
                            if (sm != null)
                            {
                                gui.ShowMessage("Mediation:" + sm.Message);
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
