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
			RecoveredRuntime.smethod_82(class47_0.class53_0, AsmJitRuntime.class63_42);
			RecoveredRuntime.smethod_318(class47_0.class53_0, AsmJitRuntime.class63_42, AsmJitRuntime.class63_41);
			return;
		}
		if (class47_0.bool_1)
		{
			class47_0.class58_1 = RecoveredRuntime.smethod_48(class47_0.class53_0);
			AsmJitAssembler class53_ = class47_0.class53_0;
			class53_.struct19_0.uint_2 = (class53_.struct19_0.uint_2 | 8u);
			RecoveredRuntime.smethod_75(class47_0.class53_0, RecoveredRuntime.smethod_126(class47_0.class58_1, 0L), AsmJitRuntime.class63_41);
			AsmJitAssembler class53_2 = class47_0.class53_0;
			AsmJitGpRegister class63_ = AsmJitRuntime.class63_41;
			AsmJitImmediate class57_ = RecoveredRuntime.smethod_374(4294967280u);
			RecoveredRuntime.smethod_23(class63_, class57_, class53_2);
			RecoveredRuntime.smethod_418(106, class47_0.class53_0);
			RecoveredRuntime.smethod_418(51, class47_0.class53_0);
			RecoveredRuntime.smethod_418(232, class47_0.class53_0);
			RecoveredRuntime.smethod_439(class47_0.class53_0, 0u);
			RecoveredRuntime.smethod_418(131, class47_0.class53_0);
			RecoveredRuntime.smethod_418(4, class47_0.class53_0);
			RecoveredRuntime.smethod_418(36, class47_0.class53_0);
			RecoveredRuntime.smethod_418(5, class47_0.class53_0);
			RecoveredRuntime.smethod_418(203, class47_0.class53_0);
		}
		RecoveredRuntime.smethod_75(class47_0.class53_0, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, 8L), AsmJitRuntime.class63_54);
		RecoveredRuntime.smethod_75(class47_0.class53_0, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, 16L), AsmJitRuntime.class63_55);
		RecoveredRuntime.smethod_75(class47_0.class53_0, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, 24L), AsmJitRuntime.class63_61);
		RecoveredRuntime.smethod_75(class47_0.class53_0, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, 32L), AsmJitRuntime.class63_62);
	}

	internal static AsmJitOperand.Struct13 smethod_16(AsmJitOperand class56_0)
	{
		return AsmJitOperand.smethod_0<AsmJitOperand.Struct7, AsmJitOperand.Struct13>(class56_0.method_0());
	}

	internal static void smethod_20(AsmJitAssembler class53_0)
	{
		if (!class53_0.method_0() && !AsmJitRuntime.bool_0)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(11455));
		}
		RecoveredRuntime.smethod_31(class53_0, AsmJitInstructionId.const_466);
	}

	internal static void smethod_23(AsmJitGpRegister class63_0, AsmJitImmediate class57_0, AsmJitAssembler class53_0)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_10, class63_0, class57_0);
	}

	internal static bool smethod_26(ManualMapInjector class89_0, ManualMapInjector.Class172 class172_0)
	{
		byte[] array = ManualMapInjector.smethod_7(class172_0.method_0());
		if (array == null)
		{
			return true;
		}
		ProcessModuleInfo gclass = RecoveredRuntime.smethod_42(class89_0.method_19())[EncodedStringTable.smethod_0(8503)];
		if (gclass == null)
		{
			return true;
		}
		IntPtr intPtr = RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(12056), false);
		if (intPtr == IntPtr.Zero)
		{
			return RecoveredRuntime.smethod_128(class89_0, new MissingMethodException(EncodedStringTable.smethod_0(12077)));
		}
		string tempFileName = Path.GetTempFileName();
		File.WriteAllBytes(tempFileName, array);
		IntPtr intPtr2 = RecoveredRuntime.smethod_175(class89_0, 4096L, NativeTypes.Enum34.flag_2);
		if (intPtr2 == IntPtr.Zero)
		{
			File.Delete(tempFileName);
			return RecoveredRuntime.smethod_128(class89_0, new AccessViolationException(EncodedStringTable.smethod_0(12146)));
		}
		AsmJitAssembler @class = new AsmJitAssembler();
		RemoteAssembler class2 = new RemoteAssembler(@class, class89_0.method_19());
		AsmJitLabel class58_ = RecoveredRuntime.smethod_48(@class);
		RecoveredRuntime.smethod_15(class2);
		RecoveredRuntime.smethod_54(class2, new AsmJitImmediate(intPtr), CallingConvention.StdCall, new object[]
		{
			RecoveredRuntime.smethod_84(class2, class58_)
		});
		class2.method_4<IntPtr>();
		RecoveredRuntime.smethod_226(class2, -1);
		RecoveredRuntime.smethod_227(class2);
		if (!RecoveredRuntime.smethod_427(class89_0.method_19()))
		{
			NativeTypes.Struct52 gparam_ = default(NativeTypes.Struct52);
			gparam_.int_0 = typeof(NativeTypes.Struct52).smethod_7();
			gparam_.intptr_0 = intPtr2.smethod_8(RecoveredRuntime.smethod_252(@class));
			RecoveredRuntime.smethod_320(@class, Encoding.Unicode.GetBytes(tempFileName + EncodedStringTable.smethod_0(12219)));
			RecoveredRuntime.smethod_227(class2);
			RecoveredRuntime.smethod_36(@class, class58_);
			@class.method_2<NativeTypes.Struct52>(gparam_);
		}
		else
		{
			NativeTypes.Struct51 gparam_2 = default(NativeTypes.Struct51);
			gparam_2.int_0 = typeof(NativeTypes.Struct51).smethod_7();
			gparam_2.uint_1 = (uint)((int)intPtr2 + RecoveredRuntime.smethod_252(@class));
			RecoveredRuntime.smethod_320(@class, Encoding.Unicode.GetBytes(tempFileName + EncodedStringTable.smethod_0(12219)));
			RecoveredRuntime.smethod_227(class2);
			RecoveredRuntime.smethod_36(@class, class58_);
			@class.method_2<NativeTypes.Struct51>(gparam_2);
		}
		class172_0.method_13(class89_0.method_22<IntPtr>(class2, intPtr2, true));
		return true;
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
			AsmJitApi.smethod_49()(ref class53_0.struct19_0, class58_0);
			return;
		}
		AsmJitApi.smethod_47()(ref class53_0.struct19_0, class58_0);
	}

	internal static bool InvokeExport(ModuleEntry module, IntPtr intptr_0, RemoteProcess process)
	{
        if (HasProcessExited(process))
        {
            throw new InvalidOperationException(UiText.Get("Message.TargetNoLongerActive"));
        }

        ExportedSymbol export;
        using (FileStream stream = new FileStream(module.Path, FileMode.Open, FileAccess.Read, FileShare.Read))
        using (PeImage image = PeExportReader.Read(stream, module.Path, ownsStream: false, layout: PeImageLayout.const_0))
        {
            if (image.method_14() == null)
            {
                throw new MissingFieldException(UiText.Get("Message.ExportDirectoryMissing"));
            }

            export = image.method_14().list_1.FirstOrDefault(candidate => candidate.method_4() == module.ExportName);
            if (export == null)
            {
                throw new MissingMethodException(UiText.Format("Message.ExportNotFound", module.ExportName));
            }
        }

        IntPtr exportAddress = intptr_0.smethod_9(export.method_6());
        if (module.Parameters == null)
        {
            module.Parameters = new List<ExportParameter>();
        }

        object[] values = module.Parameters.Select(smethod_138).ToArray();
        AsmJitAssembler assembler = new AsmJitAssembler();
        RemoteAssembler remoteAssembler = new RemoteAssembler(assembler, process);
        List<AsmJitLabel> stringLabels = new List<AsmJitLabel>();
        List<object> arguments = new List<object>();

        for (int index = 0; index < values.Length; index++)
        {
            if (values[index] is string)
            {
                AsmJitLabel label = smethod_48(assembler);
                stringLabels.Add(label);
                arguments.Add(smethod_84(remoteAssembler, label));
                continue;
            }

            if (smethod_427(process) && module.Parameters[index].Type == ExportParameterType.UInt64)
            {
                long value = (long)values[index];
                arguments.Add(((ulong)(value & 0xFFFFFFFFL)).smethod_0());
                arguments.Add(((ulong)(value & -4294967296L) >> 32).smethod_0());
            }
            else
            {
                arguments.Add(values[index].smethod_0());
            }
        }

        smethod_15(remoteAssembler);
        smethod_54(remoteAssembler, new AsmJitImmediate(exportAddress), module.CallingConvention, arguments.ToArray());
        smethod_226(remoteAssembler, -1);

        int stringIndex = 0;
        for (int index = 0; index < values.Length; index++)
        {
            if (values[index] is not string text)
            {
                continue;
            }

            smethod_227(remoteAssembler);
            smethod_36(assembler, stringLabels[stringIndex++]);
            if (module.Parameters[index].Type == ExportParameterType.AnsiString)
            {
                smethod_320(assembler, Encoding.ASCII.GetBytes(text));
                smethod_418(0, assembler);
            }
            else
            {
                smethod_320(assembler, Encoding.Unicode.GetBytes(text));
                smethod_105(0, assembler);
            }
        }

        using (RemoteCodeExecutor executor = new RemoteCodeExecutor(process))
        {
            return smethod_140(executor, assembler);
        }
    }

	internal static void smethod_39(AsmJitGpRegister class63_0, RemoteAssembler class47_0, RemoteAssembler.Enum6 enum6_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_39
		};
		if (enum6_0 < RemoteAssembler.Enum6.const_2)
		{
			RecoveredRuntime.smethod_318(class47_0.class53_0, array[(int)enum6_0], class63_0);
			return;
		}
		RecoveredRuntime.smethod_82(class47_0.class53_0, class63_0);
	}

	internal static AsmJitLabel smethod_48(AsmJitAssembler class53_0)
	{
		AsmJitLabel @class = new AsmJitLabel();
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.smethod_45()(ref class53_0.struct19_0, @class);
		}
		else
		{
			AsmJitApi.smethod_43()(ref class53_0.struct19_0, @class);
		}
		return @class;
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
		if (!class53_0.method_0() && AsmJitRuntime.bool_0)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(12411));
		}
		RecoveredRuntime.smethod_31(class53_0, AsmJitInstructionId.const_422);
	}

	internal static void smethod_54(RemoteAssembler class47_0, AsmJitImmediate class57_0, CallingConvention callingConvention_0, object[] object_0)
	{
		smethod_83(object_0, callingConvention_0, class57_0, class47_0);
	}

	internal static void smethod_55(AsmJitAssembler class53_0)
	{
		if (class53_0.method_0() || !AsmJitRuntime.bool_0)
		{
			RecoveredRuntime.smethod_31(class53_0, AsmJitInstructionId.const_420);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.smethod_0(12411));
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
		if (class53_0.method_0() || AsmJitRuntime.bool_0)
		{
			RecoveredRuntime.smethod_137(class53_0, AsmJitInstructionId.const_289, class65_0, class63_0);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.smethod_0(11455));
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
			AsmJitAssembler class53_ = class47_0.class53_0;
			class53_.struct19_0.uint_2 = (class53_.struct19_0.uint_2 | 8u);
		}
		return RecoveredRuntime.smethod_126(class58_0, long_0);
	}

	internal static void smethod_82(AsmJitAssembler class53_0, AsmJitGpRegister class63_0)
	{
		smethod_352(class63_0, AsmJitInstructionId.const_463, class53_0);
	}

	internal static void smethod_83(object[] object_0, CallingConvention callingConvention_0, AsmJitOperand class56_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			RecoveredRuntime.smethod_358(class56_0, object_0, callingConvention_0, class47_0);
			return;
		}
		RecoveredRuntime.smethod_365(class47_0, class56_0, object_0);
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
		if (!class53_0.method_0() && AsmJitRuntime.bool_0)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(12411));
		}
		RecoveredRuntime.smethod_31(class53_0, AsmJitInstructionId.const_465);
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
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_39
		};
		if (enum6_0 >= RemoteAssembler.Enum6.const_2)
		{
			RecoveredRuntime.smethod_298(class47_0.class53_0, class57_0);
			return;
		}
		if (!(RecoveredRuntime.smethod_219(class57_0).intptr_0 == IntPtr.Zero))
		{
			RecoveredRuntime.smethod_306(class47_0.class53_0, array[(int)enum6_0], class57_0);
			return;
		}
		RecoveredRuntime.smethod_164(class47_0.class53_0, array[(int)enum6_0], array[(int)enum6_0]);
	}

	internal static void smethod_115(AsmJitAssembler class53_0)
	{
		class53_0.struct19_0.struct15_0.method_0();
		class53_0.struct19_0.struct17_0.method_0();
		class53_0.struct19_0.struct18_1.method_0();
		class53_0.struct19_0.struct18_0.method_0();
		class53_0.struct19_0.uint_0 = 0u;
	}

	internal static AsmJitMemoryOperand smethod_116(AsmJitLabel class58_0, long long_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			AsmJitAssembler class53_ = class47_0.class53_0;
			class53_.struct19_0.uint_2 = (class53_.struct19_0.uint_2 | 8u);
		}
		return RecoveredRuntime.smethod_364(class58_0, long_0);
	}

	internal static void smethod_118(AsmJitAssembler class53_0, IntPtr intptr_0)
	{
		smethod_308(IntPtr.Size, intptr_0, class53_0);
	}

	internal static void smethod_121(RemoteAssembler class47_0, AsmJitImmediate class57_0, int int_0, bool bool_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		AsmJitXmmRegister[] array2 = new AsmJitXmmRegister[]
		{
			AsmJitRuntime.class65_0,
			AsmJitRuntime.class65_1,
			AsmJitRuntime.class65_2,
			AsmJitRuntime.class65_3
		};
		bool flag = RecoveredRuntime.smethod_219(class57_0).intptr_0 == IntPtr.Zero;
		if (int_0 >= 4)
		{
			if (!flag)
			{
				RecoveredRuntime.smethod_306(class47_0.class53_0, AsmJitRuntime.class63_53, class57_0);
			}
			else
			{
				RecoveredRuntime.smethod_164(class47_0.class53_0, AsmJitRuntime.class63_53, AsmJitRuntime.class63_53);
			}
			RecoveredRuntime.smethod_75(class47_0.class53_0, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, (long)(int_0 * 8)), AsmJitRuntime.class63_53);
			return;
		}
		if (bool_0)
		{
			if (flag)
			{
				RecoveredRuntime.smethod_306(class47_0.class53_0, AsmJitRuntime.class63_53, class57_0);
			}
			else
			{
				RecoveredRuntime.smethod_164(class47_0.class53_0, AsmJitRuntime.class63_53, AsmJitRuntime.class63_53);
			}
			RecoveredRuntime.smethod_68(class47_0.class53_0, array2[int_0], AsmJitRuntime.class63_53);
			return;
		}
		if (flag)
		{
			RecoveredRuntime.smethod_164(class47_0.class53_0, array[int_0], array[int_0]);
			return;
		}
		RecoveredRuntime.smethod_306(class47_0.class53_0, array[int_0], class57_0);
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
		return (class62_1 == null && class62_0 == null) || (class62_1 != null && class62_1.Equals(class62_0));
	}

	internal static void smethod_137(AsmJitAssembler class53_0, AsmJitInstructionId enum7_0, AsmJitOperand class56_0, AsmJitOperand class56_1)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.smethod_15()(ref class53_0.struct19_0, enum7_0, class56_0, class56_1);
			return;
		}
		AsmJitApi.smethod_8()(ref class53_0.struct19_0, enum7_0, class56_0, class56_1);
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
		@class.method_1(true);
		AsmJitAssembler class2 = @class;
		AsmJitLabel class58_ = RecoveredRuntime.smethod_48(class2);
		AsmJitLabel class58_2 = RecoveredRuntime.smethod_48(class2);
		AsmJitLabel class58_3 = RecoveredRuntime.smethod_48(class2);
		AsmJitLabel class58_4 = RecoveredRuntime.smethod_48(class2);
		AsmJitLabel class58_5 = RecoveredRuntime.smethod_48(class2);
		RecoveredRuntime.smethod_298(class2, RecoveredRuntime.smethod_374(struct54_0.uint_17));
		RecoveredRuntime.smethod_94(class2);
		RecoveredRuntime.smethod_173(class2);
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_37,
			AsmJitRuntime.class63_40,
			AsmJitRuntime.class63_39,
			AsmJitRuntime.class63_38,
			AsmJitRuntime.class63_44,
			AsmJitRuntime.class63_42,
			AsmJitRuntime.class63_59
		};
		AsmJitGpRegister[] array2 = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_69,
			AsmJitRuntime.class63_72,
			AsmJitRuntime.class63_71,
			AsmJitRuntime.class63_70,
			AsmJitRuntime.class63_76,
			AsmJitRuntime.class63_74,
			AsmJitRuntime.class63_60
		};
		AsmJitGpRegister class63_ = array.smethod_2<AsmJitGpRegister>();
		AsmJitAssembler class3 = class2;
		class3.struct19_0.uint_2 = (class3.struct19_0.uint_2 | 8u);
		RecoveredRuntime.smethod_263(class2, class63_, RecoveredRuntime.smethod_126(class58_, 0L));
		RecoveredRuntime.smethod_82(class2, class63_);
		int num = array.smethod_3<AsmJitGpRegister>();
		RecoveredRuntime.smethod_306(class2, array[num], new AsmJitImmediate(intptr_0));
		RecoveredRuntime.smethod_372(array2[num], class2);
		AsmJitAssembler class4 = class2;
		class4.struct19_0.uint_2 = (class4.struct19_0.uint_2 | 8u);
		RecoveredRuntime.smethod_75(class2, RecoveredRuntime.smethod_126(class58_3, 0L), AsmJitRuntime.class63_37);
		AsmJitGpRegister class63_2 = AsmJitRuntime.class63_37;
		AsmJitGpRegister class63_3 = AsmJitRuntime.class63_37;
		RecoveredRuntime.smethod_310(class63_2, class63_3, class2);
		RecoveredRuntime.smethod_91(class58_5, AsmJitJumpHint.const_0, class2);
		RecoveredRuntime.smethod_306(class2, array[num], new AsmJitImmediate(intptr_1));
		RecoveredRuntime.smethod_372(array2[num], class2);
		AsmJitAssembler class5 = class2;
		class5.struct19_0.uint_2 = (class5.struct19_0.uint_2 | 8u);
		RecoveredRuntime.smethod_75(class2, RecoveredRuntime.smethod_126(class58_4, 0L), AsmJitRuntime.class63_37);
		RecoveredRuntime.smethod_36(class2, class58_5);
		AsmJitAssembler class6 = class2;
		class6.struct19_0.uint_2 = (class6.struct19_0.uint_2 | 8u);
		AsmJitMemoryOperand class59_ = RecoveredRuntime.smethod_126(class58_2, 0L);
		AsmJitImmediate class57_ = RecoveredRuntime.smethod_167(1);
		RecoveredRuntime.smethod_127(class57_, class59_, class2);
		RecoveredRuntime.smethod_55(class2);
		RecoveredRuntime.smethod_53(class2);
		RecoveredRuntime.smethod_347(class2);
		RecoveredRuntime.smethod_200(class2, 4u);
		RecoveredRuntime.smethod_36(class2, class58_);
		RecoveredRuntime.smethod_320(class2, byte_0);
		RecoveredRuntime.smethod_200(class2, 4u);
		RecoveredRuntime.smethod_36(class2, class58_4);
		int_2 = RecoveredRuntime.smethod_252(class2);
		RecoveredRuntime.smethod_439(class2, 0u);
		RecoveredRuntime.smethod_200(class2, 4u);
		RecoveredRuntime.smethod_36(class2, class58_3);
		int_1 = RecoveredRuntime.smethod_252(class2);
		RecoveredRuntime.smethod_439(class2, 0u);
		RecoveredRuntime.smethod_36(class2, class58_2);
		int_0 = RecoveredRuntime.smethod_252(class2);
		RecoveredRuntime.smethod_439(class2, 0u);
		return RecoveredRuntime.smethod_61(class2, class90_0);
	}

	internal static void smethod_149(AsmJitInstructionId enum7_0, AsmJitLabel class58_0, AsmJitAssembler class53_0, AsmJitJumpHint enum12_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.smethod_41()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
			return;
		}
		AsmJitApi.smethod_39()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
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
		if (class53_0.method_0() || !AsmJitRuntime.bool_0)
		{
			RecoveredRuntime.smethod_31(class53_0, AsmJitInstructionId.const_464);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.smethod_0(12411));
	}

	internal static IntPtr smethod_178(ThreadHijackInjector class90_0, IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, out NativeTypes.Struct55 struct55_0, out int int_0, out int int_1, ref int int_2)
	{
		struct55_0 = default(NativeTypes.Struct55);
		int_0 = 0;
		int_1 = 0;
		AsmJitAssembler class53_ = new AsmJitAssembler();
		AsmJitLabel class58_ = RecoveredRuntime.smethod_48(class53_);
		AsmJitLabel class58_2 = RecoveredRuntime.smethod_48(class53_);
		AsmJitLabel class58_3 = RecoveredRuntime.smethod_48(class53_);
		AsmJitLabel class58_4 = RecoveredRuntime.smethod_48(class53_);
		AsmJitLabel class58_5 = RecoveredRuntime.smethod_48(class53_);
		AsmJitLabel class58_6 = RecoveredRuntime.smethod_48(class53_);
		RecoveredRuntime.smethod_371(class53_, RecoveredRuntime.smethod_329(class58_4, 0L));
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
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
		array.smethod_4<AsmJitGpRegister>();
		RecoveredRuntime.smethod_20(class53_);
		foreach (AsmJitGpRegister class63_ in array)
		{
			RecoveredRuntime.smethod_82(class53_, class63_);
		}
		ulong num = (struct55_0.ulong_16 - (ulong)((long)(IntPtr.Size * (2 + array.Length)))) % 16UL;
		if (num != 0UL)
		{
			AsmJitGpRegister class63_2 = AsmJitRuntime.class63_57;
			AsmJitImmediate class57_ = RecoveredRuntime.smethod_125(num);
			RecoveredRuntime.smethod_190(class63_2, class57_, class53_);
		}
		RecoveredRuntime.smethod_263(class53_, AsmJitRuntime.class63_54, RecoveredRuntime.smethod_329(class58_, 0L));
		AsmJitGpRegister class63_3 = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_53,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_56,
			AsmJitRuntime.class63_58,
			AsmJitRuntime.class63_59,
			AsmJitRuntime.class63_60
		}.smethod_2<AsmJitGpRegister>();
		RecoveredRuntime.smethod_306(class53_, class63_3, new AsmJitImmediate(intptr_0));
		RecoveredRuntime.smethod_372(class63_3, class53_);
		RecoveredRuntime.smethod_75(class53_, RecoveredRuntime.smethod_329(class58_3, 0L), AsmJitRuntime.class63_53);
		AsmJitGpRegister class63_4 = AsmJitRuntime.class63_53;
		AsmJitGpRegister class63_5 = AsmJitRuntime.class63_53;
		RecoveredRuntime.smethod_310(class63_4, class63_5, class53_);
		RecoveredRuntime.smethod_91(class58_5, AsmJitJumpHint.const_0, class53_);
		RecoveredRuntime.smethod_306(class53_, class63_3, new AsmJitImmediate(intptr_1));
		RecoveredRuntime.smethod_372(class63_3, class53_);
		RecoveredRuntime.smethod_75(class53_, RecoveredRuntime.smethod_126(class58_6, 0L), AsmJitRuntime.class63_37);
		RecoveredRuntime.smethod_36(class53_, class58_5);
		AsmJitMemoryOperand class59_ = RecoveredRuntime.smethod_126(class58_2, 0L);
		AsmJitImmediate class57_2 = RecoveredRuntime.smethod_167(1);
		RecoveredRuntime.smethod_127(class57_2, class59_, class53_);
		if (num != 0UL)
		{
			RecoveredRuntime.smethod_363(class53_, AsmJitRuntime.class63_57, RecoveredRuntime.smethod_125(num));
		}
		Array.Reverse(array);
		foreach (AsmJitGpRegister class63_6 in array)
		{
			RecoveredRuntime.smethod_171(class53_, class63_6);
		}
		RecoveredRuntime.smethod_297(class53_);
		RecoveredRuntime.smethod_347(class53_);
		RecoveredRuntime.smethod_200(class53_, 8u);
		RecoveredRuntime.smethod_36(class53_, class58_);
		RecoveredRuntime.smethod_320(class53_, byte_0);
		RecoveredRuntime.smethod_200(class53_, 8u);
		RecoveredRuntime.smethod_36(class53_, class58_4);
		RecoveredRuntime.smethod_98(class53_, struct55_0.ulong_28);
		RecoveredRuntime.smethod_36(class53_, class58_3);
		int_1 = RecoveredRuntime.smethod_252(class53_);
		RecoveredRuntime.smethod_118(class53_, IntPtr.Zero);
		RecoveredRuntime.smethod_200(class53_, 8u);
		int_2 = RecoveredRuntime.smethod_252(class53_);
		RecoveredRuntime.smethod_36(class53_, class58_6);
		RecoveredRuntime.smethod_439(class53_, 0u);
		RecoveredRuntime.smethod_200(class53_, 8u);
		RecoveredRuntime.smethod_36(class53_, class58_2);
		int_0 = RecoveredRuntime.smethod_252(class53_);
		RecoveredRuntime.smethod_439(class53_, 0u);
		return RecoveredRuntime.smethod_61(class53_, class90_0);
	}

	internal static void smethod_181(object object_0, RemoteAssembler class47_0, RemoteAssembler.Enum6 enum6_0)
	{
		RemoteAssembler.Class48 @class = object_0 as RemoteAssembler.Class48;
		if (@class != null)
		{
			RecoveredRuntime.smethod_263(class47_0.class53_0, AsmJitRuntime.class63_37, RecoveredRuntime.smethod_221(class47_0, @class.method_0(), 0L));
			RecoveredRuntime.smethod_39(AsmJitRuntime.class63_37, class47_0, enum6_0);
			return;
		}
		AsmJitImmediate class2 = object_0.smethod_0();
		if (RecoveredRuntime.smethod_49(class2, null))
		{
			RecoveredRuntime.smethod_112(enum6_0, class2, class47_0);
			return;
		}
		AsmJitGpRegister class3 = object_0 as AsmJitGpRegister;
		if (RecoveredRuntime.smethod_392(null, class3))
		{
			RecoveredRuntime.smethod_39(class3, class47_0, enum6_0);
			return;
		}
		AsmJitMemoryOperand class59_ = object_0 as AsmJitMemoryOperand;
		if (!RecoveredRuntime.smethod_278(class59_, null))
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(13555));
		}
		RecoveredRuntime.smethod_431(enum6_0, class47_0, class59_);
	}

	internal static AsmJitOperand.Struct9 smethod_188(AsmJitOperand class56_0)
	{
		return AsmJitOperand.smethod_0<AsmJitOperand.Struct7, AsmJitOperand.Struct9>(class56_0.method_0());
	}

	internal static void smethod_189(IntPtr intptr_0)
	{
		if (AsmJitRuntime.delegate0_0 == null)
		{
			AsmJitRuntime.delegate0_0 = RecoveredRuntime.smethod_207();
		}
		AsmJitRuntime.delegate0_0(intptr_0);
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
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		if (int_0 < 4)
		{
			RecoveredRuntime.smethod_318(class47_0.class53_0, array[int_0], class63_0);
			return;
		}
		RecoveredRuntime.smethod_318(class47_0.class53_0, AsmJitRuntime.class63_53, class63_0);
		RecoveredRuntime.smethod_75(class47_0.class53_0, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, (long)(int_0 * 8)), AsmJitRuntime.class63_53);
	}

	internal static void smethod_200(AsmJitAssembler class53_0, uint uint_0)
	{
		if (AsmJitRuntime.bool_0)
		{
			AsmJitApi.smethod_65()(ref class53_0.struct19_0, uint_0);
			return;
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
			RecoveredRuntime.smethod_318(class47_0.class53_0, AsmJitRuntime.class63_41, AsmJitRuntime.class63_42);
			RecoveredRuntime.smethod_171(class47_0.class53_0, AsmJitRuntime.class63_42);
			RecoveredRuntime.smethod_360(class47_0.class53_0, RecoveredRuntime.smethod_167((int_0 == -1) ? 4 : int_0));
		}
		else
		{
			RecoveredRuntime.smethod_429(class47_0.class53_0, AsmJitRuntime.class63_54, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, 8L));
			RecoveredRuntime.smethod_429(class47_0.class53_0, AsmJitRuntime.class63_55, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, 16L));
			RecoveredRuntime.smethod_429(class47_0.class53_0, AsmJitRuntime.class63_61, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, 24L));
			RecoveredRuntime.smethod_429(class47_0.class53_0, AsmJitRuntime.class63_62, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, 32L));
			if (class47_0.bool_1)
			{
				RecoveredRuntime.smethod_418(232, class47_0.class53_0);
				RecoveredRuntime.smethod_439(class47_0.class53_0, 0u);
				RecoveredRuntime.smethod_418(199, class47_0.class53_0);
				RecoveredRuntime.smethod_418(68, class47_0.class53_0);
				RecoveredRuntime.smethod_418(36, class47_0.class53_0);
				RecoveredRuntime.smethod_418(4, class47_0.class53_0);
				RecoveredRuntime.smethod_418(35, class47_0.class53_0);
				RecoveredRuntime.smethod_418(0, class47_0.class53_0);
				RecoveredRuntime.smethod_418(0, class47_0.class53_0);
				RecoveredRuntime.smethod_418(0, class47_0.class53_0);
				RecoveredRuntime.smethod_418(131, class47_0.class53_0);
				RecoveredRuntime.smethod_418(4, class47_0.class53_0);
				RecoveredRuntime.smethod_418(36, class47_0.class53_0);
				RecoveredRuntime.smethod_418(13, class47_0.class53_0);
				RecoveredRuntime.smethod_418(203, class47_0.class53_0);
				AsmJitAssembler class53_ = class47_0.class53_0;
				class53_.struct19_0.uint_2 = (class53_.struct19_0.uint_2 | 8u);
				RecoveredRuntime.smethod_429(class47_0.class53_0, AsmJitRuntime.class63_41, RecoveredRuntime.smethod_126(class47_0.class58_1, 0L));
				RecoveredRuntime.smethod_360(class47_0.class53_0, RecoveredRuntime.smethod_167((int_0 == -1) ? 4 : int_0));
				RecoveredRuntime.smethod_227(class47_0);
				RecoveredRuntime.smethod_36(class47_0.class53_0, class47_0.class58_1);
				RecoveredRuntime.smethod_439(class47_0.class53_0, 0u);
			}
			else
			{
				RecoveredRuntime.smethod_347(class47_0.class53_0);
			}
		}
		if (RecoveredRuntime.smethod_49(class47_0.class58_0, null))
		{
			RecoveredRuntime.smethod_227(class47_0);
			RecoveredRuntime.smethod_36(class47_0.class53_0, class47_0.class58_0);
			class47_0.method_3(RecoveredRuntime.smethod_252(class47_0.class53_0));
			RecoveredRuntime.smethod_320(class47_0.class53_0, new byte[class47_0.int_0]);
		}
	}

	internal static void smethod_227(RemoteAssembler class47_0)
	{
		smethod_200(class47_0.class53_0, class47_0.bool_0 ? 4u : 8u);
	}

	internal static void smethod_236(int int_0, AsmJitLabel class58_0, RemoteAssembler class47_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		if (int_0 < 4)
		{
			RecoveredRuntime.smethod_263(class47_0.class53_0, array[int_0], RecoveredRuntime.smethod_221(class47_0, class58_0, 0L));
			return;
		}
		RecoveredRuntime.smethod_263(class47_0.class53_0, AsmJitRuntime.class63_53, RecoveredRuntime.smethod_221(class47_0, class58_0, 0L));
		RecoveredRuntime.smethod_75(class47_0.class53_0, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, (long)(int_0 * 8)), AsmJitRuntime.class63_53);
	}

	internal static AsmJitMemoryOperand smethod_238(AsmJitGpRegister class63_0, long long_0)
	{
		return smethod_433((IntPtr)long_0, 8u, class63_0);
	}

	internal static bool smethod_239(AsmJitAssembler class53_0, RemoteCodeExecutorBase class84_0)
	{
		IntPtr intPtr = RecoveredRuntime.smethod_61(class53_0, class84_0);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		IntPtr intPtr2 = RecoveredRuntime.smethod_321(class84_0, intPtr, IntPtr.Zero);
		if (!(intPtr2 == IntPtr.Zero))
		{
			RecoveredRuntime.smethod_153(class84_0, intPtr2, -1);
			RecoveredRuntime.smethod_108(class84_0, intPtr2);
			return true;
		}
		return false;
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
			AsmJitApi.smethod_37()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
			return;
		}
		AsmJitApi.smethod_35()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
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
			RecoveredRuntime.smethod_222(class47_0.class53_0, intptr_0.ToInt32());
			return;
		}
		RecoveredRuntime.smethod_118(class47_0.class53_0, intptr_0);
	}

	internal static void smethod_288(AsmJitAssembler class53_0)
	{
		class53_0.struct19_0.uint_2 |= 8u;
	}

	internal static AsmJitMemoryOperand smethod_290(AsmJitLabel class58_0, long long_0, RemoteAssembler class47_0)
	{
		if (class47_0.bool_0)
		{
			AsmJitAssembler class53_ = class47_0.class53_0;
			class53_.struct19_0.uint_2 = (class53_.struct19_0.uint_2 | 8u);
		}
		return RecoveredRuntime.smethod_257(class58_0, long_0);
	}

	internal static byte[] smethod_292()
	{
		return (byte[])smethod_124().GetObject("AsmJitx86", EmbeddedResources.cultureInfo_0);
	}

	internal static void smethod_297(AsmJitAssembler class53_0)
	{
		if (!class53_0.method_0() && !AsmJitRuntime.bool_0)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(11455));
		}
		RecoveredRuntime.smethod_31(class53_0, AsmJitInstructionId.const_423);
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
			AsmJitApi.smethod_30()(ref class53_0.struct19_0, object_0, (IntPtr)long_0);
			return;
		}
		AsmJitApi.smethod_28()(ref class53_0.struct19_0, object_0, (IntPtr)long_0);
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
		AsmJitRuntime.class63_0 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(19962));
		AsmJitRuntime.class63_1 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(19999));
		AsmJitRuntime.class63_2 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20032));
		AsmJitRuntime.class63_3 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20065));
		AsmJitRuntime.class63_4 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20098));
		if (AsmJitRuntime.bool_0)
		{
			AsmJitRuntime.class63_5 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20131));
			AsmJitRuntime.class63_6 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20164));
			AsmJitRuntime.class63_7 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20197));
			AsmJitRuntime.class63_8 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20230));
			AsmJitRuntime.class63_9 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20263));
			AsmJitRuntime.class63_10 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20296));
			AsmJitRuntime.class63_11 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20329));
			AsmJitRuntime.class63_12 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20366));
			AsmJitRuntime.class63_13 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20403));
			AsmJitRuntime.class63_14 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20440));
			AsmJitRuntime.class63_15 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20477));
			AsmJitRuntime.class63_16 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20514));
		}
		AsmJitRuntime.class63_17 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20551));
		AsmJitRuntime.class63_18 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20584));
		AsmJitRuntime.class63_19 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20617));
		AsmJitRuntime.class63_20 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20650));
		AsmJitRuntime.class63_21 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20683));
		AsmJitRuntime.class63_22 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20716));
		AsmJitRuntime.class63_23 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20749));
		AsmJitRuntime.class63_24 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20782));
		AsmJitRuntime.class63_25 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20815));
		AsmJitRuntime.class63_26 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20848));
		AsmJitRuntime.class63_27 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20881));
		AsmJitRuntime.class63_28 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20914));
		if (AsmJitRuntime.bool_0)
		{
			AsmJitRuntime.class63_29 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20947));
			AsmJitRuntime.class63_30 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(20980));
			AsmJitRuntime.class63_31 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21013));
			AsmJitRuntime.class63_32 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21050));
			AsmJitRuntime.class63_33 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21087));
			AsmJitRuntime.class63_34 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21124));
			AsmJitRuntime.class63_35 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21161));
			AsmJitRuntime.class63_36 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21198));
		}
		AsmJitRuntime.class63_37 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21235));
		AsmJitRuntime.class63_38 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21268));
		AsmJitRuntime.class63_39 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21301));
		AsmJitRuntime.class63_40 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21334));
		AsmJitRuntime.class63_41 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21367));
		AsmJitRuntime.class63_42 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21400));
		AsmJitRuntime.class63_43 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21433));
		AsmJitRuntime.class63_44 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21466));
		if (AsmJitRuntime.bool_0)
		{
			AsmJitRuntime.class63_45 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21499));
			AsmJitRuntime.class63_46 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21532));
			AsmJitRuntime.class63_47 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21565));
			AsmJitRuntime.class63_48 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21602));
			AsmJitRuntime.class63_49 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21639));
			AsmJitRuntime.class63_50 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21676));
			AsmJitRuntime.class63_51 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21713));
			AsmJitRuntime.class63_52 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21750));
		}
		if (AsmJitRuntime.bool_0)
		{
			AsmJitRuntime.class63_53 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21787));
			AsmJitRuntime.class63_54 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21820));
			AsmJitRuntime.class63_55 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21853));
			AsmJitRuntime.class63_56 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21886));
			AsmJitRuntime.class63_57 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21919));
			AsmJitRuntime.class63_58 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21952));
			AsmJitRuntime.class63_59 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(21985));
			AsmJitRuntime.class63_60 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22018));
			AsmJitRuntime.class63_61 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22051));
			AsmJitRuntime.class63_62 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22084));
			AsmJitRuntime.class63_63 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22117));
			AsmJitRuntime.class63_64 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22150));
			AsmJitRuntime.class63_65 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22183));
			AsmJitRuntime.class63_66 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22216));
			AsmJitRuntime.class63_67 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22249));
			AsmJitRuntime.class63_68 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22282));
		}
		AsmJitRuntime.class63_69 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22315));
		AsmJitRuntime.class63_70 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22348));
		AsmJitRuntime.class63_71 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22381));
		AsmJitRuntime.class63_72 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22414));
		AsmJitRuntime.class63_73 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22447));
		AsmJitRuntime.class63_74 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22480));
		AsmJitRuntime.class63_75 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22513));
		AsmJitRuntime.class63_76 = AsmJitNative.smethod_1<AsmJitGpRegister>(EncodedStringTable.smethod_0(22546));
		AsmJitRuntime.class64_0 = AsmJitNative.smethod_1<AsmJitMmxRegister>(EncodedStringTable.smethod_0(22579));
		AsmJitRuntime.class64_1 = AsmJitNative.smethod_1<AsmJitMmxRegister>(EncodedStringTable.smethod_0(22612));
		AsmJitRuntime.class64_2 = AsmJitNative.smethod_1<AsmJitMmxRegister>(EncodedStringTable.smethod_0(22645));
		AsmJitRuntime.class64_3 = AsmJitNative.smethod_1<AsmJitMmxRegister>(EncodedStringTable.smethod_0(22678));
		AsmJitRuntime.class64_4 = AsmJitNative.smethod_1<AsmJitMmxRegister>(EncodedStringTable.smethod_0(22711));
		AsmJitRuntime.class64_5 = AsmJitNative.smethod_1<AsmJitMmxRegister>(EncodedStringTable.smethod_0(22744));
		AsmJitRuntime.class64_6 = AsmJitNative.smethod_1<AsmJitMmxRegister>(EncodedStringTable.smethod_0(22777));
		AsmJitRuntime.class64_7 = AsmJitNative.smethod_1<AsmJitMmxRegister>(EncodedStringTable.smethod_0(22810));
		AsmJitRuntime.class65_0 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(22843));
		AsmJitRuntime.class65_1 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(22880));
		AsmJitRuntime.class65_2 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(22917));
		AsmJitRuntime.class65_3 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(22954));
		AsmJitRuntime.class65_4 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(22991));
		AsmJitRuntime.class65_5 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23028));
		AsmJitRuntime.class65_6 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23065));
		AsmJitRuntime.class65_7 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23102));
		if (AsmJitRuntime.bool_0)
		{
			AsmJitRuntime.class65_8 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23139));
			AsmJitRuntime.class65_9 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23176));
			AsmJitRuntime.class65_10 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23213));
			AsmJitRuntime.class65_11 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23250));
			AsmJitRuntime.class65_12 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23287));
			AsmJitRuntime.class65_13 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23324));
			AsmJitRuntime.class65_14 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23361));
			AsmJitRuntime.class65_15 = AsmJitNative.smethod_1<AsmJitXmmRegister>(EncodedStringTable.smethod_0(23398));
		}
	}

	internal static void smethod_318(AsmJitAssembler class53_0, AsmJitGpRegister class63_0, AsmJitGpRegister class63_1)
	{
		smethod_137(class53_0, AsmJitInstructionId.const_266, class63_0, class63_1);
	}

	internal static bool smethod_319(AsmJitMemoryOperand class59_0, AsmJitMemoryOperand class59_1)
	{
		return (class59_0 == null && class59_1 == null) || (class59_0 != null && class59_0.Equals(class59_1));
	}

	internal static void smethod_320(AsmJitAssembler class53_0, byte[] byte_0)
	{
		smethod_308(byte_0.Length, byte_0, class53_0);
	}

	internal static void smethod_324(AsmJitMemoryOperand class59_0, RemoteAssembler class47_0, int int_0)
	{
		AsmJitGpRegister[] array = new AsmJitGpRegister[]
		{
			AsmJitRuntime.class63_54,
			AsmJitRuntime.class63_55,
			AsmJitRuntime.class63_61,
			AsmJitRuntime.class63_62
		};
		if (int_0 < 4)
		{
			RecoveredRuntime.smethod_429(class47_0.class53_0, array[int_0], class59_0);
			return;
		}
		RecoveredRuntime.smethod_429(class47_0.class53_0, AsmJitRuntime.class63_53, class59_0);
		RecoveredRuntime.smethod_75(class47_0.class53_0, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_57, (long)(int_0 * 8)), AsmJitRuntime.class63_53);
	}

	internal static bool smethod_328(AsmJitOperand class56_0, AsmJitOperand class56_1)
	{
		return (class56_0 == null && class56_1 == null) || (class56_0 != null && class56_0.Equals(class56_1));
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
			RecoveredRuntime.smethod_439(class47_0.class53_0, 0u);
			return;
		}
		RecoveredRuntime.smethod_269(class47_0.class53_0, 0L);
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
			AsmJitApi.smethod_13()(ref class53_0.struct19_0, enum7_0, class56_0);
			return;
		}
		AsmJitApi.smethod_6()(ref class53_0.struct19_0, enum7_0, class56_0);
	}

	internal static void smethod_358(AsmJitOperand class56_0, object[] object_0, CallingConvention callingConvention_0, RemoteAssembler class47_0)
	{
		bool[] array = new bool[object_0.Length];
		if (callingConvention_0 == CallingConvention.ThisCall || callingConvention_0 == CallingConvention.FastCall)
		{
			int num = (callingConvention_0 == CallingConvention.FastCall) ? 2 : 1;
			int num2 = 0;
			int num3 = 0;
			while (num2 < object_0.Length && num3 < num)
			{
				array[num2] = true;
				RecoveredRuntime.smethod_181(object_0[num2], class47_0, (RemoteAssembler.Enum6)num3);
				num3++;
				num2++;
			}
		}
		for (int i = object_0.Length - 1; i >= 0; i--)
		{
			if (!array[i])
			{
				RecoveredRuntime.smethod_181(object_0[i], class47_0, RemoteAssembler.Enum6.const_2);
			}
		}
		AsmJitImmediate @class = class56_0 as AsmJitImmediate;
		if (RecoveredRuntime.smethod_49(@class, null))
		{
			RecoveredRuntime.smethod_306(class47_0.class53_0, AsmJitRuntime.class63_37, @class);
			AsmJitAssembler class53_ = class47_0.class53_0;
			AsmJitGpRegister class63_ = AsmJitRuntime.class63_69;
			RecoveredRuntime.smethod_372(class63_, class53_);
		}
		AsmJitGpRegister class2 = class56_0 as AsmJitGpRegister;
		if (RecoveredRuntime.smethod_392(null, class2))
		{
			RecoveredRuntime.smethod_372(class2, class47_0.class53_0);
		}
		if (RecoveredRuntime.smethod_328(@class, null) && RecoveredRuntime.smethod_134(null, class2))
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(24964));
		}
		if (callingConvention_0 == CallingConvention.Cdecl)
		{
			int num4 = 0;
			foreach (object obj in object_0)
			{
				if (!(obj is IntPtr) && !(obj is UIntPtr) && !(obj is RemoteAssembler.Class48))
				{
					num4 += obj.GetType().smethod_7();
				}
				else
				{
					num4 += 4;
				}
			}
			RecoveredRuntime.smethod_363(class47_0.class53_0, AsmJitRuntime.class63_41, RecoveredRuntime.smethod_167(num4));
			return;
		}
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
		int num = (object_0.Length <= 4) ? 40 : (object_0.Length * 8);
		AsmJitImmediate @class = class56_0 as AsmJitImmediate;
		num -= num % 16;
		AsmJitAssembler class53_ = class47_0.class53_0;
		AsmJitGpRegister class63_ = AsmJitRuntime.class63_57;
		AsmJitImmediate class57_ = RecoveredRuntime.smethod_167(num + 8);
		RecoveredRuntime.smethod_190(class63_, class57_, class53_);
		if (!class47_0.method_0())
		{
			for (int i = 0; i < object_0.Length; i++)
			{
				RecoveredRuntime.smethod_391(class47_0, object_0[i], i);
			}
		}
		else
		{
			int[] array = Enumerable.Range(0, object_0.Length).ToArray<int>();
			array.smethod_4<int>();
			foreach (int num2 in array)
			{
				RecoveredRuntime.smethod_391(class47_0, object_0[num2], num2);
			}
		}
		if (RecoveredRuntime.smethod_49(@class, null))
		{
			RecoveredRuntime.smethod_306(class47_0.class53_0, AsmJitRuntime.class63_53, @class);
			AsmJitAssembler class53_2 = class47_0.class53_0;
			AsmJitGpRegister class63_2 = AsmJitRuntime.class63_53;
			RecoveredRuntime.smethod_372(class63_2, class53_2);
		}
		AsmJitGpRegister class2 = class56_0 as AsmJitGpRegister;
		if (RecoveredRuntime.smethod_392(null, class2))
		{
			RecoveredRuntime.smethod_372(class2, class47_0.class53_0);
		}
		if (RecoveredRuntime.smethod_328(@class, null) && RecoveredRuntime.smethod_134(null, class2))
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(24964));
		}
		RecoveredRuntime.smethod_363(class47_0.class53_0, AsmJitRuntime.class63_57, RecoveredRuntime.smethod_167(num + 8));
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
		if (@class != null)
		{
			RecoveredRuntime.smethod_236(int_0, @class.method_0(), class47_0);
			return;
		}
		AsmJitImmediate class2 = object_0.smethod_0();
		if (RecoveredRuntime.smethod_49(class2, null))
		{
			RecoveredRuntime.smethod_121(class47_0, class2, int_0, object_0 is float || object_0 is double);
			return;
		}
		AsmJitGpRegister class3 = object_0 as AsmJitGpRegister;
		if (RecoveredRuntime.smethod_392(null, class3))
		{
			RecoveredRuntime.smethod_199(int_0, class47_0, class3);
			return;
		}
		AsmJitMemoryOperand class59_ = object_0 as AsmJitMemoryOperand;
		if (RecoveredRuntime.smethod_278(class59_, null))
		{
			RecoveredRuntime.smethod_324(class59_, class47_0, int_0);
			return;
		}
		throw new InvalidOperationException(EncodedStringTable.smethod_0(13555));
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
		ProcessModuleInfo gclass = RecoveredRuntime.smethod_42(class92_0.method_19())[EncodedStringTable.smethod_0(8549)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.smethod_0(12731));
		}
		AsmJitAssembler @class = new AsmJitAssembler();
		IntPtr value;
		if (!class92_0.method_19().Is64Bit)
		{
			IntPtr intPtr = RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(27396), false);
			for (int i = 0; i < class92_0.byte_0.Length - 4; i++)
			{
				uint num = BitConverter.ToUInt32(class92_0.byte_0, i);
				if (num != 3735935610u)
				{
					if (num == 3735929054u)
					{
						BitConverter.GetBytes(intPtr.ToInt32()).CopyTo(class92_0.byte_0, i);
						break;
					}
					if (num == 3735929042u)
					{
						value = RecoveredRuntime.smethod_285(class92_0.method_19()).method_28();
						BitConverter.GetBytes(value.ToInt32()).CopyTo(class92_0.byte_0, i);
					}
				}
				else
				{
					value = RecoveredRuntime.smethod_285(class92_0.method_19()).method_26();
					BitConverter.GetBytes(value.ToInt32()).CopyTo(class92_0.byte_0, i);
				}
			}
			class92_0.intptr_2 = RecoveredRuntime.smethod_175(class92_0, (long)class92_0.byte_0.Length, NativeTypes.Enum34.flag_2);
			if (class92_0.intptr_2 == IntPtr.Zero)
			{
				throw new AccessViolationException(EncodedStringTable.smethod_0(27429));
			}
			if (!class92_0.method_16<byte>(class92_0.intptr_2, class92_0.byte_0))
			{
				throw new AccessViolationException(EncodedStringTable.smethod_0(27482));
			}
		}
		else
		{
			if (class92_0.intptr_1 == IntPtr.Zero)
			{
				class92_0.intptr_1 = RecoveredRuntime.smethod_175(class92_0, 4096L, NativeTypes.Enum34.flag_6);
				if (class92_0.intptr_1 == IntPtr.Zero)
				{
					throw new AccessViolationException(EncodedStringTable.smethod_0(27339));
				}
			}
			VectoredExceptionHandlerInstaller.Struct71 @struct = class92_0.method_11<VectoredExceptionHandlerInstaller.Struct71>(class92_0.intptr_1);
			long num2 = @struct.intptr_0.ToInt64();
			AsmJitLabel class58_;
			AsmJitLabel class58_2;
			AsmJitLabel class58_3;
			AsmJitLabel class58_4;
			AsmJitGpRegister class63_;
			AsmJitGpRegister class63_2;
			AsmJitGpRegister class63_3;
			checked
			{
				@struct.struct70_0[(int)((IntPtr)num2)].intptr_0 = intptr_0;
				@struct.struct70_0[(int)((IntPtr)num2)].intptr_1 = (IntPtr)((long)ulong_0);
				@struct.intptr_0 = @struct.intptr_0.smethod_8(1);
				class92_0.method_13<VectoredExceptionHandlerInstaller.Struct71>(class92_0.intptr_1, @struct);
				class58_ = RecoveredRuntime.smethod_48(@class);
				class58_2 = RecoveredRuntime.smethod_48(@class);
				class58_3 = RecoveredRuntime.smethod_48(@class);
				class58_4 = RecoveredRuntime.smethod_48(@class);
				RecoveredRuntime.smethod_429(@class, AsmJitRuntime.class63_53, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_54, 0L));
				AsmJitMemoryOperand class59_ = RecoveredRuntime.smethod_395(0L, AsmJitRuntime.class63_53);
				AsmJitImmediate class57_ = RecoveredRuntime.smethod_374(3765269347u);
				RecoveredRuntime.smethod_110(class57_, class59_, @class);
				RecoveredRuntime.smethod_332(AsmJitJumpHint.const_0, @class, class58_);
				class59_ = RecoveredRuntime.smethod_238(AsmJitRuntime.class63_53, 32L);
				class57_ = RecoveredRuntime.smethod_374(26820608u);
				RecoveredRuntime.smethod_110(class57_, class59_, @class);
				RecoveredRuntime.smethod_332(AsmJitJumpHint.const_0, @class, class58_);
				class59_ = RecoveredRuntime.smethod_238(AsmJitRuntime.class63_53, 56L);
				class57_ = RecoveredRuntime.smethod_167(0);
				RecoveredRuntime.smethod_110(class57_, class59_, @class);
				RecoveredRuntime.smethod_332(AsmJitJumpHint.const_0, @class, class58_);
				RecoveredRuntime.smethod_306(@class, AsmJitRuntime.class63_62, new AsmJitImmediate(class92_0.intptr_1));
				RecoveredRuntime.smethod_429(@class, AsmJitRuntime.class63_55, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_62, 0L));
				RecoveredRuntime.smethod_363(@class, AsmJitRuntime.class63_62, RecoveredRuntime.smethod_167(IntPtr.Size));
				RecoveredRuntime.smethod_164(@class, AsmJitRuntime.class63_63, AsmJitRuntime.class63_63);
				RecoveredRuntime.smethod_36(@class, class58_2);
				RecoveredRuntime.smethod_429(@class, AsmJitRuntime.class63_61, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_53, 48L));
				RecoveredRuntime.smethod_429(@class, AsmJitRuntime.class63_64, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_62, 0L));
				class63_ = AsmJitRuntime.class63_61;
				class63_2 = AsmJitRuntime.class63_64;
				RecoveredRuntime.smethod_205(class63_, @class, class63_2);
				RecoveredRuntime.smethod_32(AsmJitJumpHint.const_0, class58_3, @class);
				class63_3 = AsmJitRuntime.class63_64;
			}
			AsmJitMemoryOperand class59_2 = RecoveredRuntime.smethod_238(AsmJitRuntime.class63_62, (long)IntPtr.Size);
			RecoveredRuntime.smethod_169(class59_2, class63_3, @class);
			class63_ = AsmJitRuntime.class63_61;
			class63_2 = AsmJitRuntime.class63_64;
			RecoveredRuntime.smethod_205(class63_, @class, class63_2);
			RecoveredRuntime.smethod_220(AsmJitJumpHint.const_0, class58_3, @class);
			RecoveredRuntime.smethod_247(@class, class58_4);
			RecoveredRuntime.smethod_36(@class, class58_3);
			RecoveredRuntime.smethod_363(@class, AsmJitRuntime.class63_62, RecoveredRuntime.smethod_167(typeof(VectoredExceptionHandlerInstaller.Struct70).smethod_7()));
			RecoveredRuntime.smethod_363(@class, AsmJitRuntime.class63_63, RecoveredRuntime.smethod_167(1));
			class63_ = AsmJitRuntime.class63_63;
			class63_2 = AsmJitRuntime.class63_55;
			RecoveredRuntime.smethod_205(class63_, @class, class63_2);
			RecoveredRuntime.smethod_332(AsmJitJumpHint.const_0, @class, class58_2);
			RecoveredRuntime.smethod_247(@class, class58_);
			RecoveredRuntime.smethod_36(@class, class58_4);
			AsmJitMemoryOperand class59_3 = RecoveredRuntime.smethod_238(AsmJitRuntime.class63_53, 32L);
			AsmJitImmediate class57_2 = RecoveredRuntime.smethod_374(429065504u);
			RecoveredRuntime.smethod_127(class57_2, class59_3, @class);
			RecoveredRuntime.smethod_429(@class, AsmJitRuntime.class63_54, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_54, 0L));
			RecoveredRuntime.smethod_429(@class, AsmJitRuntime.class63_55, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_62, 0L));
			RecoveredRuntime.smethod_75(@class, RecoveredRuntime.smethod_238(AsmJitRuntime.class63_53, 56L), AsmJitRuntime.class63_55);
			RecoveredRuntime.smethod_36(@class, class58_);
			RecoveredRuntime.smethod_164(@class, AsmJitRuntime.class63_53, AsmJitRuntime.class63_53);
			RecoveredRuntime.smethod_347(@class);
			RecoveredRuntime.smethod_418(204, @class);
			RecoveredRuntime.smethod_418(204, @class);
			RecoveredRuntime.smethod_418(204, @class);
			class92_0.intptr_2 = RecoveredRuntime.smethod_61(@class, class92_0);
			RecoveredRuntime.smethod_115(@class);
		}
		RemoteAssembler class2 = new RemoteAssembler(@class, class92_0.method_19());
		RecoveredRuntime.smethod_15(class2);
		RecoveredRuntime.smethod_54(class2, new AsmJitImmediate(RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(27531), false)), CallingConvention.StdCall, new object[]
		{
			0,
			class92_0.intptr_2
		});
		class2.method_4<IntPtr>();
		RecoveredRuntime.smethod_226(class2, -1);
		value = (class92_0.intptr_3 = class92_0.method_21<IntPtr>(class2));
		return value != IntPtr.Zero;
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
