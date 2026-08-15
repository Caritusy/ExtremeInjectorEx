using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ExtremeInjector;
using Microsoft.Win32;

public sealed partial class RecoveredRuntime
{

	internal static bool QueryProcessArchitecture(RemoteProcess remoteProcess)
	{
		if (!PlatformInfo.flag || !PlatformInfo.flag4)
		{
			return true;
		}
		IntPtr processHandle = RecoveredRuntime.OpenOrReuseProcessHandle(remoteProcess, PlatformInfo.flag2 ? NativeTypes.ProcessAccessRights.QueryLimitedInformation : NativeTypes.ProcessAccessRights.QueryInformation, false, remoteProcess.ProcessId);
		if (processHandle == IntPtr.Zero)
		{
			return false;
		}

		try
		{
			if (!RecoveredRuntime.IsWow64Process(processHandle, out bool isWow64))
			{
				return false;
			}

			remoteProcess.Is64Bit = !isWow64;
			return true;
		}
		finally
		{
			RecoveredRuntime.CloseTransientProcessHandle(remoteProcess, processHandle);
		}
	}

	internal static bool CloseTransientProcessHandle(RemoteProcess remoteProcess, IntPtr address)
	{
		if (remoteProcess.Handle != address)
		{
			return CloseHandle(address);
		}
		return true;
	}

	internal static ProcessModuleCollection CaptureProcessModules(RemoteProcess remoteProcess)
	{
		return RemoteModuleSnapshotService.Capture(remoteProcess);
	}

	internal static RemoteProcess SelectProcess()
	{
		using (ProcessSelectorForm form = new ProcessSelectorForm())
		{
			return form.ShowDialog() == DialogResult.OK ? form.SelectedProcess : null;
		}
	}

	internal static RemoteProcess OpenRemoteProcessById(int intValue)
	{
		RemoteProcess gclass = new RemoteProcess((uint)intValue);
		if (RecoveredRuntime.InitializeRemoteProcess(gclass))
		{
			return gclass;
		}
		return null;
	}

	internal static IEnumerable<int> EnumerateProcessThreadIds(RemoteProcess remoteProcess)
	{
		IntPtr snapshot = RecoveredRuntime.CreateToolhelp32Snapshot(NativeTypes.SnapshotFlags.Thread, remoteProcess.ProcessId);
		if (snapshot == IntPtr.Zero || snapshot == new IntPtr(-1))
		{
			return Array.Empty<int>();
		}

		try
		{
			NativeTypes.ThreadEntry32 threadEntry = default(NativeTypes.ThreadEntry32);
			threadEntry.uintValue = (uint)typeof(NativeTypes.ThreadEntry32).SizeOf();
			if (!RecoveredRuntime.Thread32First(snapshot, ref threadEntry))
			{
				return Array.Empty<int>();
			}

			List<int> threadIds = new List<int>();
			do
			{
				if (threadEntry.uintValue4 == (uint)remoteProcess.ProcessId)
				{
					threadIds.Add((int)threadEntry.uintValue3);
				}
			}
			while (RecoveredRuntime.Thread32Next(snapshot, ref threadEntry));
			return threadIds.ToArray();
		}
		finally
		{
			RecoveredRuntime.CloseHandle(snapshot);
		}
	}

	internal static int GetRemotePointerSize(RemoteProcess remoteProcess)
	{
		if (!Is32BitProcess(remoteProcess))
		{
			return 8;
		}
		return 4;
	}

	internal static bool TerminateProcessThread(ProcessThreadInfo processThreadInfo)
	{
		IntPtr intPtr = RecoveredRuntime.OpenThread(NativeTypes.ThreadAccessRights.Terminate, false, processThreadInfo.GetThreadId());
		if (!(intPtr == IntPtr.Zero))
		{
			bool result = RecoveredRuntime.TerminateThread(intPtr, 0);
			RecoveredRuntime.CloseHandle(intPtr);
			return result;
		}
		return false;
	}

