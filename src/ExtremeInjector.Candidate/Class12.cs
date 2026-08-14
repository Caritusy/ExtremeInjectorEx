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

	private const string string_1 = "settings.xml";

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
			uint num = 1711897949u;
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
						int num2 = -844590711;
						while (true)
						{
							uint num;
							switch ((num = (uint)(num2 ^ -1275962435)) % 3)
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
							num2 = ((int)num * -2052440757) ^ 0x4BA9C39C;
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
}
