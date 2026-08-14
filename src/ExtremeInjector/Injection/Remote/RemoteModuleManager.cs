using System;
using System.Runtime.CompilerServices;

public sealed class RemoteModuleManager : RemoteProcessComponent
{
	[CompilerGenerated]
	public sealed class ModuleMatchContext
	{
		public ProcessModuleInfo isDifferentModule;

		internal bool MatchesArchitectureNtdll(ProcessModuleInfo processModuleInfo)
		{
			if (processModuleInfo.GetFilePath().Equals("ntdll.dll", StringComparison.OrdinalIgnoreCase))
			{
				return processModuleInfo.GetIs32Bit() == isDifferentModule.GetIs32Bit();
			}
			return false;
		}

		internal bool IsDifferentModule(ProcessModuleInfo processModuleInfo)
		{
			return processModuleInfo.GetModuleBase() != isDifferentModule.GetModuleBase();
		}
	}

	public RemoteModuleManager(RemoteProcess remoteProcess)
		: base(remoteProcess)
	{
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.CreateThread | NativeTypes.ProcessAccessRights.VirtualMemoryOperation | NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.VirtualMemoryWrite | NativeTypes.ProcessAccessRights.QueryInformation, false, base.GetProcessId()));
		}
	}
}
