using System;
using System.Collections.Generic;
using Lbc4000SnmpDriver.Enums;

namespace Lbc4000SnmpDriver.Configuration
{
    public class PortConfiguration
    {
        #region private consts
        protected const int LBAND_MAX = 2150000;
        protected const int LBAND_MIN = 950000;
        protected const int ATT_MIN  = 0;
        protected const int ATT_MAX  = 2000;
        protected const int SLOPE_MIN = 0;
        protected const int SLOPE_MAX = 10;

        private const int FREQUENCY = 1125000;
        private const int ATTENUATION = 0;
        private const int MUTE = 0;
        private const int CONFIGMUTE = 1;
        private const int INVERSE = 0;
        private const int SLOPE = 0;
        #endregion private consts

        #region private fields
        private int _frequency;
        private int _mute;
        private int _configMute;
        private int _attenuate;
        private int _slope;
        private int _inverse;
        #endregion private fields

        #region public properties
        public int Frequency
        {
            get { return _frequency; }
            private set
            {
                if (value >= LBAND_MIN && value <= LBAND_MAX || value == 0) _frequency = value;
                else throw new InvalidOperationException("Given RF is out of band! (should be between 950000 and 2150000)");
            }
        }
        public int Attenuation
        {
            get { return _attenuate; }
            private set
            {
                if (value >= ATT_MIN && value <= ATT_MAX) _attenuate = value;
                else throw new InvalidOperationException("Given attenuation is out of range (should be between 0 and 5000)");
            }
        }
        public int Mute
        {
            get { return _mute; }
            private set
            {
                if (value == 0 || value == 1) _mute = value;
                else throw new InvalidOperationException("Mute value should be either 0 or 1");
            }
        }
        public int ConfigMute
        {
            get { return _configMute; }
            private set
            {
                if (value == 0 || value == 1) _configMute = value;
                else throw new InvalidOperationException("ConfigMute value should be either 0 or 1");
            }
        }
        public int Inverse
        {
            get { return _inverse; }
            private set
            {
                if (value == 0 || value == 1) _inverse = value;
                else throw new InvalidOperationException("Inverse value should be either 0 or 1");
            }
        }
        public int Slope
        {
            get { return _slope; }
            private set
            {
                if (value >= SLOPE_MIN && value <= SLOPE_MAX) _slope = value;
                else throw new InvalidOperationException("Slope value should be between 0 and 10");
            }
        }
        #endregion public properties

        public PortConfiguration(int frequency, int mute, int configMute, int attenuate, int slope, int inverse)
        {
            Frequency = frequency;
            Attenuation = attenuate;
            Mute = mute;
            ConfigMute = configMute;
            Inverse = inverse;
            Slope = slope;
        }

        public PortConfiguration(int frequency, bool mute, bool configMute, int attenuate, int slope, bool inverse)
        {
            Frequency = frequency;
            Mute = mute ? 0 : 1;
            ConfigMute = configMute ? 1 : 0;
            Attenuation = attenuate;
            Slope = slope;
            Inverse = inverse ? 1 : 0;
        }

        public PortConfiguration(int frequency, MuteOptions mute,
            ConfigMuteOptions configMute, int attenuation, int slope, InverseOptions inverse)
        {
            Frequency = frequency;
            Mute = (int)mute;
            ConfigMute = (int)configMute;
            Attenuation = attenuation;
            Slope = slope;
            Inverse = (int)inverse;
        }

        public static PortConfiguration Default()
        {
            return new PortConfiguration(FREQUENCY, MUTE, CONFIGMUTE, ATTENUATION, INVERSE, SLOPE);
        }
    }

    public class PortAConfiguration : PortConfiguration
    {
        //private int _attenuationOffset;
        /*public int AttenuationOffset
        {
            get { return _attenuationOffset; }
            private set
            {
                if (value >= ATT_OFF_MIN && value <= ATT_OFF_MAX) _attenuationOffset = value;
                else throw new InvalidOperationException("Attenuation Offset should be between -50 and 50");
            }
        }*/

        public PortAConfiguration(int frequency, int mute, int configMute, int attenuate, int slope, int inverse)
            : base(frequency, mute, configMute, attenuate, slope, inverse)
        {
        }

        public PortAConfiguration(int frequency, bool mute, bool configMute, int attenuate, int slope, bool inverse)
            :base(frequency, mute, configMute, attenuate, slope, inverse)
        {
        }
        public PortAConfiguration(int frequency, MuteOptions mute,
            ConfigMuteOptions configMute, int attenuation, int slope, InverseOptions inverse)
            :base(frequency, mute, configMute, attenuation, slope, inverse)
        {
        }

        public override string ToString()
        {
            string eol = "\r\n";
            string returnString = "Port A Configuration:" + eol +
                                  "\tFrequency:   {0}" + eol +
                                  "\tMute:        {1}" + eol +
                                  "\tConfigMute:  {2}" + eol +
                                  "\tAttenuation: {3}" + eol +
                                  "\tSlope:       {4}" + eol +
                                  "\tInverse:     {5}" + eol;

            return string.Format(returnString, Frequency, Mute, ConfigMute, Attenuation, Slope, Inverse);
        }
    }

