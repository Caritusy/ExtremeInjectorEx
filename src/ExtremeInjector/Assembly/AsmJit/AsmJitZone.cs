using System;
using System.Runtime.InteropServices;

public struct AsmJitZone
{
	public IntPtr intptr_0;

	public IntPtr intptr_1;

	public IntPtr intptr_2;

	public void method_0()
	{
		IntPtr intPtr = this.intptr_0;
		this.intptr_0 = (this.intptr_1 = IntPtr.Zero);
		while (intPtr != IntPtr.Zero)
		{
			IntPtr intPtr2 = ((AsmJitZoneChunk)Marshal.PtrToStructure(intPtr, typeof(AsmJitZoneChunk))).intptr_0;
			RecoveredRuntime.smethod_189(intPtr);
			intPtr = intPtr2;
		}
	}

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object smethod_1(IntPtr intptr_3, Type type_0)
	{
		return Marshal.PtrToStructure(intptr_3, type_0);
	}
}
