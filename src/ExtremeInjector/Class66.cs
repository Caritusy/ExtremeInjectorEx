using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

internal sealed class Class66 : TypeConverter
{
	bool TypeConverter.CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
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
			typeof(Class57)
		}.Contains(sourceType))
		{
			return method_0(context, sourceType);
		}
		return true;
	}

	object TypeConverter.ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is Class57)
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
				return new Class57((IntPtr)value);
			case 2u:
				num3 = 0;
				goto IL_02d8;
			case 4u:
				return Class171.smethod_295((UIntPtr)value);
			case 5u:
				return Class171.smethod_59((sbyte)value);
			case 8u:
				return Class171.smethod_437((double)value);
			case 9u:
				return Class171.smethod_193((long)value);
			case 11u:
				return Class171.smethod_414((float)value);
			default:
				return null;
			case 21u:
				return Class171.smethod_338((short)value);
			case 22u:
				return Class171.smethod_166((int)value);
			case 23u:
				return Class171.smethod_368((uint)value);
			case 24u:
				return Class171.smethod_378((ushort)value);
			case 25u:
				return Class171.smethod_124((ulong)value);
			case 26u:
				return Class171.smethod_72((byte)value);
			case 28u:
				{
					return value;
				}
				IL_02d8:
				return new Class57((IntPtr)num3);
			}
			int num4;
			if (!(value is byte))
			{
				num = -67482812;
				num4 = -67482812;
			}
			else
			{
				num = -1991468983;
				num4 = -1991468983;
			}
			continue;
			IL_01c7:
			int num5;
			if (!(value is long))
			{
				num = -150864992;
				num5 = -150864992;
			}
			else
			{
				num = -541468822;
				num5 = -541468822;
			}
			continue;
			IL_00b0:
			int num6;
			if (!(value is ushort))
			{
				num = -1976556376;
				num6 = -1976556376;
			}
			else
			{
				num = -960237595;
				num6 = -960237595;
			}
			continue;
			IL_00f8:
			int num7;
			if (value is sbyte)
			{
				num = -1550389248;
				num7 = -1550389248;
			}
			else
			{
				num = -1402441644;
				num7 = -1402441644;
			}
			continue;
			IL_01a6:
			int num8;
			if (value is ulong)
			{
				num = -1003465902;
				num8 = -1003465902;
			}
			else
			{
				num = -901261673;
				num8 = -901261673;
			}
			continue;
			IL_008c:
			int num9;
			if (value is double)
			{
				num = -91604965;
				num9 = -91604965;
			}
			else
			{
				num = -406409146;
				num9 = -406409146;
			}
			continue;
			IL_0044:
			int num10;
			if (value is uint)
			{
				num = -361472986;
				num10 = -361472986;
			}
			else
			{
				num = -636898427;
				num10 = -636898427;
			}
			continue;
			IL_017e:
			int num11;
			if (value is bool)
			{
				num = -1927027971;
				num11 = -1927027971;
			}
			else
			{
				num = -981167589;
				num11 = -981167589;
			}
			continue;
			IL_00d4:
			int num12;
			if (value is int)
			{
				num = -152301593;
				num12 = -152301593;
			}
			else
			{
				num = -924905142;
				num12 = -924905142;
			}
			continue;
			IL_011c:
			int num13;
			if (value is short)
			{
				num = -84303530;
				num13 = -84303530;
			}
			else
			{
				num = -220819845;
				num13 = -220819845;
			}
			continue;
			IL_015d:
			int num14;
			if (!(value is float))
			{
				num = -579327698;
				num14 = -579327698;
			}
			else
			{
				num = -1964589218;
				num14 = -1964589218;
			}
			continue;
			IL_0068:
			int num15;
			if (value is UIntPtr)
			{
				num = -1951876017;
				num15 = -1951876017;
			}
			else
			{
				num = -2123450813;
				num15 = -2123450813;
			}
			continue;
			end_IL_01e6:
			break;
		}
		goto IL_019f;
		IL_027f:
		int num16;
		if (!(value is IntPtr))
		{
			num = -485408005;
			num16 = -485408005;
		}
		else
		{
			num = -1590418360;
			num16 = -1590418360;
		}
		goto IL_01e6;
	}

	bool method_0(ITypeDescriptorContext itypeDescriptorContext_0, Type type_0)
	{
		return base.CanConvertFrom(itypeDescriptorContext_0, type_0);
	}
}
