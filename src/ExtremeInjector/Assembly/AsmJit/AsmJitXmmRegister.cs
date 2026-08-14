using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitXmmRegister : AsmJitRegister
{
	public AsmJitXmmRegister()
		: base(AsmJitRuntime.uintValue, 16u)
	{
	}
}
