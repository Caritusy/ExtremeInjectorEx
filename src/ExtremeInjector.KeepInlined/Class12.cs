using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

[DataContract(Namespace = "")]
public sealed class Class12
{
	[DataMember(Name = "ProcessName")]
	public string string_0;

	[DataMember(Name = "Modules")]
	public List<Class16> list_0;

	[DataMember(Name = "Warnings")]
	public Class15 class15_0;

	[DataMember(Name = "Options")]
	public Class14 class14_0;

	[DataMember(Name = "LastUpdateCheck")]
	public DateTime dateTime_0;

	public static Class12 class12_0;

	internal const string string_1 = "settings.xml";

	public Class12()
	{
		list_0 = new List<Class16>();
		class14_0 = new Class14();
		class15_0 = new Class15();
	}

	static Class12()
	{
		class12_0 = smethod_0(Class178.smethod_0(102));
	}

	public static Class12 smethod_0(string string_2)
	{
		if (!File.Exists(string_2))
		{
			return new Class12();
		}
		try
		{
			DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(Class12));
			XmlReader xmlReader = XmlReader.Create(string_2);
			try
			{
				return (Class12)dataContractSerializer.ReadObject(xmlReader);
			}
			finally
			{
				if (xmlReader != null)
				{
					while (true)
					{
						IL_0070:
						int num = -844590711;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ -1275962435)) % 3)
							{
							case 2u:
								goto IL_0040;
							default:
								goto end_IL_0053;
							case 0u:
								break;
							case 1u:
								goto end_IL_0053;
							}
							goto IL_0070;
							IL_0040:
							((IDisposable)xmlReader).Dispose();
							num = ((int)num2 * -2052440757) ^ 0x4BA9C39C;
							continue;
							end_IL_0053:
							break;
						}
						break;
					}
				}
			}
		}
		catch (Exception)
		{
			return new Class12();
		}
	}

	public static void smethod_1()
	{
		DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(Class12));
		XmlWriter xmlWriter = XmlWriter.Create(Class178.smethod_0(102), new XmlWriterSettings
		{
			Indent = true
		});
		try
		{
			dataContractSerializer.WriteObject(xmlWriter, class12_0);
		}
		finally
		{
			if (xmlWriter != null)
			{
				while (true)
				{
					IL_006c:
					int num = -1437459050;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -853144699)) % 3)
						{
						case 2u:
							goto IL_003c;
						default:
							goto end_IL_004f;
						case 0u:
							break;
						case 1u:
							goto end_IL_004f;
						}
						goto IL_006c;
						IL_003c:
						((IDisposable)xmlWriter).Dispose();
						num = (int)((num2 * 951811176) ^ 0x18B17208);
						continue;
						end_IL_004f:
						break;
					}
					break;
				}
			}
		}
	}

	internal static bool smethod_2(string string_2)
	{
		return File.Exists(string_2);
	}

	internal static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static DataContractSerializer smethod_4(Type type_0)
	{
		return new DataContractSerializer(type_0);
	}

	internal static XmlReader smethod_5(string string_2)
	{
		return XmlReader.Create(string_2);
	}

	internal static object smethod_6(XmlObjectSerializer xmlObjectSerializer_0, XmlReader xmlReader_0)
	{
		return xmlObjectSerializer_0.ReadObject(xmlReader_0);
	}

	internal static void smethod_7(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static XmlWriterSettings smethod_8()
	{
		return new XmlWriterSettings();
	}

	internal static void smethod_9(XmlWriterSettings xmlWriterSettings_0, bool bool_0)
	{
		xmlWriterSettings_0.Indent = bool_0;
	}

	internal static XmlWriter smethod_10(string string_2, XmlWriterSettings xmlWriterSettings_0)
	{
		return XmlWriter.Create(string_2, xmlWriterSettings_0);
	}

	internal static void smethod_11(XmlObjectSerializer xmlObjectSerializer_0, XmlWriter xmlWriter_0, object object_0)
	{
		xmlObjectSerializer_0.WriteObject(xmlWriter_0, object_0);
	}
}
