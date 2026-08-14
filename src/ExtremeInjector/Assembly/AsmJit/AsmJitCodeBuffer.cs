using System;

public struct AsmJitCodeBuffer
{
	public IntPtr address;

	public IntPtr address2;

	public IntPtr address3;

	public IntPtr address4;

	public IntPtr address5;

	public void Release()
	{
		if (this.address == IntPtr.Zero)
		{
			return;
		}
		RecoveredRuntime.ReleaseAsmJitAllocation(this.address);
		this.address = (this.address2 = (this.address3 = (this.address4 = IntPtr.Zero)));
	}
}
