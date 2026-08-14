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

	internal static uint smethod_33(IEnumerable<PeScrambler.Class132> ienumerable_0, uint uint_0)
	{
		IEnumerator<PeScrambler.Class132> enumerator = ienumerable_0.Skip(1).GetEnumerator();
		try
		{
			PeScrambler.Class132 current = default(PeScrambler.Class132);
			uint num3 = default(uint);
			while (true)
			{
				IL_0101:
				int num = (enumerator.MoveNext() ? 1675044815 : 973040154);
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x784E2994)) % 8)
					{
					case 5u:
						num = ((uint_0 < current.method_5().method_4()) ? 998121445 : 715913955) ^ ((int)num2 * -1252527135);
						continue;
					case 3u:
						current = enumerator.Current;
						num = 1032026993;
						continue;
					case 2u:
						num = ((uint_0 >= current.method_5().method_4() + current.method_5().method_2()) ? 1567095424 : 1881803309) ^ (int)(num2 * 1110480400);
						continue;
					case 1u:
						num3 = uint_0 - current.method_5().method_4();
						num = (int)((num2 * 1166666783) ^ 0x753ABF84);
						continue;
					case 0u:
						num = 1675044815;
						continue;
					default:
						goto end_IL_00c0;
					case 4u:
						break;
					case 6u:
						goto end_IL_00c0;
					case 7u:
						return current.method_3().method_4() + num3 + current.method_0();
					}
					goto IL_0101;
					continue;
					end_IL_00c0:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_015e:
					int num4 = 985655805;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num4 ^ 0x784E2994)) % 3)
						{
						case 1u:
							goto IL_012c;
						default:
							goto end_IL_0140;
						case 2u:
							break;
						case 0u:
							goto end_IL_0140;
						}
						goto IL_015e;
						IL_012c:
						enumerator.Dispose();
						num4 = ((int)num2 * -602000671) ^ -1007001478;
						continue;
						end_IL_0140:
						break;
					}
					break;
				}
			}
		}
		return uint_0;
	}

	internal static bool smethod_34(string string_0)
	{
		if (!OpenProcessToken(GetCurrentProcess_1(), 40u, out var intptr_))
		{
			goto IL_0051;
		}
		goto IL_00cb;
		IL_0051:
		int num = 144515030;
		goto IL_0085;
		IL_0085:
		TokenPrivilegeNativeTypes.Struct34 @struct = default(TokenPrivilegeNativeTypes.Struct34);
		TokenPrivilegeNativeTypes.Struct35 struct35_ = default(TokenPrivilegeNativeTypes.Struct35);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xF5A4A3)) % 9)
			{
			case 7u:
				CloseHandle(intptr_);
				num = (int)(num2 * 26361342) ^ -1407695311;
				continue;
			case 6u:
				@struct.uint_1 = 2u;
				num = ((int)num2 * -1476422298) ^ -166199014;
				continue;
			case 3u:
				break;
			case 2u:
				@struct.struct35_0 = struct35_;
				num = (int)(num2 * 1930510589) ^ -1437897030;
				continue;
			case 0u:
				@struct = new TokenPrivilegeNativeTypes.Struct34
				{
					uint_0 = 1u
				};
				num = 365448676;
				continue;
			case 5u:
				goto IL_00cb;
			case 1u:
				return false;
			default:
			{
				TokenPrivilegeNativeTypes.Struct34 struct34_ = @struct;
				bool result = AdjustTokenPrivileges(intptr_, bool_0: false, ref struct34_, 0u, IntPtr.Zero, IntPtr.Zero);
				CloseHandle(intptr_);
				return result;
			}
			case 8u:
				return false;
			}
			break;
		}
		goto IL_0051;
		IL_00cb:
		num = (LookupPrivilegeValue(null, string_0, out struct35_) ? 234027652 : 818314398);
		goto IL_0085;
	}

	internal unsafe static int smethod_35(byte[] byte_0, string string_0, string string_1, int int_0)
	{
		return IndexOfMaskedByteString(byte_0, string_0, string_1, int_0);
#if false
		//The blocks IL_000e, IL_001b, IL_0027, IL_0031, IL_0040, IL_0058, IL_005e, IL_006a, IL_007a, IL_008a, IL_0090, IL_0096, IL_00a2, IL_00ac, IL_00bb, IL_00bf, IL_00cb, IL_00d5, IL_00e4, IL_00fd, IL_0116, IL_012e, IL_0134, IL_0140, IL_0145, IL_0151, IL_015b, IL_016a, IL_016c, IL_0176, IL_017c, IL_0188, IL_0192, IL_01ae, IL_01be, IL_01c4, IL_01d0, IL_01e0, IL_01ee, IL_01fa, IL_0204, IL_0213, IL_021a, IL_0226, IL_0230, IL_023f, IL_025a, IL_025f, IL_026b, IL_027b, IL_0283, IL_028f, IL_029f, IL_02b5, IL_02e8, IL_0302, IL_0315, IL_0325, IL_0333, IL_03ca, IL_03d4, IL_03d6, IL_03e0, IL_03e2 are reachable both inside and outside the pinned region starting at IL_02e0. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000e, IL_001b, IL_0027, IL_0031, IL_0058, IL_005e, IL_006a, IL_007a, IL_008a, IL_0090, IL_0096, IL_00a2, IL_00ac, IL_00bb, IL_00bf, IL_00cb, IL_00d5, IL_00e4, IL_00fd, IL_0116, IL_012e, IL_0134, IL_0140, IL_0145, IL_0151, IL_015b, IL_0176, IL_017c, IL_0188, IL_0192, IL_01ae, IL_01be, IL_01c4, IL_01d0, IL_01e0, IL_01ee, IL_01fa, IL_0204, IL_0213, IL_021a, IL_0226, IL_0230, IL_023f, IL_025a, IL_025f, IL_026b, IL_027b, IL_0283, IL_028f, IL_029f, IL_02b5, IL_02e8, IL_0302, IL_0315, IL_0325, IL_0333, IL_03ca, IL_03d4, IL_03d6, IL_03e0, IL_03e2 are reachable both inside and outside the pinned region starting at IL_016b. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_000e, IL_001b, IL_0027, IL_0031, IL_0058, IL_005e, IL_006a, IL_0090, IL_0096, IL_00a2, IL_00ac, IL_00bb, IL_00bf, IL_00cb, IL_00d5, IL_00e4, IL_00fd, IL_0116, IL_0140, IL_0145, IL_0151, IL_015b, IL_0176, IL_017c, IL_0188, IL_0192, IL_01ae, IL_01be, IL_01c4, IL_01d0, IL_01e0, IL_01ee, IL_01fa, IL_0204, IL_0213, IL_021a, IL_0226, IL_0230, IL_023f, IL_025a, IL_025f, IL_026b, IL_027b, IL_0283, IL_028f, IL_029f, IL_02b5, IL_02e8, IL_0302, IL_0315, IL_0325, IL_0333, IL_03ca, IL_03d4, IL_03d6, IL_03e0, IL_03e2 are reachable both inside and outside the pinned region starting at IL_012f. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if (int_0 < byte_0.Length)
		{
			byte* ptr3 = default(byte*);
			byte* ptr10 = default(byte*);
			char* ptr7 = default(char*);
			byte* ptr5 = default(byte*);
			byte* ptr = default(byte*);
			ref byte reference = default(ref byte);
			byte* ptr11 = default(byte*);
			byte[] array = default(byte[]);
			char* ptr9 = default(char*);
			byte* ptr2 = default(byte*);
			byte* ptr4 = default(byte*);
			byte* ptr6 = default(byte*);
			while (true)
			{
				int num = -12528856;
				while (true)
				{
					uint num3;
					uint num2 = (num3 = (uint)(num ^ -2010139096));
					int num6;
					int num10;
					int num4;
					int num8;
					int num5;
					int num9;
					int num7;
					byte[] array2;
					switch (num2 % 33)
					{
					case 32u:
						num6 = ((int_0 + string_0.Length > byte_0.Length) ? (-1010685007) : (-532059365));
						num = num6 ^ (int)(num3 * 750779878);
						continue;
					case 31u:
						text2 = null;
						goto IL_0052;
					case 30u:
						break;
					case 29u:
						text = null;
						num = ((int)num3 * -1067554318) ^ -1713314998;
						continue;
					case 28u:
						num10 = ((ptr3 == ptr10) ? 914046028 : 663609128);
						num = num10 ^ (int)(num3 * 894240496);
						continue;
					case 27u:
						num4 = ((ptr7 == null) ? (-1138130744) : (-311381692));
						num = num4 ^ ((int)num3 * -511058416);
						continue;
					case 26u:
						ptr5 += 2;
						num = (int)(num3 * 753655075) ^ -66956065;
						continue;
					case 25u:
						ptr3 += 2;
						num = (int)((num3 * 188257352) ^ 0x31EFF91E);
						continue;
					case 24u:
						ptr = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + int_0;
						ptr11 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + byte_0.Length;
						num = -670449102;
						continue;
					case 23u:
						text = string_1;
						ptr7 = (char*)(nint)text;
						num = -13835497;
						continue;
					case 22u:
						num8 = ((array.Length == 0) ? 91944615 : 329158943);
						num = num8 ^ ((int)num3 * -1879049780);
						continue;
					case 21u:
						text2 = string_0;
						num = -1390799742;
						continue;
					case 20u:
						ptr9 = (char*)(nint)text2;
						num5 = ((ptr9 != null) ? 19063170 : 949825726);
						num = num5 ^ ((int)num3 * -703871982);
						continue;
					case 19u:
						reference = ref *(byte*)null;
						num = -191664724;
						continue;
					case 18u:
						ptr2++;
						num = -776090862;
						continue;
					case 17u:
						goto IL_01be;
					case 16u:
						num9 = ((string_0.Length != string_1.Length) ? (-1535139549) : (-1080959877));
						num = num9 ^ ((int)num3 * -708549355);
						continue;
					case 15u:
						num7 = ((*ptr5 == 63) ? 1855499764 : 1867697290);
						num = num7 ^ (int)(num3 * 499446823);
						continue;
					case 13u:
						ptr9 = (char*)((byte*)ptr9 + RuntimeHelpers.OffsetToStringData);
						num = ((int)num3 * -1389555244) ^ -64279406;
						continue;
					case 10u:
						goto IL_025a;
					case 8u:
						goto IL_027b;
					case 7u:
						ptr++;
						num = (int)((num3 * 277223075) ^ 0x211B480);
						continue;
					case 5u:
						ptr4 = (byte*)ptr9;
						ptr10 = (byte*)ptr9 + (nint)string_0.Length * (nint)2;
						ptr6 = (byte*)ptr7;
						num = (int)((num3 * 699982867) ^ 0x1A29CA3);
						continue;
					case 4u:
						while (true)
						{
							IL_02d9:
							fixed (byte* ptr8 = &array[0])
							{
								num = -191664724;
								while (true)
								{
									num2 = (num3 = (uint)(num ^ -2010139096));
									switch (num2 % 33)
									{
									case 19u:
										break;
									case 32u:
										num6 = ((int_0 + string_0.Length > byte_0.Length) ? (-1010685007) : (-532059365));
										num = num6 ^ (int)(num3 * 750779878);
										continue;
									case 31u:
										text2 = null;
										goto end_IL_02d9;
									case 30u:
										num = ((ptr2 != ptr11) ? (-1179423015) : (-1028840204));
										continue;
									case 29u:
										text = null;
										num = ((int)num3 * -1067554318) ^ -1713314998;
										continue;
									case 28u:
										num10 = ((ptr3 == ptr10) ? 914046028 : 663609128);
										num = num10 ^ (int)(num3 * 894240496);
										continue;
									case 27u:
										num4 = ((ptr7 == null) ? (-1138130744) : (-311381692));
										num = num4 ^ ((int)num3 * -511058416);
										continue;
									case 26u:
										ptr5 += 2;
										num = (int)(num3 * 753655075) ^ -66956065;
										continue;
									case 25u:
										ptr3 += 2;
										num = (int)((num3 * 188257352) ^ 0x31EFF91E);
										continue;
									case 24u:
										ptr = ptr8 + int_0;
										ptr11 = ptr8 + byte_0.Length;
										num = -670449102;
										continue;
									case 23u:
										text = string_1;
										ptr7 = (char*)(nint)text;
										num = -13835497;
										continue;
									case 22u:
										num8 = ((array.Length == 0) ? 91944615 : 329158943);
										num = num8 ^ ((int)num3 * -1879049780);
										continue;
									case 21u:
										while (true)
										{
											IL_016a:
											fixed (string text2 = string_0)
											{
												num = -1390799742;
												while (true)
												{
													num2 = (num3 = (uint)(num ^ -2010139096));
													switch (num2 % 33)
													{
													case 19u:
														break;
													case 31u:
														goto end_IL_016c;
													case 32u:
														num6 = ((int_0 + string_0.Length > byte_0.Length) ? (-1010685007) : (-532059365));
														num = num6 ^ (int)(num3 * 750779878);
														continue;
													case 30u:
														num = ((ptr2 != ptr11) ? (-1179423015) : (-1028840204));
														continue;
													case 29u:
														goto IL_007a;
													case 28u:
														num10 = ((ptr3 == ptr10) ? 914046028 : 663609128);
														num = num10 ^ (int)(num3 * 894240496);
														continue;
													case 27u:
														num4 = ((ptr7 == null) ? (-1138130744) : (-311381692));
														num = num4 ^ ((int)num3 * -511058416);
														continue;
													case 26u:
														ptr5 += 2;
														num = (int)(num3 * 753655075) ^ -66956065;
														continue;
													case 25u:
														ptr3 += 2;
														num = (int)((num3 * 188257352) ^ 0x31EFF91E);
														continue;
													case 24u:
														ptr = ptr8 + int_0;
														ptr11 = ptr8 + byte_0.Length;
														num = -670449102;
														continue;
													case 23u:
														while (true)
														{
															IL_012e:
															fixed (string text = string_1)
															{
																ptr7 = (char*)(nint)text;
																num = -13835497;
																while (true)
																{
																	num2 = (num3 = (uint)(num ^ -2010139096));
																	switch (num2 % 33)
																	{
																	case 19u:
																		break;
																	case 31u:
																		goto end_IL_0134;
																	case 32u:
																		num6 = ((int_0 + string_0.Length > byte_0.Length) ? (-1010685007) : (-532059365));
																		num = num6 ^ (int)(num3 * 750779878);
																		continue;
																	case 30u:
																		num = ((ptr2 != ptr11) ? (-1179423015) : (-1028840204));
																		continue;
																	case 29u:
																		goto IL_007a;
																	case 28u:
																		num10 = ((ptr3 == ptr10) ? 914046028 : 663609128);
																		num = num10 ^ (int)(num3 * 894240496);
																		continue;
																	case 27u:
																		num4 = ((ptr7 == null) ? (-1138130744) : (-311381692));
																		num = num4 ^ ((int)num3 * -511058416);
																		continue;
																	case 26u:
																		ptr5 += 2;
																		num = (int)(num3 * 753655075) ^ -66956065;
																		continue;
																	case 25u:
																		ptr3 += 2;
																		num = (int)((num3 * 188257352) ^ 0x31EFF91E);
																		continue;
																	case 24u:
																		ptr = ptr8 + int_0;
																		ptr11 = ptr8 + byte_0.Length;
																		num = -670449102;
																		continue;
																	case 23u:
																		goto IL_012e;
																	case 22u:
																		num8 = ((array.Length == 0) ? 91944615 : 329158943);
																		num = num8 ^ ((int)num3 * -1879049780);
																		continue;
																	case 21u:
																		goto IL_016a;
																	case 20u:
																		ptr9 = (char*)(nint)text2;
																		num5 = ((ptr9 != null) ? 19063170 : 949825726);
																		num = num5 ^ ((int)num3 * -703871982);
																		continue;
																	case 18u:
																		ptr2++;
																		num = -776090862;
																		continue;
																	case 17u:
																		num = ((ptr != ptr11) ? (-1782212293) : (-305805282));
																		continue;
																	case 16u:
																		num9 = ((string_0.Length != string_1.Length) ? (-1535139549) : (-1080959877));
																		num = num9 ^ ((int)num3 * -708549355);
																		continue;
																	case 15u:
																		num7 = ((*ptr5 == 63) ? 1855499764 : 1867697290);
																		num = num7 ^ (int)(num3 * 499446823);
																		continue;
																	case 13u:
																		ptr9 = (char*)((byte*)ptr9 + RuntimeHelpers.OffsetToStringData);
																		num = ((int)num3 * -1389555244) ^ -64279406;
																		continue;
																	case 10u:
																		array2 = (array = byte_0);
																		num = ((array2 == null) ? (-141575089) : (-417898506));
																		continue;
																	case 8u:
																		num = ((*ptr2 != *ptr3) ? (-665989387) : (-1023434657));
																		continue;
																	case 7u:
																		ptr++;
																		num = (int)((num3 * 277223075) ^ 0x211B480);
																		continue;
																	case 5u:
																		ptr4 = (byte*)ptr9;
																		ptr10 = (byte*)ptr9 + (nint)string_0.Length * (nint)2;
																		ptr6 = (byte*)ptr7;
																		num = (int)((num3 * 699982867) ^ 0x1A29CA3);
																		continue;
																	case 4u:
																		goto IL_02d9;
																	case 3u:
																		ptr7 = (char*)((byte*)ptr7 + RuntimeHelpers.OffsetToStringData);
																		num = (int)(num3 * 1193931442) ^ -987013824;
																		continue;
																	case 2u:
																		ptr2 = ptr;
																		ptr3 = ptr4;
																		ptr5 = ptr6;
																		num = -1760455509;
																		continue;
																	case 1u:
																		num = ((int)num3 * -1119155384) ^ -640118957;
																		continue;
																	case 0u:
																		num = ((int)num3 * -721555487) ^ -1225208582;
																		continue;
																	case 14u:
																		num = -12528856;
																		continue;
																	case 9u:
																		return -1;
																	case 11u:
																		return (int)(ptr - ptr8);
																	default:
																		return -1;
																	case 6u:
																		return -1;
																	}
																	break;
																}
																break;
																end_IL_0134:;
															}
															goto end_IL_016c;
														}
														break;
													case 22u:
														num8 = ((array.Length == 0) ? 91944615 : 329158943);
														num = num8 ^ ((int)num3 * -1879049780);
														continue;
													case 21u:
														goto IL_016a;
													case 20u:
														ptr9 = (char*)(nint)text2;
														num5 = ((ptr9 != null) ? 19063170 : 949825726);
														num = num5 ^ ((int)num3 * -703871982);
														continue;
													case 18u:
														ptr2++;
														num = -776090862;
														continue;
													case 17u:
														num = ((ptr != ptr11) ? (-1782212293) : (-305805282));
														continue;
													case 16u:
														num9 = ((string_0.Length != string_1.Length) ? (-1535139549) : (-1080959877));
														num = num9 ^ ((int)num3 * -708549355);
														continue;
													case 15u:
														num7 = ((*ptr5 == 63) ? 1855499764 : 1867697290);
														num = num7 ^ (int)(num3 * 499446823);
														continue;
													case 13u:
														ptr9 = (char*)((byte*)ptr9 + RuntimeHelpers.OffsetToStringData);
														num = ((int)num3 * -1389555244) ^ -64279406;
														continue;
													case 10u:
														array2 = (array = byte_0);
														num = ((array2 == null) ? (-141575089) : (-417898506));
														continue;
													case 8u:
														num = ((*ptr2 != *ptr3) ? (-665989387) : (-1023434657));
														continue;
													case 7u:
														ptr++;
														num = (int)((num3 * 277223075) ^ 0x211B480);
														continue;
													case 5u:
														ptr4 = (byte*)ptr9;
														ptr10 = (byte*)ptr9 + (nint)string_0.Length * (nint)2;
														ptr6 = (byte*)ptr7;
														num = (int)((num3 * 699982867) ^ 0x1A29CA3);
														continue;
													case 4u:
														goto IL_02d9;
													case 3u:
														ptr7 = (char*)((byte*)ptr7 + RuntimeHelpers.OffsetToStringData);
														num = (int)(num3 * 1193931442) ^ -987013824;
														continue;
													case 2u:
														ptr2 = ptr;
														ptr3 = ptr4;
														ptr5 = ptr6;
														num = -1760455509;
														continue;
													case 1u:
														num = ((int)num3 * -1119155384) ^ -640118957;
														continue;
													case 0u:
														num = ((int)num3 * -721555487) ^ -1225208582;
														continue;
													case 14u:
														num = -12528856;
														continue;
													case 9u:
														return -1;
													case 11u:
														return (int)(ptr - ptr8);
													default:
														return -1;
													case 6u:
														{
															return -1;
														}
														IL_007a:
														text = null;
														num = ((int)num3 * -1067554318) ^ -1713314998;
														continue;
													}
													break;
												}
												break;
												end_IL_016c:;
											}
											goto case 31u;
										}
										break;
									case 20u:
										ptr9 = (char*)(nint)text2;
										num5 = ((ptr9 != null) ? 19063170 : 949825726);
										num = num5 ^ ((int)num3 * -703871982);
										continue;
									case 18u:
										ptr2++;
										num = -776090862;
										continue;
									case 17u:
										num = ((ptr != ptr11) ? (-1782212293) : (-305805282));
										continue;
									case 16u:
										num9 = ((string_0.Length != string_1.Length) ? (-1535139549) : (-1080959877));
										num = num9 ^ ((int)num3 * -708549355);
										continue;
									case 15u:
										num7 = ((*ptr5 == 63) ? 1855499764 : 1867697290);
										num = num7 ^ (int)(num3 * 499446823);
										continue;
									case 13u:
										ptr9 = (char*)((byte*)ptr9 + RuntimeHelpers.OffsetToStringData);
										num = ((int)num3 * -1389555244) ^ -64279406;
										continue;
									case 10u:
										array2 = (array = byte_0);
										num = ((array2 == null) ? (-141575089) : (-417898506));
										continue;
									case 8u:
										num = ((*ptr2 != *ptr3) ? (-665989387) : (-1023434657));
										continue;
									case 7u:
										ptr++;
										num = (int)((num3 * 277223075) ^ 0x211B480);
										continue;
									case 5u:
										ptr4 = (byte*)ptr9;
										ptr10 = (byte*)ptr9 + (nint)string_0.Length * (nint)2;
										ptr6 = (byte*)ptr7;
										num = (int)((num3 * 699982867) ^ 0x1A29CA3);
										continue;
									case 4u:
										goto IL_02d9;
									case 3u:
										ptr7 = (char*)((byte*)ptr7 + RuntimeHelpers.OffsetToStringData);
										num = (int)(num3 * 1193931442) ^ -987013824;
										continue;
									case 2u:
										ptr2 = ptr;
										ptr3 = ptr4;
										ptr5 = ptr6;
										num = -1760455509;
										continue;
									case 1u:
										num = ((int)num3 * -1119155384) ^ -640118957;
										continue;
									case 0u:
										num = ((int)num3 * -721555487) ^ -1225208582;
										continue;
									case 14u:
										num = -12528856;
										continue;
									case 9u:
										return -1;
									case 11u:
										return (int)(ptr - ptr8);
									default:
										return -1;
									case 6u:
										return -1;
									}
									break;
								}
							}
							goto case 19u;
							continue;
							end_IL_02d9:
							break;
						}
						goto IL_0052;
					case 3u:
						ptr7 = (char*)((byte*)ptr7 + RuntimeHelpers.OffsetToStringData);
						num = (int)(num3 * 1193931442) ^ -987013824;
						continue;
					case 2u:
						ptr2 = ptr;
						ptr3 = ptr4;
						ptr5 = ptr6;
						num = -1760455509;
						continue;
					case 1u:
						num = ((int)num3 * -1119155384) ^ -640118957;
						continue;
					case 0u:
						num = ((int)num3 * -721555487) ^ -1225208582;
						continue;
					case 14u:
						goto end_IL_0333;
					case 9u:
						return -1;
					case 11u:
						return (int)(ptr - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
					default:
						return -1;
					case 6u:
						goto end_IL_03ca;
						IL_0052:
						num = ((int)num3 * -1320968507) ^ 0x13FA7407;
						continue;
					}
					num = ((ptr2 != ptr11) ? (-1179423015) : (-1028840204));
					continue;
					IL_027b:
					num = ((*ptr2 != *ptr3) ? (-665989387) : (-1023434657));
					continue;
					IL_01be:
					num = ((ptr != ptr11) ? (-1782212293) : (-305805282));
					continue;
					IL_025a:
					array2 = (array = byte_0);
					num = ((array2 == null) ? (-141575089) : (-417898506));
					continue;
					end_IL_0333:
					break;
				}
				continue;
				end_IL_03ca:
				break;
			}
		}
		return -1;
#endif
	}

	internal static void smethod_38(List<PeScrambler.Class132> list_0, PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_14() == null)
		{
			goto IL_013f;
		}
		goto IL_02c3;
		IL_013f:
		int num = 2069377312;
		goto IL_026c;
		IL_026c:
		BinaryWriter binaryWriter = default(BinaryWriter);
		uint uint_2 = default(uint);
		uint uint_ = default(uint);
		BinaryReader binaryReader = default(BinaryReader);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x23EA6F99)) % 17)
			{
			case 16u:
				gclass4_0.class154_0.method_28().Position = smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_6().method_3().imethod_49()[0].method_0()) + 28L;
				num = (int)(num2 * 2007414949) ^ -1282504863;
				continue;
			case 15u:
				binaryWriter.Write(smethod_33(list_0, gclass4_0.class154_0.method_14().method_11()));
				binaryWriter.Write(smethod_33(list_0, gclass4_0.class154_0.method_14().method_13()));
				binaryWriter.Write(smethod_33(list_0, gclass4_0.class154_0.method_14().method_15()));
				num = ((int)num2 * -568259706) ^ -1097313760;
				continue;
			case 12u:
				gclass4_0.class154_0.method_28().Position = smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_14().method_13());
				num = (int)((num2 * 1699275028) ^ 0x6FCD9F6);
				continue;
			case 11u:
				break;
			case 10u:
				goto end_IL_026c;
			case 9u:
				num = ((int)num2 * -623813566) ^ -257325949;
				continue;
			case 8u:
				binaryWriter.Write(smethod_33(list_0, uint_2));
				num = ((int)num2 * -1188176716) ^ -1031162835;
				continue;
			case 7u:
				uint_ = binaryReader.ReadUInt32();
				gclass4_0.class154_0.method_28().Position -= 4L;
				num = 1003681441;
				continue;
			case 6u:
				num4 = 0;
				num = (int)((num2 * 692896618) ^ 0x32FD4614);
				continue;
			case 5u:
				num3 = 0;
				num = (int)(num2 * 1706010326) ^ -2073589183;
				continue;
			case 4u:
				num4++;
				num = ((int)num2 * -1200505646) ^ 0x66DF5D85;
				continue;
			case 3u:
				goto IL_01ed;
			case 2u:
				uint_2 = binaryReader.ReadUInt32();
				gclass4_0.class154_0.method_28().Position -= 4L;
				num = 1741422097;
				continue;
			case 0u:
				binaryWriter.Write(smethod_33(list_0, uint_));
				num3++;
				num = (int)((num2 * 1424550046) ^ 0x6BA19EBB);
				continue;
			default:
				return;
			case 13u:
				goto IL_02c3;
			case 1u:
				return;
			case 14u:
				return;
			}
			num = ((num4 < gclass4_0.class154_0.method_14().method_7()) ? 1063146740 : 1474334245);
			continue;
			IL_01ed:
			num = ((num3 >= gclass4_0.class154_0.method_14().method_9()) ? 219524453 : 2069590789);
			continue;
			end_IL_026c:
			break;
		}
		goto IL_013f;
		IL_02c3:
		gclass4_0.class154_0.method_28().Position = smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_14().method_11());
		binaryReader = new BinaryReader(gclass4_0.class154_0.method_28());
		binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
		num = 1704191232;
		goto IL_026c;
	}

	internal static bool smethod_40(int int_0, string string_0, byte[] byte_0, string string_1)
	{
		if (int_0 + string_0.Length > byte_0.Length)
		{
			goto IL_0056;
		}
		goto IL_00e3;
		IL_0056:
		int num = -118618801;
		goto IL_00a9;
		IL_00a9:
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1032041092)) % 10)
			{
			case 9u:
				num3++;
				num = -1101696676;
				continue;
			case 6u:
				break;
			case 5u:
				num = (int)(num2 * 1064910752) ^ -1605820292;
				continue;
			case 3u:
				goto end_IL_00a9;
			case 2u:
				goto IL_005d;
			case 0u:
				num = ((string_1[num3] == '?') ? (-1282471931) : (-59495615)) ^ (int)(num2 * 2000024787);
				continue;
			case 4u:
				goto IL_00e3;
			case 1u:
				return false;
			case 7u:
				return false;
			default:
				return true;
			}
			num = ((byte_0[int_0 + num3] == string_0[num3]) ? (-516896453) : (-1727256970));
			continue;
			IL_005d:
			num = ((num3 < string_0.Length) ? (-1190293354) : (-839745434));
			continue;
			end_IL_00a9:
			break;
		}
		goto IL_0056;
		IL_00e3:
		num3 = 0;
		num = -2125814015;
		goto IL_00a9;
	}

	internal static int smethod_44(DeflateDecoder.Stream1 stream1_0)
	{
		return smethod_438(stream1_0) | (smethod_438(stream1_0) << 16);
	}

	internal static void smethod_46(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_4().method_0() == 64)
		{
			goto IL_0014;
		}
		goto IL_003b;
		IL_0014:
		int num = 569538140;
		goto IL_0019;
		IL_0019:
		int num2 = default(int);
		switch ((uint)(num ^ 0x2A0F4C89) % 4u)
		{
		case 0u:
			break;
		case 2u:
			goto IL_003b;
		case 1u:
			return;
		default:
		{
			Stream stream = smethod_264(gclass4_0.class154_0, gclass4_0.class154_0.method_4().method_0(), num2);
			byte[] buffer;
			try
			{
				BinaryReader binaryReader = new BinaryReader(stream);
				try
				{
					buffer = binaryReader.ReadBytes(num2);
				}
				finally
				{
					if (binaryReader != null)
					{
						while (true)
						{
							IL_00d6:
							int num3 = 314618932;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)(num3 ^ 0x2A0F4C89)) % 3)
								{
								case 1u:
									goto IL_00a4;
								default:
									goto end_IL_00b8;
								case 2u:
									break;
								case 0u:
									goto end_IL_00b8;
								}
								goto IL_00d6;
								IL_00a4:
								((IDisposable)binaryReader).Dispose();
								num3 = (int)((num4 * 427955475) ^ 0x7D6B8F81);
								continue;
								end_IL_00b8:
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
						IL_0115:
						int num5 = 1972045691;
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)(num5 ^ 0x2A0F4C89)) % 3)
							{
							case 1u:
								goto IL_00e3;
							default:
								goto end_IL_00f7;
							case 2u:
								break;
							case 0u:
								goto end_IL_00f7;
							}
							goto IL_0115;
							IL_00e3:
							((IDisposable)stream).Dispose();
							num5 = ((int)num4 * -1165992716) ^ 0x20C5CA30;
							continue;
							end_IL_00f7:
							break;
						}
						break;
					}
				}
			}
			smethod_377(gclass4_0, 64L, gclass4_0.class154_0.method_4().method_0() - 64 + num2);
			while (true)
			{
				int num6 = 1937257620;
				while (true)
				{
					uint num4;
					switch ((num4 = (uint)(num6 ^ 0x2A0F4C89)) % 4)
					{
					case 2u:
						gclass4_0.class154_0.method_4().method_1(64u);
						num6 = (int)((num4 * 1622221728) ^ 0x6F9BA6CD);
						continue;
					case 1u:
						gclass4_0.class154_0.method_28().Position = 64L;
						gclass4_0.binaryWriter_0.Write(buffer);
						num6 = ((int)num4 * -1435371093) ^ 0x38CA7518;
						continue;
					default:
						return;
					case 3u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
		}
		goto IL_0014;
		IL_003b:
		num2 = 24 + gclass4_0.class154_0.method_6().method_1().method_10() + gclass4_0.class154_0.method_8().Count * 40;
		num = 1895356318;
		goto IL_0019;
	}

	internal static void smethod_56(List<PeScrambler.Class132> list_0, PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_23() == null)
		{
			goto IL_0047;
		}
		goto IL_0072;
		IL_0047:
		int num = -2133621195;
		goto IL_004c;
		IL_004c:
		long num8 = default(long);
		ResourceDirectoryNode current = default(ResourceDirectoryNode);
		int num5 = default(int);
		long position = default(long);
		ushort num6 = default(ushort);
		BinaryReader binaryReader = default(BinaryReader);
		ushort num7 = default(ushort);
		uint num4 = default(uint);
		BinaryWriter binaryWriter2 = default(BinaryWriter);
		uint uint_ = default(uint);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -593618008)) % 5)
			{
			case 1u:
				num8 = smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_6().method_3().imethod_49()[2].method_0());
				num = (int)((num2 * 1632699597) ^ 0x4825B9BC);
				continue;
			case 0u:
				break;
			case 4u:
				goto IL_0072;
			default:
			{
				IEnumerator<ResourceDirectoryNode> enumerator = smethod_9(gclass4_0.class154_0.method_23().method_0()).GetEnumerator();
				try
				{
					while (true)
					{
						int num3 = ((!enumerator.MoveNext()) ? (-1078975435) : (-2096174899));
						while (true)
						{
							switch ((num2 = (uint)(num3 ^ -593618008)) % 15)
							{
							case 14u:
								num3 = -2096174899;
								continue;
							case 13u:
								current = enumerator.Current;
								gclass4_0.class154_0.method_28().Position = num8 + current.long_0;
								gclass4_0.class154_0.method_28().Position += 12L;
								num3 = -261761820;
								continue;
							case 12u:
								num3 = ((int)num2 * -1753619790) ^ -1601973318;
								continue;
							case 10u:
								num5++;
								num3 = -1719714436;
								continue;
							case 9u:
								gclass4_0.class154_0.method_28().Position = position + num5 * 8;
								num3 = -877487346;
								continue;
							case 8u:
								num6 = binaryReader.ReadUInt16();
								num7 = binaryReader.ReadUInt16();
								num3 = ((int)num2 * -1166959388) ^ -194451834;
								continue;
							case 7u:
								gclass4_0.class154_0.method_28().Position = num8 + num4;
								num3 = (int)((num2 * 1557366961) ^ 0x5D48C553);
								continue;
							case 6u:
								num5 = 0;
								num3 = (int)((num2 * 965295561) ^ 0x56D48033);
								continue;
							case 4u:
								num3 = ((num5 < num6 + num7) ? (-1844739987) : (-1897210350));
								continue;
							case 3u:
							{
								BinaryWriter binaryWriter = binaryWriter2;
								uint value;
								current.method_4()[num5].method_5(value = smethod_33(list_0, uint_));
								binaryWriter.Write(value);
								num3 = (int)((num2 * 1893854260) ^ 0x9941A7D);
								continue;
							}
							case 2u:
								position = gclass4_0.class154_0.method_28().Position;
								num3 = (int)((num2 * 616491960) ^ 0x4DC22CB8);
								continue;
							case 1u:
								gclass4_0.class154_0.method_28().Position += 4L;
								num4 = binaryReader.ReadUInt32();
								num3 = (((num4 & 0x80000000u) != 0) ? 389468787 : 1560228213) ^ ((int)num2 * -270990909);
								continue;
							case 0u:
								uint_ = binaryReader.ReadUInt32();
								gclass4_0.class154_0.method_28().Position -= 4L;
								num3 = (int)(num2 * 1915000586) ^ -1050594213;
								continue;
							default:
								return;
							case 11u:
								break;
							case 5u:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						while (true)
						{
							IL_0378:
							int num9 = -1426211952;
							while (true)
							{
								switch ((num2 = (uint)(num9 ^ -593618008)) % 3)
								{
								case 1u:
									goto IL_0346;
								default:
									goto end_IL_035a;
								case 0u:
									break;
								case 2u:
									goto end_IL_035a;
								}
								goto IL_0378;
								IL_0346:
								enumerator.Dispose();
								num9 = (int)(num2 * 229527840) ^ -940027136;
								continue;
								end_IL_035a:
								break;
							}
							break;
						}
					}
				}
			}
			case 3u:
				return;
			}
			break;
		}
		goto IL_0047;
		IL_0072:
		binaryWriter2 = new BinaryWriter(gclass4_0.class154_0.method_28());
		binaryReader = new BinaryReader(gclass4_0.class154_0.method_28());
		num = -1231550413;
		goto IL_004c;
	}

	internal static void smethod_58(PeScrambler gclass4_0, Stream stream_0)
	{
		smethod_315(stream_0, gclass4_0.class154_0);
	}

	internal static int smethod_60(DeflateDecoder.Class181 class181_0, int int_0)
	{
		if (class181_0.int_2 < int_0)
		{
			while (true)
			{
				int num = 1659794089;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x4F25C47C)) % 6)
					{
					case 5u:
						class181_0.int_2 += 16;
						num = ((int)num2 * -1943005705) ^ -346768842;
						continue;
					case 2u:
						class181_0.uint_0 |= (uint)(((class181_0.byte_0[class181_0.int_0++] & 0xFF) | ((class181_0.byte_0[class181_0.int_0++] & 0xFF) << 8)) << class181_0.int_2);
						num = 747151361;
						continue;
					case 1u:
						num = ((class181_0.int_0 != class181_0.int_1) ? (-1238470154) : (-1539894572)) ^ ((int)num2 * -1928924540);
						continue;
					case 4u:
						break;
					case 0u:
						return -1;
					default:
						goto end_IL_00e5;
					}
					break;
				}
				continue;
				end_IL_00e5:
				break;
			}
		}
		return (int)(class181_0.uint_0 & ((1 << int_0) - 1));
	}

	internal static DeflateDecoder.Class183 smethod_62(DeflateDecoder.Class184 class184_0)
	{
		byte[] array = new byte[class184_0.int_4];
		Array.Copy(class184_0.byte_1, class184_0.int_3, array, 0, class184_0.int_4);
		return new DeflateDecoder.Class183(array);
	}

	internal static DeflateDecoder.Class183 smethod_63(DeflateDecoder.Class184 class184_0)
	{
		byte[] array = new byte[class184_0.int_3];
		while (true)
		{
			int num = 350888334;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x268BA18B)) % 3)
				{
				case 1u:
					goto IL_000e;
				case 2u:
					break;
				default:
					return new DeflateDecoder.Class183(array);
				}
				break;
				IL_000e:
				Array.Copy(class184_0.byte_1, 0, array, 0, class184_0.int_3);
				num = ((int)num2 * -1090434049) ^ -1694220453;
			}
		}
	}

	internal static int smethod_65(DeflateDecoder.Class181 class181_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		int num4 = default(int);
		while (true)
		{
			int num2 = -1279970656;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1292105655)) % 17)
				{
				case 16u:
					Array.Copy(class181_0.byte_0, class181_0.int_0, byte_0, int_0, int_1);
					num2 = -1173540011;
					continue;
				case 15u:
					int_1 = num4;
					num2 = ((int)num3 * -989037307) ^ -1238940198;
					continue;
				case 14u:
					num2 = ((class181_0.int_2 > 0) ? (-509353442) : (-669594247));
					continue;
				case 13u:
					class181_0.int_0 += int_1;
					num2 = ((int)num3 * -1718027050) ^ 0xFCAB4C8;
					continue;
				case 11u:
					num2 = ((((class181_0.int_0 - class181_0.int_1) & 1) != 0) ? (-976578256) : (-1392838230)) ^ (int)(num3 * 2000989252);
					continue;
				case 10u:
					num4 = class181_0.int_1 - class181_0.int_0;
					num2 = -1954172292;
					continue;
				case 9u:
					num2 = ((int_1 > num4) ? (-2121059616) : (-372515397)) ^ (int)(num3 * 1954470127);
					continue;
				case 8u:
					num2 = ((int)num3 * -860779836) ^ 0x70C3E387;
					continue;
				case 7u:
					num2 = ((int_1 == 0) ? (-1618309455) : (-851899883));
					continue;
				case 6u:
					num2 = ((int_1 <= 0) ? 1170426718 : 482698054) ^ (int)(num3 * 1372553393);
					continue;
				case 4u:
					class181_0.uint_0 = (uint)(class181_0.byte_0[class181_0.int_0++] & 0xFF);
					class181_0.int_2 = 8;
					num2 = (int)(num3 * 183728945) ^ -433078973;
					continue;
				case 3u:
					byte_0[int_0++] = (byte)class181_0.uint_0;
					num2 = -621009528;
					continue;
				case 2u:
					class181_0.uint_0 >>= 8;
					class181_0.int_2 -= 8;
					num2 = (int)(num3 * 852872212) ^ -929170044;
					continue;
				case 0u:
					int_1--;
					num++;
					num2 = ((int)num3 * -2018785216) ^ -880842333;
					continue;
				case 12u:
					break;
				case 1u:
					return num;
				default:
					return num + int_1;
				}
				break;
			}
		}
	}

	internal static bool smethod_69()
	{
		if (!PlatformInfo.bool_1)
		{
			goto IL_0019;
		}
		goto IL_00da;
		IL_0019:
		int num = -1308890482;
		goto IL_008c;
		IL_008c:
		TokenPrivilegeNativeTypes.Enum17 @enum = default(TokenPrivilegeNativeTypes.Enum17);
		uint uint_ = default(uint);
		IntPtr intptr_ = default(IntPtr);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -685180407)) % 11)
			{
			case 10u:
				break;
			case 8u:
				@enum = (TokenPrivilegeNativeTypes.Enum17)uint_;
				num = ((int)num2 * -46335719) ^ 0xF007824;
				continue;
			case 6u:
				goto IL_0032;
			case 2u:
				CloseHandle(intptr_);
				num = -1463965964;
				continue;
			case 1u:
				num = ((@enum == TokenPrivilegeNativeTypes.Enum17.const_1) ? (-1423328528) : (-509497601)) ^ ((int)num2 * -426048021);
				continue;
			case 9u:
				goto IL_00da;
			case 0u:
				CloseHandle(intptr_);
				return false;
			default:
				return true;
			case 4u:
				return false;
			case 5u:
				return @enum == TokenPrivilegeNativeTypes.Enum17.const_2;
			case 7u:
				return false;
			}
			break;
			IL_0032:
			num = ((!GetTokenInformation(intptr_, TokenPrivilegeNativeTypes.Enum16.const_17, out uint_, 4u, out var _)) ? (-1302826452) : (-1876553708));
		}
		goto IL_0019;
		IL_00da:
		num = (OpenProcessToken(GetCurrentProcess_1(), 8u, out intptr_) ? (-1172786300) : (-1386544104));
		goto IL_008c;
	}

	internal static void smethod_77(DeflateDecoder.Class182 class182_0, int int_0)
	{
		int num = class182_0.int_1++;
		while (true)
		{
			int num2 = -131736541;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1867479119)) % 6)
				{
				case 5u:
					class182_0.int_0 &= 32767;
					num2 = ((int)num3 * -1555515884) ^ -290284910;
					continue;
				case 4u:
					num2 = ((num == 32768) ? (-1748747564) : (-267253145)) ^ (int)(num3 * 1375128157);
					continue;
				case 0u:
					class182_0.byte_0[class182_0.int_0++] = (byte)int_0;
					num2 = -883352964;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					throw new InvalidOperationException();
				case 1u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_78(byte[] byte_0, PeScrambler gclass4_0)
	{
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
		long num = 0L;
		int num4 = default(int);
		while (true)
		{
			int num2 = (((num = smethod_1(gclass4_0, byte_0, num)) != -1L) ? (-1849902106) : (-386024766));
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -744666815)) % 8)
				{
				case 7u:
					gclass4_0.class154_0.method_28().Position = num;
					num4 = 0;
					num2 = -1755074739;
					continue;
				case 6u:
					num++;
					num2 = (int)((num3 * 1031214195) ^ 0x7346D419);
					continue;
				case 5u:
					num2 = ((num4 < byte_0.Length) ? (-1397530216) : (-1898709561));
					continue;
				case 4u:
					num2 = ((int)num3 * -1337299210) ^ 0x1DB645AC;
					continue;
				case 1u:
					binaryWriter.Write((byte)0);
					num4++;
					num2 = -1896582620;
					continue;
				case 0u:
					num2 = -1849902106;
					continue;
				default:
					return;
				case 2u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	internal static bool smethod_85(ExportedSymbol class152_0)
	{
		return class152_0.method_8() != null;
	}

	internal static void smethod_86(RemotePeb class117_0, IntPtr intptr_0)
	{
		class117_0.method_18(intptr_0);
	}

	internal static bool smethod_89(ResourceIdentifier class137_0)
	{
		return !smethod_387(class137_0);
	}

	internal static void smethod_93(IEnumerable<PeScrambler.Class132> ienumerable_0, PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_18() != null)
		{
			BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
			gclass4_0.class154_0.method_28().Position = smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_6().method_3().imethod_49()[6].method_0()) + 20L;
			uint value;
			gclass4_0.class154_0.method_18().method_8(value = smethod_33(ienumerable_0, gclass4_0.class154_0.method_18().method_7()));
			binaryWriter.Write(value);
			gclass4_0.class154_0.method_18().method_10(value = (uint)smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_18().method_9()));
			binaryWriter.Write(value);
		}
	}

	internal static void smethod_95(PeScrambler gclass4_0)
	{
		gclass4_0.class154_0.method_6().method_3().imethod_33(0u);
		while (true)
		{
			int num = 1791896488;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xF5873BF)) % 26)
				{
				case 25u:
					num = (gclass4_0.class131_0.method_23() ? 422384222 : 583317164);
					continue;
				case 23u:
					gclass4_0.method_1();
					num = (int)(num2 * 1157421226) ^ -930130104;
					continue;
				case 22u:
					smethod_46(gclass4_0);
					num = (int)((num2 * 1836723783) ^ 0x6ECC760B);
					continue;
				case 20u:
					num = (gclass4_0.class131_0.method_2() ? 532656826 : 785011267);
					continue;
				case 19u:
					smethod_0(gclass4_0);
					num = (int)((num2 * 1677140356) ^ 0x6E43FF78);
					continue;
				case 18u:
					num = ((!gclass4_0.class131_0.method_6()) ? 1797716505 : 123876975) ^ ((int)num2 * -438131779);
					continue;
				case 17u:
					num = ((!gclass4_0.class131_0.method_25()) ? 637998268 : 129449792);
					continue;
				case 16u:
					num = (gclass4_0.class131_0.method_2() ? (-1811696325) : (-1268232499)) ^ (int)(num2 * 204627375);
					continue;
				case 15u:
					smethod_376(gclass4_0);
					num = ((int)num2 * -1192122978) ^ 0x439DDB72;
					continue;
				case 14u:
					gclass4_0.method_3();
					num = ((int)num2 * -665272190) ^ -1902203311;
					continue;
				case 13u:
					gclass4_0.method_0();
					num = (int)((num2 * 1566650013) ^ 0x6C301EDF);
					continue;
				case 12u:
					smethod_208(gclass4_0);
					num = (int)(num2 * 765843847) ^ -450327029;
					continue;
				case 11u:
					num = (gclass4_0.class131_0.method_23() ? 1686228271 : 1879245819);
					continue;
				case 10u:
					num = (gclass4_0.class131_0.method_4() ? 165404659 : 887202439);
					continue;
				case 9u:
					num = (gclass4_0.class131_0.method_10() ? 1638393187 : 68236777);
					continue;
				case 8u:
					smethod_415(gclass4_0);
					num = 1704924037;
					continue;
				case 7u:
					gclass4_0.method_4();
					num = ((int)num2 * -1730583444) ^ 0x10A2305F;
					continue;
				case 6u:
					num = ((!gclass4_0.class131_0.method_8()) ? 786691494 : 172153109);
					continue;
				case 5u:
					num = (gclass4_0.class131_0.method_18() ? 1738962176 : 794879492);
					continue;
				case 4u:
					num = ((!gclass4_0.class131_0.method_0()) ? 1206828576 : 273317088);
					continue;
				case 3u:
					smethod_382(gclass4_0);
					num = ((int)num2 * -425951579) ^ -436857829;
					continue;
				case 2u:
					gclass4_0.method_2();
					num = ((int)num2 * -2097509375) ^ -1232054516;
					continue;
				case 1u:
					num = ((!gclass4_0.class131_0.method_12()) ? (-308572565) : (-199791469)) ^ (int)(num2 * 1064450590);
					continue;
				case 0u:
					num = (gclass4_0.class131_0.method_16() ? 1816581886 : 1431028322);
					continue;
				default:
					return;
				case 24u:
					break;
				case 21u:
					return;
				}
				break;
			}
		}
	}

	internal static int smethod_96(DeflateDecoder.Class183 class183_0, DeflateDecoder.Class181 class181_0)
	{
		int num;
		if ((num = smethod_60(class181_0, 9)) >= 0)
		{
			goto IL_013b;
		}
		goto IL_0237;
		IL_013b:
		int num2 = 804356770;
		goto IL_01d4;
		IL_01d4:
		int num4 = default(int);
		int int_2 = default(int);
		int num5 = default(int);
		int int_ = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ 0x3E3938FC)) % 20)
			{
			case 19u:
				num2 = ((num4 >= 0) ? 1687797849 : 1348845352) ^ (int)(num3 * 1163833347);
				continue;
			case 18u:
				num2 = (((num = smethod_60(class181_0, int_2)) >= 0) ? 1740472505 : 1182372546) ^ (int)(num3 * 1040800981);
				continue;
			case 15u:
				num4 = class183_0.short_0[num5 | (num >> 9)];
				num2 = ((int)num3 * -346619632) ^ -1596809639;
				continue;
			case 14u:
				num5 = -(num4 >> 4);
				num2 = 468719661;
				continue;
			case 13u:
				smethod_396(class181_0, num4 & 0xF);
				num2 = (int)((num3 * 1748186032) ^ 0x63574063);
				continue;
			case 12u:
				num2 = (((num4 & 0xF) <= int_) ? 1831124907 : 1514402093) ^ (int)(num3 * 129063545);
				continue;
			case 9u:
				int_2 = num4 & 0xF;
				num2 = (int)((num3 * 625002258) ^ 0x4895C250);
				continue;
			case 8u:
				smethod_396(class181_0, num4 & 0xF);
				num2 = ((int)num3 * -1905125322) ^ 0x1A8AC5FA;
				continue;
			case 7u:
				smethod_396(class181_0, num4 & 0xF);
				num2 = ((int)num3 * -614699220) ^ -1961755467;
				continue;
			case 6u:
				break;
			case 4u:
				num = smethod_60(class181_0, int_);
				num4 = class183_0.short_0[num];
				num2 = ((int)num3 * -28147758) ^ 0x63E672E7;
				continue;
			case 2u:
				num2 = (((num4 = class183_0.short_0[num]) < 0) ? (-768289090) : (-1715909475)) ^ ((int)num3 * -1229649980);
				continue;
			case 0u:
				goto IL_0196;
			case 3u:
				goto IL_0237;
			case 1u:
				return num4 >> 4;
			case 5u:
				smethod_396(class181_0, num4 & 0xF);
				return num4 >> 4;
			case 10u:
				return num4 >> 4;
			case 11u:
				return num4 >> 4;
			case 16u:
				return -1;
			default:
				return -1;
			}
			break;
			IL_0196:
			int int_3 = class181_0.int_2;
			num = smethod_60(class181_0, int_3);
			num4 = class183_0.short_0[num5 | (num >> 9)];
			num2 = (((num4 & 0xF) > int_3) ? 499341404 : 1595850012);
		}
		goto IL_013b;
		IL_0237:
		int_ = class181_0.int_2;
		num2 = 1720250300;
		goto IL_01d4;
	}

	internal static byte[] smethod_99()
	{
		return (byte[])smethod_124().GetObject("BeaEnginex64", EmbeddedResources.cultureInfo_0);
	}

	internal static void smethod_101(long long_0, ResourceDirectory class166_0, ResourceDirectoryNode class138_0)
	{
		class138_0.method_5(new List<ResourceDataEntry>());
		class138_0.method_7(new List<ResourceDirectoryNode>());
		class138_0.class166_0 = class166_0;
		class138_0.long_0 = long_0;
		smethod_414(class138_0);
	}

	internal static bool smethod_106(DeflateDecoder.Class181 class181_0)
	{
		return class181_0.int_0 == class181_0.int_1;
	}

	internal static void smethod_107(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_0() != 0)
		{
			goto IL_0080;
		}
		goto IL_01e1;
		IL_01e1:
		int num = 1540268617;
		goto IL_0130;
		IL_0130:
		uint num3 = default(uint);
		BinaryReader binaryReader = default(BinaryReader);
		long num4 = default(long);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2879BA9A)) % 13)
			{
			case 10u:
				num3 &= 0xFFFFFFFEu;
				num = (int)(num2 * 1642574177) ^ -766018388;
				continue;
			case 9u:
				num3 = binaryReader.ReadUInt32();
				num = (int)(num2 * 225167678) ^ -1198358030;
				continue;
			case 8u:
				binaryReader = new BinaryReader(gclass4_0.class154_0.method_28());
				num = 66023607;
				continue;
			case 7u:
				break;
			case 3u:
				gclass4_0.class154_0.method_28().Position = num4;
				num = ((binaryReader.ReadUInt32() != 72) ? (-756290713) : (-1131452985)) ^ ((int)num2 * -519581230);
				continue;
			case 2u:
				gclass4_0.class154_0.method_28().Position -= 4L;
				new BinaryWriter(gclass4_0.class154_0.method_28()).Write(num3);
				num = (int)((num2 * 1932561234) ^ 0x2C464B6F);
				continue;
			case 0u:
				gclass4_0.class154_0.method_28().Position += 12L;
				num = 2145782378;
				continue;
			default:
				return;
			case 4u:
				goto IL_0185;
			case 1u:
				goto IL_01bf;
			case 5u:
				return;
			case 6u:
				return;
			case 11u:
				return;
			case 12u:
				return;
			}
			break;
			IL_01bf:
			if (gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_2() != 0)
			{
				goto IL_0185;
			}
			goto IL_01e1;
			IL_0185:
			num4 = smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_0());
			num = ((num4 != -1L) ? 631714841 : 1958634042);
		}
		goto IL_0080;
		IL_0080:
		num = 1901011903;
		goto IL_0130;
	}

	internal static int smethod_117(Type type_0)
	{
		if (!RemotePlatformStructure.dictionary_0.TryGetValue(type_0, out var value))
		{
			int count2 = default(int);
			int count = default(int);
			while (true)
			{
				int num = -1812518983;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1196368478)) % 8)
					{
					case 5u:
						num = ((RemotePlatformStructure.dictionary_0.Count == count2) ? 1408843307 : 389450692) ^ (int)(num2 * 2046695968);
						continue;
					case 3u:
						num = ((!RemotePlatformStructure.dictionary_1.TryGetValue(type_0, out value)) ? 480763582 : 392920140) ^ (int)(num2 * 1794690250);
						continue;
					case 2u:
						count2 = RemotePlatformStructure.dictionary_0.Count;
						count = RemotePlatformStructure.dictionary_1.Count;
						RuntimeHelpers.RunClassConstructor(type_0.TypeHandle);
						num = ((int)num2 * -730663630) ^ -1029810517;
						continue;
					case 1u:
						num = ((RemotePlatformStructure.dictionary_1.Count == count) ? 1835531670 : 358723004) ^ ((int)num2 * -2081947112);
						continue;
					case 7u:
						break;
					case 4u:
						throw new InvalidOperationException(string.Concat("Unregistered PlatformStruct detected. (", type_0, ")"));
					case 6u:
						return smethod_117(type_0);
					default:
						goto end_IL_0105;
					}
					break;
				}
				continue;
				end_IL_0105:
				break;
			}
		}
		return value[value.Length - 1];
	}

	internal static void smethod_119(RemoteListEntry class100_0)
	{
		RemoteListEntry @class = class100_0.method_07D3();
		RemoteListEntry class2 = class100_0.method_07D2();
		@class.vmethod_8(class100_0.vmethod_7());
		while (true)
		{
			int num = -1640131843;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -174458422)) % 3)
				{
				case 1u:
					goto IL_001a;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_001a:
				class2.vmethod_10(class100_0.vmethod_9());
				num = (int)((num2 * 1382849504) ^ 0x2638FDB7);
			}
		}
	}

	internal static int smethod_123(byte[] byte_0, byte[] byte_1, int int_0)
	{
		if (int_0 + byte_1.Length > byte_0.Length)
		{
			goto IL_0019;
		}
		goto IL_007a;
		IL_0019:
		int num = -1871514311;
		goto IL_0045;
		IL_0045:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2056336564)) % 6)
			{
			case 5u:
				break;
			case 4u:
				num = ((byte_1.Length >= 5) ? 422564794 : 76445371) ^ (int)(num2 * 20031120);
				continue;
			case 2u:
				goto IL_007a;
			default:
				return smethod_12(byte_0, byte_1, int_0);
			case 1u:
				return smethod_152(byte_0, byte_1, int_0);
			case 3u:
				return -1;
			}
			break;
		}
		goto IL_0019;
		IL_007a:
		num = ((byte_0.Length - int_0 < 20000) ? (-985534181) : (-1380554202));
		goto IL_0045;
	}

	internal static int smethod_129(RemoteModuleManager class93_0, RemotePeb class117_0, IntPtr intptr_0)
	{
		RemoteLdrDataTableEntry @class = class117_0.method_0823().method_080D().method_07DF();
		while (true)
		{
			int num = -1765660381;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1543971278)) % 10)
				{
				case 8u:
					@class = @class.method_07EE().method_07DF();
					num = -783843894;
					continue;
				case 7u:
					num = ((@class.method_07F1() == intptr_0) ? (-126422960) : (-1110077348));
					continue;
				case 6u:
					num = ((@class == null) ? (-646695522) : (-2056828003));
					continue;
				case 5u:
					num = ((int)num2 * -1387812620) ^ -1605707266;
					continue;
				case 2u:
					num = ((!PlatformInfo.bool_5) ? (-1501176021) : (-376529140)) ^ ((int)num2 * -201121100);
					continue;
				case 1u:
					num = ((@class.method_07F1() != IntPtr.Zero) ? (-2039884550) : (-762392327)) ^ (int)(num2 * 290345417);
					continue;
				case 9u:
					break;
				case 0u:
					return (int)@class.method_07F5().vmethod_7();
				case 3u:
					return @class.method_07F2();
				default:
					return -1;
				}
				break;
			}
		}
	}

	internal static int smethod_130(byte[] byte_0, int int_0, int int_1, DeflateDecoder.Class180 class180_0)
	{
		int num = 0;
		int num4 = default(int);
		while (true)
		{
			int num2 = -129065528;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -830147616)) % 11)
				{
				case 10u:
					int_0 += num4;
					num += num4;
					num2 = ((int)num3 * -1971719893) ^ 0x7B7CAFA2;
					continue;
				case 9u:
					num2 = ((int_1 != 0) ? (-1223071781) : (-364726180)) ^ ((int)num3 * -674420475);
					continue;
				case 8u:
					num2 = ((!smethod_436(class180_0)) ? (-184345014) : (-129065528));
					continue;
				case 6u:
					num4 = smethod_265(int_0, class180_0.class182_0, int_1, byte_0);
					num2 = (int)(num3 * 230657597) ^ -1398654487;
					continue;
				case 5u:
					num2 = ((class180_0.int_4 == 11) ? (-577772466) : (-1037257313));
					continue;
				case 4u:
					num2 = ((class180_0.class182_0.int_1 <= 0) ? 557979265 : 759959030) ^ ((int)num3 * -50524817);
					continue;
				case 1u:
					num2 = ((class180_0.int_4 != 11) ? 1927606120 : 1542179479) ^ (int)(num3 * 109038033);
					continue;
				case 0u:
					int_1 -= num4;
					num2 = ((int)num3 * -1408966223) ^ -652534051;
					continue;
				case 7u:
					break;
				case 2u:
					return num;
				default:
					return num;
				}
				break;
			}
		}
	}

	internal static void smethod_132(DeflateDecoder.Class182 class182_0, int int_0, int int_1)
	{
		if ((class182_0.int_1 += int_0) > 32768)
		{
			goto IL_0080;
		}
		goto IL_0172;
		IL_0080:
		int num = -1964982322;
		goto IL_0120;
		IL_0120:
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -789671828)) % 12)
			{
			case 9u:
				num = ((class182_0.int_0 >= num4) ? (-984718392) : (-604495937)) ^ ((int)num2 * -1168367466);
				continue;
			case 8u:
				break;
			case 7u:
				goto end_IL_0120;
			case 6u:
				class182_0.byte_0[class182_0.int_0++] = class182_0.byte_0[num3++];
				num = -1165976356;
				continue;
			case 5u:
				num = ((int_0 > int_1) ? (-1798713815) : (-1816749427)) ^ (int)(num2 * 498749185);
				continue;
			case 4u:
				class182_0.int_0 += int_0;
				num = ((int)num2 * -1002542591) ^ 0x2FE32187;
				continue;
			case 0u:
				Array.Copy(class182_0.byte_0, num3, class182_0.byte_0, class182_0.int_0, int_0);
				num = ((int)num2 * -1936763011) ^ -1682855348;
				continue;
			case 1u:
				goto IL_0172;
			default:
				smethod_168(class182_0, num3, int_0, int_1);
				return;
			case 3u:
				return;
			case 10u:
				throw new InvalidOperationException();
			case 11u:
				return;
			}
			num = ((int_0-- > 0) ? (-970171042) : (-545212025));
			continue;
			end_IL_0120:
			break;
		}
		goto IL_0080;
		IL_0172:
		num3 = (class182_0.int_0 - int_1) & 0x7FFF;
		num4 = 32768 - int_0;
		num = ((num3 > num4) ? (-1596302354) : (-573667787));
		goto IL_0120;
	}

	internal static bool smethod_133(RemoteModuleUnlinker class129_0, RemotePeb class117_0, IntPtr intptr_0)
	{
		RemoteLdrDataTableEntry @class = class117_0.method_0823().method_080D().method_07DF();
		while (true)
		{
			int num = -853588743;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1855183036)) % 10)
				{
				case 9u:
					@class = @class.method_07EE().method_07DF();
					num = -887775417;
					continue;
				case 7u:
					smethod_119(@class.method_07F0());
					smethod_119(@class.method_07EE());
					num = (int)(num2 * 1582238711) ^ -1185054201;
					continue;
				case 6u:
					num = ((!(@class.method_07F1() != IntPtr.Zero)) ? 1724765792 : 1683899044) ^ ((int)num2 * -2102211423);
					continue;
				case 5u:
					num = (int)((num2 * 884749128) ^ 0x6B0B2B6F);
					continue;
				case 4u:
					num = ((!(@class.method_07F1() == intptr_0)) ? (-1368566679) : (-2127379857));
					continue;
				case 3u:
					num = ((@class == null) ? (-592076686) : (-818905706));
					continue;
				case 2u:
					smethod_119(@class.method_07EF());
					smethod_119(@class.method_07F3());
					num = (int)((num2 * 1225383232) ^ 0x30C61F);
					continue;
				case 0u:
					break;
				case 1u:
					return true;
				default:
					return false;
				}
				break;
			}
		}
	}

	internal static object smethod_138(ExportParameter class17_0)
	{
		if (class17_0.Type != ExportParameterType.AnsiString)
		{
			char result = default(char);
			while (true)
			{
				int num = -2102545770;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -284502838)) % 9)
					{
					case 8u:
						break;
					case 7u:
						goto IL_0032;
					case 5u:
						num = ((class17_0.Type == ExportParameterType.UnicodeString) ? (-1735061705) : (-489017136)) ^ (int)(num2 * 25929941);
						continue;
					case 3u:
						num = (char.TryParse(class17_0.Value, out result) ? (-1648022941) : (-1949091339)) ^ (int)(num2 * 713691138);
						continue;
					case 0u:
						goto end_IL_00ac;
					default:
						try
						{
							object obj = new Int64Converter().ConvertFromString(class17_0.Value);
							if (obj != null)
							{
								return (long)obj;
							}
						}
						catch
						{
						}
						return null;
					case 4u:
						return (long)result;
					case 6u:
						return float.Parse(class17_0.Value);
					case 1u:
						goto end_IL_00e2;
					}
					num = ((class17_0.Type == ExportParameterType.Byte) ? (-156496262) : (-401896299));
					continue;
					IL_0032:
					num = ((class17_0.Type != ExportParameterType.Single) ? (-1524535812) : (-1745716555));
					continue;
					end_IL_00ac:
					break;
				}
				continue;
				end_IL_00e2:
				break;
			}
		}
		return class17_0.Value;
	}

	internal static void smethod_141(DeflateDecoder.Class181 class181_0)
	{
		class181_0.uint_0 >>= class181_0.int_2 & 7;
		class181_0.int_2 &= -8;
	}

	internal static void smethod_143(byte[] byte_0, byte[] byte_1, PeScrambler gclass4_0)
	{
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
		long num = 0L;
		while (true)
		{
			int num2 = 888822696;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x33D372AF)) % 5)
				{
				case 4u:
					num2 = (((num = smethod_1(gclass4_0, byte_1, num)) == -1L) ? 1929497209 : 1287419494);
					continue;
				case 3u:
					gclass4_0.class154_0.method_28().Position = num;
					binaryWriter.Write(byte_0);
					num++;
					num2 = 1462239788;
					continue;
				case 1u:
					num2 = ((int)num3 * -1159321426) ^ 0x6984F8EE;
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

	internal static byte[] smethod_144(ResourceDirectory class166_0, int int_0)
	{
		return class166_0.class5_0.ReadBytes(int_0);
	}

	internal static string CreateUniqueTemporaryPath(string extension)
	{
		string temporaryDirectory = Path.GetTempPath();
		while (true)
		{
			string fileName = Guid.NewGuid()
				.ToString("N")
				.Substring(0, PlatformInfo.random_0.Next(5, 10)) + extension;
			string candidatePath = Path.Combine(temporaryDirectory, fileName);
			if (!File.Exists(candidatePath))
			{
				return candidatePath;
			}
		}
	}

	internal unsafe static int smethod_152(byte[] byte_0, byte[] byte_1, int int_0)
	{
		return IndexOfBytes(byte_0, byte_1, int_0);
#if false
		//The blocks IL_0012, IL_0022, IL_003b, IL_0041, IL_004d, IL_0057, IL_0066, IL_006e, IL_007a, IL_008a, IL_0090, IL_009c, IL_00ac, IL_00b4, IL_00be, IL_00da, IL_00ed, IL_00f2, IL_00fe, IL_010e, IL_0113, IL_011f, IL_0129, IL_0138, IL_014b, IL_0162, IL_0175, IL_0190, IL_0195, IL_01a1, IL_01ab, IL_01c7, IL_01e2, IL_01ef, IL_0214, IL_022a, IL_0230, IL_023c, IL_0249, IL_0256, IL_0266, IL_0269, IL_026e, IL_02f9, IL_0308, IL_0312, IL_0314, IL_031e, IL_0320 are reachable both inside and outside the pinned region starting at IL_00cf. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0012, IL_0022, IL_003b, IL_0041, IL_004d, IL_0057, IL_0066, IL_006e, IL_007a, IL_008a, IL_0090, IL_009c, IL_00be, IL_00da, IL_00ed, IL_00f2, IL_00fe, IL_010e, IL_0113, IL_011f, IL_0129, IL_0138, IL_014b, IL_0162, IL_0175, IL_0190, IL_0195, IL_01a1, IL_01ab, IL_01c7, IL_01e2, IL_01ef, IL_0214, IL_022a, IL_0230, IL_023c, IL_0249, IL_0256, IL_026e, IL_02f9, IL_0308, IL_0312, IL_0314, IL_031e, IL_0320 are reachable both inside and outside the pinned region starting at IL_00b3. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0012, IL_0022, IL_003b, IL_0041, IL_004d, IL_0057, IL_0066, IL_006e, IL_007a, IL_008a, IL_0090, IL_009c, IL_00be, IL_00c8, IL_00da, IL_00ed, IL_00f2, IL_00fe, IL_010e, IL_0113, IL_011f, IL_0129, IL_0138, IL_014b, IL_0162, IL_0175, IL_0190, IL_0195, IL_01a1, IL_01ab, IL_01ba, IL_01bd, IL_01c7, IL_01e2, IL_01ef, IL_01fe, IL_0214, IL_022a, IL_0230, IL_023c, IL_0249, IL_0256, IL_026e, IL_02f9, IL_0308, IL_0312, IL_0314, IL_031e, IL_0320 are reachable both inside and outside the pinned region starting at IL_00b3. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if (int_0 + byte_1.Length > byte_0.Length)
		{
			goto IL_00be;
		}
		goto IL_0308;
		IL_00be:
		int num = 1550813410;
		goto IL_026e;
		IL_026e:
		byte* ptr = default(byte*);
		byte* ptr2 = default(byte*);
		byte* ptr8 = default(byte*);
		byte[] array = default(byte[]);
		byte* ptr3 = default(byte*);
		byte* ptr5 = default(byte*);
		byte[] array4 = default(byte[]);
		byte* ptr4 = default(byte*);
		byte[] array2;
		ref byte reference2 = default(ref byte);
		ref byte reference = default(ref byte);
		while (true)
		{
			uint num3;
			uint num2 = (num3 = (uint)(num ^ 0x1CC179D7));
			int num5;
			byte[] array3;
			int num6;
			int num4;
			switch (num2 % 30)
			{
			case 28u:
				ptr++;
				num = (int)((num3 * 353874751) ^ 0x42533ADE);
				continue;
			case 27u:
				num5 = ((ptr2 != ptr8) ? (-1514016375) : (-2098514193));
				num = num5 ^ (int)(num3 * 1978126315);
				continue;
			case 26u:
				break;
			case 25u:
				goto IL_008a;
			case 24u:
				while (true)
				{
					fixed (byte* ptr6 = &array[0])
					{
						num = 11615403;
						while (true)
						{
							num2 = (num3 = (uint)(num ^ 0x1CC179D7));
							switch (num2 % 30)
							{
							case 24u:
								break;
							case 28u:
								ptr++;
								num = (int)((num3 * 353874751) ^ 0x42533ADE);
								continue;
							case 27u:
								num5 = ((ptr2 != ptr8) ? (-1514016375) : (-2098514193));
								num = num5 ^ (int)(num3 * 1978126315);
								continue;
							case 26u:
								num = ((*ptr3 == *ptr2) ? 2123798621 : 1822946217);
								continue;
							case 25u:
								num = ((ptr == ptr5) ? 795415700 : 75599937);
								continue;
							case 22u:
								num = 1550813410;
								continue;
							case 20u:
								while (true)
								{
									fixed (byte* ptr7 = &array4[0])
									{
										num = 1249974657;
										while (true)
										{
											num2 = (num3 = (uint)(num ^ 0x1CC179D7));
											switch (num2 % 30)
											{
											case 20u:
												break;
											case 28u:
												ptr++;
												num = (int)((num3 * 353874751) ^ 0x42533ADE);
												continue;
											case 27u:
												num5 = ((ptr2 != ptr8) ? (-1514016375) : (-2098514193));
												num = num5 ^ (int)(num3 * 1978126315);
												continue;
											case 26u:
												num = ((*ptr3 == *ptr2) ? 2123798621 : 1822946217);
												continue;
											case 25u:
												num = ((ptr == ptr5) ? 795415700 : 75599937);
												continue;
											case 24u:
												while (true)
												{
													fixed (byte* ptr6 = &array[0])
													{
														num = 11615403;
														while (true)
														{
															num2 = (num3 = (uint)(num ^ 0x1CC179D7));
															switch (num2 % 30)
															{
															case 20u:
																break;
															case 24u:
																goto end_IL_00b4;
															case 28u:
																ptr++;
																num = (int)((num3 * 353874751) ^ 0x42533ADE);
																continue;
															case 27u:
																num5 = ((ptr2 != ptr8) ? (-1514016375) : (-2098514193));
																num = num5 ^ (int)(num3 * 1978126315);
																continue;
															case 26u:
																num = ((*ptr3 == *ptr2) ? 2123798621 : 1822946217);
																continue;
															case 25u:
																num = ((ptr == ptr5) ? 795415700 : 75599937);
																continue;
															case 22u:
																num = 1550813410;
																continue;
															case 19u:
																num = ((int)num3 * -88324814) ^ -653895717;
																continue;
															case 18u:
																array3 = (array4 = byte_1);
																num = ((array3 == null) ? 679878485 : 715334150);
																continue;
															case 17u:
																num6 = ((array4.Length == 0) ? (-1334471696) : (-820751752));
																num = num6 ^ (int)(num3 * 2074434709);
																continue;
															case 16u:
																num = ((int)num3 * -1989358830) ^ -1568129721;
																continue;
															case 15u:
																ptr4 = ptr7;
																num = ((int)num3 * -991834868) ^ -140580313;
																continue;
															case 14u:
																num = (int)(num3 * 708224773) ^ -1506319928;
																continue;
															case 12u:
																ptr8 = ptr7 + byte_1.Length;
																num = ((int)num3 * -1359956091) ^ 0x52C465E7;
																continue;
															case 11u:
																num4 = ((array.Length == 0) ? (-1267433356) : (-49259144));
																num = num4 ^ ((int)num3 * -1233851803);
																continue;
															case 10u:
																goto end_IL_00c8;
															case 9u:
																ptr5 = ptr6 + byte_0.Length;
																num = ((int)num3 * -1674796939) ^ 0x1E7DB4DB;
																continue;
															case 8u:
																ptr3++;
																num = 542755379;
																continue;
															case 6u:
																ptr3 = ptr;
																ptr2 = ptr4;
																num = 1107967140;
																continue;
															case 5u:
																goto IL_01fe;
															case 4u:
																ptr2++;
																num = (int)(num3 * 1004294757) ^ -170870;
																continue;
															case 3u:
																num = ((ptr3 == ptr5) ? 1485449054 : 1767638763);
																continue;
															case 2u:
																ptr = ptr6 + int_0;
																num = 255907048;
																continue;
															case 1u:
																num = (int)((num3 * 1259605401) ^ 0x7EA35E50);
																continue;
															case 0u:
																goto IL_0266;
															case 21u:
																array2 = (array = byte_0);
																num = ((array2 == null) ? 1540936243 : 748466412);
																continue;
															case 7u:
																return -1;
															case 13u:
																return (int)(ptr - ptr6);
															default:
																return -1;
															case 29u:
																return -1;
															}
															break;
														}
														break;
														end_IL_00b4:;
													}
												}
												break;
											case 22u:
												num = 1550813410;
												continue;
											case 19u:
												num = ((int)num3 * -88324814) ^ -653895717;
												continue;
											case 18u:
												array3 = (array4 = byte_1);
												num = ((array3 == null) ? 679878485 : 715334150);
												continue;
											case 17u:
												num6 = ((array4.Length == 0) ? (-1334471696) : (-820751752));
												num = num6 ^ (int)(num3 * 2074434709);
												continue;
											case 16u:
												num = ((int)num3 * -1989358830) ^ -1568129721;
												continue;
											case 15u:
												ptr4 = ptr7;
												num = ((int)num3 * -991834868) ^ -140580313;
												continue;
											case 14u:
												num = (int)(num3 * 708224773) ^ -1506319928;
												continue;
											case 12u:
												ptr8 = ptr7 + byte_1.Length;
												num = ((int)num3 * -1359956091) ^ 0x52C465E7;
												continue;
											case 11u:
												num4 = ((array.Length == 0) ? (-1267433356) : (-49259144));
												num = num4 ^ ((int)num3 * -1233851803);
												continue;
											case 10u:
												goto end_IL_00c8;
											case 9u:
												ptr5 = ptr6 + byte_0.Length;
												num = ((int)num3 * -1674796939) ^ 0x1E7DB4DB;
												continue;
											case 8u:
												ptr3++;
												num = 542755379;
												continue;
											case 6u:
												ptr3 = ptr;
												ptr2 = ptr4;
												num = 1107967140;
												continue;
											case 5u:
												goto IL_01fe;
											case 4u:
												ptr2++;
												num = (int)(num3 * 1004294757) ^ -170870;
												continue;
											case 3u:
												num = ((ptr3 == ptr5) ? 1485449054 : 1767638763);
												continue;
											case 2u:
												ptr = ptr6 + int_0;
												num = 255907048;
												continue;
											case 1u:
												num = (int)((num3 * 1259605401) ^ 0x7EA35E50);
												continue;
											case 0u:
												goto IL_0266;
											case 21u:
												array2 = (array = byte_0);
												num = ((array2 == null) ? 1540936243 : 748466412);
												continue;
											case 7u:
												return -1;
											case 13u:
												return (int)(ptr - ptr6);
											default:
												return -1;
											case 29u:
												{
													return -1;
												}
												IL_0266:
												ptr6 = null;
												num = 85297169;
												continue;
											}
											break;
										}
									}
									continue;
									end_IL_00c8:
									break;
								}
								goto case 10u;
							case 19u:
								num = ((int)num3 * -88324814) ^ -653895717;
								continue;
							case 18u:
								array3 = (array4 = byte_1);
								num = ((array3 == null) ? 679878485 : 715334150);
								continue;
							case 17u:
								num6 = ((array4.Length == 0) ? (-1334471696) : (-820751752));
								num = num6 ^ (int)(num3 * 2074434709);
								continue;
							case 16u:
								num = ((int)num3 * -1989358830) ^ -1568129721;
								continue;
							case 15u:
								ptr4 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
								num = ((int)num3 * -991834868) ^ -140580313;
								continue;
							case 14u:
								num = (int)(num3 * 708224773) ^ -1506319928;
								continue;
							case 12u:
								ptr8 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) + byte_1.Length;
								num = ((int)num3 * -1359956091) ^ 0x52C465E7;
								continue;
							case 11u:
								num4 = ((array.Length == 0) ? (-1267433356) : (-49259144));
								num = num4 ^ ((int)num3 * -1233851803);
								continue;
							case 10u:
								reference2 = ref *(byte*)null;
								num = 1688150114;
								continue;
							case 9u:
								ptr5 = ptr6 + byte_0.Length;
								num = ((int)num3 * -1674796939) ^ 0x1E7DB4DB;
								continue;
							case 8u:
								ptr3++;
								num = 542755379;
								continue;
							case 6u:
								ptr3 = ptr;
								ptr2 = ptr4;
								num = 1107967140;
								continue;
							case 5u:
								goto IL_01fe;
							case 4u:
								ptr2++;
								num = (int)(num3 * 1004294757) ^ -170870;
								continue;
							case 3u:
								num = ((ptr3 == ptr5) ? 1485449054 : 1767638763);
								continue;
							case 2u:
								ptr = ptr6 + int_0;
								num = 255907048;
								continue;
							case 1u:
								num = (int)((num3 * 1259605401) ^ 0x7EA35E50);
								continue;
							case 0u:
								goto end_IL_00ac;
							case 21u:
								array2 = (array = byte_0);
								num = ((array2 == null) ? 1540936243 : 748466412);
								continue;
							case 7u:
								return -1;
							case 13u:
								return (int)(ptr - ptr6);
							default:
								return -1;
							case 29u:
								{
									return -1;
								}
								IL_01fe:
								reference2 = ref *(byte*)null;
								goto IL_0211;
							}
							break;
						}
					}
					continue;
					end_IL_00ac:
					break;
				}
				goto case 0u;
			case 22u:
				goto end_IL_026e;
			case 20u:
				while (true)
				{
					fixed (byte* ptr7 = &array4[0])
					{
						num = 1249974657;
						while (true)
						{
							num2 = (num3 = (uint)(num ^ 0x1CC179D7));
							switch (num2 % 30)
							{
							case 20u:
								break;
							case 28u:
								ptr++;
								num = (int)((num3 * 353874751) ^ 0x42533ADE);
								continue;
							case 27u:
								num5 = ((ptr2 != ptr8) ? (-1514016375) : (-2098514193));
								num = num5 ^ (int)(num3 * 1978126315);
								continue;
							case 26u:
								num = ((*ptr3 == *ptr2) ? 2123798621 : 1822946217);
								continue;
							case 25u:
								num = ((ptr == ptr5) ? 795415700 : 75599937);
								continue;
							case 24u:
								while (true)
								{
									fixed (byte* ptr6 = &array[0])
									{
										num = 11615403;
										while (true)
										{
											num2 = (num3 = (uint)(num ^ 0x1CC179D7));
											switch (num2 % 30)
											{
											case 20u:
												break;
											case 24u:
												goto end_IL_00b4_2;
											case 28u:
												ptr++;
												num = (int)((num3 * 353874751) ^ 0x42533ADE);
												continue;
											case 27u:
												num5 = ((ptr2 != ptr8) ? (-1514016375) : (-2098514193));
												num = num5 ^ (int)(num3 * 1978126315);
												continue;
											case 26u:
												num = ((*ptr3 == *ptr2) ? 2123798621 : 1822946217);
												continue;
											case 25u:
												num = ((ptr == ptr5) ? 795415700 : 75599937);
												continue;
											case 22u:
												num = 1550813410;
												continue;
											case 19u:
												num = ((int)num3 * -88324814) ^ -653895717;
												continue;
											case 18u:
												array3 = (array4 = byte_1);
												num = ((array3 == null) ? 679878485 : 715334150);
												continue;
											case 17u:
												num6 = ((array4.Length == 0) ? (-1334471696) : (-820751752));
												num = num6 ^ (int)(num3 * 2074434709);
												continue;
											case 16u:
												num = ((int)num3 * -1989358830) ^ -1568129721;
												continue;
											case 15u:
												ptr4 = ptr7;
												num = ((int)num3 * -991834868) ^ -140580313;
												continue;
											case 14u:
												num = (int)(num3 * 708224773) ^ -1506319928;
												continue;
											case 12u:
												ptr8 = ptr7 + byte_1.Length;
												num = ((int)num3 * -1359956091) ^ 0x52C465E7;
												continue;
											case 11u:
												num4 = ((array.Length == 0) ? (-1267433356) : (-49259144));
												num = num4 ^ ((int)num3 * -1233851803);
												continue;
											case 10u:
												goto end_IL_00c8_2;
											case 9u:
												ptr5 = ptr6 + byte_0.Length;
												num = ((int)num3 * -1674796939) ^ 0x1E7DB4DB;
												continue;
											case 8u:
												ptr3++;
												num = 542755379;
												continue;
											case 6u:
												ptr3 = ptr;
												ptr2 = ptr4;
												num = 1107967140;
												continue;
											case 5u:
												goto IL_01fe_2;
											case 4u:
												ptr2++;
												num = (int)(num3 * 1004294757) ^ -170870;
												continue;
											case 3u:
												num = ((ptr3 == ptr5) ? 1485449054 : 1767638763);
												continue;
											case 2u:
												ptr = ptr6 + int_0;
												num = 255907048;
												continue;
											case 1u:
												num = (int)((num3 * 1259605401) ^ 0x7EA35E50);
												continue;
											case 0u:
												goto IL_0266_2;
											case 21u:
												array2 = (array = byte_0);
												num = ((array2 == null) ? 1540936243 : 748466412);
												continue;
											case 7u:
												return -1;
											case 13u:
												return (int)(ptr - ptr6);
											default:
												return -1;
											case 29u:
												return -1;
											}
											break;
										}
										break;
										end_IL_00b4_2:;
									}
								}
								break;
							case 22u:
								num = 1550813410;
								continue;
							case 19u:
								num = ((int)num3 * -88324814) ^ -653895717;
								continue;
							case 18u:
								array3 = (array4 = byte_1);
								num = ((array3 == null) ? 679878485 : 715334150);
								continue;
							case 17u:
								num6 = ((array4.Length == 0) ? (-1334471696) : (-820751752));
								num = num6 ^ (int)(num3 * 2074434709);
								continue;
							case 16u:
								num = ((int)num3 * -1989358830) ^ -1568129721;
								continue;
							case 15u:
								ptr4 = ptr7;
								num = ((int)num3 * -991834868) ^ -140580313;
								continue;
							case 14u:
								num = (int)(num3 * 708224773) ^ -1506319928;
								continue;
							case 12u:
								ptr8 = ptr7 + byte_1.Length;
								num = ((int)num3 * -1359956091) ^ 0x52C465E7;
								continue;
							case 11u:
								num4 = ((array.Length == 0) ? (-1267433356) : (-49259144));
								num = num4 ^ ((int)num3 * -1233851803);
								continue;
							case 10u:
								goto end_IL_00c8_2;
							case 9u:
								ptr5 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + byte_0.Length;
								num = ((int)num3 * -1674796939) ^ 0x1E7DB4DB;
								continue;
							case 8u:
								ptr3++;
								num = 542755379;
								continue;
							case 6u:
								ptr3 = ptr;
								ptr2 = ptr4;
								num = 1107967140;
								continue;
							case 5u:
								goto IL_01fe_2;
							case 4u:
								ptr2++;
								num = (int)(num3 * 1004294757) ^ -170870;
								continue;
							case 3u:
								num = ((ptr3 == ptr5) ? 1485449054 : 1767638763);
								continue;
							case 2u:
								ptr = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + int_0;
								num = 255907048;
								continue;
							case 1u:
								num = (int)((num3 * 1259605401) ^ 0x7EA35E50);
								continue;
							case 0u:
								goto IL_0266_2;
							case 21u:
								array2 = (array = byte_0);
								num = ((array2 == null) ? 1540936243 : 748466412);
								continue;
							case 7u:
								return -1;
							case 13u:
								return (int)(ptr - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
							default:
								return -1;
							case 29u:
								{
									return -1;
								}
								IL_0266_2:
								reference = ref *(byte*)null;
								num = 85297169;
								continue;
							}
							break;
						}
					}
					continue;
					end_IL_00c8_2:
					break;
				}
				goto case 10u;
			case 19u:
				num = ((int)num3 * -88324814) ^ -653895717;
				continue;
			case 18u:
				goto IL_00ed;
			case 17u:
				num6 = ((array4.Length == 0) ? (-1334471696) : (-820751752));
				num = num6 ^ (int)(num3 * 2074434709);
				continue;
			case 16u:
				num = ((int)num3 * -1989358830) ^ -1568129721;
				continue;
			case 15u:
				ptr4 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
				num = ((int)num3 * -991834868) ^ -140580313;
				continue;
			case 14u:
				num = (int)(num3 * 708224773) ^ -1506319928;
				continue;
			case 12u:
				ptr8 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2) + byte_1.Length;
				num = ((int)num3 * -1359956091) ^ 0x52C465E7;
				continue;
			case 11u:
				num4 = ((array.Length == 0) ? (-1267433356) : (-49259144));
				num = num4 ^ ((int)num3 * -1233851803);
				continue;
			case 10u:
				reference2 = ref *(byte*)null;
				num = 1688150114;
				continue;
			case 9u:
				ptr5 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + byte_0.Length;
				num = ((int)num3 * -1674796939) ^ 0x1E7DB4DB;
				continue;
			case 8u:
				ptr3++;
				num = 542755379;
				continue;
			case 6u:
				ptr3 = ptr;
				ptr2 = ptr4;
				num = 1107967140;
				continue;
			case 5u:
				goto IL_01fe_2;
			case 4u:
				ptr2++;
				num = (int)(num3 * 1004294757) ^ -170870;
				continue;
			case 3u:
				goto IL_022a;
			case 2u:
				ptr = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + int_0;
				num = 255907048;
				continue;
			case 1u:
				num = (int)((num3 * 1259605401) ^ 0x7EA35E50);
				continue;
			case 0u:
				reference = ref *(byte*)null;
				num = 85297169;
				continue;
			case 21u:
				goto IL_0308;
			case 7u:
				return -1;
			case 13u:
				return (int)(ptr - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			default:
				return -1;
			case 29u:
				{
					return -1;
				}
				IL_0211:
				num = ((int)num3 * -1053745657) ^ -2084029283;
				continue;
				IL_01fe_2:
				reference2 = ref *(byte*)null;
				goto IL_0211;
			}
			num = ((*ptr3 == *ptr2) ? 2123798621 : 1822946217);
			continue;
			IL_022a:
			num = ((ptr3 == ptr5) ? 1485449054 : 1767638763);
			continue;
			IL_008a:
			num = ((ptr == ptr5) ? 795415700 : 75599937);
			continue;
			IL_00ed:
			array3 = (array4 = byte_1);
			num = ((array3 == null) ? 679878485 : 715334150);
			continue;
			end_IL_026e:
			break;
		}
		goto IL_00be;
		IL_0308:
		array2 = (array = byte_0);
		num = ((array2 == null) ? 1540936243 : 748466412);
		goto IL_026e;
#endif
	}

	internal static void smethod_157(BoundsCheckedBinaryReader class5_0, long long_0)
	{
		class5_0.BaseStream.Position = long_0;
	}

	internal static InvertedFunctionTableEntry32[] smethod_165(InvertedFunctionTable32 class112_0)
	{
		InvertedFunctionTableEntry32[] array = new InvertedFunctionTableEntry32[smethod_277(class112_0)];
		int num4 = default(int);
		IntPtr intptr_ = default(IntPtr);
		int num5 = default(int);
		while (true)
		{
			int num = -832829460;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1428436872)) % 8)
				{
				case 7u:
					num4++;
					num = ((int)num2 * -1107707062) ^ 0x5C46F8E0;
					continue;
				case 6u:
					num = ((num4 < smethod_366(class112_0)) ? (-1232771150) : (-1106083455));
					continue;
				case 5u:
					num = ((int)num2 * -265851072) ^ 0x236E2B96;
					continue;
				case 4u:
					intptr_ = smethod_223(class112_0, 3);
					num = ((int)num2 * -1106552790) ^ 0x45CCD84B;
					continue;
				case 3u:
					num5 = smethod_362(typeof(InvertedFunctionTableEntry32));
					num4 = 0;
					num = ((int)num2 * -878627032) ^ 0x3979DC75;
					continue;
				case 2u:
				{
					int num3 = num4;
					InvertedFunctionTableEntry32 @class = new InvertedFunctionTableEntry32(intptr_.smethod_8(num4 * num5), class112_0.method_2());
					@class.method_7(class112_0.method_6());
					array[num3] = @class;
					num = -2044595641;
					continue;
				}
				case 0u:
					break;
				default:
					return array;
				}
				break;
			}
		}
	}

	internal static byte smethod_166()
	{
		while (true)
		{
			IL_0338:
			byte b = PlatformInfo.random_0.smethod_3();
			if (b >= 64)
			{
				goto IL_029d;
			}
			goto IL_032b;
			IL_032b:
			int num = ((b > 144) ? (-529169422) : (-243871611));
			goto IL_02a2;
			IL_02a2:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -297927026)) % 26)
				{
				case 25u:
					break;
				case 24u:
					goto IL_0030;
				case 22u:
					goto IL_0045;
				case 21u:
					goto IL_0069;
				case 20u:
					goto IL_0083;
				case 19u:
					num = ((b >= 100) ? (-1544354568) : (-73062334)) ^ (int)(num2 * 1290585036);
					continue;
				case 18u:
					goto IL_00c9;
				case 17u:
					goto IL_00e3;
				case 16u:
					goto IL_0100;
				case 14u:
					num = ((b < 240) ? 1433115964 : 2059019520) ^ (int)(num2 * 15575402);
					continue;
				case 13u:
					goto IL_0141;
				case 12u:
					goto IL_015e;
				case 11u:
					goto IL_0178;
				case 10u:
					goto IL_0192;
				case 9u:
					goto IL_01af;
				case 8u:
					goto IL_01cc;
				case 7u:
					goto IL_01e9;
				case 6u:
					goto IL_0203;
				case 5u:
					goto IL_021d;
				case 4u:
					goto IL_022c;
				case 3u:
					goto IL_0243;
				case 2u:
					num = ((b >= 201) ? 1619167028 : 496320830) ^ ((int)num2 * -1258766595);
					continue;
				case 1u:
					goto IL_0283;
				case 0u:
					goto end_IL_02a2;
				case 23u:
					goto IL_032b;
				default:
					return b;
				}
				if (b != 47)
				{
					num = (int)((num2 * 986816431) ^ 0x5658DF32);
					continue;
				}
				goto IL_0338;
				IL_0283:
				if (b > 253)
				{
					num = (int)((num2 * 1605613812) ^ 0x19D8FF0B);
					continue;
				}
				goto IL_0338;
				IL_0083:
				if (b > 204)
				{
					num = (int)(num2 * 1127922578) ^ -1584167716;
					continue;
				}
				goto IL_0338;
				IL_0243:
				if (b != 63)
				{
					num = (int)((num2 * 221074837) ^ 0x25016660);
					continue;
				}
				goto IL_0338;
				IL_0141:
				if (b != 207)
				{
					num = (int)((num2 * 2038696994) ^ 0x25DF0CD1);
					continue;
				}
				goto IL_0338;
				IL_022c:
				if (b > 97)
				{
					num = (int)((num2 * 1654381924) ^ 0x3A35BD21);
					continue;
				}
				goto IL_0338;
				IL_0069:
				if (b != 54)
				{
					num = (int)(num2 * 319112342) ^ -1232242924;
					continue;
				}
				goto IL_0338;
				IL_021d:
				if (b != 38)
				{
					num = -342651954;
					continue;
				}
				goto IL_0338;
				IL_0100:
				if (b != 195)
				{
					num = -1163401004;
					continue;
				}
				goto IL_0338;
				IL_0203:
				if (b != 39)
				{
					num = ((int)num2 * -594363171) ^ 0x784B09E9;
					continue;
				}
				goto IL_0338;
				IL_0030:
				if (b != 206)
				{
					num = -616257465;
					continue;
				}
				goto IL_0338;
				IL_01e9:
				if (b != 62)
				{
					num = (int)(num2 * 2091126558) ^ -1933093699;
					continue;
				}
				goto IL_0338;
				IL_00e3:
				if (b != 214)
				{
					num = ((int)num2 * -1497111896) ^ 0x4088F097;
					continue;
				}
				goto IL_0338;
				IL_01cc:
				if (b > 245)
				{
					num = (int)(num2 * 1605303535) ^ -1388077522;
					continue;
				}
				goto IL_0338;
				IL_0045:
				num = ((b < 248) ? (-2091385545) : (-1306280907));
				continue;
				IL_01af:
				if (b != 215)
				{
					num = (int)(num2 * 671488873) ^ -1810131875;
					continue;
				}
				goto IL_0338;
				IL_00c9:
				if (b > 103)
				{
					num = (int)((num2 * 966276860) ^ 0x77E369CE);
					continue;
				}
				goto IL_0338;
				IL_0192:
				if (b >= 152)
				{
					num = ((int)num2 * -1048181733) ^ 0x3FF5FC91;
					continue;
				}
				goto IL_0338;
				IL_015e:
				if (b != 55)
				{
					num = ((int)num2 * -1691438360) ^ -615056601;
					continue;
				}
				goto IL_0338;
				IL_0178:
				if (b != 46)
				{
					num = (int)(num2 * 137928108) ^ -1990322441;
					continue;
				}
				goto IL_0338;
				continue;
				end_IL_02a2:
				break;
			}
			goto IL_029d;
			IL_029d:
			num = -34259516;
			goto IL_02a2;
		}
	}

	internal static void smethod_168(DeflateDecoder.Class182 class182_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			int num = ((int_1-- > 0) ? 1858818865 : 307071863);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x137533BE)) % 6)
				{
				case 5u:
					class182_0.byte_0[class182_0.int_0++] = class182_0.byte_0[int_0++];
					num = 1234892928;
					continue;
				case 3u:
					int_0 &= 0x7FFF;
					num = (int)(num2 * 482743048) ^ -1603584440;
					continue;
				case 2u:
					num = 1858818865;
					continue;
				case 0u:
					class182_0.int_0 &= 32767;
					num = ((int)num2 * -639422608) ^ -973828345;
					continue;
				default:
					return;
				case 4u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	internal static int smethod_170(DeflateDecoder.Class182 class182_0, DeflateDecoder.Class181 class181_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class182_0.int_1), smethod_401(class181_0));
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 916431551;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6159D9E2)) % 9)
				{
				case 8u:
					num3 += smethod_65(class181_0, class182_0.byte_0, 0, int_0 - num4);
					num = ((int)num2 * -809346629) ^ 0x3FDF1E97;
					continue;
				case 7u:
					num = ((num3 == num4) ? 1567955192 : 456797635) ^ (int)(num2 * 1949665283);
					continue;
				case 6u:
					num4 = 32768 - class182_0.int_0;
					num = ((int_0 <= num4) ? 1661000323 : 1260388343) ^ (int)(num2 * 641618596);
					continue;
				case 5u:
					num3 = smethod_65(class181_0, class182_0.byte_0, class182_0.int_0, num4);
					num = (int)((num2 * 2077472680) ^ 0x5A488C09);
					continue;
				case 3u:
					num3 = smethod_65(class181_0, class182_0.byte_0, class182_0.int_0, int_0);
					num = 2017744650;
					continue;
				case 2u:
					class182_0.int_0 = (class182_0.int_0 + num3) & 0x7FFF;
					class182_0.int_1 += num3;
					num = 1194361907;
					continue;
				case 1u:
					num = (int)((num2 * 698804631) ^ 0x5025E386);
					continue;
				case 0u:
					break;
				default:
					return num3;
				}
				break;
			}
		}
	}

	internal static IntPtr smethod_175(RemoteMemoryAccessor class82_0, long long_0, NativeTypes.Enum34 enum34_0)
	{
		return class82_0.method_15(IntPtr.Zero, long_0, enum34_0);
	}

	internal static bool smethod_176(ResourceDirectory class166_0, int int_0)
	{
		return smethod_282(class166_0, (int)(class166_0.class5_0.BaseStream.Position - class166_0.long_0), int_0);
	}

	internal static byte[] smethod_180()
	{
		return (byte[])smethod_124().GetObject("BeaEnginex86", EmbeddedResources.cultureInfo_0);
	}

	internal static string smethod_182(ThreadPriorityLevel threadPriorityLevel_0)
	{
		string text = threadPriorityLevel_0.ToString();
		int length = text.Length;
		int num = 1;
		while (true)
		{
			int num2 = ((num < length) ? 402775562 : 1565038866);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x70366C81)) % 7)
				{
				case 6u:
					num2 = (int)(num3 * 1744151531) ^ -380092630;
					continue;
				case 4u:
					num++;
					num2 = 1234169544;
					continue;
				case 2u:
					text = text.Insert(num, " ");
					num2 = (int)((num3 * 1651795129) ^ 0x2496029A);
					continue;
				case 1u:
					num2 = (char.IsUpper(text[num]) ? 211449930 : 1995831426);
					continue;
				case 0u:
					num2 = 402775562;
					continue;
				case 5u:
					break;
				default:
					return text;
				}
				break;
			}
		}
	}

	internal static bool smethod_184(IntPtr intptr_0)
	{
		if (VirtualQuery(intptr_0, out var struct47_, (uint)typeof(NativeTypes.Struct47).smethod_7()) == 0)
		{
			goto IL_0028;
		}
		goto IL_008e;
		IL_0028:
		int num = 568756417;
		goto IL_0059;
		IL_0059:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x32069580)) % 6)
			{
			case 3u:
				break;
			case 2u:
				num = (((struct47_.enum34_1 & NativeTypes.Enum34.flag_1) == 0) ? (-683618116) : (-2131935236)) ^ (int)(num2 * 585212972);
				continue;
			case 5u:
				goto IL_008e;
			case 0u:
				return (struct47_.enum34_1 & NativeTypes.Enum34.flag_2) != 0;
			case 1u:
				return false;
			default:
				return true;
			}
			break;
		}
		goto IL_0028;
		IL_008e:
		num = (((struct47_.enum34_1 & NativeTypes.Enum34.flag_5) == 0) ? 1054596244 : 1535139980);
		goto IL_0059;
	}

	internal static void smethod_185(Encoding encoding_0, PeScrambler gclass4_0, string string_0)
	{
		smethod_78(encoding_0.GetBytes(string_0), gclass4_0);
	}

	internal static string smethod_186(IEnumerable<byte> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		IEnumerator<byte> enumerator = ienumerable_0.GetEnumerator();
		try
		{
			byte current = default(byte);
			while (true)
			{
				IL_0089:
				int num = (enumerator.MoveNext() ? 1812458242 : 2013827650);
				while (true)
				{
					switch ((uint)(num ^ 0x78FF5CF1) % 6u)
					{
					case 4u:
						stringBuilder.Append((char)current);
						num = 1256947519;
						continue;
					case 1u:
						current = enumerator.Current;
						num = ((current != 0) ? 123085621 : 369032602);
						continue;
					case 0u:
						num = 1812458242;
						continue;
					default:
						goto end_IL_0054;
					case 2u:
						break;
					case 3u:
						goto end_IL_0054;
					case 5u:
						goto end_IL_0054;
					}
					goto IL_0089;
					continue;
					end_IL_0054:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_00cf:
					int num2 = 441396199;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ 0x78FF5CF1)) % 3)
						{
						case 1u:
							goto IL_009f;
						default:
							goto end_IL_00b2;
						case 2u:
							break;
						case 0u:
							goto end_IL_00b2;
						}
						goto IL_00cf;
						IL_009f:
						enumerator.Dispose();
						num2 = ((int)num3 * -401068430) ^ -690367739;
						continue;
						end_IL_00b2:
						break;
					}
					break;
				}
			}
		}
		return stringBuilder.ToString();
	}

	internal static RemotePlatformStructure.RemoteFieldLayout smethod_187(Type type_0, int int_0)
	{
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			int_0 = smethod_245(type_0) + int_0,
			bool_0 = true
		};
	}

	internal static RemotePlatformStructure.RemoteFieldLayout smethod_194(Type type_0, int int_0)
	{
		return new RemotePlatformStructure.RemoteFieldLayout
		{
			int_0 = smethod_245(type_0) * int_0
		};
	}

	internal static uint smethod_201(uint uint_0, uint uint_1)
	{
		if (uint_1 % uint_0 != 0)
		{
			return uint_1 + uint_0 - uint_1 % uint_0;
		}
		return uint_1;
	}

	internal static void smethod_202(BoundsCheckedBinaryReader class5_0, uint uint_0)
	{
		class5_0.BaseStream.Position = uint_0;
	}

	internal static void smethod_208(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_16() == null)
		{
			goto IL_0071;
		}
		goto IL_01c0;
		IL_0071:
		int num = -88095296;
		goto IL_016e;
		IL_016e:
		int[] source = default(int[]);
		int num3 = default(int);
		List<PeScrambler.Class132> list = default(List<PeScrambler.Class132>);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -348789655)) % 16)
			{
			case 15u:
				num = ((!source.Contains(num3)) ? 887840930 : 256526867) ^ ((int)num2 * -2080552492);
				continue;
			case 14u:
				smethod_56(list, gclass4_0);
				num = ((int)num2 * -1632096495) ^ 0x51A45E1F;
				continue;
			case 13u:
				smethod_420(list, gclass4_0);
				num = ((int)num2 * -15669078) ^ 0x5428566F;
				continue;
			case 12u:
				break;
			case 11u:
				num3 = 0;
				num = ((int)num2 * -888667726) ^ 0x54CCBD8D;
				continue;
			case 8u:
				gclass4_0.method_8(list);
				gclass4_0.method_9(list);
				smethod_93(list, gclass4_0);
				num = ((int)num2 * -1336868126) ^ 0x313E5174;
				continue;
			case 6u:
				num3++;
				num = -968128454;
				continue;
			case 5u:
				goto IL_00c4;
			case 3u:
				goto IL_00fb;
			case 2u:
				num = ((int)num2 * -724102447) ^ 0x31A945B8;
				continue;
			case 1u:
				gclass4_0.method_7(list);
				num = ((int)num2 * -1883079200) ^ -1907430761;
				continue;
			case 0u:
				list = gclass4_0.method_6();
				smethod_38(list, gclass4_0);
				num = (int)(num2 * 1718353375) ^ -842745560;
				continue;
			default:
				return;
			case 10u:
				goto IL_01c0;
			case 4u:
				return;
			case 7u:
				return;
			case 9u:
				return;
			}
			break;
			IL_00fb:
			num = ((num3 < gclass4_0.class154_0.method_6().method_3().imethod_47()) ? (-1923574004) : (-2139438231));
			continue;
			IL_00c4:
			num = ((gclass4_0.class154_0.method_6().method_3().imethod_49()[num3].method_0() == 0) ? (-819676481) : (-1814027146));
		}
		goto IL_0071;
		IL_01c0:
		source = new int[9] { 0, 1, 2, 3, 5, 6, 9, 10, 12 };
		num = -239591854;
		goto IL_016e;
	}

	internal static int smethod_210(DeflateDecoder.Class182 class182_0)
	{
		return class182_0.int_1;
	}

	internal static Win32Exception smethod_213(uint uint_0, RemoteCodeExecutorBase class84_0)
	{
		int num = RtlNtStatusToDosError(uint_0);
		if (num == 317L)
		{
			goto IL_0014;
		}
		goto IL_007a;
		IL_0014:
		int num2 = -488426059;
		goto IL_0051;
		IL_0051:
		Win32Exception ex = default(Win32Exception);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -295361637)) % 6)
			{
			case 3u:
				break;
			case 2u:
				num2 = (ex.Message.StartsWith("Unknown error (0x") ? 351378417 : 1454267042) ^ (int)(num3 * 907173558);
				continue;
			case 5u:
				goto IL_007a;
			default:
				return null;
			case 1u:
				return ex;
			case 4u:
				return null;
			}
			break;
		}
		goto IL_0014;
		IL_007a:
		ex = new Win32Exception(num);
		num2 = -1460079863;
		goto IL_0051;
	}

	private static string PrepareModuleForInjection(string sourcePath, InjectionOptions options, ScramblePreset scramblePreset)
	{
		string workingPath = options.StealthInject
			? CreateUniqueTemporaryPath(".dll")
			: sourcePath;

		if (scramblePreset != ScramblePreset.None)
		{
			if (!options.StealthInject)
			{
				workingPath = GetAvailableScrambledModulePath(sourcePath);
			}

			ScrambleModule(sourcePath, workingPath);
		}
		else if (!string.Equals(sourcePath, workingPath, StringComparison.OrdinalIgnoreCase))
		{
			File.Copy(sourcePath, workingPath);
		}

		return workingPath;
	}

	private static string GetAvailableScrambledModulePath(string sourcePath)
	{
		string extension = Path.GetExtension(sourcePath);
		string basePath = Path.Combine(
			Path.GetDirectoryName(sourcePath),
			Path.GetFileNameWithoutExtension(sourcePath) + "_Scrambled");
		string preferredPath = basePath + extension;

		try
		{
			if (File.Exists(preferredPath))
			{
				File.Delete(preferredPath);
			}
			return preferredPath;
		}
		catch
		{
			for (int suffix = 1; ; suffix++)
			{
				string candidatePath = basePath + "_" + suffix + extension;
				if (!File.Exists(candidatePath))
				{
					return candidatePath;
				}
			}
		}
	}

	internal static IntPtr smethod_223(RemotePlatformStructure class96_0, int int_0)
	{
		return class96_0.method_17().smethod_8(class96_0.int_1[int_0]);
	}

	internal static long smethod_228(ResourceDirectoryNode class138_0)
	{
		return class138_0.long_0;
	}

	internal static int smethod_232(Type type_0)
	{
		if (!PlatformInfo.dictionary_0.TryGetValue(type_0, out var value))
		{
			while (true)
			{
				int num = 408154614;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x3B8222CE)) % 3)
					{
					case 1u:
						PlatformInfo.dictionary_0.Add(type_0, value = smethod_18(type_0));
						num = (int)(num2 * 1532877780) ^ -1647846415;
						continue;
					case 0u:
						break;
					default:
						goto end_IL_004e;
					}
					break;
				}
				continue;
				end_IL_004e:
				break;
			}
		}
		return value;
	}

	internal static bool smethod_235(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_0() != 0)
		{
			goto IL_007a;
		}
		goto IL_0178;
		IL_0178:
		int num = 318609420;
		goto IL_00e4;
		IL_00e4:
		BinaryReader binaryReader = default(BinaryReader);
		long num3 = default(long);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x63AC295A)) % 12)
			{
			case 11u:
				num = ((binaryReader.ReadUInt32() == 72) ? 1230529189 : 1562226598) ^ (int)(num2 * 869954338);
				continue;
			case 9u:
				gclass4_0.class154_0.method_28().Position += 12L;
				num = 1567329674;
				continue;
			case 8u:
				break;
			case 4u:
				num = ((num3 != -1L) ? 2004166253 : 1382313081) ^ ((int)num2 * -1011771136);
				continue;
			case 3u:
				binaryReader = new BinaryReader(gclass4_0.class154_0.method_28());
				num = 1701154372;
				continue;
			case 2u:
				gclass4_0.class154_0.method_28().Position = num3;
				num = (int)(num2 * 671904464) ^ -13871275;
				continue;
			case 5u:
				num3 = smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_0());
				num = 508789538;
				continue;
			case 1u:
				if (gclass4_0.class154_0.method_6().method_3().imethod_49()[14].method_2() != 0)
				{
					goto case 5u;
				}
				goto IL_0178;
			default:
				return (binaryReader.ReadUInt32() & 2) == 2;
			case 6u:
				return true;
			case 7u:
				return true;
			case 10u:
				return true;
			}
			break;
		}
		goto IL_007a;
		IL_007a:
		num = 279137115;
		goto IL_00e4;
	}

	internal static string GetModulePath(MainForm.ModuleRow class21_0)
	{
		return class21_0.Entry.Path;
	}

	internal static int smethod_245(Type type_0)
	{
		if (!type_0.IsSubclassOf(typeof(RemotePlatformStructure)))
		{
			return smethod_232(type_0);
		}
		return smethod_117(type_0);
	}

	internal static void smethod_249(byte[] byte_0, DeflateDecoder.Class183 class183_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		int num8 = default(int);
		int num9 = default(int);
		int num18 = default(int);
		int num11 = default(int);
		int num5 = default(int);
		int num19 = default(int);
		int num7 = default(int);
		int num10 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		int num13 = default(int);
		int num16 = default(int);
		int num15 = default(int);
		int num17 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 1233129909;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x74D7FD5)) % 40)
				{
				case 39u:
					num8 = 0;
					num = ((int)num2 * -2076038288) ^ -828847343;
					continue;
				case 38u:
					num = ((num9 <= 9) ? 554090213 : 1130547571) ^ ((int)num2 * -735214786);
					continue;
				case 37u:
					num18 = num11 & 0x1FF80;
					num11 -= array[num5] << 16 - num5;
					num19 = num11 & 0x1FF80;
					num = 958674269;
					continue;
				case 36u:
					num7 = smethod_322(num11);
					num = ((int)num2 * -1324059382) ^ 0x3EEDEC73;
					continue;
				case 35u:
					num11 = array2[num9];
					num = (int)((num2 * 1257166697) ^ 0x6BE591EA);
					continue;
				case 34u:
					num10 = 1 << (num6 & 0xF);
					num6 = -(num6 >> 4);
					num = ((int)num2 * -1766625782) ^ -902097008;
					continue;
				case 33u:
					num9 = byte_0[num8];
					num = 456192988;
					continue;
				case 32u:
					num3 = num19;
					num = (int)((num2 * 1030075923) ^ 0x1F8A5096);
					continue;
				case 31u:
					array2[num13] = num11;
					num = 456182351;
					continue;
				case 30u:
					num8++;
					num = 444576385;
					continue;
				case 29u:
					num5 = 15;
					num = (int)(num2 * 352772387) ^ -1651882974;
					continue;
				case 28u:
					num = ((num8 < byte_0.Length) ? 914145908 : 787748301);
					continue;
				case 27u:
					array[num16]++;
					num = (int)(num2 * 770528888) ^ -541241703;
					continue;
				case 26u:
					num11 = 0;
					num15 = 512;
					num13 = 1;
					num = (int)(num2 * 624074770) ^ -1231600674;
					continue;
				case 25u:
					num = (int)((num2 * 2017927086) ^ 0x4D047375);
					continue;
				case 24u:
					num17 = 0;
					num = ((int)num2 * -381197267) ^ 0x48FE54CC;
					continue;
				case 23u:
					num = ((num13 <= 15) ? 924849682 : 785816468);
					continue;
				case 22u:
					num = ((num17 >= byte_0.Length) ? 977704335 : 1068004962);
					continue;
				case 21u:
					num7 += 1 << num9;
					num = ((num7 < 512) ? 2047890916 : 1962017446) ^ (int)(num2 * 588769121);
					continue;
				case 20u:
					num = ((num5 >= 10) ? 1858809816 : 491902970);
					continue;
				case 19u:
					num3 += 128;
					num = (int)((num2 * 1392566453) ^ 0x79399E11);
					continue;
				case 18u:
					num11 += array[num13] << 16 - num13;
					num = ((num13 >= 10) ? (-996821616) : (-276741684)) ^ (int)(num2 * 1995000787);
					continue;
				case 17u:
					num = ((num9 == 0) ? (-1352634669) : (-711999330)) ^ (int)(num2 * 290903896);
					continue;
				case 15u:
					num13++;
					num = 846592394;
					continue;
				case 14u:
					num = (int)((num2 * 210889145) ^ 0x2038C326);
					continue;
				case 13u:
					array2[num9] = num11 + (1 << 16 - num9);
					num = 1890180299;
					continue;
				case 12u:
					num17++;
					num = 1989956939;
					continue;
				case 11u:
					num = ((num3 < num18) ? 1323647309 : 1740399215);
					continue;
				case 10u:
					num6 = class183_0.short_0[num7 & 0x1FF];
					num = 1143626695;
					continue;
				case 9u:
					class183_0.short_0 = new short[num15];
					num4 = 512;
					num = (int)(num2 * 1810031871) ^ -1759291441;
					continue;
				case 8u:
					num = ((int)num2 * -145970813) ^ -1780555127;
					continue;
				case 7u:
					num16 = byte_0[num17];
					num = ((num16 > 0) ? 341126454 : 500912881);
					continue;
				case 6u:
					num4 += 1 << num5 - 9;
					num = ((int)num2 * -1281117240) ^ 0x6BC2A926;
					continue;
				case 4u:
					class183_0.short_0[num7] = (short)((num8 << 4) | num9);
					num = 604590992;
					continue;
				case 3u:
				{
					int num12 = array2[num13] & 0x1FF80;
					int num14 = num11 & 0x1FF80;
					num15 += num14 - num12 >> 16 - num13;
					num = ((int)num2 * -1018065792) ^ -1988176990;
					continue;
				}
				case 2u:
					num5--;
					num = (int)(num2 * 1318706681) ^ -672189429;
					continue;
				case 1u:
					class183_0.short_0[num6 | (num7 >> 9)] = (short)((num8 << 4) | num9);
					num7 += 1 << num9;
					num = ((num7 >= num10) ? 535927552 : 1915106084);
					continue;
				case 0u:
					class183_0.short_0[smethod_322(num3)] = (short)((-num4 << 4) | num5);
					num = 102848171;
					continue;
				default:
					return;
				case 5u:
					break;
				case 16u:
					return;
				}
				break;
			}
		}
	}
}
