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

	internal static bool ConfigureExceptionSupport(ManualMapInjector manualMapInjector, ManualMapInjector.MappingContext mappingContext)
	{
		bool useVectoredHandler = (mappingContext.GetOptions() & ManualMapInjector.ManualMapOptions.UseVectoredExceptionHandler) != (ManualMapInjector.ManualMapOptions)0;
		if (manualMapInjector.GetRemoteProcess().Is64Bit)
		{
			DataDirectory exceptionDirectory = mappingContext.GetImage().GetHeaders().GetOptionalHeader().GetDataDirectories()[3];
			if (exceptionDirectory.GetVirtualAddress() == 0u || exceptionDirectory.GetSize() == 0u)
			{
				return true;
			}

			ProcessModuleInfo ntdll = RecoveredRuntime.CaptureProcessModules(manualMapInjector.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
			if (ntdll == null)
			{
				return RecoveredRuntime.FailManualMap(manualMapInjector, new FileNotFoundException(EncodedStringTable.DecodeString(12731)));
			}

			IntPtr registerFunctionTable = RecoveredRuntime.ResolveExportByName(ntdll, EncodedStringTable.DecodeString(27654), false);
			using (AsmJitAssembler assembler = new AsmJitAssembler())
			{
				RemoteAssembler remoteAssembler = new RemoteAssembler(assembler, manualMapInjector.GetRemoteProcess());
				RecoveredRuntime.EmitRemoteCallPrologue(remoteAssembler);
				RecoveredRuntime.EmitRemoteCall(remoteAssembler, new AsmJitImmediate(registerFunctionTable), CallingConvention.StdCall, new object[]
				{
					mappingContext.GetModuleBase().Add((long)((ulong)exceptionDirectory.GetVirtualAddress())),
					exceptionDirectory.GetSize() / 12u,
					mappingContext.GetModuleBase()
				});
				remoteAssembler.CaptureReturnValue<uint>();
				RecoveredRuntime.EmitRemoteCallEpilogue(remoteAssembler, -1);
				try
				{
					if (!manualMapInjector.Execute<bool>(remoteAssembler))
					{
						return RecoveredRuntime.FailManualMap(manualMapInjector, new Exception(EncodedStringTable.DecodeString(27683)));
					}
				}
				catch (Exception exception)
				{
					return RecoveredRuntime.FailManualMap(manualMapInjector, new AccessViolationException(EncodedStringTable.DecodeString(27732), exception));
				}
			}

			try
			{
				VectoredExceptionHandlerInstaller installer = new VectoredExceptionHandlerInstaller(manualMapInjector.GetRemoteProcess());
				ulong imageSize = mappingContext.GetImage().GetHeaders().GetOptionalHeader().GetSizeOfImage();
				return RecoveredRuntime.InstallVectoredExceptionHandler(useVectoredHandler, imageSize, installer, mappingContext.GetModuleBase()) ||
					RecoveredRuntime.FailManualMap(manualMapInjector, new Exception(EncodedStringTable.DecodeString(27773)));
			}
			catch (Exception exception)
			{
				return RecoveredRuntime.FailManualMap(manualMapInjector, new Exception(EncodedStringTable.DecodeString(27830), exception));
			}
		}

		NativeLoaderHooks loaderHooks = RecoveredRuntime.GetNativeLoaderHooks(manualMapInjector.GetRemoteProcess());
		if ((mappingContext.GetOptions() & ManualMapInjector.ManualMapOptions.DisableSehValidation) != (ManualMapInjector.ManualMapOptions)0 ||
			loaderHooks.GetInsertInvertedFunctionTableAddress() == IntPtr.Zero)
		{
			return manualMapInjector.PatchSehValidation();
		}

		uint mappedImageSize = mappingContext.GetImage().GetHeaders().GetOptionalHeader().GetSizeOfImage();
		loaderHooks.InsertInvertedFunctionTableEntry(mappingContext.GetModuleBase(), mappedImageSize, out bool inserted);
		if (inserted)
		{
			return true;
		}

		try
		{
			VectoredExceptionHandlerInstaller installer = new VectoredExceptionHandlerInstaller(manualMapInjector.GetRemoteProcess());
			return RecoveredRuntime.InstallVectoredExceptionHandler(useVectoredHandler, mappedImageSize, installer, mappingContext.GetModuleBase());
		}
		catch (Exception exception)
		{
			return RecoveredRuntime.FailManualMap(manualMapInjector, new Exception(EncodedStringTable.DecodeString(27830), exception));
		}
	}

	internal static void EmitMoveMemoryToRegister(AsmJitAssembler assembler, AsmJitGpRegister gpRegister, AsmJitMemoryOperand memoryOperand)
	{
		EmitInstruction(assembler, AsmJitInstructionId.Move, gpRegister, memoryOperand);
	}

	internal static void WriteX86MemoryArgument(RemoteAssembler.X86ArgumentSlot x86ArgumentSlot, RemoteAssembler remoteAssembler, AsmJitMemoryOperand memoryOperand)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.gpRegister39,
			AsmJitRuntime.gpRegister40
		};
		if (x86ArgumentSlot < RemoteAssembler.X86ArgumentSlot.FirstStackArgument)
		{
			RecoveredRuntime.EmitMoveMemoryToRegister(remoteAssembler.assembler, array[(int)x86ArgumentSlot], memoryOperand);
			return;
		}
		RecoveredRuntime.EmitPushMemory(remoteAssembler.assembler, memoryOperand);
	}

	internal static void SetMemoryOperandData(AsmJitOperand.MemoryOperandData memoryOperandData, AsmJitOperand operand)
	{
		operand.SetRawData(AsmJitOperand.Reinterpret<AsmJitOperand.MemoryOperandData, AsmJitOperand.RawOperandData>(memoryOperandData));
	}

	internal static AsmJitMemoryOperand CreateBaseMemoryOperand(IntPtr address, uint uintValue, AsmJitGpRegister gpRegister)
	{
		AsmJitMemoryOperand @class = new AsmJitMemoryOperand();
		AsmJitApi.createRegisterMemoryOperand(@class, gpRegister, address, uintValue);
		return @class;
	}

	internal static void EmbedUInt32(AsmJitAssembler assembler, uint uintValue)
	{
		EmbedData(4L, uintValue, assembler);
	}

	internal static int RelocateAssemblerCode(AsmJitAssembler assembler, IntPtr address, IntPtr address2)
	{
		if (address == IntPtr.Zero)
		{
			throw new ArgumentException(EncodedStringTable.DecodeString(28101), EncodedStringTable.DecodeString(28146));
		}
		return (AsmJitRuntime.flag ? AsmJitApi.relocateCodeCdecl(ref assembler.assemblerState, address, address2) : AsmJitApi.relocateCodeThisCall(ref assembler.assemblerState, address, address2)).ToInt32();
	}

	internal static AsmJitImmediate CreateImmediate(double doubleValue)
	{
		return new AsmJitImmediate((IntPtr)BitConverter.ToInt64(BitConverter.GetBytes(doubleValue), 0));
	}
}
