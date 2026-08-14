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

	internal List<Class82> list_0 = new List<Class82>();

	internal List<GClass1> list_1 = new List<GClass1>();

	internal Dictionary<GClass1, List<Class152>> dictionary_0 = new Dictionary<GClass1, List<Class152>>();

	internal GClass3 gclass3_0;

	internal static readonly bool SupportsDepPolicyQuery =
		Class171.GetProcAddress(Class171.GetModuleHandle("kernel32.dll"), "GetProcessDEPPolicy") != IntPtr.Zero;

	internal RemoteProcess(uint processId)
	{
		ProcessId = checked((int)processId);
	}

	internal T TrackResource<T>(T resource) where T : Class82
	{
		if (resource.method_0() == Class171.GetCurrentProcessId())
		{
			return resource;
		}

		list_0.Add(resource);
		if (bool_4)
		{
			return resource;
		}

		IntPtr processHandle = Class171.smethod_250(
			this,
			Class124.Enum32.flag_11,
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
		foreach (Class82 resource in list_0)
		{
			Class171.smethod_388(resource);
		}

		if (Handle != IntPtr.Zero)
		{
			Class171.CloseHandle(Handle);
			Handle = IntPtr.Zero;
		}

		list_0.Clear();
		bool_3 = false;
	}
}
