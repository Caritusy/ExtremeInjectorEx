using System;
using System.Runtime.InteropServices;

public abstract class AsmJitMemoryManager
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate41();

	internal static Delegate41 delegate41_0;

	static AsmJitMemoryManager()
	{
		delegate41_0 = AsmJitNative.ResolveDelegate<Delegate41>(AsmJitRuntime.bool_0 ? "?getGlobal@MemoryManager@AsmJit@@SAPEAU12@XZ" : "?getGlobal@MemoryManager@AsmJit@@SAPAU12@XZ");
	}

	public abstract void Release(IntPtr intptr_0);
}
