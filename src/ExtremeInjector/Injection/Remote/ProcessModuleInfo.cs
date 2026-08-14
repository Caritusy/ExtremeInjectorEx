using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public sealed class ProcessModuleInfo
{
	[CompilerGenerated]
	internal IntPtr moduleBase;

	[CompilerGenerated]
	internal IntPtr entryPoint;

	[CompilerGenerated]
	internal uint imageSize;

	[CompilerGenerated]
	internal string moduleName;

	[CompilerGenerated]
	internal string filePath;

	[CompilerGenerated]
	internal bool is32Bit;

	[CompilerGenerated]
	internal bool isManualMapped;

	internal List<ExportedSymbol> items;

	internal RemoteProcess remoteProcess;

	internal ProcessModuleCollection processModuleCollection;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetModuleBase()
	{
		return moduleBase;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetModuleBase(IntPtr address)
	{
		moduleBase = address;
	}

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetEntryPoint()
	{
		return entryPoint;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetEntryPoint(IntPtr address)
	{
		entryPoint = address;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint GetImageSize()
	{
		return imageSize;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetImageSize(uint uintValue)
	{
		imageSize = uintValue;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GetModuleName()
	{
		return moduleName;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetModuleName(string text)
	{
		moduleName = text;
	}

	[SpecialName]
	[CompilerGenerated]
	public string GetFilePath()
	{
		return filePath;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetFilePath(string text)
	{
		filePath = text;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetIs32Bit()
	{
		return is32Bit;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetIs32Bit(bool flag)
	{
		is32Bit = flag;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool GetIsManualMapped()
	{
		return isManualMapped;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void SetIsManualMapped(bool flag)
	{
		isManualMapped = flag;
	}

	internal ProcessModuleInfo(RemoteProcess remoteProcess2, ProcessModuleCollection processModuleCollection2, IntPtr address, bool flag)
		: this(remoteProcess2, processModuleCollection2, address, flag, flag2: false)
	{
	}

	internal ProcessModuleInfo(RemoteProcess remoteProcess2, ProcessModuleCollection processModuleCollection2, IntPtr address, bool flag, bool flag2)
	{
		SetModuleBase(address);
		SetIs32Bit(flag);
		SetIsManualMapped(flag2);
		remoteProcess = remoteProcess2;
		processModuleCollection = processModuleCollection2;
	}

	internal IntPtr GetExportAddress(object instance, bool flag2)
	{
		bool flag;
		ushort num = (!(flag = (instance is ushort))) ? (ushort)0 : ((ushort)instance);
		string b = (instance is string) ? ((string)instance) : null;
		if (this.items == null)
		{
			foreach (KeyValuePair<ProcessModuleInfo, List<ExportedSymbol>> keyValuePair in this.remoteProcess.dictionary)
			{
				if (keyValuePair.Key.GetModuleBase() == this.GetModuleBase() && keyValuePair.Key.GetImageSize() == this.GetImageSize() && keyValuePair.Key.GetModuleName() == this.GetModuleName() && keyValuePair.Key.GetEntryPoint() == this.GetEntryPoint())
				{
					this.items = keyValuePair.Value;
					break;
				}
			}
		}
		if (this.items == null && RecoveredRuntime.GetRemoteModuleExports(this).Count == 0)
		{
			return IntPtr.Zero;
		}

		foreach (ExportedSymbol symbol in this.items)
		{
			if ((flag && symbol.GetOrdinal() != num) || (!flag && (!symbol.GetHasName() || symbol.GetName() != b)))
			{
				continue;
			}

			if (!RecoveredRuntime.IsForwardedExport(symbol))
			{
				return this.GetModuleBase().Add((long)((ulong)symbol.GetAddressRva()));
			}

			ProcessModuleCollection modules = this.processModuleCollection == null || !flag2
				? RecoveredRuntime.CaptureProcessModules(this.remoteProcess)
				: this.processModuleCollection;
			ProcessModuleInfo forwardedModule = modules[symbol.GetForwarder().GetModuleName()];
			if (forwardedModule == null)
			{
				if (symbol.GetForwarder().GetModuleName().IndexOf(EncodedStringTable.DecodeString(8498), StringComparison.OrdinalIgnoreCase) == -1)
				{
					forwardedModule = RecoveredRuntime.LoadForwardedExportModule(this, symbol.GetForwarder().GetModuleName());
					if (forwardedModule == null)
					{
						return IntPtr.Zero;
					}
					return RecoveredRuntime.ResolveExportByName(forwardedModule, symbol.GetForwarder().GetName(), false);
				}

				string resolvedPath = RecoveredRuntime.ResolveDependencyPath(symbol.GetForwarder().GetModuleName(), this.GetFilePath(), null, DependencySearchFlags.ApiSetOnly, 0, IntPtr.Zero);
				if (!string.IsNullOrEmpty(resolvedPath))
				{
					forwardedModule = modules[resolvedPath];
				}
				if (forwardedModule == null)
				{
					return IntPtr.Zero;
				}
			}

			return symbol.GetForwarder().GetIsOrdinal()
				? RecoveredRuntime.ResolveExportByName(forwardedModule, symbol.GetForwarder().GetName(), false)
				: RecoveredRuntime.ResolveExportByOrdinal(forwardedModule, symbol.GetForwarder().GetOrdinal(), false);
		}

		return IntPtr.Zero;
	}
}
