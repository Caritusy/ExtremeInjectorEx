using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ExtremeInjector;
using Microsoft.Win32;

public sealed partial class RecoveredRuntime
{
	private static int IndexOfBytes(byte[] buffer, byte[] pattern, int startIndex)
	{
		if (buffer == null || pattern == null || startIndex < 0 || startIndex > buffer.Length)
		{
			return -1;
		}
		if (pattern.Length == 0)
		{
			return startIndex;
		}
		int lastStart = buffer.Length - pattern.Length;
		for (int i = startIndex; i <= lastStart; i++)
		{
			int j = 0;
			while (j < pattern.Length && buffer[i + j] == pattern[j])
			{
				j++;
			}
			if (j == pattern.Length)
			{
				return i;
			}
		}
		return -1;
	}

	private static int IndexOfByteString(byte[] buffer, string pattern, int startIndex)
	{
		if (pattern == null)
		{
			return -1;
		}
		byte[] bytes = new byte[pattern.Length];
		for (int i = 0; i < pattern.Length; i++)
		{
			bytes[i] = (byte)pattern[i];
		}
		return IndexOfBytes(buffer, bytes, startIndex);
	}

	private static int IndexOfMaskedByteString(byte[] buffer, string pattern, string mask, int startIndex)
	{
		if (buffer == null || pattern == null || mask == null || pattern.Length != mask.Length ||
			startIndex < 0 || startIndex > buffer.Length)
		{
			return -1;
		}
		if (pattern.Length == 0)
		{
			return startIndex;
		}
		int lastStart = buffer.Length - pattern.Length;
		for (int i = startIndex; i <= lastStart; i++)
		{
			int j = 0;
			while (j < pattern.Length && (mask[j] == '?' || buffer[i + j] == (byte)pattern[j]))
			{
				j++;
			}
			if (j == pattern.Length)
			{
				return i;
			}
		}
		return -1;
	}

