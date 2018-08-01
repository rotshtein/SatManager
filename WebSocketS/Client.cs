using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace WebSocketS
{
    class Client
    {
        static List<Client> clients = new List<Client>();
        public delegate void ReceviedByteDataHandler(Client sender, byte[] data);
        public delegate void ReceviedStringDataHandler(Client sender, string msg);

        public event ReceviedByteDataHandler ReceviedData;
        public event ReceviedStringDataHandler ReceviedString;
        WebSocketSharp.WebSocket ws = null;
        Uri uri = null;

        public Client(Uri addr) : this(addr.ToString()) {}

        public Client(String addr)
        { 
            ws = new WebSocketSharp.WebSocket(addr);
            ws.Log.Level = LogLevel.Debug;
            ws.Log.Output = LoggerAction;
            ws.Log.File = null;
            //new WebSocketSharp.Logger(LogLevel.Debug, null, null);// LoggerAction);
            ws.OnMessage += onMessage;
            ws.Connect();
        }

        public static void CloseAll()
        {
            foreach(Client c in clients)
            {
                c.Close();
            }
        }

        public void Close()
        {
            if (ws != null)
            {
                ws.Close();
            }
            ws = null;
        }

        void LoggerAction(LogData data, string msg)
        {
            string Message = data.Message;

        }
        
        public void Send(String msg)
        {
            if (ws.ReadyState == WebSocketState.Open)
            {
                ws.Send(msg);
            }
        }

        public void Send(byte[] data)
        {
            if (ws.ReadyState == WebSocketState.Open)
            {
                ws.Send(data);
            }
        }

        private void onMessage(object sender, WebSocketSharp.MessageEventArgs e)
        {
            String s = e.ToString();
            switch(e.Type)
            {
                case Opcode.Text:
                    ReceviedString?.Invoke(this, e.Data);
                    break;

                case Opcode.Binary:
                    ReceviedData?.Invoke(this, e.RawData);
                    break;
            }
        }
    }
}
