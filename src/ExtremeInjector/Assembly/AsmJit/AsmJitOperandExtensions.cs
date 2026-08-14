using System.ComponentModel;

public static class AsmJitOperandExtensions
{
	public static AsmJitImmediate ToImmediate(this object object_0)
	{
		return (AsmJitImmediate)new AsmJitOperandConverter().ConvertFrom(object_0);
	}
}
