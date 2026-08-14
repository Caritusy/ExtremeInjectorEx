using System;
using System.Runtime.CompilerServices;

public sealed class Class129
{
	[CompilerGenerated]
	public sealed class Class130
	{
		public IntPtr intptr_0;

		internal bool method_0(GClass1 gclass1_0)
		{
			return gclass1_0.method_0() == intptr_0;
		}
	}

	[CompilerGenerated]
	internal GClass2 gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public GClass2 method_0()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(GClass2 gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public Class129(GClass2 gclass2_1)
	{
		method_1(gclass2_1);
	}
}
