using System;
using System.Runtime.InteropServices;

public static class BeaEngineDisassembler
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate int DisassembleInstruction(ref BeaEngineDisasm disasm);

	internal static DisassembleInstruction disassembleInstruction;

	static BeaEngineDisassembler()
	{
		disassembleInstruction = (DisassembleInstruction)Marshal.GetDelegateForFunctionPointer(new NativeLibraryImage(PlatformInfo.flag ? RecoveredRuntime.GetBeaEngineX64Image() : RecoveredRuntime.GetBeaEngineX86Image(), flag: true).GetExportAddress(PlatformInfo.flag ? "Disasm" : "_Disasm@4"), typeof(DisassembleInstruction));
	}
}
