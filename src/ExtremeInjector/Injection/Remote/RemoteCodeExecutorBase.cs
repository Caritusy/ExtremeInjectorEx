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

	protected internal T method_21<T>(RemoteAssembler class47_0)
	{
		return method_23<T>(class47_0.class53_0, IntPtr.Zero, class47_0.method_2(), bool_2: true);
	}

	protected internal T method_22<T>(RemoteAssembler class47_0, IntPtr intptr_1, bool bool_2)
	{
		return method_23<T>(class47_0.class53_0, intptr_1, class47_0.method_2(), bool_2);
	}

	protected T method_23<T>(AsmJitAssembler class53_0, IntPtr intptr_1, int int_1, bool bool_2)
	{
		int codeSize = RecoveredRuntime.smethod_252(class53_0);
		if (codeSize <= 0)
		{
			throw new InvalidOperationException("The remote execution stub is empty.");
		}

		IntPtr remoteCode = RecoveredRuntime.smethod_443(intptr_1, class53_0, this);
		if (remoteCode == IntPtr.Zero)
		{
			throw new AccessViolationException("Unable to allocate or write the remote execution stub.");
		}

		IntPtr remoteThread = IntPtr.Zero;
		bool executionCompleted = false;
		try
		{
			if (!RecoveredRuntime.FlushInstructionCache(method_2(), remoteCode, (UIntPtr)(uint)codeSize))
			{
				throw new Win32Exception(Marshal.GetLastWin32Error(), "Unable to flush the remote execution stub from the instruction cache.");
			}

			remoteThread = RecoveredRuntime.smethod_321(this, remoteCode, IntPtr.Zero);
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
			IntPtr resultAddress = remoteCode.smethod_8(int_1);
			if (typeof(T) == typeof(IntPtr) && !RecoveredRuntime.smethod_427(method_19()))
			{
				return (T)(object)(IntPtr)method_11<int>(resultAddress);
			}

			return method_11<T>(resultAddress);
		}
		finally
		{
			if (remoteThread != IntPtr.Zero)
			{
				RecoveredRuntime.smethod_108(this, remoteThread);
			}

			// Never release code that a timed-out or indeterminate thread may still execute.
			if (bool_2 && (executionCompleted || remoteThread == IntPtr.Zero))
			{
				vmethod_6(remoteCode);
			}
		}
	}

	internal static Type smethod_6(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
