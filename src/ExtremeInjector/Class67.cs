using System.Runtime.InteropServices;

internal static class Class67
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int Delegate44(ref Struct31 struct31_0);

	internal static Delegate44 delegate44_0;

	static Class67()
	{
		delegate44_0 = (Delegate44)Marshal.GetDelegateForFunctionPointer(new Class123(Class127.bool_0 ? Class171.smethod_99() : Class171.smethod_179()).method_2(Class127.bool_0 ? Class178.smethod_0(8489) : Class178.smethod_0(8476)), typeof(Delegate44));
	}
}
