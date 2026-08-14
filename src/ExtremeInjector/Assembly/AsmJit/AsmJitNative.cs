using System;
using System.Runtime.InteropServices;

public static class AsmJitNative
{
	internal static T ResolveDelegate<T>(string text) where T : class
	{
		IntPtr intPtr = AsmJitRuntime.nativeLibraryImage.GetExportAddress(text);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(text);
		}
		return (T)(object)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(T));
	}

	internal static T ReadExportValue<T>(string text)
	{
		IntPtr intPtr = AsmJitRuntime.nativeLibraryImage.GetExportAddress(text);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(text);
		}
		return (T)Marshal.PtrToStructure(intPtr, typeof(T));
	}
}
