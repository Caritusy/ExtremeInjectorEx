using System;
using System.Runtime.InteropServices;

public static class Class67
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int Delegate44(ref Struct31 struct31_0);

	internal static Delegate44 delegate44_0;

	static Class67()
	{
		delegate44_0 = (Delegate44)Marshal.GetDelegateForFunctionPointer(new Class123(Class127.bool_0 ? Class171.smethod_99() : Class171.smethod_180(), bool_0: true).method_2(Class127.bool_0 ? "Disasm" : "_Disasm@4"), typeof(Delegate44));
	}

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static Delegate smethod_1(IntPtr intptr_0, Type type_0)
	{
		return Marshal.GetDelegateForFunctionPointer(intptr_0, type_0);
	}
}
