using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class GClass3 : Class84
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class Class81
	{
		public static readonly Class81 _003C_003E9 = new Class81();

		public static Func<GClass5, bool> _003C_003E9__14_0;

		internal bool method_0(GClass5 gclass5_0)
		{
			return gclass5_0.method_0() == Class178.smethod_0(31201);
		}
	}

	[CompilerGenerated]
	private IntPtr intptr_1;

	[CompilerGenerated]
	private IntPtr intptr_2;

	[CompilerGenerated]
	private IntPtr intptr_3;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_24()
	{
		return intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_25(IntPtr intptr_4)
	{
		intptr_1 = intptr_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_26()
	{
		return intptr_2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_27(IntPtr intptr_4)
	{
		intptr_2 = intptr_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_28()
	{
		return intptr_3;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_29(IntPtr intptr_4)
	{
		intptr_3 = intptr_4;
	}

	internal GClass3(GClass2 gclass2_1)
		: base(gclass2_1)
	{
		method_8(gclass2_1.method_0());
		Class171.smethod_351(this);
	}

	void Class82._202A_202C_202E_200F_202C_206C_200C_202D_202A_206E_200F_200C_202D_202C_202B_200C_206B_200D_206C_206F_206E_206D_206F_200D_200E_206A_202A_202B_202B_206B_200C_202D_202E_206D_202E_206E_200C_202E_200E_202E()
	{
		if (!(method_2() == IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = 1041466125;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7274D933)) % 4)
				{
				case 2u:
				{
					int num3;
					int num4;
					if (method_0() != -1)
					{
						num3 = -1800098972;
						num4 = -1800098972;
					}
					else
					{
						num3 = -1449086150;
						num4 = -1449086150;
					}
					num = num3 ^ (int)(num2 * 1396636465);
					continue;
				}
				case 1u:
					method_3(Class171.OpenProcess(Class124.Enum32.flag_2 | Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5 | Class124.Enum32.flag_9, false, method_0()));
					num = (int)((num2 * 821799659) ^ 0x7CF78A27);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public bool method_30(IntPtr intptr_4, ulong ulong_0, out bool bool_2)
	{
		bool_2 = false;
		if (!(method_24() == IntPtr.Zero))
		{
			Class47 class2 = default(Class47);
			Class53 class4 = default(Class53);
			int num7 = default(int);
			Class113 @class = default(Class113);
			int num12 = default(int);
			IntPtr intPtr = default(IntPtr);
			Class112 class112_ = default(Class112);
			IntPtr intPtr2 = default(IntPtr);
			while (true)
			{
				int num = -1253173732;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1536618275)) % 39)
					{
					case 37u:
						Class171.smethod_54(class2, new Class57(method_24()), CallingConvention.StdCall, new object[2]
						{
							intptr_4,
							(IntPtr)(long)ulong_0
						});
						num = ((int)num2 * -1977353509) ^ 0x68F2559F;
						continue;
					case 36u:
						break;
					case 35u:
						Class171.smethod_114(class4);
						num = -1002844913;
						continue;
					case 34u:
						num7 = 0;
						num = -1976465236;
						continue;
					case 33u:
					{
						int num13;
						int num14;
						if (!(Class171.smethod_317(@class) != intptr_4))
						{
							num13 = 1975634092;
							num14 = 1975634092;
						}
						else
						{
							num13 = 2065742906;
							num14 = 2065742906;
						}
						num = num13 ^ ((int)num2 * -338035221);
						continue;
					}
					case 32u:
						num12 = 0;
						num = ((int)num2 * -53798391) ^ -2064830461;
						continue;
					case 31u:
						num12++;
						num = -1885765258;
						continue;
					case 30u:
					{
						int num5;
						int num6;
						if (method_26() == IntPtr.Zero)
						{
							num5 = 611755027;
							num6 = 611755027;
						}
						else
						{
							num5 = 1875342210;
							num6 = 1875342210;
						}
						num = num5 ^ ((int)num2 * -1722480434);
						continue;
					}
					case 29u:
						goto IL_0132;
					case 28u:
						goto IL_0159;
					case 27u:
						intPtr = method_21<IntPtr>(class2);
						num = ((int)num2 * -1698127742) ^ -585026187;
						continue;
					case 26u:
						num = (int)((num2 * 1477470472) ^ 0x6BC7E7C6);
						continue;
					case 25u:
						Class171.smethod_15(class2);
						num = ((int)num2 * -1472083154) ^ 0x5FB786B1;
						continue;
					case 21u:
						@class = Class171.smethod_164(class112_)[num7];
						num = -968140648;
						continue;
					case 20u:
					{
						int num10;
						int num11;
						if (intPtr2 == IntPtr.Zero)
						{
							num10 = 1025951114;
							num11 = 1025951114;
						}
						else
						{
							num10 = 1382047895;
							num11 = 1382047895;
						}
						num = num10 ^ ((int)num2 * -2074210728);
						continue;
					}
					case 19u:
						goto IL_0215;
					case 18u:
						class4 = new Class53();
						num = ((int)num2 * -366946505) ^ 0x517230E3;
						continue;
					case 17u:
						class112_ = new Class112(method_26(), method_2());
						num = -1999738795;
						continue;
					case 16u:
						class2.method_4<IntPtr>();
						num = ((int)num2 * -1714971097) ^ 0x589249A0;
						continue;
					case 15u:
					{
						int num8;
						int num9;
						if (!Class127.bool_6)
						{
							num8 = 197778975;
							num9 = 197778975;
						}
						else
						{
							num8 = 1653261054;
							num9 = 1653261054;
						}
						num = num8 ^ (int)(num2 * 1022871079);
						continue;
					}
					case 14u:
						goto IL_02b2;
					case 13u:
						Class171.smethod_15(class2);
						num = (int)(num2 * 288880045) ^ -208447066;
						continue;
					case 12u:
					{
						Class47 class3 = new Class47(class4, method_19());
						class3.method_1(bool_3: true);
						class2 = class3;
						num = ((int)num2 * -1933219988) ^ 0x33B91F8F;
						continue;
					}
					case 11u:
						Class171.smethod_221(class2, -1);
						num = (int)((num2 * 2009314897) ^ 0x66FB4A7B);
						continue;
					case 10u:
						num7++;
						num = -1976465236;
						continue;
					case 9u:
					{
						int num3;
						int num4;
						if (Class171.smethod_416(@class) != 0)
						{
							num3 = 2138464495;
							num4 = 2138464495;
						}
						else
						{
							num3 = 1656040522;
							num4 = 1656040522;
						}
						num = num3 ^ ((int)num2 * -1382153198);
						continue;
					}
					case 6u:
						Class171.smethod_54(class2, new Class57(method_24()), CallingConvention.StdCall, new object[3]
						{
							method_26(),
							intptr_4,
							(IntPtr)(long)ulong_0
						});
						num = -20460989;
						continue;
					case 3u:
						Class171.smethod_54(class2, new Class57(Class171.smethod_220(Class171.smethod_42(method_19())[Class178.smethod_0(8549)], Class178.smethod_0(8562), false)), CallingConvention.StdCall, new object[1] { intPtr2 });
						num = ((int)num2 * -31820644) ^ -1907882241;
						continue;
					case 2u:
						bool_2 = true;
						num = ((int)num2 * -11786787) ^ 0x1A72A60E;
						continue;
					case 1u:
						intPtr2 = Class171.smethod_174((Class82)this, 2048L, Class124.Enum34.flag_6);
						num = -613920069;
						continue;
					case 0u:
						Class171.smethod_54(class2, new Class57(method_24()), CallingConvention.FastCall, new object[2]
						{
							intptr_4,
							(IntPtr)(long)ulong_0
						});
						num = ((int)num2 * -1806849745) ^ 0x21542806;
						continue;
					case 7u:
						goto end_IL_0481;
					default:
						return false;
					case 5u:
						return false;
					case 8u:
					{
						vmethod_3(@class.method_17(), Class171.smethod_73(method_19()), Class124.Enum34.flag_2, out var enum34_);
						bool result = method_13(@class.method_17(), intPtr.ToInt32());
						vmethod_3(@class.method_17(), Class171.smethod_73(method_19()), enum34_, out enum34_);
						return result;
					}
					case 22u:
						return true;
					case 23u:
						return false;
					case 24u:
						return true;
					case 38u:
						goto end_IL_0530;
					}
					int num15;
					if (num7 < Class171.smethod_360(class112_))
					{
						num = -889292319;
						num15 = -889292319;
					}
					else
					{
						num = -420868134;
						num15 = -420868134;
					}
					continue;
					IL_02b2:
					int num16;
					if (!(Class171.smethod_317(Class171.smethod_164(class112_)[num12]) == intptr_4))
					{
						num = -715119863;
						num16 = -715119863;
					}
					else
					{
						num = -501275794;
						num16 = -501275794;
					}
					continue;
					IL_0159:
					Class171.smethod_221(class2, -1);
					int num17;
					if (Class171.smethod_233(class4, (Class84)this))
					{
						num = -1359804708;
						num17 = -1359804708;
					}
					else
					{
						num = -1827571932;
						num17 = -1827571932;
					}
					continue;
					IL_0132:
					int num18;
					if (num12 >= Class171.smethod_360(class112_))
					{
						num = -1801828098;
						num18 = -1801828098;
					}
					else
					{
						num = -468672563;
						num18 = -468672563;
					}
					continue;
					IL_0215:
					int num19;
					if (Class127.bool_5)
					{
						num = -710418295;
						num19 = -710418295;
					}
					else
					{
						num = -1163012768;
						num19 = -1163012768;
					}
					continue;
					end_IL_0481:
					break;
				}
				continue;
				end_IL_0530:
				break;
			}
		}
		return false;
	}
}
