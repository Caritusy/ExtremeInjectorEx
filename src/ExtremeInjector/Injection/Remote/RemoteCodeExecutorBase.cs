using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

public abstract class RemoteCodeExecutorBase : RemoteProcessComponent
{
	private const uint RemoteExecutionTimeoutMilliseconds = 30_000;
	private const uint WaitObject0 = 0;
	private const uint WaitTimeout = 0x102;

	protected RemoteCodeExecutorBase(RemoteProcess remoteProcess)
		: base(remoteProcess)
	{
	}

	protected internal T Execute<T>(RemoteAssembler remoteAssembler)
	{
		return ExecuteCore<T>(remoteAssembler.assembler, IntPtr.Zero, remoteAssembler.GetResultOffset(), flag: true);
	}

	protected internal T Execute<T>(RemoteAssembler remoteAssembler, IntPtr address, bool flag)
	{
		return ExecuteCore<T>(remoteAssembler.assembler, address, remoteAssembler.GetResultOffset(), flag);
	}

	protected T ExecuteCore<T>(AsmJitAssembler assembler, IntPtr address, int intValue, bool flag)
	{
		int codeSize = RecoveredRuntime.GetAssemblerOffset(assembler);
		if (codeSize <= 0)
		{
			throw new InvalidOperationException("The remote execution stub is empty.");
		}

		IntPtr remoteCode = RecoveredRuntime.AssembleRemoteCode(address, assembler, this);
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
			IntPtr resultAddress = remoteCode.Add(intValue);
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
			if (flag && (executionCompleted || remoteThread == IntPtr.Zero))
			{
				ReleaseMemory(remoteCode);
			}
		}
	}
}
