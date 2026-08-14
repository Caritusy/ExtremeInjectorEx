using System.Runtime.CompilerServices;

public sealed class ImportedSymbol
{
	[CompilerGenerated]
	internal ulong ulong_0;

	[CompilerGenerated]
	internal ushort ushort_0;

	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	internal ushort ushort_1;

	[CompilerGenerated]
	internal bool bool_0;

	[SpecialName]
	[CompilerGenerated]
	public ulong GetThunkValue()
	{
		return ulong_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetThunkValue(ulong ulong_1)
	{
		ulong_0 = ulong_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ushort GetOrdinal()
	{
		return ushort_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetOrdinal(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GetName()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetName(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetHint(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetIsOrdinal()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetIsOrdinal(bool bool_1)
	{
		bool_0 = bool_1;
	}
}
