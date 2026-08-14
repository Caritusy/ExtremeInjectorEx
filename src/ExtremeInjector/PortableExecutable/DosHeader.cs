using System.Runtime.CompilerServices;

public sealed class DosHeader
{
	[CompilerGenerated]
	internal uint uint_0;

	[SpecialName]
	[CompilerGenerated]
	public uint GetPeHeaderOffset()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetPeHeaderOffset(uint uint_1)
	{
		uint_0 = uint_1;
	}
}
