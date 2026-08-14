using System.Runtime.CompilerServices;

public sealed class ForwardedExport
{
	[CompilerGenerated]
	internal string moduleName;

	[CompilerGenerated]
	internal bool isOrdinal;

	[CompilerGenerated]
	internal ushort ordinal;

	[CompilerGenerated]
	internal string name;

	[SpecialName]
	[CompilerGenerated]
	public string GetModuleName()
	{
		return moduleName;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetModuleName(string text)
	{
		moduleName = text;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetIsOrdinal()
	{
		return isOrdinal;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetIsOrdinal(bool flag)
	{
		isOrdinal = flag;
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
}
