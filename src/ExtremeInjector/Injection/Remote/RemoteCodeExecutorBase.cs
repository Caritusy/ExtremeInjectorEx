using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

public abstract class RemoteCodeExecutorBase : RemoteProcessComponent
{
	protected internal const uint RemoteExecutionTimeoutMilliseconds = 30_000;
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

			WaitForRemoteThreadCompletion(remoteThread, "remote execution");

			executionCompleted = true;
			IntPtr resultAddress = remoteCode.Add(intValue);
			if (typeof(T) == typeof(IntPtr))
			{
				bool targetIs32Bit = RecoveredRuntime.Is32BitProcess(GetRemoteProcess());
				IntPtr pointerValue = NormalizeRemoteIntPtr(
					targetIs32Bit,
					targetIs32Bit ? Read<uint>(resultAddress) : 0u,
					targetIs32Bit ? IntPtr.Zero : Read<IntPtr>(resultAddress));
				return (T)(object)pointerValue;
			}

			if (typeof(T) == typeof(UIntPtr))
			{
				bool targetIs32Bit = RecoveredRuntime.Is32BitProcess(GetRemoteProcess());
				UIntPtr pointerValue = NormalizeRemoteUIntPtr(
					targetIs32Bit,
					targetIs32Bit ? Read<uint>(resultAddress) : 0u,
					targetIs32Bit ? UIntPtr.Zero : Read<UIntPtr>(resultAddress));
				return (T)(object)pointerValue;
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

	protected internal void WaitForRemoteThreadCompletion(IntPtr remoteThread, string operation)
	{
		uint waitResult = RecoveredRuntime.WaitForSingleObject(remoteThread, RemoteExecutionTimeoutMilliseconds);
		if (waitResult == WaitTimeout)
		{
			throw new RemoteExecutionTimeoutException(
				$"Timed out while waiting for {operation}. Its remote code allocation was retained because the thread may still be running.");
		}

		if (waitResult != WaitObject0)
		{
			throw new RemoteExecutionTimeoutException(
				$"Waiting for {operation} failed. Its remote code allocation was retained because the execution state is unknown.",
				new Win32Exception(Marshal.GetLastWin32Error()));
		}
	}

	internal void ReleaseRemoteCode(IntPtr remoteCode)
	{
		ReleaseMemory(remoteCode);
	}

	internal static IntPtr NormalizeRemoteIntPtr(bool targetIs32Bit, uint lowValue, IntPtr pointerValue)
	{
		return targetIs32Bit ? new IntPtr(unchecked((long)lowValue)) : pointerValue;
	}

	internal static UIntPtr NormalizeRemoteUIntPtr(bool targetIs32Bit, uint lowValue, UIntPtr pointerValue)
	{
		return targetIs32Bit ? new UIntPtr(lowValue) : pointerValue;
	}
}
