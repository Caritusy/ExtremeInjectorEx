using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public sealed class LdrLoadDllStubInjector : DllInjector
{
	public LdrLoadDllStubInjector(RemoteProcess gclass2_1)
		: base(gclass2_1)
	{
	}

	protected override void method_04C6()
	{
		if (!(method_2() == IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = -169182192;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -479013727)) % 4)
				{
				case 3u:
					method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, bool_0: false, method_0()));
					num = (int)(num2 * 1309822628) ^ -1366180425;
					continue;
				case 1u:
					num = ((method_0() != -1) ? (-1394104318) : (-2055603361)) ^ (int)(num2 * 727456532);
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

	public override IntPtr Inject(string string_0)
	{
		if (!Path.IsPathRooted(string_0))
		{
			goto IL_022d;
		}
		goto IL_02b7;
		IL_022d:
		int num = 1046222259;
		goto IL_0232;
		IL_0232:
		IntPtr intptr_ = default(IntPtr);
		int int_ = default(int);
		IntPtr intPtr3 = default(IntPtr);
		ProcessModuleInfo gClass = default(ProcessModuleInfo);
		uint num3 = default(uint);
		int int_2 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		while (true)
		{
			uint num2;
			IntPtr result;
			IntPtr intPtr;
			IntPtr intptr_2;
			switch ((num2 = (uint)(num ^ 0x44132215)) % 24)
			{
			case 22u:
				if (!RecoveredRuntime.smethod_427(method_19()))
				{
					num = 1708007698;
					continue;
				}
				result = (IntPtr)method_11<uint>(intptr_.smethod_8(int_));
				goto IL_03a4;
			case 21u:
				break;
			case 20u:
				intPtr = RecoveredRuntime.smethod_335(intPtr3, this, gClass);
				goto IL_0075;
			case 19u:
				num3 = method_11<uint>(intptr_.smethod_8(int_2));
				num = 2027720511;
				continue;
			case 18u:
				num = ((!(intPtr2 == IntPtr.Zero)) ? 783710234 : 1824475590) ^ (int)(num2 * 1585726709);
				continue;
			case 17u:
				goto IL_00dc;
			case 16u:
				num = ((intPtr3 == IntPtr.Zero) ? 963545619 : 598023456) ^ ((int)num2 * -2050087118);
				continue;
			case 14u:
				string_0 = Path.GetFullPath(string_0);
				num = ((int)num2 * -670772349) ^ -1709902956;
				continue;
			case 13u:
				if (!RecoveredRuntime.smethod_427(method_19()))
				{
					num = 1805344865;
					continue;
				}
				intPtr = RecoveredRuntime.smethod_197(this, intPtr3, gClass);
				goto IL_0075;
			case 8u:
				intPtr2 = RecoveredRuntime.smethod_321(this, intptr_, IntPtr.Zero);
				num = ((int)num2 * -1420133337) ^ 0x7C9839BF;
				continue;
			case 7u:
				vmethod_6(intptr_);
				num = (int)((num2 * 525511946) ^ 0x3E1209CA);
				continue;
			case 5u:
				intPtr3 = RecoveredRuntime.smethod_225(gClass, "LdrLoadDll", bool_0: false);
				num = 452747149;
				continue;
			case 4u:
				goto IL_01d0;
			case 2u:
				num = ((num3 == 0) ? 994285799 : 943099254) ^ (int)(num2 * 1234729938);
				continue;
			case 0u:
				goto end_IL_0232;
			case 3u:
				goto IL_02b7;
			case 1u:
				vmethod_6(intptr_);
				throw new AccessViolationException("Unable to create thread in the specified process.");
			case 6u:
				throw new MissingMethodException("Unable to find the LdrLoadDll function inside the specified process.");
			case 9u:
				throw new Exception("LdrLoadDll failed to load the specified DLL. (NT Status: 0x" + num3.ToString("X8") + ")", RecoveredRuntime.smethod_213(num3, this));
			case 10u:
				throw new FileNotFoundException("Unable to find the specified file for injection. (" + string_0 + ")");
			case 11u:
				throw new UnauthorizedAccessException("Unable to open the specified process for injection.");
			case 12u:
				throw new FileNotFoundException("Unable to find ntdll.dll in the specified process.");
			default:
				result = method_11<IntPtr>(intptr_.smethod_8(int_));
				goto IL_03a4;
			case 23u:
				{
					vmethod_6(intptr_);
					throw new Exception("The target process exited before injection could complete.");
				}
				IL_0075:
				intptr_2 = intPtr;
				intptr_ = method_24(intptr_2, string_0, out int_, out int_2);
				num = 835074445;
				continue;
				IL_03a4:
				vmethod_6(intptr_);
				RecoveredRuntime.smethod_108(this, intPtr2);
				return result;
			}
			RecoveredRuntime.smethod_153(this, intPtr2, -1);
			num = ((!RecoveredRuntime.HasProcessExited(method_19())) ? 1950611446 : 52706250);
			continue;
			IL_01d0:
			gClass = RecoveredRuntime.smethod_42(method_19())["ntdll.dll"];
			num = ((gClass != null) ? 894989736 : 894232897);
			continue;
			IL_00dc:
			num = ((!method_8(method_19().ProcessId)) ? 691193350 : 1322853569);
			continue;
			end_IL_0232:
			break;
		}
		goto IL_022d;
		IL_02b7:
		num = (File.Exists(string_0) ? 1656896620 : 1886342695);
		goto IL_0232;
	}

	internal IntPtr method_24(IntPtr intptr_1, string string_0, out int int_1, out int int_2)
	{
		int_1 = 0;
		int_2 = 0;
		IntPtr intPtr = RecoveredRuntime.smethod_175(this, 4096L, NativeTypes.Enum34.flag_2);
		int num6 = default(int);
		AsmJitAssembler @class = default(AsmJitAssembler);
		RemoteAssembler class47_ = default(RemoteAssembler);
		IntPtr intPtr3 = default(IntPtr);
		int num4 = default(int);
		AsmJitLabel class4 = default(AsmJitLabel);
		AsmJitLabel class2 = default(AsmJitLabel);
		AsmJitLabel class58_2 = default(AsmJitLabel);
		int num3 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		AsmJitLabel class58_3 = default(AsmJitLabel);
		byte[] bytes = default(byte[]);
		AsmJitLabel class58_ = default(AsmJitLabel);
		AsmJitLabel class58_4 = default(AsmJitLabel);
		int num5 = default(int);
		byte[] bytes2 = default(byte[]);
		string s = default(string);
		int num10 = default(int);
		int num11 = default(int);
		CallingConvention callingConvention_ = default(CallingConvention);
		int num8 = default(int);
		while (true)
		{
			int num = -1898858440;
			while (true)
			{
				uint num2;
				int num9;
				int num7;
				AsmJitGpRegister class3;
				AsmJitGpRegister class63_;
				switch ((num2 = (uint)(num ^ -714077643)) % 102)
				{
				case 101u:
					num = ((num6 >= 7) ? (-89615775) : (-1925192685));
					continue;
				case 99u:
					@class.struct19_0.uint_2 |= 8u;
					num = (int)(num2 * 680750298) ^ -293045959;
					continue;
				case 98u:
					num9 = 48;
					goto IL_005d;
				case 97u:
					RecoveredRuntime.smethod_286(class47_, intPtr3);
					RecoveredRuntime.smethod_336(class47_);
					num = (int)((num2 * 1660240198) ^ 0x3BDE49E0);
					continue;
				case 96u:
					if (!PlatformInfo.bool_6)
					{
						num = (int)((num2 * 1429324261) ^ 0x1120450);
						continue;
					}
					num7 = 5;
					goto IL_0112;
				case 95u:
					num = ((num4 < 8) ? (-1529467299) : (-418526850));
					continue;
				case 94u:
					class4 = RecoveredRuntime.smethod_48(@class);
					class2 = RecoveredRuntime.smethod_48(@class);
					class58_2 = RecoveredRuntime.smethod_48(@class);
					num = ((int)num2 * -887101663) ^ -448350978;
					continue;
				case 93u:
					num = ((num3 < 6) ? (-353122712) : (-839078401));
					continue;
				case 92u:
					RecoveredRuntime.smethod_286(class47_, (IntPtr)1);
					num = ((int)num2 * -44700098) ^ -978591446;
					continue;
				case 91u:
					RecoveredRuntime.smethod_286(class47_, intPtr3);
					num = (int)(num2 * 1477159452) ^ -290738672;
					continue;
				case 90u:
					RecoveredRuntime.smethod_286(class47_, intPtr2);
					num = (int)(num2 * 725766731) ^ -835440038;
					continue;
				case 89u:
					num = (int)((num2 * 1645573861) ^ 0x4E30BE91);
					continue;
				case 88u:
					RecoveredRuntime.smethod_105(1, @class);
					num = ((int)num2 * -2010420725) ^ -178374958;
					continue;
				case 87u:
					vmethod_6(intPtr);
					num = (int)((num2 * 78064333) ^ 0x3A1214B0);
					continue;
				case 86u:
					RecoveredRuntime.smethod_336(class47_);
					num = -1676417135;
					continue;
				case 85u:
					RecoveredRuntime.smethod_227(class47_);
					num = ((int)num2 * -904763961) ^ 0x52E934B;
					continue;
				case 84u:
					RecoveredRuntime.smethod_36(@class, class58_3);
					num = -1909802349;
					continue;
				case 83u:
					RecoveredRuntime.smethod_336(class47_);
					num = -1308570789;
					continue;
				case 82u:
					RecoveredRuntime.smethod_52(@class, (ushort)bytes.Length);
					num = (int)(num2 * 1767288594) ^ -1154563610;
					continue;
				case 81u:
					RecoveredRuntime.smethod_36(@class, class58_3);
					num = ((int)num2 * -1383593962) ^ -835080619;
					continue;
				case 80u:
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_1), CallingConvention.FastCall, new object[5]
					{
						RecoveredRuntime.smethod_84(class47_, class58_),
						RecoveredRuntime.smethod_84(class47_, class58_3),
						0,
						1,
						RecoveredRuntime.smethod_84(class47_, class2)
					});
					num = (int)(num2 * 1451910560) ^ -119142961;
					continue;
				case 79u:
					RecoveredRuntime.smethod_226(class47_, -1);
					RecoveredRuntime.smethod_227(class47_);
					RecoveredRuntime.smethod_36(@class, class58_4);
					num = -1573927404;
					continue;
				case 78u:
					num = (int)(num2 * 1940249374) ^ -909316474;
					continue;
				case 77u:
					num5 = 0;
					num = ((int)num2 * -461577044) ^ 0x27B53226;
					continue;
				case 76u:
					RecoveredRuntime.smethod_336(class47_);
					num = ((int)num2 * -1733520226) ^ -408288984;
					continue;
				case 75u:
					class58_3 = RecoveredRuntime.smethod_48(@class);
					RecoveredRuntime.smethod_15(class47_);
					num = (PlatformInfo.bool_7 ? (-1429336867) : (-448702901)) ^ ((int)num2 * -273914318);
					continue;
				case 74u:
					RecoveredRuntime.smethod_227(class47_);
					num = -1966493587;
					continue;
				case 73u:
					intPtr2 = intPtr.smethod_8(RecoveredRuntime.smethod_252(@class));
					num = ((int)num2 * -1164837872) ^ -1279120178;
					continue;
				case 72u:
					num = ((!PlatformInfo.bool_8) ? (-1696578767) : (-75594020)) ^ ((int)num2 * -52476840);
					continue;
				case 71u:
					bytes2 = Encoding.Unicode.GetBytes(s);
					RecoveredRuntime.smethod_320(@class, bytes2);
					num = (int)(num2 * 1752654412) ^ -360270511;
					continue;
				case 70u:
					RecoveredRuntime.smethod_227(class47_);
					RecoveredRuntime.smethod_36(@class, class2);
					num = ((int)num2 * -16557914) ^ 0xDE49707;
					continue;
				case 69u:
					RecoveredRuntime.smethod_439(@class, 0u);
					num = (int)((num2 * 1888668672) ^ 0x1E637C72);
					continue;
				case 68u:
					RecoveredRuntime.smethod_36(@class, class58_3);
					num = (int)((num2 * 278227010) ^ 0x18071CBC);
					continue;
				case 67u:
					num7 = 3;
					goto IL_0112;
				case 66u:
					num = (PlatformInfo.bool_5 ? (-1748880813) : (-238354774));
					continue;
				case 65u:
					num = (PlatformInfo.bool_2 ? (-12678132) : (-710032952)) ^ ((int)num2 * -125842582);
					continue;
				case 64u:
					RecoveredRuntime.smethod_336(class47_);
					RecoveredRuntime.smethod_336(class47_);
					num = (int)((num2 * 175100002) ^ 0x6BF7C045);
					continue;
				case 63u:
					RecoveredRuntime.smethod_336(class47_);
					num = (int)((num2 * 276934179) ^ 0x4265E09E);
					continue;
				case 62u:
					RecoveredRuntime.smethod_439(@class, 0u);
					num = -1529219630;
					continue;
				case 61u:
					RecoveredRuntime.smethod_336(class47_);
					num = ((int)num2 * -1919140938) ^ 0x25A26A6A;
					continue;
				case 60u:
				{
					@class = new AsmJitAssembler();
					RemoteAssembler class5 = new RemoteAssembler(@class, method_19());
					class5.method_1(bool_3: true);
					class47_ = class5;
					num = -532409899;
					continue;
				}
				case 59u:
					class3 = AsmJitRuntime.class63_54;
					goto IL_007b;
				case 58u:
					RecoveredRuntime.smethod_227(class47_);
					num = (int)(num2 * 336362263) ^ -146123859;
					continue;
				case 57u:
					num = (PlatformInfo.bool_7 ? 299623508 : 1721132611) ^ ((int)num2 * -412637068);
					continue;
				case 55u:
					num10++;
					num = (int)((num2 * 1410866940) ^ 0x5CCA1CBD);
					continue;
				case 54u:
					RecoveredRuntime.smethod_36(@class, class58_2);
					int_2 = RecoveredRuntime.smethod_252(@class);
					num = ((int)num2 * -1208583412) ^ -1816913634;
					continue;
				case 53u:
					RecoveredRuntime.smethod_336(class47_);
					RecoveredRuntime.smethod_286(class47_, intPtr3);
					num = (int)((num2 * 1304033657) ^ 0x41857ACA);
					continue;
				case 52u:
					num = (PlatformInfo.bool_2 ? (-1180776481) : (-129744340));
					continue;
				case 50u:
					class58_4 = RecoveredRuntime.smethod_48(@class);
					num = (int)((num2 * 796244634) ^ 0xBCE78DA);
					continue;
				case 49u:
					RecoveredRuntime.smethod_36(@class, class58_3);
					RecoveredRuntime.smethod_336(class47_);
					num = ((int)num2 * -1373335907) ^ 0x335FDD87;
					continue;
				case 48u:
					RecoveredRuntime.smethod_286(class47_, intPtr3);
					num10 = 0;
					num = (int)(num2 * 2065890421) ^ -1682368095;
					continue;
				case 47u:
					RecoveredRuntime.smethod_336(class47_);
					RecoveredRuntime.smethod_227(class47_);
					num = ((int)num2 * -1706024323) ^ -1572737930;
					continue;
				case 46u:
					RecoveredRuntime.smethod_36(@class, class58_3);
					RecoveredRuntime.smethod_52(@class, (ushort)(bytes2.Length - 2));
					num = ((int)num2 * -1623704815) ^ -1369476005;
					continue;
				case 45u:
					RecoveredRuntime.smethod_227(class47_);
					num = ((int)num2 * -226130856) ^ 0x4CA87DA3;
					continue;
				case 44u:
					num11 = RecoveredRuntime.smethod_252(@class);
					RecoveredRuntime.smethod_36(@class, class58_);
					num = (int)(num2 * 1297609668) ^ -863621477;
					continue;
				case 43u:
					int_1 = RecoveredRuntime.smethod_252(@class);
					num = (int)((num2 * 529575278) ^ 0x3CC037CC);
					continue;
				case 41u:
					num = ((!PlatformInfo.bool_5) ? (-839078401) : (-1287213217));
					continue;
				case 40u:
					num4 = 0;
					num = ((int)num2 * -1017564036) ^ -1819882043;
					continue;
				case 39u:
					RecoveredRuntime.smethod_227(class47_);
					num = (int)((num2 * 642748536) ^ 0x4EE7CFF8);
					continue;
				case 38u:
					RecoveredRuntime.smethod_52(@class, (ushort)bytes2.Length);
					RecoveredRuntime.smethod_227(class47_);
					num = ((int)num2 * -1508465672) ^ 0x2B3C4AC7;
					continue;
				case 37u:
					num = (int)(num2 * 341352959) ^ -1734610791;
					continue;
				case 36u:
					num = ((int)num2 * -936529569) ^ -1125835384;
					continue;
				case 35u:
					num = ((intPtr == IntPtr.Zero) ? (-1709340519) : (-1665428714)) ^ ((int)num2 * -1683197743);
					continue;
				case 34u:
					num = ((!PlatformInfo.bool_6) ? (-1223533718) : (-1483457892));
					continue;
				case 33u:
					num = ((int)num2 * -1177099228) ^ -301218554;
					continue;
				case 32u:
					intPtr3 = intPtr.smethod_8(RecoveredRuntime.smethod_252(@class));
					bytes = Encoding.Unicode.GetBytes(string_0 + "\0");
					num = (int)(num2 * 402426187) ^ -411364157;
					continue;
				case 31u:
					RecoveredRuntime.smethod_227(class47_);
					num = ((int)num2 * -487661495) ^ -578910152;
					continue;
				case 30u:
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_1), CallingConvention.StdCall, new object[6]
					{
						RecoveredRuntime.smethod_84(class47_, class58_),
						RecoveredRuntime.smethod_84(class47_, class58_3),
						0,
						1,
						0,
						RecoveredRuntime.smethod_84(class47_, class4)
					});
					num = (int)((num2 * 1546589662) ^ 0x1774156A);
					continue;
				case 29u:
					num = ((num5 >= 8) ? (-728403252) : (-844070902));
					continue;
				case 28u:
					num = (int)((num2 * 595000490) ^ 0x4FC796F0);
					continue;
				case 27u:
					RecoveredRuntime.smethod_336(class47_);
					num = (int)((num2 * 148921046) ^ 0x5CC4E2CA);
					continue;
				case 26u:
					num = ((int)num2 * -856353512) ^ 0x16D6E3C6;
					continue;
				case 25u:
					if (!RecoveredRuntime.smethod_427(method_19()))
					{
						num = ((int)num2 * -1187399992) ^ 0x2A93D37D;
						continue;
					}
					num9 = 24;
					goto IL_005d;
				case 24u:
					RecoveredRuntime.smethod_36(@class, class4);
					RecoveredRuntime.smethod_286(class47_, intPtr.smethod_8(num11));
					num = ((!(RecoveredRuntime.smethod_443(intPtr, @class, this) == IntPtr.Zero)) ? 313284391 : 786565798) ^ ((int)num2 * -1318042794);
					continue;
				case 23u:
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_1), callingConvention_, new object[6]
					{
						RecoveredRuntime.smethod_84(class47_, class58_),
						RecoveredRuntime.smethod_84(class47_, class58_3),
						0,
						1,
						RecoveredRuntime.smethod_84(class47_, class4),
						RecoveredRuntime.smethod_84(class47_, class2)
					});
					num = (int)((num2 * 1751730093) ^ 0x6CF3C17B);
					continue;
				case 22u:
					RecoveredRuntime.smethod_336(class47_);
					num = (int)((num2 * 1963328897) ^ 0x191C54F);
					continue;
				case 21u:
					num = ((!RecoveredRuntime.smethod_427(method_19())) ? (-348565149) : (-2068400396));
					continue;
				case 20u:
					s = Path.GetDirectoryName(method_19().FilePath) + ";" + PlatformInfo.string_1 + ";" + PlatformInfo.string_3 + ";" + PlatformInfo.string_0 + "\0";
					num = ((int)num2 * -922044725) ^ 0xE1D8B86;
					continue;
				case 19u:
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_1), CallingConvention.StdCall, new object[6]
					{
						0,
						IntPtr.Zero,
						IntPtr.Zero,
						RecoveredRuntime.smethod_84(class47_, class58_),
						RecoveredRuntime.smethod_84(class47_, class58_4),
						1
					});
					num = -1992533686;
					continue;
				case 18u:
					RecoveredRuntime.smethod_36(@class, class58_3);
					num = (int)((num2 * 861389034) ^ 0x2F0A0997);
					continue;
				case 17u:
					RecoveredRuntime.smethod_286(class47_, intPtr3);
					num6 = 0;
					num = ((int)num2 * -491321318) ^ -1220468850;
					continue;
				case 16u:
					num = ((num10 >= 7) ? (-1651540748) : (-2133417953));
					continue;
				case 15u:
					num = ((!PlatformInfo.bool_5) ? (-544807823) : (-839964761));
					continue;
				case 14u:
					RecoveredRuntime.smethod_336(class47_);
					num = ((int)num2 * -454427766) ^ 0x78458710;
					continue;
				case 13u:
					num = (PlatformInfo.bool_2 ? (-1952999845) : (-1171863944));
					continue;
				case 12u:
					num6++;
					num = ((int)num2 * -517837236) ^ -460891508;
					continue;
				case 11u:
					RecoveredRuntime.smethod_227(class47_);
					num = (PlatformInfo.bool_7 ? 1357073608 : 1429893588) ^ ((int)num2 * -892167841);
					continue;
				case 10u:
					RecoveredRuntime.smethod_336(class47_);
					num = ((int)num2 * -2086981538) ^ 0x5F95B541;
					continue;
				case 9u:
					RecoveredRuntime.smethod_439(@class, 0u);
					num5++;
					num = -581525622;
					continue;
				case 8u:
					num3++;
					num = ((int)num2 * -1119807638) ^ -730656654;
					continue;
				case 7u:
					RecoveredRuntime.smethod_336(class47_);
					num = ((int)num2 * -1209123789) ^ -1731914006;
					continue;
				case 6u:
					RecoveredRuntime.smethod_75(@class, RecoveredRuntime.smethod_126(class58_2, 0L), AsmJitRuntime.class63_37);
					num = -454015508;
					continue;
				case 5u:
					class58_ = RecoveredRuntime.smethod_48(@class);
					num = ((int)num2 * -520749919) ^ 0x251E3EA4;
					continue;
				case 4u:
					RecoveredRuntime.smethod_336(class47_);
					num = -920244310;
					continue;
				case 3u:
					num4++;
					num = ((int)num2 * -2094044581) ^ 0xF0950DB;
					continue;
				case 2u:
					RecoveredRuntime.smethod_52(@class, (ushort)(bytes.Length - 2));
					num = ((int)num2 * -341711602) ^ 0x3BAB69E3;
					continue;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 1447656530) ^ -1471834187;
					continue;
				case 0u:
					RecoveredRuntime.smethod_320(@class, bytes);
					num = (int)((num2 * 636783786) ^ 0x65692FE2);
					continue;
				case 56u:
					break;
				case 51u:
					throw new AccessViolationException("Unable to allocate memory for the LdrpLoadDll code.");
				case 100u:
					throw new InvalidOperationException("Unable to generate code for the LdrLoadDll stub.");
				default:
					{
						return intPtr;
					}
					IL_005d:
					num8 = num9;
					if (!RecoveredRuntime.smethod_427(method_19()))
					{
						num = -159378372;
						continue;
					}
					class3 = AsmJitRuntime.class63_38;
					goto IL_007b;
					IL_007b:
					class63_ = class3;
					RecoveredRuntime.smethod_429(@class, class63_, RecoveredRuntime.smethod_221(class47_, PlatformInfo.bool_7 ? class2 : class4, 0L));
					RecoveredRuntime.smethod_429(@class, class63_, RecoveredRuntime.smethod_417(class63_, num8, class47_));
					RecoveredRuntime.smethod_75(@class, RecoveredRuntime.smethod_221(class47_, class58_4, 0L), class63_);
					num = -961223918;
					continue;
					IL_0112:
					callingConvention_ = (CallingConvention)num7;
					num = -330139360;
					continue;
				}
				break;
			}
		}
	}

	internal static bool smethod_7(string string_0)
	{
		return Path.IsPathRooted(string_0);
	}

	internal static string smethod_8(string string_0)
	{
		return Path.GetFullPath(string_0);
	}

	internal static bool smethod_9(string string_0)
	{
		return File.Exists(string_0);
	}

	internal static string smethod_10(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	internal static FileNotFoundException smethod_11(string string_0)
	{
		return new FileNotFoundException(string_0);
	}

	internal static UnauthorizedAccessException smethod_12(string string_0)
	{
		return new UnauthorizedAccessException(string_0);
	}

	internal static MissingMethodException smethod_13(string string_0)
	{
		return new MissingMethodException(string_0);
	}

	internal static AccessViolationException smethod_14(string string_0)
	{
		return new AccessViolationException(string_0);
	}

	internal static Exception smethod_15(string string_0)
	{
		return new Exception(string_0);
	}

	internal static Encoding smethod_16()
	{
		return Encoding.Unicode;
	}

	internal static string smethod_17(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static byte[] smethod_18(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	internal static string smethod_19(string string_0)
	{
		return Path.GetDirectoryName(string_0);
	}

	internal static string smethod_20(string[] string_0)
	{
		return string.Concat(string_0);
	}

	internal static InvalidOperationException smethod_21(string string_0)
	{
		return new InvalidOperationException(string_0);
	}
}