	internal static long smethod_1(PeScrambler gclass4_0, byte[] byte_0, long long_0)
	{
		gclass4_0.class154_0.method_28().Position = long_0;
		long num = gclass4_0.class154_0.method_28().Length - byte_0.Length;
		int num4 = default(int);
		BinaryReader binaryReader = default(BinaryReader);
		int num5 = default(int);
		while (true)
		{
			int num2 = 854879454;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x12881092)) % 11)
				{
				case 9u:
					gclass4_0.class154_0.method_28().Position -= byte_0.Length - 1;
					num2 = 750439625;
					continue;
				case 8u:
					num4 = 1048576;
					binaryReader = new BinaryReader(gclass4_0.class154_0.method_28());
					num2 = ((int)num3 * -1994037026) ^ 0x7D1C5464;
					continue;
				case 6u:
					num5 = smethod_123(binaryReader.ReadBytes(num4), byte_0, 0);
					num2 = 1876075281;
					continue;
				case 5u:
					num4 = (int)(gclass4_0.class154_0.method_28().Length - gclass4_0.class154_0.method_28().Position);
					num2 = ((int)num3 * -1765652621) ^ 0x3DD9EC05;
					continue;
				case 4u:
					num2 = ((gclass4_0.class154_0.method_28().Position < num) ? 770768798 : 99309344);
					continue;
				case 3u:
					num2 = ((int)num3 * -445960062) ^ -1244215819;
					continue;
				case 2u:
					num2 = ((num5 == -1) ? 1510792250 : 1775606230) ^ (int)(num3 * 1949957473);
					continue;
				case 1u:
					num2 = ((gclass4_0.class154_0.method_28().Position + num4 < gclass4_0.class154_0.method_28().Length) ? 1898995925 : 714668898);
					continue;
				case 10u:
					break;
				default:
					return -1L;
				case 7u:
					return gclass4_0.class154_0.method_28().Position - num4 + num5;
				}
				break;
			}
		}
	}

	internal static void EditModuleOptions(MainForm.ModuleRow class21_0)
	{
		smethod_172(class21_0.Entry);
		ApplicationSettings.Save();
	}

	internal static IEnumerable<ResourceDirectoryNode> smethod_9(ResourceDirectoryNode class138_0)
	{
		return new PeScrambler.Class136(-2)
		{
			class138_2 = class138_0
		};
	}

	internal unsafe static int smethod_12(byte[] byte_0, byte[] byte_1, int int_0)
	{
		return IndexOfBytes(byte_0, byte_1, int_0);
#if false
		//The blocks IL_000d, IL_001e, IL_0031, IL_004a, IL_0067, IL_006c, IL_0078, IL_0088, IL_0096, IL_009a, IL_00a4, IL_00b3, IL_00c6, IL_00d7, IL_00ea, IL_00f9, IL_0105, IL_0115, IL_0133, IL_014b, IL_0163, IL_0184, IL_018e, IL_01a7, IL_01c1, IL_01c6, IL_01d2, IL_01dc, IL_01eb, IL_01fe, IL_0206, IL_0212, IL_0222, IL_022c, IL_0236, IL_023c, IL_0248, IL_0252, IL_0261, IL_0267, IL_0273, IL_027d, IL_028c, IL_02b1, IL_02c4, IL_02d4, IL_02db, IL_02e7, IL_02f4, IL_02f9, IL_0305, IL_0312, IL_0319, IL_0325, IL_0332, IL_0346, IL_03f6, IL_0402 are reachable both inside and outside the pinned region starting at IL_02a6. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000d, IL_001e, IL_0031, IL_004a, IL_0067, IL_006c, IL_0078, IL_0088, IL_00a4, IL_00b3, IL_00c6, IL_00d7, IL_00ea, IL_00f9, IL_0105, IL_0115, IL_0133, IL_014b, IL_0163, IL_0184, IL_018e, IL_01a7, IL_01c1, IL_01c6, IL_01d2, IL_01dc, IL_01eb, IL_01fe, IL_0206, IL_0212, IL_0236, IL_023c, IL_0248, IL_0252, IL_0261, IL_0267, IL_0273, IL_027d, IL_028c, IL_02b1, IL_02c4, IL_02d4, IL_02db, IL_02e7, IL_02f4, IL_02f9, IL_0305, IL_0312, IL_0319, IL_0325, IL_0332, IL_0346, IL_03f6, IL_0402 are reachable both inside and outside the pinned region starting at IL_022a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000d, IL_001e, IL_0031, IL_004a, IL_0067, IL_006c, IL_0078, IL_0088, IL_00a4, IL_00b3, IL_00c6, IL_00d7, IL_00ea, IL_00f9, IL_0105, IL_0115, IL_0133, IL_014b, IL_0163, IL_0184, IL_018e, IL_01a7, IL_01c1, IL_01c6, IL_01d2, IL_01dc, IL_01eb, IL_01fe, IL_0206, IL_0212, IL_0236, IL_023c, IL_0248, IL_0252, IL_0261, IL_0267, IL_0273, IL_027d, IL_028c, IL_029f, IL_02b1, IL_02c4, IL_02d4, IL_02db, IL_02e7, IL_02f4, IL_02f9, IL_0305, IL_0312, IL_0319, IL_0325, IL_0332, IL_0346, IL_03e9, IL_03ec, IL_03f6, IL_0402 are reachable both inside and outside the pinned region starting at IL_022a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		byte[] array;
		if ((array = byte_0) != null)
		{
			goto IL_0184;
		}
		goto IL_03e9;
		IL_0184:
		int num = -1129938379;
		goto IL_0346;
		IL_0346:
		ushort num6 = default(ushort);
		int num8 = default(int);
		byte[] array2 = default(byte[]);
		ushort num9 = default(ushort);
		int num7 = default(int);
		ref byte reference = default(ref byte);
		byte* ptr = default(byte*);
		byte* ptr5 = default(byte*);
		ref byte reference2 = default(ref byte);
		byte* ptr2 = default(byte*);
		int num4 = default(int);
		byte* ptr3 = default(byte*);
		int num5 = default(int);
		byte[] array3 = default(byte[]);
		while (true)
		{
			uint num3;
			uint num2 = (num3 = (uint)(num ^ -419083328));
			int num12;
			byte[] array4;
			int num11;
			int num10;
			switch (num2 % 36)
			{
			case 35u:
				num6++;
				num = -1243039979;
				continue;
			case 34u:
				num = (int)(num3 * 33249597) ^ -513308744;
				continue;
			case 33u:
				num8--;
				num = ((int)num3 * -1614801471) ^ 0x768B8BB2;
				continue;
			case 32u:
				array2[num9] = (byte)(num8 + 1);
				num = ((int)num3 * -671051389) ^ -1629758631;
				continue;
			case 31u:
				break;
			case 30u:
				num7 = byte_1.Length;
				num = -1062092973;
				continue;
			case 29u:
				reference = ref *(byte*)null;
				num = -583737377;
				continue;
			case 28u:
				num6 = *(ushort*)ptr;
				num = -835725628;
				continue;
			case 27u:
				num = ((int)num3 * -1309547797) ^ -2061469766;
				continue;
			case 26u:
				num9++;
				num = -239078897;
				continue;
			case 25u:
				num9 = *(ushort*)((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + num8);
				num = -534750788;
				continue;
			case 22u:
				goto IL_00ea;
			case 21u:
				ptr5 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) + byte_0.Length;
				array2 = new byte[65536];
				num = -2035543320;
				continue;
			case 20u:
				num8 = num7 - 2;
				num = ((int)num3 * -1285296076) ^ -2021163469;
				continue;
			case 19u:
				ptr2 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) + int_0;
				num = (int)((num3 * 696232750) ^ 0xEFAB5DB);
				continue;
			case 17u:
				ptr = ptr2 + num7 - 2;
				num4 = num7 - 2 + 1;
				num = (int)(num3 * 975813575) ^ -1737542274;
				continue;
			case 16u:
				goto end_IL_0346;
			case 15u:
				ptr3 = ptr - (array2[num6] - 1);
				num5 = 0;
				num = -1208200702;
				continue;
			case 14u:
				ptr += num4;
				num = (int)(num3 * 1936650610) ^ -245533493;
				continue;
			case 13u:
				num12 = ((array.Length == 0) ? (-421295107) : (-1533511196));
				num = num12 ^ (int)(num3 * 1921021894);
				continue;
			case 12u:
				num = ((int)num3 * -1787962146) ^ -378837625;
				continue;
			case 11u:
				goto IL_01fe;
			case 10u:
				while (true)
				{
					IL_0222:
					fixed (byte* ptr6 = &array3[0])
					{
						num = -331431211;
						while (true)
						{
							num2 = (num3 = (uint)(num ^ -419083328));
							switch (num2 % 36)
							{
							case 29u:
								break;
							case 35u:
								num6++;
								num = -1243039979;
								continue;
							case 34u:
								num = (int)(num3 * 33249597) ^ -513308744;
								continue;
							case 33u:
								num8--;
								num = ((int)num3 * -1614801471) ^ 0x768B8BB2;
								continue;
							case 32u:
								array2[num9] = (byte)(num8 + 1);
								num = ((int)num3 * -671051389) ^ -1629758631;
								continue;
							case 31u:
								num = ((num8 >= 0) ? (-1725701515) : (-1045775031));
								continue;
							case 30u:
								num7 = byte_1.Length;
								num = -1062092973;
								continue;
							case 28u:
								num6 = *(ushort*)ptr;
								num = -835725628;
								continue;
							case 27u:
								num = ((int)num3 * -1309547797) ^ -2061469766;
								continue;
							case 26u:
								num9++;
								num = -239078897;
								continue;
							case 25u:
								num9 = *(ushort*)(ptr6 + num8);
								num = -534750788;
								continue;
							case 22u:
								num = ((ptr3[num5] == ptr6[num5]) ? (-277024896) : (-1168458729));
								continue;
							case 21u:
								ptr5 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) + byte_0.Length;
								array2 = new byte[65536];
								num = -2035543320;
								continue;
							case 20u:
								num8 = num7 - 2;
								num = ((int)num3 * -1285296076) ^ -2021163469;
								continue;
							case 19u:
								ptr2 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) + int_0;
								num = (int)((num3 * 696232750) ^ 0xEFAB5DB);
								continue;
							case 17u:
								ptr = ptr2 + num7 - 2;
								num4 = num7 - 2 + 1;
								num = (int)(num3 * 975813575) ^ -1737542274;
								continue;
							case 16u:
								num = -1129938379;
								continue;
							case 15u:
								ptr3 = ptr - (array2[num6] - 1);
								num5 = 0;
								num = -1208200702;
								continue;
							case 14u:
								ptr += num4;
								num = (int)(num3 * 1936650610) ^ -245533493;
								continue;
							case 13u:
								num12 = ((array.Length == 0) ? (-421295107) : (-1533511196));
								num = num12 ^ (int)(num3 * 1921021894);
								continue;
							case 12u:
								num = ((int)num3 * -1787962146) ^ -378837625;
								continue;
							case 11u:
								num = ((ptr > ptr5 - num7) ? (-138394284) : (-325103780));
								continue;
							case 10u:
								goto IL_0222;
							case 9u:
								array4 = (array3 = byte_1);
								num11 = ((array4 != null) ? (-208649737) : (-395570214));
								num = num11 ^ (int)(num3 * 1890367583);
								continue;
							case 8u:
								num10 = ((array3.Length != 0) ? (-983924742) : (-47272331));
								num = num10 ^ ((int)num3 * -1750295048);
								continue;
							case 7u:
								num = (int)(num3 * 643881952) ^ -1769544971;
								continue;
							case 6u:
								while (true)
								{
									fixed (byte* ptr4 = &array[0])
									{
										num = -425128538;
										while (true)
										{
											num2 = (num3 = (uint)(num ^ -419083328));
											switch (num2 % 36)
											{
											case 6u:
												break;
											case 35u:
												num6++;
												num = -1243039979;
												continue;
											case 34u:
												num = (int)(num3 * 33249597) ^ -513308744;
												continue;
											case 33u:
												num8--;
												num = ((int)num3 * -1614801471) ^ 0x768B8BB2;
												continue;
											case 32u:
												array2[num9] = (byte)(num8 + 1);
												num = ((int)num3 * -671051389) ^ -1629758631;
												continue;
											case 31u:
												num = ((num8 >= 0) ? (-1725701515) : (-1045775031));
												continue;
											case 30u:
												num7 = byte_1.Length;
												num = -1062092973;
												continue;
											case 29u:
												ptr6 = null;
												num = -583737377;
												continue;
											case 28u:
												num6 = *(ushort*)ptr;
												num = -835725628;
												continue;
											case 27u:
												num = ((int)num3 * -1309547797) ^ -2061469766;
												continue;
											case 26u:
												num9++;
												num = -239078897;
												continue;
											case 25u:
												num9 = *(ushort*)(ptr6 + num8);
												num = -534750788;
												continue;
											case 22u:
												num = ((ptr3[num5] == ptr6[num5]) ? (-277024896) : (-1168458729));
												continue;
											case 21u:
												ptr5 = ptr4 + byte_0.Length;
												array2 = new byte[65536];
												num = -2035543320;
												continue;
											case 20u:
												num8 = num7 - 2;
												num = ((int)num3 * -1285296076) ^ -2021163469;
												continue;
											case 19u:
												ptr2 = ptr4 + int_0;
												num = (int)((num3 * 696232750) ^ 0xEFAB5DB);
												continue;
											case 17u:
												ptr = ptr2 + num7 - 2;
												num4 = num7 - 2 + 1;
												num = (int)(num3 * 975813575) ^ -1737542274;
												continue;
											case 16u:
												num = -1129938379;
												continue;
											case 15u:
												ptr3 = ptr - (array2[num6] - 1);
												num5 = 0;
												num = -1208200702;
												continue;
											case 14u:
												ptr += num4;
												num = (int)(num3 * 1936650610) ^ -245533493;
												continue;
											case 13u:
												num12 = ((array.Length == 0) ? (-421295107) : (-1533511196));
												num = num12 ^ (int)(num3 * 1921021894);
												continue;
											case 12u:
												num = ((int)num3 * -1787962146) ^ -378837625;
												continue;
											case 11u:
												num = ((ptr > ptr5 - num7) ? (-138394284) : (-325103780));
												continue;
											case 10u:
												while (true)
												{
													IL_0222_2:
													fixed (byte* ptr6 = &array3[0])
													{
														num = -331431211;
														while (true)
														{
															num2 = (num3 = (uint)(num ^ -419083328));
															switch (num2 % 36)
															{
															case 6u:
																break;
															case 29u:
																goto end_IL_022c;
															case 35u:
																num6++;
																num = -1243039979;
																continue;
															case 34u:
																num = (int)(num3 * 33249597) ^ -513308744;
																continue;
															case 33u:
																num8--;
																num = ((int)num3 * -1614801471) ^ 0x768B8BB2;
																continue;
															case 32u:
																array2[num9] = (byte)(num8 + 1);
																num = ((int)num3 * -671051389) ^ -1629758631;
																continue;
															case 31u:
																num = ((num8 >= 0) ? (-1725701515) : (-1045775031));
																continue;
															case 30u:
																num7 = byte_1.Length;
																num = -1062092973;
																continue;
															case 28u:
																num6 = *(ushort*)ptr;
																num = -835725628;
																continue;
															case 27u:
																num = ((int)num3 * -1309547797) ^ -2061469766;
																continue;
															case 26u:
																num9++;
																num = -239078897;
																continue;
															case 25u:
																num9 = *(ushort*)(ptr6 + num8);
																num = -534750788;
																continue;
															case 22u:
																num = ((ptr3[num5] == ptr6[num5]) ? (-277024896) : (-1168458729));
																continue;
															case 21u:
																ptr5 = ptr4 + byte_0.Length;
																array2 = new byte[65536];
																num = -2035543320;
																continue;
															case 20u:
																num8 = num7 - 2;
																num = ((int)num3 * -1285296076) ^ -2021163469;
																continue;
															case 19u:
																ptr2 = ptr4 + int_0;
																num = (int)((num3 * 696232750) ^ 0xEFAB5DB);
																continue;
															case 17u:
																ptr = ptr2 + num7 - 2;
																num4 = num7 - 2 + 1;
																num = (int)(num3 * 975813575) ^ -1737542274;
																continue;
															case 16u:
																num = -1129938379;
																continue;
															case 15u:
																ptr3 = ptr - (array2[num6] - 1);
																num5 = 0;
																num = -1208200702;
																continue;
															case 14u:
																ptr += num4;
																num = (int)(num3 * 1936650610) ^ -245533493;
																continue;
															case 13u:
																num12 = ((array.Length == 0) ? (-421295107) : (-1533511196));
																num = num12 ^ (int)(num3 * 1921021894);
																continue;
															case 12u:
																num = ((int)num3 * -1787962146) ^ -378837625;
																continue;
															case 11u:
																num = ((ptr > ptr5 - num7) ? (-138394284) : (-325103780));
																continue;
															case 10u:
																goto IL_0222_2;
															case 9u:
																array4 = (array3 = byte_1);
																num11 = ((array4 != null) ? (-208649737) : (-395570214));
																num = num11 ^ (int)(num3 * 1890367583);
																continue;
															case 8u:
																num10 = ((array3.Length != 0) ? (-983924742) : (-47272331));
																num = num10 ^ ((int)num3 * -1750295048);
																continue;
															case 7u:
																num = (int)(num3 * 643881952) ^ -1769544971;
																continue;
															case 5u:
																num = (int)(num3 * 1786868410) ^ -1316115011;
																continue;
															case 4u:
																num = (int)(num3 * 1618468513) ^ -516259695;
																continue;
															case 3u:
																num = ((array2[num9] != 0) ? (-958645734) : (-327904800));
																continue;
															case 2u:
																num = ((num5 >= num7) ? (-765956126) : (-1776747742));
																continue;
															case 1u:
																num = ((array2[num6] != 0) ? (-1734891529) : (-187177706));
																continue;
															case 0u:
																num5++;
																num = ((int)num3 * -115596945) ^ 0x261625C2;
																continue;
															case 23u:
																goto end_IL_029f;
															case 18u:
																return (int)(ptr3 - ptr2 + int_0);
															default:
																return smethod_152(byte_0, byte_1, int_0 + (int)(ptr - num4 + 1 - ptr2));
															}
															break;
														}
														break;
														end_IL_022c:;
													}
													goto case 29u;
												}
												break;
											case 9u:
												array4 = (array3 = byte_1);
												num11 = ((array4 != null) ? (-208649737) : (-395570214));
												num = num11 ^ (int)(num3 * 1890367583);
												continue;
											case 8u:
												num10 = ((array3.Length != 0) ? (-983924742) : (-47272331));
												num = num10 ^ ((int)num3 * -1750295048);
												continue;
											case 7u:
												num = (int)(num3 * 643881952) ^ -1769544971;
												continue;
											case 5u:
												num = (int)(num3 * 1786868410) ^ -1316115011;
												continue;
											case 4u:
												num = (int)(num3 * 1618468513) ^ -516259695;
												continue;
											case 3u:
												num = ((array2[num9] != 0) ? (-958645734) : (-327904800));
												continue;
											case 2u:
												num = ((num5 >= num7) ? (-765956126) : (-1776747742));
												continue;
											case 1u:
												num = ((array2[num6] != 0) ? (-1734891529) : (-187177706));
												continue;
											case 0u:
												num5++;
												num = ((int)num3 * -115596945) ^ 0x261625C2;
												continue;
											case 23u:
												goto end_IL_029f;
											case 18u:
												return (int)(ptr3 - ptr2 + int_0);
											default:
												return smethod_152(byte_0, byte_1, int_0 + (int)(ptr - num4 + 1 - ptr2));
											}
											break;
										}
									}
									continue;
									end_IL_029f:
									break;
								}
								goto case 23u;
							case 5u:
								num = (int)(num3 * 1786868410) ^ -1316115011;
								continue;
							case 4u:
								num = (int)(num3 * 1618468513) ^ -516259695;
								continue;
							case 3u:
								num = ((array2[num9] != 0) ? (-958645734) : (-327904800));
								continue;
							case 2u:
								num = ((num5 >= num7) ? (-765956126) : (-1776747742));
								continue;
							case 1u:
								num = ((array2[num6] != 0) ? (-1734891529) : (-187177706));
								continue;
							case 0u:
								num5++;
								num = ((int)num3 * -115596945) ^ 0x261625C2;
								continue;
							case 23u:
								reference2 = ref *(byte*)null;
								num = -1134378058;
								continue;
							case 18u:
								return (int)(ptr3 - ptr2 + int_0);
							default:
								return smethod_152(byte_0, byte_1, int_0 + (int)(ptr - num4 + 1 - ptr2));
							}
							break;
						}
					}
					break;
				}
				goto case 29u;
			case 9u:
				array4 = (array3 = byte_1);
				num11 = ((array4 != null) ? (-208649737) : (-395570214));
				num = num11 ^ (int)(num3 * 1890367583);
				continue;
			case 8u:
				num10 = ((array3.Length != 0) ? (-983924742) : (-47272331));
				num = num10 ^ ((int)num3 * -1750295048);
				continue;
			case 7u:
				num = (int)(num3 * 643881952) ^ -1769544971;
				continue;
			case 6u:
				while (true)
				{
					fixed (byte* ptr4 = &array[0])
					{
						num = -425128538;
						while (true)
						{
							num2 = (num3 = (uint)(num ^ -419083328));
							switch (num2 % 36)
							{
							case 6u:
								break;
							case 35u:
								num6++;
								num = -1243039979;
								continue;
							case 34u:
								num = (int)(num3 * 33249597) ^ -513308744;
								continue;
							case 33u:
								num8--;
								num = ((int)num3 * -1614801471) ^ 0x768B8BB2;
								continue;
							case 32u:
								array2[num9] = (byte)(num8 + 1);
								num = ((int)num3 * -671051389) ^ -1629758631;
								continue;
							case 31u:
								num = ((num8 >= 0) ? (-1725701515) : (-1045775031));
								continue;
							case 30u:
								num7 = byte_1.Length;
								num = -1062092973;
								continue;
							case 29u:
								reference = ref *(byte*)null;
								num = -583737377;
								continue;
							case 28u:
								num6 = *(ushort*)ptr;
								num = -835725628;
								continue;
							case 27u:
								num = ((int)num3 * -1309547797) ^ -2061469766;
								continue;
							case 26u:
								num9++;
								num = -239078897;
								continue;
							case 25u:
								num9 = *(ushort*)((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + num8);
								num = -534750788;
								continue;
							case 22u:
								num = ((ptr3[num5] == ((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference))[num5]) ? (-277024896) : (-1168458729));
								continue;
							case 21u:
								ptr5 = ptr4 + byte_0.Length;
								array2 = new byte[65536];
								num = -2035543320;
								continue;
							case 20u:
								num8 = num7 - 2;
								num = ((int)num3 * -1285296076) ^ -2021163469;
								continue;
							case 19u:
								ptr2 = ptr4 + int_0;
								num = (int)((num3 * 696232750) ^ 0xEFAB5DB);
								continue;
							case 17u:
								ptr = ptr2 + num7 - 2;
								num4 = num7 - 2 + 1;
								num = (int)(num3 * 975813575) ^ -1737542274;
								continue;
							case 16u:
								num = -1129938379;
								continue;
							case 15u:
								ptr3 = ptr - (array2[num6] - 1);
								num5 = 0;
								num = -1208200702;
								continue;
							case 14u:
								ptr += num4;
								num = (int)(num3 * 1936650610) ^ -245533493;
								continue;
							case 13u:
								num12 = ((array.Length == 0) ? (-421295107) : (-1533511196));
								num = num12 ^ (int)(num3 * 1921021894);
								continue;
							case 12u:
								num = ((int)num3 * -1787962146) ^ -378837625;
								continue;
							case 11u:
								num = ((ptr > ptr5 - num7) ? (-138394284) : (-325103780));
								continue;
							case 10u:
								while (true)
								{
									IL_0222_3:
									fixed (byte* ptr6 = &array3[0])
									{
										num = -331431211;
										while (true)
										{
											num2 = (num3 = (uint)(num ^ -419083328));
											switch (num2 % 36)
											{
											case 6u:
												break;
											case 29u:
												goto end_IL_022c_2;
											case 35u:
												num6++;
												num = -1243039979;
												continue;
											case 34u:
												num = (int)(num3 * 33249597) ^ -513308744;
												continue;
											case 33u:
												num8--;
												num = ((int)num3 * -1614801471) ^ 0x768B8BB2;
												continue;
											case 32u:
												array2[num9] = (byte)(num8 + 1);
												num = ((int)num3 * -671051389) ^ -1629758631;
												continue;
											case 31u:
												num = ((num8 >= 0) ? (-1725701515) : (-1045775031));
												continue;
											case 30u:
												num7 = byte_1.Length;
												num = -1062092973;
												continue;
											case 28u:
												num6 = *(ushort*)ptr;
												num = -835725628;
												continue;
											case 27u:
												num = ((int)num3 * -1309547797) ^ -2061469766;
												continue;
											case 26u:
												num9++;
												num = -239078897;
												continue;
											case 25u:
												num9 = *(ushort*)(ptr6 + num8);
												num = -534750788;
												continue;
											case 22u:
												num = ((ptr3[num5] == ptr6[num5]) ? (-277024896) : (-1168458729));
												continue;
											case 21u:
												ptr5 = ptr4 + byte_0.Length;
												array2 = new byte[65536];
												num = -2035543320;
												continue;
											case 20u:
												num8 = num7 - 2;
												num = ((int)num3 * -1285296076) ^ -2021163469;
												continue;
											case 19u:
												ptr2 = ptr4 + int_0;
												num = (int)((num3 * 696232750) ^ 0xEFAB5DB);
												continue;
											case 17u:
												ptr = ptr2 + num7 - 2;
												num4 = num7 - 2 + 1;
												num = (int)(num3 * 975813575) ^ -1737542274;
												continue;
											case 16u:
												num = -1129938379;
												continue;
											case 15u:
												ptr3 = ptr - (array2[num6] - 1);
												num5 = 0;
												num = -1208200702;
												continue;
											case 14u:
												ptr += num4;
												num = (int)(num3 * 1936650610) ^ -245533493;
												continue;
											case 13u:
												num12 = ((array.Length == 0) ? (-421295107) : (-1533511196));
												num = num12 ^ (int)(num3 * 1921021894);
												continue;
											case 12u:
												num = ((int)num3 * -1787962146) ^ -378837625;
												continue;
											case 11u:
												num = ((ptr > ptr5 - num7) ? (-138394284) : (-325103780));
												continue;
											case 10u:
												goto IL_0222_3;
											case 9u:
												array4 = (array3 = byte_1);
												num11 = ((array4 != null) ? (-208649737) : (-395570214));
												num = num11 ^ (int)(num3 * 1890367583);
												continue;
											case 8u:
												num10 = ((array3.Length != 0) ? (-983924742) : (-47272331));
												num = num10 ^ ((int)num3 * -1750295048);
												continue;
											case 7u:
												num = (int)(num3 * 643881952) ^ -1769544971;
												continue;
											case 5u:
												num = (int)(num3 * 1786868410) ^ -1316115011;
												continue;
											case 4u:
												num = (int)(num3 * 1618468513) ^ -516259695;
												continue;
											case 3u:
												num = ((array2[num9] != 0) ? (-958645734) : (-327904800));
												continue;
											case 2u:
												num = ((num5 >= num7) ? (-765956126) : (-1776747742));
												continue;
											case 1u:
												num = ((array2[num6] != 0) ? (-1734891529) : (-187177706));
												continue;
											case 0u:
												num5++;
												num = ((int)num3 * -115596945) ^ 0x261625C2;
												continue;
											case 23u:
												goto end_IL_029f_2;
											case 18u:
												return (int)(ptr3 - ptr2 + int_0);
											default:
												return smethod_152(byte_0, byte_1, int_0 + (int)(ptr - num4 + 1 - ptr2));
											}
											break;
										}
										break;
										end_IL_022c_2:;
									}
									goto case 29u;
								}
								break;
							case 9u:
								array4 = (array3 = byte_1);
								num11 = ((array4 != null) ? (-208649737) : (-395570214));
								num = num11 ^ (int)(num3 * 1890367583);
								continue;
							case 8u:
								num10 = ((array3.Length != 0) ? (-983924742) : (-47272331));
								num = num10 ^ ((int)num3 * -1750295048);
								continue;
							case 7u:
								num = (int)(num3 * 643881952) ^ -1769544971;
								continue;
							case 5u:
								num = (int)(num3 * 1786868410) ^ -1316115011;
								continue;
							case 4u:
								num = (int)(num3 * 1618468513) ^ -516259695;
								continue;
							case 3u:
								num = ((array2[num9] != 0) ? (-958645734) : (-327904800));
								continue;
							case 2u:
								num = ((num5 >= num7) ? (-765956126) : (-1776747742));
								continue;
							case 1u:
								num = ((array2[num6] != 0) ? (-1734891529) : (-187177706));
								continue;
							case 0u:
								num5++;
								num = ((int)num3 * -115596945) ^ 0x261625C2;
								continue;
							case 23u:
								goto end_IL_029f_2;
							case 18u:
								return (int)(ptr3 - ptr2 + int_0);
							default:
								return smethod_152(byte_0, byte_1, int_0 + (int)(ptr - num4 + 1 - ptr2));
							}
							break;
						}
					}
					continue;
					end_IL_029f_2:
					break;
				}
				goto IL_03e9;
			case 5u:
				num = (int)(num3 * 1786868410) ^ -1316115011;
				continue;
			case 4u:
				num = (int)(num3 * 1618468513) ^ -516259695;
				continue;
			case 3u:
				goto IL_02d4;
			case 2u:
				goto IL_02f4;
			case 1u:
				goto IL_0312;
			case 0u:
				num5++;
				num = ((int)num3 * -115596945) ^ 0x261625C2;
				continue;
			case 23u:
				goto IL_03e9;
			case 18u:
				return (int)(ptr3 - ptr2 + int_0);
			default:
				return smethod_152(byte_0, byte_1, int_0 + (int)(ptr - num4 + 1 - ptr2));
			}
			num = ((num8 >= 0) ? (-1725701515) : (-1045775031));
			continue;
			IL_0312:
			num = ((array2[num6] != 0) ? (-1734891529) : (-187177706));
			continue;
			IL_02d4:
			num = ((array2[num9] != 0) ? (-958645734) : (-327904800));
			continue;
			IL_01fe:
			num = ((ptr > ptr5 - num7) ? (-138394284) : (-325103780));
			continue;
			IL_02f4:
			num = ((num5 >= num7) ? (-765956126) : (-1776747742));
			continue;
			IL_00ea:
			num = ((ptr3[num5] == ((byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference))[num5]) ? (-277024896) : (-1168458729));
			continue;
			end_IL_0346:
			break;
		}
		goto IL_0184;
		IL_03e9:
		reference2 = ref *(byte*)null;
		num = -1134378058;
		goto IL_0346;
