using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public class Class6 : Class5
{
	protected readonly Class154 class154_0;

	protected Class6(Stream stream_0, bool bool_0, Enum39 enum39_0)
		: base(stream_0)
	{
		class154_0 = new Class154(stream_0, bool_0, enum39_0);
	}

	protected Class6(Stream stream_0, string string_0, bool bool_0, Enum39 enum39_0)
		: base(stream_0)
	{
		Class154 @class = new Class154(stream_0, bool_0, enum39_0);
		@class.method_1(Path.GetFullPath(string_0));
		@class.method_3(Path.GetFileName(string_0));
		class154_0 = @class;
	}

	protected virtual bool vmethod_0()
	{
		if (vmethod_1())
		{
			while (true)
			{
				int num = -2078205236;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1144005282)) % 5)
					{
					case 3u:
						num = ((int)num2 * -1857402248) ^ 0x63DAD123;
						continue;
					case 1u:
						method_0040();
						num = ((int)num2 * -365603818) ^ 0x1613F04;
						continue;
					case 2u:
						break;
					default:
						return true;
					case 0u:
						goto end_IL_0051;
					}
					break;
				}
				continue;
				end_IL_0051:
				break;
			}
		}
		return false;
	}

	protected virtual bool vmethod_1()
	{
		long position = BaseStream.Position;
		Class158 class158_ = default(Class158);
		if (!Class171.smethod_435(ref class158_, (Class5)this))
		{
			goto IL_0096;
		}
		goto IL_013e;
		IL_0096:
		int num = -1347855090;
		goto IL_00fb;
		IL_00fb:
		Class161 class161_ = default(Class161);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -368048140)) % 12)
			{
			case 11u:
				break;
			case 10u:
				num = ((!Class171.smethod_265(ref class161_, (Class5)this)) ? 441894260 : 1301588511) ^ (int)(num2 * 142451864);
				continue;
			case 9u:
				class154_0.method_9(new List<GClass5>());
				num3 = 0;
				num = ((int)num2 * -1460251125) ^ 0x1D555036;
				continue;
			case 8u:
				goto end_IL_00fb;
			case 5u:
				num = ((int)num2 * -684615018) ^ -258081155;
				continue;
			case 3u:
				class154_0.method_7(class161_);
				num = -1286384575;
				continue;
			case 2u:
				class154_0.method_8().Add(new GClass5(this));
				num3++;
				num = -1130675053;
				continue;
			case 1u:
				Class171.smethod_200((Class5)this, class158_.method_0());
				num = (int)((num2 * 1432805313) ^ 0x38013A37);
				continue;
			case 7u:
				goto IL_013e;
			case 0u:
				return false;
			default:
				return true;
			case 6u:
				return false;
			}
			num = ((num3 >= class161_.method_1().method_2()) ? (-983833692) : (-175537422));
			continue;
			end_IL_00fb:
			break;
		}
		goto IL_0096;
		IL_013e:
		class154_0.method_5(class158_);
		BaseStream.Position = position;
		num = -1185471087;
		goto IL_00fb;
	}

	protected virtual void method_0040()
	{
		class154_0.method_11(Class171.smethod_24(class154_0, (Class5)this));
		while (true)
		{
			int num = -1114270337;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -666036086)) % 6)
				{
				case 5u:
					class154_0.method_17(Class171.smethod_224(class154_0, (Class5)this));
					class154_0.method_24(Class171.smethod_383(class154_0, (Class5)this));
					num = ((int)num2 * -283194504) ^ -234416842;
					continue;
				case 4u:
					class154_0.method_19(Class171.smethod_3(class154_0, (Class5)this));
					class154_0.method_21(Class171.smethod_159(class154_0, (Class5)this));
					num = (int)(num2 * 179370146) ^ -1990977517;
					continue;
				case 3u:
					class154_0.method_22(Class171.smethod_92((Class5)this, class154_0));
					num = ((int)num2 * -1943216389) ^ 0x3F42EF79;
					continue;
				case 1u:
					class154_0.method_13(Class171.smethod_287((Class5)this, class154_0));
					class154_0.method_15(Class171.smethod_349(class154_0, (Class5)this));
					num = (int)(num2 * 56922965) ^ -1121016948;
					continue;
				case 0u:
					break;
				default:
					class154_0.method_26(Class171.smethod_297(class154_0, (Class5)this));
					class154_0.method_27(Class171.smethod_306(class154_0, (Class5)this));
					return;
				}
				break;
			}
		}
	}

	public static Class154 smethod_0<T>(Stream stream_0, bool bool_0, Enum39 enum39_0) where T : Class6
	{
		T val = (T)Activator.CreateInstance(typeof(T), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[3] { stream_0, bool_0, enum39_0 }, null);
		while (true)
		{
			int num = 411043789;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x3C584D7A)) % 4)
				{
				case 3u:
					num3 = ((!val.vmethod_0()) ? 267673861 : 2063708122);
					goto IL_005a;
				case 0u:
					break;
				default:
					return val.class154_0;
				case 2u:
					return null;
				}
				break;
				IL_005a:
				num = num3 ^ (int)(num2 * 232500131);
			}
		}
	}

	public static Class154 smethod_1<T>(Stream stream_0, string string_0, bool bool_0, Enum39 enum39_0) where T : Class6
	{
		T val = (T)Activator.CreateInstance(typeof(T), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new object[4] { stream_0, string_0, bool_0, enum39_0 }, null);
		while (true)
		{
			int num = 1617372357;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0xEF7BF88)) % 4)
				{
				case 1u:
					num3 = ((!val.vmethod_0()) ? (-46821009) : (-632857834));
					goto IL_005e;
				case 0u:
					break;
				default:
					return val.class154_0;
				case 3u:
					return null;
				}
				break;
				IL_005e:
				num = num3 ^ (int)(num2 * 865082632);
			}
		}
	}

	public static Class154 smethod_2(Stream stream_0, bool bool_0, Enum39 enum39_0)
	{
		Class6 @class = new Class6(stream_0, bool_0, enum39_0);
		if (!@class.vmethod_0())
		{
			return null;
		}
		return @class.class154_0;
	}

	public static Class154 smethod_3(Stream stream_0, string string_0, bool bool_0, Enum39 enum39_0)
	{
		Class6 @class = new Class6(stream_0, string_0, bool_0, enum39_0);
		while (true)
		{
			int num = 897564176;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x265914B1)) % 4)
				{
				case 1u:
					num3 = (@class.vmethod_0() ? (-907521054) : (-993323525));
					goto IL_002a;
				case 0u:
					break;
				case 2u:
					return null;
				default:
					return @class.class154_0;
				}
				break;
				IL_002a:
				num = num3 ^ ((int)num2 * -1914426056);
			}
		}
	}
}
