using System.IO;
using System.Runtime.CompilerServices;

public sealed class Class143
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal ushort ushort_0;

	[CompilerGenerated]
	internal ushort ushort_1;

	[CompilerGenerated]
	internal uint uint_2;

	[CompilerGenerated]
	internal uint uint_3;

	[CompilerGenerated]
	internal uint uint_4;

	[CompilerGenerated]
	internal ulong ulong_0;

	[CompilerGenerated]
	internal ulong ulong_1;

	[CompilerGenerated]
	internal ulong ulong_2;

	[CompilerGenerated]
	internal ulong ulong_3;

	[CompilerGenerated]
	internal ulong ulong_4;

	[CompilerGenerated]
	internal ulong ulong_5;

	[CompilerGenerated]
	internal uint uint_5;

	[CompilerGenerated]
	internal ushort ushort_2;

	[CompilerGenerated]
	internal ushort ushort_3;

	[CompilerGenerated]
	internal ulong ulong_6;

	[CompilerGenerated]
	internal ulong ulong_7;

	[CompilerGenerated]
	internal ulong ulong_8;

	[CompilerGenerated]
	internal ulong ulong_9;

	[SpecialName]
	[CompilerGenerated]
	public void method_0(uint uint_6)
	{
		uint_0 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(uint uint_6)
	{
		uint_1 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_2(ushort ushort_4)
	{
		ushort_0 = ushort_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(ushort ushort_4)
	{
		ushort_1 = ushort_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_4(uint uint_6)
	{
		uint_2 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(uint uint_6)
	{
		uint_3 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_6(uint uint_6)
	{
		uint_4 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(ulong ulong_10)
	{
		ulong_0 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_8(ulong ulong_10)
	{
		ulong_1 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(ulong ulong_10)
	{
		ulong_2 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_10(ulong ulong_10)
	{
		ulong_3 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(ulong ulong_10)
	{
		ulong_4 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_12(ulong ulong_10)
	{
		ulong_5 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_13(uint uint_6)
	{
		uint_5 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_14(ushort ushort_4)
	{
		ushort_2 = ushort_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_15(ushort ushort_4)
	{
		ushort_3 = ushort_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_16(ulong ulong_10)
	{
		ulong_6 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_17(ulong ulong_10)
	{
		ulong_7 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_18(ulong ulong_10)
	{
		ulong_8 = ulong_10;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_19(ulong ulong_10)
	{
		ulong_9 = ulong_10;
	}

	internal Class143(Class5 class5_0, Class154 class154_0)
	{
		method_0(smethod_0(class5_0));
		method_1(smethod_0(class5_0));
		method_2(smethod_1(class5_0));
		method_3(smethod_1(class5_0));
		method_4(smethod_0(class5_0));
		method_5(smethod_0(class5_0));
		method_6(smethod_0(class5_0));
		if (Class171.smethod_19(class154_0))
		{
			method_7(smethod_0(class5_0));
			method_8(smethod_0(class5_0));
			method_9(smethod_0(class5_0));
			method_10(smethod_0(class5_0));
			method_11(smethod_0(class5_0));
			method_13(smethod_0(class5_0));
			method_12(smethod_0(class5_0));
		}
		else
		{
			method_7(smethod_2(class5_0));
			method_8(smethod_2(class5_0));
			method_9(smethod_2(class5_0));
			method_10(smethod_2(class5_0));
			method_11(smethod_2(class5_0));
			method_12(smethod_2(class5_0));
			method_13(smethod_0(class5_0));
		}
		method_14(smethod_1(class5_0));
		method_15(smethod_1(class5_0));
		if (Class171.smethod_19(class154_0))
		{
			method_16(smethod_0(class5_0));
			method_17(smethod_0(class5_0));
			method_18(smethod_0(class5_0));
			method_19(smethod_0(class5_0));
		}
		else
		{
			method_16(smethod_2(class5_0));
			method_17(smethod_2(class5_0));
			method_18(smethod_2(class5_0));
			method_19(smethod_2(class5_0));
		}
	}

	internal static uint smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static ushort smethod_1(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt16();
	}

	internal static ulong smethod_2(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt64();
	}
}
