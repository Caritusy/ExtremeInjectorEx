using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public sealed class LdrLoadDllInjector : DllInjector
{
	public LdrLoadDllInjector(RemoteProcess gclass2_1)
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
			int num = -636814761;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -870730958)) % 4)
				{
				case 3u:
					method_3(RecoveredRuntime.OpenProcess(NativeTypes.Enum32.flag_2 | NativeTypes.Enum32.flag_3 | NativeTypes.Enum32.flag_4 | NativeTypes.Enum32.flag_5 | NativeTypes.Enum32.flag_9, bool_0: false, method_0()));
					num = ((int)num2 * -362496391) ^ 0x3E67C4A1;
					continue;
				case 1u:
					num = ((method_0() == -1) ? (-1014316990) : (-765609239)) ^ ((int)num2 * -969984944);
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
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
			goto IL_019a;
		}
		goto IL_02b3;
		IL_019a:
		int num = -185679819;
		goto IL_0231;
		IL_0231:
		uint num3 = default(uint);
		IntPtr intptr_ = default(IntPtr);
		int int_2 = default(int);
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		int int_ = default(int);
		while (true)
		{
			uint num2;
			IntPtr result;
			switch ((num2 = (uint)(num ^ -119094441)) % 24)
			{
			case 23u:
				num = ((num3 == 0) ? (-1856562310) : (-1689135577)) ^ ((int)num2 * -770282315);
				continue;
			case 22u:
				num3 = method_11<uint>(intptr_.smethod_8(int_2));
				num = -1199822064;
				continue;
			case 21u:
				break;
			case 20u:
				intPtr = RecoveredRuntime.smethod_321(this, intptr_, IntPtr.Zero);
				num = (int)(num2 * 1880844593) ^ -102391197;
				continue;
			case 18u:
				RecoveredRuntime.smethod_153(this, intPtr, -1);
				num = -1569625463;
				continue;
			case 17u:
				vmethod_6(intptr_);
				num = (int)(num2 * 1198042357) ^ -2129308134;
				continue;
			case 14u:
				num = (RecoveredRuntime.HasProcessExited(method_19()) ? 1085827942 : 102433601) ^ (int)(num2 * 124969340);
				continue;
			case 10u:
				string_0 = Path.GetFullPath(string_0);
				num = ((int)num2 * -953850148) ^ -712748468;
				continue;
			case 8u:
				goto IL_012e;
			case 7u:
				intptr_ = method_24(intPtr2, string_0, out int_, out int_2);
				num = -2017058477;
				continue;
			case 6u:
				if (!RecoveredRuntime.smethod_427(method_19()))
				{
					num = -1707199549;
					continue;
				}
				result = (IntPtr)method_11<uint>(intptr_.smethod_8(int_));
				goto IL_038f;
			case 5u:
				goto end_IL_0231;
			case 3u:
				vmethod_6(intptr_);
				num = ((int)num2 * -1103678123) ^ -1774238953;
				continue;
			case 2u:
				num = ((!(intPtr2 == IntPtr.Zero)) ? 1130850252 : 1344991690) ^ ((int)num2 * -1585432438);
				continue;
			case 1u:
				vmethod_6(intptr_);
				num = ((int)num2 * -1145143255) ^ 0x1976ADEA;
				continue;
			case 0u:
				num = ((intPtr == IntPtr.Zero) ? 744132606 : 762929957) ^ (int)(num2 * 1470387291);
				continue;
			case 11u:
				goto IL_02b3;
			case 4u:
				throw new AccessViolationException("Unable to create thread in the specified process.");
			case 9u:
				throw new MissingMethodException("Unable to find the LdrLoadDll function inside the specified process.");
			default:
				result = method_11<IntPtr>(intptr_.smethod_8(int_));
				goto IL_038f;
			case 13u:
				throw new UnauthorizedAccessException("Unable to open the specified process for injection.");
			case 15u:
				throw new Exception("LdrLoadDll failed to load the specified DLL. (NT Status: 0x" + num3.ToString("X8") + ")", RecoveredRuntime.smethod_213(num3, this));
			case 16u:
				throw new Exception("The target process exited before injection could complete.");
			case 19u:
				{
					throw new FileNotFoundException("Unable to find the specified file for injection. (" + string_0 + ")");
				}
				IL_038f:
				vmethod_6(intptr_);
				RecoveredRuntime.smethod_108(this, intPtr);
				return result;
			}
			num = (method_8(method_19().ProcessId) ? (-1661214097) : (-211511902));
			continue;
			IL_012e:
			intPtr2 = RecoveredRuntime.smethod_225(RecoveredRuntime.smethod_42(method_19())["ntdll.dll"] ?? throw new FileNotFoundException("Unable to find ntdll.dll in the specified process."), "LdrLoadDll", bool_0: false);
			num = -2108430739;
			continue;
			end_IL_0231:
			break;
		}
		goto IL_019a;
		IL_02b3:
		num = (File.Exists(string_0) ? (-181323686) : (-1843062060));
		goto IL_0231;
	}

	internal IntPtr method_24(IntPtr intptr_1, string string_0, out int int_1, out int int_2)
	{
		int_1 = 0;
		int_2 = 0;
		IntPtr intPtr = RecoveredRuntime.smethod_175(this, 4096L, NativeTypes.Enum34.flag_2);
		AsmJitAssembler class2 = default(AsmJitAssembler);
		AsmJitLabel class58_ = default(AsmJitLabel);
		RemoteAssembler class47_ = default(RemoteAssembler);
		AsmJitLabel class58_3 = default(AsmJitLabel);
		IntPtr intPtr2 = default(IntPtr);
		byte[] bytes = default(byte[]);
		AsmJitLabel class58_2 = default(AsmJitLabel);
		while (true)
		{
			int num = 497055350;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6FBC7D6C)) % 25)
				{
				case 24u:
					num = ((!(intPtr == IntPtr.Zero)) ? (-1625527655) : (-1108040765)) ^ ((int)num2 * -1890512416);
					continue;
				case 23u:
					RecoveredRuntime.smethod_36(class2, class58_);
					int_1 = RecoveredRuntime.smethod_252(class2);
					RecoveredRuntime.smethod_336(class47_);
					num = (int)((num2 * 1125448434) ^ 0x264039BF);
					continue;
				case 21u:
					class2 = new AsmJitAssembler();
					num = 355439472;
					continue;
				case 19u:
					RecoveredRuntime.smethod_75(class2, RecoveredRuntime.smethod_126(class58_3, 0L), AsmJitRuntime.class63_37);
					RecoveredRuntime.smethod_226(class47_, -1);
					num = 1129210671;
					continue;
				case 18u:
					RecoveredRuntime.smethod_286(class47_, intPtr2);
					num = ((RecoveredRuntime.smethod_443(intPtr, class2, this) == IntPtr.Zero) ? 1549379627 : 113368551) ^ ((int)num2 * -253945004);
					continue;
				case 17u:
					num = (RecoveredRuntime.smethod_427(method_19()) ? 1506205645 : 2023462491) ^ ((int)num2 * -904323616);
					continue;
				case 16u:
					RecoveredRuntime.smethod_36(class2, class58_3);
					num = ((int)num2 * -1534065286) ^ 0x31737CB2;
					continue;
				case 15u:
					RecoveredRuntime.smethod_52(class2, (ushort)bytes.Length);
					num = ((int)num2 * -767565473) ^ 0x18F5271E;
					continue;
				case 14u:
					vmethod_6(intPtr);
					num = ((int)num2 * -1775784928) ^ 0x26C1C57A;
					continue;
				case 13u:
					RecoveredRuntime.smethod_227(class47_);
					num = ((int)num2 * -541602821) ^ 0x45559B13;
					continue;
				case 12u:
					int_2 = RecoveredRuntime.smethod_252(class2);
					num = ((int)num2 * -853169748) ^ 0xB8B624A;
					continue;
				case 11u:
					RecoveredRuntime.smethod_52(class2, (ushort)(bytes.Length - 2));
					num = ((int)num2 * -1297069880) ^ 0x434BC59;
					continue;
				case 10u:
					RecoveredRuntime.smethod_227(class47_);
					num = ((int)num2 * -894258435) ^ 0x6B72AE95;
					continue;
				case 9u:
					RecoveredRuntime.smethod_15(class47_);
					RecoveredRuntime.smethod_54(class47_, new AsmJitImmediate(intptr_1), CallingConvention.StdCall, new object[4]
					{
						IntPtr.Zero,
						IntPtr.Zero,
						RecoveredRuntime.smethod_84(class47_, class58_2),
						RecoveredRuntime.smethod_84(class47_, class58_)
					});
					num = ((int)num2 * -930141647) ^ -1557209848;
					continue;
				case 7u:
					intPtr2 = intPtr.smethod_8(RecoveredRuntime.smethod_252(class2));
					num = ((int)num2 * -1036468219) ^ -834445518;
					continue;
				case 6u:
					class2.struct19_0.uint_2 |= 8u;
					num = (int)((num2 * 1336089541) ^ 0x65CF513E);
					continue;
				case 5u:
					RecoveredRuntime.smethod_227(class47_);
					num = ((int)num2 * -121576457) ^ -1385631303;
					continue;
				case 4u:
					RecoveredRuntime.smethod_227(class47_);
					num = (int)((num2 * 788831748) ^ 0x229502BD);
					continue;
				case 2u:
					RecoveredRuntime.smethod_439(class2, 0u);
					num = ((int)num2 * -803668432) ^ -1627327960;
					continue;
				case 1u:
					bytes = Encoding.Unicode.GetBytes(string_0 + "\0");
					RecoveredRuntime.smethod_320(class2, bytes);
					RecoveredRuntime.smethod_227(class47_);
					RecoveredRuntime.smethod_36(class2, class58_2);
					num = (int)((num2 * 1918289043) ^ 0x1E159193);
					continue;
				case 0u:
				{
					RemoteAssembler @class = new RemoteAssembler(class2, method_19());
					@class.method_1(bool_3: true);
					class47_ = @class;
					class58_ = RecoveredRuntime.smethod_48(class2);
					class58_2 = RecoveredRuntime.smethod_48(class2);
					class58_3 = RecoveredRuntime.smethod_48(class2);
					num = (int)((num2 * 381572352) ^ 0xC660C52);
					continue;
				}
				case 3u:
					break;
				case 8u:
					throw new AccessViolationException("Unable to allocate memory for the LdrLoadDll code.");
				case 22u:
					throw new InvalidOperationException("Unable to generate code for the LdrLoadDll stub.");
				default:
					return intPtr;
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

	internal static InvalidOperationException smethod_19(string string_0)
	{
		return new InvalidOperationException(string_0);
	}
}
