using System.Runtime.CompilerServices;

public abstract class ResourceIdentifier
{
	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	internal int int_0;

	[SpecialName]
	[CompilerGenerated]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void method_1(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_2()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void method_3(int int_1)
	{
		int_0 = int_1;
	}

	protected ResourceIdentifier(int int_1)
	{
		this.method_1(null);
		this.method_3(int_1);
	}

	protected ResourceIdentifier(string string_1)
	{
		method_1(string_1);
		method_3(-1);
	}
}
