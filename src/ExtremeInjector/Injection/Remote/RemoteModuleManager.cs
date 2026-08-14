using System;
using System.Runtime.CompilerServices;

public sealed class RemoteModuleManager : RemoteProcessComponent
{
	[CompilerGenerated]
	public sealed class ModuleMatchContext
	{
		public ProcessModuleInfo gclass1_0;

		internal bool MatchesArchitectureNtdll(ProcessModuleInfo gclass1_1)
		{
			if (gclass1_1.GetFilePath().Equals("ntdll.dll", StringComparison.OrdinalIgnoreCase))
			{
				return gclass1_1.GetIs32Bit() == gclass1_0.GetIs32Bit();
			}
			return false;
		}

		internal bool IsDifferentModule(ProcessModuleInfo gclass1_1)
		{
			return gclass1_1.GetModuleBase() != gclass1_0.GetModuleBase();
		}
	}

	public RemoteModuleManager(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
	}

	protected override void EnsureProcessHandle()
	{
		if (base.GetProcessHandle() == IntPtr.Zero && base.GetProcessId() != -1)
		{
			base.SetProcessHandle(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.GetProcessId()));
		}
	}
}
