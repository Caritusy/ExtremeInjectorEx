using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitMmxRegister : AsmJitRegister
{
	public AsmJitMmxRegister()
		: base(AsmJitRuntime.uint_0, 8u)
	{
	}
}
