using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public abstract class RemoteMemoryAccessor
{
	[CompilerGenerated]
	internal int int_0;

	[CompilerGenerated]
	internal IntPtr intptr_0;

	[CompilerGenerated]
	internal bool bool_0;

	[CompilerGenerated]
	internal IRemoteMemoryApi interface4_0;

	[SpecialName]
	[CompilerGenerated]
	public int GetProcessId()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetProcessId(int int_1)
	{
		int_0 = int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetProcessHandle()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetProcessHandle(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	protected bool GetAutoProtectMemory()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void SetAutoProtectMemory(bool bool_1)
	{
		bool_0 = bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public IRemoteMemoryApi GetMemoryApi()
	{
		return interface4_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetMemoryApi(IRemoteMemoryApi interface4_1)
	{
		interface4_0 = interface4_1;
	}

	protected RemoteMemoryAccessor()
	{
	}

	protected RemoteMemoryAccessor(int int_1)
	{
		SetProcessId(int_1);
	}

	protected RemoteMemoryAccessor(IntPtr intptr_1)
	{
		SetProcessId(-1);
		SetProcessHandle(intptr_1);
	}

	protected internal bool EnsureAttachedToProcess(int int_1)
	{
		if (this.GetProcessId() != int_1 || this.GetProcessHandle() == IntPtr.Zero)
		{
			this.SetProcessId(int_1);
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
			this.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, this.GetProcessId()));
		}
	}

	protected virtual void ReadMemoryCore(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0, out UIntPtr uintptr_1)
	{
		if (this.GetMemoryApi() != null)
		{
			this.GetMemoryApi().ReadMemory(this.GetProcessHandle(), intptr_1, intptr_2, uintptr_0, out uintptr_1);
			return;
		}
		if (!RecoveredRuntime.ReadProcessMemory(this.GetProcessHandle(), intptr_1, intptr_2, uintptr_0, out uintptr_1))
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(10098));
		}
		if (!(uintptr_0 != uintptr_1))
		{
			return;
		}
		throw new AccessViolationException(EncodedStringTable.DecodeString(10167));
	}

	protected void ReadMemory(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0)
	{
		ReadMemoryCore(intptr_1, intptr_2, uintptr_0, out var _);
	}

	protected internal unsafe T[] ReadArray<T>(IntPtr intptr_1, int int_1)
	{
		this.EnsureProcessHandle();
		Type typeFromHandle = typeof(T);
		if (typeFromHandle == typeof(byte))
		{
			byte[] bytes = new byte[int_1];
			fixed (byte* buffer = bytes)
			{
				this.ReadMemory(intptr_1, (IntPtr)buffer, (UIntPtr)(ulong)int_1);
			}
			return (T[])(object)bytes;
		}

		int elementSize = PlatformInfo.SizeOf<T>();
		int byteCount = checked(elementSize * int_1);
		IntPtr bufferPointer = Marshal.AllocHGlobal(byteCount);
		try
		{
			this.ReadMemory(intptr_1, bufferPointer, (UIntPtr)(ulong)byteCount);
			T[] result = new T[int_1];
			for (int index = 0; index < int_1; index++)
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

	protected internal T Read<T>(IntPtr intptr_1)
	{
		return (T)Read(typeof(T), intptr_1);
	}

	protected object Read(Type type_0, IntPtr intptr_1)
	{
		this.EnsureProcessHandle();
		int num = RecoveredRuntime.GetCachedNativeTypeSize(type_0);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		this.ReadMemory(intptr_1, intPtr, (UIntPtr)((ulong)((long)num)));
		object result = Marshal.PtrToStructure(intPtr, type_0);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected internal bool Write<T>(IntPtr intptr_1, T gparam_0)
	{
		EnsureProcessHandle();
		int num = PlatformInfo.SizeOf<T>();
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr((object)gparam_0, intPtr, false);
		bool result = WriteMemoryWithProtection(intPtr, intptr_1, (UIntPtr)(ulong)num);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected virtual bool WriteMemoryCore(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0)
	{
		if (GetMemoryApi() != null)
		{
			return GetMemoryApi().WriteMemory(GetProcessHandle(), intptr_1, intptr_2, uintptr_0);
		}
		UIntPtr uintptr_1;
		return RecoveredRuntime.WriteProcessMemory(GetProcessHandle(), intptr_2, intptr_1, uintptr_0, out uintptr_1);
	}

	protected virtual bool WriteMemoryWithProtection(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0)
	{
		bool result;
		if (!(result = this.WriteMemoryCore(intptr_1, intptr_2, uintptr_0)) && this.GetAutoProtectMemory())
		{
			NativeTypes.Enum34 enum34_;
			if (!this.ProtectMemoryCore(intptr_2, (long)((ulong)uintptr_0), NativeTypes.Enum34.flag_2, out enum34_) || !this.WriteMemoryCore(intptr_1, intptr_2, uintptr_0) || !this.ProtectMemory(intptr_2, (long)((ulong)uintptr_0), enum34_))
			{
				throw new AccessViolationException(EncodedStringTable.DecodeString(10244));
			}
			result = true;
		}
		return result;
	}

	protected virtual bool ProtectMemoryCore(IntPtr intptr_1, long long_0, NativeTypes.Enum34 enum34_0, out NativeTypes.Enum34 enum34_1)
	{
		if (GetMemoryApi() != null)
		{
			return GetMemoryApi().ProtectMemory(GetProcessHandle(), intptr_1, long_0, enum34_0, out enum34_1);
		}
		return RecoveredRuntime.VirtualProtectEx(GetProcessHandle(), intptr_1, (UIntPtr)(ulong)long_0, enum34_0, out enum34_1);
	}

	protected bool ProtectMemory(IntPtr intptr_1, long long_0, NativeTypes.Enum34 enum34_0)
	{
		NativeTypes.Enum34 enum34_1;
		return ProtectMemoryCore(intptr_1, long_0, enum34_0, out enum34_1);
	}

	protected virtual IntPtr AllocateMemoryCore(IntPtr intptr_1, long long_0, NativeTypes.Enum34 enum34_0)
	{
		if (GetMemoryApi() != null)
		{
			return GetMemoryApi().AllocateMemory(GetProcessHandle(), intptr_1, long_0, enum34_0);
		}
		return RecoveredRuntime.VirtualAllocEx(GetProcessHandle(), intptr_1, (UIntPtr)(ulong)long_0, NativeTypes.Enum33.flag_0 | NativeTypes.Enum33.flag_1, enum34_0);
	}

	protected internal IntPtr AllocateMemory(IntPtr intptr_1, long long_0, NativeTypes.Enum34 enum34_0)
	{
		IntPtr result;
		if ((result = this.AllocateMemoryCore(intptr_1, long_0, enum34_0)) == IntPtr.Zero && intptr_1 != IntPtr.Zero)
		{
			return this.AllocateMemory(IntPtr.Zero, long_0, enum34_0);
		}
		return result;
	}

	protected virtual bool FreeMemory(IntPtr intptr_1, long long_0, NativeTypes.Enum28 enum28_0)
	{
		if (GetMemoryApi() != null)
		{
			return GetMemoryApi().FreeMemory(GetProcessHandle(), intptr_1, long_0, enum28_0);
		}
		return RecoveredRuntime.VirtualFreeEx(GetProcessHandle(), intptr_1, (UIntPtr)(ulong)long_0, enum28_0);
	}

	protected virtual bool ReleaseMemory(IntPtr intptr_1)
	{
		return RecoveredRuntime.VirtualFreeEx(GetProcessHandle(), intptr_1, UIntPtr.Zero, NativeTypes.Enum28.const_1);
	}

	protected internal unsafe bool WriteArray<T>(IntPtr intptr_1, T[] gparam_0)
	{
		EnsureProcessHandle();
		if (gparam_0 == null)
		{
			throw new ArgumentNullException(nameof(gparam_0));
		}
		if (gparam_0.Length == 0)
		{
			return true;
		}
		if (typeof(T) == typeof(byte))
		{
			byte[] bytes = (byte[])(object)gparam_0;
			fixed (byte* pointer = bytes)
			{
				return WriteMemoryWithProtection((IntPtr)pointer, intptr_1, (UIntPtr)(ulong)bytes.Length);
			}
		}

		int elementSize = PlatformInfo.SizeOf<T>();
		int byteCount = checked(elementSize * gparam_0.Length);
		IntPtr buffer = Marshal.AllocHGlobal(byteCount);
		try
		{
			for (int i = 0; i < gparam_0.Length; i++)
			{
				Marshal.StructureToPtr((object)gparam_0[i], buffer.Add(i * elementSize), false);
			}
			return WriteMemoryWithProtection(buffer, intptr_1, (UIntPtr)(ulong)byteCount);
		}
		finally
		{
			Marshal.FreeHGlobal(buffer);
		}
}
}
