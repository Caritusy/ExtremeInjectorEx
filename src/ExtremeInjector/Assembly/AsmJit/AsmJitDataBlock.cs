using System;

public struct AsmJitDataBlock
{
	public IntPtr intptr_0;

	public IntPtr intptr_1;

	public IntPtr intptr_2;

	public void method_0()
	{
		if (this.intptr_0 == IntPtr.Zero)
		{
			return;
		}
		RecoveredRuntime.smethod_189(this.intptr_0);
		this.intptr_0 = (this.intptr_1 = (this.intptr_2 = IntPtr.Zero));
	}
}
