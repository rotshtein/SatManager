using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebSocketS
{
    class Production
    {
        decimal freq;
        int     simbolRate;
        decimal sNR;
        int     port1;
        int     port2;
        IguiInterface gui = null;
        Task monitorTask = null;
        CancellationTokenSource ts = null;
        CancellationToken ct;

        public Production(decimal Freq, int SimbolRate, decimal SNR, int Port1, int Port2, IguiInterface gui)
        {
            freq = Freq;
            simbolRate = SimbolRate;
            sNR = SNR;
            port1 = Port1;
            port2 = Port2;
            this.gui = gui;
        }

        public CancellationToken Ct { get => ct; set => ct = value; }

        public void Start()
        {
            ts = new CancellationTokenSource();
            ct = ts.Token;
            monitorTask = new Task(() => { Monitor(); }, ct);
        }

        public void Stop()
        {
            if (ct.CanBeCanceled)
                ts.Cancel();
        }

        void Monitor()
        {
            while (true)
            {
                if (ct.IsCancellationRequested)
                {
                    // another thread decided to cancel
                    Console.WriteLine("task canceled");
                    break;
                }

            
            }

        }

    }
}
