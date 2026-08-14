using System;
using System.Runtime.CompilerServices;

internal sealed class Class47
{
	internal sealed class Class48
	{
		[CompilerGenerated]
		private Class58 class58_0;

		[SpecialName]
		[CompilerGenerated]
		public Class58 method_0()
		{
			return class58_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(Class58 class58_1)
		{
			class58_0 = class58_1;
		}

		public Class48(Class58 class58_1)
		{
			while (true)
			{
				int num = -1309916334;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1150050368)) % 3)
					{
					case 1u:
						goto IL_0008;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0008:
					method_1(class58_1);
					num = (int)(num2 * 1238232558) ^ -985049822;
				}
			}
		}
	}

	internal enum Enum6
	{
		const_0,
		const_1,
		const_2
	}

	internal Class53 class53_0;

	internal bool bool_0;

	internal bool bool_1;

	internal Class58 class58_0;

	internal Class58 class58_1;

	internal int int_0;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private int int_1;

	[SpecialName]
	[CompilerGenerated]
	public bool method_0()
	{
		return bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(bool bool_3)
	{
		bool_2 = bool_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_2()
	{
		return int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_3(int int_2)
	{
		int_1 = int_2;
	}

	public Class47(Class53 class53_1, GClass2 gclass2_0)
	{
		class53_0 = class53_1;
		bool_0 = Class171.smethod_418(gclass2_0);
		bool_1 = gclass2_0.bool_2;
	}

	public void method_4<T>()
	{
		class58_0 = Class171.smethod_48(class53_0);
		while (true)
		{
			int num = -2068964950;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -714431061)) % 16)
				{
				case 14u:
					Class171.smethod_75(class53_0, Class171.smethod_115(class58_0, 0L, this), Class49.class63_21);
					num = (int)((num2 * 1326707871) ^ 0x39C56CDC);
					continue;
				case 13u:
					Class171.smethod_75(class53_0, Class171.smethod_284(class58_0, 0L, this), Class49.class63_37);
					num = (int)((num2 * 739642685) ^ 0x4565DAE6);
					continue;
				case 12u:
				{
					int num5;
					int num6;
					if ((object)typeof(T) != typeof(IntPtr))
					{
						num5 = 640685527;
						num6 = 640685527;
					}
					else
					{
						num5 = 1935894933;
						num6 = 1935894933;
					}
					num = num5 ^ ((int)num2 * -1601807039);
					continue;
				}
				case 9u:
				{
					int num8;
					if (int_0 != 2)
					{
						num = -587012189;
						num8 = -587012189;
					}
					else
					{
						num = -410853547;
						num8 = -410853547;
					}
					continue;
				}
				case 8u:
				{
					int num7;
					if (int_0 == 1)
					{
						num = -383820506;
						num7 = -383820506;
					}
					else
					{
						num = -1989533555;
						num7 = -1989533555;
					}
					continue;
				}
				case 7u:
				{
					int num9;
					if (int_0 != 4)
					{
						num = -1399359950;
						num9 = -1399359950;
					}
					else
					{
						num = -744592575;
						num9 = -744592575;
					}
					continue;
				}
				case 3u:
					int_0 = (bool_0 ? 4 : 8);
					num = -747413692;
					continue;
				case 2u:
					Class171.smethod_75(class53_0, Class171.smethod_216(this, class58_0, 0L), bool_0 ? Class49.class63_37 : Class49.class63_53);
					num = -2037542776;
					continue;
				case 1u:
					int_0 = Class127.smethod_1<T>();
					num = ((int)num2 * -799940171) ^ -1787245134;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if ((object)typeof(T) != typeof(UIntPtr))
					{
						num3 = -1557595092;
						num4 = -1557595092;
					}
					else
					{
						num3 = -1885138615;
						num4 = -1885138615;
					}
					num = num3 ^ ((int)num2 * -641305757);
					continue;
				}
				case 11u:
					break;
				case 4u:
					return;
				case 5u:
					return;
				default:
					throw new InvalidOperationException(Class178.smethod_0(4473));
				case 10u:
					Class171.smethod_75(class53_0, Class171.smethod_80(0L, this, class58_0), Class49.class63_37);
					return;
				case 15u:
					return;
				}
				break;
			}
		}
	}
}
