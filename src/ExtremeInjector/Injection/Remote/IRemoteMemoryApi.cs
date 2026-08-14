using System;

public interface IRemoteMemoryApi
{
	IntPtr OpenProcessHandle(IntPtr address, int intValue);

	void ReadMemory(IntPtr address, IntPtr address2, IntPtr address3, UIntPtr address4, out UIntPtr address5);

	bool WriteMemory(IntPtr address, IntPtr address2, IntPtr address3, UIntPtr address4);

	bool ProtectMemory(IntPtr address, IntPtr address2, long longValue, NativeTypes.MemoryProtection memoryProtection, out NativeTypes.MemoryProtection memoryProtection2);

	IntPtr AllocateMemory(IntPtr address, IntPtr address2, long longValue, NativeTypes.MemoryProtection memoryProtection);

	bool FreeMemory(IntPtr address, IntPtr address2, long longValue, NativeTypes.MemoryFreeType memoryFreeType);

	void CloseHandle(IntPtr address);
}
