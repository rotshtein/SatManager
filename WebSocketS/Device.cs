using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketS
{


    abstract class Device
    {
        protected Client client = null;
        protected IguiInterface gui = null;


        public Device(Uri WebSocketServer, IguiInterface Gui)
        {
            client = new Client(WebSocketServer);
            client.ReceviedData += OnReceive;
            gui = Gui;
        }

        abstract public Task<bool> Stop();

        abstract public bool IsRunnign();

        abstract public void OnReceive(Client sender, byte[] data);
    }
}
