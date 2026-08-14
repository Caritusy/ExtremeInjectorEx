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
		private uint uint_0;

		[CompilerGenerated]
		private uint uint_1;

		[CompilerGenerated]
		private GClass5 gclass5_0;

		[CompilerGenerated]
		private GClass5 gclass5_1;

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
					{
						int num7;
						if (method_3().method_6() != 0)
						{
							num = 1120781505;
							num7 = 1120781505;
						}
						else
						{
							num = 697322040;
							num7 = 697322040;
						}
						continue;
					}
					case 6u:
					{
						int num5;
						int num6;
						if (method_3().method_2() == 0)
						{
							num5 = 1999603262;
							num6 = 1999603262;
						}
						else
						{
							num5 = 138517418;
							num6 = 138517418;
						}
						num = num5 ^ (int)(num2 * 1707315408);
						continue;
					}
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
					{
						int num3;
						int num4;
						if (method_3().method_6() != 0)
						{
							num3 = 1386658269;
							num4 = 1386658269;
						}
						else
						{
							num3 = 472553584;
							num4 = 472553584;
						}
						num = num3 ^ (int)(num2 * 154208106);
						continue;
					}
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
	}

	[CompilerGenerated]
	public sealed class Class134
	{
		public string string_0;

		internal bool method_0(GClass5 gclass5_0)
		{
			return gclass5_0.method_0() == string_0;
		}
	}

	[Serializable]
	[CompilerGenerated]
	public sealed class Class135
	{
		public static readonly Class135 field_07DA = new Class135();

		public static Converter<ulong, uint> field_07DB;

		public static Func<Class132, GClass5> field_07DC;

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
	public sealed class Class136 : IEnumerable<Class138>, IEnumerator<Class138>, IEnumerable, IEnumerator, IDisposable
	{
		private int int_0;

		private Class138 class138_0;

		private int int_1;

		private Class138 class138_1;

		public Class138 class138_2;

		private Stack<Class138> stack_0;

		private Class138 class138_3;

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
				int num6;
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x520716B1)) % 9)
				{
				case 8u:
				{
					int num7;
					int num8;
					if (num == 1)
					{
						num7 = -1457585482;
						num8 = -1457585482;
					}
					else
					{
						num7 = -253412196;
						num8 = -253412196;
					}
					num2 = num7 ^ (int)(num3 * 347906349);
					continue;
				}
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
							int num4;
							int num5;
							if (enumerator.MoveNext())
							{
								num4 = 1371860487;
								num5 = 1371860487;
							}
							else
							{
								num4 = 861044791;
								num5 = 861044791;
							}
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
					num6 = 452955126;
					goto IL_0059;
					IL_0079:
					if (stack_0.Count <= 0)
					{
						num6 = 1624390508;
						goto IL_0059;
					}
					goto case 2u;
					IL_0059:
					switch ((num3 = (uint)(num6 ^ 0x520716B1)) % 3)
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
				{
					int num3;
					int num4;
					if (int_1 != Thread.CurrentThread.ManagedThreadId)
					{
						num3 = 1793584649;
						num4 = 1793584649;
					}
					else
					{
						num3 = 11253495;
						num4 = 11253495;
					}
					num = num3 ^ ((int)num2 * -291713645);
					continue;
				}
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
		class154_0 = Class6.smethod_2(memoryStream, bool_0: true, Enum39.const_0);
		binaryWriter_0 = new BinaryWriter(class154_0.method_28());
		class131_0 = class131_1;
	}

	internal void method_0()
	{
		using List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = -1663277427;
				num2 = -1663277427;
			}
			else
			{
				num = -453608597;
				num2 = -453608597;
			}
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
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = 36303379;
				num2 = 36303379;
			}
			else
			{
				num = 563664385;
				num2 = 563664385;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num ^ 0x788E119F)) % 11)
				{
				case 10u:
					@class.string_0 = Class171.smethod_267(this);
					num = (int)(num3 * 1838718642) ^ -358303055;
					continue;
				case 9u:
					num = 563664385;
					continue;
				case 6u:
					@class.string_0 = Class171.smethod_267(this);
					num = 1105291837;
					continue;
				case 5u:
					@class = new Class133();
					num = ((int)num3 * -678597729) ^ -1595562387;
					continue;
				case 4u:
					num = ((int)num3 * -1816335861) ^ 0x4766E401;
					continue;
				case 3u:
					string_ = Class171.smethod_267(this);
					num = ((int)num3 * -376360851) ^ 0x3689F483;
					continue;
				case 2u:
					current.method_1(string_);
					num = (int)((num3 * 2058160171) ^ 0x5563F4C8);
					continue;
				case 1u:
					current = enumerator.Current;
					num = 1292327678;
					continue;
				case 0u:
				{
					int num4;
					if (class154_0.method_8().FindIndex(@class.method_0) != -1)
					{
						num = 1432261672;
						num4 = 1432261672;
					}
					else
					{
						num = 1780673205;
						num4 = 1780673205;
					}
					continue;
				}
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
					Class171.smethod_428(this, (long)current.method_8(), (long)num);
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
			Stream stream = Class171.smethod_258(class154_0, (long)current.method_8(), (int)(class154_0.method_28().Length - current.method_8()));
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
		int num7 = default(int);
		byte[] array = default(byte[]);
		int num6 = default(int);
		int num8 = default(int);
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
					Stream stream = Class171.smethod_258(class154_0, (long)current.method_8(), (int)current.method_6());
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
									{
										int num16;
										if (num7 % 16 != 0)
										{
											num3 = -893234337;
											num16 = -893234337;
										}
										else
										{
											num3 = -845242480;
											num16 = -845242480;
										}
										continue;
									}
									case 18u:
										array = binaryReader.ReadBytes((int)current.method_6());
										num3 = (int)((num2 * 1381950513) ^ 0x444388CE);
										continue;
									case 17u:
										num7++;
										num3 = -1332702427;
										continue;
									case 15u:
										num7 += num6;
										num3 = -716924991;
										continue;
									case 14u:
									{
										int num13;
										int num14;
										if (array[num7 + num8++] != 204)
										{
											num13 = 871648354;
											num14 = 871648354;
										}
										else
										{
											num13 = 2021486695;
											num14 = 2021486695;
										}
										num3 = num13 ^ (int)(num2 * 333035286);
										continue;
									}
									case 13u:
										num6 = 0;
										num3 = (int)((num2 * 583957228) ^ 0x395FFAD);
										continue;
									case 12u:
									{
										int num10;
										if (num7 >= array.Length)
										{
											num3 = -1307768695;
											num10 = -1307768695;
										}
										else
										{
											num3 = -1748802662;
											num10 = -1748802662;
										}
										continue;
									}
									case 11u:
									{
										int num15;
										if (num6 < 6)
										{
											num3 = -1386627390;
											num15 = -1386627390;
										}
										else
										{
											num3 = -837437308;
											num15 = -837437308;
										}
										continue;
									}
									case 10u:
										num3 = (int)((num2 * 605683219) ^ 0x35EEF1F);
										continue;
									case 9u:
									{
										int num11;
										int num12;
										if ((num7 + num6) % 16 == 0)
										{
											num11 = 1241103648;
											num12 = 1241103648;
										}
										else
										{
											num11 = 370811512;
											num12 = 370811512;
										}
										num3 = num11 ^ ((int)num2 * -46591662);
										continue;
									}
									case 8u:
									{
										int num9;
										if (num7 + num8 >= array.Length)
										{
											num3 = -573991706;
											num9 = -573991706;
										}
										else
										{
											num3 = -1956304617;
											num9 = -1956304617;
										}
										continue;
									}
									case 6u:
										num6++;
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
										dictionary.Add(current.method_8() + num7, num6);
										num3 = ((int)num2 * -1097686528) ^ -1183954750;
										continue;
									case 2u:
										num8 = 0;
										num3 = (int)(num2 * 593471444) ^ -1429560661;
										continue;
									case 1u:
										num7 = 0;
										num3 = (int)(num2 * 2036463796) ^ -1494963360;
										continue;
									case 0u:
										num6 = 0;
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
												int num4;
												int num5;
												if (enumerator2.MoveNext())
												{
													num4 = -1588347748;
													num5 = -1588347748;
												}
												else
												{
													num4 = -1604335847;
													num5 = -1604335847;
												}
												while (true)
												{
													switch ((num2 = (uint)(num4 ^ -109110255)) % 4)
													{
													case 3u:
														num4 = -1588347748;
														continue;
													case 1u:
													{
														KeyValuePair<long, int> current2 = enumerator2.Current;
														Class171.smethod_428(this, current2.Key, (long)current2.Value);
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
									int num17 = -901759074;
									while (true)
									{
										switch ((num2 = (uint)(num17 ^ -109110255)) % 3)
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
										num17 = (int)((num2 * 1932739936) ^ 0x6368DF46);
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
								int num18 = -224085062;
								while (true)
								{
									switch ((num2 = (uint)(num18 ^ -109110255)) % 3)
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
									num18 = ((int)num2 * -1582775908) ^ -1994434527;
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
		int num76 = default(int);
		bool flag2 = default(bool);
		uint num7 = default(uint);
		bool flag3 = default(bool);
		int num28 = default(int);
		int num74 = default(int);
		GClass5 current = default(GClass5);
		bool flag = default(bool);
		uint num11 = default(uint);
		uint num15 = default(uint);
		uint num73 = default(uint);
		GClass5 current2 = default(GClass5);
		int num35 = default(int);
		uint uint_2 = default(uint);
		uint num34 = default(uint);
		GClass5 gClass3 = default(GClass5);
		Enum41 @enum = default(Enum41);
		int num31 = default(int);
		int num42 = default(int);
		Class134 @class = default(Class134);
		int num39 = default(int);
		int num29 = default(int);
		int num27 = default(int);
		Enum41[] array = default(Enum41[]);
		GClass5 gClass2 = default(GClass5);
		while (true)
		{
			int num = 1700781662;
			while (true)
			{
				int num80;
				int num79;
				int num10;
				int num12;
				uint num2;
				int num81;
				switch ((num2 = (uint)(num ^ 0x33C08BAD)) % 17)
				{
				case 16u:
					num76++;
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
					num80 = (class131_0.method_22() ? 1 : 0);
					goto IL_006a;
				case 13u:
				{
					int num78;
					if (!flag2)
					{
						num = 1853675992;
						num78 = 1853675992;
					}
					else
					{
						num = 1407930181;
						num78 = 1407930181;
					}
					continue;
				}
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
					num79 = ((class154_0.method_6().method_3().imethod_11() != 0) ? 1 : 0);
					goto IL_00ec;
				case 7u:
					if (class131_0.method_20())
					{
						num = (int)((num2 * 215148946) ^ 0xAF70682);
						continue;
					}
					goto IL_00eb;
				case 6u:
					num76++;
					num = (int)(num2 * 1914934975) ^ -809303872;
					continue;
				case 5u:
					num7 = uint.MaxValue;
					num = ((int)num2 * -121631621) ^ 0x5D76F8F8;
					continue;
				case 4u:
				{
					int num77;
					if (flag3)
					{
						num = 656028041;
						num77 = 656028041;
					}
					else
					{
						num = 1989747313;
						num77 = 1989747313;
					}
					continue;
				}
				case 3u:
					num28 = random_0.Next(num76, 10);
					num = 124659322;
					continue;
				case 2u:
					num74 = num28 * 40;
					num = ((int)num2 * -857177961) ^ 0x44E7039C;
					continue;
				case 1u:
					num76++;
					num = ((int)num2 * -594170312) ^ -137884271;
					continue;
				case 0u:
					num10 = ((class154_0.method_6().method_3().imethod_49()[5].method_2() != 0) ? 1 : 0);
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
								int num3;
								int num4;
								if (!enumerator.MoveNext())
								{
									num3 = 1425025869;
									num4 = 1425025869;
								}
								else
								{
									num3 = 2091259651;
									num4 = 2091259651;
								}
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x33C08BAD)) % 7)
									{
									case 5u:
										num7 = current.method_8();
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
									{
										int num8;
										int num9;
										if (current.method_8() < num7)
										{
											num8 = 900867756;
											num9 = 900867756;
										}
										else
										{
											num8 = 1081434159;
											num9 = 1081434159;
										}
										num3 = num8 ^ ((int)num2 * -742772997);
										continue;
									}
									case 0u:
									{
										int num5;
										int num6;
										if (current.method_8() != 0)
										{
											num5 = -1953652996;
											num6 = -1953652996;
										}
										else
										{
											num5 = -1035666012;
											num6 = -1035666012;
										}
										num3 = num5 ^ (int)(num2 * 1769095069);
										continue;
									}
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
						if (num7 == uint.MaxValue)
						{
							goto IL_0362;
						}
						goto IL_0423;
					}
					IL_0054:
					flag = (byte)num10 != 0;
					num = 1302175311;
					continue;
					IL_0423:
					num11 = (uint)(class154_0.method_4().method_0() + 24 + class154_0.method_6().method_1().method_10() + class154_0.method_8().Count * 40);
					num12 = 1658894166;
					goto IL_03f1;
					IL_03f1:
					while (true)
					{
						switch ((num2 = (uint)(num12 ^ 0x33C08BAD)) % 8)
						{
						case 5u:
							break;
						case 3u:
							num15 = num7;
							num12 = (int)(num2 * 762629663) ^ -1669727896;
							continue;
						case 2u:
							num15 += class154_0.method_6().method_3().imethod_18();
							num73 += class154_0.method_6().method_3().imethod_18();
							num12 = 683902132;
							continue;
						case 1u:
							goto IL_03bb;
						case 0u:
							num73 = num7 - num11;
							num12 = ((int)num2 * -173758990) ^ -1563248652;
							continue;
						case 4u:
							goto IL_0423;
						default:
						{
							Stream stream = Class171.smethod_258(class154_0, (long)num7, (int)(class154_0.method_28().Length - num7));
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
											int num13 = 1961847450;
											while (true)
											{
												switch ((num2 = (uint)(num13 ^ 0x33C08BAD)) % 3)
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
												num13 = (int)((num2 * 188254321) ^ 0x642BD929);
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
										int num14 = 620001602;
										while (true)
										{
											switch ((num2 = (uint)(num14 ^ 0x33C08BAD)) % 3)
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
											num14 = ((int)num2 * -1351621192) ^ -1753545110;
											continue;
											end_IL_050c:
											break;
										}
										break;
									}
								}
							}
							Class171.smethod_371(this, (long)num11, (long)(num15 - num11));
							class154_0.method_28().Position = num15;
							binaryWriter_0.Write(buffer);
							uint num16 = 0u;
							uint num17 = 0u;
							using (List<GClass5>.Enumerator enumerator = class154_0.method_8().GetEnumerator())
							{
								while (true)
								{
									IL_06ac:
									int num18;
									int num19;
									if (enumerator.MoveNext())
									{
										num18 = 464671946;
										num19 = 464671946;
									}
									else
									{
										num18 = 2039500516;
										num19 = 2039500516;
									}
									while (true)
									{
										switch ((num2 = (uint)(num18 ^ 0x33C08BAD)) % 9)
										{
										case 7u:
										{
											int num21;
											int num22;
											if (current2.method_8() == 0)
											{
												num21 = 1083348901;
												num22 = 1083348901;
											}
											else
											{
												num21 = 234427813;
												num22 = 234427813;
											}
											num18 = num21 ^ (int)(num2 * 1891451991);
											continue;
										}
										case 6u:
											current2 = enumerator.Current;
											num18 = 738907943;
											continue;
										case 5u:
											num17 = current2.method_4() + current2.method_2();
											num18 = (int)((num2 * 2120417160) ^ 0x2E0E6AA4);
											continue;
										case 4u:
											num18 = 464671946;
											continue;
										case 3u:
										{
											int num20;
											if (current2.method_8() + current2.method_6() <= num16)
											{
												num18 = 1537319204;
												num20 = 1537319204;
											}
											else
											{
												num18 = 1750900281;
												num20 = 1750900281;
											}
											continue;
										}
										case 2u:
											num16 = current2.method_8() + current2.method_6();
											num18 = ((int)num2 * -423315230) ^ -112072843;
											continue;
										case 0u:
										{
											GClass5 gClass = current2;
											gClass.method_9(gClass.method_8() + (num15 - num7));
											num18 = (int)((num2 * 694098504) ^ 0x73F103B3);
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
							if (num16 < class154_0.method_28().Length)
							{
								Stream stream2 = Class171.smethod_258(class154_0, (long)num16, (int)(class154_0.method_28().Length - num16));
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
												int num23 = 451787953;
												while (true)
												{
													switch ((num2 = (uint)(num23 ^ 0x33C08BAD)) % 3)
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
													num23 = ((int)num2 * -470091932) ^ 0x71DA773B;
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
											int num24 = 910361126;
											while (true)
											{
												switch ((num2 = (uint)(num24 ^ 0x33C08BAD)) % 3)
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
												num24 = ((int)num2 * -451554289) ^ -92715536;
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
								int num25 = 1144619223;
								while (true)
								{
									switch ((num2 = (uint)(num25 ^ 0x33C08BAD)) % 61)
									{
									case 60u:
										num17 = Class171.smethod_199(uint_, num17);
										num25 = (int)(num2 * 367251348) ^ -1950492042;
										continue;
									case 59u:
										num35 = -1;
										num25 = 1959509111;
										continue;
									case 58u:
									{
										int num59;
										if (!flag)
										{
											num25 = 1128883172;
											num59 = 1128883172;
										}
										else
										{
											num25 = 1163146677;
											num59 = 1163146677;
										}
										continue;
									}
									case 56u:
										num25 = (int)(num2 * 621292566) ^ -2128535585;
										continue;
									case 55u:
									{
										int num44;
										int num45;
										if (num35 == -1)
										{
											num44 = -1479533957;
											num45 = -1479533957;
										}
										else
										{
											num44 = -2127524021;
											num45 = -2127524021;
										}
										num25 = num44 ^ (int)(num2 * 484417033);
										continue;
									}
									case 54u:
										uint_2 = class154_0.method_6().method_3().imethod_19();
										num34 = Class171.smethod_199(uint_, gClass3.method_2());
										num25 = (int)((num2 * 1270102669) ^ 0x49C0FC29);
										continue;
									case 53u:
										Class171.smethod_41(gClass3, this);
										num25 = ((int)num2 * -574424709) ^ -2069619606;
										continue;
									case 52u:
									{
										int num62;
										int num63;
										if ((gClass3.method_18() & @enum) == @enum)
										{
											num62 = 1149268239;
											num63 = 1149268239;
										}
										else
										{
											num62 = 794998859;
											num63 = 794998859;
										}
										num25 = num62 ^ (int)(num2 * 1251705935);
										continue;
									}
									case 51u:
									{
										int num49;
										int num50;
										if (num31 != -1)
										{
											num49 = -227672996;
											num50 = -227672996;
										}
										else
										{
											num49 = -1247878542;
											num50 = -1247878542;
										}
										num25 = num49 ^ (int)(num2 * 1005882264);
										continue;
									}
									case 50u:
									{
										int num67;
										int num68;
										if (num31 != num42)
										{
											num67 = -1723036716;
											num68 = -1723036716;
										}
										else
										{
											num67 = -810966561;
											num68 = -810966561;
										}
										num25 = num67 ^ ((int)num2 * -954550044);
										continue;
									}
									case 49u:
										num31 = -1;
										num25 = (int)((num2 * 2081489658) ^ 0x75144B67);
										continue;
									case 48u:
									{
										int num53;
										int num54;
										if (num35 != num42)
										{
											num53 = -1479875606;
											num54 = -1479875606;
										}
										else
										{
											num53 = -1865077093;
											num54 = -1865077093;
										}
										num25 = num53 ^ (int)(num2 * 1739471165);
										continue;
									}
									case 47u:
										@class = new Class134();
										@class.string_0 = Class171.smethod_267(this);
										num25 = 1122686269;
										continue;
									case 46u:
									{
										int num40;
										int num41;
										if (num31 == num39)
										{
											num40 = 1437095566;
											num41 = 1437095566;
										}
										else
										{
											num40 = 1092104536;
											num41 = 1092104536;
										}
										num25 = num40 ^ ((int)num2 * -328855172);
										continue;
									}
									case 45u:
										num29++;
										num25 = 941722875;
										continue;
									case 44u:
									{
										Class171.smethod_428(this, (long)gClass3.method_8(), (long)gClass3.method_6());
										int num71;
										int num72;
										if (class131_0.method_6())
										{
											num71 = 501807256;
											num72 = 501807256;
										}
										else
										{
											num71 = 1151215555;
											num72 = 1151215555;
										}
										num25 = num71 ^ ((int)num2 * -221888343);
										continue;
									}
									case 43u:
										num16 += gClass3.method_6();
										num25 = (int)(num2 * 2095793978) ^ -1793748178;
										continue;
									case 42u:
									{
										int num64;
										if (flag3)
										{
											num25 = 388408013;
											num64 = 388408013;
										}
										else
										{
											num25 = 357485847;
											num64 = 357485847;
										}
										continue;
									}
									case 41u:
									{
										int num57;
										int num58;
										if (num27 == num35)
										{
											num57 = 485329588;
											num58 = 485329588;
										}
										else
										{
											num57 = 1093690205;
											num58 = 1093690205;
										}
										num25 = num57 ^ ((int)num2 * -290249446);
										continue;
									}
									case 39u:
									{
										int num55;
										if (flag2)
										{
											num25 = 1913867019;
											num55 = 1913867019;
										}
										else
										{
											num25 = 2031812535;
											num55 = 2031812535;
										}
										continue;
									}
									case 38u:
										class154_0.method_28().Position = num16;
										num25 = (int)((num2 * 1653740554) ^ 0x3729B324);
										continue;
									case 37u:
									{
										int num46;
										if (!flag2)
										{
											num25 = 1937880682;
											num46 = 1937880682;
										}
										else
										{
											num25 = 629114925;
											num46 = 629114925;
										}
										continue;
									}
									case 36u:
									{
										int num38;
										if (flag)
										{
											num25 = 1172898485;
											num38 = 1172898485;
										}
										else
										{
											num25 = 851169972;
											num38 = 851169972;
										}
										continue;
									}
									case 35u:
										num29--;
										num25 = 1907455292;
										continue;
									case 34u:
										num17 += num34;
										num25 = (int)((num2 * 1701229093) ^ 0x40F7487E);
										continue;
									case 33u:
									{
										int num30;
										if (num29 < random_0.Next(array.Length))
										{
											num25 = 542376334;
											num30 = 542376334;
										}
										else
										{
											num25 = 1779669402;
											num30 = 1779669402;
										}
										continue;
									}
									case 32u:
										num27 = random_0.Next(num28);
										num25 = 1675564108;
										continue;
									case 31u:
										gClass3.method_7(Class171.smethod_199(uint_2, num34));
										array = new Enum41[4]
										{
											Enum41.flag_34,
											Enum41.flag_32,
											Enum41.flag_28,
											Enum41.flag_2
										};
										num25 = (int)((num2 * 1163273393) ^ 0x7A52F083);
										continue;
									case 30u:
										class154_0.method_8().Add(gClass3);
										num25 = 1791964403;
										continue;
									case 29u:
										class154_0.method_6().method_3().imethod_30(Class171.smethod_199(uint_, gClass2.method_4() + gClass2.method_2()));
										num25 = ((int)num2 * -451959105) ^ -1867067043;
										continue;
									case 28u:
									{
										int num69;
										int num70;
										if (num39 == num42)
										{
											num69 = 1920494833;
											num70 = 1920494833;
										}
										else
										{
											num69 = 845927170;
											num70 = 845927170;
										}
										num25 = num69 ^ ((int)num2 * -1822570925);
										continue;
									}
									case 27u:
									{
										GClass5 gClass5 = gClass3;
										gClass5.method_19(gClass5.method_18() | @enum);
										num25 = (int)(num2 * 2098551681) ^ -1744938878;
										continue;
									}
									case 26u:
										Class171.smethod_298(this, gClass3);
										num25 = ((int)num2 * -892170871) ^ -213144554;
										continue;
									case 25u:
									{
										int num65;
										int num66;
										if (num27 == -1)
										{
											num65 = 1475806514;
											num66 = 1475806514;
										}
										else
										{
											num65 = 170235289;
											num66 = 170235289;
										}
										num25 = num65 ^ ((int)num2 * -1680711900);
										continue;
									}
									case 24u:
									{
										int num60;
										int num61;
										if (num27 == num42)
										{
											num60 = -102368383;
											num61 = -102368383;
										}
										else
										{
											num60 = -1726079721;
											num61 = -1726079721;
										}
										num25 = num60 ^ ((int)num2 * -35519616);
										continue;
									}
									case 23u:
									{
										int num56;
										if (!flag3)
										{
											num25 = 449346667;
											num56 = 449346667;
										}
										else
										{
											num25 = 1154136929;
											num56 = 1154136929;
										}
										continue;
									}
									case 22u:
									{
										GClass5 gClass4 = new GClass5();
										gClass4.method_1(@class.string_0);
										gClass4.method_19(Enum41.flag_33);
										gClass4.method_9(num16);
										gClass4.method_3(random_0.smethod_1(10u, 100u) * 50);
										gClass4.method_5(num17);
										gClass3 = gClass4;
										num25 = ((int)num2 * -618124037) ^ 0x53FF03BB;
										continue;
									}
									case 21u:
										method_5(gClass3);
										num25 = (int)((num2 * 57528577) ^ 0x11BB413B);
										continue;
									case 20u:
										@enum = array[random_0.Next(array.Length)];
										num25 = 1985498757;
										continue;
									case 19u:
										num42++;
										num25 = (int)((num2 * 1550255907) ^ 0x66E4867A);
										continue;
									case 18u:
										num35 = random_0.Next(num28);
										num25 = 1959509111;
										continue;
									case 17u:
									{
										int num51;
										int num52;
										if (num35 == num39)
										{
											num51 = 356055443;
											num52 = 356055443;
										}
										else
										{
											num51 = 838870409;
											num52 = 838870409;
										}
										num25 = num51 ^ (int)(num2 * 1696476326);
										continue;
									}
									case 16u:
										num29 = 0;
										num25 = (int)(num2 * 112527079) ^ -51457226;
										continue;
									case 15u:
									{
										int num47;
										int num48;
										if (num27 == num39)
										{
											num47 = 2058188440;
											num48 = 2058188440;
										}
										else
										{
											num47 = 1072225392;
											num48 = 1072225392;
										}
										num25 = num47 ^ ((int)num2 * -1268259983);
										continue;
									}
									case 14u:
									{
										int num43;
										if (num42 < num28)
										{
											num25 = 1471617676;
											num43 = 1471617676;
										}
										else
										{
											num25 = 678590307;
											num43 = 678590307;
										}
										continue;
									}
									case 13u:
										@class.string_0 = Class171.smethod_267(this);
										num25 = 398907354;
										continue;
									case 12u:
										num25 = ((int)num2 * -1436092143) ^ 0x4A8F0132;
										continue;
									case 11u:
										num39 = random_0.Next(num28);
										num25 = (int)(num2 * 1287992606) ^ -81180371;
										continue;
									case 10u:
										num42 = 0;
										num25 = 1846710994;
										continue;
									case 9u:
										class154_0.method_6().method_1().method_3((ushort)class154_0.method_8().Count);
										num25 = (int)(num2 * 1143816285) ^ -642117510;
										continue;
									case 8u:
										num27 = -1;
										num25 = 1675564108;
										continue;
									case 7u:
										Class171.smethod_278(this, gClass3);
										num25 = (int)((num2 * 315716441) ^ 0x538C72C);
										continue;
									case 6u:
									{
										int num36;
										int num37;
										if (num35 != num31)
										{
											num36 = -1084451384;
											num37 = -1084451384;
										}
										else
										{
											num36 = -1621794483;
											num37 = -1621794483;
										}
										num25 = num36 ^ (int)(num2 * 1795961946);
										continue;
									}
									case 5u:
										num31 = random_0.Next(num28);
										num25 = 1807791787;
										continue;
									case 4u:
									{
										int num32;
										int num33;
										if (num27 != num31)
										{
											num32 = -617819037;
											num33 = -617819037;
										}
										else
										{
											num32 = -596010506;
											num33 = -596010506;
										}
										num25 = num32 ^ ((int)num2 * -1000215043);
										continue;
									}
									case 3u:
										num25 = (int)((num2 * 187790071) ^ 0x404B8B2A);
										continue;
									case 2u:
										binaryWriter_0.Write(buffer);
										num25 = (int)((num2 * 136726999) ^ 0x3D056838);
										continue;
									case 1u:
									{
										int num26;
										if (class154_0.method_8().FindIndex(@class.method_0) == -1)
										{
											num25 = 1005348459;
											num26 = 1005348459;
										}
										else
										{
											num25 = 1347633148;
											num26 = 1347633148;
										}
										continue;
									}
									case 0u:
										gClass2 = class154_0.method_8()[class154_0.method_8().Count - 1];
										num25 = (int)((num2 * 881045494) ^ 0x52A7DA28);
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
						int num75;
						if (num73 < num74)
						{
							num12 = 501623231;
							num75 = 501623231;
						}
						else
						{
							num12 = 1920373387;
							num75 = 1920373387;
						}
					}
					goto IL_0362;
					IL_0362:
					num12 = 909627258;
					goto IL_03f1;
					IL_00eb:
					num79 = 0;
					goto IL_00ec;
					IL_00ec:
					flag2 = (byte)num79 != 0;
					if (Class171.smethod_19(class154_0))
					{
						num = 384846310;
						continue;
					}
					num80 = 0;
					goto IL_006a;
					IL_006a:
					flag3 = (byte)num80 != 0;
					num76 = 1;
					if (flag)
					{
						num = 896795711;
						num81 = 896795711;
					}
					else
					{
						num = 1393397153;
						num81 = 1393397153;
					}
					continue;
					IL_0053:
					num10 = 0;
					goto IL_0054;
				}
				break;
			}
		}
	}

	private void method_5(GClass5 gclass5_0)
	{
		gclass5_0.method_19(Enum41.flag_32 | Enum41.flag_33 | Enum41.flag_34);
		Class157 @class = default(Class157);
		List<uint> list = default(List<uint>);
		uint num9 = default(uint);
		uint num5 = default(uint);
		uint num6 = default(uint);
		uint value2 = default(uint);
		uint num8 = default(uint);
		uint num7 = default(uint);
		uint num10 = default(uint);
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
					binaryWriter_0.Write(num9);
					binaryWriter_0.Write(num5);
					binaryWriter_0.Write(num6);
					binaryWriter_0.Write(value2);
					num = (int)((num2 * 715802246) ^ 0x7EEE32C6);
					continue;
				case 21u:
					list.Add(num8);
					class154_0.method_28().Position = gclass5_0.method_8() + (num8 - num7 - gclass5_0.method_4());
					num = 740061908;
					continue;
				case 20u:
					class154_0.method_28().Position = gclass5_0.method_8();
					binaryWriter_0.Write(num10);
					num = (int)((num2 * 777398144) ^ 0x14664C17);
					continue;
				case 19u:
					num5 = (uint)class154_0.method_20().method_4();
					num6 = num7 + gclass5_0.method_4() + 24;
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
					class154_0.method_28().Position = gclass5_0.method_8() + (num6 - num7 - gclass5_0.method_4());
					num = (int)(num2 * 1647551760) ^ -908302058;
					continue;
				case 15u:
					num10 = (uint)class154_0.method_20().method_0();
					num = ((int)num2 * -1719106579) ^ 0x7D41A944;
					continue;
				case 13u:
					binaryWriter_0.Write(new byte[6] { 144, 144, 144, 194, 12, 0 });
					num = (int)((num2 * 784874002) ^ 0x2477F8BD);
					continue;
				case 12u:
				{
					int num11;
					int num12;
					if (class154_0.method_20() == null)
					{
						num11 = -2034683587;
						num12 = -2034683587;
					}
					else
					{
						num11 = -1773933810;
						num12 = -1773933810;
					}
					num = num11 ^ ((int)num2 * -2078760204);
					continue;
				}
				case 11u:
					num10 = num7 + gclass5_0.method_4() + 24;
					num = 422863214;
					continue;
				case 10u:
					value2 = class154_0.method_20().method_8();
					num = (int)(num2 * 1711383335) ^ -1931609895;
					continue;
				case 9u:
					num9 = (uint)class154_0.method_20().method_2();
					num = ((int)num2 * -2143889560) ^ 0x1BD13621;
					continue;
				case 8u:
					num9 = num10 + random_0.smethod_1(1u, 5u) * 4;
					num = ((int)num2 * -1221837672) ^ 0x7D001CA7;
					continue;
				case 7u:
					@class.method_1(gclass5_0.method_4());
					num = ((int)num2 * -1629199253) ^ 0x1C2947FD;
					continue;
				case 5u:
					num7 = (uint)class154_0.method_6().method_3().imethod_17();
					num8 = num7 + gclass5_0.method_4();
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
					num5 = num9 + random_0.smethod_1(1u, 5u) * 4;
					num6 = num5 + random_0.smethod_1(1u, 5u) * 4;
					num = (int)((num2 * 904938281) ^ 0x35C1768F);
					continue;
				case 1u:
					Class171.smethod_428(this, (long)gclass5_0.method_8(), (long)gclass5_0.method_6());
					@class = class154_0.method_6().method_3().imethod_49()[9];
					num = ((int)num2 * -1592922910) ^ 0x543D6DC0;
					continue;
				case 0u:
					value = 0u;
					value2 = 0u;
					num8 = num6 + random_0.smethod_1(2u, 5u) * 4;
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
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 118745939;
								num4 = 118745939;
							}
							else
							{
								num3 = 1601919713;
								num4 = 1601919713;
							}
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x138898F)) % 4)
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
			int num;
			int num2;
			if (result.Equals(gparam_0))
			{
				num = 1859486466;
				num2 = 1859486466;
			}
			else
			{
				num = 361787660;
				num2 = 361787660;
			}
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
		uint num11 = default(uint);
		uint num9 = default(uint);
		uint num7 = default(uint);
		uint num5 = default(uint);
		Class132 @class = default(Class132);
		uint num6 = default(uint);
		while (true)
		{
			int num = 533663446;
			while (true)
			{
				int num10;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x53C4D7B5)) % 7)
				{
				case 6u:
					if (!Class171.smethod_19(class154_0))
					{
						num = (int)(num2 * 736127035) ^ -1260354819;
						continue;
					}
					num10 = (int)(random_0.smethod_1(1u, num11 + 1) * class154_0.method_6().method_3().imethod_19());
					goto IL_0050;
				case 5u:
					num9 = 0u;
					num = (int)(num2 * 2022289533) ^ -343916685;
					continue;
				case 3u:
					num7 = class154_0.method_8()[0].method_4() + num5;
					num = ((int)num2 * -639180834) ^ 0x250F37A;
					continue;
				case 2u:
					num10 = 0;
					goto IL_0050;
				case 1u:
					num11 = random_0.smethod_1(1u, 10u);
					num5 = num11 * class154_0.method_6().method_3().imethod_18();
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
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = 346687121;
									num4 = 346687121;
								}
								else
								{
									num3 = 241808760;
									num4 = 241808760;
								}
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
										gClass.method_9(gClass.method_8() + num9);
										num3 = ((int)num2 * -1418474868) ^ -1506869931;
										continue;
									}
									case 4u:
										list.Add(@class);
										num3 = 1491945630;
										continue;
									case 3u:
										num9 += num6;
										num3 = ((int)num2 * -1684760583) ^ -284635667;
										continue;
									case 1u:
									{
										GClass5 current = enumerator.Current;
										@class = new Class132(current, num5, num6);
										@class.method_3().method_5(num7);
										uint uint_ = num7 + @class.method_3().method_2();
										uint uint_2 = class154_0.method_6().method_3().imethod_18();
										num7 = Class171.smethod_199(uint_2, uint_);
										int num8;
										if (current.method_6() == 0)
										{
											num3 = 2019712025;
											num8 = 2019712025;
										}
										else
										{
											num3 = 2138851466;
											num8 = 2138851466;
										}
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
						gClass2.method_3(num5);
						gClass2.method_1(Class171.smethod_267(this));
						list.Insert(0, new Class132(gClass2, 0u, 0u));
						return list;
					}
					IL_0050:
					num6 = (uint)num10;
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
			uint num = 1203043130u;
			return;
		}
		BinaryWriter binaryWriter = new BinaryWriter(class154_0.method_28());
		class154_0.method_28().Position = Class171.smethod_134(class154_0, class154_0.method_6().method_3().imethod_49()[1].method_0());
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
					int num2 = -1437391201;
					while (true)
					{
						uint num;
						switch ((num = (uint)(num2 ^ -851691805)) % 7)
						{
						case 6u:
							num2 = -837280797;
							continue;
						case 5u:
							binaryWriter.Write(Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_6()));
							position = class154_0.method_28().Position;
							class154_0.method_28().Position = Class171.smethod_134(class154_0, current.method_0());
							num2 = ((int)num * -857508609) ^ -1702002374;
							continue;
						case 2u:
							binaryWriter.Write(Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_0()));
							num2 = ((int)num * -2035643783) ^ 0x6CAA37E6;
							continue;
						case 1u:
							class154_0.method_28().Position += 8L;
							num2 = (int)(num * 1246749018) ^ -1762608560;
							continue;
						case 0u:
							binaryWriter.Write(Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_4()));
							num2 = ((int)num * -376813912) ^ -19342247;
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
						int num3;
						int num4;
						if (!enumerator2.MoveNext())
						{
							num3 = -813822703;
							num4 = -813822703;
						}
						else
						{
							num3 = -525615418;
							num4 = -525615418;
						}
						while (true)
						{
							uint num;
							switch ((num = (uint)(num3 ^ -851691805)) % 10)
							{
							case 9u:
								current2 = enumerator2.Current;
								num3 = -2061373852;
								continue;
							case 8u:
								num3 = (int)((num * 947452163) ^ 0x5358F716);
								continue;
							case 7u:
							{
								int num6;
								int num7;
								if (!current2.method_7())
								{
									num6 = -1575513446;
									num7 = -1575513446;
								}
								else
								{
									num6 = -1529020143;
									num7 = -1529020143;
								}
								num3 = num6 ^ ((int)num * -551667859);
								continue;
							}
							case 6u:
							{
								int num8;
								if (!Class171.smethod_19(class154_0))
								{
									num3 = -236609310;
									num8 = -236609310;
								}
								else
								{
									num3 = -752147151;
									num8 = -752147151;
								}
								continue;
							}
							case 5u:
								class154_0.method_28().Position += (Class171.smethod_19(class154_0) ? 4 : 8);
								num3 = -2129259869;
								continue;
							case 3u:
							{
								ulong num5;
								current2.method_1(num5 = Class171.smethod_33((IEnumerable<Class132>)list_0, (uint)current2.method_0()));
								binaryWriter.Write(num5);
								num3 = -1936172074;
								continue;
							}
							case 2u:
							{
								ulong num5;
								current2.method_1(num5 = Class171.smethod_33((IEnumerable<Class132>)list_0, (uint)current2.method_0()));
								binaryWriter.Write((uint)num5);
								num3 = ((int)num * -1153726936) ^ 0x33F95F06;
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
					class154_0.method_28().Position = Class171.smethod_134(class154_0, current.method_6());
					using List<Class164>.Enumerator enumerator2 = current.method_10().GetEnumerator();
					while (true)
					{
						IL_04c5:
						int num9;
						int num10;
						if (!enumerator2.MoveNext())
						{
							num9 = -226771341;
							num10 = -226771341;
						}
						else
						{
							num9 = -232663685;
							num10 = -232663685;
						}
						while (true)
						{
							uint num;
							switch ((num = (uint)(num9 ^ -851691805)) % 10)
							{
							case 9u:
							{
								ulong num5;
								current3.method_1(num5 = Class171.smethod_33((IEnumerable<Class132>)list_0, (uint)current3.method_0()));
								binaryWriter.Write((uint)num5);
								num9 = ((int)num * -701778638) ^ 0x68B0BDC2;
								continue;
							}
							case 8u:
							{
								int num11;
								if (Class171.smethod_19(class154_0))
								{
									num9 = -153582566;
									num11 = -153582566;
								}
								else
								{
									num9 = -997255661;
									num11 = -997255661;
								}
								continue;
							}
							case 7u:
								num9 = -232663685;
								continue;
							case 6u:
							{
								current3 = enumerator2.Current;
								int num12;
								if (!current3.method_7())
								{
									num9 = -51132467;
									num12 = -51132467;
								}
								else
								{
									num9 = -1299850840;
									num12 = -1299850840;
								}
								continue;
							}
							case 3u:
								num9 = ((int)num * -299343990) ^ -1864051312;
								continue;
							case 2u:
								num9 = (int)(num * 1279736494) ^ -1912259530;
								continue;
							case 1u:
								class154_0.method_28().Position += (Class171.smethod_19(class154_0) ? 4 : 8);
								num9 = -382573913;
								continue;
							case 0u:
							{
								ulong num5;
								current3.method_1(num5 = Class171.smethod_33((IEnumerable<Class132>)list_0, (uint)current3.method_0()));
								binaryWriter.Write(num5);
								num9 = -1045065202;
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
				current.method_1(Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_0()));
				current.method_5(Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_4()));
				goto IL_055c;
			}
			int num13 = -846042793;
			goto IL_053a;
			IL_053a:
			while (true)
			{
				uint num;
				switch ((num = (uint)(num13 ^ -851691805)) % 4)
				{
				case 1u:
					current.method_7(Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_6()));
					class154_0.method_28().Position = position;
					num13 = (int)(num * 1395445963) ^ -161151034;
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
			num13 = -663548978;
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
		uint num2;
		BinaryWriter binaryWriter2 = default(BinaryWriter);
		switch ((num2 = (uint)(num ^ -1156633631)) % 4)
		{
		case 0u:
			break;
		case 1u:
			goto IL_0034;
		case 2u:
			return;
		default:
		{
			class154_0.method_28().Position = Class171.smethod_134(class154_0, class154_0.method_6().method_3().imethod_49()[3].method_0());
			using List<Class140>.Enumerator enumerator = class154_0.method_25().list_0.GetEnumerator();
			Class140 current = default(Class140);
			while (true)
			{
				int num3;
				int num4;
				if (!enumerator.MoveNext())
				{
					num3 = -1579988937;
					num4 = -1579988937;
				}
				else
				{
					num3 = -1289405756;
					num4 = -1289405756;
				}
				while (true)
				{
					switch ((num2 = (uint)(num3 ^ -1156633631)) % 7)
					{
					case 6u:
						num3 = -1289405756;
						continue;
					case 4u:
					{
						BinaryWriter binaryWriter4 = binaryWriter2;
						uint value;
						current.method_3(value = Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_2()));
						binaryWriter4.Write(value);
						num3 = (int)(num2 * 29284499) ^ -1487425163;
						continue;
					}
					case 2u:
					{
						BinaryWriter binaryWriter3 = binaryWriter2;
						uint value;
						current.method_1(value = Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_0()));
						binaryWriter3.Write(value);
						num3 = (int)((num2 * 144062653) ^ 0x124DA656);
						continue;
					}
					case 1u:
						current = enumerator.Current;
						num3 = -263573548;
						continue;
					case 0u:
					{
						BinaryWriter binaryWriter = binaryWriter2;
						uint value;
						current.method_5(value = Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_4()));
						binaryWriter.Write(value);
						num3 = (int)((num2 * 654510067) ^ 0x4C4DEFE);
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
		ulong num8 = default(ulong);
		BinaryWriter binaryWriter = default(BinaryWriter);
		Class144 current2 = default(Class144);
		uint num9 = default(uint);
		ulong num11 = default(ulong);
		BinaryReader binaryReader = default(BinaryReader);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1299608026)) % 6)
			{
			case 4u:
				num3 = Class171.smethod_134(class154_0, class154_0.method_6().method_3().imethod_49()[5].method_0());
				num = (int)(num2 * 161890499) ^ -914632068;
				continue;
			case 2u:
				num8 = class154_0.method_6().method_3().imethod_17();
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
						binaryWriter.Write(Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_0()));
						using (List<Class144>.Enumerator enumerator2 = current.list_0.GetEnumerator())
						{
							while (true)
							{
								IL_0304:
								int num4;
								int num5;
								if (!enumerator2.MoveNext())
								{
									num4 = -2029392844;
									num5 = -2029392844;
								}
								else
								{
									num4 = -572974935;
									num5 = -572974935;
								}
								while (true)
								{
									switch ((num2 = (uint)(num4 ^ -1299608026)) % 12)
									{
									case 10u:
									{
										int num10;
										if (current2.method_2() != GEnum0.Dir64)
										{
											num4 = -848775079;
											num10 = -848775079;
										}
										else
										{
											num4 = -204465497;
											num10 = -204465497;
										}
										continue;
									}
									case 9u:
										binaryWriter.Write((uint)(int)num8 + Class171.smethod_33((IEnumerable<Class132>)list_0, num9 - (uint)(int)num8));
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
										num11 = binaryReader.ReadUInt64();
										class154_0.method_28().Position -= 8L;
										num4 = (int)((num2 * 1012304616) ^ 0x517823BB);
										continue;
									case 4u:
										num9 = binaryReader.ReadUInt32();
										class154_0.method_28().Position -= 4L;
										num4 = ((int)num2 * -427476099) ^ -2117506253;
										continue;
									case 3u:
										num4 = -572974935;
										continue;
									case 2u:
										class154_0.method_28().Position = Class171.smethod_134(class154_0, current.method_0() + current2.method_0());
										num4 = ((int)num2 * -37649823) ^ 0x49CF5D8C;
										continue;
									case 1u:
										binaryWriter.Write(num8 + Class171.smethod_33((IEnumerable<Class132>)list_0, (uint)(num11 - num8)));
										num4 = ((int)num2 * -1411925062) ^ -106864037;
										continue;
									case 0u:
									{
										int num6;
										int num7;
										if (current2.method_2() == GEnum0.HighLow)
										{
											num6 = 1878221062;
											num7 = 1878221062;
										}
										else
										{
											num6 = 813692528;
											num7 = 813692528;
										}
										num4 = num6 ^ (int)(num2 * 1736278061);
										continue;
									}
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
						current.method_1(Class171.smethod_33((IEnumerable<Class132>)list_0, current.method_0()));
						num3 += current.method_2();
						goto IL_0341;
					}
					int num12 = -1950432886;
					goto IL_0346;
					IL_0346:
					switch ((num2 = (uint)(num12 ^ -1299608026)) % 3)
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
					num12 = -1053152223;
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
}
