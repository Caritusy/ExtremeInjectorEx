using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

public sealed class GClass4 : IDisposable
{
	public delegate T Delegate48<out T>();

	public sealed class Class132
	{
		[CompilerGenerated]
		internal uint uint_0;

		[CompilerGenerated]
		internal uint uint_1;

		[CompilerGenerated]
		internal GClass5 gclass5_0;

		[CompilerGenerated]
		internal GClass5 gclass5_1;

		[SpecialName]
		[CompilerGenerated]
		public uint method_0()
		{
			return uint_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_1(uint uint_2)
		{
			uint_0 = uint_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_2(uint uint_2)
		{
			uint_1 = uint_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public GClass5 method_3()
		{
			return gclass5_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_4(GClass5 gclass5_2)
		{
			gclass5_0 = gclass5_2;
		}

		[SpecialName]
		[CompilerGenerated]
		public GClass5 method_5()
		{
			return gclass5_1;
		}

		[SpecialName]
		[CompilerGenerated]
		public void method_6(GClass5 gclass5_2)
		{
			gclass5_1 = gclass5_2;
		}

		public Class132(GClass5 gclass5_2, uint uint_2, uint uint_3)
		{
			while (true)
			{
				int num = 668751514;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x43F39531)) % 10)
					{
					case 9u:
						num = ((method_3().method_6() == 0) ? 697322040 : 1120781505);
						continue;
					case 6u:
						num = ((method_3().method_2() != 0) ? 138517418 : 1999603262) ^ (int)(num2 * 1707315408);
						continue;
					case 5u:
					{
						GClass5 gClass = new GClass5();
						gClass.method_19(gclass5_2.method_18());
						gClass.method_1(gclass5_2.method_0());
						gClass.method_17(gclass5_2.method_16());
						gClass.method_15(gclass5_2.method_14());
						gClass.method_13(gclass5_2.method_12());
						gClass.method_9(gclass5_2.method_8());
						gClass.method_11(gclass5_2.method_10());
						gClass.method_7(gclass5_2.method_6());
						gClass.method_5(gclass5_2.method_4() + uint_2);
						gClass.method_3(gclass5_2.method_2());
						method_4(gClass);
						num = (int)((num2 * 1593962926) ^ 0x61D80499);
						continue;
					}
					case 4u:
					{
						GClass5 gClass3 = method_3();
						gClass3.method_7(gClass3.method_6() + uint_3);
						num = ((int)num2 * -1711932643) ^ 0x3085D208;
						continue;
					}
					case 3u:
						method_6(gclass5_2);
						method_2(uint_2);
						num = (int)((num2 * 2041380024) ^ 0x25EEDEB9);
						continue;
					case 2u:
					{
						GClass5 gClass2 = method_3();
						gClass2.method_3(gClass2.method_2() + uint_3);
						num = (int)(num2 * 451016062) ^ -1639560222;
						continue;
					}
					case 1u:
						num = ((method_3().method_6() == 0) ? 472553584 : 1386658269) ^ (int)(num2 * 154208106);
						continue;
					case 0u:
						method_1(uint_3);
						num = ((int)num2 * -310177794) ^ -2074761626;
						continue;
					default:
						return;
					case 8u:
						break;
					case 7u:
						return;
					}
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	public sealed class Class133
	{
		public string string_0;

		internal bool method_0(GClass5 gclass5_0)
		{
			return gclass5_0.method_0() == string_0;
		}

		internal static bool smethod_0(string string_1, string string_2)
		{
			return string_1 == string_2;
		}
	}

	[CompilerGenerated]
	public sealed class Class134
	{
		public string string_0;

		internal bool method_0(GClass5 gclass5_0)
		{
			return gclass5_0.method_0() == string_0;
		}

		internal static bool smethod_0(string string_1, string string_2)
		{
			return string_1 == string_2;
		}
	}

	[Serializable]
	[CompilerGenerated]
	public sealed class Class135
	{
		public static readonly Class135 _003C_003E9 = new Class135();

		public static Converter<ulong, uint> _003C_003E9__36_0;

		public static Func<Class132, GClass5> _003C_003E9__53_0;

		internal uint method_0(ulong ulong_0)
		{
			return (uint)ulong_0;
		}

		internal GClass5 method_1(Class132 class132_0)
		{
			return class132_0.method_3();
		}
	}

	[CompilerGenerated]
	public sealed class Class136 : IEnumerable<Class138>, IEnumerator<Class138>, IDisposable, IEnumerator, IEnumerable
	{
		internal int int_0;

		internal Class138 class138_0;

		internal int int_1;

		internal Class138 class138_1;

		public Class138 class138_2;

		internal Stack<Class138> stack_0;

		internal Class138 class138_3;

		Class138 IEnumerator<Class138>.Current => class138_0;

		object IEnumerator.Current => class138_0;

		public Class136(int int_2)
		{
			int_0 = int_2;
			int_1 = Thread.CurrentThread.ManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		bool IEnumerator.MoveNext()
		{
			int num = int_0;
			if (num != 0)
			{
				goto IL_016e;
			}
			goto IL_01ac;
			IL_016e:
			int num2 = 1158115310;
			goto IL_0173;
			IL_0173:
			Class138 current = default(Class138);
			while (true)
			{
				uint num3;
				int num5;
				switch ((num3 = (uint)(num2 ^ 0x520716B1)) % 9)
				{
				case 8u:
					num2 = ((num != 1) ? (-253412196) : (-1457585482)) ^ (int)(num3 * 347906349);
					continue;
				case 5u:
					stack_0.Push(class138_1);
					goto IL_0079;
				case 2u:
					class138_3 = stack_0.Pop();
					class138_0 = class138_3;
					int_0 = 1;
					num2 = 1927854357;
					continue;
				case 3u:
					int_0 = -1;
					num2 = 1186662636;
					continue;
				default:
				{
					using (List<Class138>.Enumerator enumerator = class138_3.method_6().GetEnumerator())
					{
						while (true)
						{
							IL_0147:
							int num4 = ((!enumerator.MoveNext()) ? 861044791 : 1371860487);
							while (true)
							{
								switch ((num3 = (uint)(num4 ^ 0x520716B1)) % 5)
								{
								case 3u:
									current = enumerator.Current;
									num4 = 905205766;
									continue;
								case 2u:
									stack_0.Push(current);
									num4 = ((int)num3 * -681690614) ^ -1699508943;
									continue;
								case 0u:
									num4 = 1371860487;
									continue;
								default:
									goto end_IL_0116;
								case 4u:
									break;
								case 1u:
									goto end_IL_0116;
								}
								goto IL_0147;
								continue;
								end_IL_0116:
								break;
							}
							break;
						}
					}
					class138_3 = null;
					goto IL_0054;
				}
				case 0u:
					break;
				case 7u:
					goto IL_01ac;
				case 4u:
					return true;
				case 6u:
					{
						return false;
					}
					IL_0054:
					num5 = 452955126;
					goto IL_0059;
					IL_0079:
					if (stack_0.Count <= 0)
					{
						num5 = 1624390508;
						goto IL_0059;
					}
					goto case 2u;
					IL_0059:
					switch ((uint)(num5 ^ 0x520716B1) % 3u)
					{
					case 0u:
						break;
					case 2u:
						goto IL_0079;
					default:
						return false;
					}
					goto IL_0054;
				}
				break;
			}
			goto IL_016e;
			IL_01ac:
			int_0 = -1;
			stack_0 = new Stack<Class138>();
			num2 = 1392490732;
			goto IL_0173;
		}

		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		IEnumerator<Class138> IEnumerable<Class138>.GetEnumerator()
		{
			if (int_0 == -2)
			{
				goto IL_0078;
			}
			goto IL_00aa;
			IL_0078:
			int num = -2023037988;
			goto IL_007d;
			IL_007d:
			Class136 @class = default(Class136);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2009038529)) % 7)
				{
				case 4u:
					num = ((int_1 == Thread.CurrentThread.ManagedThreadId) ? 11253495 : 1793584649) ^ ((int)num2 * -291713645);
					continue;
				case 3u:
					num = (int)((num2 * 1649612954) ^ 0x2ACD604A);
					continue;
				case 2u:
					int_0 = 0;
					num = ((int)num2 * -1509180717) ^ 0x3CF03D06;
					continue;
				case 1u:
					@class = this;
					num = (int)((num2 * 20330) ^ 0x3A6299CF);
					continue;
				case 0u:
					break;
				case 6u:
					goto IL_00aa;
				default:
					@class.class138_1 = class138_2;
					return @class;
				}
				break;
			}
			goto IL_0078;
			IL_00aa:
			@class = new Class136(0);
			num = -205388670;
			goto IL_007d;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<Class138>)this).GetEnumerator();
		}

