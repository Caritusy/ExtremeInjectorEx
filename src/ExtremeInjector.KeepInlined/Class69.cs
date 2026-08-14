using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class Class69 : List<GClass1>
{
	[CompilerGenerated]
	public sealed class Class70
	{
		public string string_0;

		internal bool method_0(GClass1 gclass1_0)
		{
			return gclass1_0.method_6().Equals(string_0, StringComparison.OrdinalIgnoreCase);
		}

		internal bool method_1(GClass1 gclass1_0)
		{
			return gclass1_0.method_8().Equals(string_0, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool smethod_0(string string_1, string string_2, StringComparison stringComparison_0)
		{
			return string_1.Equals(string_2, stringComparison_0);
		}
	}

	[CompilerGenerated]
	public sealed class Class71
	{
		public IntPtr intptr_0;

		internal bool method_0(GClass1 gclass1_0)
		{
			return gclass1_0.method_0() == intptr_0;
		}
	}

	[CompilerGenerated]
	public sealed class Class72
	{
		public string string_0;

		internal bool method_0(GClass1 gclass1_0)
		{
			return gclass1_0.method_8().Equals(string_0, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool smethod_0(string string_1, string string_2, StringComparison stringComparison_0)
		{
			return string_1.Equals(string_2, stringComparison_0);
		}
	}

	internal GClass2 gclass2_0;

	public GClass1 this[string string_0] => Find((GClass1 gclass1_0) => gclass1_0.method_8().Equals(string_0, StringComparison.OrdinalIgnoreCase));

	public Class69(GClass2 gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	public IntPtr method_0(string string_0)
	{
		int num3 = default(int);
		string string_1 = default(string);
		while (true)
		{
			int num = -840541156;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -508880491)) % 9)
				{
				case 8u:
					num = ((num3 >= 0) ? (-289575236) : (-673426763));
					continue;
				case 7u:
					num3 = FindIndex((GClass1 gclass1_0) => gclass1_0.method_8().Equals(string_1, StringComparison.OrdinalIgnoreCase));
					num = -108590644;
					continue;
				case 6u:
					string_1 = string_0;
					num = ((int)num2 * -1257608882) ^ 0x350496;
					continue;
				case 3u:
					num = (Path.IsPathRooted(string_1) ? (-1151442079) : (-1550847651)) ^ ((int)num2 * -1418292516);
					continue;
				case 1u:
					num3 = FindIndex((GClass1 gclass1_0) => gclass1_0.method_6().Equals(string_1, StringComparison.OrdinalIgnoreCase));
					num = (int)(num2 * 1214666303) ^ -886877397;
					continue;
				case 0u:
					num = (int)(num2 * 1690923808) ^ -427076340;
					continue;
				case 5u:
					break;
				default:
					return base[num3].method_0();
				case 4u:
					return IntPtr.Zero;
				}
				break;
			}
		}
	}

	internal static bool smethod_0(string string_0)
	{
		return Path.IsPathRooted(string_0);
	}
}