	internal static bool QueryProcessIdentity(RemoteProcess remoteProcess)
	{
		NativeTypes.ProcessAccessRights access = PlatformInfo.flag2 ? NativeTypes.ProcessAccessRights.QueryLimitedInformation : NativeTypes.ProcessAccessRights.QueryInformation;
		IntPtr processHandle = RecoveredRuntime.OpenOrReuseProcessHandle(remoteProcess, access, false, remoteProcess.ProcessId);
		if (processHandle == IntPtr.Zero)
		{
			return false;
		}

		try
		{
			StringBuilder pathBuilder = new StringBuilder(255);
			if (PlatformInfo.flag2)
			{
				int capacity = pathBuilder.Capacity;
				if (!RecoveredRuntime.QueryFullProcessImageName(processHandle, 0, pathBuilder, ref capacity))
				{
					return false;
				}
			}
			else if (RecoveredRuntime.GetProcessImageFileName(processHandle, pathBuilder, (uint)pathBuilder.Capacity) == 0u)
			{
				return false;
			}

			string processPath = PlatformInfo.flag2
				? pathBuilder.ToString()
				: PlatformInfo.ConvertDevicePathToDosPath(pathBuilder.ToString());
			if (string.IsNullOrEmpty(processPath))
			{
				return false;
			}

			remoteProcess.FilePath = processPath;
			remoteProcess.Name = Path.GetFileName(processPath);
			return true;
		}
		finally
		{
			RecoveredRuntime.CloseTransientProcessHandle(remoteProcess, processHandle);
		}
	}

	internal static void UpdateThreadActionText(ProcessInspectorForm processInspectorForm)
	{
		if (processInspectorForm.dataGridView2.SelectedRows.Count == 0)
		{
			processInspectorForm.button4.Text = UiText.Get("ProcessInfo.Suspend");
			return;
		}

		NativeThreadInfo @class = ((ProcessThreadInfo)processInspectorForm.dataGridView2.SelectedRows[0].Tag).GetNativeInfo();
		if (@class.systemThreadInformation.uintValue4 == 5u && @class.systemThreadInformation.nativeThreadWaitReason == NativeTypes.NativeThreadWaitReason.Suspended)
		{
			processInspectorForm.button4.Text = UiText.Get("ProcessInfo.Resume");
			return;
		}
		processInspectorForm.button4.Text = UiText.Get("ProcessInfo.Suspend");
	}

	internal static bool ResumeProcessThread(ProcessThreadInfo processThreadInfo)
	{
		IntPtr intPtr = OpenThread(NativeTypes.ThreadAccessRights.SuspendResume, flag: false, processThreadInfo.GetThreadId());
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		int num = ResumeThread(intPtr);
		CloseHandle(intPtr);
		return num != -1;
	}

	internal static bool InitializeRemoteProcess(RemoteProcess remoteProcess)
	{
		return RecoveredRuntime.QueryProcessIdentity(remoteProcess) && RecoveredRuntime.QueryProcessArchitecture(remoteProcess) && RecoveredRuntime.QueryDepPolicy(remoteProcess);
	}

