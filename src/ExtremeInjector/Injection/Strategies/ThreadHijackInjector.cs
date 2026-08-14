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

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5, false, base.GetProcessId()));
		}
	}

	public override IntPtr Inject(string string_0)
	{
		if (PlatformInfo.bool_0 && !PlatformInfo.bool_1)
		{
			throw new PlatformNotSupportedException(EncodedStringTable.DecodeString(30373));
		}
		if (!Path.IsPathRooted(string_0))
		{
			string_0 = Path.GetFullPath(string_0);
		}
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(28151) + string_0 + EncodedStringTable.DecodeString(3656));
		}
		if (!base.EnsureAttachedToProcess(base.GetRemoteProcess().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(12662));
		}
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(base.GetRemoteProcess())[EncodedStringTable.DecodeString(8503)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(28636));
		}
		IntPtr intPtr = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(28709), false);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(28726));
		}
		IntPtr intPtr2 = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(30450), false);
		if (intPtr2 == IntPtr.Zero)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(30467));
		}
		List<ProcessThreadInfo> list = RecoveredRuntime.EnumerateProcessThreads(base.GetRemoteProcess());
		if (list.Count == 0)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(30564));
		}
		ProcessThreadInfo @class = list[0];
		NativeTypes.Enum31 @enum = NativeTypes.Enum31.flag_1 | NativeTypes.Enum31.flag_2 | NativeTypes.Enum31.flag_3;
		if (PlatformInfo.bool_0 && RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()))
		{
			@enum |= NativeTypes.Enum31.flag_5;
		}
		IntPtr intPtr3 = RecoveredRuntime.OpenThread(@enum, false, @class.GetThreadId());
		if (intPtr3 == IntPtr.Zero)
		{
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(30617));
		}
		if (RecoveredRuntime.SuspendThread(intPtr3) == -1)
		{
			RecoveredRuntime.CloseRemoteHandle(this, intPtr3);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(30694));
		}
		byte[] bytes = Encoding.Unicode.GetBytes(string_0 + EncodedStringTable.DecodeString(12219));
		int int_;
		int int_2;
		int int_3;
		IntPtr intPtr4;
		if (RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()))
		{
			intPtr4 = this.PrepareWow64Hijack(intPtr3, intPtr, intPtr2, bytes, out int_, out int_2, out int_3);
		}
		else
		{
			intPtr4 = this.PrepareX64Hijack(intPtr3, intPtr, intPtr2, bytes, out int_, out int_2, out int_3);
		}
		if (RecoveredRuntime.ResumeThread(intPtr3) == -1)
		{
			RecoveredRuntime.CloseRemoteHandle(this, intPtr3);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(30775));
		}
		bool flag = false;
		while (!(flag = RecoveredRuntime.HasProcessExited(base.GetRemoteProcess())) && base.Read<uint>(intPtr4.Add(int_)) == 0u)
		{
			Thread.Sleep(100);
		}
		if (flag)
		{
			throw new Exception(EncodedStringTable.DecodeString(28330));
		}
		int num = base.Read<int>(intPtr4.Add(int_3));
		if (num == 0)
		{
			IntPtr result = RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()) ? ((IntPtr)((long)((ulong)base.Read<uint>(intPtr4.Add(int_2))))) : base.Read<IntPtr>(intPtr4.Add(int_2));
			this.ReleaseMemory(intPtr4);
			RecoveredRuntime.CloseRemoteHandle(this, intPtr3);
			return result;
		}
		this.ReleaseMemory(intPtr4);
		RecoveredRuntime.CloseRemoteHandle(this, intPtr3);
		throw new Exception(EncodedStringTable.DecodeString(30909), new Win32Exception(num));
	}

	internal IntPtr PrepareWow64Hijack(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, byte[] byte_0, out int int_1, out int int_2, out int int_3)
	{
		int_3 = 0;
		NativeTypes.Struct54 @struct = default(NativeTypes.Struct54);
		@struct.enum21_0 = NativeTypes.Enum21.flag_2;
		NativeTypes.Struct54 struct2 = @struct;
		if (!(PlatformInfo.bool_0 ? RecoveredRuntime.Wow64GetThreadContext(intptr_1, ref struct2) : RecoveredRuntime.GetThreadContext(intptr_1, ref struct2)))
		{
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.CloseRemoteHandle(this, intptr_1);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(30974));
		}
		if (struct2.uint_18 == 51u)
		{
			RecoveredRuntime.ResumeThread(intptr_1);
			Thread.Sleep(1);
			RecoveredRuntime.SuspendThread(intptr_1);
			return this.PrepareWow64Hijack(intptr_1, intptr_2, intptr_3, byte_0, out int_1, out int_2, out int_3);
		}
		IntPtr intPtr = RecoveredRuntime.BuildThreadHijackStub32(this, intptr_2, intptr_3, byte_0, out struct2, out int_1, out int_2, ref int_3);
		if (intPtr == IntPtr.Zero)
		{
			this.ReleaseMemory(intPtr);
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.CloseRemoteHandle(this, intptr_1);
			throw new InvalidOperationException(EncodedStringTable.DecodeString(31039));
		}
		struct2.uint_17 = (uint)((int)intPtr);
		if (!(PlatformInfo.bool_0 ? RecoveredRuntime.Wow64SetThreadContext(intptr_1, ref struct2) : RecoveredRuntime.SetThreadContext32(intptr_1, ref struct2)))
		{
			this.ReleaseMemory(intPtr);
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.CloseRemoteHandle(this, intptr_1);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(31140));
		}
		return intPtr;
	}

	internal IntPtr PrepareX64Hijack(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, byte[] byte_0, out int int_1, out int int_2, out int int_3)
	{
		int_3 = 0;
		NativeTypes.Struct55 @struct = new NativeTypes.Struct55
		{
			enum22_0 = NativeTypes.Enum22.flag_1
		};
		if (!RecoveredRuntime.GetAlignedThreadContext(ref @struct, intptr_1))
		{
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.CloseRemoteHandle(this, intptr_1);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(30974));
		}
		IntPtr intPtr = RecoveredRuntime.BuildThreadHijackStub64(this, intptr_2, intptr_3, byte_0, out @struct, out int_1, out int_2, ref int_3);
		if (intPtr == IntPtr.Zero)
		{
			this.ReleaseMemory(intPtr);
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.CloseRemoteHandle(this, intptr_1);
			throw new InvalidOperationException(EncodedStringTable.DecodeString(31039));
		}
		@struct.ulong_28 = (ulong)((long)intPtr);
		if (!RecoveredRuntime.SetAlignedThreadContext(ref @struct, intptr_1))
		{
			this.ReleaseMemory(intPtr);
			RecoveredRuntime.ResumeThread(intptr_1);
			RecoveredRuntime.CloseRemoteHandle(this, intptr_1);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(31140));
		}
		return intPtr;
	}
}
