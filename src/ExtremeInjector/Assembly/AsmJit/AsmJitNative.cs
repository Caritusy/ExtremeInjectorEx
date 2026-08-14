using System;
using System.Runtime.InteropServices;

public static class AsmJitNative
{
	internal static T ResolveDelegate<T>(string string_0) where T : class
	{
		IntPtr intPtr = AsmJitRuntime.class123_0.GetExportAddress(string_0);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(string_0);
		}
		return (T)(object)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(T));
	}

	internal static T ReadExportValue<T>(string string_0)
	{
		IntPtr intPtr = AsmJitRuntime.class123_0.GetExportAddress(string_0);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(string_0);
		}
		return (T)Marshal.PtrToStructure(intPtr, typeof(T));
	}
}
