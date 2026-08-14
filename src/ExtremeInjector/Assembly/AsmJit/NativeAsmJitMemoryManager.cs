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

	internal T GetVirtualFunction<T>(int int_0)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Marshal.ReadIntPtr(Marshal.ReadIntPtr(intptr_0), int_0 * IntPtr.Size), typeof(T));
	}

	public override void Release(IntPtr intptr_1)
	{
		if (AsmJitRuntime.bool_0)
		{
			this.GetVirtualFunction<NativeAsmJitMemoryManager.Delegate43>(2)(this.intptr_0, intptr_1);
			return;
		}
		this.GetVirtualFunction<NativeAsmJitMemoryManager.Delegate42>(2)(this.intptr_0, intptr_1);
	}
}
