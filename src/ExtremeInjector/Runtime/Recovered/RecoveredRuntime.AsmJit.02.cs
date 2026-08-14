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
		bool bool_ = (class172_0.method_8() & ManualMapInjector.Enum44.flag_5) > (ManualMapInjector.Enum44)0;
		bool result;
		if (class89_0.method_19().Is64Bit)
		{
			DataDirectory @class = class172_0.method_0().method_6().method_3().imethod_49()[3];
			if (@class.method_0() == 0u || @class.method_2() == 0u)
			{
				return true;
			}
			ProcessModuleInfo gclass = RecoveredRuntime.smethod_42(class89_0.method_19())[EncodedStringTable.smethod_0(8549)];
			if (gclass != null)
			{
				IntPtr intptr_ = RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(27654), false);
				RemoteAssembler class2 = new RemoteAssembler(new AsmJitAssembler(), class89_0.method_19());
				RecoveredRuntime.smethod_15(class2);
				RecoveredRuntime.smethod_54(class2, new AsmJitImmediate(intptr_), CallingConvention.StdCall, new object[]
				{
					class172_0.method_2().smethod_9((long)((ulong)@class.method_0())),
					@class.method_2() / 12u,
					class172_0.method_2()
				});
				class2.method_4<uint>();
				RecoveredRuntime.smethod_226(class2, -1);
				try
				{
					if (!class89_0.method_21<bool>(class2))
					{
						return RecoveredRuntime.smethod_128(class89_0, new Exception(EncodedStringTable.smethod_0(27683)));
					}
				}
				catch (Exception innerException)
				{
					return RecoveredRuntime.smethod_128(class89_0, new AccessViolationException(EncodedStringTable.smethod_0(27732), innerException));
				}
				try
				{
					VectoredExceptionHandlerInstaller class92_ = new VectoredExceptionHandlerInstaller(class89_0.method_19());
					IntPtr intptr_2 = class172_0.method_2();
					ulong ulong_ = (ulong)class172_0.method_0().method_6().method_3().imethod_29();
					if (!RecoveredRuntime.smethod_410(bool_, ulong_, class92_, intptr_2))
					{
						return RecoveredRuntime.smethod_128(class89_0, new Exception(EncodedStringTable.smethod_0(27773)));
					}
					return true;
				}
				catch (Exception innerException2)
				{
					return RecoveredRuntime.smethod_128(class89_0, new Exception(EncodedStringTable.smethod_0(27830), innerException2));
				}
			}
			return RecoveredRuntime.smethod_128(class89_0, new FileNotFoundException(EncodedStringTable.smethod_0(12731)));
		}
		else
		{
			if ((class172_0.method_8() & ManualMapInjector.Enum44.flag_0) != (ManualMapInjector.Enum44)0 || !(RecoveredRuntime.smethod_285(class89_0.method_19()).method_24() != IntPtr.Zero))
			{
				return class89_0.method_40();
			}
			uint num = class172_0.method_0().method_6().method_3().imethod_29();
			bool flag;
			RecoveredRuntime.smethod_285(class89_0.method_19()).method_30(class172_0.method_2(), (ulong)num, out flag);
			if (flag)
			{
				return true;
			}
			try
			{
				VectoredExceptionHandlerInstaller class92_ = new VectoredExceptionHandlerInstaller(class89_0.method_19());
				IntPtr intptr_2 = class172_0.method_2();
				result = RecoveredRuntime.smethod_410(bool_, (ulong)num, class92_, intptr_2);
			}
			catch (Exception innerException3)
			{
				result = RecoveredRuntime.smethod_128(class89_0, new Exception(EncodedStringTable.smethod_0(27830), innerException3));
			}
		}
		return result;
	}

	internal static void smethod_429(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitMemoryOperand class59_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_266, class63_0, class59_0);
	}

	internal static void smethod_431(RemoteAssembler.Enum6 enum6_0, RemoteAssembler class47_0, AsmJitMemoryOperand class59_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_39
		};
		if (enum6_0 < RemoteAssembler.Enum6.const_2)
		{
			RecoveredRuntime.smethod_429(class47_0.class53_0, array[(int)enum6_0], class59_0);
			return;
		}
		RecoveredRuntime.smethod_371(class47_0.class53_0, class59_0);
	}

	internal static void smethod_432(AsmJitOperand.Struct11 struct11_0, AsmJitOperand class56_0)
	{
		class56_0.method_1(AsmJitOperand.smethod_0<AsmJitOperand.Struct11, AsmJitOperand.Struct7>(struct11_0));
	}

	internal static AsmJitMemoryOperand smethod_433(IntPtr intptr_0, uint uint_0, AsmJitGpRegister class63_0)
	{
		AsmJitMemoryOperand @class = new AsmJitMemoryOperand();
		AsmJitApi.smethod_60()(@class, class63_0, intptr_0, uint_0);
		return @class;
	}

	internal static void smethod_439(AsmJitAssembler class53_0, uint uint_0)
	{
		smethod_308(4L, uint_0, class53_0);
	}

	internal static int smethod_441(AsmJitAssembler class53_0, IntPtr intptr_0, IntPtr intptr_1)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			throw new ArgumentException(EncodedStringTable.smethod_0(28101), EncodedStringTable.smethod_0(28146));
		}
		return (AsmJitRuntime.bool_0 ? AsmJitApi.smethod_26()(ref class53_0.struct19_0, intptr_0, intptr_1) : AsmJitApi.smethod_24()(ref class53_0.struct19_0, intptr_0, intptr_1)).ToInt32();
	}

	internal static AsmJitImmediate smethod_446(double double_0)
	{
		return new AsmJitImmediate((IntPtr)BitConverter.ToInt64(BitConverter.GetBytes(double_0), 0));
	}
}
