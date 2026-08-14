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

	internal static void smethod_15(RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			goto IL_01d5;
		}
		goto IL_02d3;
		IL_01d5:
		int num = 1187696634;
		goto IL_026e;
		IL_026e:
		AsmJitAssembler class53_ = default(AsmJitAssembler);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5049091C)) % 17)
			{
			case 16u:
				smethod_75(class47_0.class53_0, smethod_238(AsmJitRuntime.class63_57, 24L), AsmJitRuntime.class63_61);
				num = (int)((num2 * 1746904381) ^ 0xBDC7F80);
				continue;
			case 15u:
				smethod_418(36, class47_0.class53_0);
				num = ((int)num2 * -1856611688) ^ 0x59B9A022;
				continue;
			case 14u:
				class47_0.class58_1 = smethod_48(class47_0.class53_0);
				num = ((int)num2 * -848056874) ^ -526862878;
				continue;
			case 13u:
				smethod_418(131, class47_0.class53_0);
				smethod_418(4, class47_0.class53_0);
				num = ((int)num2 * -1156983299) ^ 0x7E2755BF;
				continue;
			case 12u:
				smethod_75(class47_0.class53_0, smethod_126(class47_0.class58_1, 0L), AsmJitRuntime.class63_41);
				class53_ = class47_0.class53_0;
				num = (int)((num2 * 966856432) ^ 0x2BC7B1BD);
				continue;
			case 10u:
				smethod_418(5, class47_0.class53_0);
				smethod_418(203, class47_0.class53_0);
				num = (int)(num2 * 1732949850) ^ -698119908;
				continue;
			case 9u:
			{
				AsmJitGpRegister class63_ = AsmJitRuntime.class63_41;
				AsmJitImmediate class57_ = smethod_374(4294967280u);
				smethod_23(class63_, class57_, class53_);
				smethod_418(106, class47_0.class53_0);
				num = (int)((num2 * 2068701569) ^ 0x5A52C1E8);
				continue;
			}
			case 7u:
				smethod_75(class47_0.class53_0, smethod_238(AsmJitRuntime.class63_57, 16L), AsmJitRuntime.class63_55);
				num = (int)((num2 * 376998474) ^ 0x377C94C7);
				continue;
			case 5u:
				smethod_418(51, class47_0.class53_0);
				smethod_418(232, class47_0.class53_0);
				smethod_439(class47_0.class53_0, 0u);
				num = (int)((num2 * 1448497055) ^ 0x29A0F099);
				continue;
			case 4u:
				break;
			case 3u:
				smethod_82(class47_0.class53_0, AsmJitRuntime.class63_42);
				num = ((int)num2 * -2116699661) ^ -255508387;
				continue;
			case 2u:
				class47_0.class53_0.struct19_0.uint_2 |= 8u;
				num = ((int)num2 * -1050884535) ^ 0x2AA1C5B0;
				continue;
			case 1u:
				smethod_318(class47_0.class53_0, AsmJitRuntime.class63_42, AsmJitRuntime.class63_41);
				num = (int)(num2 * 755218750) ^ -1869089995;
				continue;
			case 0u:
				smethod_75(class47_0.class53_0, smethod_238(AsmJitRuntime.class63_57, 8L), AsmJitRuntime.class63_54);
				num = 1458901024;
				continue;
			case 11u:
				goto IL_02d3;
			case 6u:
				return;
			default:
				smethod_75(class47_0.class53_0, smethod_238(AsmJitRuntime.class63_57, 32L), AsmJitRuntime.class63_62);
				return;
			}
			break;
		}
		goto IL_01d5;
		IL_02d3:
		num = (class47_0.bool_1 ? 1434133484 : 1497108864);
		goto IL_026e;
	}

	internal static AsmJitOperand.Struct13 smethod_16(AsmJitOperand class56_0)
	{
		return AsmJitOperand.smethod_0<AsmJitOperand.Struct7, AsmJitOperand.Struct13>(class56_0.method_0());
	}

	internal static void smethod_20(AsmJitAssembler class53_0)
	{
		if (!class53_0.method_0())
		{
			goto IL_0008;
		}
		goto IL_005a;
		IL_0008:
		int num = -505350396;
		goto IL_0035;
		IL_0035:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1771032293)) % 5)
			{
			case 4u:
				break;
			case 2u:
				num = (AsmJitRuntime.bool_0 ? 499761726 : 158839544) ^ (int)(num2 * 634876672);
				continue;
			default:
				return;
			case 3u:
				goto IL_005a;
			case 1u:
				throw new InvalidOperationException("This instruction is only available in x64 mode.");
			case 0u:
				return;
			}
			break;
		}
		goto IL_0008;
		IL_005a:
		smethod_31(class53_0, AsmJitInstructionId.const_466);
		num = -91744275;
		goto IL_0035;
	}

	internal static void smethod_23(AsmJitGpRegister class63_0, AsmJitImmediate class57_0, AsmJitAssembler class53_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_10, class63_0, class57_0);
	}

	internal static bool smethod_26(ManualMapInjector class89_0, ManualMapInjector.Class172 class172_0)
	{
		byte[] array = ManualMapInjector.smethod_7(class172_0.method_0());
		AsmJitAssembler @class = default(AsmJitAssembler);
		RemoteAssembler class2 = default(RemoteAssembler);
		AsmJitLabel class58_ = default(AsmJitLabel);
		ProcessModuleInfo gClass = default(ProcessModuleInfo);
		IntPtr intPtr2 = default(IntPtr);
		NativeTypes.Struct52 gparam_2 = default(NativeTypes.Struct52);
		IntPtr intPtr = default(IntPtr);
		NativeTypes.Struct51 gparam_ = default(NativeTypes.Struct51);
		string tempFileName = default(string);
		while (true)
		{
			int num = -1258531032;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1443353583)) % 27)
				{
				case 26u:
					@class = new AsmJitAssembler();
					num = -1122508537;
					continue;
				case 25u:
					num = (smethod_427(class89_0.method_19()) ? 848312522 : 1159463344) ^ (int)(num2 * 954473858);
					continue;
				case 24u:
					class2 = new RemoteAssembler(@class, class89_0.method_19());
					class58_ = smethod_48(@class);
					smethod_15(class2);
					num = ((int)num2 * -63947719) ^ 0x53D70BB2;
					continue;
				case 23u:
					class2.method_4<IntPtr>();
					num = (int)((num2 * 2125379434) ^ 0x1A63D503);
					continue;
				case 22u:
					num = ((gClass != null) ? (-999920717) : (-2119019942)) ^ ((int)num2 * -1226992556);
					continue;
				case 20u:
					intPtr2 = smethod_225(gClass, "CreateActCtxW", bool_0: false);
					num = -36187558;
					continue;
				case 19u:
					gparam_2.int_0 = typeof(NativeTypes.Struct52).smethod_7();
					gparam_2.intptr_0 = intPtr.smethod_8(smethod_252(@class));
					num = (int)((num2 * 1468163334) ^ 0x27A8E10E);
					continue;
				case 18u:
					num = ((int)num2 * -374693124) ^ -2130770767;
					continue;
				case 14u:
					class172_0.method_13(class89_0.method_22<IntPtr>(class2, intPtr, bool_2: true));
					num = -1773771938;
					continue;
				case 12u:
					gClass = smethod_42(class89_0.method_19())["kernel32.dll"];
					num = -1373156490;
					continue;
				case 11u:
					intPtr = smethod_175(class89_0, 4096L, NativeTypes.Enum34.flag_2);
					num = ((!(intPtr == IntPtr.Zero)) ? 1116662100 : 180805032) ^ ((int)num2 * -1388759173);
					continue;
				case 10u:
					num = ((intPtr2 == IntPtr.Zero) ? 980196084 : 1632087816) ^ (int)(num2 * 66576407);
					continue;
				case 9u:
					smethod_54(class2, new AsmJitImmediate(intPtr2), CallingConvention.StdCall, new object[1] { smethod_84(class2, class58_) });
					num = ((int)num2 * -718224445) ^ 0x3B41212;
					continue;
				case 8u:
					@class.method_2(gparam_);
					num = ((int)num2 * -2109154805) ^ -1670989238;
					continue;
				case 7u:
					tempFileName = Path.GetTempFileName();
					File.WriteAllBytes(tempFileName, array);
					num = -709951988;
					continue;
				case 6u:
					smethod_320(@class, Encoding.Unicode.GetBytes(tempFileName + "\0"));
					smethod_227(class2);
					smethod_36(@class, class58_);
					@class.method_2(gparam_2);
					num = (int)((num2 * 1421188708) ^ 0x330C83D9);
					continue;
				case 5u:
					smethod_226(class2, -1);
					smethod_227(class2);
					num = (int)(num2 * 198860040) ^ -223470;
					continue;
				case 4u:
					smethod_227(class2);
					smethod_36(@class, class58_);
					num = (int)(num2 * 2071285507) ^ -196341934;
					continue;
				case 3u:
					num = ((array != null) ? (-798451944) : (-122760755)) ^ ((int)num2 * -2136322131);
					continue;
				case 1u:
					gparam_2 = default(NativeTypes.Struct52);
					num = -1437511661;
					continue;
				case 0u:
					gparam_ = new NativeTypes.Struct51
					{
						int_0 = typeof(NativeTypes.Struct51).smethod_7(),
						uint_1 = (uint)((int)intPtr + smethod_252(@class))
					};
					smethod_320(@class, Encoding.Unicode.GetBytes(tempFileName + "\0"));
					num = ((int)num2 * -1584942624) ^ -1616480940;
					continue;
				case 21u:
					break;
				case 2u:
					return true;
				case 13u:
					File.Delete(tempFileName);
					return smethod_128(class89_0, new AccessViolationException("Unable to allocate memory for activation context stub."));
				default:
					return true;
				case 16u:
					return true;
				case 17u:
					return smethod_128(class89_0, new MissingMethodException("Unable to find CreateActCtxW inside kernel32.dll."));
				}
				break;
			}
		}
	}

	internal static void smethod_31(AsmJitAssembler class53_0, AsmJitInstructionId enum7_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.smethod_11()(ref class53_0.struct19_0, enum7_0);
		}
		else
		{
			AsmJitApi.smethod_4()(ref class53_0.struct19_0, enum7_0);
		}
	}

	internal static void smethod_32(AsmJitJumpHint enum12_0, AsmJitLabel class58_0, AsmJitAssembler class53_0)
	{
		smethod_256(class58_0, enum12_0, class53_0, AsmJitInstructionId.const_225);
	}

	internal static void smethod_36(AsmJitAssembler class53_0, AsmJitLabel class58_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			goto IL_0029;
		}
		goto IL_0053;
		IL_0029:
		int num = 1986250196;
		goto IL_002e;
		IL_002e:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x13CB37C2)) % 5)
			{
			case 3u:
				AsmJitApi.smethod_49()(ref class53_0.struct19_0, class58_0);
				num = ((int)num2 * -947920963) ^ 0x2F522074;
				continue;
			case 2u:
				break;
			default:
				return;
			case 1u:
				goto IL_0053;
			case 0u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0029;
		IL_0053:
		AsmJitApi.smethod_47()(ref class53_0.struct19_0, class58_0);
		num = 1518986711;
		goto IL_002e;
	}

	internal static bool InvokeExport(MainForm.ModuleRow class21_0, IntPtr intptr_0, MainForm mainForm)
	{
		ExportedSymbol class3 = default(ExportedSymbol);
		int num9 = default(int);
		object[] array = default(object[]);
		RemoteAssembler class47_ = default(RemoteAssembler);
		AsmJitAssembler class5 = default(AsmJitAssembler);
		List<AsmJitLabel> list2 = default(List<AsmJitLabel>);
		List<object> list = default(List<object>);
		string text = default(string);
		int num8 = default(int);
		long num10 = default(long);
		int num11 = default(int);
		while (true)
		{
			int num = 72746129;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x460EA75B)) % 5)
				{
				case 4u:
					num = ((int)num2 * -1740599076) ^ -1619867697;
					continue;
				case 3u:
					num = ((!HasProcessExited(mainForm.selectedProcess)) ? 1796612693 : 423241358) ^ ((int)num2 * -1062268972);
					continue;
				case 2u:
					break;
				case 0u:
					throw new InvalidOperationException("The target process is no longer active.");
				default:
				{
					FileStream fileStream = new FileStream(GetModulePath(class21_0), FileMode.Open, FileAccess.Read, FileShare.Read);
					try
					{
						PeImage class2 = PeExportReader.Read(fileStream, GetModulePath(class21_0), ownsStream: false, layout: PeImageLayout.const_0);
						try
						{
							if (class2.method_14() == null)
							{
								goto IL_00cc;
							}
							goto IL_0103;
							IL_00cc:
							int num3 = 1170273542;
							goto IL_00d1;
							IL_00d1:
							switch ((uint)(num3 ^ 0x460EA75B) % 5u)
							{
							case 3u:
								break;
							default:
								goto end_IL_00b4;
							case 1u:
								goto IL_0103;
							case 0u:
								throw new MissingMethodException("Unable to find the exported routine, '" + class21_0.Entry.ExportName + "'.");
							case 4u:
								throw new MissingFieldException("Unable to detect export directory in the specified module.");
							case 2u:
								goto end_IL_00b4;
							}
							goto IL_00cc;
							IL_0103:
							class3 = class2.method_14().list_1.FirstOrDefault(export => export.method_4() == class21_0.Entry.ExportName);
							num3 = ((class3 != null) ? 1875164677 : 2096044763);
							goto IL_00d1;
							end_IL_00b4:;
						}
						finally
						{
							if (class2 != null)
							{
								while (true)
								{
									IL_01a3:
									int num4 = 1328130802;
									while (true)
									{
										switch ((num2 = (uint)(num4 ^ 0x460EA75B)) % 3)
										{
										case 2u:
											goto IL_0170;
										default:
											goto end_IL_0185;
										case 0u:
											break;
										case 1u:
											goto end_IL_0185;
										}
										goto IL_01a3;
										IL_0170:
										((IDisposable)class2).Dispose();
										num4 = ((int)num2 * -1174344794) ^ -531990266;
										continue;
										end_IL_0185:
										break;
									}
									break;
								}
							}
						}
					}
					finally
					{
						if (fileStream != null)
						{
							while (true)
							{
								IL_01e4:
								int num5 = 888732473;
								while (true)
								{
									switch ((num2 = (uint)(num5 ^ 0x460EA75B)) % 3)
									{
									case 1u:
										goto IL_01b1;
									default:
										goto end_IL_01c6;
									case 0u:
										break;
									case 2u:
										goto end_IL_01c6;
									}
									goto IL_01e4;
									IL_01b1:
									((IDisposable)fileStream).Dispose();
									num5 = ((int)num2 * -324139211) ^ -990825792;
									continue;
									end_IL_01c6:
									break;
								}
								break;
							}
						}
					}
					IntPtr intptr_1 = intptr_0.smethod_9(class3.method_6());
					while (true)
					{
						int num6 = 534266462;
						while (true)
						{
							switch ((num2 = (uint)(num6 ^ 0x460EA75B)) % 33)
							{
							case 32u:
								num6 = ((num9 >= array.Length) ? 768547781 : 973708458);
								continue;
							case 31u:
								smethod_226(class47_, -1);
								num6 = (int)(num2 * 1880940475) ^ -374943923;
								continue;
							case 30u:
							{
								AsmJitLabel class6 = smethod_48(class5);
								list2.Add(class6);
								list.Add(smethod_84(class47_, class6));
								num6 = (int)((num2 * 54606) ^ 0x5E51E37D);
								continue;
							}
							case 29u:
								smethod_15(class47_);
								num6 = ((int)num2 * -212515327) ^ -908933102;
								continue;
							case 28u:
								num9++;
								num6 = 23605831;
								continue;
							case 27u:
								num6 = ((class21_0.Entry.Parameters != null) ? 277257009 : 458827322) ^ (int)(num2 * 1073412424);
								continue;
							case 26u:
								num6 = ((text == null) ? (-737539902) : (-781970105)) ^ (int)(num2 * 1280621455);
								continue;
							case 25u:
								smethod_418(0, class5);
								num6 = ((int)num2 * -2031373568) ^ 0x3ADEFA02;
								continue;
							case 24u:
								smethod_54(class47_, new AsmJitImmediate(intptr_1), class21_0.Entry.CallingConvention, list.ToArray());
								num6 = ((int)num2 * -833880767) ^ -355695803;
								continue;
							case 23u:
								text = array[num9] as string;
								num6 = 207993883;
								continue;
							case 22u:
								class47_ = new RemoteAssembler(class5, mainForm.selectedProcess);
								list2 = new List<AsmJitLabel>();
								num6 = (int)(num2 * 1666297250) ^ -1722348554;
								continue;
							case 21u:
								array = class21_0.Entry.Parameters.Select(smethod_138).ToArray();
								class5 = new AsmJitAssembler();
								num6 = 361321445;
								continue;
							case 20u:
								list = new List<object>();
								num8 = 0;
								num6 = (int)(num2 * 2128581540) ^ -319960742;
								continue;
							case 19u:
								num6 = ((array[num8] is string) ? 38147963 : 816649650);
								continue;
							case 18u:
								list.Add(((ulong)(num10 & 0xFFFFFFFFL)).smethod_0());
								num6 = (int)(num2 * 1183786450) ^ -1674758520;
								continue;
							case 17u:
								list.Add(((ulong)(num10 & -4294967296L) >> 32).smethod_0());
								num6 = ((int)num2 * -1183410051) ^ 0x2AA7C96B;
								continue;
							case 15u:
								smethod_227(class47_);
								num6 = (int)((num2 * 1225654093) ^ 0x5A723097);
								continue;
							case 14u:
								num6 = ((num8 >= array.Length) ? 1913190811 : 584225830);
								continue;
							case 12u:
								smethod_36(class5, list2[num11++]);
								num6 = ((class21_0.Entry.Parameters[num9].Type != ExportParameterType.AnsiString) ? 603531166 : 1483483870) ^ ((int)num2 * -612483973);
								continue;
							case 11u:
								num11 = 0;
								num6 = ((int)num2 * -822281546) ^ 0x229DE7AE;
								continue;
							case 10u:
								smethod_320(class5, Encoding.Unicode.GetBytes(text));
								smethod_105(0, class5);
								num6 = 1806823426;
								continue;
							case 9u:
								num6 = ((class21_0.Entry.Parameters[num8].Type != ExportParameterType.UInt64) ? 999067885 : 24045617) ^ ((int)num2 * -1483361820);
								continue;
							case 8u:
								num6 = (smethod_427(mainForm.selectedProcess) ? 1596134350 : 1875134809);
								continue;
							case 7u:
								num6 = ((int)num2 * -1199280702) ^ 0x4B2314FA;
								continue;
							case 6u:
								class21_0.Entry.Parameters = new List<ExportParameter>();
								num6 = (int)(num2 * 932447528) ^ -163800271;
								continue;
							case 5u:
								num10 = (long)array[num8];
								num6 = ((int)num2 * -1201005529) ^ 0x62581D4A;
								continue;
							case 4u:
								num6 = ((int)num2 * -560534925) ^ 0x445ED6AA;
								continue;
							case 3u:
								num8++;
								num6 = 921915070;
								continue;
							case 2u:
								num9 = 0;
								num6 = (int)(num2 * 1749684053) ^ -565240236;
								continue;
							case 1u:
								smethod_320(class5, Encoding.ASCII.GetBytes(text));
								num6 = (int)(num2 * 60815747) ^ -881080710;
								continue;
							case 0u:
								list.Add(array[num8].smethod_0());
								num6 = 847621368;
								continue;
							case 16u:
								break;
							default:
							{
								RemoteCodeExecutor class4 = new RemoteCodeExecutor(mainForm.selectedProcess);
								try
								{
									return smethod_140(class4, class5);
								}
								finally
								{
									if (class4 != null)
									{
										while (true)
										{
											IL_075a:
											int num7 = 2094227502;
											while (true)
											{
												switch ((num2 = (uint)(num7 ^ 0x460EA75B)) % 3)
												{
												case 1u:
													goto IL_0727;
												default:
													goto end_IL_073c;
												case 2u:
													break;
												case 0u:
													goto end_IL_073c;
												}
												goto IL_075a;
												IL_0727:
												((IDisposable)class4).Dispose();
												num7 = ((int)num2 * -158544961) ^ 0x303678CB;
												continue;
												end_IL_073c:
												break;
											}
											break;
										}
									}
								}
							}
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	internal static void smethod_39(AsmJitGpRegister class63_0, RemoteAssembler class47_0, RemoteAssembler.Enum6 enum6_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[2]
		{
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_39
		};
		if (enum6_0 < RemoteAssembler.Enum6.const_2)
		{
			while (true)
			{
				int num = 1944652368;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7BE4CEA5)) % 4)
					{
					case 1u:
						smethod_318(class47_0.class53_0, array[(int)enum6_0], class63_0);
						num = (int)(num2 * 1669180148) ^ -936052402;
						continue;
					case 0u:
						break;
					case 3u:
						return;
					default:
						goto end_IL_005a;
					}
					break;
				}
				continue;
				end_IL_005a:
				break;
			}
		}
		smethod_82(class47_0.class53_0, class63_0);
	}

	internal static AsmJitLabel smethod_48(AsmJitAssembler class53_0)
	{
		AsmJitLabel @class = new AsmJitLabel();
		if (AsmJitRuntime.bool_0)
		{
			goto IL_0030;
		}
		goto IL_0056;
		IL_0030:
		int num = -1343311329;
		goto IL_0035;
		IL_0035:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -872701947)) % 4)
			{
			case 2u:
				AsmJitApi.smethod_45()(ref class53_0.struct19_0, @class);
				num = ((int)num2 * -1408394789) ^ 0x5CBF6C44;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0056;
			default:
				return @class;
			}
			break;
		}
		goto IL_0030;
		IL_0056:
		AsmJitApi.smethod_43()(ref class53_0.struct19_0, @class);
		num = -980063622;
		goto IL_0035;
	}

	internal static bool smethod_49(AsmJitOperand class56_0, AsmJitOperand class56_1)
	{
		return !smethod_328(class56_0, class56_1);
	}

	internal static AsmJitMemoryManager smethod_51()
	{
		return new NativeAsmJitMemoryManager(AsmJitMemoryManager.delegate41_0());
	}

	internal static void smethod_52(AsmJitAssembler class53_0, ushort ushort_0)
	{
		smethod_308(2L, ushort_0, class53_0);
	}

	internal static void smethod_53(AsmJitAssembler class53_0)
	{
		if (!class53_0.method_0())
		{
			while (true)
			{
				int num = -1315959667;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -386372948)) % 4)
					{
					case 1u:
						num = ((!AsmJitRuntime.bool_0) ? 1898818375 : 1076915690) ^ (int)(num2 * 1293123976);
						continue;
					case 0u:
						break;
					case 2u:
						throw new InvalidOperationException("This instruction is only available in x86 mode.");
					default:
						goto end_IL_0051;
					}
					break;
				}
				continue;
				end_IL_0051:
				break;
			}
		}
		smethod_31(class53_0, AsmJitInstructionId.const_422);
	}

	internal static void smethod_54(RemoteAssembler class47_0, AsmJitImmediate class57_0, CallingConvention callingConvention_0, object[] object_0)
	{
		smethod_83(object_0, callingConvention_0, class57_0, class47_0);
	}

	internal static void smethod_55(AsmJitAssembler class53_0)
	{
		if (!class53_0.method_0())
		{
			goto IL_0032;
		}
		goto IL_005c;
		IL_0032:
		int num = 2007550817;
		goto IL_0037;
		IL_0037:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x133B41A7)) % 5)
			{
			case 3u:
				num = (AsmJitRuntime.bool_0 ? 1309333914 : 1500478594) ^ (int)(num2 * 610774414);
				continue;
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_005c;
			case 2u:
				throw new InvalidOperationException("This instruction is only available in x86 mode.");
			case 4u:
				return;
			}
			break;
		}
		goto IL_0032;
		IL_005c:
		smethod_31(class53_0, AsmJitInstructionId.const_420);
		num = 1954586311;
		goto IL_0037;
	}

	internal static void smethod_57(AsmJitOperand.Struct14 struct14_0, AsmJitOperand class56_0)
	{
		class56_0.method_1(AsmJitOperand.smethod_0<AsmJitOperand.Struct14, AsmJitOperand.Struct7>(struct14_0));
	}

	internal static AsmJitImmediate smethod_59(sbyte sbyte_0)
	{
		return new AsmJitImmediate((IntPtr)sbyte_0);
	}

	internal static IntPtr smethod_61(AsmJitAssembler class53_0, RemoteCodeExecutorBase class84_0)
	{
		return smethod_443(IntPtr.Zero, class53_0, class84_0);
	}

	internal static void smethod_68(AsmJitAssembler class53_0, AsmJitXmmRegister class65_0, AsmJitGpRegister class63_0)
	{
		if (!class53_0.method_0())
		{
			while (true)
			{
				int num = 481217105;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x2B9635E7)) % 4)
					{
					case 2u:
						num = ((!AsmJitRuntime.bool_0) ? (-1835674768) : (-740240534)) ^ ((int)num2 * -1734933389);
						continue;
					case 0u:
						break;
					case 1u:
						throw new InvalidOperationException("This instruction is only available in x64 mode.");
					default:
						goto end_IL_0051;
					}
					break;
				}
				continue;
				end_IL_0051:
				break;
			}
		}
		smethod_137(class53_0, AsmJitInstructionId.const_289, class65_0, class63_0);
	}

	internal static AsmJitImmediate smethod_72(byte byte_0)
	{
		return new AsmJitImmediate((IntPtr)byte_0, bool_0: true);
	}

	internal static void smethod_75(AsmJitAssembler class53_0, AsmJitMemoryOperand class59_0, AsmJitGpRegister class63_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_266, class59_0, class63_0);
	}

	internal static AsmJitMemoryOperand smethod_80(long long_0, RemoteAssembler class47_0, AsmJitLabel class58_0)
	{
		if (class47_0.bool_0)
		{
			while (true)
			{
				int num = -266895509;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1065384508)) % 3)
					{
					case 1u:
						class47_0.class53_0.struct19_0.uint_2 |= 8u;
						num = (int)((num2 * 1859920697) ^ 0x35367297);
						continue;
					case 2u:
						break;
					default:
						goto end_IL_0049;
					}
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
		return smethod_126(class58_0, long_0);
	}

	internal static void smethod_82(AsmJitAssembler class53_0, AsmJitGpRegister class63_0)
	{
		smethod_352(class63_0, AsmJitInstructionId.const_463, class53_0);
	}

	internal static void smethod_83(object[] object_0, CallingConvention callingConvention_0, AsmJitOperand class56_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			goto IL_0008;
		}
		goto IL_002c;
		IL_0008:
		int num = 107200593;
		goto IL_000d;
		IL_000d:
		switch ((uint)(num ^ 0x5322E4DC) % 4u)
		{
		case 0u:
			break;
		default:
			return;
		case 2u:
			goto IL_002c;
		case 1u:
			smethod_358(class56_0, object_0, callingConvention_0, class47_0);
			return;
		case 3u:
			return;
		}
		goto IL_0008;
		IL_002c:
		smethod_365(class47_0, class56_0, object_0);
		num = 63399227;
		goto IL_000d;
	}

	internal static object smethod_84(RemoteAssembler class47_0, AsmJitLabel class58_0)
	{
		return new RemoteAssembler.Class48(class58_0);
	}

	internal static void smethod_91(AsmJitLabel class58_0, AsmJitJumpHint enum12_0, AsmJitAssembler class53_0)
	{
		smethod_149(AsmJitInstructionId.const_240, class58_0, class53_0, enum12_0);
	}

	internal static void smethod_94(AsmJitAssembler class53_0)
	{
		if (!class53_0.method_0())
		{
			while (true)
			{
				int num = -1187826456;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -348140675)) % 4)
					{
					case 1u:
						num = ((!AsmJitRuntime.bool_0) ? (-91515736) : (-1073536982)) ^ (int)(num2 * 1891261021);
						continue;
					case 3u:
						break;
					case 2u:
						throw new InvalidOperationException("This instruction is only available in x86 mode.");
					default:
						goto end_IL_0051;
					}
					break;
				}
				continue;
				end_IL_0051:
				break;
			}
		}
		smethod_31(class53_0, AsmJitInstructionId.const_465);
	}

	internal static void smethod_98(AsmJitAssembler class53_0, ulong ulong_0)
	{
		smethod_308(8L, ulong_0, class53_0);
	}

	internal static void smethod_105(ushort ushort_0, AsmJitAssembler class53_0)
	{
		smethod_308(2L, ushort_0, class53_0);
	}

	internal static void smethod_110(AsmJitImmediate class57_0, AsmJitMemoryOperand class59_0, AsmJitAssembler class53_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_64, class59_0, class57_0);
	}

	internal static void smethod_112(RemoteAssembler.Enum6 enum6_0, AsmJitImmediate class57_0, RemoteAssembler class47_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[2]
		{
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_39
		};
		while (true)
		{
			int num = -571977475;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1910256609)) % 7)
				{
				case 3u:
					num = ((smethod_219(class57_0).intptr_0 == IntPtr.Zero) ? 759899138 : 245411398) ^ (int)(num2 * 1099436875);
					continue;
				case 2u:
					num = ((enum6_0 >= RemoteAssembler.Enum6.const_2) ? 1260589441 : 1124186668) ^ ((int)num2 * -76952853);
					continue;
				case 1u:
					smethod_298(class47_0.class53_0, class57_0);
					num = -1271876836;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					smethod_306(class47_0.class53_0, array[(int)enum6_0], class57_0);
					return;
				case 5u:
					return;
				case 6u:
					smethod_164(class47_0.class53_0, array[(int)enum6_0], array[(int)enum6_0]);
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_115(AsmJitAssembler class53_0)
	{
		class53_0.struct19_0.struct15_0.method_0();
		while (true)
		{
			int num = 1798072902;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2656FB73)) % 3)
				{
				case 1u:
					goto IL_0012;
				case 0u:
					break;
				default:
					class53_0.struct19_0.struct18_0.method_0();
					class53_0.struct19_0.uint_0 = 0u;
					return;
				}
				break;
				IL_0012:
				class53_0.struct19_0.struct17_0.method_0();
				class53_0.struct19_0.struct18_1.method_0();
				num = (int)((num2 * 883304366) ^ 0x5FC29636);
			}
		}
	}

	internal static AsmJitMemoryOperand smethod_116(AsmJitLabel class58_0, long long_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			while (true)
			{
				int num = -1243577564;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1205310931)) % 3)
					{
					case 2u:
						class47_0.class53_0.struct19_0.uint_2 |= 8u;
						num = (int)((num2 * 1185718550) ^ 0x48D00187);
						continue;
					case 0u:
						break;
					default:
						goto end_IL_0049;
					}
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
		return smethod_364(class58_0, long_0);
	}

	internal static void smethod_118(AsmJitAssembler class53_0, IntPtr intptr_0)
	{
		smethod_308(IntPtr.Size, intptr_0, class53_0);
	}

	internal static void smethod_121(RemoteAssembler class47_0, AsmJitImmediate class57_0, int int_0, bool bool_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[4]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		AsmJitXmmRegister[] array2 = new AsmJitXmmRegister[4]
		{
			AsmJitRuntime.class65_0,
			AsmJitRuntime.class65_1,
			AsmJitRuntime.class65_2,
			AsmJitRuntime.class65_3
		};
		bool flag = smethod_219(class57_0).intptr_0 == IntPtr.Zero;
		while (true)
		{
			int num = -644702325;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1514443797)) % 17)
				{
				case 16u:
					smethod_164(class47_0.class53_0, array[int_0], array[int_0]);
					num = (int)((num2 * 834807351) ^ 0x3CDF5A3F);
					continue;
				case 14u:
					smethod_306(class47_0.class53_0, AsmJitRuntime.class63_53, class57_0);
					num = -352165479;
					continue;
				case 12u:
					num = ((int_0 >= 4) ? (-124176856) : (-1661161595)) ^ (int)(num2 * 158674543);
					continue;
				case 11u:
					smethod_306(class47_0.class53_0, array[int_0], class57_0);
					num = -1795795489;
					continue;
				case 10u:
					num = (flag ? (-1905073565) : (-443665538));
					continue;
				case 8u:
					num = (bool_0 ? 1110974086 : 737571191) ^ ((int)num2 * -1589946831);
					continue;
				case 7u:
					smethod_164(class47_0.class53_0, AsmJitRuntime.class63_53, AsmJitRuntime.class63_53);
					num = (int)((num2 * 1717565688) ^ 0xAF29A59);
					continue;
				case 6u:
					num = ((!flag) ? (-1110369353) : (-1878756229)) ^ ((int)num2 * -1841662369);
					continue;
				case 5u:
					smethod_164(class47_0.class53_0, AsmJitRuntime.class63_53, AsmJitRuntime.class63_53);
					num = -1049273267;
					continue;
				case 4u:
					num = ((!flag) ? (-332630357) : (-63223526));
					continue;
				case 3u:
					smethod_306(class47_0.class53_0, AsmJitRuntime.class63_53, class57_0);
					num = (int)(num2 * 1089930465) ^ -389581548;
					continue;
				case 1u:
					num = ((int)num2 * -728698216) ^ 0x22BCA2FD;
					continue;
				case 15u:
					break;
				case 0u:
					smethod_68(class47_0.class53_0, array2[int_0], AsmJitRuntime.class63_53);
					return;
				case 2u:
					return;
				case 9u:
					return;
				default:
					smethod_75(class47_0.class53_0, smethod_238(AsmJitRuntime.class63_57, int_0 * 8), AsmJitRuntime.class63_53);
					return;
				}
				break;
			}
		}
	}

	internal static AsmJitImmediate smethod_125(ulong ulong_0)
	{
		if (!PlatformInfo.bool_0)
		{
			return new AsmJitImmediate((IntPtr)(int)ulong_0);
		}
		return new AsmJitImmediate((IntPtr)(long)ulong_0);
	}

	internal static AsmJitMemoryOperand smethod_126(AsmJitLabel class58_0, long long_0)
	{
		return smethod_161(4u, (IntPtr)long_0, class58_0);
	}

	internal static void smethod_127(AsmJitImmediate class57_0, AsmJitMemoryOperand class59_0, AsmJitAssembler class53_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_266, class59_0, class57_0);
	}

	internal static bool smethod_134(AsmJitRegister class62_0, AsmJitRegister class62_1)
	{
		if (class62_1 == null)
		{
			goto IL_0036;
		}
		goto IL_0070;
		IL_0036:
		int num = -1249018911;
		goto IL_003b;
		IL_003b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1006511978)) % 6)
			{
			case 1u:
				num = ((class62_0 != null) ? (-2137661679) : (-1684772406)) ^ ((int)num2 * -1567517001);
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0070;
			default:
				return class62_1.Equals(class62_0);
			case 4u:
				return false;
			case 5u:
				return true;
			}
			break;
		}
		goto IL_0036;
		IL_0070:
		num = ((class62_1 == null) ? (-1598677240) : (-825412133));
		goto IL_003b;
	}

	internal static void smethod_137(AsmJitAssembler class53_0, AsmJitInstructionId enum7_0, AsmJitOperand class56_0, AsmJitOperand class56_1)
	{
		if (AsmJitRuntime.bool_0)
		{
			goto IL_0007;
		}
		goto IL_002b;
		IL_0007:
		int num = 595926341;
		goto IL_000c;
		IL_000c:
		switch ((uint)(num ^ 0x2BD36C38) % 4u)
		{
		case 3u:
			break;
		default:
			return;
		case 2u:
			goto IL_002b;
		case 0u:
			return;
		case 1u:
			AsmJitApi.smethod_15()(ref class53_0.struct19_0, enum7_0, class56_0, class56_1);
			return;
		}
		goto IL_0007;
		IL_002b:
		AsmJitApi.smethod_8()(ref class53_0.struct19_0, enum7_0, class56_0, class56_1);
		num = 1496366956;
		goto IL_000c;
	}

	internal static bool smethod_140(RemoteCodeExecutor class91_0, AsmJitAssembler class53_0)
	{
		return smethod_239(class53_0, class91_0);
	}

	internal static IntPtr smethod_142(ThreadHijackInjector class90_0, IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, out NativeTypes.Struct54 struct54_0, out int int_0, out int int_1, ref int int_2)
	{
		struct54_0 = default(NativeTypes.Struct54);
		int_0 = 0;
		int_1 = 0;
		AsmJitAssembler @class = new AsmJitAssembler();
		@class.method_1(bool_1: true);
		AsmJitAssembler class2 = @class;
		AsmJitLabel class58_ = smethod_48(class2);
		AsmJitGpRegister class63_ = default(AsmJitGpRegister);
		AsmJitGpRegister[] array = default(AsmJitGpRegister[]);
		AsmJitLabel class58_4 = default(AsmJitLabel);
		AsmJitGpRegister class63_2 = default(AsmJitGpRegister);
		AsmJitGpRegister class63_3 = default(AsmJitGpRegister);
		AsmJitLabel class58_5 = default(AsmJitLabel);
		AsmJitMemoryOperand class59_ = default(AsmJitMemoryOperand);
		int num3 = default(int);
		AsmJitGpRegister[] array2 = default(AsmJitGpRegister[]);
		AsmJitLabel class58_3 = default(AsmJitLabel);
		AsmJitLabel class58_2 = default(AsmJitLabel);
		while (true)
		{
			int num = -2048418765;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2057354372)) % 30)
				{
				case 29u:
					smethod_173(class2);
					num = ((int)num2 * -1435349910) ^ -1852544493;
					continue;
				case 28u:
					class63_ = array.smethod_2();
					num = ((int)num2 * -1394858336) ^ -1624765270;
					continue;
				case 27u:
					smethod_298(class2, smethod_374(struct54_0.uint_17));
					num = (int)((num2 * 2085609091) ^ 0x6D5AFA4B);
					continue;
				case 25u:
					smethod_53(class2);
					smethod_347(class2);
					smethod_200(class2, 4u);
					num = (int)(num2 * 611504890) ^ -533582899;
					continue;
				case 24u:
					class2.struct19_0.uint_2 |= 8u;
					num = (int)((num2 * 1478971600) ^ 0x14C4C891);
					continue;
				case 23u:
					smethod_36(class2, class58_);
					num = ((int)num2 * -398182065) ^ -1867424194;
					continue;
				case 22u:
					smethod_82(class2, class63_);
					num = ((int)num2 * -2038543312) ^ -1998734664;
					continue;
				case 21u:
					class58_4 = smethod_48(class2);
					num = ((int)num2 * -615381917) ^ -719376932;
					continue;
				case 20u:
					smethod_310(class63_2, class63_3, class2);
					smethod_91(class58_5, AsmJitJumpHint.const_0, class2);
					num = (int)(num2 * 69512701) ^ -287439830;
					continue;
				case 19u:
					class59_ = smethod_126(class58_4, 0L);
					num = ((int)num2 * -1534160978) ^ 0x5B3D3D8A;
					continue;
				case 18u:
					smethod_306(class2, array[num3], new AsmJitImmediate(intptr_1));
					num = ((int)num2 * -202348127) ^ -612259958;
					continue;
				case 17u:
					smethod_372(array2[num3], class2);
					class2.struct19_0.uint_2 |= 8u;
					smethod_75(class2, smethod_126(class58_3, 0L), AsmJitRuntime.class63_37);
					class63_2 = AsmJitRuntime.class63_37;
					class63_3 = AsmJitRuntime.class63_37;
					num = ((int)num2 * -560529742) ^ 0x4AD43C96;
					continue;
				case 16u:
					class2.struct19_0.uint_2 |= 8u;
					smethod_75(class2, smethod_126(class58_2, 0L), AsmJitRuntime.class63_37);
					num = (int)((num2 * 339217226) ^ 0x796D8914);
					continue;
				case 15u:
					smethod_320(class2, byte_0);
					num = (int)(num2 * 1936125983) ^ -482241611;
					continue;
				case 14u:
					smethod_36(class2, class58_5);
					num = (int)((num2 * 344720032) ^ 0x70A3F4D);
					continue;
				case 13u:
					class2.struct19_0.uint_2 |= 8u;
					num = ((int)num2 * -2043439191) ^ 0x6DBB7510;
					continue;
				case 12u:
					smethod_372(array2[num3], class2);
					num = ((int)num2 * -213602687) ^ 0x60F4A12E;
					continue;
				case 11u:
					class58_3 = smethod_48(class2);
					class58_2 = smethod_48(class2);
					class58_5 = smethod_48(class2);
					num = ((int)num2 * -722958491) ^ -1086788480;
					continue;
				case 10u:
					num3 = array.smethod_3();
					num = ((int)num2 * -597646032) ^ -617822571;
					continue;
				case 8u:
					int_1 = smethod_252(class2);
					smethod_439(class2, 0u);
					smethod_36(class2, class58_4);
					num = (int)(num2 * 1086304263) ^ -523408708;
					continue;
				case 7u:
					array2 = new AsmJitGpRegister[7]
					{
						AsmJitRuntime.class63_69,
						AsmJitRuntime.class63_72,
						AsmJitRuntime.class63_71,
						AsmJitRuntime.class63_70,
						AsmJitRuntime.class63_76,
						AsmJitRuntime.class63_74,
						AsmJitRuntime.class63_60
					};
					num = (int)((num2 * 627800004) ^ 0x1B91A11C);
					continue;
				case 6u:
					smethod_94(class2);
					num = (int)(num2 * 499716291) ^ -150531643;
					continue;
				case 5u:
					smethod_306(class2, array[num3], new AsmJitImmediate(intptr_0));
					num = (int)(num2 * 1433490231) ^ -1859193754;
					continue;
				case 4u:
					int_0 = smethod_252(class2);
					num = (int)(num2 * 550792982) ^ -124544148;
					continue;
				case 3u:
					smethod_263(class2, class63_, smethod_126(class58_, 0L));
					num = ((int)num2 * -410680118) ^ 0x3E272308;
					continue;
				case 2u:
				{
					AsmJitImmediate class57_ = smethod_167(1);
					smethod_127(class57_, class59_, class2);
					smethod_55(class2);
					num = ((int)num2 * -2063622367) ^ -2002027075;
					continue;
				}
				case 1u:
					array = new AsmJitGpRegister[7]
					{
						AsmJitRuntime.class63_37,
						AsmJitRuntime.class63_40,
						AsmJitRuntime.class63_39,
						AsmJitRuntime.class63_38,
						AsmJitRuntime.class63_44,
						AsmJitRuntime.class63_42,
						AsmJitRuntime.class63_59
					};
					num = ((int)num2 * -2011828964) ^ 0x4B25FBAD;
					continue;
				case 0u:
					smethod_200(class2, 4u);
					smethod_36(class2, class58_2);
					int_2 = smethod_252(class2);
					smethod_439(class2, 0u);
					smethod_200(class2, 4u);
					smethod_36(class2, class58_3);
					num = (int)((num2 * 1761900705) ^ 0x32B12E56);
					continue;
				case 9u:
					break;
				default:
					smethod_439(class2, 0u);
					return smethod_61(class2, class90_0);
				}
				break;
			}
		}
	}

	internal static void smethod_149(AsmJitInstructionId enum7_0, AsmJitLabel class58_0, AsmJitAssembler class53_0, AsmJitJumpHint enum12_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			goto IL_002b;
		}
		goto IL_0055;
		IL_002b:
		int num = 597276120;
		goto IL_0030;
		IL_0030:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x728D9C89)) % 5)
			{
			case 3u:
				AsmJitApi.smethod_41()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
				num = (int)(num2 * 756304326) ^ -2006243969;
				continue;
			case 2u:
				break;
			default:
				return;
			case 1u:
				goto IL_0055;
			case 0u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_002b;
		IL_0055:
		AsmJitApi.smethod_39()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
		num = 287275651;
		goto IL_0030;
	}

	internal static void smethod_150(AsmJitOperand class56_0, AsmJitOperand.Struct12 struct12_0)
	{
		class56_0.method_1(AsmJitOperand.smethod_0<AsmJitOperand.Struct12, AsmJitOperand.Struct7>(struct12_0));
	}

	internal static AsmJitMemoryOperand smethod_161(uint uint_0, IntPtr intptr_0, AsmJitLabel class58_0)
	{
		AsmJitMemoryOperand @class = new AsmJitMemoryOperand();
		AsmJitApi.smethod_51()(@class, class58_0, intptr_0, uint_0);
		return @class;
	}

	internal static void smethod_164(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitGpRegister class63_1)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_575, class63_0, class63_1);
	}

	internal static AsmJitImmediate smethod_167(int int_0)
	{
		return new AsmJitImmediate((IntPtr)int_0);
	}

	internal static void smethod_169(AsmJitMemoryOperand class59_0, AsmJitGpRegister class63_0, AsmJitAssembler class53_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_1, class63_0, class59_0);
	}

	internal static void smethod_171(AsmJitAssembler class53_0, AsmJitGpRegister class63_0)
	{
		smethod_352(class63_0, AsmJitInstructionId.const_419, class53_0);
	}

	internal static void smethod_173(AsmJitAssembler class53_0)
	{
		if (!class53_0.method_0())
		{
			goto IL_0032;
		}
		goto IL_005c;
		IL_0032:
		int num = 1447506176;
		goto IL_0037;
		IL_0037:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6D10EC64)) % 5)
			{
			case 2u:
				num = (AsmJitRuntime.bool_0 ? 1184734117 : 594743410) ^ ((int)num2 * -1612408583);
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_005c;
			case 4u:
				throw new InvalidOperationException("This instruction is only available in x86 mode.");
			case 1u:
				return;
			}
			break;
		}
		goto IL_0032;
		IL_005c:
		smethod_31(class53_0, AsmJitInstructionId.const_464);
		num = 1160325670;
		goto IL_0037;
	}

	internal static IntPtr smethod_178(ThreadHijackInjector class90_0, IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, out NativeTypes.Struct55 struct55_0, out int int_0, out int int_1, ref int int_2)
	{
		struct55_0 = default(NativeTypes.Struct55);
		int_0 = 0;
		int_1 = 0;
		AsmJitAssembler class53_ = new AsmJitAssembler();
		AsmJitLabel class58_ = smethod_48(class53_);
		int num4 = default(int);
		AsmJitGpRegister[] array = default(AsmJitGpRegister[]);
		ulong num3 = default(ulong);
		AsmJitGpRegister class63_3 = default(AsmJitGpRegister);
		AsmJitLabel class58_3 = default(AsmJitLabel);
		AsmJitMemoryOperand class59_ = default(AsmJitMemoryOperand);
		AsmJitLabel class58_6 = default(AsmJitLabel);
		AsmJitImmediate class57_2 = default(AsmJitImmediate);
		AsmJitLabel class58_2 = default(AsmJitLabel);
		AsmJitLabel class58_5 = default(AsmJitLabel);
		AsmJitGpRegister[] array2 = default(AsmJitGpRegister[]);
		AsmJitLabel class58_4 = default(AsmJitLabel);
		AsmJitGpRegister class63_2 = default(AsmJitGpRegister);
		while (true)
		{
			int num = -2111155643;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1265218909)) % 45)
				{
				case 44u:
					num = ((num4 >= array.Length) ? (-2064250982) : (-416337602));
					continue;
				case 43u:
					num = ((num3 == 0L) ? (-360469638) : (-1060070033)) ^ (int)(num2 * 1000903636);
					continue;
				case 42u:
					num4++;
					num = ((int)num2 * -1572151555) ^ -1777887503;
					continue;
				case 41u:
					smethod_36(class53_, class58_);
					num = (int)(num2 * 359887414) ^ -82057740;
					continue;
				case 40u:
					smethod_372(class63_3, class53_);
					num = (int)(num2 * 1112202912) ^ -55717196;
					continue;
				case 39u:
					int_2 = smethod_252(class53_);
					smethod_36(class53_, class58_3);
					smethod_439(class53_, 0u);
					smethod_200(class53_, 8u);
					num = ((int)num2 * -1332537631) ^ -633990160;
					continue;
				case 38u:
				{
					AsmJitGpRegister class63_6 = array[num4];
					smethod_82(class53_, class63_6);
					num = -2004827943;
					continue;
				}
				case 37u:
					class59_ = smethod_126(class58_6, 0L);
					class57_2 = smethod_167(1);
					num = ((int)num2 * -1224324970) ^ 0x225F7D51;
					continue;
				case 36u:
					smethod_36(class53_, class58_2);
					num = ((int)num2 * -1656207294) ^ -1651162520;
					continue;
				case 34u:
					smethod_200(class53_, 8u);
					num = (int)(num2 * 1110028581) ^ -997294892;
					continue;
				case 33u:
					smethod_36(class53_, class58_5);
					int_1 = smethod_252(class53_);
					smethod_118(class53_, IntPtr.Zero);
					num = ((int)num2 * -2141142957) ^ -1026693771;
					continue;
				case 32u:
					smethod_36(class53_, class58_6);
					num = ((int)num2 * -888341313) ^ 0x517E6E99;
					continue;
				case 31u:
					class58_6 = smethod_48(class53_);
					num = (int)(num2 * 642084513) ^ -1412265932;
					continue;
				case 30u:
					smethod_127(class57_2, class59_, class53_);
					num = ((int)num2 * -664381764) ^ -741070242;
					continue;
				case 28u:
					num4 = 0;
					num = ((int)num2 * -1495698515) ^ 0x7B8BB2B3;
					continue;
				case 27u:
					Array.Reverse(array2);
					num = -1540210179;
					continue;
				case 26u:
					smethod_297(class53_);
					num = ((int)num2 * -1481077302) ^ -1817840574;
					continue;
				case 25u:
					class58_5 = smethod_48(class53_);
					num = (int)(num2 * 405472283) ^ -437875733;
					continue;
				case 24u:
					smethod_91(class58_2, AsmJitJumpHint.const_0, class53_);
					num = (int)(num2 * 1025717141) ^ -196938389;
					continue;
				case 23u:
					num3 = (ulong)((long)struct55_0.ulong_16 - (long)(IntPtr.Size * (2 + array2.Length))) % 16uL;
					num = ((num3 != 0L) ? (-1717241392) : (-26593848)) ^ ((int)num2 * -960528037);
					continue;
				case 22u:
					class58_3 = smethod_48(class53_);
					smethod_371(class53_, smethod_329(class58_4, 0L));
					array2 = new AsmJitGpRegister[15]
					{
						AsmJitRuntime.class63_53,
						AsmJitRuntime.class63_54,
						AsmJitRuntime.class63_55,
						AsmJitRuntime.class63_56,
						AsmJitRuntime.class63_58,
						AsmJitRuntime.class63_59,
						AsmJitRuntime.class63_60,
						AsmJitRuntime.class63_61,
						AsmJitRuntime.class63_62,
						AsmJitRuntime.class63_63,
						AsmJitRuntime.class63_64,
						AsmJitRuntime.class63_65,
						AsmJitRuntime.class63_66,
						AsmJitRuntime.class63_67,
						AsmJitRuntime.class63_68
					};
					array2.smethod_4();
					num = (int)(num2 * 429527046) ^ -1738194259;
					continue;
				case 21u:
					array = array2;
					num = ((int)num2 * -248591880) ^ -1161013293;
					continue;
				case 20u:
					smethod_75(class53_, smethod_329(class58_5, 0L), AsmJitRuntime.class63_53);
					class63_2 = AsmJitRuntime.class63_53;
					num = ((int)num2 * -630075215) ^ 0x5EF8EAA1;
					continue;
				case 19u:
					num4 = 0;
					num = (int)((num2 * 993330166) ^ 0x17F40A9A);
					continue;
				case 18u:
					smethod_306(class53_, class63_3, new AsmJitImmediate(intptr_1));
					num = ((int)num2 * -1914529697) ^ 0x2C5F4A90;
					continue;
				case 17u:
				{
					AsmJitGpRegister class63_5 = array[num4];
					smethod_171(class53_, class63_5);
					num4++;
					num = -1998586996;
					continue;
				}
				case 16u:
					smethod_263(class53_, AsmJitRuntime.class63_54, smethod_329(class58_, 0L));
					class63_3 = new AsmJitGpRegister[6]
					{
						AsmJitRuntime.class63_53,
						AsmJitRuntime.class63_55,
						AsmJitRuntime.class63_56,
						AsmJitRuntime.class63_58,
						AsmJitRuntime.class63_59,
						AsmJitRuntime.class63_60
					}.smethod_2();
					smethod_306(class53_, class63_3, new AsmJitImmediate(intptr_0));
					num = -995664462;
					continue;
				case 15u:
					array = array2;
					num = (int)((num2 * 1971146982) ^ 0x1AC6F266);
					continue;
				case 14u:
					int_0 = smethod_252(class53_);
					smethod_439(class53_, 0u);
					num = ((int)num2 * -1622213535) ^ 0x6ED5CAD4;
					continue;
				case 13u:
					class58_4 = smethod_48(class53_);
					num = (int)((num2 * 633806371) ^ 0x3F424ADD);
					continue;
				case 12u:
					num = ((num4 < array.Length) ? (-630125802) : (-1517491092));
					continue;
				case 11u:
					smethod_20(class53_);
					num = (int)((num2 * 968758232) ^ 0x19246797);
					continue;
				case 10u:
				{
					AsmJitGpRegister class63_4 = AsmJitRuntime.class63_57;
					AsmJitImmediate class57_ = smethod_125(num3);
					smethod_190(class63_4, class57_, class53_);
					num = ((int)num2 * -1982796345) ^ 0x706B37DB;
					continue;
				}
				case 9u:
					smethod_200(class53_, 8u);
					num = (int)((num2 * 478389072) ^ 0x5F70E722);
					continue;
				case 8u:
					smethod_347(class53_);
					num = ((int)num2 * -438977605) ^ 0x13730D40;
					continue;
				case 7u:
					smethod_363(class53_, AsmJitRuntime.class63_57, smethod_125(num3));
					num = (int)(num2 * 1940763118) ^ -1691503986;
					continue;
				case 6u:
					smethod_372(class63_3, class53_);
					num = ((int)num2 * -1091271359) ^ 0x76687A17;
					continue;
				case 5u:
				{
					AsmJitGpRegister class63_ = AsmJitRuntime.class63_53;
					smethod_310(class63_2, class63_, class53_);
					num = (int)((num2 * 411221918) ^ 0x3EFE3296);
					continue;
				}
				case 4u:
					smethod_36(class53_, class58_4);
					smethod_98(class53_, struct55_0.ulong_28);
					num = ((int)num2 * -130908194) ^ -1439769193;
					continue;
				case 3u:
					smethod_75(class53_, smethod_126(class58_3, 0L), AsmJitRuntime.class63_37);
					num = (int)((num2 * 765112438) ^ 0x2357FAB);
					continue;
				case 2u:
					smethod_200(class53_, 8u);
					num = (int)(num2 * 2113779622) ^ -2067404525;
					continue;
				case 1u:
					class58_2 = smethod_48(class53_);
					num = (int)((num2 * 620110552) ^ 0x71F59B1C);
					continue;
				case 0u:
					smethod_320(class53_, byte_0);
					num = ((int)num2 * -2090987103) ^ 0xCABB3DC;
					continue;
				case 35u:
					break;
				default:
					return smethod_61(class53_, class90_0);
				}
				break;
			}
		}
	}

	internal static void smethod_181(object object_0, RemoteAssembler class47_0, RemoteAssembler.Enum6 enum6_0)
	{
		RemoteAssembler.Class48 @class = object_0 as RemoteAssembler.Class48;
		AsmJitMemoryOperand class59_ = default(AsmJitMemoryOperand);
		AsmJitImmediate class2 = default(AsmJitImmediate);
		AsmJitGpRegister class3 = default(AsmJitGpRegister);
		while (true)
		{
			int num = -307481787;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1943350127)) % 13)
				{
				case 8u:
					num = ((@class == null) ? 624897134 : 74775435) ^ ((int)num2 * -770862114);
					continue;
				case 7u:
					smethod_263(class47_0.class53_0, AsmJitRuntime.class63_37, smethod_221(class47_0, @class.method_0(), 0L));
					smethod_39(AsmJitRuntime.class63_37, class47_0, enum6_0);
					num = ((int)num2 * -1577482625) ^ 0x43E1400F;
					continue;
				case 6u:
					class59_ = object_0 as AsmJitMemoryOperand;
					num = -1314020461;
					continue;
				case 5u:
					num = (smethod_278(class59_, null) ? (-497940270) : (-1967569884)) ^ (int)(num2 * 212262744);
					continue;
				case 2u:
					class2 = object_0.smethod_0();
					num = -981871488;
					continue;
				case 1u:
					num = (smethod_49(class2, null) ? (-2139150582) : (-1423917370)) ^ ((int)num2 * -401374236);
					continue;
				case 0u:
					class3 = object_0 as AsmJitGpRegister;
					num = ((!smethod_392(null, class3)) ? (-1653079716) : (-1109504707));
					continue;
				case 12u:
					break;
				case 3u:
					smethod_39(class3, class47_0, enum6_0);
					return;
				case 4u:
					smethod_431(enum6_0, class47_0, class59_);
					return;
				default:
					throw new InvalidOperationException("Unknown object type.");
				case 10u:
					return;
				case 11u:
					smethod_112(enum6_0, class2, class47_0);
					return;
				}
				break;
			}
		}
	}

	internal static AsmJitOperand.Struct9 smethod_188(AsmJitOperand class56_0)
	{
		return AsmJitOperand.smethod_0<AsmJitOperand.Struct7, AsmJitOperand.Struct9>(class56_0.method_0());
	}

	internal static void smethod_189(IntPtr intptr_0)
	{
		if (AsmJitRuntime.delegate0_0 == null)
		{
			goto IL_0022;
		}
		goto IL_0048;
		IL_0022:
		int num = 1600419388;
		goto IL_0027;
		IL_0027:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3A9982CF)) % 4)
			{
			case 3u:
				AsmJitRuntime.delegate0_0 = smethod_207();
				num = ((int)num2 * -1778335261) ^ 0x16E06B3E;
				continue;
			case 2u:
				break;
			default:
				return;
			case 0u:
				goto IL_0048;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0022;
		IL_0048:
		AsmJitRuntime.delegate0_0(intptr_0);
		num = 1346836210;
		goto IL_0027;
	}

	internal static void smethod_190(AsmJitGpRegister class63_0, AsmJitImmediate class57_0, AsmJitAssembler class53_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_560, class63_0, class57_0);
	}

	internal static AsmJitAssembler smethod_191(RemoteAssembler class47_0)
	{
		return class47_0.class53_0;
	}

	internal static AsmJitImmediate smethod_195(long long_0)
	{
		if (!PlatformInfo.bool_0)
		{
			return new AsmJitImmediate((IntPtr)(int)long_0);
		}
		return new AsmJitImmediate((IntPtr)long_0);
	}

	internal static void smethod_199(int int_0, RemoteAssembler class47_0, AsmJitGpRegister class63_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[4]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		if (int_0 < 4)
		{
			goto IL_002b;
		}
		goto IL_0082;
		IL_002b:
		int num = -874063077;
		goto IL_005d;
		IL_005d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -48508189)) % 5)
			{
			case 2u:
				break;
			case 0u:
				smethod_75(class47_0.class53_0, smethod_238(AsmJitRuntime.class63_57, int_0 * 8), AsmJitRuntime.class63_53);
				num = ((int)num2 * -1557266712) ^ -112569558;
				continue;
			default:
				return;
			case 3u:
				goto IL_0082;
			case 1u:
				return;
			case 4u:
				smethod_318(class47_0.class53_0, array[int_0], class63_0);
				return;
			}
			break;
		}
		goto IL_002b;
		IL_0082:
		smethod_318(class47_0.class53_0, AsmJitRuntime.class63_53, class63_0);
		num = -657653372;
		goto IL_005d;
	}

	internal static void smethod_200(AsmJitAssembler class53_0, uint uint_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			while (true)
			{
				int num = 121528500;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x175D0C0F)) % 4)
					{
					case 3u:
						AsmJitApi.smethod_65()(ref class53_0.struct19_0, uint_0);
						num = ((int)num2 * -1668988340) ^ -2101865998;
						continue;
					case 0u:
						break;
					case 1u:
						return;
					default:
						goto end_IL_0048;
					}
					break;
				}
				continue;
				end_IL_0048:
				break;
			}
		}
		AsmJitApi.smethod_63()(ref class53_0.struct19_0, uint_0);
	}

	internal static void smethod_205(AsmJitGpRegister class63_0, AsmJitAssembler class53_0, AsmJitGpRegister class63_1)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_64, class63_0, class63_1);
	}

	internal static AsmJitOperand.Struct8 smethod_218(AsmJitOperand class56_0)
	{
		return AsmJitOperand.smethod_0<AsmJitOperand.Struct7, AsmJitOperand.Struct8>(class56_0.method_0());
	}

	internal static AsmJitOperand.Struct12 smethod_219(AsmJitOperand class56_0)
	{
		return AsmJitOperand.smethod_0<AsmJitOperand.Struct7, AsmJitOperand.Struct12>(class56_0.method_0());
	}

	internal static void smethod_220(AsmJitJumpHint enum12_0, AsmJitLabel class58_0, AsmJitAssembler class53_0)
	{
		smethod_256(class58_0, enum12_0, class53_0, AsmJitInstructionId.const_223);
	}

	internal static AsmJitMemoryOperand smethod_221(RemoteAssembler class47_0, AsmJitLabel class58_0, long long_0)
	{
		if (class47_0.bool_0)
		{
			class47_0.class53_0.struct19_0.uint_2 |= 8u;
			return smethod_126(class58_0, long_0);
		}
		return smethod_329(class58_0, long_0);
	}

	internal static void smethod_222(AsmJitAssembler class53_0, int int_0)
	{
		smethod_308(4L, int_0, class53_0);
	}

	internal static int smethod_224(ref BeaEngineDisasm struct31_0)
	{
		return BeaEngineDisassembler.delegate44_0(ref struct31_0);
	}

	internal static void smethod_226(RemoteAssembler class47_0, int int_0)
	{
		if (class47_0.bool_0)
		{
			goto IL_0175;
		}
		goto IL_04bf;
		IL_0175:
		int num = 1189979764;
		goto IL_0435;
		IL_0435:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2A5C47ED)) % 30)
			{
			case 29u:
				smethod_418(13, class47_0.class53_0);
				num = (int)((num2 * 1729407365) ^ 0x53F0594C);
				continue;
			case 28u:
				smethod_418(232, class47_0.class53_0);
				num = (int)((num2 * 1474013262) ^ 0x2EE43B2F);
				continue;
			case 27u:
				num = (int)((num2 * 744374997) ^ 0x7B48A303);
				continue;
			case 26u:
				smethod_360(class47_0.class53_0, smethod_167((int_0 == -1) ? 4 : int_0));
				smethod_227(class47_0);
				num = 1126171423;
				continue;
			case 24u:
				smethod_171(class47_0.class53_0, AsmJitRuntime.class63_42);
				num = (int)(num2 * 906442768) ^ -1189727333;
				continue;
			case 22u:
				class47_0.method_3(smethod_252(class47_0.class53_0));
				num = ((int)num2 * -1394908335) ^ -437876051;
				continue;
			case 21u:
				smethod_429(class47_0.class53_0, AsmJitRuntime.class63_41, smethod_126(class47_0.class58_1, 0L));
				num = ((int)num2 * -569134392) ^ 0x11EF1979;
				continue;
			case 20u:
				smethod_439(class47_0.class53_0, 0u);
				smethod_418(199, class47_0.class53_0);
				smethod_418(68, class47_0.class53_0);
				num = ((int)num2 * -2048412739) ^ 0x572A5D58;
				continue;
			case 19u:
				smethod_418(36, class47_0.class53_0);
				num = ((int)num2 * -1184774464) ^ 0x422D2851;
				continue;
			case 18u:
				smethod_347(class47_0.class53_0);
				num = 1817863374;
				continue;
			case 17u:
				break;
			case 16u:
				smethod_429(class47_0.class53_0, AsmJitRuntime.class63_55, smethod_238(AsmJitRuntime.class63_57, 16L));
				num = (int)(num2 * 718733664) ^ -738810777;
				continue;
			case 15u:
				smethod_227(class47_0);
				smethod_36(class47_0.class53_0, class47_0.class58_0);
				num = (int)((num2 * 274840067) ^ 0x456F7748);
				continue;
			case 14u:
				smethod_36(class47_0.class53_0, class47_0.class58_1);
				num = (int)(num2 * 874890200) ^ -328666880;
				continue;
			case 13u:
				smethod_418(0, class47_0.class53_0);
				smethod_418(0, class47_0.class53_0);
				smethod_418(0, class47_0.class53_0);
				num = ((int)num2 * -1220556248) ^ -360329765;
				continue;
			case 12u:
				smethod_360(class47_0.class53_0, smethod_167((int_0 == -1) ? 4 : int_0));
				num = 1996083784;
				continue;
			case 11u:
				goto IL_0258;
			case 10u:
				class47_0.class53_0.struct19_0.uint_2 |= 8u;
				num = ((int)num2 * -139110068) ^ -1940251412;
				continue;
			case 9u:
				num = ((!class47_0.bool_1) ? 1938258210 : 2103563978) ^ ((int)num2 * -871427367);
				continue;
			case 8u:
				smethod_320(class47_0.class53_0, new byte[class47_0.int_0]);
				num = (int)(num2 * 280379461) ^ -229724170;
				continue;
			case 7u:
				smethod_429(class47_0.class53_0, AsmJitRuntime.class63_62, smethod_238(AsmJitRuntime.class63_57, 32L));
				num = ((int)num2 * -888350539) ^ 0x7F181E17;
				continue;
			case 6u:
				smethod_418(131, class47_0.class53_0);
				smethod_418(4, class47_0.class53_0);
				smethod_418(36, class47_0.class53_0);
				num = ((int)num2 * -1211377801) ^ 0x18DBC4D2;
				continue;
			case 5u:
				smethod_439(class47_0.class53_0, 0u);
				num = (int)((num2 * 1288639036) ^ 0x70711738);
				continue;
			case 4u:
				smethod_429(class47_0.class53_0, AsmJitRuntime.class63_61, smethod_238(AsmJitRuntime.class63_57, 24L));
				num = ((int)num2 * -2091822961) ^ -1277348170;
				continue;
			case 3u:
				smethod_318(class47_0.class53_0, AsmJitRuntime.class63_41, AsmJitRuntime.class63_42);
				num = ((int)num2 * -562338653) ^ -666257430;
				continue;
			case 2u:
				smethod_418(4, class47_0.class53_0);
				smethod_418(35, class47_0.class53_0);
				num = ((int)num2 * -1008665874) ^ -1379574234;
				continue;
			case 1u:
				num = ((int)num2 * -377100248) ^ 0x196F8D06;
				continue;
			case 0u:
				smethod_418(203, class47_0.class53_0);
				num = ((int)num2 * -231773239) ^ 0x1B90B079;
				continue;
			default:
				return;
			case 25u:
				goto IL_04bf;
			case 23u:
				return;
			}
			break;
			IL_0258:
			num = ((!smethod_49(class47_0.class58_0, null)) ? 206547758 : 295699762);
		}
		goto IL_0175;
		IL_04bf:
		smethod_429(class47_0.class53_0, AsmJitRuntime.class63_54, smethod_238(AsmJitRuntime.class63_57, 8L));
		num = 113233291;
		goto IL_0435;
	}

	internal static void smethod_227(RemoteAssembler class47_0)
	{
		smethod_200(class47_0.class53_0, class47_0.bool_0 ? 4u : 8u);
	}

	internal static void smethod_236(int int_0, AsmJitLabel class58_0, RemoteAssembler class47_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[4]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		while (true)
		{
			int num = 1210646683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1605827C)) % 6)
				{
				case 3u:
					smethod_263(class47_0.class53_0, array[int_0], smethod_221(class47_0, class58_0, 0L));
					num = (int)(num2 * 563434055) ^ -464546206;
					continue;
				case 2u:
					smethod_263(class47_0.class53_0, AsmJitRuntime.class63_53, smethod_221(class47_0, class58_0, 0L));
					smethod_75(class47_0.class53_0, smethod_238(AsmJitRuntime.class63_57, int_0 * 8), AsmJitRuntime.class63_53);
					num = 1484663116;
					continue;
				case 1u:
					num = ((int_0 >= 4) ? (-62745234) : (-1004842189)) ^ (int)(num2 * 2052989890);
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	internal static AsmJitMemoryOperand smethod_238(AsmJitGpRegister class63_0, long long_0)
	{
		return smethod_433((IntPtr)long_0, 8u, class63_0);
	}

	internal static bool smethod_239(AsmJitAssembler class53_0, RemoteCodeExecutorBase class84_0)
	{
		IntPtr intPtr = smethod_61(class53_0, class84_0);
		IntPtr intPtr2 = default(IntPtr);
		while (true)
		{
			int num = 434890484;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x278A99D7)) % 9)
				{
				case 8u:
					smethod_108(class84_0, intPtr2);
					num = (int)(num2 * 231443116) ^ -722933073;
					continue;
				case 6u:
					num = ((intPtr == IntPtr.Zero) ? 625401272 : 703035029) ^ ((int)num2 * -1881636175);
					continue;
				case 5u:
					intPtr2 = smethod_321(class84_0, intPtr, IntPtr.Zero);
					num = 538867479;
					continue;
				case 3u:
					smethod_153(class84_0, intPtr2, -1);
					num = 863530444;
					continue;
				case 0u:
					num = ((intPtr2 == IntPtr.Zero) ? 899592985 : 1108878760) ^ (int)(num2 * 42281777);
					continue;
				case 4u:
					break;
				case 1u:
					return false;
				default:
					return true;
				case 7u:
					return false;
				}
				break;
			}
		}
	}

	internal static void smethod_247(AsmJitAssembler class53_0, AsmJitLabel class58_0)
	{
		smethod_352(class58_0, AsmJitInstructionId.const_247, class53_0);
	}

	internal static int smethod_252(AsmJitAssembler class53_0)
	{
		return (int)(class53_0.struct19_0.struct17_0.intptr_1.ToInt64() - class53_0.struct19_0.struct17_0.intptr_0.ToInt64() + class53_0.struct19_0.intptr_3.ToInt64());
	}

	internal static void smethod_256(AsmJitLabel class58_0, AsmJitJumpHint enum12_0, AsmJitAssembler class53_0, AsmJitInstructionId enum7_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			goto IL_002b;
		}
		goto IL_0055;
		IL_002b:
		int num = -341225826;
		goto IL_0030;
		IL_0030:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1652406805)) % 5)
			{
			case 4u:
				AsmJitApi.smethod_37()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
				num = ((int)num2 * -587851590) ^ -2102072399;
				continue;
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_0055;
			case 2u:
				return;
			case 3u:
				return;
			}
			break;
		}
		goto IL_002b;
		IL_0055:
		AsmJitApi.smethod_35()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
		num = -2069125753;
		goto IL_0030;
	}

	internal static AsmJitMemoryOperand smethod_257(AsmJitLabel class58_0, long long_0)
	{
		return smethod_161(1u, (IntPtr)long_0, class58_0);
	}

	internal static void smethod_263(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitMemoryOperand class59_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_251, class63_0, class59_0);
	}

	internal static void smethod_269(AsmJitAssembler class53_0, long long_0)
	{
		smethod_308(8L, long_0, class53_0);
	}

	internal static bool smethod_278(AsmJitMemoryOperand class59_0, AsmJitMemoryOperand class59_1)
	{
		return !smethod_319(class59_0, class59_1);
	}

	internal static void smethod_279(AsmJitOperand class56_0, AsmJitOperand.Struct8 struct8_0)
	{
		class56_0.method_1(AsmJitOperand.smethod_0<AsmJitOperand.Struct8, AsmJitOperand.Struct7>(struct8_0));
	}

	internal static void smethod_280(AsmJitOperand class56_0, AsmJitOperand.Struct9 struct9_0)
	{
		class56_0.method_1(AsmJitOperand.smethod_0<AsmJitOperand.Struct9, AsmJitOperand.Struct7>(struct9_0));
	}

	internal static void smethod_286(RemoteAssembler class47_0, IntPtr intptr_0)
	{
		if (class47_0.bool_0)
		{
			goto IL_002b;
		}
		goto IL_0055;
		IL_002b:
		int num = 1410379729;
		goto IL_0030;
		IL_0030:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x57B7743E)) % 5)
			{
			case 3u:
				smethod_222(class47_0.class53_0, intptr_0.ToInt32());
				num = (int)((num2 * 544993288) ^ 0x31CEECDD);
				continue;
			case 2u:
				break;
			default:
				return;
			case 1u:
				goto IL_0055;
			case 0u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_002b;
		IL_0055:
		smethod_118(class47_0.class53_0, intptr_0);
		num = 1606717740;
		goto IL_0030;
	}

	internal static void smethod_288(AsmJitAssembler class53_0)
	{
		class53_0.struct19_0.uint_2 |= 8u;
	}

	internal static AsmJitMemoryOperand smethod_290(AsmJitLabel class58_0, long long_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			while (true)
			{
				int num = -747650810;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1979585359)) % 3)
					{
					case 1u:
						class47_0.class53_0.struct19_0.uint_2 |= 8u;
						num = (int)(num2 * 962352465) ^ -1883202530;
						continue;
					case 2u:
						break;
					default:
						goto end_IL_0049;
					}
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
		return smethod_257(class58_0, long_0);
	}

	internal static byte[] smethod_292()
	{
		return (byte[])smethod_124().GetObject("AsmJitx86", EmbeddedResources.cultureInfo_0);
	}

	internal static void smethod_297(AsmJitAssembler class53_0)
	{
		if (!class53_0.method_0())
		{
			while (true)
			{
				int num = 1767148883;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x21D62CEC)) % 4)
					{
					case 3u:
						num = (AsmJitRuntime.bool_0 ? 398489940 : 67701927) ^ ((int)num2 * -1131913682);
						continue;
					case 0u:
						break;
					case 1u:
						throw new InvalidOperationException("This instruction is only available in x64 mode.");
					default:
						goto end_IL_0051;
					}
					break;
				}
				continue;
				end_IL_0051:
				break;
			}
		}
		smethod_31(class53_0, AsmJitInstructionId.const_423);
	}

	internal static void smethod_298(AsmJitAssembler class53_0, AsmJitImmediate class57_0)
	{
		smethod_352(class57_0, AsmJitInstructionId.const_463, class53_0);
	}

	internal static AsmJitImmediate smethod_301(UIntPtr uintptr_0)
	{
		return new AsmJitImmediate((IntPtr)(long)(ulong)uintptr_0, bool_0: true);
	}

	internal static void smethod_306(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitImmediate class57_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_266, class63_0, class57_0);
	}

	internal static void smethod_308(long long_0, object object_0, AsmJitAssembler class53_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			goto IL_0007;
		}
		goto IL_0057;
		IL_0007:
		int num = -1592849599;
		goto IL_0032;
		IL_0032:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1588862186)) % 5)
			{
			case 3u:
				break;
			case 2u:
				AsmJitApi.smethod_30()(ref class53_0.struct19_0, object_0, (IntPtr)long_0);
				num = (int)(num2 * 1585359362) ^ -2133610936;
				continue;
			default:
				return;
			case 4u:
				goto IL_0057;
			case 0u:
				return;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0007;
		IL_0057:
		AsmJitApi.smethod_28()(ref class53_0.struct19_0, object_0, (IntPtr)long_0);
		num = -1460730178;
		goto IL_0032;
	}

	internal static byte[] smethod_309()
	{
		return (byte[])smethod_124().GetObject("AsmJitx64", EmbeddedResources.cultureInfo_0);
	}

	internal static void smethod_310(AsmJitGpRegister class63_0, AsmJitGpRegister class63_1, AsmJitAssembler class53_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_565, class63_0, class63_1);
	}

	internal static void smethod_311()
	{
		AsmJitRuntime.class63_0 = AsmJitNative.smethod_1<AsmJitGpRegister>("?no_reg@AsmJit@@3UGPReg@1@B");
		AsmJitRuntime.class63_1 = AsmJitNative.smethod_1<AsmJitGpRegister>("?al@AsmJit@@3UGPReg@1@B");
		AsmJitRuntime.class63_2 = AsmJitNative.smethod_1<AsmJitGpRegister>("?cl@AsmJit@@3UGPReg@1@B");
		AsmJitRuntime.class63_3 = AsmJitNative.smethod_1<AsmJitGpRegister>("?dl@AsmJit@@3UGPReg@1@B");
		AsmJitRuntime.class63_4 = AsmJitNative.smethod_1<AsmJitGpRegister>("?bl@AsmJit@@3UGPReg@1@B");
		while (true)
		{
			int num = -1283845303;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -745550669)) % 66)
				{
				case 65u:
					AsmJitRuntime.class64_1 = AsmJitNative.smethod_1<AsmJitMmxRegister>("?mm1@AsmJit@@3UMMReg@1@B");
					num = ((int)num2 * -466661698) ^ -1500152714;
					continue;
				case 64u:
					num = (AsmJitRuntime.bool_0 ? 1732533020 : 582164788) ^ ((int)num2 * -2026130458);
					continue;
				case 63u:
					AsmJitRuntime.class63_63 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r10@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_64 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r11@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1538640193) ^ -1998856575;
					continue;
				case 62u:
					AsmJitRuntime.class63_12 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r11b@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_13 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r12b@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 1494029670) ^ 0x76582B57);
					continue;
				case 61u:
					AsmJitRuntime.class63_40 = AsmJitNative.smethod_1<AsmJitGpRegister>("?ebx@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_41 = AsmJitNative.smethod_1<AsmJitGpRegister>("?esp@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1281604944) ^ -1155684980;
					continue;
				case 60u:
					AsmJitRuntime.class65_1 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm1@AsmJit@@3UXMMReg@1@B");
					num = (int)((num2 * 610647561) ^ 0x10D4C856);
					continue;
				case 59u:
					AsmJitRuntime.class63_45 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r8d@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1601657306) ^ -1012507797;
					continue;
				case 58u:
					AsmJitRuntime.class63_18 = AsmJitNative.smethod_1<AsmJitGpRegister>("?ch@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -758428795) ^ 0x1634376F;
					continue;
				case 57u:
					AsmJitRuntime.class63_67 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r14@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 997384931) ^ 0x199684A3);
					continue;
				case 56u:
					AsmJitRuntime.class63_25 = AsmJitNative.smethod_1<AsmJitGpRegister>("?sp@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 293983785) ^ -829145779;
					continue;
				case 55u:
					AsmJitRuntime.class63_37 = AsmJitNative.smethod_1<AsmJitGpRegister>("?eax@AsmJit@@3UGPReg@1@B");
					num = -681590305;
					continue;
				case 54u:
					AsmJitRuntime.class63_76 = AsmJitNative.smethod_1<AsmJitGpRegister>("?ndi@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1725322453) ^ -936912316;
					continue;
				case 53u:
					AsmJitRuntime.class63_28 = AsmJitNative.smethod_1<AsmJitGpRegister>("?di@AsmJit@@3UGPReg@1@B");
					num = ((!AsmJitRuntime.bool_0) ? (-1763829185) : (-1751907634)) ^ (int)(num2 * 1994870339);
					continue;
				case 52u:
					AsmJitRuntime.class63_11 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r10b@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 626389340) ^ -536714753;
					continue;
				case 51u:
					AsmJitRuntime.class63_17 = AsmJitNative.smethod_1<AsmJitGpRegister>("?ah@AsmJit@@3UGPReg@1@B");
					num = -362153323;
					continue;
				case 50u:
					num = ((!AsmJitRuntime.bool_0) ? (-1148443142) : (-1736399571)) ^ ((int)num2 * -1092756559);
					continue;
				case 49u:
					AsmJitRuntime.class65_12 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm12@AsmJit@@3UXMMReg@1@B");
					AsmJitRuntime.class65_13 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm13@AsmJit@@3UXMMReg@1@B");
					AsmJitRuntime.class65_14 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm14@AsmJit@@3UXMMReg@1@B");
					num = ((int)num2 * -1457726638) ^ -206486949;
					continue;
				case 48u:
					AsmJitRuntime.class63_38 = AsmJitNative.smethod_1<AsmJitGpRegister>("?ecx@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_39 = AsmJitNative.smethod_1<AsmJitGpRegister>("?edx@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1017133357) ^ -1090476654;
					continue;
				case 47u:
					AsmJitRuntime.class65_2 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm2@AsmJit@@3UXMMReg@1@B");
					num = ((int)num2 * -1255189193) ^ 0x546D0A28;
					continue;
				case 46u:
					AsmJitRuntime.class65_3 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm3@AsmJit@@3UXMMReg@1@B");
					AsmJitRuntime.class65_4 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm4@AsmJit@@3UXMMReg@1@B");
					num = (int)(num2 * 2013354066) ^ -2010149920;
					continue;
				case 45u:
					AsmJitRuntime.class63_65 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r12@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_66 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r13@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 1829066171) ^ 0x29D030BB);
					continue;
				case 44u:
					AsmJitRuntime.class63_14 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r13b@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 110752486) ^ -968289311;
					continue;
				case 43u:
					AsmJitRuntime.class63_68 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r15@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 780983877) ^ 0x487DFABB);
					continue;
				case 42u:
					AsmJitRuntime.class64_4 = AsmJitNative.smethod_1<AsmJitMmxRegister>("?mm4@AsmJit@@3UMMReg@1@B");
					AsmJitRuntime.class64_5 = AsmJitNative.smethod_1<AsmJitMmxRegister>("?mm5@AsmJit@@3UMMReg@1@B");
					num = ((int)num2 * -1183122166) ^ 0x109AB482;
					continue;
				case 40u:
					num = ((!AsmJitRuntime.bool_0) ? 2006744194 : 1315136026) ^ (int)(num2 * 663419238);
					continue;
				case 39u:
					AsmJitRuntime.class64_3 = AsmJitNative.smethod_1<AsmJitMmxRegister>("?mm3@AsmJit@@3UMMReg@1@B");
					num = ((int)num2 * -1453290581) ^ -1059147444;
					continue;
				case 38u:
					AsmJitRuntime.class63_27 = AsmJitNative.smethod_1<AsmJitGpRegister>("?si@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -771711138) ^ 0x20A04880;
					continue;
				case 37u:
					AsmJitRuntime.class63_20 = AsmJitNative.smethod_1<AsmJitGpRegister>("?bh@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1657904912) ^ 0x467F9334;
					continue;
				case 36u:
					AsmJitRuntime.class63_48 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r11d@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_49 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r12d@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1946566820) ^ -1057948391;
					continue;
				case 35u:
					AsmJitRuntime.class63_21 = AsmJitNative.smethod_1<AsmJitGpRegister>("?ax@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -662123244) ^ 0x36C1FAD7;
					continue;
				case 34u:
					AsmJitRuntime.class63_8 = AsmJitNative.smethod_1<AsmJitGpRegister>("?dil@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_9 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r8b@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1657014651) ^ 0x1E7A924B;
					continue;
				case 33u:
					AsmJitRuntime.class63_16 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r15b@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 1486420893) ^ -688755115;
					continue;
				case 32u:
					AsmJitRuntime.class63_50 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r13d@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_51 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r14d@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -277882469) ^ 0x481AA04A;
					continue;
				case 31u:
					AsmJitRuntime.class63_7 = AsmJitNative.smethod_1<AsmJitGpRegister>("?sil@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 831205666) ^ -271856685;
					continue;
				case 30u:
					AsmJitRuntime.class63_29 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r8w@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 521540610) ^ -1918085345;
					continue;
				case 29u:
					AsmJitRuntime.class63_58 = AsmJitNative.smethod_1<AsmJitGpRegister>("?rbp@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_59 = AsmJitNative.smethod_1<AsmJitGpRegister>("?rsi@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_60 = AsmJitNative.smethod_1<AsmJitGpRegister>("?rdi@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_61 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r8@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_62 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r9@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 1224603143) ^ 0x38CF5E73);
					continue;
				case 28u:
					AsmJitRuntime.class63_30 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r9w@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_31 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r10w@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1744612974) ^ -2059969359;
					continue;
				case 27u:
					AsmJitRuntime.class63_42 = AsmJitNative.smethod_1<AsmJitGpRegister>("?ebp@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_43 = AsmJitNative.smethod_1<AsmJitGpRegister>("?esi@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_44 = AsmJitNative.smethod_1<AsmJitGpRegister>("?edi@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 20207133) ^ 0x3F5854B0);
					continue;
				case 26u:
					AsmJitRuntime.class63_26 = AsmJitNative.smethod_1<AsmJitGpRegister>("?bp@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 978948368) ^ 0x5852390B);
					continue;
				case 25u:
					AsmJitRuntime.class63_69 = AsmJitNative.smethod_1<AsmJitGpRegister>("?nax@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_70 = AsmJitNative.smethod_1<AsmJitGpRegister>("?ncx@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_71 = AsmJitNative.smethod_1<AsmJitGpRegister>("?ndx@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_72 = AsmJitNative.smethod_1<AsmJitGpRegister>("?nbx@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_73 = AsmJitNative.smethod_1<AsmJitGpRegister>("?nsp@AsmJit@@3UGPReg@1@B");
					num = -200302434;
					continue;
				case 24u:
					AsmJitRuntime.class63_23 = AsmJitNative.smethod_1<AsmJitGpRegister>("?dx@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 74115907) ^ 0x63A77EBD);
					continue;
				case 23u:
					AsmJitRuntime.class65_5 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm5@AsmJit@@3UXMMReg@1@B");
					AsmJitRuntime.class65_6 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm6@AsmJit@@3UXMMReg@1@B");
					AsmJitRuntime.class65_7 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm7@AsmJit@@3UXMMReg@1@B");
					num = (int)(num2 * 275208838) ^ -2115116905;
					continue;
				case 22u:
					AsmJitRuntime.class65_15 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm15@AsmJit@@3UXMMReg@1@B");
					num = (int)(num2 * 1275018715) ^ -1958866906;
					continue;
				case 21u:
					AsmJitRuntime.class63_53 = AsmJitNative.smethod_1<AsmJitGpRegister>("?rax@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_54 = AsmJitNative.smethod_1<AsmJitGpRegister>("?rcx@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_55 = AsmJitNative.smethod_1<AsmJitGpRegister>("?rdx@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 544958900) ^ -1300822138;
					continue;
				case 20u:
					AsmJitRuntime.class65_8 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm8@AsmJit@@3UXMMReg@1@B");
					num = ((int)num2 * -1506031424) ^ 0x6D720EE6;
					continue;
				case 19u:
					AsmJitRuntime.class64_0 = AsmJitNative.smethod_1<AsmJitMmxRegister>("?mm0@AsmJit@@3UMMReg@1@B");
					num = ((int)num2 * -1205074054) ^ 0x4F3CF9FC;
					continue;
				case 18u:
					AsmJitRuntime.class63_10 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r9b@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -583163015) ^ -1946115339;
					continue;
				case 17u:
					AsmJitRuntime.class64_6 = AsmJitNative.smethod_1<AsmJitMmxRegister>("?mm6@AsmJit@@3UMMReg@1@B");
					num = (int)(num2 * 801123639) ^ -809538179;
					continue;
				case 16u:
					AsmJitRuntime.class63_46 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r9d@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_47 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r10d@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -132552288) ^ -912122865;
					continue;
				case 15u:
					AsmJitRuntime.class63_5 = AsmJitNative.smethod_1<AsmJitGpRegister>("?spl@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_6 = AsmJitNative.smethod_1<AsmJitGpRegister>("?bpl@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 1432119236) ^ 0x73932726);
					continue;
				case 13u:
					AsmJitRuntime.class63_56 = AsmJitNative.smethod_1<AsmJitGpRegister>("?rbx@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_57 = AsmJitNative.smethod_1<AsmJitGpRegister>("?rsp@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1092165702) ^ 0x2BAE48BC;
					continue;
				case 12u:
					AsmJitRuntime.class63_24 = AsmJitNative.smethod_1<AsmJitGpRegister>("?bx@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1367969840) ^ 0x2504999B;
					continue;
				case 11u:
					AsmJitRuntime.class63_74 = AsmJitNative.smethod_1<AsmJitGpRegister>("?nbp@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_75 = AsmJitNative.smethod_1<AsmJitGpRegister>("?nsi@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -61123922) ^ 0x2A02357;
					continue;
				case 10u:
					AsmJitRuntime.class63_15 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r14b@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 1153734781) ^ -190802298;
					continue;
				case 9u:
					AsmJitRuntime.class64_2 = AsmJitNative.smethod_1<AsmJitMmxRegister>("?mm2@AsmJit@@3UMMReg@1@B");
					num = (int)(num2 * 1623998899) ^ -1384848669;
					continue;
				case 8u:
					AsmJitRuntime.class63_19 = AsmJitNative.smethod_1<AsmJitGpRegister>("?dh@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 1962295877) ^ -1905397064;
					continue;
				case 7u:
					AsmJitRuntime.class65_9 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm9@AsmJit@@3UXMMReg@1@B");
					AsmJitRuntime.class65_10 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm10@AsmJit@@3UXMMReg@1@B");
					AsmJitRuntime.class65_11 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm11@AsmJit@@3UXMMReg@1@B");
					num = ((int)num2 * -406590269) ^ -1319426861;
					continue;
				case 6u:
					AsmJitRuntime.class63_36 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r15w@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -652550803) ^ -606441300;
					continue;
				case 5u:
					AsmJitRuntime.class63_52 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r15d@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -353759196) ^ -1811908888;
					continue;
				case 4u:
					AsmJitRuntime.class63_32 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r11w@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 79547584) ^ -1713755935;
					continue;
				case 3u:
					num = (AsmJitRuntime.bool_0 ? (-2106226974) : (-1457313144));
					continue;
				case 2u:
					AsmJitRuntime.class63_33 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r12w@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_34 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r13w@AsmJit@@3UGPReg@1@B");
					AsmJitRuntime.class63_35 = AsmJitNative.smethod_1<AsmJitGpRegister>("?r14w@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -156990361) ^ -1453361169;
					continue;
				case 1u:
					AsmJitRuntime.class64_7 = AsmJitNative.smethod_1<AsmJitMmxRegister>("?mm7@AsmJit@@3UMMReg@1@B");
					AsmJitRuntime.class65_0 = AsmJitNative.smethod_1<AsmJitXmmRegister>("?xmm0@AsmJit@@3UXMMReg@1@B");
					num = ((int)num2 * -1142924980) ^ -1724479487;
					continue;
				case 0u:
					AsmJitRuntime.class63_22 = AsmJitNative.smethod_1<AsmJitGpRegister>("?cx@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1218021946) ^ -79457047;
					continue;
				default:
					return;
				case 14u:
					break;
				case 41u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_318(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitGpRegister class63_1)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_266, class63_0, class63_1);
	}

	internal static bool smethod_319(AsmJitMemoryOperand class59_0, AsmJitMemoryOperand class59_1)
	{
		if (class59_0 == null)
		{
			goto IL_0036;
		}
		goto IL_0070;
		IL_0036:
		int num = 1320019907;
		goto IL_003b;
		IL_003b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xC7CF7E2)) % 6)
			{
			case 3u:
				num = ((class59_1 == null) ? 1133296777 : 1359623839) ^ (int)(num2 * 478980359);
				continue;
			case 2u:
				break;
			case 4u:
				goto IL_0070;
			case 0u:
				return true;
			case 1u:
				return false;
			default:
				return class59_0.Equals(class59_1);
			}
			break;
		}
		goto IL_0036;
		IL_0070:
		num = ((class59_0 == null) ? 1311145371 : 242735013);
		goto IL_003b;
	}

	internal static void smethod_320(AsmJitAssembler class53_0, byte[] byte_0)
	{
		smethod_308(byte_0.Length, byte_0, class53_0);
	}

	internal static void smethod_324(AsmJitMemoryOperand class59_0, RemoteAssembler class47_0, int int_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[4]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		if (int_0 < 4)
		{
			goto IL_004b;
		}
		goto IL_0075;
		IL_004b:
		int num = -565262347;
		goto IL_0050;
		IL_0050:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1861397863)) % 5)
			{
			case 3u:
				smethod_429(class47_0.class53_0, array[int_0], class59_0);
				num = (int)(num2 * 715875784) ^ -393629077;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0075;
			case 1u:
				return;
			default:
				smethod_75(class47_0.class53_0, smethod_238(AsmJitRuntime.class63_57, int_0 * 8), AsmJitRuntime.class63_53);
				return;
			}
			break;
		}
		goto IL_004b;
		IL_0075:
		smethod_429(class47_0.class53_0, AsmJitRuntime.class63_53, class59_0);
		num = -1836502537;
		goto IL_0050;
	}

	internal static bool smethod_328(AsmJitOperand class56_0, AsmJitOperand class56_1)
	{
		if (class56_0 == null)
		{
			goto IL_0036;
		}
		goto IL_0070;
		IL_0036:
		int num = -798089757;
		goto IL_003b;
		IL_003b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1923596835)) % 6)
			{
			case 4u:
				num = ((class56_1 != null) ? (-1035514944) : (-881180818)) ^ (int)(num2 * 348935868);
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_0070;
			default:
				return class56_0.Equals(class56_1);
			case 2u:
				return false;
			case 5u:
				return true;
			}
			break;
		}
		goto IL_0036;
		IL_0070:
		num = ((class56_0 == null) ? (-894972497) : (-1859074298));
		goto IL_003b;
	}

	internal static AsmJitMemoryOperand smethod_329(AsmJitLabel class58_0, long long_0)
	{
		return smethod_161(8u, (IntPtr)long_0, class58_0);
	}

	internal static void smethod_332(AsmJitJumpHint enum12_0, AsmJitAssembler class53_0, AsmJitLabel class58_0)
	{
		smethod_256(class58_0, enum12_0, class53_0, AsmJitInstructionId.const_232);
	}

	internal static void smethod_336(RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			goto IL_0025;
		}
		goto IL_004f;
		IL_0025:
		int num = -1459123326;
		goto IL_002a;
		IL_002a:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -323810449)) % 5)
			{
			case 4u:
				smethod_439(class47_0.class53_0, 0u);
				num = ((int)num2 * -1087769558) ^ 0x5D3F4CC2;
				continue;
			case 2u:
				break;
			default:
				return;
			case 1u:
				goto IL_004f;
			case 0u:
				return;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0025;
		IL_004f:
		smethod_269(class47_0.class53_0, 0L);
		num = -1589330783;
		goto IL_002a;
	}

	internal static uint smethod_338(AsmJitRegister class62_0)
	{
		return smethod_188(class62_0).uint_1;
	}

	internal static AsmJitImmediate smethod_344(short short_0)
	{
		return new AsmJitImmediate((IntPtr)short_0);
	}

	internal static void smethod_347(AsmJitAssembler class53_0)
	{
		smethod_31(class53_0, AsmJitInstructionId.const_502);
	}

	internal static void smethod_352(AsmJitOperand class56_0, AsmJitInstructionId enum7_0, AsmJitAssembler class53_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			goto IL_0007;
		}
		goto IL_0052;
		IL_0007:
		int num = 1203289807;
		goto IL_002d;
		IL_002d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x73B4642F)) % 5)
			{
			case 2u:
				break;
			case 1u:
				AsmJitApi.smethod_13()(ref class53_0.struct19_0, enum7_0, class56_0);
				num = ((int)num2 * -2109173394) ^ -2113571889;
				continue;
			default:
				return;
			case 4u:
				goto IL_0052;
			case 0u:
				return;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0007;
		IL_0052:
		AsmJitApi.smethod_6()(ref class53_0.struct19_0, enum7_0, class56_0);
		num = 853696725;
		goto IL_002d;
	}

	internal static void smethod_358(AsmJitOperand class56_0, object[] object_0, CallingConvention callingConvention_0, RemoteAssembler class47_0)
	{
		bool[] array = new bool[object_0.Length];
		if (callingConvention_0 != CallingConvention.ThisCall)
		{
			goto IL_019b;
		}
		goto IL_04b8;
		IL_019b:
		int num = -1288428068;
		goto IL_03f3;
		IL_03f3:
		int num5 = default(int);
		object obj = default(object);
		object[] array2 = default(object[]);
		int num4 = default(int);
		AsmJitGpRegister @class = default(AsmJitGpRegister);
		int num6 = default(int);
		AsmJitImmediate class2 = default(AsmJitImmediate);
		int num8 = default(int);
		int num3 = default(int);
		int num7 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1211465069)) % 38)
			{
			case 37u:
				smethod_181(object_0[num5], class47_0, RemoteAssembler.Enum6.const_2);
				num = ((int)num2 * -1211331439) ^ 0x4954EC25;
				continue;
			case 36u:
				obj = array2[num4];
				num = -264081910;
				continue;
			case 35u:
				num5--;
				num = -1207532562;
				continue;
			case 33u:
				@class = class56_0 as AsmJitGpRegister;
				num = -1534324660;
				continue;
			case 32u:
				num6++;
				num = (int)(num2 * 1301699255) ^ -882691877;
				continue;
			case 31u:
				num = ((int)num2 * -1505907566) ^ 0x6CFE61C;
				continue;
			case 30u:
			{
				smethod_306(class47_0.class53_0, AsmJitRuntime.class63_37, class2);
				AsmJitAssembler class53_ = class47_0.class53_0;
				AsmJitGpRegister class63_ = AsmJitRuntime.class63_69;
				smethod_372(class63_, class53_);
				num = ((int)num2 * -1167270270) ^ -2069930302;
				continue;
			}
			case 29u:
				num6 = 0;
				num = ((int)num2 * -913040919) ^ -1152539133;
				continue;
			case 28u:
				num5 = object_0.Length - 1;
				num = -450972254;
				continue;
			case 27u:
				class2 = class56_0 as AsmJitImmediate;
				num = (int)((num2 * 1787599892) ^ 0x7CB010D9);
				continue;
			case 26u:
				num = ((num6 >= num8) ? (-1547506509) : (-1074467715)) ^ (int)(num2 * 676800022);
				continue;
			case 25u:
				num = ((!smethod_392(null, @class)) ? 1789842968 : 615849675) ^ (int)(num2 * 1262489841);
				continue;
			case 23u:
				num = ((!smethod_134(null, @class)) ? 307116507 : 865603960) ^ (int)(num2 * 1187578848);
				continue;
			case 22u:
				break;
			case 21u:
				goto IL_01a5;
			case 20u:
				goto IL_01c8;
			case 19u:
				goto IL_01ec;
			case 18u:
				num4 = 0;
				num = (int)((num2 * 920670584) ^ 0x2299CBE1);
				continue;
			case 16u:
				num3 = 0;
				array2 = object_0;
				num = -607909471;
				continue;
			case 15u:
				num = ((obj is IntPtr) ? 682700618 : 981396693) ^ (int)(num2 * 2024373347);
				continue;
			case 14u:
				num3 += 4;
				num = -926967529;
				continue;
			case 12u:
				array[num7] = true;
				smethod_181(object_0[num7], class47_0, (RemoteAssembler.Enum6)num6);
				num = -343652087;
				continue;
			case 11u:
				num = ((callingConvention_0 != CallingConvention.FastCall) ? 719818976 : 1652913666) ^ ((int)num2 * -1423876759);
				continue;
			case 10u:
				goto IL_02b3;
			case 8u:
				num7++;
				num = ((int)num2 * -582436032) ^ 0x348B208;
				continue;
			case 7u:
				num = ((!(obj is UIntPtr)) ? (-1138941855) : (-1568969845)) ^ (int)(num2 * 148402002);
				continue;
			case 6u:
				num4++;
				num = -1174021487;
				continue;
			case 5u:
				goto IL_032a;
			case 4u:
				num = ((!smethod_49(class2, null)) ? 91968244 : 423993175) ^ (int)(num2 * 1319061799);
				continue;
			case 3u:
				smethod_372(@class, class47_0.class53_0);
				num = (int)(num2 * 1861575084) ^ -139886589;
				continue;
			case 2u:
				goto IL_0392;
			case 1u:
				num3 += obj.GetType().smethod_7();
				num = -926967529;
				continue;
			case 0u:
				num = ((obj is RemoteAssembler.Class48) ? (-1101741943) : (-245433692)) ^ ((int)num2 * -1386902337);
				continue;
			case 9u:
				goto IL_049e;
			case 24u:
				goto IL_04b8;
			case 13u:
				throw new InvalidOperationException("Unknown function pointer type");
			default:
				smethod_363(class47_0.class53_0, AsmJitRuntime.class63_41, smethod_167(num3));
				return;
			case 34u:
				return;
			}
			break;
			IL_0392:
			num = (smethod_328(class2, null) ? (-480363574) : (-1889468101));
			continue;
			IL_02b3:
			num = ((callingConvention_0 != CallingConvention.Cdecl) ? (-185002849) : (-787291443));
			continue;
			IL_01c8:
			num = ((num4 < array2.Length) ? (-1513483141) : (-160967592));
			continue;
			IL_032a:
			num = ((num5 < 0) ? (-640849980) : (-1372807174));
			continue;
			IL_01a5:
			num = ((num7 < object_0.Length) ? (-928418019) : (-812727673));
			continue;
			IL_01ec:
			num = ((!array[num5]) ? (-1952261536) : (-1757959802));
		}
		goto IL_019b;
		IL_04b8:
		int num9;
		if (callingConvention_0 == CallingConvention.FastCall)
		{
			num9 = 2;
			goto IL_049f;
		}
		num = -762306292;
		goto IL_03f3;
		IL_049f:
		num8 = num9;
		num7 = 0;
		num = -87730752;
		goto IL_03f3;
		IL_049e:
		num9 = 1;
		goto IL_049f;
	}

	internal static void smethod_360(AsmJitAssembler class53_0, AsmJitImmediate class57_0)
	{
		smethod_352(class57_0, AsmJitInstructionId.const_502, class53_0);
	}

	internal static void smethod_363(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitImmediate class57_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_1, class63_0, class57_0);
	}

	internal static AsmJitMemoryOperand smethod_364(AsmJitLabel class58_0, long long_0)
	{
		return smethod_161(2u, (IntPtr)long_0, class58_0);
	}

	internal static void smethod_365(RemoteAssembler class47_0, AsmJitOperand class56_0, object[] object_0)
	{
		int num2 = 0;
		AsmJitImmediate @class = null;
		if (object_0.Length <= 4)
		{
			goto IL_02a8;
		}
		int num = object_0.Length * 8;
		goto IL_0326;
		IL_0324:
		num = 40;
		goto IL_0326;
		IL_0326:
		num2 = num;
		@class = class56_0 as AsmJitImmediate;
		num2 -= num2 % 16;
		int num3 = -477424628;
		goto IL_02ad;
		IL_02ad:
		int[] array = default(int[]);
		AsmJitAssembler class53_2 = default(AsmJitAssembler);
		AsmJitGpRegister class2 = default(AsmJitGpRegister);
		int num6 = default(int);
		AsmJitAssembler class53_ = default(AsmJitAssembler);
		int num5 = default(int);
		while (true)
		{
			uint num4;
			switch ((num4 = (uint)(num3 ^ -1654128794)) % 25)
			{
			case 24u:
			{
				int[] array2 = Enumerable.Range(0, object_0.Length).ToArray();
				array2.smethod_4();
				array = array2;
				num3 = (int)(num4 * 351147968) ^ -2060633881;
				continue;
			}
			case 23u:
			{
				AsmJitGpRegister class63_2 = AsmJitRuntime.class63_53;
				smethod_372(class63_2, class53_2);
				num3 = (int)(num4 * 1596945902) ^ -1676622225;
				continue;
			}
			case 22u:
				num3 = ((!smethod_134(null, class2)) ? 1347721345 : 648917204) ^ ((int)num4 * -2090724803);
				continue;
			case 20u:
				class2 = class56_0 as AsmJitGpRegister;
				num3 = -803227643;
				continue;
			case 19u:
				break;
			case 18u:
				num6 = 0;
				num3 = -865413926;
				continue;
			case 17u:
			{
				AsmJitGpRegister class63_ = AsmJitRuntime.class63_57;
				AsmJitImmediate class57_ = smethod_167(num2 + 8);
				smethod_190(class63_, class57_, class53_);
				num3 = ((int)num4 * -1296944756) ^ -1791562437;
				continue;
			}
			case 16u:
				smethod_306(class47_0.class53_0, AsmJitRuntime.class63_53, @class);
				num3 = ((int)num4 * -1177294428) ^ -1243670742;
				continue;
			case 15u:
				num3 = (class47_0.method_0() ? 343031415 : 2064726918) ^ ((int)num4 * -19714018);
				continue;
			case 13u:
			{
				int num7 = array[num5];
				smethod_391(class47_0, object_0[num7], num7);
				num3 = -950295674;
				continue;
			}
			case 12u:
				num3 = (int)(num4 * 722407968) ^ -132880285;
				continue;
			case 11u:
				smethod_391(class47_0, object_0[num6], num6);
				num6++;
				num3 = -865413926;
				continue;
			case 10u:
				goto IL_0198;
			case 8u:
				goto IL_01bb;
			case 7u:
				num5 = 0;
				num3 = ((int)num4 * -1338254048) ^ 0x2B340EAE;
				continue;
			case 6u:
				goto IL_01f6;
			case 5u:
				smethod_372(class2, class47_0.class53_0);
				num3 = ((int)num4 * -1822982286) ^ 0x5288A71A;
				continue;
			case 4u:
				class53_2 = class47_0.class53_0;
				num3 = ((int)num4 * -798009677) ^ -1654502301;
				continue;
			case 3u:
				class53_ = class47_0.class53_0;
				num3 = (int)((num4 * 1754161637) ^ 0xFF19062);
				continue;
			case 2u:
				num3 = ((!smethod_392(null, class2)) ? (-1442595508) : (-1712354238)) ^ ((int)num4 * -45601394);
				continue;
			case 1u:
				num5++;
				num3 = (int)((num4 * 196827592) ^ 0x74DB48E);
				continue;
			case 0u:
				goto end_IL_02ad;
			case 14u:
				goto IL_0324;
			case 21u:
				throw new InvalidOperationException("Unknown function pointer type");
			default:
				smethod_363(class47_0.class53_0, AsmJitRuntime.class63_57, smethod_167(num2 + 8));
				return;
			}
			num3 = ((num5 >= array.Length) ? (-807006229) : (-1220298295));
			continue;
			IL_01f6:
			num3 = ((!smethod_328(@class, null)) ? (-1331588779) : (-542520062));
			continue;
			IL_0198:
			num3 = ((num6 >= object_0.Length) ? (-1031892029) : (-1946655624));
			continue;
			IL_01bb:
			num3 = (smethod_49(@class, null) ? (-15732939) : (-986202871));
			continue;
			end_IL_02ad:
			break;
		}
		goto IL_02a8;
		IL_02a8:
		num3 = -1750269952;
		goto IL_02ad;
	}

	internal static void smethod_371(AsmJitAssembler class53_0, AsmJitMemoryOperand class59_0)
	{
		smethod_352(class59_0, AsmJitInstructionId.const_463, class53_0);
	}

	internal static void smethod_372(AsmJitGpRegister class63_0, AsmJitAssembler class53_0)
	{
		smethod_352(class63_0, AsmJitInstructionId.const_26, class53_0);
	}

	internal static AsmJitImmediate smethod_374(uint uint_0)
	{
		return new AsmJitImmediate((IntPtr)(int)uint_0, bool_0: true);
	}

	internal static void smethod_381(AsmJitOperand.Struct13 struct13_0, AsmJitOperand class56_0)
	{
		class56_0.method_1(AsmJitOperand.smethod_0<AsmJitOperand.Struct13, AsmJitOperand.Struct7>(struct13_0));
	}

	internal static AsmJitImmediate smethod_384(ushort ushort_0)
	{
		return new AsmJitImmediate((IntPtr)ushort_0);
	}

	internal static AsmJitOperand.Struct11 smethod_386(AsmJitOperand class56_0)
	{
		return AsmJitOperand.smethod_0<AsmJitOperand.Struct7, AsmJitOperand.Struct11>(class56_0.method_0());
	}

	internal static AsmJitImmediate smethod_390(IntPtr intptr_0)
	{
		return new AsmJitImmediate(intptr_0);
	}

	internal static void smethod_391(RemoteAssembler class47_0, object object_0, int int_0)
	{
		RemoteAssembler.Class48 @class = object_0 as RemoteAssembler.Class48;
		AsmJitGpRegister class3 = default(AsmJitGpRegister);
		AsmJitMemoryOperand class59_ = default(AsmJitMemoryOperand);
		AsmJitImmediate class2 = default(AsmJitImmediate);
		while (true)
		{
			int num = -129526793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -166401786)) % 15)
				{
				case 14u:
					class3 = object_0 as AsmJitGpRegister;
					num = -1657962017;
					continue;
				case 11u:
					smethod_324(class59_, class47_0, int_0);
					num = ((int)num2 * -71044171) ^ 0x16DFE349;
					continue;
				case 10u:
					num = ((@class == null) ? 1752018050 : 909060028) ^ ((int)num2 * -91658263);
					continue;
				case 8u:
					num = ((!smethod_278(class59_, null)) ? 1786717269 : 1409204151) ^ (int)(num2 * 1633103399);
					continue;
				case 5u:
					num = ((!smethod_392(null, class3)) ? (-474050390) : (-1884301972)) ^ (int)(num2 * 965553881);
					continue;
				case 4u:
					class2 = object_0.smethod_0();
					num = ((!smethod_49(class2, null)) ? (-2028432363) : (-1323049905));
					continue;
				case 2u:
					class59_ = object_0 as AsmJitMemoryOperand;
					num = -1075158410;
					continue;
				case 1u:
					smethod_236(int_0, @class.method_0(), class47_0);
					num = (int)((num2 * 1251070644) ^ 0x73377B37);
					continue;
				case 0u:
					smethod_199(int_0, class47_0, class3);
					num = ((int)num2 * -1813522895) ^ 0x18025E0B;
					continue;
				case 13u:
					break;
				case 3u:
					return;
				case 6u:
					return;
				case 7u:
					return;
				default:
					throw new InvalidOperationException("Unknown object type.");
				case 12u:
					smethod_121(class47_0, class2, int_0, object_0 is float || object_0 is double);
					return;
				}
				break;
			}
		}
	}

	internal static bool smethod_392(AsmJitRegister class62_0, AsmJitRegister class62_1)
	{
		return !smethod_134(class62_0, class62_1);
	}

	internal static AsmJitMemoryOperand smethod_395(long long_0, AsmJitGpRegister class63_0)
	{
		return smethod_433((IntPtr)long_0, 4u, class63_0);
	}

	internal static IntPtr smethod_397(AsmJitAssembler class53_0)
	{
		if (!AsmJitRuntime.bool_0)
		{
			return AsmJitApi.smethod_18()(ref class53_0.struct19_0);
		}
		return AsmJitApi.smethod_20()(ref class53_0.struct19_0);
	}

	internal static AsmJitOperand.Struct14 smethod_403(AsmJitOperand class56_0)
	{
		return AsmJitOperand.smethod_0<AsmJitOperand.Struct7, AsmJitOperand.Struct14>(class56_0.method_0());
	}

	internal static bool smethod_410(bool bool_0, ulong ulong_0, VectoredExceptionHandlerInstaller class92_0, IntPtr intptr_0)
	{
		ProcessModuleInfo gClass = smethod_42(class92_0.method_19())["ntdll.dll"];
		AsmJitGpRegister class63_ = default(AsmJitGpRegister);
		AsmJitAssembler @class = default(AsmJitAssembler);
		AsmJitGpRegister class63_3 = default(AsmJitGpRegister);
		AsmJitMemoryOperand class59_ = default(AsmJitMemoryOperand);
		AsmJitImmediate class57_ = default(AsmJitImmediate);
		uint num5 = default(uint);
		int num3 = default(int);
		VectoredExceptionHandlerInstaller.Struct71 gparam_ = default(VectoredExceptionHandlerInstaller.Struct71);
		long num4 = default(long);
		IntPtr intPtr = default(IntPtr);
		AsmJitLabel class58_4 = default(AsmJitLabel);
		IntPtr intPtr2 = default(IntPtr);
		AsmJitGpRegister class63_2 = default(AsmJitGpRegister);
		RemoteAssembler class2 = default(RemoteAssembler);
		AsmJitLabel class58_3 = default(AsmJitLabel);
		AsmJitLabel class58_ = default(AsmJitLabel);
		AsmJitLabel class58_2 = default(AsmJitLabel);
		while (true)
		{
			int num = 2124793361;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x789016F9)) % 71)
				{
				case 70u:
					smethod_205(class63_, @class, class63_3);
					num = ((int)num2 * -202104059) ^ -2085167891;
					continue;
				case 69u:
					class59_ = smethod_395(0L, AsmJitRuntime.class63_53);
					class57_ = smethod_374(3765269347u);
					smethod_110(class57_, class59_, @class);
					num = ((int)num2 * -786739640) ^ -504654311;
					continue;
				case 67u:
					num5 = BitConverter.ToUInt32(class92_0.byte_0, num3);
					num = ((num5 == 3735935610u) ? 827292592 : 764475565);
					continue;
				case 66u:
					num = ((num3 >= class92_0.byte_0.Length - 4) ? 520534705 : 210201124);
					continue;
				case 65u:
					num = ((int)num2 * -1497846063) ^ 0x737E5F75;
					continue;
				case 64u:
					gparam_ = class92_0.method_11<VectoredExceptionHandlerInstaller.Struct71>(class92_0.intptr_1);
					num4 = gparam_.intptr_0.ToInt64();
					num = 738694385;
					continue;
				case 63u:
					class63_3 = AsmJitRuntime.class63_55;
					num = ((int)num2 * -1003963183) ^ -1959147897;
					continue;
				case 62u:
					intPtr = smethod_285(class92_0.method_19()).method_28();
					BitConverter.GetBytes(intPtr.ToInt32()).CopyTo(class92_0.byte_0, num3);
					num = (int)((num2 * 1389643800) ^ 0x1CAC63F3);
					continue;
				case 61u:
					smethod_332(AsmJitJumpHint.const_0, @class, class58_4);
					class59_ = smethod_238(AsmJitRuntime.class63_53, 32L);
					num = ((int)num2 * -1692758582) ^ -687735026;
					continue;
				case 60u:
					gparam_.struct70_0[num4].intptr_0 = intptr_0;
					num = (int)((num2 * 1403587108) ^ 0x50B32679);
					continue;
				case 59u:
					smethod_332(AsmJitJumpHint.const_0, @class, class58_4);
					num = ((int)num2 * -1149696274) ^ -975212268;
					continue;
				case 58u:
					smethod_332(AsmJitJumpHint.const_0, @class, class58_4);
					num = ((int)num2 * -564449262) ^ -2084703681;
					continue;
				case 57u:
					BitConverter.GetBytes(intPtr.ToInt32()).CopyTo(class92_0.byte_0, num3);
					num = ((int)num2 * -834342897) ^ 0x4B273AA7;
					continue;
				case 56u:
					intPtr2 = smethod_225(gClass, "RtlDecodeSystemPointer", bool_0: false);
					num = 24344764;
					continue;
				case 55u:
					num = ((!(class92_0.intptr_1 == IntPtr.Zero)) ? 2033965669 : 1041281663) ^ ((int)num2 * -553800921);
					continue;
				case 54u:
					num = ((num5 != 3735929054u) ? 1095077730 : 30532957);
					continue;
				case 53u:
				{
					AsmJitMemoryOperand class59_3 = smethod_238(AsmJitRuntime.class63_62, IntPtr.Size);
					smethod_169(class59_3, class63_2, @class);
					num = ((int)num2 * -1194536231) ^ -2142556560;
					continue;
				}
				case 52u:
					smethod_164(@class, AsmJitRuntime.class63_63, AsmJitRuntime.class63_63);
					num = (int)((num2 * 1512829021) ^ 0x152DF6D);
					continue;
				case 51u:
					num = (int)((num2 * 509529213) ^ 0x669B32E3);
					continue;
				case 50u:
					smethod_429(@class, AsmJitRuntime.class63_55, smethod_238(AsmJitRuntime.class63_62, 0L));
					num = (int)((num2 * 1966281933) ^ 0x78F5FBEF);
					continue;
				case 49u:
					class2.method_4<IntPtr>();
					smethod_226(class2, -1);
					num = ((int)num2 * -84778706) ^ -40418380;
					continue;
				case 48u:
				{
					AsmJitMemoryOperand class59_2 = smethod_238(AsmJitRuntime.class63_53, 32L);
					AsmJitImmediate class57_2 = smethod_374(429065504u);
					smethod_127(class57_2, class59_2, @class);
					num = (int)(num2 * 1036423967) ^ -1911781498;
					continue;
				}
				case 47u:
					class92_0.intptr_2 = smethod_175(class92_0, class92_0.byte_0.Length, NativeTypes.Enum34.flag_2);
					num = ((!(class92_0.intptr_2 == IntPtr.Zero)) ? 1724333493 : 569166740);
					continue;
				case 46u:
					smethod_306(@class, AsmJitRuntime.class63_62, new AsmJitImmediate(class92_0.intptr_1));
					smethod_429(@class, AsmJitRuntime.class63_55, smethod_238(AsmJitRuntime.class63_62, 0L));
					num = (int)((num2 * 2141000902) ^ 0x6B3752D);
					continue;
				case 44u:
					smethod_205(class63_, @class, class63_3);
					num = (int)(num2 * 1293983261) ^ -1744408913;
					continue;
				case 43u:
					class59_ = smethod_238(AsmJitRuntime.class63_53, 56L);
					num = (int)((num2 * 1473774393) ^ 0x41756877);
					continue;
				case 42u:
					class57_ = smethod_374(26820608u);
					num = ((int)num2 * -1132276667) ^ 0x3C9DAFC0;
					continue;
				case 40u:
					gparam_.intptr_0 = gparam_.intptr_0.smethod_8(1);
					num = ((int)num2 * -1932217139) ^ 0x6873C295;
					continue;
				case 39u:
					smethod_75(@class, smethod_238(AsmJitRuntime.class63_53, 56L), AsmJitRuntime.class63_55);
					num = (int)((num2 * 1586931031) ^ 0x12CABA15);
					continue;
				case 38u:
					smethod_363(@class, AsmJitRuntime.class63_62, smethod_167(IntPtr.Size));
					num = ((int)num2 * -721373078) ^ 0x512CFDA9;
					continue;
				case 37u:
					class2 = new RemoteAssembler(@class, class92_0.method_19());
					smethod_15(class2);
					smethod_54(class2, new AsmJitImmediate(smethod_225(gClass, "RtlAddVectoredExceptionHandler", bool_0: false)), CallingConvention.StdCall, new object[2] { 0, class92_0.intptr_2 });
					num = 2129636980;
					continue;
				case 36u:
					class92_0.method_13(class92_0.intptr_1, gparam_);
					class58_4 = smethod_48(@class);
					class58_3 = smethod_48(@class);
					num = (int)(num2 * 46063604) ^ -97241406;
					continue;
				case 35u:
					num3++;
					num = 315035395;
					continue;
				case 34u:
					smethod_36(@class, class58_4);
					num = (int)(num2 * 1614786777) ^ -389953731;
					continue;
				case 33u:
					smethod_363(@class, AsmJitRuntime.class63_63, smethod_167(1));
					num = ((int)num2 * -2048095374) ^ -1190774931;
					continue;
				case 32u:
					class63_ = AsmJitRuntime.class63_63;
					num = ((int)num2 * -875597638) ^ -1337065233;
					continue;
				case 31u:
					smethod_220(AsmJitJumpHint.const_0, class58_, @class);
					smethod_247(@class, class58_2);
					num = ((int)num2 * -35662981) ^ 0x53695AD9;
					continue;
				case 30u:
					class63_3 = AsmJitRuntime.class63_64;
					num = ((int)num2 * -286126351) ^ 0x736CD622;
					continue;
				case 29u:
					num = ((num5 == 3735929042u) ? 2087398 : 801390875);
					continue;
				case 28u:
					class92_0.intptr_2 = smethod_61(@class, class92_0);
					smethod_115(@class);
					num = (int)((num2 * 1690773023) ^ 0x30BA4605);
					continue;
				case 27u:
					num = ((gClass != null) ? 727311944 : 1157901590) ^ ((int)num2 * -1041048921);
					continue;
				case 26u:
					class57_ = smethod_167(0);
					num = ((int)num2 * -1052007470) ^ -1247933243;
					continue;
				case 25u:
					smethod_332(AsmJitJumpHint.const_0, @class, class58_3);
					smethod_247(@class, class58_4);
					smethod_36(@class, class58_2);
					num = (int)((num2 * 1538207082) ^ 0x4C3752B3);
					continue;
				case 24u:
					smethod_36(@class, class58_3);
					smethod_429(@class, AsmJitRuntime.class63_61, smethod_238(AsmJitRuntime.class63_53, 48L));
					smethod_429(@class, AsmJitRuntime.class63_64, smethod_238(AsmJitRuntime.class63_62, 0L));
					num = ((int)num2 * -324398711) ^ 0x4653B182;
					continue;
				case 22u:
					class63_ = AsmJitRuntime.class63_61;
					class63_3 = AsmJitRuntime.class63_64;
					num = (int)((num2 * 34924507) ^ 0x3E941045);
					continue;
				case 21u:
					num = ((!class92_0.method_16(class92_0.intptr_2, class92_0.byte_0)) ? 1238233527 : 888158518);
					continue;
				case 20u:
					smethod_110(class57_, class59_, @class);
					num = (int)((num2 * 1121192180) ^ 0x72EE9328);
					continue;
				case 19u:
					num = (class92_0.method_19().Is64Bit ? 1520727512 : 401250852) ^ (int)(num2 * 1334665265);
					continue;
				case 18u:
					smethod_164(@class, AsmJitRuntime.class63_53, AsmJitRuntime.class63_53);
					num = ((int)num2 * -855016202) ^ 0x1B499319;
					continue;
				case 16u:
					intPtr = (class92_0.intptr_3 = class92_0.method_21<IntPtr>(class2));
					num = (int)((num2 * 787716627) ^ 0x35B1721F);
					continue;
				case 15u:
					smethod_205(class63_, @class, class63_3);
					num = ((int)num2 * -1760668733) ^ 0x3F833ED0;
					continue;
				case 14u:
					class58_ = smethod_48(@class);
					class58_2 = smethod_48(@class);
					smethod_429(@class, AsmJitRuntime.class63_53, smethod_238(AsmJitRuntime.class63_54, 0L));
					num = (int)((num2 * 951599599) ^ 0xA2B83BD);
					continue;
				case 13u:
					gparam_.struct70_0[num4].intptr_1 = (IntPtr)(long)ulong_0;
					num = ((int)num2 * -693079858) ^ -205896791;
					continue;
				case 12u:
					smethod_110(class57_, class59_, @class);
					num = ((int)num2 * -140789703) ^ -1181042394;
					continue;
				case 11u:
					@class = new AsmJitAssembler();
					num = 1715510004;
					continue;
				case 10u:
					smethod_32(AsmJitJumpHint.const_0, class58_, @class);
					class63_2 = AsmJitRuntime.class63_64;
					num = (int)(num2 * 640230484) ^ -2073980872;
					continue;
				case 9u:
					smethod_36(@class, class58_);
					smethod_363(@class, AsmJitRuntime.class63_62, smethod_167(typeof(VectoredExceptionHandlerInstaller.Struct70).smethod_7()));
					num = (int)((num2 * 890256792) ^ 0x55306306);
					continue;
				case 8u:
					class92_0.intptr_1 = smethod_175(class92_0, 4096L, NativeTypes.Enum34.flag_6);
					num = ((!(class92_0.intptr_1 == IntPtr.Zero)) ? 182465141 : 1494122010) ^ (int)(num2 * 1726769930);
					continue;
				case 7u:
					intPtr = smethod_285(class92_0.method_19()).method_26();
					num = (int)(num2 * 1759082266) ^ -424275433;
					continue;
				case 6u:
					smethod_347(@class);
					num = ((int)num2 * -1741308699) ^ 0x4936511C;
					continue;
				case 5u:
					BitConverter.GetBytes(intPtr2.ToInt32()).CopyTo(class92_0.byte_0, num3);
					num = ((int)num2 * -1457549804) ^ -869352863;
					continue;
				case 4u:
					smethod_418(204, @class);
					smethod_418(204, @class);
					smethod_418(204, @class);
					num = ((int)num2 * -1518214786) ^ -1021901746;
					continue;
				case 3u:
					class63_ = AsmJitRuntime.class63_61;
					num = ((int)num2 * -91358633) ^ 0x6605F4A4;
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -427718184) ^ 0x61591AA1;
					continue;
				case 0u:
					smethod_429(@class, AsmJitRuntime.class63_54, smethod_238(AsmJitRuntime.class63_54, 0L));
					num = (int)(num2 * 1650601673) ^ -415035518;
					continue;
				case 41u:
					break;
				case 17u:
					throw new AccessViolationException("Unable to allocate memory for VEH handler.");
				case 23u:
					throw new AccessViolationException("Unable to allocate memory for the VEH.");
				case 45u:
					throw new FileNotFoundException("Unable to find ntdll.dll in the specified process.");
				case 68u:
					throw new AccessViolationException("Unable to write memory for the VEH.");
				default:
					return intPtr != IntPtr.Zero;
				}
				break;
			}
		}
	}

	internal static AsmJitMemoryOperand smethod_417(AsmJitGpRegister class63_0, long long_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			class47_0.class53_0.struct19_0.uint_2 |= 8u;
			return smethod_395(long_0, class63_0);
		}
		return smethod_238(class63_0, long_0);
	}

	internal static void smethod_418(byte byte_0, AsmJitAssembler class53_0)
	{
		smethod_308(1L, byte_0, class53_0);
	}

	internal static AsmJitImmediate smethod_423(float float_0)
	{
		return new AsmJitImmediate((IntPtr)BitConverter.ToInt32(BitConverter.GetBytes(float_0), 0));
	}
}
