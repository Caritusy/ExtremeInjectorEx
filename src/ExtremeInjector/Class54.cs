using System;
using System.Runtime.InteropServices;

internal abstract class Class54
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate IntPtr Delegate41();

	internal static Delegate41 delegate41_0;

	static Class54()
	{
		delegate41_0 = Class51.smethod_0<Delegate41>(Class49.bool_0 ? Class178.smethod_0(8415) : Class178.smethod_0(8354));
	}

	public abstract void Class54_002E_202A_202C_202E_200F_202C_206C_200C_202D_202A_206E_200F_200C_202D_202C_202B_200C_206B_200D_206C_206F_206E_206D_206F_200D_200E_206A_202A_202B_202B_206B_200C_202D_202E_206D_202E_206E_200C_202E_200E_202E(IntPtr intptr_0);
}
