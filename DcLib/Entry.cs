using System;
using Lbc4000SnmpDriver.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lbc4000Logger
{
    public class Entry
    {
        private string _fmt;

        private DateTime Stamp
        {
            get { return DateTime.Now; }
        }

        public string Message { get; private set; }

        public DebugLevel Level { get; private set; }

        public Entry(string msg, DebugLevel level, string fmt = "")
        {
            Message = msg;
            Level = level;
            if (fmt == "")
                _fmt = "{0, -10}{1,10}\t{2}\r\n";
        }

        public override string ToString()
        {
            return String.Format(_fmt, Stamp, Level, Message);
        }


    }
}
