using System;

public struct AsmJitCodeBuffer
{
	public IntPtr intptr_0;

	public IntPtr intptr_1;

	public IntPtr intptr_2;

	public IntPtr intptr_3;

	public IntPtr intptr_4;

	public void Release()
	{
		if (this.intptr_0 == IntPtr.Zero)
		{
			return;
		}
		RecoveredRuntime.ReleaseAsmJitAllocation(this.intptr_0);
		this.intptr_0 = (this.intptr_1 = (this.intptr_2 = (this.intptr_3 = IntPtr.Zero)));
	}
}
