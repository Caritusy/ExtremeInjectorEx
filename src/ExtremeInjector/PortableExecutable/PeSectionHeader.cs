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
	public string GetName()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetName(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetVirtualSize()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetVirtualSize(uint uint_6)
	{
		uint_0 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetVirtualAddress()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetVirtualAddress(uint uint_6)
	{
		uint_1 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSizeOfRawData()
	{
		return uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfRawData(uint uint_6)
	{
		uint_2 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetPointerToRawData()
	{
		return uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPointerToRawData(uint uint_6)
	{
		uint_3 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetPointerToRelocations()
	{
		return uint_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPointerToRelocations(uint uint_6)
	{
		uint_4 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetPointerToLineNumbers()
	{
		return uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPointerToLineNumbers(uint uint_6)
	{
		uint_5 = uint_6;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetNumberOfRelocations()
	{
		return ushort_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfRelocations(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetNumberOfLineNumbers()
	{
		return ushort_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfLineNumbers(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public SectionCharacteristics GetCharacteristics()
	{
		return enum41_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCharacteristics(SectionCharacteristics enum41_1)
	{
		enum41_0 = enum41_1;
	}

	public PeSectionHeader()
	{
	}

	public PeSectionHeader(BinaryReader binaryReader_0)
	{
		byte[] ienumerable_ = binaryReader_0.ReadBytes(8);
		this.SetName(RecoveredRuntime.ReadNullTerminatedByteString(ienumerable_));
		this.SetVirtualSize(binaryReader_0.ReadUInt32());
		this.SetVirtualAddress(binaryReader_0.ReadUInt32());
		this.SetSizeOfRawData(binaryReader_0.ReadUInt32());
		this.SetPointerToRawData(binaryReader_0.ReadUInt32());
		this.SetPointerToRelocations(binaryReader_0.ReadUInt32());
		this.SetPointerToLineNumbers(binaryReader_0.ReadUInt32());
		this.SetNumberOfRelocations(binaryReader_0.ReadUInt16());
		this.SetNumberOfLineNumbers(binaryReader_0.ReadUInt16());
		this.SetCharacteristics((SectionCharacteristics)binaryReader_0.ReadUInt32());
	}
}
