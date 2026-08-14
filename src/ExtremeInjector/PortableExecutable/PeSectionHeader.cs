using System.IO;
using System.Runtime.CompilerServices;

public sealed class PeSectionHeader
{
	[CompilerGenerated]
	internal string name;

	[CompilerGenerated]
	internal uint virtualSize;

	[CompilerGenerated]
	internal uint virtualAddress;

	[CompilerGenerated]
	internal uint sizeOfRawData;

	[CompilerGenerated]
	internal uint pointerToRawData;

	[CompilerGenerated]
	internal uint pointerToRelocations;

	[CompilerGenerated]
	internal uint pointerToLineNumbers;

	[CompilerGenerated]
	internal ushort numberOfRelocations;

	[CompilerGenerated]
	internal ushort numberOfLineNumbers;

	[CompilerGenerated]
	internal SectionCharacteristics characteristics;

	[SpecialName]
	[CompilerGenerated]
	public string GetName()
	{
		return name;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetName(string text)
	{
		name = text;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetVirtualSize()
	{
		return virtualSize;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetVirtualSize(uint uintValue)
	{
		virtualSize = uintValue;
	}

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
	public uint GetSizeOfRawData()
	{
		return sizeOfRawData;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfRawData(uint uintValue)
	{
		sizeOfRawData = uintValue;
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

	[SpecialName]
	[CompilerGenerated]
	public uint GetPointerToRelocations()
	{
		return pointerToRelocations;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPointerToRelocations(uint uintValue)
	{
		pointerToRelocations = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetPointerToLineNumbers()
	{
		return pointerToLineNumbers;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPointerToLineNumbers(uint uintValue)
	{
		pointerToLineNumbers = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetNumberOfRelocations()
	{
		return numberOfRelocations;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfRelocations(ushort ushortValue)
	{
		numberOfRelocations = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetNumberOfLineNumbers()
	{
		return numberOfLineNumbers;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfLineNumbers(ushort ushortValue)
	{
		numberOfLineNumbers = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public SectionCharacteristics GetCharacteristics()
	{
		return characteristics;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCharacteristics(SectionCharacteristics sectionCharacteristics)
	{
		characteristics = sectionCharacteristics;
	}

	public PeSectionHeader()
	{
	}

	public PeSectionHeader(BinaryReader binaryReader)
	{
		byte[] ienumerable_ = binaryReader.ReadBytes(8);
		this.SetName(RecoveredRuntime.ReadNullTerminatedByteString(ienumerable_));
		this.SetVirtualSize(binaryReader.ReadUInt32());
		this.SetVirtualAddress(binaryReader.ReadUInt32());
		this.SetSizeOfRawData(binaryReader.ReadUInt32());
		this.SetPointerToRawData(binaryReader.ReadUInt32());
		this.SetPointerToRelocations(binaryReader.ReadUInt32());
		this.SetPointerToLineNumbers(binaryReader.ReadUInt32());
		this.SetNumberOfRelocations(binaryReader.ReadUInt16());
		this.SetNumberOfLineNumbers(binaryReader.ReadUInt16());
		this.SetCharacteristics((SectionCharacteristics)binaryReader.ReadUInt32());
	}
}
