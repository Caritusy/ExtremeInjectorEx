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

	internal static bool smethod_2(RemoteProcess gclass2_0)
	{
		if (!PlatformInfo.bool_0 || !PlatformInfo.bool_3)
		{
			return true;
		}
		IntPtr intPtr = RecoveredRuntime.smethod_250(gclass2_0, PlatformInfo.bool_1 ? NativeTypes.Enum32.flag_10 : NativeTypes.Enum32.flag_9, false, gclass2_0.ProcessId);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		bool flag;
		if (!RecoveredRuntime.IsWow64Process(intPtr, out flag))
		{
			RecoveredRuntime.smethod_27(gclass2_0, intPtr);
			return false;
		}
		gclass2_0.Is64Bit=!flag;
		RecoveredRuntime.smethod_27(gclass2_0, intPtr);
		return true;
	}

	internal static void smethod_25(ProcessSelectorForm form5_0)
	{
		form5_0.dataGridView_0.Rows.Clear();
		foreach (RemoteProcess gclass in RecoveredRuntime.smethod_155())
		{
			Icon icon = RecoveredRuntime.smethod_11(gclass.FilePath, IconSize.const_1);
			Bitmap bitmap = (icon == null) ? new Bitmap(22, 22) : RecoveredRuntime.smethod_100(icon);
			int index = form5_0.dataGridView_0.Rows.Add(new object[]
			{
				bitmap,
				string.Format(EncodedStringTable.smethod_0(12039), gclass.ProcessId, gclass.Name)
			});
			form5_0.dataGridView_0.Rows[index].Tag = gclass;
		}
		bool flag = form5_0.dataGridView_0.Rows.Count > 0;
		form5_0.button_2.Enabled = flag;
		form5_0.dataGridView_0.Rows[0].Selected = flag;
	}

	internal static bool smethod_27(RemoteProcess gclass2_0, IntPtr intptr_0)
	{
		if (gclass2_0.Handle != intptr_0)
		{
			return CloseHandle(intptr_0);
		}
		return true;
	}

	internal static IntPtr[] smethod_30(RemoteProcess gclass2_0, bool bool_0)
	{
		_ = bool_0;
		return RemoteModuleSnapshotService.EnumerateModuleHandles(gclass2_0);
	}

	internal static ProcessModuleCollection smethod_42(RemoteProcess gclass2_0)
	{
		return RemoteModuleSnapshotService.Capture(gclass2_0);
	}

	internal static RemoteProcess SelectProcess()
	{
		using (ProcessSelectorForm form = new ProcessSelectorForm())
		{
			return form.ShowDialog() == DialogResult.OK ? form.method_0() : null;
		}
	}

	internal static RemoteProcess smethod_47(int int_0)
	{
		RemoteProcess gclass = new RemoteProcess((uint)int_0);
		if (RecoveredRuntime.smethod_102(gclass))
		{
			return gclass;
		}
		return null;
	}

	internal static IEnumerable<int> smethod_66(RemoteProcess gclass2_0)
	{
		IntPtr intPtr = RecoveredRuntime.CreateToolhelp32Snapshot(NativeTypes.Enum27.flag_2, gclass2_0.ProcessId);
		if (intPtr == IntPtr.Zero)
		{
			return new int[0];
		}
		NativeTypes.Struct44 @struct = default(NativeTypes.Struct44);
		@struct.uint_0 = (uint)typeof(NativeTypes.Struct44).smethod_7();
		NativeTypes.Struct44 struct2 = @struct;
		if (RecoveredRuntime.Thread32First(intPtr, ref struct2))
		{
			List<int> list = new List<int>();
			do
			{
				if (struct2.uint_3 == (uint)gclass2_0.ProcessId)
				{
					list.Add((int)struct2.uint_2);
				}
			}
			while (RecoveredRuntime.Thread32Next(intPtr, ref struct2));
			RecoveredRuntime.smethod_27(gclass2_0, intPtr);
			return list.ToArray();
		}
		RecoveredRuntime.smethod_27(gclass2_0, intPtr);
		return new int[0];
	}

	internal static int smethod_73(RemoteProcess gclass2_0)
	{
		if (!smethod_427(gclass2_0))
		{
			return 8;
		}
		return 4;
	}

	internal static bool smethod_74(ProcessThreadInfo class75_0)
	{
		IntPtr intPtr = RecoveredRuntime.OpenThread(NativeTypes.Enum31.flag_0, false, class75_0.method_0());
		if (!(intPtr == IntPtr.Zero))
		{
			bool result = RecoveredRuntime.TerminateThread(intPtr, 0);
			RecoveredRuntime.CloseHandle(intPtr);
			return result;
		}
		return false;
	}

	internal static bool smethod_87(RemoteProcess gclass2_0)
	{
		if (PlatformInfo.bool_1)
		{
			IntPtr intPtr = RecoveredRuntime.smethod_250(gclass2_0, NativeTypes.Enum32.flag_10, false, gclass2_0.ProcessId);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			StringBuilder stringBuilder = new StringBuilder(255);
			int capacity = stringBuilder.Capacity;
			if (!RecoveredRuntime.QueryFullProcessImageName(intPtr, 0, stringBuilder, ref capacity))
			{
				RecoveredRuntime.smethod_27(gclass2_0, intPtr);
				return false;
			}
			gclass2_0.FilePath=stringBuilder.ToString();
			gclass2_0.Name=Path.GetFileName(gclass2_0.FilePath);
			RecoveredRuntime.smethod_27(gclass2_0, intPtr);
			return true;
		}
		else
		{
			IntPtr intPtr2 = RecoveredRuntime.smethod_250(gclass2_0, NativeTypes.Enum32.flag_9, false, gclass2_0.ProcessId);
			if (intPtr2 == IntPtr.Zero)
			{
				return false;
			}
			StringBuilder stringBuilder2 = new StringBuilder(255);
			if (RecoveredRuntime.GetProcessImageFileName(intPtr2, stringBuilder2, (uint)stringBuilder2.Capacity) == 0u)
			{
				RecoveredRuntime.smethod_27(gclass2_0, intPtr2);
				return false;
			}
			string text = PlatformInfo.smethod_0(stringBuilder2.ToString());
			if (!string.IsNullOrEmpty(text))
			{
				gclass2_0.FilePath=text;
				gclass2_0.Name=Path.GetFileName(gclass2_0.FilePath);
				RecoveredRuntime.smethod_27(gclass2_0, intPtr2);
				return true;
			}
			RecoveredRuntime.smethod_27(gclass2_0, intPtr2);
			return false;
		}
	}

	internal static void smethod_88(ProcessInspectorForm form4_0)
	{
		NativeThreadInfo @class = ((ProcessThreadInfo)form4_0.dataGridView_1.SelectedRows[0].Tag).method_9();
		if (@class.struct40_0.uint_3 == 5u && @class.struct40_0.enum23_0 == NativeTypes.Enum23.const_5)
		{
			form4_0.button_3.Text = EncodedStringTable.smethod_0(2546);
			return;
		}
		form4_0.button_3.Text = EncodedStringTable.smethod_0(12632);
	}

	internal static bool smethod_97(ProcessThreadInfo class75_0)
	{
		IntPtr intPtr = OpenThread(NativeTypes.Enum31.flag_1, bool_0: false, class75_0.method_0());
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		int num = ResumeThread(intPtr);
		CloseHandle(intPtr);
		return num != -1;
	}

	internal static bool smethod_102(RemoteProcess gclass2_0)
	{
		return RecoveredRuntime.smethod_87(gclass2_0) && RecoveredRuntime.smethod_2(gclass2_0) && RecoveredRuntime.smethod_260(gclass2_0);
	}

	internal static bool smethod_103(ProcessModuleInfo gclass1_0, RemoteModuleManager class93_0)
	{
		RemoteModuleManager.ModuleMatchContext @class = new RemoteModuleManager.ModuleMatchContext();
		@class.gclass1_0 = gclass1_0;
		if (RecoveredRuntime.smethod_385(class93_0, @class.gclass1_0) <= 0)
		{
			return false;
		}
		if (!class93_0.method_8(class93_0.method_19().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(12662));
		}
		ProcessModuleInfo gclass = RecoveredRuntime.smethod_42(class93_0.method_19()).FirstOrDefault(new Func<ProcessModuleInfo, bool>(@class.method_0));
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.smethod_0(12731));
		}
		IntPtr intPtr = RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(12800), false);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(EncodedStringTable.smethod_0(12817));
		}
		IntPtr intPtr2 = RecoveredRuntime.smethod_321(class93_0, intPtr, @class.gclass1_0.method_0());
		if (!(intPtr2 == IntPtr.Zero))
		{
			RecoveredRuntime.smethod_153(class93_0, intPtr2, -1);
			uint num;
			RecoveredRuntime.GetExitCodeThread(intPtr2, out num);
			RecoveredRuntime.smethod_108(class93_0, intPtr2);
			return num == 0u && RecoveredRuntime.smethod_42(class93_0.method_19()).All(new Func<ProcessModuleInfo, bool>(@class.method_1));
		}
		throw new AccessViolationException(EncodedStringTable.smethod_0(12914));
	}

	internal static void smethod_108(RemoteProcessComponent class83_0, IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	internal static bool smethod_109(ProcessModuleInfo gclass1_0)
	{
		return !gclass1_0.method_10();
	}

	internal static ThreadWaitReason smethod_122(NativeThreadInfo class76_0)
	{
		return (ThreadWaitReason)class76_0.struct40_0.enum23_0;
	}

	internal static void smethod_145(ProcessSelectorForm form5_0)
	{
		form5_0.dataGridView_0.Rows.Clear();
		foreach (ProcessWindowInfo @class in RecoveredRuntime.smethod_413())
		{
			string text = RecoveredRuntime.smethod_331(@class);
			if (RecoveredRuntime.smethod_287(@class) && text.Length != 0)
			{
				RemoteProcess gclass = RecoveredRuntime.smethod_47(@class.method_2());
				if (gclass != null)
				{
					Icon icon = RecoveredRuntime.smethod_274(@class);
					Bitmap bitmap = (icon == null) ? new Bitmap(22, 22) : RecoveredRuntime.smethod_100(icon);
					int index = form5_0.dataGridView_0.Rows.Add(new object[]
					{
						bitmap,
						string.Format(EncodedStringTable.smethod_0(12039), @class.method_2(), text)
					});
					form5_0.dataGridView_0.Rows[index].Tag = gclass;
				}
			}
		}
	}

	internal static IntPtr smethod_146(IntPtr intptr_0, IntPtr intptr_1, bool bool_0, RemoteProcessComponent class83_0)
	{
		IntPtr threadHandle;
		if (PlatformInfo.bool_1 && NtCreateThreadEx(
			out threadHandle,
			2097151u,
			IntPtr.Zero,
			class83_0.method_2(),
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
			return CreateRemoteThread(class83_0.method_2(), IntPtr.Zero, UIntPtr.Zero, intptr_1, intptr_0, 0u, IntPtr.Zero);
		}

		threadHandle = CreateRemoteThread(class83_0.method_2(), IntPtr.Zero, UIntPtr.Zero, intptr_1, intptr_0, 4u, IntPtr.Zero);
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

	internal static RemoteProcess[] smethod_148(string string_0, bool bool_0)
	{
		List<RemoteProcess> list = new List<RemoteProcess>();
		foreach (RemoteProcess gclass in RecoveredRuntime.smethod_155())
		{
			string text = gclass.Name;
			if (!bool_0 && text.EndsWith(EncodedStringTable.smethod_0(93), StringComparison.OrdinalIgnoreCase))
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

	internal static bool smethod_151(ProcessWindowInfo class77_0)
	{
		if (!(class77_0.method_0() == IntPtr.Zero) && RecoveredRuntime.IsWindow(class77_0.method_0()))
		{
			int int_;
			class77_0.method_4(RecoveredRuntime.GetWindowThreadProcessId(class77_0.method_0(), out int_));
			class77_0.method_3(int_);
			return true;
		}
		return false;
	}

	internal static bool smethod_153(RemoteProcessComponent class83_0, IntPtr intptr_0, int int_0)
	{
		return WaitForSingleObject(intptr_0, (int_0 == -1) ? uint.MaxValue : ((uint)int_0)) == 0;
	}

	internal static RemoteProcess[] smethod_155()
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
				if (RecoveredRuntime.smethod_102(gclass))
				{
					list.Add(gclass);
				}
			}
		}
		while (num2 == num3);
		return list.ToArray();
	}

	internal static void smethod_156(ProcessMemoryStream stream0_0)
	{
		if (!stream0_0.bool_0)
		{
			throw new ObjectDisposedException(null, "Can not access a closed Stream.");
		}
	}

	internal static List<ProcessThreadInfo> smethod_179(RemoteProcess gclass2_0)
	{
		List<ProcessThreadInfo> list = new List<ProcessThreadInfo>();
		foreach (int int_ in RecoveredRuntime.smethod_66(gclass2_0))
		{
			ProcessThreadInfo @class = new ProcessThreadInfo(gclass2_0, int_);
			if (RecoveredRuntime.smethod_70(@class))
			{
				list.Add(@class);
			}
		}
		return list;
	}

	internal static RemoteProcess smethod_183(IntPtr intptr_0, int int_0)
	{
		RemoteProcess gclass = new RemoteProcess((uint)int_0);
		gclass.Handle=intptr_0;
		RemoteProcess gclass2 = gclass;
		if (RecoveredRuntime.smethod_102(gclass2))
		{
			return gclass2;
		}
		return null;
	}

	internal static ProcessModuleInfo smethod_196(ProcessModuleCollection class69_0, IntPtr intptr_0)
	{
		ProcessModuleCollection.Class71 @class = new ProcessModuleCollection.Class71();
		@class.intptr_0 = intptr_0;
		return class69_0.Find(@class.method_0);
	}

	internal unsafe static IntPtr smethod_197(LdrLoadDllStubInjector class86_0, IntPtr intptr_0, ProcessModuleInfo gclass1_0)
	{
		byte[] array = class86_0.method_10<byte>(intptr_0, 512);
		int num = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(13703), 0);
		if (num == -1)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(13712));
		}
		Array.Resize<byte>(ref array, num);
		num = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(13769), 0);
		if (num == -1)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(13774));
		}
		fixed (byte* ptr = array)
		{
			BeaEngineDisasm disassembly = default(BeaEngineDisasm);
			disassembly.uint_1 = 0u;
			disassembly.pByte_0 = ptr + num;
			byte* end = ptr + array.Length;
			int instructionLength;
			while (disassembly.pByte_0 < end && (instructionLength = RecoveredRuntime.smethod_224(ref disassembly)) > 0)
			{
				if (disassembly.struct27_0.method_0() == EncodedStringTable.smethod_0(13835))
				{
					num = (int)(disassembly.pByte_0 - ptr);
					break;
				}

				disassembly.pByte_0 += instructionLength;
			}
		}
		if (num == -1)
		{
			throw new MissingMethodException(EncodedStringTable.smethod_0(13844));
		}
		int num3 = BitConverter.ToInt32(array, num + 1);
		IntPtr intPtr = intptr_0.smethod_8(num + 5 + num3);
		long moduleBase = gclass1_0.method_0().ToInt64();
		long moduleEnd = checked(moduleBase + gclass1_0.method_4());
		long targetAddress = intPtr.ToInt64();
		if (targetAddress >= moduleBase && targetAddress < moduleEnd)
		{
			array = class86_0.method_10<byte>(intPtr, 15);
			if (!PlatformInfo.bool_7)
			{
				string string_ = EncodedStringTable.smethod_0(14010);
				string string_2 = EncodedStringTable.smethod_0(14027);
				if (!RecoveredRuntime.smethod_40(0, string_, array, string_2))
				{
					throw new MissingMethodException(EncodedStringTable.smethod_0(14044));
				}
			}
			return intPtr;
		}
		throw new MissingMethodException(EncodedStringTable.smethod_0(13929));
	}

	internal static RemoteProcess smethod_211()
	{
		return smethod_183(GetCurrentProcess(), (int)GetCurrentProcessId());
	}

	internal static void ShowProcessInspector(RemoteProcess gclass2_0)
	{
		ProcessInspectorForm form = new ProcessInspectorForm();
		form.method_1(gclass2_0);
		form.ShowDialog();
	}

	internal static IntPtr smethod_225(ProcessModuleInfo gclass1_0, string string_0, bool bool_0)
	{
		return gclass1_0.method_14(string_0, bool_0);
	}

	internal static bool smethod_229(RemoteModuleUnlinker class129_0, ProcessModuleInfo gclass1_0)
	{
		return smethod_133(class129_0, gclass1_0.method_10() ? ((RemotePeb)smethod_255(class129_0.method_0())) : ((RemotePeb)smethod_369(class129_0.method_0())), gclass1_0.method_0());
	}

	internal static ProcessModuleInfo smethod_231(ProcessModuleInfo gclass1_0, string string_0)
	{
		string text = RecoveredRuntime.smethod_440(string_0, null, null, DependencySearchFlags.flag_2 | (RecoveredRuntime.smethod_379(gclass1_0.gclass2_0) ? DependencySearchFlags.flag_4 : DependencySearchFlags.flag_0), 0, IntPtr.Zero);
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		ProcessModuleInfo result;
		try
		{
			if (!(FileVersionInfo.GetVersionInfo(text).CompanyName != EncodedStringTable.smethod_0(14624)))
			{
				using (LoadLibraryInjector @class = new LoadLibraryInjector(gclass1_0.gclass2_0))
				{
					IntPtr intPtr = @class.Inject(text);
					return (!(intPtr == IntPtr.Zero)) ? RecoveredRuntime.smethod_196(RecoveredRuntime.smethod_42(gclass1_0.gclass2_0), intPtr) : null;
				}
			}
			result = null;
		}
		catch
		{
			result = null;
		}
		return result;
	}

	internal static void ShowSettings(RemoteProcess gclass2_0)
	{
		SettingsForm gForm = new SettingsForm();
		gForm.method_1(gclass2_0);
		gForm.button_6.Enabled = gclass2_0 != null;
		gForm.ShowDialog();
	}

	internal static bool smethod_246(ProcessModuleInfo gclass1_0)
	{
		return RemoteModuleSnapshotService.TryPopulate(gclass1_0);
	}

	internal static IntPtr smethod_248(ProcessModuleInfo gclass1_0, ushort ushort_0, bool bool_0)
	{
		return gclass1_0.method_14(ushort_0, bool_0);
	}

	internal static IntPtr smethod_250(RemoteProcess gclass2_0, NativeTypes.Enum32 enum32_0, bool bool_0, int int_0)
	{
		if (gclass2_0.Handle != IntPtr.Zero)
		{
			return gclass2_0.Handle;
		}
		return OpenProcess(enum32_0, bool_0, int_0);
	}

	internal static IntPtr smethod_253(int int_0, ProcessMemoryAccess enum15_0)
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

	internal static Peb32 smethod_255(RemoteProcess gclass2_0)
	{
		if (PlatformInfo.bool_0 && gclass2_0.Is64Bit)
		{
			return null;
		}
		Peb32 @class = (gclass2_0.Handle != IntPtr.Zero) ? new Peb32(gclass2_0, gclass2_0.Handle) : new Peb32(gclass2_0);
		if (!RecoveredRuntime.smethod_409(@class) || !(RecoveredRuntime.smethod_270(@class) != IntPtr.Zero))
		{
			return null;
		}
		return gclass2_0.TrackResource(@class);
	}

	internal static bool smethod_260(RemoteProcess gclass2_0)
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
		IntPtr intPtr = RecoveredRuntime.smethod_250(gclass2_0, NativeTypes.Enum32.flag_9, false, gclass2_0.ProcessId);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		uint num;
		bool flag;
		if (!RecoveredRuntime.GetProcessDEPPolicy(intPtr, out num, out flag))
		{
			RecoveredRuntime.smethod_27(gclass2_0, intPtr);
			return false;
		}
		gclass2_0.IsDepEnabled=(num & 1u) > 0u;
		RecoveredRuntime.smethod_27(gclass2_0, intPtr);
		return true;
	}

	internal static Icon smethod_274(ProcessWindowInfo class77_0)
	{
		IntPtr intPtr;
		RecoveredRuntime.SendMessageTimeout(class77_0.method_0(), 127u, (UIntPtr)1UL, IntPtr.Zero, NativeTypes.Enum20.flag_2, 250u, out intPtr);
		if (intPtr != IntPtr.Zero)
		{
			return Icon.FromHandle(intPtr);
		}
		intPtr = RecoveredRuntime.smethod_445(class77_0.method_0(), -14);
		if (!(intPtr != IntPtr.Zero))
		{
			return null;
		}
		return Icon.FromHandle(intPtr);
	}

	internal static void smethod_283(IntPtr intptr_0, ProcessModuleCollection class69_0)
	{
		for (int i = class69_0.gclass2_0.list_1.Count - 1; i >= 0; i--)
		{
			if (class69_0.gclass2_0.list_1[i].method_0() == intptr_0)
			{
				class69_0.gclass2_0.list_1.RemoveAt(i);
				return;
			}
		}
	}

	internal static NativeLoaderHooks smethod_285(RemoteProcess gclass2_0)
	{
		return gclass2_0.gclass3_0 ?? (gclass2_0.gclass3_0 = new NativeLoaderHooks(gclass2_0));
	}

	internal static bool smethod_287(ProcessWindowInfo class77_0)
	{
		return IsWindowVisible(class77_0.method_0());
	}

	internal static bool smethod_300(ProcessThreadInfo class75_0)
	{
		IntPtr intPtr = RecoveredRuntime.OpenThread(NativeTypes.Enum31.flag_1, false, class75_0.method_0());
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
			IntPtr waitHandle = smethod_250(gclass2_0, NativeTypes.Enum32.flag_11, bool_0: false, gclass2_0.ProcessId);
			if (waitHandle == IntPtr.Zero)
			{
				return true;
			}

			uint waitResult = WaitForSingleObject(waitHandle, 0u);
			smethod_27(gclass2_0, waitHandle);
			return waitResult != 258u;
		}

		IntPtr queryHandle = smethod_250(
			gclass2_0,
			PlatformInfo.bool_1 ? NativeTypes.Enum32.flag_10 : NativeTypes.Enum32.flag_9,
			bool_0: false,
			gclass2_0.ProcessId);
		if (queryHandle == IntPtr.Zero)
		{
			return true;
		}

		bool queried = GetExitCodeProcess(queryHandle, out uint exitCode);
		smethod_27(gclass2_0, queryHandle);
		return !queried || exitCode != 259u;
	}

	internal static void smethod_313(string string_0, string string_1, IntPtr intptr_0, ProcessModuleInfo gclass1_0, uint uint_0)
	{
		gclass1_0.method_7(string_0);
		gclass1_0.method_9(string_1);
		gclass1_0.method_3(intptr_0);
		gclass1_0.method_5(uint_0);
	}

	internal static IntPtr smethod_321(RemoteProcessComponent class83_0, IntPtr intptr_0, IntPtr intptr_1)
	{
		return smethod_146(intptr_1, intptr_0, class83_0.method_17(), class83_0);
	}

	internal static bool smethod_327(RemoteModuleUnlinker class129_0, IntPtr intptr_0)
	{
		RemoteModuleUnlinker.Class130 @class = new RemoteModuleUnlinker.Class130();
		@class.intptr_0 = intptr_0;
		ProcessModuleInfo gclass = RecoveredRuntime.smethod_42(class129_0.method_0()).FirstOrDefault(new Func<ProcessModuleInfo, bool>(@class.method_0));
		if (gclass != null)
		{
			return RecoveredRuntime.smethod_229(class129_0, gclass);
		}
		throw new InvalidOperationException(EncodedStringTable.smethod_0(23435));
	}

	internal static string smethod_331(ProcessWindowInfo class77_0)
	{
		int windowTextLength = RecoveredRuntime.GetWindowTextLength(class77_0.method_0());
		if (windowTextLength == 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(windowTextLength + 1);
		if (RecoveredRuntime.GetWindowText(class77_0.method_0(), stringBuilder, stringBuilder.Capacity) == 0)
		{
			return string.Empty;
		}
		return stringBuilder.ToString();
	}

	internal static void smethod_334(ProcessSelectorForm form5_0)
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
		form5_0.dataGridView_0.Name = EncodedStringTable.smethod_0(23504);
		form5_0.dataGridView_0.ReadOnly = true;
		form5_0.dataGridView_0.RowHeadersVisible = false;
		form5_0.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		form5_0.dataGridView_0.RowTemplate.Resizable = DataGridViewTriState.False;
		form5_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		form5_0.dataGridView_0.Size = new Size(248, 204);
		form5_0.dataGridView_0.TabIndex = 0;
		form5_0.dataGridView_0.CellContentDoubleClick += form5_0.method_5;
		form5_0.dataGridViewImageColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		form5_0.dataGridViewImageColumn_0.HeaderText = EncodedStringTable.smethod_0(394);
		form5_0.dataGridViewImageColumn_0.Name = EncodedStringTable.smethod_0(23541);
		form5_0.dataGridViewImageColumn_0.ReadOnly = true;
		form5_0.dataGridViewImageColumn_0.Width = 32;
		form5_0.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		form5_0.dataGridViewTextBoxColumn_0.HeaderText = EncodedStringTable.smethod_0(394);
		form5_0.dataGridViewTextBoxColumn_0.Name = EncodedStringTable.smethod_0(23566);
		form5_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
		form5_0.button_0.Location = new Point(10, 223);
		form5_0.button_0.Name = EncodedStringTable.smethod_0(23591);
		form5_0.button_0.Size = new Size(122, 23);
		form5_0.button_0.TabIndex = 1;
		form5_0.button_0.Text = EncodedStringTable.smethod_0(23616);
		form5_0.button_0.UseVisualStyleBackColor = true;
		form5_0.button_0.Click += form5_0.method_4;
		form5_0.button_1.Location = new Point(138, 223);
		form5_0.button_1.Name = EncodedStringTable.smethod_0(23633);
		form5_0.button_1.Size = new Size(122, 23);
		form5_0.button_1.TabIndex = 2;
		form5_0.button_1.Text = EncodedStringTable.smethod_0(23658);
		form5_0.button_1.UseVisualStyleBackColor = true;
		form5_0.button_1.Click += form5_0.method_6;
		form5_0.button_2.Location = new Point(10, 252);
		form5_0.button_2.Name = EncodedStringTable.smethod_0(23675);
		form5_0.button_2.Size = new Size(122, 23);
		form5_0.button_2.TabIndex = 3;
		form5_0.button_2.Text = EncodedStringTable.smethod_0(23692);
		form5_0.button_2.UseVisualStyleBackColor = true;
		form5_0.button_2.Click += form5_0.method_3;
		form5_0.button_3.Location = new Point(138, 252);
		form5_0.button_3.Name = EncodedStringTable.smethod_0(23701);
		form5_0.button_3.Size = new Size(122, 23);
		form5_0.button_3.TabIndex = 4;
		form5_0.button_3.Text = EncodedStringTable.smethod_0(23718);
		form5_0.button_3.UseVisualStyleBackColor = true;
		form5_0.button_3.Click += form5_0.method_2;
		form5_0.AutoScaleDimensions = new SizeF(96f, 96f);
		form5_0.AutoScaleMode = AutoScaleMode.Dpi;
		form5_0.ClientSize = new Size(270, 283);
		form5_0.Controls.Add(form5_0.button_3);
		form5_0.Controls.Add(form5_0.button_2);
		form5_0.Controls.Add(form5_0.button_1);
		form5_0.Controls.Add(form5_0.button_0);
		form5_0.Controls.Add(form5_0.dataGridView_0);
		form5_0.Font = new Font(EncodedStringTable.smethod_0(11956), 8.25f);
		form5_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
		form5_0.Icon = (Icon)componentResourceManager.GetObject(EncodedStringTable.smethod_0(13062));
		form5_0.MaximizeBox = false;
		form5_0.MinimizeBox = false;
		form5_0.Name = EncodedStringTable.smethod_0(23727);
		form5_0.Text = EncodedStringTable.smethod_0(23616);
		((ISupportInitialize)form5_0.dataGridView_0).EndInit();
		form5_0.ResumeLayout(false);
	}

	internal unsafe static IntPtr smethod_335(IntPtr intptr_0, LdrLoadDllStubInjector class86_0, ProcessModuleInfo gclass1_0)
	{
		byte[] array = class86_0.method_10<byte>(intptr_0, 512);
		int num = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(23752), 0);
		if (num == -1)
		{
			num = RecoveredRuntime.smethod_419(array, EncodedStringTable.smethod_0(23761), EncodedStringTable.smethod_0(23770), 0);
		}
		if (num == -1)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(23779));
		}
		fixed (byte* ptr = array)
		{
			BeaEngineDisasm @struct = default(BeaEngineDisasm);
			@struct.uint_1 = 64u;
			@struct.pByte_0 = ptr + num;
			BeaEngineDisasm struct2 = @struct;
			byte* ptr2 = ptr + array.Length;
			int num2;
			while (struct2.pByte_0 < ptr2 && (num2 = RecoveredRuntime.smethod_224(ref struct2)) > 0)
			{
				if (struct2.struct27_0.method_0() == EncodedStringTable.smethod_0(13835))
				{
					num = (int)((long)(struct2.pByte_0 - ptr));
					break;
				}
				struct2.pByte_0 += num2;
			}
		}
		if (num == -1)
		{
			throw new MissingMethodException(EncodedStringTable.smethod_0(13844));
		}
		int num3 = BitConverter.ToInt32(array, num + 1);
		IntPtr intPtr = intptr_0.smethod_8(num + 5 + num3);
		long moduleBase = gclass1_0.method_0().ToInt64();
		long moduleEnd = checked(moduleBase + gclass1_0.method_4());
		long targetAddress = intPtr.ToInt64();
		if (targetAddress < moduleBase || targetAddress >= moduleEnd)
		{
			throw new MissingMethodException(EncodedStringTable.smethod_0(13929));
		}
		array = class86_0.method_10<byte>(intPtr, 48);
		num = RecoveredRuntime.smethod_419(array, EncodedStringTable.smethod_0(23836), EncodedStringTable.smethod_0(23869), 0);
		if (PlatformInfo.bool_7 || num != -1)
		{
			return intPtr;
		}
		throw new MissingMethodException(EncodedStringTable.smethod_0(14044));
	}

	internal static Peb64 smethod_369(RemoteProcess gclass2_0)
	{
		if (!PlatformInfo.bool_0 && RecoveredRuntime.smethod_427(gclass2_0))
		{
			return null;
		}
		Peb64 @class = (gclass2_0.Handle != IntPtr.Zero) ? new Peb64(gclass2_0, gclass2_0.Handle) : new Peb64(gclass2_0);
		if (!RecoveredRuntime.smethod_281(@class) || !(RecoveredRuntime.smethod_270(@class) != IntPtr.Zero))
		{
			return null;
		}
		return gclass2_0.TrackResource(@class);
	}

	internal static bool smethod_379(RemoteProcess gclass2_0)
	{
		if (smethod_427(gclass2_0))
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
			using (Icon icon = smethod_11(process.FilePath, IconSize.const_1))
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

	internal static int smethod_385(RemoteModuleManager class93_0, ProcessModuleInfo gclass1_0)
	{
		if (gclass1_0.method_10())
		{
			return smethod_129(class93_0, smethod_255(class93_0.method_19()), gclass1_0.method_0());
		}
		return smethod_129(class93_0, smethod_369(class93_0.method_19()), gclass1_0.method_0());
	}

	internal static bool smethod_399(RemoteProcess gclass2_0)
	{
		return gclass2_0.bool_2;
	}

	internal static ThreadState smethod_402(NativeThreadInfo class76_0)
	{
		return (ThreadState)class76_0.struct40_0.uint_3;
	}

	internal static long smethod_407(ProcessMemoryStream stream0_0, IntPtr intptr_0)
	{
		long num = 0L;
		IntPtr intptr_ = intptr_0;
		NativeTypes.Struct47 @struct;
		while (NativeTypes.VirtualQueryEx(stream0_0.intptr_0, intptr_, out @struct, (uint)NativeTypes.int_0) == 0 && ((@struct.enum34_1 & NativeTypes.Enum34.flag_5) != (NativeTypes.Enum34)0u || (@struct.enum34_1 & NativeTypes.Enum34.flag_6) != (NativeTypes.Enum34)0u || (@struct.enum34_1 & NativeTypes.Enum34.flag_2) != (NativeTypes.Enum34)0u || (@struct.enum34_1 & NativeTypes.Enum34.flag_1) != (NativeTypes.Enum34)0u))
		{
			num += @struct.intptr_2.ToInt64();
			intptr_ = @struct.intptr_0.smethod_10(@struct.intptr_2);
		}
		return num;
	}

	internal static void smethod_411(RemoteProcess gclass2_0)
	{
		IntPtr intPtr = RecoveredRuntime.smethod_250(gclass2_0, NativeTypes.Enum32.flag_1, false, gclass2_0.ProcessId);
		if (intPtr == IntPtr.Zero)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(27572));
		}
		bool flag = RecoveredRuntime.TerminateProcess(intPtr, -1);
		RecoveredRuntime.smethod_27(gclass2_0, intPtr);
		if (flag)
		{
			return;
		}
		throw new Win32Exception(EncodedStringTable.smethod_0(27609));
	}

	internal static ProcessWindowInfo[] smethod_413()
	{
		ProcessWindowInfo.Class78 obj = new ProcessWindowInfo.Class78
		{
			list_0 = new List<ProcessWindowInfo>()
		};
		EnumWindows(obj.method_0, IntPtr.Zero);
		return obj.list_0.ToArray();
	}

	internal static bool smethod_427(RemoteProcess gclass2_0)
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

		RemoteProcess process = smethod_148(processName, bool_0: true).FirstOrDefault();
		SetSelectedProcess(mainForm, process);
	}
}
