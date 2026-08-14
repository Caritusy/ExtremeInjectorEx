using System;
using System.Runtime.InteropServices;

internal static class Class51
{
	internal static T smethod_0<T>(string string_0) where T : class
	{
		IntPtr intPtr = Class49.class123_0.method_2(string_0);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(string_0);
		}
		return (T)(object)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(T));
	}

	internal static T smethod_1<T>(string string_0)
	{
		IntPtr intPtr = Class49.class123_0.method_2(string_0);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(string_0);
		}
		return (T)Marshal.PtrToStructure(intPtr, typeof(T));
	}
}
