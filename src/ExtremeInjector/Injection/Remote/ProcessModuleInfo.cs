using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ProcessModuleInfo
{
	[CompilerGenerated]
	internal IntPtr intptr_0;

	[CompilerGenerated]
	internal IntPtr intptr_1;

	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	internal string string_1;

	[CompilerGenerated]
	internal bool bool_0;

	[CompilerGenerated]
	internal bool bool_1;

	internal List<ExportedSymbol> list_0;

	internal RemoteProcess gclass2_0;

	internal ProcessModuleCollection class69_0;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_0()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(IntPtr intptr_2)
	{
		intptr_0 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_2()
	{
		return intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(IntPtr intptr_2)
	{
		intptr_1 = intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_4()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_5(uint uint_1)
	{
		uint_0 = uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_6()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_7(string string_2)
	{
		string_0 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_8()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_9(string string_2)
	{
		string_1 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_10()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_11(bool bool_2)
	{
		bool_0 = bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_12()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_13(bool bool_2)
	{
		bool_1 = bool_2;
	}

	internal ProcessModuleInfo(RemoteProcess gclass2_1, ProcessModuleCollection class69_1, IntPtr intptr_2, bool bool_2)
		: this(gclass2_1, class69_1, intptr_2, bool_2, bool_3: false)
	{
	}

	internal ProcessModuleInfo(RemoteProcess gclass2_1, ProcessModuleCollection class69_1, IntPtr intptr_2, bool bool_2, bool bool_3)
	{
		method_1(intptr_2);
		method_11(bool_2);
		method_13(bool_3);
		gclass2_0 = gclass2_1;
		class69_0 = class69_1;
	}

	internal IntPtr method_14(object object_0, bool bool_2)
	{
		ushort num4 = 0;
		bool flag;
		if (!(flag = object_0 is ushort))
		{
			goto IL_003e;
		}
		int num = (ushort)object_0;
		goto IL_0089;
		IL_0272:
		int num3;
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num3 ^ 0x29D8FE6E)) % 5)
			{
			case 3u:
				num3 = ((RecoveredRuntime.smethod_131(this).Count == 0) ? (-1523013849) : (-1056748293)) ^ ((int)num2 * -393997819);
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0298;
			case 1u:
				return IntPtr.Zero;
			default:
				goto IL_02ab;
			}
			break;
		}
		goto IL_026d;
		IL_0089:
		num4 = (ushort)num;
		int num5 = 1263106335;
		goto IL_005e;
		IL_005e:
		string text = default(string);
		KeyValuePair<ProcessModuleInfo, List<ExportedSymbol>> current = default(KeyValuePair<ProcessModuleInfo, List<ExportedSymbol>>);
		while (true)
		{
			object obj;
			uint num2;
			switch ((num2 = (uint)(num5 ^ 0x29D8FE6E)) % 6)
			{
			case 5u:
				if (!(object_0 is string))
				{
					num5 = (int)(num2 * 1185089570) ^ -1766746252;
					continue;
				}
				obj = (string)object_0;
				goto IL_0033;
			case 4u:
				obj = null;
				goto IL_0033;
			case 3u:
				break;
			case 2u:
				goto IL_0045;
			case 1u:
				goto IL_0088;
			default:
				goto IL_0091;
				IL_0033:
				text = (string)obj;
				num5 = 609655576;
				continue;
			}
			break;
			IL_0091:
			using (Dictionary<ProcessModuleInfo, List<ExportedSymbol>>.Enumerator enumerator = gclass2_0.dictionary_0.GetEnumerator())
			{
				while (true)
				{
					IL_0200:
					int num6 = (enumerator.MoveNext() ? 1184961391 : 312291516);
					while (true)
					{
						switch ((num2 = (uint)(num6 ^ 0x29D8FE6E)) % 9)
						{
						case 8u:
							current = enumerator.Current;
							num6 = 1753717848;
							continue;
						case 7u:
							num6 = ((!(current.Key.method_6() == method_6())) ? (-1084369159) : (-358944230)) ^ (int)(num2 * 1081615982);
							continue;
						case 6u:
							num6 = ((!(current.Key.method_0() == method_0())) ? 1131681909 : 1047704741) ^ (int)(num2 * 1021130744);
							continue;
						case 5u:
							num6 = ((current.Key.method_2() == method_2()) ? (-1411027070) : (-362924499)) ^ ((int)num2 * -161813059);
							continue;
						case 2u:
							num6 = 1184961391;
							continue;
						case 0u:
							num6 = ((current.Key.method_4() == method_4()) ? (-1155803564) : (-290688995)) ^ ((int)num2 * -489113048);
							continue;
						default:
							goto end_IL_01ba;
						case 4u:
							break;
						case 1u:
							goto end_IL_01ba;
						case 3u:
							list_0 = current.Value;
							goto end_IL_01ba;
						}
						goto IL_0200;
						continue;
						end_IL_01ba:
						break;
					}
					break;
				}
			}
			goto IL_022d;
			IL_0045:
			if (list_0 == null)
			{
				num5 = (int)((num2 * 966298847) ^ 0x5CB55186);
				continue;
			}
			goto IL_022d;
		}
		goto IL_003e;
		IL_0088:
		num = 0;
		goto IL_0089;
		IL_026d:
		num3 = 739870297;
		goto IL_0272;
		IL_022d:
		if (list_0 == null)
		{
			goto IL_026d;
		}
		goto IL_0298;
		IL_003e:
		num5 = 627742407;
		goto IL_005e;
		IL_02ab:
		IntPtr result = default(IntPtr);
		using (List<ExportedSymbol>.Enumerator enumerator2 = list_0.GetEnumerator())
		{
			ExportedSymbol current2 = default(ExportedSymbol);
			ProcessModuleInfo gClass = default(ProcessModuleInfo);
			ProcessModuleCollection @class = default(ProcessModuleCollection);
			string value = default(string);
			while (true)
			{
				IL_06e8:
				int num7 = (enumerator2.MoveNext() ? 92444429 : 2083384949);
				while (true)
				{
					uint num2;
					IntPtr intPtr = IntPtr.Zero;
					switch ((num2 = (uint)(num7 ^ 0x29D8FE6E)) % 32)
					{
					case 31u:
						num7 = ((class69_0 == null) ? (-1507176011) : (-1722723288)) ^ (int)(num2 * 602898862);
						continue;
					case 29u:
						num7 = ((!RecoveredRuntime.smethod_85(current2)) ? 2077426171 : 1431325777);
						continue;
					case 28u:
						result = RecoveredRuntime.smethod_225(gClass, current2.method_8().method_6(), bool_0: false);
						num7 = 228034350;
						continue;
					case 26u:
						num7 = (current2.method_0() ? (-1904908271) : (-837855327)) ^ ((int)num2 * -1545081484);
						continue;
					case 25u:
						num7 = ((gClass != null) ? 374872585 : 1631205140) ^ ((int)num2 * -487925101);
						continue;
					case 23u:
						num7 = ((!(current2.method_4() != text)) ? (-817980784) : (-863804854)) ^ ((int)num2 * -1155092747);
						continue;
					case 22u:
						num7 = ((gClass != null) ? 390034045 : 457545636);
						continue;
					case 21u:
						result = method_0().smethod_9(current2.method_6());
						num7 = 1557692566;
						continue;
					case 20u:
						num7 = (bool_2 ? 672636714 : 1907061071) ^ (int)(num2 * 358468482);
						continue;
					case 19u:
						if (!current2.method_8().method_2())
						{
							num7 = 1486686256;
							continue;
						}
						intPtr = RecoveredRuntime.smethod_225(gClass, current2.method_8().method_6(), bool_0: false);
						goto IL_072a;
					case 18u:
						num7 = 92444429;
						continue;
					case 17u:
						gClass = RecoveredRuntime.smethod_231(this, current2.method_8().method_0());
						num7 = (int)((num2 * 468578661) ^ 0x488C7042);
						continue;
					case 16u:
						gClass = @class[current2.method_8().method_0()];
						num7 = ((gClass != null) ? 390034045 : 1846101893);
						continue;
					case 15u:
						num7 = (flag ? (-151122066) : (-1957113177)) ^ (int)(num2 * 495798467);
						continue;
					case 14u:
						num7 = (int)(num2 * 1682527254) ^ -73052406;
						continue;
					case 13u:
						num7 = ((current2.method_2() == num4) ? 1106376777 : 454755530) ^ ((int)num2 * -151563345);
						continue;
					case 12u:
						@class = class69_0;
						num7 = 907601150;
						continue;
					case 11u:
						num7 = ((current2.method_8().method_0().IndexOf("-ms", StringComparison.OrdinalIgnoreCase) != -1) ? 283128262 : 1173164818) ^ ((int)num2 * -414334873);
						continue;
					case 10u:
						result = IntPtr.Zero;
						num7 = (int)((num2 * 974885039) ^ 0x34EB287A);
						continue;
					case 9u:
						@class = RecoveredRuntime.smethod_42(gclass2_0);
						num7 = 924132928;
						continue;
					case 6u:
						gClass = @class[value];
						num7 = ((int)num2 * -1544337376) ^ -175341128;
						continue;
					case 5u:
						value = RecoveredRuntime.smethod_440(current2.method_8().method_0(), method_8(), null, DependencySearchFlags.flag_1, 0, IntPtr.Zero);
						num7 = (string.IsNullOrEmpty(value) ? 385089912 : 717977832);
						continue;
					case 4u:
						num7 = ((!flag) ? 1605896564 : 580626099);
						continue;
					case 3u:
						current2 = enumerator2.Current;
						num7 = 2057744321;
						continue;
					case 1u:
						result = IntPtr.Zero;
						num7 = ((int)num2 * -659989696) ^ -1579562234;
						continue;
					default:
						goto end_IL_0646;
					case 7u:
						break;
					case 27u:
						goto end_IL_0646;
					case 30u:
						intPtr = RecoveredRuntime.smethod_248(gClass, current2.method_8().method_4(), bool_0: false);
						goto IL_072a;
					case 0u:
					case 2u:
					case 8u:
					case 24u:
						goto IL_073c;
						IL_072a:
						result = intPtr;
						goto IL_073c;
					}
					goto IL_06e8;
					continue;
					end_IL_0646:
					break;
				}
				break;
			}
		}
		goto IL_073f;
		IL_073c:
		return result;
		IL_0298:
		if (list_0 != null)
		{
			num3 = 41780438;
			goto IL_0272;
		}
		goto IL_073f;
		IL_073f:
		return IntPtr.Zero;
	}

	internal static bool smethod_0(string string_2, string string_3)
	{
		return string_2 == string_3;
	}

	internal static bool smethod_1(string string_2, string string_3)
	{
		return string_2 != string_3;
	}

	internal static int smethod_2(string string_2, string string_3, StringComparison stringComparison_0)
	{
		return string_2.IndexOf(string_3, stringComparison_0);
	}

	internal static bool smethod_3(string string_2)
	{
		return string.IsNullOrEmpty(string_2);
	}
}
