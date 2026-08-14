using System.IO;
using System.Runtime.CompilerServices;

public sealed class DataDirectory
{
	[CompilerGenerated]
	internal uint virtualAddress;

	[CompilerGenerated]
	internal uint size;

	[SpecialName]
	[CompilerGenerated]
	public uint GetVirtualAddress()
	{
		return virtualAddress;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetVirtualAddress(uint uintValue)
	{
		virtualAddress = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSize()
	{
		return size;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSize(uint uintValue)
	{
		size = uintValue;
	}

	public DataDirectory()
	{
	}

	public DataDirectory(BinaryReader binaryReader)
	{
		this.SetVirtualAddress(binaryReader.ReadUInt32());
		this.SetSize(binaryReader.ReadUInt32());
	}
}
