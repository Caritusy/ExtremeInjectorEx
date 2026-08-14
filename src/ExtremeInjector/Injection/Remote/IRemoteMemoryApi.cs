using System;

public interface IRemoteMemoryApi
{
	IntPtr OpenProcessHandle(IntPtr intptr_0, int int_0);

	void ReadMemory(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0, out UIntPtr uintptr_1);

	bool WriteMemory(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0);

	bool ProtectMemory(IntPtr intptr_0, IntPtr intptr_1, long long_0, NativeTypes.Enum34 enum34_0, out NativeTypes.Enum34 enum34_1);

	IntPtr AllocateMemory(IntPtr intptr_0, IntPtr intptr_1, long long_0, NativeTypes.Enum34 enum34_0);

	bool FreeMemory(IntPtr intptr_0, IntPtr intptr_1, long long_0, NativeTypes.Enum28 enum28_0);

	void CloseHandle(IntPtr intptr_0);
}
