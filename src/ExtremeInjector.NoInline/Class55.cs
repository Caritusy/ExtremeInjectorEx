using System;
using System.Runtime.InteropServices;

public sealed class Class55 : Class54
{
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate void Delegate42(IntPtr intptr_0, IntPtr intptr_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Delegate43(IntPtr intptr_0, IntPtr intptr_1);

	internal IntPtr intptr_0;

	internal Class55(IntPtr intptr_1)
	{
		while (true)
		{
			int num = -730954214;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2009850770)) % 3)
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
				intptr_0 = intptr_1;
				num = (int)(num2 * 463483546) ^ -180098689;
			}
		}
	}

	internal T method_0<T>(int int_0)
	{
		return (T)(object)smethod_3(smethod_1(smethod_0(intptr_0), int_0 * IntPtr.Size), smethod_2(typeof(T).TypeHandle));
	}

	public override void method_03FF(IntPtr intptr_1)
	{
		if (Class49.bool_0)
		{
			while (true)
			{
				int num = 2020841994;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x4F933F4F)) % 4)
					{
					case 1u:
						method_0<Delegate43>(2)(intptr_0, intptr_1);
						num = (int)(num2 * 1359226588) ^ -1805477605;
						continue;
					case 2u:
						break;
					case 0u:
						return;
					default:
						goto end_IL_004a;
					}
					break;
				}
				continue;
				end_IL_004a:
				break;
			}
		}
		method_0<Delegate42>(2)(intptr_0, intptr_1);
	}

	internal static IntPtr smethod_0(IntPtr intptr_1)
	{
		return Marshal.ReadIntPtr(intptr_1);
	}

	internal static IntPtr smethod_1(IntPtr intptr_1, int int_0)
	{
		return Marshal.ReadIntPtr(intptr_1, int_0);
	}

	internal static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static Delegate smethod_3(IntPtr intptr_1, Type type_0)
	{
		return Marshal.GetDelegateForFunctionPointer(intptr_1, type_0);
	}
}
