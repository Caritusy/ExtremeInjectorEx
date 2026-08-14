using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

public sealed class AsmJitOperandConverter : TypeConverter
{
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if (!new Type[14]
		{
			typeof(IntPtr),
			typeof(UIntPtr),
			typeof(int),
			typeof(uint),
			typeof(long),
			typeof(ulong),
			typeof(ushort),
			typeof(short),
			typeof(float),
			typeof(double),
			typeof(bool),
			typeof(byte),
			typeof(sbyte),
			typeof(AsmJitImmediate)
		}.Contains(sourceType))
		{
			return method_0(context, sourceType);
		}
		return true;
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is AsmJitImmediate)
		{
			goto IL_019f;
		}
		goto IL_027f;
		IL_019f:
		int num = -1537798551;
		goto IL_01e6;
		IL_01e6:
		while (true)
		{
			uint num2;
			int num3;
			switch ((num2 = (uint)(num ^ -1182442543)) % 30)
			{
			case 29u:
				break;
			case 27u:
				goto IL_0044;
			case 20u:
				goto IL_0068;
			case 17u:
				goto IL_008c;
			case 16u:
				goto IL_00b0;
			case 15u:
				goto IL_00d4;
			case 14u:
				goto IL_00f8;
			case 13u:
				goto IL_011c;
			case 12u:
				if (!(bool)value)
				{
					num = (int)((num2 * 2131421853) ^ 0x5D86CFAF);
					continue;
				}
				num3 = 1;
				goto IL_02d8;
			case 10u:
				goto IL_015d;
			case 7u:
				goto IL_017e;
			case 6u:
				goto end_IL_01e6;
			case 3u:
				goto IL_01a6;
			case 0u:
				goto IL_01c7;
			case 19u:
				goto IL_027f;
			case 1u:
				return new AsmJitImmediate((IntPtr)value);
			case 2u:
				num3 = 0;
				goto IL_02d8;
			case 4u:
				return RecoveredRuntime.smethod_301((UIntPtr)value);
			case 5u:
				return RecoveredRuntime.smethod_59((sbyte)value);
			case 8u:
				return RecoveredRuntime.smethod_446((double)value);
			case 9u:
				return RecoveredRuntime.smethod_195((long)value);
			case 11u:
				return RecoveredRuntime.smethod_423((float)value);
			default:
				return null;
			case 21u:
				return RecoveredRuntime.smethod_344((short)value);
			case 22u:
				return RecoveredRuntime.smethod_167((int)value);
			case 23u:
				return RecoveredRuntime.smethod_374((uint)value);
			case 24u:
				return RecoveredRuntime.smethod_384((ushort)value);
			case 25u:
				return RecoveredRuntime.smethod_125((ulong)value);
			case 26u:
				return RecoveredRuntime.smethod_72((byte)value);
			case 28u:
				{
					return value;
				}
				IL_02d8:
				return new AsmJitImmediate((IntPtr)num3);
			}
			num = ((value is byte) ? (-1991468983) : (-67482812));
			continue;
			IL_01c7:
			num = ((value is long) ? (-541468822) : (-150864992));
			continue;
			IL_00b0:
			num = ((value is ushort) ? (-960237595) : (-1976556376));
			continue;
			IL_00f8:
			num = ((!(value is sbyte)) ? (-1402441644) : (-1550389248));
			continue;
			IL_01a6:
			num = ((!(value is ulong)) ? (-901261673) : (-1003465902));
			continue;
			IL_008c:
			num = ((!(value is double)) ? (-406409146) : (-91604965));
			continue;
			IL_0044:
			num = ((!(value is uint)) ? (-636898427) : (-361472986));
			continue;
			IL_017e:
			num = ((!(value is bool)) ? (-981167589) : (-1927027971));
			continue;
			IL_00d4:
			num = ((!(value is int)) ? (-924905142) : (-152301593));
			continue;
			IL_011c:
			num = ((!(value is short)) ? (-220819845) : (-84303530));
			continue;
			IL_015d:
			num = ((value is float) ? (-1964589218) : (-579327698));
			continue;
			IL_0068:
			num = ((!(value is UIntPtr)) ? (-2123450813) : (-1951876017));
			continue;
			end_IL_01e6:
			break;
		}
		goto IL_019f;
		IL_027f:
		num = ((value is IntPtr) ? (-1590418360) : (-485408005));
		goto IL_01e6;
	}

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal bool method_0(ITypeDescriptorContext itypeDescriptorContext_0, Type type_0)
	{
		return base.CanConvertFrom(itypeDescriptorContext_0, type_0);
	}
}
