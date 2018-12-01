using log4net;
using System;
using System.Reflection;
using System.Threading;

namespace WebSocketS
{


    abstract class Device
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        protected Client client = null;
        protected IguiInterface gui = null;
        protected bool runMonitor = false;
        protected Thread monitorThread = null;
        protected Thread startThread = null;

        protected bool gotAck = false;
        protected bool gotNack = false;
        protected string lastCommand = "";
        protected bool isRunning = false;
        Uri webSocketServer = null;

        public Device(Uri WebSocketServer, IguiInterface Gui)
        {
            webSocketServer = WebSocketServer;
            gui = Gui;
            log.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + "Created as device");
        }

        public bool Connect()
        {
            client = new Client(webSocketServer);
            if (client.IsConnected)
            {
                client.ReceviedData += OnReceive;
                gui.ShowMessage(this.GetType().Name + " connected");
                log.Debug(this.GetType().Name + " connected");
            }
            else
            {
                gui.ShowMessage(this.GetType().Name + " can NOT connect");
                log.Warn(this.GetType().Name + " can NOT connect");
            }
            return client.IsConnected;
        }

        public bool Close()
        {
            if (client != null)
            {
                if (client.IsConnected)
                {
                    client.ReceviedData -= OnReceive;
                    gui.ShowMessage(this.GetType().Name + " disconnect");
                    log.Debug(this.GetType().Name + " disconnect");
                }
                else
                {
                    log.Warn(this.GetType().Name + " alreay disconnected");
                }
                client.Close();
                return !client.IsConnected;
            }
            return true;
        }

        public void StartMonitor()
        {
            runMonitor = true;
            monitorThread = new Thread(unused => MonitorThread());
            monitorThread.IsBackground = true;
            monitorThread.Start();
        }

        public void StopMonitor()
        {
            runMonitor = false;
            monitorThread = null;
        }

        abstract public void MonitorThread();

        abstract public bool Stop();

        abstract public bool IsRunnign();

        abstract public void OnReceive(Client sender, byte[] data);
    }
}
