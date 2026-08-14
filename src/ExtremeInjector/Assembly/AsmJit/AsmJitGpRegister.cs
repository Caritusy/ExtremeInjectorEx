using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitGpRegister : AsmJitRegister
{
	public AsmJitGpRegister()
		: base(AsmJitRuntime.uintValue, 0u)
	{
	}
}
