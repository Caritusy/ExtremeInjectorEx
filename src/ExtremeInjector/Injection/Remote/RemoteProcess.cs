using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Win32.SafeHandles;

public sealed class RemoteProcess
{
	private sealed class OwnedProcessWaitHandle : WaitHandle
	{
		internal OwnedProcessWaitHandle(IntPtr handle)
		{
			SafeWaitHandle = new SafeWaitHandle(handle, ownsHandle: true);
		}
	}

	public int ProcessId { get; }

	public string Name { get; internal set; }

	public string FilePath { get; internal set; }

	public bool Is64Bit { get; internal set; }

	public bool IsDepEnabled { get; internal set; }

	public IntPtr Handle { get; internal set; }

	internal bool flag;

	internal bool flag2 = true;

	internal bool flag3;

	internal List<RemoteMemoryAccessor> items = new List<RemoteMemoryAccessor>();

	internal List<ProcessModuleInfo> items2 = new List<ProcessModuleInfo>();

	internal Dictionary<ProcessModuleInfo, List<ExportedSymbol>> dictionary = new Dictionary<ProcessModuleInfo, List<ExportedSymbol>>();

	internal NativeLoaderHooks nativeLoaderHooks;

	internal static readonly bool SupportsDepPolicyQuery =
		RecoveredRuntime.GetProcAddress(RecoveredRuntime.GetModuleHandle("kernel32.dll"), "GetProcessDEPPolicy") != IntPtr.Zero;

	internal RemoteProcess(uint processId)
	{
		ProcessId = checked((int)processId);
	}

	internal T TrackResource<T>(T resource) where T : RemoteMemoryAccessor
	{
		if (resource.GetProcessId() == RecoveredRuntime.GetCurrentProcessId())
		{
			return resource;
		}

		items.Add(resource);
		if (flag3)
		{
			return resource;
		}

		IntPtr processHandle = RecoveredRuntime.OpenOrReuseProcessHandle(
			this,
			NativeTypes.ProcessAccessRights.Synchronize,
			flag: false,
			ProcessId);
		if (processHandle == IntPtr.Zero)
		{
			return resource;
		}

		ThreadPool.RegisterWaitForSingleObject(
			new OwnedProcessWaitHandle(processHandle),
			OnProcessExited,
			null,
			-1,
			executeOnlyOnce: true);
		flag3 = true;
		return resource;
	}

	private void OnProcessExited(object state, bool timedOut)
	{
		foreach (RemoteMemoryAccessor resource in items)
		{
			RecoveredRuntime.CloseRemoteMemoryAccessor(resource);
		}

		if (Handle != IntPtr.Zero)
		{
			RecoveredRuntime.CloseHandle(Handle);
			Handle = IntPtr.Zero;
		}

		items.Clear();
		flag2 = false;
	}
}