    public class PortBConfiguration : PortConfiguration
    {
        public PortBConfiguration(int frequency, int mute, int configMute, int attenuate, int slope, int inverse) 
            : base(frequency, mute, configMute, attenuate, slope, inverse)
        {
        }

        public PortBConfiguration(int frequency, bool mute, bool configMute, int attenuate, int slope, bool inverse)
            :base(frequency, mute, configMute, attenuate, slope, inverse)
        {
        }

        public PortBConfiguration(int frequency, MuteOptions mute,
         ConfigMuteOptions configMute, int attenuation, int slope, InverseOptions inverse)
            :base(frequency, mute, configMute, attenuation, slope, inverse)
        {
        }

        public override string ToString()
        {
            string eol = "\r\n";
            string returnString = "Port B Configuration:" + eol +
                                  "\tFrequency:   {0}" + eol +
                                  "\tMute:        {1}" + eol +
                                  "\tConfigMute:  {2}" + eol +
                                  "\tAttenuation: {3}" + eol +
                                  "\tSlope:       {4}" + eol +
                                  "\tInverse:     {5}" + eol;
            return string.Format(returnString, Frequency, Mute, ConfigMute, Attenuation, Slope, Inverse);
        }
    }

    public class FaultList
    {
        #region private strings
        
        private const string conv4000PSA12VFault = "PSA12VFault";
        private const string conv4000PSA08VFault = "PSA08VFault";
        private const string conv4000PSA05VFault = "PSA05VFault";
        private const string conv4000PSB12VFault = "PSB12VFault";
        private const string conv4000PSB08VFault = "PSB08VFault";
        private const string conv4000PSB05VFault = "PSB05VFault";
        private const string conv4000ConvARFLOFault = "ConvARFLOFault";
        private const string conv4000ConvAIFLOFault = "ConvAIFLOFault";
        private const string conv4000ConvATempFault = "ConvATempFault";
        private const string conv4000ConvBIFLOFault = "ConvBRFLOFault";
        private const string conv4000ConvBRFLOFault = "ConvBIFLOFault";
        private const string conv4000ConvBTempFault = "ConvBTempFault";
        private const string conv4000ExternalRefFault = "ExternalRefFault";

        #endregion private strings

        private Dictionary<string, int> _faultDict;

        public Dictionary<string, int>.KeyCollection Keys
        {
            get
            {
                return _faultDict.Keys;
            }
        }

        public int this[string key]
        {
            get
            {
                return _faultDict[key];
            }

            set
            {
                _faultDict[key] = value;
            }
        }

        public FaultList(int psA12VFault, int psA08VFault, int psA05VFault,
                        int psB12VFault, int psB08VFault, int psB05VFault,
                        int aRFLOFault, int aIFLOFault, int aTempFault,
                        int bRFLOFault, int bIFLOFault, int bTempFault,
                        int externalRefFault)
        {
            _faultDict = new Dictionary<string, int>();
            _faultDict.Add(conv4000PSA12VFault, psA12VFault);
            _faultDict.Add(conv4000PSA08VFault, psA08VFault);
            _faultDict.Add(conv4000PSA05VFault, psA05VFault);
            _faultDict.Add(conv4000PSB12VFault, psB12VFault);
            _faultDict.Add(conv4000PSB08VFault ,psB08VFault);
            _faultDict.Add(conv4000PSB05VFault, psB05VFault);
            _faultDict.Add(conv4000ConvARFLOFault, aRFLOFault);
            _faultDict.Add(conv4000ConvAIFLOFault, aIFLOFault);
            _faultDict.Add(conv4000ConvATempFault, aTempFault);
            _faultDict.Add(conv4000ConvBRFLOFault, bRFLOFault);
            _faultDict.Add(conv4000ConvBIFLOFault, bIFLOFault);
            _faultDict.Add(conv4000ConvBTempFault, bTempFault);
            _faultDict.Add(conv4000ExternalRefFault, externalRefFault);
        }

        public override string ToString()
        {
            var retString = "Faults:\r\n";
            foreach (var key in Keys)
            {
                retString += string.Format("\t{0,-10}:{1,-10", key, this[key] == 1 ? "ON" : "OFF");
            }
            return retString;
        }

        public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
        {
            return _faultDict.GetEnumerator();
        }
    }

    public class Lbc4000Status
    {
        #region public properties
        public PortAConfiguration PortAConfiguration
        {
            get; set;
        }

        public PortBConfiguration PortBConfiguration
        {
            get; set;
        }

        public FaultList ActiveFaults
        {
            get; set;
        }
        #endregion public properties

        public Lbc4000Status(PortAConfiguration portA, PortBConfiguration portB, FaultList faults)
        {
            PortAConfiguration = portA;
            PortBConfiguration = portB;
            ActiveFaults       = faults;
        }

        public override string ToString()
        {
            string eol = "\r\n";
            var returnString = "Port A:" + eol +
                               "{0}" +
                               "Port B" + eol +
                               "{1}" +
                               "Active Faults:" + eol +
                               "{2}" + eol;
            return string.Format(returnString, PortAConfiguration, PortBConfiguration, ActiveFaults);
        }
    }
}
