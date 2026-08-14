using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class GClass1
{
	[CompilerGenerated]
	private IntPtr intptr_0;

	[CompilerGenerated]
	private IntPtr intptr_1;

	[CompilerGenerated]
	private uint uint_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	internal List<Class152> list_0;

	internal GClass2 gclass2_0;

	private Class69 class69_0;

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
	private void method_11(bool bool_2)
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
	private void method_13(bool bool_2)
	{
		bool_1 = bool_2;
	}

	internal GClass1(GClass2 gclass2_1, Class69 class69_1, IntPtr intptr_2, bool bool_2)
		: this(gclass2_1, class69_1, intptr_2, bool_2, bool_3: false)
	{
	}

	internal GClass1(GClass2 gclass2_1, Class69 class69_1, IntPtr intptr_2, bool bool_2, bool bool_3)
	{
		method_1(intptr_2);
		method_11(bool_2);
		method_13(bool_3);
		gclass2_0 = gclass2_1;
		class69_0 = class69_1;
	}

	internal IntPtr method_14(object object_0, bool bool_2)
	{
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
			{
				int num4;
				int num5;
				if (Class171.smethod_130(this).Count != 0)
				{
					num4 = -1056748293;
					num5 = -1056748293;
				}
				else
				{
					num4 = -1523013849;
					num5 = -1523013849;
				}
				num3 = num4 ^ ((int)num2 * -393997819);
				continue;
			}
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
		ushort num6 = (ushort)num;
		int num7 = 1263106335;
		goto IL_005e;
		IL_005e:
		string text = default(string);
		KeyValuePair<GClass1, List<Class152>> current = default(KeyValuePair<GClass1, List<Class152>>);
		while (true)
		{
			object obj;
			uint num2;
			switch ((num2 = (uint)(num7 ^ 0x29D8FE6E)) % 6)
			{
			case 5u:
				if (!(object_0 is string))
				{
					num7 = (int)(num2 * 1185089570) ^ -1766746252;
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
				num7 = 609655576;
				continue;
			}
			break;
			IL_0091:
			using (Dictionary<GClass1, List<Class152>>.Enumerator enumerator = gclass2_0.dictionary_0.GetEnumerator())
			{
				while (true)
				{
					IL_0200:
					int num8;
					int num9;
					if (!enumerator.MoveNext())
					{
						num8 = 312291516;
						num9 = 312291516;
					}
					else
					{
						num8 = 1184961391;
						num9 = 1184961391;
					}
					while (true)
					{
						switch ((num2 = (uint)(num8 ^ 0x29D8FE6E)) % 9)
						{
						case 8u:
							current = enumerator.Current;
							num8 = 1753717848;
							continue;
						case 7u:
						{
							int num14;
							int num15;
							if (current.Key.method_6() == method_6())
							{
								num14 = -358944230;
								num15 = -358944230;
							}
							else
							{
								num14 = -1084369159;
								num15 = -1084369159;
							}
							num8 = num14 ^ (int)(num2 * 1081615982);
							continue;
						}
						case 6u:
						{
							int num12;
							int num13;
							if (current.Key.method_0() == method_0())
							{
								num12 = 1047704741;
								num13 = 1047704741;
							}
							else
							{
								num12 = 1131681909;
								num13 = 1131681909;
							}
							num8 = num12 ^ (int)(num2 * 1021130744);
							continue;
						}
						case 5u:
						{
							int num16;
							int num17;
							if (!(current.Key.method_2() == method_2()))
							{
								num16 = -362924499;
								num17 = -362924499;
							}
							else
							{
								num16 = -1411027070;
								num17 = -1411027070;
							}
							num8 = num16 ^ ((int)num2 * -161813059);
							continue;
						}
						case 2u:
							num8 = 1184961391;
							continue;
						case 0u:
						{
							int num10;
							int num11;
							if (current.Key.method_4() != method_4())
							{
								num10 = -290688995;
								num11 = -290688995;
							}
							else
							{
								num10 = -1155803564;
								num11 = -1155803564;
							}
							num8 = num10 ^ ((int)num2 * -489113048);
							continue;
						}
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
				num7 = (int)((num2 * 966298847) ^ 0x5CB55186);
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
		num7 = 627742407;
		goto IL_005e;
		IL_02ab:
		IntPtr result = default(IntPtr);
		using (List<Class152>.Enumerator enumerator2 = list_0.GetEnumerator())
		{
			Class152 current2 = default(Class152);
			GClass1 gClass = default(GClass1);
			Class69 @class = default(Class69);
			string value = default(string);
			while (true)
			{
				IL_06e8:
				int num18;
				int num19;
				if (!enumerator2.MoveNext())
				{
					num18 = 2083384949;
					num19 = 2083384949;
				}
				else
				{
					num18 = 92444429;
					num19 = 92444429;
				}
				while (true)
				{
					uint num2;
					IntPtr intPtr;
					switch ((num2 = (uint)(num18 ^ 0x29D8FE6E)) % 32)
					{
					case 31u:
					{
						int num27;
						int num28;
						if (class69_0 != null)
						{
							num27 = -1722723288;
							num28 = -1722723288;
						}
						else
						{
							num27 = -1507176011;
							num28 = -1507176011;
						}
						num18 = num27 ^ (int)(num2 * 602898862);
						continue;
					}
					case 29u:
					{
						int num39;
						if (Class171.smethod_85(current2))
						{
							num18 = 1431325777;
							num39 = 1431325777;
						}
						else
						{
							num18 = 2077426171;
							num39 = 2077426171;
						}
						continue;
					}
					case 28u:
						result = Class171.smethod_220(gClass, current2.method_8().method_6(), false);
						num18 = 228034350;
						continue;
					case 26u:
					{
						int num35;
						int num36;
						if (!current2.method_0())
						{
							num35 = -837855327;
							num36 = -837855327;
						}
						else
						{
							num35 = -1904908271;
							num36 = -1904908271;
						}
						num18 = num35 ^ ((int)num2 * -1545081484);
						continue;
					}
					case 25u:
					{
						int num22;
						int num23;
						if (gClass == null)
						{
							num22 = 1631205140;
							num23 = 1631205140;
						}
						else
						{
							num22 = 374872585;
							num23 = 374872585;
						}
						num18 = num22 ^ ((int)num2 * -487925101);
						continue;
					}
					case 23u:
					{
						int num29;
						int num30;
						if (current2.method_4() != text)
						{
							num29 = -863804854;
							num30 = -863804854;
						}
						else
						{
							num29 = -817980784;
							num30 = -817980784;
						}
						num18 = num29 ^ ((int)num2 * -1155092747);
						continue;
					}
					case 22u:
					{
						int num21;
						if (gClass == null)
						{
							num18 = 457545636;
							num21 = 457545636;
						}
						else
						{
							num18 = 390034045;
							num21 = 390034045;
						}
						continue;
					}
					case 21u:
						result = method_0().smethod_9(current2.method_6());
						num18 = 1557692566;
						continue;
					case 20u:
					{
						int num33;
						int num34;
						if (!bool_2)
						{
							num33 = 1907061071;
							num34 = 1907061071;
						}
						else
						{
							num33 = 672636714;
							num34 = 672636714;
						}
						num18 = num33 ^ (int)(num2 * 358468482);
						continue;
					}
					case 19u:
						if (!current2.method_8().method_2())
						{
							num18 = 1486686256;
							continue;
						}
						intPtr = Class171.smethod_220(gClass, current2.method_8().method_6(), false);
						goto IL_072a;
					case 18u:
						num18 = 92444429;
						continue;
					case 17u:
						gClass = Class171.smethod_225(this, current2.method_8().method_0());
						num18 = (int)((num2 * 468578661) ^ 0x488C7042);
						continue;
					case 16u:
					{
						gClass = @class[current2.method_8().method_0()];
						int num40;
						if (gClass == null)
						{
							num18 = 1846101893;
							num40 = 1846101893;
						}
						else
						{
							num18 = 390034045;
							num40 = 390034045;
						}
						continue;
					}
					case 15u:
					{
						int num37;
						int num38;
						if (!flag)
						{
							num37 = -1957113177;
							num38 = -1957113177;
						}
						else
						{
							num37 = -151122066;
							num38 = -151122066;
						}
						num18 = num37 ^ (int)(num2 * 495798467);
						continue;
					}
					case 14u:
						num18 = (int)(num2 * 1682527254) ^ -73052406;
						continue;
					case 13u:
					{
						int num31;
						int num32;
						if (current2.method_2() != num6)
						{
							num31 = 454755530;
							num32 = 454755530;
						}
						else
						{
							num31 = 1106376777;
							num32 = 1106376777;
						}
						num18 = num31 ^ ((int)num2 * -151563345);
						continue;
					}
					case 12u:
						@class = class69_0;
						num18 = 907601150;
						continue;
					case 11u:
					{
						int num25;
						int num26;
						if (current2.method_8().method_0().IndexOf(Class178.smethod_0(8498), StringComparison.OrdinalIgnoreCase) == -1)
						{
							num25 = 1173164818;
							num26 = 1173164818;
						}
						else
						{
							num25 = 283128262;
							num26 = 283128262;
						}
						num18 = num25 ^ ((int)num2 * -414334873);
						continue;
					}
					case 10u:
						result = IntPtr.Zero;
						num18 = (int)((num2 * 974885039) ^ 0x34EB287A);
						continue;
					case 9u:
						@class = Class171.smethod_42(gclass2_0);
						num18 = 924132928;
						continue;
					case 6u:
						gClass = @class[value];
						num18 = ((int)num2 * -1544337376) ^ -175341128;
						continue;
					case 5u:
					{
						value = Class171.smethod_431(current2.method_8().method_0(), method_8(), (string)null, Enum43.flag_1, 0, IntPtr.Zero);
						int num24;
						if (!string.IsNullOrEmpty(value))
						{
							num18 = 717977832;
							num24 = 717977832;
						}
						else
						{
							num18 = 385089912;
							num24 = 385089912;
						}
						continue;
					}
					case 4u:
					{
						int num20;
						if (flag)
						{
							num18 = 580626099;
							num20 = 580626099;
						}
						else
						{
							num18 = 1605896564;
							num20 = 1605896564;
						}
						continue;
					}
					case 3u:
						current2 = enumerator2.Current;
						num18 = 2057744321;
						continue;
					case 1u:
						result = IntPtr.Zero;
						num18 = ((int)num2 * -659989696) ^ -1579562234;
						continue;
					default:
						goto end_IL_0646;
					case 7u:
						break;
					case 27u:
						goto end_IL_0646;
					case 30u:
						intPtr = Class171.smethod_242(gClass, current2.method_8().method_4(), false);
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
}
