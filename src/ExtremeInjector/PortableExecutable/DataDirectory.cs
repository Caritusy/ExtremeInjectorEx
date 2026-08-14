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
	public uint GetVirtualAddress()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetVirtualAddress(uint uint_2)
	{
		uint_0 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSize()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSize(uint uint_2)
	{
		uint_1 = uint_2;
	}

	public DataDirectory()
	{
	}

	public DataDirectory(BinaryReader binaryReader_0)
	{
		this.SetVirtualAddress(binaryReader_0.ReadUInt32());
		this.SetSize(binaryReader_0.ReadUInt32());
	}
}