#endif
	}

	internal static int smethod_14(DeflateDecoder.Class182 class182_0)
	{
		return 32768 - class182_0.int_1;
	}

	internal unsafe static int smethod_17(int int_0, string string_0, string string_1, byte[] byte_0)
	{
		return IndexOfMaskedByteString(byte_0, string_0, string_1, int_0);
#if false
		//The blocks IL_000d, IL_0026, IL_0035, IL_003a, IL_0046, IL_0050, IL_005f, IL_0073, IL_007f, IL_008f, IL_0099, IL_00ae, IL_00ba, IL_00ca, IL_00d8, IL_00e4, IL_00ee, IL_00fd, IL_010b, IL_0117, IL_0121, IL_0130, IL_0138, IL_0142, IL_0156, IL_0162, IL_0172, IL_0178, IL_017e, IL_018a, IL_019a, IL_01a0, IL_01ac, IL_01bc, IL_01cb, IL_01d4, IL_01e0, IL_01ea, IL_01f9, IL_020d, IL_0219, IL_0229, IL_0237, IL_0243, IL_024d, IL_025c, IL_026f, IL_028c, IL_0298, IL_02a4, IL_02ae, IL_02bd, IL_02d8, IL_02ec, IL_02f8, IL_0308, IL_0316, IL_0322, IL_032c, IL_033b, IL_0349, IL_0355, IL_035f, IL_036e, IL_037c, IL_0388, IL_0392, IL_03a1, IL_03af, IL_03bb, IL_03c5, IL_03d4, IL_040b, IL_041f, IL_042b, IL_043b, IL_044a, IL_0458, IL_0464, IL_046e, IL_047d, IL_0489, IL_0495, IL_049f, IL_04ae, IL_04be, IL_04cd, IL_04d9, IL_04e9, IL_04f7, IL_0503, IL_050d, IL_051c, IL_052c, IL_0538, IL_0544, IL_054e, IL_055d, IL_0571, IL_057d, IL_058d, IL_05a0, IL_05ac, IL_05bc, IL_05c2, IL_05ce, IL_05de, IL_05ec, IL_05fd, IL_0609, IL_0613, IL_0622, IL_0639, IL_064f, IL_065b, IL_0665, IL_0671, IL_067f, IL_068b, IL_0698, IL_06a8, IL_06ab, IL_06b7, IL_06c5, IL_06d1, IL_06db, IL_06e5, IL_07ec, IL_07ef, IL_07f9, IL_0805, IL_0811, IL_081d, IL_0829, IL_082b, IL_0837, IL_0843, IL_084f, IL_085b, IL_0867, IL_0871, IL_087b are reachable both inside and outside the pinned region starting at IL_03e8. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000d, IL_0026, IL_0035, IL_003a, IL_0046, IL_0050, IL_005f, IL_0073, IL_007f, IL_008f, IL_0099, IL_00ae, IL_00ba, IL_00ca, IL_00d8, IL_00e4, IL_00ee, IL_00fd, IL_010b, IL_0117, IL_0121, IL_0130, IL_0138, IL_0142, IL_0156, IL_0162, IL_019a, IL_01a0, IL_01ac, IL_01bc, IL_01cb, IL_01d4, IL_01e0, IL_01ea, IL_01f9, IL_020d, IL_0219, IL_0229, IL_0237, IL_0243, IL_024d, IL_025c, IL_026f, IL_028c, IL_0298, IL_02a4, IL_02ae, IL_02bd, IL_02d8, IL_02ec, IL_02f8, IL_0308, IL_0316, IL_0322, IL_032c, IL_033b, IL_0349, IL_0355, IL_035f, IL_036e, IL_037c, IL_0388, IL_0392, IL_03a1, IL_03af, IL_03bb, IL_03c5, IL_03d4, IL_040b, IL_041f, IL_042b, IL_043b, IL_044a, IL_0458, IL_0464, IL_046e, IL_047d, IL_0489, IL_0495, IL_049f, IL_04ae, IL_04be, IL_04cd, IL_04d9, IL_04e9, IL_04f7, IL_0503, IL_050d, IL_051c, IL_052c, IL_0538, IL_0544, IL_054e, IL_055d, IL_0571, IL_057d, IL_058d, IL_05a0, IL_05ac, IL_05bc, IL_05c2, IL_05ce, IL_05de, IL_05ec, IL_05fd, IL_0609, IL_0613, IL_0622, IL_0639, IL_064f, IL_065b, IL_0665, IL_0671, IL_067f, IL_068b, IL_0698, IL_06a8, IL_06b7, IL_06c5, IL_06d1, IL_06db, IL_06e5, IL_07ec, IL_07ef, IL_07f9, IL_0805, IL_0811, IL_081d, IL_0829, IL_082b, IL_0837, IL_0843, IL_084f, IL_085b, IL_0867, IL_0871, IL_087b are reachable both inside and outside the pinned region starting at IL_0173. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000d, IL_0026, IL_0035, IL_003a, IL_0046, IL_0050, IL_005f, IL_0073, IL_007f, IL_008f, IL_0099, IL_00ae, IL_00ba, IL_00ca, IL_00d8, IL_00e4, IL_00ee, IL_00fd, IL_010b, IL_0117, IL_0121, IL_0142, IL_0156, IL_0162, IL_019a, IL_01a0, IL_01ac, IL_01bc, IL_01cb, IL_01d4, IL_01e0, IL_01ea, IL_01f9, IL_020d, IL_0219, IL_0229, IL_0237, IL_0243, IL_024d, IL_025c, IL_026f, IL_028c, IL_0298, IL_02a4, IL_02ae, IL_02bd, IL_02d8, IL_02ec, IL_02f8, IL_0308, IL_0316, IL_0322, IL_032c, IL_033b, IL_0349, IL_0355, IL_035f, IL_036e, IL_037c, IL_0388, IL_0392, IL_03a1, IL_03af, IL_03bb, IL_03c5, IL_03d4, IL_040b, IL_041f, IL_042b, IL_043b, IL_044a, IL_0458, IL_0464, IL_046e, IL_047d, IL_0489, IL_0495, IL_049f, IL_04ae, IL_04be, IL_04cd, IL_04d9, IL_04e9, IL_04f7, IL_0503, IL_050d, IL_051c, IL_052c, IL_0538, IL_0544, IL_054e, IL_055d, IL_0571, IL_057d, IL_058d, IL_05a0, IL_05ac, IL_05bc, IL_05c2, IL_05ce, IL_05de, IL_05ec, IL_05fd, IL_0609, IL_0613, IL_0622, IL_0639, IL_064f, IL_065b, IL_0665, IL_0671, IL_067f, IL_068b, IL_06b7, IL_06c5, IL_06d1, IL_06db, IL_06e5, IL_07f9, IL_0805, IL_0811, IL_081d, IL_0829, IL_082b, IL_0837, IL_0843, IL_084f, IL_085b, IL_0867, IL_0871, IL_087b are reachable both inside and outside the pinned region starting at IL_0137. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000d, IL_0026, IL_0035, IL_003a, IL_0046, IL_0050, IL_005f, IL_0073, IL_007f, IL_008f, IL_0099, IL_00ae, IL_00ba, IL_00ca, IL_00d8, IL_00e4, IL_00ee, IL_00fd, IL_010b, IL_0117, IL_0121, IL_0142, IL_0156, IL_0162, IL_0172, IL_019a, IL_01a0, IL_01ac, IL_01bc, IL_01cb, IL_01d4, IL_01e0, IL_01ea, IL_01f9, IL_020d, IL_0219, IL_0229, IL_0237, IL_0243, IL_024d, IL_025c, IL_026f, IL_028c, IL_0298, IL_02a4, IL_02ae, IL_02bd, IL_02d8, IL_02ec, IL_02f8, IL_0308, IL_0316, IL_0322, IL_032c, IL_033b, IL_0349, IL_0355, IL_035f, IL_036e, IL_037c, IL_0388, IL_0392, IL_03a1, IL_03af, IL_03bb, IL_03c5, IL_03d4, IL_040b, IL_041f, IL_042b, IL_043b, IL_044a, IL_0458, IL_0464, IL_046e, IL_047d, IL_0489, IL_0495, IL_049f, IL_04ae, IL_04be, IL_04cd, IL_04d9, IL_04e9, IL_04f7, IL_0503, IL_050d, IL_051c, IL_052c, IL_0538, IL_0544, IL_054e, IL_055d, IL_0571, IL_057d, IL_058d, IL_05a0, IL_05ac, IL_05bc, IL_05c2, IL_05ce, IL_05de, IL_05ec, IL_05fd, IL_0609, IL_0613, IL_0622, IL_0639, IL_064f, IL_065b, IL_0665, IL_0671, IL_067f, IL_068b, IL_06ab, IL_06b7, IL_06c5, IL_06d1, IL_06db, IL_06e5, IL_07f9, IL_0805, IL_0811, IL_081d, IL_0829, IL_082b, IL_0837, IL_0843, IL_084f, IL_085b, IL_0867, IL_0871, IL_087b are reachable both inside and outside the pinned region starting at IL_0137. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000d, IL_0026, IL_0035, IL_003a, IL_0046, IL_0050, IL_005f, IL_0073, IL_007f, IL_008f, IL_0099, IL_00ae, IL_00ba, IL_00ca, IL_00d8, IL_00e4, IL_00ee, IL_00fd, IL_010b, IL_0117, IL_0121, IL_0142, IL_0156, IL_0162, IL_0172, IL_0178, IL_017e, IL_018a, IL_019a, IL_01a0, IL_01ac, IL_01bc, IL_01cb, IL_01d4, IL_01e0, IL_01ea, IL_01f9, IL_020d, IL_0219, IL_0229, IL_0237, IL_0243, IL_024d, IL_025c, IL_026f, IL_028c, IL_0298, IL_02a4, IL_02ae, IL_02bd, IL_02d8, IL_02ec, IL_02f8, IL_0308, IL_0316, IL_0322, IL_032c, IL_033b, IL_0349, IL_0355, IL_035f, IL_036e, IL_037c, IL_0388, IL_0392, IL_03a1, IL_03af, IL_03bb, IL_03c5, IL_03d4, IL_03e7, IL_040b, IL_041f, IL_042b, IL_043b, IL_044a, IL_0458, IL_0464, IL_046e, IL_047d, IL_0489, IL_0495, IL_049f, IL_04ae, IL_04be, IL_04cd, IL_04d9, IL_04e9, IL_04f7, IL_0503, IL_050d, IL_051c, IL_052c, IL_0538, IL_0544, IL_054e, IL_055d, IL_0571, IL_057d, IL_058d, IL_05a0, IL_05ac, IL_05bc, IL_05c2, IL_05ce, IL_05de, IL_05ec, IL_05fd, IL_0609, IL_0613, IL_0622, IL_0639, IL_064f, IL_065b, IL_0665, IL_0671, IL_067f, IL_068b, IL_06ab, IL_06af, IL_06b0, IL_06b7, IL_06c5, IL_06d1, IL_06db, IL_06e5, IL_07f9, IL_0805, IL_0811, IL_081d, IL_0829, IL_082b, IL_0837, IL_0843, IL_084f, IL_085b, IL_0867, IL_0871, IL_087b are reachable both inside and outside the pinned region starting at IL_0137. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		byte[] array;
		if ((array = byte_0) != null)
		{
			goto IL_008f;
		}
		goto IL_07ec;
		IL_008f:
		int num = -1665081844;
		goto IL_06e5;
		IL_06e5:
		byte* ptr7 = default(byte*);
		ref byte reference = default(ref byte);
		int num7 = default(int);
		byte* ptr2 = default(byte*);
		char* ptr3 = default(char*);
		byte* ptr = default(byte*);
		char* ptr4 = default(char*);
		ulong num5 = default(ulong);
		byte b = default(byte);
		byte* ptr6 = default(byte*);
		while (true)
		{
			uint num3;
			uint num2 = (num3 = (uint)(num ^ -365176481));
			int num21;
			int num14;
			int num12;
			int num20;
			int num6;
			int num13;
			int num19;
			int num17;
			int num15;
			int num9;
			int num11;
			int num22;
			int num18;
			int num16;
			int num10;
			int num8;
			int num4;
			switch (num2 % 61)
			{
			case 60u:
				ptr7 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + int_0;
				num = ((int)num3 * -532873121) ^ -862370226;
				continue;
			case 59u:
				num7 = *(int*)ptr2;
				num = -468261644;
				continue;
			case 58u:
				num21 = ((array.Length != 0) ? 989267473 : 889770294);
				num = num21 ^ ((int)num3 * -532192968);
				continue;
			case 57u:
				break;
			case 54u:
				goto end_IL_06e5;
			case 53u:
				goto IL_0099;
			case 52u:
				num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
				num = num14 ^ (int)(num3 * 952758559);
				continue;
			case 50u:
				num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
				num = num12 ^ ((int)num3 * -1309906003);
				continue;
			case 49u:
				while (true)
				{
					fixed (byte* ptr5 = &array[0])
					{
						num = -365908208;
						while (true)
						{
							num2 = (num3 = (uint)(num ^ -365176481));
							switch (num2 % 61)
							{
							case 49u:
								break;
							case 60u:
								ptr7 = ptr5 + int_0;
								num = ((int)num3 * -532873121) ^ -862370226;
								continue;
							case 59u:
								num7 = *(int*)ptr2;
								num = -468261644;
								continue;
							case 58u:
								num21 = ((array.Length != 0) ? 989267473 : 889770294);
								num = num21 ^ ((int)num3 * -532192968);
								continue;
							case 57u:
								num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
								continue;
							case 54u:
								num = -1665081844;
								continue;
							case 53u:
								num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
								continue;
							case 52u:
								num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
								num = num14 ^ (int)(num3 * 952758559);
								continue;
							case 50u:
								num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
								num = num12 ^ ((int)num3 * -1309906003);
								continue;
							case 48u:
								num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
								continue;
							case 47u:
								text2 = string_1;
								ptr3 = (char*)(nint)text2;
								num = ((ptr3 == null) ? (-45909674) : (-761675787));
								continue;
							case 46u:
								num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
								continue;
							case 45u:
								num5 = *(ulong*)ptr;
								num = -175932393;
								continue;
							case 44u:
								num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
								num = num20 ^ ((int)num3 * -1521996513);
								continue;
							case 43u:
								num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
								continue;
							case 42u:
								num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
								num = num6 ^ ((int)num3 * -1526451258);
								continue;
							case 40u:
								num = ((int)num3 * -1760778114) ^ -947094406;
								continue;
							case 39u:
								ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
								num = (int)(num3 * 1856495725) ^ -962392268;
								continue;
							case 38u:
								num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
								num = num13 ^ ((int)num3 * -1028200843);
								continue;
							case 36u:
								ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
								num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
								continue;
							case 35u:
								num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
								continue;
							case 34u:
								num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
								num = num19 ^ ((int)num3 * -1372792833);
								continue;
							case 33u:
								num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
								num = num17 ^ (int)(num3 * 694607493);
								continue;
							case 32u:
								num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
								num = num15 ^ (int)(num3 * 1837507049);
								continue;
							case 31u:
								num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
								num = num9 ^ (int)(num3 * 1942369578);
								continue;
							case 30u:
								num = ((int)num3 * -1551642925) ^ -500874067;
								continue;
							case 29u:
								while (true)
								{
									fixed (string text = string_0)
									{
										ptr4 = (char*)(nint)text;
										num = ((ptr4 == null) ? (-1500356863) : (-1278502343));
										while (true)
										{
											num2 = (num3 = (uint)(num ^ -365176481));
											switch (num2 % 61)
											{
											case 29u:
												break;
											case 60u:
												ptr7 = ptr5 + int_0;
												num = ((int)num3 * -532873121) ^ -862370226;
												continue;
											case 59u:
												num7 = *(int*)ptr2;
												num = -468261644;
												continue;
											case 58u:
												num21 = ((array.Length != 0) ? 989267473 : 889770294);
												num = num21 ^ ((int)num3 * -532192968);
												continue;
											case 57u:
												num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
												continue;
											case 54u:
												num = -1665081844;
												continue;
											case 53u:
												num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
												continue;
											case 52u:
												num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
												num = num14 ^ (int)(num3 * 952758559);
												continue;
											case 50u:
												num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
												num = num12 ^ ((int)num3 * -1309906003);
												continue;
											case 49u:
												while (true)
												{
													fixed (byte* ptr5 = &array[0])
													{
														num = -365908208;
														while (true)
														{
															num2 = (num3 = (uint)(num ^ -365176481));
															switch (num2 % 61)
															{
															case 29u:
																break;
															case 49u:
																goto end_IL_0138;
															case 60u:
																ptr7 = ptr5 + int_0;
																num = ((int)num3 * -532873121) ^ -862370226;
																continue;
															case 59u:
																num7 = *(int*)ptr2;
																num = -468261644;
																continue;
															case 58u:
																num21 = ((array.Length != 0) ? 989267473 : 889770294);
																num = num21 ^ ((int)num3 * -532192968);
																continue;
															case 57u:
																num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
																continue;
															case 54u:
																num = -1665081844;
																continue;
															case 53u:
																num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
																continue;
															case 52u:
																num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
																num = num14 ^ (int)(num3 * 952758559);
																continue;
															case 50u:
																num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
																num = num12 ^ ((int)num3 * -1309906003);
																continue;
															case 48u:
																num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
																continue;
															case 47u:
																while (true)
																{
																	fixed (string text2 = string_1)
																	{
																		ptr3 = (char*)(nint)text2;
																		num = ((ptr3 == null) ? (-45909674) : (-761675787));
																		while (true)
																		{
																			num2 = (num3 = (uint)(num ^ -365176481));
																			switch (num2 % 61)
																			{
																			case 29u:
																				break;
																			case 47u:
																				goto end_IL_0178;
																			case 60u:
																				ptr7 = ptr5 + int_0;
																				num = ((int)num3 * -532873121) ^ -862370226;
																				continue;
																			case 59u:
																				num7 = *(int*)ptr2;
																				num = -468261644;
																				continue;
																			case 58u:
																				num21 = ((array.Length != 0) ? 989267473 : 889770294);
																				num = num21 ^ ((int)num3 * -532192968);
																				continue;
																			case 57u:
																				num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
																				continue;
																			case 54u:
																				num = -1665081844;
																				continue;
																			case 53u:
																				num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
																				continue;
																			case 52u:
																				num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
																				num = num14 ^ (int)(num3 * 952758559);
																				continue;
																			case 50u:
																				num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
																				num = num12 ^ ((int)num3 * -1309906003);
																				continue;
																			case 49u:
																				while (true)
																				{
																					fixed (byte* ptr5 = &array[0])
																					{
																						num = -365908208;
																						while (true)
																						{
																							num2 = (num3 = (uint)(num ^ -365176481));
																							switch (num2 % 61)
																							{
																							case 29u:
																								break;
																							case 47u:
																								goto end_IL_0178;
																							case 49u:
																								goto end_IL_0138_2;
																							case 60u:
																								ptr7 = ptr5 + int_0;
																								num = ((int)num3 * -532873121) ^ -862370226;
																								continue;
																							case 59u:
																								num7 = *(int*)ptr2;
																								num = -468261644;
																								continue;
																							case 58u:
																								num21 = ((array.Length != 0) ? 989267473 : 889770294);
																								num = num21 ^ ((int)num3 * -532192968);
																								continue;
																							case 57u:
																								num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
																								continue;
																							case 54u:
																								num = -1665081844;
																								continue;
																							case 53u:
																								num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
																								continue;
																							case 52u:
																								num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
																								num = num14 ^ (int)(num3 * 952758559);
																								continue;
																							case 50u:
																								num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
																								num = num12 ^ ((int)num3 * -1309906003);
																								continue;
																							case 48u:
																								num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
																								continue;
																							case 46u:
																								num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
																								continue;
																							case 45u:
																								num5 = *(ulong*)ptr;
																								num = -175932393;
																								continue;
																							case 44u:
																								num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
																								num = num20 ^ ((int)num3 * -1521996513);
																								continue;
																							case 43u:
																								num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
																								continue;
																							case 42u:
																								num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
																								num = num6 ^ ((int)num3 * -1526451258);
																								continue;
																							case 40u:
																								num = ((int)num3 * -1760778114) ^ -947094406;
																								continue;
																							case 39u:
																								ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
																								num = (int)(num3 * 1856495725) ^ -962392268;
																								continue;
																							case 38u:
																								num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
																								num = num13 ^ ((int)num3 * -1028200843);
																								continue;
																							case 36u:
																								ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
																								num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
																								continue;
																							case 35u:
																								num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
																								continue;
																							case 34u:
																								num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
																								num = num19 ^ ((int)num3 * -1372792833);
																								continue;
																							case 33u:
																								num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
																								num = num17 ^ (int)(num3 * 694607493);
																								continue;
																							case 32u:
																								num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
																								num = num15 ^ (int)(num3 * 1837507049);
																								continue;
																							case 31u:
																								num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
																								num = num9 ^ (int)(num3 * 1942369578);
																								continue;
																							case 30u:
																								num = ((int)num3 * -1551642925) ^ -500874067;
																								continue;
																							case 28u:
																								num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
																								continue;
																							case 27u:
																								b = (byte)(*ptr4);
																								num = -1295512042;
																								continue;
																							case 26u:
																								num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
																								num = num11 ^ (int)(num3 * 548081056);
																								continue;
																							case 25u:
																								num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
																								num = num22 ^ (int)(num3 * 1698295174);
																								continue;
																							case 24u:
																								ptr2 += 4;
																								num = -319008360;
																								continue;
																							case 23u:
																								num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
																								continue;
																							case 22u:
																								num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
																								num = num18 ^ ((int)num3 * -1570396110);
																								continue;
																							case 21u:
																								ptr += 8;
																								num = -1147100231;
																								continue;
																							case 20u:
																								num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
																								num = num16 ^ ((int)num3 * -365153547);
																								continue;
																							case 18u:
																								num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
																								continue;
																							case 17u:
																								num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
																								continue;
																							case 14u:
																								num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
																								continue;
																							case 12u:
																								ptr2 = ptr7;
																								num = -319008360;
																								continue;
																							case 10u:
																								num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
																								num = num10 ^ ((int)num3 * -2047740790);
																								continue;
																							case 7u:
																								ptr = ptr7;
																								num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
																								continue;
																							case 5u:
																								ptr6 = ptr5 + byte_0.Length - string_0.Length;
																								num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
																								num = num8 ^ ((int)num3 * -683634994);
																								continue;
																							case 4u:
																								num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
																								continue;
																							case 3u:
																								goto IL_0698;
																							case 2u:
																								goto IL_06ab;
																							case 0u:
																								num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
																								num = num4 ^ (int)(num3 * 1098314894);
																								continue;
																							case 37u:
																								goto IL_07ec_2;
																							case 1u:
																								return (int)(ptr2 + 3 - ptr5);
																							case 6u:
																								return (int)(ptr + 3 - ptr5);
																							case 8u:
																								return (int)(ptr2 + 1 - ptr5);
																							case 9u:
																								return (int)(ptr + 6 - ptr5);
																							default:
																								return -1;
																							case 13u:
																								return (int)(ptr + 7 - ptr5);
																							case 15u:
																								return (int)(ptr + 4 - ptr5);
																							case 16u:
																								return (int)(ptr2 + 2 - ptr5);
																							case 19u:
																								return (int)(ptr + 5 - ptr5);
																							case 41u:
																								return (int)(ptr + 2 - ptr5);
																							case 51u:
																								return (int)(ptr - ptr5);
																							case 55u:
																								return (int)(ptr2 - ptr5);
																							case 56u:
																								return (int)(ptr + 1 - ptr5);
																							}
																							break;
																						}
																						break;
																						end_IL_0138_2:;
																					}
																				}
																				break;
																			case 48u:
																				num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
																				continue;
																			case 46u:
																				num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
																				continue;
																			case 45u:
																				num5 = *(ulong*)ptr;
																				num = -175932393;
																				continue;
																			case 44u:
																				num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
																				num = num20 ^ ((int)num3 * -1521996513);
																				continue;
																			case 43u:
																				num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
																				continue;
																			case 42u:
																				num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
																				num = num6 ^ ((int)num3 * -1526451258);
																				continue;
																			case 40u:
																				num = ((int)num3 * -1760778114) ^ -947094406;
																				continue;
																			case 39u:
																				ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
																				num = (int)(num3 * 1856495725) ^ -962392268;
																				continue;
																			case 38u:
																				num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
																				num = num13 ^ ((int)num3 * -1028200843);
																				continue;
																			case 36u:
																				ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
																				num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
																				continue;
																			case 35u:
																				num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
																				continue;
																			case 34u:
																				num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
																				num = num19 ^ ((int)num3 * -1372792833);
																				continue;
																			case 33u:
																				num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
																				num = num17 ^ (int)(num3 * 694607493);
																				continue;
																			case 32u:
																				num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
																				num = num15 ^ (int)(num3 * 1837507049);
																				continue;
																			case 31u:
																				num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
																				num = num9 ^ (int)(num3 * 1942369578);
																				continue;
																			case 30u:
																				num = ((int)num3 * -1551642925) ^ -500874067;
																				continue;
																			case 28u:
																				num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
																				continue;
																			case 27u:
																				b = (byte)(*ptr4);
																				num = -1295512042;
																				continue;
																			case 26u:
																				num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
																				num = num11 ^ (int)(num3 * 548081056);
																				continue;
																			case 25u:
																				num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
																				num = num22 ^ (int)(num3 * 1698295174);
																				continue;
																			case 24u:
																				ptr2 += 4;
																				num = -319008360;
																				continue;
																			case 23u:
																				num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
																				continue;
																			case 22u:
																				num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
																				num = num18 ^ ((int)num3 * -1570396110);
																				continue;
																			case 21u:
																				ptr += 8;
																				num = -1147100231;
																				continue;
																			case 20u:
																				num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
																				num = num16 ^ ((int)num3 * -365153547);
																				continue;
																			case 18u:
																				num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
																				continue;
																			case 17u:
																				num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
																				continue;
																			case 14u:
																				num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
																				continue;
																			case 12u:
																				ptr2 = ptr7;
																				num = -319008360;
																				continue;
																			case 10u:
																				num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
																				num = num10 ^ ((int)num3 * -2047740790);
																				continue;
																			case 7u:
																				ptr = ptr7;
																				num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
																				continue;
																			case 5u:
																				ptr6 = ptr5 + byte_0.Length - string_0.Length;
																				num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
																				num = num8 ^ ((int)num3 * -683634994);
																				continue;
																			case 4u:
																				num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
																				continue;
																			case 3u:
																				goto IL_0698;
																			case 2u:
																				goto IL_06ab;
																			case 0u:
																				num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
																				num = num4 ^ (int)(num3 * 1098314894);
																				continue;
																			case 37u:
																				goto IL_07ec_2;
																			case 1u:
																				return (int)(ptr2 + 3 - ptr5);
																			case 6u:
																				return (int)(ptr + 3 - ptr5);
																			case 8u:
																				return (int)(ptr2 + 1 - ptr5);
																			case 9u:
																				return (int)(ptr + 6 - ptr5);
																			default:
																				return -1;
																			case 13u:
																				return (int)(ptr + 7 - ptr5);
																			case 15u:
																				return (int)(ptr + 4 - ptr5);
																			case 16u:
																				return (int)(ptr2 + 2 - ptr5);
																			case 19u:
																				return (int)(ptr + 5 - ptr5);
																			case 41u:
																				return (int)(ptr + 2 - ptr5);
																			case 51u:
																				return (int)(ptr - ptr5);
																			case 55u:
																				return (int)(ptr2 - ptr5);
																			case 56u:
																				{
																					return (int)(ptr + 1 - ptr5);
																				}
																				IL_07ec_2:
																				ptr5 = null;
																				num = -1403802540;
																				continue;
																				IL_0698:
																				ptr5 = null;
																				num = (int)((num3 * 1768218667) ^ 0x7D687283);
																				continue;
																			}
																			break;
																		}
																		break;
																		end_IL_0178:;
																	}
																}
																break;
															case 46u:
																num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
																continue;
															case 45u:
																num5 = *(ulong*)ptr;
																num = -175932393;
																continue;
															case 44u:
																num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
																num = num20 ^ ((int)num3 * -1521996513);
																continue;
															case 43u:
																num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
																continue;
															case 42u:
																num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
																num = num6 ^ ((int)num3 * -1526451258);
																continue;
															case 40u:
																num = ((int)num3 * -1760778114) ^ -947094406;
																continue;
															case 39u:
																ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
																num = (int)(num3 * 1856495725) ^ -962392268;
																continue;
															case 38u:
																num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
																num = num13 ^ ((int)num3 * -1028200843);
																continue;
															case 36u:
																ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
																num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
																continue;
															case 35u:
																num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
																continue;
															case 34u:
																num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
																num = num19 ^ ((int)num3 * -1372792833);
																continue;
															case 33u:
																num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
																num = num17 ^ (int)(num3 * 694607493);
																continue;
															case 32u:
																num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
																num = num15 ^ (int)(num3 * 1837507049);
																continue;
															case 31u:
																num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
																num = num9 ^ (int)(num3 * 1942369578);
																continue;
															case 30u:
																num = ((int)num3 * -1551642925) ^ -500874067;
																continue;
															case 28u:
																num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
																continue;
															case 27u:
																b = (byte)(*ptr4);
																num = -1295512042;
																continue;
															case 26u:
																num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
																num = num11 ^ (int)(num3 * 548081056);
																continue;
															case 25u:
																num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
																num = num22 ^ (int)(num3 * 1698295174);
																continue;
															case 24u:
																ptr2 += 4;
																num = -319008360;
																continue;
															case 23u:
																num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
																continue;
															case 22u:
																num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
																num = num18 ^ ((int)num3 * -1570396110);
																continue;
															case 21u:
																ptr += 8;
																num = -1147100231;
																continue;
															case 20u:
																num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
																num = num16 ^ ((int)num3 * -365153547);
																continue;
															case 18u:
																num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
																continue;
															case 17u:
																num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
																continue;
															case 14u:
																num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
																continue;
															case 12u:
																ptr2 = ptr7;
																num = -319008360;
																continue;
															case 10u:
																num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
																num = num10 ^ ((int)num3 * -2047740790);
																continue;
															case 7u:
																ptr = ptr7;
																num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
																continue;
															case 5u:
																ptr6 = ptr5 + byte_0.Length - string_0.Length;
																num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
																num = num8 ^ ((int)num3 * -683634994);
																continue;
															case 4u:
																num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
																continue;
															case 3u:
																goto IL_0698_2;
															case 2u:
																goto IL_06ab;
															case 0u:
																num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
																num = num4 ^ (int)(num3 * 1098314894);
																continue;
															case 37u:
																goto IL_07ec_3;
															case 1u:
																return (int)(ptr2 + 3 - ptr5);
															case 6u:
																return (int)(ptr + 3 - ptr5);
															case 8u:
																return (int)(ptr2 + 1 - ptr5);
															case 9u:
																return (int)(ptr + 6 - ptr5);
															default:
																return -1;
															case 13u:
																return (int)(ptr + 7 - ptr5);
															case 15u:
																return (int)(ptr + 4 - ptr5);
															case 16u:
																return (int)(ptr2 + 2 - ptr5);
															case 19u:
																return (int)(ptr + 5 - ptr5);
															case 41u:
																return (int)(ptr + 2 - ptr5);
															case 51u:
																return (int)(ptr - ptr5);
															case 55u:
																return (int)(ptr2 - ptr5);
															case 56u:
																{
																	return (int)(ptr + 1 - ptr5);
																}
																IL_06ab:
																text2 = null;
																goto end_IL_03e7;
															}
															break;
														}
														break;
														end_IL_0138:;
													}
												}
												break;
											case 48u:
												num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
												continue;
											case 47u:
												while (true)
												{
													fixed (string text2 = string_1)
													{
														ptr3 = (char*)(nint)text2;
														num = ((ptr3 == null) ? (-45909674) : (-761675787));
														while (true)
														{
															num2 = (num3 = (uint)(num ^ -365176481));
															switch (num2 % 61)
															{
															case 29u:
																break;
															case 47u:
																goto end_IL_0178_2;
															case 60u:
																ptr7 = ptr5 + int_0;
																num = ((int)num3 * -532873121) ^ -862370226;
																continue;
															case 59u:
																num7 = *(int*)ptr2;
																num = -468261644;
																continue;
															case 58u:
																num21 = ((array.Length != 0) ? 989267473 : 889770294);
																num = num21 ^ ((int)num3 * -532192968);
																continue;
															case 57u:
																num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
																continue;
															case 54u:
																num = -1665081844;
																continue;
															case 53u:
																num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
																continue;
															case 52u:
																num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
																num = num14 ^ (int)(num3 * 952758559);
																continue;
															case 50u:
																num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
																num = num12 ^ ((int)num3 * -1309906003);
																continue;
															case 49u:
																while (true)
																{
																	fixed (byte* ptr5 = &array[0])
																	{
																		num = -365908208;
																		while (true)
																		{
																			num2 = (num3 = (uint)(num ^ -365176481));
																			switch (num2 % 61)
																			{
																			case 29u:
																				break;
																			case 47u:
																				goto end_IL_0178_2;
																			case 49u:
																				goto end_IL_0138_3;
																			case 60u:
																				ptr7 = ptr5 + int_0;
																				num = ((int)num3 * -532873121) ^ -862370226;
																				continue;
																			case 59u:
																				num7 = *(int*)ptr2;
																				num = -468261644;
																				continue;
																			case 58u:
																				num21 = ((array.Length != 0) ? 989267473 : 889770294);
																				num = num21 ^ ((int)num3 * -532192968);
																				continue;
																			case 57u:
																				num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
																				continue;
																			case 54u:
																				num = -1665081844;
																				continue;
																			case 53u:
																				num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
																				continue;
																			case 52u:
																				num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
																				num = num14 ^ (int)(num3 * 952758559);
																				continue;
																			case 50u:
																				num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
																				num = num12 ^ ((int)num3 * -1309906003);
																				continue;
																			case 48u:
																				num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
																				continue;
																			case 46u:
																				num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
																				continue;
																			case 45u:
																				num5 = *(ulong*)ptr;
																				num = -175932393;
																				continue;
																			case 44u:
																				num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
																				num = num20 ^ ((int)num3 * -1521996513);
																				continue;
																			case 43u:
																				num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
																				continue;
																			case 42u:
																				num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
																				num = num6 ^ ((int)num3 * -1526451258);
																				continue;
																			case 40u:
																				num = ((int)num3 * -1760778114) ^ -947094406;
																				continue;
																			case 39u:
																				ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
																				num = (int)(num3 * 1856495725) ^ -962392268;
																				continue;
																			case 38u:
																				num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
																				num = num13 ^ ((int)num3 * -1028200843);
																				continue;
																			case 36u:
																				ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
																				num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
																				continue;
																			case 35u:
																				num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
																				continue;
																			case 34u:
																				num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
																				num = num19 ^ ((int)num3 * -1372792833);
																				continue;
																			case 33u:
																				num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
																				num = num17 ^ (int)(num3 * 694607493);
																				continue;
																			case 32u:
																				num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
																				num = num15 ^ (int)(num3 * 1837507049);
																				continue;
																			case 31u:
																				num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
																				num = num9 ^ (int)(num3 * 1942369578);
																				continue;
																			case 30u:
																				num = ((int)num3 * -1551642925) ^ -500874067;
																				continue;
																			case 28u:
																				num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
																				continue;
																			case 27u:
																				b = (byte)(*ptr4);
																				num = -1295512042;
																				continue;
																			case 26u:
																				num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
																				num = num11 ^ (int)(num3 * 548081056);
																				continue;
																			case 25u:
																				num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
																				num = num22 ^ (int)(num3 * 1698295174);
																				continue;
																			case 24u:
																				ptr2 += 4;
																				num = -319008360;
																				continue;
																			case 23u:
																				num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
																				continue;
																			case 22u:
																				num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
																				num = num18 ^ ((int)num3 * -1570396110);
																				continue;
																			case 21u:
																				ptr += 8;
																				num = -1147100231;
																				continue;
																			case 20u:
																				num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
																				num = num16 ^ ((int)num3 * -365153547);
																				continue;
																			case 18u:
																				num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
																				continue;
																			case 17u:
																				num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
																				continue;
																			case 14u:
																				num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
																				continue;
																			case 12u:
																				ptr2 = ptr7;
																				num = -319008360;
																				continue;
																			case 10u:
																				num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
																				num = num10 ^ ((int)num3 * -2047740790);
																				continue;
																			case 7u:
																				ptr = ptr7;
																				num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
																				continue;
																			case 5u:
																				ptr6 = ptr5 + byte_0.Length - string_0.Length;
																				num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
																				num = num8 ^ ((int)num3 * -683634994);
																				continue;
																			case 4u:
																				num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
																				continue;
																			case 3u:
																				goto IL_0698_3;
																			case 2u:
																				goto IL_06ab_2;
																			case 0u:
																				num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
																				num = num4 ^ (int)(num3 * 1098314894);
																				continue;
																			case 37u:
																				goto IL_07ec_4;
																			case 1u:
																				return (int)(ptr2 + 3 - ptr5);
																			case 6u:
																				return (int)(ptr + 3 - ptr5);
																			case 8u:
																				return (int)(ptr2 + 1 - ptr5);
																			case 9u:
																				return (int)(ptr + 6 - ptr5);
																			default:
																				return -1;
																			case 13u:
																				return (int)(ptr + 7 - ptr5);
																			case 15u:
																				return (int)(ptr + 4 - ptr5);
																			case 16u:
																				return (int)(ptr2 + 2 - ptr5);
																			case 19u:
																				return (int)(ptr + 5 - ptr5);
																			case 41u:
																				return (int)(ptr + 2 - ptr5);
																			case 51u:
																				return (int)(ptr - ptr5);
																			case 55u:
																				return (int)(ptr2 - ptr5);
																			case 56u:
																				return (int)(ptr + 1 - ptr5);
																			}
																			break;
																		}
																		break;
																		end_IL_0138_3:;
																	}
																}
																break;
															case 48u:
																num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
																continue;
															case 46u:
																num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
																continue;
															case 45u:
																num5 = *(ulong*)ptr;
																num = -175932393;
																continue;
															case 44u:
																num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
																num = num20 ^ ((int)num3 * -1521996513);
																continue;
															case 43u:
																num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
																continue;
															case 42u:
																num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
																num = num6 ^ ((int)num3 * -1526451258);
																continue;
															case 40u:
																num = ((int)num3 * -1760778114) ^ -947094406;
																continue;
															case 39u:
																ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
																num = (int)(num3 * 1856495725) ^ -962392268;
																continue;
															case 38u:
																num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
																num = num13 ^ ((int)num3 * -1028200843);
																continue;
															case 36u:
																ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
																num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
																continue;
															case 35u:
																num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
																continue;
															case 34u:
																num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
																num = num19 ^ ((int)num3 * -1372792833);
																continue;
															case 33u:
																num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
																num = num17 ^ (int)(num3 * 694607493);
																continue;
															case 32u:
																num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
																num = num15 ^ (int)(num3 * 1837507049);
																continue;
															case 31u:
																num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
																num = num9 ^ (int)(num3 * 1942369578);
																continue;
															case 30u:
																num = ((int)num3 * -1551642925) ^ -500874067;
																continue;
															case 28u:
																num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
																continue;
															case 27u:
																b = (byte)(*ptr4);
																num = -1295512042;
																continue;
															case 26u:
																num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
																num = num11 ^ (int)(num3 * 548081056);
																continue;
															case 25u:
																num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
																num = num22 ^ (int)(num3 * 1698295174);
																continue;
															case 24u:
																ptr2 += 4;
																num = -319008360;
																continue;
															case 23u:
																num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
																continue;
															case 22u:
																num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
																num = num18 ^ ((int)num3 * -1570396110);
																continue;
															case 21u:
																ptr += 8;
																num = -1147100231;
																continue;
															case 20u:
																num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
																num = num16 ^ ((int)num3 * -365153547);
																continue;
															case 18u:
																num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
																continue;
															case 17u:
																num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
																continue;
															case 14u:
																num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
																continue;
															case 12u:
																ptr2 = ptr7;
																num = -319008360;
																continue;
															case 10u:
																num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
																num = num10 ^ ((int)num3 * -2047740790);
																continue;
															case 7u:
																ptr = ptr7;
																num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
																continue;
															case 5u:
																ptr6 = ptr5 + byte_0.Length - string_0.Length;
																num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
																num = num8 ^ ((int)num3 * -683634994);
																continue;
															case 4u:
																num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
																continue;
															case 3u:
																goto IL_0698_3;
															case 2u:
																goto IL_06ab_2;
															case 0u:
																num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
																num = num4 ^ (int)(num3 * 1098314894);
																continue;
															case 37u:
																goto IL_07ec_4;
															case 1u:
																return (int)(ptr2 + 3 - ptr5);
															case 6u:
																return (int)(ptr + 3 - ptr5);
															case 8u:
																return (int)(ptr2 + 1 - ptr5);
															case 9u:
																return (int)(ptr + 6 - ptr5);
															default:
																return -1;
															case 13u:
																return (int)(ptr + 7 - ptr5);
															case 15u:
																return (int)(ptr + 4 - ptr5);
															case 16u:
																return (int)(ptr2 + 2 - ptr5);
															case 19u:
																return (int)(ptr + 5 - ptr5);
															case 41u:
																return (int)(ptr + 2 - ptr5);
															case 51u:
																return (int)(ptr - ptr5);
															case 55u:
																return (int)(ptr2 - ptr5);
															case 56u:
																{
																	return (int)(ptr + 1 - ptr5);
																}
																IL_07ec_4:
																ptr5 = null;
																num = -1403802540;
																continue;
																IL_0698_3:
																ptr5 = null;
																num = (int)((num3 * 1768218667) ^ 0x7D687283);
																continue;
															}
															break;
														}
														break;
														end_IL_0178_2:;
													}
												}
												break;
											case 46u:
												num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
												continue;
											case 45u:
												num5 = *(ulong*)ptr;
												num = -175932393;
												continue;
											case 44u:
												num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
												num = num20 ^ ((int)num3 * -1521996513);
												continue;
											case 43u:
												num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
												continue;
											case 42u:
												num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
												num = num6 ^ ((int)num3 * -1526451258);
												continue;
											case 40u:
												num = ((int)num3 * -1760778114) ^ -947094406;
												continue;
											case 39u:
												ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
												num = (int)(num3 * 1856495725) ^ -962392268;
												continue;
											case 38u:
												num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
												num = num13 ^ ((int)num3 * -1028200843);
												continue;
											case 36u:
												ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
												num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
												continue;
											case 35u:
												num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
												continue;
											case 34u:
												num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
												num = num19 ^ ((int)num3 * -1372792833);
												continue;
											case 33u:
												num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
												num = num17 ^ (int)(num3 * 694607493);
												continue;
											case 32u:
												num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
												num = num15 ^ (int)(num3 * 1837507049);
												continue;
											case 31u:
												num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
												num = num9 ^ (int)(num3 * 1942369578);
												continue;
											case 30u:
												num = ((int)num3 * -1551642925) ^ -500874067;
												continue;
											case 28u:
												num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
												continue;
											case 27u:
												b = (byte)(*ptr4);
												num = -1295512042;
												continue;
											case 26u:
												num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
												num = num11 ^ (int)(num3 * 548081056);
												continue;
											case 25u:
												num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
												num = num22 ^ (int)(num3 * 1698295174);
												continue;
											case 24u:
												ptr2 += 4;
												num = -319008360;
												continue;
											case 23u:
												num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
												continue;
											case 22u:
												num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
												num = num18 ^ ((int)num3 * -1570396110);
												continue;
											case 21u:
												ptr += 8;
												num = -1147100231;
												continue;
											case 20u:
												num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
												num = num16 ^ ((int)num3 * -365153547);
												continue;
											case 18u:
												num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
												continue;
											case 17u:
												num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
												continue;
											case 14u:
												num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
												continue;
											case 12u:
												ptr2 = ptr7;
												num = -319008360;
												continue;
											case 10u:
												num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
												num = num10 ^ ((int)num3 * -2047740790);
												continue;
											case 7u:
												ptr = ptr7;
												num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
												continue;
											case 5u:
												ptr6 = ptr5 + byte_0.Length - string_0.Length;
												num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
												num = num8 ^ ((int)num3 * -683634994);
												continue;
											case 4u:
												num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
												continue;
											case 3u:
												goto IL_0698_2;
											case 2u:
												goto IL_06ab_2;
											case 0u:
												num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
												num = num4 ^ (int)(num3 * 1098314894);
												continue;
											case 37u:
												goto IL_07ec_3;
											case 1u:
												return (int)(ptr2 + 3 - ptr5);
											case 6u:
												return (int)(ptr + 3 - ptr5);
											case 8u:
												return (int)(ptr2 + 1 - ptr5);
											case 9u:
												return (int)(ptr + 6 - ptr5);
											default:
												return -1;
											case 13u:
												return (int)(ptr + 7 - ptr5);
											case 15u:
												return (int)(ptr + 4 - ptr5);
											case 16u:
												return (int)(ptr2 + 2 - ptr5);
											case 19u:
												return (int)(ptr + 5 - ptr5);
											case 41u:
												return (int)(ptr + 2 - ptr5);
											case 51u:
												return (int)(ptr - ptr5);
											case 55u:
												return (int)(ptr2 - ptr5);
											case 56u:
												{
													return (int)(ptr + 1 - ptr5);
												}
												IL_07ec_3:
												ptr5 = null;
												num = -1403802540;
												continue;
												IL_0698_2:
												ptr5 = null;
												num = (int)((num3 * 1768218667) ^ 0x7D687283);
												continue;
												IL_06ab_2:
												text2 = null;
												goto end_IL_03e7;
											}
											break;
										}
									}
									continue;
									end_IL_03e7:
									break;
								}
								goto IL_06b0;
							case 28u:
								num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
								continue;
							case 27u:
								b = (byte)(*ptr4);
								num = -1295512042;
								continue;
							case 26u:
								num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
								num = num11 ^ (int)(num3 * 548081056);
								continue;
							case 25u:
								num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
								num = num22 ^ (int)(num3 * 1698295174);
								continue;
							case 24u:
								ptr2 += 4;
								num = -319008360;
								continue;
							case 23u:
								num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
								continue;
							case 22u:
								num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
								num = num18 ^ ((int)num3 * -1570396110);
								continue;
							case 21u:
								ptr += 8;
								num = -1147100231;
								continue;
							case 20u:
								num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
								num = num16 ^ ((int)num3 * -365153547);
								continue;
							case 18u:
								num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
								continue;
							case 17u:
								num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
								continue;
							case 14u:
								num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
								continue;
							case 12u:
								ptr2 = ptr7;
								num = -319008360;
								continue;
							case 10u:
								num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
								num = num10 ^ ((int)num3 * -2047740790);
								continue;
							case 7u:
								ptr = ptr7;
								num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
								continue;
							case 5u:
								ptr6 = ptr5 + byte_0.Length - string_0.Length;
								num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
								num = num8 ^ ((int)num3 * -683634994);
								continue;
							case 4u:
								num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
								continue;
							case 3u:
								goto end_IL_0130;
							case 2u:
								text2 = null;
								goto IL_06b0;
							case 0u:
								num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
								num = num4 ^ (int)(num3 * 1098314894);
								continue;
							case 37u:
								goto IL_07ec;
							case 1u:
								return (int)(ptr2 + 3 - ptr5);
							case 6u:
								return (int)(ptr + 3 - ptr5);
							case 8u:
								return (int)(ptr2 + 1 - ptr5);
							case 9u:
								return (int)(ptr + 6 - ptr5);
							default:
								return -1;
							case 13u:
								return (int)(ptr + 7 - ptr5);
							case 15u:
								return (int)(ptr + 4 - ptr5);
							case 16u:
								return (int)(ptr2 + 2 - ptr5);
							case 19u:
								return (int)(ptr + 5 - ptr5);
							case 41u:
								return (int)(ptr + 2 - ptr5);
							case 51u:
								return (int)(ptr - ptr5);
							case 55u:
								return (int)(ptr2 - ptr5);
							case 56u:
								{
									return (int)(ptr + 1 - ptr5);
								}
								IL_06b0:
								num = -1723474841;
								continue;
							}
							break;
						}
					}
					continue;
					end_IL_0130:
					break;
				}
				goto case 3u;
			case 48u:
				goto IL_0142;
			case 47u:
				goto IL_0172_3;
			case 46u:
				goto IL_019a;
			case 45u:
				num5 = *(ulong*)ptr;
				num = -175932393;
				continue;
			case 44u:
				num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
				num = num20 ^ ((int)num3 * -1521996513);
				continue;
			case 43u:
				goto IL_01f9;
			case 42u:
				num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
				num = num6 ^ ((int)num3 * -1526451258);
				continue;
			case 40u:
				num = ((int)num3 * -1760778114) ^ -947094406;
				continue;
			case 39u:
				ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
				num = (int)(num3 * 1856495725) ^ -962392268;
				continue;
			case 38u:
				num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
				num = num13 ^ ((int)num3 * -1028200843);
				continue;
			case 36u:
				ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
				num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
				continue;
			case 35u:
				goto IL_02d8;
			case 34u:
				num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
				num = num19 ^ ((int)num3 * -1372792833);
				continue;
			case 33u:
				num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
				num = num17 ^ (int)(num3 * 694607493);
				continue;
			case 32u:
				num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
				num = num15 ^ (int)(num3 * 1837507049);
				continue;
			case 31u:
				num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
				num = num9 ^ (int)(num3 * 1942369578);
				continue;
			case 30u:
				num = ((int)num3 * -1551642925) ^ -500874067;
				continue;
			case 29u:
				while (true)
				{
					fixed (string text = string_0)
					{
						ptr4 = (char*)(nint)text;
						num = ((ptr4 == null) ? (-1500356863) : (-1278502343));
						while (true)
						{
							num2 = (num3 = (uint)(num ^ -365176481));
							switch (num2 % 61)
							{
							case 29u:
								break;
							case 60u:
								ptr7 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + int_0;
								num = ((int)num3 * -532873121) ^ -862370226;
								continue;
							case 59u:
								num7 = *(int*)ptr2;
								num = -468261644;
								continue;
							case 58u:
								num21 = ((array.Length != 0) ? 989267473 : 889770294);
								num = num21 ^ ((int)num3 * -532192968);
								continue;
							case 57u:
								num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
								continue;
							case 54u:
								num = -1665081844;
								continue;
							case 53u:
								num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
								continue;
							case 52u:
								num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
								num = num14 ^ (int)(num3 * 952758559);
								continue;
							case 50u:
								num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
								num = num12 ^ ((int)num3 * -1309906003);
								continue;
							case 49u:
								while (true)
								{
									fixed (byte* ptr5 = &array[0])
									{
										num = -365908208;
										while (true)
										{
											num2 = (num3 = (uint)(num ^ -365176481));
											switch (num2 % 61)
											{
											case 29u:
												break;
											case 49u:
												goto end_IL_0138_4;
											case 60u:
												ptr7 = ptr5 + int_0;
												num = ((int)num3 * -532873121) ^ -862370226;
												continue;
											case 59u:
												num7 = *(int*)ptr2;
												num = -468261644;
												continue;
											case 58u:
												num21 = ((array.Length != 0) ? 989267473 : 889770294);
												num = num21 ^ ((int)num3 * -532192968);
												continue;
											case 57u:
												num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
												continue;
											case 54u:
												num = -1665081844;
												continue;
											case 53u:
												num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
												continue;
											case 52u:
												num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
												num = num14 ^ (int)(num3 * 952758559);
												continue;
											case 50u:
												num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
												num = num12 ^ ((int)num3 * -1309906003);
												continue;
											case 48u:
												num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
												continue;
											case 47u:
												while (true)
												{
													fixed (string text2 = string_1)
													{
														ptr3 = (char*)(nint)text2;
														num = ((ptr3 == null) ? (-45909674) : (-761675787));
														while (true)
														{
															num2 = (num3 = (uint)(num ^ -365176481));
															switch (num2 % 61)
															{
															case 29u:
																break;
															case 47u:
																goto end_IL_0178_3;
															case 60u:
																ptr7 = ptr5 + int_0;
																num = ((int)num3 * -532873121) ^ -862370226;
																continue;
															case 59u:
																num7 = *(int*)ptr2;
																num = -468261644;
																continue;
															case 58u:
																num21 = ((array.Length != 0) ? 989267473 : 889770294);
																num = num21 ^ ((int)num3 * -532192968);
																continue;
															case 57u:
																num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
																continue;
															case 54u:
																num = -1665081844;
																continue;
															case 53u:
																num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
																continue;
															case 52u:
																num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
																num = num14 ^ (int)(num3 * 952758559);
																continue;
															case 50u:
																num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
																num = num12 ^ ((int)num3 * -1309906003);
																continue;
															case 49u:
																while (true)
																{
																	fixed (byte* ptr5 = &array[0])
																	{
																		num = -365908208;
																		while (true)
																		{
																			num2 = (num3 = (uint)(num ^ -365176481));
																			switch (num2 % 61)
																			{
																			case 29u:
																				break;
																			case 47u:
																				goto end_IL_0178_3;
																			case 49u:
																				goto end_IL_0138_5;
																			case 60u:
																				ptr7 = ptr5 + int_0;
																				num = ((int)num3 * -532873121) ^ -862370226;
																				continue;
																			case 59u:
																				num7 = *(int*)ptr2;
																				num = -468261644;
																				continue;
																			case 58u:
																				num21 = ((array.Length != 0) ? 989267473 : 889770294);
																				num = num21 ^ ((int)num3 * -532192968);
																				continue;
																			case 57u:
																				num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
																				continue;
																			case 54u:
																				num = -1665081844;
																				continue;
																			case 53u:
																				num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
																				continue;
																			case 52u:
																				num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
																				num = num14 ^ (int)(num3 * 952758559);
																				continue;
																			case 50u:
																				num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
																				num = num12 ^ ((int)num3 * -1309906003);
																				continue;
																			case 48u:
																				num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
																				continue;
																			case 46u:
																				num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
																				continue;
																			case 45u:
																				num5 = *(ulong*)ptr;
																				num = -175932393;
																				continue;
																			case 44u:
																				num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
																				num = num20 ^ ((int)num3 * -1521996513);
																				continue;
																			case 43u:
																				num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
																				continue;
																			case 42u:
																				num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
																				num = num6 ^ ((int)num3 * -1526451258);
																				continue;
																			case 40u:
																				num = ((int)num3 * -1760778114) ^ -947094406;
																				continue;
																			case 39u:
																				ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
																				num = (int)(num3 * 1856495725) ^ -962392268;
																				continue;
																			case 38u:
																				num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
																				num = num13 ^ ((int)num3 * -1028200843);
																				continue;
																			case 36u:
																				ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
																				num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
																				continue;
																			case 35u:
																				num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
																				continue;
																			case 34u:
																				num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
																				num = num19 ^ ((int)num3 * -1372792833);
																				continue;
																			case 33u:
																				num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
																				num = num17 ^ (int)(num3 * 694607493);
																				continue;
																			case 32u:
																				num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
																				num = num15 ^ (int)(num3 * 1837507049);
																				continue;
																			case 31u:
																				num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
																				num = num9 ^ (int)(num3 * 1942369578);
																				continue;
																			case 30u:
																				num = ((int)num3 * -1551642925) ^ -500874067;
																				continue;
																			case 28u:
																				num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
																				continue;
																			case 27u:
																				b = (byte)(*ptr4);
																				num = -1295512042;
																				continue;
																			case 26u:
																				num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
																				num = num11 ^ (int)(num3 * 548081056);
																				continue;
																			case 25u:
																				num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
																				num = num22 ^ (int)(num3 * 1698295174);
																				continue;
																			case 24u:
																				ptr2 += 4;
																				num = -319008360;
																				continue;
																			case 23u:
																				num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
																				continue;
																			case 22u:
																				num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
																				num = num18 ^ ((int)num3 * -1570396110);
																				continue;
																			case 21u:
																				ptr += 8;
																				num = -1147100231;
																				continue;
																			case 20u:
																				num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
																				num = num16 ^ ((int)num3 * -365153547);
																				continue;
																			case 18u:
																				num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
																				continue;
																			case 17u:
																				num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
																				continue;
																			case 14u:
																				num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
																				continue;
																			case 12u:
																				ptr2 = ptr7;
																				num = -319008360;
																				continue;
																			case 10u:
																				num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
																				num = num10 ^ ((int)num3 * -2047740790);
																				continue;
																			case 7u:
																				ptr = ptr7;
																				num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
																				continue;
																			case 5u:
																				ptr6 = ptr5 + byte_0.Length - string_0.Length;
																				num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
																				num = num8 ^ ((int)num3 * -683634994);
																				continue;
																			case 4u:
																				num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
																				continue;
																			case 3u:
																				goto IL_0698_4;
																			case 2u:
																				goto IL_06ab_3;
																			case 0u:
																				num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
																				num = num4 ^ (int)(num3 * 1098314894);
																				continue;
																			case 37u:
																				goto IL_07ec_5;
																			case 1u:
																				return (int)(ptr2 + 3 - ptr5);
																			case 6u:
																				return (int)(ptr + 3 - ptr5);
																			case 8u:
																				return (int)(ptr2 + 1 - ptr5);
																			case 9u:
																				return (int)(ptr + 6 - ptr5);
																			default:
																				return -1;
																			case 13u:
																				return (int)(ptr + 7 - ptr5);
																			case 15u:
																				return (int)(ptr + 4 - ptr5);
																			case 16u:
																				return (int)(ptr2 + 2 - ptr5);
																			case 19u:
																				return (int)(ptr + 5 - ptr5);
																			case 41u:
																				return (int)(ptr + 2 - ptr5);
																			case 51u:
																				return (int)(ptr - ptr5);
																			case 55u:
																				return (int)(ptr2 - ptr5);
																			case 56u:
																				return (int)(ptr + 1 - ptr5);
																			}
																			break;
																		}
																		break;
																		end_IL_0138_5:;
																	}
																}
																break;
															case 48u:
																num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
																continue;
															case 46u:
																num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
																continue;
															case 45u:
																num5 = *(ulong*)ptr;
																num = -175932393;
																continue;
															case 44u:
																num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
																num = num20 ^ ((int)num3 * -1521996513);
																continue;
															case 43u:
																num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
																continue;
															case 42u:
																num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
																num = num6 ^ ((int)num3 * -1526451258);
																continue;
															case 40u:
																num = ((int)num3 * -1760778114) ^ -947094406;
																continue;
															case 39u:
																ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
																num = (int)(num3 * 1856495725) ^ -962392268;
																continue;
															case 38u:
																num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
																num = num13 ^ ((int)num3 * -1028200843);
																continue;
															case 36u:
																ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
																num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
																continue;
															case 35u:
																num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
																continue;
															case 34u:
																num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
																num = num19 ^ ((int)num3 * -1372792833);
																continue;
															case 33u:
																num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
																num = num17 ^ (int)(num3 * 694607493);
																continue;
															case 32u:
																num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
																num = num15 ^ (int)(num3 * 1837507049);
																continue;
															case 31u:
																num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
																num = num9 ^ (int)(num3 * 1942369578);
																continue;
															case 30u:
																num = ((int)num3 * -1551642925) ^ -500874067;
																continue;
															case 28u:
																num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
																continue;
															case 27u:
																b = (byte)(*ptr4);
																num = -1295512042;
																continue;
															case 26u:
																num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
																num = num11 ^ (int)(num3 * 548081056);
																continue;
															case 25u:
																num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
																num = num22 ^ (int)(num3 * 1698295174);
																continue;
															case 24u:
																ptr2 += 4;
																num = -319008360;
																continue;
															case 23u:
																num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
																continue;
															case 22u:
																num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
																num = num18 ^ ((int)num3 * -1570396110);
																continue;
															case 21u:
																ptr += 8;
																num = -1147100231;
																continue;
															case 20u:
																num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
																num = num16 ^ ((int)num3 * -365153547);
																continue;
															case 18u:
																num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
																continue;
															case 17u:
																num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
																continue;
															case 14u:
																num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
																continue;
															case 12u:
																ptr2 = ptr7;
																num = -319008360;
																continue;
															case 10u:
																num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
																num = num10 ^ ((int)num3 * -2047740790);
																continue;
															case 7u:
																ptr = ptr7;
																num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
																continue;
															case 5u:
																ptr6 = ptr5 + byte_0.Length - string_0.Length;
																num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
																num = num8 ^ ((int)num3 * -683634994);
																continue;
															case 4u:
																num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
																continue;
															case 3u:
																goto IL_0698_4;
															case 2u:
																goto IL_06ab_3;
															case 0u:
																num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
																num = num4 ^ (int)(num3 * 1098314894);
																continue;
															case 37u:
																goto IL_07ec_5;
															case 1u:
																return (int)(ptr2 + 3 - ptr5);
															case 6u:
																return (int)(ptr + 3 - ptr5);
															case 8u:
																return (int)(ptr2 + 1 - ptr5);
															case 9u:
																return (int)(ptr + 6 - ptr5);
															default:
																return -1;
															case 13u:
																return (int)(ptr + 7 - ptr5);
															case 15u:
																return (int)(ptr + 4 - ptr5);
															case 16u:
																return (int)(ptr2 + 2 - ptr5);
															case 19u:
																return (int)(ptr + 5 - ptr5);
															case 41u:
																return (int)(ptr + 2 - ptr5);
															case 51u:
																return (int)(ptr - ptr5);
															case 55u:
																return (int)(ptr2 - ptr5);
															case 56u:
																{
																	return (int)(ptr + 1 - ptr5);
																}
																IL_07ec_5:
																ptr5 = null;
																num = -1403802540;
																continue;
																IL_0698_4:
																ptr5 = null;
																num = (int)((num3 * 1768218667) ^ 0x7D687283);
																continue;
															}
															break;
														}
														break;
														end_IL_0178_3:;
													}
												}
												break;
											case 46u:
												num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
												continue;
											case 45u:
												num5 = *(ulong*)ptr;
												num = -175932393;
												continue;
											case 44u:
												num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
												num = num20 ^ ((int)num3 * -1521996513);
												continue;
											case 43u:
												num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
												continue;
											case 42u:
												num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
												num = num6 ^ ((int)num3 * -1526451258);
												continue;
											case 40u:
												num = ((int)num3 * -1760778114) ^ -947094406;
												continue;
											case 39u:
												ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
												num = (int)(num3 * 1856495725) ^ -962392268;
												continue;
											case 38u:
												num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
												num = num13 ^ ((int)num3 * -1028200843);
												continue;
											case 36u:
												ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
												num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
												continue;
											case 35u:
												num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
												continue;
											case 34u:
												num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
												num = num19 ^ ((int)num3 * -1372792833);
												continue;
											case 33u:
												num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
												num = num17 ^ (int)(num3 * 694607493);
												continue;
											case 32u:
												num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
												num = num15 ^ (int)(num3 * 1837507049);
												continue;
											case 31u:
												num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
												num = num9 ^ (int)(num3 * 1942369578);
												continue;
											case 30u:
												num = ((int)num3 * -1551642925) ^ -500874067;
												continue;
											case 28u:
												num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
												continue;
											case 27u:
												b = (byte)(*ptr4);
												num = -1295512042;
												continue;
											case 26u:
												num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
												num = num11 ^ (int)(num3 * 548081056);
												continue;
											case 25u:
												num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
												num = num22 ^ (int)(num3 * 1698295174);
												continue;
											case 24u:
												ptr2 += 4;
												num = -319008360;
												continue;
											case 23u:
												num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
												continue;
											case 22u:
												num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
												num = num18 ^ ((int)num3 * -1570396110);
												continue;
											case 21u:
												ptr += 8;
												num = -1147100231;
												continue;
											case 20u:
												num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
												num = num16 ^ ((int)num3 * -365153547);
												continue;
											case 18u:
												num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
												continue;
											case 17u:
												num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
												continue;
											case 14u:
												num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
												continue;
											case 12u:
												ptr2 = ptr7;
												num = -319008360;
												continue;
											case 10u:
												num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
												num = num10 ^ ((int)num3 * -2047740790);
												continue;
											case 7u:
												ptr = ptr7;
												num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
												continue;
											case 5u:
												ptr6 = ptr5 + byte_0.Length - string_0.Length;
												num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
												num = num8 ^ ((int)num3 * -683634994);
												continue;
											case 4u:
												num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
												continue;
											case 3u:
												goto IL_0698_5;
											case 2u:
												goto IL_06ab_3;
											case 0u:
												num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
												num = num4 ^ (int)(num3 * 1098314894);
												continue;
											case 37u:
												goto IL_07ec_6;
											case 1u:
												return (int)(ptr2 + 3 - ptr5);
											case 6u:
												return (int)(ptr + 3 - ptr5);
											case 8u:
												return (int)(ptr2 + 1 - ptr5);
											case 9u:
												return (int)(ptr + 6 - ptr5);
											default:
												return -1;
											case 13u:
												return (int)(ptr + 7 - ptr5);
											case 15u:
												return (int)(ptr + 4 - ptr5);
											case 16u:
												return (int)(ptr2 + 2 - ptr5);
											case 19u:
												return (int)(ptr + 5 - ptr5);
											case 41u:
												return (int)(ptr + 2 - ptr5);
											case 51u:
												return (int)(ptr - ptr5);
											case 55u:
												return (int)(ptr2 - ptr5);
											case 56u:
												{
													return (int)(ptr + 1 - ptr5);
												}
												IL_06ab_3:
												text2 = null;
												goto end_IL_03e7_2;
											}
											break;
										}
										break;
										end_IL_0138_4:;
									}
								}
								break;
							case 48u:
								num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
								continue;
							case 47u:
								while (true)
								{
									fixed (string text2 = string_1)
									{
										ptr3 = (char*)(nint)text2;
										num = ((ptr3 == null) ? (-45909674) : (-761675787));
										while (true)
										{
											num2 = (num3 = (uint)(num ^ -365176481));
											switch (num2 % 61)
											{
											case 29u:
												break;
											case 47u:
												goto end_IL_0178_4;
											case 60u:
												ptr7 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + int_0;
												num = ((int)num3 * -532873121) ^ -862370226;
												continue;
											case 59u:
												num7 = *(int*)ptr2;
												num = -468261644;
												continue;
											case 58u:
												num21 = ((array.Length != 0) ? 989267473 : 889770294);
												num = num21 ^ ((int)num3 * -532192968);
												continue;
											case 57u:
												num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
												continue;
											case 54u:
												num = -1665081844;
												continue;
											case 53u:
												num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
												continue;
											case 52u:
												num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
												num = num14 ^ (int)(num3 * 952758559);
												continue;
											case 50u:
												num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
												num = num12 ^ ((int)num3 * -1309906003);
												continue;
											case 49u:
												while (true)
												{
													fixed (byte* ptr5 = &array[0])
													{
														num = -365908208;
														while (true)
														{
															num2 = (num3 = (uint)(num ^ -365176481));
															switch (num2 % 61)
															{
															case 29u:
																break;
															case 47u:
																goto end_IL_0178_4;
															case 49u:
																goto end_IL_0138_6;
															case 60u:
																ptr7 = ptr5 + int_0;
																num = ((int)num3 * -532873121) ^ -862370226;
																continue;
															case 59u:
																num7 = *(int*)ptr2;
																num = -468261644;
																continue;
															case 58u:
																num21 = ((array.Length != 0) ? 989267473 : 889770294);
																num = num21 ^ ((int)num3 * -532192968);
																continue;
															case 57u:
																num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
																continue;
															case 54u:
																num = -1665081844;
																continue;
															case 53u:
																num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
																continue;
															case 52u:
																num14 = (smethod_375(ptr3, ptr + 1, ptr4) ? (-635583242) : (-1378573526));
																num = num14 ^ (int)(num3 * 952758559);
																continue;
															case 50u:
																num12 = (smethod_375(ptr3, ptr2 + 2, ptr4) ? (-1361720241) : (-61439958));
																num = num12 ^ ((int)num3 * -1309906003);
																continue;
															case 48u:
																num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
																continue;
															case 46u:
																num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
																continue;
															case 45u:
																num5 = *(ulong*)ptr;
																num = -175932393;
																continue;
															case 44u:
																num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
																num = num20 ^ ((int)num3 * -1521996513);
																continue;
															case 43u:
																num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
																continue;
															case 42u:
																num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
																num = num6 ^ ((int)num3 * -1526451258);
																continue;
															case 40u:
																num = ((int)num3 * -1760778114) ^ -947094406;
																continue;
															case 39u:
																ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
																num = (int)(num3 * 1856495725) ^ -962392268;
																continue;
															case 38u:
																num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
																num = num13 ^ ((int)num3 * -1028200843);
																continue;
															case 36u:
																ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
																num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
																continue;
															case 35u:
																num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
																continue;
															case 34u:
																num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
																num = num19 ^ ((int)num3 * -1372792833);
																continue;
															case 33u:
																num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
																num = num17 ^ (int)(num3 * 694607493);
																continue;
															case 32u:
																num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
																num = num15 ^ (int)(num3 * 1837507049);
																continue;
															case 31u:
																num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
																num = num9 ^ (int)(num3 * 1942369578);
																continue;
															case 30u:
																num = ((int)num3 * -1551642925) ^ -500874067;
																continue;
															case 28u:
																num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
																continue;
															case 27u:
																b = (byte)(*ptr4);
																num = -1295512042;
																continue;
															case 26u:
																num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
																num = num11 ^ (int)(num3 * 548081056);
																continue;
															case 25u:
																num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
																num = num22 ^ (int)(num3 * 1698295174);
																continue;
															case 24u:
																ptr2 += 4;
																num = -319008360;
																continue;
															case 23u:
																num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
																continue;
															case 22u:
																num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
																num = num18 ^ ((int)num3 * -1570396110);
																continue;
															case 21u:
																ptr += 8;
																num = -1147100231;
																continue;
															case 20u:
																num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
																num = num16 ^ ((int)num3 * -365153547);
																continue;
															case 18u:
																num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
																continue;
															case 17u:
																num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
																continue;
															case 14u:
																num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
																continue;
															case 12u:
																ptr2 = ptr7;
																num = -319008360;
																continue;
															case 10u:
																num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
																num = num10 ^ ((int)num3 * -2047740790);
																continue;
															case 7u:
																ptr = ptr7;
																num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
																continue;
															case 5u:
																ptr6 = ptr5 + byte_0.Length - string_0.Length;
																num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
																num = num8 ^ ((int)num3 * -683634994);
																continue;
															case 4u:
																num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
																continue;
															case 3u:
																goto IL_0698_6;
															case 2u:
																goto IL_06ab_4;
															case 0u:
																num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
																num = num4 ^ (int)(num3 * 1098314894);
																continue;
															case 37u:
																goto IL_07ec_7;
															case 1u:
																return (int)(ptr2 + 3 - ptr5);
															case 6u:
																return (int)(ptr + 3 - ptr5);
															case 8u:
																return (int)(ptr2 + 1 - ptr5);
															case 9u:
																return (int)(ptr + 6 - ptr5);
															default:
																return -1;
															case 13u:
																return (int)(ptr + 7 - ptr5);
															case 15u:
																return (int)(ptr + 4 - ptr5);
															case 16u:
																return (int)(ptr2 + 2 - ptr5);
															case 19u:
																return (int)(ptr + 5 - ptr5);
															case 41u:
																return (int)(ptr + 2 - ptr5);
															case 51u:
																return (int)(ptr - ptr5);
															case 55u:
																return (int)(ptr2 - ptr5);
															case 56u:
																return (int)(ptr + 1 - ptr5);
															}
															break;
														}
														break;
														end_IL_0138_6:;
													}
												}
												break;
											case 48u:
												num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
												continue;
											case 46u:
												num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
												continue;
											case 45u:
												num5 = *(ulong*)ptr;
												num = -175932393;
												continue;
											case 44u:
												num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
												num = num20 ^ ((int)num3 * -1521996513);
												continue;
											case 43u:
												num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
												continue;
											case 42u:
												num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
												num = num6 ^ ((int)num3 * -1526451258);
												continue;
											case 40u:
												num = ((int)num3 * -1760778114) ^ -947094406;
												continue;
											case 39u:
												ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
												num = (int)(num3 * 1856495725) ^ -962392268;
												continue;
											case 38u:
												num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
												num = num13 ^ ((int)num3 * -1028200843);
												continue;
											case 36u:
												ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
												num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
												continue;
											case 35u:
												num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
												continue;
											case 34u:
												num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
												num = num19 ^ ((int)num3 * -1372792833);
												continue;
											case 33u:
												num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
												num = num17 ^ (int)(num3 * 694607493);
												continue;
											case 32u:
												num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
												num = num15 ^ (int)(num3 * 1837507049);
												continue;
											case 31u:
												num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
												num = num9 ^ (int)(num3 * 1942369578);
												continue;
											case 30u:
												num = ((int)num3 * -1551642925) ^ -500874067;
												continue;
											case 28u:
												num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
												continue;
											case 27u:
												b = (byte)(*ptr4);
												num = -1295512042;
												continue;
											case 26u:
												num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
												num = num11 ^ (int)(num3 * 548081056);
												continue;
											case 25u:
												num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
												num = num22 ^ (int)(num3 * 1698295174);
												continue;
											case 24u:
												ptr2 += 4;
												num = -319008360;
												continue;
											case 23u:
												num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
												continue;
											case 22u:
												num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
												num = num18 ^ ((int)num3 * -1570396110);
												continue;
											case 21u:
												ptr += 8;
												num = -1147100231;
												continue;
											case 20u:
												num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
												num = num16 ^ ((int)num3 * -365153547);
												continue;
											case 18u:
												num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
												continue;
											case 17u:
												num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
												continue;
											case 14u:
												num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
												continue;
											case 12u:
												ptr2 = ptr7;
												num = -319008360;
												continue;
											case 10u:
												num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
												num = num10 ^ ((int)num3 * -2047740790);
												continue;
											case 7u:
												ptr = ptr7;
												num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
												continue;
											case 5u:
												ptr6 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + byte_0.Length - string_0.Length;
												num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
												num = num8 ^ ((int)num3 * -683634994);
												continue;
											case 4u:
												num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
												continue;
											case 3u:
												goto IL_0698_6;
											case 2u:
												goto IL_06ab_4;
											case 0u:
												num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
												num = num4 ^ (int)(num3 * 1098314894);
												continue;
											case 37u:
												goto IL_07ec_7;
											case 1u:
												return (int)(ptr2 + 3 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											case 6u:
												return (int)(ptr + 3 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											case 8u:
												return (int)(ptr2 + 1 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											case 9u:
												return (int)(ptr + 6 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											default:
												return -1;
											case 13u:
												return (int)(ptr + 7 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											case 15u:
												return (int)(ptr + 4 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											case 16u:
												return (int)(ptr2 + 2 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											case 19u:
												return (int)(ptr + 5 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											case 41u:
												return (int)(ptr + 2 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											case 51u:
												return (int)(ptr - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											case 55u:
												return (int)(ptr2 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
											case 56u:
												{
													return (int)(ptr + 1 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
												}
												IL_07ec_7:
												reference = ref *(byte*)null;
												num = -1403802540;
												continue;
												IL_0698_6:
												reference = ref *(byte*)null;
												num = (int)((num3 * 1768218667) ^ 0x7D687283);
												continue;
											}
											break;
										}
										break;
										end_IL_0178_4:;
									}
								}
								break;
							case 46u:
								num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
								continue;
							case 45u:
								num5 = *(ulong*)ptr;
								num = -175932393;
								continue;
							case 44u:
								num20 = ((string_0.Length < 8) ? (-1097288893) : (-151066181));
								num = num20 ^ ((int)num3 * -1521996513);
								continue;
							case 43u:
								num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
								continue;
							case 42u:
								num6 = ((!smethod_375(ptr3, ptr + 7, ptr4)) ? (-1668385690) : (-2025189813));
								num = num6 ^ ((int)num3 * -1526451258);
								continue;
							case 40u:
								num = ((int)num3 * -1760778114) ^ -947094406;
								continue;
							case 39u:
								ptr3 = (char*)((byte*)ptr3 + RuntimeHelpers.OffsetToStringData);
								num = (int)(num3 * 1856495725) ^ -962392268;
								continue;
							case 38u:
								num13 = (((num7 & 0xFF) == b) ? 713716107 : 2043179473);
								num = num13 ^ ((int)num3 * -1028200843);
								continue;
							case 36u:
								ptr4 = (char*)((byte*)ptr4 + RuntimeHelpers.OffsetToStringData);
								num = (int)((num3 * 1673010289) ^ 0x7B2EB707);
								continue;
							case 35u:
								num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
								continue;
							case 34u:
								num19 = ((!smethod_375(ptr3, ptr + 3, ptr4)) ? (-466992619) : (-1489669152));
								num = num19 ^ ((int)num3 * -1372792833);
								continue;
							case 33u:
								num17 = ((!smethod_375(ptr3, ptr + 5, ptr4)) ? 1438927695 : 1849922740);
								num = num17 ^ (int)(num3 * 694607493);
								continue;
							case 32u:
								num15 = (smethod_375(ptr3, ptr2 + 3, ptr4) ? 261334917 : 1309425646);
								num = num15 ^ (int)(num3 * 1837507049);
								continue;
							case 31u:
								num9 = (smethod_375(ptr3, ptr + 6, ptr4) ? 2135498628 : 2062879556);
								num = num9 ^ (int)(num3 * 1942369578);
								continue;
							case 30u:
								num = ((int)num3 * -1551642925) ^ -500874067;
								continue;
							case 28u:
								num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
								continue;
							case 27u:
								b = (byte)(*ptr4);
								num = -1295512042;
								continue;
							case 26u:
								num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
								num = num11 ^ (int)(num3 * 548081056);
								continue;
							case 25u:
								num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
								num = num22 ^ (int)(num3 * 1698295174);
								continue;
							case 24u:
								ptr2 += 4;
								num = -319008360;
								continue;
							case 23u:
								num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
								continue;
							case 22u:
								num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
								num = num18 ^ ((int)num3 * -1570396110);
								continue;
							case 21u:
								ptr += 8;
								num = -1147100231;
								continue;
							case 20u:
								num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
								num = num16 ^ ((int)num3 * -365153547);
								continue;
							case 18u:
								num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
								continue;
							case 17u:
								num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
								continue;
							case 14u:
								num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
								continue;
							case 12u:
								ptr2 = ptr7;
								num = -319008360;
								continue;
							case 10u:
								num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
								num = num10 ^ ((int)num3 * -2047740790);
								continue;
							case 7u:
								ptr = ptr7;
								num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
								continue;
							case 5u:
								ptr6 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + byte_0.Length - string_0.Length;
								num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
								num = num8 ^ ((int)num3 * -683634994);
								continue;
							case 4u:
								num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
								continue;
							case 3u:
								goto IL_0698_5;
							case 2u:
								goto IL_06ab_4;
							case 0u:
								num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
								num = num4 ^ (int)(num3 * 1098314894);
								continue;
							case 37u:
								goto IL_07ec_6;
							case 1u:
								return (int)(ptr2 + 3 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							case 6u:
								return (int)(ptr + 3 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							case 8u:
								return (int)(ptr2 + 1 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							case 9u:
								return (int)(ptr + 6 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							default:
								return -1;
							case 13u:
								return (int)(ptr + 7 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							case 15u:
								return (int)(ptr + 4 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							case 16u:
								return (int)(ptr2 + 2 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							case 19u:
								return (int)(ptr + 5 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							case 41u:
								return (int)(ptr + 2 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							case 51u:
								return (int)(ptr - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							case 55u:
								return (int)(ptr2 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							case 56u:
								{
									return (int)(ptr + 1 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
								}
								IL_07ec_6:
								reference = ref *(byte*)null;
								num = -1403802540;
								continue;
								IL_0698_5:
								reference = ref *(byte*)null;
								num = (int)((num3 * 1768218667) ^ 0x7D687283);
								continue;
								IL_06ab_4:
								text2 = null;
								goto end_IL_03e7_2;
							}
							break;
						}
					}
					continue;
					end_IL_03e7_2:
					break;
				}
				goto IL_06b0_2;
			case 28u:
				goto IL_040b;
			case 27u:
				b = (byte)(*ptr4);
				num = -1295512042;
				continue;
			case 26u:
				num11 = (smethod_375(ptr3, ptr2 + 1, ptr4) ? 495319607 : 2040051987);
				num = num11 ^ (int)(num3 * 548081056);
				continue;
			case 25u:
				num22 = (smethod_375(ptr3, ptr, ptr4) ? 1654606789 : 939518733);
				num = num22 ^ (int)(num3 * 1698295174);
				continue;
			case 24u:
				ptr2 += 4;
				num = -319008360;
				continue;
			case 23u:
				goto IL_04be;
			case 22u:
				num18 = ((!smethod_375(ptr3, ptr + 4, ptr4)) ? 2117524092 : 1655849664);
				num = num18 ^ ((int)num3 * -1570396110);
				continue;
			case 21u:
				ptr += 8;
				num = -1147100231;
				continue;
			case 20u:
				num16 = ((!smethod_375(ptr3, ptr2, ptr4)) ? (-464286855) : (-179553226));
				num = num16 ^ ((int)num3 * -365153547);
				continue;
			case 18u:
				goto IL_055d;
			case 17u:
				goto IL_058d;
			case 14u:
				goto IL_05bc;
			case 12u:
				ptr2 = ptr7;
				num = -319008360;
				continue;
			case 10u:
				num10 = (((num5 & 0xFFL) != b) ? (-1668374233) : (-2085737680));
				num = num10 ^ ((int)num3 * -2047740790);
				continue;
			case 7u:
				ptr = ptr7;
				num = ((int)num3 * -2065218472) ^ 0x1CA5CDE1;
				continue;
			case 5u:
				ptr6 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + byte_0.Length - string_0.Length;
				num8 = (PlatformInfo.bool_0 ? 1037055152 : 471426738);
				num = num8 ^ ((int)num3 * -683634994);
				continue;
			case 4u:
				goto IL_0671;
			case 3u:
				reference = ref *(byte*)null;
				num = (int)((num3 * 1768218667) ^ 0x7D687283);
				continue;
			case 2u:
				text2 = null;
				goto IL_06b0_2;
			case 0u:
				num4 = (smethod_375(ptr3, ptr + 2, ptr4) ? (-1270585414) : (-1595497062));
				num = num4 ^ (int)(num3 * 1098314894);
				continue;
			case 37u:
				goto IL_07ec;
			case 1u:
				return (int)(ptr2 + 3 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 6u:
				return (int)(ptr + 3 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 8u:
				return (int)(ptr2 + 1 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 9u:
				return (int)(ptr + 6 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			default:
				return -1;
			case 13u:
				return (int)(ptr + 7 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 15u:
				return (int)(ptr + 4 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 16u:
				return (int)(ptr2 + 2 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 19u:
				return (int)(ptr + 5 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 41u:
				return (int)(ptr + 2 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 51u:
				return (int)(ptr - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 55u:
				return (int)(ptr2 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 56u:
				{
					return (int)(ptr + 1 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
				}
				IL_06b0_2:
				num = -1723474841;
				continue;
			}
			num = (((num5 & 0xFF000000L) >> 24 == b) ? (-1222332956) : (-1280831152));
			continue;
			IL_0671:
			num = (((num7 & 0xFF00) >> 8 != b) ? (-1572523053) : (-17372495));
			continue;
			IL_040b:
			num = (((num5 & 0xFF000000000000L) >> 48 == b) ? (-1942806871) : (-1007700200));
			continue;
			IL_019a:
			num = ((ptr2 >= ptr6) ? (-1688115294) : (-106293645));
			continue;
			IL_05bc:
			num = ((ptr >= ptr6) ? (-359492598) : (-1768075465));
			continue;
			IL_04be:
			num = (((num7 & 0xFF0000) >> 16 == b) ? (-1195496631) : (-559068428));
			continue;
			IL_02d8:
			num = (((num5 & 0xFF0000000000L) >> 40 == b) ? (-2059841750) : (-810816634));
			continue;
			IL_058d:
			num = (((num5 & 0xFF00L) >> 8 != b) ? (-322709539) : (-1652977546));
			continue;
			IL_0172_3:
			text2 = string_1;
			ptr3 = (char*)(nint)text2;
			num = ((ptr3 == null) ? (-45909674) : (-761675787));
			continue;
			IL_0099:
			num = (((num7 & 0xFF000000L) >> 24 == b) ? (-1748791709) : (-1851646350));
			continue;
			IL_055d:
			num = (((num5 & 0xFF0000L) >> 16 != b) ? (-1818675076) : (-2088585558));
			continue;
			IL_01f9:
			num = (((num5 & 0xFF00000000000000uL) >> 56 != b) ? (-2065968854) : (-982170883));
			continue;
			IL_0142:
			num = (((num5 & 0xFF00000000L) >> 32 == b) ? (-1796466151) : (-891369008));
			continue;
			end_IL_06e5:
			break;
		}
		goto IL_008f;
		IL_07ec:
		reference = ref *(byte*)null;
		num = -1403802540;
		goto IL_06e5;
#endif
	}

	internal static void smethod_28()
	{
		try
		{
			smethod_326();
		}
		catch (Exception)
		{
		}
	}
}
