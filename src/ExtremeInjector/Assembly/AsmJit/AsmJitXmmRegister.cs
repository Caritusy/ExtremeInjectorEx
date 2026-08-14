using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public sealed class AsmJitXmmRegister : AsmJitRegister
{
	public AsmJitXmmRegister()
		: base(AsmJitRuntime.uint_0, 16u)
	{
	}
}
