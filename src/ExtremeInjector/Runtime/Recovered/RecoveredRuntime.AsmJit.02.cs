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

	internal static bool ConfigureExceptionSupport(ManualMapInjector class89_0, ManualMapInjector.Class172 class172_0)
	{
		bool useVectoredHandler = (class172_0.GetOptions() & ManualMapInjector.Enum44.flag_5) != (ManualMapInjector.Enum44)0;
		if (class89_0.GetRemoteProcess().Is64Bit)
		{
			DataDirectory exceptionDirectory = class172_0.GetImage().GetHeaders().GetOptionalHeader().GetDataDirectories()[3];
			if (exceptionDirectory.GetVirtualAddress() == 0u || exceptionDirectory.GetSize() == 0u)
			{
				return true;
			}

			ProcessModuleInfo ntdll = RecoveredRuntime.CaptureProcessModules(class89_0.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
			if (ntdll == null)
			{
				return RecoveredRuntime.FailManualMap(class89_0, new FileNotFoundException(EncodedStringTable.DecodeString(12731)));
			}

			IntPtr registerFunctionTable = RecoveredRuntime.ResolveExportByName(ntdll, EncodedStringTable.DecodeString(27654), false);
			using (AsmJitAssembler assembler = new AsmJitAssembler())
			{
				RemoteAssembler remoteAssembler = new RemoteAssembler(assembler, class89_0.GetRemoteProcess());
				RecoveredRuntime.EmitRemoteCallPrologue(remoteAssembler);
				RecoveredRuntime.EmitRemoteCall(remoteAssembler, new AsmJitImmediate(registerFunctionTable), CallingConvention.StdCall, new object[]
				{
					class172_0.GetModuleBase().Add((long)((ulong)exceptionDirectory.GetVirtualAddress())),
					exceptionDirectory.GetSize() / 12u,
					class172_0.GetModuleBase()
				});
				remoteAssembler.CaptureReturnValue<uint>();
				RecoveredRuntime.EmitRemoteCallEpilogue(remoteAssembler, -1);
				try
				{
					if (!class89_0.Execute<bool>(remoteAssembler))
					{
						return RecoveredRuntime.FailManualMap(class89_0, new Exception(EncodedStringTable.DecodeString(27683)));
					}
				}
				catch (Exception exception)
				{
					return RecoveredRuntime.FailManualMap(class89_0, new AccessViolationException(EncodedStringTable.DecodeString(27732), exception));
				}
			}

			try
			{
				VectoredExceptionHandlerInstaller installer = new VectoredExceptionHandlerInstaller(class89_0.GetRemoteProcess());
				ulong imageSize = class172_0.GetImage().GetHeaders().GetOptionalHeader().GetSizeOfImage();
				return RecoveredRuntime.InstallVectoredExceptionHandler(useVectoredHandler, imageSize, installer, class172_0.GetModuleBase()) ||
					RecoveredRuntime.FailManualMap(class89_0, new Exception(EncodedStringTable.DecodeString(27773)));
			}
			catch (Exception exception)
			{
				return RecoveredRuntime.FailManualMap(class89_0, new Exception(EncodedStringTable.DecodeString(27830), exception));
			}
		}

		NativeLoaderHooks loaderHooks = RecoveredRuntime.GetNativeLoaderHooks(class89_0.GetRemoteProcess());
		if ((class172_0.GetOptions() & ManualMapInjector.Enum44.flag_0) != (ManualMapInjector.Enum44)0 ||
			loaderHooks.GetInsertInvertedFunctionTableAddress() == IntPtr.Zero)
		{
			return class89_0.PatchSehValidation();
		}

		uint mappedImageSize = class172_0.GetImage().GetHeaders().GetOptionalHeader().GetSizeOfImage();
		loaderHooks.InsertInvertedFunctionTableEntry(class172_0.GetModuleBase(), mappedImageSize, out bool inserted);
		if (inserted)
		{
			return true;
		}

		try
		{
			VectoredExceptionHandlerInstaller installer = new VectoredExceptionHandlerInstaller(class89_0.GetRemoteProcess());
			return RecoveredRuntime.InstallVectoredExceptionHandler(useVectoredHandler, mappedImageSize, installer, class172_0.GetModuleBase());
		}
		catch (Exception exception)
		{
			return RecoveredRuntime.FailManualMap(class89_0, new Exception(EncodedStringTable.DecodeString(27830), exception));
		}
	}

	internal static void EmitMoveMemoryToRegister(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitMemoryOperand class59_0)
	{
		EmitInstruction(class53_0, AsmJitInstructionId.const_266, class63_0, class59_0);
	}

	internal static void WriteX86MemoryArgument(RemoteAssembler.Enum6 enum6_0, RemoteAssembler class47_0, AsmJitMemoryOperand class59_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_39
		};
		if (enum6_0 < RemoteAssembler.Enum6.const_2)
		{
			RecoveredRuntime.EmitMoveMemoryToRegister(class47_0.class53_0, array[(int)enum6_0], class59_0);
			return;
		}
		RecoveredRuntime.EmitPushMemory(class47_0.class53_0, class59_0);
	}

	internal static void SetMemoryOperandData(AsmJitOperand.Struct11 struct11_0, AsmJitOperand class56_0)
	{
		class56_0.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.Struct11, AsmJitOperand.Struct7>(struct11_0));
	}

	internal static AsmJitMemoryOperand CreateBaseMemoryOperand(IntPtr intptr_0, uint uint_0, AsmJitGpRegister class63_0)
	{
		AsmJitMemoryOperand @class = new AsmJitMemoryOperand();
		AsmJitApi.delegate34_0(@class, class63_0, intptr_0, uint_0);
		return @class;
	}

	internal static void EmbedUInt32(AsmJitAssembler class53_0, uint uint_0)
	{
		EmbedData(4L, uint_0, class53_0);
	}

	internal static int RelocateAssemblerCode(AsmJitAssembler class53_0, IntPtr intptr_0, IntPtr intptr_1)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			throw new ArgumentException(EncodedStringTable.DecodeString(28101), EncodedStringTable.DecodeString(28146));
		}
		return (AsmJitRuntime.bool_0 ? AsmJitApi.delegate16_0(ref class53_0.struct19_0, intptr_0, intptr_1) : AsmJitApi.delegate15_0(ref class53_0.struct19_0, intptr_0, intptr_1)).ToInt32();
	}

	internal static AsmJitImmediate CreateImmediate(double double_0)
	{
		return new AsmJitImmediate((IntPtr)BitConverter.ToInt64(BitConverter.GetBytes(double_0), 0));
	}
}
