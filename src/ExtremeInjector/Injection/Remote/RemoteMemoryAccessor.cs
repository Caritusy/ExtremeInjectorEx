using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public abstract class RemoteMemoryAccessor
{
	[CompilerGenerated]
	internal int processId;

	[CompilerGenerated]
	internal IntPtr processHandle;

	[CompilerGenerated]
	internal bool autoProtectMemory;

	[CompilerGenerated]
	internal IRemoteMemoryApi memoryApi;

	[SpecialName]
	[CompilerGenerated]
	public int GetProcessId()
	{
		return processId;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetProcessId(int intValue)
	{
		processId = intValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetProcessHandle()
	{
		return processHandle;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetProcessHandle(IntPtr address)
	{
		processHandle = address;
	}

	[SpecialName]
	[CompilerGenerated]
	protected bool GetAutoProtectMemory()
	{
		return autoProtectMemory;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void SetAutoProtectMemory(bool flag)
	{
		autoProtectMemory = flag;
	}

	[SpecialName]
	[CompilerGenerated]
	public IRemoteMemoryApi GetMemoryApi()
	{
		return memoryApi;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMemoryApi(IRemoteMemoryApi remoteMemoryApi)
	{
		memoryApi = remoteMemoryApi;
	}

	protected RemoteMemoryAccessor()
	{
	}

	protected RemoteMemoryAccessor(int intValue)
	{
		SetProcessId(intValue);
	}

	protected RemoteMemoryAccessor(IntPtr address)
	{
		SetProcessId(-1);
		SetProcessHandle(address);
	}

	protected internal bool EnsureAttachedToProcess(int intValue)
	{
		if (this.GetProcessId() != intValue || this.GetProcessHandle() == IntPtr.Zero)
		{
			this.SetProcessId(intValue);
			if (this.GetProcessHandle() != IntPtr.Zero)
			{
				RecoveredRuntime.CloseRemoteMemoryAccessor(this);
			}
			this.EnsureProcessHandle();
		}
		return this.GetProcessHandle() != IntPtr.Zero;
	}

	protected virtual void EnsureProcessHandle()
	{
		if (this.GetMemoryApi() != null)
		{
			this.SetProcessHandle(this.GetMemoryApi().OpenProcessHandle(this.GetProcessHandle(), this.GetProcessId()));
			return;
		}
		if (this.GetProcessHandle() == IntPtr.Zero && this.GetProcessId() != -1)
		{
			this.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.VirtualMemoryOperation | NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.VirtualMemoryWrite | NativeTypes.ProcessAccessRights.QueryInformation, false, this.GetProcessId()));
		}
	}

	protected virtual void ReadMemoryCore(IntPtr address, IntPtr address2, UIntPtr address3, out UIntPtr address4)
	{
		if (this.GetMemoryApi() != null)
		{
			this.GetMemoryApi().ReadMemory(this.GetProcessHandle(), address, address2, address3, out address4);
			return;
		}
		if (!RecoveredRuntime.ReadProcessMemory(this.GetProcessHandle(), address, address2, address3, out address4))
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(10098));
		}
		if (!(address3 != address4))
		{
			return;
		}
		throw new AccessViolationException(EncodedStringTable.DecodeString(10167));
	}

	protected void ReadMemory(IntPtr address, IntPtr address2, UIntPtr address3)
	{
		ReadMemoryCore(address, address2, address3, out var _);
	}

	protected internal unsafe T[] ReadArray<T>(IntPtr address, int intValue)
	{
		this.EnsureProcessHandle();
		Type typeFromHandle = typeof(T);
		if (typeFromHandle == typeof(byte))
		{
			byte[] bytes = new byte[intValue];
			fixed (byte* buffer = bytes)
			{
				this.ReadMemory(address, (IntPtr)buffer, (UIntPtr)(ulong)intValue);
			}
			return (T[])(object)bytes;
		}

		int elementSize = PlatformInfo.SizeOf<T>();
		int byteCount = checked(elementSize * intValue);
		IntPtr bufferPointer = Marshal.AllocHGlobal(byteCount);
		try
		{
			this.ReadMemory(address, bufferPointer, (UIntPtr)(ulong)byteCount);
			T[] result = new T[intValue];
			for (int index = 0; index < intValue; index++)
			{
				result[index] = (T)Marshal.PtrToStructure(bufferPointer.Add(index * elementSize), typeFromHandle);
			}
			return result;
		}
		finally
		{
			Marshal.FreeHGlobal(bufferPointer);
		}
	}

	protected internal T Read<T>(IntPtr address)
	{
		return (T)Read(typeof(T), address);
	}

	protected object Read(Type typeValue, IntPtr address)
	{
		this.EnsureProcessHandle();
		int num = RecoveredRuntime.GetCachedNativeTypeSize(typeValue);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		this.ReadMemory(address, intPtr, (UIntPtr)((ulong)((long)num)));
		object result = Marshal.PtrToStructure(intPtr, typeValue);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected internal bool Write<T>(IntPtr address, T value)
	{
		EnsureProcessHandle();
		int num = PlatformInfo.SizeOf<T>();
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr((object)value, intPtr, false);
		bool result = WriteMemoryWithProtection(intPtr, address, (UIntPtr)(ulong)num);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected virtual bool WriteMemoryCore(IntPtr address, IntPtr address2, UIntPtr address3)
	{
		if (GetMemoryApi() != null)
		{
			return GetMemoryApi().WriteMemory(GetProcessHandle(), address, address2, address3);
		}
		UIntPtr address4;
		return RecoveredRuntime.WriteProcessMemory(GetProcessHandle(), address2, address, address3, out address4);
	}

	protected virtual bool WriteMemoryWithProtection(IntPtr address, IntPtr address2, UIntPtr address3)
	{
		bool result;
		if (!(result = this.WriteMemoryCore(address, address2, address3)) && this.GetAutoProtectMemory())
		{
			NativeTypes.MemoryProtection enum34_;
			if (!this.ProtectMemoryCore(address2, (long)((ulong)address3), NativeTypes.MemoryProtection.ExecuteReadWrite, out enum34_) || !this.WriteMemoryCore(address, address2, address3) || !this.ProtectMemory(address2, (long)((ulong)address3), enum34_))
			{
				throw new AccessViolationException(EncodedStringTable.DecodeString(10244));
			}
			result = true;
		}
		return result;
	}

	protected virtual bool ProtectMemoryCore(IntPtr address, long longValue, NativeTypes.MemoryProtection memoryProtection, out NativeTypes.MemoryProtection memoryProtection2)
	{
		if (GetMemoryApi() != null)
		{
			return GetMemoryApi().ProtectMemory(GetProcessHandle(), address, longValue, memoryProtection, out memoryProtection2);
		}
		return RecoveredRuntime.VirtualProtectEx(GetProcessHandle(), address, (UIntPtr)(ulong)longValue, memoryProtection, out memoryProtection2);
	}

	protected bool ProtectMemory(IntPtr address, long longValue, NativeTypes.MemoryProtection memoryProtection)
	{
		NativeTypes.MemoryProtection memoryProtection2;
		return ProtectMemoryCore(address, longValue, memoryProtection, out memoryProtection2);
	}

	protected virtual IntPtr AllocateMemoryCore(IntPtr address, long longValue, NativeTypes.MemoryProtection memoryProtection)
	{
		if (GetMemoryApi() != null)
		{
			return GetMemoryApi().AllocateMemory(GetProcessHandle(), address, longValue, memoryProtection);
		}
		return RecoveredRuntime.VirtualAllocEx(GetProcessHandle(), address, (UIntPtr)(ulong)longValue, NativeTypes.MemoryAllocationType.Commit | NativeTypes.MemoryAllocationType.Reserve, memoryProtection);
	}

	protected internal IntPtr AllocateMemory(IntPtr address, long longValue, NativeTypes.MemoryProtection memoryProtection)
	{
		IntPtr result;
		if ((result = this.AllocateMemoryCore(address, longValue, memoryProtection)) == IntPtr.Zero && address != IntPtr.Zero)
		{
			return this.AllocateMemory(IntPtr.Zero, longValue, memoryProtection);
		}
		return result;
	}

	protected virtual bool FreeMemory(IntPtr address, long longValue, NativeTypes.MemoryFreeType memoryFreeType)
	{
		if (GetMemoryApi() != null)
		{
			return GetMemoryApi().FreeMemory(GetProcessHandle(), address, longValue, memoryFreeType);
		}
		return RecoveredRuntime.VirtualFreeEx(GetProcessHandle(), address, (UIntPtr)(ulong)longValue, memoryFreeType);
	}

	protected virtual bool ReleaseMemory(IntPtr address)
	{
		return RecoveredRuntime.VirtualFreeEx(GetProcessHandle(), address, UIntPtr.Zero, NativeTypes.MemoryFreeType.Release);
	}

	protected internal unsafe bool WriteArray<T>(IntPtr address, T[] valueArray)
	{
		EnsureProcessHandle();
		if (valueArray == null)
		{
			throw new ArgumentNullException(nameof(valueArray));
		}
		if (valueArray.Length == 0)
		{
			return true;
		}
		if (typeof(T) == typeof(byte))
		{
			byte[] bytes = (byte[])(object)valueArray;
			fixed (byte* pointer = bytes)
			{
				return WriteMemoryWithProtection((IntPtr)pointer, address, (UIntPtr)(ulong)bytes.Length);
			}
		}

		int elementSize = PlatformInfo.SizeOf<T>();
		int byteCount = checked(elementSize * valueArray.Length);
		IntPtr buffer = Marshal.AllocHGlobal(byteCount);
		try
		{
			for (int i = 0; i < valueArray.Length; i++)
			{
				Marshal.StructureToPtr((object)valueArray[i], buffer.Add(i * elementSize), false);
			}
			return WriteMemoryWithProtection(buffer, address, (UIntPtr)(ulong)byteCount);
		}
		finally
		{
			Marshal.FreeHGlobal(buffer);
		}
}
}
