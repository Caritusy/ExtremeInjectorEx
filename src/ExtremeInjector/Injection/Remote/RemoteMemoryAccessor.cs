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
	public int method_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(int int_1)
	{
		int_0 = int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_2()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	protected bool method_4()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void method_5(bool bool_1)
	{
		bool_0 = bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public IRemoteMemoryApi method_6()
	{
		return interface4_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(IRemoteMemoryApi interface4_1)
	{
		interface4_0 = interface4_1;
	}

	protected RemoteMemoryAccessor()
	{
	}

	protected RemoteMemoryAccessor(int int_1)
	{
		method_1(int_1);
	}

	protected RemoteMemoryAccessor(IntPtr intptr_1)
	{
		method_1(-1);
		method_3(intptr_1);
	}

	protected internal bool method_8(int int_1)
	{
		if (this.method_0() != int_1 || this.method_2() == IntPtr.Zero)
		{
			this.method_1(int_1);
			if (this.method_2() != IntPtr.Zero)
			{
				RecoveredRuntime.smethod_388(this);
			}
			this.method_04C6();
		}
		return this.method_2() != IntPtr.Zero;
	}

	protected virtual void method_04C6()
	{
		if (this.method_6() != null)
		{
			this.method_3(this.method_6().imethod_0(this.method_2(), this.method_0()));
			return;
		}
		if (this.method_2() == IntPtr.Zero && this.method_0() != -1)
		{
			this.method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, this.method_0()));
		}
	}

	protected virtual void vmethod_0(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0, out UIntPtr uintptr_1)
	{
		if (this.method_6() != null)
		{
			this.method_6().imethod_1(this.method_2(), intptr_1, intptr_2, uintptr_0, out uintptr_1);
			return;
		}
		if (!RecoveredRuntime.ReadProcessMemory(this.method_2(), intptr_1, intptr_2, uintptr_0, out uintptr_1))
		{
			throw new AccessViolationException(EncodedStringTable.smethod_0(10098));
		}
		if (!(uintptr_0 != uintptr_1))
		{
			return;
		}
		throw new AccessViolationException(EncodedStringTable.smethod_0(10167));
	}

	protected void method_9(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0)
	{
		vmethod_0(intptr_1, intptr_2, uintptr_0, out var _);
	}

	protected internal unsafe T[] method_10<T>(IntPtr intptr_1, int int_1)
	{
		this.method_04C6();
		Type typeFromHandle = typeof(T);
		if (typeFromHandle == typeof(byte))
		{
			byte[] bytes = new byte[int_1];
			fixed (byte* buffer = bytes)
			{
				this.method_9(intptr_1, (IntPtr)buffer, (UIntPtr)(ulong)int_1);
			}
			return (T[])(object)bytes;
		}

		int elementSize = PlatformInfo.smethod_1<T>();
		int byteCount = checked(elementSize * int_1);
		IntPtr bufferPointer = Marshal.AllocHGlobal(byteCount);
		try
		{
			this.method_9(intptr_1, bufferPointer, (UIntPtr)(ulong)byteCount);
			T[] result = new T[int_1];
			for (int index = 0; index < int_1; index++)
			{
				result[index] = (T)Marshal.PtrToStructure(bufferPointer.smethod_8(index * elementSize), typeFromHandle);
			}
			return result;
		}
		finally
		{
			Marshal.FreeHGlobal(bufferPointer);
		}
	}

	protected internal T method_11<T>(IntPtr intptr_1)
	{
		return (T)method_12(typeof(T), intptr_1);
	}

	protected object method_12(Type type_0, IntPtr intptr_1)
	{
		this.method_04C6();
		int num = RecoveredRuntime.smethod_232(type_0);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		this.method_9(intptr_1, intPtr, (UIntPtr)((ulong)((long)num)));
		object result = Marshal.PtrToStructure(intPtr, type_0);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected internal bool method_13<T>(IntPtr intptr_1, T gparam_0)
	{
		method_04C6();
		int num = PlatformInfo.smethod_1<T>();
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr((object)gparam_0, intPtr, false);
		bool result = vmethod_2(intPtr, intptr_1, (UIntPtr)(ulong)num);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	protected virtual bool vmethod_1(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0)
	{
		if (method_6() != null)
		{
			return method_6().imethod_2(method_2(), intptr_1, intptr_2, uintptr_0);
		}
		UIntPtr uintptr_1;
		return RecoveredRuntime.WriteProcessMemory(method_2(), intptr_2, intptr_1, uintptr_0, out uintptr_1);
	}

	protected virtual bool vmethod_2(IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0)
	{
		bool result;
		if (!(result = this.vmethod_1(intptr_1, intptr_2, uintptr_0)) && this.method_4())
		{
			NativeTypes.Enum34 enum34_;
			if (!this.vmethod_3(intptr_2, (long)((ulong)uintptr_0), NativeTypes.Enum34.flag_2, out enum34_) || !this.vmethod_1(intptr_1, intptr_2, uintptr_0) || !this.method_14(intptr_2, (long)((ulong)uintptr_0), enum34_))
			{
				throw new AccessViolationException(EncodedStringTable.smethod_0(10244));
			}
			result = true;
		}
		return result;
	}

	protected virtual bool vmethod_3(IntPtr intptr_1, long long_0, NativeTypes.Enum34 enum34_0, out NativeTypes.Enum34 enum34_1)
	{
		if (method_6() != null)
		{
			return method_6().imethod_3(method_2(), intptr_1, long_0, enum34_0, out enum34_1);
		}
		return RecoveredRuntime.VirtualProtectEx(method_2(), intptr_1, (UIntPtr)(ulong)long_0, enum34_0, out enum34_1);
	}

	protected bool method_14(IntPtr intptr_1, long long_0, NativeTypes.Enum34 enum34_0)
	{
		NativeTypes.Enum34 enum34_1;
		return vmethod_3(intptr_1, long_0, enum34_0, out enum34_1);
	}

	protected virtual IntPtr vmethod_4(IntPtr intptr_1, long long_0, NativeTypes.Enum34 enum34_0)
	{
		if (method_6() != null)
		{
			return method_6().imethod_4(method_2(), intptr_1, long_0, enum34_0);
		}
		return RecoveredRuntime.VirtualAllocEx(method_2(), intptr_1, (UIntPtr)(ulong)long_0, NativeTypes.Enum33.flag_0 | NativeTypes.Enum33.flag_1, enum34_0);
	}

	protected internal IntPtr method_15(IntPtr intptr_1, long long_0, NativeTypes.Enum34 enum34_0)
	{
		IntPtr result;
		if ((result = this.vmethod_4(intptr_1, long_0, enum34_0)) == IntPtr.Zero && intptr_1 != IntPtr.Zero)
		{
			return this.method_15(IntPtr.Zero, long_0, enum34_0);
		}
		return result;
	}

	protected virtual bool vmethod_5(IntPtr intptr_1, long long_0, NativeTypes.Enum28 enum28_0)
	{
		if (method_6() != null)
		{
			return method_6().imethod_5(method_2(), intptr_1, long_0, enum28_0);
		}
		return RecoveredRuntime.VirtualFreeEx(method_2(), intptr_1, (UIntPtr)(ulong)long_0, enum28_0);
	}

	protected virtual bool vmethod_6(IntPtr intptr_1)
	{
		return RecoveredRuntime.VirtualFreeEx(method_2(), intptr_1, UIntPtr.Zero, NativeTypes.Enum28.const_1);
	}

	protected internal unsafe bool method_16<T>(IntPtr intptr_1, T[] gparam_0)
	{
		method_04C6();
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
				return vmethod_2((IntPtr)pointer, intptr_1, (UIntPtr)(ulong)bytes.Length);
			}
		}

		int elementSize = PlatformInfo.smethod_1<T>();
		int byteCount = checked(elementSize * gparam_0.Length);
		IntPtr buffer = Marshal.AllocHGlobal(byteCount);
		try
		{
			for (int i = 0; i < gparam_0.Length; i++)
			{
				Marshal.StructureToPtr((object)gparam_0[i], buffer.smethod_8(i * elementSize), false);
			}
			return vmethod_2(buffer, intptr_1, (UIntPtr)(ulong)byteCount);
		}
		finally
		{
			Marshal.FreeHGlobal(buffer);
		}
}

	internal static AccessViolationException smethod_0(string string_0)
	{
		return new AccessViolationException(string_0);
	}

	internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static IntPtr smethod_2(int int_1)
	{
		return Marshal.AllocHGlobal(int_1);
	}

	internal static object smethod_3(IntPtr intptr_1, Type type_0)
	{
		return Marshal.PtrToStructure(intptr_1, type_0);
	}

	internal static void smethod_4(IntPtr intptr_1)
	{
		Marshal.FreeHGlobal(intptr_1);
	}

	internal static void smethod_5(object object_0, IntPtr intptr_1, bool bool_1)
	{
		Marshal.StructureToPtr(object_0, intptr_1, bool_1);
	}
}
