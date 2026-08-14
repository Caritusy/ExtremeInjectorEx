using System.IO;
using System.Runtime.CompilerServices;

public sealed class DataDirectory
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

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
	public uint method_2()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(uint uint_2)
	{
		uint_1 = uint_2;
	}

	public DataDirectory()
	{
	}

	public DataDirectory(BinaryReader binaryReader_0)
	{
		this.method_1(binaryReader_0.ReadUInt32());
		this.method_3(binaryReader_0.ReadUInt32());
	}

	internal static uint smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}
}
