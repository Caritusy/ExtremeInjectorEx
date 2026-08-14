using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public sealed class Class88 : Class85
{
	public Class88(GClass2 gclass2_1)
		: base(gclass2_1)
	{
	}

	protected override void method_033E()
	{
		if (!(method_2() == IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = -636814761;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -870730958)) % 4)
				{
				case 3u:
					method_3(Class171.OpenProcess(Class124.Enum32.flag_2 | Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5 | Class124.Enum32.flag_9, false, method_0()));
					num = ((int)num2 * -362496391) ^ 0x3E67C4A1;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (method_0() != -1)
					{
						num3 = -765609239;
						num4 = -765609239;
					}
					else
					{
						num3 = -1014316990;
						num4 = -1014316990;
					}
					num = num3 ^ ((int)num2 * -969984944);
					continue;
				}
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public IntPtr method_0843(string string_0)
	{
		if (!Path.IsPathRooted(string_0))
		{
			goto IL_019a;
		}
		goto IL_02b3;
		IL_019a:
		int num = -185679819;
		goto IL_0231;
		IL_0231:
		uint num3 = default(uint);
		IntPtr intptr_ = default(IntPtr);
		int int_2 = default(int);
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		int int_ = default(int);
		while (true)
		{
			uint num2;
			IntPtr result;
			switch ((num2 = (uint)(num ^ -119094441)) % 24)
			{
			case 23u:
			{
				int num10;
				int num11;
				if (num3 != 0)
				{
					num10 = -1689135577;
					num11 = -1689135577;
				}
				else
				{
					num10 = -1856562310;
					num11 = -1856562310;
				}
				num = num10 ^ ((int)num2 * -770282315);
				continue;
			}
			case 22u:
				num3 = method_11<uint>(intptr_.smethod_8(int_2));
				num = -1199822064;
				continue;
			case 21u:
				break;
			case 20u:
				intPtr = Class171.smethod_315((Class83)this, intptr_, IntPtr.Zero);
				num = (int)(num2 * 1880844593) ^ -102391197;
				continue;
			case 18u:
				Class171.smethod_152((Class83)this, intPtr, -1);
				num = -1569625463;
				continue;
			case 17u:
				vmethod_6(intptr_);
				num = (int)(num2 * 1198042357) ^ -2129308134;
				continue;
			case 14u:
			{
				int num6;
				int num7;
				if (!Class171.smethod_296(method_19()))
				{
					num6 = 102433601;
					num7 = 102433601;
				}
				else
				{
					num6 = 1085827942;
					num7 = 1085827942;
				}
				num = num6 ^ (int)(num2 * 124969340);
				continue;
			}
			case 10u:
				string_0 = Path.GetFullPath(string_0);
				num = ((int)num2 * -953850148) ^ -712748468;
				continue;
			case 8u:
				goto IL_012e;
			case 7u:
				intptr_ = method_24(intPtr2, string_0, out int_, out int_2);
				num = -2017058477;
				continue;
			case 6u:
				if (!Class171.smethod_418(method_19()))
				{
					num = -1707199549;
					continue;
				}
				result = (IntPtr)method_11<uint>(intptr_.smethod_8(int_));
				goto IL_038f;
			case 5u:
				goto end_IL_0231;
			case 3u:
				vmethod_6(intptr_);
				num = ((int)num2 * -1103678123) ^ -1774238953;
				continue;
			case 2u:
			{
				int num8;
				int num9;
				if (intPtr2 == IntPtr.Zero)
				{
					num8 = 1344991690;
					num9 = 1344991690;
				}
				else
				{
					num8 = 1130850252;
					num9 = 1130850252;
				}
				num = num8 ^ ((int)num2 * -1585432438);
				continue;
			}
			case 1u:
				vmethod_6(intptr_);
				num = ((int)num2 * -1145143255) ^ 0x1976ADEA;
				continue;
			case 0u:
			{
				int num4;
				int num5;
				if (!(intPtr == IntPtr.Zero))
				{
					num4 = 762929957;
					num5 = 762929957;
				}
				else
				{
					num4 = 744132606;
					num5 = 744132606;
				}
				num = num4 ^ (int)(num2 * 1470387291);
				continue;
			}
			case 11u:
				goto IL_02b3;
			case 4u:
				throw new AccessViolationException(Class178.smethod_0(12914));
			case 9u:
				throw new MissingMethodException(Class178.smethod_0(28237));
			default:
				result = method_11<IntPtr>(intptr_.smethod_8(int_));
				goto IL_038f;
			case 13u:
				throw new UnauthorizedAccessException(Class178.smethod_0(12662));
			case 15u:
				throw new Exception(Class178.smethod_0(28411) + num3.ToString(Class178.smethod_0(28492)) + Class178.smethod_0(3656), Class171.smethod_208(num3, (Class84)this));
			case 16u:
				throw new Exception(Class178.smethod_0(28330));
			case 19u:
				{
					throw new FileNotFoundException(Class178.smethod_0(28151) + string_0 + Class178.smethod_0(3656));
				}
				IL_038f:
				vmethod_6(intptr_);
				Class171.smethod_108((Class83)this, intPtr);
				return result;
			}
			int num12;
			if (!method_8(method_19().method_0()))
			{
				num = -211511902;
				num12 = -211511902;
			}
			else
			{
				num = -1661214097;
				num12 = -1661214097;
			}
			continue;
			IL_012e:
			intPtr2 = Class171.smethod_220(Class171.smethod_42(method_19())[Class178.smethod_0(8549)] ?? throw new FileNotFoundException(Class178.smethod_0(12731)), Class178.smethod_0(28220), false);
			num = -2108430739;
			continue;
			end_IL_0231:
			break;
		}
		goto IL_019a;
		IL_02b3:
		int num13;
		if (!File.Exists(string_0))
		{
			num = -1843062060;
			num13 = -1843062060;
		}
		else
		{
			num = -181323686;
			num13 = -181323686;
		}
		goto IL_0231;
	}

	private IntPtr method_24(IntPtr intptr_1, string string_0, out int int_1, out int int_2)
	{
		IntPtr intPtr = Class171.smethod_174((Class82)this, 4096L, Class124.Enum34.flag_2);
		Class53 class2 = default(Class53);
		Class58 class58_ = default(Class58);
		Class47 class47_ = default(Class47);
		Class58 class58_3 = default(Class58);
		IntPtr intPtr2 = default(IntPtr);
		byte[] bytes = default(byte[]);
		Class58 class58_2 = default(Class58);
		while (true)
		{
			int num = 497055350;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6FBC7D6C)) % 25)
				{
				case 24u:
				{
					int num5;
					int num6;
					if (intPtr == IntPtr.Zero)
					{
						num5 = -1108040765;
						num6 = -1108040765;
					}
					else
					{
						num5 = -1625527655;
						num6 = -1625527655;
					}
					num = num5 ^ ((int)num2 * -1890512416);
					continue;
				}
				case 23u:
					Class171.smethod_36(class2, class58_);
					int_1 = Class171.smethod_246(class2);
					Class171.smethod_330(class47_);
					num = (int)((num2 * 1125448434) ^ 0x264039BF);
					continue;
				case 21u:
					class2 = new Class53();
					num = 355439472;
					continue;
				case 19u:
					Class171.smethod_75(class2, Class171.smethod_125(class58_3, 0L), Class49.class63_37);
					Class171.smethod_221(class47_, -1);
					num = 1129210671;
					continue;
				case 18u:
				{
					Class171.smethod_280(class47_, intPtr2);
					int num7;
					int num8;
					if (!(Class171.smethod_434(intPtr, class2, (Class84)this) == IntPtr.Zero))
					{
						num7 = 113368551;
						num8 = 113368551;
					}
					else
					{
						num7 = 1549379627;
						num8 = 1549379627;
					}
					num = num7 ^ ((int)num2 * -253945004);
					continue;
				}
				case 17u:
				{
					int num3;
					int num4;
					if (!Class171.smethod_418(method_19()))
					{
						num3 = 2023462491;
						num4 = 2023462491;
					}
					else
					{
						num3 = 1506205645;
						num4 = 1506205645;
					}
					num = num3 ^ ((int)num2 * -904323616);
					continue;
				}
				case 16u:
					Class171.smethod_36(class2, class58_3);
					num = ((int)num2 * -1534065286) ^ 0x31737CB2;
					continue;
				case 15u:
					Class171.smethod_52(class2, (ushort)bytes.Length);
					num = ((int)num2 * -767565473) ^ 0x18F5271E;
					continue;
				case 14u:
					vmethod_6(intPtr);
					num = ((int)num2 * -1775784928) ^ 0x26C1C57A;
					continue;
				case 13u:
					Class171.smethod_222(class47_);
					num = ((int)num2 * -541602821) ^ 0x45559B13;
					continue;
				case 12u:
					int_2 = Class171.smethod_246(class2);
					num = ((int)num2 * -853169748) ^ 0xB8B624A;
					continue;
				case 11u:
					Class171.smethod_52(class2, (ushort)(bytes.Length - 2));
					num = ((int)num2 * -1297069880) ^ 0x434BC59;
					continue;
				case 10u:
					Class171.smethod_222(class47_);
					num = ((int)num2 * -894258435) ^ 0x6B72AE95;
					continue;
				case 9u:
					Class171.smethod_15(class47_);
					Class171.smethod_54(class47_, new Class57(intptr_1), CallingConvention.StdCall, new object[4]
					{
						IntPtr.Zero,
						IntPtr.Zero,
						Class171.smethod_84(class47_, class58_2),
						Class171.smethod_84(class47_, class58_)
					});
					num = ((int)num2 * -930141647) ^ -1557209848;
					continue;
				case 7u:
					intPtr2 = intPtr.smethod_8(Class171.smethod_246(class2));
					num = ((int)num2 * -1036468219) ^ -834445518;
					continue;
				case 6u:
					class2.struct19_0.uint_2 |= 8u;
					num = (int)((num2 * 1336089541) ^ 0x65CF513E);
					continue;
				case 5u:
					Class171.smethod_222(class47_);
					num = ((int)num2 * -121576457) ^ -1385631303;
					continue;
				case 4u:
					Class171.smethod_222(class47_);
					num = (int)((num2 * 788831748) ^ 0x229502BD);
					continue;
				case 2u:
					Class171.smethod_430(class2, 0u);
					num = ((int)num2 * -803668432) ^ -1627327960;
					continue;
				case 1u:
					bytes = Encoding.Unicode.GetBytes(string_0 + Class178.smethod_0(12219));
					Class171.smethod_314(class2, bytes);
					Class171.smethod_222(class47_);
					Class171.smethod_36(class2, class58_2);
					num = (int)((num2 * 1918289043) ^ 0x1E159193);
					continue;
				case 0u:
				{
					Class47 @class = new Class47(class2, method_19());
					@class.method_1(bool_3: true);
					class47_ = @class;
					class58_ = Class171.smethod_48(class2);
					class58_2 = Class171.smethod_48(class2);
					class58_3 = Class171.smethod_48(class2);
					num = (int)((num2 * 381572352) ^ 0xC660C52);
					continue;
				}
				case 3u:
					break;
				case 8u:
					throw new AccessViolationException(Class178.smethod_0(28957));
				case 22u:
					throw new InvalidOperationException(Class178.smethod_0(28571));
				default:
					return intPtr;
				}
				break;
			}
		}
	}
}