	internal static bool UnloadProcessModule(ProcessModuleInfo processModuleInfo, RemoteModuleManager remoteModuleManager)
	{
		RemoteModuleManager.ModuleMatchContext @class = new RemoteModuleManager.ModuleMatchContext();
		@class.isDifferentModule = processModuleInfo;
		if (RecoveredRuntime.GetModuleReferenceCount(remoteModuleManager, @class.isDifferentModule) <= 0)
		{
			return false;
		}
		if (!remoteModuleManager.EnsureAttachedToProcess(remoteModuleManager.GetRemoteProcess().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(12662));
		}
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(remoteModuleManager.GetRemoteProcess()).FirstOrDefault(new Func<ProcessModuleInfo, bool>(@class.MatchesArchitectureNtdll));
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(12731));
		}
		IntPtr intPtr = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(12800), false);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(12817));
		}
		IntPtr intPtr2 = RecoveredRuntime.StartRemoteThread(remoteModuleManager, intPtr, @class.isDifferentModule.GetModuleBase());
		if (!(intPtr2 == IntPtr.Zero))
		{
			RecoveredRuntime.WaitForRemoteThread(remoteModuleManager, intPtr2, -1);
			uint num;
			RecoveredRuntime.GetExitCodeThread(intPtr2, out num);
			RecoveredRuntime.CloseRemoteHandle(remoteModuleManager, intPtr2);
			return num == 0u && RecoveredRuntime.CaptureProcessModules(remoteModuleManager.GetRemoteProcess()).All(new Func<ProcessModuleInfo, bool>(@class.IsDifferentModule));
		}
		throw new AccessViolationException(EncodedStringTable.DecodeString(12914));
	}

	internal static void CloseRemoteHandle(RemoteProcessComponent remoteProcessComponent, IntPtr address)
	{
		CloseHandle(address);
	}

	internal static IntPtr CreateRemoteThreadHandle(IntPtr address, IntPtr address2, bool flag, RemoteProcessComponent remoteProcessComponent)
	{
		IntPtr threadHandle;
		if (PlatformInfo.flag2 && NtCreateThreadEx(
			out threadHandle,
			2097151u,
			IntPtr.Zero,
			remoteProcessComponent.GetProcessHandle(),
			address2,
			address,
			flag ? 4u : 0u,
			0u,
			0u,
			0u,
			IntPtr.Zero) == 0)
		{
			return threadHandle;
		}

		if (!flag)
		{
			return CreateRemoteThread(remoteProcessComponent.GetProcessHandle(), IntPtr.Zero, UIntPtr.Zero, address2, address, 0u, IntPtr.Zero);
		}

		threadHandle = CreateRemoteThread(remoteProcessComponent.GetProcessHandle(), IntPtr.Zero, UIntPtr.Zero, address2, address, 4u, IntPtr.Zero);
		if (threadHandle != IntPtr.Zero)
		{
			if (PlatformInfo.flag4)
			{
				NtSetInformationThread(threadHandle, NativeTypes.ThreadInformationClass.HideFromDebugger, IntPtr.Zero, 0);
			}
			ResumeThread(threadHandle);
		}

		return threadHandle;
	}

	internal static RemoteProcess[] FindProcessesByName(string text2, bool flag)
	{
		List<RemoteProcess> list = new List<RemoteProcess>();
		foreach (RemoteProcess gclass in RecoveredRuntime.EnumerateRemoteProcesses())
		{
			string text = gclass.Name;
			if (!flag && text.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
			{
				text = text.Substring(0, text.Length - 4);
			}
			if (text.Equals(text2, StringComparison.OrdinalIgnoreCase))
			{
				list.Add(gclass);
			}
		}
		return list.ToArray();
	}

	internal static bool PopulateWindowIdentifiers(ProcessWindowInfo processWindowInfo)
	{
		if (!(processWindowInfo.GetHandle() == IntPtr.Zero) && RecoveredRuntime.IsWindow(processWindowInfo.GetHandle()))
		{
			int int_;
			processWindowInfo.SetThreadId(RecoveredRuntime.GetWindowThreadProcessId(processWindowInfo.GetHandle(), out int_));
			processWindowInfo.SetProcessId(int_);
			return true;
		}
		return false;
	}

	internal static bool WaitForRemoteThread(RemoteProcessComponent remoteProcessComponent, IntPtr address, int intValue)
	{
		return WaitForSingleObject(address, (intValue == -1) ? uint.MaxValue : ((uint)intValue)) == 0;
	}

	internal static RemoteProcess[] EnumerateRemoteProcesses()
	{
		uint num = 0u;
		uint num2 = 0u;
		List<RemoteProcess> list = new List<RemoteProcess>
		{
			Capacity = 0
		};
		uint num3;
		do
		{
			num += 1024u;
			uint[] array = new uint[num];
			num2 = (uint)(array.Length * 4);
			RecoveredRuntime.EnumProcesses(array, num2, out num3);
			uint num4 = num3 / 4u;
			list.Capacity += (int)num4;
			for (uint num5 = num - 1024u; num5 < num4; num5 += 1u)
			{
				RemoteProcess gclass = new RemoteProcess(array[(int)num5]);
				if (RecoveredRuntime.InitializeRemoteProcess(gclass))
				{
					list.Add(gclass);
				}
			}
		}
		while (num2 == num3);
		return list.ToArray();
	}

	internal static void EnsureStreamOpen(ProcessMemoryStream processMemoryStream)
	{
		if (!processMemoryStream.flag)
		{
			throw new ObjectDisposedException(null, "Can not access a closed Stream.");
		}
	}

	internal static List<ProcessThreadInfo> EnumerateProcessThreads(RemoteProcess remoteProcess)
	{
		List<ProcessThreadInfo> list = new List<ProcessThreadInfo>();
		foreach (int int_ in RecoveredRuntime.EnumerateProcessThreadIds(remoteProcess))
		{
			ProcessThreadInfo @class = new ProcessThreadInfo(remoteProcess, int_);
			if (RecoveredRuntime.PopulateThreadInformation(@class))
			{
				list.Add(@class);
			}
		}
		return list;
	}

	internal static RemoteProcess CreateRemoteProcess(IntPtr address, int intValue)
	{
		RemoteProcess gclass = new RemoteProcess((uint)intValue);
		gclass.Handle=address;
		RemoteProcess gclass2 = gclass;
		if (RecoveredRuntime.InitializeRemoteProcess(gclass2))
		{
			return gclass2;
		}
		return null;
	}

	internal static ProcessModuleInfo FindModuleByBaseAddress(ProcessModuleCollection processModuleCollection, IntPtr address)
	{
		ProcessModuleCollection.ModuleBaseMatcher @class = new ProcessModuleCollection.ModuleBaseMatcher();
		@class.address = address;
		return processModuleCollection.Find(@class.MatchesModuleBase);
	}

	internal unsafe static IntPtr LocateLdrpLoadDll32(LdrLoadDllStubInjector ldrLoadDllStubInjector, IntPtr address, ProcessModuleInfo processModuleInfo)
	{
		byte[] array = ldrLoadDllStubInjector.ReadArray<byte>(address, 512);
		int num = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(13703), 0);
		if (num == -1)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(13712));
		}
		Array.Resize<byte>(ref array, num);
		num = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(13769), 0);
		if (num == -1)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(13774));
		}
		fixed (byte* ptr = array)
		{
			BeaEngineDisasm disassembly = default(BeaEngineDisasm);
			disassembly.uintValue2 = 0u;
			disassembly.pointer = ptr + num;
			byte* end = ptr + array.Length;
			int instructionLength;
			while (disassembly.pointer < end && (instructionLength = RecoveredRuntime.DisassembleInstruction(ref disassembly)) > 0)
			{
				if (disassembly.instruction.GetMnemonic() == EncodedStringTable.DecodeString(13835))
				{
					num = (int)(disassembly.pointer - ptr);
					break;
				}

				disassembly.pointer += instructionLength;
			}
		}
		if (num == -1)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(13844));
		}
		int num3 = BitConverter.ToInt32(array, num + 1);
		IntPtr intPtr = address.Add(num + 5 + num3);
		long moduleBase = processModuleInfo.GetModuleBase().ToInt64();
		long moduleEnd = checked(moduleBase + processModuleInfo.GetImageSize());
		long targetAddress = intPtr.ToInt64();
		if (targetAddress >= moduleBase && targetAddress < moduleEnd)
		{
			array = ldrLoadDllStubInjector.ReadArray<byte>(intPtr, 15);
			if (!PlatformInfo.flag8)
			{
				string string_ = EncodedStringTable.DecodeString(14010);
				string text = EncodedStringTable.DecodeString(14027);
				if (!RecoveredRuntime.MatchesMaskedBytePattern(0, string_, array, text))
				{
					throw new MissingMethodException(EncodedStringTable.DecodeString(14044));
				}
			}
			return intPtr;
		}
		throw new MissingMethodException(EncodedStringTable.DecodeString(13929));
	}

	internal static RemoteProcess GetCurrentRemoteProcess()
	{
		return CreateRemoteProcess(GetCurrentProcess(), (int)GetCurrentProcessId());
	}

	internal static void ShowProcessInspector(RemoteProcess remoteProcess)
	{
		ProcessInspectorForm form = new ProcessInspectorForm();
		form.SelectedProcess = remoteProcess;
		form.ShowDialog();
	}

	internal static IntPtr ResolveExportByName(ProcessModuleInfo processModuleInfo, string text, bool flag)
	{
		return processModuleInfo.GetExportAddress(text, flag);
	}

	internal static bool UnlinkProcessModule(RemoteModuleUnlinker remoteModuleUnlinker, ProcessModuleInfo processModuleInfo)
	{
		return UnlinkModuleFromPebLists(remoteModuleUnlinker, processModuleInfo.GetIs32Bit() ? ((RemotePeb)GetPeb32(remoteModuleUnlinker.GetRemoteProcess())) : ((RemotePeb)GetPeb64(remoteModuleUnlinker.GetRemoteProcess())), processModuleInfo.GetModuleBase());
	}

	internal static ProcessModuleInfo LoadForwardedExportModule(ProcessModuleInfo processModuleInfo, string text2)
	{
		string text = RecoveredRuntime.ResolveDependencyPath(text2, null, null, DependencySearchFlags.ResolveApiSetToSystemDirectory | (RecoveredRuntime.IsWow64RemoteProcess(processModuleInfo.remoteProcess) ? DependencySearchFlags.UseWow64SystemDirectory : DependencySearchFlags.None), 0, IntPtr.Zero);
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		try
		{
			if (FileVersionInfo.GetVersionInfo(text).CompanyName != EncodedStringTable.DecodeString(14624))
			{
				return null;
			}

			using (LoadLibraryInjector injector = new LoadLibraryInjector(processModuleInfo.remoteProcess))
			{
				IntPtr moduleBase = injector.Inject(text);
				return moduleBase == IntPtr.Zero
					? null
					: RecoveredRuntime.FindModuleByBaseAddress(RecoveredRuntime.CaptureProcessModules(processModuleInfo.remoteProcess), moduleBase);
			}
		}
		catch
		{
			return null;
		}
	}

	internal static void ShowSettings(RemoteProcess remoteProcess)
	{
		SettingsForm gForm = new SettingsForm();
		gForm.SelectedProcess = remoteProcess;
		gForm.button7.Enabled = remoteProcess != null;
		gForm.ShowDialog();
	}

	internal static IntPtr ResolveExportByOrdinal(ProcessModuleInfo processModuleInfo, ushort ushortValue, bool flag)
	{
		return processModuleInfo.GetExportAddress(ushortValue, flag);
	}

	internal static IntPtr OpenOrReuseProcessHandle(RemoteProcess remoteProcess, NativeTypes.ProcessAccessRights processAccessRights, bool flag, int intValue)
	{
		if (remoteProcess.Handle != IntPtr.Zero)
		{
			return remoteProcess.Handle;
		}
		return OpenProcess(processAccessRights, flag, intValue);
	}

	internal static IntPtr OpenProcessMemoryHandle(int intValue, ProcessMemoryAccess processMemoryAccess)
	{
		NativeTypes.ProcessAccessRights @enum;
		if (processMemoryAccess == ProcessMemoryAccess.Read)
		{
			@enum = NativeTypes.ProcessAccessRights.VirtualMemoryRead;
		}
		else if (processMemoryAccess != ProcessMemoryAccess.ReadWrite)
		{
			@enum = (NativeTypes.ProcessAccessRights.VirtualMemoryOperation | NativeTypes.ProcessAccessRights.VirtualMemoryWrite);
		}
		else
		{
			@enum = (NativeTypes.ProcessAccessRights.VirtualMemoryOperation | NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.VirtualMemoryWrite);
		}
		@enum |= NativeTypes.ProcessAccessRights.QueryInformation;
		return RecoveredRuntime.OpenProcess(@enum, false, intValue);
	}

	internal static Peb32 GetPeb32(RemoteProcess remoteProcess)
	{
		if (PlatformInfo.flag && remoteProcess.Is64Bit)
		{
			return null;
		}
		Peb32 @class = (remoteProcess.Handle != IntPtr.Zero) ? new Peb32(remoteProcess, remoteProcess.Handle) : new Peb32(remoteProcess);
		if (!RecoveredRuntime.TryInitializePeb32Address(@class) || !(RecoveredRuntime.GetPebAddress(@class) != IntPtr.Zero))
		{
			return null;
		}
		return remoteProcess.TrackResource(@class);
	}

	internal static bool QueryDepPolicy(RemoteProcess remoteProcess)
	{
		if (PlatformInfo.flag && remoteProcess.Is64Bit)
		{
			remoteProcess.IsDepEnabled=true;
			return true;
		}
		if (!RemoteProcess.SupportsDepPolicyQuery)
		{
			remoteProcess.IsDepEnabled=false;
			return true;
		}
		IntPtr processHandle = RecoveredRuntime.OpenOrReuseProcessHandle(remoteProcess, NativeTypes.ProcessAccessRights.QueryInformation, false, remoteProcess.ProcessId);
		if (processHandle == IntPtr.Zero)
		{
			return false;
		}

		try
		{
			if (!RecoveredRuntime.GetProcessDEPPolicy(processHandle, out uint flags, out _))
			{
				return false;
			}

			remoteProcess.IsDepEnabled = (flags & 1u) != 0u;
			return true;
		}
		finally
		{
			RecoveredRuntime.CloseTransientProcessHandle(remoteProcess, processHandle);
		}
	}

	internal static Icon GetWindowIcon(ProcessWindowInfo processWindowInfo)
	{
		IntPtr intPtr;
		RecoveredRuntime.SendMessageTimeout(processWindowInfo.GetHandle(), 127u, (UIntPtr)1UL, IntPtr.Zero, NativeTypes.SendMessageTimeoutFlags.AbortIfHung, 250u, out intPtr);
		if (intPtr != IntPtr.Zero)
		{
			return Icon.FromHandle(intPtr);
		}
		intPtr = RecoveredRuntime.GetWindowClassLongPtr(processWindowInfo.GetHandle(), -14);
		if (!(intPtr != IntPtr.Zero))
		{
			return null;
		}
		return Icon.FromHandle(intPtr);
	}

	internal static void RemoveManualMappedModuleRecord(IntPtr address, ProcessModuleCollection processModuleCollection)
	{
		for (int i = processModuleCollection.remoteProcess.items2.Count - 1; i >= 0; i--)
		{
			if (processModuleCollection.remoteProcess.items2[i].GetModuleBase() == address)
			{
				processModuleCollection.remoteProcess.items2.RemoveAt(i);
				return;
			}
		}
	}

	internal static NativeLoaderHooks GetNativeLoaderHooks(RemoteProcess remoteProcess)
	{
		return remoteProcess.nativeLoaderHooks ?? (remoteProcess.nativeLoaderHooks = new NativeLoaderHooks(remoteProcess));
	}

	internal static bool IsProcessWindowVisible(ProcessWindowInfo processWindowInfo)
	{
		return IsWindowVisible(processWindowInfo.GetHandle());
	}

	internal static bool SuspendProcessThread(ProcessThreadInfo processThreadInfo)
	{
		IntPtr intPtr = RecoveredRuntime.OpenThread(NativeTypes.ThreadAccessRights.SuspendResume, false, processThreadInfo.GetThreadId());
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		int num = RecoveredRuntime.SuspendThread(intPtr);
		RecoveredRuntime.CloseHandle(intPtr);
		return num != -1;
	}

	internal static bool HasProcessExited(RemoteProcess remoteProcess)
	{
		if (remoteProcess.flag3 && !remoteProcess.flag2)
		{
			return true;
		}

		if (!remoteProcess.flag3)
		{
			IntPtr waitHandle = OpenOrReuseProcessHandle(remoteProcess, NativeTypes.ProcessAccessRights.Synchronize, flag: false, remoteProcess.ProcessId);
			if (waitHandle == IntPtr.Zero)
			{
				return true;
			}

			uint waitResult = WaitForSingleObject(waitHandle, 0u);
			CloseTransientProcessHandle(remoteProcess, waitHandle);
			return waitResult != 258u;
		}

		IntPtr queryHandle = OpenOrReuseProcessHandle(
			remoteProcess,
			PlatformInfo.flag2 ? NativeTypes.ProcessAccessRights.QueryLimitedInformation : NativeTypes.ProcessAccessRights.QueryInformation,
			flag: false,
			remoteProcess.ProcessId);
		if (queryHandle == IntPtr.Zero)
		{
			return true;
		}

		bool queried = GetExitCodeProcess(queryHandle, out uint exitCode);
		CloseTransientProcessHandle(remoteProcess, queryHandle);
		return !queried || exitCode != 259u;
	}

	internal static void SetProcessModuleMetadata(string text, string text2, IntPtr address, ProcessModuleInfo processModuleInfo, uint uintValue)
	{
		processModuleInfo.SetModuleName(text);
		processModuleInfo.SetFilePath(text2);
		processModuleInfo.SetEntryPoint(address);
		processModuleInfo.SetImageSize(uintValue);
	}

	internal static IntPtr StartRemoteThread(RemoteProcessComponent remoteProcessComponent, IntPtr address, IntPtr address2)
	{
		return CreateRemoteThreadHandle(address2, address, remoteProcessComponent.GetHideRemoteThreadFromDebugger(), remoteProcessComponent);
	}

	internal static bool UnlinkModuleByBaseAddress(RemoteModuleUnlinker remoteModuleUnlinker, IntPtr address)
	{
		RemoteModuleUnlinker.ModuleBaseMatcher @class = new RemoteModuleUnlinker.ModuleBaseMatcher();
		@class.address = address;
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(remoteModuleUnlinker.GetRemoteProcess()).FirstOrDefault(new Func<ProcessModuleInfo, bool>(@class.MatchesModuleBase));
		if (gclass != null)
		{
			return RecoveredRuntime.UnlinkProcessModule(remoteModuleUnlinker, gclass);
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(23435));
	}

	internal static string GetWindowTitle(ProcessWindowInfo processWindowInfo)
	{
		int windowTextLength = RecoveredRuntime.GetWindowTextLength(processWindowInfo.GetHandle());
		if (windowTextLength == 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(windowTextLength + 1);
		if (RecoveredRuntime.GetWindowText(processWindowInfo.GetHandle(), stringBuilder, stringBuilder.Capacity) == 0)
		{
			return string.Empty;
		}
		return stringBuilder.ToString();
	}

	internal unsafe static IntPtr LocateLdrpLoadDll64(IntPtr address, LdrLoadDllStubInjector ldrLoadDllStubInjector, ProcessModuleInfo processModuleInfo)
	{
		byte[] array = ldrLoadDllStubInjector.ReadArray<byte>(address, 512);
		int num = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(23752), 0);
		if (num == -1)
		{
			num = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(23761), EncodedStringTable.DecodeString(23770), 0);
		}
		if (num == -1)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(23779));
		}
		fixed (byte* ptr = array)
		{
			BeaEngineDisasm @struct = default(BeaEngineDisasm);
			@struct.uintValue2 = 64u;
			@struct.pointer = ptr + num;
			BeaEngineDisasm struct2 = @struct;
			byte* ptr2 = ptr + array.Length;
			int num2;
			while (struct2.pointer < ptr2 && (num2 = RecoveredRuntime.DisassembleInstruction(ref struct2)) > 0)
			{
				if (struct2.instruction.GetMnemonic() == EncodedStringTable.DecodeString(13835))
				{
					num = (int)((long)(struct2.pointer - ptr));
					break;
				}
				struct2.pointer += num2;
			}
		}
		if (num == -1)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(13844));
		}
		int num3 = BitConverter.ToInt32(array, num + 1);
		IntPtr intPtr = address.Add(num + 5 + num3);
		long moduleBase = processModuleInfo.GetModuleBase().ToInt64();
		long moduleEnd = checked(moduleBase + processModuleInfo.GetImageSize());
		long targetAddress = intPtr.ToInt64();
		if (targetAddress < moduleBase || targetAddress >= moduleEnd)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(13929));
		}
		array = ldrLoadDllStubInjector.ReadArray<byte>(intPtr, 48);
		num = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(23836), EncodedStringTable.DecodeString(23869), 0);
		if (PlatformInfo.flag8 || num != -1)
		{
			return intPtr;
		}
		throw new MissingMethodException(EncodedStringTable.DecodeString(14044));
	}

	internal static Peb64 GetPeb64(RemoteProcess remoteProcess)
	{
		if (!PlatformInfo.flag && RecoveredRuntime.Is32BitProcess(remoteProcess))
		{
			return null;
		}
		Peb64 @class = (remoteProcess.Handle != IntPtr.Zero) ? new Peb64(remoteProcess, remoteProcess.Handle) : new Peb64(remoteProcess);
		if (!RecoveredRuntime.TryInitializePeb64Address(@class) || !(RecoveredRuntime.GetPebAddress(@class) != IntPtr.Zero))
		{
			return null;
		}
		return remoteProcess.TrackResource(@class);
	}

	internal static bool IsWow64RemoteProcess(RemoteProcess remoteProcess)
	{
		if (Is32BitProcess(remoteProcess))
		{
			return PlatformInfo.flag;
		}
		return false;
	}

	internal static void SetSelectedProcess(MainForm mainForm, RemoteProcess remoteProcess)
	{
		Image previousImage = mainForm.processIconPictureBox.BackgroundImage;
		Image nextImage = null;
		Cursor nextCursor = Cursors.Default;
		string nextDescription = UiText.Get("Main.NoProcessSelected");
		bool injectEnabled = false;
		bool isSameProcess = remoteProcess != null &&
			mainForm.selectedProcess != null &&
			mainForm.selectedProcess.ProcessId == remoteProcess.ProcessId;

		if (remoteProcess != null)
		{
			nextCursor = Cursors.Hand;
			nextImage = isSameProcess ? previousImage : LoadProcessIcon(remoteProcess);
			string description = LoadProcessDescription(remoteProcess);
			nextDescription = UiText.Format("Main.ProcessDetails", description, remoteProcess.ProcessId);
			injectEnabled = !ApplicationSettings.Current.Options.AutoInject;
		}

		mainForm.processSurface.SuspendLayout();
		try
		{
			mainForm.selectedProcess = remoteProcess;
			mainForm.processIconPictureBox.BackgroundImage = nextImage;
			mainForm.processIconPictureBox.Cursor = nextCursor;
			mainForm.processDescriptionLabel.Text = nextDescription;
			mainForm.injectButton.Enabled = injectEnabled;
		}
		finally
		{
			mainForm.processSurface.ResumeLayout(performLayout: false);
			mainForm.processSurface.Invalidate(invalidateChildren: true);
		}

		if (!ReferenceEquals(previousImage, nextImage))
		{
			previousImage?.Dispose();
		}

		if (remoteProcess != null)
		{
			ApplicationSettings.Current.ProcessName = mainForm.processNameTextBox.Text;
			ApplicationSettings.Save();
		}
	}

	private static Image LoadProcessIcon(RemoteProcess process)
	{
		try
		{
			using (Icon icon = GetFileIcon(process.FilePath, IconSize.Large))
			{
				return icon?.ToBitmap();
			}
		}
		catch
		{
			return null;
		}
	}

	private static string LoadProcessDescription(RemoteProcess process)
	{
		string description = UiText.Get("Main.NoDescription");
		try
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(process.FilePath);
			if (!string.IsNullOrEmpty(versionInfo.FileDescription))
			{
				description = versionInfo.FileDescription;
			}
		}
		catch
		{
		}

		return description.Length > 50
			? description.Substring(0, 50) + "..."
			: description;
	}

	internal static int GetModuleReferenceCount(RemoteModuleManager remoteModuleManager, ProcessModuleInfo processModuleInfo)
	{
		if (processModuleInfo.GetIs32Bit())
		{
			return GetLoaderModuleReferenceCount(remoteModuleManager, GetPeb32(remoteModuleManager.GetRemoteProcess()), processModuleInfo.GetModuleBase());
		}
		return GetLoaderModuleReferenceCount(remoteModuleManager, GetPeb64(remoteModuleManager.GetRemoteProcess()), processModuleInfo.GetModuleBase());
	}

	internal static long CalculateProcessMemoryLength(ProcessMemoryStream processMemoryStream, IntPtr address)
	{
		long length = 0L;
		IntPtr currentAddress = address;
		NativeTypes.MemoryBasicInformation region;
		while (NativeTypes.VirtualQueryEx(processMemoryStream.address, currentAddress, out region, (uint)NativeTypes.intValue) != 0 &&
			((region.memoryProtection2 & NativeTypes.MemoryProtection.ReadOnly) != (NativeTypes.MemoryProtection)0 ||
			 (region.memoryProtection2 & NativeTypes.MemoryProtection.ReadWrite) != (NativeTypes.MemoryProtection)0 ||
			 (region.memoryProtection2 & NativeTypes.MemoryProtection.ExecuteReadWrite) != (NativeTypes.MemoryProtection)0 ||
			 (region.memoryProtection2 & NativeTypes.MemoryProtection.ExecuteRead) != (NativeTypes.MemoryProtection)0))
		{
			length += region.address3.ToInt64();
			currentAddress = region.address.Add(region.address3);
		}
		return length;
	}

	internal static void TerminateRemoteProcess(RemoteProcess remoteProcess)
	{
		IntPtr intPtr = RecoveredRuntime.OpenOrReuseProcessHandle(remoteProcess, NativeTypes.ProcessAccessRights.Terminate, false, remoteProcess.ProcessId);
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(27572));
		}
		bool flag = RecoveredRuntime.TerminateProcess(intPtr, -1);
		RecoveredRuntime.CloseTransientProcessHandle(remoteProcess, intPtr);
		if (flag)
		{
			return;
		}
		throw new Win32Exception(EncodedStringTable.DecodeString(27609));
	}

	internal static ProcessWindowInfo[] EnumerateTopLevelWindows()
	{
		ProcessWindowInfo.WindowCollector obj = new ProcessWindowInfo.WindowCollector
		{
			items = new List<ProcessWindowInfo>()
		};
		EnumWindows(obj.CollectWindow, IntPtr.Zero);
		return obj.items.ToArray();
	}

	internal static bool Is32BitProcess(RemoteProcess remoteProcess)
	{
		return !remoteProcess.Is64Bit;
	}

	internal static void ResolveSelectedProcess(MainForm mainForm)
	{
		string processName = mainForm.processNameTextBox.Text;
		if (!processName.Contains("."))
		{
			SetSelectedProcess(mainForm, null);
			return;
		}

		RemoteProcess process = FindProcessesByName(processName, flag: true).FirstOrDefault();
		SetSelectedProcess(mainForm, process);
	}
}
