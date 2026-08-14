using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading;

public sealed class ThreadHijackInjector : DllInjector
{
	public ThreadHijackInjector(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
	}

	protected override void method_04C6()
	{
		if (base.method_2() == IntPtr.Zero && base.method_0() != -1)
		{
			base.method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5, false, base.method_0()));
		}
	}

	public override IntPtr Inject(string string_0)
	{
		if (PlatformInfo.bool_0 && !PlatformInfo.bool_1)
		{
			throw new PlatformNotSupportedException(EncodedStringTable.smethod_0(30373));
		}
		if (!Path.IsPathRooted(string_0))
		{
			string_0 = Path.GetFullPath(string_0);
		}
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException(EncodedStringTable.smethod_0(28151) + string_0 + EncodedStringTable.smethod_0(3656));
		}
		if (!base.method_8(base.method_19().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(12662));
		}
		ProcessModuleInfo gclass = RecoveredRuntime.smethod_42(base.method_19())[EncodedStringTable.smethod_0(8503)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.smethod_0(28636));
		}
		IntPtr intPtr = RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(28709), false);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(EncodedStringTable.smethod_0(28726));
		}
		IntPtr intPtr2 = RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(30450), false);
		if (intPtr2 == IntPtr.Zero)
		{
			throw new MissingMethodException(EncodedStringTable.smethod_0(30467));
		}
		List<ProcessThreadInfo> list = RecoveredRuntime.smethod_179(base.method_19());
		if (list.Count == 0)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(30564));
		}
		ProcessThreadInfo @class = list[0];
		NativeTypes.Enum31 @enum = NativeTypes.Enum31.flag_1 | NativeTypes.Enum31.flag_2 | NativeTypes.Enum31.flag_3;
		if (PlatformInfo.bool_0 && RecoveredRuntime.smethod_427(base.method_19()))
		{
			@enum |= NativeTypes.Enum31.flag_5;
		}
		IntPtr intPtr3 = RecoveredRuntime.OpenThread(@enum, false, @class.method_0());
		if (intPtr3 == IntPtr.Zero)
		{
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(30617));
		}
		if (RecoveredRuntime.SuspendThread(intPtr3) == -1)
		{
			RecoveredRuntime.smethod_108(this, intPtr3);
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(30694));
		}
		byte[] bytes = Encoding.Unicode.GetBytes(string_0 + EncodedStringTable.smethod_0(12219));
		int int_;
		int int_2;
		int int_3;
		IntPtr intPtr4;
		if (RecoveredRuntime.smethod_427(base.method_19()))
		{
			intPtr4 = this.method_24(intPtr3, intPtr, intPtr2, bytes, out int_, out int_2, out int_3);
		}
		else
		{
			intPtr4 = this.method_25(intPtr3, intPtr, intPtr2, bytes, out int_, out int_2, out int_3);
		}
		if (RecoveredRuntime.ResumeThread(intPtr3) == -1)
		{
			RecoveredRuntime.smethod_108(this, intPtr3);
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(30775));
		}
		bool flag = false;
		while (!(flag = RecoveredRuntime.HasProcessExited(base.method_19())) && base.method_11<uint>(intPtr4.smethod_8(int_)) == 0u)
		{
			Thread.Sleep(100);
		}
		if (flag)
		{
			throw new Exception(EncodedStringTable.smethod_0(28330));
		}
		int num = base.method_11<int>(intPtr4.smethod_8(int_3));
		if (num == 0)
		{
			IntPtr result = RecoveredRuntime.smethod_427(base.method_19()) ? ((IntPtr)((long)((ulong)base.method_11<uint>(intPtr4.smethod_8(int_2))))) : base.method_11<IntPtr>(intPtr4.smethod_8(int_2));
			this.vmethod_6(intPtr4);
			RecoveredRuntime.smethod_108(this, intPtr3);
			return result;
		}
		this.vmethod_6(intPtr4);
		RecoveredRuntime.smethod_108(this, intPtr3);
		throw new Exception(EncodedStringTable.smethod_0(30909), new Win32Exception(num));
	}

	internal IntPtr method_24(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, byte[] byte_0, out int int_1, out int int_2, out int int_3)
	{
		int_3 = 0;
		NativeTypes.Struct54 @struct = default(NativeTypes.Struct54);
		@struct.enum21_0 = NativeTypes.Enum21.flag_2;
		NativeTypes.Struct54 struct2 = @struct;
		if (!(PlatformInfo.bool_0 ? RecoveredRuntime.Wow64GetThreadContext(intptr_1, ref struct2) : RecoveredRuntime.GetThreadContext(intptr_1, ref struct2)))
		{
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.smethod_108(this, intptr_1);
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(30974));
		}
		if (struct2.uint_18 == 51u)
		{
			RecoveredRuntime.ResumeThread(intptr_1);
			Thread.Sleep(1);
			RecoveredRuntime.SuspendThread(intptr_1);
			return this.method_24(intptr_1, intptr_2, intptr_3, byte_0, out int_1, out int_2, out int_3);
		}
		IntPtr intPtr = RecoveredRuntime.smethod_142(this, intptr_2, intptr_3, byte_0, out struct2, out int_1, out int_2, ref int_3);
		if (intPtr == IntPtr.Zero)
		{
			this.vmethod_6(intPtr);
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.smethod_108(this, intptr_1);
			throw new InvalidOperationException(EncodedStringTable.smethod_0(31039));
		}
		struct2.uint_17 = (uint)((int)intPtr);
		if (!(PlatformInfo.bool_0 ? RecoveredRuntime.Wow64SetThreadContext(intptr_1, ref struct2) : RecoveredRuntime.SetThreadContext_1(intptr_1, ref struct2)))
		{
			this.vmethod_6(intPtr);
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.smethod_108(this, intptr_1);
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(31140));
		}
		return intPtr;
	}

	internal IntPtr method_25(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, byte[] byte_0, out int int_1, out int int_2, out int int_3)
	{
		int_3 = 0;
		NativeTypes.Struct55 @struct = new NativeTypes.Struct55
		{
			enum22_0 = NativeTypes.Enum22.flag_1
		};
		if (!RecoveredRuntime.smethod_393(ref @struct, intptr_1))
		{
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.smethod_108(this, intptr_1);
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(30974));
		}
		IntPtr intPtr = RecoveredRuntime.smethod_178(this, intptr_2, intptr_3, byte_0, out @struct, out int_1, out int_2, ref int_3);
		if (intPtr == IntPtr.Zero)
		{
			this.vmethod_6(intPtr);
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.smethod_108(this, intptr_1);
			throw new InvalidOperationException(EncodedStringTable.smethod_0(31039));
		}
		@struct.ulong_28 = (ulong)((long)intPtr);
		if (!RecoveredRuntime.smethod_373(ref @struct, intptr_1))
		{
			this.vmethod_6(intPtr);
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.smethod_108(this, intptr_1);
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(31140));
		}
		return intPtr;
	}

	internal static PlatformNotSupportedException smethod_7(string string_0)
	{
		return new PlatformNotSupportedException(string_0);
	}

	internal static bool smethod_8(string string_0)
	{
		return Path.IsPathRooted(string_0);
	}

	internal static string smethod_9(string string_0)
	{
		return Path.GetFullPath(string_0);
	}

	internal static bool smethod_10(string string_0)
	{
		return File.Exists(string_0);
	}

	internal static string smethod_11(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	internal static FileNotFoundException smethod_12(string string_0)
	{
		return new FileNotFoundException(string_0);
	}

	internal static UnauthorizedAccessException smethod_13(string string_0)
	{
		return new UnauthorizedAccessException(string_0);
	}

	internal static MissingMethodException smethod_14(string string_0)
	{
		return new MissingMethodException(string_0);
	}

	internal static InvalidOperationException smethod_15(string string_0)
	{
		return new InvalidOperationException(string_0);
	}

	internal static Encoding smethod_16()
	{
		return Encoding.Unicode;
	}

	internal static string smethod_17(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static byte[] smethod_18(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	internal static void smethod_19(int int_1)
	{
		Thread.Sleep(int_1);
	}

	internal static Exception smethod_20(string string_0)
	{
		return new Exception(string_0);
	}

	internal static Win32Exception smethod_21(int int_1)
	{
		return new Win32Exception(int_1);
	}

	internal static Exception smethod_22(string string_0, Exception exception_0)
	{
		return new Exception(string_0, exception_0);
	}
}
