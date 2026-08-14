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

	internal static void EnableFileDropMessages(FileDropMessageFilter fileDropMessageFilter, IntPtr address)
	{
		if (PlatformInfo.flag3)
		{
			FileDropMessageFilter.MessageFilterChangeInfo @struct = default(FileDropMessageFilter.MessageFilterChangeInfo);
			@struct.Size = (uint)Marshal.SizeOf(typeof(FileDropMessageFilter.MessageFilterChangeInfo));
			FileDropMessageFilter.MessageFilterChangeInfo struct2 = @struct;
			RecoveredRuntime.ChangeWindowMessageFilterEx(address, 563u, FileDropMessageFilter.MessageFilterAction.Allow, ref struct2);
			RecoveredRuntime.ChangeWindowMessageFilterEx(address, 74u, FileDropMessageFilter.MessageFilterAction.Allow, ref struct2);
			RecoveredRuntime.ChangeWindowMessageFilterEx(address, 73u, FileDropMessageFilter.MessageFilterAction.Allow, ref struct2);
		}
		else if (PlatformInfo.flag2)
		{
			RecoveredRuntime.ChangeWindowMessageFilter(563u, FileDropMessageFilter.LegacyMessageFilterAction.Add);
			RecoveredRuntime.ChangeWindowMessageFilter(74u, FileDropMessageFilter.LegacyMessageFilterAction.Add);
			RecoveredRuntime.ChangeWindowMessageFilter(73u, FileDropMessageFilter.LegacyMessageFilterAction.Add);
		}
		RecoveredRuntime.DragAcceptFiles(address, true);
	}

	internal static Icon GetFileIcon(string text, IconSize iconSize)
	{
		ShellFileInfoNativeTypes.ShellFileInfo @struct = default(ShellFileInfoNativeTypes.ShellFileInfo);
		ShellFileInfoNativeTypes.ShellFileInfoFlags enum19_ = ShellFileInfoNativeTypes.ShellFileInfoFlags.Icon | ShellFileInfoNativeTypes.ShellFileInfoFlags.UseFileAttributes | ((iconSize == IconSize.Small) ? ShellFileInfoNativeTypes.ShellFileInfoFlags.SmallIcon : ShellFileInfoNativeTypes.ShellFileInfoFlags.LargeIcon);
		RecoveredRuntime.SHGetFileInfo(text, 128u, ref @struct, (uint)Marshal.SizeOf(@struct), enum19_);
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

	internal static IntPtr AllocateAlignedThreadContext(ref NativeTypes.Context64 context64)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(typeof(NativeTypes.Context64).SizeOf() + 16);
		intPtr = intPtr.Add(-intPtr.ToInt64() & 15L);
		Marshal.StructureToPtr(context64, intPtr, false);
		return intPtr;
	}

	internal static int SizeOfNativeType(Type typeValue)
	{
		if (typeValue == typeof(char))
		{
			return 2;
		}
		if (typeof(Enum).IsAssignableFrom(typeValue))
		{
			return Marshal.SizeOf(Enum.GetUnderlyingType(typeValue));
		}
		return Marshal.SizeOf(typeValue);
	}

	[DllImport("ntdll.dll")]
	internal static extern uint RtlDosApplyFileIsolationRedirection_Ustr(uint uintValue, ref NativeTypes.UnicodeString unicodeString, ref NativeTypes.UnicodeString unicodeString2, ref NativeTypes.UnicodeString unicodeString3, ref NativeTypes.UnicodeString unicodeString4, ref IntPtr address, IntPtr address2, UIntPtr address3, UIntPtr address4);

	internal static List<NativeProcessInfo> EnumerateSystemProcesses()
	{
		List<NativeProcessInfo> list = new List<NativeProcessInfo>();
		int num = 65536;
		IntPtr intPtr = Marshal.AllocHGlobal(65536);
		int num3;
		uint num2;
		while ((num2 = RecoveredRuntime.NtQuerySystemInformation(NativeTypes.SystemInformationClass.ProcessInformation, intPtr, num, out num3)) == 3221225476u)
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
			NativeTypes.SystemProcessInformation @struct = (NativeTypes.SystemProcessInformation)Marshal.PtrToStructure(intPtr2, typeof(NativeTypes.SystemProcessInformation));
			IntPtr intPtr3 = intPtr2.Add(typeof(NativeTypes.SystemProcessInformation).SizeOf());
			int num4 = 0;
			while ((long)num4 < (long)((ulong)@struct.uintValue2))
			{
				NativeTypes.SystemThreadInformation item = (NativeTypes.SystemThreadInformation)Marshal.PtrToStructure(intPtr3, typeof(NativeTypes.SystemThreadInformation));
				@class.GetThreads().Add(item);
				intPtr3 = intPtr3.Add(typeof(NativeTypes.SystemThreadInformation).SizeOf());
				num4++;
			}
			@class.SetProcessRecord(@struct);
			list.Add(@class);
			if (@struct.uintValue == 0u)
			{
				break;
			}
			intPtr2 = intPtr2.Add((long)((ulong)@struct.uintValue));
		}
		Marshal.FreeHGlobal(intPtr);
		return list;
	}

	[DllImport("psapi.dll")]
	internal static extern uint GetModuleBaseName(IntPtr address, IntPtr address2, StringBuilder stringBuilder, int intValue);

	[DllImport("ntdll.dll", SetLastError = true)]
	internal static extern uint NtQueryInformationProcess(IntPtr address, NativeTypes.ProcessInformationClass processInformationClass, out NativeTypes.ProcessBasicInformation processBasicInformation, int intValue, out int intValue2);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool WriteProcessMemory(IntPtr address, IntPtr address2, IntPtr address3, UIntPtr address4, out UIntPtr address5);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool ReadProcessMemory(IntPtr address, IntPtr address2, IntPtr address3, UIntPtr address4, out UIntPtr address5);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool OpenProcessToken(IntPtr address, uint uintValue, out IntPtr address2);

	[DllImport("psapi.dll")]
	internal static extern uint GetModuleFileNameEx(IntPtr address, IntPtr address2, StringBuilder stringBuilder, int intValue);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsWindowVisible(IntPtr address);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool LookupPrivilegeValue(string text, string text2, out TokenPrivilegeNativeTypes.Luid luid);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool VirtualFree(IntPtr address, UIntPtr address2, NativeTypes.MemoryFreeType memoryFreeType);

	internal static bool PopulateThreadInformation(ProcessThreadInfo processThreadInfo)
	{
		IntPtr intPtr = RecoveredRuntime.OpenThread(NativeTypes.ThreadAccessRights.QueryInformation, false, processThreadInfo.GetThreadId());
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		NativeTypes.ThreadBasicInformation @struct;
		int num;
		if (RecoveredRuntime.NtQueryInformationThread(intPtr, NativeTypes.ThreadInformationClass.BasicInformation, out @struct, typeof(NativeTypes.ThreadBasicInformation).SizeOf(), out num) != 0u)
		{
			RecoveredRuntime.CloseHandle(intPtr);
			return false;
		}
		processThreadInfo.SetBasePriority((int)@struct.uintValue3);
		processThreadInfo.SetCurrentPriority((int)@struct.uintValue2);
		processThreadInfo.SetTebAddress(@struct.address);
		IntPtr intptr_;
		if (RecoveredRuntime.NtQueryInformationThreadPointer(intPtr, NativeTypes.ThreadInformationClass.Win32StartAddress, out intptr_, IntPtr.Size, out num) == 0u)
		{
			processThreadInfo.SetStartAddress(intptr_);
			processThreadInfo.SetPriorityLevel((ThreadPriorityLevel)RecoveredRuntime.GetThreadPriority(intPtr));
			RecoveredRuntime.CloseHandle(intPtr);
			return true;
		}
		RecoveredRuntime.CloseHandle(intPtr);
		return false;
	}

	[DllImport("kernel32.dll")]
	internal static extern IntPtr CreateRemoteThread(IntPtr address, IntPtr address2, UIntPtr address3, IntPtr address4, IntPtr address5, uint uintValue, IntPtr address6);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EnumWindows(NativeTypes.WindowEnumerationCallback windowEnumerationCallback, IntPtr address);

	[DllImport("kernel32.dll")]
	internal static extern uint QueryDosDevice(string text, [Out] StringBuilder stringBuilder, int intValue);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr GetModuleHandle(string text);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool AdjustTokenPrivileges(IntPtr address, [MarshalAs(UnmanagedType.Bool)] bool flag, ref TokenPrivilegeNativeTypes.TokenPrivileges tokenPrivileges, uint uintValue, IntPtr address2, IntPtr address3);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool TerminateProcess(IntPtr address, int intValue);

	[DllImport("user32.dll")]
	internal static extern uint GetClassLong(IntPtr address, int intValue);

	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess", SetLastError = true)]
	internal static extern uint NtQueryInformationProcessPointer(IntPtr address, NativeTypes.ProcessInformationClass processInformationClass, out IntPtr address2, int intValue, out int intValue2);

	[DllImport("kernel32")]
	internal static extern bool MoveFileEx(string text, string text2, int intValue);

	[DllImport("kernel32.dll")]
	internal static extern bool GetThreadContext(IntPtr address, ref NativeTypes.Context32 context32);

	[DllImport("shell32.dll")]
	internal static extern void DragFinish(IntPtr address);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetExitCodeProcess(IntPtr address, out uint uintValue);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsWindow(IntPtr address);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern int SuspendThread(IntPtr address);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool VirtualFreeEx(IntPtr address, IntPtr address2, UIntPtr address3, NativeTypes.MemoryFreeType memoryFreeType);

	internal static void ReadApiSetSchemaV6(IntPtr address)
	{
		foreach (ApiSetSchema.ApiSetNamespaceEntryV6 @struct in ApiSetSchema.ReadEntries<ApiSetSchema.ApiSetNamespaceHeaderV6, ApiSetSchema.ApiSetNamespaceEntryV6>(address))
		{
			List<string> list = new List<string>();
			string key = Marshal.PtrToStringUni(address.Add((long)((ulong)@struct.uintValue)), (int)(@struct.uintValue2 / 2u)).ToLowerInvariant();
			foreach (ApiSetSchema.ApiSetValueEntryV6 struct2 in ApiSetSchema.ReadEntries<ApiSetSchema.ApiSetValueArrayV6, ApiSetSchema.ApiSetValueEntryV6>(address.Add((long)((ulong)@struct.uintValue3))))
			{
				string text = Marshal.PtrToStringUni(address.Add((long)((ulong)struct2.uintValue3)), (int)(struct2.uintValue4 / 2u));
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
			ApiSetSchema.dictionary.Add(key, list);
		}
	}

	[DllImport("psapi.dll", SetLastError = true)]
	internal static extern bool EnumProcessModulesEx(IntPtr address, IntPtr[] addresses, uint uintValue, out uint uintValue2, uint uintValue3);

	internal static bool ResolveSideBySideDllPath(ref string text, IntPtr address)
	{
		if (text.EndsWith(EncodedStringTable.DecodeString(10075)))
		{
			text = text.Substring(0, text.Length - 4);
		}
		NativeTypes.UnicodeString @struct;
		RecoveredRuntime.RtlInitUnicodeString(out @struct, EncodedStringTable.DecodeString(10075));
		NativeTypes.UnicodeString struct2;
		RecoveredRuntime.RtlInitUnicodeString(out struct2, text);
		NativeTypes.UnicodeString struct3;
		RecoveredRuntime.RtlInitUnicodeString(out struct3, EncodedStringTable.DecodeString(394));
		IntPtr intPtr = Marshal.AllocHGlobal(255);
		NativeTypes.UnicodeString struct4 = default(NativeTypes.UnicodeString);
		struct4.address = intPtr;
		struct4.ushortValue2 = 255;
		NativeTypes.UnicodeString struct5 = struct4;
		IntPtr zero = IntPtr.Zero;
		if (address != NativeTypes.address)
		{
			RecoveredRuntime.ActivateActCtx(address, out zero);
		}
		IntPtr zero2 = IntPtr.Zero;
		bool flag = RecoveredRuntime.RtlDosApplyFileIsolationRedirection_Ustr(1u, ref struct2, ref @struct, ref struct5, ref struct3, ref zero2, IntPtr.Zero, UIntPtr.Zero, UIntPtr.Zero) != 0u;
		if (zero != IntPtr.Zero && address != NativeTypes.address)
		{
			RecoveredRuntime.DeactivateActCtx(0, zero);
		}
		if (!flag)
		{
			text = ((NativeTypes.UnicodeString)Marshal.PtrToStructure(zero2, typeof(NativeTypes.UnicodeString))).ToString();
		}
		else
		{
			RecoveredRuntime.RtlFreeUnicodeString(ref struct3);
			text += EncodedStringTable.DecodeString(10075);
		}
		Marshal.FreeHGlobal(intPtr);
		return false;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool TerminateThread(IntPtr address, int intValue);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr LoadLibrary(string text);

	[DllImport("ntdll.dll")]
	internal static extern void RtlFreeUnicodeString(ref NativeTypes.UnicodeString unicodeString);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern int GetWindowThreadProcessId(IntPtr address, out int intValue);

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsWow64Process(IntPtr address, out bool flag);

	[DllImport("psapi.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EnumProcessModules(IntPtr address, [Out][MarshalAs(UnmanagedType.LPArray)] IntPtr[] addresses, uint uintValue, out uint uintValue2);

	[DllImport("shell32.dll")]
	internal static extern uint DragQueryFile(IntPtr address, uint uintValue, [Out] StringBuilder stringBuilder, uint uintValue2);

	[DllImport("kernel32.dll")]
	internal static extern bool Thread32First(IntPtr address, ref NativeTypes.ThreadEntry32 threadEntry32);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern uint WaitForSingleObject(IntPtr address, uint uintValue);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool FlushInstructionCache(IntPtr processHandle, IntPtr baseAddress, UIntPtr size);

	[DllImport("kernel32.dll")]
	internal static extern bool SetThreadContext(IntPtr address, IntPtr address2);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr VirtualAlloc(IntPtr address, UIntPtr address2, NativeTypes.MemoryAllocationType memoryAllocationType, NativeTypes.MemoryProtection memoryProtection);

	[DllImport("kernel32.dll")]
	internal static extern int VirtualQuery(IntPtr address, out NativeTypes.MemoryBasicInformation memoryBasicInformation, uint uintValue);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr address, string text);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool VirtualProtect(IntPtr address, UIntPtr address2, NativeTypes.MemoryProtection memoryProtection, out NativeTypes.MemoryProtection memoryProtection2);

	[DllImport("kernel32.dll", EntryPoint = "SetThreadContext")]
	internal static extern bool SetThreadContext32(IntPtr address, ref NativeTypes.Context32 context32);

	[DllImport("psapi.dll", SetLastError = true)]
	internal static extern bool EnumProcesses(uint[] uintValueArray, uint uintValue, out uint uintValue2);

	[DllImport("shell32.dll")]
	internal static extern void DragAcceptFiles(IntPtr address, bool flag);

	internal static AsmJitRuntime.ReleaseNativeLibrary ResolveAsmJitAllocationDelegate()
	{
		IntPtr intPtr = Marshal.ReadIntPtr(Marshal.ReadIntPtr(((NativeAsmJitMemoryManager)RecoveredRuntime.CreateAsmJitMemoryManager()).virtualFunction), 4 * IntPtr.Size);
		if (AsmJitRuntime.flag)
		{
			byte[] array = new byte[100];
			Marshal.Copy(intPtr, array, 0, array.Length);
			int num = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(14185), EncodedStringTable.DecodeString(14206), 0);
			if (num == -1)
			{
				return null;
			}
			int num2 = BitConverter.ToInt32(array, num + 1);
			return (AsmJitRuntime.ReleaseNativeLibrary)Marshal.GetDelegateForFunctionPointer(intPtr.Add(num + num2 + 5), typeof(AsmJitRuntime.ReleaseNativeLibrary));
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
			return (AsmJitRuntime.ReleaseNativeLibrary)Marshal.GetDelegateForFunctionPointer(intPtr2.Add(num3 + num4 + 5), typeof(AsmJitRuntime.ReleaseNativeLibrary));
		}
	}

	[DllImport("psapi.dll")]
	internal static extern uint GetProcessImageFileName(IntPtr address, [Out] StringBuilder stringBuilder, uint uintValue);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool QueryFullProcessImageName([In] IntPtr address, [In] int intValue, [Out] StringBuilder stringBuilder, ref int intValue2);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ChangeWindowMessageFilter(uint uintValue, FileDropMessageFilter.LegacyMessageFilterAction legacyMessageFilterAction);

	internal static void ReadApiSetSchemaV2(IntPtr address)
	{
		ApiSetSchema.ApiSetNamespaceHeaderV2 @struct = (ApiSetSchema.ApiSetNamespaceHeaderV2)Marshal.PtrToStructure(address, typeof(ApiSetSchema.ApiSetNamespaceHeaderV2));
		int num = 0;
		while ((long)num < (long)((ulong)@struct.uintValue4))
		{
			IntPtr intPtr = address.Add((long)((ulong)@struct.uintValue6 + (ulong)((long)(num * typeof(ApiSetSchema.ApiSetEntryIndexV2).SizeOf()))));
			if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr))
			{
				return;
			}
			ApiSetSchema.ApiSetEntryIndexV2 struct2 = (ApiSetSchema.ApiSetEntryIndexV2)Marshal.PtrToStructure(intPtr, typeof(ApiSetSchema.ApiSetEntryIndexV2));
			IntPtr ptr = address.Add((long)((ulong)@struct.uintValue5 + (ulong)((long)typeof(ApiSetSchema.ApiSetNamespaceEntryV2).SizeOf() * (long)((ulong)struct2.uintValue2))));
			if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr))
			{
				return;
			}
			ApiSetSchema.ApiSetNamespaceEntryV2 struct3 = (ApiSetSchema.ApiSetNamespaceEntryV2)Marshal.PtrToStructure(ptr, typeof(ApiSetSchema.ApiSetNamespaceEntryV2));
			IntPtr intPtr2 = address.Add((long)((ulong)struct3.uintValue2));
			if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr2))
			{
				return;
			}
			string key = Marshal.PtrToStringUni(intPtr2, (int)(struct3.uintValue4 / 2u)).ToLowerInvariant();
			List<string> list = new List<string>();
			int num2 = 0;
			while ((long)num2 < (long)((ulong)struct3.uintValue6))
			{
				IntPtr intPtr3 = address.Add((long)((ulong)struct3.uintValue5 + (ulong)((long)(num2 * typeof(ApiSetSchema.ApiSetValueEntryV2).SizeOf()))));
				if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr3))
				{
					return;
				}
				ApiSetSchema.ApiSetValueEntryV2 struct4 = (ApiSetSchema.ApiSetValueEntryV2)Marshal.PtrToStructure(intPtr3, typeof(ApiSetSchema.ApiSetValueEntryV2));
				IntPtr intPtr4 = address.Add((long)((ulong)struct4.uintValue4));
				if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr4))
				{
					return;
				}
				string text = Marshal.PtrToStringUni(intPtr4, (int)(struct4.uintValue5 / 2u));
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
				num2++;
			}
			ApiSetSchema.dictionary.Add(key, list);
			num++;
		}
	}

	[DllImport("shell32.dll")]
	internal static extern bool DragQueryPoint(IntPtr address, out FileDropMessageFilter.NativePoint nativePoint);

	[DllImport("kernel32.dll")]
	internal static extern ulong VerSetConditionMask(ulong ulongValue, uint uintValue, byte byteValue);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenProcess(NativeTypes.ProcessAccessRights processAccessRights, [MarshalAs(UnmanagedType.Bool)] bool flag, int intValue);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr CreateToolhelp32Snapshot(NativeTypes.SnapshotFlags snapshotFlags, int intValue);

	internal static bool TryInitializePeb64Address(Peb64 peb64)
	{
		if (!PlatformInfo.flag)
		{
			return false;
		}
		IntPtr intPtr = RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.QueryInformation, false, peb64.remoteProcess.ProcessId);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		NativeTypes.ProcessBasicInformation @struct;
		int num;
		if (RecoveredRuntime.NtQueryInformationProcess(intPtr, NativeTypes.ProcessInformationClass.BasicInformation, out @struct, typeof(NativeTypes.ProcessBasicInformation).SizeOf(), out num) != 0u)
		{
			RecoveredRuntime.CloseHandle(intPtr);
			return false;
		}
		RecoveredRuntime.SetRemotePebAddress(peb64, @struct.address2);
		RecoveredRuntime.CloseHandle(intPtr);
		return true;
	}

	[DllImport("user32.dll")]
	internal static extern IntPtr GetClassLongPtr(IntPtr address, int intValue);

	[DllImport("shell32.dll")]
	internal static extern IntPtr SHGetFileInfo(string text, uint uintValue, ref ShellFileInfoNativeTypes.ShellFileInfo shellFileInfo, uint uintValue2, ShellFileInfoNativeTypes.ShellFileInfoFlags shellFileInfoFlags);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetExitCodeThread(IntPtr address, out uint uintValue);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenThread(NativeTypes.ThreadAccessRights threadAccessRights, bool flag, int intValue);

	[DllImport("ntdll.dll", SetLastError = true)]
	internal static extern uint NtQueryInformationThread(IntPtr address, NativeTypes.ThreadInformationClass threadInformationClass, out NativeTypes.ThreadBasicInformation threadBasicInformation, int intValue, out int intValue2);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ChangeWindowMessageFilterEx(IntPtr address, uint uintValue, FileDropMessageFilter.MessageFilterAction messageFilterAction, ref FileDropMessageFilter.MessageFilterChangeInfo messageFilterChangeInfo);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern uint GetWindowsDirectory(StringBuilder stringBuilder, int intValue);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetProcessDEPPolicy(IntPtr address, out uint uintValue, out bool flag);

	[DllImport("kernel32.dll")]
	internal static extern bool Wow64SetThreadContext(IntPtr address, ref NativeTypes.Context32 context32);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool VirtualProtectEx(IntPtr address, IntPtr address2, UIntPtr address3, NativeTypes.MemoryProtection memoryProtection, out NativeTypes.MemoryProtection memoryProtection2);

	[DllImport("kernel32.dll")]
	internal static extern uint GetCurrentProcessId();

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int GetWindowText(IntPtr address, StringBuilder stringBuilder, int intValue);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern int ResumeThread(IntPtr address);

	[DllImport("kernel32.dll")]
	internal static extern bool Thread32Next(IntPtr address, ref NativeTypes.ThreadEntry32 threadEntry32);

	[DllImport("Kernel32.dll", SetLastError = true)]
	internal static extern void ReleaseActCtx(IntPtr address);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int GetWindowTextLength(IntPtr address);

	[DllImport("ntdll.dll", SetLastError = true)]
	internal static extern uint NtQuerySystemInformation(NativeTypes.SystemInformationClass systemInformationClass, IntPtr address, int intValue, out int intValue2);

	internal static void ReadApiSetSchemaV4(IntPtr address)
	{
		foreach (ApiSetSchema.ApiSetNamespaceEntryV4 @struct in ApiSetSchema.ReadEntries<ApiSetSchema.ApiSetNamespaceHeaderV4, ApiSetSchema.ApiSetNamespaceEntryV4>(address))
		{
			List<string> list = new List<string>();
			string key = Marshal.PtrToStringUni(address.Add((long)((ulong)@struct.uintValue2)), (int)(@struct.uintValue3 / 2u)).ToLowerInvariant();
			foreach (ApiSetSchema.ApiSetValueEntryV2 struct2 in ApiSetSchema.ReadEntries<ApiSetSchema.ApiSetValueArrayV4, ApiSetSchema.ApiSetValueEntryV2>(address.Add((long)((ulong)@struct.uintValue6))))
			{
				string text = Marshal.PtrToStringUni(address.Add((long)((ulong)struct2.uintValue4)), (int)(struct2.uintValue5 / 2u));
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
			ApiSetSchema.dictionary.Add(key, list);
		}
	}

	[DllImport("ntdll.dll")]
	internal static extern uint RtlGetVersion(ref NativeTypes.OsVersionInfoEx osVersionInfoEx);

	[DllImport("ntdll.dll")]
	internal static extern uint NtCreateThreadEx(out IntPtr address, uint uintValue, IntPtr address2, IntPtr address3, IntPtr address4, IntPtr address5, uint uintValue2, uint uintValue3, uint uintValue4, uint uintValue5, IntPtr address6);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
	internal static extern long StrFormatByteSize(long longValue, StringBuilder stringBuilder, int intValue);

	[DllImport("psapi.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetModuleInformation(IntPtr address, IntPtr address2, out NativeTypes.ModuleInformation moduleInformation, int intValue);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr VirtualAllocEx(IntPtr address, IntPtr address2, UIntPtr address3, NativeTypes.MemoryAllocationType memoryAllocationType, NativeTypes.MemoryProtection memoryProtection);

	internal static bool SetAlignedThreadContext(ref NativeTypes.Context64 context64, IntPtr address)
	{
		IntPtr intPtr = AllocateAlignedThreadContext(ref context64);
		bool result = SetThreadContext(address, intPtr);
		context64 = (NativeTypes.Context64)Marshal.PtrToStructure(intPtr, typeof(NativeTypes.Context64));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ActivateActCtx(IntPtr address, out IntPtr address2);

	[DllImport("kernel32.dll")]
	internal static extern int GetThreadPriority(IntPtr address);

	internal static bool GetAlignedThreadContext(ref NativeTypes.Context64 context64, IntPtr address)
	{
		IntPtr intPtr = AllocateAlignedThreadContext(ref context64);
		bool threadContext_ = GetThreadContextAligned(address, intPtr);
		context64 = (NativeTypes.Context64)Marshal.PtrToStructure(intPtr, typeof(NativeTypes.Context64));
		Marshal.FreeHGlobal(intPtr);
		return threadContext_;
	}

	[DllImport("ntdll.dll")]
	internal static extern int RtlNtStatusToDosError(uint uintValue);

	[DllImport("kernel32.dll", EntryPoint = "GetThreadContext")]
	internal static extern bool GetThreadContextAligned(IntPtr address, IntPtr address2);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	internal unsafe static extern bool WriteProcessMemoryBuffer(IntPtr address, IntPtr address2, byte* pointer, UIntPtr address3, UIntPtr* pointer2);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr SendMessageTimeout(IntPtr address, uint uintValue, UIntPtr address2, IntPtr address3, NativeTypes.SendMessageTimeoutFlags sendMessageTimeoutFlags, uint uintValue2, out IntPtr address4);

	internal static bool TryInitializePeb32Address(Peb32 peb32)
	{
		if (RecoveredRuntime.IsWow64RemoteProcess(peb32.remoteProcess))
		{
			IntPtr intPtr = RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.QueryInformation, false, peb32.remoteProcess.ProcessId);
			if (intPtr == IntPtr.Zero)
			{
				return false;
			}
			IntPtr intptr_;
			int num;
			if (RecoveredRuntime.NtQueryInformationProcessPointer(intPtr, NativeTypes.ProcessInformationClass.Wow64Information, out intptr_, IntPtr.Size, out num) == 0u)
			{
				RecoveredRuntime.SetRemotePebAddress(peb32, intptr_);
				RecoveredRuntime.CloseHandle(intPtr);
				return true;
			}
			RecoveredRuntime.CloseHandle(intPtr);
			return false;
		}
		else
		{
			if (!RecoveredRuntime.Is32BitProcess(peb32.remoteProcess))
			{
				return false;
			}
			IntPtr intPtr2 = RecoveredRuntime.OpenProcess(NativeTypes.ProcessAccessRights.VirtualMemoryRead | NativeTypes.ProcessAccessRights.QueryInformation, false, peb32.remoteProcess.ProcessId);
			if (intPtr2 == IntPtr.Zero)
			{
				return false;
			}
			NativeTypes.ProcessBasicInformation @struct;
			int num2;
			if (RecoveredRuntime.NtQueryInformationProcess(intPtr2, NativeTypes.ProcessInformationClass.BasicInformation, out @struct, typeof(NativeTypes.ProcessBasicInformation).SizeOf(), out num2) != 0u)
			{
				RecoveredRuntime.CloseHandle(intPtr2);
				return false;
			}
			RecoveredRuntime.SetRemotePebAddress(peb32, @struct.address2);
			RecoveredRuntime.CloseHandle(intPtr2);
			return true;
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	internal unsafe static extern bool ReadProcessMemoryBuffer(IntPtr address, IntPtr address2, byte* pointer, UIntPtr address3, UIntPtr* pointer2);

	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationThread", SetLastError = true)]
	internal static extern uint NtQueryInformationThreadPointer(IntPtr address, NativeTypes.ThreadInformationClass threadInformationClass, out IntPtr address2, int intValue, out int intValue2);

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeactivateActCtx(int intValue, IntPtr address);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr CreateActCtx(ref NativeTypes.ActivationContext activationContext);

	[DllImport("ntdll.dll")]
	internal static extern void RtlInitUnicodeString(out NativeTypes.UnicodeString unicodeString, [MarshalAs(UnmanagedType.LPWStr)] string text);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CloseHandle(IntPtr address);

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool VerifyVersionInfo([In] ref NativeTypes.OsVersionInfoEx osVersionInfoEx, uint uintValue, ulong ulongValue);

	[DllImport("kernel32.dll")]
	internal static extern bool Wow64GetThreadContext(IntPtr address, ref NativeTypes.Context32 context32);

	[DllImport("ntdll.dll")]
	internal static extern uint NtSetInformationThread(IntPtr address, NativeTypes.ThreadInformationClass threadInformationClass, IntPtr address2, int intValue);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool GetTokenInformation(IntPtr address, TokenPrivilegeNativeTypes.TokenInformationClass tokenInformationClass, out uint uintValue, uint uintValue2, out uint uintValue3);

	internal static IntPtr AssembleRemoteCode(IntPtr address, AsmJitAssembler assembler, RemoteCodeExecutorBase remoteCodeExecutorBase)
	{
		IntPtr intPtr = RecoveredRuntime.GetAssemblerCodePointer(assembler);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		if (address == IntPtr.Zero)
		{
			address = RecoveredRuntime.AllocateRemoteMemory(remoteCodeExecutorBase, (long)RecoveredRuntime.GetAssemblerOffset(assembler), NativeTypes.MemoryProtection.ExecuteReadWrite);
			if (address == IntPtr.Zero)
			{
				return IntPtr.Zero;
			}
		}
		int num = RecoveredRuntime.RelocateAssemblerCode(assembler, intPtr, address);
		byte[] array = new byte[num];
		Marshal.Copy(intPtr, array, 0, num);
		RecoveredRuntime.CreateAsmJitMemoryManager().Release(intPtr);
		RecoveredRuntime.DisposeAssemblerState(assembler);
		remoteCodeExecutorBase.WriteArray<byte>(address, array);
		return address;
	}
}
