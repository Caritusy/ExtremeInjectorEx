using System.Runtime.CompilerServices;

public sealed class BaseRelocationEntry
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal BaseRelocationType genum0_0;

	[SpecialName]
	[CompilerGenerated]
	public uint GetOffset()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOffset(uint uint_1)
	{
		uint_0 = uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public BaseRelocationType GetRelocationType()
	{
		return genum0_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetType(BaseRelocationType genum0_1)
	{
		genum0_0 = genum0_1;
	}
}
