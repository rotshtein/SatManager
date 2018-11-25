using CygnusProto;
using log4net;
using System;
using Google.Protobuf;
using System.Reflection;
using System.Threading;

namespace WebSocketS 
{
    class CygnusDevice : Device
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        

        public CygnusDevice(Uri WebSocketUrl, IguiInterface Gui) : base(WebSocketUrl, Gui)
        {
            log.Debug("Cygnus initlized");
        }

        public void Start(Uri Orion_url, Uri input1_url, Uri input2_url, int Port1, int Port2)
        {
            startThread = new Thread(
                unused =>
                    StartThread(Orion_url, input1_url, input2_url, Port1, Port2));

            startThread.IsBackground = true;
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
                    Thread.Sleep(200);
                }
                catch (Exception ex)
                {
                    log.Error("Error during monitoring", ex);
                }
            }
        }

        public bool StartThread(Uri Orion_url, Uri input1_url, Uri input2_url, int Port1 , int Port2)
        {
            log.Debug("Cygnus started");
            if (Connect() == false)
            {
                log.Warn("Cannot connect to the Cygnus server");
                return false;
            }

            try
            {
                lastCommand = "Start Command";
                StartCommand sc = new StartCommand
                {
                    BoxUrl = Orion_url.ToString(),
                    E1Port1 = Port1,
                    E1Port2 = Port2,
                    Input1Url = input1_url.ToString(),
                    Input2Url = input2_url.ToString()
                };
                Header h = new Header { Sequence = 0, Opcode = OPCODE.StartCmd, MessageData = MessageExtensions.ToByteString(sc) };
                Send(h);
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

        public override bool Stop()
        {
            try
            {
                StopMonitor();
                Header h = new Header { Sequence = 0, Opcode = OPCODE.StopCmd };
                Send(h);
                lastCommand = "Stop Command";
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
                            gui.ShowMessage("Cygnus: " + lastCommand + " pass");
                            log.Debug("Cygnus: " + lastCommand + " pass");
                            break;

                        case OPCODE.Nack:
                            gotNack = false;
                            gui.ShowMessage("Cygnus: " + lastCommand + " failed");
                            log.Warn("got Nack from the server");
                            break;

                        case OPCODE.StatusMessage:
                            StatusMessage sm = StatusMessage.Parser.ParseFrom(h.MessageData);
                            if (sm != null)
                            {
                                gui.ShowMessage("Cygnus:" + sm.Message);
                                log.Debug("Cygnus:" + sm.Message);
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
