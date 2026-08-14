using System;

public struct AsmJitDataBlock
{
	public IntPtr address;

	public IntPtr address2;

	public IntPtr address3;

	public void Release()
	{
		if (this.address == IntPtr.Zero)
		{
			return;
		}
		RecoveredRuntime.ReleaseAsmJitAllocation(this.address);
		this.address = (this.address2 = (this.address3 = IntPtr.Zero));
	}
}
