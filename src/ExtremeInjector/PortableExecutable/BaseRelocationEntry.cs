using System.Runtime.CompilerServices;

public sealed class BaseRelocationEntry
{
	[CompilerGenerated]
	internal uint offset;

	[CompilerGenerated]
	internal BaseRelocationType relocationType;

	[SpecialName]
	[CompilerGenerated]
	public uint GetOffset()
	{
		return offset;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOffset(uint uintValue)
	{
		offset = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public BaseRelocationType GetRelocationType()
	{
		return relocationType;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetType(BaseRelocationType baseRelocationType)
	{
		relocationType = baseRelocationType;
	}
}
