using System.Runtime.CompilerServices;

public sealed class ExportedSymbol
{
	[CompilerGenerated]
	internal bool hasName;

	[CompilerGenerated]
	internal ushort ordinal;

	[CompilerGenerated]
	internal string name;

	[CompilerGenerated]
	internal uint addressRva;

	[CompilerGenerated]
	internal ForwardedExport forwarder;

	[SpecialName]
	[CompilerGenerated]
	public bool GetHasName()
	{
		return hasName;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetHasName(bool flag)
	{
		hasName = flag;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetOrdinal()
	{
		return ordinal;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOrdinal(ushort ushortValue)
	{
		ordinal = ushortValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GetName()
	{
		return name;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetName(string text)
	{
		name = text;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetAddressRva()
	{
		return addressRva;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetAddressRva(uint uintValue)
	{
		addressRva = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public ForwardedExport GetForwarder()
	{
		return forwarder;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetForwarder(ForwardedExport forwardedExport)
	{
		forwarder = forwardedExport;
	}
}
