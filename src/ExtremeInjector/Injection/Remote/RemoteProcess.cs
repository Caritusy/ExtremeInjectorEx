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

	internal bool bool_2;

	internal bool bool_3 = true;

	internal bool bool_4;

	internal List<RemoteMemoryAccessor> list_0 = new List<RemoteMemoryAccessor>();

	internal List<ProcessModuleInfo> list_1 = new List<ProcessModuleInfo>();

	internal Dictionary<ProcessModuleInfo, List<ExportedSymbol>> dictionary_0 = new Dictionary<ProcessModuleInfo, List<ExportedSymbol>>();

	internal NativeLoaderHooks gclass3_0;

	internal static readonly bool SupportsDepPolicyQuery =
		RecoveredRuntime.GetProcAddress(RecoveredRuntime.GetModuleHandle("kernel32.dll"), "GetProcessDEPPolicy") != IntPtr.Zero;

	internal RemoteProcess(uint processId)
	{
		ProcessId = checked((int)processId);
	}

	internal T TrackResource<T>(T resource) where T : RemoteMemoryAccessor
	{
		if (resource.method_0() == RecoveredRuntime.GetCurrentProcessId())
		{
			return resource;
		}

		list_0.Add(resource);
		if (bool_4)
		{
			return resource;
		}

		IntPtr processHandle = RecoveredRuntime.smethod_250(
			this,
			NativeTypes.Enum32.flag_11,
			bool_0: false,
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
		bool_4 = true;
		return resource;
	}

	private void OnProcessExited(object state, bool timedOut)
	{
		foreach (RemoteMemoryAccessor resource in list_0)
		{
			RecoveredRuntime.smethod_388(resource);
		}

		if (Handle != IntPtr.Zero)
		{
			RecoveredRuntime.CloseHandle(Handle);
			Handle = IntPtr.Zero;
		}

		list_0.Clear();
		bool_3 = false;
	}
}
