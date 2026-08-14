using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class Class154 : IDisposable
{
	public interface Interface3
	{
		long imethod_0(Class154 class154_0, uint uint_0);
	}

	public sealed class Class155 : Interface3
	{
		public long imethod_0(Class154 class154_0, uint uint_0)
		{
			using (List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator())
			{
				GClass5 current = default(GClass5);
				long result = default(long);
				while (true)
				{
					IL_00f1:
					int num = ((!enumerator.MoveNext()) ? (-1572770025) : (-669986976));
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -813529743)) % 8)
						{
						case 7u:
							num = ((uint_0 >= current.method_4() + current.method_6()) ? 1661393667 : 1961237498) ^ (int)(num2 * 840203914);
							continue;
						case 5u:
							result = uint_0 - current.method_4() + current.method_8();
							num = (int)((num2 * 312627368) ^ 0x285EE639);
							continue;
						case 3u:
							num = ((uint_0 < current.method_4()) ? 304465364 : 81893455) ^ ((int)num2 * -993563573);
							continue;
						case 2u:
							num = -669986976;
							continue;
						case 1u:
							current = enumerator.Current;
							num = -137276558;
							continue;
						default:
							goto end_IL_00b1;
						case 4u:
							break;
						case 6u:
							goto end_IL_00b1;
						case 0u:
							return result;
						}
						goto IL_00f1;
						continue;
						end_IL_00b1:
						break;
					}
					break;
				}
			}
			return -1L;
		}
	}

	public sealed class Class156 : Interface3
	{
		public long imethod_0(Class154 class154_0, uint uint_0)
		{
			return uint_0;
		}
	}

	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	internal string string_1;

	[CompilerGenerated]
	internal Class158 class158_0;

	[CompilerGenerated]
	internal Class161 class161_0;

	[CompilerGenerated]
	internal List<GClass5> list_0;

	[CompilerGenerated]
	internal Class148 class148_0;

	[CompilerGenerated]
	internal Class149 class149_0;

	[CompilerGenerated]
	internal Class151 class151_0;

	[CompilerGenerated]
	internal Class146 class146_0;

	[CompilerGenerated]
	internal Class147 class147_0;

	[CompilerGenerated]
	internal Class167 class167_0;

	[CompilerGenerated]
	internal Class143 class143_0;

	[CompilerGenerated]
	internal Class166 class166_0;

	[CompilerGenerated]
	internal Class141 class141_0;

	[CompilerGenerated]
	internal Class142 class142_0;

	[CompilerGenerated]
	internal Stream stream_0;

	[CompilerGenerated]
	internal Enum39 enum39_0;

	internal readonly bool bool_0;

	internal readonly Interface3 interface3_0;

	[SpecialName]
	[CompilerGenerated]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(string string_2)
	{
		string_0 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_2()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(string string_2)
	{
		string_1 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class158 method_4()
	{
		return class158_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(Class158 class158_1)
	{
		class158_0 = class158_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class161 method_6()
	{
		return class161_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(Class161 class161_1)
	{
		class161_0 = class161_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<GClass5> method_8()
	{
		return list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(List<GClass5> list_1)
	{
		list_0 = list_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class148 method_10()
	{
		return class148_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(Class148 class148_1)
	{
		class148_0 = class148_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class149 method_12()
	{
		return class149_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_13(Class149 class149_1)
	{
		class149_0 = class149_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class151 method_14()
	{
		return class151_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_15(Class151 class151_1)
	{
		class151_0 = class151_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class146 method_16()
	{
		return class146_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_17(Class146 class146_1)
	{
		class146_0 = class146_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class147 method_18()
	{
		return class147_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_19(Class147 class147_1)
	{
		class147_0 = class147_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class167 method_20()
	{
		return class167_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_21(Class167 class167_1)
	{
		class167_0 = class167_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_22(Class143 class143_1)
	{
		class143_0 = class143_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class166 method_23()
	{
		return class166_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_24(Class166 class166_1)
	{
		class166_0 = class166_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Class141 method_25()
	{
		return class141_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_26(Class141 class141_1)
	{
		class141_0 = class141_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_27(Class142 class142_1)
	{
		class142_0 = class142_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Stream method_28()
	{
		return stream_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_29(Stream stream_1)
	{
		stream_0 = stream_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_30(Enum39 enum39_1)
	{
		enum39_0 = enum39_1;
	}

	public Class154(Stream stream_1, Enum39 enum39_1)
	{
		while (true)
		{
			int num = -1679192658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -433066232)) % 7)
				{
				case 5u:
					interface3_0 = new Class155();
					num = ((int)num2 * -1506842910) ^ -723329806;
					continue;
				case 3u:
					num = ((enum39_1 == Enum39.const_0) ? (-847196778) : (-13216941)) ^ (int)(num2 * 290839860);
					continue;
				case 2u:
					interface3_0 = new Class156();
					num = -265587503;
					continue;
				case 1u:
					method_30(enum39_1);
					method_29(stream_1);
					num = ((int)num2 * -1146167102) ^ -1392579271;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public Class154(Stream stream_1, bool bool_1, Enum39 enum39_1)
		: this(stream_1, enum39_1)
	{
		bool_0 = bool_1;
	}

	~Class154()
	{
		if (!bool_0)
		{
			return;
		}
		while (true)
		{
			int num = -1241300689;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1031244942)) % 3)
				{
				case 2u:
					goto IL_000b;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000b:
				((IDisposable)this).Dispose();
				num = ((int)num2 * -755813774) ^ -244268752;
			}
		}
	}

	public void System_002EIDisposable_002EDispose()
	{
		((IDisposable)this).Dispose();
	}

	void IDisposable.Dispose()
	{
		if (!bool_0)
		{
			return;
		}
		while (true)
		{
			int num = 36478713;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1274D5EE)) % 5)
				{
				case 3u:
					method_28().Dispose();
					num = (int)(num2 * 1805078712) ^ -290425668;
					continue;
				case 2u:
					num = ((method_28() == null) ? 567030699 : 247700802) ^ (int)(num2 * 1981427340);
					continue;
				case 1u:
					method_29(null);
					num = (int)((num2 * 1801503697) ^ 0x78880C8D);
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_0(Stream stream_1)
	{
		stream_1.Dispose();
	}
}
