using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
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

	internal static bool QueryProcessArchitecture(RemoteProcess gclass2_0)
	{
		if (!PlatformInfo.bool_0 || !PlatformInfo.bool_3)
		{
			return true;
		}
		IntPtr processHandle = RecoveredRuntime.OpenOrReuseProcessHandle(gclass2_0, PlatformInfo.bool_1 ? NativeTypes.Enum32.flag_10 : NativeTypes.Enum32.flag_9, false, gclass2_0.ProcessId);
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

			gclass2_0.Is64Bit = !isWow64;
			return true;
		}
		finally
		{
			RecoveredRuntime.CloseTransientProcessHandle(gclass2_0, processHandle);
		}
	}

	internal static void PopulateAllProcesses(ProcessSelectorForm form5_0)
	{
		form5_0.dataGridView_0.Rows.Clear();
		foreach (RemoteProcess gclass in RecoveredRuntime.EnumerateRemoteProcesses())
		{
			Icon icon = RecoveredRuntime.GetFileIcon(gclass.FilePath, IconSize.const_1);
			Bitmap bitmap = (icon == null) ? new Bitmap(22, 22) : RecoveredRuntime.CreateSmallIconBitmap(icon);
			int index = form5_0.dataGridView_0.Rows.Add(new object[]
			{
				bitmap,
				string.Format(EncodedStringTable.DecodeString(12039), gclass.ProcessId, gclass.Name)
			});
			form5_0.dataGridView_0.Rows[index].Tag = gclass;
		}
		bool flag = form5_0.dataGridView_0.Rows.Count > 0;
		form5_0.button_2.Enabled = flag;
		if (flag)
		{
			form5_0.dataGridView_0.Rows[0].Selected = true;
		}
	}

	internal static bool CloseTransientProcessHandle(RemoteProcess gclass2_0, IntPtr intptr_0)
	{
		if (gclass2_0.Handle != intptr_0)
		{
			return CloseHandle(intptr_0);
		}
		return true;
	}

	internal static ProcessModuleCollection CaptureProcessModules(RemoteProcess gclass2_0)
	{
		return RemoteModuleSnapshotService.Capture(gclass2_0);
	}

	internal static RemoteProcess SelectProcess()
	{
		using (ProcessSelectorForm form = new ProcessSelectorForm())
		{
			return form.ShowDialog() == DialogResult.OK ? form.SelectedProcess : null;
		}
	}

	internal static RemoteProcess OpenRemoteProcessById(int int_0)
	{
		RemoteProcess gclass = new RemoteProcess((uint)int_0);
		if (RecoveredRuntime.InitializeRemoteProcess(gclass))
		{
			return gclass;
		}
		return null;
	}

	internal static IEnumerable<int> EnumerateProcessThreadIds(RemoteProcess gclass2_0)
	{
		IntPtr snapshot = RecoveredRuntime.CreateToolhelp32Snapshot(NativeTypes.Enum27.flag_2, gclass2_0.ProcessId);
		if (snapshot == IntPtr.Zero || snapshot == new IntPtr(-1))
		{
			return Array.Empty<int>();
		}

		try
		{
			NativeTypes.Struct44 threadEntry = default(NativeTypes.Struct44);
			threadEntry.uint_0 = (uint)typeof(NativeTypes.Struct44).SizeOf();
			if (!RecoveredRuntime.Thread32First(snapshot, ref threadEntry))
			{
				return Array.Empty<int>();
			}

			List<int> threadIds = new List<int>();
			do
			{
				if (threadEntry.uint_3 == (uint)gclass2_0.ProcessId)
				{
					threadIds.Add((int)threadEntry.uint_2);
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

	internal static int GetRemotePointerSize(RemoteProcess gclass2_0)
	{
		if (!Is32BitProcess(gclass2_0))
		{
			return 8;
		}
		return 4;
	}

	internal static bool TerminateProcessThread(ProcessThreadInfo class75_0)
	{
		IntPtr intPtr = RecoveredRuntime.OpenThread(NativeTypes.Enum31.flag_0, false, class75_0.GetThreadId());
		if (!(intPtr == IntPtr.Zero))
		{
			bool result = RecoveredRuntime.TerminateThread(intPtr, 0);
			RecoveredRuntime.CloseHandle(intPtr);
			return result;
		}
		return false;
	}

	internal static bool QueryProcessIdentity(RemoteProcess gclass2_0)
	{
		NativeTypes.Enum32 access = PlatformInfo.bool_1 ? NativeTypes.Enum32.flag_10 : NativeTypes.Enum32.flag_9;
		IntPtr processHandle = RecoveredRuntime.OpenOrReuseProcessHandle(gclass2_0, access, false, gclass2_0.ProcessId);
		if (processHandle == IntPtr.Zero)
		{
			return false;
		}

		try
		{
			StringBuilder pathBuilder = new StringBuilder(255);
			if (PlatformInfo.bool_1)
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

			string processPath = PlatformInfo.bool_1
				? pathBuilder.ToString()
				: PlatformInfo.ConvertDevicePathToDosPath(pathBuilder.ToString());
			if (string.IsNullOrEmpty(processPath))
			{
				return false;
			}

			gclass2_0.FilePath = processPath;
			gclass2_0.Name = Path.GetFileName(processPath);
			return true;
		}
		finally
		{
			RecoveredRuntime.CloseTransientProcessHandle(gclass2_0, processHandle);
		}
	}

	internal static void UpdateThreadActionText(ProcessInspectorForm form4_0)
	{
		NativeThreadInfo @class = ((ProcessThreadInfo)form4_0.dataGridView_1.SelectedRows[0].Tag).GetNativeInfo();
		if (@class.struct40_0.uint_3 == 5u && @class.struct40_0.enum23_0 == NativeTypes.Enum23.const_5)
		{
			form4_0.button_3.Text = EncodedStringTable.DecodeString(2546);
			return;
		}
		form4_0.button_3.Text = EncodedStringTable.DecodeString(12632);
	}

	internal static bool ResumeProcessThread(ProcessThreadInfo class75_0)
	{
		IntPtr intPtr = OpenThread(NativeTypes.Enum31.flag_1, bool_0: false, class75_0.GetThreadId());
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		int num = ResumeThread(intPtr);
		CloseHandle(intPtr);
		return num != -1;
	}

	internal static bool InitializeRemoteProcess(RemoteProcess gclass2_0)
	{
		return RecoveredRuntime.QueryProcessIdentity(gclass2_0) && RecoveredRuntime.QueryProcessArchitecture(gclass2_0) && RecoveredRuntime.QueryDepPolicy(gclass2_0);
	}

	internal static bool UnloadProcessModule(ProcessModuleInfo gclass1_0, RemoteModuleManager class93_0)
	{
		RemoteModuleManager.ModuleMatchContext @class = new RemoteModuleManager.ModuleMatchContext();
		@class.gclass1_0 = gclass1_0;
		if (RecoveredRuntime.GetModuleReferenceCount(class93_0, @class.gclass1_0) <= 0)
		{
			return false;
		}
		if (!class93_0.EnsureAttachedToProcess(class93_0.GetRemoteProcess().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.DecodeString(12662));
		}
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(class93_0.GetRemoteProcess()).FirstOrDefault(new Func<ProcessModuleInfo, bool>(@class.MatchesArchitectureNtdll));
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(12731));
		}
		IntPtr intPtr = RecoveredRuntime.ResolveExportByName(gclass, EncodedStringTable.DecodeString(12800), false);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(12817));
		}
		IntPtr intPtr2 = RecoveredRuntime.StartRemoteThread(class93_0, intPtr, @class.gclass1_0.GetModuleBase());
		if (!(intPtr2 == IntPtr.Zero))
		{
			RecoveredRuntime.WaitForRemoteThread(class93_0, intPtr2, -1);
			uint num;
			RecoveredRuntime.GetExitCodeThread(intPtr2, out num);
			RecoveredRuntime.CloseRemoteHandle(class93_0, intPtr2);
			return num == 0u && RecoveredRuntime.CaptureProcessModules(class93_0.GetRemoteProcess()).All(new Func<ProcessModuleInfo, bool>(@class.IsDifferentModule));
		}
		throw new AccessViolationException(EncodedStringTable.DecodeString(12914));
	}

	internal static void CloseRemoteHandle(RemoteProcessComponent class83_0, IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	internal static void PopulateWindowedProcesses(ProcessSelectorForm form5_0)
	{
		form5_0.dataGridView_0.Rows.Clear();
		foreach (ProcessWindowInfo window in RecoveredRuntime.EnumerateTopLevelWindows())
		{
			string title = RecoveredRuntime.GetWindowTitle(window);
			if (!RecoveredRuntime.IsProcessWindowVisible(window) || title.Length == 0)
			{
				continue;
			}

			RemoteProcess process = RecoveredRuntime.OpenRemoteProcessById(window.GetProcessId());
			if (process == null)
			{
				continue;
			}

			Icon icon = RecoveredRuntime.GetWindowIcon(window);
			Bitmap bitmap = icon == null ? new Bitmap(22, 22) : RecoveredRuntime.CreateSmallIconBitmap(icon);
			int index = form5_0.dataGridView_0.Rows.Add(new object[]
			{
				bitmap,
				string.Format(EncodedStringTable.DecodeString(12039), window.GetProcessId(), title)
			});
			form5_0.dataGridView_0.Rows[index].Tag = process;
		}
	}

	internal static IntPtr CreateRemoteThreadHandle(IntPtr intptr_0, IntPtr intptr_1, bool bool_0, RemoteProcessComponent class83_0)
	{
		IntPtr threadHandle;
		if (PlatformInfo.bool_1 && NtCreateThreadEx(
			out threadHandle,
			2097151u,
			IntPtr.Zero,
			class83_0.GetProcessHandle(),
			intptr_1,
			intptr_0,
			bool_0 ? 4u : 0u,
			0u,
			0u,
			0u,
			IntPtr.Zero) == 0)
		{
			return threadHandle;
		}

		if (!bool_0)
		{
			return CreateRemoteThread(class83_0.GetProcessHandle(), IntPtr.Zero, UIntPtr.Zero, intptr_1, intptr_0, 0u, IntPtr.Zero);
		}

		threadHandle = CreateRemoteThread(class83_0.GetProcessHandle(), IntPtr.Zero, UIntPtr.Zero, intptr_1, intptr_0, 4u, IntPtr.Zero);
		if (threadHandle != IntPtr.Zero)
		{
			if (PlatformInfo.bool_3)
			{
				NtSetInformationThread(threadHandle, NativeTypes.Enum25.const_17, IntPtr.Zero, 0);
			}
			ResumeThread(threadHandle);
		}

		return threadHandle;
	}

	internal static RemoteProcess[] FindProcessesByName(string string_0, bool bool_0)
	{
		List<RemoteProcess> list = new List<RemoteProcess>();
		foreach (RemoteProcess gclass in RecoveredRuntime.EnumerateRemoteProcesses())
		{
			string text = gclass.Name;
			if (!bool_0 && text.EndsWith(EncodedStringTable.DecodeString(93), StringComparison.OrdinalIgnoreCase))
			{
				text = text.Substring(0, text.Length - 4);
			}
			if (text.Equals(string_0, StringComparison.OrdinalIgnoreCase))
			{
				list.Add(gclass);
			}
		}
		return list.ToArray();
	}

	internal static bool PopulateWindowIdentifiers(ProcessWindowInfo class77_0)
	{
		if (!(class77_0.GetHandle() == IntPtr.Zero) && RecoveredRuntime.IsWindow(class77_0.GetHandle()))
		{
			int int_;
			class77_0.SetThreadId(RecoveredRuntime.GetWindowThreadProcessId(class77_0.GetHandle(), out int_));
			class77_0.SetProcessId(int_);
			return true;
		}
		return false;
	}

	internal static bool WaitForRemoteThread(RemoteProcessComponent class83_0, IntPtr intptr_0, int int_0)
	{
		return WaitForSingleObject(intptr_0, (int_0 == -1) ? uint.MaxValue : ((uint)int_0)) == 0;
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

	internal static void EnsureStreamOpen(ProcessMemoryStream stream0_0)
	{
		if (!stream0_0.bool_0)
		{
			throw new ObjectDisposedException(null, "Can not access a closed Stream.");
		}
	}

	internal static List<ProcessThreadInfo> EnumerateProcessThreads(RemoteProcess gclass2_0)
	{
		List<ProcessThreadInfo> list = new List<ProcessThreadInfo>();
		foreach (int int_ in RecoveredRuntime.EnumerateProcessThreadIds(gclass2_0))
		{
			ProcessThreadInfo @class = new ProcessThreadInfo(gclass2_0, int_);
			if (RecoveredRuntime.PopulateThreadInformation(@class))
			{
				list.Add(@class);
			}
		}
		return list;
	}

	internal static RemoteProcess CreateRemoteProcess(IntPtr intptr_0, int int_0)
	{
		RemoteProcess gclass = new RemoteProcess((uint)int_0);
		gclass.Handle=intptr_0;
		RemoteProcess gclass2 = gclass;
		if (RecoveredRuntime.InitializeRemoteProcess(gclass2))
		{
			return gclass2;
		}
		return null;
	}

	internal static ProcessModuleInfo FindModuleByBaseAddress(ProcessModuleCollection class69_0, IntPtr intptr_0)
	{
		ProcessModuleCollection.Class71 @class = new ProcessModuleCollection.Class71();
		@class.intptr_0 = intptr_0;
		return class69_0.Find(@class.MatchesModuleBase);
	}

	internal unsafe static IntPtr LocateLdrpLoadDll32(LdrLoadDllStubInjector class86_0, IntPtr intptr_0, ProcessModuleInfo gclass1_0)
	{
		byte[] array = class86_0.ReadArray<byte>(intptr_0, 512);
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
			disassembly.uint_1 = 0u;
			disassembly.pByte_0 = ptr + num;
			byte* end = ptr + array.Length;
			int instructionLength;
			while (disassembly.pByte_0 < end && (instructionLength = RecoveredRuntime.DisassembleInstruction(ref disassembly)) > 0)
			{
				if (disassembly.struct27_0.GetMnemonic() == EncodedStringTable.DecodeString(13835))
				{
					num = (int)(disassembly.pByte_0 - ptr);
					break;
				}

				disassembly.pByte_0 += instructionLength;
			}
		}
		if (num == -1)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(13844));
		}
		int num3 = BitConverter.ToInt32(array, num + 1);
		IntPtr intPtr = intptr_0.Add(num + 5 + num3);
		long moduleBase = gclass1_0.GetModuleBase().ToInt64();
		long moduleEnd = checked(moduleBase + gclass1_0.GetImageSize());
		long targetAddress = intPtr.ToInt64();
		if (targetAddress >= moduleBase && targetAddress < moduleEnd)
		{
			array = class86_0.ReadArray<byte>(intPtr, 15);
			if (!PlatformInfo.bool_7)
			{
				string string_ = EncodedStringTable.DecodeString(14010);
				string string_2 = EncodedStringTable.DecodeString(14027);
				if (!RecoveredRuntime.MatchesMaskedBytePattern(0, string_, array, string_2))
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

	internal static void ShowProcessInspector(RemoteProcess gclass2_0)
	{
		ProcessInspectorForm form = new ProcessInspectorForm();
		form.SelectedProcess = gclass2_0;
		form.ShowDialog();
	}

	internal static IntPtr ResolveExportByName(ProcessModuleInfo gclass1_0, string string_0, bool bool_0)
	{
		return gclass1_0.GetExportAddress(string_0, bool_0);
	}

	internal static bool UnlinkProcessModule(RemoteModuleUnlinker class129_0, ProcessModuleInfo gclass1_0)
	{
		return UnlinkModuleFromPebLists(class129_0, gclass1_0.GetIs32Bit() ? ((RemotePeb)GetPeb32(class129_0.GetRemoteProcess())) : ((RemotePeb)GetPeb64(class129_0.GetRemoteProcess())), gclass1_0.GetModuleBase());
	}

	internal static ProcessModuleInfo LoadForwardedExportModule(ProcessModuleInfo gclass1_0, string string_0)
	{
		string text = RecoveredRuntime.ResolveDependencyPath(string_0, null, null, DependencySearchFlags.flag_2 | (RecoveredRuntime.IsWow64RemoteProcess(gclass1_0.gclass2_0) ? DependencySearchFlags.flag_4 : DependencySearchFlags.flag_0), 0, IntPtr.Zero);
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

			using (LoadLibraryInjector injector = new LoadLibraryInjector(gclass1_0.gclass2_0))
			{
				IntPtr moduleBase = injector.Inject(text);
				return moduleBase == IntPtr.Zero
					? null
					: RecoveredRuntime.FindModuleByBaseAddress(RecoveredRuntime.CaptureProcessModules(gclass1_0.gclass2_0), moduleBase);
			}
		}
		catch
		{
			return null;
		}
	}

	internal static void ShowSettings(RemoteProcess gclass2_0)
	{
		SettingsForm gForm = new SettingsForm();
		gForm.SelectedProcess = gclass2_0;
		gForm.button_6.Enabled = gclass2_0 != null;
		gForm.ShowDialog();
	}

	internal static IntPtr ResolveExportByOrdinal(ProcessModuleInfo gclass1_0, ushort ushort_0, bool bool_0)
	{
		return gclass1_0.GetExportAddress(ushort_0, bool_0);
	}

	internal static IntPtr OpenOrReuseProcessHandle(RemoteProcess gclass2_0, NativeTypes.Enum32 enum32_0, bool bool_0, int int_0)
	{
		if (gclass2_0.Handle != IntPtr.Zero)
		{
			return gclass2_0.Handle;
		}
		return OpenProcess(enum32_0, bool_0, int_0);
	}

	internal static IntPtr OpenProcessMemoryHandle(int int_0, ProcessMemoryAccess enum15_0)
	{
		NativeTypes.Enum32 @enum;
		if (enum15_0 == ProcessMemoryAccess.const_0)
		{
			@enum = NativeTypes.Enum32.flag_4;
		}
		else if (enum15_0 != ProcessMemoryAccess.const_2)
		{
			@enum = (NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_5);
		}
		else
		{
			@enum = (NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5);
		}
		@enum |= NativeTypes.Enum32.flag_9;
		return RecoveredRuntime.OpenProcess(@enum, false, int_0);
	}

	internal static Peb32 GetPeb32(RemoteProcess gclass2_0)
	{
		if (PlatformInfo.bool_0 && gclass2_0.Is64Bit)
		{
			return null;
		}
		Peb32 @class = (gclass2_0.Handle != IntPtr.Zero) ? new Peb32(gclass2_0, gclass2_0.Handle) : new Peb32(gclass2_0);
		if (!RecoveredRuntime.TryInitializePeb32Address(@class) || !(RecoveredRuntime.GetPebAddress(@class) != IntPtr.Zero))
		{
			return null;
		}
		return gclass2_0.TrackResource(@class);
	}

	internal static bool QueryDepPolicy(RemoteProcess gclass2_0)
	{
		if (PlatformInfo.bool_0 && gclass2_0.Is64Bit)
		{
			gclass2_0.IsDepEnabled=true;
			return true;
		}
		if (!RemoteProcess.SupportsDepPolicyQuery)
		{
			gclass2_0.IsDepEnabled=false;
			return true;
		}
		IntPtr processHandle = RecoveredRuntime.OpenOrReuseProcessHandle(gclass2_0, NativeTypes.Enum32.flag_9, false, gclass2_0.ProcessId);
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

			gclass2_0.IsDepEnabled = (flags & 1u) != 0u;
			return true;
		}
		finally
		{
			RecoveredRuntime.CloseTransientProcessHandle(gclass2_0, processHandle);
		}
	}

	internal static Icon GetWindowIcon(ProcessWindowInfo class77_0)
	{
		IntPtr intPtr;
		RecoveredRuntime.SendMessageTimeout(class77_0.GetHandle(), 127u, (UIntPtr)1UL, IntPtr.Zero, NativeTypes.SendMessageTimeoutFlags.AbortIfHung, 250u, out intPtr);
		if (intPtr != IntPtr.Zero)
		{
			return Icon.FromHandle(intPtr);
		}
		intPtr = RecoveredRuntime.GetWindowClassLongPtr(class77_0.GetHandle(), -14);
		if (!(intPtr != IntPtr.Zero))
		{
			return null;
		}
		return Icon.FromHandle(intPtr);
	}

	internal static void RemoveManualMappedModuleRecord(IntPtr intptr_0, ProcessModuleCollection class69_0)
	{
		for (int i = class69_0.gclass2_0.list_1.Count - 1; i >= 0; i--)
		{
			if (class69_0.gclass2_0.list_1[i].GetModuleBase() == intptr_0)
			{
				class69_0.gclass2_0.list_1.RemoveAt(i);
				return;
			}
		}
	}

	internal static NativeLoaderHooks GetNativeLoaderHooks(RemoteProcess gclass2_0)
	{
		return gclass2_0.gclass3_0 ?? (gclass2_0.gclass3_0 = new NativeLoaderHooks(gclass2_0));
	}

	internal static bool IsProcessWindowVisible(ProcessWindowInfo class77_0)
	{
		return IsWindowVisible(class77_0.GetHandle());
	}

	internal static bool SuspendProcessThread(ProcessThreadInfo class75_0)
	{
		IntPtr intPtr = RecoveredRuntime.OpenThread(NativeTypes.Enum31.flag_1, false, class75_0.GetThreadId());
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		int num = RecoveredRuntime.SuspendThread(intPtr);
		RecoveredRuntime.CloseHandle(intPtr);
		return num != -1;
	}

	internal static bool HasProcessExited(RemoteProcess gclass2_0)
	{
		if (gclass2_0.bool_4 && !gclass2_0.bool_3)
		{
			return true;
		}

		if (!gclass2_0.bool_4)
		{
			IntPtr waitHandle = OpenOrReuseProcessHandle(gclass2_0, NativeTypes.Enum32.flag_11, bool_0: false, gclass2_0.ProcessId);
			if (waitHandle == IntPtr.Zero)
			{
				return true;
			}

			uint waitResult = WaitForSingleObject(waitHandle, 0u);
			CloseTransientProcessHandle(gclass2_0, waitHandle);
			return waitResult != 258u;
		}

		IntPtr queryHandle = OpenOrReuseProcessHandle(
			gclass2_0,
			PlatformInfo.bool_1 ? NativeTypes.Enum32.flag_10 : NativeTypes.Enum32.flag_9,
			bool_0: false,
			gclass2_0.ProcessId);
		if (queryHandle == IntPtr.Zero)
		{
			return true;
		}

		bool queried = GetExitCodeProcess(queryHandle, out uint exitCode);
		CloseTransientProcessHandle(gclass2_0, queryHandle);
		return !queried || exitCode != 259u;
	}

	internal static void SetProcessModuleMetadata(string string_0, string string_1, IntPtr intptr_0, ProcessModuleInfo gclass1_0, uint uint_0)
	{
		gclass1_0.SetModuleName(string_0);
		gclass1_0.SetFilePath(string_1);
		gclass1_0.SetEntryPoint(intptr_0);
		gclass1_0.SetImageSize(uint_0);
	}

	internal static IntPtr StartRemoteThread(RemoteProcessComponent class83_0, IntPtr intptr_0, IntPtr intptr_1)
	{
		return CreateRemoteThreadHandle(intptr_1, intptr_0, class83_0.GetHideRemoteThreadFromDebugger(), class83_0);
	}

	internal static bool UnlinkModuleByBaseAddress(RemoteModuleUnlinker class129_0, IntPtr intptr_0)
	{
		RemoteModuleUnlinker.Class130 @class = new RemoteModuleUnlinker.Class130();
		@class.intptr_0 = intptr_0;
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(class129_0.GetRemoteProcess()).FirstOrDefault(new Func<ProcessModuleInfo, bool>(@class.MatchesModuleBase));
		if (gclass != null)
		{
			return RecoveredRuntime.UnlinkProcessModule(class129_0, gclass);
		}
		throw new InvalidOperationException(EncodedStringTable.DecodeString(23435));
	}

	internal static string GetWindowTitle(ProcessWindowInfo class77_0)
	{
		int windowTextLength = RecoveredRuntime.GetWindowTextLength(class77_0.GetHandle());
		if (windowTextLength == 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(windowTextLength + 1);
		if (RecoveredRuntime.GetWindowText(class77_0.GetHandle(), stringBuilder, stringBuilder.Capacity) == 0)
		{
			return string.Empty;
		}
		return stringBuilder.ToString();
	}

	internal static void InitializeProcessSelectorForm(ProcessSelectorForm form5_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProcessSelectorForm));
		form5_0.dataGridView_0 = new DataGridView();
		form5_0.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
		form5_0.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		form5_0.button_0 = new Button();
		form5_0.button_1 = new Button();
		form5_0.button_2 = new Button();
		form5_0.button_3 = new Button();
		((ISupportInitialize)form5_0.dataGridView_0).BeginInit();
		form5_0.SuspendLayout();
		form5_0.dataGridView_0.AllowUserToAddRows = false;
		form5_0.dataGridView_0.AllowUserToDeleteRows = false;
		form5_0.dataGridView_0.AllowUserToResizeColumns = false;
		form5_0.dataGridView_0.AllowUserToResizeRows = false;
		form5_0.dataGridView_0.BackgroundColor = Color.White;
		form5_0.dataGridView_0.CellBorderStyle = DataGridViewCellBorderStyle.None;
		form5_0.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		form5_0.dataGridView_0.ColumnHeadersVisible = false;
		form5_0.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			form5_0.dataGridViewImageColumn_0,
			form5_0.dataGridViewTextBoxColumn_0
		});
		form5_0.dataGridView_0.EditMode = DataGridViewEditMode.EditProgrammatically;
		form5_0.dataGridView_0.Location = new Point(11, 13);
		form5_0.dataGridView_0.MultiSelect = false;
		form5_0.dataGridView_0.Name = EncodedStringTable.DecodeString(23504);
		form5_0.dataGridView_0.ReadOnly = true;
		form5_0.dataGridView_0.RowHeadersVisible = false;
		form5_0.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		form5_0.dataGridView_0.RowTemplate.Resizable = DataGridViewTriState.False;
		form5_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		form5_0.dataGridView_0.Size = new Size(248, 204);
		form5_0.dataGridView_0.TabIndex = 0;
		form5_0.dataGridView_0.CellContentDoubleClick += form5_0.OnProcessDoubleClick;
		form5_0.dataGridViewImageColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		form5_0.dataGridViewImageColumn_0.HeaderText = EncodedStringTable.DecodeString(394);
		form5_0.dataGridViewImageColumn_0.Name = EncodedStringTable.DecodeString(23541);
		form5_0.dataGridViewImageColumn_0.ReadOnly = true;
		form5_0.dataGridViewImageColumn_0.Width = 32;
		form5_0.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		form5_0.dataGridViewTextBoxColumn_0.HeaderText = EncodedStringTable.DecodeString(394);
		form5_0.dataGridViewTextBoxColumn_0.Name = EncodedStringTable.DecodeString(23566);
		form5_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
		form5_0.button_0.Location = new Point(10, 223);
		form5_0.button_0.Name = EncodedStringTable.DecodeString(23591);
		form5_0.button_0.Size = new Size(122, 23);
		form5_0.button_0.TabIndex = 1;
		form5_0.button_0.Text = EncodedStringTable.DecodeString(23616);
		form5_0.button_0.UseVisualStyleBackColor = true;
		form5_0.button_0.Click += form5_0.OnAllProcessesClick;
		form5_0.button_1.Location = new Point(138, 223);
		form5_0.button_1.Name = EncodedStringTable.DecodeString(23633);
		form5_0.button_1.Size = new Size(122, 23);
		form5_0.button_1.TabIndex = 2;
		form5_0.button_1.Text = EncodedStringTable.DecodeString(23658);
		form5_0.button_1.UseVisualStyleBackColor = true;
		form5_0.button_1.Click += form5_0.OnWindowedProcessesClick;
		form5_0.button_2.Location = new Point(10, 252);
		form5_0.button_2.Name = EncodedStringTable.DecodeString(23675);
		form5_0.button_2.Size = new Size(122, 23);
		form5_0.button_2.TabIndex = 3;
		form5_0.button_2.Text = EncodedStringTable.DecodeString(23692);
		form5_0.button_2.UseVisualStyleBackColor = true;
		form5_0.button_2.Click += form5_0.OnSelectClick;
		form5_0.button_3.Location = new Point(138, 252);
		form5_0.button_3.Name = EncodedStringTable.DecodeString(23701);
		form5_0.button_3.Size = new Size(122, 23);
		form5_0.button_3.TabIndex = 4;
		form5_0.button_3.Text = EncodedStringTable.DecodeString(23718);
		form5_0.button_3.UseVisualStyleBackColor = true;
		form5_0.button_3.Click += form5_0.OnCancelClick;
		form5_0.AutoScaleDimensions = new SizeF(96f, 96f);
		form5_0.AutoScaleMode = AutoScaleMode.Dpi;
		form5_0.ClientSize = new Size(270, 283);
		form5_0.Controls.Add(form5_0.button_3);
		form5_0.Controls.Add(form5_0.button_2);
		form5_0.Controls.Add(form5_0.button_1);
		form5_0.Controls.Add(form5_0.button_0);
		form5_0.Controls.Add(form5_0.dataGridView_0);
		form5_0.Font = new Font(EncodedStringTable.DecodeString(11956), 8.25f);
		form5_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		form5_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.DecodeString(13062));
		form5_0.MaximizeBox = false;
		form5_0.MinimizeBox = false;
		form5_0.Name = EncodedStringTable.DecodeString(23727);
		form5_0.Text = EncodedStringTable.DecodeString(23616);
		((ISupportInitialize)form5_0.dataGridView_0).EndInit();
		form5_0.ResumeLayout(false);
	}

	internal unsafe static IntPtr LocateLdrpLoadDll64(IntPtr intptr_0, LdrLoadDllStubInjector class86_0, ProcessModuleInfo gclass1_0)
	{
		byte[] array = class86_0.ReadArray<byte>(intptr_0, 512);
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
			@struct.uint_1 = 64u;
			@struct.pByte_0 = ptr + num;
			BeaEngineDisasm struct2 = @struct;
			byte* ptr2 = ptr + array.Length;
			int num2;
			while (struct2.pByte_0 < ptr2 && (num2 = RecoveredRuntime.DisassembleInstruction(ref struct2)) > 0)
			{
				if (struct2.struct27_0.GetMnemonic() == EncodedStringTable.DecodeString(13835))
				{
					num = (int)((long)(struct2.pByte_0 - ptr));
					break;
				}
				struct2.pByte_0 += num2;
			}
		}
		if (num == -1)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(13844));
		}
		int num3 = BitConverter.ToInt32(array, num + 1);
		IntPtr intPtr = intptr_0.Add(num + 5 + num3);
		long moduleBase = gclass1_0.GetModuleBase().ToInt64();
		long moduleEnd = checked(moduleBase + gclass1_0.GetImageSize());
		long targetAddress = intPtr.ToInt64();
		if (targetAddress < moduleBase || targetAddress >= moduleEnd)
		{
			throw new MissingMethodException(EncodedStringTable.DecodeString(13929));
		}
		array = class86_0.ReadArray<byte>(intPtr, 48);
		num = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(23836), EncodedStringTable.DecodeString(23869), 0);
		if (PlatformInfo.bool_7 || num != -1)
		{
			return intPtr;
		}
		throw new MissingMethodException(EncodedStringTable.DecodeString(14044));
	}

	internal static Peb64 GetPeb64(RemoteProcess gclass2_0)
	{
		if (!PlatformInfo.bool_0 && RecoveredRuntime.Is32BitProcess(gclass2_0))
		{
			return null;
		}
		Peb64 @class = (gclass2_0.Handle != IntPtr.Zero) ? new Peb64(gclass2_0, gclass2_0.Handle) : new Peb64(gclass2_0);
		if (!RecoveredRuntime.TryInitializePeb64Address(@class) || !(RecoveredRuntime.GetPebAddress(@class) != IntPtr.Zero))
		{
			return null;
		}
		return gclass2_0.TrackResource(@class);
	}

	internal static bool IsWow64RemoteProcess(RemoteProcess gclass2_0)
	{
		if (Is32BitProcess(gclass2_0))
		{
			return PlatformInfo.bool_0;
		}
		return false;
	}

	internal static void SetSelectedProcess(MainForm mainForm, RemoteProcess gclass2_0)
	{
		Image previousImage = mainForm.processIconPictureBox.BackgroundImage;
		Image nextImage = null;
		Cursor nextCursor = Cursors.Default;
		string nextDescription = UiText.Get("Main.NoProcessSelected");
		bool injectEnabled = false;
		bool isSameProcess = gclass2_0 != null &&
			mainForm.selectedProcess != null &&
			mainForm.selectedProcess.ProcessId == gclass2_0.ProcessId;

		if (gclass2_0 != null)
		{
			nextCursor = Cursors.Hand;
			nextImage = isSameProcess ? previousImage : LoadProcessIcon(gclass2_0);
			string description = LoadProcessDescription(gclass2_0);
			nextDescription = UiText.Format("Main.ProcessDetails", description, gclass2_0.ProcessId);
			injectEnabled = !ApplicationSettings.Current.Options.AutoInject;
		}

		mainForm.processSurface.SuspendLayout();
		try
		{
			mainForm.selectedProcess = gclass2_0;
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

		if (gclass2_0 != null)
		{
			ApplicationSettings.Current.ProcessName = mainForm.processNameTextBox.Text;
			ApplicationSettings.Save();
		}
	}

	private static Image LoadProcessIcon(RemoteProcess process)
	{
		try
		{
			using (Icon icon = GetFileIcon(process.FilePath, IconSize.const_1))
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

	internal static int GetModuleReferenceCount(RemoteModuleManager class93_0, ProcessModuleInfo gclass1_0)
	{
		if (gclass1_0.GetIs32Bit())
		{
			return GetLoaderModuleReferenceCount(class93_0, GetPeb32(class93_0.GetRemoteProcess()), gclass1_0.GetModuleBase());
		}
		return GetLoaderModuleReferenceCount(class93_0, GetPeb64(class93_0.GetRemoteProcess()), gclass1_0.GetModuleBase());
	}

	internal static long CalculateProcessMemoryLength(ProcessMemoryStream stream0_0, IntPtr intptr_0)
	{
		long length = 0L;
		IntPtr currentAddress = intptr_0;
		NativeTypes.Struct47 region;
		while (NativeTypes.VirtualQueryEx(stream0_0.intptr_0, currentAddress, out region, (uint)NativeTypes.int_0) != 0 &&
			((region.enum34_1 & NativeTypes.Enum34.flag_5) != (NativeTypes.Enum34)0 ||
			 (region.enum34_1 & NativeTypes.Enum34.flag_6) != (NativeTypes.Enum34)0 ||
			 (region.enum34_1 & NativeTypes.Enum34.flag_2) != (NativeTypes.Enum34)0 ||
			 (region.enum34_1 & NativeTypes.Enum34.flag_1) != (NativeTypes.Enum34)0))
		{
			length += region.intptr_2.ToInt64();
			currentAddress = region.intptr_0.Add(region.intptr_2);
		}
		return length;
	}

	internal static void TerminateRemoteProcess(RemoteProcess gclass2_0)
	{
		IntPtr intPtr = RecoveredRuntime.OpenOrReuseProcessHandle(gclass2_0, NativeTypes.Enum32.flag_1, false, gclass2_0.ProcessId);
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(27572));
		}
		bool flag = RecoveredRuntime.TerminateProcess(intPtr, -1);
		RecoveredRuntime.CloseTransientProcessHandle(gclass2_0, intPtr);
		if (flag)
		{
			return;
		}
		throw new Win32Exception(EncodedStringTable.DecodeString(27609));
	}

	internal static ProcessWindowInfo[] EnumerateTopLevelWindows()
	{
		ProcessWindowInfo.Class78 obj = new ProcessWindowInfo.Class78
		{
			list_0 = new List<ProcessWindowInfo>()
		};
		EnumWindows(obj.CollectWindow, IntPtr.Zero);
		return obj.list_0.ToArray();
	}

	internal static bool Is32BitProcess(RemoteProcess gclass2_0)
	{
		return !gclass2_0.Is64Bit;
	}

	internal static void ResolveSelectedProcess(MainForm mainForm)
	{
		string processName = mainForm.processNameTextBox.Text;
		if (!processName.Contains("."))
		{
			SetSelectedProcess(mainForm, null);
			return;
		}

		RemoteProcess process = FindProcessesByName(processName, bool_0: true).FirstOrDefault();
		SetSelectedProcess(mainForm, process);
	}
}
