using System.IO;
using System.Runtime.CompilerServices;

public sealed class PeSectionHeader
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
	internal SectionCharacteristics enum41_0;

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
	public SectionCharacteristics method_18()
	{
		return enum41_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_19(SectionCharacteristics enum41_1)
	{
		enum41_0 = enum41_1;
	}

	public PeSectionHeader()
	{
	}

	public PeSectionHeader(BinaryReader binaryReader_0)
	{
		byte[] ienumerable_ = binaryReader_0.ReadBytes(8);
		this.method_1(RecoveredRuntime.smethod_186(ienumerable_));
		this.method_3(binaryReader_0.ReadUInt32());
		this.method_5(binaryReader_0.ReadUInt32());
		this.method_7(binaryReader_0.ReadUInt32());
		this.method_9(binaryReader_0.ReadUInt32());
		this.method_11(binaryReader_0.ReadUInt32());
		this.method_13(binaryReader_0.ReadUInt32());
		this.method_15(binaryReader_0.ReadUInt16());
		this.method_17(binaryReader_0.ReadUInt16());
		this.method_19((SectionCharacteristics)binaryReader_0.ReadUInt32());
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
