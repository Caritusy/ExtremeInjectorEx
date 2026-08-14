using System.ComponentModel;

public static class AsmJitOperandExtensions
{
	public static AsmJitImmediate smethod_0(this object object_0)
	{
		return (AsmJitImmediate)new AsmJitOperandConverter().ConvertFrom(object_0);
	}

	internal static object smethod_1(TypeConverter typeConverter_0, object object_0)
	{
		return typeConverter_0.ConvertFrom(object_0);
	}
}
