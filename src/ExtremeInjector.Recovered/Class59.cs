using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class Class59 : Class56
{
	public Class59()
		: base(Class49.struct20_0)
	{
		Struct11 struct11_ = default(Struct11);
		while (true)
		{
			int num = 1171848956;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xAD832E7)) % 12)
				{
				case 9u:
					struct11_.byte_0 = 0;
					num = ((int)num2 * -105150427) ^ -700943170;
					continue;
				case 8u:
					struct11_.intptr_0 = IntPtr.Zero;
					struct11_.intptr_1 = IntPtr.Zero;
					num = ((int)num2 * -1533920726) ^ -596124812;
					continue;
				case 7u:
					struct11_ = Class171.smethod_380((Class56)this);
					num = (int)(num2 * 463185167) ^ -1810959236;
					continue;
				case 6u:
					struct11_.enum8_0 = Enum8.flag_2;
					num = ((int)num2 * -535145181) ^ 0x1AC4EFEC;
					continue;
				case 5u:
					struct11_.uint_2 = Class49.uint_0;
					num = (int)(num2 * 1371817034) ^ -1737726263;
					continue;
				case 4u:
					struct11_.uint_0 = Class49.uint_0;
					num = (int)((num2 * 17940802) ^ 0x35EA638E);
					continue;
				case 3u:
					Class171.smethod_423(struct11_, (Class56)this);
					num = ((int)num2 * -918814844) ^ 0x5D23930D;
					continue;
				case 2u:
					struct11_.method_0(bool_0: false);
					struct11_.method_1(0);
					num = ((int)num2 * -816505076) ^ -627572693;
					continue;
				case 1u:
					struct11_.uint_1 = Class49.uint_0;
					num = (int)(num2 * 146964207) ^ -2111524331;
					continue;
				case 0u:
					struct11_.enum9_0 = Enum9.const_0;
					num = (int)((num2 * 572785893) ^ 0x767CF62D);
					continue;
				default:
					return;
				case 11u:
					break;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	public bool method_02BA(object obj)
	{
		Class59 @class = obj as Class59;
		Struct7 @struct = default(Struct7);
		Struct7 struct2 = default(Struct7);
		while (true)
		{
			int num = 887827450;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x129501F3)) % 11)
				{
				case 10u:
				{
					int num9;
					int num10;
					if (!(@struct.intptr_0[0] == struct2.intptr_0[0]))
					{
						num9 = 1561415149;
						num10 = 1561415149;
					}
					else
					{
						num9 = 104769761;
						num10 = 104769761;
					}
					num = num9 ^ ((int)num2 * -1244592466);
					continue;
				}
				case 8u:
				{
					int num7;
					int num8;
					if (@struct.uint_0[1] != struct2.uint_0[1])
					{
						num7 = -360179468;
						num8 = -360179468;
					}
					else
					{
						num7 = -1603902715;
						num8 = -1603902715;
					}
					num = num7 ^ (int)(num2 * 1000774927);
					continue;
				}
				case 7u:
				{
					int num13;
					int num14;
					if (Class171.smethod_313(@class, (Class59)null))
					{
						num13 = -1306826328;
						num14 = -1306826328;
					}
					else
					{
						num13 = -1106260864;
						num14 = -1106260864;
					}
					num = num13 ^ (int)(num2 * 40917377);
					continue;
				}
				case 5u:
					@struct = method_0();
					num = 260533538;
					continue;
				case 4u:
				{
					struct2 = @class.method_0();
					int num5;
					int num6;
					if (@struct.uint_0[0] != struct2.uint_0[0])
					{
						num5 = 588105506;
						num6 = 588105506;
					}
					else
					{
						num5 = 1746314219;
						num6 = 1746314219;
					}
					num = num5 ^ ((int)num2 * -20905403);
					continue;
				}
				case 3u:
				{
					int num11;
					int num12;
					if (@struct.uint_0[2] != struct2.uint_0[2])
					{
						num11 = 1499761560;
						num12 = 1499761560;
					}
					else
					{
						num11 = 2124719847;
						num12 = 2124719847;
					}
					num = num11 ^ ((int)num2 * -1642482605);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (@struct.uint_0[3] != struct2.uint_0[3])
					{
						num3 = 1586584450;
						num4 = 1586584450;
					}
					else
					{
						num3 = 2047779837;
						num4 = 2047779837;
					}
					num = num3 ^ ((int)num2 * -1126959153);
					continue;
				}
				case 9u:
					break;
				case 0u:
					return false;
				case 2u:
					return @struct.intptr_0[1] == struct2.intptr_0[1];
				default:
					return false;
				}
				break;
			}
		}
	}

	public int method_02BB()
	{
		Struct7 @struct = method_0();
		return ((int)((((@struct.uint_0[0] * 397 + @struct.uint_0[1]) * 397 + @struct.uint_0[2]) * 397 + @struct.uint_0[3]) * 397) + (int)@struct.intptr_0[0]) * 397 + (int)@struct.intptr_0[1];
	}
}
