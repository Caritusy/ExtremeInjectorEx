using System;
using System.Runtime.InteropServices;

public sealed class NativeAsmJitMemoryManager : AsmJitMemoryManager
{
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate void Delegate42(IntPtr intptr_0, IntPtr intptr_1);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Delegate43(IntPtr intptr_0, IntPtr intptr_1);

	internal IntPtr intptr_0;

	internal NativeAsmJitMemoryManager(IntPtr intptr_1)
	{
		this.intptr_0 = intptr_1;
	}

	internal T method_0<T>(int int_0)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Marshal.ReadIntPtr(Marshal.ReadIntPtr(intptr_0), int_0 * IntPtr.Size), typeof(T));
	}

	public override void method_03FF(IntPtr intptr_1)
	{
		if (AsmJitRuntime.bool_0)
		{
			this.method_0<NativeAsmJitMemoryManager.Delegate43>(2)(this.intptr_0, intptr_1);
			return;
		}
		this.method_0<NativeAsmJitMemoryManager.Delegate42>(2)(this.intptr_0, intptr_1);
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
