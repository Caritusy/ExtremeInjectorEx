using System.Runtime.CompilerServices;

public sealed class PeHeaders
{
	[CompilerGenerated]
	internal uint signature;

	[CompilerGenerated]
	internal CoffHeader coffHeader;

	[CompilerGenerated]
	internal IPeOptionalHeader optionalHeader;

	[SpecialName]
	[CompilerGenerated]
	public void SetSignature(uint uintValue)
	{
		signature = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public CoffHeader GetCoffHeader()
	{
		return coffHeader;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCoffHeader(CoffHeader coffHeader2)
	{
		coffHeader = coffHeader2;
	}

	[SpecialName]
	[CompilerGenerated]
	public IPeOptionalHeader GetOptionalHeader()
	{
		return optionalHeader;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOptionalHeader(IPeOptionalHeader peOptionalHeader)
	{
		optionalHeader = peOptionalHeader;
	}
}
