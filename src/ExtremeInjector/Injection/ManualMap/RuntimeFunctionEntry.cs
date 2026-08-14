using System.Runtime.CompilerServices;

public sealed class RuntimeFunctionEntry
{
	[CompilerGenerated]
	internal uint beginAddress;

	[CompilerGenerated]
	internal uint endAddress;

	[CompilerGenerated]
	internal uint unwindInfoAddress;

	[SpecialName]
	[CompilerGenerated]
	public uint GetBeginAddress()
	{
		return beginAddress;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetBeginAddress(uint uintValue)
	{
		beginAddress = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetEndAddress()
	{
		return endAddress;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetEndAddress(uint uintValue)
	{
		endAddress = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetUnwindInfoAddress()
	{
		return unwindInfoAddress;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetUnwindInfoAddress(uint uintValue)
	{
		unwindInfoAddress = uintValue;
	}
}
