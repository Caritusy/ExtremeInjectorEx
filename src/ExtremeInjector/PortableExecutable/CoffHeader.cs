using System.IO;
using System.Runtime.CompilerServices;

public sealed class CoffHeader
{
	[CompilerGenerated]
	internal MachineType machine;

	[CompilerGenerated]
	internal ushort numberOfSections;

	[CompilerGenerated]
	internal uint timeDateStamp;

	[CompilerGenerated]
	internal uint pointerToSymbolTable;

	[CompilerGenerated]
	internal uint numberOfSymbols;

	[CompilerGenerated]
	internal ushort sizeOfOptionalHeader;

	[CompilerGenerated]
	internal CoffCharacteristics characteristics;

	[SpecialName]
	[CompilerGenerated]
	public MachineType GetMachine()
	{
		return machine;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMachine(MachineType machineType)
	{
		machine = machineType;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetNumberOfSections()
	{
		return numberOfSections;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfSections(ushort ushortValue)
	{
		numberOfSections = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetTimeDateStamp()
	{
		return timeDateStamp;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetTimeDateStamp(uint uintValue)
	{
		timeDateStamp = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetPointerToSymbolTable()
	{
		return pointerToSymbolTable;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPointerToSymbolTable(uint uintValue)
	{
		pointerToSymbolTable = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetNumberOfSymbols()
	{
		return numberOfSymbols;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNumberOfSymbols(uint uintValue)
	{
		numberOfSymbols = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetSizeOfOptionalHeader()
	{
		return sizeOfOptionalHeader;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSizeOfOptionalHeader(ushort ushortValue)
	{
		sizeOfOptionalHeader = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public CoffCharacteristics GetCharacteristics()
	{
		return characteristics;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCharacteristics(CoffCharacteristics coffCharacteristics)
	{
		characteristics = coffCharacteristics;
	}

	public CoffHeader()
	{
	}

	public CoffHeader(BinaryReader binaryReader)
	{
		this.SetMachine((MachineType)binaryReader.ReadUInt16());
		this.SetNumberOfSections(binaryReader.ReadUInt16());
		this.SetTimeDateStamp(binaryReader.ReadUInt32());
		this.SetPointerToSymbolTable(binaryReader.ReadUInt32());
		this.SetNumberOfSymbols(binaryReader.ReadUInt32());
		this.SetSizeOfOptionalHeader(binaryReader.ReadUInt16());
		this.SetCharacteristics((CoffCharacteristics)binaryReader.ReadUInt16());
	}
}
