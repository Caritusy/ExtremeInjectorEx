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

	internal static void smethod_4(FileDropMessageFilter class10_0, IntPtr intptr_0)
	{
		if (PlatformInfo.bool_2)
		{
			goto IL_0066;
		}
		goto IL_0128;
		IL_0066:
		int num = -270770127;
		goto IL_00e3;
		IL_00e3:
		FileDropMessageFilter.Struct6 struct6_ = default(FileDropMessageFilter.Struct6);
		FileDropMessageFilter.Struct6 @struct = default(FileDropMessageFilter.Struct6);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -653105853)) % 9)
			{
			case 7u:
				struct6_ = @struct;
				num = ((int)num2 * -125969318) ^ -687022563;
				continue;
			case 6u:
				ChangeWindowMessageFilterEx(intptr_0, 563u, FileDropMessageFilter.Enum1.const_1, ref struct6_);
				ChangeWindowMessageFilterEx(intptr_0, 74u, FileDropMessageFilter.Enum1.const_1, ref struct6_);
				ChangeWindowMessageFilterEx(intptr_0, 73u, FileDropMessageFilter.Enum1.const_1, ref struct6_);
				num = ((int)num2 * -672728581) ^ -47488733;
				continue;
			case 5u:
				break;
			case 4u:
				@struct.uint_0 = (uint)Marshal.SizeOf(typeof(FileDropMessageFilter.Struct6));
				num = (int)((num2 * 24164508) ^ 0x570FFE91);
				continue;
			case 2u:
				ChangeWindowMessageFilter(563u, FileDropMessageFilter.Enum2.const_0);
				ChangeWindowMessageFilter(74u, FileDropMessageFilter.Enum2.const_0);
				num = ((int)num2 * -981999770) ^ -936126998;
				continue;
			case 1u:
				@struct = default(FileDropMessageFilter.Struct6);
				num = (int)((num2 * 1465128633) ^ 0x40B6BE6D);
				continue;
			case 0u:
				ChangeWindowMessageFilter(73u, FileDropMessageFilter.Enum2.const_0);
				num = ((int)num2 * -51443913) ^ 0x7F4FD9E2;
				continue;
			case 8u:
				goto IL_0128;
			default:
				DragAcceptFiles(intptr_0, bool_0: true);
				return;
			}
			break;
		}
		goto IL_0066;
		IL_0128:
		num = (PlatformInfo.bool_1 ? (-1605748973) : (-1962184115));
		goto IL_00e3;
	}

	internal static Icon smethod_11(string string_0, IconSize enum18_0)
	{
		ShellFileInfoNativeTypes.Struct36 struct36_ = default(ShellFileInfoNativeTypes.Struct36);
		ShellFileInfoNativeTypes.Enum19 enum19_ = (ShellFileInfoNativeTypes.Enum19)(0x110u | ((enum18_0 == IconSize.const_0) ? 1u : 0u));
		SHGetFileInfo(string_0, 128u, ref struct36_, (uint)Marshal.SizeOf((object)struct36_), enum19_);
		Icon result = default(Icon);
		try
		{
			Icon icon = Icon.FromHandle(struct36_.intptr_0);
			try
			{
				result = (Icon)icon.Clone();
			}
			finally
			{
				if (icon != null)
				{
					while (true)
					{
						IL_0087:
						int num = -848840261;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ -1289780321)) % 3)
							{
							case 1u:
								goto IL_0055;
							default:
								goto end_IL_0069;
							case 2u:
								break;
							case 0u:
								goto end_IL_0069;
							}
							goto IL_0087;
							IL_0055:
							((IDisposable)icon).Dispose();
							num = ((int)num2 * -1541313732) ^ -1876435111;
							continue;
							end_IL_0069:
							break;
						}
						break;
					}
				}
			}
		}
		catch (Exception)
		{
			while (true)
			{
				IL_00c0:
				int num3 = -660738296;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num3 ^ -1289780321)) % 3)
					{
					case 1u:
						goto IL_0092;
					default:
						goto end_IL_00a2;
					case 2u:
						break;
					case 0u:
						goto end_IL_00a2;
					}
					goto IL_00c0;
					IL_0092:
					result = null;
					num3 = (int)(num2 * 942994905) ^ -28502286;
					continue;
					end_IL_00a2:
					break;
				}
				break;
			}
		}
		return result;
	}

	internal static IntPtr smethod_13(ref NativeTypes.Struct55 struct55_0)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(typeof(NativeTypes.Struct55).smethod_7() + 16);
		while (true)
		{
			int num = 915114728;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xB7C3BE5)) % 4)
				{
				case 2u:
					Marshal.StructureToPtr((object)struct55_0, intPtr, false);
					num = (int)(num2 * 913671627) ^ -1885447129;
					continue;
				case 1u:
					intPtr = intPtr.smethod_9(-intPtr.ToInt64() & 0xFL);
					num = ((int)num2 * -1282346740) ^ -1872886249;
					continue;
				case 3u:
					break;
				default:
					return intPtr;
				}
				break;
			}
		}
	}

	internal static int smethod_18(Type type_0)
	{
		if ((object)type_0 == typeof(char))
		{
			goto IL_001c;
		}
		goto IL_0050;
		IL_001c:
		int num = 811157221;
		goto IL_0021;
		IL_0021:
		switch ((uint)(num ^ 0x146F070) % 5u)
		{
		case 4u:
			break;
		case 3u:
			goto IL_0050;
		default:
			return Marshal.SizeOf(type_0);
		case 1u:
			return 2;
		case 2u:
			return Marshal.SizeOf(Enum.GetUnderlyingType(type_0));
		}
		goto IL_001c;
		IL_0050:
		num = (typeof(Enum).IsAssignableFrom(type_0) ? 81634190 : 1723409053);
		goto IL_0021;
	}

	[DllImport("ntdll.dll")]
	internal static extern uint RtlDosApplyFileIsolationRedirection_Ustr(uint uint_0, ref NativeTypes.Struct43 struct43_0, ref NativeTypes.Struct43 struct43_1, ref NativeTypes.Struct43 struct43_2, ref NativeTypes.Struct43 struct43_3, ref IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, UIntPtr uintptr_1);

	internal static List<NativeProcessInfo> smethod_21()
	{
		List<NativeProcessInfo> list = new List<NativeProcessInfo>();
		IntPtr intPtr3 = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		int num5 = default(int);
		uint num3 = default(uint);
		IntPtr intPtr = default(IntPtr);
		int num4 = default(int);
		NativeTypes.Struct39 struct39_ = default(NativeTypes.Struct39);
		NativeProcessInfo @class = default(NativeProcessInfo);
		NativeTypes.Struct40 item = default(NativeTypes.Struct40);
		while (true)
		{
			int num = -2128162707;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1762260554)) % 19)
				{
				case 18u:
					intPtr3 = intPtr2.smethod_8(typeof(NativeTypes.Struct39).smethod_7());
					num5 = 0;
					num = (int)(num2 * 171570624) ^ -222443169;
					continue;
				case 17u:
				{
					num = (((num3 = NtQuerySystemInformation(NativeTypes.Enum24.const_5, intPtr, num4, out var _)) != 3221225476u) ? (-1873691861) : (-850434513));
					continue;
				}
				case 16u:
					Marshal.FreeHGlobal(intPtr);
					num4 += 65536;
					intPtr = Marshal.AllocHGlobal(num4);
					num = -271065583;
					continue;
				case 15u:
					num = ((num5 >= struct39_.uint_1) ? (-1557223032) : (-1744986724));
					continue;
				case 14u:
					num = ((num3 == 0) ? 1316447535 : 2140085630) ^ ((int)num2 * -212546510);
					continue;
				case 13u:
					@class.method_2().Add(item);
					intPtr3 = intPtr3.smethod_8(typeof(NativeTypes.Struct40).smethod_7());
					num5++;
					num = (int)(num2 * 522738449) ^ -453839450;
					continue;
				case 11u:
					item = (NativeTypes.Struct40)Marshal.PtrToStructure(intPtr3, typeof(NativeTypes.Struct40));
					num = -330870858;
					continue;
				case 10u:
					num4 = 65536;
					intPtr = Marshal.AllocHGlobal(65536);
					num = ((int)num2 * -739706403) ^ 0xCE87095;
					continue;
				case 9u:
					num = ((int)num2 * -2029230962) ^ -609030535;
					continue;
				case 8u:
					@class.method_1(struct39_);
					list.Add(@class);
					num = ((int)num2 * -1306954970) ^ -1971811687;
					continue;
				case 7u:
					num = (int)((num2 * 2117714006) ^ 0x42A44F60);
					continue;
				case 6u:
					intPtr2 = intPtr2.smethod_9(struct39_.uint_0);
					num = (int)(num2 * 1506578629) ^ -612614115;
					continue;
				case 5u:
					num = ((struct39_.uint_0 != 0) ? 2135236729 : 2051204727) ^ ((int)num2 * -1055630049);
					continue;
				case 4u:
					@class = new NativeProcessInfo();
					struct39_ = (NativeTypes.Struct39)Marshal.PtrToStructure(intPtr2, typeof(NativeTypes.Struct39));
					num = -1254018951;
					continue;
				case 1u:
					intPtr2 = intPtr;
					num = -124316425;
					continue;
				case 0u:
					num = (int)((num2 * 935786555) ^ 0x2258F7B4);
					continue;
				case 12u:
					break;
				default:
					Marshal.FreeHGlobal(intPtr);
					return list;
				case 3u:
					return list;
				}
				break;
			}
		}
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
	internal static extern bool LookupPrivilegeValue(string string_0, string string_1, out TokenPrivilegeNativeTypes.Struct35 struct35_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool VirtualFree(IntPtr intptr_0, UIntPtr uintptr_0, NativeTypes.Enum28 enum28_0);

	internal static bool smethod_70(ProcessThreadInfo class75_0)
	{
		IntPtr intPtr = OpenThread(NativeTypes.Enum31.flag_5, bool_0: false, class75_0.method_0());
		if (intPtr == IntPtr.Zero)
		{
			goto IL_0031;
		}
		goto IL_010d;
		IL_0031:
		int num = -2101173460;
		goto IL_00c3;
		IL_00c3:
		IntPtr intptr_ = default(IntPtr);
		int int_;
		NativeTypes.Struct49 struct49_ = default(NativeTypes.Struct49);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -249622791)) % 10)
			{
			case 6u:
				break;
			case 4u:
				num = ((NtQueryInformationThread_1(intPtr, NativeTypes.Enum25.const_9, out intptr_, IntPtr.Size, out int_) != 0) ? 493597642 : 918120976) ^ (int)(num2 * 1333310952);
				continue;
			case 3u:
				class75_0.method_3(intptr_);
				num = -1103030450;
				continue;
			case 1u:
				class75_0.method_8((ThreadPriorityLevel)GetThreadPriority(intPtr));
				num = ((int)num2 * -1509299532) ^ -349476709;
				continue;
			case 0u:
				class75_0.method_4((int)struct49_.uint_2);
				class75_0.method_5((int)struct49_.uint_1);
				class75_0.method_6(struct49_.intptr_0);
				num = -1548753795;
				continue;
			case 2u:
				goto IL_010d;
			case 5u:
				CloseHandle(intPtr);
				return false;
			case 7u:
				return false;
			default:
				CloseHandle(intPtr);
				return true;
			case 9u:
				CloseHandle(intPtr);
				return false;
			}
			break;
		}
		goto IL_0031;
		IL_010d:
		num = ((NtQueryInformationThread(intPtr, NativeTypes.Enum25.const_0, out struct49_, typeof(NativeTypes.Struct49).smethod_7(), out int_) != 0) ? (-1354389344) : (-1669882073));
		goto IL_00c3;
	}

	[DllImport("kernel32.dll")]
	internal static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, IntPtr intptr_2, IntPtr intptr_3, uint uint_0, IntPtr intptr_4);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EnumWindows(NativeTypes.Delegate46 delegate46_0, IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	internal static extern uint QueryDosDevice(string string_0, [Out] StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool AdjustTokenPrivileges(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, ref TokenPrivilegeNativeTypes.Struct34 struct34_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool TerminateProcess(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll")]
	internal static extern uint GetClassLong(IntPtr intptr_0, int int_0);

	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess", SetLastError = true)]
	internal static extern uint NtQueryInformationProcess_1(IntPtr intptr_0, NativeTypes.Enum26 enum26_0, out IntPtr intptr_1, int int_0, out int int_1);

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

	internal static void smethod_120(IntPtr intptr_0)
	{
		ApiSetSchema.Struct68[] array = ApiSetSchema.smethod_0<ApiSetSchema.Struct69, ApiSetSchema.Struct68>(intptr_0);
		ApiSetSchema.Struct68 struct2 = default(ApiSetSchema.Struct68);
		int num4 = default(int);
		List<string> list = default(List<string>);
		string key = default(string);
		ApiSetSchema.Struct66[] array2 = default(ApiSetSchema.Struct66[]);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			int num = -585717459;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1270855648)) % 14)
				{
				case 13u:
					struct2 = array[num4];
					list = new List<string>();
					key = Marshal.PtrToStringUni(intptr_0.smethod_9(struct2.uint_0), (int)(struct2.uint_1 / 2)).ToLowerInvariant();
					num = -1115535436;
					continue;
				case 12u:
					num4++;
					num = ((int)num2 * -684277217) ^ -1465673307;
					continue;
				case 11u:
					num = (int)((num2 * 222551695) ^ 0x7A21D216);
					continue;
				case 10u:
					array2 = ApiSetSchema.smethod_0<ApiSetSchema.Struct67, ApiSetSchema.Struct66>(intptr_0.smethod_9(struct2.uint_2));
					num3 = 0;
					num = ((int)num2 * -1842341550) ^ -177703831;
					continue;
				case 8u:
					list.Add(text);
					num = (int)((num2 * 1098606816) ^ 0x192C8D23);
					continue;
				case 7u:
					num4 = 0;
					num = ((int)num2 * -947305) ^ -1455671676;
					continue;
				case 6u:
					ApiSetSchema.dictionary_0.Add(key, list);
					num = ((int)num2 * -1148062503) ^ -1068654486;
					continue;
				case 5u:
					num = ((num4 < array.Length) ? (-1695066901) : (-1748821778));
					continue;
				case 3u:
					num3++;
					num = -1027644468;
					continue;
				case 2u:
				{
					ApiSetSchema.Struct66 @struct = array2[num3];
					text = Marshal.PtrToStringUni(intptr_0.smethod_9(@struct.uint_2), (int)(@struct.uint_3 / 2));
					num = (string.IsNullOrEmpty(text) ? (-975932701) : (-605064398));
					continue;
				}
				case 1u:
					num = (int)(num2 * 1753798652) ^ -616709968;
					continue;
				case 0u:
					num = ((num3 < array2.Length) ? (-1215215184) : (-1171686556));
					continue;
				default:
					return;
				case 9u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	[DllImport("psapi.dll", SetLastError = true)]
	internal static extern bool EnumProcessModulesEx(IntPtr intptr_0, IntPtr[] intptr_1, uint uint_0, out uint uint_1, uint uint_2);

	internal static bool smethod_136(ref string string_0, IntPtr intptr_0)
	{
		if (string_0.EndsWith(".dll"))
		{
			goto IL_0128;
		}
		goto IL_023d;
		IL_0128:
		int num = -1687434913;
		goto IL_01ee;
		IL_01ee:
		NativeTypes.Struct43 struct43_ = default(NativeTypes.Struct43);
		NativeTypes.Struct43 struct43_4 = default(NativeTypes.Struct43);
		NativeTypes.Struct43 struct43_3 = default(NativeTypes.Struct43);
		NativeTypes.Struct43 struct43_2 = default(NativeTypes.Struct43);
		IntPtr intptr_2 = default(IntPtr);
		IntPtr intptr_1 = default(IntPtr);
		IntPtr intPtr = default(IntPtr);
		NativeTypes.Struct43 @struct = default(NativeTypes.Struct43);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1561278483)) % 15)
			{
			case 14u:
				string_0 = string_0.Substring(0, string_0.Length - 4);
				num = ((int)num2 * -1191010174) ^ 0x5B8D9174;
				continue;
			case 12u:
			{
				uint num3 = RtlDosApplyFileIsolationRedirection_Ustr(1u, ref struct43_, ref struct43_4, ref struct43_3, ref struct43_2, ref intptr_2, IntPtr.Zero, UIntPtr.Zero, UIntPtr.Zero);
				if (intptr_1 != IntPtr.Zero && intptr_0 != NativeTypes.intptr_0)
				{
					DeactivateActCtx(0, intptr_1);
				}
				if (num3 == 0)
				{
					num = -1071638081;
					continue;
				}
				goto case 2u;
			}
			case 2u:
				RtlFreeUnicodeString(ref struct43_2);
				num = -434694695;
				continue;
			case 11u:
				Marshal.FreeHGlobal(intPtr);
				num = -662153495;
				continue;
			case 10u:
				string_0 = ((NativeTypes.Struct43)Marshal.PtrToStructure(intptr_2, typeof(NativeTypes.Struct43))/*cast due to constrained. prefix*/).ToString();
				num = ((int)num2 * -1053629383) ^ -403682609;
				continue;
			case 9u:
				struct43_3 = @struct;
				intptr_1 = IntPtr.Zero;
				num = ((!(intptr_0 != NativeTypes.intptr_0)) ? (-790145851) : (-867222926)) ^ (int)(num2 * 34226057);
				continue;
			case 8u:
				break;
			case 7u:
				intPtr = Marshal.AllocHGlobal(255);
				num = ((int)num2 * -1730467390) ^ -814694156;
				continue;
			case 6u:
				string_0 += ".dll";
				num = (int)(num2 * 766421706) ^ -257120379;
				continue;
			case 5u:
				intptr_2 = IntPtr.Zero;
				num = -1054105669;
				continue;
			case 4u:
				RtlInitUnicodeString(out struct43_, string_0);
				RtlInitUnicodeString(out struct43_2, "");
				num = (int)((num2 * 1557584949) ^ 0x4AFDE9FA);
				continue;
			case 3u:
				@struct = new NativeTypes.Struct43
				{
					intptr_0 = intPtr,
					ushort_1 = 255
				};
				num = (int)(num2 * 1420723249) ^ -1926440808;
				continue;
			case 0u:
				ActivateActCtx(intptr_0, out intptr_1);
				num = (int)((num2 * 626244533) ^ 0x3369D96);
				continue;
			case 13u:
				goto IL_023d;
			default:
				return false;
			}
			break;
		}
		goto IL_0128;
		IL_023d:
		RtlInitUnicodeString(out struct43_4, ".dll");
		num = -555189863;
		goto IL_01ee;
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
	internal static extern bool SetThreadContext_1(IntPtr intptr_0, ref NativeTypes.Struct54 struct54_0);

	[DllImport("psapi.dll", SetLastError = true)]
	internal static extern bool EnumProcesses(uint[] uint_0, uint uint_1, out uint uint_2);

	[DllImport("shell32.dll")]
	internal static extern void DragAcceptFiles(IntPtr intptr_0, bool bool_0);

	internal static AsmJitRuntime.Delegate0 smethod_207()
	{
		IntPtr intPtr = Marshal.ReadIntPtr(Marshal.ReadIntPtr(((NativeAsmJitMemoryManager)smethod_51()).intptr_0), 4 * IntPtr.Size);
		if (AsmJitRuntime.bool_0)
		{
			goto IL_0118;
		}
		goto IL_020d;
		IL_0118:
		int num = 146084594;
		goto IL_01ba;
		IL_01ba:
		int num3 = default(int);
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		byte[] array = default(byte[]);
		int num5 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		int num4 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x1C5256E8)) % 16)
			{
			case 15u:
				num3 = smethod_419(array2, "è\0\0\0\0H\u008BËè", "x????xxxx", 0);
				num = ((num3 != -1) ? (-94460459) : (-64714969)) ^ (int)(num2 * 1572366844);
				continue;
			case 14u:
				num6 = BitConverter.ToInt32(array, num5 + 3);
				intPtr2 = intPtr.smethod_8(num5 + 2 + num6 + 5);
				array = new byte[100];
				num = 1239470229;
				continue;
			case 13u:
				Marshal.Copy(intPtr2, array, 0, array.Length);
				num = ((int)num2 * -1554020668) ^ -756453442;
				continue;
			case 12u:
				num6 = BitConverter.ToInt32(array, num5 + 1);
				num = 2858573;
				continue;
			case 10u:
				array2 = new byte[100];
				Marshal.Copy(intPtr, array2, 0, array2.Length);
				num = (int)((num2 * 1972141925) ^ 0x5F09AF55);
				continue;
			case 9u:
				num4 = BitConverter.ToInt32(array2, num3 + 1);
				num = 1165531760;
				continue;
			case 7u:
				break;
			case 2u:
				num5 = smethod_419(array, "è\0\0\0\0Vè\0\0\0\0\u0083Ä\b", "x????xx????xxx", 0);
				num = ((num5 != -1) ? 830833092 : 1079343950) ^ (int)(num2 * 1178614576);
				continue;
			case 1u:
				num = ((num5 != -1) ? (-2037255687) : (-600563405)) ^ ((int)num2 * -1288864625);
				continue;
			case 0u:
				num5 = smethod_419(array, "j\0è", "xxx", 0);
				num = (int)((num2 * 1624723693) ^ 0x5F35D519);
				continue;
			case 3u:
				goto IL_020d;
			case 4u:
				return null;
			default:
				return (AsmJitRuntime.Delegate0)Marshal.GetDelegateForFunctionPointer(intPtr2.smethod_8(num5 + num6 + 5), typeof(AsmJitRuntime.Delegate0));
			case 6u:
				return null;
			case 8u:
				return (AsmJitRuntime.Delegate0)Marshal.GetDelegateForFunctionPointer(intPtr.smethod_8(num3 + num4 + 5), typeof(AsmJitRuntime.Delegate0));
			case 11u:
				return null;
			}
			break;
		}
		goto IL_0118;
		IL_020d:
		array = new byte[20];
		Marshal.Copy(intPtr, array, 0, array.Length);
		num = 1286306376;
		goto IL_01ba;
	}

	[DllImport("psapi.dll")]
	internal static extern uint GetProcessImageFileName(IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool QueryFullProcessImageName([In] IntPtr intptr_0, [In] int int_0, [Out] StringBuilder stringBuilder_0, ref int int_1);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ChangeWindowMessageFilter(uint uint_0, FileDropMessageFilter.Enum2 enum2_0);

	internal static void smethod_241(IntPtr intptr_0)
	{
		ApiSetSchema.Struct61 @struct = (ApiSetSchema.Struct61)Marshal.PtrToStructure(intptr_0, typeof(ApiSetSchema.Struct61));
		int num = 0;
		IntPtr intPtr4 = default(IntPtr);
		ApiSetSchema.Struct59 struct3 = default(ApiSetSchema.Struct59);
		string key = default(string);
		ApiSetSchema.Struct62 struct4 = default(ApiSetSchema.Struct62);
		IntPtr intPtr2 = default(IntPtr);
		IntPtr intPtr3 = default(IntPtr);
		int num4 = default(int);
		IntPtr intPtr = default(IntPtr);
		IntPtr ptr = default(IntPtr);
		string text = default(string);
		List<string> list = default(List<string>);
		while (true)
		{
			int num2 = 742087013;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x607A5483)) % 26)
				{
				case 25u:
					intPtr4 = intptr_0.smethod_9(struct3.uint_1);
					num2 = (int)(num3 * 1117864027) ^ -1156146508;
					continue;
				case 24u:
					key = Marshal.PtrToStringUni(intPtr4, (int)(struct3.uint_3 / 2)).ToLowerInvariant();
					num2 = 711647293;
					continue;
				case 23u:
					num2 = ((num < @struct.uint_3) ? 1445084661 : 55077943);
					continue;
				case 22u:
					struct4 = (ApiSetSchema.Struct62)Marshal.PtrToStructure(intPtr2, typeof(ApiSetSchema.Struct62));
					intPtr3 = intptr_0.smethod_9(struct4.uint_3);
					num2 = ((!smethod_184(intPtr3)) ? 1830733229 : 1905089965);
					continue;
				case 20u:
					num2 = (int)(num3 * 338874188) ^ -1875756666;
					continue;
				case 19u:
					intPtr2 = intptr_0.smethod_9(struct3.uint_4 + num4 * typeof(ApiSetSchema.Struct62).smethod_7());
					num2 = ((!smethod_184(intPtr2)) ? 1322593216 : 39878801);
					continue;
				case 18u:
					num2 = ((num4 >= struct3.uint_5) ? 1768704576 : 1809963994);
					continue;
				case 17u:
					num4++;
					num2 = 1586730079;
					continue;
				case 16u:
					intPtr = intptr_0.smethod_9(@struct.uint_5 + num * typeof(ApiSetSchema.Struct60).smethod_7());
					num2 = 1386755637;
					continue;
				case 15u:
				{
					ApiSetSchema.Struct60 struct2 = (ApiSetSchema.Struct60)Marshal.PtrToStructure(intPtr, typeof(ApiSetSchema.Struct60));
					ptr = intptr_0.smethod_9(@struct.uint_4 + typeof(ApiSetSchema.Struct59).smethod_7() * struct2.uint_1);
					num2 = 1464036764;
					continue;
				}
				case 14u:
					text = Marshal.PtrToStringUni(intPtr3, (int)(struct4.uint_4 / 2));
					num2 = ((!string.IsNullOrEmpty(text)) ? 1746809500 : 1725408206);
					continue;
				case 11u:
					struct3 = (ApiSetSchema.Struct59)Marshal.PtrToStructure(ptr, typeof(ApiSetSchema.Struct59));
					num2 = 158216088;
					continue;
				case 9u:
					list.Add(text);
					num2 = (int)((num3 * 1779497568) ^ 0xF87326E);
					continue;
				case 8u:
					list = new List<string>();
					num4 = 0;
					num2 = (int)((num3 * 2087154473) ^ 0x67A122F0);
					continue;
				case 7u:
					ApiSetSchema.dictionary_0.Add(key, list);
					num++;
					num2 = (int)((num3 * 2092717873) ^ 0x30AF0B9D);
					continue;
				case 5u:
					num2 = ((int)num3 * -830115844) ^ 0x54C353D3;
					continue;
				case 4u:
					num2 = (smethod_184(intPtr4) ? (-1000462149) : (-525760491)) ^ (int)(num3 * 1223629963);
					continue;
				case 3u:
					num2 = ((!smethod_184(intPtr)) ? (-1108701115) : (-1930584702)) ^ (int)(num3 * 1502133720);
					continue;
				case 2u:
					num2 = ((!smethod_184(intPtr)) ? (-634396564) : (-1625234068)) ^ ((int)num3 * -1453482708);
					continue;
				default:
					return;
				case 21u:
					break;
				case 0u:
					return;
				case 1u:
					return;
				case 6u:
					return;
				case 10u:
					return;
				case 12u:
					return;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	[DllImport("shell32.dll")]
	internal static extern bool DragQueryPoint(IntPtr intptr_0, out FileDropMessageFilter.Struct5 struct5_0);

	[DllImport("kernel32.dll")]
	internal static extern ulong VerSetConditionMask(ulong ulong_0, uint uint_0, byte byte_0);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenProcess(NativeTypes.Enum32 enum32_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr CreateToolhelp32Snapshot(NativeTypes.Enum27 enum27_0, int int_0);

	internal static bool smethod_281(Peb64 class118_0)
	{
		if (PlatformInfo.bool_0)
		{
			IntPtr intPtr = default(IntPtr);
			NativeTypes.Struct45 struct45_ = default(NativeTypes.Struct45);
			while (true)
			{
				int num = 1467455355;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x233E6FD9)) % 11)
					{
					case 10u:
						num = ((intPtr == IntPtr.Zero) ? (-1018909171) : (-1351058720)) ^ (int)(num2 * 646622078);
						continue;
					case 9u:
						intPtr = OpenProcess(NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_9, bool_0: false, class118_0.gclass2_0.ProcessId);
						num = (int)(num2 * 1204011911) ^ -163764910;
						continue;
					case 7u:
						CloseHandle(intPtr);
						num = ((int)num2 * -2132803047) ^ -961408650;
						continue;
					case 6u:
						break;
					case 1u:
						CloseHandle(intPtr);
						num = ((int)num2 * -1354762312) ^ 0x4BA09160;
						continue;
					case 0u:
						smethod_86(class118_0, struct45_.intptr_1);
						num = 970785537;
						continue;
					case 4u:
						goto end_IL_00d8;
					case 2u:
						return true;
					case 3u:
						return false;
					case 8u:
						return false;
					default:
						goto end_IL_0116;
					}
					num = ((NtQueryInformationProcess(intPtr, NativeTypes.Enum26.const_4, out struct45_, typeof(NativeTypes.Struct45).smethod_7(), out var _) == 0) ? 1453037481 : 1830189235);
					continue;
					end_IL_00d8:
					break;
				}
				continue;
				end_IL_0116:
				break;
			}
		}
		return false;
	}

	[DllImport("user32.dll")]
	internal static extern IntPtr GetClassLongPtr(IntPtr intptr_0, int int_0);

	[DllImport("shell32.dll")]
	internal static extern IntPtr SHGetFileInfo(string string_0, uint uint_0, ref ShellFileInfoNativeTypes.Struct36 struct36_0, uint uint_1, ShellFileInfoNativeTypes.Enum19 enum19_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetExitCodeThread(IntPtr intptr_0, out uint uint_0);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenThread(NativeTypes.Enum31 enum31_0, bool bool_0, int int_0);

	[DllImport("ntdll.dll", SetLastError = true)]
	internal static extern uint NtQueryInformationThread(IntPtr intptr_0, NativeTypes.Enum25 enum25_0, out NativeTypes.Struct49 struct49_0, int int_0, out int int_1);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ChangeWindowMessageFilterEx(IntPtr intptr_0, uint uint_0, FileDropMessageFilter.Enum1 enum1_0, ref FileDropMessageFilter.Struct6 struct6_0);

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

	internal static void smethod_346(IntPtr intptr_0)
	{
		ApiSetSchema.Struct64[] array = ApiSetSchema.smethod_0<ApiSetSchema.Struct65, ApiSetSchema.Struct64>(intptr_0);
		int num4 = default(int);
		string key = default(string);
		List<string> list = default(List<string>);
		string text = default(string);
		int num3 = default(int);
		ApiSetSchema.Struct62[] array2 = default(ApiSetSchema.Struct62[]);
		ApiSetSchema.Struct62 struct2 = default(ApiSetSchema.Struct62);
		ApiSetSchema.Struct64 @struct = default(ApiSetSchema.Struct64);
		while (true)
		{
			int num = -228169995;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -269218673)) % 17)
				{
				case 16u:
					num4++;
					num = (int)(num2 * 1695917076) ^ -969580007;
					continue;
				case 15u:
					ApiSetSchema.dictionary_0.Add(key, list);
					num = (int)(num2 * 1116886859) ^ -2145043140;
					continue;
				case 14u:
					num = (string.IsNullOrEmpty(text) ? (-2139125076) : (-946683873)) ^ ((int)num2 * -700612590);
					continue;
				case 13u:
					list.Add(text);
					num = (int)(num2 * 509548331) ^ -890690412;
					continue;
				case 12u:
					num4 = 0;
					num = ((int)num2 * -1033921483) ^ -728719377;
					continue;
				case 11u:
					num = ((num3 >= array2.Length) ? (-1613212191) : (-1701311274));
					continue;
				case 10u:
					num = ((num4 < array.Length) ? (-490908214) : (-191437907));
					continue;
				case 9u:
					text = Marshal.PtrToStringUni(intptr_0.smethod_9(struct2.uint_3), (int)(struct2.uint_4 / 2));
					num = (int)((num2 * 221661978) ^ 0x6B0FF991);
					continue;
				case 8u:
					struct2 = array2[num3];
					num = -1564266221;
					continue;
				case 6u:
					@struct = array[num4];
					num = -189715202;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -1747981098) ^ 0x18C701CC;
					continue;
				case 3u:
					list = new List<string>();
					num = (int)((num2 * 1613305807) ^ 0x4400BF51);
					continue;
				case 2u:
					num = ((int)num2 * -6844630) ^ 0x23E17EEE;
					continue;
				case 1u:
					num3++;
					num = -1465335944;
					continue;
				case 0u:
					key = Marshal.PtrToStringUni(intptr_0.smethod_9(@struct.uint_1), (int)(@struct.uint_2 / 2)).ToLowerInvariant();
					array2 = ApiSetSchema.smethod_0<ApiSetSchema.Struct63, ApiSetSchema.Struct62>(intptr_0.smethod_9(@struct.uint_5));
					num = (int)((num2 * 493902270) ^ 0xF2106DB);
					continue;
				default:
					return;
				case 4u:
					break;
				case 7u:
					return;
				}
				break;
			}
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

	internal static bool smethod_373(ref NativeTypes.Struct55 struct55_0, IntPtr intptr_0)
	{
		IntPtr intPtr = smethod_13(ref struct55_0);
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

	internal static bool smethod_393(ref NativeTypes.Struct55 struct55_0, IntPtr intptr_0)
	{
		IntPtr intPtr = smethod_13(ref struct55_0);
		bool threadContext_ = GetThreadContext_1(intptr_0, intPtr);
		struct55_0 = (NativeTypes.Struct55)Marshal.PtrToStructure(intPtr, typeof(NativeTypes.Struct55));
		Marshal.FreeHGlobal(intPtr);
		return threadContext_;
	}

	[DllImport("ntdll.dll")]
	internal static extern int RtlNtStatusToDosError(uint uint_0);

	[DllImport("kernel32.dll", EntryPoint = "GetThreadContext")]
	internal static extern bool GetThreadContext_1(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	internal unsafe static extern bool WriteProcessMemory_1(IntPtr intptr_0, IntPtr intptr_1, byte* pByte_0, UIntPtr uintptr_0, UIntPtr* pUintPtr_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr SendMessageTimeout(IntPtr intptr_0, uint uint_0, UIntPtr uintptr_0, IntPtr intptr_1, NativeTypes.Enum20 enum20_0, uint uint_1, out IntPtr intptr_2);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
	internal static extern IntPtr GetCurrentProcess_1();

	internal static bool smethod_409(Peb32 class119_0)
	{
		if (smethod_379(class119_0.gclass2_0))
		{
			goto IL_0054;
		}
		goto IL_020b;
		IL_0054:
		int num = -534106453;
		goto IL_019d;
		IL_019d:
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		NativeTypes.Struct45 struct45_ = default(NativeTypes.Struct45);
		IntPtr intptr_ = default(IntPtr);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1450601091)) % 19)
			{
			case 18u:
				num = ((intPtr == IntPtr.Zero) ? 2135096789 : 895207490) ^ (int)(num2 * 198239614);
				continue;
			case 16u:
				break;
			case 14u:
				CloseHandle(intPtr2);
				num = (int)(num2 * 1273488161) ^ -877692768;
				continue;
			case 13u:
				goto IL_0078;
			case 12u:
				intPtr2 = OpenProcess(NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_9, bool_0: false, class119_0.gclass2_0.ProcessId);
				num = ((!(intPtr2 == IntPtr.Zero)) ? (-1507649381) : (-990940690)) ^ (int)(num2 * 257908533);
				continue;
			case 11u:
				CloseHandle(intPtr);
				num = (int)(num2 * 332830065) ^ -162665467;
				continue;
			case 8u:
				CloseHandle(intPtr2);
				num = ((int)num2 * -22350589) ^ -325300029;
				continue;
			case 7u:
				smethod_86(class119_0, struct45_.intptr_1);
				num = -962768521;
				continue;
			case 5u:
				goto IL_0135;
			case 4u:
				smethod_86(class119_0, intptr_);
				num = -705260852;
				continue;
			case 3u:
				intPtr = OpenProcess(NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_9, bool_0: false, class119_0.gclass2_0.ProcessId);
				num = (int)(num2 * 1294523756) ^ -1554815762;
				continue;
			case 17u:
				goto IL_020b;
			default:
				return false;
			case 1u:
				return false;
			case 2u:
				return false;
			case 6u:
				return false;
			case 9u:
				return false;
			case 10u:
				CloseHandle(intPtr);
				return true;
			case 15u:
				return true;
			}
			break;
			IL_0135:
			num = ((NtQueryInformationProcess(intPtr, NativeTypes.Enum26.const_4, out struct45_, typeof(NativeTypes.Struct45).smethod_7(), out var _) == 0) ? (-1766581978) : (-431562695));
			continue;
			IL_0078:
			num = ((NtQueryInformationProcess_1(intPtr2, NativeTypes.Enum26.const_24, out intptr_, IntPtr.Size, out var _) != 0) ? (-1623485353) : (-141542084));
		}
		goto IL_0054;
		IL_020b:
		num = ((!smethod_427(class119_0.gclass2_0)) ? (-1356599508) : (-846150103));
		goto IL_019d;
	}

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	internal unsafe static extern bool ReadProcessMemory_1(IntPtr intptr_0, IntPtr intptr_1, byte* pByte_0, UIntPtr uintptr_0, UIntPtr* pUintPtr_0);

	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationThread", SetLastError = true)]
	internal static extern uint NtQueryInformationThread_1(IntPtr intptr_0, NativeTypes.Enum25 enum25_0, out IntPtr intptr_1, int int_0, out int int_1);

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
	internal static extern bool GetTokenInformation(IntPtr intptr_0, TokenPrivilegeNativeTypes.Enum16 enum16_0, out uint uint_0, uint uint_1, out uint uint_2);

	internal static IntPtr smethod_443(IntPtr intptr_0, AsmJitAssembler class53_0, RemoteCodeExecutorBase class84_0)
	{
		IntPtr intPtr = smethod_397(class53_0);
		if (intPtr == IntPtr.Zero)
		{
			goto IL_0029;
		}
		goto IL_00ed;
		IL_0029:
		int num = 1310917854;
		goto IL_00ad;
		IL_00ad:
		byte[] array = default(byte[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2B412A0C)) % 8)
			{
			case 7u:
				break;
			case 4u:
				smethod_51().method_03FF(intPtr);
				smethod_115(class53_0);
				num = ((int)num2 * -584882684) ^ -361535214;
				continue;
			case 3u:
			{
				int num3 = smethod_441(class53_0, intPtr, intptr_0);
				array = new byte[num3];
				Marshal.Copy(intPtr, array, 0, num3);
				num = 573603616;
				continue;
			}
			case 1u:
				intptr_0 = smethod_175(class84_0, smethod_252(class53_0), NativeTypes.Enum34.flag_2);
				num = ((intptr_0 == IntPtr.Zero) ? 1060938478 : 1673520685) ^ (int)(num2 * 921516514);
				continue;
			case 5u:
				goto IL_00ed;
			case 0u:
				return IntPtr.Zero;
			case 2u:
				return IntPtr.Zero;
			default:
				class84_0.method_16(intptr_0, array);
				return intptr_0;
			}
			break;
		}
		goto IL_0029;
		IL_00ed:
		num = ((!(intptr_0 == IntPtr.Zero)) ? 398598959 : 1881601181);
		goto IL_00ad;
	}

	internal static int smethod_458(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	internal static int smethod_479(object object_0)
	{
		return Marshal.SizeOf(object_0);
	}

	internal static IntPtr smethod_482(int int_0)
	{
		return Marshal.AllocHGlobal(int_0);
	}

	internal static void smethod_488(IntPtr intptr_0)
	{
		Marshal.FreeHGlobal(intptr_0);
	}

	internal static object smethod_489(IntPtr intptr_0, Type type_0)
	{
		return Marshal.PtrToStructure(intptr_0, type_0);
	}

	internal static string smethod_580(IntPtr intptr_0, int int_0)
	{
		return Marshal.PtrToStringUni(intptr_0, int_0);
	}

	internal static IntPtr smethod_618(IntPtr intptr_0)
	{
		return Marshal.ReadIntPtr(intptr_0);
	}

	internal static IntPtr smethod_619(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadIntPtr(intptr_0, int_0);
	}

	internal static void smethod_620(IntPtr intptr_0, byte[] byte_0, int int_0, int int_1)
	{
		Marshal.Copy(intptr_0, byte_0, int_0, int_1);
	}

	internal static Delegate smethod_621(IntPtr intptr_0, Type type_0)
	{
		return Marshal.GetDelegateForFunctionPointer(intptr_0, type_0);
	}
}
