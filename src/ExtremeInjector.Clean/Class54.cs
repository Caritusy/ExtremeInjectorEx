using System;
using System.Runtime.InteropServices;

public abstract class Class54
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate IntPtr Delegate41();

	internal static Delegate41 delegate41_0;

	static Class54()
	{
		delegate41_0 = Class51.smethod_0<Delegate41>(Class49.bool_0 ? "?getGlobal@MemoryManager@AsmJit@@SAPEAU12@XZ" : "?getGlobal@MemoryManager@AsmJit@@SAPAU12@XZ");
	}

	public abstract void method_03FF(IntPtr intptr_0);
}
