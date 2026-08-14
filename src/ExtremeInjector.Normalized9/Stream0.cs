using System;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class Stream0 : Stream, Interface0
{
	internal Enum15 enum15_0;

	internal long long_0;

	internal long long_1;

	internal IntPtr intptr_0;

	internal IntPtr intptr_1;

	internal bool bool_0;

	internal bool bool_1 = true;

	[CompilerGenerated]
	internal bool bool_2;

	public override bool CanRead
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
							num = ((enum15_0 == Enum15.const_0) ? (-1832543292) : (-1628139131)) ^ ((int)num2 * -1883396110);
							continue;
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

	public override bool CanSeek => bool_0;

	public override bool CanWrite
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
							num = ((enum15_0 == Enum15.const_1) ? 1188335210 : 1517287185) ^ ((int)num2 * -1992095951);
							continue;
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

	public override long Length
	{
		get
		{
			Class171.smethod_155(this);
			return long_0;
		}
	}

	public override long Position
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
					num = ((gclass2_0.method_10() != IntPtr.Zero) ? (-275960835) : (-1182880146)) ^ ((int)num2 * -943599107);
					continue;
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
				num = (bool_1 ? 1801232346 : 1022716463) ^ (int)(num2 * 1506402031);
				continue;
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
					num = ((long_0 + offset >= 0L) ? (-1605277974) : (-1086123456));
					continue;
					IL_0047:
					num = ((offset < 0L) ? (-2061927254) : (-593190859));
					continue;
					IL_006f:
					num = ((long_1 + offset < 0L) ? (-623977070) : (-1926981618));
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
		while (true)
		{
			uint num3;
			uint num2 = (num3 = (uint)(num ^ 0x3521FF48));
			int num7;
			int num6;
			byte[] array2;
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
				num7 = ((long_1 < long_0) ? (-1884900352) : (-1347745740));
				num = num7 ^ ((int)num3 * -917123988);
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
				num6 = ((array.Length == 0) ? 1325575800 : 228405337);
				num = num6 ^ ((int)num3 * -1193183899);
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
								num7 = ((long_1 < long_0) ? (-1884900352) : (-1347745740));
								num = num7 ^ ((int)num3 * -917123988);
								continue;
							case 19u:
								array2 = (array = buffer);
								num = ((array2 != null) ? 1393662523 : 243940135);
								continue;
							case 17u:
								num = ((count >= 0) ? 1205737655 : 718908136);
								continue;
							case 16u:
								num = (Class171.ReadProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), ptr + offset, (UIntPtr)(ulong)num5, &uIntPtr) ? 1718637327 : 1215664866);
								continue;
							case 15u:
								num = ((buffer.Length - offset < count) ? 103696877 : 23937579);
								continue;
							case 14u:
								long_1 += num4;
								num = ((int)num3 * -1131824927) ^ 0x4B635FDC;
								continue;
							case 13u:
								num = ((!CanRead) ? 776692189 : 983408507);
								continue;
							case 12u:
								num = ((long_1 + num5 < long_0) ? 679136695 : 1104500166);
								continue;
							case 11u:
								num = (int)(num3 * 498717340) ^ -461642524;
								continue;
							case 9u:
								num6 = ((array.Length == 0) ? 1325575800 : 228405337);
								num = num6 ^ ((int)num3 * -1193183899);
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
								num = ((offset < 0) ? 169837394 : 1404091671);
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
			num = ((array2 != null) ? 1393662523 : 243940135);
			continue;
			IL_0189:
			num = ((long_1 + num5 < long_0) ? 679136695 : 1104500166);
			continue;
			IL_011f:
			num = ((buffer.Length - offset < count) ? 103696877 : 23937579);
			continue;
			IL_00d7:
			num = (Class171.ReadProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + offset, (UIntPtr)(ulong)num5, &uIntPtr) ? 1718637327 : 1215664866);
			continue;
			IL_0165:
			num = ((!CanRead) ? 776692189 : 983408507);
			continue;
			IL_00b7:
			num = ((count >= 0) ? 1205737655 : 718908136);
			continue;
			end_IL_021c:
			break;
		}
		goto IL_020d;
		IL_02a6:
		num = ((offset < 0) ? 169837394 : 1404091671);
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
		ref byte reference = default(ref byte);
		while (true)
		{
			uint num3;
			uint num2 = (num3 = (uint)(num ^ -1271568356));
			int num5;
			bool num7;
			byte[] array2;
			int num6;
			int num4;
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
								num = (flag ? (-794367956) : (-225128688));
								continue;
							case 21u:
								num = ((!CanWrite) ? (-1417446855) : (-1241113410));
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
								num5 = ((array.Length == 0) ? 1701273162 : 524776130);
								num = num5 ^ ((int)num3 * -392540205);
								continue;
							case 15u:
								num = -597439955;
								continue;
							case 14u:
								goto end_IL_003a;
							case 11u:
								num7 = (flag = Class171.WriteProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), ptr + offset, (UIntPtr)(ulong)count, &uIntPtr));
								num = ((!num7) ? (-384108756) : (-477288837));
								continue;
							case 10u:
								Class171.smethod_155(this);
								array2 = (array = buffer);
								num = ((array2 == null) ? (-1679734478) : (-678543436));
								continue;
							case 8u:
								num6 = (method_0() ? 1369262209 : 2129095275);
								num = num6 ^ ((int)num3 * -337412229);
								continue;
							case 7u:
								num = ((buffer.Length - offset < count) ? (-740929808) : (-2102421327));
								continue;
							case 5u:
								num4 = ((!Class171.VirtualProtectEx(intptr_0, intptr_1.smethod_9(long_1), (UIntPtr)(ulong)count, Class124.Enum34.flag_2, out enum34_)) ? (-149352974) : (-1105346113));
								num = num4 ^ ((int)num3 * -1244290579);
								continue;
							case 3u:
								num = ((count >= 0) ? (-342171725) : (-980091795));
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
								num = ((offset >= 0) ? (-1429984345) : (-1124984904));
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
				num5 = ((array.Length == 0) ? 1701273162 : 524776130);
				num = num5 ^ ((int)num3 * -392540205);
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
				num6 = (method_0() ? 1369262209 : 2129095275);
				num = num6 ^ ((int)num3 * -337412229);
				continue;
			case 7u:
				goto IL_01c8;
			case 5u:
				num4 = ((!Class171.VirtualProtectEx(intptr_0, intptr_1.smethod_9(long_1), (UIntPtr)(ulong)count, Class124.Enum34.flag_2, out enum34_)) ? (-149352974) : (-1105346113));
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
			num = (flag ? (-794367956) : (-225128688));
			continue;
			IL_0237:
			num = ((count >= 0) ? (-342171725) : (-980091795));
			continue;
			IL_0174:
			Class171.smethod_155(this);
			array2 = (array = buffer);
			num = ((array2 == null) ? (-1679734478) : (-678543436));
			continue;
			IL_012a:
			num7 = (flag = Class171.WriteProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + offset, (UIntPtr)(ulong)count, &uIntPtr));
			num = ((!num7) ? (-384108756) : (-477288837));
			continue;
			IL_01c8:
			num = ((buffer.Length - offset < count) ? (-740929808) : (-2102421327));
			continue;
			IL_004c:
			num = ((!CanWrite) ? (-1417446855) : (-1241113410));
			continue;
			end_IL_0280:
			break;
		}
		goto IL_0113;
		IL_0302:
		num = ((offset >= 0) ? (-1429984345) : (-1124984904));
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
