using System;
using System.Collections.Generic;

public abstract class Class96 : Class95
{
	public sealed class Class168
	{
		public int int_0;

		public bool bool_0;

		internal Class168()
		{
		}
	}

	internal static Dictionary<Type, int[]> dictionary_0 = new Dictionary<Type, int[]>();

	internal static Dictionary<Type, int[]> dictionary_1;

	internal int[] int_1;

	internal bool bool_1;

	protected Class96(int int_2, bool bool_2)
		: base(int_2)
	{
		while (true)
		{
			int num = 90471125;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3748BE2C)) % 4)
				{
				case 3u:
					int_1 = (bool_2 ? dictionary_0[GetType()] : dictionary_1[GetType()]);
					num = 1507801890;
					continue;
				case 1u:
					bool_1 = bool_2;
					num = ((int)num2 * -791381720) ^ 0x49365AC7;
					continue;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	protected Class96(IntPtr intptr_2, bool bool_2)
		: base(intptr_2)
	{
		bool_1 = bool_2;
		int_1 = (bool_2 ? dictionary_0[GetType()] : dictionary_1[GetType()]);
	}

	protected static void smethod_0<T>(Class168[] class168_0)
	{
		smethod_2<T>(bool_2: true, class168_0);
	}

	protected static void smethod_1<T>(Class168[] class168_0)
	{
		smethod_2<T>(bool_2: false, class168_0);
	}

	internal static void smethod_2<T>(bool bool_2, IList<Class168> ilist_0)
	{
		int[] array = new int[ilist_0.Count + 1];
		Dictionary<Type, int[]> dictionary2 = default(Dictionary<Type, int[]>);
		int num6 = default(int);
		int num7 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num = -108367302;
			while (true)
			{
				uint num2;
				Dictionary<Type, int[]> dictionary;
				int num4;
				switch ((num2 = (uint)(num ^ -2131308173)) % 24)
				{
				case 23u:
					num = (dictionary2.ContainsKey(typeof(T)) ? (-1886263514) : (-890272922)) ^ ((int)num2 * -796279118);
					continue;
				case 22u:
					dictionary = dictionary_1;
					goto IL_004f;
				case 21u:
					num6 = ilist_0[num7].int_0;
					num = ((int)num2 * -2116506148) ^ 0x3C16C2FD;
					continue;
				case 20u:
					if (!bool_2)
					{
						num = (int)((num2 * 1507370999) ^ 0x4091AE71);
						continue;
					}
					dictionary = dictionary_0;
					goto IL_004f;
				case 19u:
					dictionary2.Add(typeof(T), array);
					num = -1106850741;
					continue;
				case 18u:
					num = ((!ilist_0[num7].bool_0) ? (-629037088) : (-2126708197)) ^ ((int)num2 * -414314325);
					continue;
				case 16u:
					num7++;
					num = -481667577;
					continue;
				case 15u:
					num = ((num7 >= ilist_0.Count) ? (-1635925582) : (-1830662645)) ^ ((int)num2 * -991524857);
					continue;
				case 14u:
					array[num7] = num3;
					num = -1215650100;
					continue;
				case 13u:
					num5 = -num3 & (num6 - 1);
					num = -302979539;
					continue;
				case 12u:
					num6 = num8;
					num = (int)((num2 * 736792909) ^ 0x72C58C8A);
					continue;
				case 11u:
					dictionary2[typeof(T)] = array;
					num = ((int)num2 * -359776088) ^ -1228474078;
					continue;
				case 10u:
					num4 = 8;
					goto IL_017f;
				case 9u:
					num3 += ilist_0[num7].int_0;
					num = (int)((num2 * 1914422362) ^ 0x70030B51);
					continue;
				case 8u:
					num3 += num5;
					num = ((int)num2 * -2036552135) ^ -1270155883;
					continue;
				case 7u:
					num7 = 0;
					num = ((int)num2 * -2011997735) ^ 0x5FCB3600;
					continue;
				case 6u:
					num = ((num5 > 0) ? 1517954737 : 1215923287) ^ (int)(num2 * 1589531343);
					continue;
				case 4u:
					num = ((num7 >= ilist_0.Count + 1) ? (-1254110089) : (-870225136));
					continue;
				case 3u:
					num = ((num7 >= ilist_0.Count) ? (-1979751083) : (-1175105383));
					continue;
				case 2u:
					if (!bool_2)
					{
						num = ((int)num2 * -1337381755) ^ 0x33EC02BB;
						continue;
					}
					num4 = 4;
					goto IL_017f;
				case 1u:
					num3 = 0;
					num = (int)(num2 * 615589107) ^ -691933209;
					continue;
				default:
					return;
				case 5u:
					break;
				case 0u:
					return;
				case 17u:
					return;
					IL_004f:
					dictionary2 = dictionary;
					num = -175254540;
					continue;
					IL_017f:
					num8 = num4;
					num = ((num6 <= num8) ? (-1083592106) : (-710320833));
					continue;
				}
				break;
			}
		}
	}

	protected internal T method_21<T>(int int_2)
	{
		int num = int_1[int_2];
		if (bool_1)
		{
			while (true)
			{
				int num2 = 738383032;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x4C5E904E)) % 4)
					{
					case 2u:
						num2 = (((object)typeof(T) == typeof(IntPtr)) ? (-1809049409) : (-346211655)) ^ (int)(num3 * 316702938);
						continue;
					case 0u:
						break;
					case 1u:
						return (T)(object)(IntPtr)method_19<int>(num);
					default:
						goto end_IL_0069;
					}
					break;
				}
				continue;
				end_IL_0069:
				break;
			}
		}
		return method_19<T>(num);
	}

	protected void method_22<T>(int int_2, T gparam_0)
	{
		int num = int_1[int_2];
		while (true)
		{
			int num2 = 449735955;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x38BC24C)) % 6)
				{
				case 4u:
					num2 = (((object)typeof(T) != typeof(IntPtr)) ? (-350935761) : (-333221278)) ^ (int)(num3 * 1766883677);
					continue;
				case 1u:
					num2 = (bool_1 ? 847812248 : 2105556291) ^ (int)(num3 * 169957718);
					continue;
				case 0u:
					method_20((int)(IntPtr)(object)gparam_0, num);
					num2 = ((int)num3 * -823861741) ^ 0x5CF4D03B;
					continue;
				case 2u:
					break;
				default:
					method_20(gparam_0, num);
					return;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	static Class96()
	{
		while (true)
		{
			int num = 877409229;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4754864E)) % 3)
				{
				case 1u:
					goto IL_000c;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_000c:
				dictionary_1 = new Dictionary<Type, int[]>();
				num = (int)(num2 * 1486128869) ^ -120980066;
			}
		}
	}
}
