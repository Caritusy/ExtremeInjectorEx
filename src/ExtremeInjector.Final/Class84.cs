using System;

public abstract class Class84 : Class83
{
	protected Class84(GClass2 gclass2_1)
		: base(gclass2_1)
	{
	}

	protected internal T method_21<T>(Class47 class47_0)
	{
		return method_23<T>(class47_0.class53_0, IntPtr.Zero, class47_0.method_2(), bool_2: true);
	}

	protected internal T method_22<T>(Class47 class47_0, IntPtr intptr_1, bool bool_2)
	{
		return method_23<T>(class47_0.class53_0, intptr_1, class47_0.method_2(), bool_2);
	}

	protected T method_23<T>(Class53 class53_0, IntPtr intptr_1, int int_1, bool bool_2)
	{
		intptr_1 = Class171.smethod_434(intptr_1, class53_0, this);
		IntPtr intPtr = Class171.smethod_315((Class83)this, intptr_1, IntPtr.Zero);
		Class171.smethod_152((Class83)this, intPtr, -1);
		T result = default(T);
		while (true)
		{
			int num = 1735853985;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5D14F60A)) % 10)
				{
				case 9u:
					Class171.smethod_108((Class83)this, intPtr);
					num = (int)((num2 * 1373518870) ^ 0x288A1ADA);
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!Class171.smethod_418(method_19()))
					{
						num5 = 964182253;
						num6 = 964182253;
					}
					else
					{
						num5 = 942172755;
						num6 = 942172755;
					}
					num = num5 ^ ((int)num2 * -167539714);
					continue;
				}
				case 7u:
				{
					int num7;
					if (bool_2)
					{
						num = 1351242382;
						num7 = 1351242382;
					}
					else
					{
						num = 704633865;
						num7 = 704633865;
					}
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if ((object)typeof(T) == typeof(IntPtr))
					{
						num3 = -926141324;
						num4 = -926141324;
					}
					else
					{
						num3 = -1540118587;
						num4 = -1540118587;
					}
					num = num3 ^ ((int)num2 * -1181570940);
					continue;
				}
				case 4u:
					result = (T)(object)(IntPtr)method_11<int>(intptr_1.smethod_8(int_1));
					num = ((int)num2 * -1505767297) ^ -1541013618;
					continue;
				case 3u:
					result = method_11<T>(intptr_1.smethod_8(int_1));
					num = 713294831;
					continue;
				case 2u:
					vmethod_6(intptr_1);
					num = (int)(num2 * 492033324) ^ -1995585863;
					continue;
				case 0u:
					num = ((int)num2 * -273108360) ^ 0x7B55F79F;
					continue;
				case 6u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
