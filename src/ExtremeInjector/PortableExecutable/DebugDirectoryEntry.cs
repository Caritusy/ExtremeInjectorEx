using System.IO;
using System.Runtime.CompilerServices;

public sealed class DebugDirectoryEntry
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
	internal DebugDirectoryType enum37_0;

	[CompilerGenerated]
	internal uint uint_2;

	[CompilerGenerated]
	internal uint uint_3;

	[CompilerGenerated]
	internal uint uint_4;

	[SpecialName]
	[CompilerGenerated]
	public void SetCharacteristics(uint uint_5)
	{
		uint_0 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetTimeDateStamp(uint uint_5)
	{
		uint_1 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorVersion(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorVersion(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetType(DebugDirectoryType enum37_1)
	{
		enum37_0 = enum37_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfData()
	{
		return uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfData(uint uint_5)
	{
		uint_2 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressOfRawData()
	{
		return uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfRawData(uint uint_5)
	{
		uint_3 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetPointerToRawData()
	{
		return uint_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPointerToRawData(uint uint_5)
	{
		uint_4 = uint_5;
	}

	protected DebugDirectoryEntry()
	{
	}

	internal DebugDirectoryEntry(BoundsCheckedBinaryReader class5_0)
	{
		SetCharacteristics(class5_0.ReadUInt32());
		SetTimeDateStamp(class5_0.ReadUInt32());
		SetMajorVersion(class5_0.ReadUInt16());
		SetMinorVersion(class5_0.ReadUInt16());
		SetType((DebugDirectoryType)class5_0.ReadUInt32());
		SetSizeOfData(class5_0.ReadUInt32());
		SetAddressOfRawData(class5_0.ReadUInt32());
		SetPointerToRawData(class5_0.ReadUInt32());
	}
}
