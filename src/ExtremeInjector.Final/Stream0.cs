using System;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class Stream0 : Stream, Interface0
{
	private Enum15 enum15_0;

	private long long_0;

	private long long_1;

	internal IntPtr intptr_0;

	private IntPtr intptr_1;

	internal bool bool_0;

	private bool bool_1 = true;

	[CompilerGenerated]
	private bool bool_2;

	public override bool System_002EIO_002EStream_002ECanRead
	{
		get
		{
			if (bool_0)
			{
				while (true)
				{
					int num = -1042226366;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1813343399)) % 5)
						{
						case 1u:
						{
							int num3;
							int num4;
							if (enum15_0 != Enum15.const_0)
							{
								num3 = -1628139131;
								num4 = -1628139131;
							}
							else
							{
								num3 = -1832543292;
								num4 = -1832543292;
							}
							num = num3 ^ ((int)num2 * -1883396110);
							continue;
						}
						case 2u:
							break;
						case 0u:
							return true;
						case 4u:
							return enum15_0 == Enum15.const_2;
						default:
							goto end_IL_0056;
						}
						break;
					}
					continue;
					end_IL_0056:
					break;
				}
			}
			return false;
		}
	}

	public override bool System_002EIO_002EStream_002ECanSeek => bool_0;

	public override bool System_002EIO_002EStream_002ECanWrite
	{
		get
		{
			if (bool_0)
			{
				while (true)
				{
					int num = -1265241371;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1254847351)) % 5)
						{
						case 1u:
						{
							int num3;
							int num4;
							if (enum15_0 != Enum15.const_1)
							{
								num3 = 1517287185;
								num4 = 1517287185;
							}
							else
							{
								num3 = 1188335210;
								num4 = 1188335210;
							}
							num = num3 ^ ((int)num2 * -1992095951);
							continue;
						}
						case 0u:
							break;
						case 2u:
							return true;
						case 4u:
							return enum15_0 == Enum15.const_2;
						default:
							goto end_IL_0057;
						}
						break;
					}
					continue;
					end_IL_0057:
					break;
				}
			}
			return false;
		}
	}

	public override long System_002EIO_002EStream_002ELength
	{
		get
		{
			Class171.smethod_155(this);
			return long_0;
		}
	}

	public override long System_002EIO_002EStream_002EPosition
	{
		get
		{
			Class171.smethod_155(this);
			return long_1;
		}
		set
		{
			Class171.smethod_155(this);
			long_1 = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_0()
	{
		return bool_2;
	}

	public Stream0(GClass2 gclass2_0, IntPtr intptr_2, Enum15 enum15_1, long long_2)
		: this((gclass2_0.method_10() != IntPtr.Zero) ? gclass2_0.method_10() : Class171.smethod_247(gclass2_0.method_0(), enum15_1), intptr_2, enum15_1, long_2)
	{
		while (true)
		{
			int num = 1167099740;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1229B333)) % 4)
				{
				case 3u:
				{
					int num3;
					int num4;
					if (!(gclass2_0.method_10() != IntPtr.Zero))
					{
						num3 = -1182880146;
						num4 = -1182880146;
					}
					else
					{
						num3 = -275960835;
						num4 = -275960835;
					}
					num = num3 ^ ((int)num2 * -943599107);
					continue;
				}
				case 1u:
					bool_1 = false;
					num = ((int)num2 * -1834432788) ^ 0x2FFFDFE1;
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

	public Stream0(IntPtr intptr_2, IntPtr intptr_3, Enum15 enum15_1, long long_2)
	{
		if (intptr_2 == IntPtr.Zero)
		{
			throw new ArgumentException(Class178.smethod_0(8595), Class178.smethod_0(8692));
		}
		if (long_2 < -1L)
		{
			throw new ArgumentException(Class178.smethod_0(8705), Class178.smethod_0(8746));
		}
		enum15_0 = enum15_1;
		long_0 = ((long_2 == -1L) ? Class171.smethod_399(this, intptr_3) : long_2);
		intptr_0 = intptr_2;
		intptr_1 = intptr_3;
		bool_0 = true;
	}

	protected override void Dispose(bool disposing)
	{
		if (intptr_0 != IntPtr.Zero)
		{
			goto IL_0015;
		}
		goto IL_00a8;
		IL_0015:
		int num = 192183772;
		goto IL_007f;
		IL_007f:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xF0FF519)) % 6)
			{
			case 4u:
				break;
			case 3u:
				base.Dispose(disposing);
				num = (int)(num2 * 664655631) ^ -623294606;
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (!bool_1)
				{
					num3 = 1022716463;
					num4 = 1022716463;
				}
				else
				{
					num3 = 1801232346;
					num4 = 1801232346;
				}
				num = num3 ^ (int)(num2 * 1506402031);
				continue;
			}
			case 0u:
				Class171.CloseHandle(intptr_0);
				intptr_0 = IntPtr.Zero;
				num = (int)(num2 * 1690911761) ^ -1177260436;
				continue;
			default:
				return;
			case 5u:
				goto IL_00a8;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0015;
		IL_00a8:
		bool_0 = false;
		num = 1592525098;
		goto IL_007f;
	}

	public override void Flush()
	{
		Class171.smethod_155(this);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		Class171.smethod_155(this);
		while (true)
		{
			int num = -2090090218;
			while (true)
			{
				uint num2;
				int num3;
				int num4;
				int num5;
				switch ((num2 = (uint)(num ^ -317985256)) % 15)
				{
				case 13u:
					long_1 += offset;
					num = -1985816602;
					continue;
				case 12u:
					switch (origin)
					{
					case SeekOrigin.Begin:
						goto IL_0047;
					case SeekOrigin.Current:
						goto IL_006f;
					case SeekOrigin.End:
						goto IL_009b;
					}
					num = (int)(num2 * 285078598) ^ -1257169470;
					continue;
				case 9u:
					goto IL_0047;
				case 7u:
					goto IL_006f;
				case 3u:
					goto IL_009b;
				case 10u:
					num = (int)((num2 * 767429352) ^ 0x2CB8304A);
					continue;
				case 5u:
					long_1 = long_0 + offset;
					num = -1432597894;
					continue;
				case 2u:
					long_1 = offset;
					num = -1226077488;
					continue;
				case 1u:
					num = (int)(num2 * 1965842504) ^ -1190610550;
					continue;
				case 0u:
					num = (int)(num2 * 1666194133) ^ -1192468462;
					continue;
				case 8u:
					break;
				case 6u:
					throw new IOException(Class178.smethod_0(8755));
				case 11u:
					throw new IOException(Class178.smethod_0(8755));
				case 14u:
					throw new IOException(Class178.smethod_0(8755));
				default:
					{
						return long_1;
					}
					IL_009b:
					if (long_0 + offset < 0L)
					{
						num = -1086123456;
						num3 = -1086123456;
					}
					else
					{
						num = -1605277974;
						num3 = -1605277974;
					}
					continue;
					IL_0047:
					if (offset >= 0L)
					{
						num = -593190859;
						num4 = -593190859;
					}
					else
					{
						num = -2061927254;
						num4 = -2061927254;
					}
					continue;
					IL_006f:
					if (long_1 + offset >= 0L)
					{
						num = -1926981618;
						num5 = -1926981618;
					}
					else
					{
						num = -623977070;
						num5 = -623977070;
					}
					continue;
				}
				break;
			}
		}
	}

	public override void SetLength(long value)
	{
		Class171.smethod_155(this);
		while (true)
		{
			int num = 1136264978;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x596BE85D)) % 3)
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
				long_0 = value;
				num = (int)((num2 * 464445026) ^ 0x8B60999);
			}
		}
	}

	public unsafe override int Read(byte[] buffer, int offset, int count)
	{
		//The blocks IL_000b, IL_001b, IL_002b, IL_004d, IL_005b, IL_0067, IL_0071, IL_0095, IL_009b, IL_00a7, IL_00b7, IL_00bb, IL_00c7, IL_00d7, IL_0103, IL_010f, IL_011f, IL_0127, IL_0133, IL_0143, IL_0165, IL_016d, IL_0179, IL_0189, IL_019a, IL_01a6, IL_01b3, IL_01c3, IL_01c9, IL_01d5, IL_01df, IL_01fb, IL_020d, IL_021c, IL_0297, IL_02a6, IL_02af, IL_02bf, IL_02cf, IL_02d1, IL_02e1, IL_02f1, IL_02f3, IL_0303 are reachable both inside and outside the pinned region starting at IL_01f3. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if (buffer == null)
		{
			goto IL_020d;
		}
		goto IL_02a6;
		IL_020d:
		int num = 2131932671;
		goto IL_021c;
		IL_021c:
		int num5 = default(int);
		ref byte reference = default(ref byte);
		int num4 = default(int);
		UIntPtr uIntPtr = default(UIntPtr);
		byte[] array = default(byte[]);
		int num6;
		while (true)
		{
			uint num3;
			uint num2 = (num3 = (uint)(num ^ 0x3521FF48));
			int num10;
			int num11;
			int num8;
			int num9;
			byte[] array2;
			int num15;
			int num7;
			int num14;
			int num12;
			int num16;
			int num13;
			switch (num2 % 26)
			{
			case 25u:
				Class171.smethod_155(this);
				num = 472018229;
				continue;
			case 24u:
				num5 = (int)(long_0 - long_1);
				num = (int)(num3 * 1435160740) ^ -442077361;
				continue;
			case 22u:
				if (long_1 >= long_0)
				{
					num10 = -1347745740;
					num11 = -1347745740;
				}
				else
				{
					num10 = -1884900352;
					num11 = -1884900352;
				}
				num = num10 ^ ((int)num3 * -917123988);
				continue;
			case 21u:
				reference = ref *(byte*)null;
				num4 = (int)uIntPtr.ToUInt32();
				num = 1424451634;
				continue;
			case 19u:
				break;
			case 17u:
				goto IL_00b7;
			case 16u:
				goto IL_00d7;
			case 15u:
				goto IL_011f;
			case 14u:
				long_1 += num4;
				num = ((int)num3 * -1131824927) ^ 0x4B635FDC;
				continue;
			case 13u:
				goto IL_0165;
			case 12u:
				goto IL_0189;
			case 11u:
				num = (int)(num3 * 498717340) ^ -461642524;
				continue;
			case 9u:
				if (array.Length != 0)
				{
					num8 = 228405337;
					num9 = 228405337;
				}
				else
				{
					num8 = 1325575800;
					num9 = 1325575800;
				}
				num = num8 ^ ((int)num3 * -1193183899);
				continue;
			case 8u:
				while (true)
				{
					IL_01eb:
					fixed (byte* ptr = &array[0])
					{
						num = 920063960;
						while (true)
						{
							num2 = (num3 = (uint)(num ^ 0x3521FF48));
							switch (num2 % 26)
							{
							case 21u:
								break;
							case 25u:
								Class171.smethod_155(this);
								num = 472018229;
								continue;
							case 24u:
								num5 = (int)(long_0 - long_1);
								num = (int)(num3 * 1435160740) ^ -442077361;
								continue;
							case 22u:
								if (long_1 >= long_0)
								{
									num10 = -1347745740;
									num11 = -1347745740;
								}
								else
								{
									num10 = -1884900352;
									num11 = -1884900352;
								}
								num = num10 ^ ((int)num3 * -917123988);
								continue;
							case 19u:
								array2 = (array = buffer);
								if (array2 == null)
								{
									num = 243940135;
									num15 = 243940135;
								}
								else
								{
									num = 1393662523;
									num15 = 1393662523;
								}
								continue;
							case 17u:
								if (count < 0)
								{
									num = 718908136;
									num7 = 718908136;
								}
								else
								{
									num = 1205737655;
									num7 = 1205737655;
								}
								continue;
							case 16u:
								if (!Class171.ReadProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), ptr + offset, (UIntPtr)(ulong)num5, &uIntPtr))
								{
									num = 1215664866;
									num14 = 1215664866;
								}
								else
								{
									num = 1718637327;
									num14 = 1718637327;
								}
								continue;
							case 15u:
								if (buffer.Length - offset >= count)
								{
									num = 23937579;
									num12 = 23937579;
								}
								else
								{
									num = 103696877;
									num12 = 103696877;
								}
								continue;
							case 14u:
								long_1 += num4;
								num = ((int)num3 * -1131824927) ^ 0x4B635FDC;
								continue;
							case 13u:
								if (CanRead)
								{
									num = 983408507;
									num16 = 983408507;
								}
								else
								{
									num = 776692189;
									num16 = 776692189;
								}
								continue;
							case 12u:
								if (long_1 + num5 >= long_0)
								{
									num = 1104500166;
									num13 = 1104500166;
								}
								else
								{
									num = 679136695;
									num13 = 679136695;
								}
								continue;
							case 11u:
								num = (int)(num3 * 498717340) ^ -461642524;
								continue;
							case 9u:
								if (array.Length != 0)
								{
									num8 = 228405337;
									num9 = 228405337;
								}
								else
								{
									num8 = 1325575800;
									num9 = 1325575800;
								}
								num = num8 ^ ((int)num3 * -1193183899);
								continue;
							case 8u:
								goto IL_01eb;
							case 7u:
								num5 = count;
								num = (int)((num3 * 8461130) ^ 0x77473D5E);
								continue;
							case 6u:
								num = 2131932671;
								continue;
							case 3u:
								goto end_IL_01eb;
							case 2u:
								if (offset >= 0)
								{
									num = 1404091671;
									num6 = 1404091671;
								}
								else
								{
									num = 169837394;
									num6 = 169837394;
								}
								continue;
							case 0u:
								throw new ArgumentOutOfRangeException(Class178.smethod_0(8869));
							case 1u:
								throw new ArgumentException(Class178.smethod_0(8887));
							default:
								return num4;
							case 5u:
								throw new InvalidOperationException(Class178.smethod_0(8960));
							case 10u:
								throw new ArgumentOutOfRangeException(Class178.smethod_0(8878));
							case 18u:
								return 0;
							case 23u:
								throw new ArgumentNullException(Class178.smethod_0(8860));
							case 20u:
								return 0;
							}
							break;
						}
					}
					goto case 21u;
					continue;
					end_IL_01eb:
					break;
				}
				goto case 3u;
			case 7u:
				num5 = count;
				num = (int)((num3 * 8461130) ^ 0x77473D5E);
				continue;
			case 6u:
				goto end_IL_021c;
			case 3u:
				reference = ref *(byte*)null;
				num = 658782929;
				continue;
			case 2u:
				goto IL_02a6;
			case 0u:
				throw new ArgumentOutOfRangeException(Class178.smethod_0(8869));
			case 1u:
				throw new ArgumentException(Class178.smethod_0(8887));
			default:
				return num4;
			case 5u:
				throw new InvalidOperationException(Class178.smethod_0(8960));
			case 10u:
				throw new ArgumentOutOfRangeException(Class178.smethod_0(8878));
			case 18u:
				return 0;
			case 23u:
				throw new ArgumentNullException(Class178.smethod_0(8860));
			case 20u:
				return 0;
			}
			array2 = (array = buffer);
			if (array2 == null)
			{
				num = 243940135;
				num15 = 243940135;
			}
			else
			{
				num = 1393662523;
				num15 = 1393662523;
			}
			continue;
			IL_0189:
			if (long_1 + num5 >= long_0)
			{
				num = 1104500166;
				num13 = 1104500166;
			}
			else
			{
				num = 679136695;
				num13 = 679136695;
			}
			continue;
			IL_011f:
			if (buffer.Length - offset >= count)
			{
				num = 23937579;
				num12 = 23937579;
			}
			else
			{
				num = 103696877;
				num12 = 103696877;
			}
			continue;
			IL_00d7:
			if (!Class171.ReadProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + offset, (UIntPtr)(ulong)num5, &uIntPtr))
			{
				num = 1215664866;
				num14 = 1215664866;
			}
			else
			{
				num = 1718637327;
				num14 = 1718637327;
			}
			continue;
			IL_0165:
			if (CanRead)
			{
				num = 983408507;
				num16 = 983408507;
			}
			else
			{
				num = 776692189;
				num16 = 776692189;
			}
			continue;
			IL_00b7:
			if (count < 0)
			{
				num = 718908136;
				num7 = 718908136;
			}
			else
			{
				num = 1205737655;
				num7 = 1205737655;
			}
			continue;
			end_IL_021c:
			break;
		}
		goto IL_020d;
		IL_02a6:
		if (offset >= 0)
		{
			num = 1404091671;
			num6 = 1404091671;
		}
		else
		{
			num = 169837394;
			num6 = 169837394;
		}
		goto IL_021c;
	}

	public unsafe override void Write(byte[] buffer, int offset, int count)
	{
		//The blocks IL_000b, IL_001b, IL_001e, IL_002a, IL_004c, IL_0054, IL_0060, IL_0070, IL_00ab, IL_00e9, IL_00ee, IL_00fa, IL_0104, IL_0113, IL_012a, IL_0158, IL_0164, IL_0174, IL_017f, IL_018b, IL_019b, IL_01a3, IL_01af, IL_01b9, IL_01c8, IL_01d0, IL_01dc, IL_01ec, IL_0215, IL_0221, IL_022b, IL_0237, IL_023b, IL_0247, IL_0267, IL_0280, IL_02f3, IL_0302, IL_030b, IL_031b, IL_032b, IL_033b, IL_034b, IL_035b are reachable both inside and outside the pinned region starting at IL_0041. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if (buffer == null)
		{
			goto IL_0113;
		}
		goto IL_0302;
		IL_0113:
		int num = -597439955;
		goto IL_0280;
		IL_0280:
		byte[] array = default(byte[]);
		bool flag = default(bool);
		Class124.Enum34 enum34_ = default(Class124.Enum34);
		UIntPtr uIntPtr = default(UIntPtr);
		int num10;
		ref byte reference = default(ref byte);
		while (true)
		{
			uint num3;
			uint num2 = (num3 = (uint)(num ^ -1271568356));
			int num13;
			int num12;
			int num6;
			int num7;
			bool num16;
			int num17;
			byte[] array2;
			int num14;
			int num8;
			int num9;
			int num15;
			int num4;
			int num5;
			int num11;
			switch (num2 % 24)
			{
			case 23u:
				break;
			case 22u:
				while (true)
				{
					fixed (byte* ptr = &array[0])
					{
						num = -1766855841;
						while (true)
						{
							num2 = (num3 = (uint)(num ^ -1271568356));
							switch (num2 % 24)
							{
							case 22u:
								break;
							case 23u:
								if (!flag)
								{
									num = -225128688;
									num13 = -225128688;
								}
								else
								{
									num = -794367956;
									num13 = -794367956;
								}
								continue;
							case 21u:
								if (CanWrite)
								{
									num = -1241113410;
									num12 = -1241113410;
								}
								else
								{
									num = -1417446855;
									num12 = -1417446855;
								}
								continue;
							case 19u:
								Class171.VirtualProtectEx(intptr_0, intptr_1.smethod_9(long_1), (UIntPtr)(ulong)count, enum34_, out enum34_);
								num = ((int)num3 * -399409082) ^ -684171031;
								continue;
							case 18u:
								flag = Class171.WriteProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), ptr + offset, (UIntPtr)(ulong)count, &uIntPtr);
								num = ((int)num3 * -1191710251) ^ 0x646714D;
								continue;
							case 16u:
								if (array.Length != 0)
								{
									num6 = 524776130;
									num7 = 524776130;
								}
								else
								{
									num6 = 1701273162;
									num7 = 1701273162;
								}
								num = num6 ^ ((int)num3 * -392540205);
								continue;
							case 15u:
								num = -597439955;
								continue;
							case 14u:
								goto end_IL_003a;
							case 11u:
								num16 = (flag = Class171.WriteProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), ptr + offset, (UIntPtr)(ulong)count, &uIntPtr));
								if (num16)
								{
									num = -477288837;
									num17 = -477288837;
								}
								else
								{
									num = -384108756;
									num17 = -384108756;
								}
								continue;
							case 10u:
								Class171.smethod_155(this);
								array2 = (array = buffer);
								if (array2 != null)
								{
									num = -678543436;
									num14 = -678543436;
								}
								else
								{
									num = -1679734478;
									num14 = -1679734478;
								}
								continue;
							case 8u:
								if (!method_0())
								{
									num8 = 2129095275;
									num9 = 2129095275;
								}
								else
								{
									num8 = 1369262209;
									num9 = 1369262209;
								}
								num = num8 ^ ((int)num3 * -337412229);
								continue;
							case 7u:
								if (buffer.Length - offset >= count)
								{
									num = -2102421327;
									num15 = -2102421327;
								}
								else
								{
									num = -740929808;
									num15 = -740929808;
								}
								continue;
							case 5u:
								if (Class171.VirtualProtectEx(intptr_0, intptr_1.smethod_9(long_1), (UIntPtr)(ulong)count, Class124.Enum34.flag_2, out enum34_))
								{
									num4 = -1105346113;
									num5 = -1105346113;
								}
								else
								{
									num4 = -149352974;
									num5 = -149352974;
								}
								num = num4 ^ ((int)num3 * -1244290579);
								continue;
							case 3u:
								if (count < 0)
								{
									num = -980091795;
									num11 = -980091795;
								}
								else
								{
									num = -342171725;
									num11 = -342171725;
								}
								continue;
							case 2u:
								goto IL_0254;
							case 0u:
								long_1 += (long)uIntPtr.ToUInt64();
								num = -1215941306;
								continue;
							default:
								return;
							case 9u:
								if (offset < 0)
								{
									num = -1124984904;
									num10 = -1124984904;
								}
								else
								{
									num = -1429984345;
									num10 = -1429984345;
								}
								continue;
							case 1u:
								throw new ArgumentOutOfRangeException(Class178.smethod_0(8878));
							case 4u:
								throw new ArgumentException(Class178.smethod_0(8887));
							case 12u:
								throw new ArgumentOutOfRangeException(Class178.smethod_0(8869));
							case 13u:
								throw new InvalidOperationException(Class178.smethod_0(9005));
							case 17u:
								throw new ArgumentNullException(Class178.smethod_0(8860));
							case 20u:
								throw new AccessViolationException();
							case 6u:
								return;
							}
							break;
						}
					}
					continue;
					end_IL_003a:
					break;
				}
				goto case 14u;
			case 21u:
				goto IL_004c;
			case 19u:
				Class171.VirtualProtectEx(intptr_0, intptr_1.smethod_9(long_1), (UIntPtr)(ulong)count, enum34_, out enum34_);
				num = ((int)num3 * -399409082) ^ -684171031;
				continue;
			case 18u:
				flag = Class171.WriteProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + offset, (UIntPtr)(ulong)count, &uIntPtr);
				num = ((int)num3 * -1191710251) ^ 0x646714D;
				continue;
			case 16u:
				if (array.Length != 0)
				{
					num6 = 524776130;
					num7 = 524776130;
				}
				else
				{
					num6 = 1701273162;
					num7 = 1701273162;
				}
				num = num6 ^ ((int)num3 * -392540205);
				continue;
			case 15u:
				goto end_IL_0280;
			case 14u:
				reference = ref *(byte*)null;
				num = -1766855841;
				continue;
			case 11u:
				goto IL_012a;
			case 10u:
				goto IL_0174;
			case 8u:
				if (!method_0())
				{
					num8 = 2129095275;
					num9 = 2129095275;
				}
				else
				{
					num8 = 1369262209;
					num9 = 1369262209;
				}
				num = num8 ^ ((int)num3 * -337412229);
				continue;
			case 7u:
				goto IL_01c8;
			case 5u:
				if (Class171.VirtualProtectEx(intptr_0, intptr_1.smethod_9(long_1), (UIntPtr)(ulong)count, Class124.Enum34.flag_2, out enum34_))
				{
					num4 = -1105346113;
					num5 = -1105346113;
				}
				else
				{
					num4 = -149352974;
					num5 = -149352974;
				}
				num = num4 ^ ((int)num3 * -1244290579);
				continue;
			case 3u:
				goto IL_0237;
			case 2u:
				goto IL_0254;
			case 0u:
				long_1 += (long)uIntPtr.ToUInt64();
				num = -1215941306;
				continue;
			default:
				return;
			case 9u:
				goto IL_0302;
			case 1u:
				throw new ArgumentOutOfRangeException(Class178.smethod_0(8878));
			case 4u:
				throw new ArgumentException(Class178.smethod_0(8887));
			case 12u:
				throw new ArgumentOutOfRangeException(Class178.smethod_0(8869));
			case 13u:
				throw new InvalidOperationException(Class178.smethod_0(9005));
			case 17u:
				throw new ArgumentNullException(Class178.smethod_0(8860));
			case 20u:
				throw new AccessViolationException();
			case 6u:
				return;
				IL_0254:
				reference = ref *(byte*)null;
				num = ((int)num3 * -848754560) ^ 0x40B2E6E2;
				continue;
			}
			if (!flag)
			{
				num = -225128688;
				num13 = -225128688;
			}
			else
			{
				num = -794367956;
				num13 = -794367956;
			}
			continue;
			IL_0237:
			if (count < 0)
			{
				num = -980091795;
				num11 = -980091795;
			}
			else
			{
				num = -342171725;
				num11 = -342171725;
			}
			continue;
			IL_0174:
			Class171.smethod_155(this);
			array2 = (array = buffer);
			if (array2 != null)
			{
				num = -678543436;
				num14 = -678543436;
			}
			else
			{
				num = -1679734478;
				num14 = -1679734478;
			}
			continue;
			IL_012a:
			num16 = (flag = Class171.WriteProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + offset, (UIntPtr)(ulong)count, &uIntPtr));
			if (num16)
			{
				num = -477288837;
				num17 = -477288837;
			}
			else
			{
				num = -384108756;
				num17 = -384108756;
			}
			continue;
			IL_01c8:
			if (buffer.Length - offset >= count)
			{
				num = -2102421327;
				num15 = -2102421327;
			}
			else
			{
				num = -740929808;
				num15 = -740929808;
			}
			continue;
			IL_004c:
			if (CanWrite)
			{
				num = -1241113410;
				num12 = -1241113410;
			}
			else
			{
				num = -1417446855;
				num12 = -1417446855;
			}
			continue;
			end_IL_0280:
			break;
		}
		goto IL_0113;
		IL_0302:
		if (offset < 0)
		{
			num = -1124984904;
			num10 = -1124984904;
		}
		else
		{
			num = -1429984345;
			num10 = -1429984345;
		}
		goto IL_0280;
	}

	public bool imethod_0(long long_2)
	{
		if (long_2 >= 0L)
		{
			return long_2 <= long_0;
		}
		return false;
	}
}
