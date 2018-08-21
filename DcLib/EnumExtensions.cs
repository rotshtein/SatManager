using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Lbc4000SnmpDriver.Enums;

namespace DCControllerUI
{
    public static class EnumExtensions
    {
        public static string GetText(this MuteOptions op)
        {
            switch (op)
            {
                case MuteOptions.On:
                    return "Disabled";
                case MuteOptions.Off:
                    return "Enabled";
                default:
                    throw new Exception("Unsupported Operation");
            }
        }

        public static string GetText(this ConfigMuteOptions op)
        {
            switch (op)
            {
                case ConfigMuteOptions.On:
                    return "On";
                case ConfigMuteOptions.Off:
                    return "Off";
                default:
                    throw new Exception("Unsupported Operation");
            }
        }
        public static string GetText(this InstalledOptions op)
        {
            switch (op)
            {
                case InstalledOptions.Yes:
                    return "Yes";
                case InstalledOptions.No:
                    return "No";
                default:
                    throw new Exception("Unsupported Operation");
            }
        }

        public static string GetText(this InverseOptions op)
        {
            switch (op)
            {
                case InverseOptions.Inv:
                    return "On";
                case InverseOptions.Nrm:
                    return "Off";
                default:
                    throw new Exception("Unsupported Operation");
            }
        }
    }
}
