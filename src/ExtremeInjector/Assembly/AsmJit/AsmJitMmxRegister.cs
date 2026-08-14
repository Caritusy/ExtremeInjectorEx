using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitMmxRegister : AsmJitRegister
{
	public AsmJitMmxRegister()
		: base(AsmJitRuntime.uintValue, 8u)
	{
	}
}