		internal static Thread smethod_0()
		{
			return Thread.CurrentThread;
		}

		internal static int smethod_1(Thread thread_0)
		{
			return thread_0.ManagedThreadId;
		}

		internal static NotSupportedException smethod_2()
		{
			return new NotSupportedException();
		}
	}

	internal readonly Class154 class154_0;

	internal readonly Random random_0 = new Random();

	internal readonly BinaryWriter binaryWriter_0;

	internal readonly Class131 class131_0;

	public GClass4(Class154 class154_1, Class131 class131_1)
	{
		MemoryStream memoryStream = new MemoryStream();
		class154_1.method_28().Position = 0L;
		class154_1.method_28().smethod_6(memoryStream);
		memoryStream.Position = 0L;
		class154_0 = Class6.smethod_4(memoryStream, bool_0: true, Enum39.const_0);
		binaryWriter_0 = new BinaryWriter(class154_0.method_28());
		class131_0 = class131_1;
	}

	internal void method_0()
	{
		using List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator();
		while (true)
		{
			int num = (enumerator.MoveNext() ? (-453608597) : (-1663277427));
			while (true)
			{
				switch ((uint)(num ^ -1009840942) % 4u)
				{
				case 2u:
					num = -453608597;
					continue;
				case 1u:
				{
					GClass5 current = enumerator.Current;
					current.method_19((Enum41)((uint)current.method_18() & 0xFFFFFF1Fu));
					num = -2031008082;
					continue;
				}
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	internal void method_1()
	{
		Class171.smethod_107(this);
		using List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator();
		Class133 @class = default(Class133);
		string string_ = default(string);
		GClass5 current = default(GClass5);
		while (true)
		{
			int num = (enumerator.MoveNext() ? 563664385 : 36303379);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x788E119F)) % 11)
				{
				case 10u:
					@class.string_0 = Class171.smethod_273(this);
					num = (int)(num2 * 1838718642) ^ -358303055;
					continue;
				case 9u:
					num = 563664385;
					continue;
				case 6u:
					@class.string_0 = Class171.smethod_273(this);
					num = 1105291837;
					continue;
				case 5u:
					@class = new Class133();
					num = ((int)num2 * -678597729) ^ -1595562387;
					continue;
				case 4u:
					num = ((int)num2 * -1816335861) ^ 0x4766E401;
					continue;
				case 3u:
					string_ = Class171.smethod_273(this);
					num = ((int)num2 * -376360851) ^ 0x3689F483;
					continue;
				case 2u:
					current.method_1(string_);
					num = (int)((num2 * 2058160171) ^ 0x5563F4C8);
					continue;
				case 1u:
					current = enumerator.Current;
					num = 1292327678;
					continue;
				case 0u:
					num = ((class154_0.method_8().FindIndex(@class.method_0) == -1) ? 1780673205 : 1432261672);
					continue;
				default:
					return;
				case 7u:
					break;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	internal void method_2()
	{
		uint num = 0u;
		using List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator();
		GClass5 current = default(GClass5);
		byte[] buffer = default(byte[]);
		while (true)
		{
			IL_0219:
			if (enumerator.MoveNext())
			{
				while (true)
				{
					current = enumerator.Current;
					if (current.method_8() == 0)
					{
						break;
					}
					int num2 = 1544548810;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ 0x25ECC005)) % 4)
						{
						case 3u:
							break;
						case 2u:
							num2 = 907036688;
							continue;
						case 1u:
							goto end_IL_003b;
						default:
							goto IL_0072;
						}
						if (num == 0)
						{
							num2 = (int)((num3 * 202937803) ^ 0xC427E20);
							continue;
						}
						goto IL_01fd;
						continue;
						end_IL_003b:
						break;
					}
				}
				continue;
			}
			int num4 = 1324621605;
			goto IL_01cf;
			IL_01fd:
			GClass5 gClass = current;
			gClass.method_9(gClass.method_8() + num);
			num4 = 1626083943;
			goto IL_01cf;
			IL_01cf:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num4 ^ 0x25ECC005)) % 7)
				{
				case 5u:
					binaryWriter_0.Write(buffer);
					num4 = ((int)num3 * -1484368779) ^ 0xEA18D8B;
					continue;
				case 4u:
					class154_0.method_28().Position = current.method_8() + num;
					num4 = (int)((num3 * 350639510) ^ 0x7C9C722C);
					continue;
				case 3u:
					Class171.smethod_437(this, current.method_8(), num);
					num4 = (int)((num3 * 1655536487) ^ 0x6D5AF7EA);
					continue;
				case 2u:
					break;
				default:
					return;
				case 0u:
					goto IL_01fd;
				case 6u:
					goto IL_0219;
				case 1u:
					return;
				}
				break;
			}
			goto IL_01ca;
			IL_0072:
			Stream stream = Class171.smethod_264(class154_0, current.method_8(), (int)(class154_0.method_28().Length - current.method_8()));
			try
			{
				BinaryReader binaryReader = new BinaryReader(stream);
				try
				{
					buffer = binaryReader.ReadBytes((int)stream.Length);
				}
				finally
				{
					if (binaryReader != null)
					{
						while (true)
						{
							IL_00f6:
							int num5 = 1402479545;
							while (true)
							{
								uint num3;
								switch ((num3 = (uint)(num5 ^ 0x25ECC005)) % 3)
								{
								case 1u:
									goto IL_00c3;
								default:
									goto end_IL_00d8;
								case 0u:
									break;
								case 2u:
									goto end_IL_00d8;
								}
								goto IL_00f6;
								IL_00c3:
								((IDisposable)binaryReader).Dispose();
								num5 = ((int)num3 * -1702041105) ^ -321504882;
								continue;
								end_IL_00d8:
								break;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (stream != null)
				{
					while (true)
					{
						IL_0137:
						int num6 = 1093272867;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num6 ^ 0x25ECC005)) % 3)
							{
							case 2u:
								goto IL_0104;
							default:
								goto end_IL_0119;
							case 0u:
								break;
							case 1u:
								goto end_IL_0119;
							}
							goto IL_0137;
							IL_0104:
							((IDisposable)stream).Dispose();
							num6 = ((int)num3 * -1811737642) ^ 0x72B484B8;
							continue;
							end_IL_0119:
							break;
						}
						break;
					}
				}
			}
			num = random_0.smethod_1(5u, 40u) * class154_0.method_6().method_3().imethod_19();
			goto IL_01ca;
			IL_01ca:
			num4 = 137407915;
			goto IL_01cf;
		}
	}

	internal void method_3()
	{
		using List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator();
		int num6 = default(int);
		byte[] array = default(byte[]);
		int num5 = default(int);
		int num7 = default(int);
		Dictionary<long, int> dictionary = default(Dictionary<long, int>);
		while (enumerator.MoveNext())
		{
			while (true)
			{
				GClass5 current = enumerator.Current;
				if (current.method_8() == 0)
				{
					break;
				}
				int num = -19356781;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -109110255)) % 6)
					{
					case 3u:
						num = -676641753;
						continue;
					case 2u:
						break;
					case 1u:
						goto IL_0040;
					case 0u:
						goto IL_0066;
					case 4u:
						goto end_IL_007f;
					default:
						goto IL_00c1;
					}
					if (current.method_2() == 0)
					{
						goto end_IL_00a9;
					}
					num = ((int)num2 * -1780679403) ^ -281568256;
					continue;
					IL_00c1:
					Stream stream = Class171.smethod_264(class154_0, current.method_8(), (int)current.method_6());
					try
					{
						BinaryReader binaryReader = new BinaryReader(stream);
						try
						{
							class154_0.method_28().Position = current.method_8();
							while (true)
							{
								IL_0354:
								int num3 = -1639126865;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -109110255)) % 20)
									{
									case 19u:
										num3 = ((num6 % 16 == 0) ? (-845242480) : (-893234337));
										continue;
									case 18u:
										array = binaryReader.ReadBytes((int)current.method_6());
										num3 = (int)((num2 * 1381950513) ^ 0x444388CE);
										continue;
									case 17u:
										num6++;
										num3 = -1332702427;
										continue;
									case 15u:
										num6 += num5;
										num3 = -716924991;
										continue;
									case 14u:
										num3 = ((array[num6 + num7++] == 204) ? 2021486695 : 871648354) ^ (int)(num2 * 333035286);
										continue;
									case 13u:
										num5 = 0;
										num3 = (int)((num2 * 583957228) ^ 0x395FFAD);
										continue;
									case 12u:
										num3 = ((num6 < array.Length) ? (-1748802662) : (-1307768695));
										continue;
									case 11u:
										num3 = ((num5 >= 6) ? (-837437308) : (-1386627390));
										continue;
									case 10u:
										num3 = (int)((num2 * 605683219) ^ 0x35EEF1F);
										continue;
									case 9u:
										num3 = (((num6 + num5) % 16 != 0) ? 370811512 : 1241103648) ^ ((int)num2 * -46591662);
										continue;
									case 8u:
										num3 = ((num6 + num7 < array.Length) ? (-1956304617) : (-573991706));
										continue;
									case 6u:
										num5++;
										num3 = -1567120999;
										continue;
									case 5u:
										num3 = ((int)num2 * -119532322) ^ 0x4375DA53;
										continue;
									case 4u:
										dictionary = new Dictionary<long, int>();
										num3 = ((int)num2 * -53632179) ^ -1045535388;
										continue;
									case 3u:
										dictionary.Add(current.method_8() + num6, num5);
										num3 = ((int)num2 * -1097686528) ^ -1183954750;
										continue;
									case 2u:
										num7 = 0;
										num3 = (int)(num2 * 593471444) ^ -1429560661;
										continue;
									case 1u:
										num6 = 0;
										num3 = (int)(num2 * 2036463796) ^ -1494963360;
										continue;
									case 0u:
										num5 = 0;
										num3 = (int)(num2 * 215086922) ^ -328038992;
										continue;
									case 7u:
										break;
									default:
									{
										using (Dictionary<long, int>.Enumerator enumerator2 = dictionary.GetEnumerator())
										{
											while (true)
											{
												IL_03cc:
												int num4 = ((!enumerator2.MoveNext()) ? (-1604335847) : (-1588347748));
												while (true)
												{
													switch ((uint)(num4 ^ -109110255) % 4u)
													{
													case 3u:
														num4 = -1588347748;
														continue;
													case 1u:
													{
														KeyValuePair<long, int> current2 = enumerator2.Current;
														Class171.smethod_437(this, current2.Key, current2.Value);
														num4 = -242992493;
														continue;
													}
													default:
														goto end_IL_039e;
													case 2u:
														break;
													case 0u:
														goto end_IL_039e;
													}
													goto IL_03cc;
													continue;
													end_IL_039e:
													break;
												}
												break;
											}
										}
										goto end_IL_02f1;
									}
									}
									goto IL_0354;
									continue;
									end_IL_02f1:
									break;
								}
								break;
							}
						}
						finally
						{
							if (binaryReader != null)
							{
								while (true)
								{
									IL_0421:
									int num8 = -901759074;
									while (true)
									{
										switch ((num2 = (uint)(num8 ^ -109110255)) % 3)
										{
										case 1u:
											goto IL_03ef;
										default:
											goto end_IL_0403;
										case 0u:
											break;
										case 2u:
											goto end_IL_0403;
										}
										goto IL_0421;
										IL_03ef:
										((IDisposable)binaryReader).Dispose();
										num8 = (int)((num2 * 1932739936) ^ 0x6368DF46);
										continue;
										end_IL_0403:
										break;
									}
									break;
								}
							}
						}
					}
					finally
					{
						if (stream != null)
						{
							while (true)
							{
								IL_0460:
								int num9 = -224085062;
								while (true)
								{
									switch ((num2 = (uint)(num9 ^ -109110255)) % 3)
									{
									case 1u:
										goto IL_042e;
									default:
										goto end_IL_0442;
									case 2u:
										break;
									case 0u:
										goto end_IL_0442;
									}
									goto IL_0460;
									IL_042e:
									((IDisposable)stream).Dispose();
									num9 = ((int)num2 * -1582775908) ^ -1994434527;
									continue;
									end_IL_0442:
									break;
								}
								break;
							}
						}
					}
					goto end_IL_00a9;
					IL_0066:
					if (current.method_6() == 0)
					{
						goto end_IL_00a9;
					}
					num = (int)((num2 * 679436267) ^ 0x6E667F81);
					continue;
					IL_0040:
					if ((current.method_18() & Enum41.flag_32) != Enum41.flag_32)
					{
						goto end_IL_00a9;
					}
					num = (int)(num2 * 1457083685) ^ -510083437;
					continue;
					end_IL_007f:
					break;
				}
				continue;
				end_IL_00a9:
				break;
			}
		}
	}

	void IDisposable.Dispose()
	{
		binaryWriter_0.Close();
		class154_0.System_002EIDisposable_002EDispose();
	}

	internal void method_4()
	{
		Class171.smethod_107(this);
		int num27 = default(int);
		bool flag2 = default(bool);
		uint num4 = default(uint);
		bool flag3 = default(bool);
		int num18 = default(int);
		int num26 = default(int);
		GClass5 current = default(GClass5);
		bool flag = default(bool);
		uint num6 = default(uint);
		uint num10 = default(uint);
		uint num25 = default(uint);
		GClass5 current2 = default(GClass5);
		int num22 = default(int);
		uint uint_2 = default(uint);
		uint num21 = default(uint);
		GClass5 gClass3 = default(GClass5);
		Enum41 @enum = default(Enum41);
		int num20 = default(int);
		int num24 = default(int);
		Class134 @class = default(Class134);
		int num23 = default(int);
		int num19 = default(int);
		int num17 = default(int);
		Enum41[] array = default(Enum41[]);
		GClass5 gClass2 = default(GClass5);
		while (true)
		{
			int num = 1700781662;
			while (true)
			{
				int num29;
				int num28;
				int num5;
				int num7;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x33C08BAD)) % 17)
				{
				case 16u:
					num27++;
					num = ((int)num2 * -888574996) ^ 0x2B95ED39;
					continue;
				case 15u:
					if (class154_0.method_6().method_3().imethod_49()[5].method_0() != 0)
					{
						num = (int)((num2 * 940256676) ^ 0x517ADEF6);
						continue;
					}
					goto IL_0053;
				case 14u:
					num29 = (class131_0.method_22() ? 1 : 0);
					goto IL_006a;
				case 13u:
					num = (flag2 ? 1407930181 : 1853675992);
					continue;
				case 12u:
					if (class131_0.method_14())
					{
						num = ((int)num2 * -1103606401) ^ 0x1B27D89F;
						continue;
					}
					goto IL_0053;
				case 10u:
					if (Class171.smethod_19(class154_0))
					{
						num = ((int)num2 * -322095713) ^ 0x105A2165;
						continue;
					}
					goto IL_00eb;
				case 9u:
					num28 = ((class154_0.method_6().method_3().imethod_11() != 0) ? 1 : 0);
					goto IL_00ec;
				case 7u:
					if (class131_0.method_20())
					{
						num = (int)((num2 * 215148946) ^ 0xAF70682);
						continue;
					}
					goto IL_00eb;
				case 6u:
					num27++;
					num = (int)(num2 * 1914934975) ^ -809303872;
					continue;
				case 5u:
					num4 = uint.MaxValue;
					num = ((int)num2 * -121631621) ^ 0x5D76F8F8;
					continue;
				case 4u:
					num = ((!flag3) ? 1989747313 : 656028041);
					continue;
				case 3u:
					num18 = random_0.Next(num27, 10);
					num = 124659322;
					continue;
				case 2u:
					num26 = num18 * 40;
					num = ((int)num2 * -857177961) ^ 0x44E7039C;
					continue;
				case 1u:
					num27++;
					num = ((int)num2 * -594170312) ^ -137884271;
					continue;
				case 0u:
					num5 = ((class154_0.method_6().method_3().imethod_49()[5].method_2() != 0) ? 1 : 0);
					goto IL_0054;
				case 11u:
					break;
				default:
					{
						using (List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator())
						{
							while (true)
							{
								IL_033c:
								int num3 = (enumerator.MoveNext() ? 2091259651 : 1425025869);
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x33C08BAD)) % 7)
									{
									case 5u:
										num4 = current.method_8();
										num3 = ((int)num2 * -317192529) ^ -1365236458;
										continue;
									case 3u:
										current = enumerator.Current;
										num3 = 473729011;
										continue;
									case 2u:
										num3 = 2091259651;
										continue;
									case 1u:
										num3 = ((current.method_8() >= num4) ? 1081434159 : 900867756) ^ ((int)num2 * -742772997);
										continue;
									case 0u:
										num3 = ((current.method_8() == 0) ? (-1035666012) : (-1953652996)) ^ (int)(num2 * 1769095069);
										continue;
									default:
										goto end_IL_02ff;
									case 4u:
										break;
									case 6u:
										goto end_IL_02ff;
									}
									goto IL_033c;
									continue;
									end_IL_02ff:
									break;
								}
								break;
							}
						}
						if (num4 == uint.MaxValue)
						{
							goto IL_0362;
						}
						goto IL_0423;
					}
					IL_0054:
					flag = (byte)num5 != 0;
					num = 1302175311;
					continue;
					IL_0423:
					num6 = (uint)(class154_0.method_4().method_0() + 24 + class154_0.method_6().method_1().method_10() + class154_0.method_8().Count * 40);
					num7 = 1658894166;
					goto IL_03f1;
					IL_03f1:
					while (true)
					{
						switch ((num2 = (uint)(num7 ^ 0x33C08BAD)) % 8)
						{
						case 5u:
							break;
						case 3u:
							num10 = num4;
							num7 = (int)(num2 * 762629663) ^ -1669727896;
							continue;
						case 2u:
							num10 += class154_0.method_6().method_3().imethod_18();
							num25 += class154_0.method_6().method_3().imethod_18();
							num7 = 683902132;
							continue;
						case 1u:
							goto IL_03bb;
						case 0u:
							num25 = num4 - num6;
							num7 = ((int)num2 * -173758990) ^ -1563248652;
							continue;
						case 4u:
							goto IL_0423;
						default:
						{
							Stream stream = Class171.smethod_264(class154_0, num4, (int)(class154_0.method_28().Length - num4));
							byte[] buffer;
							try
							{
								BinaryReader binaryReader = new BinaryReader(stream);
								try
								{
									buffer = binaryReader.ReadBytes((int)stream.Length);
								}
								finally
								{
									if (binaryReader != null)
									{
										while (true)
										{
											IL_04e9:
											int num8 = 1961847450;
											while (true)
											{
												switch ((num2 = (uint)(num8 ^ 0x33C08BAD)) % 3)
												{
												case 2u:
													goto IL_04b6;
												default:
													goto end_IL_04cb;
												case 0u:
													break;
												case 1u:
													goto end_IL_04cb;
												}
												goto IL_04e9;
												IL_04b6:
												((IDisposable)binaryReader).Dispose();
												num8 = (int)((num2 * 188254321) ^ 0x642BD929);
												continue;
												end_IL_04cb:
												break;
											}
											break;
										}
									}
								}
							}
							finally
							{
								if (stream != null)
								{
									while (true)
									{
										IL_052a:
										int num9 = 620001602;
										while (true)
										{
											switch ((num2 = (uint)(num9 ^ 0x33C08BAD)) % 3)
											{
											case 1u:
												goto IL_04f7;
											default:
												goto end_IL_050c;
											case 0u:
												break;
											case 2u:
												goto end_IL_050c;
											}
											goto IL_052a;
											IL_04f7:
											((IDisposable)stream).Dispose();
											num9 = ((int)num2 * -1351621192) ^ -1753545110;
											continue;
											end_IL_050c:
											break;
										}
										break;
									}
								}
							}
							Class171.smethod_377(this, num6, num10 - num6);
							class154_0.method_28().Position = num10;
							binaryWriter_0.Write(buffer);
							uint num11 = 0u;
							uint num12 = 0u;
							using (List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator())
							{
								while (true)
								{
									IL_06ac:
									int num13 = ((!enumerator.MoveNext()) ? 2039500516 : 464671946);
									while (true)
									{
										switch ((num2 = (uint)(num13 ^ 0x33C08BAD)) % 9)
										{
										case 7u:
											num13 = ((current2.method_8() != 0) ? 234427813 : 1083348901) ^ (int)(num2 * 1891451991);
											continue;
										case 6u:
											current2 = enumerator.Current;
											num13 = 738907943;
											continue;
										case 5u:
											num12 = current2.method_4() + current2.method_2();
											num13 = (int)((num2 * 2120417160) ^ 0x2E0E6AA4);
											continue;
										case 4u:
											num13 = 464671946;
											continue;
										case 3u:
											num13 = ((current2.method_8() + current2.method_6() > num11) ? 1750900281 : 1537319204);
											continue;
										case 2u:
											num11 = current2.method_8() + current2.method_6();
											num13 = ((int)num2 * -423315230) ^ -112072843;
											continue;
										case 0u:
										{
											GClass5 gClass = current2;
											gClass.method_9(gClass.method_8() + (num10 - num4));
											num13 = (int)((num2 * 694098504) ^ 0x73F103B3);
											continue;
										}
										default:
											goto end_IL_0666;
										case 8u:
											break;
										case 1u:
											goto end_IL_0666;
										}
										goto IL_06ac;
										continue;
										end_IL_0666:
										break;
									}
									break;
								}
							}
							buffer = new byte[0];
							if (num11 < class154_0.method_28().Length)
							{
								Stream stream2 = Class171.smethod_264(class154_0, num11, (int)(class154_0.method_28().Length - num11));
								try
								{
									BinaryReader binaryReader2 = new BinaryReader(stream2);
									try
									{
										buffer = binaryReader2.ReadBytes((int)stream2.Length);
									}
									finally
									{
										if (binaryReader2 != null)
										{
											while (true)
											{
												IL_0767:
												int num14 = 451787953;
												while (true)
												{
													switch ((num2 = (uint)(num14 ^ 0x33C08BAD)) % 3)
													{
													case 1u:
														goto IL_0734;
													default:
														goto end_IL_0749;
													case 2u:
														break;
													case 0u:
														goto end_IL_0749;
													}
													goto IL_0767;
													IL_0734:
													((IDisposable)binaryReader2).Dispose();
													num14 = ((int)num2 * -470091932) ^ 0x71DA773B;
													continue;
													end_IL_0749:
													break;
												}
												break;
											}
										}
									}
								}
								finally
								{
									if (stream2 != null)
									{
										while (true)
										{
											IL_07a8:
											int num15 = 910361126;
											while (true)
											{
												switch ((num2 = (uint)(num15 ^ 0x33C08BAD)) % 3)
												{
												case 1u:
													goto IL_0775;
												default:
													goto end_IL_078a;
												case 2u:
													break;
												case 0u:
													goto end_IL_078a;
												}
												goto IL_07a8;
												IL_0775:
												((IDisposable)stream2).Dispose();
												num15 = ((int)num2 * -451554289) ^ -92715536;
												continue;
												end_IL_078a:
												break;
											}
											break;
										}
									}
								}
							}
							uint uint_ = class154_0.method_6().method_3().imethod_18();
							while (true)
							{
								int num16 = 1144619223;
								while (true)
								{
									switch ((num2 = (uint)(num16 ^ 0x33C08BAD)) % 61)
									{
									case 60u:
										num12 = Class171.smethod_201(uint_, num12);
										num16 = (int)(num2 * 367251348) ^ -1950492042;
										continue;
									case 59u:
										num22 = -1;
										num16 = 1959509111;
										continue;
									case 58u:
										num16 = (flag ? 1163146677 : 1128883172);
										continue;
									case 56u:
										num16 = (int)(num2 * 621292566) ^ -2128535585;
										continue;
									case 55u:
										num16 = ((num22 != -1) ? (-2127524021) : (-1479533957)) ^ (int)(num2 * 484417033);
										continue;
									case 54u:
										uint_2 = class154_0.method_6().method_3().imethod_19();
										num21 = Class171.smethod_201(uint_, gClass3.method_2());
										num16 = (int)((num2 * 1270102669) ^ 0x49C0FC29);
										continue;
									case 53u:
										Class171.smethod_41(gClass3, this);
										num16 = ((int)num2 * -574424709) ^ -2069619606;
										continue;
									case 52u:
										num16 = (((gClass3.method_18() & @enum) != @enum) ? 794998859 : 1149268239) ^ (int)(num2 * 1251705935);
										continue;
									case 51u:
										num16 = ((num20 == -1) ? (-1247878542) : (-227672996)) ^ (int)(num2 * 1005882264);
										continue;
									case 50u:
										num16 = ((num20 == num24) ? (-810966561) : (-1723036716)) ^ ((int)num2 * -954550044);
										continue;
									case 49u:
										num20 = -1;
										num16 = (int)((num2 * 2081489658) ^ 0x75144B67);
										continue;
									case 48u:
										num16 = ((num22 == num24) ? (-1865077093) : (-1479875606)) ^ (int)(num2 * 1739471165);
										continue;
									case 47u:
										@class = new Class134();
										@class.string_0 = Class171.smethod_273(this);
										num16 = 1122686269;
										continue;
									case 46u:
										num16 = ((num20 != num23) ? 1092104536 : 1437095566) ^ ((int)num2 * -328855172);
										continue;
									case 45u:
										num19++;
										num16 = 941722875;
										continue;
									case 44u:
										Class171.smethod_437(this, gClass3.method_8(), gClass3.method_6());
										num16 = ((!class131_0.method_6()) ? 1151215555 : 501807256) ^ ((int)num2 * -221888343);
										continue;
									case 43u:
										num11 += gClass3.method_6();
										num16 = (int)(num2 * 2095793978) ^ -1793748178;
										continue;
									case 42u:
										num16 = ((!flag3) ? 357485847 : 388408013);
										continue;
									case 41u:
										num16 = ((num17 != num22) ? 1093690205 : 485329588) ^ ((int)num2 * -290249446);
										continue;
									case 39u:
										num16 = ((!flag2) ? 2031812535 : 1913867019);
										continue;
									case 38u:
										class154_0.method_28().Position = num11;
										num16 = (int)((num2 * 1653740554) ^ 0x3729B324);
										continue;
									case 37u:
										num16 = (flag2 ? 629114925 : 1937880682);
										continue;
									case 36u:
										num16 = ((!flag) ? 851169972 : 1172898485);
										continue;
									case 35u:
										num19--;
										num16 = 1907455292;
										continue;
									case 34u:
										num12 += num21;
										num16 = (int)((num2 * 1701229093) ^ 0x40F7487E);
										continue;
									case 33u:
										num16 = ((num19 >= random_0.Next(array.Length)) ? 1779669402 : 542376334);
										continue;
									case 32u:
										num17 = random_0.Next(num18);
										num16 = 1675564108;
										continue;
									case 31u:
										gClass3.method_7(Class171.smethod_201(uint_2, num21));
										array = new Enum41[4]
										{
											Enum41.flag_34,
											Enum41.flag_32,
											Enum41.flag_28,
											Enum41.flag_2
										};
										num16 = (int)((num2 * 1163273393) ^ 0x7A52F083);
										continue;
									case 30u:
										class154_0.method_8().Add(gClass3);
										num16 = 1791964403;
										continue;
									case 29u:
										class154_0.method_6().method_3().imethod_30(Class171.smethod_201(uint_, gClass2.method_4() + gClass2.method_2()));
										num16 = ((int)num2 * -451959105) ^ -1867067043;
										continue;
									case 28u:
										num16 = ((num23 != num24) ? 845927170 : 1920494833) ^ ((int)num2 * -1822570925);
										continue;
									case 27u:
									{
										GClass5 gClass5 = gClass3;
										gClass5.method_19(gClass5.method_18() | @enum);
										num16 = (int)(num2 * 2098551681) ^ -1744938878;
										continue;
									}
									case 26u:
										Class171.smethod_304(this, gClass3);
										num16 = ((int)num2 * -892170871) ^ -213144554;
										continue;
									case 25u:
										num16 = ((num17 != -1) ? 170235289 : 1475806514) ^ ((int)num2 * -1680711900);
										continue;
									case 24u:
										num16 = ((num17 != num24) ? (-1726079721) : (-102368383)) ^ ((int)num2 * -35519616);
										continue;
									case 23u:
										num16 = (flag3 ? 1154136929 : 449346667);
										continue;
									case 22u:
									{
										GClass5 gClass4 = new GClass5();
										gClass4.method_1(@class.string_0);
										gClass4.method_19(Enum41.flag_33);
										gClass4.method_9(num11);
										gClass4.method_3(random_0.smethod_1(10u, 100u) * 50);
										gClass4.method_5(num12);
										gClass3 = gClass4;
										num16 = ((int)num2 * -618124037) ^ 0x53FF03BB;
										continue;
									}
									case 21u:
										method_5(gClass3);
										num16 = (int)((num2 * 57528577) ^ 0x11BB413B);
										continue;
									case 20u:
										@enum = array[random_0.Next(array.Length)];
										num16 = 1985498757;
										continue;
									case 19u:
										num24++;
										num16 = (int)((num2 * 1550255907) ^ 0x66E4867A);
										continue;
									case 18u:
										num22 = random_0.Next(num18);
										num16 = 1959509111;
										continue;
									case 17u:
										num16 = ((num22 != num23) ? 838870409 : 356055443) ^ (int)(num2 * 1696476326);
										continue;
									case 16u:
										num19 = 0;
										num16 = (int)(num2 * 112527079) ^ -51457226;
										continue;
									case 15u:
										num16 = ((num17 != num23) ? 1072225392 : 2058188440) ^ ((int)num2 * -1268259983);
										continue;
									case 14u:
										num16 = ((num24 >= num18) ? 678590307 : 1471617676);
										continue;
									case 13u:
										@class.string_0 = Class171.smethod_273(this);
										num16 = 398907354;
										continue;
									case 12u:
										num16 = ((int)num2 * -1436092143) ^ 0x4A8F0132;
										continue;
									case 11u:
										num23 = random_0.Next(num18);
										num16 = (int)(num2 * 1287992606) ^ -81180371;
										continue;
									case 10u:
										num24 = 0;
										num16 = 1846710994;
										continue;
									case 9u:
										class154_0.method_6().method_1().method_3((ushort)class154_0.method_8().Count);
										num16 = (int)(num2 * 1143816285) ^ -642117510;
										continue;
									case 8u:
										num17 = -1;
										num16 = 1675564108;
										continue;
									case 7u:
										Class171.smethod_284(this, gClass3);
										num16 = (int)((num2 * 315716441) ^ 0x538C72C);
										continue;
									case 6u:
										num16 = ((num22 == num20) ? (-1621794483) : (-1084451384)) ^ (int)(num2 * 1795961946);
										continue;
									case 5u:
										num20 = random_0.Next(num18);
										num16 = 1807791787;
										continue;
									case 4u:
										num16 = ((num17 == num20) ? (-596010506) : (-617819037)) ^ ((int)num2 * -1000215043);
										continue;
									case 3u:
										num16 = (int)((num2 * 187790071) ^ 0x404B8B2A);
										continue;
									case 2u:
										binaryWriter_0.Write(buffer);
										num16 = (int)((num2 * 136726999) ^ 0x3D056838);
										continue;
									case 1u:
										num16 = ((class154_0.method_8().FindIndex(@class.method_0) != -1) ? 1347633148 : 1005348459);
										continue;
									case 0u:
										gClass2 = class154_0.method_8()[class154_0.method_8().Count - 1];
										num16 = (int)((num2 * 881045494) ^ 0x52A7DA28);
										continue;
									default:
										return;
									case 40u:
										break;
									case 57u:
										return;
									}
									break;
								}
							}
						}
						case 7u:
							return;
						}
						break;
						IL_03bb:
						num7 = ((num25 >= num26) ? 1920373387 : 501623231);
					}
					goto IL_0362;
					IL_0362:
					num7 = 909627258;
					goto IL_03f1;
					IL_00eb:
					num28 = 0;
					goto IL_00ec;
					IL_00ec:
					flag2 = (byte)num28 != 0;
					if (Class171.smethod_19(class154_0))
					{
						num = 384846310;
						continue;
					}
					num29 = 0;
					goto IL_006a;
					IL_006a:
					flag3 = (byte)num29 != 0;
					num27 = 1;
					num = ((!flag) ? 1393397153 : 896795711);
					continue;
					IL_0053:
					num5 = 0;
					goto IL_0054;
				}
				break;
			}
		}
	}

	internal void method_5(GClass5 gclass5_0)
	{
		gclass5_0.method_19(Enum41.flag_32 | Enum41.flag_33 | Enum41.flag_34);
		Class157 @class = default(Class157);
		List<uint> list = default(List<uint>);
		uint num8 = default(uint);
		uint num4 = default(uint);
		uint num5 = default(uint);
		uint value2 = default(uint);
		uint num7 = default(uint);
		uint num6 = default(uint);
		uint num9 = default(uint);
		uint value = default(uint);
		while (true)
		{
			int num = 1970095780;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x138898F)) % 25)
				{
				case 24u:
					@class.method_3(24u);
					num = ((int)num2 * -912293507) ^ -1231309659;
					continue;
				case 23u:
					list = new List<uint>();
					num = (int)(num2 * 52339115) ^ -1296347313;
					continue;
				case 22u:
					binaryWriter_0.Write(num8);
					binaryWriter_0.Write(num4);
					binaryWriter_0.Write(num5);
					binaryWriter_0.Write(value2);
					num = (int)((num2 * 715802246) ^ 0x7EEE32C6);
					continue;
				case 21u:
					list.Add(num7);
					class154_0.method_28().Position = gclass5_0.method_8() + (num7 - num6 - gclass5_0.method_4());
					num = 740061908;
					continue;
				case 20u:
					class154_0.method_28().Position = gclass5_0.method_8();
					binaryWriter_0.Write(num9);
					num = (int)((num2 * 777398144) ^ 0x14664C17);
					continue;
				case 19u:
					num4 = (uint)class154_0.method_20().method_4();
					num5 = num6 + gclass5_0.method_4() + 24;
					num = ((int)num2 * -1036243776) ^ -1200259211;
					continue;
				case 18u:
					binaryWriter_0.Write(value);
					num = (int)((num2 * 1117759861) ^ 0x2766A568);
					continue;
				case 17u:
					value = class154_0.method_20().method_10();
					num = ((int)num2 * -1058305703) ^ 0x709EE8F1;
					continue;
				case 16u:
					class154_0.method_28().Position = gclass5_0.method_8() + (num5 - num6 - gclass5_0.method_4());
					num = (int)(num2 * 1647551760) ^ -908302058;
					continue;
				case 15u:
					num9 = (uint)class154_0.method_20().method_0();
					num = ((int)num2 * -1719106579) ^ 0x7D41A944;
					continue;
				case 13u:
					binaryWriter_0.Write(new byte[6] { 144, 144, 144, 194, 12, 0 });
					num = (int)((num2 * 784874002) ^ 0x2477F8BD);
					continue;
				case 12u:
					num = ((class154_0.method_20() != null) ? (-1773933810) : (-2034683587)) ^ ((int)num2 * -2078760204);
					continue;
				case 11u:
					num9 = num6 + gclass5_0.method_4() + 24;
					num = 422863214;
					continue;
				case 10u:
					value2 = class154_0.method_20().method_8();
					num = (int)(num2 * 1711383335) ^ -1931609895;
					continue;
				case 9u:
					num8 = (uint)class154_0.method_20().method_2();
					num = ((int)num2 * -2143889560) ^ 0x1BD13621;
					continue;
				case 8u:
					num8 = num9 + random_0.smethod_1(1u, 5u) * 4;
					num = ((int)num2 * -1221837672) ^ 0x7D001CA7;
					continue;
				case 7u:
					@class.method_1(gclass5_0.method_4());
					num = ((int)num2 * -1629199253) ^ 0x1C2947FD;
					continue;
				case 5u:
					num6 = (uint)class154_0.method_6().method_3().imethod_17();
					num7 = num6 + gclass5_0.method_4();
					num = ((int)num2 * -237610855) ^ 0x7870A076;
					continue;
				case 4u:
					list.AddRange(Array.ConvertAll(class154_0.method_20().list_0.ToArray(), (ulong ulong_0) => (uint)ulong_0));
					num = 888244439;
					continue;
				case 3u:
					num = ((int)num2 * -398484809) ^ 0x412E2DFE;
					continue;
				case 2u:
					num4 = num8 + random_0.smethod_1(1u, 5u) * 4;
					num5 = num4 + random_0.smethod_1(1u, 5u) * 4;
					num = (int)((num2 * 904938281) ^ 0x35C1768F);
					continue;
				case 1u:
					Class171.smethod_437(this, gclass5_0.method_8(), gclass5_0.method_6());
					@class = class154_0.method_6().method_3().imethod_49()[9];
					num = ((int)num2 * -1592922910) ^ 0x543D6DC0;
					continue;
				case 0u:
					value = 0u;
					value2 = 0u;
					num7 = num5 + random_0.smethod_1(2u, 5u) * 4;
					num = (int)((num2 * 1056199803) ^ 0x1F897406);
					continue;
				case 6u:
					break;
				default:
				{
					using (List<uint>.Enumerator enumerator = list.GetEnumerator())
					{
						while (true)
						{
							IL_04e5:
							int num3 = (enumerator.MoveNext() ? 1601919713 : 118745939);
							while (true)
							{
								switch ((uint)(num3 ^ 0x138898F) % 4u)
								{
								case 3u:
									num3 = 1601919713;
									continue;
								case 2u:
								{
									uint current = enumerator.Current;
									binaryWriter_0.Write(current);
									num3 = 887995814;
									continue;
								}
								default:
									goto end_IL_04b7;
								case 1u:
									break;
								case 0u:
									goto end_IL_04b7;
								}
								goto IL_04e5;
								continue;
								end_IL_04b7:
								break;
							}
							break;
						}
					}
					binaryWriter_0.Write(0);
					return;
				}
				}
				break;
			}
		}
	}

	internal static T smethod_0<T>(T gparam_0, Delegate48<T> delegate48_0)
	{
		T result = delegate48_0();
		while (true)
		{
			int num = ((!result.Equals(gparam_0)) ? 361787660 : 1859486466);
			while (true)
			{
				switch ((uint)(num ^ 0xF376D85) % 4u)
				{
				case 3u:
					result = delegate48_0();
					num = 1519666161;
					continue;
				case 2u:
					num = 1859486466;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	internal List<Class132> method_6()
	{
		List<Class132> list = new List<Class132>();
		uint num9 = default(uint);
		uint num7 = default(uint);
		uint num6 = default(uint);
		uint num4 = default(uint);
		Class132 @class = default(Class132);
		uint num5 = default(uint);
		while (true)
		{
			int num = 533663446;
			while (true)
			{
				int num8;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x53C4D7B5)) % 7)
				{
				case 6u:
					if (!Class171.smethod_19(class154_0))
					{
						num = (int)(num2 * 736127035) ^ -1260354819;
						continue;
					}
					num8 = (int)(random_0.smethod_1(1u, num9 + 1) * class154_0.method_6().method_3().imethod_19());
					goto IL_0050;
				case 5u:
					num7 = 0u;
					num = (int)(num2 * 2022289533) ^ -343916685;
					continue;
				case 3u:
					num6 = class154_0.method_8()[0].method_4() + num4;
					num = ((int)num2 * -639180834) ^ 0x250F37A;
					continue;
				case 2u:
					num8 = 0;
					goto IL_0050;
				case 1u:
					num9 = random_0.smethod_1(1u, 10u);
					num4 = num9 * class154_0.method_6().method_3().imethod_18();
					num = (int)(num2 * 1240415969) ^ -22316013;
					continue;
				case 4u:
					break;
				default:
					{
						using (List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator())
						{
							while (true)
							{
								IL_0231:
								int num3 = ((!enumerator.MoveNext()) ? 241808760 : 346687121);
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x53C4D7B5)) % 7)
									{
									case 6u:
										num3 = 346687121;
										continue;
									case 5u:
									{
										GClass5 gClass = @class.method_3();
										gClass.method_9(gClass.method_8() + num7);
										num3 = ((int)num2 * -1418474868) ^ -1506869931;
										continue;
									}
									case 4u:
										list.Add(@class);
										num3 = 1491945630;
										continue;
									case 3u:
										num7 += num5;
										num3 = ((int)num2 * -1684760583) ^ -284635667;
										continue;
									case 1u:
									{
										GClass5 current = enumerator.Current;
										@class = new Class132(current, num4, num5);
										@class.method_3().method_5(num6);
										uint uint_ = num6 + @class.method_3().method_2();
										uint uint_2 = class154_0.method_6().method_3().imethod_18();
										num6 = Class171.smethod_201(uint_2, uint_);
										num3 = ((current.method_6() != 0) ? 2138851466 : 2019712025);
										continue;
									}
									default:
										goto end_IL_01f4;
									case 2u:
										break;
									case 0u:
										goto end_IL_01f4;
									}
									goto IL_0231;
									continue;
									end_IL_01f4:
									break;
								}
								break;
							}
						}
						GClass5 gClass2 = new GClass5();
						gClass2.method_19(Enum41.flag_33);
						gClass2.method_5(class154_0.method_8()[0].method_4());
						gClass2.method_3(num4);
						gClass2.method_1(Class171.smethod_273(this));
						list.Insert(0, new Class132(gClass2, 0u, 0u));
						return list;
					}
					IL_0050:
					num5 = (uint)num8;
					num = 145975557;
					continue;
				}
				break;
			}
		}
	}

	internal void method_7(List<Class132> list_0)
	{
		if (class154_0.method_10() == null)
		{
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(class154_0.method_28());
		class154_0.method_28().Position = Class171.smethod_135(class154_0, class154_0.method_6().method_3().imethod_49()[1].method_0());
		using List<Class160>.Enumerator enumerator = class154_0.method_10().list_0.GetEnumerator();
		Class160 current = default(Class160);
		long position = default(long);
		Class164 current2 = default(Class164);
		Class164 current3 = default(Class164);
		while (true)
		{
			IL_056a:
			if (enumerator.MoveNext())
			{
				while (true)
				{
					current = enumerator.Current;
					int num = -1437391201;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -851691805)) % 7)
						{
						case 6u:
							num = -837280797;
							continue;
						case 5u:
							binaryWriter.Write(Class171.smethod_33(list_0, current.method_6()));
							position = class154_0.method_28().Position;
							class154_0.method_28().Position = Class171.smethod_135(class154_0, current.method_0());
							num = ((int)num2 * -857508609) ^ -1702002374;
							continue;
						case 2u:
							binaryWriter.Write(Class171.smethod_33(list_0, current.method_0()));
							num = ((int)num2 * -2035643783) ^ 0x6CAA37E6;
							continue;
						case 1u:
							class154_0.method_28().Position += 8L;
							num = (int)(num2 * 1246749018) ^ -1762608560;
							continue;
						case 0u:
							binaryWriter.Write(Class171.smethod_33(list_0, current.method_4()));
							num = ((int)num2 * -376813912) ^ -19342247;
							continue;
						case 3u:
							break;
						default:
							goto end_IL_0177;
						}
						break;
					}
					continue;
					end_IL_0177:
					break;
				}
				using (List<Class164>.Enumerator enumerator2 = current.method_8().GetEnumerator())
				{
					while (true)
					{
						IL_02ff:
						int num3 = (enumerator2.MoveNext() ? (-525615418) : (-813822703));
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num3 ^ -851691805)) % 10)
							{
							case 9u:
								current2 = enumerator2.Current;
								num3 = -2061373852;
								continue;
							case 8u:
								num3 = (int)((num2 * 947452163) ^ 0x5358F716);
								continue;
							case 7u:
								num3 = (current2.method_7() ? (-1529020143) : (-1575513446)) ^ ((int)num2 * -551667859);
								continue;
							case 6u:
								num3 = (Class171.smethod_19(class154_0) ? (-752147151) : (-236609310));
								continue;
							case 5u:
								class154_0.method_28().Position += (Class171.smethod_19(class154_0) ? 4 : 8);
								num3 = -2129259869;
								continue;
							case 3u:
							{
								ulong num4;
								current2.method_1(num4 = Class171.smethod_33(list_0, (uint)current2.method_0()));
								binaryWriter.Write(num4);
								num3 = -1936172074;
								continue;
							}
							case 2u:
							{
								ulong num4;
								current2.method_1(num4 = Class171.smethod_33(list_0, (uint)current2.method_0()));
								binaryWriter.Write((uint)num4);
								num3 = ((int)num2 * -1153726936) ^ 0x33F95F06;
								continue;
							}
							case 0u:
								num3 = -525615418;
								continue;
							default:
								goto end_IL_02b5;
							case 1u:
								break;
							case 4u:
								goto end_IL_02b5;
							}
							goto IL_02ff;
							continue;
							end_IL_02b5:
							break;
						}
						break;
					}
				}
				if (current.method_6() != current.method_0())
				{
					class154_0.method_28().Position = Class171.smethod_135(class154_0, current.method_6());
					using List<Class164>.Enumerator enumerator2 = current.method_10().GetEnumerator();
					while (true)
					{
						IL_04c5:
						int num5 = (enumerator2.MoveNext() ? (-232663685) : (-226771341));
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num5 ^ -851691805)) % 10)
							{
							case 9u:
							{
								ulong num4;
								current3.method_1(num4 = Class171.smethod_33(list_0, (uint)current3.method_0()));
								binaryWriter.Write((uint)num4);
								num5 = ((int)num2 * -701778638) ^ 0x68B0BDC2;
								continue;
							}
							case 8u:
								num5 = ((!Class171.smethod_19(class154_0)) ? (-997255661) : (-153582566));
								continue;
							case 7u:
								num5 = -232663685;
								continue;
							case 6u:
								current3 = enumerator2.Current;
								num5 = (current3.method_7() ? (-1299850840) : (-51132467));
								continue;
							case 3u:
								num5 = ((int)num2 * -299343990) ^ -1864051312;
								continue;
							case 2u:
								num5 = (int)(num2 * 1279736494) ^ -1912259530;
								continue;
							case 1u:
								class154_0.method_28().Position += (Class171.smethod_19(class154_0) ? 4 : 8);
								num5 = -382573913;
								continue;
							case 0u:
							{
								ulong num4;
								current3.method_1(num4 = Class171.smethod_33(list_0, (uint)current3.method_0()));
								binaryWriter.Write(num4);
								num5 = -1045065202;
								continue;
							}
							default:
								goto end_IL_047b;
							case 5u:
								break;
							case 4u:
								goto end_IL_047b;
							}
							goto IL_04c5;
							continue;
							end_IL_047b:
							break;
						}
						break;
					}
				}
				current.method_1(Class171.smethod_33(list_0, current.method_0()));
				current.method_5(Class171.smethod_33(list_0, current.method_4()));
				goto IL_055c;
			}
			int num6 = -846042793;
			goto IL_053a;
			IL_053a:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num6 ^ -851691805)) % 4)
				{
				case 1u:
					current.method_7(Class171.smethod_33(list_0, current.method_6()));
					class154_0.method_28().Position = position;
					num6 = (int)(num2 * 1395445963) ^ -161151034;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					goto IL_056a;
				case 0u:
					return;
				}
				break;
			}
			goto IL_055c;
			IL_055c:
			num6 = -663548978;
			goto IL_053a;
		}
	}

	internal void method_8(List<Class132> list_0)
	{
		if (class154_0.method_25() == null)
		{
			goto IL_000d;
		}
		goto IL_0034;
		IL_000d:
		int num = -1998457241;
		goto IL_0012;
		IL_0012:
		BinaryWriter binaryWriter2 = default(BinaryWriter);
		switch ((uint)(num ^ -1156633631) % 4u)
		{
		case 0u:
			break;
		case 1u:
			goto IL_0034;
		case 2u:
			return;
		default:
		{
			class154_0.method_28().Position = Class171.smethod_135(class154_0, class154_0.method_6().method_3().imethod_49()[3].method_0());
			using List<Class140>.Enumerator enumerator = class154_0.method_25().list_0.GetEnumerator();
			Class140 current = default(Class140);
			while (true)
			{
				int num2 = (enumerator.MoveNext() ? (-1289405756) : (-1579988937));
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ -1156633631)) % 7)
					{
					case 6u:
						num2 = -1289405756;
						continue;
					case 4u:
					{
						BinaryWriter binaryWriter4 = binaryWriter2;
						uint value;
						current.method_3(value = Class171.smethod_33(list_0, current.method_2()));
						binaryWriter4.Write(value);
						num2 = (int)(num3 * 29284499) ^ -1487425163;
						continue;
					}
					case 2u:
					{
						BinaryWriter binaryWriter3 = binaryWriter2;
						uint value;
						current.method_1(value = Class171.smethod_33(list_0, current.method_0()));
						binaryWriter3.Write(value);
						num2 = (int)((num3 * 144062653) ^ 0x124DA656);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						num2 = -263573548;
						continue;
					case 0u:
					{
						BinaryWriter binaryWriter = binaryWriter2;
						uint value;
						current.method_5(value = Class171.smethod_33(list_0, current.method_4()));
						binaryWriter.Write(value);
						num2 = (int)((num3 * 654510067) ^ 0x4C4DEFE);
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 5u:
						return;
					}
					break;
				}
			}
		}
		}
		goto IL_000d;
		IL_0034:
		binaryWriter2 = new BinaryWriter(class154_0.method_28());
		num = -1822981006;
		goto IL_0012;
	}

	internal void method_9(List<Class132> list_0)
	{
		if (class154_0.method_16() == null)
		{
			goto IL_0070;
		}
		goto IL_009f;
		IL_0070:
		int num = -1033034339;
		goto IL_0075;
		IL_0075:
		long num3 = default(long);
		ulong num5 = default(ulong);
		BinaryWriter binaryWriter = default(BinaryWriter);
		Class144 current2 = default(Class144);
		uint num6 = default(uint);
		ulong num7 = default(ulong);
		BinaryReader binaryReader = default(BinaryReader);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1299608026)) % 6)
			{
			case 4u:
				num3 = Class171.smethod_135(class154_0, class154_0.method_6().method_3().imethod_49()[5].method_0());
				num = (int)(num2 * 161890499) ^ -914632068;
				continue;
			case 2u:
				num5 = class154_0.method_6().method_3().imethod_17();
				num = ((int)num2 * -827749719) ^ 0x7920B27;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_009f;
			default:
			{
				using List<Class145>.Enumerator enumerator = class154_0.method_16().list_0.GetEnumerator();
				while (true)
				{
					if (enumerator.MoveNext())
					{
						Class145 current = enumerator.Current;
						class154_0.method_28().Position = num3;
						binaryWriter.Write(Class171.smethod_33(list_0, current.method_0()));
						using (List<Class144>.Enumerator enumerator2 = current.list_0.GetEnumerator())
						{
							while (true)
							{
								IL_0304:
								int num4 = (enumerator2.MoveNext() ? (-572974935) : (-2029392844));
								while (true)
								{
									switch ((num2 = (uint)(num4 ^ -1299608026)) % 12)
									{
									case 10u:
										num4 = ((current2.method_2() == GEnum0.Dir64) ? (-204465497) : (-848775079));
										continue;
									case 9u:
										binaryWriter.Write((uint)(int)num5 + Class171.smethod_33(list_0, num6 - (uint)(int)num5));
										num4 = (int)((num2 * 1131721546) ^ 0x350BEB18);
										continue;
									case 8u:
										num4 = ((int)num2 * -211135219) ^ 0x332BB0DD;
										continue;
									case 7u:
										current2 = enumerator2.Current;
										num4 = -1352949080;
										continue;
									case 5u:
										num7 = binaryReader.ReadUInt64();
										class154_0.method_28().Position -= 8L;
										num4 = (int)((num2 * 1012304616) ^ 0x517823BB);
										continue;
									case 4u:
										num6 = binaryReader.ReadUInt32();
										class154_0.method_28().Position -= 4L;
										num4 = ((int)num2 * -427476099) ^ -2117506253;
										continue;
									case 3u:
										num4 = -572974935;
										continue;
									case 2u:
										class154_0.method_28().Position = Class171.smethod_135(class154_0, current.method_0() + current2.method_0());
										num4 = ((int)num2 * -37649823) ^ 0x49CF5D8C;
										continue;
									case 1u:
										binaryWriter.Write(num5 + Class171.smethod_33(list_0, (uint)(num7 - num5)));
										num4 = ((int)num2 * -1411925062) ^ -106864037;
										continue;
									case 0u:
										num4 = ((current2.method_2() != GEnum0.HighLow) ? 813692528 : 1878221062) ^ (int)(num2 * 1736278061);
										continue;
									default:
										goto end_IL_02b2;
									case 11u:
										break;
									case 6u:
										goto end_IL_02b2;
									}
									goto IL_0304;
									continue;
									end_IL_02b2:
									break;
								}
								break;
							}
						}
						current.method_1(Class171.smethod_33(list_0, current.method_0()));
						num3 += current.method_2();
						goto IL_0341;
					}
					int num8 = -1950432886;
					goto IL_0346;
					IL_0346:
					switch ((uint)(num8 ^ -1299608026) % 3u)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						continue;
					case 0u:
						return;
					}
					goto IL_0341;
					IL_0341:
					num8 = -1053152223;
					goto IL_0346;
				}
			}
			case 5u:
				return;
			}
			break;
		}
		goto IL_0070;
		IL_009f:
		binaryReader = new BinaryReader(class154_0.method_28());
		binaryWriter = new BinaryWriter(class154_0.method_28());
		num = -1185638126;
		goto IL_0075;
	}

	[CompilerGenerated]
	internal int method_10()
	{
		return random_0.Next(53);
	}

	[CompilerGenerated]
	internal uint method_11()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_12()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_13()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_14()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_15()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_16()
	{
		return random_0.smethod_0();
	}

	[CompilerGenerated]
	internal uint method_17()
	{
		return random_0.smethod_0();
	}

	internal static Random smethod_1()
	{
		return new Random();
	}

	internal static MemoryStream smethod_2()
	{
		return new MemoryStream();
	}

	internal static void smethod_3(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	internal static BinaryWriter smethod_4(Stream stream_0)
	{
		return new BinaryWriter(stream_0);
	}

	internal static long smethod_5(Stream stream_0)
	{
		return stream_0.Length;
	}

	internal static BinaryReader smethod_6(Stream stream_0)
	{
		return new BinaryReader(stream_0);
	}

	internal static byte[] smethod_7(BinaryReader binaryReader_0, int int_0)
	{
		return binaryReader_0.ReadBytes(int_0);
	}

	internal static void smethod_8(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static void smethod_9(BinaryWriter binaryWriter_1, byte[] byte_0)
	{
		binaryWriter_1.Write(byte_0);
	}

	internal static void smethod_10(BinaryWriter binaryWriter_1)
	{
		binaryWriter_1.Close();
	}

	internal static int smethod_11(Random random_1, int int_0, int int_1)
	{
		return random_1.Next(int_0, int_1);
	}

	internal static int smethod_12(Random random_1, int int_0)
	{
		return random_1.Next(int_0);
	}

	internal static void smethod_13(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	internal static void smethod_14(BinaryWriter binaryWriter_1, uint uint_0)
	{
		binaryWriter_1.Write(uint_0);
	}

	internal static void smethod_15(BinaryWriter binaryWriter_1, int int_0)
	{
		binaryWriter_1.Write(int_0);
	}

	internal static long smethod_16(Stream stream_0)
	{
		return stream_0.Position;
	}

	internal static void smethod_17(BinaryWriter binaryWriter_1, ulong ulong_0)
	{
		binaryWriter_1.Write(ulong_0);
	}

	internal static uint smethod_18(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static ulong smethod_19(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt64();
	}
}
