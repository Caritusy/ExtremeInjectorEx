using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class BaseRelocationBlock
{
	[CompilerGenerated]
	internal uint pageRva;

	[CompilerGenerated]
	internal uint blockSize;

	public List<BaseRelocationEntry> items = new List<BaseRelocationEntry>();

	[SpecialName]
	[CompilerGenerated]
	public uint GetPageRva()
	{
		return pageRva;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPageRva(uint uintValue)
	{
		pageRva = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetBlockSize()
	{
		return blockSize;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetBlockSize(uint uintValue)
	{
		blockSize = uintValue;
	}
}
