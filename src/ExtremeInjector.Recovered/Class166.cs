using System.Runtime.CompilerServices;

public sealed class Class166
{
	internal long long_0;

	internal uint uint_0;

	internal Class5 class5_0;

	[CompilerGenerated]
	private Class138 class138_0;

	[SpecialName]
	[CompilerGenerated]
	public Class138 method_0()
	{
		return class138_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(Class138 class138_1)
	{
		class138_0 = class138_1;
	}

	internal Class166(Class5 class5_1, long long_1, uint uint_1)
	{
		class5_0 = class5_1;
		long_0 = long_1;
		uint_0 = uint_1;
		method_1(new Class138(Class178.smethod_0(10089), this, (long_0 <= 0L) ? (-1) : 0));
	}
}
