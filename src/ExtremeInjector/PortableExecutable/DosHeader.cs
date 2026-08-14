using System.Runtime.CompilerServices;

public sealed class DosHeader
{
	[CompilerGenerated]
	internal uint peHeaderOffset;

	[SpecialName]
	[CompilerGenerated]
	public uint GetPeHeaderOffset()
	{
		return peHeaderOffset;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPeHeaderOffset(uint uintValue)
	{
		peHeaderOffset = uintValue;
	}
}
