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

	internal static void smethod_251(int int_0, byte[] byte_0, int int_1, DeflateDecoder.Class181 class181_0)
	{
		if (class181_0.int_0 < class181_0.int_1)
		{
			goto IL_0127;
		}
		goto IL_0181;
		IL_0127:
		int num = -204073274;
		goto IL_012c;
		IL_012c:
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -833974792)) % 13)
			{
			case 12u:
				num = ((int_1 <= num3) ? 1851636686 : 783636969) ^ (int)(num2 * 1456899440);
				continue;
			case 8u:
				break;
			case 7u:
				class181_0.byte_0 = byte_0;
				num = -1578514549;
				continue;
			case 6u:
				num = ((num3 <= byte_0.Length) ? (-979265642) : (-594132859)) ^ (int)(num2 * 984425746);
				continue;
			case 5u:
				class181_0.int_2 += 8;
				num = (int)(num2 * 2087814200) ^ -249297488;
				continue;
			case 4u:
				class181_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class181_0.int_2);
				num = ((int)num2 * -69655551) ^ -1029613726;
				continue;
			case 3u:
				class181_0.int_0 = int_1;
				num = (int)((num2 * 1620944909) ^ 0x7F9C05D1);
				continue;
			case 1u:
				class181_0.int_1 = num3;
				num = ((int)num2 * -643396109) ^ 0x24995E13;
				continue;
			case 0u:
				goto end_IL_012c;
			default:
				return;
			case 2u:
				goto IL_0181;
			case 9u:
				throw new ArgumentOutOfRangeException();
			case 10u:
				throw new InvalidOperationException();
			case 11u:
				return;
			}
			num = (((int_0 & 1) != 0) ? (-828817170) : (-1415441648));
			continue;
			end_IL_012c:
			break;
		}
		goto IL_0127;
		IL_0181:
		num3 = int_1 + int_0;
		num = ((0 <= int_1) ? (-433463550) : (-1338411383));
		goto IL_012c;
	}

	internal static void smethod_254(FileDropMessageFilter class10_0, Message message_0)
	{
		StringBuilder stringBuilder = new StringBuilder(260);
		uint num3 = default(uint);
		FileDropMessageFilter.Struct5 struct5_ = default(FileDropMessageFilter.Struct5);
		List<string> list = default(List<string>);
		uint num4 = default(uint);
		FileDropEventArgs e = default(FileDropEventArgs);
		while (true)
		{
			int num = -14438100;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -723138968)) % 12)
				{
				case 11u:
					num3++;
					num = -1126807068;
					continue;
				case 10u:
					DragQueryPoint(message_0.WParam, out struct5_);
					DragFinish(message_0.WParam);
					num = (int)(num2 * 641475378) ^ -80843295;
					continue;
				case 9u:
					list = new List<string>();
					num = ((int)num2 * -1516380883) ^ -2081603339;
					continue;
				case 8u:
					num4 = DragQueryFile(message_0.WParam, uint.MaxValue, stringBuilder, 0u);
					num = ((int)num2 * -679041813) ^ 0x3D181CCD;
					continue;
				case 6u:
					num = ((DragQueryFile(message_0.WParam, num3, stringBuilder, Convert.ToUInt32(stringBuilder.Capacity) * 2) != 0) ? (-1957786797) : (-260167221));
					continue;
				case 5u:
				{
					FileDropEventArgs eventArgs = new FileDropEventArgs();
					eventArgs.method_0(message_0.HWnd);
					eventArgs.method_2(list);
					eventArgs.method_3(struct5_.int_0);
					eventArgs.method_4(struct5_.int_1);
					e = eventArgs;
					num = ((class10_0.eventHandler_0 == null) ? 197205043 : 367233280) ^ ((int)num2 * -1478029599);
					continue;
				}
				case 4u:
					num3 = 0u;
					num = ((int)num2 * -2020196420) ^ -669305084;
					continue;
				case 3u:
					list.Add(stringBuilder.ToString());
					num = ((int)num2 * -1410647425) ^ 0x63DD878E;
					continue;
				case 1u:
					class10_0.eventHandler_0(class10_0, e);
					num = (int)((num2 * 319709075) ^ 0x4D37D401);
					continue;
				case 0u:
					num = ((num3 > num4 - 1) ? (-959252862) : (-1034118814));
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal static bool smethod_262(ResourceDirectory class166_0, long long_0)
	{
		if (!smethod_282(class166_0, long_0, 0))
		{
			return false;
		}
		class166_0.class5_0.BaseStream.Position = class166_0.long_0 + long_0;
		return true;
	}

	internal static int smethod_265(int int_0, DeflateDecoder.Class182 class182_0, int int_1, byte[] byte_0)
	{
		int num = class182_0.int_0;
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = 674811611;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x6A97B667)) % 15)
				{
				case 14u:
					int_1 = num;
					num2 = ((int)num3 * -1107127011) ^ -1828353081;
					continue;
				case 13u:
					num2 = ((class182_0.int_1 >= 0) ? (-512031932) : (-1831976275)) ^ (int)(num3 * 942018344);
					continue;
				case 11u:
					num2 = (int)((num3 * 1325297385) ^ 0x29575F1D);
					continue;
				case 9u:
					num2 = ((int_1 > class182_0.int_1) ? 221782340 : 1903097625) ^ (int)(num3 * 820606100);
					continue;
				case 8u:
					num4 = int_1;
					num5 = int_1 - num;
					num2 = 493256555;
					continue;
				case 7u:
					num = (class182_0.int_0 - class182_0.int_1 + int_1) & 0x7FFF;
					num2 = 72709629;
					continue;
				case 6u:
					int_0 += num5;
					num2 = (int)(num3 * 890364682) ^ -1354569738;
					continue;
				case 5u:
					int_1 = class182_0.int_1;
					num2 = (int)((num3 * 365104785) ^ 0x225989C4);
					continue;
				case 4u:
					class182_0.int_1 -= num4;
					num2 = (int)(num3 * 1309442035) ^ -1860903927;
					continue;
				case 3u:
					num2 = ((num5 > 0) ? (-57948017) : (-188750426)) ^ (int)(num3 * 1354547983);
					continue;
				case 2u:
					Array.Copy(class182_0.byte_0, 32768 - num5, byte_0, int_0, num5);
					num2 = (int)(num3 * 1675330505) ^ -812816721;
					continue;
				case 1u:
					Array.Copy(class182_0.byte_0, num - int_1, byte_0, int_0, int_1);
					num2 = 1150515527;
					continue;
				case 0u:
					break;
				case 10u:
					throw new InvalidOperationException();
				default:
					return num4;
				}
				break;
			}
		}
	}

	internal static void smethod_267(Encoding encoding_0, PeScrambler gclass4_0, string string_0)
	{
		byte[] bytes = encoding_0.GetBytes(string_0);
		byte[] bytes2 = encoding_0.GetBytes(smethod_275(string_0.Length));
		smethod_143(bytes2, bytes, gclass4_0);
	}

	internal static string smethod_268()
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		while (true)
		{
			int num = 982721856;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x548442D9)) % 4)
				{
				case 1u:
					num3 = ((GetWindowsDirectory(stringBuilder, stringBuilder.Capacity) == 0) ? 1778679026 : 1984353705);
					goto IL_0031;
				case 2u:
					break;
				default:
					return Environment.GetEnvironmentVariable("windir");
				case 3u:
					return stringBuilder.ToString();
				}
				break;
				IL_0031:
				num = num3 ^ (int)(num2 * 410135563);
			}
		}
	}

	internal static IntPtr smethod_270(RemotePeb class117_0)
	{
		return class117_0.method_17();
	}

	internal static bool smethod_272()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	internal static string smethod_273(PeScrambler gclass4_0)
	{
		StringBuilder stringBuilder = new StringBuilder(".");
		int num3 = default(int);
		while (true)
		{
			int num = -539653346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -770911694)) % 5)
				{
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1725949177) ^ 0x3C71706C;
					continue;
				case 2u:
					num = ((num3 >= gclass4_0.random_0.Next(4, 8)) ? (-1989363767) : (-82926332));
					continue;
				case 1u:
					stringBuilder.Append("abcdefghijklmnopqrstuvwxyz0123456789"[gclass4_0.random_0.Next("abcdefghijklmnopqrstuvwxyz0123456789".Length)]);
					num3++;
					num = -2102893480;
					continue;
				case 0u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	internal static string smethod_275(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num3 = default(int);
		while (true)
		{
			int num = -975845276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -460401423)) % 5)
				{
				case 3u:
					num = ((num3 < int_0) ? (-1321583561) : (-1041946180));
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -557386287) ^ 0x55933A7B;
					continue;
				case 0u:
				{
					char c = "abcdefghijklmnopqrstuvwxyz0123456789"[PlatformInfo.random_0.Next("abcdefghijklmnopqrstuvwxyz0123456789".Length)];
					stringBuilder.Append((PlatformInfo.random_0.Next(2) == 1) ? c : char.ToUpper(c));
					num3++;
					num = -345385762;
					continue;
				}
				case 2u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	internal static PlatformInfo.Delegate47 smethod_276(int int_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("Memcpy", typeof(void), new Type[3]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(uint)
		}, typeof(PlatformInfo));
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		if (int_0 != -1)
		{
			iLGenerator.Emit(OpCodes.Unaligned, (byte)int_0);
		}
		iLGenerator.Emit(OpCodes.Cpblk);
		iLGenerator.Emit(OpCodes.Ret);
		return (PlatformInfo.Delegate47)dynamicMethod.CreateDelegate(typeof(PlatformInfo.Delegate47));
	}

	internal static uint smethod_277(InvertedFunctionTable32 class112_0)
	{
		return class112_0.method_21<uint>(1);
	}

	internal static bool smethod_282(ResourceDirectory class166_0, long long_0, int int_0)
	{
		if (long_0 >= 0L)
		{
			while (true)
			{
				int num = 1141989307;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x700887EE)) % 4)
					{
					case 1u:
						num = ((long_0 + int_0 < long_0) ? 1171330542 : 179811636) ^ (int)(num2 * 1544526648);
						continue;
					case 3u:
						break;
					default:
						return (uint)(long_0 + int_0) <= class166_0.uint_0;
					case 0u:
						goto end_IL_0055;
					}
					break;
				}
				continue;
				end_IL_0055:
				break;
			}
		}
		return false;
	}

	internal static bool smethod_295(int int_0, ushort ushort_0, int int_1, int int_2)
	{
		if (GetProcAddress(GetModuleHandle("ntdll.dll"), "RtlGetVersion") != IntPtr.Zero)
		{
			goto IL_011c;
		}
		goto IL_02f7;
		IL_011c:
		int num = 1584740921;
		goto IL_027c;
		IL_027c:
		NativeTypes.Struct38 struct38_ = default(NativeTypes.Struct38);
		NativeTypes.Struct38 struct38_2 = default(NativeTypes.Struct38);
		NativeTypes.Struct38 @struct = default(NativeTypes.Struct38);
		ulong ulong_ = default(ulong);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6047B3AD)) % 26)
			{
			case 25u:
				break;
			case 24u:
				num = ((struct38_.int_1 > int_1) ? (-834489083) : (-1423346720)) ^ ((int)num2 * -1727269489);
				continue;
			case 23u:
				struct38_2.int_1 = int_1;
				num = ((int)num2 * -1418537763) ^ 0x6240583A;
				continue;
			case 22u:
				struct38_2 = @struct;
				num = ((int)num2 * -958104869) ^ -2031607089;
				continue;
			case 21u:
				struct38_2.int_3 = int_2;
				num = (int)(num2 * 1595617324) ^ -478282882;
				continue;
			case 20u:
				@struct = new NativeTypes.Struct38
				{
					int_0 = typeof(NativeTypes.Struct38).smethod_7()
				};
				num = ((int)num2 * -1851377860) ^ 0x27533A49;
				continue;
			case 18u:
				struct38_2.ushort_0 = ushort_0;
				num = (int)((num2 * 692479553) ^ 0xE6EDAE0);
				continue;
			case 17u:
				goto end_IL_027c;
			case 16u:
				struct38_ = @struct;
				num = ((RtlGetVersion(ref struct38_) != 0) ? (-984489119) : (-1988292229)) ^ (int)(num2 * 1207908146);
				continue;
			case 14u:
				struct38_2.int_2 = int_0;
				num = ((int)num2 * -1614048655) ^ 0x68F4B389;
				continue;
			case 13u:
				goto IL_0171;
			case 10u:
				num = ((struct38_.int_3 > int_2) ? (-631404816) : (-1351097330)) ^ ((int)num2 * -1410281571);
				continue;
			case 8u:
				ulong_ = VerSetConditionMask(VerSetConditionMask(VerSetConditionMask(0uL, 2u, 3), 1u, 3), 32u, 3);
				num = (int)(num2 * 1166176452) ^ -413852372;
				continue;
			case 7u:
				goto IL_01f7;
			case 4u:
				goto IL_0219;
			case 3u:
				num = ((int_2 != -1) ? 1147933632 : 619897540) ^ ((int)num2 * -697459862);
				continue;
			case 1u:
				goto IL_025c;
			case 6u:
				goto IL_02f7;
			case 0u:
				return true;
			case 2u:
				return false;
			default:
				return VerifyVersionInfo(ref struct38_2, 35u, ulong_);
			case 9u:
				return false;
			case 11u:
				return false;
			case 12u:
				return true;
			case 15u:
				return true;
			case 19u:
				return struct38_.ushort_0 >= ushort_0;
			}
			num = ((struct38_.int_2 > int_0) ? 391818675 : 403618096);
			continue;
			IL_025c:
			num = ((struct38_.int_2 < int_0) ? 1297410717 : 226007735);
			continue;
			IL_01f7:
			num = ((struct38_.int_3 >= int_2) ? 108067654 : 1630356440);
			continue;
			IL_0171:
			num = ((struct38_.int_1 < int_1) ? 1624885040 : 151568648);
			continue;
			IL_0219:
			num = ((int_2 != -1) ? 1847967105 : 108067654);
			continue;
			end_IL_027c:
			break;
		}
		goto IL_011c;
		IL_02f7:
		@struct = new NativeTypes.Struct38
		{
			int_0 = typeof(NativeTypes.Struct38).smethod_7()
		};
		num = 153685219;
		goto IL_027c;
	}

	internal static void SetModulePath(MainForm.ModuleRow class21_0, string string_0)
	{
		class21_0.Entry.Path = string_0;
	}

	internal static bool smethod_305(DeflateDecoder.Class184 class184_0, DeflateDecoder.Class181 class181_0)
	{
		int num3 = default(int);
		int int_2 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int int_ = class184_0.int_2;
			while (true)
			{
				int num = -205037803;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1464743051)) % 49)
					{
					case 48u:
						class184_0.int_8 = 0;
						class184_0.int_2 = 3;
						num = ((int)num2 * -1531072887) ^ -1463986808;
						continue;
					case 47u:
						num = (int)((num2 * 1370971646) ^ 0x2D5FB54B);
						continue;
					case 46u:
						class184_0.int_7 = num3 - 16;
						class184_0.int_2 = 5;
						num = -802068148;
						continue;
					case 45u:
						class184_0.int_2 = 4;
						num = ((int)num2 * -1606276774) ^ -825198848;
						continue;
					case 44u:
						class184_0.class183_0 = new DeflateDecoder.Class183(class184_0.byte_0);
						class184_0.byte_0 = null;
						num = ((int)num2 * -659417241) ^ -1699470478;
						continue;
					case 43u:
						class184_0.int_8++;
						num = ((int)num2 * -28701636) ^ -1560173628;
						continue;
					case 41u:
						smethod_396(class181_0, 3);
						num = -753151462;
						continue;
					case 40u:
						break;
					case 39u:
						smethod_396(class181_0, int_2);
						num = -1666420432;
						continue;
					case 38u:
						goto IL_010f;
					case 37u:
						class184_0.byte_0[DeflateDecoder.Class184.int_9[class184_0.int_8]] = (byte)num4;
						num = (int)((num2 * 1248976421) ^ 0x1D1ECE63);
						continue;
					case 35u:
						class184_0.byte_1 = new byte[class184_0.int_6];
						num = (int)((num2 * 501187212) ^ 0x6266AEA2);
						continue;
					case 34u:
						goto IL_01ac;
					case 33u:
						goto IL_01d6;
					case 32u:
						class184_0.int_3 += 257;
						smethod_396(class181_0, 5);
						class184_0.int_2 = 1;
						num = -567893540;
						continue;
					case 31u:
						class184_0.int_5 += 4;
						num = -36548358;
						continue;
					case 30u:
						goto IL_023c;
					case 28u:
						class184_0.int_8 = 0;
						num = (int)((num2 * 50099360) ^ 0x350CB99C);
						continue;
					case 27u:
						goto IL_0277;
					case 26u:
						smethod_396(class181_0, 5);
						class184_0.int_6 = class184_0.int_3 + class184_0.int_4;
						num = (int)((num2 * 1616270737) ^ 0x20CFF787);
						continue;
					case 25u:
						num5 = smethod_60(class181_0, int_2);
						num = ((int)num2 * -884389621) ^ -2041200537;
						continue;
					case 24u:
						class184_0.byte_2 = 0;
						num = (int)(num2 * 1105868822) ^ -1519478838;
						continue;
					case 23u:
						num = ((class184_0.int_4 >= 0) ? 270235194 : 478520174) ^ ((int)num2 * -1444950561);
						continue;
					case 21u:
						switch (int_)
						{
						case 0:
							break;
						case 3:
							goto IL_01ac;
						case 4:
							goto IL_0277;
						default:
							goto IL_0355;
						case 1:
							goto IL_0368;
						case 2:
							goto IL_037f;
						case 5:
							goto IL_03b1;
						}
						break;
					case 19u:
						goto IL_0368;
					case 12u:
						goto IL_037f;
					case 10u:
						goto IL_03b1;
					case 20u:
						num = (int)(num2 * 928060664) ^ -2010697741;
						continue;
					case 17u:
						num = ((num5 < 0) ? 459182128 : 285255978) ^ (int)(num2 * 349434518);
						continue;
					case 16u:
						goto IL_0404;
					case 15u:
						class184_0.byte_1[class184_0.int_8++] = class184_0.byte_2;
						num = -1084085445;
						continue;
					case 13u:
						num5 += DeflateDecoder.Class184.int_0[class184_0.int_7];
						num = ((int)num2 * -1733238663) ^ 0x54D14920;
						continue;
					case 8u:
						class184_0.int_2 = 4;
						num = -1848980503;
						continue;
					case 6u:
						num = ((num3 < 0) ? 658194272 : 283353340) ^ (int)(num2 * 448235678);
						continue;
					case 5u:
						class184_0.int_2 = 2;
						num = (int)((num2 * 518695990) ^ 0x3C2B406C);
						continue;
					case 4u:
						num = ((class184_0.int_8 == class184_0.int_6) ? 1186420544 : 1116382683) ^ ((int)num2 * -1442392868);
						continue;
					case 3u:
						smethod_396(class181_0, 4);
						class184_0.byte_0 = new byte[19];
						num = ((int)num2 * -1047420500) ^ 0x163CF0E1;
						continue;
					case 2u:
						class184_0.int_4++;
						num = -1120050513;
						continue;
					case 14u:
						goto end_IL_052d;
					default:
						goto end_IL_0604;
					case 0u:
						return true;
					case 1u:
						return false;
					case 7u:
						return false;
					case 9u:
						return false;
					case 18u:
						return false;
					case 22u:
						return false;
					case 36u:
						return true;
					case 42u:
						{
							return false;
						}
						IL_03b1:
						int_2 = DeflateDecoder.Class184.int_1[class184_0.int_7];
						num = -1281597031;
						continue;
						IL_0368:
						class184_0.int_4 = smethod_60(class181_0, 5);
						num = -873981485;
						continue;
						IL_0355:
						num = ((int)num2 * -1158835886) ^ 0x47D3B055;
						continue;
					}
					class184_0.int_3 = smethod_60(class181_0, 5);
					num = ((class184_0.int_3 >= 0) ? (-789277596) : (-1264944343));
					continue;
					IL_0404:
					num4 = smethod_60(class181_0, 3);
					num = ((num4 < 0) ? (-242503294) : (-1761383781));
					continue;
					IL_023c:
					num = ((num3 < 17) ? (-249196530) : (-1539441261));
					continue;
					IL_01ac:
					num = ((class184_0.int_8 < class184_0.int_5) ? (-1885650475) : (-1469767028));
					continue;
					IL_037f:
					class184_0.int_5 = smethod_60(class181_0, 4);
					num = ((class184_0.int_5 < 0) ? (-157109144) : (-1721851069));
					continue;
					IL_01d6:
					num = ((num5-- > 0) ? (-415170131) : (-1890786856));
					continue;
					IL_010f:
					class184_0.byte_1[class184_0.int_8++] = (class184_0.byte_2 = (byte)num3);
					num = ((class184_0.int_8 != class184_0.int_6) ? (-10941957) : (-515204015));
					continue;
					IL_0277:
					num = ((((num3 = smethod_96(class184_0.class183_0, class181_0)) & -16) == 0) ? (-1303576432) : (-194562666));
					continue;
					end_IL_052d:
					break;
				}
				continue;
				end_IL_0604:
				break;
			}
		}
	}

	internal static uint smethod_314(ResourceDirectory class166_0)
	{
		return class166_0.class5_0.ReadUInt32();
	}

	internal static RemotePlatformStructure.RemoteFieldLayout smethod_316(Type type_0)
	{
		int int_ = smethod_245(type_0);
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			int_0 = int_
		};
	}

	internal static string smethod_317()
	{
		string s = ApplicationSettings.DefaultPath;
		char[] array = Convert.ToBase64String(Encoding.UTF8.GetBytes(s)).ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	internal static short smethod_322(int int_0)
	{
		return (short)((DeflateDecoder.Class185.byte_0[int_0 & 0xF] << 12) | (DeflateDecoder.Class185.byte_0[(int_0 >> 4) & 0xF] << 8) | (DeflateDecoder.Class185.byte_0[(int_0 >> 8) & 0xF] << 4) | DeflateDecoder.Class185.byte_0[int_0 >> 12]);
	}

	internal static IntPtr smethod_323(InvertedFunctionTableEntry32 class113_0)
	{
		return (IntPtr)class113_0.method_21<uint>(1);
	}

	internal static void smethod_339(CookieAwareWebClient class20_0, WebResponse webResponse_0)
	{
		HttpWebResponse httpWebResponse = webResponse_0 as HttpWebResponse;
		if (httpWebResponse == null)
		{
			goto IL_000a;
		}
		goto IL_002e;
		IL_000a:
		int num = 387608055;
		goto IL_000f;
		IL_000f:
		CookieCollection cookies = default(CookieCollection);
		switch ((uint)(num ^ 0x477F8669) % 4u)
		{
		case 3u:
			break;
		case 1u:
			goto IL_002e;
		default:
			class20_0.method_0().Add(cookies);
			return;
		case 2u:
			return;
		}
		goto IL_000a;
		IL_002e:
		cookies = httpWebResponse.Cookies;
		num = 1216624305;
		goto IL_000f;
	}

	internal static bool smethod_340(string string_0, int int_0, byte[] byte_0)
	{
		if (int_0 + string_0.Length > byte_0.Length)
		{
			goto IL_0010;
		}
		goto IL_0098;
		IL_0010:
		int num = 1936663603;
		goto IL_0069;
		IL_0069:
		int num2 = default(int);
		while (true)
		{
			switch ((uint)(num ^ 0x5F7229D) % 8u)
			{
			case 5u:
				break;
			case 3u:
				num2++;
				num = 356993700;
				continue;
			case 1u:
				goto IL_0022;
			case 0u:
				goto IL_0044;
			case 7u:
				goto IL_0098;
			default:
				return true;
			case 4u:
				return false;
			case 6u:
				return false;
			}
			break;
			IL_0044:
			num = ((byte_0[int_0 + num2] == string_0[num2]) ? 426322790 : 1810114433);
			continue;
			IL_0022:
			num = ((num2 >= string_0.Length) ? 1015790159 : 1957325589);
		}
		goto IL_0010;
		IL_0098:
		num2 = 0;
		num = 356993700;
		goto IL_0069;
	}

	internal static void smethod_341()
	{
		smethod_34("SeDebugPrivilege");
	}

	internal unsafe static int smethod_343(byte[] byte_0, string string_0, int int_0)
	{
		return IndexOfByteString(byte_0, string_0, int_0);
#if false
		//The blocks IL_0015, IL_0025, IL_002b, IL_0037, IL_0041, IL_0050, IL_0070, IL_0072, IL_007c, IL_0092, IL_0097, IL_00a3, IL_00ad, IL_00bc, IL_00e7, IL_00f1, IL_00f7, IL_0103, IL_0113, IL_012e, IL_0136, IL_0142, IL_0152, IL_0158, IL_0164, IL_0174, IL_0183, IL_0186, IL_019a, IL_019d, IL_01a9, IL_01b3, IL_01bf, IL_01ca, IL_01ef, IL_0200, IL_0273, IL_0282, IL_028c, IL_0293, IL_029d are reachable both inside and outside the pinned region starting at IL_00dc. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0015, IL_0025, IL_002b, IL_0037, IL_0041, IL_0050, IL_007c, IL_0092, IL_0097, IL_00a3, IL_00ad, IL_00bc, IL_00e7, IL_00f1, IL_00f7, IL_0103, IL_0113, IL_012e, IL_0136, IL_0142, IL_0152, IL_0158, IL_0164, IL_0186, IL_019a, IL_019d, IL_01a9, IL_01b3, IL_01bf, IL_01ca, IL_01ef, IL_0200, IL_0273, IL_0282, IL_028c, IL_0293, IL_029d are reachable both inside and outside the pinned region starting at IL_0071. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if (int_0 + string_0.Length > byte_0.Length)
		{
			goto IL_00e7;
		}
		goto IL_0282;
		IL_00e7:
		int num = -1537406695;
		goto IL_0200;
		IL_0200:
		byte* ptr3 = default(byte*);
		byte* ptr7 = default(byte*);
		ref byte reference = default(ref byte);
		char* ptr6 = default(char*);
		byte[] array = default(byte[]);
		byte* ptr = default(byte*);
		byte* ptr2 = default(byte*);
		byte* ptr4 = default(byte*);
		byte* ptr5 = default(byte*);
		byte[] array2;
		while (true)
		{
			uint num3;
			uint num2 = (num3 = (uint)(num ^ -759416851));
			int num5;
			int num6;
			int num4;
			switch (num2 % 24)
			{
			case 23u:
				num5 = ((ptr3 == ptr7) ? 1832194556 : 1376663040);
				num = num5 ^ (int)(num3 * 638597496);
				continue;
			case 22u:
				num = ((int)num3 * -183013126) ^ -1743205869;
				continue;
			case 21u:
				reference = ref *(byte*)null;
				num = -1872760679;
				continue;
			case 20u:
				text = string_0;
				num = -751094330;
				continue;
			case 19u:
				ptr6 = (char*)(nint)text;
				num = (int)(num3 * 647211380) ^ -1127220318;
				continue;
			case 18u:
				num6 = ((array.Length == 0) ? 1128946194 : 1830948792);
				num = num6 ^ ((int)num3 * -1120293511);
				continue;
			case 17u:
				ptr++;
				num = (int)(num3 * 1675944968) ^ -1857139166;
				continue;
			case 15u:
				while (true)
				{
					IL_00d5:
					fixed (byte* ptr8 = &array[0])
					{
						num = -1872760679;
						while (true)
						{
							num2 = (num3 = (uint)(num ^ -759416851));
							switch (num2 % 24)
							{
							case 21u:
								break;
							case 23u:
								num5 = ((ptr3 == ptr7) ? 1832194556 : 1376663040);
								num = num5 ^ (int)(num3 * 638597496);
								continue;
							case 22u:
								num = ((int)num3 * -183013126) ^ -1743205869;
								continue;
							case 20u:
								while (true)
								{
									IL_0070:
									fixed (string text = string_0)
									{
										num = -751094330;
										while (true)
										{
											num2 = (num3 = (uint)(num ^ -759416851));
											switch (num2 % 24)
											{
											case 21u:
												break;
											case 23u:
												num5 = ((ptr3 == ptr7) ? 1832194556 : 1376663040);
												num = num5 ^ (int)(num3 * 638597496);
												continue;
											case 22u:
												num = ((int)num3 * -183013126) ^ -1743205869;
												continue;
											case 20u:
												goto IL_0070;
											case 19u:
												ptr6 = (char*)(nint)text;
												num = (int)(num3 * 647211380) ^ -1127220318;
												continue;
											case 18u:
												num6 = ((array.Length == 0) ? 1128946194 : 1830948792);
												num = num6 ^ ((int)num3 * -1120293511);
												continue;
											case 17u:
												ptr++;
												num = (int)(num3 * 1675944968) ^ -1857139166;
												continue;
											case 15u:
												goto end_IL_0070;
											case 14u:
												num = -1537406695;
												continue;
											case 13u:
												num = ((ptr2 == ptr4) ? (-1308023867) : (-1706889121));
												continue;
											case 12u:
												ptr6 = (char*)((byte*)ptr6 + RuntimeHelpers.OffsetToStringData);
												num = ((int)num3 * -836340733) ^ -2115463072;
												continue;
											case 10u:
												num = ((*ptr2 != *ptr3) ? (-1476676076) : (-1049738427));
												continue;
											case 7u:
												num = ((ptr == ptr4) ? (-421979101) : (-893132001));
												continue;
											case 6u:
												goto IL_0174;
											case 5u:
												ptr3 = ptr5;
												num = ((int)num3 * -1736285284) ^ 0x256E601F;
												continue;
											case 3u:
												num4 = ((ptr6 != null) ? 1837604076 : 131795305);
												num = num4 ^ ((int)num3 * -376893721);
												continue;
											case 2u:
												ptr2 = ptr;
												num = -1506476288;
												continue;
											case 1u:
												ptr = ptr8 + int_0;
												ptr4 = ptr8 + byte_0.Length;
												ptr5 = (byte*)ptr6;
												ptr7 = (byte*)ptr6 + (nint)string_0.Length * (nint)2;
												num = -141582870;
												continue;
											case 0u:
												ptr2++;
												ptr3 += 2;
												num = -2082197718;
												continue;
											case 11u:
												array2 = (array = byte_0);
												num = ((array2 != null) ? (-95372641) : (-1735606544));
												continue;
											case 4u:
												return -1;
											default:
												goto end_IL_00d5;
											case 9u:
												return (int)(ptr - ptr8);
											case 16u:
												return -1;
											}
											break;
										}
									}
									goto end_IL_020c;
									continue;
									end_IL_0070:
									break;
								}
								goto IL_00d5;
							case 19u:
								ptr6 = (char*)(nint)text;
								num = (int)(num3 * 647211380) ^ -1127220318;
								continue;
							case 18u:
								num6 = ((array.Length == 0) ? 1128946194 : 1830948792);
								num = num6 ^ ((int)num3 * -1120293511);
								continue;
							case 17u:
								ptr++;
								num = (int)(num3 * 1675944968) ^ -1857139166;
								continue;
							case 15u:
								goto IL_00d5;
							case 14u:
								num = -1537406695;
								continue;
							case 13u:
								num = ((ptr2 == ptr4) ? (-1308023867) : (-1706889121));
								continue;
							case 12u:
								ptr6 = (char*)((byte*)ptr6 + RuntimeHelpers.OffsetToStringData);
								num = ((int)num3 * -836340733) ^ -2115463072;
								continue;
							case 10u:
								num = ((*ptr2 != *ptr3) ? (-1476676076) : (-1049738427));
								continue;
							case 7u:
								num = ((ptr == ptr4) ? (-421979101) : (-893132001));
								continue;
							case 6u:
								goto IL_0174;
							case 5u:
								ptr3 = ptr5;
								num = ((int)num3 * -1736285284) ^ 0x256E601F;
								continue;
							case 3u:
								num4 = ((ptr6 != null) ? 1837604076 : 131795305);
								num = num4 ^ ((int)num3 * -376893721);
								continue;
							case 2u:
								ptr2 = ptr;
								num = -1506476288;
								continue;
							case 1u:
								ptr = ptr8 + int_0;
								ptr4 = ptr8 + byte_0.Length;
								ptr5 = (byte*)ptr6;
								ptr7 = (byte*)ptr6 + (nint)string_0.Length * (nint)2;
								num = -141582870;
								continue;
							case 0u:
								ptr2++;
								ptr3 += 2;
								num = -2082197718;
								continue;
							case 11u:
								array2 = (array = byte_0);
								num = ((array2 != null) ? (-95372641) : (-1735606544));
								continue;
							case 4u:
								return -1;
							default:
								goto end_IL_00d5;
							case 9u:
								return (int)(ptr - ptr8);
							case 16u:
								{
									return -1;
								}
								IL_0174:
								text = null;
								num = ((int)num3 * -1078758850) ^ -823171879;
								continue;
								end_IL_020c:
								break;
							}
							break;
						}
					}
					goto case 21u;
					continue;
					end_IL_00d5:
					break;
				}
				goto default;
			case 14u:
				break;
			case 13u:
				goto IL_00f1;
			case 12u:
				ptr6 = (char*)((byte*)ptr6 + RuntimeHelpers.OffsetToStringData);
				num = ((int)num3 * -836340733) ^ -2115463072;
				continue;
			case 10u:
				goto IL_012e;
			case 7u:
				goto IL_0152;
			case 6u:
				text = null;
				num = ((int)num3 * -1078758850) ^ -823171879;
				continue;
			case 5u:
				ptr3 = ptr5;
				num = ((int)num3 * -1736285284) ^ 0x256E601F;
				continue;
			case 3u:
				num4 = ((ptr6 != null) ? 1837604076 : 131795305);
				num = num4 ^ ((int)num3 * -376893721);
				continue;
			case 2u:
				ptr2 = ptr;
				num = -1506476288;
				continue;
			case 1u:
				ptr = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + int_0;
				ptr4 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + byte_0.Length;
				ptr5 = (byte*)ptr6;
				ptr7 = (byte*)ptr6 + (nint)string_0.Length * (nint)2;
				num = -141582870;
				continue;
			case 0u:
				ptr2++;
				ptr3 += 2;
				num = -2082197718;
				continue;
			case 11u:
				goto IL_0282;
			case 4u:
				return -1;
			default:
				reference = ref *(byte*)null;
				return -1;
			case 9u:
				return (int)(ptr - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 16u:
				return -1;
			}
			break;
			IL_0152:
			num = ((ptr == ptr4) ? (-421979101) : (-893132001));
			continue;
			IL_012e:
			num = ((*ptr2 != *ptr3) ? (-1476676076) : (-1049738427));
			continue;
			IL_00f1:
			num = ((ptr2 == ptr4) ? (-1308023867) : (-1706889121));
		}
		goto IL_00e7;
		IL_0282:
		array2 = (array = byte_0);
		num = ((array2 != null) ? (-95372641) : (-1735606544));
		goto IL_0200;
#endif
	}

	internal static string smethod_345(string string_0, Exception exception_0, bool bool_0)
	{
		Type type = exception_0.GetType();
		string text = default(string);
		while (true)
		{
			int num = -1755716187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -996110060)) % 9)
				{
				case 7u:
					text = text + type.FullName + ": " + exception_0.Message;
					num = -842379024;
					continue;
				case 5u:
					num = ((!text.EndsWith(".")) ? 1804667958 : 765113376) ^ ((int)num2 * -1012018073);
					continue;
				case 3u:
					text += ".";
					num = ((int)num2 * -589952584) ^ 0x3B93A10C;
					continue;
				case 2u:
					num = ((exception_0.InnerException == null) ? (-1413268292) : (-991308870));
					continue;
				case 1u:
					text = string_0;
					num = (bool_0 ? 697253933 : 1460972286) ^ (int)(num2 * 385945033);
					continue;
				case 0u:
					text += "\n\n";
					num = ((int)num2 * -1982244131) ^ -1194903865;
					continue;
				case 6u:
					break;
				default:
					return smethod_345(text + "\n\n", exception_0.InnerException, bool_0: false);
				case 8u:
					return text;
				}
				break;
			}
		}
	}

	internal static bool smethod_348(DeflateDecoder.Class180 class180_0)
	{
		int num = smethod_14(class180_0.class182_0);
		int num4 = default(int);
		int num6 = default(int);
		int int_ = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = ((num < 258) ? 763319921 : 1160327810);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0xFD9D10E)) % 34)
				{
				case 33u:
					class180_0.class183_1 = null;
					num2 = 577513338;
					continue;
				case 32u:
					class180_0.int_4 = 9;
					num2 = 1743734130;
					continue;
				case 31u:
					num2 = ((num4 >= 0) ? 627331638 : 1661256961) ^ (int)(num3 * 327633403);
					continue;
				case 30u:
					class180_0.int_6 = DeflateDecoder.Class180.int_0[num4 - 257];
					class180_0.int_5 = DeflateDecoder.Class180.int_1[num4 - 257];
					num2 = 557491619;
					continue;
				case 29u:
					num6 = smethod_60(class180_0.class181_0, class180_0.int_5);
					num2 = ((num6 < 0) ? (-2142351955) : (-1087205975)) ^ (int)(num3 * 57578442);
					continue;
				case 27u:
					class180_0.int_4 = 10;
					num2 = (int)((num3 * 1631180901) ^ 0x237934E8);
					continue;
				case 26u:
					num2 = ((((num4 = smethod_96(class180_0.class183_0, class180_0.class181_0)) & -256) != 0) ? 443705541 : 1681283153);
					continue;
				case 25u:
					num2 = 1160327810;
					continue;
				case 24u:
					smethod_132(class180_0.class182_0, class180_0.int_6, class180_0.int_7);
					num -= class180_0.int_6;
					num2 = 585707809;
					continue;
				case 23u:
					class180_0.int_7 += num6;
					num2 = ((int)num3 * -710629906) ^ -1825613888;
					continue;
				case 22u:
					goto IL_017f;
				case 21u:
					switch (int_)
					{
					case 7:
						break;
					case 9:
						goto IL_017f;
					default:
						goto IL_01b4;
					case 8:
						goto IL_01c7;
					case 10:
						goto IL_01ec;
					}
					goto case 26u;
				case 1u:
					goto IL_01c7;
				case 16u:
					goto IL_01ec;
				case 20u:
					class180_0.int_7 = DeflateDecoder.Class180.int_2[num4];
					class180_0.int_5 = DeflateDecoder.Class180.int_3[num4];
					num2 = 1737455134;
					continue;
				case 19u:
					num2 = ((num4 < 257) ? 1923460237 : 1404177172) ^ ((int)num3 * -1944184838);
					continue;
				case 18u:
					int_ = class180_0.int_4;
					num2 = 536257933;
					continue;
				case 17u:
					smethod_77(class180_0.class182_0, num4);
					num2 = ((--num < 258) ? 2136181693 : 1521823804);
					continue;
				case 14u:
					class180_0.int_6 += num5;
					num2 = (int)((num3 * 361324795) ^ 0x1DEFBD26);
					continue;
				case 13u:
					smethod_396(class180_0.class181_0, class180_0.int_5);
					num2 = 1212664481;
					continue;
				case 12u:
					smethod_396(class180_0.class181_0, class180_0.int_5);
					num2 = 1026482512;
					continue;
				case 11u:
					num5 = smethod_60(class180_0.class181_0, class180_0.int_5);
					num2 = ((num5 >= 0) ? (-1673683693) : (-1861683763)) ^ ((int)num3 * -2014024301);
					continue;
				case 7u:
					class180_0.int_4 = 7;
					num2 = (int)((num3 * 820425283) ^ 0x38B854BD);
					continue;
				case 6u:
					num2 = ((int)num3 * -1080952740) ^ 0x308BEE0;
					continue;
				case 4u:
					class180_0.int_4 = 8;
					num2 = (int)((num3 * 813207140) ^ 0x47CE7C87);
					continue;
				case 2u:
					num2 = ((num4 < 0) ? (-1833661905) : (-404843388)) ^ (int)(num3 * 849433045);
					continue;
				case 8u:
					break;
				case 0u:
					return false;
				default:
					return true;
				case 5u:
					return false;
				case 9u:
					return true;
				case 10u:
					class180_0.class183_0 = null;
					class180_0.int_4 = 2;
					return true;
				case 15u:
					return false;
				case 28u:
					{
						return false;
					}
					IL_01c7:
					num2 = ((class180_0.int_5 > 0) ? 886495452 : 1596068108);
					continue;
					IL_017f:
					num4 = smethod_96(class180_0.class183_1, class180_0.class181_0);
					num2 = 856621872;
					continue;
					IL_01b4:
					num2 = (int)(num3 * 854322245) ^ -71163683;
					continue;
					IL_01ec:
					num2 = ((class180_0.int_5 <= 0) ? 1088344178 : 220059203);
					continue;
				}
				break;
			}
		}
	}

	internal static void smethod_359()
	{
		try
		{
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				return;
			}
			while (true)
			{
				int num = 1403186211;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x3DD9FE26)) % 3)
					{
					case 1u:
						goto IL_0010;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0010:
					WorkingSetTrimmer.gclass6_0 = new WorkingSetTrimmer();
					num = (int)((num2 * 297737197) ^ 0x24163AC5);
				}
			}
		}
		catch
		{
		}
	}

	internal unsafe static void smethod_361(long long_0, IntPtr intptr_0, byte byte_0)
	{
		byte* ptr = (byte*)(void*)intptr_0;
		byte* ptr2 = default(byte*);
		long num3 = default(long);
		while (true)
		{
			int num = 1699662745;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1DD28092)) % 12)
				{
				case 11u:
					ptr2 = ptr + long_0;
					num = ((int)num2 * -1414931965) ^ 0x3254CD6D;
					continue;
				case 10u:
					num3 = ptr2 - ptr;
					num = 1485180467;
					continue;
				case 9u:
					num = ((num3 >= 8L) ? (-1260486489) : (-1538773396)) ^ ((int)num2 * -950699635);
					continue;
				case 8u:
					num = ((num3 < 2L) ? 952437844 : 1194389455);
					continue;
				case 7u:
					num = ((num3 >= 4L) ? 641997871 : 2110625374);
					continue;
				case 6u:
					num = ((int)num2 * -902919817) ^ -384522794;
					continue;
				case 5u:
					*(int*)ptr = byte_0;
					ptr += 4;
					num = (int)((num2 * 1631417547) ^ 0x23D71F93);
					continue;
				case 4u:
					ptr += 8;
					num = ((int)num2 * -1209299499) ^ -1762388028;
					continue;
				case 1u:
					*(short*)ptr = byte_0;
					ptr += 2;
					num = (int)(num2 * 1694458221) ^ -1768598059;
					continue;
				case 0u:
					*(long*)ptr = byte_0;
					num = ((int)num2 * -670467657) ^ -798253990;
					continue;
				case 3u:
					break;
				default:
					*ptr = byte_0;
					return;
				}
				break;
			}
		}
	}

	internal static int smethod_362(Type type_0)
	{
		if (type_0.IsSubclassOf(typeof(RemotePlatformStructure)))
		{
			int count = default(int);
			int count2 = default(int);
			while (true)
			{
				int num = 1954533698;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x218DFF1F)) % 11)
					{
					case 10u:
						break;
					case 8u:
						count = RemotePlatformStructure.dictionary_0.Count;
						count2 = RemotePlatformStructure.dictionary_1.Count;
						RuntimeHelpers.RunClassConstructor(type_0.TypeHandle);
						num = 1366969982;
						continue;
					case 7u:
						num = (RemotePlatformStructure.dictionary_0.ContainsKey(type_0) ? (-1970454478) : (-854377611)) ^ ((int)num2 * -1061427865);
						continue;
					case 3u:
						num = ((RemotePlatformStructure.dictionary_1.Count != count2) ? 2037727753 : 155529082) ^ (int)(num2 * 663721599);
						continue;
					case 1u:
						num = ((RemotePlatformStructure.dictionary_0.Count != count) ? (-193483585) : (-2070102187)) ^ ((int)num2 * -998035680);
						continue;
					case 0u:
						goto end_IL_00f6;
					case 2u:
						return RemotePlatformStructure.dictionary_1[type_0].Last();
					case 4u:
						throw new InvalidOperationException(string.Concat("Unregistered PlatformStruct detected. (", type_0, ")"));
					case 5u:
						return RemotePlatformStructure.dictionary_0[type_0].Last();
					default:
						goto end_IL_0134;
					case 9u:
						return smethod_362(type_0);
					}
					num = ((!RemotePlatformStructure.dictionary_1.ContainsKey(type_0)) ? 2130066399 : 889016104);
					continue;
					end_IL_00f6:
					break;
				}
				continue;
				end_IL_0134:
				break;
			}
		}
		throw new InvalidOperationException("The type must be a PlatformStruct.");
	}

	internal static uint smethod_366(InvertedFunctionTable32 class112_0)
	{
		return class112_0.method_21<uint>(0);
	}

	internal static void smethod_367(string string_0, PeScrambler gclass4_0)
	{
		smethod_299(string_0, gclass4_0.class154_0);
	}

	internal static ushort smethod_370(ResourceDirectory class166_0)
	{
		return class166_0.class5_0.ReadUInt16();
	}

	internal unsafe static bool smethod_375(char* pChar_0, byte* pByte_0, char* pChar_1)
	{
		byte* ptr = (byte*)pChar_1;
		byte* ptr2 = default(byte*);
		while (true)
		{
			int num = -1792574972;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1764546018)) % 10)
				{
				case 9u:
					num = ((int)num2 * -1976049927) ^ 0x48DC3D37;
					continue;
				case 8u:
					ptr2 = (byte*)pChar_0;
					num = (int)((num2 * 1130431397) ^ 0x438E0FAF);
					continue;
				case 7u:
					num = ((*ptr2 != 120) ? (-1939384998) : (-362095551));
					continue;
				case 6u:
					ptr2 += 2;
					pByte_0++;
					num = -1597492465;
					continue;
				case 5u:
					num = ((*pByte_0 != *ptr) ? 645752570 : 252858347) ^ ((int)num2 * -1431377681);
					continue;
				case 4u:
					num = ((*ptr2 != 0) ? (-2085956741) : (-300785992));
					continue;
				case 3u:
					ptr += 2;
					num = (int)((num2 * 1582455632) ^ 0x6B2A41BC);
					continue;
				case 2u:
					break;
				default:
					return *ptr2 == 0;
				case 1u:
					return false;
				}
				break;
			}
		}
	}

	internal static void smethod_377(PeScrambler gclass4_0, long long_0, long long_1)
	{
		byte[] buffer = new byte[long_1];
		while (true)
		{
			int num = -836880045;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1784234244)) % 4)
				{
				case 3u:
					gclass4_0.class154_0.method_28().Position = long_0;
					num = ((int)num2 * -471602024) ^ -63907403;
					continue;
				case 1u:
					gclass4_0.binaryWriter_0.Write(buffer);
					num = (int)((num2 * 1354479059) ^ 0x67EF169D);
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal static int smethod_378(byte[] byte_0, string string_0, int int_0)
	{
		if (int_0 + string_0.Length > byte_0.Length)
		{
			goto IL_0081;
		}
		goto IL_0135;
		IL_0081:
		int num = -594057257;
		goto IL_00e0;
		IL_00e0:
		int num3 = default(int);
		byte[] array = default(byte[]);
		int length = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1572129997)) % 13)
			{
			case 12u:
				num = (int)((num2 * 1557213288) ^ 0xD1AFE95);
				continue;
			case 11u:
				num3 = 0;
				num = (int)(num2 * 1223115804) ^ -1033244178;
				continue;
			case 10u:
				array[num3] = (byte)string_0[num3];
				num = -1456216870;
				continue;
			case 8u:
				array = new byte[length];
				num = (int)(num2 * 1472680885) ^ -758293758;
				continue;
			case 7u:
				length = string_0.Length;
				num = -336851990;
				continue;
			case 5u:
				break;
			case 4u:
				num3++;
				num = (int)(num2 * 1619575105) ^ -1958246668;
				continue;
			case 1u:
				num = ((string_0.Length >= 5) ? (-860857234) : (-563254696)) ^ (int)(num2 * 442627558);
				continue;
			case 0u:
				goto IL_00c5;
			case 6u:
				goto IL_0135;
			case 2u:
				return -1;
			default:
				return smethod_12(byte_0, array, int_0);
			case 9u:
				return smethod_343(byte_0, string_0, int_0);
			}
			break;
			IL_00c5:
			num = ((num3 >= length) ? (-30094545) : (-970385153));
		}
		goto IL_0081;
		IL_0135:
		num = ((byte_0.Length - int_0 < 20000) ? (-1509323608) : (-198238309));
		goto IL_00e0;
	}

	internal static bool smethod_387(ResourceIdentifier class137_0)
	{
		return class137_0.method_0() != null;
	}

	internal static void smethod_388(RemoteMemoryAccessor class82_0)
	{
		if (class82_0.method_6() != null)
		{
			goto IL_001a;
		}
		goto IL_00b0;
		IL_001a:
		int num = 2024457989;
		goto IL_0074;
		IL_0074:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x28A5DB30)) % 7)
			{
			case 6u:
				break;
			case 4u:
				CloseHandle(class82_0.method_2());
				num = (int)((num2 * 375033129) ^ 0x1395D966);
				continue;
			case 2u:
				class82_0.method_6().imethod_6(class82_0.method_2());
				num = (int)(num2 * 404934870) ^ -545109904;
				continue;
			case 0u:
				class82_0.method_3(IntPtr.Zero);
				num = (int)((num2 * 127881160) ^ 0x34661AF4);
				continue;
			default:
				return;
			case 5u:
				goto IL_00b0;
			case 1u:
				return;
			case 3u:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_00b0:
		num = ((class82_0.method_2() != IntPtr.Zero) ? 1654359615 : 1861459900);
		goto IL_0074;
	}

	internal static void smethod_396(DeflateDecoder.Class181 class181_0, int int_0)
	{
		class181_0.uint_0 >>= int_0;
		class181_0.int_2 -= int_0;
	}

	internal static void smethod_400(IntPtr intptr_0, RemotePebLdrData class109_0)
	{
		class109_0.method_18(intptr_0);
	}

	internal static int smethod_401(DeflateDecoder.Class181 class181_0)
	{
		return class181_0.int_1 - class181_0.int_0 + (class181_0.int_2 >> 3);
	}

	internal static string smethod_404(BoundsCheckedBinaryReader class5_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			bool flag = true;
			int num3 = default(int);
			byte b = default(byte);
			byte[] array = default(byte[]);
			while (true)
			{
				int num = ((!flag) ? 1716743178 : 631100482);
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x52F71297)) % 13)
					{
					case 12u:
						num = ((num3 < 16) ? 1537929263 : 689050140);
						continue;
					case 11u:
						num3 = 0;
						num = (int)((num2 * 519083441) ^ 0x49EC9EF8);
						continue;
					case 10u:
						b = array[num3];
						num = 1830812451;
						continue;
					case 9u:
						class5_0.BaseStream.Position -= 15 - num3;
						num = (int)(num2 * 881359187) ^ -1047748261;
						continue;
					case 8u:
						num = ((int)num2 * -479388399) ^ -997211451;
						continue;
					case 7u:
						num = ((b != 0) ? (-1146135692) : (-1451420060)) ^ ((int)num2 * -949210825);
						continue;
					case 6u:
						num = 631100482;
						continue;
					case 5u:
						flag = false;
						num = ((int)num2 * -674214030) ^ 0x6E9438AC;
						continue;
					case 4u:
						stringBuilder.Append((char)b);
						num = 1549077182;
						continue;
					case 3u:
						num3++;
						num = ((int)num2 * -1832289219) ^ 0x633E4C12;
						continue;
					case 1u:
						array = class5_0.ReadBytes(16);
						num = 1672222792;
						continue;
					case 0u:
						break;
					default:
						return stringBuilder.ToString();
					}
					break;
				}
			}
		}
		catch
		{
			return stringBuilder.ToString();
		}
	}

	internal static void smethod_414(ResourceDirectoryNode class138_0)
	{
		if (class138_0.long_0 < 0L)
		{
			goto IL_02a6;
		}
		goto IL_05bc;
		IL_02a6:
		int num = -1775434932;
		goto IL_04f6;
		IL_04f6:
		int int_ = default(int);
		int num6 = default(int);
		string text = default(string);
		long num9 = default(long);
		uint num5 = default(uint);
		int num8 = default(int);
		uint num7 = default(uint);
		uint num4 = default(uint);
		uint uint_ = default(uint);
		long num3 = default(long);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1303306011)) % 41)
			{
			case 40u:
				break;
			case 39u:
				class138_0.method_6().Add(new ResourceDirectoryNode(int_, class138_0.class166_0, num6));
				num = (int)(num2 * 1321182643) ^ -1048202268;
				continue;
			case 38u:
				num = ((int)num2 * -1835096247) ^ -933917880;
				continue;
			case 37u:
				num = ((text != null) ? (-1036189665) : (-1956645628)) ^ (int)(num2 * 557030566);
				continue;
			case 36u:
				num9++;
				num = -151372826;
				continue;
			case 35u:
				goto IL_00d8;
			case 34u:
				int_ = (int)num5;
				num = -338677743;
				continue;
			case 29u:
				num = ((text != null) ? 2145434809 : 48614946) ^ ((int)num2 * -1365308690);
				continue;
			case 28u:
				text = null;
				num = ((int)num2 * -802271296) ^ -911414576;
				continue;
			case 27u:
				num = ((num6 == class138_0.long_0) ? (-1222783056) : (-415526062)) ^ ((int)num2 * -232818203);
				continue;
			case 26u:
				num9 = 0L;
				num = -1622600243;
				continue;
			case 24u:
				num = ((num6 != 0) ? 320528572 : 292799433) ^ (int)(num2 * 40777389);
				continue;
			case 23u:
				num = ((!smethod_176(class138_0.class166_0, num8 * 8)) ? 2028871081 : 1708715661) ^ ((int)num2 * -1328621998);
				continue;
			case 22u:
				num = ((text != null) ? 513541114 : 268636129) ^ ((int)num2 * -1977901315);
				continue;
			case 21u:
			{
				class138_0.method_11(smethod_370(class138_0.class166_0));
				ushort num10 = smethod_370(class138_0.class166_0);
				int num11 = smethod_370(class138_0.class166_0);
				num8 = num10 + num11;
				num = (int)(num2 * 12522394) ^ -1181235280;
				continue;
			}
			case 20u:
				int_ = -1;
				num = (((num5 & 0x80000000u) != 0) ? 417965382 : 1086051584) ^ ((int)num2 * -606048333);
				continue;
			case 19u:
				class138_0.method_6().Add(new ResourceDirectoryNode(text, class138_0.class166_0, num6));
				num = -1587287256;
				continue;
			case 18u:
				goto end_IL_04f6;
			case 17u:
				num6 = (int)(num7 & 0x7FFFFFFF);
				num = -381106848;
				continue;
			case 16u:
				num5 = smethod_314(class138_0.class166_0);
				num7 = smethod_314(class138_0.class166_0);
				num = (int)(num2 * 586410116) ^ -879507152;
				continue;
			case 15u:
				class138_0.method_4().Add(new ResourceDataEntry(int_, num4, uint_));
				num = (int)((num2 * 702623672) ^ 0x28AB256D);
				continue;
			case 14u:
				num = (int)(num2 * 164921784) ^ -522482136;
				continue;
			case 13u:
				smethod_262(class138_0.class166_0, num3);
				num = -500688815;
				continue;
			case 12u:
				num = ((num4 == 0) ? 2101121866 : 1456711581) ^ ((int)num2 * -193837778);
				continue;
			case 11u:
				num3 += 8L;
				num = (int)((num2 * 1820035801) ^ 0x5FCA5F7C);
				continue;
			case 10u:
				num = ((!smethod_262(class138_0.class166_0, (int)num7)) ? 1594330112 : 1870379850) ^ (int)(num2 * 987591257);
				continue;
			case 9u:
				goto IL_03c1;
			case 8u:
				uint_ = smethod_314(class138_0.class166_0);
				num = (int)(num2 * 1542480390) ^ -1193326078;
				continue;
			case 7u:
				num = ((!smethod_176(class138_0.class166_0, 16)) ? (-1285822201) : (-1006128669)) ^ ((int)num2 * -1946128439);
				continue;
			case 5u:
				text = smethod_90((int)(num5 & 0x7FFFFFFF), class138_0.class166_0);
				num = (int)(num2 * 138576926) ^ -1142511030;
				continue;
			case 3u:
				num4 = smethod_314(class138_0.class166_0);
				num = (int)((num2 * 1651893016) ^ 0x211B5985);
				continue;
			case 2u:
				class138_0.method_8(smethod_314(class138_0.class166_0));
				class138_0.method_9(smethod_314(class138_0.class166_0));
				class138_0.method_10(smethod_370(class138_0.class166_0));
				num = -574411015;
				continue;
			case 1u:
				class138_0.method_4().Add(new ResourceDataEntry(text, num4, uint_));
				num = -1587287256;
				continue;
			case 0u:
				num3 = class138_0.long_0 + 16L;
				num = ((int)num2 * -425286253) ^ 0x8D9910F;
				continue;
			default:
				return;
			case 4u:
				goto IL_05bc;
			case 6u:
				return;
			case 25u:
				return;
			case 30u:
				return;
			case 31u:
				return;
			case 32u:
				return;
			case 33u:
				return;
			}
			num = (smethod_262(class138_0.class166_0, class138_0.long_0) ? (-478104458) : (-709056625));
			continue;
			IL_03c1:
			num = (((num7 & 0x80000000u) != 0) ? (-1159667969) : (-1146342367));
			continue;
			IL_00d8:
			num = ((num9 >= num8) ? (-563606492) : (-1507146908));
			continue;
			end_IL_04f6:
			break;
		}
		goto IL_02a6;
		IL_05bc:
		num = ((!smethod_282(class138_0.class166_0, class138_0.long_0, 16)) ? (-57534421) : (-1434323077));
		goto IL_04f6;
	}

	internal static int smethod_419(byte[] byte_0, string string_0, string string_1, int int_0)
	{
		if (int_0 < byte_0.Length)
		{
			while (true)
			{
				int num = -1634227725;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -682606134)) % 8)
					{
					case 6u:
						break;
					case 4u:
						num = ((string_0.Length >= 4) ? (-1746713829) : (-516347775)) ^ (int)(num2 * 669219861);
						continue;
					case 3u:
						num = ((int_0 + string_0.Length <= byte_0.Length) ? 1389075937 : 839933303) ^ ((int)num2 * -657585009);
						continue;
					case 1u:
						num = ((string_0.Length != string_1.Length) ? 621275278 : 1065365533) ^ (int)(num2 * 1137282492);
						continue;
					case 2u:
						goto end_IL_00b7;
					case 5u:
						return smethod_17(int_0, string_0, string_1, byte_0);
					default:
						return smethod_35(byte_0, string_0, string_1, int_0);
					case 0u:
						goto end_IL_00e8;
					}
					num = ((byte_0.Length - int_0 >= 4) ? (-2049305042) : (-1842442955));
					continue;
					end_IL_00b7:
					break;
				}
				continue;
				end_IL_00e8:
				break;
			}
		}
		return -1;
	}

	internal static int smethod_422(DeflateDecoder.Class181 class181_0)
	{
		return class181_0.int_2;
	}

	internal static uint smethod_425(InvertedFunctionTableEntry32 class113_0)
	{
		return class113_0.method_21<uint>(3);
	}

	internal static string smethod_426()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1214701600;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x59DFA929)) % 7)
				{
				case 6u:
					num4++;
					num = ((int)num2 * -2043740366) ^ -1210613553;
					continue;
				case 5u:
					stringBuilder.Append((DynamicIlEmitter.random_0.Next(2) == 1) ? char.ToUpper("abcdefghijklmnopqrstuvwxyz0123456789"[DynamicIlEmitter.random_0.Next("abcdefghijklmnopqrstuvwxyz0123456789".Length)]) : "abcdefghijklmnopqrstuvwxyz0123456789"[DynamicIlEmitter.random_0.Next("abcdefghijklmnopqrstuvwxyz0123456789".Length)]);
					num = 362027199;
					continue;
				case 4u:
					num = (int)((num2 * 2058249138) ^ 0x60266B4F);
					continue;
				case 3u:
					num = ((num4 >= num3) ? 126734586 : 975612514);
					continue;
				case 2u:
					num3 = DynamicIlEmitter.random_0.Next(5, 30);
					num4 = 0;
					num = (int)((num2 * 814251286) ^ 0x409E7C39);
					continue;
				case 0u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	internal static string smethod_428(PeScrambler gclass4_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -2009811485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2002537020)) % 11)
				{
				case 10u:
					stringBuilder.Append("abcdefghijklmnopqrstuvwxyz0123456789"[gclass4_0.random_0.Next("abcdefghijklmnopqrstuvwxyz0123456789".Length)]);
					num = -17987200;
					continue;
				case 9u:
					stringBuilder.Append("\\");
					num3 = 0;
					num = -1883849846;
					continue;
				case 8u:
					num = (int)((num2 * 1870334238) ^ 0x358837BF);
					continue;
				case 7u:
					num = ((num4 >= gclass4_0.random_0.Next(4, 8)) ? (-1443008879) : (-1580977083));
					continue;
				case 6u:
					num4++;
					num = ((int)num2 * -1882946318) ^ 0x437B6363;
					continue;
				case 5u:
					num4 = 0;
					num = ((int)num2 * -2122666048) ^ 0x2E0C9529;
					continue;
				case 3u:
					num = ((num3 >= gclass4_0.random_0.Next(4, 20)) ? (-1024140687) : (-1312626104));
					continue;
				case 1u:
					stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ"[gclass4_0.random_0.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Length)]).Append(':');
					num = ((int)num2 * -721303528) ^ -463269694;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 2008923895) ^ -539220458;
					continue;
				case 2u:
					break;
				default:
					return stringBuilder.Append(".pdb").ToString();
				}
				break;
			}
		}
	}

	internal static bool smethod_434(string string_0, string string_1)
	{
		if (!string_0.StartsWith("msvcr" + string_1, StringComparison.OrdinalIgnoreCase))
		{
			goto IL_0065;
		}
		goto IL_009f;
		IL_0065:
		int num = -807695399;
		goto IL_006a;
		IL_006a:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2049228342)) % 6)
			{
			case 1u:
				num = (string_0.StartsWith("msvcp" + string_1, StringComparison.OrdinalIgnoreCase) ? 1516025877 : 1408513057) ^ (int)(num2 * 2000435714);
				continue;
			case 0u:
				break;
			case 5u:
				goto IL_009f;
			case 2u:
				return string_0.EndsWith(".dll", StringComparison.OrdinalIgnoreCase);
			default:
				return false;
			case 4u:
				return true;
			}
			break;
		}
		goto IL_0065;
		IL_009f:
		num = (string_0.EndsWith("d.dll", StringComparison.OrdinalIgnoreCase) ? (-1996802280) : (-430113638));
		goto IL_006a;
	}

	internal static bool smethod_436(DeflateDecoder.Class180 class180_0)
	{
		int int_ = class180_0.int_4;
		int num6 = default(int);
		int num4 = default(int);
		int num7 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 362105484;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x37F368BA)) % 47)
				{
				case 45u:
					num = (int)(num2 * 219656286) ^ -205718148;
					continue;
				case 44u:
					class180_0.class183_1 = DeflateDecoder.Class183.class183_1;
					num = ((int)num2 * -516349916) ^ -1432668625;
					continue;
				case 43u:
					class180_0.int_8 -= num6;
					num = ((int)num2 * -1447246017) ^ -1595423273;
					continue;
				case 42u:
					num = (int)((num2 * 430371484) ^ 0x604A9DE2);
					continue;
				case 41u:
					num = ((class180_0.int_8 == 0) ? (-859630807) : (-879228617)) ^ ((int)num2 * -576239764);
					continue;
				case 40u:
					switch (int_)
					{
					case 2:
						goto IL_00e5;
					case 3:
						goto IL_0109;
					case 4:
						goto IL_0129;
					case 5:
						goto IL_0141;
					case 6:
						goto IL_0163;
					case 7:
					case 8:
					case 9:
					case 10:
						goto IL_0511;
					case 11:
						goto IL_0518;
					case 12:
						goto IL_051a;
					}
					num = (int)(num2 * 1805354572) ^ -1452677852;
					continue;
				case 30u:
					goto IL_00e5;
				case 39u:
					goto IL_0109;
				case 22u:
					goto IL_0129;
				case 29u:
					goto IL_0141;
				case 32u:
					goto IL_0163;
				case 37u:
					num = (((num4 & 1) != 0) ? 1407922705 : 101904180) ^ ((int)num2 * -391803759);
					continue;
				case 35u:
					class180_0.bool_0 = true;
					num = ((int)num2 * -1254971918) ^ 0x728823F0;
					continue;
				case 33u:
					class180_0.class183_0 = smethod_63(class180_0.class184_0);
					class180_0.class183_1 = smethod_62(class180_0.class184_0);
					num = 571084027;
					continue;
				case 28u:
					smethod_396(class180_0.class181_0, 3);
					num = 1452282308;
					continue;
				case 27u:
					class180_0.int_4 = 3;
					num = ((int)num2 * -1711257174) ^ -335702806;
					continue;
				case 26u:
					num = (int)((num2 * 534117641) ^ 0xB815BCD);
					continue;
				case 25u:
					num = ((num7 >= 0) ? 663913588 : 616067339) ^ (int)(num2 * 1267762008);
					continue;
				case 24u:
					smethod_141(class180_0.class181_0);
					num = 872832251;
					continue;
				case 23u:
					smethod_396(class180_0.class181_0, 16);
					num = 2099790088;
					continue;
				case 21u:
					goto IL_029b;
				case 20u:
					num = ((int)num2 * -251196449) ^ 0x230ECC11;
					continue;
				case 19u:
					class180_0.int_4 = 12;
					num = (int)((num2 * 2053654318) ^ 0x11263FC6);
					continue;
				case 17u:
					num = ((num5 >= 0) ? 1044340518 : 602371600) ^ (int)(num2 * 2134745621);
					continue;
				case 16u:
					class180_0.int_4 = 5;
					num = (int)(num2 * 495332007) ^ -611196955;
					continue;
				case 15u:
					class180_0.int_4 = 7;
					num = ((int)num2 * -1977439502) ^ -1390434363;
					continue;
				case 14u:
					switch (num3)
					{
					case 0:
						break;
					case 1:
						goto IL_029b;
					default:
						goto IL_034e;
					case 2:
						goto IL_0361;
					}
					goto case 24u;
				case 7u:
					goto IL_0361;
				case 11u:
					class180_0.int_4 = 2;
					num = ((int)num2 * -1492236967) ^ -1833135498;
					continue;
				case 9u:
					class180_0.int_4 = 7;
					num = (int)((num2 * 23252645) ^ 0x52BBE03C);
					continue;
				case 6u:
					class180_0.int_4 = 4;
					num = (int)((num2 * 1582771635) ^ 0x681A642D);
					continue;
				case 5u:
					num = ((num4 < 0) ? (-615466750) : (-1043804967)) ^ ((int)num2 * -2093761634);
					continue;
				case 3u:
					num4 = smethod_60(class180_0.class181_0, 3);
					num = 79393671;
					continue;
				case 1u:
					smethod_396(class180_0.class181_0, 16);
					num = 1562120;
					continue;
				case 0u:
					num3 = num4 >> 1;
					num = 194433039;
					continue;
				case 38u:
					break;
				case 2u:
					return true;
				case 4u:
					return false;
				case 8u:
					return false;
				case 10u:
					return false;
				case 12u:
					return false;
				case 18u:
					return true;
				case 34u:
					return !smethod_106(class180_0.class181_0);
				case 36u:
					goto IL_0511;
				default:
					goto IL_0518;
				case 13u:
					goto IL_051a;
				case 46u:
					{
						return false;
					}
					IL_0511:
					return smethod_348(class180_0);
					IL_0163:
					num = ((!smethod_305(class180_0.class184_0, class180_0.class181_0)) ? 693771016 : 850802448);
					continue;
					IL_0518:
					return false;
					IL_0361:
					class180_0.class184_0 = new DeflateDecoder.Class184();
					class180_0.int_4 = 6;
					num = 798622650;
					continue;
					IL_034e:
					num = ((int)num2 * -1373167525) ^ 0x2FC9ABE0;
					continue;
					IL_0141:
					num6 = smethod_170(class180_0.class182_0, class180_0.class181_0, class180_0.int_8);
					num = 1476275907;
					continue;
					IL_029b:
					class180_0.class183_0 = DeflateDecoder.Class183.class183_0;
					num = 398999694;
					continue;
					IL_0109:
					num7 = (class180_0.int_8 = smethod_60(class180_0.class181_0, 16));
					num = 2070007949;
					continue;
					IL_00e5:
					num = (class180_0.bool_0 ? 1988500195 : 763869425);
					continue;
					IL_0129:
					num5 = smethod_60(class180_0.class181_0, 16);
					num = 2030736736;
					continue;
					IL_051a:
					return false;
				}
				break;
			}
		}
	}

	internal static void smethod_437(PeScrambler gclass4_0, long long_0, long long_1)
	{
		byte[] buffer = new byte[long_1];
		gclass4_0.random_0.NextBytes(buffer);
		gclass4_0.class154_0.method_28().Position = long_0;
		gclass4_0.binaryWriter_0.Write(buffer);
	}

	internal static int smethod_438(DeflateDecoder.Stream1 stream1_0)
	{
		return stream1_0.ReadByte() | (stream1_0.ReadByte() << 8);
	}

	internal static string smethod_440(string string_0, string string_1, string string_2, DependencySearchFlags enum43_0, int int_0, IntPtr intptr_0)
	{
		ApiSetSchema.Class170 @class = new ApiSetSchema.Class170();
		KeyValuePair<string, List<string>> keyValuePair = default(KeyValuePair<string, List<string>>);
		List<string> value = default(List<string>);
		string[] array = default(string[]);
		string text = default(string);
		string text2 = default(string);
		int num4 = default(int);
		string result = default(string);
		string text4 = default(string);
		string text3 = default(string);
		string environmentVariable = default(string);
		while (true)
		{
			int num = -650662351;
			while (true)
			{
				string text5;
				string text6;
				int num6;
				uint num2;
				switch ((num2 = (uint)(num ^ -1981681091)) % 31)
				{
				case 29u:
					@class.string_0 = Path.GetFileName(string_0);
					num = (PlatformInfo.bool_7 ? (-1364913063) : (-737535499)) ^ ((int)num2 * -1561389723);
					continue;
				case 28u:
					num = ((!Path.IsPathRooted(string_0)) ? (-1788888497) : (-646515600));
					continue;
				case 27u:
					num = (((enum43_0 & DependencySearchFlags.flag_4) == 0) ? (-1335227476) : (-1426697291)) ^ ((int)num2 * -1189229907);
					continue;
				case 26u:
					keyValuePair = ApiSetSchema.dictionary_0.FirstOrDefault(@class.method_0);
					num = -161131984;
					continue;
				case 25u:
					num = (smethod_136(ref string_0, intptr_0) ? (-1804593245) : (-38205909)) ^ ((int)num2 * -476063702);
					continue;
				case 24u:
					num = ((string_1.Length <= 0) ? (-1457353625) : (-87594712)) ^ ((int)num2 * -730463411);
					continue;
				case 21u:
					@class.string_0 = @class.string_0.Substring(4);
					num = ((int)num2 * -894624248) ^ -845003557;
					continue;
				case 20u:
					num = (((enum43_0 & DependencySearchFlags.flag_3) == 0) ? (-1828595556) : (-483456755));
					continue;
				case 18u:
					num = (((enum43_0 & DependencySearchFlags.flag_1) == 0) ? (-1681691906) : (-1065504100));
					continue;
				case 17u:
					num = (@class.string_0.StartsWith("ext-ms-") ? 1389390605 : 1196899425) ^ (int)(num2 * 1578652169);
					continue;
				case 16u:
					text5 = value.Last();
					goto IL_01ba;
				case 15u:
					if (!(value.First() != string_1))
					{
						num = ((int)num2 * -327969056) ^ 0x41A41313;
						continue;
					}
					text5 = value.First();
					goto IL_01ba;
				case 12u:
					value = keyValuePair.Value;
					num = ((int)num2 * -1660292329) ^ 0x18A1378F;
					continue;
				case 11u:
					num = (((enum43_0 & DependencySearchFlags.flag_2) == 0) ? (-2030513069) : (-1026820125));
					continue;
				case 9u:
					num = ((keyValuePair.Key == null) ? (-353454714) : (-770617207)) ^ ((int)num2 * -2039735746);
					continue;
				case 8u:
					text6 = string_1.ToLowerInvariant();
					goto IL_0262;
				case 7u:
					string_0 = string_0.ToLowerInvariant();
					if (!string.IsNullOrEmpty(string_1))
					{
						num = ((int)num2 * -1964382031) ^ -1651181957;
						continue;
					}
					text6 = string.Empty;
					goto IL_0262;
				case 5u:
					num = ((keyValuePair.Value.Count < 1) ? (-1379572966) : (-171819431)) ^ ((int)num2 * -807529292);
					continue;
				case 3u:
					num = ((keyValuePair.Value == null) ? (-759757346) : (-818792076)) ^ ((int)num2 * -851161492);
					continue;
				case 2u:
					num = ((!File.Exists(string_0)) ? 156468471 : 64656344) ^ ((int)num2 * -825948776);
					continue;
				case 0u:
					num = ((!smethod_136(ref string_0, intptr_0)) ? (-1330248542) : (-983201955));
					continue;
				case 19u:
					break;
				case 1u:
					return string_0;
				case 4u:
					return Path.Combine(PlatformInfo.string_2, string_0);
				case 6u:
					return Path.Combine(PlatformInfo.string_1, string_0);
				case 10u:
					return null;
				case 13u:
					return string_0;
				case 14u:
					return null;
				case 22u:
					return string_0;
				case 23u:
					return string_0;
				default:
					{
						RegistryKey registryKey = null;
						try
						{
							registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\KnownDLLs");
							while (true)
							{
								IL_05e9:
								int num3 = -1328324977;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -1981681091)) % 15)
									{
									case 13u:
										array = registryKey.GetValueNames();
										num3 = (int)(num2 * 898882130) ^ -1116507635;
										continue;
									case 12u:
										registryKey.Close();
										num3 = (int)((num2 * 697106196) ^ 0x6B3AC8CD);
										continue;
									case 11u:
										num3 = ((int)num2 * -125852992) ^ 0x60C1CDFB;
										continue;
									case 10u:
										text = registryKey.GetValue(((enum43_0 & DependencySearchFlags.flag_4) != DependencySearchFlags.flag_0) ? "DllDirectory32" : "DllDirectory") as string;
										num3 = -1716291897;
										continue;
									case 9u:
										num3 = ((text2 == null) ? (-800190501) : (-1507198816)) ^ (int)(num2 * 1511004368);
										continue;
									case 8u:
									{
										string name = array[num4];
										text2 = registryKey.GetValue(name) as string;
										num3 = -502192251;
										continue;
									}
									case 7u:
										num3 = ((registryKey != null) ? (-141465939) : (-1289806511)) ^ ((int)num2 * -1455511396);
										continue;
									case 6u:
										num3 = ((num4 >= array.Length) ? (-347979496) : (-1588393580));
										continue;
									case 4u:
										num4++;
										num3 = -417206725;
										continue;
									case 3u:
										num4 = 0;
										num3 = ((int)num2 * -1703178435) ^ 0x34C54050;
										continue;
									case 1u:
										num3 = ((!text2.Equals(@class.string_0, StringComparison.OrdinalIgnoreCase)) ? 112847159 : 27758244) ^ (int)(num2 * 594172252);
										continue;
									case 0u:
										num3 = ((text == null) ? 576481995 : 1854774867) ^ (int)(num2 * 1434397672);
										continue;
									default:
										goto end_IL_059a;
									case 5u:
										break;
									case 2u:
										registryKey.Close();
										result = Path.Combine(text, text2);
										return result;
									case 14u:
										goto end_IL_059a;
									}
									goto IL_05e9;
									continue;
									end_IL_059a:
									break;
								}
								break;
							}
						}
						catch
						{
						}
						finally
						{
							if (registryKey != null)
							{
								while (true)
								{
									IL_0642:
									int num5 = -102725329;
									while (true)
									{
										switch ((num2 = (uint)(num5 ^ -1981681091)) % 3)
										{
										case 2u:
											goto IL_0610;
										default:
											goto end_IL_0624;
										case 0u:
											break;
										case 1u:
											goto end_IL_0624;
										}
										goto IL_0642;
										IL_0610:
										registryKey.Close();
										num5 = ((int)num2 * -1125825718) ^ -298467781;
										continue;
										end_IL_0624:
										break;
									}
									break;
								}
							}
						}
						if (!string.IsNullOrEmpty(string_2))
						{
							goto IL_0707;
						}
						goto IL_09b0;
					}
					IL_09b0:
					num6 = ((int_0 != 0) ? (-1423674231) : (-503829033));
					goto IL_091e;
					IL_091e:
					while (true)
					{
						string path;
						switch ((num2 = (uint)(num6 ^ -1981681091)) % 28)
						{
						case 25u:
							text4 = array[num4];
							num6 = -495439490;
							continue;
						case 24u:
							text3 = Path.Combine(Path.GetDirectoryName(smethod_47(int_0).FilePath), @class.string_0);
							num6 = ((int)num2 * -135185338) ^ -1880361875;
							continue;
						case 23u:
							break;
						case 22u:
							array = environmentVariable.Split(';');
							num4 = 0;
							num6 = ((int)num2 * -508002088) ^ -1055264709;
							continue;
						case 21u:
							goto end_IL_091e;
						case 19u:
							goto IL_0711;
						case 14u:
							num6 = ((int)num2 * -987523071) ^ -1793302756;
							continue;
						case 13u:
							text3 = Path.Combine(Environment.CurrentDirectory, @class.string_0);
							num6 = -1831864875;
							continue;
						case 12u:
							num6 = (File.Exists(text3) ? 1220954646 : 411545295) ^ ((int)num2 * -1981206001);
							continue;
						case 11u:
							num6 = ((!text4.Equals(PlatformInfo.string_1, StringComparison.OrdinalIgnoreCase)) ? (-1921698981) : (-1021550079)) ^ (int)(num2 * 1634420511);
							continue;
						case 9u:
							num4++;
							num6 = -1683112374;
							continue;
						case 8u:
							num6 = ((!File.Exists(text3)) ? 1345052954 : 1373808812) ^ (int)(num2 * 1960578900);
							continue;
						case 7u:
							num6 = (((enum43_0 & DependencySearchFlags.flag_4) == 0) ? 252168476 : 50377060) ^ (int)(num2 * 1026803198);
							continue;
						case 6u:
							if ((enum43_0 & DependencySearchFlags.flag_4) == 0)
							{
								num6 = -512145623;
								continue;
							}
							path = PlatformInfo.string_2;
							goto IL_083f;
						case 5u:
							num6 = ((!File.Exists(text3)) ? (-368187429) : (-2021062277)) ^ (int)(num2 * 850977140);
							continue;
						case 4u:
							path = PlatformInfo.string_1;
							goto IL_083f;
						case 3u:
							goto IL_0889;
						case 2u:
							goto IL_08b7;
						case 1u:
							text3 = Path.Combine(string_2, @class.string_0);
							num6 = ((!File.Exists(text3)) ? 749925931 : 1229213245) ^ (int)(num2 * 836721340);
							continue;
						case 10u:
							goto IL_09b0;
						case 0u:
							return null;
						case 15u:
							return text3;
						case 16u:
							return text3;
						case 17u:
							return text3;
						case 18u:
							return text3;
						case 20u:
							return text3;
						case 26u:
							return text3;
						default:
							{
								return result;
							}
							IL_083f:
							text3 = Path.Combine(path, @class.string_0);
							num6 = -533040600;
							continue;
						}
						text3 = Path.Combine(text4, @class.string_0);
						num6 = ((!File.Exists(text3)) ? (-1304046788) : (-1106451249));
						continue;
						IL_08b7:
						text3 = Path.Combine(PlatformInfo.string_0, @class.string_0);
						num6 = ((!File.Exists(text3)) ? (-1845936252) : (-111863759));
						continue;
						IL_0711:
						num6 = ((num4 < array.Length) ? (-1586074812) : (-1464990319));
						continue;
						IL_0889:
						environmentVariable = Environment.GetEnvironmentVariable("PATH");
						num6 = ((environmentVariable != null) ? (-1099240477) : (-1464990319));
						continue;
						end_IL_091e:
						break;
					}
					goto IL_0707;
					IL_0707:
					num6 = -799320596;
					goto IL_091e;
					IL_01ba:
					string_0 = text5;
					num = -755327658;
					continue;
					IL_0262:
					string_1 = text6;
					num = -466642217;
					continue;
				}
				break;
			}
		}
	}

	internal static string smethod_442(long long_0)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		while (true)
		{
			int num = -1932533864;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -689469890)) % 3)
				{
				case 1u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
				IL_000d:
				StrFormatByteSize(long_0, stringBuilder, stringBuilder.Capacity);
				num = ((int)num2 * -1723419399) ^ 0x35B68A52;
			}
		}
	}

	internal static bool smethod_444(ref DosHeader class158_0, [Out] BoundsCheckedBinaryReader class5_0)
	{
		class158_0 = null;
		while (true)
		{
			int num = -1854229931;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1723750453)) % 8)
				{
				case 7u:
					class158_0 = new DosHeader();
					num = ((class5_0.ReadUInt16() != 23117) ? (-472599502) : (-1032085040));
					continue;
				case 6u:
					num = ((class5_0.BaseStream.Length >= 128L) ? (-1638458688) : (-2045615157)) ^ ((int)num2 * -805455514);
					continue;
				case 5u:
					class158_0.method_1(class5_0.ReadUInt32());
					num = (int)((num2 * 719228764) ^ 0x49171FB5);
					continue;
				case 3u:
					smethod_217(class5_0, 58);
					num = -436551962;
					continue;
				case 0u:
					break;
				case 1u:
					return false;
				default:
					return true;
				case 4u:
					return false;
				}
				break;
			}
		}
	}

	internal static IntPtr smethod_445(IntPtr intptr_0, int int_0)
	{
		if (PlatformInfo.bool_0)
		{
			return GetClassLongPtr(intptr_0, int_0);
		}
		return (IntPtr)GetClassLong(intptr_0, int_0);
	}

	internal static BinaryReader smethod_447(Stream stream_0)
	{
		return new BinaryReader(stream_0);
	}

	internal static void smethod_448(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	internal static uint smethod_449(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static long smethod_450(Stream stream_0)
	{
		return stream_0.Position;
	}

	internal static int smethod_451(Random random_0, int int_0)
	{
		return random_0.Next(int_0);
	}

	internal static void smethod_452(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	internal static byte smethod_453(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadByte();
	}

	internal static void smethod_454(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static long smethod_455(Stream stream_0)
	{
		return stream_0.Length;
	}

	internal static byte[] smethod_456(BinaryReader binaryReader_0, int int_0)
	{
		return binaryReader_0.ReadBytes(int_0);
	}

	internal static Type smethod_457(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static string smethod_459(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	internal static TypeBuilder smethod_460(ModuleBuilder moduleBuilder_0, string string_0, TypeAttributes typeAttributes_0)
	{
		return moduleBuilder_0.DefineType(string_0, typeAttributes_0);
	}

	internal static int smethod_461(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	internal static MethodBuilder smethod_462(TypeBuilder typeBuilder_0, string string_0, MethodAttributes methodAttributes_0, Type type_0, Type[] type_1)
	{
		return typeBuilder_0.DefineMethod(string_0, methodAttributes_0, type_0, type_1);
	}

	internal static ILGenerator smethod_463(MethodBuilder methodBuilder_0)
	{
		return methodBuilder_0.GetILGenerator();
	}

	internal static bool smethod_464(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	internal static LocalBuilder smethod_465(ILGenerator ilgenerator_0, Type type_0)
	{
		return ilgenerator_0.DeclareLocal(type_0);
	}

	internal static void smethod_466(ILGenerator ilgenerator_0, OpCode opCode_0, LocalBuilder localBuilder_0)
	{
		ilgenerator_0.Emit(opCode_0, localBuilder_0);
	}

	internal static void smethod_467(ILGenerator ilgenerator_0, OpCode opCode_0, Type type_0)
	{
		ilgenerator_0.Emit(opCode_0, type_0);
	}

	internal static void smethod_468(ILGenerator ilgenerator_0, OpCode opCode_0)
	{
		ilgenerator_0.Emit(opCode_0);
	}

	internal static bool smethod_469(Type type_0, Type type_1)
	{
		return type_0 == type_1;
	}

	internal static FieldBuilder smethod_470(TypeBuilder typeBuilder_0, string string_0, Type type_0, FieldAttributes fieldAttributes_0)
	{
		return typeBuilder_0.DefineField(string_0, type_0, fieldAttributes_0);
	}

	internal static Stream smethod_471(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static ushort smethod_472(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt16();
	}

	internal static MemoryStream smethod_473()
	{
		return new MemoryStream();
	}

	internal static byte[] smethod_474(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	internal static bool smethod_478(WaitCallback waitCallback_0)
	{
		return ThreadPool.QueueUserWorkItem(waitCallback_0);
	}

	internal static int smethod_483()
	{
		return RuntimeHelpers.OffsetToStringData;
	}

	internal static int smethod_484(string string_0)
	{
		return string_0.Length;
	}

	internal static bool smethod_485(Type type_0, Type type_1)
	{
		return type_0.IsAssignableFrom(type_1);
	}

	internal static Type smethod_486(Type type_0)
	{
		return Enum.GetUnderlyingType(type_0);
	}

	internal static InvalidOperationException smethod_487(string string_0)
	{
		return new InvalidOperationException(string_0);
	}

	internal static GroupBox smethod_490()
	{
		return new ModernGroupBox();
	}

	internal static Button smethod_491()
	{
		return new Button();
	}

	internal static TextBox smethod_492()
	{
		return new TextBox();
	}

	internal static ComboBox smethod_493()
	{
		return new ComboBox();
	}

	internal static void smethod_498(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	internal static string smethod_505(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	internal static MissingMethodException smethod_511(string string_0)
	{
		return new MissingMethodException(string_0);
	}

	internal static string smethod_512()
	{
		return Path.GetTempFileName();
	}

	internal static void smethod_513(string string_0, byte[] byte_0)
	{
		File.WriteAllBytes(string_0, byte_0);
	}

	internal static void smethod_514(string string_0)
	{
		File.Delete(string_0);
	}

	internal static AccessViolationException smethod_515(string string_0)
	{
		return new AccessViolationException(string_0);
	}

	internal static Encoding smethod_516()
	{
		return Encoding.Unicode;
	}

	internal static string smethod_517(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static byte[] smethod_518(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	internal static bool smethod_519(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	internal static FileStream smethod_520(string string_0, FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0)
	{
		return new FileStream(string_0, fileMode_0, fileAccess_0, fileShare_0);
	}

	internal static MissingFieldException smethod_521(string string_0)
	{
		return new MissingFieldException(string_0);
	}

	internal static Encoding smethod_522()
	{
		return Encoding.ASCII;
	}

	internal static BinaryWriter smethod_523(Stream stream_0)
	{
		return new BinaryWriter(stream_0);
	}

	internal static void smethod_524(BinaryWriter binaryWriter_0, uint uint_0)
	{
		binaryWriter_0.Write(uint_0);
	}

	internal static char smethod_525(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	internal static void smethod_526(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}

	internal static int smethod_527(Random random_0)
	{
		return random_0.Next();
	}

	internal static void smethod_528(BinaryWriter binaryWriter_0, byte[] byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	internal static void smethod_530(Array array_0, int int_0, Array array_1, int int_1, int int_2)
	{
		Array.Copy(array_0, int_0, array_1, int_1, int_2);
	}

	internal static string smethod_531(string string_0)
	{
		return Path.GetDirectoryName(string_0);
	}

	internal static FileNotFoundException smethod_532(string string_0)
	{
		return new FileNotFoundException(string_0);
	}

	internal static Exception smethod_533(string string_0, Exception exception_0)
	{
		return new Exception(string_0, exception_0);
	}

	internal static void smethod_534(Stream stream_0, long long_0)
	{
		stream_0.SetLength(long_0);
	}

	internal static InvalidOperationException smethod_535()
	{
		return new InvalidOperationException();
	}

	internal static StringBuilder smethod_536(string string_0)
	{
		return new StringBuilder(string_0);
	}

	internal static int smethod_540(Version version_0)
	{
		return version_0.Major;
	}

	internal static StringBuilder smethod_541(StringBuilder stringBuilder_0, int int_0)
	{
		return stringBuilder_0.Append(int_0);
	}

	internal static StringBuilder smethod_542(StringBuilder stringBuilder_0, char char_0)
	{
		return stringBuilder_0.Append(char_0);
	}

	internal static int smethod_543(Version version_0)
	{
		return version_0.Minor;
	}

	internal static int smethod_544(Version version_0)
	{
		return version_0.Build;
	}

	internal static StringBuilder smethod_545(StringBuilder stringBuilder_0, string string_0)
	{
		return stringBuilder_0.Append(string_0);
	}

	internal static string smethod_546(object object_0)
	{
		return object_0.ToString();
	}

	internal static StringBuilder smethod_548(int int_0)
	{
		return new StringBuilder(int_0);
	}

	internal static int smethod_549(StringBuilder stringBuilder_0)
	{
		return stringBuilder_0.Capacity;
	}

	internal static string smethod_550(string string_0)
	{
		return Path.GetFileName(string_0);
	}

	internal static bool smethod_551(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	internal static void smethod_559(Graphics graphics_0, InterpolationMode interpolationMode_0)
	{
		graphics_0.InterpolationMode = interpolationMode_0;
	}

	internal static UnauthorizedAccessException smethod_563(string string_0)
	{
		return new UnauthorizedAccessException(string_0);
	}

	internal static void smethod_565(CheckBox checkBox_0, EventHandler eventHandler_0)
	{
		checkBox_0.CheckedChanged += eventHandler_0;
	}

	internal static object smethod_566(FieldInfo fieldInfo_0, object object_0)
	{
		return fieldInfo_0.GetValue(object_0);
	}

	internal static void smethod_567(CheckBox checkBox_0, bool bool_0)
	{
		checkBox_0.Checked = bool_0;
	}

	internal static ProgressBar smethod_573()
	{
		return new ProgressBar();
	}

	internal static Font smethod_575(string string_0, float float_0)
	{
		return new Font(string_0, float_0);
	}

	internal static RuntimeTypeHandle smethod_577(Type type_0)
	{
		return type_0.TypeHandle;
	}

	internal static void smethod_578(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		RuntimeHelpers.RunClassConstructor(runtimeTypeHandle_0);
	}

	internal static string smethod_579(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	internal static string smethod_581(string string_0)
	{
		return string_0.ToLowerInvariant();
	}

	internal static bool smethod_583(object object_0, object object_1)
	{
		return object_0.Equals(object_1);
	}

	internal static bool smethod_584(string string_0, string string_1)
	{
		return string_0.EndsWith(string_1);
	}

	internal static string smethod_585(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	internal static Int64Converter smethod_586()
	{
		return new Int64Converter();
	}

	internal static object smethod_587(TypeConverter typeConverter_0, string string_0)
	{
		return typeConverter_0.ConvertFromString(string_0);
	}

	internal static bool smethod_588(string string_0, string string_1)
	{
		return string_0.StartsWith(string_1);
	}

	internal static string smethod_589(string string_0, int int_0)
	{
		return string_0.Substring(int_0);
	}

	internal static string smethod_590()
	{
		return Path.GetTempPath();
	}

	internal static string smethod_591(string string_0, string string_1, string string_2)
	{
		return string_0.Replace(string_1, string_2);
	}

	internal static string smethod_592(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	internal static bool smethod_593(string string_0)
	{
		return File.Exists(string_0);
	}

	internal static bool smethod_594(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string_0.EndsWith(string_1, stringComparison_0);
	}

	internal static bool smethod_595(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string_0.Equals(string_1, stringComparison_0);
	}

	internal static ObjectDisposedException smethod_596(string string_0, string string_1)
	{
		return new ObjectDisposedException(string_0, string_1);
	}

	internal static void smethod_598(BinaryWriter binaryWriter_0, ushort ushort_0)
	{
		binaryWriter_0.Write(ushort_0);
	}

	internal static ulong smethod_599(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt64();
	}

	internal static void smethod_600(BinaryWriter binaryWriter_0, ulong ulong_0)
	{
		binaryWriter_0.Write(ulong_0);
	}

	internal static int smethod_601(int int_0, int int_1)
	{
		return Math.Min(int_0, int_1);
	}

	internal static void smethod_602(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static void smethod_603(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static string smethod_604(string[] string_0)
	{
		return string.Concat(string_0);
	}

	internal static void smethod_605(Array array_0)
	{
		Array.Reverse(array_0);
	}

	internal static string smethod_606(string string_0, int int_0, string string_1)
	{
		return string_0.Insert(int_0, string_1);
	}

	internal static StringBuilder smethod_607()
	{
		return new StringBuilder();
	}

	internal static bool smethod_608()
	{
		return NetworkInterface.GetIsNetworkAvailable();
	}

	internal static string smethod_609(WebClient webClient_0, string string_0)
	{
		return webClient_0.DownloadString(string_0);
	}

	internal static bool smethod_611(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	internal static bool smethod_612(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	internal static int smethod_613(byte[] byte_0, int int_0)
	{
		return BitConverter.ToInt32(byte_0, int_0);
	}

	internal static string smethod_617(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	internal static void smethod_622(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	internal static void smethod_624(int int_0)
	{
		Thread.Sleep(int_0);
	}

	internal static Win32Exception smethod_625(int int_0)
	{
		return new Win32Exception(int_0);
	}

	internal static string smethod_626(Exception exception_0)
	{
		return exception_0.Message;
	}

	internal static string smethod_627(string string_0)
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	internal static string smethod_628(string string_0)
	{
		return Path.GetExtension(string_0);
	}

	internal static string smethod_629(object[] object_0)
	{
		return string.Concat(object_0);
	}

	internal static void smethod_630(string string_0, string string_1)
	{
		File.Copy(string_0, string_1);
	}

	internal static object smethod_631(Type type_0, object[] object_0)
	{
		return Activator.CreateInstance(type_0, object_0);
	}

	internal static Exception smethod_632(string string_0)
	{
		return new Exception(string_0);
	}

	internal static FileVersionInfo smethod_633(string string_0)
	{
		return FileVersionInfo.GetVersionInfo(string_0);
	}

	internal static string smethod_634(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.CompanyName;
	}

	internal static CheckBox smethod_635()
	{
		return new CheckBox();
	}

	internal static bool smethod_636(CheckBox checkBox_0)
	{
		return checkBox_0.Checked;
	}

	internal static bool smethod_637(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string_0.StartsWith(string_1, stringComparison_0);
	}

	internal static Process smethod_638(string string_0)
	{
		return Process.Start(string_0);
	}

	internal static bool smethod_639(Type type_0, Type type_1)
	{
		return type_0.IsSubclassOf(type_1);
	}

	internal static ArgumentOutOfRangeException smethod_640()
	{
		return new ArgumentOutOfRangeException();
	}

	internal static void smethod_643(NumericUpDown numericUpDown_0, decimal decimal_0)
	{
		numericUpDown_0.Value = decimal_0;
	}

	internal static string smethod_644(string string_0)
	{
		return Environment.GetEnvironmentVariable(string_0);
	}

	internal static WindowsIdentity smethod_645()
	{
		return WindowsIdentity.GetCurrent();
	}

	internal static WindowsPrincipal smethod_646(WindowsIdentity windowsIdentity_0)
	{
		return new WindowsPrincipal(windowsIdentity_0);
	}

	internal static bool smethod_647(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0)
	{
		return windowsPrincipal_0.IsInRole(windowsBuiltInRole_0);
	}

	internal static int smethod_648(string string_0)
	{
		return string_0.Length;
	}

	internal static char smethod_649(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	internal static DynamicMethod smethod_650(string string_0, Type type_0, Type[] type_1, Type type_2)
	{
		return new DynamicMethod(string_0, type_0, type_1, type_2);
	}

	internal static ILGenerator smethod_651(DynamicMethod dynamicMethod_0)
	{
		return dynamicMethod_0.GetILGenerator();
	}

	internal static void smethod_652(ILGenerator ilgenerator_0, OpCode opCode_0, byte byte_0)
	{
		ilgenerator_0.Emit(opCode_0, byte_0);
	}

	internal static Delegate smethod_653(DynamicMethod dynamicMethod_0, Type type_0)
	{
		return dynamicMethod_0.CreateDelegate(type_0);
	}

	internal static void smethod_654(Random random_0, byte[] byte_0)
	{
		random_0.NextBytes(byte_0);
	}

	internal static short smethod_656(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadInt16();
	}

	internal static int smethod_657(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadInt32();
	}

	internal static int smethod_659(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
	{
		return hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_1, int_2);
	}

	internal static byte[] smethod_660(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		return hashAlgorithm_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	internal static byte[] smethod_661(HashAlgorithm hashAlgorithm_0)
	{
		return hashAlgorithm_0.Hash;
	}

	internal static NumericUpDown smethod_662()
	{
		return new NumericUpDown();
	}

	internal static Panel smethod_663()
	{
		return new Panel();
	}

	internal static ColorDialog smethod_664()
	{
		return new ColorDialog();
	}

	internal static FileStream smethod_665(string string_0)
	{
		return File.OpenWrite(string_0);
	}

	internal static PictureBox smethod_666()
	{
		return new PictureBox();
	}

	internal static LinkLabel smethod_667()
	{
		return new LinkLabel();
	}

	internal static void smethod_668(Panel panel_0, BorderStyle borderStyle_0)
	{
		panel_0.BorderStyle = borderStyle_0;
	}

	internal static Encoding smethod_670()
	{
		return Encoding.UTF8;
	}

	internal static string smethod_671(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	internal static char[] smethod_672(string string_0)
	{
		return string_0.ToCharArray();
	}

	internal static string smethod_673(char[] char_0)
	{
		return new string(char_0);
	}

	internal static void smethod_674(string string_0, string string_1, bool bool_0)
	{
		File.Copy(string_0, string_1, bool_0);
	}

	internal static AppDomain smethod_675()
	{
		return AppDomain.CurrentDomain;
	}

	internal static decimal smethod_679(NumericUpDown numericUpDown_0)
	{
		return numericUpDown_0.Value;
	}

	internal static CookieCollection smethod_692(HttpWebResponse httpWebResponse_0)
	{
		return httpWebResponse_0.Cookies;
	}

	internal static void smethod_693(CookieContainer cookieContainer_0, CookieCollection cookieCollection_0)
	{
		cookieContainer_0.Add(cookieCollection_0);
	}

	internal static ComboBox.ObjectCollection smethod_694(ComboBox comboBox_0)
	{
		return comboBox_0.Items;
	}

	internal static object smethod_695(ComboBox.ObjectCollection objectCollection_0, int int_0)
	{
		return objectCollection_0[int_0];
	}

	internal static Type smethod_696(Exception exception_0)
	{
		return exception_0.GetType();
	}

	internal static string smethod_697(Type type_0)
	{
		return type_0.FullName;
	}

	internal static string smethod_698(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	internal static Exception smethod_699(Exception exception_0)
	{
		return exception_0.InnerException;
	}

	internal static string smethod_700(string string_0)
	{
		return Path.GetFullPath(string_0);
	}

	internal static IEnumerator smethod_701(IEnumerable ienumerable_0)
	{
		return ienumerable_0.GetEnumerator();
	}

	internal static object smethod_702(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	internal static Exception smethod_703()
	{
		return new Exception();
	}

	internal static byte[] smethod_708(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	internal static void smethod_709(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	internal static Type smethod_710(object object_0)
	{
		return object_0.GetType();
	}

	internal static OperatingSystem smethod_711()
	{
		return Environment.OSVersion;
	}

	internal static PlatformID smethod_712(OperatingSystem operatingSystem_0)
	{
		return operatingSystem_0.Platform;
	}

	internal static IEnumerable<int> smethod_713(int int_0, int int_1)
	{
		return Enumerable.Range(int_0, int_1);
	}

	internal static Cursor smethod_718()
	{
		return Cursors.Default;
	}

	internal static Cursor smethod_720()
	{
		return Cursors.Hand;
	}

	internal static string smethod_721(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.FileDescription;
	}

	internal static Container smethod_723()
	{
		return new Container();
	}

	internal static FormatException smethod_729(string string_0)
	{
		return new FormatException(string_0);
	}

	internal static int smethod_730(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	internal static void smethod_732(Stream stream_0)
	{
		stream_0.Close();
	}

	internal static TabPage smethod_734()
	{
		return new TabPage();
	}

	internal static Win32Exception smethod_736(string string_0)
	{
		return new Win32Exception(string_0);
	}

	internal static string[] smethod_738(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	internal static int smethod_739(string string_0, char char_0)
	{
		return string_0.IndexOf(char_0);
	}

	internal static DirectoryInfo smethod_742(string string_0)
	{
		return Directory.CreateDirectory(string_0);
	}

	internal static int smethod_744(ComboBox.ObjectCollection objectCollection_0)
	{
		return objectCollection_0.Count;
	}

	internal static byte[] smethod_745(float float_0)
	{
		return BitConverter.GetBytes(float_0);
	}

	internal static AccessViolationException smethod_746(string string_0, Exception exception_0)
	{
		return new AccessViolationException(string_0, exception_0);
	}
}
