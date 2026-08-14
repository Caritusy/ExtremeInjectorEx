using System.ComponentModel;

public static class AsmJitOperandExtensions
{
	public static AsmJitImmediate ToImmediate(this object instance)
	{
		return (AsmJitImmediate)new AsmJitOperandConverter().ConvertFrom(instance);
	}
}
