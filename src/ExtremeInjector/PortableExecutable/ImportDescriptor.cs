using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ImportDescriptor
{
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
	internal List<ImportedSymbol> list_0;

	[CompilerGenerated]
	internal List<ImportedSymbol> list_1;

	[CompilerGenerated]
	internal string string_0;

	[SpecialName]
	[CompilerGenerated]
	public uint GetOriginalFirstThunk()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOriginalFirstThunk(uint uint_5)
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
	public void SetForwarderChain(uint uint_5)
	{
		uint_2 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetNameRva()
	{
		return uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNameRva(uint uint_5)
	{
		uint_3 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetFirstThunk()
	{
		return uint_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFirstThunk(uint uint_5)
	{
		uint_4 = uint_5;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<ImportedSymbol> GetOriginalThunkSymbols()
	{
		return list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOriginalThunkSymbols(List<ImportedSymbol> list_2)
	{
		list_0 = list_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<ImportedSymbol> GetFirstThunkSymbols()
	{
		return list_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFirstThunkSymbols(List<ImportedSymbol> list_2)
	{
		list_1 = list_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GetModuleName()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetModuleName(string string_1)
	{
		string_0 = string_1;
	}

	public ImportDescriptor()
	{
		this.SetOriginalThunkSymbols(new List<ImportedSymbol>());
		this.SetFirstThunkSymbols(new List<ImportedSymbol>());
	}
}
