using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebSocketS
{


    abstract class Device
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        protected Client client = null;
        protected IguiInterface gui = null;
        protected bool runMonitor = false;
        Thread monitorThread = null;

        public Device(Uri WebSocketServer, IguiInterface Gui)
        {
            client = new Client(WebSocketServer);
            client.ReceviedData += OnReceive;
            gui = Gui;
            log.Debug(MethodBase.GetCurrentMethod().DeclaringType.Name + "Created as device");
        }

        public void StartMonitor()
        {
            runMonitor = true;
            monitorThread = new Thread(unused => MonitorThread());
            monitorThread.Start();
        }

        public void StopMonitor()
        {
            runMonitor = false;
            monitorThread = null;
        }

        abstract public void MonitorThread();

        abstract public Task<bool> Stop();

        abstract public bool IsRunnign();

        abstract public void OnReceive(Client sender, byte[] data);
    }
}
