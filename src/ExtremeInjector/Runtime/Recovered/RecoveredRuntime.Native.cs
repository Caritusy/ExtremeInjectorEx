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

	internal static void EnableFileDropMessages(FileDropMessageFilter class10_0, IntPtr intptr_0)
	{
		if (PlatformInfo.bool_2)
		{
			FileDropMessageFilter.MessageFilterChangeInfo @struct = default(FileDropMessageFilter.MessageFilterChangeInfo);
			@struct.Size = (uint)Marshal.SizeOf(typeof(FileDropMessageFilter.MessageFilterChangeInfo));
			FileDropMessageFilter.MessageFilterChangeInfo struct2 = @struct;
			RecoveredRuntime.ChangeWindowMessageFilterEx(intptr_0, 563u, FileDropMessageFilter.MessageFilterAction.Allow, ref struct2);
			RecoveredRuntime.ChangeWindowMessageFilterEx(intptr_0, 74u, FileDropMessageFilter.MessageFilterAction.Allow, ref struct2);
			RecoveredRuntime.ChangeWindowMessageFilterEx(intptr_0, 73u, FileDropMessageFilter.MessageFilterAction.Allow, ref struct2);
		}
		else if (PlatformInfo.bool_1)
		{
			RecoveredRuntime.ChangeWindowMessageFilter(563u, FileDropMessageFilter.LegacyMessageFilterAction.Add);
			RecoveredRuntime.ChangeWindowMessageFilter(74u, FileDropMessageFilter.LegacyMessageFilterAction.Add);
			RecoveredRuntime.ChangeWindowMessageFilter(73u, FileDropMessageFilter.LegacyMessageFilterAction.Add);
		}
		RecoveredRuntime.DragAcceptFiles(intptr_0, true);
	}

	internal static Icon GetFileIcon(string string_0, IconSize enum18_0)
	{
		ShellFileInfoNativeTypes.ShellFileInfo @struct = default(ShellFileInfoNativeTypes.ShellFileInfo);
		ShellFileInfoNativeTypes.ShellFileInfoFlags enum19_ = ShellFileInfoNativeTypes.ShellFileInfoFlags.Icon | ShellFileInfoNativeTypes.ShellFileInfoFlags.UseFileAttributes | ((enum18_0 == IconSize.const_0) ? ShellFileInfoNativeTypes.ShellFileInfoFlags.SmallIcon : ShellFileInfoNativeTypes.ShellFileInfoFlags.LargeIcon);
		RecoveredRuntime.SHGetFileInfo(string_0, 128u, ref @struct, (uint)Marshal.SizeOf(@struct), enum19_);
		Icon result;
		try
		{
			using (Icon icon = Icon.FromHandle(@struct.IconHandle))
			{
				result = (Icon)icon.Clone();
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	internal static IntPtr AllocateAlignedThreadContext(ref NativeTypes.Struct55 struct55_0)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(typeof(NativeTypes.Struct55).SizeOf() + 16);
		intPtr = intPtr.Add(-intPtr.ToInt64() & 15L);
		Marshal.StructureToPtr(struct55_0, intPtr, false);
		return intPtr;
	}

	internal static int SizeOfNativeType(Type type_0)
	{
		if (type_0 == typeof(char))
		{
			return 2;
		}
		if (typeof(Enum).IsAssignableFrom(type_0))
		{
			return Marshal.SizeOf(Enum.GetUnderlyingType(type_0));
		}
		return Marshal.SizeOf(type_0);
	}

	[DllImport("ntdll.dll")]
	internal static extern uint RtlDosApplyFileIsolationRedirection_Ustr(uint uint_0, ref NativeTypes.Struct43 struct43_0, ref NativeTypes.Struct43 struct43_1, ref NativeTypes.Struct43 struct43_2, ref NativeTypes.Struct43 struct43_3, ref IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, UIntPtr uintptr_1);

	internal static List<NativeProcessInfo> EnumerateSystemProcesses()
	{
		List<NativeProcessInfo> list = new List<NativeProcessInfo>();
		int num = 65536;
		IntPtr intPtr = Marshal.AllocHGlobal(65536);
		int num3;
		uint num2;
		while ((num2 = RecoveredRuntime.NtQuerySystemInformation(NativeTypes.Enum24.const_5, intPtr, num, out num3)) == 3221225476u)
		{
			Marshal.FreeHGlobal(intPtr);
			num += 65536;
			intPtr = Marshal.AllocHGlobal(num);
		}
		if (num2 != 0u)
		{
			return list;
		}
		IntPtr intPtr2 = intPtr;
		for (;;)
		{
			NativeProcessInfo @class = new NativeProcessInfo();
			NativeTypes.Struct39 @struct = (NativeTypes.Struct39)Marshal.PtrToStructure(intPtr2, typeof(NativeTypes.Struct39));
			IntPtr intPtr3 = intPtr2.Add(typeof(NativeTypes.Struct39).SizeOf());
			int num4 = 0;
			while ((long)num4 < (long)((ulong)@struct.uint_1))
			{
				NativeTypes.Struct40 item = (NativeTypes.Struct40)Marshal.PtrToStructure(intPtr3, typeof(NativeTypes.Struct40));
				@class.GetThreads().Add(item);
				intPtr3 = intPtr3.Add(typeof(NativeTypes.Struct40).SizeOf());
				num4++;
			}
			@class.SetProcessRecord(@struct);
			list.Add(@class);
			if (@struct.uint_0 == 0u)
			{
				break;
			}
			intPtr2 = intPtr2.Add((long)((ulong)@struct.uint_0));
		}
		Marshal.FreeHGlobal(intPtr);
		return list;
	}

	[DllImport("psapi.dll")]
	internal static extern uint GetModuleBaseName(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	[DllImport("ntdll.dll", SetLastError = true)]
	internal static extern uint NtQueryInformationProcess(IntPtr intptr_0, NativeTypes.Enum26 enum26_0, out NativeTypes.Struct45 struct45_0, int int_0, out int int_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0, out UIntPtr uintptr_1);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0, out UIntPtr uintptr_1);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool OpenProcessToken(IntPtr intptr_0, uint uint_0, out IntPtr intptr_1);

	[DllImport("psapi.dll")]
	internal static extern uint GetModuleFileNameEx(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsWindowVisible(IntPtr intptr_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool LookupPrivilegeValue(string string_0, string string_1, out TokenPrivilegeNativeTypes.Luid struct35_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool VirtualFree(IntPtr intptr_0, UIntPtr uintptr_0, NativeTypes.Enum28 enum28_0);

	internal static bool PopulateThreadInformation(ProcessThreadInfo class75_0)
	{
		IntPtr intPtr = RecoveredRuntime.OpenThread(NativeTypes.Enum31.flag_5, false, class75_0.GetThreadId());
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		NativeTypes.Struct49 @struct;
		int num;
		if (RecoveredRuntime.NtQueryInformationThread(intPtr, NativeTypes.Enum25.const_0, out @struct, typeof(NativeTypes.Struct49).SizeOf(), out num) != 0u)
		{
			RecoveredRuntime.CloseHandle(intPtr);
			return false;
		}
		class75_0.SetBasePriority((int)@struct.uint_2);
		class75_0.SetCurrentPriority((int)@struct.uint_1);
		class75_0.SetTebAddress(@struct.intptr_0);
		IntPtr intptr_;
		if (RecoveredRuntime.NtQueryInformationThreadPointer(intPtr, NativeTypes.Enum25.const_9, out intptr_, IntPtr.Size, out num) == 0u)
		{
			class75_0.SetStartAddress(intptr_);
			class75_0.SetPriorityLevel((ThreadPriorityLevel)RecoveredRuntime.GetThreadPriority(intPtr));
			RecoveredRuntime.CloseHandle(intPtr);
			return true;
		}
		RecoveredRuntime.CloseHandle(intPtr);
		return false;
	}

	[DllImport("kernel32.dll")]
	internal static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, IntPtr intptr_2, IntPtr intptr_3, uint uint_0, IntPtr intptr_4);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EnumWindows(NativeTypes.WindowEnumerationCallback delegate46_0, IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	internal static extern uint QueryDosDevice(string string_0, [Out] StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool AdjustTokenPrivileges(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, ref TokenPrivilegeNativeTypes.TokenPrivileges struct34_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool TerminateProcess(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll")]
	internal static extern uint GetClassLong(IntPtr intptr_0, int int_0);

	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess", SetLastError = true)]
	internal static extern uint NtQueryInformationProcessPointer(IntPtr intptr_0, NativeTypes.Enum26 enum26_0, out IntPtr intptr_1, int int_0, out int int_1);

	[DllImport("kernel32")]
	internal static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	[DllImport("kernel32.dll")]
	internal static extern bool GetThreadContext(IntPtr intptr_0, ref NativeTypes.Struct54 struct54_0);

	[DllImport("shell32.dll")]
	internal static extern void DragFinish(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetExitCodeProcess(IntPtr intptr_0, out uint uint_0);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsWindow(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern int SuspendThread(IntPtr intptr_0);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, NativeTypes.Enum28 enum28_0);

	internal static void ReadApiSetSchemaV6(IntPtr intptr_0)
	{
		foreach (ApiSetSchema.Struct68 @struct in ApiSetSchema.ReadEntries<ApiSetSchema.Struct69, ApiSetSchema.Struct68>(intptr_0))
		{
			List<string> list = new List<string>();
			string key = Marshal.PtrToStringUni(intptr_0.Add((long)((ulong)@struct.uint_0)), (int)(@struct.uint_1 / 2u)).ToLowerInvariant();
			foreach (ApiSetSchema.Struct66 struct2 in ApiSetSchema.ReadEntries<ApiSetSchema.Struct67, ApiSetSchema.Struct66>(intptr_0.Add((long)((ulong)@struct.uint_2))))
			{
				string text = Marshal.PtrToStringUni(intptr_0.Add((long)((ulong)struct2.uint_2)), (int)(struct2.uint_3 / 2u));
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
			ApiSetSchema.dictionary_0.Add(key, list);
		}
	}

	[DllImport("psapi.dll", SetLastError = true)]
	internal static extern bool EnumProcessModulesEx(IntPtr intptr_0, IntPtr[] intptr_1, uint uint_0, out uint uint_1, uint uint_2);

	internal static bool ResolveSideBySideDllPath(ref string string_0, IntPtr intptr_0)
	{
		if (string_0.EndsWith(EncodedStringTable.DecodeString(10075)))
		{
			string_0 = string_0.Substring(0, string_0.Length - 4);
		}
		NativeTypes.Struct43 @struct;
		RecoveredRuntime.RtlInitUnicodeString(out @struct, EncodedStringTable.DecodeString(10075));
		NativeTypes.Struct43 struct2;
		RecoveredRuntime.RtlInitUnicodeString(out struct2, string_0);
		NativeTypes.Struct43 struct3;
		RecoveredRuntime.RtlInitUnicodeString(out struct3, EncodedStringTable.DecodeString(394));
		IntPtr intPtr = Marshal.AllocHGlobal(255);
		NativeTypes.Struct43 struct4 = default(NativeTypes.Struct43);
		struct4.intptr_0 = intPtr;
		struct4.ushort_1 = 255;
		NativeTypes.Struct43 struct5 = struct4;
		IntPtr zero = IntPtr.Zero;
		if (intptr_0 != NativeTypes.intptr_0)
		{
			RecoveredRuntime.ActivateActCtx(intptr_0, out zero);
		}
		IntPtr zero2 = IntPtr.Zero;
		bool flag = RecoveredRuntime.RtlDosApplyFileIsolationRedirection_Ustr(1u, ref struct2, ref @struct, ref struct5, ref struct3, ref zero2, IntPtr.Zero, UIntPtr.Zero, UIntPtr.Zero) != 0u;
		if (zero != IntPtr.Zero && intptr_0 != NativeTypes.intptr_0)
		{
			RecoveredRuntime.DeactivateActCtx(0, zero);
		}
		if (!flag)
		{
			string_0 = ((NativeTypes.Struct43)Marshal.PtrToStructure(zero2, typeof(NativeTypes.Struct43))).ToString();
		}
		else
		{
			RecoveredRuntime.RtlFreeUnicodeString(ref struct3);
			string_0 += EncodedStringTable.DecodeString(10075);
		}
		Marshal.FreeHGlobal(intPtr);
		return false;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool TerminateThread(IntPtr intptr_0, int int_0);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr LoadLibrary(string string_0);

	[DllImport("ntdll.dll")]
	internal static extern void RtlFreeUnicodeString(ref NativeTypes.Struct43 struct43_0);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern int GetWindowThreadProcessId(IntPtr intptr_0, out int int_0);

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	[DllImport("psapi.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EnumProcessModules(IntPtr intptr_0, [Out][MarshalAs(UnmanagedType.LPArray)] IntPtr[] intptr_1, uint uint_0, out uint uint_1);

	[DllImport("shell32.dll")]
	internal static extern uint DragQueryFile(IntPtr intptr_0, uint uint_0, [Out] StringBuilder stringBuilder_0, uint uint_1);

	[DllImport("kernel32.dll")]
	internal static extern bool Thread32First(IntPtr intptr_0, ref NativeTypes.Struct44 struct44_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern uint WaitForSingleObject(IntPtr intptr_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FlushInstructionCache(IntPtr processHandle, IntPtr baseAddress, UIntPtr size);

	[DllImport("kernel32.dll")]
	internal static extern bool SetThreadContext(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr VirtualAlloc(IntPtr intptr_0, UIntPtr uintptr_0, NativeTypes.Enum33 enum33_0, NativeTypes.Enum34 enum34_0);

	[DllImport("kernel32.dll")]
	internal static extern int VirtualQuery(IntPtr intptr_0, out NativeTypes.Struct47 struct47_0, uint uint_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool VirtualProtect(IntPtr intptr_0, UIntPtr uintptr_0, NativeTypes.Enum34 enum34_0, out NativeTypes.Enum34 enum34_1);

	[DllImport("kernel32.dll", EntryPoint = "SetThreadContext")]
	internal static extern bool SetThreadContext32(IntPtr intptr_0, ref NativeTypes.Struct54 struct54_0);

	[DllImport("psapi.dll", SetLastError = true)]
	internal static extern bool EnumProcesses(uint[] uint_0, uint uint_1, out uint uint_2);

	[DllImport("shell32.dll")]
	internal static extern void DragAcceptFiles(IntPtr intptr_0, bool bool_0);

	internal static AsmJitRuntime.Delegate0 ResolveAsmJitAllocationDelegate()
	{
		IntPtr intPtr = Marshal.ReadIntPtr(Marshal.ReadIntPtr(((NativeAsmJitMemoryManager)RecoveredRuntime.CreateAsmJitMemoryManager()).intptr_0), 4 * IntPtr.Size);
		if (AsmJitRuntime.bool_0)
		{
			byte[] array = new byte[100];
			Marshal.Copy(intPtr, array, 0, array.Length);
			int num = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(14185), EncodedStringTable.DecodeString(14206), 0);
			if (num == -1)
			{
				return null;
			}
			int num2 = BitConverter.ToInt32(array, num + 1);
			return (AsmJitRuntime.Delegate0)Marshal.GetDelegateForFunctionPointer(intPtr.Add(num + num2 + 5), typeof(AsmJitRuntime.Delegate0));
		}
		else
		{
			byte[] array2 = new byte[20];
			Marshal.Copy(intPtr, array2, 0, array2.Length);
			int num3 = RecoveredRuntime.FindMaskedPattern(array2, EncodedStringTable.DecodeString(14219), EncodedStringTable.DecodeString(14228), 0);
			if (num3 == -1)
			{
				return null;
			}
			int num4 = BitConverter.ToInt32(array2, num3 + 3);
			IntPtr intPtr2 = intPtr.Add(num3 + 2 + num4 + 5);
			array2 = new byte[100];
			Marshal.Copy(intPtr2, array2, 0, array2.Length);
			num3 = RecoveredRuntime.FindMaskedPattern(array2, EncodedStringTable.DecodeString(14233), EncodedStringTable.DecodeString(14258), 0);
			if (num3 == -1)
			{
				return null;
			}
			num4 = BitConverter.ToInt32(array2, num3 + 1);
			return (AsmJitRuntime.Delegate0)Marshal.GetDelegateForFunctionPointer(intPtr2.Add(num3 + num4 + 5), typeof(AsmJitRuntime.Delegate0));
		}
	}

	[DllImport("psapi.dll")]
	internal static extern uint GetProcessImageFileName(IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool QueryFullProcessImageName([In] IntPtr intptr_0, [In] int int_0, [Out] StringBuilder stringBuilder_0, ref int int_1);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ChangeWindowMessageFilter(uint uint_0, FileDropMessageFilter.LegacyMessageFilterAction enum2_0);

	internal static void ReadApiSetSchemaV2(IntPtr intptr_0)
	{
		ApiSetSchema.Struct61 @struct = (ApiSetSchema.Struct61)Marshal.PtrToStructure(intptr_0, typeof(ApiSetSchema.Struct61));
		int num = 0;
		while ((long)num < (long)((ulong)@struct.uint_3))
		{
			IntPtr intPtr = intptr_0.Add((long)((ulong)@struct.uint_5 + (ulong)((long)(num * typeof(ApiSetSchema.Struct60).SizeOf()))));
			if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr))
			{
				return;
			}
			ApiSetSchema.Struct60 struct2 = (ApiSetSchema.Struct60)Marshal.PtrToStructure(intPtr, typeof(ApiSetSchema.Struct60));
			IntPtr ptr = intptr_0.Add((long)((ulong)@struct.uint_4 + (ulong)((long)typeof(ApiSetSchema.Struct59).SizeOf() * (long)((ulong)struct2.uint_1))));
			if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr))
			{
				return;
			}
			ApiSetSchema.Struct59 struct3 = (ApiSetSchema.Struct59)Marshal.PtrToStructure(ptr, typeof(ApiSetSchema.Struct59));
			IntPtr intPtr2 = intptr_0.Add((long)((ulong)struct3.uint_1));
			if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr2))
			{
				return;
			}
			string key = Marshal.PtrToStringUni(intPtr2, (int)(struct3.uint_3 / 2u)).ToLowerInvariant();
			List<string> list = new List<string>();
			int num2 = 0;
			while ((long)num2 < (long)((ulong)struct3.uint_5))
			{
				IntPtr intPtr3 = intptr_0.Add((long)((ulong)struct3.uint_4 + (ulong)((long)(num2 * typeof(ApiSetSchema.Struct62).SizeOf()))));
				if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr3))
				{
					return;
				}
				ApiSetSchema.Struct62 struct4 = (ApiSetSchema.Struct62)Marshal.PtrToStructure(intPtr3, typeof(ApiSetSchema.Struct62));
				IntPtr intPtr4 = intptr_0.Add((long)((ulong)struct4.uint_3));
				if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr4))
				{
					return;
				}
				string text = Marshal.PtrToStringUni(intPtr4, (int)(struct4.uint_4 / 2u));
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
				num2++;
			}
			ApiSetSchema.dictionary_0.Add(key, list);
			num++;
		}
	}

	[DllImport("shell32.dll")]
	internal static extern bool DragQueryPoint(IntPtr intptr_0, out FileDropMessageFilter.NativePoint struct5_0);

	[DllImport("kernel32.dll")]
	internal static extern ulong VerSetConditionMask(ulong ulong_0, uint uint_0, byte byte_0);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenProcess(NativeTypes.Enum32 enum32_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr CreateToolhelp32Snapshot(NativeTypes.Enum27 enum27_0, int int_0);

	internal static bool TryInitializePeb64Address(Peb64 class118_0)
	{
		if (!PlatformInfo.bool_0)
		{
			return false;
		}
		IntPtr intPtr = RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_9, false, class118_0.gclass2_0.ProcessId);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		NativeTypes.Struct45 @struct;
		int num;
		if (RecoveredRuntime.NtQueryInformationProcess(intPtr, NativeTypes.Enum26.const_4, out @struct, typeof(NativeTypes.Struct45).SizeOf(), out num) != 0u)
		{
			RecoveredRuntime.CloseHandle(intPtr);
			return false;
		}
		RecoveredRuntime.SetRemotePebAddress(class118_0, @struct.intptr_1);
		RecoveredRuntime.CloseHandle(intPtr);
		return true;
	}

	[DllImport("user32.dll")]
	internal static extern IntPtr GetClassLongPtr(IntPtr intptr_0, int int_0);

	[DllImport("shell32.dll")]
	internal static extern IntPtr SHGetFileInfo(string string_0, uint uint_0, ref ShellFileInfoNativeTypes.ShellFileInfo struct36_0, uint uint_1, ShellFileInfoNativeTypes.ShellFileInfoFlags enum19_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetExitCodeThread(IntPtr intptr_0, out uint uint_0);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenThread(NativeTypes.Enum31 enum31_0, bool bool_0, int int_0);

	[DllImport("ntdll.dll", SetLastError = true)]
	internal static extern uint NtQueryInformationThread(IntPtr intptr_0, NativeTypes.Enum25 enum25_0, out NativeTypes.Struct49 struct49_0, int int_0, out int int_1);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ChangeWindowMessageFilterEx(IntPtr intptr_0, uint uint_0, FileDropMessageFilter.MessageFilterAction enum1_0, ref FileDropMessageFilter.MessageFilterChangeInfo struct6_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern uint GetWindowsDirectory(StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetProcessDEPPolicy(IntPtr intptr_0, out uint uint_0, out bool bool_0);

	[DllImport("kernel32.dll")]
	internal static extern bool Wow64SetThreadContext(IntPtr intptr_0, ref NativeTypes.Struct54 struct54_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, NativeTypes.Enum34 enum34_0, out NativeTypes.Enum34 enum34_1);

	[DllImport("kernel32.dll")]
	internal static extern uint GetCurrentProcessId();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern int ResumeThread(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	internal static extern bool Thread32Next(IntPtr intptr_0, ref NativeTypes.Struct44 struct44_0);

	[DllImport("Kernel32.dll", SetLastError = true)]
	internal static extern void ReleaseActCtx(IntPtr intptr_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int GetWindowTextLength(IntPtr intptr_0);

	[DllImport("ntdll.dll", SetLastError = true)]
	internal static extern uint NtQuerySystemInformation(NativeTypes.Enum24 enum24_0, IntPtr intptr_0, int int_0, out int int_1);

	internal static void ReadApiSetSchemaV4(IntPtr intptr_0)
	{
		foreach (ApiSetSchema.Struct64 @struct in ApiSetSchema.ReadEntries<ApiSetSchema.Struct65, ApiSetSchema.Struct64>(intptr_0))
		{
			List<string> list = new List<string>();
			string key = Marshal.PtrToStringUni(intptr_0.Add((long)((ulong)@struct.uint_1)), (int)(@struct.uint_2 / 2u)).ToLowerInvariant();
			foreach (ApiSetSchema.Struct62 struct2 in ApiSetSchema.ReadEntries<ApiSetSchema.Struct63, ApiSetSchema.Struct62>(intptr_0.Add((long)((ulong)@struct.uint_5))))
			{
				string text = Marshal.PtrToStringUni(intptr_0.Add((long)((ulong)struct2.uint_3)), (int)(struct2.uint_4 / 2u));
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
			ApiSetSchema.dictionary_0.Add(key, list);
		}
	}

	[DllImport("ntdll.dll")]
	internal static extern uint RtlGetVersion(ref NativeTypes.Struct38 struct38_0);

	[DllImport("ntdll.dll")]
	internal static extern uint NtCreateThreadEx(out IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3, uint uint_4, IntPtr intptr_5);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
	internal static extern long StrFormatByteSize(long long_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("psapi.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetModuleInformation(IntPtr intptr_0, IntPtr intptr_1, out NativeTypes.Struct46 struct46_0, int int_0);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, NativeTypes.Enum33 enum33_0, NativeTypes.Enum34 enum34_0);

	internal static bool SetAlignedThreadContext(ref NativeTypes.Struct55 struct55_0, IntPtr intptr_0)
	{
		IntPtr intPtr = AllocateAlignedThreadContext(ref struct55_0);
		bool result = SetThreadContext(intptr_0, intPtr);
		struct55_0 = (NativeTypes.Struct55)Marshal.PtrToStructure(intPtr, typeof(NativeTypes.Struct55));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ActivateActCtx(IntPtr intptr_0, out IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	internal static extern int GetThreadPriority(IntPtr intptr_0);

	internal static bool GetAlignedThreadContext(ref NativeTypes.Struct55 struct55_0, IntPtr intptr_0)
	{
		IntPtr intPtr = AllocateAlignedThreadContext(ref struct55_0);
		bool threadContext_ = GetThreadContextAligned(intptr_0, intPtr);
		struct55_0 = (NativeTypes.Struct55)Marshal.PtrToStructure(intPtr, typeof(NativeTypes.Struct55));
		Marshal.FreeHGlobal(intPtr);
		return threadContext_;
	}

	[DllImport("ntdll.dll")]
	internal static extern int RtlNtStatusToDosError(uint uint_0);

	[DllImport("kernel32.dll", EntryPoint = "GetThreadContext")]
	internal static extern bool GetThreadContextAligned(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	internal unsafe static extern bool WriteProcessMemoryBuffer(IntPtr intptr_0, IntPtr intptr_1, byte* pByte_0, UIntPtr uintptr_0, UIntPtr* pUintPtr_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr SendMessageTimeout(IntPtr intptr_0, uint uint_0, UIntPtr uintptr_0, IntPtr intptr_1, NativeTypes.SendMessageTimeoutFlags enum20_0, uint uint_1, out IntPtr intptr_2);

	internal static bool TryInitializePeb32Address(Peb32 class119_0)
	{
		if (RecoveredRuntime.IsWow64RemoteProcess(class119_0.gclass2_0))
		{
			IntPtr intPtr = RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_9, false, class119_0.gclass2_0.ProcessId);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			IntPtr intptr_;
			int num;
			if (RecoveredRuntime.NtQueryInformationProcessPointer(intPtr, NativeTypes.Enum26.const_24, out intptr_, IntPtr.Size, out num) == 0u)
			{
				RecoveredRuntime.SetRemotePebAddress(class119_0, intptr_);
				RecoveredRuntime.CloseHandle(intPtr);
				return true;
			}
			RecoveredRuntime.CloseHandle(intPtr);
			return false;
		}
		else
		{
			if (!RecoveredRuntime.Is32BitProcess(class119_0.gclass2_0))
			{
				return false;
			}
			IntPtr intPtr2 = RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_9, false, class119_0.gclass2_0.ProcessId);
			if (intPtr2 == IntPtr.Zero)
			{
				return false;
			}
			NativeTypes.Struct45 @struct;
			int num2;
			if (RecoveredRuntime.NtQueryInformationProcess(intPtr2, NativeTypes.Enum26.const_4, out @struct, typeof(NativeTypes.Struct45).SizeOf(), out num2) != 0u)
			{
				RecoveredRuntime.CloseHandle(intPtr2);
				return false;
			}
			RecoveredRuntime.SetRemotePebAddress(class119_0, @struct.intptr_1);
			RecoveredRuntime.CloseHandle(intPtr2);
			return true;
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	internal unsafe static extern bool ReadProcessMemoryBuffer(IntPtr intptr_0, IntPtr intptr_1, byte* pByte_0, UIntPtr uintptr_0, UIntPtr* pUintPtr_0);

	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationThread", SetLastError = true)]
	internal static extern uint NtQueryInformationThreadPointer(IntPtr intptr_0, NativeTypes.Enum25 enum25_0, out IntPtr intptr_1, int int_0, out int int_1);

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeactivateActCtx(int int_0, IntPtr intptr_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr CreateActCtx(ref NativeTypes.Struct50 struct50_0);

	[DllImport("ntdll.dll")]
	internal static extern void RtlInitUnicodeString(out NativeTypes.Struct43 struct43_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool VerifyVersionInfo([In] ref NativeTypes.Struct38 struct38_0, uint uint_0, ulong ulong_0);

	[DllImport("kernel32.dll")]
	internal static extern bool Wow64GetThreadContext(IntPtr intptr_0, ref NativeTypes.Struct54 struct54_0);

	[DllImport("ntdll.dll")]
	internal static extern uint NtSetInformationThread(IntPtr intptr_0, NativeTypes.Enum25 enum25_0, IntPtr intptr_1, int int_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool GetTokenInformation(IntPtr intptr_0, TokenPrivilegeNativeTypes.TokenInformationClass enum16_0, out uint uint_0, uint uint_1, out uint uint_2);

	internal static IntPtr AssembleRemoteCode(IntPtr intptr_0, AsmJitAssembler class53_0, RemoteCodeExecutorBase class84_0)
	{
		IntPtr intPtr = RecoveredRuntime.GetAssemblerCodePointer(class53_0);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		if (intptr_0 == IntPtr.Zero)
		{
			intptr_0 = RecoveredRuntime.AllocateRemoteMemory(class84_0, (long)RecoveredRuntime.GetAssemblerOffset(class53_0), NativeTypes.Enum34.flag_2);
			if (intptr_0 == IntPtr.Zero)
			{
				return IntPtr.Zero;
			}
		}
		int num = RecoveredRuntime.RelocateAssemblerCode(class53_0, intPtr, intptr_0);
		byte[] array = new byte[num];
		Marshal.Copy(intPtr, array, 0, num);
		RecoveredRuntime.CreateAsmJitMemoryManager().Release(intPtr);
		RecoveredRuntime.DisposeAssemblerState(class53_0);
		class84_0.WriteArray<byte>(intptr_0, array);
		return intptr_0;
	}
}
