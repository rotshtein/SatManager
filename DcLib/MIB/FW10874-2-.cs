using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace ComtechEFDataMib
{
	public class SnmpOid
	{
		private readonly string oid;

		public SnmpOid(string oid)
		{
			this.oid = oid;
		}

		public static implicit operator string(SnmpOid so) { return so.oid; }
		public string this[int rowIndex] { get { return oid + "." + rowIndex; } }
	}

	public abstract class SnmpNode
	{
		public readonly SnmpOid oid;
		public readonly Type type;
		public abstract string ParentName { get; }
		public abstract string SnmpType { get; }

		protected SnmpNode(string oid, Type type)
		{
			this.oid = new SnmpOid(oid);
			this.type = type;
		}

		public static SnmpNode[] CreateSnmpNodes(string ns)
		{
			var res = new List<SnmpNode>();

			var list = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace != null && t.Namespace.EndsWith(ns)).Select(x => x.ToString()).ToArray();

			foreach (var classname in list)
			{
				try
				{
					var type = Type.GetType(classname);
					if (type == null) continue;
					if (type.IsAbstract) continue;
					if (type.IsClass == false) continue;
					var item = Activator.CreateInstance(type);
					res.Add((SnmpNode) item);
				}
				catch { }
			}
			return res.ToArray();
		}
	}

	namespace comtechEFData
	{
		namespace conv4000
		{
			namespace conv4000Objects
			{
				namespace conv4000System
				{
					namespace conv4000SystemInfo
					{
						public class conv4000ModelNumber : SnmpNode
						{
							public conv4000ModelNumber() : base(".1.3.6.1.4.1.6247.70.1.1.1.1.0", typeof(string)) { }

							public const string Name ="conv4000ModelNumber";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "OCTET"; } }
							public static readonly conv4000ModelNumber Default = new conv4000ModelNumber();
						}
						public class conv4000SerialNumber : SnmpNode
						{
							public conv4000SerialNumber() : base(".1.3.6.1.4.1.6247.70.1.1.1.2.0", typeof(string)) { }

							public const string Name ="conv4000SerialNumber";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "OCTET"; } }
							public static readonly conv4000SerialNumber Default = new conv4000SerialNumber();
						}
						public class conv4000SoftwareRevision : SnmpNode
						{
							public conv4000SoftwareRevision() : base(".1.3.6.1.4.1.6247.70.1.1.1.3.0", typeof(string)) { }

							public const string Name ="conv4000SoftwareRevision";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "OCTET"; } }
							public static readonly conv4000SoftwareRevision Default = new conv4000SoftwareRevision();
						}
						public class conv4000PartNumber : SnmpNode
						{
							public conv4000PartNumber() : base(".1.3.6.1.4.1.6247.70.1.1.1.4.0", typeof(string)) { }

							public const string Name ="conv4000PartNumber";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "OCTET"; } }
							public static readonly conv4000PartNumber Default = new conv4000PartNumber();
						}
						public static class conv4000SystemInfoHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000SystemInfo");
						}
					}
					public static class conv4000SystemHelper
					{
						public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000System");
					}
				}
				namespace conv4000Config
				{
					namespace conv4000ConvAOutput
					{
						public class conv4000ConvAInstalled : SnmpNode
						{
							public conv4000ConvAInstalled() : base(".1.3.6.1.4.1.6247.70.1.2.1.1.0", typeof(int)) { }

							public const string Name ="conv4000ConvAInstalled";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvAInstalled Default = new conv4000ConvAInstalled();
							public enum Options : int
							{
								off = 0,
								on = 1
							}
						}
						public class conv4000ConvAFrequency : SnmpNode
						{
							public conv4000ConvAFrequency() : base(".1.3.6.1.4.1.6247.70.1.2.1.2.0", typeof(int)) { }

							public const string Name ="conv4000ConvAFrequency";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvAFrequency Default = new conv4000ConvAFrequency();
							public const int minValue = 0;
							public const int maxValue = 99999999;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000ConvAMute : SnmpNode
						{
							public conv4000ConvAMute() : base(".1.3.6.1.4.1.6247.70.1.2.1.3.0", typeof(int)) { }

							public const string Name ="conv4000ConvAMute";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvAMute Default = new conv4000ConvAMute();
							public enum Options : int
							{
								off = 0,
								on = 1
							}
						}
						public class conv4000ConvAConfigMuteMode : SnmpNode
						{
							public conv4000ConvAConfigMuteMode() : base(".1.3.6.1.4.1.6247.70.1.2.1.4.0", typeof(int)) { }

							public const string Name ="conv4000ConvAConfigMuteMode";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvAConfigMuteMode Default = new conv4000ConvAConfigMuteMode();
							public enum Options : int
							{
								off = 0,
								on = 1
							}
						}
						public class conv4000ConvAAttenuator : SnmpNode
						{
							public conv4000ConvAAttenuator() : base(".1.3.6.1.4.1.6247.70.1.2.1.5.0", typeof(int)) { }

							public const string Name ="conv4000ConvAAttenuator";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvAAttenuator Default = new conv4000ConvAAttenuator();
							public const int minValue = 0;
							public const int maxValue = 5000;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000ConvASlope : SnmpNode
						{
							public conv4000ConvASlope() : base(".1.3.6.1.4.1.6247.70.1.2.1.6.0", typeof(int)) { }

							public const string Name ="conv4000ConvASlope";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvASlope Default = new conv4000ConvASlope();
							public const int minValue = 0;
							public const int maxValue = 10;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000ConvAAttenuationOffset : SnmpNode
						{
							public conv4000ConvAAttenuationOffset() : base(".1.3.6.1.4.1.6247.70.1.2.1.7.0", typeof(int)) { }

							public const string Name ="conv4000ConvAAttenuationOffset";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvAAttenuationOffset Default = new conv4000ConvAAttenuationOffset();
							public const int minValue = -50;
							public const int maxValue = 50;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public static class conv4000ConvAOutputHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000ConvAOutput");
						}
					}
					namespace conv4000ConvBOutput
					{
						public class conv4000ConvBInstalled : SnmpNode
						{
							public conv4000ConvBInstalled() : base(".1.3.6.1.4.1.6247.70.1.2.2.1.0", typeof(int)) { }

							public const string Name ="conv4000ConvBInstalled";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvBInstalled Default = new conv4000ConvBInstalled();
							public enum Options : int
							{
								off = 0,
								on = 1
							}
						}
						public class conv4000ConvBFrequency : SnmpNode
						{
							public conv4000ConvBFrequency() : base(".1.3.6.1.4.1.6247.70.1.2.2.2.0", typeof(int)) { }

							public const string Name ="conv4000ConvBFrequency";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvBFrequency Default = new conv4000ConvBFrequency();
							public const int minValue = 0;
							public const int maxValue = 99999999;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000ConvBMute : SnmpNode
						{
							public conv4000ConvBMute() : base(".1.3.6.1.4.1.6247.70.1.2.2.3.0", typeof(int)) { }

							public const string Name ="conv4000ConvBMute";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvBMute Default = new conv4000ConvBMute();
							public enum Options : int
							{
								off = 0,
								on = 1
							}
						}
						public class conv4000ConvBConfigMuteMode : SnmpNode
						{
							public conv4000ConvBConfigMuteMode() : base(".1.3.6.1.4.1.6247.70.1.2.2.4.0", typeof(int)) { }

							public const string Name ="conv4000ConvBConfigMuteMode";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvBConfigMuteMode Default = new conv4000ConvBConfigMuteMode();
							public enum Options : int
							{
								off = 0,
								on = 1
							}
						}
						public class conv4000ConvBAttenuator : SnmpNode
						{
							public conv4000ConvBAttenuator() : base(".1.3.6.1.4.1.6247.70.1.2.2.5.0", typeof(int)) { }

							public const string Name ="conv4000ConvBAttenuator";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvBAttenuator Default = new conv4000ConvBAttenuator();
							public const int minValue = 0;
							public const int maxValue = 5000;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000ConvBSlope : SnmpNode
						{
							public conv4000ConvBSlope() : base(".1.3.6.1.4.1.6247.70.1.2.2.6.0", typeof(int)) { }

							public const string Name ="conv4000ConvBSlope";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvBSlope Default = new conv4000ConvBSlope();
							public const int minValue = 0;
							public const int maxValue = 10;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public static class conv4000ConvBOutputHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000ConvBOutput");
						}
					}
					namespace conv4000SerialRemoteControl
					{
						public class conv4000SerialInterfaceType : SnmpNode
						{
							public conv4000SerialInterfaceType() : base(".1.3.6.1.4.1.6247.70.1.2.3.2.0", typeof(int)) { }

							public const string Name ="conv4000SerialInterfaceType";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000SerialInterfaceType Default = new conv4000SerialInterfaceType();
							public enum Options : int
							{
								rs232 = 0,
								rs485 = 1
							}
						}
						public class conv4000SerialPhysicalAddress : SnmpNode
						{
							public conv4000SerialPhysicalAddress() : base(".1.3.6.1.4.1.6247.70.1.2.3.3.0", typeof(int)) { }

							public const string Name ="conv4000SerialPhysicalAddress";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000SerialPhysicalAddress Default = new conv4000SerialPhysicalAddress();
							public const int minValue = 1;
							public const int maxValue = 9999;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000SerialBaudRate : SnmpNode
						{
							public conv4000SerialBaudRate() : base(".1.3.6.1.4.1.6247.70.1.2.3.4.0", typeof(int)) { }

							public const string Name ="conv4000SerialBaudRate";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000SerialBaudRate Default = new conv4000SerialBaudRate();
						}
						public class conv4000SerialParity : SnmpNode
						{
							public conv4000SerialParity() : base(".1.3.6.1.4.1.6247.70.1.2.3.5.0", typeof(int)) { }

							public const string Name ="conv4000SerialParity";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000SerialParity Default = new conv4000SerialParity();
							public enum Options : int
							{
								none = 0,
								even = 1,
								odd = 2
							}
						}
						public static class conv4000SerialRemoteControlHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000SerialRemoteControl");
						}
					}
					namespace conv4000EthernetRemoteControl
					{
						public class conv4000IpAddress : SnmpNode
						{
							public conv4000IpAddress() : base(".1.3.6.1.4.1.6247.70.1.2.4.2.0", typeof(byte[])) { }

							public const string Name ="conv4000IpAddress";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "IpAddress"; } }
							public static readonly conv4000IpAddress Default = new conv4000IpAddress();
						}
						public class conv4000IpSubnetMask : SnmpNode
						{
							public conv4000IpSubnetMask() : base(".1.3.6.1.4.1.6247.70.1.2.4.3.0", typeof(int)) { }

							public const string Name ="conv4000IpSubnetMask";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000IpSubnetMask Default = new conv4000IpSubnetMask();
							public const int minValue = 8;
							public const int maxValue = 30;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000DefaultGateway : SnmpNode
						{
							public conv4000DefaultGateway() : base(".1.3.6.1.4.1.6247.70.1.2.4.4.0", typeof(byte[])) { }

							public const string Name ="conv4000DefaultGateway";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "IpAddress"; } }
							public static readonly conv4000DefaultGateway Default = new conv4000DefaultGateway();
						}
						public class conv4000MacAddress : SnmpNode
						{
							public conv4000MacAddress() : base(".1.3.6.1.4.1.6247.70.1.2.4.5.0", typeof(byte[])) { }

							public const string Name ="conv4000MacAddress";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "MacAddress"; } }
							public static readonly conv4000MacAddress Default = new conv4000MacAddress();
						}
						namespace conv4000SNMP
						{
							public class conv4000SNMPTrapDestinationIpAddress1 : SnmpNode
							{
								public conv4000SNMPTrapDestinationIpAddress1() : base(".1.3.6.1.4.1.6247.70.1.2.4.6.2.0", typeof(byte[])) { }

								public const string Name ="conv4000SNMPTrapDestinationIpAddress1";
								public override string ParentName { get { return Name; } }
								public override string SnmpType { get { return "IpAddress"; } }
								public static readonly conv4000SNMPTrapDestinationIpAddress1 Default = new conv4000SNMPTrapDestinationIpAddress1();
							}
							public class conv4000SNMPTrapDestinationIpAddress2 : SnmpNode
							{
								public conv4000SNMPTrapDestinationIpAddress2() : base(".1.3.6.1.4.1.6247.70.1.2.4.6.3.0", typeof(byte[])) { }

								public const string Name ="conv4000SNMPTrapDestinationIpAddress2";
								public override string ParentName { get { return Name; } }
								public override string SnmpType { get { return "IpAddress"; } }
								public static readonly conv4000SNMPTrapDestinationIpAddress2 Default = new conv4000SNMPTrapDestinationIpAddress2();
							}
							public class conv4000SNMPTrapCommunity : SnmpNode
							{
								public conv4000SNMPTrapCommunity() : base(".1.3.6.1.4.1.6247.70.1.2.4.6.4.0", typeof(string)) { }

								public const string Name ="conv4000SNMPTrapCommunity";
								public override string ParentName { get { return Name; } }
								public override string SnmpType { get { return "DisplayString"; } }
								public static readonly conv4000SNMPTrapCommunity Default = new conv4000SNMPTrapCommunity();
							}
							public class conv4000SNMPTrapVersion : SnmpNode
							{
								public conv4000SNMPTrapVersion() : base(".1.3.6.1.4.1.6247.70.1.2.4.6.5.0", typeof(int)) { }

								public const string Name ="conv4000SNMPTrapVersion";
								public override string ParentName { get { return Name; } }
								public override string SnmpType { get { return "INTEGER"; } }
								public static readonly conv4000SNMPTrapVersion Default = new conv4000SNMPTrapVersion();
								public enum Options : int
								{
									snmpV1 = 1,
									snmpV2 = 2
								}
							}
							public static class conv4000SNMPHelper
							{
								public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000SNMP");
							}
						}
						public static class conv4000EthernetRemoteControlHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000EthernetRemoteControl");
						}
					}
					namespace conv4000Redundancy
					{
						public class conv4000RedundancyState : SnmpNode
						{
							public conv4000RedundancyState() : base(".1.3.6.1.4.1.6247.70.1.2.5.1.0", typeof(int)) { }

							public const string Name ="conv4000RedundancyState";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000RedundancyState Default = new conv4000RedundancyState();
							public enum Options : int
							{
								disable = 0,
								enable = 1
							}
						}
						public class conv4000RedundancyMode : SnmpNode
						{
							public conv4000RedundancyMode() : base(".1.3.6.1.4.1.6247.70.1.2.5.2.0", typeof(int)) { }

							public const string Name ="conv4000RedundancyMode";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000RedundancyMode Default = new conv4000RedundancyMode();
							public enum Options : int
							{
								manual = 0,
								auto = 1
							}
						}
						public class conv4000RedundancyForceBackup : SnmpNode
						{
							public conv4000RedundancyForceBackup() : base(".1.3.6.1.4.1.6247.70.1.2.5.3.0", typeof(int)) { }

							public const string Name ="conv4000RedundancyForceBackup";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000RedundancyForceBackup Default = new conv4000RedundancyForceBackup();
							public enum Options : int
							{
								no = 0,
								yes = 1
							}
						}
						public class conv4000ConvAOnLineStatus : SnmpNode
						{
							public conv4000ConvAOnLineStatus() : base(".1.3.6.1.4.1.6247.70.1.2.5.4.0", typeof(int)) { }

							public const string Name ="conv4000ConvAOnLineStatus";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvAOnLineStatus Default = new conv4000ConvAOnLineStatus();
							public enum Options : int
							{
								offline = 0,
								online = 1
							}
						}
						public class conv4000ConvBOnLineStatus : SnmpNode
						{
							public conv4000ConvBOnLineStatus() : base(".1.3.6.1.4.1.6247.70.1.2.5.5.0", typeof(int)) { }

							public const string Name ="conv4000ConvBOnLineStatus";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvBOnLineStatus Default = new conv4000ConvBOnLineStatus();
							public enum Options : int
							{
								offline = 0,
								online = 1
							}
						}
						public static class conv4000RedundancyHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000Redundancy");
						}
					}
					namespace conv4000AutoFaultRecoveryMode
					{
						public class conv4000AutoFaultRecovery : SnmpNode
						{
							public conv4000AutoFaultRecovery() : base(".1.3.6.1.4.1.6247.70.1.2.6.2.0", typeof(int)) { }

							public const string Name ="conv4000AutoFaultRecovery";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000AutoFaultRecovery Default = new conv4000AutoFaultRecovery();
							public enum Options : int
							{
								manual = 0,
								automatic = 1
							}
						}
						public static class conv4000AutoFaultRecoveryModeHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000AutoFaultRecoveryMode");
						}
					}
					namespace conv4000SpectrumInversionMode
					{
						public class conv4000convASpectrumInversion : SnmpNode
						{
							public conv4000convASpectrumInversion() : base(".1.3.6.1.4.1.6247.70.1.2.7.2.0", typeof(int)) { }

							public const string Name ="conv4000convASpectrumInversion";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000convASpectrumInversion Default = new conv4000convASpectrumInversion();
							public enum Options : int
							{
								inv = 0,
								nrm = 1
							}
						}
						public class conv4000convBSpectrumInversion : SnmpNode
						{
							public conv4000convBSpectrumInversion() : base(".1.3.6.1.4.1.6247.70.1.2.7.3.0", typeof(int)) { }

							public const string Name ="conv4000convBSpectrumInversion";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000convBSpectrumInversion Default = new conv4000convBSpectrumInversion();
							public enum Options : int
							{
								inv = 0,
								nrm = 1
							}
						}
						public static class conv4000SpectrumInversionModeHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000SpectrumInversionMode");
						}
					}
					public static class conv4000ConfigHelper
					{
						public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000Config");
					}
				}
				namespace conv4000Monitor
				{
					namespace conv4000MonitorPSA
					{
						public class conv4000MonitorPSA12Volt : SnmpNode
						{
							public conv4000MonitorPSA12Volt() : base(".1.3.6.1.4.1.6247.70.1.3.1.1.0", typeof(int)) { }

							public const string Name ="conv4000MonitorPSA12Volt";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorPSA12Volt Default = new conv4000MonitorPSA12Volt();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000MonitorPSA8Volt : SnmpNode
						{
							public conv4000MonitorPSA8Volt() : base(".1.3.6.1.4.1.6247.70.1.3.1.2.0", typeof(int)) { }

							public const string Name ="conv4000MonitorPSA8Volt";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorPSA8Volt Default = new conv4000MonitorPSA8Volt();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000MonitorPSA5Volt : SnmpNode
						{
							public conv4000MonitorPSA5Volt() : base(".1.3.6.1.4.1.6247.70.1.3.1.3.0", typeof(int)) { }

							public const string Name ="conv4000MonitorPSA5Volt";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorPSA5Volt Default = new conv4000MonitorPSA5Volt();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public static class conv4000MonitorPSAHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000MonitorPSA");
						}
					}
					namespace conv4000MonitorPSB
					{
						public class conv4000MonitorPSB12Volt : SnmpNode
						{
							public conv4000MonitorPSB12Volt() : base(".1.3.6.1.4.1.6247.70.1.3.2.1.0", typeof(int)) { }

							public const string Name ="conv4000MonitorPSB12Volt";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorPSB12Volt Default = new conv4000MonitorPSB12Volt();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000MonitorPSB8Volt : SnmpNode
						{
							public conv4000MonitorPSB8Volt() : base(".1.3.6.1.4.1.6247.70.1.3.2.2.0", typeof(int)) { }

							public const string Name ="conv4000MonitorPSB8Volt";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorPSB8Volt Default = new conv4000MonitorPSB8Volt();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000MonitorPSB5Volt : SnmpNode
						{
							public conv4000MonitorPSB5Volt() : base(".1.3.6.1.4.1.6247.70.1.3.2.3.0", typeof(int)) { }

							public const string Name ="conv4000MonitorPSB5Volt";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorPSB5Volt Default = new conv4000MonitorPSB5Volt();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public static class conv4000MonitorPSBHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000MonitorPSB");
						}
					}
					namespace conv4000MonitorConvAVoltages
					{
						public class conv4000MonitorConvAIFLOVoltage : SnmpNode
						{
							public conv4000MonitorConvAIFLOVoltage() : base(".1.3.6.1.4.1.6247.70.1.3.3.1.0", typeof(int)) { }

							public const string Name ="conv4000MonitorConvAIFLOVoltage";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorConvAIFLOVoltage Default = new conv4000MonitorConvAIFLOVoltage();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000MonitorConvARFLOVoltage : SnmpNode
						{
							public conv4000MonitorConvARFLOVoltage() : base(".1.3.6.1.4.1.6247.70.1.3.3.2.0", typeof(int)) { }

							public const string Name ="conv4000MonitorConvARFLOVoltage";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorConvARFLOVoltage Default = new conv4000MonitorConvARFLOVoltage();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000MonitorConvATemp : SnmpNode
						{
							public conv4000MonitorConvATemp() : base(".1.3.6.1.4.1.6247.70.1.3.3.3.0", typeof(int)) { }

							public const string Name ="conv4000MonitorConvATemp";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorConvATemp Default = new conv4000MonitorConvATemp();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public static class conv4000MonitorConvAVoltagesHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000MonitorConvAVoltages");
						}
					}
					namespace conv4000MonitorConvBVoltages
					{
						public class conv4000MonitorConvBIFLOVoltage : SnmpNode
						{
							public conv4000MonitorConvBIFLOVoltage() : base(".1.3.6.1.4.1.6247.70.1.3.4.1.0", typeof(int)) { }

							public const string Name ="conv4000MonitorConvBIFLOVoltage";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorConvBIFLOVoltage Default = new conv4000MonitorConvBIFLOVoltage();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000MonitorConvBRFLOVoltage : SnmpNode
						{
							public conv4000MonitorConvBRFLOVoltage() : base(".1.3.6.1.4.1.6247.70.1.3.4.2.0", typeof(int)) { }

							public const string Name ="conv4000MonitorConvBRFLOVoltage";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorConvBRFLOVoltage Default = new conv4000MonitorConvBRFLOVoltage();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class conv4000MonitorConvBTemp : SnmpNode
						{
							public conv4000MonitorConvBTemp() : base(".1.3.6.1.4.1.6247.70.1.3.4.3.0", typeof(int)) { }

							public const string Name ="conv4000MonitorConvBTemp";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000MonitorConvBTemp Default = new conv4000MonitorConvBTemp();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public static class conv4000MonitorConvBVoltagesHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000MonitorConvBVoltages");
						}
					}
					public static class conv4000MonitorHelper
					{
						public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000Monitor");
					}
				}
				namespace conv4000Utility
				{
					namespace conv4000RealTimeClock
					{
						public class conv4000RTCDate : SnmpNode
						{
							public conv4000RTCDate() : base(".1.3.6.1.4.1.6247.70.1.5.1.1.0", typeof(string)) { }

							public const string Name ="conv4000RTCDate";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "DisplayString"; } }
							public static readonly conv4000RTCDate Default = new conv4000RTCDate();
						}
						public class conv4000RTCTime : SnmpNode
						{
							public conv4000RTCTime() : base(".1.3.6.1.4.1.6247.70.1.5.1.2.0", typeof(string)) { }

							public const string Name ="conv4000RTCTime";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "DisplayString"; } }
							public static readonly conv4000RTCTime Default = new conv4000RTCTime();
						}
						public static class conv4000RealTimeClockHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000RealTimeClock");
						}
					}
					namespace conv4000FirmwareImage
					{
						public class conv4000FirmwareImgActive : SnmpNode
						{
							public conv4000FirmwareImgActive() : base(".1.3.6.1.4.1.6247.70.1.5.2.1.0", typeof(int)) { }

							public const string Name ="conv4000FirmwareImgActive";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000FirmwareImgActive Default = new conv4000FirmwareImgActive();
							public enum Options : int
							{
								bulkImage1 = 1,
								bulkImage2 = 2
							}
						}
						public class conv4000FirmwareImgNextReboot : SnmpNode
						{
							public conv4000FirmwareImgNextReboot() : base(".1.3.6.1.4.1.6247.70.1.5.2.2.0", typeof(int)) { }

							public const string Name ="conv4000FirmwareImgNextReboot";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000FirmwareImgNextReboot Default = new conv4000FirmwareImgNextReboot();
							public enum Options : int
							{
								bulkImage1 = 1,
								bulkImage2 = 2
							}
						}
						namespace conv4000FirmwareInfoTable
						{
							namespace conv4000FirmwareInfoEntry
							{
								public class conv4000FirmwareInfoIndex : SnmpNode
								{
									public conv4000FirmwareInfoIndex() : base(".1.3.6.1.4.1.6247.70.1.5.2.3.1.1", typeof(int)) { }

									public const string Name ="conv4000FirmwareInfoIndex";
									public override string ParentName { get { return Name; } }
									public override string SnmpType { get { return "INTEGER"; } }
									public static readonly conv4000FirmwareInfoIndex Default = new conv4000FirmwareInfoIndex();
									public const int minValue = 1;
									public const int maxValue = 24;
									public static bool isValid(int value)
									{
										if (value < minValue) return false;
										if (value > maxValue) return false;
										return true;
									}
								}
								public class conv4000FirmwareImg : SnmpNode
								{
									public conv4000FirmwareImg() : base(".1.3.6.1.4.1.6247.70.1.5.2.3.1.2", typeof(string)) { }

									public const string Name ="conv4000FirmwareImg";
									public override string ParentName { get { return Name; } }
									public override string SnmpType { get { return "DisplayString"; } }
									public static readonly conv4000FirmwareImg Default = new conv4000FirmwareImg();
								}
								public class conv4000FirmwareDesc : SnmpNode
								{
									public conv4000FirmwareDesc() : base(".1.3.6.1.4.1.6247.70.1.5.2.3.1.3", typeof(string)) { }

									public const string Name ="conv4000FirmwareDesc";
									public override string ParentName { get { return Name; } }
									public override string SnmpType { get { return "DisplayString"; } }
									public static readonly conv4000FirmwareDesc Default = new conv4000FirmwareDesc();
								}
								public static class conv4000FirmwareInfoEntryHelper
								{
									public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000FirmwareInfoEntry");
									public static readonly string[] Indexes = new string[]{"conv4000FirmwareInfoIndex"};
								}
							}
							public static class conv4000FirmwareInfoTableHelper
							{
								public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000FirmwareInfoTable");
							}
						}
						public static class conv4000FirmwareImageHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000FirmwareImage");
						}
					}
					namespace conv4000ApplicationIdentifier
					{
						public class conv4000ApplicationID : SnmpNode
						{
							public conv4000ApplicationID() : base(".1.3.6.1.4.1.6247.70.1.5.3.1.0", typeof(string)) { }

							public const string Name ="conv4000ApplicationID";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "DisplayString"; } }
							public static readonly conv4000ApplicationID Default = new conv4000ApplicationID();
						}
						public static class conv4000ApplicationIdentifierHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000ApplicationIdentifier");
						}
					}
					namespace conv4000Reference
					{
						public class conv4000ReferenceOscillatorAdjust : SnmpNode
						{
							public conv4000ReferenceOscillatorAdjust() : base(".1.3.6.1.4.1.6247.70.1.5.4.1.0", typeof(int)) { }

							public const string Name ="conv4000ReferenceOscillatorAdjust";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ReferenceOscillatorAdjust Default = new conv4000ReferenceOscillatorAdjust();
							public const int minValue = 0;
							public const int maxValue = 255;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class referenceTuningVoltageMonitor : SnmpNode
						{
							public referenceTuningVoltageMonitor() : base(".1.3.6.1.4.1.6247.70.1.5.4.2.0", typeof(int)) { }

							public const string Name ="referenceTuningVoltageMonitor";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly referenceTuningVoltageMonitor Default = new referenceTuningVoltageMonitor();
							public const int minValue = 0;
							public const int maxValue = 640;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public class referenceXRefFreq : SnmpNode
						{
							public referenceXRefFreq() : base(".1.3.6.1.4.1.6247.70.1.5.4.3.0", typeof(int)) { }

							public const string Name ="referenceXRefFreq";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly referenceXRefFreq Default = new referenceXRefFreq();
							public enum Options : int
							{
								na = 0,
								freq5MHZ = 1,
								freq10MHZ = 2
							}
						}
						public class referenceXRefLock : SnmpNode
						{
							public referenceXRefLock() : base(".1.3.6.1.4.1.6247.70.1.5.4.4.0", typeof(int)) { }

							public const string Name ="referenceXRefLock";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly referenceXRefLock Default = new referenceXRefLock();
							public enum Options : int
							{
								no = 0,
								notlocked = 1,
								locked = 2
							}
						}
						public static class conv4000ReferenceHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000Reference");
						}
					}
					namespace conv4000Reboot
					{
						public class conv4000RebootCmd : SnmpNode
						{
							public conv4000RebootCmd() : base(".1.3.6.1.4.1.6247.70.1.5.5.1.0", typeof(int)) { }

							public const string Name ="conv4000RebootCmd";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000RebootCmd Default = new conv4000RebootCmd();
							public enum Options : int
							{
								reboot = 1
							}
						}
						public static class conv4000RebootHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000Reboot");
						}
					}
					namespace conv4000VFD
					{
						public class conv4000VFDBrightness : SnmpNode
						{
							public conv4000VFDBrightness() : base(".1.3.6.1.4.1.6247.70.1.5.6.1.0", typeof(int)) { }

							public const string Name ="conv4000VFDBrightness";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000VFDBrightness Default = new conv4000VFDBrightness();
							public enum Options : int
							{
								twentyFivePercent = 1,
								fiftyPercent = 2,
								seventyFivePercent = 3,
								oneHundredPercent = 4
							}
						}
						public static class conv4000VFDHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000VFD");
						}
					}
					namespace conv4000ScreenSaver
					{
						public class conv4000ScreenSaverTheme : SnmpNode
						{
							public conv4000ScreenSaverTheme() : base(".1.3.6.1.4.1.6247.70.1.5.7.1.0", typeof(int)) { }

							public const string Name ="conv4000ScreenSaverTheme";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ScreenSaverTheme Default = new conv4000ScreenSaverTheme();
							public enum Options : int
							{
								classic = 1,
								bboard = 2,
								swiper = 3,
								zipped = 4,
								cycling = 5
							}
						}
						public class conv4000ScreenSaverTime : SnmpNode
						{
							public conv4000ScreenSaverTime() : base(".1.3.6.1.4.1.6247.70.1.5.7.2.0", typeof(int)) { }

							public const string Name ="conv4000ScreenSaverTime";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ScreenSaverTime Default = new conv4000ScreenSaverTime();
							public const int minValue = 0;
							public const int maxValue = 999;
							public static bool isValid(int value)
							{
								if (value < minValue) return false;
								if (value > maxValue) return false;
								return true;
							}
						}
						public static class conv4000ScreenSaverHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000ScreenSaver");
						}
					}
					namespace conv4000FaultRelayLogic
					{
						public class conv4000FaultRelayControl : SnmpNode
						{
							public conv4000FaultRelayControl() : base(".1.3.6.1.4.1.6247.70.1.5.8.1.0", typeof(int)) { }

							public const string Name ="conv4000FaultRelayControl";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000FaultRelayControl Default = new conv4000FaultRelayControl();
							public enum Options : int
							{
								normal = 0,
								invert = 1
							}
						}
						public static class conv4000FaultRelayLogicHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000FaultRelayLogic");
						}
					}
					public static class conv4000UtilityHelper
					{
						public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000Utility");
					}
				}
				namespace conv4000Faults
				{
					namespace conv4000CurrentFaults
					{
						public class conv4000PSA12VFault : SnmpNode
						{
							public conv4000PSA12VFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.1.0", typeof(int)) { }

							public const string Name ="conv4000PSA12VFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000PSA12VFault Default = new conv4000PSA12VFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000PSA08VFault : SnmpNode
						{
							public conv4000PSA08VFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.2.0", typeof(int)) { }

							public const string Name ="conv4000PSA08VFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000PSA08VFault Default = new conv4000PSA08VFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000PSA05VFault : SnmpNode
						{
							public conv4000PSA05VFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.3.0", typeof(int)) { }

							public const string Name ="conv4000PSA05VFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000PSA05VFault Default = new conv4000PSA05VFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000PSB12VFault : SnmpNode
						{
							public conv4000PSB12VFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.4.0", typeof(int)) { }

							public const string Name ="conv4000PSB12VFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000PSB12VFault Default = new conv4000PSB12VFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000PSB08VFault : SnmpNode
						{
							public conv4000PSB08VFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.5.0", typeof(int)) { }

							public const string Name ="conv4000PSB08VFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000PSB08VFault Default = new conv4000PSB08VFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000PSB05VFault : SnmpNode
						{
							public conv4000PSB05VFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.6.0", typeof(int)) { }

							public const string Name ="conv4000PSB05VFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000PSB05VFault Default = new conv4000PSB05VFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000ConvAIFLOFault : SnmpNode
						{
							public conv4000ConvAIFLOFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.7.0", typeof(int)) { }

							public const string Name ="conv4000ConvAIFLOFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvAIFLOFault Default = new conv4000ConvAIFLOFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000ConvARFLOFault : SnmpNode
						{
							public conv4000ConvARFLOFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.8.0", typeof(int)) { }

							public const string Name ="conv4000ConvARFLOFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvARFLOFault Default = new conv4000ConvARFLOFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000ConvATempFault : SnmpNode
						{
							public conv4000ConvATempFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.9.0", typeof(int)) { }

							public const string Name ="conv4000ConvATempFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvATempFault Default = new conv4000ConvATempFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000ConvBIFLOFault : SnmpNode
						{
							public conv4000ConvBIFLOFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.10.0", typeof(int)) { }

							public const string Name ="conv4000ConvBIFLOFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvBIFLOFault Default = new conv4000ConvBIFLOFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000ConvBRFLOFault : SnmpNode
						{
							public conv4000ConvBRFLOFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.11.0", typeof(int)) { }

							public const string Name ="conv4000ConvBRFLOFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvBRFLOFault Default = new conv4000ConvBRFLOFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1,
								notApplicable = 2,
								masked = 3
							}
						}
						public class conv4000ConvBTempFault : SnmpNode
						{
							public conv4000ConvBTempFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.12.0", typeof(int)) { }

							public const string Name ="conv4000ConvBTempFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ConvBTempFault Default = new conv4000ConvBTempFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public class conv4000ExternalRefFault : SnmpNode
						{
							public conv4000ExternalRefFault() : base(".1.3.6.1.4.1.6247.70.1.6.5.13.0", typeof(int)) { }

							public const string Name ="conv4000ExternalRefFault";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ExternalRefFault Default = new conv4000ExternalRefFault();
							public enum Options : int
							{
								ok = 0,
								fault = 1
							}
						}
						public static class conv4000CurrentFaultsHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000CurrentFaults");
						}
					}
					namespace conv4000ListAllFaults
					{
						namespace conv4000ListAllFaultsTable
						{
							namespace conv4000ListAllFaultsEntry
							{
								public class conv4000FaultIndex : SnmpNode
								{
									public conv4000FaultIndex() : base(".1.3.6.1.4.1.6247.70.1.6.6.1.1.1", typeof(int)) { }

									public const string Name ="conv4000FaultIndex";
									public override string ParentName { get { return Name; } }
									public override string SnmpType { get { return "INTEGER"; } }
									public static readonly conv4000FaultIndex Default = new conv4000FaultIndex();
									public const int minValue = 1;
									public const int maxValue = 1000;
									public static bool isValid(int value)
									{
										if (value < minValue) return false;
										if (value > maxValue) return false;
										return true;
									}
								}
								public class conv4000FaultDate : SnmpNode
								{
									public conv4000FaultDate() : base(".1.3.6.1.4.1.6247.70.1.6.6.1.1.2", typeof(string)) { }

									public const string Name ="conv4000FaultDate";
									public override string ParentName { get { return Name; } }
									public override string SnmpType { get { return "DisplayString"; } }
									public static readonly conv4000FaultDate Default = new conv4000FaultDate();
								}
								public class conv4000FaultTime : SnmpNode
								{
									public conv4000FaultTime() : base(".1.3.6.1.4.1.6247.70.1.6.6.1.1.3", typeof(string)) { }

									public const string Name ="conv4000FaultTime";
									public override string ParentName { get { return Name; } }
									public override string SnmpType { get { return "DisplayString"; } }
									public static readonly conv4000FaultTime Default = new conv4000FaultTime();
								}
								public class conv4000FaultDescription : SnmpNode
								{
									public conv4000FaultDescription() : base(".1.3.6.1.4.1.6247.70.1.6.6.1.1.4", typeof(string)) { }

									public const string Name ="conv4000FaultDescription";
									public override string ParentName { get { return Name; } }
									public override string SnmpType { get { return "DisplayString"; } }
									public static readonly conv4000FaultDescription Default = new conv4000FaultDescription();
								}
								public static class conv4000ListAllFaultsEntryHelper
								{
									public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000ListAllFaultsEntry");
									public static readonly string[] Indexes = new string[]{"conv4000FaultIndex"};
								}
							}
							public static class conv4000ListAllFaultsTableHelper
							{
								public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000ListAllFaultsTable");
							}
						}
						public class conv4000ClearAllFaults : SnmpNode
						{
							public conv4000ClearAllFaults() : base(".1.3.6.1.4.1.6247.70.1.6.6.2.0", typeof(int)) { }

							public const string Name ="conv4000ClearAllFaults";
							public override string ParentName { get { return Name; } }
							public override string SnmpType { get { return "INTEGER"; } }
							public static readonly conv4000ClearAllFaults Default = new conv4000ClearAllFaults();
							public enum Options : int
							{
								clearAll = 1
							}
						}
						public static class conv4000ListAllFaultsHelper
						{
							public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000ListAllFaults");
						}
					}
					public static class conv4000FaultsHelper
					{
						public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000Faults");
					}
				}
				public static class conv4000ObjectsHelper
				{
					public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000Objects");
				}
			}
			namespace conv4000Notifications
			{
				public class conv4000NotificationPrefix
				{
				}
				public static class conv4000NotificationsHelper
				{
					public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000Notifications");
				}
			}
			namespace conv4000Conformance
			{
				public class conv4000Groups
				{
				}
				public class conv4000Compliances
				{
				}
				public static class conv4000ConformanceHelper
				{
					public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000Conformance");
				}
			}
			public static class conv4000Helper
			{
				public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("conv4000");
			}
		}
		public static class comtechEFDataHelper
		{
			public static readonly SnmpNode[] SnmpNodes = SnmpNode.CreateSnmpNodes("comtechEFData");
		}
	}
}
