using System;
using System.Collections.Generic;
using System.Text;

internal static class RemoteModuleSnapshotService
{
	private const uint ListModulesAll = 3;

	internal static ProcessModuleCollection Capture(RemoteProcess process)
	{
		if (process == null)
		{
			throw new ArgumentNullException(nameof(process));
		}

		var modules = new ProcessModuleCollection(process);
		var knownBases = new HashSet<IntPtr>();
		bool is32BitProcess = !process.Is64Bit;
		foreach (IntPtr moduleBase in EnumerateModuleHandles(process))
		{
			var module = new ProcessModuleInfo(process, modules, moduleBase, is32BitProcess);
			if (TryPopulate(module) && knownBases.Add(module.GetModuleBase()))
			{
				modules.Add(module);
			}
		}

		foreach (ProcessModuleInfo trackedModule in process.list_1)
		{
			if (trackedModule != null && knownBases.Add(trackedModule.GetModuleBase()))
			{
				modules.Add(trackedModule);
			}
		}

		return modules;
	}

	internal static IntPtr[] EnumerateModuleHandles(RemoteProcess process)
	{
		if (process == null)
		{
			throw new ArgumentNullException(nameof(process));
		}

		IntPtr processHandle = RecoveredRuntime.OpenOrReuseProcessHandle(
			process,
			NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_9,
			bool_0: false,
			process.ProcessId);
		if (processHandle == IntPtr.Zero)
		{
			return Array.Empty<IntPtr>();
		}

		try
		{
			if (!RecoveredRuntime.EnumProcessModulesEx(
				processHandle,
				Array.Empty<IntPtr>(),
				0,
				out uint neededBytes,
				ListModulesAll) || neededBytes == 0)
			{
				return Array.Empty<IntPtr>();
			}

			for (int attempt = 0; attempt < 3; attempt++)
			{
				int capacity = checked((int)((neededBytes + (uint)IntPtr.Size - 1) / (uint)IntPtr.Size));
				var moduleHandles = new IntPtr[capacity];
				uint bufferBytes = checked((uint)(capacity * IntPtr.Size));
				if (!RecoveredRuntime.EnumProcessModulesEx(
					processHandle,
					moduleHandles,
					bufferBytes,
					out uint actualBytes,
					ListModulesAll))
				{
					return Array.Empty<IntPtr>();
				}

				if (actualBytes <= bufferBytes)
				{
					int count = checked((int)(actualBytes / (uint)IntPtr.Size));
					if (count != moduleHandles.Length)
					{
						Array.Resize(ref moduleHandles, count);
					}

					return moduleHandles;
				}

				neededBytes = actualBytes;
			}

			return Array.Empty<IntPtr>();
		}
		finally
		{
			RecoveredRuntime.CloseTransientProcessHandle(process, processHandle);
		}
	}

	internal static bool TryPopulate(ProcessModuleInfo module)
	{
		if (module == null)
		{
			throw new ArgumentNullException(nameof(module));
		}

		RemoteProcess process = module.gclass2_0;
		IntPtr processHandle = RecoveredRuntime.OpenOrReuseProcessHandle(
			process,
			NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_9,
			bool_0: false,
			process.ProcessId);
		if (processHandle == IntPtr.Zero)
		{
			return false;
		}

		try
		{
			if (!RecoveredRuntime.GetModuleInformation(
				processHandle,
				module.GetModuleBase(),
				out NativeTypes.Struct46 information,
				typeof(NativeTypes.Struct46).SizeOf()))
			{
				return false;
			}

			var modulePath = new StringBuilder(32768);
			if (RecoveredRuntime.GetModuleFileNameEx(
				processHandle,
				module.GetModuleBase(),
				modulePath,
				modulePath.Capacity) == 0)
			{
				return false;
			}

			var moduleName = new StringBuilder(1024);
			if (RecoveredRuntime.GetModuleBaseName(
				processHandle,
				module.GetModuleBase(),
				moduleName,
				moduleName.Capacity) == 0)
			{
				return false;
			}

			module.SetModuleBase(information.intptr_0);
			module.SetEntryPoint(information.intptr_1);
			module.SetImageSize(information.uint_0);
			module.SetModuleName(modulePath.ToString());
			module.SetFilePath(moduleName.ToString());
			return true;
		}
		finally
		{
			RecoveredRuntime.CloseTransientProcessHandle(process, processHandle);
		}
	}
}
