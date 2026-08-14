using System;
using System.Runtime.InteropServices;

public static class AsmJitRuntime
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ReleaseNativeLibrary(IntPtr address);

	internal static NativeLibraryImage nativeLibraryImage;

	public static readonly bool flag;

	internal static readonly AsmJitUninitializedOperandTag uninitializedOperandTag;

	internal static ReleaseNativeLibrary releaseNativeLibrary;

	public static readonly uint uintValue;

	public static AsmJitGpRegister gpRegister;

	public static AsmJitGpRegister gpRegister2;

	public static AsmJitGpRegister gpRegister3;

	public static AsmJitGpRegister gpRegister4;

	public static AsmJitGpRegister gpRegister5;

	public static AsmJitGpRegister gpRegister6;

	public static AsmJitGpRegister gpRegister7;

	public static AsmJitGpRegister gpRegister8;

	public static AsmJitGpRegister gpRegister9;

	public static AsmJitGpRegister gpRegister10;

	public static AsmJitGpRegister gpRegister11;

	public static AsmJitGpRegister gpRegister12;

	public static AsmJitGpRegister gpRegister13;

	public static AsmJitGpRegister gpRegister14;

	public static AsmJitGpRegister gpRegister15;

	public static AsmJitGpRegister gpRegister16;

	public static AsmJitGpRegister gpRegister17;

	public static AsmJitGpRegister gpRegister18;

	public static AsmJitGpRegister gpRegister19;

	public static AsmJitGpRegister gpRegister20;

	public static AsmJitGpRegister gpRegister21;

	public static AsmJitGpRegister gpRegister22;

	public static AsmJitGpRegister gpRegister23;

	public static AsmJitGpRegister gpRegister24;

	public static AsmJitGpRegister gpRegister25;

	public static AsmJitGpRegister gpRegister26;

	public static AsmJitGpRegister gpRegister27;

	public static AsmJitGpRegister gpRegister28;

	public static AsmJitGpRegister gpRegister29;

	public static AsmJitGpRegister gpRegister30;

	public static AsmJitGpRegister gpRegister31;

	public static AsmJitGpRegister gpRegister32;

	public static AsmJitGpRegister gpRegister33;

	public static AsmJitGpRegister gpRegister34;

	public static AsmJitGpRegister gpRegister35;

	public static AsmJitGpRegister gpRegister36;

	public static AsmJitGpRegister gpRegister37;

	public static AsmJitGpRegister gpRegister38;

	public static AsmJitGpRegister gpRegister39;

	public static AsmJitGpRegister gpRegister40;

	public static AsmJitGpRegister gpRegister41;

	public static AsmJitGpRegister gpRegister42;

	public static AsmJitGpRegister gpRegister43;

	public static AsmJitGpRegister gpRegister44;

	public static AsmJitGpRegister gpRegister45;

	public static AsmJitGpRegister gpRegister46;

	public static AsmJitGpRegister gpRegister47;

	public static AsmJitGpRegister gpRegister48;

	public static AsmJitGpRegister gpRegister49;

	public static AsmJitGpRegister gpRegister50;

	public static AsmJitGpRegister gpRegister51;

	public static AsmJitGpRegister gpRegister52;

	public static AsmJitGpRegister gpRegister53;

	public static AsmJitGpRegister gpRegister54;

	public static AsmJitGpRegister gpRegister55;

	public static AsmJitGpRegister gpRegister56;

	public static AsmJitGpRegister gpRegister57;

	public static AsmJitGpRegister gpRegister58;

	public static AsmJitGpRegister gpRegister59;

	public static AsmJitGpRegister gpRegister60;

	public static AsmJitGpRegister gpRegister61;

	public static AsmJitGpRegister gpRegister62;

	public static AsmJitGpRegister gpRegister63;

	public static AsmJitGpRegister gpRegister64;

	public static AsmJitGpRegister gpRegister65;

	public static AsmJitGpRegister gpRegister66;

	public static AsmJitGpRegister gpRegister67;

	public static AsmJitGpRegister gpRegister68;

	public static AsmJitGpRegister gpRegister69;

	public static AsmJitGpRegister gpRegister70;

	public static AsmJitGpRegister gpRegister71;

	public static AsmJitGpRegister gpRegister72;

	public static AsmJitGpRegister gpRegister73;

	public static AsmJitGpRegister gpRegister74;

	public static AsmJitGpRegister gpRegister75;

	public static AsmJitGpRegister gpRegister76;

	public static AsmJitGpRegister gpRegister77;

	public static AsmJitMmxRegister mmxRegister;

	public static AsmJitMmxRegister mmxRegister2;

	public static AsmJitMmxRegister mmxRegister3;

	public static AsmJitMmxRegister mmxRegister4;

	public static AsmJitMmxRegister mmxRegister5;

	public static AsmJitMmxRegister mmxRegister6;

	public static AsmJitMmxRegister mmxRegister7;

	public static AsmJitMmxRegister mmxRegister8;

	public static AsmJitXmmRegister xmmRegister;

	public static AsmJitXmmRegister xmmRegister2;

	public static AsmJitXmmRegister xmmRegister3;

	public static AsmJitXmmRegister xmmRegister4;

	public static AsmJitXmmRegister xmmRegister5;

	public static AsmJitXmmRegister xmmRegister6;

	public static AsmJitXmmRegister xmmRegister7;

	public static AsmJitXmmRegister xmmRegister8;

	public static AsmJitXmmRegister xmmRegister9;

	public static AsmJitXmmRegister xmmRegister10;

	public static AsmJitXmmRegister xmmRegister11;

	public static AsmJitXmmRegister xmmRegister12;

	public static AsmJitXmmRegister xmmRegister13;

	public static AsmJitXmmRegister xmmRegister14;

	public static AsmJitXmmRegister xmmRegister15;

	public static AsmJitXmmRegister xmmRegister16;

	static AsmJitRuntime()
	{
		AsmJitRuntime.nativeLibraryImage = new NativeLibraryImage(AsmJitRuntime.flag ? RecoveredRuntime.GetAsmJitX64Image() : RecoveredRuntime.GetAsmJitX86Image(), true);
		RecoveredRuntime.InitializeAsmJitRegisters();
	}
}
