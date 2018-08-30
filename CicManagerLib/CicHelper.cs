using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicManagerLib
{
    public static class CicHelper
    {
        private static List<DownConverterHandler> _downConverters = new List<DownConverterHandler>();
        private static List<CicDecoderHandler> _cicDecoders = new List<CicDecoderHandler>();
        private static List<CicManager> _activeConfigurations = new List<CicManager>();

        public static void AddDownConverter(long deviceId, string deviceIp)
        {
            if (_downConverters.Any(x => x.DeviceId == deviceId)) return; // Already exists
            _downConverters.Add(new DownConverterHandler { DeviceId = deviceId, DeviceIp = deviceIp });
        }

        public static void AddCicDecoder(long deviceId, string deviceIp)
        {
            if (_cicDecoders.Any(x => x.DeviceId == deviceId)) return; // Already exists
            _cicDecoders.Add(new CicDecoderHandler { DeviceId = deviceId, DeviceIp = deviceIp });
        }

        public static bool AddConfiguration(CarrierInformation carrier, long downCoverterDeviceId, long cicDecoderDeviceId)
        {
            if (_activeConfigurations.Any(x => x.CarrierInformation.CarrierId == carrier.CarrierId)) return false;

            var downConverter = _downConverters.FirstOrDefault(x => x.DeviceId == downCoverterDeviceId);
            if (downConverter == null) return false;

            var cicDecoder = _cicDecoders.FirstOrDefault(x => x.DeviceId == cicDecoderDeviceId);
            if (cicDecoder == null) return false;

            var manager = new CicManager { CarrierInformation = carrier, DownConverter = downConverter, Decoder = cicDecoder };
            manager.StartConfiguration();
            _activeConfigurations.Add(manager);
            return true;
        }

        public static bool RemoveConfiguration(int carrierId)
        {
            var configuration = _activeConfigurations.FirstOrDefault(x => x.CarrierInformation.CarrierId == carrierId);
            if (configuration == null) return false;
            _activeConfigurations.Remove(configuration);
            configuration.Dispose();
            return true;
        }
    }

    public class CarrierInformation
    {
        public int CarrierId { get; set; }
        public uint CenterFrequency { get; set; }
        public uint SymbolRate { get; set; }
        public double Snr { get; set; }
    }
}
