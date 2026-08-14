using System.Runtime.CompilerServices;

public abstract class ResourceIdentifier
{
	[CompilerGenerated]
	internal string name;

	[CompilerGenerated]
	internal int id;

	[SpecialName]
	[CompilerGenerated]
	public string GetName()
	{
		return name;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void SetName(string text)
	{
		name = text;
	}

	[SpecialName]
	[CompilerGenerated]
	public int GetId()
	{
		return id;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void SetId(int intValue)
	{
		id = intValue;
	}

	protected ResourceIdentifier(int intValue)
	{
		this.SetName(null);
		this.SetId(intValue);
	}

	protected ResourceIdentifier(string text)
	{
		SetName(text);
		SetId(-1);
	}
}
