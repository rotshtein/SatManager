using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace CicManagerLib
{
    internal class CicDecoderHandler : NetworkDevice, IDisposable
    {
        public event EventHandler<ConfigurationUpdateEventArgs> OnCarrierConfigurationUpdateReceived = delegate { };
        public event EventHandler<ConfigurationUpdateEventArgs> OnMediationSoftwareConfigurationUpdateReceived = delegate { };

        private WebSocketSharp.WebSocket _cicDecoderClient;
        private WebSocketSharp.WebSocket _mediationSoftwareClient;
        private bool _disposing = false;

        public CicDecoderHandler()
        {
            // Start websockets
            _cicDecoderClient = new WebSocketSharp.WebSocket("ws://" + DeviceIp + ":10000");
            _cicDecoderClient.OnClose += (sender, args) =>
            {
                Debug.WriteLine("OnClose " + args.Code + ", " + args.Reason + ", " + args.WasClean);

                if (_disposing) return;

                UpdateDeviceStatus(new CicDecoderStatusEventArgs { IsWebSocketConnected = false });

                Task.Run(() =>
                {
                    Thread.Sleep(5000);
                    _cicDecoderClient.Connect();
                });
            };
            _cicDecoderClient.OnError += (sender, args) => Debug.WriteLine("OnError " + args.Message + ", " + args.Exception);
            _cicDecoderClient.OnOpen += (sender, args) =>
            {
                Debug.WriteLine("OnOpen");

                UpdateDeviceStatus(new CicDecoderStatusEventArgs { IsWebSocketConnected = true });
            };
            _cicDecoderClient.OnMessage += (sender, args) => { };

            _mediationSoftwareClient = new WebSocketSharp.WebSocket("ws://" + DeviceIp + ":10001");
            _mediationSoftwareClient.OnClose += (sender, args) =>
            {
                Debug.WriteLine("OnClose " + args.Code + ", " + args.Reason + ", " + args.WasClean);

                if (_disposing) return;

                UpdateDeviceStatus(new MediationSoftwareStatusEventArgs { IsWebSocketConnected = false });

                Task.Run(() =>
                {
                    Thread.Sleep(5000);
                    _mediationSoftwareClient.Connect();
                });
            };
            _mediationSoftwareClient.OnError += (sender, args) => Debug.WriteLine("OnError " + args.Message + ", " + args.Exception);
            _mediationSoftwareClient.OnOpen += (sender, args) =>
            {
                Debug.WriteLine("OnOpen");

                UpdateDeviceStatus(new MediationSoftwareStatusEventArgs { IsWebSocketConnected = true });
            };
            _mediationSoftwareClient.OnMessage += (sender, args) => { };
        }

        #region CIC Decoder

        internal static void ConfigureCarrier(CarrierInformation carrierInformation)
        {
            throw new NotImplementedException();
        }

        internal static void DetectCarrier()
        {
            throw new NotImplementedException();
        }

        internal static void StartCarrierProduction()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Mediation Software

        internal static void ConfigureMediatorSoftware()
        {
            throw new NotImplementedException();
        }

        internal static void DetectCicData()
        {
            throw new NotImplementedException();
        }

        internal static void StartDataProduction()
        {
            throw new NotImplementedException();
        }

        #endregion

        public void Dispose()
        {
            _disposing = true;

            if (_cicDecoderClient != null)
            {
                _cicDecoderClient.Close();
                _cicDecoderClient = null;
            }

            if (_mediationSoftwareClient != null)
            {
                _mediationSoftwareClient.Close();
                _mediationSoftwareClient = null;
            }
        }

    }

    public class CicDecoderStatusEventArgs : EventArgs
    {
        public bool IsWebSocketConnected { get; set; }
    }

    public class MediationSoftwareStatusEventArgs : EventArgs
    {
        public bool IsWebSocketConnected { get; set; }
    }
}