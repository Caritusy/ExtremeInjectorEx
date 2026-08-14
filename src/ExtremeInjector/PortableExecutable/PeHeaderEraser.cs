using System;
using System.Runtime.CompilerServices;

public sealed class PeHeaderEraser : RemoteMemoryAccessor, IDisposable
{
	[CompilerGenerated]
	internal RemoteProcess remoteProcess;

	[SpecialName]
	[CompilerGenerated]
	public RemoteProcess GetRemoteProcess()
	{
		return remoteProcess;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetRemoteProcess(RemoteProcess remoteProcess2)
	{
		remoteProcess = remoteProcess2;
	}

	public PeHeaderEraser(RemoteProcess remoteProcess2)
	{
		SetRemoteProcess(remoteProcess2);
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.VirtualMemoryOperation | NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.VirtualMemoryWrite | NativeTypes.ProcessAccessRights.QueryInformation, false, base.GetProcessId()));
		}
	}

	public void EraseAt(IntPtr address)
	{
		if (!base.EnsureAttachedToProcess(this.GetRemoteProcess().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(9714));
		}
		NativeTypes.MemoryBasicInformation @struct;
		if (NativeTypes.VirtualQueryEx(base.GetProcessHandle(), address, out @struct, (uint)NativeTypes.intValue) == 0)
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(9791));
		}
		NativeTypes.MemoryProtection enum34_;
		if (!this.ProtectMemoryCore(address, @struct.address3.ToInt64(), NativeTypes.MemoryProtection.ReadWrite, out enum34_))
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(9876));
		}
		byte[] array = new byte[@struct.address3.ToInt64()];
		PlatformInfo.randomElement.NextBytes(array);
		if (!base.WriteArray<byte>(address, array))
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(9949));
		}
		if (!base.ProtectMemory(address, @struct.address3.ToInt64(), enum34_))
		{
			throw new AccessViolationException(EncodedStringTable.DecodeString(9998));
		}
	}

	void IDisposable.Dispose()
	{
		RecoveredRuntime.CloseRemoteMemoryAccessor(this);
	}
}
