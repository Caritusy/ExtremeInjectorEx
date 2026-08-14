using System.Runtime.CompilerServices;

public sealed class PeHeaders
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal CoffHeader class159_0;

	[CompilerGenerated]
	internal IPeOptionalHeader interface2_0;

	[SpecialName]
	[CompilerGenerated]
	public void SetSignature(uint uint_1)
	{
		uint_0 = uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public CoffHeader GetCoffHeader()
	{
		return class159_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetCoffHeader(CoffHeader class159_1)
	{
		class159_0 = class159_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public IPeOptionalHeader GetOptionalHeader()
	{
		return interface2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOptionalHeader(IPeOptionalHeader interface2_1)
	{
		interface2_0 = interface2_1;
	}
}
