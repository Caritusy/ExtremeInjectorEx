using System.IO;
using System.Runtime.CompilerServices;

public sealed class CoffHeader
{
	[CompilerGenerated]
	internal MachineType enum40_0;

	[CompilerGenerated]
	internal ushort ushort_0;

	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal uint uint_2;

	[CompilerGenerated]
	internal ushort ushort_1;

	[CompilerGenerated]
	internal CoffCharacteristics enum36_0;

	[SpecialName]
	[CompilerGenerated]
	public MachineType method_0()
	{
		return enum40_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(MachineType enum40_1)
	{
		enum40_0 = enum40_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort method_2()
	{
		return ushort_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_4()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(uint uint_3)
	{
		uint_0 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_6()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(uint uint_3)
	{
		uint_1 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_8()
	{
		return uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(uint uint_3)
	{
		uint_2 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort method_10()
	{
		return ushort_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public CoffCharacteristics method_12()
	{
		return enum36_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_13(CoffCharacteristics enum36_1)
	{
		enum36_0 = enum36_1;
	}

	public CoffHeader()
	{
	}

	public CoffHeader(BinaryReader binaryReader_0)
	{
		this.method_1((MachineType)binaryReader_0.ReadUInt16());
		this.method_3(binaryReader_0.ReadUInt16());
		this.method_5(binaryReader_0.ReadUInt32());
		this.method_7(binaryReader_0.ReadUInt32());
		this.method_9(binaryReader_0.ReadUInt32());
		this.method_11(binaryReader_0.ReadUInt16());
		this.method_13((CoffCharacteristics)binaryReader_0.ReadUInt16());
	}

	internal static ushort smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt16();
	}

	internal static uint smethod_1(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}
}
