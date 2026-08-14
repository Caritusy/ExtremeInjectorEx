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
		if (base.method_2() == IntPtr.Zero && base.method_0() != -1)
		{
			base.method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, false, base.method_0()));
		}
	}

	public override IntPtr Inject(string string_0)
	{
		if (!Path.IsPathRooted(string_0))
		{
			string_0 = Path.GetFullPath(string_0);
		}
		if (!File.Exists(string_0))
		{
			throw new FileNotFoundException(EncodedStringTable.smethod_0(28151) + string_0 + EncodedStringTable.smethod_0(3656));
		}
		if (!base.method_8(base.method_19().ProcessId))
		{
			throw new UnauthorizedAccessException(EncodedStringTable.smethod_0(12662));
		}
		ProcessModuleInfo gclass = RecoveredRuntime.smethod_42(base.method_19())[EncodedStringTable.smethod_0(8549)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.smethod_0(12731));
		}
		IntPtr intPtr = RecoveredRuntime.smethod_225(gclass, EncodedStringTable.smethod_0(28220), false);
		if (intPtr == IntPtr.Zero)
		{
			throw new MissingMethodException(EncodedStringTable.smethod_0(28237));
		}
		IntPtr intptr_ = RecoveredRuntime.smethod_427(base.method_19()) ? RecoveredRuntime.smethod_197(this, intPtr, gclass) : RecoveredRuntime.smethod_335(intPtr, this, gclass);
		int int_;
		int int_2;
		IntPtr intPtr2 = this.method_24(intptr_, string_0, out int_, out int_2);
		IntPtr intPtr3 = RecoveredRuntime.smethod_321(this, intPtr2, IntPtr.Zero);
		if (intPtr3 == IntPtr.Zero)
		{
			this.vmethod_6(intPtr2);
			throw new AccessViolationException(EncodedStringTable.smethod_0(12914));
		}
		RecoveredRuntime.smethod_153(this, intPtr3, -1);
		if (RecoveredRuntime.HasProcessExited(base.method_19()))
		{
			this.vmethod_6(intPtr2);
			throw new Exception(EncodedStringTable.smethod_0(28330));
		}
		uint num = base.method_11<uint>(intPtr2.smethod_8(int_2));
		if (num != 0u)
		{
			this.vmethod_6(intPtr2);
			throw new Exception(EncodedStringTable.smethod_0(28411) + num.ToString(EncodedStringTable.smethod_0(28492)) + EncodedStringTable.smethod_0(3656), RecoveredRuntime.smethod_213(num, this));
		}
		IntPtr result = RecoveredRuntime.smethod_427(base.method_19()) ? ((IntPtr)((long)((ulong)base.method_11<uint>(intPtr2.smethod_8(int_))))) : base.method_11<IntPtr>(intPtr2.smethod_8(int_));
		this.vmethod_6(intPtr2);
		RecoveredRuntime.smethod_108(this, intPtr3);
		return result;
	}

	internal IntPtr method_24(IntPtr intptr_1, string string_0, out int int_1, out int int_2)
	{
		IntPtr intPtr = RecoveredRuntime.smethod_175(this, 4096L, NativeTypes.Enum34.flag_2);
		if (intPtr == IntPtr.Zero)
		{
			throw new AccessViolationException(EncodedStringTable.smethod_0(28497));
		}
		AsmJitAssembler @class = new AsmJitAssembler();
		RemoteAssembler class2 = new RemoteAssembler(@class, base.method_19());
		class2.method_1(true);
		RemoteAssembler class47_ = class2;
		AsmJitLabel class58_ = RecoveredRuntime.smethod_48(@class);
		AsmJitLabel class58_2 = RecoveredRuntime.smethod_48(@class);
		AsmJitLabel class3 = RecoveredRuntime.smethod_48(@class);
		AsmJitLabel class4 = RecoveredRuntime.smethod_48(@class);
		AsmJitLabel class58_3 = RecoveredRuntime.smethod_48(@class);
		AsmJitLabel class58_4 = RecoveredRuntime.smethod_48(@class);
		RecoveredRuntime.smethod_15(class47_);
		if (!PlatformInfo.bool_7)
		{
			if (!PlatformInfo.bool_5)
			{
				if (!PlatformInfo.bool_2)
				{
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_1), CallingConvention.StdCall, new object[]
					{
						0,
						IntPtr.Zero,
						IntPtr.Zero,
						RecoveredRuntime.smethod_84(class47_, class58_2),
						RecoveredRuntime.smethod_84(class47_, class58_),
						1
					});
				}
				else
				{
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_1), CallingConvention.StdCall, new object[]
					{
						RecoveredRuntime.smethod_84(class47_, class58_2),
						RecoveredRuntime.smethod_84(class47_, class58_4),
						0,
						1,
						0,
						RecoveredRuntime.smethod_84(class47_, class3)
					});
				}
			}
			else
			{
				CallingConvention callingConvention_ = PlatformInfo.bool_6 ? CallingConvention.FastCall : CallingConvention.StdCall;
				RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_1), callingConvention_, new object[]
				{
					RecoveredRuntime.smethod_84(class47_, class58_2),
					RecoveredRuntime.smethod_84(class47_, class58_4),
					0,
					1,
					RecoveredRuntime.smethod_84(class47_, class3),
					RecoveredRuntime.smethod_84(class47_, class4)
				});
			}
		}
		else
		{
			RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_1), CallingConvention.FastCall, new object[]
			{
				RecoveredRuntime.smethod_84(class47_, class58_2),
				RecoveredRuntime.smethod_84(class47_, class58_4),
				0,
				1,
				RecoveredRuntime.smethod_84(class47_, class4)
			});
		}
		if (RecoveredRuntime.smethod_427(base.method_19()))
		{
			AsmJitAssembler class5 = @class;
			class5.struct19_0.uint_2 = (class5.struct19_0.uint_2 | 8u);
		}
		RecoveredRuntime.smethod_75(@class, RecoveredRuntime.smethod_126(class58_3, 0L), AsmJitRuntime.class63_37);
		if (PlatformInfo.bool_2)
		{
			int num = RecoveredRuntime.smethod_427(base.method_19()) ? 24 : 48;
			AsmJitGpRegister class63_ = RecoveredRuntime.smethod_427(base.method_19()) ? AsmJitRuntime.class63_38 : AsmJitRuntime.class63_54;
			RecoveredRuntime.smethod_429(@class, class63_, RecoveredRuntime.smethod_221(class47_, PlatformInfo.bool_7 ? class4 : class3, 0L));
			RecoveredRuntime.smethod_429(@class, class63_, RecoveredRuntime.smethod_417(class63_, (long)num, class47_));
			RecoveredRuntime.smethod_75(@class, RecoveredRuntime.smethod_221(class47_, class58_, 0L), class63_);
		}
		RecoveredRuntime.smethod_226(class47_, -1);
		RecoveredRuntime.smethod_227(class47_);
		RecoveredRuntime.smethod_36(@class, class58_);
		int_1 = RecoveredRuntime.smethod_252(@class);
		RecoveredRuntime.smethod_336(class47_);
		RecoveredRuntime.smethod_227(class47_);
		RecoveredRuntime.smethod_36(@class, class58_3);
		int_2 = RecoveredRuntime.smethod_252(@class);
		RecoveredRuntime.smethod_439(@class, 0u);
		RecoveredRuntime.smethod_227(class47_);
		IntPtr intptr_2 = intPtr.smethod_8(RecoveredRuntime.smethod_252(@class));
		byte[] bytes = Encoding.Unicode.GetBytes(string_0 + EncodedStringTable.smethod_0(12219));
		RecoveredRuntime.smethod_320(@class, bytes);
		RecoveredRuntime.smethod_227(class47_);
		if (!PlatformInfo.bool_7)
		{
			if (PlatformInfo.bool_6)
			{
				RecoveredRuntime.smethod_36(@class, class58_4);
				RecoveredRuntime.smethod_336(class47_);
				RecoveredRuntime.smethod_336(class47_);
				RecoveredRuntime.smethod_336(class47_);
				RecoveredRuntime.smethod_286(class47_, intptr_2);
				RecoveredRuntime.smethod_336(class47_);
				RecoveredRuntime.smethod_336(class47_);
			}
			else if (PlatformInfo.bool_5)
			{
				RecoveredRuntime.smethod_36(@class, class58_4);
				RecoveredRuntime.smethod_336(class47_);
				RecoveredRuntime.smethod_286(class47_, intptr_2);
				RecoveredRuntime.smethod_105(1, @class);
			}
			else if (PlatformInfo.bool_2)
			{
				string s = string.Concat(new string[]
				{
					Path.GetDirectoryName(base.method_19().FilePath),
					EncodedStringTable.smethod_0(28566),
					PlatformInfo.string_1,
					EncodedStringTable.smethod_0(28566),
					PlatformInfo.string_3,
					EncodedStringTable.smethod_0(28566),
					PlatformInfo.string_0,
					EncodedStringTable.smethod_0(12219)
				});
				RecoveredRuntime.smethod_227(class47_);
				IntPtr intptr_3 = intPtr.smethod_8(RecoveredRuntime.smethod_252(@class));
				byte[] bytes2 = Encoding.Unicode.GetBytes(s);
				RecoveredRuntime.smethod_320(@class, bytes2);
				RecoveredRuntime.smethod_227(class47_);
				RecoveredRuntime.smethod_36(@class, class58_4);
				RecoveredRuntime.smethod_52(@class, (ushort)(bytes2.Length - 2));
				RecoveredRuntime.smethod_52(@class, (ushort)bytes2.Length);
				RecoveredRuntime.smethod_227(class47_);
				RecoveredRuntime.smethod_286(class47_, intptr_3);
			}
		}
		else if (PlatformInfo.bool_8)
		{
			RecoveredRuntime.smethod_36(@class, class58_4);
			RecoveredRuntime.smethod_36(@class, class58_4);
			RecoveredRuntime.smethod_336(class47_);
			RecoveredRuntime.smethod_336(class47_);
			RecoveredRuntime.smethod_336(class47_);
			RecoveredRuntime.smethod_336(class47_);
			RecoveredRuntime.smethod_286(class47_, intptr_2);
			for (int i = 0; i < 7; i++)
			{
				RecoveredRuntime.smethod_336(class47_);
			}
			for (int j = 0; j < 8; j++)
			{
				RecoveredRuntime.smethod_439(@class, 0u);
			}
		}
		else
		{
			RecoveredRuntime.smethod_36(@class, class58_4);
			RecoveredRuntime.smethod_336(class47_);
			RecoveredRuntime.smethod_336(class47_);
			RecoveredRuntime.smethod_336(class47_);
			RecoveredRuntime.smethod_286(class47_, intptr_2);
			for (int k = 0; k < 7; k++)
			{
				RecoveredRuntime.smethod_336(class47_);
			}
			for (int l = 0; l < 8; l++)
			{
				RecoveredRuntime.smethod_439(@class, 0u);
			}
		}
		if (PlatformInfo.bool_5)
		{
			RecoveredRuntime.smethod_227(class47_);
			RecoveredRuntime.smethod_36(@class, class4);
			RecoveredRuntime.smethod_286(class47_, (IntPtr)1);
			if (PlatformInfo.bool_7)
			{
				for (int m = 0; m < 6; m++)
				{
					RecoveredRuntime.smethod_336(class47_);
				}
			}
		}
		RecoveredRuntime.smethod_227(class47_);
		int int_3 = RecoveredRuntime.smethod_252(@class);
		RecoveredRuntime.smethod_36(@class, class58_2);
		RecoveredRuntime.smethod_52(@class, (ushort)(bytes.Length - 2));
		RecoveredRuntime.smethod_52(@class, (ushort)bytes.Length);
		RecoveredRuntime.smethod_227(class47_);
		RecoveredRuntime.smethod_286(class47_, intptr_2);
		RecoveredRuntime.smethod_227(class47_);
		RecoveredRuntime.smethod_36(@class, class3);
		RecoveredRuntime.smethod_286(class47_, intPtr.smethod_8(int_3));
		if (RecoveredRuntime.smethod_443(intPtr, @class, this) == IntPtr.Zero)
		{
			this.vmethod_6(intPtr);
			throw new InvalidOperationException(EncodedStringTable.smethod_0(28571));
		}
		return intPtr;
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
