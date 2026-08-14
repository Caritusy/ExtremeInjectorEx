using System;
using System.Runtime.InteropServices;

public static class Class51
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

	internal static MissingMethodException smethod_2(string string_0)
	{
		return new MissingMethodException(string_0);
	}

	internal static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static Delegate smethod_4(IntPtr intptr_0, Type type_0)
	{
		return Marshal.GetDelegateForFunctionPointer(intptr_0, type_0);
	}

	internal static object smethod_5(IntPtr intptr_0, Type type_0)
	{
		return Marshal.PtrToStructure(intptr_0, type_0);
	}
}
