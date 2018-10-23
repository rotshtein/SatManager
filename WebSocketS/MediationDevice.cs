using log4net;
using MedcicProto;
using System;
using System.Reflection;
using Google.Protobuf;
using System.Threading;

namespace WebSocketS
{
    class MediationDevice : Device
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);


        public MediationDevice(Uri WebSocketUrl, IguiInterface Gui) : base (WebSocketUrl, Gui)
        {
            log.Debug("Mediation intilized");
        }

        public void Start(Uri input1_url, Uri input2_url, Uri output1_url, Uri output2_url)
        {
            startThread = new Thread(
               unused =>
                   StartThread(input1_url, input2_url, output1_url, output2_url));
            StartMonitor();
        }

        public override void MonitorThread()
        {
            log.Debug("Monitor theard started");
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

        public void StartThread(Uri input1_url, Uri input2_url, Uri output1_url, Uri output2_url)
        {
            try
            {
                log.Debug("Starting Mediation");
                lastCommand = "Start Command";
                AutomaticStartCommand asc = new AutomaticStartCommand
                {
                    Input1Url = input1_url.ToString(),
                    Input2Url = input2_url.ToString(),
                    Output1Url = output1_url.ToString(),
                    Output2Url = output2_url.ToString()
                };

                Header h = new Header { Sequence = 0, Opcode = OPCODE.AutoStartCmd, MessageData = MessageExtensions.ToByteString(asc) };
                Send(h);
                log.Debug("Mediation started");
                isRunning = true;
            }
            catch (Exception e)
            {
                log.Error("Mediation error during auto start", e);
                isRunning = false;
            }
        }

        public override bool Stop()
        {
            try
            {
                log.Debug("Stopping Mediation");
                Header h = new Header { Sequence = 0, Opcode = OPCODE.StopCmd };
                Send(h);
                lastCommand = "Stop Command";
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
                            gui.ShowMessage("Mediation: " + lastCommand + " pass");
                            log.Debug("Mediation: " + lastCommand + " pass");
                            break;

                        case OPCODE.Nack:
                            gotNack = false;
                            gui.ShowMessage("Mediation: " + lastCommand + " failed");
                            log.Warn("got Nack from the server");
                            break;

                        case OPCODE.StatusMessage:
                            StatusMessage sm = StatusMessage.Parser.ParseFrom(h.MessageData);
                            if (sm != null)
                            {
                                gui.ShowMessage("Mediation:" + sm.Message);
                                log.Debug("Mediation:" + sm.Message);
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

        void Send(Header h)
        {
            gui.ShowMessage("Command " + Enum.GetName(typeof(OPCODE), h.Opcode) + " sent");
            log.Debug("Command " + Enum.GetName(typeof(OPCODE), h.Opcode) + " sent");
            gotAck = false;
            gotNack = false;
            client.Send(MessageExtensions.ToByteArray(h));
        }
    }
}
