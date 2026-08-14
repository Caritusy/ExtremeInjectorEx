using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

public class Class148
{
	[CompilerGenerated]
	public sealed class Class150 : IEnumerable<string>, IEnumerator<string>, IDisposable, IEnumerator, IEnumerable
	{
		internal int int_0;

		internal string string_0;

		internal int int_1;

		internal IEnumerable<Class164> ienumerable_0;

		public IEnumerable<Class164> ienumerable_1;

		internal string string_1;

		public string string_2;

		internal Class164 class164_0;

		internal IEnumerator<Class164> ienumerator_0;

		string IEnumerator<string>.Current => string_0;

		object IEnumerator.Current => string_0;

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

		void IDisposable.Dispose()
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
						num2 = ((num == -3) ? (-1948661460) : (-1694623183)) ^ ((int)num3 * -2129395048);
						continue;
					case 1u:
						num2 = ((num != 1) ? (-1016495012) : (-276687156)) ^ ((int)num3 * -1278186660);
						continue;
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

		bool IEnumerator.MoveNext()
		{
			bool result = default(bool);
			try
			{
				int num = int_0;
				int num4 = default(int);
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
							string_1 = string_1.Substring(0, num4);
							num2 = ((int)num3 * -989884367) ^ 0x47974698;
							continue;
						case 21u:
							goto IL_0043;
						case 20u:
							num2 = ((num4 != -1) ? 2043759820 : 1355211678) ^ ((int)num3 * -1031302988);
							continue;
						case 19u:
							class164_0 = ienumerator_0.Current;
							num2 = ((!class164_0.method_7()) ? 2041582042 : 55738522);
							continue;
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
							num4 = string_1.LastIndexOf(".dll", StringComparison.OrdinalIgnoreCase);
							num2 = ((int)num3 * -90542336) ^ 0x7F53C766;
							continue;
						case 7u:
							int_0 = -3;
							num2 = ((int)num3 * -497434657) ^ 0x415977C1;
							continue;
						case 4u:
							string_0 = string_1 + "." + class164_0.method_2();
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
							num2 = ((!ienumerator_0.MoveNext()) ? 2001591733 : 189482537);
							continue;
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
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
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
					num = ((int_1 == Thread.CurrentThread.ManagedThreadId) ? 59569871 : 1762889299) ^ ((int)num2 * -700373703);
					continue;
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

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}

		internal static Thread smethod_0()
		{
			return Thread.CurrentThread;
		}

		internal static int smethod_1(Thread thread_0)
		{
			return thread_0.ManagedThreadId;
		}

		internal static int smethod_2(string string_3, string string_4, StringComparison stringComparison_0)
		{
			return string_3.LastIndexOf(string_4, stringComparison_0);
		}

		internal static string smethod_3(string string_3, int int_2, int int_3)
		{
			return string_3.Substring(int_2, int_3);
		}

		internal static string smethod_4(object object_0, object object_1, object object_2)
		{
			return string.Concat(object_0, object_1, object_2);
		}

		internal static bool smethod_5(IEnumerator ienumerator_1)
		{
			return ienumerator_1.MoveNext();
		}

		internal static NotSupportedException smethod_6()
		{
			return new NotSupportedException();
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
		long num4 = default(long);
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
					collection = Class171.smethod_162(class5_0, this, class154_0);
					@class.method_8().AddRange(collection);
					num = ((@class.method_0() != @class.method_6()) ? (-2085410740) : (-1512329624)) ^ (int)(num2 * 1960013493);
					continue;
				case 23u:
					@class.method_2(class5_0.ReadUInt32());
					@class.method_3(class5_0.ReadUInt32());
					num = (int)(num2 * 966981632) ^ -221179670;
					continue;
				case 22u:
					text = Class171.smethod_404(class5_0);
					@class.method_13(text);
					Class171.smethod_157(class5_0, num3);
					num = (int)(num2 * 1536381042) ^ -823420306;
					continue;
				case 21u:
					num = (class5_0.imethod_0(num4) ? 1419870831 : 674905396) ^ (int)(num2 * 2076752282);
					continue;
				case 20u:
					num = ((num3 != -1L) ? 1344741135 : 1354765408) ^ ((int)num2 * -1328813551);
					continue;
				case 18u:
					num4 = Class171.smethod_135(class154_0, @class.method_4());
					num = ((int)num2 * -1420778911) ^ -1647313493;
					continue;
				case 17u:
					num = ((num4 != -1L) ? (-6000526) : (-473347619)) ^ ((int)num2 * -1373515419);
					continue;
				case 16u:
					@class.method_5(class5_0.ReadUInt32());
					@class.method_7(class5_0.ReadUInt32());
					num = ((@class.method_0() != 0) ? 138174256 : 708437211) ^ ((int)num2 * -1036837450);
					continue;
				case 14u:
					num = (class5_0.imethod_0(num3) ? 1107266464 : 1792550379) ^ (int)(num2 * 1216664307);
					continue;
				case 13u:
					@class.method_10().AddRange(Class171.smethod_162(class5_0, this, class154_0));
					num = (int)((num2 * 1002909013) ^ 0x2F39881C);
					continue;
				case 12u:
					num = (gclass0_0.imethod_6(text) ? (-649131201) : (-424430119));
					continue;
				case 11u:
					@class.method_10().AddRange(collection);
					num = (int)(num2 * 1639900574) ^ -22486031;
					continue;
				case 10u:
					@class.method_1(@class.method_6());
					num = (int)((num2 * 1506895680) ^ 0x554B6188);
					continue;
				case 9u:
					gclass0_0[text].AddRange(Class171.smethod_412(text, @class.method_8(), this));
					num = ((int)num2 * -1556872968) ^ -377113697;
					continue;
				case 8u:
					num3 = Class171.smethod_135(class154_0, @class.method_6());
					Class171.smethod_157(class5_0, num3);
					num = ((num3 != -1L) ? (-1403968019) : (-775515405));
					continue;
				case 7u:
					num = ((int)num2 * -2102108517) ^ 0x673C902E;
					continue;
				case 6u:
					Class171.smethod_157(class5_0, num4);
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
					Class171.smethod_157(class5_0, position);
					num = -1951820067;
					continue;
				case 2u:
					num = ((@class.method_0() != 0) ? (-945391017) : (-546281438));
					continue;
				case 1u:
					gclass0_0.imethod_0(text, new List<string>(Class171.smethod_412(text, @class.method_8(), this)));
					num = -784129433;
					continue;
				case 0u:
					num3 = Class171.smethod_135(class154_0, @class.method_0());
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

	internal static StringComparer smethod_0()
	{
		return StringComparer.OrdinalIgnoreCase;
	}

	internal static uint smethod_1(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static Stream smethod_2(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static long smethod_3(Stream stream_0)
	{
		return stream_0.Position;
	}
}
