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
				{
					int num6;
					if (num3 < 0)
					{
						num = -673426763;
						num6 = -673426763;
					}
					else
					{
						num = -289575236;
						num6 = -289575236;
					}
					continue;
				}
				case 7u:
					num3 = FindIndex((GClass1 gclass1_0) => gclass1_0.method_8().Equals(string_1, StringComparison.OrdinalIgnoreCase));
					num = -108590644;
					continue;
				case 6u:
					string_1 = string_0;
					num = ((int)num2 * -1257608882) ^ 0x350496;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (!Path.IsPathRooted(string_1))
					{
						num4 = -1550847651;
						num5 = -1550847651;
					}
					else
					{
						num4 = -1151442079;
						num5 = -1151442079;
					}
					num = num4 ^ ((int)num2 * -1418292516);
					continue;
				}
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
}
