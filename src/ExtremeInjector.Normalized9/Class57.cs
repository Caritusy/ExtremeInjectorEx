using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class Class57 : Class56
{
	public Class57()
		: base(Class49.struct20_0)
	{
		Struct12 struct12_ = default(Struct12);
		while (true)
		{
			int num = -263696107;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1564020306)) % 9)
				{
				case 8u:
					Class171.smethod_149(this, struct12_);
					num = ((int)num2 * -957850372) ^ 0x2718C23B;
					continue;
				case 6u:
					struct12_.byte_1 = 0;
					struct12_.uint_0 = Class49.uint_0;
					num = (int)(num2 * 1287595985) ^ -987886686;
					continue;
				case 5u:
					struct12_.bool_0 = false;
					num = ((int)num2 * -1523979909) ^ 0x4DA2CCC1;
					continue;
				case 4u:
					struct12_ = Class171.smethod_214(this);
					num = ((int)num2 * -391945684) ^ 0x6D16BAF0;
					continue;
				case 3u:
					struct12_.enum8_0 = Enum8.flag_3;
					num = ((int)num2 * -101404776) ^ 0x3165998E;
					continue;
				case 1u:
					struct12_.intptr_0 = IntPtr.Zero;
					num = (int)((num2 * 1922880765) ^ 0x7F548F69);
					continue;
				case 0u:
					struct12_.byte_0 = 0;
					num = (int)((num2 * 1244060327) ^ 0x50E933B5);
					continue;
				default:
					return;
				case 2u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public Class57(IntPtr intptr_0)
		: base(Class49.struct20_0)
	{
		Struct12 struct12_ = default(Struct12);
		while (true)
		{
			int num = -2113883184;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1942112433)) % 5)
				{
				case 3u:
					struct12_ = Class171.smethod_214(this);
					num = ((int)num2 * -548004930) ^ -1037678428;
					continue;
				case 1u:
					struct12_.intptr_0 = intptr_0;
					num = ((int)num2 * -730895266) ^ 0x65546231;
					continue;
				case 0u:
					struct12_.enum8_0 = Enum8.flag_3;
					struct12_.byte_0 = 0;
					struct12_.bool_0 = false;
					struct12_.byte_1 = 0;
					struct12_.uint_0 = Class49.uint_0;
					num = (int)(num2 * 1085506117) ^ -1523855477;
					continue;
				case 4u:
					break;
				default:
					Class171.smethod_149(this, struct12_);
					return;
				}
				break;
			}
		}
	}

	public Class57(IntPtr intptr_0, bool bool_0)
		: base(Class49.struct20_0)
	{
		Struct12 struct12_ = default(Struct12);
		while (true)
		{
			int num = 1059182004;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x602AFAAB)) % 5)
				{
				case 4u:
					struct12_ = Class171.smethod_214(this);
					struct12_.enum8_0 = Enum8.flag_3;
					num = ((int)num2 * -1846983884) ^ -446282228;
					continue;
				case 3u:
					struct12_.bool_0 = bool_0;
					struct12_.byte_1 = 0;
					struct12_.uint_0 = Class49.uint_0;
					num = ((int)num2 * -1015986850) ^ 0x6AC3980D;
					continue;
				case 1u:
					struct12_.byte_0 = 0;
					num = (int)((num2 * 767523404) ^ 0x30FCB908);
					continue;
				case 0u:
					break;
				default:
					struct12_.intptr_0 = intptr_0;
					Class171.smethod_149(this, struct12_);
					return;
				}
				break;
			}
		}
	}
}
