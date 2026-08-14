using System;
using System.IO;
using System.Text;

public sealed class Class87 : Class85
{
	public Class87(GClass2 gclass2_1)
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
			int num = -797266021;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -820164780)) % 4)
				{
				case 3u:
					num = ((method_0() == -1) ? 1531184034 : 1163380753) ^ ((int)num2 * -448381827);
					continue;
				case 2u:
					method_3(Class171.OpenProcess(Class124.Enum32.flag_2 | Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5 | Class124.Enum32.flag_9, bool_0: false, method_0()));
					num = ((int)num2 * -91392743) ^ -202254633;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override IntPtr method_0BA6(string string_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		if (method_8(method_19().method_0()))
		{
			goto IL_0016;
		}
		goto IL_0160;
		IL_0016:
		intPtr = Class171.smethod_225(Class171.smethod_42(method_19())["kernel32.dll"] ?? throw new FileNotFoundException("Unable to find kernel32.dll in the specified process."), "LoadLibraryW", bool_0: false);
		int num = ((intPtr == IntPtr.Zero) ? 1138006522 : 439665122);
		goto IL_0165;
		IL_0165:
		IntPtr intPtr2 = default(IntPtr);
		IntPtr intPtr3 = default(IntPtr);
		byte[] bytes = default(byte[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5748254C)) % 15)
			{
			case 8u:
				break;
			case 13u:
				goto IL_0070;
			case 10u:
				num = ((intPtr2 == IntPtr.Zero) ? (-942292716) : (-420430306)) ^ ((int)num2 * -470306695);
				continue;
			case 9u:
				intPtr2 = Class171.smethod_321(this, intPtr, intPtr3);
				num = 703462975;
				continue;
			case 5u:
				Class171.smethod_153(this, intPtr2, -1);
				num = 116946065;
				continue;
			case 4u:
				vmethod_6(intPtr3);
				num = (int)(num2 * 1428417808) ^ -428510312;
				continue;
			case 3u:
				bytes = Encoding.Unicode.GetBytes(string_0 + "\0");
				intPtr3 = Class171.smethod_175(this, bytes.Length, Class124.Enum34.flag_6);
				num = 324879476;
				continue;
			case 2u:
				num = ((intPtr3 == IntPtr.Zero) ? (-1454378523) : (-944372867)) ^ ((int)num2 * -1591192879);
				continue;
			case 0u:
				goto IL_0160;
			case 1u:
				throw new AccessViolationException("Unable to write memory for the injection path.");
			case 6u:
				throw new MissingMethodException("Unable to find the LoadLibraryW function inside the specified process.");
			case 7u:
				throw new AccessViolationException("Unable to allocate memory for the injection path.");
			case 11u:
				vmethod_6(intPtr3);
				throw new AccessViolationException("Unable to create thread in the specified process.");
			case 14u:
				throw new UnauthorizedAccessException("Unable to open the specified process for injection.");
			default:
				Class171.smethod_108(this, intPtr2);
				return Class171.smethod_42(method_19()).method_0(Path.GetFileName(string_0));
			}
			break;
			IL_0070:
			num = (method_16(intPtr3, bytes) ? 1343511101 : 1743339821);
		}
		goto IL_0016;
		IL_0160:
		num = 1718071972;
		goto IL_0165;
	}

	internal static UnauthorizedAccessException smethod_7(string string_0)
	{
		return new UnauthorizedAccessException(string_0);
	}

	internal static FileNotFoundException smethod_8(string string_0)
	{
		return new FileNotFoundException(string_0);
	}

	internal static MissingMethodException smethod_9(string string_0)
	{
		return new MissingMethodException(string_0);
	}

	internal static Encoding smethod_10()
	{
		return Encoding.Unicode;
	}

	internal static string smethod_11(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static byte[] smethod_12(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	internal static AccessViolationException smethod_13(string string_0)
	{
		return new AccessViolationException(string_0);
	}

	internal static string smethod_14(string string_0)
	{
		return Path.GetFileName(string_0);
	}
}
