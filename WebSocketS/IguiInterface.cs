using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketS
{
    public interface IguiInterface
    {
        void ShowMessage(string msg);
        void UpdateCicdState(bool SeperationState);
        void UpdateCicdCounter(ulong Cic1Data, ulong Cic2Data, ulong Cic1Errors, ulong Cic2Errors );

    }
}
