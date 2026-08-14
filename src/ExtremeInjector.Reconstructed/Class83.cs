using System;
using System.Runtime.CompilerServices;

public abstract class Class83 : Class82, IDisposable
{
	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private GClass2 gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public bool method_17()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_18(bool bool_2)
	{
		bool_1 = bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal GClass2 method_19()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal void method_20(GClass2 gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	protected Class83(GClass2 gclass2_1)
	{
		while (true)
		{
			int num = -1882158127;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1591041248)) % 3)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				method_20(gclass2_1);
				method_5(bool_1: false);
				num = ((int)num2 * -513153544) ^ 0x489575DD;
			}
		}
	}

	void IDisposable.Dispose()
	{
		Class171.smethod_382((Class82)this);
	}
}
