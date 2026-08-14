using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Field)]
internal sealed class Attribute0 : Attribute
{
	[CompilerGenerated]
	private Enum3 enum3_0;

	[SpecialName]
	[CompilerGenerated]
	public Enum3 method_0()
	{
		return enum3_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(Enum3 enum3_1)
	{
		enum3_0 = enum3_1;
	}

	public Attribute0(Enum3 enum3_1)
	{
		while (true)
		{
			int num = -747228563;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1474642088)) % 3)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				method_1(enum3_1);
				num = ((int)num2 * -1823084880) ^ -1711958509;
			}
		}
	}
}
