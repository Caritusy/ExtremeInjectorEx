using System;

public abstract class Class84 : Class83
{
	protected Class84(RemoteProcess gclass2_1)
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
		intptr_1 = Class171.smethod_443(intptr_1, class53_0, this);
		IntPtr intPtr = Class171.smethod_321(this, intptr_1, IntPtr.Zero);
		Class171.smethod_153(this, intPtr, -1);
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
					Class171.smethod_108(this, intPtr);
					num = (int)((num2 * 1373518870) ^ 0x288A1ADA);
					continue;
				case 8u:
					num = (Class171.smethod_427(method_19()) ? 942172755 : 964182253) ^ ((int)num2 * -167539714);
					continue;
				case 7u:
					num = ((!bool_2) ? 704633865 : 1351242382);
					continue;
				case 5u:
					num = (((object)typeof(T) != typeof(IntPtr)) ? (-1540118587) : (-926141324)) ^ ((int)num2 * -1181570940);
					continue;
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

	internal static Type smethod_6(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
