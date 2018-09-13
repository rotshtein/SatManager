using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicManagerLib
{
    class NetworkDevice
    {
        public long DeviceId { get; set; }
        public string DeviceIp { get; set; }

        public event EventHandler OnDeviceStatusUpdated = delegate { };

        protected void UpdateDeviceStatus(EventArgs args)
        {
            OnDeviceStatusUpdated(this, args);
        }
    }

    public class DeviceStatusChangedEventArgs : EventArgs
    {
        public long DeviceId { get; set; }
        public int OldStatus { get; set; }
        public int NewStatus { get; set; }
    }
}
