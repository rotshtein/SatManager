using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using WebSocketSharp;

namespace WebSocketS
{
    class Client
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
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
            try
            {
                ws = new WebSocketSharp.WebSocket(addr);
                ws.Log.Level = LogLevel.Debug;
                ws.Log.Output = LoggerAction;
                ws.Log.File = null;
                //new WebSocketSharp.Logger(LogLevel.Debug, null, null);// LoggerAction);
                ws.OnMessage += onMessage;
                ws.Connect();
            }
            catch (Exception ex)
            {
                log.Error("Failed to connect to WebSocket server", ex);
                throw new Exception("Failed to connect to WebSocket server");
            }
        }

        public static void CloseAll()
        {
            foreach (Client c in clients)
            {
                c.Close();
            }
        }

        public void Close()
        {

            if (ws != null)
            {
                try
                {
                    log.Debug(this.uri.ToString() +": Closing connection");
                    ws.Close();
                }
                catch (Exception ex)
                {
                    log.Error("Failed to close connection with client", ex);
                }
            }
            ws = null;
        }

        void LoggerAction(LogData data, string msg)
        {
            log.Debug(this.uri.ToString() + ": " + data.Message);
        }
        
        public void Send(String msg)
        {
            if (ws.ReadyState == WebSocketState.Open)
            {
                ws.Send(msg);
                log.Debug(this.uri.ToString()+ " Message sent");
            }
        }

        public void Send(byte[] data)
        {
            if (ws.ReadyState == WebSocketState.Open)
            {
                ws.Send(data);
                log.Debug(this.uri.ToString() + " Message sent");
            }
        }

        private void onMessage(object sender, WebSocketSharp.MessageEventArgs e)
        {
            String s = e.ToString();
            switch(e.Type)
            {
                case Opcode.Text:
                    log.Debug(this.uri.ToString() + " Text message received");
                    ReceviedString?.Invoke(this, e.Data);
                    break;

                case Opcode.Binary:
                    log.Debug(this.uri.ToString() + " Binary message received");
                    ReceviedData?.Invoke(this, e.RawData);
                    break;

                default:
                    log.Error(this.uri.ToString() + " Unknown message received");
                    break;
            }
        }
    }
}
