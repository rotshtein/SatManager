using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lbc4000SnmpDriver;
using Lbc4000Logger;
using System.Net;

namespace WebSocketS
{
    class DownConverterDevice : Device
    {
        private Lbc4000 _device;

        public DownConverterDevice(IPAddress ipAddress, Uri webSocketServer, IguiInterface gui)
            : base(webSocketServer, gui)
        {
            _device = Lbc4000.GetDevice(ipAddress);
        }

        public override bool IsRunnign()
        {
            return _device.TestConnection();
        }

        public override void OnReceive(Client sender, byte[] data)
        {
            throw new NotImplementedException();
        }


        public override async Task<bool> Stop()
        {
            if (_device != null)
            {
                return await Task.Run(() => _device.Dispose());
            }
            return true;
        }
    }
}
