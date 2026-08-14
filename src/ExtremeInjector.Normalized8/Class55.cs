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
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Marshal.ReadIntPtr(Marshal.ReadIntPtr(intptr_0), int_0 * IntPtr.Size), typeof(T));
	}

	public override void Class54_002E_202A_202C_202E_200F_202C_206C_200C_202D_202A_206E_200F_200C_202D_202C_202B_200C_206B_200D_206C_206F_206E_206D_206F_200D_200E_206A_202A_202B_202B_206B_200C_202D_202E_206D_202E_206E_200C_202E_200E_202E(IntPtr intptr_1)
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
}
