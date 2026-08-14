using System.Runtime.CompilerServices;

public abstract class ResourceIdentifier
{
	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	internal int int_0;

	[SpecialName]
	[CompilerGenerated]
	public string GetName()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void SetName(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public int GetId()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void SetId(int int_1)
	{
		int_0 = int_1;
	}

	protected ResourceIdentifier(int int_1)
	{
		this.SetName(null);
		this.SetId(int_1);
	}

	protected ResourceIdentifier(string string_1)
	{
		SetName(string_1);
		SetId(-1);
	}
}
