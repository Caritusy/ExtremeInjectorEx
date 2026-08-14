using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ImportDescriptor
{
	[CompilerGenerated]
	internal uint originalFirstThunk;

	[CompilerGenerated]
	internal uint timeDateStamp;

	[CompilerGenerated]
	internal uint forwarderChain;

	[CompilerGenerated]
	internal uint nameRva;

	[CompilerGenerated]
	internal uint firstThunk;

	[CompilerGenerated]
	internal List<ImportedSymbol> originalThunkSymbols;

	[CompilerGenerated]
	internal List<ImportedSymbol> firstThunkSymbols;

	[CompilerGenerated]
	internal string moduleName;

	[SpecialName]
	[CompilerGenerated]
	public uint GetOriginalFirstThunk()
	{
		return originalFirstThunk;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOriginalFirstThunk(uint uintValue)
	{
		originalFirstThunk = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetTimeDateStamp(uint uintValue)
	{
		timeDateStamp = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetForwarderChain(uint uintValue)
	{
		forwarderChain = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetNameRva()
	{
		return nameRva;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetNameRva(uint uintValue)
	{
		nameRva = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetFirstThunk()
	{
		return firstThunk;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFirstThunk(uint uintValue)
	{
		firstThunk = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<ImportedSymbol> GetOriginalThunkSymbols()
	{
		return originalThunkSymbols;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOriginalThunkSymbols(List<ImportedSymbol> items)
	{
		originalThunkSymbols = items;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<ImportedSymbol> GetFirstThunkSymbols()
	{
		return firstThunkSymbols;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetFirstThunkSymbols(List<ImportedSymbol> items)
	{
		firstThunkSymbols = items;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GetModuleName()
	{
		return moduleName;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetModuleName(string text)
	{
		moduleName = text;
	}

	public ImportDescriptor()
	{
		this.SetOriginalThunkSymbols(new List<ImportedSymbol>());
		this.SetFirstThunkSymbols(new List<ImportedSymbol>());
	}
}
