using System;
using System.Runtime.InteropServices;

public struct AsmJitZone
{
	public IntPtr address;

	public IntPtr address2;

	public IntPtr address3;

	public void Release()
	{
		IntPtr intPtr = this.address;
		this.address = (this.address2 = IntPtr.Zero);
		while (intPtr != IntPtr.Zero)
		{
			IntPtr intPtr2 = ((AsmJitZoneChunk)Marshal.PtrToStructure(intPtr, typeof(AsmJitZoneChunk))).address;
			RecoveredRuntime.ReleaseAsmJitAllocation(intPtr);
			intPtr = intPtr2;
		}
	}
}
