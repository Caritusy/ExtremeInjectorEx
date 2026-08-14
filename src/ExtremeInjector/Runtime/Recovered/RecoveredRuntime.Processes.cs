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
		if (PlatformInfo.bool_0)
		{
			IntPtr intPtr = default(IntPtr);
			bool bool_ = default(bool);
			while (true)
			{
				int num = -1666634709;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1574627672)) % 12)
					{
					case 10u:
						num = ((intPtr == IntPtr.Zero) ? (-1356036650) : (-1425031679)) ^ ((int)num2 * -653878624);
						continue;
					case 9u:
						gclass2_0.Is64Bit = !bool_;
						num = -340052088;
						continue;
					case 8u:
						smethod_27(gclass2_0, intPtr);
						num = (int)((num2 * 226701568) ^ 0x68B98F0B);
						continue;
					case 7u:
						num = (PlatformInfo.bool_3 ? 139569797 : 1190481027) ^ ((int)num2 * -1282458244);
						continue;
					case 5u:
						break;
					case 1u:
						intPtr = smethod_250(gclass2_0, PlatformInfo.bool_1 ? NativeTypes.Enum32.flag_10 : NativeTypes.Enum32.flag_9, bool_0: false, gclass2_0.ProcessId);
						num = -1143235234;
						continue;
					case 0u:
						smethod_27(gclass2_0, intPtr);
						num = ((int)num2 * -1301083901) ^ 0x762A19A;
						continue;
					case 4u:
						goto end_IL_00f6;
					case 2u:
						return false;
					case 3u:
						return true;
					case 6u:
						return false;
					default:
						goto end_IL_0138;
					}
					num = (IsWow64Process(intPtr, out bool_) ? (-281541091) : (-1104958980));
					continue;
					end_IL_00f6:
					break;
				}
				continue;
				end_IL_0138:
				break;
			}
		}
		return true;
	}

	internal static void smethod_25(ProcessSelectorForm form5_0)
	{
		form5_0.dataGridView_0.Rows.Clear();
		RemoteProcess[] array = smethod_155();
		int num = 0;
		bool flag = default(bool);
		RemoteProcess gClass = default(RemoteProcess);
		Icon icon = default(Icon);
		while (true)
		{
			int num2 = ((num < array.Length) ? (-1115168763) : (-1756142350));
			while (true)
			{
				uint num3;
				Bitmap bitmap;
				Bitmap bitmap2;
				int index;
				switch ((num3 = (uint)(num2 ^ -1595487646)) % 9)
				{
				case 8u:
					form5_0.button_2.Enabled = flag;
					num2 = (int)(num3 * 563866476) ^ -737744115;
					continue;
				case 7u:
					gClass = array[num];
					icon = smethod_11(gClass.FilePath, IconSize.const_1);
					if (icon != null)
					{
						num2 = -729349090;
						continue;
					}
					bitmap = new Bitmap(22, 22);
					goto IL_0075;
				case 6u:
					bitmap = smethod_100(icon);
					goto IL_0075;
				case 4u:
					num2 = -1115168763;
					continue;
				case 2u:
					flag = form5_0.dataGridView_0.Rows.Count > 0;
					num2 = ((int)num3 * -1617798344) ^ 0x5D5CFF6C;
					continue;
				case 1u:
					form5_0.dataGridView_0.Rows[0].Selected = flag;
					num2 = (int)(num3 * 887968065) ^ -1457326172;
					continue;
				case 0u:
					num++;
					num2 = (int)(num3 * 1235007747) ^ -1014861754;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
					return;
					IL_0075:
					bitmap2 = bitmap;
					index = form5_0.dataGridView_0.Rows.Add(bitmap2, string.Format("{0:X8}-{1}", gClass.ProcessId, gClass.Name));
					form5_0.dataGridView_0.Rows[index].Tag = gClass;
					num2 = -435977795;
					continue;
				}
				break;
			}
		}
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
		if (bool_0)
		{
			goto IL_0051;
		}
		goto IL_0227;
		IL_0051:
		int num = 1069849805;
		goto IL_01c5;
		IL_01c5:
		IntPtr[] array = default(IntPtr[]);
		uint uint_ = default(uint);
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4B446BDF)) % 20)
			{
			case 19u:
				break;
			case 17u:
				array = new IntPtr[(int)(uint_ / IntPtr.Size)];
				num = 980320595;
				continue;
			case 16u:
				goto end_IL_01c5;
			case 15u:
				goto IL_005b;
			case 14u:
				num = (PlatformInfo.bool_0 ? (-524732546) : (-1696607906)) ^ (int)(num2 * 501578739);
				continue;
			case 12u:
				EnumProcessModules(intPtr, array, uint_, out uint_);
				num = ((int)num2 * -1901861338) ^ -445982927;
				continue;
			case 9u:
				num = (PlatformInfo.bool_1 ? (-578650930) : (-780818862)) ^ ((int)num2 * -705867474);
				continue;
			case 8u:
				num = (int)((num2 * 551291766) ^ 0x77D41DD9);
				continue;
			case 6u:
				num = ((intPtr == IntPtr.Zero) ? 345606480 : 2083207736) ^ (int)(num2 * 1138004351);
				continue;
			case 4u:
				EnumProcessModulesEx(intPtr, array, uint_, out uint_, (!bool_0) ? 1u : 2u);
				num = 621457091;
				continue;
			case 3u:
				num = (PlatformInfo.bool_0 ? (-1662259923) : (-1046425109)) ^ ((int)num2 * -990717186);
				continue;
			case 2u:
				array = new IntPtr[(int)(uint_ / IntPtr.Size)];
				num = 2132131295;
				continue;
			case 1u:
				array = new IntPtr[0];
				num = 1295692530;
				continue;
			case 0u:
				num = (PlatformInfo.bool_1 ? 1209495353 : 1804199944) ^ ((int)num2 * -34911618);
				continue;
			case 10u:
				goto IL_0227;
			case 5u:
				return array;
			case 7u:
				return new IntPtr[0];
			case 11u:
				return array;
			case 13u:
				return new IntPtr[0];
			default:
				smethod_27(gclass2_0, intPtr);
				return array;
			}
			num = (EnumProcessModulesEx(intPtr, array, 0u, out uint_, (!bool_0) ? 1u : 2u) ? 1576634546 : 53785870);
			continue;
			IL_005b:
			num = (EnumProcessModules(intPtr, array, 0u, out uint_) ? 691320577 : 1260139292);
			continue;
			end_IL_01c5:
			break;
		}
		goto IL_0051;
		IL_0227:
		intPtr = smethod_250(gclass2_0, NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_9, bool_0: false, gclass2_0.ProcessId);
		num = 817091961;
		goto IL_01c5;
	}

	internal static ProcessModuleCollection smethod_42(RemoteProcess gclass2_0)
	{
		ProcessModuleCollection @class = new ProcessModuleCollection(gclass2_0);
		int num3 = default(int);
		ProcessModuleInfo gClass = default(ProcessModuleInfo);
		IntPtr[] array = default(IntPtr[]);
		ProcessModuleInfo gClass2 = default(ProcessModuleInfo);
		IntPtr intptr_ = default(IntPtr);
		while (true)
		{
			int num = 1445066163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x11D96717)) % 18)
				{
				case 17u:
					num3++;
					num = 847578817;
					continue;
				case 16u:
					num3 = 0;
					num = (int)((num2 * 1456103393) ^ 0x7F34B10B);
					continue;
				case 15u:
					@class.AddRange(gclass2_0.list_1.Where(module => module.method_10()));
					num = 1014844718;
					continue;
				case 13u:
					@class.Add(gClass);
					num = (int)((num2 * 2048640384) ^ 0x7F1E4EC8);
					continue;
				case 12u:
					num = ((num3 < array.Length) ? 1953961120 : 504325155);
					continue;
				case 11u:
					array = smethod_30(gclass2_0, bool_0: false);
					num = ((int)num2 * -106916349) ^ 0x61236E7C;
					continue;
				case 10u:
					num = ((num3 >= array.Length) ? 684717404 : 2114337985);
					continue;
				case 9u:
				{
					IntPtr intptr_2 = array[num3];
					gClass = new ProcessModuleInfo(gclass2_0, @class, intptr_2, bool_2: false);
					num = (smethod_246(gClass) ? 554302014 : 1905028936);
					continue;
				}
				case 8u:
					num = (gclass2_0.bool_2 ? 127108562 : 1199907640) ^ (int)(num2 * 1408796839);
					continue;
				case 7u:
					@class.Add(gClass2);
					num = (int)((num2 * 172035582) ^ 0x2208E624);
					continue;
				case 6u:
					gClass2 = new ProcessModuleInfo(gclass2_0, @class, intptr_, bool_2: true);
					num = (int)((num2 * 141323035) ^ 0x4C156DF3);
					continue;
				case 5u:
					array = smethod_30(gclass2_0, bool_0: true);
					num3 = 0;
					num = 847578817;
					continue;
				case 4u:
					num = (smethod_246(gClass2) ? 493758102 : 1343730546) ^ ((int)num2 * -98838020);
					continue;
				case 2u:
					@class.AddRange(gclass2_0.list_1.Where(module => smethod_109(module)));
					num = 1914154479;
					continue;
				case 1u:
					num3++;
					num = 499609561;
					continue;
				case 0u:
					intptr_ = array[num3];
					num = 579936525;
					continue;
				case 3u:
					break;
				default:
					return @class;
				}
				break;
			}
		}
	}

	internal static RemoteProcess SelectProcess()
	{
		ProcessSelectorForm form = new ProcessSelectorForm();
		while (true)
		{
			int num = -1184526344;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -1091078455)) % 4)
				{
				case 1u:
					num3 = ((form.ShowDialog() != DialogResult.OK) ? 19718946 : 831995776);
					goto IL_0027;
				case 3u:
					break;
				case 0u:
					return null;
				default:
					return form.method_0();
				}
				break;
				IL_0027:
				num = num3 ^ ((int)num2 * -39096669);
			}
		}
	}

	internal static RemoteProcess smethod_47(int int_0)
	{
		RemoteProcess gClass = new RemoteProcess((uint)int_0);
		while (true)
		{
			int num = -1650746781;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -874376814)) % 4)
				{
				case 1u:
					num3 = ((!smethod_102(gClass)) ? (-1306103517) : (-79975456));
					goto IL_0027;
				case 2u:
					break;
				case 0u:
					return null;
				default:
					return gClass;
				}
				break;
				IL_0027:
				num = num3 ^ (int)(num2 * 341441009);
			}
		}
	}

	internal static IEnumerable<int> smethod_66(RemoteProcess gclass2_0)
	{
		IntPtr intPtr = CreateToolhelp32Snapshot(NativeTypes.Enum27.flag_2, gclass2_0.ProcessId);
		NativeTypes.Struct44 struct44_ = default(NativeTypes.Struct44);
		NativeTypes.Struct44 @struct = default(NativeTypes.Struct44);
		List<int> list = default(List<int>);
		while (true)
		{
			int num = 1307487682;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x208B2906)) % 12)
				{
				case 11u:
					num = (Thread32Next(intPtr, ref struct44_) ? 2070883810 : 1164233383);
					continue;
				case 9u:
					struct44_ = @struct;
					num = ((int)num2 * -1408375011) ^ -762988503;
					continue;
				case 8u:
					num = ((struct44_.uint_3 != (uint)gclass2_0.ProcessId) ? 168089781 : 439633439);
					continue;
				case 6u:
					num = ((!Thread32First(intPtr, ref struct44_)) ? 2057302549 : 2073148229) ^ (int)(num2 * 1867242070);
					continue;
				case 4u:
					num = ((!(intPtr == IntPtr.Zero)) ? 1813319728 : 1662597444) ^ ((int)num2 * -532927045);
					continue;
				case 3u:
					list = new List<int>();
					num = 2070883810;
					continue;
				case 2u:
					@struct = new NativeTypes.Struct44
					{
						uint_0 = (uint)typeof(NativeTypes.Struct44).smethod_7()
					};
					num = 1610360023;
					continue;
				case 1u:
					list.Add((int)struct44_.uint_2);
					num = ((int)num2 * -1517580532) ^ 0x159FF499;
					continue;
				case 0u:
					break;
				default:
					smethod_27(gclass2_0, intPtr);
					return list.ToArray();
				case 7u:
					smethod_27(gclass2_0, intPtr);
					return new int[0];
				case 10u:
					return new int[0];
				}
				break;
			}
		}
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
		IntPtr intPtr = OpenThread(NativeTypes.Enum31.flag_0, bool_0: false, class75_0.method_0());
		bool result = default(bool);
		while (true)
		{
			int num = 1565626896;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1821A878)) % 5)
				{
				case 3u:
					num = ((intPtr == IntPtr.Zero) ? (-859009436) : (-1202907501)) ^ ((int)num2 * -309030725);
					continue;
				case 2u:
					result = TerminateThread(intPtr, 0);
					CloseHandle(intPtr);
					num = 896413084;
					continue;
				case 4u:
					break;
				default:
					return result;
				case 1u:
					return false;
				}
				break;
			}
		}
	}

	internal static bool smethod_87(RemoteProcess gclass2_0)
	{
		if (PlatformInfo.bool_1)
		{
			goto IL_00ad;
		}
		goto IL_01ea;
		IL_00ad:
		int num = 1849043284;
		goto IL_018f;
		IL_018f:
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		StringBuilder stringBuilder2 = default(StringBuilder);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5A7375FD)) % 18)
			{
			case 17u:
				smethod_27(gclass2_0, intPtr);
				num = ((int)num2 * -1822048471) ^ -1875017693;
				continue;
			case 16u:
				smethod_27(gclass2_0, intPtr);
				num = (int)((num2 * 2146624685) ^ 0x1DE4FD81);
				continue;
			case 15u:
				smethod_27(gclass2_0, intPtr2);
				num = ((int)num2 * -966737247) ^ -1586166768;
				continue;
			case 13u:
			{
				int int_ = stringBuilder.Capacity;
				num = (QueryFullProcessImageName(intPtr2, 0, stringBuilder, ref int_) ? (-494058667) : (-52817372)) ^ (int)(num2 * 1218064214);
				continue;
			}
			case 11u:
				stringBuilder = new StringBuilder(255);
				num = 2049625726;
				continue;
			case 9u:
				break;
			case 8u:
				goto IL_00b7;
			case 7u:
				goto IL_00ea;
			case 1u:
				intPtr2 = smethod_250(gclass2_0, NativeTypes.Enum32.flag_10, bool_0: false, gclass2_0.ProcessId);
				num = ((intPtr2 == IntPtr.Zero) ? 564309919 : 8767601) ^ ((int)num2 * -2057680169);
				continue;
			case 0u:
				num = ((!(intPtr == IntPtr.Zero)) ? 883077294 : 1908357069) ^ (int)(num2 * 2146263940);
				continue;
			case 2u:
				goto IL_01ea;
			case 3u:
				return false;
			case 4u:
				gclass2_0.FilePath = stringBuilder.ToString();
				gclass2_0.Name = Path.GetFileName(gclass2_0.FilePath);
				smethod_27(gclass2_0, intPtr2);
				return true;
			case 5u:
				return false;
			case 6u:
				return false;
			case 10u:
				return false;
			case 12u:
				return false;
			default:
				gclass2_0.FilePath = text;
				gclass2_0.Name = Path.GetFileName(gclass2_0.FilePath);
				smethod_27(gclass2_0, intPtr);
				return true;
			}
			break;
			IL_00ea:
			stringBuilder2 = new StringBuilder(255);
			num = ((GetProcessImageFileName(intPtr, stringBuilder2, (uint)stringBuilder2.Capacity) != 0) ? 19586961 : 2146451832);
			continue;
			IL_00b7:
			text = PlatformInfo.smethod_0(stringBuilder2.ToString());
			num = (string.IsNullOrEmpty(text) ? 504097765 : 1139174099);
		}
		goto IL_00ad;
		IL_01ea:
		intPtr = smethod_250(gclass2_0, NativeTypes.Enum32.flag_9, bool_0: false, gclass2_0.ProcessId);
		num = 704195301;
		goto IL_018f;
	}

	internal static void smethod_88(ProcessInspectorForm form4_0)
	{
		NativeThreadInfo @class = ((ProcessThreadInfo)form4_0.dataGridView_1.SelectedRows[0].Tag).method_9();
		if (@class.struct40_0.uint_3 == 5)
		{
			goto IL_0058;
		}
		goto IL_00b5;
		IL_0058:
		int num = -1147301404;
		goto IL_008c;
		IL_008c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -938941599)) % 6)
			{
			case 4u:
				form4_0.button_3.Text = UiText.Get("ProcessInfo.Resume");
				num = ((int)num2 * -667996033) ^ 0x3EDCEFF9;
				continue;
			case 3u:
				break;
			case 1u:
				num = ((@class.struct40_0.enum23_0 != NativeTypes.Enum23.const_5) ? 1812338164 : 1483751917) ^ ((int)num2 * -577221706);
				continue;
			default:
				return;
			case 5u:
				goto IL_00b5;
			case 0u:
				return;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0058;
		IL_00b5:
		form4_0.button_3.Text = UiText.Get("ProcessInfo.Suspend");
		num = -109253225;
		goto IL_008c;
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
		if (!smethod_87(gclass2_0))
		{
			goto IL_0038;
		}
		goto IL_0074;
		IL_0038:
		int num = -757083136;
		goto IL_003d;
		IL_003d:
		while (true)
		{
			switch ((uint)(num ^ -631056001) % 7u)
			{
			case 2u:
				break;
			case 0u:
				goto end_IL_003d;
			case 6u:
				goto IL_0074;
			default:
				return true;
			case 3u:
				return false;
			case 4u:
				return false;
			case 5u:
				return false;
			}
			num = (smethod_260(gclass2_0) ? (-1727402089) : (-1957794087));
			continue;
			end_IL_003d:
			break;
		}
		goto IL_0038;
		IL_0074:
		num = ((!smethod_2(gclass2_0)) ? (-18596145) : (-554709095));
		goto IL_003d;
	}

	internal static bool smethod_103(ProcessModuleInfo gclass1_0, RemoteModuleManager class93_0)
	{
		RemoteModuleManager.ModuleMatchContext @class = new RemoteModuleManager.ModuleMatchContext();
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		uint uint_ = default(uint);
		while (true)
		{
			int num = 111241506;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2B7E122B)) % 15)
				{
				case 11u:
					smethod_153(class93_0, intPtr, -1);
					num = 899517699;
					continue;
				case 10u:
					@class.gclass1_0 = gclass1_0;
					num = ((smethod_385(class93_0, @class.gclass1_0) <= 0) ? (-825638444) : (-878217952)) ^ ((int)num2 * -700172841);
					continue;
				case 7u:
				{
					ProcessModuleInfo gClass = smethod_42(class93_0.method_19()).FirstOrDefault(@class.method_0);
					if (gClass != null)
					{
						intPtr2 = smethod_225(gClass, "LdrUnloadDll", bool_0: false);
						num = ((!(intPtr2 == IntPtr.Zero)) ? 1744170323 : 470399402);
						continue;
					}
					throw new FileNotFoundException("Unable to find ntdll.dll in the specified process.");
				}
				case 6u:
					GetExitCodeThread(intPtr, out uint_);
					num = ((int)num2 * -638592711) ^ 0x4914EB80;
					continue;
				case 5u:
					intPtr = smethod_321(class93_0, intPtr2, @class.gclass1_0.method_0());
					num = 1706188068;
					continue;
				case 4u:
					smethod_108(class93_0, intPtr);
					num = ((uint_ != 0) ? 1334523807 : 100454095) ^ (int)(num2 * 323425302);
					continue;
				case 3u:
					num = ((!class93_0.method_8(class93_0.method_19().ProcessId)) ? 1422638295 : 2124295937);
					continue;
				case 1u:
					num = ((intPtr == IntPtr.Zero) ? 329242723 : 1906672512) ^ (int)(num2 * 56786663);
					continue;
				case 0u:
					break;
				case 2u:
					return false;
				default:
					return false;
				case 9u:
					throw new MissingMethodException("Unable to find the LdrUnloadDll function inside the specified process.");
				case 13u:
					throw new AccessViolationException("Unable to create thread in the specified process.");
				case 14u:
					throw new UnauthorizedAccessException("Unable to open the specified process for injection.");
				case 12u:
					return smethod_42(class93_0.method_19()).All(@class.method_1);
				}
				break;
			}
		}
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
		RemoteProcess gClass = default(RemoteProcess);
		ProcessWindowInfo @class = default(ProcessWindowInfo);
		ProcessWindowInfo[] array = default(ProcessWindowInfo[]);
		int num3 = default(int);
		int index = default(int);
		string text = default(string);
		Icon icon = default(Icon);
		Bitmap bitmap = default(Bitmap);
		while (true)
		{
			int num = 1363494530;
			while (true)
			{
				uint num2;
				Bitmap bitmap2;
				switch ((num2 = (uint)(num ^ 0x7F2B8557)) % 15)
				{
				case 14u:
					gClass = smethod_47(@class.method_2());
					num = ((gClass != null) ? 138933608 : 1386967852) ^ ((int)num2 * -1913677816);
					continue;
				case 13u:
					@class = array[num3];
					num = 904475238;
					continue;
				case 12u:
					num = (int)((num2 * 407335046) ^ 0x7809DD94);
					continue;
				case 10u:
					form5_0.dataGridView_0.Rows[index].Tag = gClass;
					num = (int)(num2 * 795412755) ^ -1266468621;
					continue;
				case 9u:
					array = smethod_413();
					num = ((int)num2 * -302315363) ^ 0x63399414;
					continue;
				case 7u:
					num = ((text.Length == 0) ? (-1643091981) : (-548535499)) ^ (int)(num2 * 1158990031);
					continue;
				case 6u:
					num = ((num3 >= array.Length) ? 2133218206 : 584770980);
					continue;
				case 5u:
					text = smethod_331(@class);
					num = (smethod_287(@class) ? (-502967497) : (-958519747)) ^ ((int)num2 * -1951646455);
					continue;
				case 4u:
					num3++;
					num = 1104253328;
					continue;
				case 3u:
					bitmap2 = smethod_100(icon);
					goto IL_0149;
				case 2u:
					num3 = 0;
					num = (int)((num2 * 930748759) ^ 0x41F7014F);
					continue;
				case 1u:
					icon = smethod_274(@class);
					if (icon != null)
					{
						num = (int)((num2 * 1603632467) ^ 0x7548CF7A);
						continue;
					}
					bitmap2 = new Bitmap(22, 22);
					goto IL_0149;
				case 0u:
					index = form5_0.dataGridView_0.Rows.Add(bitmap, string.Format("{0:X8}-{1}", @class.method_2(), text));
					num = ((int)num2 * -12646959) ^ 0x702D7BC;
					continue;
				default:
					return;
				case 11u:
					break;
				case 8u:
					return;
					IL_0149:
					bitmap = bitmap2;
					num = 487409361;
					continue;
				}
				break;
			}
		}
	}

	internal static IntPtr smethod_146(IntPtr intptr_0, IntPtr intptr_1, bool bool_0, RemoteProcessComponent class83_0)
	{
		if (PlatformInfo.bool_1)
		{
			goto IL_003d;
		}
		goto IL_01b2;
		IL_003d:
		int num = -113995873;
		goto IL_0161;
		IL_0161:
		IntPtr intptr_2 = default(IntPtr);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -425249148)) % 12)
			{
			case 11u:
				NtSetInformationThread(intptr_2, NativeTypes.Enum25.const_17, IntPtr.Zero, 0);
				num = ((int)num2 * -1356163893) ^ -1196351519;
				continue;
			case 10u:
				break;
			case 8u:
				intptr_2 = CreateRemoteThread(class83_0.method_2(), IntPtr.Zero, UIntPtr.Zero, intptr_1, intptr_0, 0u, IntPtr.Zero);
				num = -71825487;
				continue;
			case 6u:
				num = (int)((num2 * 1973600605) ^ 0xD113F33);
				continue;
			case 4u:
				ResumeThread(intptr_2);
				num = (int)((num2 * 1549463048) ^ 0x7168FE2E);
				continue;
			case 3u:
				goto IL_009a;
			case 2u:
				num = ((!PlatformInfo.bool_3) ? (-717832740) : (-1540611496)) ^ (int)(num2 * 1623421764);
				continue;
			case 1u:
				num = ((!(intptr_2 != IntPtr.Zero)) ? (-477428475) : (-1222377497)) ^ (int)(num2 * 525971060);
				continue;
			case 0u:
				intptr_2 = CreateRemoteThread(class83_0.method_2(), IntPtr.Zero, UIntPtr.Zero, intptr_1, intptr_0, 4u, IntPtr.Zero);
				num = ((int)num2 * -1425589997) ^ 0xE8D4299;
				continue;
			case 7u:
				goto IL_01b2;
			case 5u:
				return intptr_2;
			default:
				return intptr_2;
			}
			break;
			IL_009a:
			num = ((NtCreateThreadEx(out intptr_2, 2097151u, IntPtr.Zero, class83_0.method_2(), intptr_1, intptr_0, bool_0 ? 4u : 0u, 0u, 0u, 0u, IntPtr.Zero) == 0) ? (-583039335) : (-2138671661));
		}
		goto IL_003d;
		IL_01b2:
		num = (bool_0 ? (-1064599342) : (-2005029628));
		goto IL_0161;
	}

	internal static RemoteProcess[] smethod_148(string string_0, bool bool_0)
	{
		List<RemoteProcess> list = new List<RemoteProcess>();
		int num3 = default(int);
		RemoteProcess[] array = default(RemoteProcess[]);
		string text = default(string);
		RemoteProcess gClass = default(RemoteProcess);
		while (true)
		{
			int num = -1797034305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -384576450)) % 14)
				{
				case 13u:
					num = ((num3 < array.Length) ? (-344784802) : (-1824232147));
					continue;
				case 12u:
					num = (text.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) ? (-1778225723) : (-513210659)) ^ ((int)num2 * -296238362);
					continue;
				case 11u:
					num = (bool_0 ? (-455249756) : (-1808222077)) ^ ((int)num2 * -598137637);
					continue;
				case 10u:
					num = (int)((num2 * 653959725) ^ 0x7D353A8B);
					continue;
				case 9u:
					num = ((!text.Equals(string_0, StringComparison.OrdinalIgnoreCase)) ? (-1243497508) : (-1488624278));
					continue;
				case 8u:
					num3 = 0;
					num = (int)((num2 * 17857332) ^ 0x77DA5924);
					continue;
				case 7u:
					text = gClass.Name;
					num = (int)(num2 * 484229070) ^ -1986312089;
					continue;
				case 6u:
					list.Add(gClass);
					num = ((int)num2 * -1850663936) ^ 0x1F988BDC;
					continue;
				case 4u:
					gClass = array[num3];
					num = -49339547;
					continue;
				case 3u:
					text = text.Substring(0, text.Length - 4);
					num = ((int)num2 * -1406809422) ^ 0x1021363;
					continue;
				case 1u:
					array = smethod_155();
					num = (int)(num2 * 737029593) ^ -559464653;
					continue;
				case 0u:
					num3++;
					num = -287538359;
					continue;
				case 2u:
					break;
				default:
					return list.ToArray();
				}
				break;
			}
		}
	}

	internal static bool smethod_151(ProcessWindowInfo class77_0)
	{
		if (!(class77_0.method_0() == IntPtr.Zero))
		{
			int int_ = default(int);
			while (true)
			{
				int num = 317222210;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7A4AFE37)) % 6)
					{
					case 5u:
						num = ((!IsWindow(class77_0.method_0())) ? (-1888454681) : (-1210580712)) ^ (int)(num2 * 997723809);
						continue;
					case 2u:
						class77_0.method_4(GetWindowThreadProcessId(class77_0.method_0(), out int_));
						num = 1704812998;
						continue;
					case 1u:
						class77_0.method_3(int_);
						num = (int)((num2 * 1420060104) ^ 0x424A36F1);
						continue;
					case 0u:
						break;
					default:
						return true;
					case 3u:
						goto end_IL_009f;
					}
					break;
				}
				continue;
				end_IL_009f:
				break;
			}
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
		uint num5 = default(uint);
		uint num6 = default(uint);
		RemoteProcess gClass = default(RemoteProcess);
		uint[] array = default(uint[]);
		uint num4 = default(uint);
		List<RemoteProcess> list = default(List<RemoteProcess>);
		uint uint_ = default(uint);
		while (true)
		{
			int num2 = -916512996;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1275962191)) % 15)
				{
				case 14u:
					num2 = ((num5 < num6) ? (-226235777) : (-367053465));
					continue;
				case 13u:
					num5++;
					num2 = -387749309;
					continue;
				case 12u:
					num2 = ((int)num3 * -1716113736) ^ 0x47080EB3;
					continue;
				case 11u:
					gClass = new RemoteProcess(array[num5]);
					num2 = -1933701878;
					continue;
				case 10u:
					num4 = 0u;
					list = new List<RemoteProcess>
					{
						Capacity = 0
					};
					num2 = ((int)num3 * -1430066918) ^ -784867021;
					continue;
				case 9u:
					num6 = uint_ / 4;
					num2 = ((int)num3 * -503568540) ^ 0x45B35F2D;
					continue;
				case 8u:
					EnumProcesses(array, num4, out uint_);
					num2 = (int)(num3 * 1565712766) ^ -1773526658;
					continue;
				case 7u:
					num5 = num - 1024;
					num2 = (int)((num3 * 1730369987) ^ 0x79EAC26C);
					continue;
				case 5u:
					num += 1024;
					array = new uint[num];
					num4 = (uint)(array.Length * 4);
					num2 = -431663925;
					continue;
				case 4u:
					list.Add(gClass);
					num2 = ((int)num3 * -997331693) ^ -24072470;
					continue;
				case 2u:
					num2 = (smethod_102(gClass) ? 868553410 : 833166873) ^ (int)(num3 * 1444445929);
					continue;
				case 1u:
					list.Capacity += (int)num6;
					num2 = ((int)num3 * -458021860) ^ -1089709196;
					continue;
				case 0u:
					num2 = ((num4 == uint_) ? (-497993605) : (-210126297)) ^ ((int)num3 * -842244729);
					continue;
				case 3u:
					break;
				default:
					return list.ToArray();
				}
				break;
			}
		}
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
		IEnumerator<int> enumerator = smethod_66(gclass2_0).GetEnumerator();
		try
		{
			ProcessThreadInfo @class = default(ProcessThreadInfo);
			int current = default(int);
			while (true)
			{
				IL_00ce:
				int num = (enumerator.MoveNext() ? (-220082529) : (-1654316114));
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -780643675)) % 7)
					{
					case 6u:
						list.Add(@class);
						num = (int)((num2 * 1572174479) ^ 0x44717921);
						continue;
					case 5u:
						num = -220082529;
						continue;
					case 4u:
						@class = new ProcessThreadInfo(gclass2_0, current);
						num = (int)(num2 * 542129054) ^ -1296490314;
						continue;
					case 1u:
						current = enumerator.Current;
						num = -1953046908;
						continue;
					case 0u:
						num = (smethod_70(@class) ? 137711753 : 1285514769) ^ ((int)num2 * -1104536626);
						continue;
					default:
						goto end_IL_0091;
					case 3u:
						break;
					case 2u:
						goto end_IL_0091;
					}
					goto IL_00ce;
					continue;
					end_IL_0091:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_0114:
					int num3 = -168540479;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num3 ^ -780643675)) % 3)
						{
						case 2u:
							goto IL_00e2;
						default:
							goto end_IL_00f6;
						case 0u:
							break;
						case 1u:
							goto end_IL_00f6;
						}
						goto IL_0114;
						IL_00e2:
						enumerator.Dispose();
						num3 = (int)(num2 * 644218183) ^ -1176034497;
						continue;
						end_IL_00f6:
						break;
					}
					break;
				}
			}
		}
		return list;
	}

	internal static RemoteProcess smethod_183(IntPtr intptr_0, int int_0)
	{
		RemoteProcess gClass = new RemoteProcess((uint)int_0);
		gClass.Handle = intptr_0;
		RemoteProcess gClass2 = gClass;
		while (true)
		{
			int num = 1566458528;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0xF373082)) % 4)
				{
				case 2u:
					num3 = ((!smethod_102(gClass2)) ? (-1457748859) : (-813358121));
					goto IL_002e;
				case 0u:
					break;
				case 1u:
					return null;
				default:
					return gClass2;
				}
				break;
				IL_002e:
				num = num3 ^ ((int)num2 * -2097154587);
			}
		}
	}

	internal static ProcessModuleInfo smethod_196(ProcessModuleCollection class69_0, IntPtr intptr_0)
	{
		ProcessModuleCollection.Class71 @class = new ProcessModuleCollection.Class71();
		@class.intptr_0 = intptr_0;
		return class69_0.Find(@class.method_0);
	}

	internal unsafe static IntPtr smethod_197(LdrLoadDllStubInjector class86_0, IntPtr intptr_0, ProcessModuleInfo gclass1_0)
	{
		//The blocks IL_004a, IL_005e, IL_007e, IL_008b, IL_0097, IL_00a1, IL_00b0, IL_00d5, IL_00e1, IL_00eb, IL_00fa, IL_0111, IL_0127, IL_0133, IL_013d, IL_014c, IL_0162, IL_016e, IL_0178, IL_0187, IL_01aa, IL_01c0, IL_01cc, IL_01d6, IL_01e5, IL_01f8, IL_0204, IL_020e, IL_021d, IL_023a, IL_0246, IL_0256, IL_025d, IL_0269, IL_0273, IL_0282, IL_0288, IL_0294, IL_029e, IL_02ad, IL_02b3, IL_02bf, IL_02cf, IL_02e1, IL_02ec, IL_02f8, IL_0305, IL_0320, IL_0349, IL_0361, IL_036e, IL_03f9, IL_0403, IL_0413, IL_0423, IL_0433, IL_0443, IL_0453 are reachable both inside and outside the pinned region starting at IL_003e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		byte[] array = class86_0.method_10<byte>(intptr_0, 512);
		byte referenceStorage = 0;
		ref byte reference = ref referenceStorage;
		int num4 = default(int);
		byte[] array3 = default(byte[]);
		IntPtr intPtr = default(IntPtr);
		int num10 = default(int);
		BeaEngineDisasm struct31_ = default(BeaEngineDisasm);
		byte* ptr = default(byte*);
		BeaEngineDisasm @struct = default(BeaEngineDisasm);
		while (true)
		{
			int num = -434742910;
			while (true)
			{
				uint num3;
				uint num2 = (num3 = (uint)(num ^ -868245406));
				int num9;
				int num11;
				int num8;
				ref byte* pByte_ = ref struct31_.pByte_0;
				int num5;
				int num13;
				int num6;
				int num14;
				int num12;
				int num7;
				byte[] array2;
				switch (num2 % 30)
				{
				case 29u:
					reference = ref *(byte*)null;
					num = ((num4 == -1) ? (-898327583) : (-109086173));
					continue;
				case 27u:
					while (true)
					{
						IL_0036:
						fixed (byte* ptr2 = &array3[0])
						{
							num = -1801241708;
							while (true)
							{
								num2 = (num3 = (uint)(num ^ -868245406));
								switch (num2 % 30)
								{
								case 29u:
									break;
								case 27u:
									goto IL_0036;
								case 26u:
									array = class86_0.method_10<byte>(intPtr, 15);
									num = -222138447;
									continue;
								case 25u:
								{
									int num15 = BitConverter.ToInt32(array, num4 + 1);
									intPtr = intptr_0.smethod_8(num4 + 5 + num15);
									num = -181273287;
									continue;
								}
								case 24u:
									num9 = (num10 = smethod_224(ref struct31_));
									num11 = ((num9 <= 0) ? 788743707 : 1770834186);
									num = num11 ^ ((int)num3 * -349977012);
									continue;
								case 23u:
								{
									string string_ = "h\0\0\0\0h\0\0\0\0è";
									string string_2 = "x????x????x";
									num8 = (smethod_40(0, string_, array, string_2) ? 1204606268 : 2059884722);
									num = num8 ^ ((int)num3 * -1104139123);
									continue;
								}
								case 22u:
									pByte_ = ref struct31_.pByte_0;
									pByte_ += num10;
									num = -682302182;
									continue;
								case 20u:
									num5 = (((ulong)(long)intPtr >= (ulong)((long)intPtr + gclass1_0.method_4())) ? 188985037 : 1264292352);
									num = num5 ^ (int)(num3 * 300569485);
									continue;
								case 19u:
									num4 = smethod_378(array, "j\u0001", 0);
									num13 = ((num4 != -1) ? (-520168972) : (-342354620));
									num = num13 ^ (int)(num3 * 829113150);
									continue;
								case 18u:
									num4 = (int)(struct31_.pByte_0 - ptr2);
									num = ((int)num3 * -1366876534) ^ -622215185;
									continue;
								case 16u:
									num4 = smethod_378(array, "Â\u0010\0", 0);
									num6 = ((num4 != -1) ? 924948785 : 403664903);
									num = num6 ^ (int)(num3 * 225315374);
									continue;
								case 15u:
									num14 = (((ulong)(long)intPtr < (ulong)(long)gclass1_0.method_0()) ? (-1185537316) : (-1981051253));
									num = num14 ^ (int)(num3 * 1503913541);
									continue;
								case 14u:
									num = ((struct31_.struct27_0.method_0() == "call ") ? (-1069048020) : (-1651216740));
									continue;
								case 13u:
									num12 = ((!PlatformInfo.bool_7) ? (-201253133) : (-1891877039));
									num = num12 ^ (int)(num3 * 2027098178);
									continue;
								case 12u:
									num7 = ((array3.Length == 0) ? (-999760709) : (-1151907387));
									num = num7 ^ ((int)num3 * -2104651953);
									continue;
								case 10u:
									array2 = (array3 = array);
									num = ((array2 != null) ? (-2089302806) : (-1844567741));
									continue;
								case 9u:
									Array.Resize(ref array, num4);
									num = -720497681;
									continue;
								case 8u:
									num = ((struct31_.pByte_0 >= ptr) ? (-323552285) : (-791054040));
									continue;
								case 6u:
									num = (int)((num3 * 1718509531) ^ 0x6697BB64);
									continue;
								case 5u:
									goto end_IL_0036;
								case 4u:
									@struct.pByte_0 = ptr2 + num4;
									struct31_ = @struct;
									ptr = ptr2 + array.Length;
									num = (int)(num3 * 1634112372) ^ -78365312;
									continue;
								case 3u:
									@struct.uint_1 = 0u;
									num = (int)((num3 * 1856669281) ^ 0x67DFCBBB);
									continue;
								case 0u:
									@struct = default(BeaEngineDisasm);
									num = -1242932931;
									continue;
								case 2u:
									num = -434742910;
									continue;
								case 1u:
									throw new MissingMethodException("Unable to find call to LdrpLoadDll function inside LdrLoadDll.");
								case 7u:
									throw new MissingMethodException("Unable to verify the guessed function is LdrpLoadDll.");
								case 11u:
									throw new MissingMethodException("The function thought to be LdrpLoadDll is outside ntdll.dll.");
								case 17u:
									throw new InvalidOperationException("Unable to find function end of LdrLoadDll.");
								case 28u:
									throw new InvalidOperationException("Unable to detect signature for LdrpLoadDll.");
								default:
									return intPtr;
								}
								break;
							}
						}
						goto case 29u;
						continue;
						end_IL_0036:
						break;
					}
					goto case 5u;
				case 26u:
					array = class86_0.method_10<byte>(intPtr, 15);
					num = -222138447;
					continue;
				case 25u:
				{
					int num15 = BitConverter.ToInt32(array, num4 + 1);
					intPtr = intptr_0.smethod_8(num4 + 5 + num15);
					num = -181273287;
					continue;
				}
				case 24u:
					num9 = (num10 = smethod_224(ref struct31_));
					num11 = ((num9 <= 0) ? 788743707 : 1770834186);
					num = num11 ^ ((int)num3 * -349977012);
					continue;
				case 23u:
				{
					string string_ = "h\0\0\0\0h\0\0\0\0è";
					string string_2 = "x????x????x";
					num8 = (smethod_40(0, string_, array, string_2) ? 1204606268 : 2059884722);
					num = num8 ^ ((int)num3 * -1104139123);
					continue;
				}
				case 22u:
					pByte_ = ref struct31_.pByte_0;
					pByte_ += num10;
					num = -682302182;
					continue;
				case 20u:
					num5 = (((ulong)(long)intPtr >= (ulong)((long)intPtr + gclass1_0.method_4())) ? 188985037 : 1264292352);
					num = num5 ^ (int)(num3 * 300569485);
					continue;
				case 19u:
					num4 = smethod_378(array, "j\u0001", 0);
					num13 = ((num4 != -1) ? (-520168972) : (-342354620));
					num = num13 ^ (int)(num3 * 829113150);
					continue;
				case 18u:
					num4 = (int)(struct31_.pByte_0 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
					num = ((int)num3 * -1366876534) ^ -622215185;
					continue;
				case 16u:
					num4 = smethod_378(array, "Â\u0010\0", 0);
					num6 = ((num4 != -1) ? 924948785 : 403664903);
					num = num6 ^ (int)(num3 * 225315374);
					continue;
				case 15u:
					num14 = (((ulong)(long)intPtr < (ulong)(long)gclass1_0.method_0()) ? (-1185537316) : (-1981051253));
					num = num14 ^ (int)(num3 * 1503913541);
					continue;
				case 14u:
					num = ((struct31_.struct27_0.method_0() == "call ") ? (-1069048020) : (-1651216740));
					continue;
				case 13u:
					num12 = ((!PlatformInfo.bool_7) ? (-201253133) : (-1891877039));
					num = num12 ^ (int)(num3 * 2027098178);
					continue;
				case 12u:
					num7 = ((array3.Length == 0) ? (-999760709) : (-1151907387));
					num = num7 ^ ((int)num3 * -2104651953);
					continue;
				case 10u:
					array2 = (array3 = array);
					num = ((array2 != null) ? (-2089302806) : (-1844567741));
					continue;
				case 9u:
					Array.Resize(ref array, num4);
					num = -720497681;
					continue;
				case 8u:
					num = ((struct31_.pByte_0 >= ptr) ? (-323552285) : (-791054040));
					continue;
				case 6u:
					num = (int)((num3 * 1718509531) ^ 0x6697BB64);
					continue;
				case 5u:
					reference = ref *(byte*)null;
					num = -1801241708;
					continue;
				case 4u:
					@struct.pByte_0 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + num4;
					struct31_ = @struct;
					ptr = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + array.Length;
					num = (int)(num3 * 1634112372) ^ -78365312;
					continue;
				case 3u:
					@struct.uint_1 = 0u;
					num = (int)((num3 * 1856669281) ^ 0x67DFCBBB);
					continue;
				case 0u:
					@struct = default(BeaEngineDisasm);
					num = -1242932931;
					continue;
				case 2u:
					break;
				case 1u:
					throw new MissingMethodException("Unable to find call to LdrpLoadDll function inside LdrLoadDll.");
				case 7u:
					throw new MissingMethodException("Unable to verify the guessed function is LdrpLoadDll.");
				case 11u:
					throw new MissingMethodException("The function thought to be LdrpLoadDll is outside ntdll.dll.");
				case 17u:
					throw new InvalidOperationException("Unable to find function end of LdrLoadDll.");
				case 28u:
					throw new InvalidOperationException("Unable to detect signature for LdrpLoadDll.");
				default:
					return intPtr;
				}
				break;
			}
		}
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
		string text = smethod_440(string_0, null, null, (DependencySearchFlags)(2 | (smethod_379(gclass1_0.gclass2_0) ? 8 : 0)), 0, IntPtr.Zero);
		ProcessModuleInfo result = default(ProcessModuleInfo);
		while (true)
		{
			int num = 1991169265;
			while (true)
			{
				int num5;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x73180430)) % 4)
				{
				case 1u:
					num5 = ((!string.IsNullOrEmpty(text)) ? 1149833949 : 1014053732);
					goto IL_0042;
				case 0u:
					break;
				case 2u:
					return null;
				default:
					try
					{
						if (!(FileVersionInfo.GetVersionInfo(text).CompanyName != "Microsoft Corporation"))
						{
							LoadLibraryInjector @class = new LoadLibraryInjector(gclass1_0.gclass2_0);
							try
							{
								IntPtr intPtr = @class.Inject(text);
								if (!(intPtr == IntPtr.Zero))
								{
									goto IL_00bb;
								}
								object obj = null;
								goto IL_00ef;
								IL_00de:
								obj = smethod_196(smethod_42(gclass1_0.gclass2_0), intPtr);
								goto IL_00ef;
								IL_00ef:
								result = (ProcessModuleInfo)obj;
								int num3 = 693599755;
								goto IL_00c0;
								IL_00c0:
								switch ((uint)(num3 ^ 0x73180430) % 3u)
								{
								case 0u:
									break;
								default:
									goto end_IL_00a3;
								case 1u:
									goto IL_00de;
								case 2u:
									goto end_IL_00a3;
								}
								goto IL_00bb;
								IL_00bb:
								num3 = 1761742619;
								goto IL_00c0;
								end_IL_00a3:;
							}
							finally
							{
								if (@class != null)
								{
									while (true)
									{
										IL_0130:
										int num4 = 837427947;
										while (true)
										{
											switch ((num2 = (uint)(num4 ^ 0x73180430)) % 3)
											{
											case 1u:
												goto IL_00fe;
											default:
												goto end_IL_0112;
											case 2u:
												break;
											case 0u:
												goto end_IL_0112;
											}
											goto IL_0130;
											IL_00fe:
											((IDisposable)@class).Dispose();
											num4 = (int)((num2 * 1222569326) ^ 0x1B7806DD);
											continue;
											end_IL_0112:
											break;
										}
										break;
									}
								}
							}
						}
						else
						{
							result = null;
						}
					}
					catch
					{
						result = null;
					}
					return result;
				}
				break;
				IL_0042:
				num = num5 ^ ((int)num2 * -557636338);
			}
		}
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
		IntPtr intPtr = smethod_250(gclass1_0.gclass2_0, NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_9, bool_0: false, gclass1_0.gclass2_0.ProcessId);
		StringBuilder stringBuilder = default(StringBuilder);
		NativeTypes.Struct46 struct46_ = default(NativeTypes.Struct46);
		while (true)
		{
			int num = -2136729239;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -127140649)) % 15)
				{
				case 12u:
					gclass1_0.method_7(stringBuilder.ToString());
					num = ((GetModuleBaseName(intPtr, gclass1_0.method_0(), stringBuilder, stringBuilder.Capacity) == 0) ? (-727661816) : (-880688301));
					continue;
				case 11u:
					num = ((intPtr == IntPtr.Zero) ? (-802655388) : (-459723165)) ^ ((int)num2 * -1639283245);
					continue;
				case 10u:
					num = (GetModuleInformation(intPtr, gclass1_0.method_0(), out struct46_, typeof(NativeTypes.Struct46).smethod_7()) ? (-830289858) : (-1757415651));
					continue;
				case 9u:
					stringBuilder = new StringBuilder(255);
					num = ((GetModuleFileNameEx(intPtr, gclass1_0.method_0(), stringBuilder, stringBuilder.Capacity) == 0) ? 1993322590 : 269386978) ^ (int)(num2 * 340438428);
					continue;
				case 8u:
					smethod_27(gclass1_0.gclass2_0, intPtr);
					num = ((int)num2 * -1274770309) ^ -1814361568;
					continue;
				case 4u:
					gclass1_0.method_1(struct46_.intptr_0);
					num = (int)((num2 * 107175750) ^ 0x3269A255);
					continue;
				case 3u:
					smethod_27(gclass1_0.gclass2_0, intPtr);
					num = (int)(num2 * 1170926132) ^ -771540066;
					continue;
				case 2u:
					gclass1_0.method_3(struct46_.intptr_1);
					gclass1_0.method_5(struct46_.uint_0);
					num = -1334528545;
					continue;
				case 0u:
					gclass1_0.method_9(stringBuilder.ToString());
					num = -1172327067;
					continue;
				case 14u:
					break;
				case 1u:
					return false;
				case 5u:
					return false;
				case 6u:
					smethod_27(gclass1_0.gclass2_0, intPtr);
					return false;
				case 7u:
					return false;
				default:
					smethod_27(gclass1_0.gclass2_0, intPtr);
					return true;
				}
				break;
			}
		}
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
		if (enum15_0 == ProcessMemoryAccess.const_0)
		{
			goto IL_004f;
		}
		goto IL_00a6;
		IL_004f:
		int num = -1492687271;
		goto IL_0066;
		IL_0066:
		NativeTypes.Enum32 @enum = default(NativeTypes.Enum32);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -112940600)) % 8)
			{
			case 7u:
				num = ((int)num2 * -1836325901) ^ -1242989383;
				continue;
			case 5u:
				@enum = NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_5;
				num = -565761348;
				continue;
			case 4u:
				@enum |= NativeTypes.Enum32.flag_9;
				num = -989861536;
				continue;
			case 3u:
				@enum = NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5;
				num = ((int)num2 * -854360926) ^ -503782774;
				continue;
			case 2u:
				break;
			case 1u:
				@enum = NativeTypes.Enum32.flag_4;
				num = (int)(num2 * 1541353853) ^ -748992734;
				continue;
			case 6u:
				goto IL_00a6;
			default:
				return OpenProcess(@enum, bool_0: false, int_0);
			}
			break;
		}
		goto IL_004f;
		IL_00a6:
		num = ((enum15_0 != ProcessMemoryAccess.const_2) ? (-209039675) : (-38261405));
		goto IL_0066;
	}

	internal static Peb32 smethod_255(RemoteProcess gclass2_0)
	{
		if (PlatformInfo.bool_0)
		{
			goto IL_00a5;
		}
		goto IL_00f5;
		IL_00a5:
		int num = 1978106553;
		goto IL_00aa;
		IL_00aa:
		Peb32 @class = default(Peb32);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6AD39705)) % 9)
			{
			case 7u:
				num = ((!smethod_409(@class)) ? (-1440016353) : (-1128519321)) ^ (int)(num2 * 301388504);
				continue;
			case 5u:
				num = ((smethod_270(@class) != IntPtr.Zero) ? 690128447 : 1113153845) ^ ((int)num2 * -220634323);
				continue;
			case 1u:
				num = ((!gclass2_0.Is64Bit) ? 446886717 : 1299284044) ^ (int)(num2 * 1150804737);
				continue;
			case 0u:
				break;
			case 8u:
				goto IL_00e0;
			case 4u:
				goto IL_00f5;
			default:
				return gclass2_0.TrackResource(@class);
			case 3u:
				return null;
			case 6u:
				return null;
			}
			break;
		}
		goto IL_00a5;
		IL_00f5:
		Peb32 class2;
		if (gclass2_0.Handle != IntPtr.Zero)
		{
			class2 = new Peb32(gclass2_0, gclass2_0.Handle);
			goto IL_00e6;
		}
		num = 493614286;
		goto IL_00aa;
		IL_00e6:
		@class = class2;
		num = 445208270;
		goto IL_00aa;
		IL_00e0:
		class2 = new Peb32(gclass2_0);
		goto IL_00e6;
	}

	internal static bool smethod_260(RemoteProcess gclass2_0)
	{
		if (PlatformInfo.bool_0)
		{
			goto IL_00d8;
		}
		goto IL_012e;
		IL_00d8:
		int num = -849872108;
		goto IL_00dd;
		IL_00dd:
		IntPtr intPtr = default(IntPtr);
		uint uint_ = default(uint);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -24526846)) % 12)
			{
			case 11u:
				intPtr = smethod_250(gclass2_0, NativeTypes.Enum32.flag_9, bool_0: false, gclass2_0.ProcessId);
				num = ((!(intPtr == IntPtr.Zero)) ? (-608033379) : (-662107286)) ^ ((int)num2 * -506787402);
				continue;
			case 6u:
				num = ((!gclass2_0.Is64Bit) ? 553229817 : 1638943364) ^ ((int)num2 * -498208378);
				continue;
			case 5u:
				break;
			case 4u:
				smethod_27(gclass2_0, intPtr);
				num = (int)(num2 * 1999703407) ^ -1992290343;
				continue;
			case 1u:
				gclass2_0.IsDepEnabled = (uint_ & 1) != 0;
				num = -493749486;
				continue;
			case 0u:
				goto end_IL_00dd;
			case 7u:
				goto IL_012e;
			case 2u:
				gclass2_0.IsDepEnabled = true;
				return true;
			case 3u:
				return true;
			case 8u:
				smethod_27(gclass2_0, intPtr);
				return false;
			default:
				gclass2_0.IsDepEnabled = false;
				return true;
			case 10u:
				return false;
			}
			num = (GetProcessDEPPolicy(intPtr, out uint_, out var _) ? (-1700153137) : (-1533967634));
			continue;
			end_IL_00dd:
			break;
		}
		goto IL_00d8;
		IL_012e:
		num = ((!RemoteProcess.SupportsDepPolicyQuery) ? (-69344553) : (-581835979));
		goto IL_00dd;
	}

	internal static Icon smethod_274(ProcessWindowInfo class77_0)
	{
		SendMessageTimeout(class77_0.method_0(), 127u, (UIntPtr)1uL, IntPtr.Zero, NativeTypes.Enum20.flag_2, 250u, out var intptr_);
		if (intptr_ != IntPtr.Zero)
		{
			goto IL_0045;
		}
		goto IL_0079;
		IL_0045:
		int num = -1852905715;
		goto IL_004a;
		IL_004a:
		switch ((uint)(num ^ -1596148236) % 5u)
		{
		case 4u:
			break;
		case 1u:
			goto IL_0079;
		default:
			return null;
		case 2u:
			return Icon.FromHandle(intptr_);
		case 3u:
			return Icon.FromHandle(intptr_);
		}
		goto IL_0045;
		IL_0079:
		intptr_ = smethod_445(class77_0.method_0(), -14);
		num = ((!(intptr_ != IntPtr.Zero)) ? (-1351201187) : (-1754428798));
		goto IL_004a;
	}

	internal static void smethod_283(IntPtr intptr_0, ProcessModuleCollection class69_0)
	{
		int num = class69_0.gclass2_0.list_1.Count - 1;
		while (true)
		{
			int num2 = ((num >= 0) ? 1965510689 : 319296093);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x198697BB)) % 7)
				{
				case 4u:
					num2 = 1965510689;
					continue;
				case 2u:
					class69_0.gclass2_0.list_1.RemoveAt(num);
					num2 = ((int)num3 * -1936119763) ^ -1633136007;
					continue;
				case 1u:
					num2 = ((!(class69_0.gclass2_0.list_1[num].method_0() == intptr_0)) ? 89802423 : 82506468);
					continue;
				case 0u:
					num--;
					num2 = 2140263822;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
					return;
				case 6u:
					return;
				}
				break;
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
		IntPtr intPtr = OpenThread(NativeTypes.Enum31.flag_1, bool_0: false, class75_0.method_0());
		if (intPtr == IntPtr.Zero)
		{
			goto IL_001b;
		}
		goto IL_005b;
		IL_001b:
		int num = 1568985078;
		goto IL_0036;
		IL_0036:
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xEAF4109)) % 5)
			{
			case 4u:
				break;
			case 1u:
				CloseHandle(intPtr);
				num = ((int)num2 * -1178281959) ^ -802970622;
				continue;
			case 2u:
				goto IL_005b;
			default:
				return num3 != -1;
			case 3u:
				return false;
			}
			break;
		}
		goto IL_001b;
		IL_005b:
		num3 = SuspendThread(intPtr);
		num = 1674778241;
		goto IL_0036;
	}

	internal static bool HasProcessExited(RemoteProcess gclass2_0)
	{
		if (gclass2_0.bool_4)
		{
			goto IL_00a0;
		}
		goto IL_0105;
		IL_00a0:
		int num = -1463933434;
		goto IL_00bc;
		IL_00bc:
		IntPtr intPtr = default(IntPtr);
		uint uint_ = default(uint);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2042076637)) % 10)
			{
			case 8u:
				break;
			case 7u:
				num = ((!gclass2_0.bool_3) ? (-1209576991) : (-731424082)) ^ (int)(num2 * 1686629331);
				continue;
			case 3u:
				GetExitCodeProcess(intPtr, out uint_);
				num = -1866404106;
				continue;
			case 2u:
				goto end_IL_00bc;
			case 1u:
				smethod_27(gclass2_0, intPtr);
				num = (int)((num2 * 1409327358) ^ 0x6A306AED);
				continue;
			case 6u:
				goto IL_0105;
			default:
			{
				uint num3 = WaitForSingleObject(intPtr, 0u);
				smethod_27(gclass2_0, intPtr);
				return num3 != 258;
			}
			case 4u:
				return uint_ != 259;
			case 5u:
				return true;
			case 9u:
				return true;
			}
			intPtr = smethod_250(gclass2_0, PlatformInfo.bool_1 ? NativeTypes.Enum32.flag_10 : NativeTypes.Enum32.flag_9, bool_0: false, gclass2_0.ProcessId);
			num = ((!(intPtr == IntPtr.Zero)) ? (-1399956404) : (-1042910522));
			continue;
			end_IL_00bc:
			break;
		}
		goto IL_00a0;
		IL_0105:
		intPtr = smethod_250(gclass2_0, NativeTypes.Enum32.flag_11, bool_0: false, gclass2_0.ProcessId);
		num = ((intPtr == IntPtr.Zero) ? (-862091211) : (-427289265));
		goto IL_00bc;
	}

	internal static void smethod_313(string string_0, string string_1, IntPtr intptr_0, ProcessModuleInfo gclass1_0, uint uint_0)
	{
		gclass1_0.method_7(string_0);
		gclass1_0.method_9(string_1);
		gclass1_0.method_3(intptr_0);
		while (true)
		{
			int num = -2135046550;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1333916164)) % 3)
				{
				case 2u:
					goto IL_0017;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0017:
				gclass1_0.method_5(uint_0);
				num = (int)(num2 * 50272429) ^ -1657704505;
			}
		}
	}

	internal static IntPtr smethod_321(RemoteProcessComponent class83_0, IntPtr intptr_0, IntPtr intptr_1)
	{
		return smethod_146(intptr_1, intptr_0, class83_0.method_17(), class83_0);
	}

	internal static bool smethod_327(RemoteModuleUnlinker class129_0, IntPtr intptr_0)
	{
		RemoteModuleUnlinker.Class130 @class = new RemoteModuleUnlinker.Class130();
		ProcessModuleInfo gClass = default(ProcessModuleInfo);
		while (true)
		{
			int num = 916096859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x558C464C)) % 6)
				{
				case 2u:
					num = ((gClass == null) ? 698416911 : 1558461311) ^ (int)(num2 * 435940279);
					continue;
				case 1u:
					@class.intptr_0 = intptr_0;
					num = (int)(num2 * 195198426) ^ -1823967228;
					continue;
				case 0u:
					gClass = smethod_42(class129_0.method_0()).FirstOrDefault(@class.method_0);
					num = (int)((num2 * 967830023) ^ 0x17C9D700);
					continue;
				case 4u:
					break;
				case 5u:
					throw new InvalidOperationException("Unable to find the specified module in the process.");
				default:
					return smethod_229(class129_0, gClass);
				}
				break;
			}
		}
	}

	internal static string smethod_331(ProcessWindowInfo class77_0)
	{
		int windowTextLength = GetWindowTextLength(class77_0.method_0());
		if (windowTextLength == 0)
		{
			goto IL_001e;
		}
		goto IL_0052;
		IL_001e:
		int num = 1373384318;
		goto IL_0023;
		IL_0023:
		StringBuilder stringBuilder = default(StringBuilder);
		switch ((uint)(num ^ 0x26C020BD) % 5u)
		{
		case 4u:
			break;
		case 0u:
			goto IL_0052;
		case 1u:
			return string.Empty;
		case 2u:
			return stringBuilder.ToString();
		default:
			return string.Empty;
		}
		goto IL_001e;
		IL_0052:
		stringBuilder = new StringBuilder(windowTextLength + 1);
		num = ((GetWindowText(class77_0.method_0(), stringBuilder, stringBuilder.Capacity) == 0) ? 90177617 : 1258583095);
		goto IL_0023;
	}

	internal static void smethod_334(ProcessSelectorForm form5_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProcessSelectorForm));
		while (true)
		{
			int num = -2065578591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2022571101)) % 52)
				{
				case 51u:
					form5_0.Controls.Add(form5_0.button_0);
					form5_0.Controls.Add(form5_0.dataGridView_0);
					form5_0.Font = new Font("Segoe UI", 8.25f);
					num = ((int)num2 * -803629189) ^ -1223527194;
					continue;
				case 50u:
					form5_0.dataGridView_0.CellContentDoubleClick += form5_0.method_5;
					form5_0.dataGridViewImageColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
					num = ((int)num2 * -966559062) ^ -1868056723;
					continue;
				case 49u:
					form5_0.dataGridView_0.ColumnHeadersVisible = false;
					num = (int)((num2 * 1285860555) ^ 0xE715635);
					continue;
				case 48u:
					form5_0.button_3.Size = new Size(122, 23);
					form5_0.button_3.TabIndex = 4;
					form5_0.button_3.Text = UiText.Get("Common.Close");
					form5_0.button_3.UseVisualStyleBackColor = true;
					num = ((int)num2 * -768709894) ^ -691705746;
					continue;
				case 47u:
					form5_0.MaximizeBox = false;
					form5_0.MinimizeBox = false;
					num = ((int)num2 * -1683533116) ^ 0x25CC5834;
					continue;
				case 46u:
					form5_0.button_1.TabIndex = 2;
					num = (int)(num2 * 212623809) ^ -808915532;
					continue;
				case 45u:
					form5_0.button_1.Location = new Point(138, 223);
					form5_0.button_1.Name = "windowListButton";
					num = ((int)num2 * -1315850481) ^ -655111121;
					continue;
				case 44u:
					form5_0.dataGridView_0.EditMode = DataGridViewEditMode.EditProgrammatically;
					form5_0.dataGridView_0.Location = new Point(11, 13);
					num = (int)(num2 * 1718375585) ^ -1701513294;
					continue;
				case 42u:
					form5_0.dataGridView_0.ReadOnly = true;
					form5_0.dataGridView_0.RowHeadersVisible = false;
					form5_0.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
					num = (int)((num2 * 1110555285) ^ 0x6F98941F);
					continue;
				case 41u:
					form5_0.dataGridView_0.MultiSelect = false;
					num = ((int)num2 * -1843021452) ^ -251247046;
					continue;
				case 40u:
					form5_0.button_2.Click += form5_0.method_3;
					num = (int)((num2 * 663908027) ^ 0x2229AE07);
					continue;
				case 39u:
					form5_0.button_0.UseVisualStyleBackColor = true;
					form5_0.button_0.Click += form5_0.method_4;
					num = ((int)num2 * -455335248) ^ -670186518;
					continue;
				case 38u:
					form5_0.dataGridViewImageColumn_0.HeaderText = "";
					num = ((int)num2 * -1275976711) ^ -388785097;
					continue;
				case 37u:
					form5_0.button_2 = new Button();
					form5_0.button_3 = new Button();
					num = ((int)num2 * -111954435) ^ 0x26FD2525;
					continue;
				case 36u:
					form5_0.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					num = (int)(num2 * 1044046171) ^ -1315679614;
					continue;
				case 35u:
					form5_0.Name = "ProcessSelectForm";
					form5_0.Text = UiText.Get("ProcessList.Title");
					num = (int)(num2 * 618651243) ^ -275190735;
					continue;
				case 34u:
					form5_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = ((int)num2 * -1879597) ^ -360716422;
					continue;
				case 33u:
					form5_0.Controls.Add(form5_0.button_3);
					num = ((int)num2 * -1584076976) ^ -1361580172;
					continue;
				case 32u:
					form5_0.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
					form5_0.button_0 = new Button();
					num = (int)((num2 * 882900905) ^ 0x45F3250);
					continue;
				case 31u:
					form5_0.button_1.Size = new Size(122, 23);
					num = ((int)num2 * -2072702047) ^ -1617388622;
					continue;
				case 30u:
					form5_0.dataGridViewImageColumn_0.ReadOnly = true;
					num = (int)(num2 * 11690481) ^ -1975027776;
					continue;
				case 29u:
					form5_0.dataGridView_0.Columns.AddRange(form5_0.dataGridViewImageColumn_0, form5_0.dataGridViewTextBoxColumn_0);
					num = (int)((num2 * 1509726236) ^ 0x1DC2D44B);
					continue;
				case 28u:
					form5_0.dataGridView_0.AllowUserToResizeRows = false;
					form5_0.dataGridView_0.BackgroundColor = Color.White;
					form5_0.dataGridView_0.CellBorderStyle = DataGridViewCellBorderStyle.None;
					num = (int)(num2 * 270550795) ^ -999588789;
					continue;
				case 27u:
					form5_0.AutoScaleMode = AutoScaleMode.Dpi;
					num = (int)(num2 * 316309052) ^ -2059665591;
					continue;
				case 26u:
					form5_0.dataGridViewImageColumn_0.Name = "ProcessWindowIcon";
					num = ((int)num2 * -445815404) ^ 0x5421F815;
					continue;
				case 25u:
					form5_0.button_1.Text = UiText.Get("ProcessList.Windows");
					num = ((int)num2 * -1714145420) ^ -1343087227;
					continue;
				case 24u:
					form5_0.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = (int)((num2 * 208601208) ^ 0x2450828A);
					continue;
				case 23u:
					form5_0.button_1 = new Button();
					num = (int)((num2 * 145353532) ^ 0x370AD3E6);
					continue;
				case 22u:
					form5_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)(num2 * 1502987124) ^ -1036461324;
					continue;
				case 21u:
					form5_0.dataGridViewImageColumn_0.Width = 32;
					num = (int)((num2 * 840969501) ^ 0x3A511BCE);
					continue;
				case 20u:
					form5_0.button_0.Size = new Size(122, 23);
					num = (int)((num2 * 1470725205) ^ 0x7D0799B9);
					continue;
				case 19u:
					form5_0.Controls.Add(form5_0.button_2);
					num = (int)(num2 * 1619510871) ^ -960083355;
					continue;
				case 18u:
					form5_0.dataGridView_0 = new DataGridView();
					form5_0.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
					num = (int)((num2 * 1547751821) ^ 0x4FFB8C5);
					continue;
				case 16u:
					form5_0.dataGridViewTextBoxColumn_0.Name = "ProcessWindowName";
					form5_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
					num = (int)(num2 * 119325311) ^ -278591921;
					continue;
				case 15u:
					form5_0.Controls.Add(form5_0.button_1);
					num = ((int)num2 * -662221619) ^ -1022249465;
					continue;
				case 14u:
					form5_0.ClientSize = new Size(270, 283);
					num = ((int)num2 * -1688560752) ^ 0x58DFDF16;
					continue;
				case 13u:
					form5_0.dataGridView_0.AllowUserToResizeColumns = false;
					num = ((int)num2 * -1284064473) ^ 0x119AC8A8;
					continue;
				case 12u:
					form5_0.button_0.Location = new Point(10, 223);
					form5_0.button_0.Name = "processListButton";
					num = ((int)num2 * -922859942) ^ 0x5222985F;
					continue;
				case 11u:
					form5_0.button_2.Location = new Point(10, 252);
					form5_0.button_2.Name = "selectButton";
					form5_0.button_2.Size = new Size(122, 23);
					form5_0.button_2.TabIndex = 3;
					form5_0.button_2.Text = UiText.Get("ProcessList.Select");
					num = (int)(num2 * 1787356769) ^ -2051678009;
					continue;
				case 10u:
					form5_0.button_0.TabIndex = 1;
					num = ((int)num2 * -1254973592) ^ -16408253;
					continue;
				case 9u:
					form5_0.button_3.Click += form5_0.method_2;
					num = (int)(num2 * 335084122) ^ -1750722957;
					continue;
				case 8u:
					form5_0.button_3.Location = new Point(138, 252);
					form5_0.button_3.Name = "closeButton";
					num = ((int)num2 * -259186355) ^ -1318514193;
					continue;
				case 7u:
					form5_0.button_2.UseVisualStyleBackColor = true;
					num = (int)(num2 * 1019075875) ^ -1350666366;
					continue;
				case 6u:
					form5_0.dataGridView_0.RowTemplate.Resizable = DataGridViewTriState.False;
					form5_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					form5_0.dataGridView_0.Size = new Size(248, 204);
					form5_0.dataGridView_0.TabIndex = 0;
					num = ((int)num2 * -455543726) ^ 0x331FE025;
					continue;
				case 5u:
					form5_0.dataGridViewTextBoxColumn_0.HeaderText = "";
					num = (int)((num2 * 1860751607) ^ 0x226EFCD8);
					continue;
				case 4u:
					form5_0.button_0.Text = UiText.Get("ProcessList.Processes");
					num = ((int)num2 * -371993339) ^ 0x7DE2F620;
					continue;
				case 3u:
					((ISupportInitialize)form5_0.dataGridView_0).BeginInit();
					form5_0.SuspendLayout();
					form5_0.dataGridView_0.AllowUserToAddRows = false;
					form5_0.dataGridView_0.AllowUserToDeleteRows = false;
					num = ((int)num2 * -1585033242) ^ -1779456760;
					continue;
				case 2u:
					form5_0.button_1.UseVisualStyleBackColor = true;
					form5_0.button_1.Click += form5_0.method_6;
					num = ((int)num2 * -1521203077) ^ -299851566;
					continue;
				case 1u:
					form5_0.dataGridView_0.Name = "processWindowDataGridView";
					num = (int)(num2 * 392976815) ^ -2042898414;
					continue;
				case 0u:
					form5_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
					num = (int)(num2 * 223249023) ^ -97876431;
					continue;
				case 17u:
					break;
				default:
					((ISupportInitialize)form5_0.dataGridView_0).EndInit();
					form5_0.ResumeLayout(performLayout: false);
					return;
				}
				break;
			}
		}
	}

	internal unsafe static IntPtr smethod_335(IntPtr intptr_0, LdrLoadDllStubInjector class86_0, ProcessModuleInfo gclass1_0)
	{
		//The blocks IL_0012, IL_0016, IL_0022, IL_002c, IL_0049, IL_005c, IL_0073, IL_0096, IL_00b5, IL_00c1, IL_00cb, IL_00da, IL_011d, IL_012a, IL_0136, IL_0140, IL_014f, IL_0155, IL_0161, IL_0171, IL_0185, IL_01a0, IL_01cd, IL_01d9, IL_01e9, IL_0206, IL_0212, IL_0222, IL_0226, IL_0232, IL_0242, IL_0267, IL_026d, IL_0279, IL_0283, IL_0292, IL_029d, IL_02a9, IL_02b9, IL_02bd, IL_02c9, IL_02d3, IL_02e2, IL_02fe, IL_0314, IL_0320, IL_032a, IL_0341, IL_0361, IL_0365, IL_0371, IL_037b, IL_0385, IL_0410, IL_041a, IL_042a, IL_043a, IL_044a, IL_045a are reachable both inside and outside the pinned region starting at IL_0111. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		byte[] array = class86_0.method_10<byte>(intptr_0, 512);
		int num5 = default(int);
		byte referenceStorage = 0;
		ref byte reference = ref referenceStorage;
		BeaEngineDisasm struct31_ = default(BeaEngineDisasm);
		int num7 = default(int);
		BeaEngineDisasm @struct = default(BeaEngineDisasm);
		IntPtr intPtr = default(IntPtr);
		int num13 = default(int);
		byte[] array2 = default(byte[]);
		byte* ptr2 = default(byte*);
		while (true)
		{
			int num = 956025620;
			while (true)
			{
				uint num3;
				uint num2 = (num3 = (uint)(num ^ 0xDD03A59));
				int num11;
				ref byte* pByte_ = ref struct31_.pByte_0;
				int num14;
				int num8;
				int num9;
				byte[] array3;
				int num12;
				int num10;
				int num6;
				int num4;
				switch (num2 % 30)
				{
				case 28u:
					num11 = ((num5 == -1) ? (-1452599920) : (-1163030483));
					num = num11 ^ ((int)num3 * -29733925);
					continue;
				case 26u:
					reference = ref *(byte*)null;
					num = 2011256951;
					continue;
				case 25u:
					num = (int)((num3 * 284789633) ^ 0x6FB5EED3);
					continue;
				case 24u:
					pByte_ = ref struct31_.pByte_0;
					pByte_ += num7;
					num = 1651710050;
					continue;
				case 23u:
					@struct.pByte_0 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + num5;
					struct31_ = @struct;
					num = (int)(num3 * 1567968214) ^ -924991132;
					continue;
				case 22u:
					intPtr = intptr_0.smethod_8(num5 + 5 + num13);
					num14 = (((ulong)(long)intPtr >= (ulong)(long)gclass1_0.method_0()) ? 1866652416 : 1300935600);
					num = num14 ^ ((int)num3 * -1824422125);
					continue;
				case 20u:
					num5 = smethod_419(array, "L\u008DD\0\u0001", "xxx?x", 0);
					num = ((int)num3 * -2033959918) ^ 0x7089751;
					continue;
				case 19u:
					while (true)
					{
						IL_0109:
						fixed (byte* ptr = &array2[0])
						{
							num = 605535980;
							while (true)
							{
								num2 = (num3 = (uint)(num ^ 0xDD03A59));
								switch (num2 % 30)
								{
								case 26u:
									break;
								case 28u:
									num11 = ((num5 == -1) ? (-1452599920) : (-1163030483));
									num = num11 ^ ((int)num3 * -29733925);
									continue;
								case 25u:
									num = (int)((num3 * 284789633) ^ 0x6FB5EED3);
									continue;
								case 24u:
									pByte_ = ref struct31_.pByte_0;
									pByte_ += num7;
									num = 1651710050;
									continue;
								case 23u:
									@struct.pByte_0 = ptr + num5;
									struct31_ = @struct;
									num = (int)(num3 * 1567968214) ^ -924991132;
									continue;
								case 22u:
									intPtr = intptr_0.smethod_8(num5 + 5 + num13);
									num14 = (((ulong)(long)intPtr >= (ulong)(long)gclass1_0.method_0()) ? 1866652416 : 1300935600);
									num = num14 ^ ((int)num3 * -1824422125);
									continue;
								case 20u:
									num5 = smethod_419(array, "L\u008DD\0\u0001", "xxx?x", 0);
									num = ((int)num3 * -2033959918) ^ 0x7089751;
									continue;
								case 19u:
									goto IL_0109;
								case 18u:
									num8 = (num7 = smethod_224(ref struct31_));
									num9 = ((num8 <= 0) ? (-1380556961) : (-1929564752));
									num = num9 ^ ((int)num3 * -1469459848);
									continue;
								case 16u:
									array3 = (array2 = array);
									num = ((array3 != null) ? 1561284411 : 1837341141);
									continue;
								case 15u:
									num13 = BitConverter.ToInt32(array, num5 + 1);
									num = 1294299805;
									continue;
								case 13u:
									@struct = new BeaEngineDisasm
									{
										uint_1 = 64u
									};
									num = 1127138750;
									continue;
								case 12u:
									array = class86_0.method_10<byte>(intPtr, 48);
									num5 = smethod_419(array, "WATAUAVAWH\u0081ì\0\0\0\0H\u008B\u0005", "xxxxxxxxxxxx????xxx", 0);
									num = (PlatformInfo.bool_7 ? 1177915201 : 602401373);
									continue;
								case 11u:
									num = ((!(struct31_.struct27_0.method_0() == "call ")) ? 1480824025 : 1159400702);
									continue;
								case 10u:
									num = ((num5 == -1) ? 1788914984 : 2022509579);
									continue;
								case 9u:
									num5 = smethod_378(array, "A±\u0001", 0);
									num = ((int)num3 * -407541822) ^ 0x215460ED;
									continue;
								case 8u:
									num12 = ((array2.Length != 0) ? (-273900134) : (-138484547));
									num = num12 ^ (int)(num3 * 1269116660);
									continue;
								case 7u:
									num = ((struct31_.pByte_0 >= ptr2) ? 2132406143 : 57255653);
									continue;
								case 6u:
									num10 = ((num5 != -1) ? 1069380215 : 980083529);
									num = num10 ^ (int)(num3 * 1659249783);
									continue;
								case 5u:
									ptr2 = ptr + array.Length;
									num = ((int)num3 * -571244627) ^ 0x23C0A333;
									continue;
								case 3u:
									num6 = (((ulong)(long)intPtr < (ulong)((long)intPtr + gclass1_0.method_4())) ? 928936981 : 1819509570);
									num = num6 ^ ((int)num3 * -1828000378);
									continue;
								case 2u:
									goto end_IL_0109;
								case 1u:
									num5 = (int)(struct31_.pByte_0 - ptr);
									num = (int)(num3 * 294035196) ^ -1187565285;
									continue;
								case 0u:
									num4 = ((num5 == -1) ? 2114420497 : 1045825226);
									num = num4 ^ (int)(num3 * 1032595841);
									continue;
								case 27u:
									num = 956025620;
									continue;
								case 4u:
									throw new MissingMethodException("Unable to find call to LdrpLoadDll function inside LdrLoadDll.");
								case 17u:
									throw new MissingMethodException("The function thought to be LdrpLoadDll is outside ntdll.dll.");
								case 21u:
									throw new MissingMethodException("Unable to verify the guessed function is LdrpLoadDll.");
								case 29u:
									throw new InvalidOperationException("Unable to find signature for LdrpLoadDll.");
								default:
									return intPtr;
								}
								break;
							}
						}
						goto case 26u;
						continue;
						end_IL_0109:
						break;
					}
					goto case 2u;
				case 18u:
					num8 = (num7 = smethod_224(ref struct31_));
					num9 = ((num8 <= 0) ? (-1380556961) : (-1929564752));
					num = num9 ^ ((int)num3 * -1469459848);
					continue;
				case 16u:
					array3 = (array2 = array);
					num = ((array3 != null) ? 1561284411 : 1837341141);
					continue;
				case 15u:
					num13 = BitConverter.ToInt32(array, num5 + 1);
					num = 1294299805;
					continue;
				case 13u:
					@struct = new BeaEngineDisasm
					{
						uint_1 = 64u
					};
					num = 1127138750;
					continue;
				case 12u:
					array = class86_0.method_10<byte>(intPtr, 48);
					num5 = smethod_419(array, "WATAUAVAWH\u0081ì\0\0\0\0H\u008B\u0005", "xxxxxxxxxxxx????xxx", 0);
					num = (PlatformInfo.bool_7 ? 1177915201 : 602401373);
					continue;
				case 11u:
					num = ((!(struct31_.struct27_0.method_0() == "call ")) ? 1480824025 : 1159400702);
					continue;
				case 10u:
					num = ((num5 == -1) ? 1788914984 : 2022509579);
					continue;
				case 9u:
					num5 = smethod_378(array, "A±\u0001", 0);
					num = ((int)num3 * -407541822) ^ 0x215460ED;
					continue;
				case 8u:
					num12 = ((array2.Length != 0) ? (-273900134) : (-138484547));
					num = num12 ^ (int)(num3 * 1269116660);
					continue;
				case 7u:
					num = ((struct31_.pByte_0 >= ptr2) ? 2132406143 : 57255653);
					continue;
				case 6u:
					num10 = ((num5 != -1) ? 1069380215 : 980083529);
					num = num10 ^ (int)(num3 * 1659249783);
					continue;
				case 5u:
					ptr2 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + array.Length;
					num = ((int)num3 * -571244627) ^ 0x23C0A333;
					continue;
				case 3u:
					num6 = (((ulong)(long)intPtr < (ulong)((long)intPtr + gclass1_0.method_4())) ? 928936981 : 1819509570);
					num = num6 ^ ((int)num3 * -1828000378);
					continue;
				case 2u:
					reference = ref *(byte*)null;
					num = 605535980;
					continue;
				case 1u:
					num5 = (int)(struct31_.pByte_0 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
					num = (int)(num3 * 294035196) ^ -1187565285;
					continue;
				case 0u:
					num4 = ((num5 == -1) ? 2114420497 : 1045825226);
					num = num4 ^ (int)(num3 * 1032595841);
					continue;
				case 27u:
					break;
				case 4u:
					throw new MissingMethodException("Unable to find call to LdrpLoadDll function inside LdrLoadDll.");
				case 17u:
					throw new MissingMethodException("The function thought to be LdrpLoadDll is outside ntdll.dll.");
				case 21u:
					throw new MissingMethodException("Unable to verify the guessed function is LdrpLoadDll.");
				case 29u:
					throw new InvalidOperationException("Unable to find signature for LdrpLoadDll.");
				default:
					return intPtr;
				}
				break;
			}
		}
	}

	internal static Peb64 smethod_369(RemoteProcess gclass2_0)
	{
		if (!PlatformInfo.bool_0)
		{
			goto IL_0086;
		}
		goto IL_00e8;
		IL_0086:
		int num = -1220482538;
		goto IL_008b;
		IL_008b:
		Peb64 @class = default(Peb64);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -124340677)) % 8)
			{
			case 5u:
				num = ((!smethod_427(gclass2_0)) ? 1781939524 : 1950522238) ^ ((int)num2 * -1960146539);
				continue;
			case 2u:
				num = ((smethod_270(@class) != IntPtr.Zero) ? 1353923320 : 1682319214) ^ (int)(num2 * 160012274);
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_00bc;
			case 6u:
				goto IL_00e8;
			case 1u:
				return null;
			case 4u:
				return null;
			default:
				return gclass2_0.TrackResource(@class);
			}
			break;
		}
		goto IL_0086;
		IL_00bc:
		Peb64 class2 = new Peb64(gclass2_0);
		goto IL_00d3;
		IL_00d3:
		@class = class2;
		num = ((!smethod_281(@class)) ? (-766285094) : (-1197472239));
		goto IL_008b;
		IL_00e8:
		if (gclass2_0.Handle != IntPtr.Zero)
		{
			class2 = new Peb64(gclass2_0, gclass2_0.Handle);
			goto IL_00d3;
		}
		num = -1979089664;
		goto IL_008b;
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
		mainForm.processIconPictureBox.BackgroundImage = null;
		previousImage?.Dispose();

		mainForm.selectedProcess = gclass2_0;
		mainForm.processDescriptionLabel.Text = UiText.Get("Main.NoProcessSelected");

		if (gclass2_0 == null)
		{
			mainForm.processIconPictureBox.Cursor = Cursors.Default;
			mainForm.injectButton.Enabled = false;
			return;
		}

		mainForm.processIconPictureBox.Cursor = Cursors.Hand;
		try
		{
			using (Icon icon = smethod_11(gclass2_0.FilePath, IconSize.const_1))
			{
				mainForm.processIconPictureBox.BackgroundImage = icon?.ToBitmap();
			}
		}
		catch
		{
			mainForm.processIconPictureBox.BackgroundImage = null;
		}

		string description = UiText.Get("Main.NoDescription");
		try
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(gclass2_0.FilePath);
			if (!string.IsNullOrEmpty(versionInfo.FileDescription))
			{
				description = versionInfo.FileDescription;
			}
		}
		catch
		{
		}

		if (description.Length > 50)
		{
			description = description.Substring(0, 50) + "...";
		}

		mainForm.processDescriptionLabel.Text = UiText.Format("Main.ProcessDetails", description, gclass2_0.ProcessId);
		ApplicationSettings.Current.ProcessName = mainForm.processNameTextBox.Text;
		ApplicationSettings.Save();
		mainForm.injectButton.Enabled = !ApplicationSettings.Current.Options.AutoInject;
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
		IntPtr intptr_1 = default(IntPtr);
		NativeTypes.Struct47 struct47_ = default(NativeTypes.Struct47);
		while (true)
		{
			int num2 = 1543152558;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x5A64279)) % 9)
				{
				case 8u:
					intptr_1 = intptr_0;
					num2 = (int)((num3 * 1838851553) ^ 0x522BBBD1);
					continue;
				case 6u:
					num2 = (((struct47_.enum34_1 & NativeTypes.Enum34.flag_1) == 0) ? 2139404433 : 602391557) ^ ((int)num3 * -761333466);
					continue;
				case 5u:
					num2 = (((struct47_.enum34_1 & NativeTypes.Enum34.flag_6) != 0) ? (-1068121381) : (-1208183802)) ^ ((int)num3 * -360828908);
					continue;
				case 4u:
					num2 = (((struct47_.enum34_1 & NativeTypes.Enum34.flag_5) == 0) ? 956824082 : 1639299719);
					continue;
				case 3u:
					num += struct47_.intptr_2.ToInt64();
					intptr_1 = struct47_.intptr_0.smethod_10(struct47_.intptr_2);
					num2 = 1638116134;
					continue;
				case 1u:
					num2 = ((NativeTypes.VirtualQueryEx(stream0_0.intptr_0, intptr_1, out struct47_, (uint)NativeTypes.int_0) == 0) ? 2108600720 : 1037485587);
					continue;
				case 0u:
					num2 = (((struct47_.enum34_1 & NativeTypes.Enum34.flag_2) == 0) ? (-1441023172) : (-396243303)) ^ (int)(num3 * 1725450826);
					continue;
				case 2u:
					break;
				default:
					return num;
				}
				break;
			}
		}
	}

	internal static void smethod_411(RemoteProcess gclass2_0)
	{
		IntPtr intPtr = smethod_250(gclass2_0, NativeTypes.Enum32.flag_1, bool_0: false, gclass2_0.ProcessId);
		while (true)
		{
			int num = 459084344;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3033F39D)) % 6)
				{
				case 4u:
				{
					bool num3 = TerminateProcess(intPtr, -1);
					smethod_27(gclass2_0, intPtr);
					num = ((!num3) ? 470475232 : 1793443999);
					continue;
				}
				case 3u:
					num = ((intPtr == IntPtr.Zero) ? 596482349 : 1114648150) ^ ((int)num2 * -1115381483);
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					throw new Win32Exception("TerminateProcess returned FALSE.");
				case 5u:
					throw new InvalidOperationException("OpenProcess returned NULL.");
				case 2u:
					return;
				}
				break;
			}
		}
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
