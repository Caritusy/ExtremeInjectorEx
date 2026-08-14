using System;
using System.Runtime.InteropServices;

public static class BeaEngineDisassembler
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int Delegate44(ref BeaEngineDisasm struct31_0);

	internal static Delegate44 delegate44_0;

	static BeaEngineDisassembler()
	{
		delegate44_0 = (Delegate44)Marshal.GetDelegateForFunctionPointer(new NativeLibraryImage(PlatformInfo.bool_0 ? RecoveredRuntime.smethod_99() : RecoveredRuntime.smethod_180(), bool_0: true).method_2(PlatformInfo.bool_0 ? "Disasm" : "_Disasm@4"), typeof(Delegate44));
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
