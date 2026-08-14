using System.Runtime.CompilerServices;

public sealed class ImportedSymbol
{
	[CompilerGenerated]
	internal ulong thunkValue;

	[CompilerGenerated]
	internal ushort ordinal;

	[CompilerGenerated]
	internal string name;

	[CompilerGenerated]
	internal ushort hint;

	[CompilerGenerated]
	internal bool isOrdinal;

	[SpecialName]
	[CompilerGenerated]
	public ulong GetThunkValue()
	{
		return thunkValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetThunkValue(ulong ulongValue)
	{
		thunkValue = ulongValue;
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
	public void SetHint(ushort ushortValue)
	{
		hint = ushortValue;
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
}
