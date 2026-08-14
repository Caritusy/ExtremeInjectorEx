using System;
using System.Runtime.CompilerServices;

public sealed class Class93 : Class83
{
	[CompilerGenerated]
	public sealed class Class120
	{
		public GClass1 gclass1_0;

		internal bool method_0(GClass1 gclass1_1)
		{
			if (smethod_0(gclass1_1.method_8(), Class178.smethod_0(8549), StringComparison.OrdinalIgnoreCase))
			{
				return gclass1_1.method_10() == gclass1_0.method_10();
			}
			return false;
		}

		internal bool method_1(GClass1 gclass1_1)
		{
			return gclass1_1.method_0() != gclass1_0.method_0();
		}

		internal static bool smethod_0(string string_0, string string_1, StringComparison stringComparison_0)
		{
			return string_0.Equals(string_1, stringComparison_0);
		}
	}

	public Class93(GClass2 gclass2_1)
		: base(gclass2_1)
	{
	}

	protected override void method_04C6()
	{
		if (!(method_2() == IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = -720526839;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -860400977)) % 4)
				{
				case 2u:
					num = ((method_0() == -1) ? (-723716906) : (-1067356984)) ^ (int)(num2 * 928770381);
					continue;
				case 1u:
					method_3(Class171.OpenProcess(Class124.Enum32.flag_2 | Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5 | Class124.Enum32.flag_9, bool_0: false, method_0()));
					num = (int)((num2 * 669194560) ^ 0x4F644078);
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}
}
