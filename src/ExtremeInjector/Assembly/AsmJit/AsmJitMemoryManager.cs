using System;
using System.Runtime.InteropServices;

public abstract class AsmJitMemoryManager
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr GetGlobalMemoryManager();

	internal static GetGlobalMemoryManager getGlobalMemoryManager;

	static AsmJitMemoryManager()
	{
		getGlobalMemoryManager = AsmJitNative.ResolveDelegate<GetGlobalMemoryManager>(AsmJitRuntime.flag ? "?getGlobal@MemoryManager@AsmJit@@SAPEAU12@XZ" : "?getGlobal@MemoryManager@AsmJit@@SAPAU12@XZ");
	}

	public abstract void Release(IntPtr address);
}
