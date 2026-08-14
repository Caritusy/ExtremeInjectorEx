using System.Runtime.CompilerServices;

public sealed class ResourceDataEntry : ResourceIdentifier
{
	[CompilerGenerated]
	internal uint dataRva;

	[CompilerGenerated]
	internal uint size;

	[SpecialName]
	[CompilerGenerated]
	public uint GetDataRva()
	{
		return dataRva;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetDataRva(uint uintValue)
	{
		dataRva = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetSize()
	{
		return size;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetSize(uint uintValue)
	{
		size = uintValue;
	}

	public ResourceDataEntry(int intValue, uint uintValue, uint uintValue2)
		: base(intValue)
	{
		SetDataRva(uintValue);
		SetSize(uintValue2);
	}

	public ResourceDataEntry(string text, uint uintValue, uint uintValue2)
		: base(text)
	{
		SetDataRva(uintValue);
		SetSize(uintValue2);
	}
}
