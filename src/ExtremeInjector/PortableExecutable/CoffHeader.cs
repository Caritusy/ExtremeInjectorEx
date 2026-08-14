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
	public MachineType GetMachine()
	{
		return enum40_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMachine(MachineType enum40_1)
	{
		enum40_0 = enum40_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetNumberOfSections()
	{
		return ushort_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfSections(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetTimeDateStamp()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetTimeDateStamp(uint uint_3)
	{
		uint_0 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetPointerToSymbolTable()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPointerToSymbolTable(uint uint_3)
	{
		uint_1 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetNumberOfSymbols()
	{
		return uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfSymbols(uint uint_3)
	{
		uint_2 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetSizeOfOptionalHeader()
	{
		return ushort_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfOptionalHeader(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public CoffCharacteristics GetCharacteristics()
	{
		return enum36_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCharacteristics(CoffCharacteristics enum36_1)
	{
		enum36_0 = enum36_1;
	}

	public CoffHeader()
	{
	}

	public CoffHeader(BinaryReader binaryReader_0)
	{
		this.SetMachine((MachineType)binaryReader_0.ReadUInt16());
		this.SetNumberOfSections(binaryReader_0.ReadUInt16());
		this.SetTimeDateStamp(binaryReader_0.ReadUInt32());
		this.SetPointerToSymbolTable(binaryReader_0.ReadUInt32());
		this.SetNumberOfSymbols(binaryReader_0.ReadUInt32());
		this.SetSizeOfOptionalHeader(binaryReader_0.ReadUInt16());
		this.SetCharacteristics((CoffCharacteristics)binaryReader_0.ReadUInt16());
	}
}
