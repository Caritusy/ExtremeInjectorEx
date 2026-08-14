using System.Runtime.CompilerServices;

internal sealed class Class142
{
	[CompilerGenerated]
	private uint uint_0;

	[CompilerGenerated]
	private ushort ushort_0;

	[CompilerGenerated]
	private ushort ushort_1;

	[CompilerGenerated]
	private Class157 class157_0;

	[CompilerGenerated]
	private Enum35 enum35_0;

	[CompilerGenerated]
	private uint uint_1;

	[CompilerGenerated]
	private Class157 class157_1;

	[CompilerGenerated]
	private Class157 class157_2;

	[CompilerGenerated]
	private Class157 class157_3;

	[CompilerGenerated]
	private Class157 class157_4;

	[CompilerGenerated]
	private Class157 class157_5;

	[CompilerGenerated]
	private Class157 class157_6;

	[SpecialName]
	[CompilerGenerated]
	public uint method_0()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(uint uint_2)
	{
		uint_0 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_2(ushort ushort_2)
	{
		ushort_0 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(ushort ushort_2)
	{
		ushort_1 = ushort_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_4(Class157 class157_7)
	{
		class157_0 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(Enum35 enum35_1)
	{
		enum35_0 = enum35_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_6(uint uint_2)
	{
		uint_1 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(Class157 class157_7)
	{
		class157_1 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_8(Class157 class157_7)
	{
		class157_2 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(Class157 class157_7)
	{
		class157_3 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_10(Class157 class157_7)
	{
		class157_4 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(Class157 class157_7)
	{
		class157_5 = class157_7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_12(Class157 class157_7)
	{
		class157_6 = class157_7;
	}

	public Class142()
	{
	}

	internal Class142(Class5 class5_0)
	{
		while (true)
		{
			int num = -1363839455;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -953142585)) % 10)
				{
				case 8u:
					method_6(class5_0.ReadUInt32());
					method_7(new Class157(class5_0));
					num = ((int)num2 * -790790398) ^ 0x6CC2B342;
					continue;
				case 7u:
					method_12(new Class157(class5_0));
					num = (int)(num2 * 1828547557) ^ -1436956789;
					continue;
				case 6u:
					method_1(class5_0.ReadUInt32());
					method_2(class5_0.ReadUInt16());
					method_3(class5_0.ReadUInt16());
					num = (int)((num2 * 829679713) ^ 0x4655FCA9);
					continue;
				case 5u:
					method_11(new Class157(class5_0));
					num = ((int)num2 * -2091150749) ^ -1615402381;
					continue;
				case 4u:
					method_9(new Class157(class5_0));
					method_10(new Class157(class5_0));
					num = (int)(num2 * 1646589260) ^ -1988171420;
					continue;
				case 2u:
					method_5((Enum35)class5_0.ReadUInt32());
					num = ((int)num2 * -508397412) ^ 0x18899665;
					continue;
				case 1u:
					method_8(new Class157(class5_0));
					num = ((int)num2 * -1136784375) ^ 0x38BD8EE8;
					continue;
				case 0u:
					method_4(new Class157(class5_0));
					num = ((int)num2 * -1599784309) ^ -1811821037;
					continue;
				default:
					return;
				case 9u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}
}
