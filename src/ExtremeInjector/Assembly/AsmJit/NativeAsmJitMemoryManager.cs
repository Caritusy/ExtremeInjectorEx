using System;
using System.Runtime.InteropServices;

public sealed class NativeAsmJitMemoryManager : AsmJitMemoryManager
{
	[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
	public delegate void ReleaseMemoryThisCall(IntPtr address, IntPtr address2);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ReleaseMemoryCdecl(IntPtr address, IntPtr address2);

	internal IntPtr virtualFunction;

	internal NativeAsmJitMemoryManager(IntPtr address)
	{
		this.virtualFunction = address;
	}

	internal T GetVirtualFunction<T>(int intValue)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(Marshal.ReadIntPtr(Marshal.ReadIntPtr(virtualFunction), intValue * IntPtr.Size), typeof(T));
	}

	public override void Release(IntPtr address)
	{
		if (AsmJitRuntime.flag)
		{
			this.GetVirtualFunction<NativeAsmJitMemoryManager.ReleaseMemoryCdecl>(2)(this.virtualFunction, address);
			return;
		}
		this.GetVirtualFunction<NativeAsmJitMemoryManager.ReleaseMemoryThisCall>(2)(this.virtualFunction, address);
	}
}
