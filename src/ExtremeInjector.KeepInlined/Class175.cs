using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

public sealed class Class175
{
	public struct Struct79
	{
		public string string_0 = string.Empty;

		public Version version_0 = null;

		public string string_1 = string.Empty;

		public string string_2 = string.Empty;

		public string method_0(bool bool_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string_0);
			if (bool_0)
			{
				goto IL_0019;
			}
			goto IL_00d3;
			IL_0019:
			int num = -1407974179;
			goto IL_00aa;
			IL_00aa:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1027399608)) % 6)
				{
				case 5u:
					break;
				case 3u:
					num = ((version_0 != null) ? (-1736204103) : (-950266078)) ^ ((int)num2 * -1083559574);
					continue;
				case 1u:
					stringBuilder.Append(global::_003CModule_003E.smethod_5<string>(2088884392u));
					stringBuilder.Append(version_0);
					num = ((int)num2 * -44155482) ^ -1697979422;
					continue;
				case 0u:
					stringBuilder.Append((string_1.Length == 0) ? global::_003CModule_003E.smethod_4<string>(4180971965u) : string_1);
					num = -40593040;
					continue;
				case 2u:
					goto IL_00d3;
				default:
					stringBuilder.Append(global::_003CModule_003E.smethod_2<string>(2500547674u));
					stringBuilder.Append((string_2.Length == 0) ? global::_003CModule_003E.smethod_6<string>(868523558u) : string_2);
					return stringBuilder.ToString();
				}
				break;
			}
			goto IL_0019;
			IL_00d3:
			stringBuilder.Append(global::_003CModule_003E.smethod_6<string>(3582041215u));
			num = -1709531986;
			goto IL_00aa;
		}

		public Struct79(string string_3)
		{
			string[] array = string_3.Split(',');
			foreach (string text in array)
			{
				string text2 = text.Trim();
				if (text2.StartsWith(global::_003CModule_003E.smethod_4<string>(892207196u)))
				{
					version_0 = new Version(text2.Substring(8));
				}
				else if (text2.StartsWith(global::_003CModule_003E.smethod_3<string>(1971849447u)))
				{
					string_1 = text2.Substring(8);
					if (string_1 == global::_003CModule_003E.smethod_3<string>(3198505089u))
					{
						string_1 = string.Empty;
					}
				}
				else if (text2.StartsWith(global::_003CModule_003E.smethod_3<string>(1226974768u)))
				{
					string_2 = text2.Substring(15);
					if (string_2 == global::_003CModule_003E.smethod_6<string>(868523558u))
					{
						string_2 = string.Empty;
					}
				}
				else
				{
					string_0 = text2;
				}
			}
		}

		internal static StringBuilder smethod_0()
		{
			return new StringBuilder();
		}

		internal static StringBuilder smethod_1(StringBuilder stringBuilder_0, string string_3)
		{
			return stringBuilder_0.Append(string_3);
		}

		internal static bool smethod_2(Version version_1, Version version_2)
		{
			return version_1 != version_2;
		}

		internal static StringBuilder smethod_3(StringBuilder stringBuilder_0, object object_0)
		{
			return stringBuilder_0.Append(object_0);
		}

		internal static int smethod_4(string string_3)
		{
			return string_3.Length;
		}

		internal static string smethod_5(object object_0)
		{
			return object_0.ToString();
		}

		internal static string[] smethod_6(string string_3, char[] char_0)
		{
			return string_3.Split(char_0);
		}

		internal static string smethod_7(string string_3)
		{
			return string_3.Trim();
		}

		internal static bool smethod_8(string string_3, string string_4)
		{
			return string_3.StartsWith(string_4);
		}

		internal static string smethod_9(string string_3, int int_0)
		{
			return string_3.Substring(int_0);
		}

		internal static Version smethod_10(string string_3)
		{
			return new Version(string_3);
		}

		internal static bool smethod_11(string string_3, string string_4)
		{
			return string_3 == string_4;
		}
	}

	internal const string string_0 = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	internal const int int_0 = 4;

	internal static Dictionary<string, Assembly> dictionary_0 = new Dictionary<string, Assembly>();

	internal static bool Boolean_0
	{
		get
		{
			try
			{
				string text = Process.GetCurrentProcess().MainModule.ModuleName.ToLower();
				bool result = default(bool);
				while (true)
				{
					IL_00ca:
					int num = 1594212398;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x1A7CFD23)) % 8)
						{
						case 5u:
							num = ((!(text == global::_003CModule_003E.smethod_6<string>(2162436899u))) ? 1833580387 : 1606128040) ^ ((int)num2 * -816973014);
							continue;
						case 3u:
							result = true;
							num = (int)((num2 * 1960835525) ^ 0x59A50F98);
							continue;
						case 2u:
							num = ((!(text == global::_003CModule_003E.smethod_3<string>(348880682u))) ? 1288425533 : 1924341784);
							continue;
						case 1u:
							result = true;
							num = ((int)num2 * -971330851) ^ -118081439;
							continue;
						default:
							goto end_IL_0099;
						case 0u:
							break;
						case 6u:
							goto end_IL_0099;
						case 4u:
						case 7u:
							return result;
						}
						goto IL_00ca;
						continue;
						end_IL_0099:
						break;
					}
					break;
				}
			}
			catch
			{
			}
			return false;
		}
	}

	internal static Process smethod_0()
	{
		return Process.GetCurrentProcess();
	}

	internal static ProcessModule smethod_1(Process process_0)
	{
		return process_0.MainModule;
	}

	internal static string smethod_2(ProcessModule processModule_0)
	{
		return processModule_0.ModuleName;
	}

	internal static string smethod_3(string string_1)
	{
		return string_1.ToLower();
	}

	internal static bool smethod_4(string string_1, string string_2)
	{
		return string_1 == string_2;
	}
}
