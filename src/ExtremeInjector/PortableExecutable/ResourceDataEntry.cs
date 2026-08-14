using System.Runtime.CompilerServices;

public sealed class ResourceDataEntry : ResourceIdentifier
{
	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	[SpecialName]
	[CompilerGenerated]
	public uint GetDataRva()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDataRva(uint uint_2)
	{
		uint_0 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSize()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSize(uint uint_2)
	{
		uint_1 = uint_2;
	}

	public ResourceDataEntry(int int_1, uint uint_2, uint uint_3)
		: base(int_1)
	{
		SetDataRva(uint_2);
		SetSize(uint_3);
	}

	public ResourceDataEntry(string string_1, uint uint_2, uint uint_3)
		: base(string_1)
	{
		SetDataRva(uint_2);
		SetSize(uint_3);
	}
}
