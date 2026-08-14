using System.IO;
using System.Runtime.CompilerServices;

public sealed class ClrHeader
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal ushort ushort_0;

	[CompilerGenerated]
	internal ushort ushort_1;

	[CompilerGenerated]
	internal DataDirectory class157_0;

	[CompilerGenerated]
	internal CorFlags enum35_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal DataDirectory class157_1;

	[CompilerGenerated]
	internal DataDirectory class157_2;

	[CompilerGenerated]
	internal DataDirectory class157_3;

	[CompilerGenerated]
	internal DataDirectory class157_4;

	[CompilerGenerated]
	internal DataDirectory class157_5;

	[CompilerGenerated]
	internal DataDirectory class157_6;

	[SpecialName]
	[CompilerGenerated]
	public uint method_0()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(uint uint_2)
	{
		uint_0 = uint_2;
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
	public void method_4(DataDirectory class157_7)
	{
		class157_0 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(CorFlags enum35_1)
	{
		enum35_0 = enum35_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_6(uint uint_2)
	{
		uint_1 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(DataDirectory class157_7)
	{
		class157_1 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_8(DataDirectory class157_7)
	{
		class157_2 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(DataDirectory class157_7)
	{
		class157_3 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_10(DataDirectory class157_7)
	{
		class157_4 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(DataDirectory class157_7)
	{
		class157_5 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_12(DataDirectory class157_7)
	{
		class157_6 = class157_7;
	}

	public ClrHeader()
	{
	}

	internal ClrHeader(BoundsCheckedBinaryReader class5_0)
	{
		this.method_1(class5_0.ReadUInt32());
		this.method_2(class5_0.ReadUInt16());
		this.method_3(class5_0.ReadUInt16());
		this.method_4(new DataDirectory(class5_0));
		this.method_5((CorFlags)class5_0.ReadUInt32());
		this.method_6(class5_0.ReadUInt32());
		this.method_7(new DataDirectory(class5_0));
		this.method_8(new DataDirectory(class5_0));
		this.method_9(new DataDirectory(class5_0));
		this.method_10(new DataDirectory(class5_0));
		this.method_11(new DataDirectory(class5_0));
		this.method_12(new DataDirectory(class5_0));
	}

	internal static uint smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static ushort smethod_1(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt16();
	}
}
