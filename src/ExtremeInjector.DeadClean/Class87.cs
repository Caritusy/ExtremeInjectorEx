using System;
using System.IO;
using System.Text;

public sealed class Class87 : Class85
{
	public Class87(GClass2 gclass2_1)
		: base(gclass2_1)
	{
	}

	protected override void method_033E()
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
					method_3(Class171.OpenProcess(Class124.Enum32.flag_2 | Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5 | Class124.Enum32.flag_9, false, method_0()));
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

	public override IntPtr method_083B(string string_0)
	{
		if (method_8(method_19().method_0()))
		{
			goto IL_0016;
		}
		goto IL_0160;
		IL_0016:
		IntPtr intPtr = Class171.smethod_220(Class171.smethod_42(method_19())[Class178.smethod_0(8503)] ?? throw new FileNotFoundException(Class178.smethod_0(28636)), Class178.smethod_0(28709), false);
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
				intPtr2 = Class171.smethod_315((Class83)this, intPtr, intPtr3);
				num = 703462975;
				continue;
			case 5u:
				Class171.smethod_152((Class83)this, intPtr2, -1);
				num = 116946065;
				continue;
			case 4u:
				vmethod_6(intPtr3);
				num = (int)(num2 * 1428417808) ^ -428510312;
				continue;
			case 3u:
				bytes = Encoding.Unicode.GetBytes(string_0 + Class178.smethod_0(12219));
				intPtr3 = Class171.smethod_174((Class82)this, (long)bytes.Length, Class124.Enum34.flag_6);
				num = 324879476;
				continue;
			case 2u:
				num = ((intPtr3 == IntPtr.Zero) ? (-1454378523) : (-944372867)) ^ ((int)num2 * -1591192879);
				continue;
			case 0u:
				goto IL_0160;
			case 1u:
				throw new AccessViolationException(Class178.smethod_0(28892));
			case 6u:
				throw new MissingMethodException(Class178.smethod_0(28726));
			case 7u:
				throw new AccessViolationException(Class178.smethod_0(28823));
			case 11u:
				vmethod_6(intPtr3);
				throw new AccessViolationException(Class178.smethod_0(12914));
			case 14u:
				throw new UnauthorizedAccessException(Class178.smethod_0(12662));
			default:
				Class171.smethod_108((Class83)this, intPtr2);
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
}
