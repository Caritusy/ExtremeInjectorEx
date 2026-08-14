using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading;

public sealed class Class90 : Class85
{
	public Class90(GClass2 gclass2_1)
		: base(gclass2_1)
	{
	}

	protected override void method_033E()
	{
		if (!(method_2() == IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = -1426799299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -107431140)) % 4)
				{
				case 2u:
					method_3(Class171.OpenProcess(Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5, false, method_0()));
					num = (int)((num2 * 2022395663) ^ 0x3DEF602D);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (method_0() == -1)
					{
						num3 = 744273031;
						num4 = 744273031;
					}
					else
					{
						num3 = 2132824298;
						num4 = 2132824298;
					}
					num = num3 ^ ((int)num2 * -105841700);
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

	public override IntPtr method_083B(string string_0)
	{
		if (Class127.bool_0)
		{
			goto IL_03a6;
		}
		goto IL_04f3;
		IL_03a6:
		int num = 1960553540;
		goto IL_0432;
		IL_0432:
		IntPtr intptr_ = default(IntPtr);
		int int_3 = default(int);
		int num3 = default(int);
		int int_2 = default(int);
		IntPtr intPtr3 = default(IntPtr);
		Class124.Enum31 @enum = default(Class124.Enum31);
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		byte[] bytes = default(byte[]);
		int int_ = default(int);
		bool flag = default(bool);
		Class75 @class = default(Class75);
		while (true)
		{
			uint num2;
			IntPtr result;
			switch ((num2 = (uint)(num ^ 0x211458FB)) % 39)
			{
			case 38u:
			{
				int num8;
				int num9;
				if (method_11<uint>(intptr_.smethod_8(int_3)) != 0)
				{
					num8 = 616188636;
					num9 = 616188636;
				}
				else
				{
					num8 = 1024052873;
					num9 = 1024052873;
				}
				num = num8 ^ ((int)num2 * -1762768113);
				continue;
			}
			case 37u:
				break;
			case 36u:
			{
				int num14;
				int num15;
				if (!Class171.smethod_418(method_19()))
				{
					num14 = -1534524574;
					num15 = -1534524574;
				}
				else
				{
					num14 = -1303769790;
					num15 = -1303769790;
				}
				num = num14 ^ (int)(num2 * 1358446145);
				continue;
			}
			case 35u:
			{
				int num4;
				int num5;
				if (!Class127.bool_0)
				{
					num4 = 2009829680;
					num5 = 2009829680;
				}
				else
				{
					num4 = 946229225;
					num5 = 946229225;
				}
				num = num4 ^ ((int)num2 * -1540866819);
				continue;
			}
			case 34u:
				num3 = method_11<int>(intptr_.smethod_8(int_2));
				num = 1063449372;
				continue;
			case 33u:
			{
				int num12;
				int num13;
				if (intPtr3 == IntPtr.Zero)
				{
					num12 = -878964408;
					num13 = -878964408;
				}
				else
				{
					num12 = -832381458;
					num13 = -832381458;
				}
				num = num12 ^ (int)(num2 * 1548308250);
				continue;
			}
			case 31u:
				@enum |= Class124.Enum31.flag_5;
				num = (int)((num2 * 1243225975) ^ 0x216ACB97);
				continue;
			case 30u:
				@enum = Class124.Enum31.flag_1 | Class124.Enum31.flag_2 | Class124.Enum31.flag_3;
				num = (int)(num2 * 601838558) ^ -747131852;
				continue;
			case 29u:
				intptr_ = method_25(intPtr, intPtr2, intPtr3, bytes, out int_3, out int_, out int_2);
				num = 1615975944;
				continue;
			case 26u:
				goto IL_0173;
			case 25u:
			{
				int num16;
				int num17;
				if (!Class127.bool_1)
				{
					num16 = -2115250629;
					num17 = -2115250629;
				}
				else
				{
					num16 = -1487559384;
					num17 = -1487559384;
				}
				num = num16 ^ (int)(num2 * 447840823);
				continue;
			}
			case 24u:
				goto IL_01fc;
			case 23u:
				goto IL_0220;
			case 22u:
			{
				int num10;
				int num11;
				if (num3 == 0)
				{
					num10 = -233665078;
					num11 = -233665078;
				}
				else
				{
					num10 = -142609034;
					num11 = -142609034;
				}
				num = num10 ^ (int)(num2 * 1215147546);
				continue;
			}
			case 21u:
				string_0 = Path.GetFullPath(string_0);
				num = (int)(num2 * 694960030) ^ -1030275203;
				continue;
			case 20u:
				intptr_ = method_24(intPtr, intPtr2, intPtr3, bytes, out int_3, out int_, out int_2);
				num = ((int)num2 * -219424586) ^ 0x715E279C;
				continue;
			case 19u:
				flag = false;
				num = 1318797801;
				continue;
			case 17u:
				intPtr = Class171.OpenThread(@enum, false, @class.method_0());
				num = 2084340977;
				continue;
			case 15u:
				goto IL_02f6;
			case 12u:
				goto IL_0316;
			case 10u:
				goto IL_033c;
			case 7u:
				Thread.Sleep(100);
				num = 1318797801;
				continue;
			case 6u:
			{
				int num6;
				int num7;
				if (intPtr == IntPtr.Zero)
				{
					num6 = 1391663746;
					num7 = 1391663746;
				}
				else
				{
					num6 = 1225343663;
					num7 = 1225343663;
				}
				num = num6 ^ ((int)num2 * -1834997860);
				continue;
			}
			case 5u:
				goto end_IL_0432;
			case 4u:
				goto IL_03b0;
			case 3u:
				goto IL_03dc;
			case 2u:
				if (!Class171.smethod_418(method_19()))
				{
					num = 1134369794;
					continue;
				}
				result = (IntPtr)method_11<uint>(intptr_.smethod_8(int_));
				goto IL_061b;
			case 1u:
				Class171.smethod_108((Class83)this, intPtr);
				num = (int)((num2 * 1785162613) ^ 0x2A2FC9B5);
				continue;
			case 28u:
				goto IL_04f3;
			case 0u:
				throw new Exception(Class178.smethod_0(28330));
			case 8u:
				throw new UnauthorizedAccessException(Class178.smethod_0(30775));
			case 9u:
				throw new FileNotFoundException(Class178.smethod_0(28151) + string_0 + Class178.smethod_0(3656));
			case 11u:
				throw new PlatformNotSupportedException(Class178.smethod_0(30373));
			case 13u:
				throw new UnauthorizedAccessException(Class178.smethod_0(12662));
			case 14u:
				Class171.smethod_108((Class83)this, intPtr);
				throw new UnauthorizedAccessException(Class178.smethod_0(30694));
			case 16u:
				vmethod_6(intptr_);
				Class171.smethod_108((Class83)this, intPtr);
				throw new Exception(Class178.smethod_0(30909), new Win32Exception(num3));
			default:
				result = method_11<IntPtr>(intptr_.smethod_8(int_));
				goto IL_061b;
			case 27u:
				throw new MissingMethodException(Class178.smethod_0(30467));
			case 32u:
				{
					throw new UnauthorizedAccessException(Class178.smethod_0(30617));
				}
				IL_061b:
				vmethod_6(intptr_);
				Class171.smethod_108((Class83)this, intPtr);
				return result;
			}
			List<Class75> list = Class171.smethod_178(method_19());
			if (list.Count != 0)
			{
				@class = list[0];
				num = 1019469284;
				continue;
			}
			throw new InvalidOperationException(Class178.smethod_0(30564));
			IL_03dc:
			int num18;
			if (flag = Class171.smethod_296(method_19()))
			{
				num = 400719038;
				num18 = 400719038;
			}
			else
			{
				num = 1162097541;
				num18 = 1162097541;
			}
			continue;
			IL_01fc:
			int num19;
			if (File.Exists(string_0))
			{
				num = 1456769755;
				num19 = 1456769755;
			}
			else
			{
				num = 838312434;
				num19 = 838312434;
			}
			continue;
			IL_02f6:
			int num20;
			if (flag)
			{
				num = 510167614;
				num20 = 510167614;
			}
			else
			{
				num = 1834549555;
				num20 = 1834549555;
			}
			continue;
			IL_03b0:
			int num21;
			if (method_8(method_19().method_0()))
			{
				num = 1880433719;
				num21 = 1880433719;
			}
			else
			{
				num = 478909834;
				num21 = 478909834;
			}
			continue;
			IL_0316:
			int num22;
			if (Class171.ResumeThread(intPtr) == -1)
			{
				num = 825188329;
				num22 = 825188329;
			}
			else
			{
				num = 1999961644;
				num22 = 1999961644;
			}
			continue;
			IL_0173:
			GClass1 gclass1_ = Class171.smethod_42(method_19())[Class178.smethod_0(8503)] ?? throw new FileNotFoundException(Class178.smethod_0(28636));
			intPtr2 = Class171.smethod_220(gclass1_, Class178.smethod_0(28709), false);
			if (!(intPtr2 == IntPtr.Zero))
			{
				intPtr3 = Class171.smethod_220(gclass1_, Class178.smethod_0(30450), false);
				num = 277739124;
				continue;
			}
			throw new MissingMethodException(Class178.smethod_0(28726));
			IL_033c:
			int num23;
			if (Class171.SuspendThread(intPtr) != -1)
			{
				num = 703693467;
				num23 = 703693467;
			}
			else
			{
				num = 634159802;
				num23 = 634159802;
			}
			continue;
			IL_0220:
			bytes = Encoding.Unicode.GetBytes(string_0 + Class178.smethod_0(12219));
			int num24;
			if (Class171.smethod_418(method_19()))
			{
				num = 1357804677;
				num24 = 1357804677;
			}
			else
			{
				num = 2065088503;
				num24 = 2065088503;
			}
			continue;
			end_IL_0432:
			break;
		}
		goto IL_03a6;
		IL_04f3:
		int num25;
		if (!Path.IsPathRooted(string_0))
		{
			num = 253625625;
			num25 = 253625625;
		}
		else
		{
			num = 105885697;
			num25 = 105885697;
		}
		goto IL_0432;
	}

	private IntPtr method_24(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, byte[] byte_0, out int int_1, out int int_2, out int int_3)
	{
		Class124.Struct54 @struct = default(Class124.Struct54);
		IntPtr intPtr = default(IntPtr);
		Class124.Struct54 struct54_ = default(Class124.Struct54);
		while (true)
		{
			int num = 1855959020;
			while (true)
			{
				uint num2;
				bool num4;
				bool num3;
				switch ((num2 = (uint)(num ^ 0x492930F0)) % 21)
				{
				case 19u:
				{
					intPtr = Class171.smethod_141(this, intptr_2, intptr_3, byte_0, out struct54_, out int_1, out int_2, ref int_3);
					int num5;
					if (intPtr == IntPtr.Zero)
					{
						num = 584145380;
						num5 = 584145380;
					}
					else
					{
						num = 1294121464;
						num5 = 1294121464;
					}
					continue;
				}
				case 18u:
					if (!Class127.bool_0)
					{
						num = (int)(num2 * 187646562) ^ -934441781;
						continue;
					}
					num4 = Class171.Wow64SetThreadContext(intptr_1, ref struct54_);
					goto IL_006a;
				case 17u:
					Class171.ResumeThread(intptr_1);
					num = (int)((num2 * 468662225) ^ 0x34518B4F);
					continue;
				case 16u:
					Class171.ResumeThread(intptr_1);
					num = ((int)num2 * -1244131948) ^ -1129018746;
					continue;
				case 14u:
					Thread.Sleep(1);
					num = (int)(num2 * 7653905) ^ -1700216167;
					continue;
				case 13u:
				{
					int num6;
					if (struct54_.uint_18 != 51)
					{
						num = 1530387438;
						num6 = 1530387438;
					}
					else
					{
						num = 1575936827;
						num6 = 1575936827;
					}
					continue;
				}
				case 12u:
					vmethod_6(intPtr);
					num = (int)((num2 * 1170832648) ^ 0x77BF637E);
					continue;
				case 9u:
					Class171.ResumeThread(intptr_1);
					num = ((int)num2 * -743085460) ^ -386922642;
					continue;
				case 8u:
					num4 = Class171.SetThreadContext_1(intptr_1, ref struct54_);
					goto IL_006a;
				case 7u:
					num3 = Class171.GetThreadContext(intptr_1, ref struct54_);
					goto IL_0131;
				case 5u:
					Class171.smethod_108((Class83)this, intptr_1);
					num = ((int)num2 * -742034171) ^ -876346675;
					continue;
				case 3u:
					@struct.enum21_0 = Class124.Enum21.flag_2;
					struct54_ = @struct;
					if (!Class127.bool_0)
					{
						num = ((int)num2 * -904851816) ^ 0x13E1B2B1;
						continue;
					}
					num3 = Class171.Wow64GetThreadContext(intptr_1, ref struct54_);
					goto IL_0131;
				case 2u:
					Class171.smethod_108((Class83)this, intptr_1);
					num = (int)((num2 * 784945311) ^ 0x384DDBCB);
					continue;
				case 1u:
					struct54_.uint_17 = (uint)(int)intPtr;
					num = 1252952508;
					continue;
				case 0u:
					vmethod_6(intPtr);
					Class171.ResumeThread(intptr_1);
					Class171.smethod_108((Class83)this, intptr_1);
					num = (int)(num2 * 84219527) ^ -1551451817;
					continue;
				case 20u:
					break;
				case 4u:
					throw new InvalidOperationException(Class178.smethod_0(31039));
				case 6u:
					throw new UnauthorizedAccessException(Class178.smethod_0(31140));
				case 10u:
					throw new UnauthorizedAccessException(Class178.smethod_0(30974));
				case 15u:
					Class171.SuspendThread(intptr_1);
					return method_24(intptr_1, intptr_2, intptr_3, byte_0, out int_1, out int_2, out int_3);
				default:
					{
						return intPtr;
					}
					IL_0131:
					if (!num3)
					{
						num = 2141630474;
						continue;
					}
					goto case 13u;
					IL_006a:
					if (!num4)
					{
						num = 840998701;
						continue;
					}
					goto default;
				}
				break;
			}
		}
	}

	private IntPtr method_25(IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, byte[] byte_0, out int int_1, out int int_2, out int int_3)
	{
		Class124.Struct55 struct55_ = new Class124.Struct55
		{
			enum22_0 = Class124.Enum22.flag_1
		};
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			int num = -893752807;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -227381986)) % 14)
				{
				case 12u:
					Class171.smethod_108((Class83)this, intptr_1);
					num = (int)((num2 * 850280132) ^ 0x726BDC2A);
					continue;
				case 8u:
					vmethod_6(intPtr);
					num = (int)((num2 * 1936462832) ^ 0x3BFD7B5);
					continue;
				case 7u:
				{
					struct55_.ulong_28 = (ulong)(long)intPtr;
					int num5;
					if (!Class171.smethod_367(ref struct55_, intptr_1))
					{
						num = -194459382;
						num5 = -194459382;
					}
					else
					{
						num = -1321971419;
						num5 = -1321971419;
					}
					continue;
				}
				case 6u:
					vmethod_6(intPtr);
					num = (int)((num2 * 770070303) ^ 0x1CFA6949);
					continue;
				case 5u:
					Class171.ResumeThread(intptr_1);
					num = (int)(num2 * 1879489755) ^ -1841330951;
					continue;
				case 4u:
					Class171.ResumeThread(intptr_1);
					num = (int)(num2 * 1046813426) ^ -821758584;
					continue;
				case 3u:
				{
					intPtr = Class171.smethod_177(this, intptr_2, intptr_3, byte_0, out struct55_, out int_1, out int_2, ref int_3);
					int num6;
					if (!(intPtr == IntPtr.Zero))
					{
						num = -1990609095;
						num6 = -1990609095;
					}
					else
					{
						num = -596343336;
						num6 = -596343336;
					}
					continue;
				}
				case 2u:
					Class171.smethod_108((Class83)this, intptr_1);
					num = (int)(num2 * 1320784907) ^ -1480716191;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!Class171.smethod_386(ref struct55_, intptr_1))
					{
						num3 = -778051359;
						num4 = -778051359;
					}
					else
					{
						num3 = -1953038812;
						num4 = -1953038812;
					}
					num = num3 ^ (int)(num2 * 1031457061);
					continue;
				}
				case 10u:
					break;
				case 0u:
					throw new InvalidOperationException(Class178.smethod_0(31039));
				case 11u:
					Class171.ResumeThread(intptr_1);
					Class171.smethod_108((Class83)this, intptr_1);
					throw new UnauthorizedAccessException(Class178.smethod_0(31140));
				case 13u:
					throw new UnauthorizedAccessException(Class178.smethod_0(30974));
				default:
					return intPtr;
				}
				break;
			}
		}
	}
}
