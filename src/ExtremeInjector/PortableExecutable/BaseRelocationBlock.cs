using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class BaseRelocationBlock
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	public List<BaseRelocationEntry> list_0 = new List<BaseRelocationEntry>();

	[SpecialName]
	[CompilerGenerated]
	public uint GetPageRva()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPageRva(uint uint_2)
	{
		uint_0 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetBlockSize()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetBlockSize(uint uint_2)
	{
		uint_1 = uint_2;
	}
}
