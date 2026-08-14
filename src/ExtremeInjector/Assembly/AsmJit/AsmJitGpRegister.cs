using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitGpRegister : AsmJitRegister
{
	public AsmJitGpRegister()
		: base(AsmJitRuntime.uint_0, 0u)
	{
	}
}
