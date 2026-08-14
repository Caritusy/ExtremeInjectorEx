using System.IO;
using System.Runtime.CompilerServices;

public sealed class GClass5
{
	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal uint uint_2;

	[CompilerGenerated]
	internal uint uint_3;

	[CompilerGenerated]
	internal uint uint_4;

	[CompilerGenerated]
	internal uint uint_5;

	[CompilerGenerated]
	internal ushort ushort_0;

	[CompilerGenerated]
	internal ushort ushort_1;

	[CompilerGenerated]
	internal Enum41 enum41_0;

	[SpecialName]
	[CompilerGenerated]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_2()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(uint uint_6)
	{
		uint_0 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_4()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(uint uint_6)
	{
		uint_1 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_6()
	{
		return uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(uint uint_6)
	{
		uint_2 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_8()
	{
		return uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(uint uint_6)
	{
		uint_3 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_10()
	{
		return uint_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(uint uint_6)
	{
		uint_4 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_12()
	{
		return uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_13(uint uint_6)
	{
		uint_5 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort method_14()
	{
		return ushort_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_15(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort method_16()
	{
		return ushort_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_17(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Enum41 method_18()
	{
		return enum41_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_19(Enum41 enum41_1)
	{
		enum41_0 = enum41_1;
	}

	public GClass5()
	{
	}

	public GClass5(BinaryReader binaryReader_0)
	{
		byte[] ienumerable_ = default(byte[]);
		while (true)
		{
			int num = 1949148112;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x29A665CE)) % 9)
				{
				case 8u:
					method_15(smethod_2(binaryReader_0));
					num = (int)((num2 * 358457584) ^ 0x4C1497FC);
					continue;
				case 7u:
					ienumerable_ = smethod_0(binaryReader_0, 8);
					num = (int)((num2 * 1539616028) ^ 0x562D65A6);
					continue;
				case 6u:
					method_7(smethod_1(binaryReader_0));
					method_9(smethod_1(binaryReader_0));
					method_11(smethod_1(binaryReader_0));
					num = ((int)num2 * -481452740) ^ 0x1BE43287;
					continue;
				case 4u:
					method_1(Class171.smethod_186(ienumerable_));
					num = ((int)num2 * -1383373167) ^ 0x4DA1823;
					continue;
				case 3u:
					method_13(smethod_1(binaryReader_0));
					num = ((int)num2 * -1962298138) ^ -94192800;
					continue;
				case 2u:
					method_17(smethod_2(binaryReader_0));
					method_19((Enum41)smethod_1(binaryReader_0));
					num = ((int)num2 * -1858070482) ^ 0x70D29774;
					continue;
				case 1u:
					method_3(smethod_1(binaryReader_0));
					method_5(smethod_1(binaryReader_0));
					num = (int)((num2 * 614120263) ^ 0x7291A21E);
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	internal static byte[] smethod_0(BinaryReader binaryReader_0, int int_0)
	{
		return binaryReader_0.ReadBytes(int_0);
	}

	internal static uint smethod_1(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static ushort smethod_2(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt16();
	}
}
