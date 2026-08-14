using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading;

public sealed class ThreadHijackInjector : DllInjector
{
	public ThreadHijackInjector(RemoteProcess remoteProcess)
		: base(remoteProcess)
	{
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.VirtualMemoryOperation | NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.VirtualMemoryWrite, false, base.GetProcessId()));
		}
	}

	public override IntPtr Inject(string text)
	{
		if (PlatformInfo.flag && !PlatformInfo.flag2)
		{
			throw new PlatformNotSupportedException(EncodedStringTable.DecodeString(30373));
		}
		if (!Path.IsPathRooted(text))
		{
			text = Path.GetFullPath(text);
		}
		if (!File.Exists(text))
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(28151) + text + EncodedStringTable.DecodeString(3656));
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
		NativeTypes.ThreadAccessRights @enum = NativeTypes.ThreadAccessRights.SuspendResume | NativeTypes.ThreadAccessRights.GetContext | NativeTypes.ThreadAccessRights.SetContext;
		if (PlatformInfo.flag && RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()))
		{
			@enum |= NativeTypes.ThreadAccessRights.QueryInformation;
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
		byte[] bytes = Encoding.Unicode.GetBytes(text + EncodedStringTable.DecodeString(12219));
		int int_;
		int intValue;
		int intValue2;
		IntPtr intPtr4;
		if (RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()))
		{
			intPtr4 = this.PrepareWow64Hijack(intPtr3, intPtr, intPtr2, bytes, out int_, out intValue, out intValue2);
		}
		else
		{
			intPtr4 = this.PrepareX64Hijack(intPtr3, intPtr, intPtr2, bytes, out int_, out intValue, out intValue2);
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
		int num = base.Read<int>(intPtr4.Add(intValue2));
		if (num == 0)
		{
			IntPtr result = RecoveredRuntime.Is32BitProcess(base.GetRemoteProcess()) ? ((IntPtr)((long)((ulong)base.Read<uint>(intPtr4.Add(intValue))))) : base.Read<IntPtr>(intPtr4.Add(intValue));
			this.ReleaseMemory(intPtr4);
			RecoveredRuntime.CloseRemoteHandle(this, intPtr3);
			return result;
		}
		this.ReleaseMemory(intPtr4);
		RecoveredRuntime.CloseRemoteHandle(this, intPtr3);
		throw new Exception(EncodedStringTable.DecodeString(30909), new Win32Exception(num));
	}

	internal IntPtr PrepareWow64Hijack(IntPtr address, IntPtr address2, IntPtr address3, byte[] bytes, out int intValue, out int intValue2, out int intValue3)
	{
		intValue3 = 0;
		NativeTypes.Context32 @struct = default(NativeTypes.Context32);
		@struct.x86ContextFlags = NativeTypes.X86ContextFlags.Control;
		NativeTypes.Context32 struct2 = @struct;
		if (!(PlatformInfo.flag ? RecoveredRuntime.Wow64GetThreadContext(address, ref struct2) : RecoveredRuntime.GetThreadContext(address, ref struct2)))
		{
			RecoveredRuntime.ResumeThread(address);
			RecoveredRuntime.CloseRemoteHandle(this, address);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(30974));
		}
		if (struct2.uintValue19 == 51u)
		{
			RecoveredRuntime.ResumeThread(address);
			Thread.Sleep(1);
			RecoveredRuntime.SuspendThread(address);
			return this.PrepareWow64Hijack(address, address2, address3, bytes, out intValue, out intValue2, out intValue3);
		}
		IntPtr intPtr = RecoveredRuntime.BuildThreadHijackStub32(this, address2, address3, bytes, out struct2, out intValue, out intValue2, ref intValue3);
		if (intPtr == IntPtr.Zero)
		{
			this.ReleaseMemory(intPtr);
			RecoveredRuntime.ResumeThread(address);
			RecoveredRuntime.CloseRemoteHandle(this, address);
			throw new InvalidOperationException(EncodedStringTable.DecodeString(31039));
		}
		struct2.uintValue18 = (uint)((int)intPtr);
		if (!(PlatformInfo.flag ? RecoveredRuntime.Wow64SetThreadContext(address, ref struct2) : RecoveredRuntime.SetThreadContext32(address, ref struct2)))
		{
			this.ReleaseMemory(intPtr);
			RecoveredRuntime.ResumeThread(address);
			RecoveredRuntime.CloseRemoteHandle(this, address);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(31140));
		}
		return intPtr;
	}

	internal IntPtr PrepareX64Hijack(IntPtr address, IntPtr address2, IntPtr address3, byte[] bytes, out int intValue, out int intValue2, out int intValue3)
	{
		intValue3 = 0;
		NativeTypes.Context64 @struct = new NativeTypes.Context64
		{
			x64ContextFlags = NativeTypes.X64ContextFlags.Control
		};
		if (!RecoveredRuntime.GetAlignedThreadContext(ref @struct, address))
		{
			RecoveredRuntime.ResumeThread(address);
			RecoveredRuntime.CloseRemoteHandle(this, address);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(30974));
		}
		IntPtr intPtr = RecoveredRuntime.BuildThreadHijackStub64(this, address2, address3, bytes, out @struct, out intValue, out intValue2, ref intValue3);
		if (intPtr == IntPtr.Zero)
		{
			this.ReleaseMemory(intPtr);
			RecoveredRuntime.ResumeThread(address);
			RecoveredRuntime.CloseRemoteHandle(this, address);
			throw new InvalidOperationException(EncodedStringTable.DecodeString(31039));
		}
		@struct.ulongValue29 = (ulong)((long)intPtr);
		if (!RecoveredRuntime.SetAlignedThreadContext(ref @struct, address))
		{
			this.ReleaseMemory(intPtr);
			RecoveredRuntime.ResumeThread(address);
			RecoveredRuntime.CloseRemoteHandle(this, address);
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(31140));
		}
		return intPtr;
	}
}
