using System.Runtime.CompilerServices;

public sealed class RuntimeFunctionEntry
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[CompilerGenerated]
	internal uint uint_2;

	[SpecialName]
	[CompilerGenerated]
	public uint GetBeginAddress()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetBeginAddress(uint uint_3)
	{
		uint_0 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetEndAddress()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetEndAddress(uint uint_3)
	{
		uint_1 = uint_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetUnwindInfoAddress()
	{
		return uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetUnwindInfoAddress(uint uint_3)
	{
		uint_2 = uint_3;
	}
}
