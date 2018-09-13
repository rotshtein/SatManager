using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CicManagerLib
{
    class CicManager : IDisposable
    {
        public CarrierInformation CarrierInformation { get; set; }
        public DownConverterHandler DownConverter { get; set; }
        public CicDecoderHandler Decoder { get; set; }

        public event EventHandler<ConfigurationUpdateEventArgs> OnConfigurationUpdated = delegate { };

        private CancellationTokenSource _token = null;

        public void Dispose()
        {
            if (_token != null)
            {
                _token.Cancel();
                _token = null;
            }
        }

        internal void StartConfiguration()
        {
            _token = new CancellationTokenSource();

            DownConverter.OnDownConverterConfigurationUpdateReceived += (sender, args) =>
            {
                OnConfigurationUpdated(this, args);
                if (args.Success) Task.Run(() => CicDecoderHandler.ConfigureCarrier(CarrierInformation));
            };

            Decoder.OnCarrierConfigurationUpdateReceived += (sender, args) =>
            {
                OnConfigurationUpdated(this, args);
                if (args.Success)
                {
                    switch (args.Code)
                    {
                        case CicManagerConfigurationCode.CicDecoderCarrierConfiguration:
                            Task.Run(() => CicDecoderHandler.DetectCarrier());
                            break;

                        case CicManagerConfigurationCode.CicDecoderCarrierParametersDetection:
                            Task.Run(() => CicDecoderHandler.StartCarrierProduction());
                            break;

                        case CicManagerConfigurationCode.CicDecoderProductionStart:
                            Task.Run(() => CicDecoderHandler.ConfigureMediatorSoftware());
                            break;
                    }
                }
            };

            Decoder.OnMediationSoftwareConfigurationUpdateReceived += (sender, args) =>
            {
                OnConfigurationUpdated(this, args);
                if (args.Success)
                {
                    switch (args.Code)
                    {
                        case CicManagerConfigurationCode.MediationSofwareConfiguration:
                            Task.Run(() => CicDecoderHandler.DetectCicData());
                            break;

                        case CicManagerConfigurationCode.MediattionSoftwareParametersDetection:
                            Task.Run(() => CicDecoderHandler.StartDataProduction());
                            break;
                    }
                }
            };

            Task.Run(() => DownConverter.ConfigureCarrier(CarrierInformation));
        }
    }

    public enum CicManagerConfigurationCode
    {
        DownConverterConfiguration,

        CicDecoderCarrierConfiguration,
        CicDecoderCarrierParametersDetection,
        CicDecoderProductionStart,

        MediationSofwareConfiguration,
        MediattionSoftwareParametersDetection,
        MediationSoftwareProductionStart
    }

    public class ConfigurationUpdateEventArgs : EventArgs
    {
        public bool Success { get; set; }
        public CicManagerConfigurationCode Code { get; set; }
        public string Decription { get; set; }
    }
}
