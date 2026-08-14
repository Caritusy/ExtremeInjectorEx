using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class ProcessModuleCollection : List<ProcessModuleInfo>
{
	[CompilerGenerated]
	public sealed class ModuleNameMatcher
	{
		public string text;

		internal bool MatchesModuleName(ProcessModuleInfo processModuleInfo)
		{
			return processModuleInfo.GetModuleName().Equals(text, StringComparison.OrdinalIgnoreCase);
		}

		internal bool MatchesFilePath(ProcessModuleInfo processModuleInfo)
		{
			return processModuleInfo.GetFilePath().Equals(text, StringComparison.OrdinalIgnoreCase);
		}
	}

	[CompilerGenerated]
	public sealed class ModuleBaseMatcher
	{
		public IntPtr address;

		internal bool MatchesModuleBase(ProcessModuleInfo processModuleInfo)
		{
			return processModuleInfo.GetModuleBase() == address;
		}
	}

	[CompilerGenerated]
	public sealed class ModulePathMatcher
	{
		public string text;

		internal bool MatchesFilePath(ProcessModuleInfo processModuleInfo)
		{
			return processModuleInfo.GetFilePath().Equals(text, StringComparison.OrdinalIgnoreCase);
		}
	}

	internal RemoteProcess remoteProcess;

	public ProcessModuleInfo this[string text] => Find((ProcessModuleInfo processModuleInfo) => processModuleInfo.GetFilePath().Equals(text, StringComparison.OrdinalIgnoreCase));

	public ProcessModuleCollection(RemoteProcess remoteProcess2)
	{
		remoteProcess = remoteProcess2;
	}

	public IntPtr GetModuleBase(string text)
	{
		int num;
		if (!Path.IsPathRooted(text))
		{
			num = base.FindIndex((ProcessModuleInfo processModuleInfo) => processModuleInfo.GetFilePath().Equals(text, StringComparison.OrdinalIgnoreCase));
		}
		else
		{
			num = base.FindIndex((ProcessModuleInfo processModuleInfo) => processModuleInfo.GetModuleName().Equals(text, StringComparison.OrdinalIgnoreCase));
		}
		if (num < 0)
		{
			return IntPtr.Zero;
		}
		return base[num].GetModuleBase();
	}
}
