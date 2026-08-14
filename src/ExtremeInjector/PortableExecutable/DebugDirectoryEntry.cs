using System.IO;
using System.Runtime.CompilerServices;

public sealed class DebugDirectoryEntry
{
	[CompilerGenerated]
	internal uint characteristics;

	[CompilerGenerated]
	internal uint timeDateStamp;

	[CompilerGenerated]
	internal ushort majorVersion;

	[CompilerGenerated]
	internal ushort minorVersion;

	[CompilerGenerated]
	internal DebugDirectoryType typeValue;

	[CompilerGenerated]
	internal uint sizeOfData;

	[CompilerGenerated]
	internal uint addressOfRawData;

	[CompilerGenerated]
	internal uint pointerToRawData;

	[SpecialName]
	[CompilerGenerated]
	public void SetCharacteristics(uint uintValue)
	{
		characteristics = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetTimeDateStamp(uint uintValue)
	{
		timeDateStamp = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMajorVersion(ushort ushortValue)
	{
		majorVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMinorVersion(ushort ushortValue)
	{
		minorVersion = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetType(DebugDirectoryType debugDirectoryType)
	{
		typeValue = debugDirectoryType;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfData()
	{
		return sizeOfData;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfData(uint uintValue)
	{
		sizeOfData = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressOfRawData()
	{
		return addressOfRawData;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressOfRawData(uint uintValue)
	{
		addressOfRawData = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetPointerToRawData()
	{
		return pointerToRawData;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPointerToRawData(uint uintValue)
	{
		pointerToRawData = uintValue;
	}

	protected DebugDirectoryEntry()
	{
	}

	internal DebugDirectoryEntry(BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		SetCharacteristics(boundsCheckedBinaryReader.ReadUInt32());
		SetTimeDateStamp(boundsCheckedBinaryReader.ReadUInt32());
		SetMajorVersion(boundsCheckedBinaryReader.ReadUInt16());
		SetMinorVersion(boundsCheckedBinaryReader.ReadUInt16());
		SetType((DebugDirectoryType)boundsCheckedBinaryReader.ReadUInt32());
		SetSizeOfData(boundsCheckedBinaryReader.ReadUInt32());
		SetAddressOfRawData(boundsCheckedBinaryReader.ReadUInt32());
		SetPointerToRawData(boundsCheckedBinaryReader.ReadUInt32());
	}
}
