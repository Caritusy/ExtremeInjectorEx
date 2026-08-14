using System;
using System.Runtime.InteropServices;

public struct AsmJitZone
{
	public IntPtr intptr_0;

	public IntPtr intptr_1;

	public IntPtr intptr_2;

	public void Release()
	{
		IntPtr intPtr = this.intptr_0;
		this.intptr_0 = (this.intptr_1 = IntPtr.Zero);
		while (intPtr != IntPtr.Zero)
		{
			IntPtr intPtr2 = ((AsmJitZoneChunk)Marshal.PtrToStructure(intPtr, typeof(AsmJitZoneChunk))).intptr_0;
			RecoveredRuntime.ReleaseAsmJitAllocation(intPtr);
			intPtr = intPtr2;
		}
	}
}
