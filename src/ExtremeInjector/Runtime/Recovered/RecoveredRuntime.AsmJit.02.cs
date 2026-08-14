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

	internal static bool smethod_424(ManualMapInjector class89_0, ManualMapInjector.Class172 class172_0)
	{
		bool bool_ = (class172_0.method_8() & ManualMapInjector.Enum44.flag_5) != 0;
		ProcessModuleInfo gClass = default(ProcessModuleInfo);
		IntPtr intptr_2 = default(IntPtr);
		RemoteAssembler @class = default(RemoteAssembler);
		DataDirectory class2 = default(DataDirectory);
		uint num7 = default(uint);
		bool result = default(bool);
		IntPtr intptr_ = default(IntPtr);
		while (true)
		{
			int num = 747753993;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6133B4B7)) % 12)
				{
				case 11u:
					num = ((gClass != null) ? 1617806714 : 342505977) ^ (int)(num2 * 1384534457);
					continue;
				case 10u:
					intptr_2 = smethod_225(gClass, "RtlAddFunctionTable", bool_0: false);
					@class = new RemoteAssembler(new AsmJitAssembler(), class89_0.method_19());
					smethod_15(@class);
					num = 1916041087;
					continue;
				case 9u:
					class2 = class172_0.method_0().method_6().method_3()
						.imethod_49()[3];
					num = ((int)num2 * -738077742) ^ 0x4F5D13EF;
					continue;
				case 6u:
					if (class89_0.method_19().Is64Bit)
					{
						num = ((int)num2 * -845766627) ^ -1299211156;
						continue;
					}
					if ((class172_0.method_8() & ManualMapInjector.Enum44.flag_0) == 0)
					{
						while (true)
						{
							int num6 = 171845372;
							while (true)
							{
								switch ((num2 = (uint)(num6 ^ 0x6133B4B7)) % 6)
								{
								case 5u:
									break;
								case 1u:
									num7 = class172_0.method_0().method_6().method_3()
										.imethod_29();
									num6 = (int)(num2 * 1859109924) ^ -656951645;
									continue;
								case 0u:
								{
									smethod_285(class89_0.method_19()).method_30(class172_0.method_2(), num7, out var bool_2);
									num6 = (bool_2 ? (-1516088331) : (-512947761)) ^ ((int)num2 * -157170035);
									continue;
								}
								case 3u:
									goto end_IL_045f;
								default:
									goto end_IL_0489;
								case 4u:
									return true;
								}
								if (smethod_285(class89_0.method_19()).method_24() != IntPtr.Zero)
								{
									num6 = ((int)num2 * -530202924) ^ 0x36CB85E0;
									continue;
								}
								goto IL_050e;
								continue;
								end_IL_045f:
								break;
							}
							continue;
							end_IL_0489:
							break;
						}
						try
						{
							VectoredExceptionHandlerInstaller class92_ = new VectoredExceptionHandlerInstaller(class89_0.method_19());
							while (true)
							{
								IL_04e3:
								int num8 = 859009516;
								while (true)
								{
									switch ((num2 = (uint)(num8 ^ 0x6133B4B7)) % 3)
									{
									case 1u:
										goto IL_04a0;
									default:
										goto end_IL_04c5;
									case 0u:
										break;
									case 2u:
										goto end_IL_04c5;
									}
									goto IL_04e3;
									IL_04a0:
									intptr_ = class172_0.method_2();
									result = smethod_410(bool_, num7, class92_, intptr_);
									num8 = ((int)num2 * -1808432043) ^ 0x651632BC;
									continue;
									end_IL_04c5:
									break;
								}
								break;
							}
						}
						catch (Exception innerException3)
						{
							result = smethod_128(class89_0, new Exception("Unable to create VEH for exception handling.", innerException3));
						}
						goto IL_0509;
					}
					goto IL_050e;
				case 4u:
					smethod_54(@class, new AsmJitImmediate(intptr_2), CallingConvention.StdCall, new object[3]
					{
						class172_0.method_2().smethod_9(class2.method_0()),
						class2.method_2() / 12,
						class172_0.method_2()
					});
					num = (int)(num2 * 1860968546) ^ -38117065;
					continue;
				case 3u:
					num = ((class2.method_2() != 0) ? (-2043721373) : (-273699586)) ^ ((int)num2 * -1367162961);
					continue;
				case 2u:
					num = ((class2.method_0() == 0) ? (-1293876121) : (-1743957216)) ^ (int)(num2 * 2063953214);
					continue;
				case 1u:
					gClass = smethod_42(class89_0.method_19())["ntdll.dll"];
					num = 467160976;
					continue;
				case 7u:
					break;
				default:
					@class.method_4<uint>();
					smethod_226(@class, -1);
					try
					{
						if (!class89_0.method_21<bool>(@class))
						{
							while (true)
							{
								IL_023a:
								int num3 = 159156274;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x6133B4B7)) % 4)
									{
									case 1u:
										goto IL_01f3;
									default:
										goto end_IL_0218;
									case 3u:
										break;
									case 2u:
										goto end_IL_0218;
									case 0u:
										goto IL_0509;
									}
									goto IL_023a;
									IL_01f3:
									result = smethod_128(class89_0, new Exception("RtlAddFunctionTable returned NULL."));
									num3 = ((int)num2 * -799601569) ^ 0x6A7E37A8;
									continue;
									end_IL_0218:
									break;
								}
								break;
							}
						}
					}
					catch (Exception innerException)
					{
						while (true)
						{
							IL_0291:
							int num4 = 1687069713;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x6133B4B7)) % 3)
								{
								case 1u:
									goto IL_024c;
								case 0u:
									break;
								default:
									goto end_IL_0273;
								}
								goto IL_0291;
								IL_024c:
								result = smethod_128(class89_0, new AccessViolationException("Unable to add function table.", innerException));
								num4 = ((int)num2 * -1807800379) ^ 0x69F0A16A;
								continue;
								end_IL_0273:
								break;
							}
							break;
						}
						goto IL_0509;
					}
					try
					{
						VectoredExceptionHandlerInstaller class92_ = new VectoredExceptionHandlerInstaller(class89_0.method_19());
						while (true)
						{
							IL_0370:
							int num5 = 1692987240;
							while (true)
							{
								switch ((num2 = (uint)(num5 ^ 0x6133B4B7)) % 7)
								{
								case 6u:
									result = true;
									num5 = 1001193383;
									continue;
								case 5u:
								{
									ulong ulong_ = class172_0.method_0().method_6().method_3()
										.imethod_29();
									num5 = (smethod_410(bool_, ulong_, class92_, intptr_) ? (-1079463147) : (-155605072)) ^ (int)(num2 * 157283344);
									continue;
								}
								case 4u:
									result = smethod_128(class89_0, new Exception("AddVectoredExceptionHandler returned NULL."));
									num5 = (int)(num2 * 1565327577) ^ -1558342489;
									continue;
								case 1u:
									intptr_ = class172_0.method_2();
									num5 = (int)((num2 * 1663965224) ^ 0x6C4B7B15);
									continue;
								default:
									goto end_IL_0342;
								case 2u:
									break;
								case 0u:
									goto end_IL_0342;
								case 3u:
									goto end_IL_0342;
								}
								goto IL_0370;
								continue;
								end_IL_0342:
								break;
							}
							break;
						}
					}
					catch (Exception innerException2)
					{
						result = smethod_128(class89_0, new Exception("Unable to create VEH for exception handling.", innerException2));
					}
					goto IL_0509;
				case 5u:
					return smethod_128(class89_0, new FileNotFoundException("Unable to find ntdll.dll in the specified process."));
				case 8u:
					{
						return true;
					}
					IL_050e:
					return class89_0.method_40();
					IL_0509:
					return result;
				}
				break;
			}
		}
	}

	internal static void smethod_429(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitMemoryOperand class59_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_266, class63_0, class59_0);
	}

	internal static void smethod_431(RemoteAssembler.Enum6 enum6_0, RemoteAssembler class47_0, AsmJitMemoryOperand class59_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[2]
		{
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_39
		};
		while (true)
		{
			int num = 659726129;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1C28A858)) % 6)
				{
				case 5u:
					num = ((enum6_0 >= RemoteAssembler.Enum6.const_2) ? (-477592048) : (-1342125189)) ^ (int)(num2 * 459966993);
					continue;
				case 3u:
					smethod_371(class47_0.class53_0, class59_0);
					num = 1868990529;
					continue;
				case 0u:
					smethod_429(class47_0.class53_0, array[(int)enum6_0], class59_0);
					num = (int)(num2 * 749078584) ^ -1505451904;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_432(AsmJitOperand.Struct11 struct11_0, AsmJitOperand class56_0)
	{
		class56_0.method_1(AsmJitOperand.smethod_0<AsmJitOperand.Struct11, AsmJitOperand.Struct7>(struct11_0));
	}

	internal static AsmJitMemoryOperand smethod_433(IntPtr intptr_0, uint uint_0, AsmJitGpRegister class63_0)
	{
		AsmJitMemoryOperand @class = new AsmJitMemoryOperand();
		while (true)
		{
			int num = 1024338629;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4F8009B9)) % 3)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					return @class;
				}
				break;
				IL_0008:
				AsmJitApi.smethod_60()(@class, class63_0, intptr_0, uint_0);
				num = ((int)num2 * -2143689129) ^ -351832783;
			}
		}
	}

	internal static void smethod_439(AsmJitAssembler class53_0, uint uint_0)
	{
		smethod_308(4L, uint_0, class53_0);
	}

	internal static int smethod_441(AsmJitAssembler class53_0, IntPtr intptr_0, IntPtr intptr_1)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			goto IL_0023;
		}
		goto IL_006c;
		IL_0023:
		int num = 358328795;
		goto IL_0028;
		IL_0028:
		IntPtr intPtr = default(IntPtr);
		switch ((uint)(num ^ 0x4BAB216B) % 5u)
		{
		case 4u:
			break;
		case 2u:
			goto IL_004b;
		case 0u:
			goto IL_006c;
		case 1u:
			throw new ArgumentException("The value cannot be IntPtr.Zero.", "dst");
		default:
			return intPtr.ToInt32();
		}
		goto IL_0023;
		IL_006c:
		IntPtr intPtr2;
		if (AsmJitRuntime.bool_0)
		{
			intPtr2 = AsmJitApi.smethod_26()(ref class53_0.struct19_0, intptr_0, intptr_1);
			goto IL_005d;
		}
		num = 581705563;
		goto IL_0028;
		IL_004b:
		intPtr2 = AsmJitApi.smethod_24()(ref class53_0.struct19_0, intptr_0, intptr_1);
		goto IL_005d;
		IL_005d:
		intPtr = intPtr2;
		num = 878799475;
		goto IL_0028;
	}

	internal static AsmJitImmediate smethod_446(double double_0)
	{
		return new AsmJitImmediate((IntPtr)BitConverter.ToInt64(BitConverter.GetBytes(double_0), 0));
	}
}
