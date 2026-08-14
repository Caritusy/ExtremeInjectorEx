using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

public abstract class RemoteCodeExecutorBase : RemoteProcessComponent
{
	private const uint RemoteExecutionTimeoutMilliseconds = 30_000;
	private const uint WaitObject0 = 0;
	private const uint WaitTimeout = 0x102;

	protected RemoteCodeExecutorBase(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
	}

	protected internal T Execute<T>(RemoteAssembler class47_0)
	{
		return ExecuteCore<T>(class47_0.class53_0, IntPtr.Zero, class47_0.GetResultOffset(), bool_2: true);
	}

	protected internal T Execute<T>(RemoteAssembler class47_0, IntPtr intptr_1, bool bool_2)
	{
		return ExecuteCore<T>(class47_0.class53_0, intptr_1, class47_0.GetResultOffset(), bool_2);
	}

	protected T ExecuteCore<T>(AsmJitAssembler class53_0, IntPtr intptr_1, int int_1, bool bool_2)
	{
		int codeSize = RecoveredRuntime.GetAssemblerOffset(class53_0);
		if (codeSize <= 0)
		{
			throw new InvalidOperationException("The remote execution stub is empty.");
		}

		IntPtr remoteCode = RecoveredRuntime.AssembleRemoteCode(intptr_1, class53_0, this);
		if (remoteCode == IntPtr.Zero)
		{
			throw new AccessViolationException("Unable to allocate or write the remote execution stub.");
		}

		IntPtr remoteThread = IntPtr.Zero;
		bool executionCompleted = false;
		try
		{
			if (!RecoveredRuntime.FlushInstructionCache(GetProcessHandle(), remoteCode, (UIntPtr)(uint)codeSize))
			{
				throw new Win32Exception(Marshal.GetLastWin32Error(), "Unable to flush the remote execution stub from the instruction cache.");
			}

			remoteThread = RecoveredRuntime.StartRemoteThread(this, remoteCode, IntPtr.Zero);
			if (remoteThread == IntPtr.Zero)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error(), "Unable to create the remote execution thread.");
			}

			uint waitResult = RecoveredRuntime.WaitForSingleObject(remoteThread, RemoteExecutionTimeoutMilliseconds);
			if (waitResult == WaitTimeout)
			{
				throw new RemoteExecutionTimeoutException(
					"Timed out while waiting for the remote execution thread. " +
					"Its code allocation was intentionally retained because the thread may still be running.");
			}

			if (waitResult != WaitObject0)
			{
				throw new RemoteExecutionTimeoutException(
					"Waiting for the remote execution thread failed. " +
					"Its code allocation was intentionally retained because the execution state is unknown.",
					new Win32Exception(Marshal.GetLastWin32Error()));
			}

			executionCompleted = true;
			IntPtr resultAddress = remoteCode.Add(int_1);
			if (typeof(T) == typeof(IntPtr) && !RecoveredRuntime.Is32BitProcess(GetRemoteProcess()))
			{
				return (T)(object)(IntPtr)Read<int>(resultAddress);
			}

			return Read<T>(resultAddress);
		}
		finally
		{
			if (remoteThread != IntPtr.Zero)
			{
				RecoveredRuntime.CloseRemoteHandle(this, remoteThread);
			}

			// Never release code that a timed-out or indeterminate thread may still execute.
			if (bool_2 && (executionCompleted || remoteThread == IntPtr.Zero))
			{
				ReleaseMemory(remoteCode);
			}
		}
	}
}
