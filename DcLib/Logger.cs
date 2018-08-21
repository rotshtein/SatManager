using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Lbc4000SnmpDriver.Enums;

namespace Lbc4000Logger
{
    public class Logger
    {
        StreamWriter _logWriter;
        private static readonly object _padlock = new object();
        private static Logger _logger;
        private string _logFilePath;

        public bool Silence { get; private set; }

        private Logger(string filePath = "", bool silence = false)
        {
            Silence = silence;
            _logFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\logfile.txt";
            if (File.Exists(_logFilePath))
                File.Delete(_logFilePath);
            _logWriter = new StreamWriter(_logFilePath);
        }

        public void Dispose(object sender, EventArgs e)
        {
#if DEBUG
            if (File.Exists(_logFilePath))
                System.Diagnostics.Process.Start(_logFilePath);
#endif
        }

        public void WriteMessage(string msg, DebugLevel level, string fmt = "")
        {
            if (!Silence)
            {
                lock (_padlock)
                {
                    Entry entry = new Entry(msg, level, fmt);
                    _logWriter.Write(entry.ToString());
                    _logWriter.Flush();
                    Console.Write(entry.ToString());
                }
            }
        }

        public void WriteAsIs(string msg)
        {
            if (!Silence)
            {
                lock(_padlock)
                {
                    _logWriter.Write(msg + "\r\n");
                    Console.Write(msg + "\r\n");
                }
            }
        }

        public static Logger GetLogger(string tempFilePath = "", bool silence = false)
        {
            lock (_padlock)
            {
                if (_logger == null)
                    _logger = new Logger(tempFilePath, silence);
                return _logger;
            }
        }
    }
}
