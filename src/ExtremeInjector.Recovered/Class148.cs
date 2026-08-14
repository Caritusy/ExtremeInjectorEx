using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

public class Class148
{
	[CompilerGenerated]
	public sealed class Class150 : IEnumerable<string>, IEnumerator<string>, IEnumerable, IEnumerator, IDisposable
	{
		internal int int_0;

		private string string_0;

		private int int_1;

		private IEnumerable<Class164> ienumerable_0;

		public IEnumerable<Class164> ienumerable_1;

		private string string_1;

		public string string_2;

		private Class164 class164_0;

		internal IEnumerator<Class164> ienumerator_0;

		private string Property002E => string_0;

		private object Property002F => string_0;

		public Class150(int int_2)
		{
			while (true)
			{
				int num = -1310840278;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1068286776)) % 3)
					{
					case 1u:
						goto IL_0008;
					case 2u:
						break;
					default:
						int_1 = Thread.CurrentThread.ManagedThreadId;
						return;
					}
					break;
					IL_0008:
					int_0 = int_2;
					num = (int)(num2 * 1245308840) ^ -1986634113;
				}
			}
		}

		private void Dispose()
		{
			int num = int_0;
			while (true)
			{
				int num2 = 1635967249;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num2 ^ 0x4731EB69)) % 5)
					{
					case 2u:
					{
						int num4;
						int num5;
						if (num != -3)
						{
							num4 = -1694623183;
							num5 = -1694623183;
						}
						else
						{
							num4 = -1948661460;
							num5 = -1948661460;
						}
						num2 = num4 ^ ((int)num3 * -2129395048);
						continue;
					}
					case 1u:
					{
						int num6;
						int num7;
						if (num == 1)
						{
							num6 = -276687156;
							num7 = -276687156;
						}
						else
						{
							num6 = -1016495012;
							num7 = -1016495012;
						}
						num2 = num6 ^ ((int)num3 * -1278186660);
						continue;
					}
					case 0u:
						if (num == 2)
						{
							num2 = ((int)num3 * -1477800630) ^ 0x4400C7E;
							continue;
						}
						return;
					case 3u:
						break;
					default:
						try
						{
							return;
						}
						finally
						{
							Class171.smethod_43(this);
						}
					}
					break;
				}
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		private bool MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = int_0;
				int num5 = default(int);
				while (true)
				{
					IL_02bc:
					int num2 = 1442866303;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ 0x6A2729EA)) % 24)
						{
						case 23u:
							int_0 = -1;
							num2 = 1392808676;
							continue;
						case 22u:
							string_1 = string_1.Substring(0, num5);
							num2 = ((int)num3 * -989884367) ^ 0x47974698;
							continue;
						case 21u:
							goto IL_0043;
						case 20u:
						{
							int num6;
							int num7;
							if (num5 == -1)
							{
								num6 = 1355211678;
								num7 = 1355211678;
							}
							else
							{
								num6 = 2043759820;
								num7 = 2043759820;
							}
							num2 = num6 ^ ((int)num3 * -1031302988);
							continue;
						}
						case 19u:
						{
							class164_0 = ienumerator_0.Current;
							int num8;
							if (class164_0.method_7())
							{
								num2 = 55738522;
								num8 = 55738522;
							}
							else
							{
								num2 = 2041582042;
								num8 = 2041582042;
							}
							continue;
						}
						case 18u:
							result = false;
							num2 = (int)((num3 * 477560987) ^ 0x53F9DBCD);
							continue;
						case 16u:
							string_0 = class164_0.method_4();
							int_0 = 2;
							result = true;
							num2 = 171612518;
							continue;
						case 15u:
							Class171.smethod_43(this);
							num2 = ((int)num3 * -1641975489) ^ -1750320344;
							continue;
						case 14u:
							ienumerator_0 = ienumerable_0.GetEnumerator();
							num2 = ((int)num3 * -1263309089) ^ -891404561;
							continue;
						case 13u:
							switch (num)
							{
							case 0:
								break;
							case 1:
								goto IL_0043;
							default:
								goto IL_013c;
							case 2:
								goto IL_014e;
							}
							goto case 23u;
						case 10u:
							goto IL_014e;
						case 11u:
							result = true;
							num2 = ((int)num3 * -180469080) ^ 0x1E122133;
							continue;
						case 9u:
							class164_0 = null;
							num2 = 1592282794;
							continue;
						case 8u:
							num5 = string_1.LastIndexOf(Class178.smethod_0(10075), StringComparison.OrdinalIgnoreCase);
							num2 = ((int)num3 * -90542336) ^ 0x7F53C766;
							continue;
						case 7u:
							int_0 = -3;
							num2 = ((int)num3 * -497434657) ^ 0x415977C1;
							continue;
						case 4u:
							string_0 = string_1 + Class178.smethod_0(952) + class164_0.method_2();
							int_0 = 1;
							num2 = 1159990593;
							continue;
						case 3u:
							ienumerator_0 = null;
							num2 = (int)((num3 * 1298062336) ^ 0x77BFD828);
							continue;
						case 2u:
							num2 = (int)(num3 * 702623532) ^ -1053928974;
							continue;
						case 0u:
						{
							int num4;
							if (ienumerator_0.MoveNext())
							{
								num2 = 189482537;
								num4 = 189482537;
							}
							else
							{
								num2 = 2001591733;
								num4 = 2001591733;
							}
							continue;
						}
						default:
							goto end_IL_024a;
						case 6u:
							break;
						case 1u:
							goto end_IL_024a;
						case 5u:
							result = false;
							goto end_IL_024a;
						case 12u:
							goto end_IL_024a;
						case 17u:
							goto end_IL_024a;
							IL_014e:
							int_0 = -3;
							num2 = 617127763;
							continue;
							IL_013c:
							num2 = ((int)num3 * -903327397) ^ -23769880;
							continue;
							IL_0043:
							int_0 = -3;
							num2 = 617127763;
							continue;
						}
						goto IL_02bc;
						continue;
						end_IL_024a:
						break;
					}
					break;
				}
			}
			catch
			{
				//try-fault
				Dispose();
				throw;
			}
			return result;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void Reset()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Reset
			this.Reset();
		}

		private IEnumerator<string> GetEnumerator()
		{
			if (int_0 == -2)
			{
				goto IL_00ac;
			}
			goto IL_00e7;
			IL_00ac:
			int num = 1038307375;
			goto IL_00b1;
			IL_00b1:
			Class150 @class = default(Class150);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5EC583FF)) % 9)
				{
				case 7u:
					int_0 = 0;
					num = (int)((num2 * 1158784038) ^ 0x1814CC80);
					continue;
				case 6u:
					@class.string_1 = string_2;
					num = 950000989;
					continue;
				case 5u:
					num = ((int)num2 * -1723302025) ^ -1668384879;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (int_1 != Thread.CurrentThread.ManagedThreadId)
					{
						num3 = 1762889299;
						num4 = 1762889299;
					}
					else
					{
						num3 = 59569871;
						num4 = 59569871;
					}
					num = num3 ^ ((int)num2 * -700373703);
					continue;
				}
				case 3u:
					@class = this;
					num = (int)(num2 * 2051277933) ^ -255649637;
					continue;
				case 1u:
					@class.ienumerable_0 = ienumerable_1;
					num = ((int)num2 * -1697645443) ^ -850787277;
					continue;
				case 0u:
					break;
				case 8u:
					goto IL_00e7;
				default:
					return @class;
				}
				break;
			}
			goto IL_00ac;
			IL_00e7:
			@class = new Class150(0);
			num = 1050675584;
			goto IL_00b1;
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
			return this.GetEnumerator();
		}

		private IEnumerator GetEnumerator_044B()
		{
			return GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator_044B
			return this.GetEnumerator_044B();
		}
	}

	public GClass0<string, List<string>> gclass0_0 = new GClass0<string, List<string>>(StringComparer.OrdinalIgnoreCase);

	public List<Class160> list_0 = new List<Class160>();

	protected List<string> this[string string_0] => gclass0_0[string_0];

	public Class148()
	{
	}

	internal Class148(Class5 class5_0, Class154 class154_0)
	{
		Class160 @class = default(Class160);
		long position = default(long);
		List<Class164> collection = default(List<Class164>);
		string text = default(string);
		long num3 = default(long);
		long num7 = default(long);
		while (true)
		{
			int num = -1962300342;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -174726434)) % 27)
				{
				case 26u:
					@class.method_1(class5_0.ReadUInt32());
					num = ((int)num2 * -212443749) ^ -2083822355;
					continue;
				case 25u:
					position = class5_0.BaseStream.Position;
					num = (int)((num2 * 1062885165) ^ 0x4FCBF728);
					continue;
				case 24u:
				{
					collection = Class171.smethod_161(class5_0, this, class154_0);
					@class.method_8().AddRange(collection);
					int num5;
					int num6;
					if (@class.method_0() == @class.method_6())
					{
						num5 = -1512329624;
						num6 = -1512329624;
					}
					else
					{
						num5 = -2085410740;
						num6 = -2085410740;
					}
					num = num5 ^ (int)(num2 * 1960013493);
					continue;
				}
				case 23u:
					@class.method_2(class5_0.ReadUInt32());
					@class.method_3(class5_0.ReadUInt32());
					num = (int)(num2 * 966981632) ^ -221179670;
					continue;
				case 22u:
					text = Class171.smethod_396(class5_0);
					@class.method_13(text);
					Class171.smethod_156(class5_0, num3);
					num = (int)(num2 * 1536381042) ^ -823420306;
					continue;
				case 21u:
				{
					int num16;
					int num17;
					if (!class5_0.imethod_0(num7))
					{
						num16 = 674905396;
						num17 = 674905396;
					}
					else
					{
						num16 = 1419870831;
						num17 = 1419870831;
					}
					num = num16 ^ (int)(num2 * 2076752282);
					continue;
				}
				case 20u:
				{
					int num14;
					int num15;
					if (num3 == -1L)
					{
						num14 = 1354765408;
						num15 = 1354765408;
					}
					else
					{
						num14 = 1344741135;
						num15 = 1344741135;
					}
					num = num14 ^ ((int)num2 * -1328813551);
					continue;
				}
				case 18u:
					num7 = Class171.smethod_134(class154_0, @class.method_4());
					num = ((int)num2 * -1420778911) ^ -1647313493;
					continue;
				case 17u:
				{
					int num9;
					int num10;
					if (num7 == -1L)
					{
						num9 = -473347619;
						num10 = -473347619;
					}
					else
					{
						num9 = -6000526;
						num10 = -6000526;
					}
					num = num9 ^ ((int)num2 * -1373515419);
					continue;
				}
				case 16u:
				{
					@class.method_5(class5_0.ReadUInt32());
					@class.method_7(class5_0.ReadUInt32());
					int num18;
					int num19;
					if (@class.method_0() == 0)
					{
						num18 = 708437211;
						num19 = 708437211;
					}
					else
					{
						num18 = 138174256;
						num19 = 138174256;
					}
					num = num18 ^ ((int)num2 * -1036837450);
					continue;
				}
				case 14u:
				{
					int num12;
					int num13;
					if (!class5_0.imethod_0(num3))
					{
						num12 = 1792550379;
						num13 = 1792550379;
					}
					else
					{
						num12 = 1107266464;
						num13 = 1107266464;
					}
					num = num12 ^ (int)(num2 * 1216664307);
					continue;
				}
				case 13u:
					@class.method_10().AddRange(Class171.smethod_161(class5_0, this, class154_0));
					num = (int)((num2 * 1002909013) ^ 0x2F39881C);
					continue;
				case 12u:
				{
					int num11;
					if (!gclass0_0.imethod_6(text))
					{
						num = -424430119;
						num11 = -424430119;
					}
					else
					{
						num = -649131201;
						num11 = -649131201;
					}
					continue;
				}
				case 11u:
					@class.method_10().AddRange(collection);
					num = (int)(num2 * 1639900574) ^ -22486031;
					continue;
				case 10u:
					@class.method_1(@class.method_6());
					num = (int)((num2 * 1506895680) ^ 0x554B6188);
					continue;
				case 9u:
					gclass0_0[text].AddRange(Class171.smethod_404(text, (IEnumerable<Class164>)@class.method_8(), this));
					num = ((int)num2 * -1556872968) ^ -377113697;
					continue;
				case 8u:
				{
					num3 = Class171.smethod_134(class154_0, @class.method_6());
					Class171.smethod_156(class5_0, num3);
					int num8;
					if (num3 == -1L)
					{
						num = -775515405;
						num8 = -775515405;
					}
					else
					{
						num = -1403968019;
						num8 = -1403968019;
					}
					continue;
				}
				case 7u:
					num = ((int)num2 * -2102108517) ^ 0x673C902E;
					continue;
				case 6u:
					Class171.smethod_156(class5_0, num7);
					num = ((int)num2 * -560561428) ^ -286978101;
					continue;
				case 5u:
					num = ((int)num2 * -1805944501) ^ 0xC95CBAB;
					continue;
				case 4u:
					@class = new Class160();
					num = -63279095;
					continue;
				case 3u:
					list_0.Add(@class);
					Class171.smethod_156(class5_0, position);
					num = -1951820067;
					continue;
				case 2u:
				{
					int num4;
					if (@class.method_0() == 0)
					{
						num = -546281438;
						num4 = -546281438;
					}
					else
					{
						num = -945391017;
						num4 = -945391017;
					}
					continue;
				}
				case 1u:
					gclass0_0.imethod_0(text, new List<string>(Class171.smethod_404(text, (IEnumerable<Class164>)@class.method_8(), this)));
					num = -784129433;
					continue;
				case 0u:
					num3 = Class171.smethod_134(class154_0, @class.method_0());
					num = ((int)num2 * -1945295150) ^ 0x42B178CD;
					continue;
				default:
					return;
				case 15u:
					break;
				case 19u:
					return;
				}
				break;
			}
		}
	}
}
