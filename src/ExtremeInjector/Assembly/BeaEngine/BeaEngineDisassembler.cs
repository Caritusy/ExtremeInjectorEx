using System;
using System.Runtime.InteropServices;

public static class BeaEngineDisassembler
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int Delegate44(ref BeaEngineDisasm struct31_0);

	internal static Delegate44 delegate44_0;

	static BeaEngineDisassembler()
	{
		delegate44_0 = (Delegate44)Marshal.GetDelegateForFunctionPointer(new NativeLibraryImage(PlatformInfo.bool_0 ? RecoveredRuntime.GetBeaEngineX64Image() : RecoveredRuntime.GetBeaEngineX86Image(), bool_0: true).GetExportAddress(PlatformInfo.bool_0 ? "Disasm" : "_Disasm@4"), typeof(Delegate44));
	}
}
