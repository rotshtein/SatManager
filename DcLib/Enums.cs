using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnmpSharpNet;

namespace Lbc4000SnmpDriver.Enums
{
    public enum MuteOptions
    {
        On = 1,
        Off = 0,
    }

    public enum ConfigMuteOptions
    {
        On = 1,
        Off = 0,
    }

    public enum InstalledOptions
    {
        Yes = 1,
        No = 0,
    }

    public enum InverseOptions
    {
        Inv = 0,
        Nrm = 1,
    }

    public enum DebugLevel
    {
        VERBOSE = 0,
        DEBUG = 1,
        ERROR = 2,
    }
}

