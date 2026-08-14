using System.Runtime.CompilerServices;

public sealed class Class147
{
	[CompilerGenerated]
	private uint uint_0;

	[CompilerGenerated]
	private uint uint_1;

	[CompilerGenerated]
	private ushort ushort_0;

	[CompilerGenerated]
	private ushort ushort_1;

	[CompilerGenerated]
	private Enum37 enum37_0;

	[CompilerGenerated]
	private uint uint_2;

	[CompilerGenerated]
	private uint uint_3;

	[CompilerGenerated]
	private uint uint_4;

	[SpecialName]
	[CompilerGenerated]
	public void method_0(uint uint_5)
	{
		uint_0 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(uint uint_5)
	{
		uint_1 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_2(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_4(Enum37 enum37_1)
	{
		enum37_0 = enum37_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_5()
	{
		return uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_6(uint uint_5)
	{
		uint_2 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_7()
	{
		return uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_8(uint uint_5)
	{
		uint_3 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_9()
	{
		return uint_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_10(uint uint_5)
	{
		uint_4 = uint_5;
	}

	protected Class147()
	{
	}

	internal Class147(Class5 class5_0)
	{
		method_0(class5_0.ReadUInt32());
		method_1(class5_0.ReadUInt32());
		method_2(class5_0.ReadUInt16());
		method_3(class5_0.ReadUInt16());
		method_4((Enum37)class5_0.ReadUInt32());
		method_6(class5_0.ReadUInt32());
		method_8(class5_0.ReadUInt32());
		method_10(class5_0.ReadUInt32());
	}
}
