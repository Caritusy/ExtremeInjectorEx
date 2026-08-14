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

public sealed class Class171
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

	internal static void smethod_0(GClass4 gclass4_0)
	{
		Class157 @class = gclass4_0.class154_0.method_6().method_3().imethod_49()[1];
		long num3 = default(long);
		long position = default(long);
		long num5 = default(long);
		byte c = default(byte);
		uint uint_ = default(uint);
		uint num6 = default(uint);
		while (true)
		{
			int num = 540401048;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7C66F37F)) % 5)
				{
				case 3u:
					num = ((num3 != -1L) ? 419420136 : 59497708) ^ (int)(num2 * 181328586);
					continue;
				case 2u:
					num3 = smethod_135(gclass4_0.class154_0, @class.method_0());
					num = ((int)num2 * -1464551743) ^ 0x4ED6733D;
					continue;
				case 0u:
					break;
				case 1u:
					return;
				default:
				{
					Stream stream = smethod_174(gclass4_0.class154_0);
					try
					{
						BinaryReader binaryReader = new BinaryReader(stream);
						try
						{
							stream.Position = num3;
							while (true)
							{
								int num4 = 870570562;
								while (true)
								{
									switch ((num2 = (uint)(num4 ^ 0x7C66F37F)) % 11)
									{
									case 10u:
										num4 = (int)((num2 * 1525613292) ^ 0xD7FD7);
										continue;
									case 9u:
										position = stream.Position;
										stream.Position = num5;
										num4 = (int)((num2 * 753593317) ^ 0xABDF745);
										continue;
									case 8u:
										gclass4_0.binaryWriter_0.Write((gclass4_0.random_0.Next(2) == 1) ? ((byte)char.ToUpper((char)c)) : ((byte)char.ToLower((char)c)));
										num4 = 1701885455;
										continue;
									case 5u:
									{
										uint num7 = binaryReader.ReadUInt32();
										stream.Position += 8L;
										uint_ = binaryReader.ReadUInt32();
										num6 = binaryReader.ReadUInt32();
										num4 = ((num7 != 0) ? 1718117796 : 226559387);
										continue;
									}
									case 4u:
										num4 = (((c = binaryReader.ReadByte()) == 0) ? 2062131862 : 1480653048);
										continue;
									case 3u:
										gclass4_0.class154_0.method_28().Position = num5;
										num4 = (int)(num2 * 1401116587) ^ -1741766045;
										continue;
									case 2u:
										num4 = ((num6 == 0) ? 1851301904 : 437072204) ^ ((int)num2 * -799618038);
										continue;
									case 1u:
										num5 = smethod_135(gclass4_0.class154_0, uint_);
										num4 = ((num5 == -1L) ? 870570562 : 511459231);
										continue;
									default:
										stream.Position = position;
										goto case 5u;
									case 6u:
										break;
									case 7u:
										return;
									}
									break;
								}
							}
						}
						finally
						{
							if (binaryReader != null)
							{
								while (true)
								{
									IL_029b:
									int num8 = 1873412360;
									while (true)
									{
										switch ((num2 = (uint)(num8 ^ 0x7C66F37F)) % 3)
										{
										case 2u:
											goto IL_0269;
										default:
											goto end_IL_027d;
										case 0u:
											break;
										case 1u:
											goto end_IL_027d;
										}
										goto IL_029b;
										IL_0269:
										((IDisposable)binaryReader).Dispose();
										num8 = (int)(num2 * 216807074) ^ -883956626;
										continue;
										end_IL_027d:
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
								IL_02da:
								int num9 = 1316564494;
								while (true)
								{
									switch ((num2 = (uint)(num9 ^ 0x7C66F37F)) % 3)
									{
									case 1u:
										goto IL_02a8;
									default:
										goto end_IL_02bc;
									case 2u:
										break;
									case 0u:
										goto end_IL_02bc;
									}
									goto IL_02da;
									IL_02a8:
									((IDisposable)stream).Dispose();
									num9 = ((int)num2 * -1486022512) ^ 0x5D1E42AD;
									continue;
									end_IL_02bc:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
			}
		}
	}

	internal static long smethod_1(GClass4 gclass4_0, byte[] byte_0, long long_0)
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

	internal static bool smethod_2(GClass2 gclass2_0)
	{
		if (Class127.bool_0)
		{
			IntPtr intPtr = default(IntPtr);
			bool bool_ = default(bool);
			while (true)
			{
				int num = -1666634709;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1574627672)) % 12)
					{
					case 10u:
						num = ((intPtr == IntPtr.Zero) ? (-1356036650) : (-1425031679)) ^ ((int)num2 * -653878624);
						continue;
					case 9u:
						gclass2_0.method_7(!bool_);
						num = -340052088;
						continue;
					case 8u:
						smethod_27(gclass2_0, intPtr);
						num = (int)((num2 * 226701568) ^ 0x68B98F0B);
						continue;
					case 7u:
						num = (Class127.bool_3 ? 139569797 : 1190481027) ^ ((int)num2 * -1282458244);
						continue;
					case 5u:
						break;
					case 1u:
						intPtr = smethod_250(gclass2_0, Class127.bool_1 ? Class124.Enum32.flag_10 : Class124.Enum32.flag_9, bool_0: false, gclass2_0.method_0());
						num = -1143235234;
						continue;
					case 0u:
						smethod_27(gclass2_0, intPtr);
						num = ((int)num2 * -1301083901) ^ 0x762A19A;
						continue;
					case 4u:
						goto end_IL_00f6;
					case 2u:
						return false;
					case 3u:
						return true;
					case 6u:
						return false;
					default:
						goto end_IL_0138;
					}
					num = (IsWow64Process(intPtr, out bool_) ? (-281541091) : (-1104958980));
					continue;
					end_IL_00f6:
					break;
				}
				continue;
				end_IL_0138:
				break;
			}
		}
		return true;
	}

	internal static Class147 smethod_3(Class154 class154_0, Class5 class5_0)
	{
		Class157 @class = class154_0.method_6().method_3().imethod_49()[6];
		long num3 = default(long);
		while (true)
		{
			int num = 1839152769;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x55FDDBAE)) % 11)
				{
				case 10u:
					num = ((!class5_0.imethod_0(num3 + @class.method_2())) ? 484342345 : 22573945);
					continue;
				case 6u:
					smethod_157(class5_0, num3);
					num = 101535526;
					continue;
				case 5u:
					num = ((@class.method_2() == 0) ? (-381777920) : (-129109227)) ^ ((int)num2 * -1814964685);
					continue;
				case 4u:
					num = ((@class.method_0() == 0) ? (-877033036) : (-1725844192)) ^ ((int)num2 * -2102095317);
					continue;
				case 3u:
					num = (class5_0.imethod_0(num3) ? 313754748 : 1660788475) ^ (int)(num2 * 1967925550);
					continue;
				case 1u:
					num3 = smethod_135(class154_0, @class.method_0());
					num = ((num3 != -1L) ? 909075534 : 1709491387);
					continue;
				case 0u:
					break;
				case 2u:
					return null;
				case 7u:
					return null;
				case 8u:
					return null;
				default:
					return new Class147(class5_0);
				}
				break;
			}
		}
	}

	internal static void smethod_4(Class10 class10_0, IntPtr intptr_0)
	{
		if (Class127.bool_2)
		{
			goto IL_0066;
		}
		goto IL_0128;
		IL_0066:
		int num = -270770127;
		goto IL_00e3;
		IL_00e3:
		Class10.Struct6 struct6_ = default(Class10.Struct6);
		Class10.Struct6 @struct = default(Class10.Struct6);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -653105853)) % 9)
			{
			case 7u:
				struct6_ = @struct;
				num = ((int)num2 * -125969318) ^ -687022563;
				continue;
			case 6u:
				ChangeWindowMessageFilterEx(intptr_0, 563u, Class10.Enum1.const_1, ref struct6_);
				ChangeWindowMessageFilterEx(intptr_0, 74u, Class10.Enum1.const_1, ref struct6_);
				ChangeWindowMessageFilterEx(intptr_0, 73u, Class10.Enum1.const_1, ref struct6_);
				num = ((int)num2 * -672728581) ^ -47488733;
				continue;
			case 5u:
				break;
			case 4u:
				@struct.uint_0 = (uint)Marshal.SizeOf(typeof(Class10.Struct6));
				num = (int)((num2 * 24164508) ^ 0x570FFE91);
				continue;
			case 2u:
				ChangeWindowMessageFilter(563u, Class10.Enum2.const_0);
				ChangeWindowMessageFilter(74u, Class10.Enum2.const_0);
				num = ((int)num2 * -981999770) ^ -936126998;
				continue;
			case 1u:
				@struct = default(Class10.Struct6);
				num = (int)((num2 * 1465128633) ^ 0x40B6BE6D);
				continue;
			case 0u:
				ChangeWindowMessageFilter(73u, Class10.Enum2.const_0);
				num = ((int)num2 * -51443913) ^ 0x7F4FD9E2;
				continue;
			case 8u:
				goto IL_0128;
			default:
				DragAcceptFiles(intptr_0, bool_0: true);
				return;
			}
			break;
		}
		goto IL_0066;
		IL_0128:
		num = (Class127.bool_1 ? (-1605748973) : (-1962184115));
		goto IL_00e3;
	}

	internal static TypeBuilder smethod_5(ModuleBuilder moduleBuilder_0)
	{
		TypeBuilder typeBuilder = moduleBuilder_0.DefineType(smethod_426() + "." + smethod_426(), TypeAttributes.NotPublic);
		ILGenerator iLGenerator = default(ILGenerator);
		int num5 = default(int);
		int num4 = default(int);
		int num7 = default(int);
		int num6 = default(int);
		LocalBuilder local = default(LocalBuilder);
		Type type2 = default(Type);
		int num3 = default(int);
		Type type = default(Type);
		while (true)
		{
			int num = 1806833511;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x65088887)) % 23)
				{
				case 22u:
					iLGenerator.Emit(OpCodes.Ldloc_0);
					num = ((int)num2 * -1862606786) ^ -946109449;
					continue;
				case 21u:
					num5 = Class9.random_0.Next(5);
					num4 = 0;
					num = 2017471772;
					continue;
				case 20u:
					num = ((num7 < num6) ? 2012028774 : 1387516343);
					continue;
				case 19u:
					num7 = 0;
					num = (int)(num2 * 1223541641) ^ -361310432;
					continue;
				case 18u:
					num = ((num4 < num5) ? 1556420600 : 1980581815);
					continue;
				case 17u:
					local = iLGenerator.DeclareLocal(type2);
					num = (int)(num2 * 717000516) ^ -864868273;
					continue;
				case 16u:
					num6 = Class9.random_0.Next(2, 20);
					num = ((int)num2 * -895605863) ^ -729273682;
					continue;
				case 15u:
					num4++;
					num = (int)((num2 * 1581595788) ^ 0x79AA143A);
					continue;
				case 14u:
					iLGenerator.Emit(OpCodes.Ldloca_S, local);
					iLGenerator.Emit(OpCodes.Initobj, type2);
					num = (int)((num2 * 44255745) ^ 0x49C4F87F);
					continue;
				case 13u:
					num = ((num3 < num6) ? 1417344014 : 485776924);
					continue;
				case 11u:
					num = (int)((num2 * 670371144) ^ 0x170F2A66);
					continue;
				case 10u:
					num6 = Class9.random_0.Next(2, 20);
					num3 = 0;
					num = ((int)num2 * -1342059483) ^ -14570024;
					continue;
				case 9u:
					iLGenerator.Emit(OpCodes.Nop);
					num = 1821051676;
					continue;
				case 8u:
					iLGenerator.Emit(OpCodes.Ret);
					num7++;
					num = (int)((num2 * 701901305) ^ 0x69726601);
					continue;
				case 6u:
					type = Class9.type_0[Class9.random_0.Next(Class9.type_0.Length)];
					num = ((type == typeof(void)) ? 115753001 : 634291345);
					continue;
				case 5u:
					type2 = Class9.type_0[Class9.random_0.Next(Class9.type_0.Length)];
					iLGenerator = typeBuilder.DefineMethod(smethod_426(), MethodAttributes.Assembly | MethodAttributes.Static, type2, new Type[0]).GetILGenerator();
					num = 453399476;
					continue;
				case 4u:
					num = ((type2 != typeof(void)) ? (-355871550) : (-566305738)) ^ (int)(num2 * 1384223739);
					continue;
				case 3u:
					typeBuilder.DefineField(smethod_426(), type, FieldAttributes.Assembly | FieldAttributes.Static);
					num = 1521328639;
					continue;
				case 2u:
					num3++;
					num = 1836125873;
					continue;
				case 1u:
					num = (int)(num2 * 1242336675) ^ -927814948;
					continue;
				case 0u:
					num3--;
					num = ((int)num2 * -1652936427) ^ 0x654665B9;
					continue;
				case 12u:
					break;
				default:
					return typeBuilder;
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

	internal static bool smethod_7(Class5 class5_0, uint uint_0, out Class162 class162_0)
	{
		class162_0 = null;
		if (uint_0 < 96)
		{
			goto IL_00c2;
		}
		goto IL_0108;
		IL_00c2:
		int num = 2114613326;
		goto IL_00c7;
		IL_00c7:
		int num3 = default(int);
		long position = default(long);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x496BDC3B)) % 11)
			{
			case 9u:
				num3++;
				num = 449640402;
				continue;
			case 7u:
				break;
			case 6u:
				num = (int)((num2 * 308424389) ^ 0x18DEF21F);
				continue;
			case 5u:
				class162_0.imethod_49()[num3] = new Class157(class5_0);
				num = ((int)num2 * -1013470488) ^ -1684078075;
				continue;
			case 4u:
				class162_0.imethod_49()[num3] = new Class157();
				num = 831849573;
				continue;
			case 3u:
				goto IL_008c;
			case 2u:
				num3 = 0;
				num = (int)((num2 * 1413374443) ^ 0x2D08019A);
				continue;
			case 0u:
				goto end_IL_00c7;
			case 8u:
				goto IL_0108;
			default:
				class5_0.BaseStream.Position = position + uint_0;
				return true;
			case 10u:
				return false;
			}
			num = (((uint)((int)(class5_0.BaseStream.Position - position) + 8) > uint_0) ? 1438402630 : 1553995527);
			continue;
			IL_008c:
			num = ((num3 < class162_0.imethod_49().Length) ? 1762151235 : 716079289);
			continue;
			end_IL_00c7:
			break;
		}
		goto IL_00c2;
		IL_0108:
		position = class5_0.BaseStream.Position;
		Class162 @class = new Class162();
		@class.vmethod_0(class5_0.ReadUInt16());
		@class.imethod_2(class5_0.ReadByte());
		@class.imethod_4(class5_0.ReadByte());
		@class.imethod_6(class5_0.ReadUInt32());
		@class.imethod_8(class5_0.ReadUInt32());
		@class.imethod_10(class5_0.ReadUInt32());
		@class.imethod_12(class5_0.ReadUInt32());
		@class.imethod_14(class5_0.ReadUInt32());
		@class.imethod_16(class5_0.ReadUInt32());
		@class.vmethod_1(class5_0.ReadUInt32());
		@class.vmethod_2(class5_0.ReadUInt32());
		@class.vmethod_3(class5_0.ReadUInt32());
		@class.vmethod_4(class5_0.ReadUInt16());
		@class.vmethod_5(class5_0.ReadUInt16());
		@class.imethod_23(class5_0.ReadUInt16());
		@class.imethod_25(class5_0.ReadUInt16());
		@class.vmethod_6(class5_0.ReadUInt16());
		@class.vmethod_7(class5_0.ReadUInt16());
		@class.vmethod_8(class5_0.ReadUInt32());
		@class.imethod_30(class5_0.ReadUInt32());
		@class.vmethod_9(class5_0.ReadUInt32());
		@class.imethod_33(class5_0.ReadUInt32());
		@class.vmethod_10((Enum42)class5_0.ReadUInt16());
		@class.imethod_36((Enum38)class5_0.ReadUInt16());
		@class.imethod_38(class5_0.ReadUInt32());
		@class.imethod_40(class5_0.ReadUInt32());
		@class.imethod_42(class5_0.ReadUInt32());
		@class.imethod_44(class5_0.ReadUInt32());
		@class.imethod_46(class5_0.ReadUInt32());
		@class.imethod_48(class5_0.ReadUInt32());
		class162_0 = @class;
		num = 1313011299;
		goto IL_00c7;
	}

	internal static byte[] smethod_8(long long_0, Class154 class154_0, long long_1)
	{
		long position = class154_0.method_28().Position;
		class154_0.method_28().Position = long_1;
		MemoryStream memoryStream = new MemoryStream();
		byte[] result = default(byte[]);
		try
		{
			class154_0.method_28().smethod_5(memoryStream, (int)((long_0 == -1L) ? (class154_0.method_28().Length - long_1) : long_0));
			while (true)
			{
				IL_0099:
				int num = 53687269;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x4376A52C)) % 4)
					{
					case 2u:
						result = memoryStream.ToArray();
						num = ((int)num2 * -1607740926) ^ 0x162E187;
						continue;
					case 1u:
						class154_0.method_28().Position = position;
						num = (int)((num2 * 1490051492) ^ 0x178E6F36);
						continue;
					default:
						goto end_IL_0078;
					case 0u:
						break;
					case 3u:
						goto end_IL_0078;
					}
					goto IL_0099;
					continue;
					end_IL_0078:
					break;
				}
				break;
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_00d7:
					int num3 = 872099658;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num3 ^ 0x4376A52C)) % 3)
						{
						case 1u:
							goto IL_00a7;
						default:
							goto end_IL_00ba;
						case 2u:
							break;
						case 0u:
							goto end_IL_00ba;
						}
						goto IL_00d7;
						IL_00a7:
						((IDisposable)memoryStream).Dispose();
						num3 = ((int)num2 * -1955289633) ^ 0x469149F3;
						continue;
						end_IL_00ba:
						break;
					}
					break;
				}
			}
		}
		return result;
	}

	internal static IEnumerable<Class138> smethod_9(Class138 class138_0)
	{
		return new GClass4.Class136(-2)
		{
			class138_2 = class138_0
		};
	}

	internal static void BeginInjection(MainForm mainForm)
	{
		MainForm.ModuleRow[] modules = GetEnabledModuleRows(mainForm);
		if (modules.Length == 0)
		{
			return;
		}

		InjectionOptions options = ApplicationSettings.Current.Options;
		WarningPreferences warnings = ApplicationSettings.Current.Warnings;
		ScramblePreset scramblePreset = options.Scramble.Detect();
		bool warningsChanged = false;

		if (!Class127.bool_11 && options.Method == InjectionMethod.ManualMap && !warnings.ManualMapAcknowledged)
		{
			MessageBox.Show(mainForm, "It appears you are using a version of Windows that has not been properly tested with the manual map injection method. There is a chance that injection may fail or crash so use another injection method if it doesn't work and report the problem to me. If it crashes, you may want to try ticking \"Disable SEH handler validation\" under Injection Method's Advanced settings.", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			warnings.ManualMapAcknowledged = true;
			warningsChanged = true;
		}

		bool usesLdrpLoadDll = options.Method == InjectionMethod.LdrpLoadDll || options.Method == InjectionMethod.LdrpLoadDllStub;
		if (!Class127.bool_11 && usesLdrpLoadDll && !warnings.LdrpLoadDllAcknowledged)
		{
			MessageBox.Show(mainForm, "It appears you are using a version of Windows that has not been properly tested with the LdrpLoadDll injection method. There is a chance that injection may fail or crash so use another injection method if it doesn't work and report the problem to me.", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			warnings.LdrpLoadDllAcknowledged = true;
			warningsChanged = true;
		}

		if (scramblePreset != ScramblePreset.None && !warnings.ScrambleAcknowledged)
		{
			MessageBox.Show(mainForm, "It appears it's the first time you have used the scrambling feature. Sometimes scrambling may cause a DLL to stop working. If this happens, try lowering the scrambling preset (eg. Extreme -> Basic) or turn scrambling off completely.", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			warnings.ScrambleAcknowledged = true;
			warningsChanged = true;
		}

		if (warningsChanged)
		{
			ApplicationSettings.Save();
		}

		mainForm.processRefreshTimer.Stop();
		mainForm.injectButton.Enabled = false;
		mainForm.settingsButton.Enabled = false;
		mainForm.QueueInjectionWorkflow(modules, scramblePreset);
	}

	internal static Icon smethod_11(string string_0, Enum18 enum18_0)
	{
		Class122.Struct36 struct36_ = default(Class122.Struct36);
		Class122.Enum19 enum19_ = (Class122.Enum19)(0x110u | ((enum18_0 == Enum18.const_0) ? 1u : 0u));
		SHGetFileInfo(string_0, 128u, ref struct36_, (uint)Marshal.SizeOf((object)struct36_), enum19_);
		Icon result = default(Icon);
		try
		{
			Icon icon = Icon.FromHandle(struct36_.intptr_0);
			try
			{
				result = (Icon)icon.Clone();
			}
			finally
			{
				if (icon != null)
				{
					while (true)
					{
						IL_0087:
						int num = -848840261;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ -1289780321)) % 3)
							{
							case 1u:
								goto IL_0055;
							default:
								goto end_IL_0069;
							case 2u:
								break;
							case 0u:
								goto end_IL_0069;
							}
							goto IL_0087;
							IL_0055:
							((IDisposable)icon).Dispose();
							num = ((int)num2 * -1541313732) ^ -1876435111;
							continue;
							end_IL_0069:
							break;
						}
						break;
					}
				}
			}
		}
		catch (Exception)
		{
			while (true)
			{
				IL_00c0:
				int num3 = -660738296;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num3 ^ -1289780321)) % 3)
					{
					case 1u:
						goto IL_0092;
					default:
						goto end_IL_00a2;
					case 2u:
						break;
					case 0u:
						goto end_IL_00a2;
					}
					goto IL_00c0;
					IL_0092:
					result = null;
					num3 = (int)(num2 * 942994905) ^ -28502286;
					continue;
					end_IL_00a2:
					break;
				}
				break;
			}
		}
		return result;
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

	internal static IntPtr smethod_13(ref Class124.Struct55 struct55_0)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(typeof(Class124.Struct55).smethod_7() + 16);
		while (true)
		{
			int num = 915114728;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xB7C3BE5)) % 4)
				{
				case 2u:
					Marshal.StructureToPtr((object)struct55_0, intPtr, false);
					num = (int)(num2 * 913671627) ^ -1885447129;
					continue;
				case 1u:
					intPtr = intPtr.smethod_9(-intPtr.ToInt64() & 0xFL);
					num = ((int)num2 * -1282346740) ^ -1872886249;
					continue;
				case 3u:
					break;
				default:
					return intPtr;
				}
				break;
			}
		}
	}

	internal static int smethod_14(Class179.Class182 class182_0)
	{
		return 32768 - class182_0.int_1;
	}

	internal static void smethod_15(Class47 class47_0)
	{
		if (class47_0.bool_0)
		{
			goto IL_01d5;
		}
		goto IL_02d3;
		IL_01d5:
		int num = 1187696634;
		goto IL_026e;
		IL_026e:
		Class53 class53_ = default(Class53);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5049091C)) % 17)
			{
			case 16u:
				smethod_75(class47_0.class53_0, smethod_238(Class49.class63_57, 24L), Class49.class63_61);
				num = (int)((num2 * 1746904381) ^ 0xBDC7F80);
				continue;
			case 15u:
				smethod_418(36, class47_0.class53_0);
				num = ((int)num2 * -1856611688) ^ 0x59B9A022;
				continue;
			case 14u:
				class47_0.class58_1 = smethod_48(class47_0.class53_0);
				num = ((int)num2 * -848056874) ^ -526862878;
				continue;
			case 13u:
				smethod_418(131, class47_0.class53_0);
				smethod_418(4, class47_0.class53_0);
				num = ((int)num2 * -1156983299) ^ 0x7E2755BF;
				continue;
			case 12u:
				smethod_75(class47_0.class53_0, smethod_126(class47_0.class58_1, 0L), Class49.class63_41);
				class53_ = class47_0.class53_0;
				num = (int)((num2 * 966856432) ^ 0x2BC7B1BD);
				continue;
			case 10u:
				smethod_418(5, class47_0.class53_0);
				smethod_418(203, class47_0.class53_0);
				num = (int)(num2 * 1732949850) ^ -698119908;
				continue;
			case 9u:
			{
				Class63 class63_ = Class49.class63_41;
				Class57 class57_ = smethod_374(4294967280u);
				smethod_23(class63_, class57_, class53_);
				smethod_418(106, class47_0.class53_0);
				num = (int)((num2 * 2068701569) ^ 0x5A52C1E8);
				continue;
			}
			case 7u:
				smethod_75(class47_0.class53_0, smethod_238(Class49.class63_57, 16L), Class49.class63_55);
				num = (int)((num2 * 376998474) ^ 0x377C94C7);
				continue;
			case 5u:
				smethod_418(51, class47_0.class53_0);
				smethod_418(232, class47_0.class53_0);
				smethod_439(class47_0.class53_0, 0u);
				num = (int)((num2 * 1448497055) ^ 0x29A0F099);
				continue;
			case 4u:
				break;
			case 3u:
				smethod_82(class47_0.class53_0, Class49.class63_42);
				num = ((int)num2 * -2116699661) ^ -255508387;
				continue;
			case 2u:
				class47_0.class53_0.struct19_0.uint_2 |= 8u;
				num = ((int)num2 * -1050884535) ^ 0x2AA1C5B0;
				continue;
			case 1u:
				smethod_318(class47_0.class53_0, Class49.class63_42, Class49.class63_41);
				num = (int)(num2 * 755218750) ^ -1869089995;
				continue;
			case 0u:
				smethod_75(class47_0.class53_0, smethod_238(Class49.class63_57, 8L), Class49.class63_54);
				num = 1458901024;
				continue;
			case 11u:
				goto IL_02d3;
			case 6u:
				return;
			default:
				smethod_75(class47_0.class53_0, smethod_238(Class49.class63_57, 32L), Class49.class63_62);
				return;
			}
			break;
		}
		goto IL_01d5;
		IL_02d3:
		num = (class47_0.bool_1 ? 1434133484 : 1497108864);
		goto IL_026e;
	}

	internal static Class56.Struct13 smethod_16(Class56 class56_0)
	{
		return Class56.smethod_0<Class56.Struct7, Class56.Struct13>(class56_0.method_0());
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
																								num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
																				num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
																num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
																				num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
																num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
												num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
								num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
																				num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
																num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
												num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
																num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
												num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
								num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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
				num8 = (Class127.bool_0 ? 1037055152 : 471426738);
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

	internal static int smethod_18(Type type_0)
	{
		if ((object)type_0 == typeof(char))
		{
			goto IL_001c;
		}
		goto IL_0050;
		IL_001c:
		int num = 811157221;
		goto IL_0021;
		IL_0021:
		switch ((uint)(num ^ 0x146F070) % 5u)
		{
		case 4u:
			break;
		case 3u:
			goto IL_0050;
		default:
			return Marshal.SizeOf(type_0);
		case 1u:
			return 2;
		case 2u:
			return Marshal.SizeOf(Enum.GetUnderlyingType(type_0));
		}
		goto IL_001c;
		IL_0050:
		num = (typeof(Enum).IsAssignableFrom(type_0) ? 81634190 : 1723409053);
		goto IL_0021;
	}

	[DllImport("ntdll.dll")]
	internal static extern uint RtlDosApplyFileIsolationRedirection_Ustr(uint uint_0, ref Class124.Struct43 struct43_0, ref Class124.Struct43 struct43_1, ref Class124.Struct43 struct43_2, ref Class124.Struct43 struct43_3, ref IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, UIntPtr uintptr_1);

	internal static bool smethod_19(Class154 class154_0)
	{
		return class154_0.method_6().method_3().imethod_0() == 267;
	}

	internal static void smethod_20(Class53 class53_0)
	{
		if (!class53_0.method_0())
		{
			goto IL_0008;
		}
		goto IL_005a;
		IL_0008:
		int num = -505350396;
		goto IL_0035;
		IL_0035:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1771032293)) % 5)
			{
			case 4u:
				break;
			case 2u:
				num = (Class49.bool_0 ? 499761726 : 158839544) ^ (int)(num2 * 634876672);
				continue;
			default:
				return;
			case 3u:
				goto IL_005a;
			case 1u:
				throw new InvalidOperationException("This instruction is only available in x64 mode.");
			case 0u:
				return;
			}
			break;
		}
		goto IL_0008;
		IL_005a:
		smethod_31(class53_0, Enum7.const_466);
		num = -91744275;
		goto IL_0035;
	}

	internal static List<Class79> smethod_21()
	{
		List<Class79> list = new List<Class79>();
		IntPtr intPtr3 = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		int num5 = default(int);
		uint num3 = default(uint);
		IntPtr intPtr = default(IntPtr);
		int num4 = default(int);
		Class124.Struct39 struct39_ = default(Class124.Struct39);
		Class79 @class = default(Class79);
		Class124.Struct40 item = default(Class124.Struct40);
		while (true)
		{
			int num = -2128162707;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1762260554)) % 19)
				{
				case 18u:
					intPtr3 = intPtr2.smethod_8(typeof(Class124.Struct39).smethod_7());
					num5 = 0;
					num = (int)(num2 * 171570624) ^ -222443169;
					continue;
				case 17u:
				{
					num = (((num3 = NtQuerySystemInformation(Class124.Enum24.const_5, intPtr, num4, out var _)) != 3221225476u) ? (-1873691861) : (-850434513));
					continue;
				}
				case 16u:
					Marshal.FreeHGlobal(intPtr);
					num4 += 65536;
					intPtr = Marshal.AllocHGlobal(num4);
					num = -271065583;
					continue;
				case 15u:
					num = ((num5 >= struct39_.uint_1) ? (-1557223032) : (-1744986724));
					continue;
				case 14u:
					num = ((num3 == 0) ? 1316447535 : 2140085630) ^ ((int)num2 * -212546510);
					continue;
				case 13u:
					@class.method_2().Add(item);
					intPtr3 = intPtr3.smethod_8(typeof(Class124.Struct40).smethod_7());
					num5++;
					num = (int)(num2 * 522738449) ^ -453839450;
					continue;
				case 11u:
					item = (Class124.Struct40)Marshal.PtrToStructure(intPtr3, typeof(Class124.Struct40));
					num = -330870858;
					continue;
				case 10u:
					num4 = 65536;
					intPtr = Marshal.AllocHGlobal(65536);
					num = ((int)num2 * -739706403) ^ 0xCE87095;
					continue;
				case 9u:
					num = ((int)num2 * -2029230962) ^ -609030535;
					continue;
				case 8u:
					@class.method_1(struct39_);
					list.Add(@class);
					num = ((int)num2 * -1306954970) ^ -1971811687;
					continue;
				case 7u:
					num = (int)((num2 * 2117714006) ^ 0x42A44F60);
					continue;
				case 6u:
					intPtr2 = intPtr2.smethod_9(struct39_.uint_0);
					num = (int)(num2 * 1506578629) ^ -612614115;
					continue;
				case 5u:
					num = ((struct39_.uint_0 != 0) ? 2135236729 : 2051204727) ^ ((int)num2 * -1055630049);
					continue;
				case 4u:
					@class = new Class79();
					struct39_ = (Class124.Struct39)Marshal.PtrToStructure(intPtr2, typeof(Class124.Struct39));
					num = -1254018951;
					continue;
				case 1u:
					intPtr2 = intPtr;
					num = -124316425;
					continue;
				case 0u:
					num = (int)((num2 * 935786555) ^ 0x2258F7B4);
					continue;
				case 12u:
					break;
				default:
					Marshal.FreeHGlobal(intPtr);
					return list;
				case 3u:
					return list;
				}
				break;
			}
		}
	}

	internal static void smethod_22(ModuleOptionsForm form0_0)
	{
		form0_0.groupBox_0 = new GroupBox();
		while (true)
		{
			int num = -438807568;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1137245213)) % 72)
				{
				case 71u:
					form0_0.groupBox_0.TabStop = false;
					form0_0.groupBox_0.Text = "Export Options";
					num = ((int)num2 * -10012300) ^ -993370950;
					continue;
				case 70u:
					form0_0.comboBox_1 = new ComboBox();
					num = (int)(num2 * 1576235532) ^ -94106030;
					continue;
				case 69u:
					form0_0.label_0.Size = new Size(137, 13);
					form0_0.label_0.TabIndex = 0;
					num = ((int)num2 * -616780528) ^ -1323735521;
					continue;
				case 68u:
					form0_0.label_0 = new System.Windows.Forms.Label();
					form0_0.groupBox_0.SuspendLayout();
					num = (int)((num2 * 684650846) ^ 0x4DEAE30);
					continue;
				case 67u:
					form0_0.button_0 = new Button();
					form0_0.textBox_0 = new TextBox();
					form0_0.comboBox_2 = new ComboBox();
					form0_0.dataGridView_0 = new DataGridView();
					form0_0.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
					form0_0.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
					num = ((int)num2 * -1532101053) ^ -222103568;
					continue;
				case 66u:
					form0_0.groupBox_0.Location = new Point(12, 12);
					form0_0.groupBox_0.Name = "exportGroupBox";
					num = ((int)num2 * -1427684341) ^ -1874370773;
					continue;
				case 65u:
					form0_0.dataGridView_0.Name = "paramDataGridView";
					form0_0.dataGridView_0.ReadOnly = true;
					num = (int)(num2 * 871137329) ^ -332823018;
					continue;
				case 64u:
					form0_0.comboBox_1.SelectedIndexChanged += form0_0.method_6;
					form0_0.label_1.AutoSize = true;
					num = (int)((num2 * 1515966208) ^ 0x4B59C109);
					continue;
				case 63u:
					form0_0.dataGridViewTextBoxColumn_1.ReadOnly = true;
					form0_0.dataGridViewTextBoxColumn_1.Width = 55;
					num = (int)((num2 * 1801586444) ^ 0x12E97ADD);
					continue;
				case 62u:
					form0_0.comboBox_0.SelectedIndexChanged += form0_0.method_5;
					form0_0.label_0.AutoSize = true;
					form0_0.label_0.Location = new Point(7, 21);
					form0_0.label_0.Name = "exportFunctionLabel";
					num = (int)((num2 * 2061103370) ^ 0x1468706A);
					continue;
				case 61u:
					form0_0.button_0.Location = new Point(188, 227);
					num = (int)(num2 * 783651630) ^ -1275901385;
					continue;
				case 60u:
					form0_0.dataGridView_0.AllowUserToResizeColumns = false;
					form0_0.dataGridView_0.AllowUserToResizeRows = false;
					form0_0.dataGridView_0.BackgroundColor = Color.White;
					num = ((int)num2 * -2047378690) ^ 0x7191F9D1;
					continue;
				case 59u:
					form0_0.button_0.Size = new Size(51, 23);
					form0_0.button_0.TabIndex = 8;
					form0_0.button_0.Text = "Add";
					form0_0.button_0.UseVisualStyleBackColor = true;
					form0_0.button_0.Click += form0_0.method_7;
					num = ((int)num2 * -886628270) ^ 0x2441D5AE;
					continue;
				case 58u:
					form0_0.comboBox_2.Name = "paramTypeComboBox";
					form0_0.comboBox_2.Size = new Size(76, 21);
					num = ((int)num2 * -974930357) ^ 0x18ADF3B;
					continue;
				case 57u:
					form0_0.groupBox_0.Controls.Add(form0_0.button_0);
					num = ((int)num2 * -740489005) ^ 0x68C54E8E;
					continue;
				case 56u:
					form0_0.comboBox_1.TabIndex = 3;
					num = (int)((num2 * 421662214) ^ 0x23BBAEE3);
					continue;
				case 55u:
					form0_0.label_2 = new System.Windows.Forms.Label();
					num = (int)((num2 * 1831248463) ^ 0x3690F2E4);
					continue;
				case 54u:
					form0_0.comboBox_2.TabIndex = 6;
					form0_0.dataGridView_0.AllowUserToAddRows = false;
					num = ((int)num2 * -1495297976) ^ -1548197505;
					continue;
				case 53u:
					form0_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
					num = ((int)num2 * -1165939021) ^ 0x3A369996;
					continue;
				case 52u:
					form0_0.StartPosition = FormStartPosition.CenterParent;
					form0_0.Text = "Advanced Module Options";
					form0_0.Load += form0_0.method_4;
					num = (int)(num2 * 1908332636) ^ -730069252;
					continue;
				case 51u:
					form0_0.comboBox_0 = new ComboBox();
					num = (int)(num2 * 1420889978) ^ -1053864799;
					continue;
				case 50u:
					form0_0.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
					num = (int)(num2 * 19098558) ^ -115233384;
					continue;
				case 49u:
					form0_0.dataGridView_0.RowsAdded += form0_0.method_8;
					num = ((int)num2 * -1855281124) ^ 0x160E02F6;
					continue;
				case 48u:
					form0_0.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
					num = (int)((num2 * 1720243663) ^ 0x3A84E22E);
					continue;
				case 46u:
					form0_0.groupBox_0.Controls.Add(form0_0.textBox_0);
					form0_0.groupBox_0.Controls.Add(form0_0.comboBox_2);
					form0_0.groupBox_0.Controls.Add(form0_0.dataGridView_0);
					form0_0.groupBox_0.Controls.Add(form0_0.label_2);
					form0_0.groupBox_0.Controls.Add(form0_0.comboBox_1);
					num = ((int)num2 * -2035460303) ^ 0x364BA8C2;
					continue;
				case 45u:
					form0_0.label_2.Location = new Point(7, 108);
					form0_0.label_2.Name = "parametersLabel";
					form0_0.label_2.Size = new Size(126, 13);
					num = ((int)num2 * -481480834) ^ -1339679223;
					continue;
				case 44u:
					form0_0.dataGridView_0.RowHeadersVisible = false;
					form0_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					num = ((int)num2 * -654255515) ^ 0x51E646A4;
					continue;
				case 43u:
					form0_0.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
					form0_0.comboBox_1.FormattingEnabled = true;
					num = ((int)num2 * -1290899922) ^ -1601301643;
					continue;
				case 42u:
					form0_0.comboBox_2.Location = new Point(10, 229);
					num = ((int)num2 * -95386088) ^ -1434935943;
					continue;
				case 41u:
					form0_0.label_1.Size = new Size(109, 13);
					num = (int)((num2 * 1820041713) ^ 0x110050A9);
					continue;
				case 40u:
					form0_0.SuspendLayout();
					num = ((int)num2 * -495111633) ^ -1458954470;
					continue;
				case 39u:
					form0_0.dataGridViewTextBoxColumn_0.HeaderText = "";
					form0_0.dataGridViewTextBoxColumn_0.Name = "NumberColumn";
					num = ((int)num2 * -1381964607) ^ -850974727;
					continue;
				case 38u:
					form0_0.groupBox_0.Size = new Size(246, 256);
					num = (int)((num2 * 660957898) ^ 0x6730FEF3);
					continue;
				case 37u:
					form0_0.dataGridViewTextBoxColumn_1.HeaderText = "Type";
					form0_0.dataGridViewTextBoxColumn_1.Name = "TypeColumn";
					num = ((int)num2 * -2102444401) ^ 0x3F917287;
					continue;
				case 36u:
					form0_0.comboBox_1.Location = new Point(10, 80);
					num = ((int)num2 * -1827315752) ^ -1583955851;
					continue;
				case 35u:
					form0_0.label_1.TabIndex = 2;
					num = ((int)num2 * -1606469813) ^ 0x45AA8EAD;
					continue;
				case 34u:
					form0_0.dataGridViewTextBoxColumn_0.Width = 19;
					num = (int)(num2 * 56315837) ^ -1122082855;
					continue;
				case 33u:
					form0_0.label_1 = new System.Windows.Forms.Label();
					num = ((int)num2 * -327545496) ^ -662733664;
					continue;
				case 32u:
					form0_0.dataGridView_0.TabIndex = 5;
					num = ((int)num2 * -923596769) ^ -569183374;
					continue;
				case 31u:
					form0_0.label_1.Text = "Calling Convention:";
					form0_0.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
					num = ((int)num2 * -1929047089) ^ -494413140;
					continue;
				case 30u:
					form0_0.comboBox_0.FormattingEnabled = true;
					form0_0.comboBox_0.Location = new Point(10, 37);
					num = ((int)num2 * -287199415) ^ -562303043;
					continue;
				case 29u:
					form0_0.AutoScaleMode = AutoScaleMode.Font;
					num = (int)(num2 * 789205610) ^ -1249280313;
					continue;
				case 28u:
					form0_0.label_2.TabIndex = 4;
					num = ((int)num2 * -1885998355) ^ -325901201;
					continue;
				case 27u:
					((ISupportInitialize)form0_0.dataGridView_0).BeginInit();
					num = ((int)num2 * -1025451239) ^ 0x225B7A90;
					continue;
				case 26u:
					form0_0.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					form0_0.dataGridView_0.Columns.AddRange(form0_0.dataGridViewTextBoxColumn_0, form0_0.dataGridViewTextBoxColumn_1, form0_0.dataGridViewTextBoxColumn_2);
					num = ((int)num2 * -934688223) ^ -2142949159;
					continue;
				case 25u:
					form0_0.dataGridView_0.RowsRemoved += form0_0.method_9;
					num = ((int)num2 * -922479897) ^ 0x4A206665;
					continue;
				case 23u:
					form0_0.groupBox_0.Controls.Add(form0_0.label_1);
					form0_0.groupBox_0.Controls.Add(form0_0.comboBox_0);
					form0_0.groupBox_0.Controls.Add(form0_0.label_0);
					num = ((int)num2 * -2044187082) ^ -191276069;
					continue;
				case 22u:
					form0_0.ClientSize = new Size(270, 280);
					form0_0.Controls.Add(form0_0.groupBox_0);
					form0_0.Font = new Font("Segoe UI", 8.25f);
					form0_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
					num = ((int)num2 * -1144520454) ^ -56154578;
					continue;
				case 21u:
					form0_0.dataGridView_0.MultiSelect = false;
					num = ((int)num2 * -1065705389) ^ -1949515731;
					continue;
				case 20u:
					form0_0.groupBox_0.TabIndex = 0;
					num = (int)(num2 * 113903180) ^ -996029444;
					continue;
				case 19u:
					((ISupportInitialize)form0_0.dataGridView_0).EndInit();
					form0_0.ResumeLayout(performLayout: false);
					num = (int)(num2 * 911824908) ^ -378471041;
					continue;
				case 18u:
					form0_0.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = ((int)num2 * -1767805509) ^ -1784917390;
					continue;
				case 17u:
					form0_0.textBox_0.TabIndex = 7;
					form0_0.comboBox_2.DropDownStyle = ComboBoxStyle.DropDownList;
					form0_0.comboBox_2.FormattingEnabled = true;
					num = (int)((num2 * 2061221051) ^ 0x3C51857A);
					continue;
				case 16u:
					form0_0.label_2.Text = "Parameters/Arguments:";
					num = ((int)num2 * -1847463114) ^ 0x345735A0;
					continue;
				case 15u:
					form0_0.groupBox_0.ResumeLayout(performLayout: false);
					num = (int)((num2 * 5716963) ^ 0x55BEC71B);
					continue;
				case 14u:
					form0_0.comboBox_1.Size = new Size(229, 21);
					num = (int)((num2 * 1764151489) ^ 0x67A3A4BD);
					continue;
				case 13u:
					form0_0.groupBox_0.PerformLayout();
					num = ((int)num2 * -1092899620) ^ -925748500;
					continue;
				case 12u:
					form0_0.label_2.AutoSize = true;
					num = (int)((num2 * 247398853) ^ 0x4183A762);
					continue;
				case 11u:
					form0_0.textBox_0.Location = new Point(92, 228);
					form0_0.textBox_0.Name = "argValueTextBox";
					form0_0.textBox_0.Size = new Size(90, 22);
					num = ((int)num2 * -1243478033) ^ -1810365769;
					continue;
				case 10u:
					form0_0.button_0.Name = "addButton";
					num = ((int)num2 * -1032839304) ^ 0x7E085CD0;
					continue;
				case 9u:
					form0_0.MaximizeBox = false;
					form0_0.MinimizeBox = false;
					form0_0.Name = "AdvancedModuleOptionsForm";
					num = (int)(num2 * 2083888429) ^ -1894112310;
					continue;
				case 8u:
					form0_0.dataGridView_0.Location = new Point(10, 124);
					num = (int)((num2 * 1791822145) ^ 0x1567FB5E);
					continue;
				case 7u:
					form0_0.dataGridViewTextBoxColumn_2.HeaderText = "Value";
					form0_0.dataGridViewTextBoxColumn_2.Name = "ValueColumn";
					form0_0.dataGridViewTextBoxColumn_2.ReadOnly = true;
					num = ((int)num2 * -1254743129) ^ 0x17AE915E;
					continue;
				case 6u:
					form0_0.comboBox_1.Name = "callingConvComboBox";
					num = (int)(num2 * 10036335) ^ -1293850617;
					continue;
				case 5u:
					form0_0.AutoScaleDimensions = new SizeF(6f, 13f);
					num = (int)(num2 * 1351954849) ^ -405506269;
					continue;
				case 4u:
					form0_0.label_0.Text = "Export Function/Routine:";
					num = ((int)num2 * -1100384208) ^ 0x2930EEC6;
					continue;
				case 3u:
					form0_0.dataGridView_0.Size = new Size(229, 99);
					num = ((int)num2 * -544058712) ^ 0x248BE613;
					continue;
				case 2u:
					form0_0.label_1.Location = new Point(7, 64);
					form0_0.label_1.Name = "callingConventionLabel";
					num = ((int)num2 * -519109860) ^ -245499422;
					continue;
				case 1u:
					form0_0.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
					num = ((int)num2 * -1593684966) ^ -1294137474;
					continue;
				case 0u:
					form0_0.comboBox_0.Name = "exportFunctionComboBox";
					form0_0.comboBox_0.Size = new Size(229, 21);
					form0_0.comboBox_0.TabIndex = 1;
					num = ((int)num2 * -661769907) ^ -676956827;
					continue;
				default:
					return;
				case 47u:
					break;
				case 24u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_23(Class63 class63_0, Class57 class57_0, Class53 class53_0)
	{
		smethod_137(class53_0, Enum7.const_10, class63_0, class57_0);
	}

	internal static Class148 smethod_24(Class154 class154_0, Class5 class5_0)
	{
		Class157 @class = class154_0.method_6().method_3().imethod_49()[1];
		if (@class.method_0() != 0)
		{
			long num3 = default(long);
			while (true)
			{
				int num = 1809806289;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7573263F)) % 9)
					{
					case 8u:
						break;
					case 4u:
						goto IL_0055;
					case 3u:
						num = ((@class.method_2() == 0) ? (-631331484) : (-1538800215)) ^ (int)(num2 * 1825944899);
						continue;
					case 2u:
						num = ((!class5_0.imethod_0(num3)) ? (-1860934608) : (-681132653)) ^ ((int)num2 * -2076873983);
						continue;
					case 0u:
						goto end_IL_00d0;
					case 1u:
						return null;
					case 5u:
						return null;
					default:
						smethod_157(class5_0, num3);
						return new Class148(class5_0, class154_0);
					case 6u:
						goto end_IL_0106;
					}
					num3 = smethod_135(class154_0, @class.method_0());
					num = ((num3 == -1L) ? 717800216 : 1609419031);
					continue;
					IL_0055:
					num = ((!class5_0.imethod_0(num3 + @class.method_2())) ? 1505719495 : 603287673);
					continue;
					end_IL_00d0:
					break;
				}
				continue;
				end_IL_0106:
				break;
			}
		}
		return null;
	}

	internal static void smethod_25(ProcessSelectorForm form5_0)
	{
		form5_0.dataGridView_0.Rows.Clear();
		GClass2[] array = smethod_155();
		int num = 0;
		bool flag = default(bool);
		GClass2 gClass = default(GClass2);
		Icon icon = default(Icon);
		while (true)
		{
			int num2 = ((num < array.Length) ? (-1115168763) : (-1756142350));
			while (true)
			{
				uint num3;
				Bitmap bitmap;
				Bitmap bitmap2;
				int index;
				switch ((num3 = (uint)(num2 ^ -1595487646)) % 9)
				{
				case 8u:
					form5_0.button_2.Enabled = flag;
					num2 = (int)(num3 * 563866476) ^ -737744115;
					continue;
				case 7u:
					gClass = array[num];
					icon = smethod_11(gClass.method_4(), Enum18.const_1);
					if (icon != null)
					{
						num2 = -729349090;
						continue;
					}
					bitmap = new Bitmap(22, 22);
					goto IL_0075;
				case 6u:
					bitmap = smethod_100(icon);
					goto IL_0075;
				case 4u:
					num2 = -1115168763;
					continue;
				case 2u:
					flag = form5_0.dataGridView_0.Rows.Count > 0;
					num2 = ((int)num3 * -1617798344) ^ 0x5D5CFF6C;
					continue;
				case 1u:
					form5_0.dataGridView_0.Rows[0].Selected = flag;
					num2 = (int)(num3 * 887968065) ^ -1457326172;
					continue;
				case 0u:
					num++;
					num2 = (int)(num3 * 1235007747) ^ -1014861754;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
					return;
					IL_0075:
					bitmap2 = bitmap;
					index = form5_0.dataGridView_0.Rows.Add(bitmap2, string.Format("{0:X8}-{1}", gClass.method_0(), gClass.method_2()));
					form5_0.dataGridView_0.Rows[index].Tag = gClass;
					num2 = -435977795;
					continue;
				}
				break;
			}
		}
	}

	internal static bool smethod_26(Class89 class89_0, Class89.Class172 class172_0)
	{
		byte[] array = Class89.smethod_7(class172_0.method_0());
		Class53 @class = default(Class53);
		Class47 class2 = default(Class47);
		Class58 class58_ = default(Class58);
		GClass1 gClass = default(GClass1);
		IntPtr intPtr2 = default(IntPtr);
		Class124.Struct52 gparam_2 = default(Class124.Struct52);
		IntPtr intPtr = default(IntPtr);
		Class124.Struct51 gparam_ = default(Class124.Struct51);
		string tempFileName = default(string);
		while (true)
		{
			int num = -1258531032;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1443353583)) % 27)
				{
				case 26u:
					@class = new Class53();
					num = -1122508537;
					continue;
				case 25u:
					num = (smethod_427(class89_0.method_19()) ? 848312522 : 1159463344) ^ (int)(num2 * 954473858);
					continue;
				case 24u:
					class2 = new Class47(@class, class89_0.method_19());
					class58_ = smethod_48(@class);
					smethod_15(class2);
					num = ((int)num2 * -63947719) ^ 0x53D70BB2;
					continue;
				case 23u:
					class2.method_4<IntPtr>();
					num = (int)((num2 * 2125379434) ^ 0x1A63D503);
					continue;
				case 22u:
					num = ((gClass != null) ? (-999920717) : (-2119019942)) ^ ((int)num2 * -1226992556);
					continue;
				case 20u:
					intPtr2 = smethod_225(gClass, "CreateActCtxW", bool_0: false);
					num = -36187558;
					continue;
				case 19u:
					gparam_2.int_0 = typeof(Class124.Struct52).smethod_7();
					gparam_2.intptr_0 = intPtr.smethod_8(smethod_252(@class));
					num = (int)((num2 * 1468163334) ^ 0x27A8E10E);
					continue;
				case 18u:
					num = ((int)num2 * -374693124) ^ -2130770767;
					continue;
				case 14u:
					class172_0.method_13(class89_0.method_22<IntPtr>(class2, intPtr, bool_2: true));
					num = -1773771938;
					continue;
				case 12u:
					gClass = smethod_42(class89_0.method_19())["kernel32.dll"];
					num = -1373156490;
					continue;
				case 11u:
					intPtr = smethod_175(class89_0, 4096L, Class124.Enum34.flag_2);
					num = ((!(intPtr == IntPtr.Zero)) ? 1116662100 : 180805032) ^ ((int)num2 * -1388759173);
					continue;
				case 10u:
					num = ((intPtr2 == IntPtr.Zero) ? 980196084 : 1632087816) ^ (int)(num2 * 66576407);
					continue;
				case 9u:
					smethod_54(class2, new Class57(intPtr2), CallingConvention.StdCall, new object[1] { smethod_84(class2, class58_) });
					num = ((int)num2 * -718224445) ^ 0x3B41212;
					continue;
				case 8u:
					@class.method_2(gparam_);
					num = ((int)num2 * -2109154805) ^ -1670989238;
					continue;
				case 7u:
					tempFileName = Path.GetTempFileName();
					File.WriteAllBytes(tempFileName, array);
					num = -709951988;
					continue;
				case 6u:
					smethod_320(@class, Encoding.Unicode.GetBytes(tempFileName + "\0"));
					smethod_227(class2);
					smethod_36(@class, class58_);
					@class.method_2(gparam_2);
					num = (int)((num2 * 1421188708) ^ 0x330C83D9);
					continue;
				case 5u:
					smethod_226(class2, -1);
					smethod_227(class2);
					num = (int)(num2 * 198860040) ^ -223470;
					continue;
				case 4u:
					smethod_227(class2);
					smethod_36(@class, class58_);
					num = (int)(num2 * 2071285507) ^ -196341934;
					continue;
				case 3u:
					num = ((array != null) ? (-798451944) : (-122760755)) ^ ((int)num2 * -2136322131);
					continue;
				case 1u:
					gparam_2 = default(Class124.Struct52);
					num = -1437511661;
					continue;
				case 0u:
					gparam_ = new Class124.Struct51
					{
						int_0 = typeof(Class124.Struct51).smethod_7(),
						uint_1 = (uint)((int)intPtr + smethod_252(@class))
					};
					smethod_320(@class, Encoding.Unicode.GetBytes(tempFileName + "\0"));
					num = ((int)num2 * -1584942624) ^ -1616480940;
					continue;
				case 21u:
					break;
				case 2u:
					return true;
				case 13u:
					File.Delete(tempFileName);
					return smethod_128(class89_0, new AccessViolationException("Unable to allocate memory for activation context stub."));
				default:
					return true;
				case 16u:
					return true;
				case 17u:
					return smethod_128(class89_0, new MissingMethodException("Unable to find CreateActCtxW inside kernel32.dll."));
				}
				break;
			}
		}
	}

	internal static bool smethod_27(GClass2 gclass2_0, IntPtr intptr_0)
	{
		if (gclass2_0.method_10() != intptr_0)
		{
			return CloseHandle(intptr_0);
		}
		return true;
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

	internal static void smethod_29(DependencyInstallerForm form3_0, string string_0, string string_1, string string_2)
	{
		form3_0.string_0 = string_0;
		form3_0.string_1 = string_1;
		form3_0.string_2 = string_2;
		while (true)
		{
			int num = -1081599329;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1141489570)) % 3)
				{
				case 2u:
					goto IL_0017;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0017:
				form3_0.bool_0 = true;
				num = ((int)num2 * -312124660) ^ 0x1AC67D05;
			}
		}
	}

	internal static IntPtr[] smethod_30(GClass2 gclass2_0, bool bool_0)
	{
		if (bool_0)
		{
			goto IL_0051;
		}
		goto IL_0227;
		IL_0051:
		int num = 1069849805;
		goto IL_01c5;
		IL_01c5:
		IntPtr[] array = default(IntPtr[]);
		uint uint_ = default(uint);
		IntPtr intPtr = default(IntPtr);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x4B446BDF)) % 20)
			{
			case 19u:
				break;
			case 17u:
				array = new IntPtr[(int)(uint_ / IntPtr.Size)];
				num = 980320595;
				continue;
			case 16u:
				goto end_IL_01c5;
			case 15u:
				goto IL_005b;
			case 14u:
				num = (Class127.bool_0 ? (-524732546) : (-1696607906)) ^ (int)(num2 * 501578739);
				continue;
			case 12u:
				EnumProcessModules(intPtr, array, uint_, out uint_);
				num = ((int)num2 * -1901861338) ^ -445982927;
				continue;
			case 9u:
				num = (Class127.bool_1 ? (-578650930) : (-780818862)) ^ ((int)num2 * -705867474);
				continue;
			case 8u:
				num = (int)((num2 * 551291766) ^ 0x77D41DD9);
				continue;
			case 6u:
				num = ((intPtr == IntPtr.Zero) ? 345606480 : 2083207736) ^ (int)(num2 * 1138004351);
				continue;
			case 4u:
				EnumProcessModulesEx(intPtr, array, uint_, out uint_, (!bool_0) ? 1u : 2u);
				num = 621457091;
				continue;
			case 3u:
				num = (Class127.bool_0 ? (-1662259923) : (-1046425109)) ^ ((int)num2 * -990717186);
				continue;
			case 2u:
				array = new IntPtr[(int)(uint_ / IntPtr.Size)];
				num = 2132131295;
				continue;
			case 1u:
				array = new IntPtr[0];
				num = 1295692530;
				continue;
			case 0u:
				num = (Class127.bool_1 ? 1209495353 : 1804199944) ^ ((int)num2 * -34911618);
				continue;
			case 10u:
				goto IL_0227;
			case 5u:
				return array;
			case 7u:
				return new IntPtr[0];
			case 11u:
				return array;
			case 13u:
				return new IntPtr[0];
			default:
				smethod_27(gclass2_0, intPtr);
				return array;
			}
			num = (EnumProcessModulesEx(intPtr, array, 0u, out uint_, (!bool_0) ? 1u : 2u) ? 1576634546 : 53785870);
			continue;
			IL_005b:
			num = (EnumProcessModules(intPtr, array, 0u, out uint_) ? 691320577 : 1260139292);
			continue;
			end_IL_01c5:
			break;
		}
		goto IL_0051;
		IL_0227:
		intPtr = smethod_250(gclass2_0, Class124.Enum32.flag_4 | Class124.Enum32.flag_9, bool_0: false, gclass2_0.method_0());
		num = 817091961;
		goto IL_01c5;
	}

	internal static void smethod_31(Class53 class53_0, Enum7 enum7_0)
	{
		if (Class49.bool_0)
		{
			Class52.smethod_11()(ref class53_0.struct19_0, enum7_0);
		}
		else
		{
			Class52.smethod_4()(ref class53_0.struct19_0, enum7_0);
		}
	}

	internal static void smethod_32(Enum12 enum12_0, Class58 class58_0, Class53 class53_0)
	{
		smethod_256(class58_0, enum12_0, class53_0, Enum7.const_225);
	}

	internal static uint smethod_33(IEnumerable<GClass4.Class132> ienumerable_0, uint uint_0)
	{
		IEnumerator<GClass4.Class132> enumerator = ienumerable_0.Skip(1).GetEnumerator();
		try
		{
			GClass4.Class132 current = default(GClass4.Class132);
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
		Class121.Struct34 @struct = default(Class121.Struct34);
		Class121.Struct35 struct35_ = default(Class121.Struct35);
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
				@struct = new Class121.Struct34
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
				Class121.Struct34 struct34_ = @struct;
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

	internal static void smethod_36(Class53 class53_0, Class58 class58_0)
	{
		if (Class49.bool_0)
		{
			goto IL_0029;
		}
		goto IL_0053;
		IL_0029:
		int num = 1986250196;
		goto IL_002e;
		IL_002e:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x13CB37C2)) % 5)
			{
			case 3u:
				Class52.smethod_49()(ref class53_0.struct19_0, class58_0);
				num = ((int)num2 * -947920963) ^ 0x2F522074;
				continue;
			case 2u:
				break;
			default:
				return;
			case 1u:
				goto IL_0053;
			case 0u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0029;
		IL_0053:
		Class52.smethod_47()(ref class53_0.struct19_0, class58_0);
		num = 1518986711;
		goto IL_002e;
	}

	internal static bool InvokeExport(MainForm.ModuleRow class21_0, IntPtr intptr_0, MainForm mainForm)
	{
		Class152 class3 = default(Class152);
		int num9 = default(int);
		object[] array = default(object[]);
		Class47 class47_ = default(Class47);
		Class53 class5 = default(Class53);
		List<Class58> list2 = default(List<Class58>);
		List<object> list = default(List<object>);
		string text = default(string);
		int num8 = default(int);
		long num10 = default(long);
		int num11 = default(int);
		while (true)
		{
			int num = 72746129;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x460EA75B)) % 5)
				{
				case 4u:
					num = ((int)num2 * -1740599076) ^ -1619867697;
					continue;
				case 3u:
					num = ((!HasProcessExited(mainForm.selectedProcess)) ? 1796612693 : 423241358) ^ ((int)num2 * -1062268972);
					continue;
				case 2u:
					break;
				case 0u:
					throw new InvalidOperationException("The target process is no longer active.");
				default:
				{
					FileStream fileStream = new FileStream(GetModulePath(class21_0), FileMode.Open, FileAccess.Read, FileShare.Read);
					try
					{
						Class154 class2 = Class6.smethod_3<Class8>(fileStream, GetModulePath(class21_0), bool_0: false, Enum39.const_0);
						try
						{
							if (class2.method_14() == null)
							{
								goto IL_00cc;
							}
							goto IL_0103;
							IL_00cc:
							int num3 = 1170273542;
							goto IL_00d1;
							IL_00d1:
							switch ((uint)(num3 ^ 0x460EA75B) % 5u)
							{
							case 3u:
								break;
							default:
								goto end_IL_00b4;
							case 1u:
								goto IL_0103;
							case 0u:
								throw new MissingMethodException("Unable to find the exported routine, '" + class21_0.Entry.ExportName + "'.");
							case 4u:
								throw new MissingFieldException("Unable to detect export directory in the specified module.");
							case 2u:
								goto end_IL_00b4;
							}
							goto IL_00cc;
							IL_0103:
							class3 = class2.method_14().list_1.FirstOrDefault(export => export.method_4() == class21_0.Entry.ExportName);
							num3 = ((class3 != null) ? 1875164677 : 2096044763);
							goto IL_00d1;
							end_IL_00b4:;
						}
						finally
						{
							if (class2 != null)
							{
								while (true)
								{
									IL_01a3:
									int num4 = 1328130802;
									while (true)
									{
										switch ((num2 = (uint)(num4 ^ 0x460EA75B)) % 3)
										{
										case 2u:
											goto IL_0170;
										default:
											goto end_IL_0185;
										case 0u:
											break;
										case 1u:
											goto end_IL_0185;
										}
										goto IL_01a3;
										IL_0170:
										((IDisposable)class2).Dispose();
										num4 = ((int)num2 * -1174344794) ^ -531990266;
										continue;
										end_IL_0185:
										break;
									}
									break;
								}
							}
						}
					}
					finally
					{
						if (fileStream != null)
						{
							while (true)
							{
								IL_01e4:
								int num5 = 888732473;
								while (true)
								{
									switch ((num2 = (uint)(num5 ^ 0x460EA75B)) % 3)
									{
									case 1u:
										goto IL_01b1;
									default:
										goto end_IL_01c6;
									case 0u:
										break;
									case 2u:
										goto end_IL_01c6;
									}
									goto IL_01e4;
									IL_01b1:
									((IDisposable)fileStream).Dispose();
									num5 = ((int)num2 * -324139211) ^ -990825792;
									continue;
									end_IL_01c6:
									break;
								}
								break;
							}
						}
					}
					IntPtr intptr_1 = intptr_0.smethod_9(class3.method_6());
					while (true)
					{
						int num6 = 534266462;
						while (true)
						{
							switch ((num2 = (uint)(num6 ^ 0x460EA75B)) % 33)
							{
							case 32u:
								num6 = ((num9 >= array.Length) ? 768547781 : 973708458);
								continue;
							case 31u:
								smethod_226(class47_, -1);
								num6 = (int)(num2 * 1880940475) ^ -374943923;
								continue;
							case 30u:
							{
								Class58 class6 = smethod_48(class5);
								list2.Add(class6);
								list.Add(smethod_84(class47_, class6));
								num6 = (int)((num2 * 54606) ^ 0x5E51E37D);
								continue;
							}
							case 29u:
								smethod_15(class47_);
								num6 = ((int)num2 * -212515327) ^ -908933102;
								continue;
							case 28u:
								num9++;
								num6 = 23605831;
								continue;
							case 27u:
								num6 = ((class21_0.Entry.Parameters != null) ? 277257009 : 458827322) ^ (int)(num2 * 1073412424);
								continue;
							case 26u:
								num6 = ((text == null) ? (-737539902) : (-781970105)) ^ (int)(num2 * 1280621455);
								continue;
							case 25u:
								smethod_418(0, class5);
								num6 = ((int)num2 * -2031373568) ^ 0x3ADEFA02;
								continue;
							case 24u:
								smethod_54(class47_, new Class57(intptr_1), class21_0.Entry.CallingConvention, list.ToArray());
								num6 = ((int)num2 * -833880767) ^ -355695803;
								continue;
							case 23u:
								text = array[num9] as string;
								num6 = 207993883;
								continue;
							case 22u:
								class47_ = new Class47(class5, mainForm.selectedProcess);
								list2 = new List<Class58>();
								num6 = (int)(num2 * 1666297250) ^ -1722348554;
								continue;
							case 21u:
								array = class21_0.Entry.Parameters.Select(smethod_138).ToArray();
								class5 = new Class53();
								num6 = 361321445;
								continue;
							case 20u:
								list = new List<object>();
								num8 = 0;
								num6 = (int)(num2 * 2128581540) ^ -319960742;
								continue;
							case 19u:
								num6 = ((array[num8] is string) ? 38147963 : 816649650);
								continue;
							case 18u:
								list.Add(((ulong)(num10 & 0xFFFFFFFFL)).smethod_0());
								num6 = (int)(num2 * 1183786450) ^ -1674758520;
								continue;
							case 17u:
								list.Add(((ulong)(num10 & -4294967296L) >> 32).smethod_0());
								num6 = ((int)num2 * -1183410051) ^ 0x2AA7C96B;
								continue;
							case 15u:
								smethod_227(class47_);
								num6 = (int)((num2 * 1225654093) ^ 0x5A723097);
								continue;
							case 14u:
								num6 = ((num8 >= array.Length) ? 1913190811 : 584225830);
								continue;
							case 12u:
								smethod_36(class5, list2[num11++]);
								num6 = ((class21_0.Entry.Parameters[num9].Type != Enum5.LPCSTR) ? 603531166 : 1483483870) ^ ((int)num2 * -612483973);
								continue;
							case 11u:
								num11 = 0;
								num6 = ((int)num2 * -822281546) ^ 0x229DE7AE;
								continue;
							case 10u:
								smethod_320(class5, Encoding.Unicode.GetBytes(text));
								smethod_105(0, class5);
								num6 = 1806823426;
								continue;
							case 9u:
								num6 = ((class21_0.Entry.Parameters[num8].Type != Enum5.QWORD) ? 999067885 : 24045617) ^ ((int)num2 * -1483361820);
								continue;
							case 8u:
								num6 = (smethod_427(mainForm.selectedProcess) ? 1596134350 : 1875134809);
								continue;
							case 7u:
								num6 = ((int)num2 * -1199280702) ^ 0x4B2314FA;
								continue;
							case 6u:
								class21_0.Entry.Parameters = new List<ExportParameter>();
								num6 = (int)(num2 * 932447528) ^ -163800271;
								continue;
							case 5u:
								num10 = (long)array[num8];
								num6 = ((int)num2 * -1201005529) ^ 0x62581D4A;
								continue;
							case 4u:
								num6 = ((int)num2 * -560534925) ^ 0x445ED6AA;
								continue;
							case 3u:
								num8++;
								num6 = 921915070;
								continue;
							case 2u:
								num9 = 0;
								num6 = (int)(num2 * 1749684053) ^ -565240236;
								continue;
							case 1u:
								smethod_320(class5, Encoding.ASCII.GetBytes(text));
								num6 = (int)(num2 * 60815747) ^ -881080710;
								continue;
							case 0u:
								list.Add(array[num8].smethod_0());
								num6 = 847621368;
								continue;
							case 16u:
								break;
							default:
							{
								Class91 class4 = new Class91(mainForm.selectedProcess);
								try
								{
									return smethod_140(class4, class5);
								}
								finally
								{
									if (class4 != null)
									{
										while (true)
										{
											IL_075a:
											int num7 = 2094227502;
											while (true)
											{
												switch ((num2 = (uint)(num7 ^ 0x460EA75B)) % 3)
												{
												case 1u:
													goto IL_0727;
												default:
													goto end_IL_073c;
												case 2u:
													break;
												case 0u:
													goto end_IL_073c;
												}
												goto IL_075a;
												IL_0727:
												((IDisposable)class4).Dispose();
												num7 = ((int)num2 * -158544961) ^ 0x303678CB;
												continue;
												end_IL_073c:
												break;
											}
											break;
										}
									}
								}
							}
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	internal static void smethod_38(List<GClass4.Class132> list_0, GClass4 gclass4_0)
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

	internal static void smethod_39(Class63 class63_0, Class47 class47_0, Class47.Enum6 enum6_0)
	{
		Class63[] array = new Class63[2]
		{
			Class49.class63_38,
			Class49.class63_39
		};
		if (enum6_0 < Class47.Enum6.const_2)
		{
			while (true)
			{
				int num = 1944652368;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7BE4CEA5)) % 4)
					{
					case 1u:
						smethod_318(class47_0.class53_0, array[(int)enum6_0], class63_0);
						num = (int)(num2 * 1669180148) ^ -936052402;
						continue;
					case 0u:
						break;
					case 3u:
						return;
					default:
						goto end_IL_005a;
					}
					break;
				}
				continue;
				end_IL_005a:
				break;
			}
		}
		smethod_82(class47_0.class53_0, class63_0);
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

	internal static void smethod_41(GClass5 gclass5_0, GClass4 gclass4_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] array;
		try
		{
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			try
			{
				binaryWriter.Write(1396986706);
				while (true)
				{
					IL_00e7:
					int num = -1870487940;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1044298899)) % 5)
						{
						case 4u:
							binaryWriter.Write(gclass4_0.random_0.Next());
							binaryWriter.Write(gclass4_0.random_0.Next());
							binaryWriter.Write(Encoding.ASCII.GetBytes(smethod_428(gclass4_0) + "\0"));
							num = (int)((num2 * 1540468110) ^ 0x183F5763);
							continue;
						case 3u:
							binaryWriter.Write(gclass4_0.random_0.Next());
							binaryWriter.Write(gclass4_0.random_0.Next());
							num = (int)((num2 * 1865871664) ^ 0x18918E8D);
							continue;
						case 1u:
							binaryWriter.Write(gclass4_0.random_0.Next());
							num = (int)((num2 * 26423592) ^ 0x76AA72DD);
							continue;
						case 2u:
							break;
						default:
							array = memoryStream.ToArray();
							goto end_IL_00c2;
						}
						goto IL_00e7;
						continue;
						end_IL_00c2:
						break;
					}
					break;
				}
			}
			finally
			{
				if (binaryWriter != null)
				{
					while (true)
					{
						IL_012c:
						int num3 = -2125217943;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num3 ^ -1044298899)) % 3)
							{
							case 1u:
								goto IL_00fc;
							default:
								goto end_IL_010f;
							case 0u:
								break;
							case 2u:
								goto end_IL_010f;
							}
							goto IL_012c;
							IL_00fc:
							((IDisposable)binaryWriter).Dispose();
							num3 = ((int)num2 * -1580879481) ^ -1775441165;
							continue;
							end_IL_010f:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					IL_0169:
					int num4 = -529713195;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num4 ^ -1044298899)) % 3)
						{
						case 1u:
							goto IL_0139;
						default:
							goto end_IL_014c;
						case 0u:
							break;
						case 2u:
							goto end_IL_014c;
						}
						goto IL_0169;
						IL_0139:
						((IDisposable)memoryStream).Dispose();
						num4 = ((int)num2 * -2050419802) ^ 0x7E6A58C5;
						continue;
						end_IL_014c:
						break;
					}
					break;
				}
			}
		}
		gclass4_0.class154_0.method_28().Position = gclass5_0.method_8();
		while (true)
		{
			int num5 = -1372042530;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num5 ^ -1044298899)) % 9)
				{
				case 8u:
					gclass4_0.binaryWriter_0.Write(0);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num5 = ((int)num2 * -233917129) ^ 0x55B1D94C;
					continue;
				case 7u:
					gclass4_0.binaryWriter_0.Write(array.Length);
					num5 = ((int)num2 * -206896365) ^ -1401188166;
					continue;
				case 6u:
					gclass4_0.binaryWriter_0.Write(0);
					num5 = (int)(num2 * 534129865) ^ -1911474422;
					continue;
				case 5u:
					gclass4_0.binaryWriter_0.Write(gclass5_0.method_4() + 32);
					gclass4_0.binaryWriter_0.Write(gclass5_0.method_8() + 32);
					num5 = ((int)num2 * -1264665237) ^ -99212651;
					continue;
				case 4u:
					gclass4_0.binaryWriter_0.Write(2);
					num5 = (int)((num2 * 1555342059) ^ 0x3103DD8);
					continue;
				case 2u:
					gclass4_0.binaryWriter_0.Write(0);
					gclass4_0.binaryWriter_0.Write(array);
					num5 = (int)(num2 * 512326005) ^ -750366103;
					continue;
				case 0u:
					gclass4_0.class154_0.method_6().method_3().imethod_49()[6].method_1(gclass5_0.method_4());
					num5 = (int)((num2 * 1971433476) ^ 0x7990A0D5);
					continue;
				case 3u:
					break;
				default:
					gclass4_0.class154_0.method_6().method_3().imethod_49()[6].method_3(28u);
					gclass5_0.method_19((Enum41)((uint)gclass5_0.method_18() & 0xFDFFFFFFu));
					return;
				}
				break;
			}
		}
	}

	internal static Class69 smethod_42(GClass2 gclass2_0)
	{
		Class69 @class = new Class69(gclass2_0);
		int num3 = default(int);
		GClass1 gClass = default(GClass1);
		IntPtr[] array = default(IntPtr[]);
		GClass1 gClass2 = default(GClass1);
		IntPtr intptr_ = default(IntPtr);
		while (true)
		{
			int num = 1445066163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x11D96717)) % 18)
				{
				case 17u:
					num3++;
					num = 847578817;
					continue;
				case 16u:
					num3 = 0;
					num = (int)((num2 * 1456103393) ^ 0x7F34B10B);
					continue;
				case 15u:
					@class.AddRange(gclass2_0.list_1.Where(GClass2.Class74._003C_003E9.method_0));
					num = 1014844718;
					continue;
				case 13u:
					@class.Add(gClass);
					num = (int)((num2 * 2048640384) ^ 0x7F1E4EC8);
					continue;
				case 12u:
					num = ((num3 < array.Length) ? 1953961120 : 504325155);
					continue;
				case 11u:
					array = smethod_30(gclass2_0, bool_0: false);
					num = ((int)num2 * -106916349) ^ 0x61236E7C;
					continue;
				case 10u:
					num = ((num3 >= array.Length) ? 684717404 : 2114337985);
					continue;
				case 9u:
				{
					IntPtr intptr_2 = array[num3];
					gClass = new GClass1(gclass2_0, @class, intptr_2, bool_2: false);
					num = (smethod_246(gClass) ? 554302014 : 1905028936);
					continue;
				}
				case 8u:
					num = (gclass2_0.bool_2 ? 127108562 : 1199907640) ^ (int)(num2 * 1408796839);
					continue;
				case 7u:
					@class.Add(gClass2);
					num = (int)((num2 * 172035582) ^ 0x2208E624);
					continue;
				case 6u:
					gClass2 = new GClass1(gclass2_0, @class, intptr_, bool_2: true);
					num = (int)((num2 * 141323035) ^ 0x4C156DF3);
					continue;
				case 5u:
					array = smethod_30(gclass2_0, bool_0: true);
					num3 = 0;
					num = 847578817;
					continue;
				case 4u:
					num = (smethod_246(gClass2) ? 493758102 : 1343730546) ^ ((int)num2 * -98838020);
					continue;
				case 2u:
					@class.AddRange(gclass2_0.list_1.Where(GClass2.Class74._003C_003E9.method_1));
					num = 1914154479;
					continue;
				case 1u:
					num3++;
					num = 499609561;
					continue;
				case 0u:
					intptr_ = array[num3];
					num = 579936525;
					continue;
				case 3u:
					break;
				default:
					return @class;
				}
				break;
			}
		}
	}

	internal static void smethod_43(Class148.Class150 class150_0)
	{
		class150_0.int_0 = -1;
		while (true)
		{
			int num = 423635800;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4D4CAC9B)) % 4)
				{
				case 3u:
					num = ((class150_0.ienumerator_0 != null) ? 1814998357 : 1465715938) ^ (int)(num2 * 2015806412);
					continue;
				case 2u:
					class150_0.ienumerator_0.Dispose();
					num = (int)(num2 * 2071760766) ^ -1938431190;
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	[DllImport("psapi.dll")]
	internal static extern uint GetModuleBaseName(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	[DllImport("ntdll.dll", SetLastError = true)]
	internal static extern uint NtQueryInformationProcess(IntPtr intptr_0, Class124.Enum26 enum26_0, out Class124.Struct45 struct45_0, int int_0, out int int_1);

	internal static int smethod_44(Class179.Stream1 stream1_0)
	{
		return smethod_438(stream1_0) | (smethod_438(stream1_0) << 16);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0, out UIntPtr uintptr_1);

	internal static GClass2 SelectProcess()
	{
		ProcessSelectorForm form = new ProcessSelectorForm();
		while (true)
		{
			int num = -1184526344;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -1091078455)) % 4)
				{
				case 1u:
					num3 = ((form.ShowDialog() != DialogResult.OK) ? 19718946 : 831995776);
					goto IL_0027;
				case 3u:
					break;
				case 0u:
					return null;
				default:
					return form.method_0();
				}
				break;
				IL_0027:
				num = num3 ^ ((int)num2 * -39096669);
			}
		}
	}

	internal static void smethod_46(GClass4 gclass4_0)
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

	internal static GClass2 smethod_47(int int_0)
	{
		GClass2 gClass = new GClass2((uint)int_0);
		while (true)
		{
			int num = -1650746781;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ -874376814)) % 4)
				{
				case 1u:
					num3 = ((!smethod_102(gClass)) ? (-1306103517) : (-79975456));
					goto IL_0027;
				case 2u:
					break;
				case 0u:
					return null;
				default:
					return gClass;
				}
				break;
				IL_0027:
				num = num3 ^ (int)(num2 * 341441009);
			}
		}
	}

	[DllImport("kernel32.dll")]
	internal static extern IntPtr GetCurrentProcess();

	internal static Class58 smethod_48(Class53 class53_0)
	{
		Class58 @class = new Class58();
		if (Class49.bool_0)
		{
			goto IL_0030;
		}
		goto IL_0056;
		IL_0030:
		int num = -1343311329;
		goto IL_0035;
		IL_0035:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -872701947)) % 4)
			{
			case 2u:
				Class52.smethod_45()(ref class53_0.struct19_0, @class);
				num = ((int)num2 * -1408394789) ^ 0x5CBF6C44;
				continue;
			case 0u:
				break;
			case 1u:
				goto IL_0056;
			default:
				return @class;
			}
			break;
		}
		goto IL_0030;
		IL_0056:
		Class52.smethod_43()(ref class53_0.struct19_0, @class);
		num = -980063622;
		goto IL_0035;
	}

	internal static bool smethod_49(Class56 class56_0, Class56 class56_1)
	{
		return !smethod_328(class56_0, class56_1);
	}

	internal static void smethod_50(DependencyInstallerForm form3_0, string string_0, string string_1)
	{
		form3_0.string_0 = string_0;
		form3_0.string_1 = string_1;
		form3_0.bool_0 = false;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, UIntPtr uintptr_0, out UIntPtr uintptr_1);

	internal static Class54 smethod_51()
	{
		return new Class55(Class54.delegate41_0());
	}

	internal static void smethod_52(Class53 class53_0, ushort ushort_0)
	{
		smethod_308(2L, ushort_0, class53_0);
	}

	internal static void smethod_53(Class53 class53_0)
	{
		if (!class53_0.method_0())
		{
			while (true)
			{
				int num = -1315959667;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -386372948)) % 4)
					{
					case 1u:
						num = ((!Class49.bool_0) ? 1898818375 : 1076915690) ^ (int)(num2 * 1293123976);
						continue;
					case 0u:
						break;
					case 2u:
						throw new InvalidOperationException("This instruction is only available in x86 mode.");
					default:
						goto end_IL_0051;
					}
					break;
				}
				continue;
				end_IL_0051:
				break;
			}
		}
		smethod_31(class53_0, Enum7.const_422);
	}

	internal static void smethod_54(Class47 class47_0, Class57 class57_0, CallingConvention callingConvention_0, object[] object_0)
	{
		smethod_83(object_0, callingConvention_0, class57_0, class47_0);
	}

	internal static void smethod_55(Class53 class53_0)
	{
		if (!class53_0.method_0())
		{
			goto IL_0032;
		}
		goto IL_005c;
		IL_0032:
		int num = 2007550817;
		goto IL_0037;
		IL_0037:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x133B41A7)) % 5)
			{
			case 3u:
				num = (Class49.bool_0 ? 1309333914 : 1500478594) ^ (int)(num2 * 610774414);
				continue;
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_005c;
			case 2u:
				throw new InvalidOperationException("This instruction is only available in x86 mode.");
			case 4u:
				return;
			}
			break;
		}
		goto IL_0032;
		IL_005c:
		smethod_31(class53_0, Enum7.const_420);
		num = 1954586311;
		goto IL_0037;
	}

	internal static void smethod_56(List<GClass4.Class132> list_0, GClass4 gclass4_0)
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
		Class138 current = default(Class138);
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
				IEnumerator<Class138> enumerator = smethod_9(gclass4_0.class154_0.method_23().method_0()).GetEnumerator();
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

	internal static void smethod_57(Class56.Struct14 struct14_0, Class56 class56_0)
	{
		class56_0.method_1(Class56.smethod_0<Class56.Struct14, Class56.Struct7>(struct14_0));
	}

	internal static void smethod_58(GClass4 gclass4_0, Stream stream_0)
	{
		smethod_315(stream_0, gclass4_0.class154_0);
	}

	internal static Class57 smethod_59(sbyte sbyte_0)
	{
		return new Class57((IntPtr)sbyte_0);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool OpenProcessToken(IntPtr intptr_0, uint uint_0, out IntPtr intptr_1);

	internal static int smethod_60(Class179.Class181 class181_0, int int_0)
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

	[DllImport("psapi.dll")]
	internal static extern uint GetModuleFileNameEx(IntPtr intptr_0, IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

	internal static IntPtr smethod_61(Class53 class53_0, Class84 class84_0)
	{
		return smethod_443(IntPtr.Zero, class53_0, class84_0);
	}

	internal static Class179.Class183 smethod_62(Class179.Class184 class184_0)
	{
		byte[] array = new byte[class184_0.int_4];
		Array.Copy(class184_0.byte_1, class184_0.int_3, array, 0, class184_0.int_4);
		return new Class179.Class183(array);
	}

	internal static Class179.Class183 smethod_63(Class179.Class184 class184_0)
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
					return new Class179.Class183(array);
				}
				break;
				IL_000e:
				Array.Copy(class184_0.byte_1, 0, array, 0, class184_0.int_3);
				num = ((int)num2 * -1090434049) ^ -1694220453;
			}
		}
	}

	internal static long smethod_64(Class154 class154_0, ulong ulong_0)
	{
		if (ulong_0 < class154_0.method_6().method_3().imethod_17())
		{
			return -1L;
		}
		return smethod_135(class154_0, (uint)(ulong_0 - class154_0.method_6().method_3().imethod_17()));
	}

	internal static int smethod_65(Class179.Class181 class181_0, byte[] byte_0, int int_0, int int_1)
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

	internal static IEnumerable<int> smethod_66(GClass2 gclass2_0)
	{
		IntPtr intPtr = CreateToolhelp32Snapshot(Class124.Enum27.flag_2, gclass2_0.method_0());
		Class124.Struct44 struct44_ = default(Class124.Struct44);
		Class124.Struct44 @struct = default(Class124.Struct44);
		List<int> list = default(List<int>);
		while (true)
		{
			int num = 1307487682;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x208B2906)) % 12)
				{
				case 11u:
					num = (Thread32Next(intPtr, ref struct44_) ? 2070883810 : 1164233383);
					continue;
				case 9u:
					struct44_ = @struct;
					num = ((int)num2 * -1408375011) ^ -762988503;
					continue;
				case 8u:
					num = ((struct44_.uint_3 != (uint)gclass2_0.method_0()) ? 168089781 : 439633439);
					continue;
				case 6u:
					num = ((!Thread32First(intPtr, ref struct44_)) ? 2057302549 : 2073148229) ^ (int)(num2 * 1867242070);
					continue;
				case 4u:
					num = ((!(intPtr == IntPtr.Zero)) ? 1813319728 : 1662597444) ^ ((int)num2 * -532927045);
					continue;
				case 3u:
					list = new List<int>();
					num = 2070883810;
					continue;
				case 2u:
					@struct = new Class124.Struct44
					{
						uint_0 = (uint)typeof(Class124.Struct44).smethod_7()
					};
					num = 1610360023;
					continue;
				case 1u:
					list.Add((int)struct44_.uint_2);
					num = ((int)num2 * -1517580532) ^ 0x159FF499;
					continue;
				case 0u:
					break;
				default:
					smethod_27(gclass2_0, intPtr);
					return list.ToArray();
				case 7u:
					smethod_27(gclass2_0, intPtr);
					return new int[0];
				case 10u:
					return new int[0];
				}
				break;
			}
		}
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsWindowVisible(IntPtr intptr_0);

	internal static IntPtr smethod_67(Class89.Class172 class172_0, Class89 class89_0, string string_0)
	{
		Class89.Enum44 enum44_ = Class89.Enum44.flag_5 | Class89.Enum44.flag_6 | Class89.Enum44.flag_7;
		IntPtr intPtr = smethod_42(class89_0.method_19()).method_0(string_0);
		if (intPtr != IntPtr.Zero)
		{
			goto IL_0028;
		}
		goto IL_015a;
		IL_0028:
		int num = 2058013507;
		goto IL_0117;
		IL_0117:
		Enum43 @enum = default(Enum43);
		Class89 @class = default(Class89);
		string text = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6DAC9DEC)) % 12)
			{
			case 10u:
				break;
			case 9u:
				@enum |= Enum43.flag_4;
				num = ((int)num2 * -617834182) ^ 0x92E7F4F;
				continue;
			case 8u:
			{
				Class89 class2 = new Class89(class89_0.method_19());
				class2.method_20(class89_0.method_19());
				@class = class2;
				num = ((int)num2 * -58568668) ^ -244573276;
				continue;
			}
			case 6u:
				num = (smethod_379(class89_0.method_19()) ? (-608394723) : (-119591427)) ^ (int)(num2 * 1614912708);
				continue;
			case 5u:
				num = ((text != null) ? (-1646373516) : (-584007238)) ^ (int)(num2 * 1169821124);
				continue;
			case 4u:
				goto IL_00c9;
			case 1u:
				text = smethod_440(string_0, class172_0.method_4(), Path.GetDirectoryName(class172_0.method_4()), @enum, class89_0.method_0(), class172_0.method_10());
				num = 504318009;
				continue;
			case 7u:
				goto IL_015a;
			case 0u:
			{
				IntPtr intPtr2 = @class.method_36(text, enum44_);
				if (intPtr2 == IntPtr.Zero)
				{
					class89_0.method_35(new Exception("Failed to load the requested depedency: " + text, @class.method_34()));
				}
				return intPtr2;
			}
			case 2u:
				class89_0.method_35(new FileNotFoundException("Unable to resolve path for dependency: " + string_0));
				return IntPtr.Zero;
			default:
				try
				{
					return new Class87(class89_0.method_19()).method_0BA6(text);
				}
				catch (Exception innerException)
				{
					class89_0.method_35(new Exception("Failed to load the requested depedency: " + text, innerException));
					return IntPtr.Zero;
				}
			case 11u:
				return intPtr;
			}
			break;
			IL_00c9:
			num = (((class172_0.method_8() & Class89.Enum44.flag_4) != 0) ? 1788943320 : 1492857747);
		}
		goto IL_0028;
		IL_015a:
		@enum = Enum43.flag_2;
		num = 1007740930;
		goto IL_0117;
	}

	internal static void smethod_68(Class53 class53_0, Class65 class65_0, Class63 class63_0)
	{
		if (!class53_0.method_0())
		{
			while (true)
			{
				int num = 481217105;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x2B9635E7)) % 4)
					{
					case 2u:
						num = ((!Class49.bool_0) ? (-1835674768) : (-740240534)) ^ ((int)num2 * -1734933389);
						continue;
					case 0u:
						break;
					case 1u:
						throw new InvalidOperationException("This instruction is only available in x64 mode.");
					default:
						goto end_IL_0051;
					}
					break;
				}
				continue;
				end_IL_0051:
				break;
			}
		}
		smethod_137(class53_0, Enum7.const_289, class65_0, class63_0);
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool LookupPrivilegeValue(string string_0, string string_1, out Class121.Struct35 struct35_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool VirtualFree(IntPtr intptr_0, UIntPtr uintptr_0, Class124.Enum28 enum28_0);

	internal static bool smethod_69()
	{
		if (!Class127.bool_1)
		{
			goto IL_0019;
		}
		goto IL_00da;
		IL_0019:
		int num = -1308890482;
		goto IL_008c;
		IL_008c:
		Class121.Enum17 @enum = default(Class121.Enum17);
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
				@enum = (Class121.Enum17)uint_;
				num = ((int)num2 * -46335719) ^ 0xF007824;
				continue;
			case 6u:
				goto IL_0032;
			case 2u:
				CloseHandle(intptr_);
				num = -1463965964;
				continue;
			case 1u:
				num = ((@enum == Class121.Enum17.const_1) ? (-1423328528) : (-509497601)) ^ ((int)num2 * -426048021);
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
				return @enum == Class121.Enum17.const_2;
			case 7u:
				return false;
			}
			break;
			IL_0032:
			num = ((!GetTokenInformation(intptr_, Class121.Enum16.const_17, out uint_, 4u, out var _)) ? (-1302826452) : (-1876553708));
		}
		goto IL_0019;
		IL_00da:
		num = (OpenProcessToken(GetCurrentProcess_1(), 8u, out intptr_) ? (-1172786300) : (-1386544104));
		goto IL_008c;
	}

	internal static bool smethod_70(Class75 class75_0)
	{
		IntPtr intPtr = OpenThread(Class124.Enum31.flag_5, bool_0: false, class75_0.method_0());
		if (intPtr == IntPtr.Zero)
		{
			goto IL_0031;
		}
		goto IL_010d;
		IL_0031:
		int num = -2101173460;
		goto IL_00c3;
		IL_00c3:
		IntPtr intptr_ = default(IntPtr);
		int int_;
		Class124.Struct49 struct49_ = default(Class124.Struct49);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -249622791)) % 10)
			{
			case 6u:
				break;
			case 4u:
				num = ((NtQueryInformationThread_1(intPtr, Class124.Enum25.const_9, out intptr_, IntPtr.Size, out int_) != 0) ? 493597642 : 918120976) ^ (int)(num2 * 1333310952);
				continue;
			case 3u:
				class75_0.method_3(intptr_);
				num = -1103030450;
				continue;
			case 1u:
				class75_0.method_8((ThreadPriorityLevel)GetThreadPriority(intPtr));
				num = ((int)num2 * -1509299532) ^ -349476709;
				continue;
			case 0u:
				class75_0.method_4((int)struct49_.uint_2);
				class75_0.method_5((int)struct49_.uint_1);
				class75_0.method_6(struct49_.intptr_0);
				num = -1548753795;
				continue;
			case 2u:
				goto IL_010d;
			case 5u:
				CloseHandle(intPtr);
				return false;
			case 7u:
				return false;
			default:
				CloseHandle(intPtr);
				return true;
			case 9u:
				CloseHandle(intPtr);
				return false;
			}
			break;
		}
		goto IL_0031;
		IL_010d:
		num = ((NtQueryInformationThread(intPtr, Class124.Enum25.const_0, out struct49_, typeof(Class124.Struct49).smethod_7(), out int_) != 0) ? (-1354389344) : (-1669882073));
		goto IL_00c3;
	}

	internal static void smethod_71(Class165 class165_0)
	{
		class165_0.stream_0.Position = class165_0.class154_0.method_4().method_0();
		while (true)
		{
			int num = 1728965764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4FFAF0F9)) % 4)
				{
				case 1u:
					class165_0.stream_0.Position += 4L;
					num = (int)(num2 * 1744096964) ^ -930849271;
					continue;
				case 0u:
					smethod_159(class165_0);
					num = ((int)num2 * -655409013) ^ -1596080050;
					continue;
				case 2u:
					break;
				default:
					smethod_163(class165_0);
					return;
				}
				break;
			}
		}
	}

	internal static Class57 smethod_72(byte byte_0)
	{
		return new Class57((IntPtr)byte_0, bool_0: true);
	}

	internal static int smethod_73(GClass2 gclass2_0)
	{
		if (!smethod_427(gclass2_0))
		{
			return 8;
		}
		return 4;
	}

	internal static bool smethod_74(Class75 class75_0)
	{
		IntPtr intPtr = OpenThread(Class124.Enum31.flag_0, bool_0: false, class75_0.method_0());
		bool result = default(bool);
		while (true)
		{
			int num = 1565626896;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1821A878)) % 5)
				{
				case 3u:
					num = ((intPtr == IntPtr.Zero) ? (-859009436) : (-1202907501)) ^ ((int)num2 * -309030725);
					continue;
				case 2u:
					result = TerminateThread(intPtr, 0);
					CloseHandle(intPtr);
					num = 896413084;
					continue;
				case 4u:
					break;
				default:
					return result;
				case 1u:
					return false;
				}
				break;
			}
		}
	}

	internal static void smethod_75(Class53 class53_0, Class59 class59_0, Class63 class63_0)
	{
		smethod_137(class53_0, Enum7.const_266, class59_0, class63_0);
	}

	internal static void smethod_76(Stream stream_0, Class165 class165_0)
	{
		stream_0.SetLength(0L);
		while (true)
		{
			int num = -26007130;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1110948373)) % 6)
				{
				case 4u:
					class165_0.class154_0.method_28().Position = 0L;
					smethod_333(class165_0);
					smethod_71(class165_0);
					num = ((int)num2 * -171861212) ^ 0x223EFF10;
					continue;
				case 3u:
					class165_0.method_0();
					num = (int)((num2 * 1475144994) ^ 0x2706DE75);
					continue;
				case 1u:
					class165_0.stream_0 = stream_0;
					class165_0.binaryWriter_0 = new BinaryWriter(stream_0);
					num = (int)((num2 * 94666023) ^ 0x705902E2);
					continue;
				case 0u:
					class165_0.class154_0.method_28().Position = 0L;
					class165_0.class154_0.method_28().smethod_6(stream_0);
					num = ((int)num2 * -306463078) ^ -1347130365;
					continue;
				default:
					return;
				case 5u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_77(Class179.Class182 class182_0, int int_0)
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

	internal static void smethod_78(byte[] byte_0, GClass4 gclass4_0)
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

	internal static void smethod_79(MainForm mainForm)
	{
		StringBuilder stringBuilder = new StringBuilder("Extreme Injector v");
		Version version = typeof(MainForm).Assembly.GetName().Version;
		while (true)
		{
			int num = -1107503483;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1148725449)) % 5)
				{
				case 3u:
					stringBuilder.Append(version.Major).Append('.').Append(version.Minor);
					num = ((version.Build != 0) ? (-1078511260) : (-1775771370)) ^ ((int)num2 * -1353278177);
					continue;
				case 1u:
					stringBuilder.Append(" by master131");
					mainForm.Text = stringBuilder.ToString();
					num = -419022673;
					continue;
				case 0u:
					stringBuilder.Append('.').Append(version.Build);
					num = (int)(num2 * 1689097857) ^ -1681775931;
					continue;
				default:
					return;
				case 4u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal static Class59 smethod_80(long long_0, Class47 class47_0, Class58 class58_0)
	{
		if (class47_0.bool_0)
		{
			while (true)
			{
				int num = -266895509;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1065384508)) % 3)
					{
					case 1u:
						class47_0.class53_0.struct19_0.uint_2 |= 8u;
						num = (int)((num2 * 1859920697) ^ 0x35367297);
						continue;
					case 2u:
						break;
					default:
						goto end_IL_0049;
					}
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
		return smethod_126(class58_0, long_0);
	}

	internal static Class154 smethod_81(Enum39 enum39_0, string string_0)
	{
		return Class6.smethod_5(new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), string_0, bool_0: true, enum39_0);
	}

	internal static void smethod_82(Class53 class53_0, Class63 class63_0)
	{
		smethod_352(class63_0, Enum7.const_463, class53_0);
	}

	[DllImport("kernel32.dll")]
	internal static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, IntPtr intptr_2, IntPtr intptr_3, uint uint_0, IntPtr intptr_4);

	internal static void smethod_83(object[] object_0, CallingConvention callingConvention_0, Class56 class56_0, Class47 class47_0)
	{
		if (class47_0.bool_0)
		{
			goto IL_0008;
		}
		goto IL_002c;
		IL_0008:
		int num = 107200593;
		goto IL_000d;
		IL_000d:
		switch ((uint)(num ^ 0x5322E4DC) % 4u)
		{
		case 0u:
			break;
		default:
			return;
		case 2u:
			goto IL_002c;
		case 1u:
			smethod_358(class56_0, object_0, callingConvention_0, class47_0);
			return;
		case 3u:
			return;
		}
		goto IL_0008;
		IL_002c:
		smethod_365(class47_0, class56_0, object_0);
		num = 63399227;
		goto IL_000d;
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EnumWindows(Class124.Delegate46 delegate46_0, IntPtr intptr_0);

	internal static object smethod_84(Class47 class47_0, Class58 class58_0)
	{
		return new Class47.Class48(class58_0);
	}

	internal static bool smethod_85(Class152 class152_0)
	{
		return class152_0.method_8() != null;
	}

	internal static void smethod_86(Class117 class117_0, IntPtr intptr_0)
	{
		class117_0.method_18(intptr_0);
	}

	internal static bool smethod_87(GClass2 gclass2_0)
	{
		if (Class127.bool_1)
		{
			goto IL_00ad;
		}
		goto IL_01ea;
		IL_00ad:
		int num = 1849043284;
		goto IL_018f;
		IL_018f:
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		StringBuilder stringBuilder2 = default(StringBuilder);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x5A7375FD)) % 18)
			{
			case 17u:
				smethod_27(gclass2_0, intPtr);
				num = ((int)num2 * -1822048471) ^ -1875017693;
				continue;
			case 16u:
				smethod_27(gclass2_0, intPtr);
				num = (int)((num2 * 2146624685) ^ 0x1DE4FD81);
				continue;
			case 15u:
				smethod_27(gclass2_0, intPtr2);
				num = ((int)num2 * -966737247) ^ -1586166768;
				continue;
			case 13u:
			{
				int int_ = stringBuilder.Capacity;
				num = (QueryFullProcessImageName(intPtr2, 0, stringBuilder, ref int_) ? (-494058667) : (-52817372)) ^ (int)(num2 * 1218064214);
				continue;
			}
			case 11u:
				stringBuilder = new StringBuilder(255);
				num = 2049625726;
				continue;
			case 9u:
				break;
			case 8u:
				goto IL_00b7;
			case 7u:
				goto IL_00ea;
			case 1u:
				intPtr2 = smethod_250(gclass2_0, Class124.Enum32.flag_10, bool_0: false, gclass2_0.method_0());
				num = ((intPtr2 == IntPtr.Zero) ? 564309919 : 8767601) ^ ((int)num2 * -2057680169);
				continue;
			case 0u:
				num = ((!(intPtr == IntPtr.Zero)) ? 883077294 : 1908357069) ^ (int)(num2 * 2146263940);
				continue;
			case 2u:
				goto IL_01ea;
			case 3u:
				return false;
			case 4u:
				gclass2_0.method_5(stringBuilder.ToString());
				gclass2_0.method_3(Path.GetFileName(gclass2_0.method_4()));
				smethod_27(gclass2_0, intPtr2);
				return true;
			case 5u:
				return false;
			case 6u:
				return false;
			case 10u:
				return false;
			case 12u:
				return false;
			default:
				gclass2_0.method_5(text);
				gclass2_0.method_3(Path.GetFileName(gclass2_0.method_4()));
				smethod_27(gclass2_0, intPtr);
				return true;
			}
			break;
			IL_00ea:
			stringBuilder2 = new StringBuilder(255);
			num = ((GetProcessImageFileName(intPtr, stringBuilder2, (uint)stringBuilder2.Capacity) != 0) ? 19586961 : 2146451832);
			continue;
			IL_00b7:
			text = Class127.smethod_0(stringBuilder2.ToString());
			num = (string.IsNullOrEmpty(text) ? 504097765 : 1139174099);
		}
		goto IL_00ad;
		IL_01ea:
		intPtr = smethod_250(gclass2_0, Class124.Enum32.flag_9, bool_0: false, gclass2_0.method_0());
		num = 704195301;
		goto IL_018f;
	}

	[DllImport("kernel32.dll")]
	internal static extern uint QueryDosDevice(string string_0, [Out] StringBuilder stringBuilder_0, int int_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr GetModuleHandle(string string_0);

	internal static void smethod_88(ProcessInspectorForm form4_0)
	{
		Class76 @class = ((Class75)form4_0.dataGridView_1.SelectedRows[0].Tag).method_9();
		if (@class.struct40_0.uint_3 == 5)
		{
			goto IL_0058;
		}
		goto IL_00b5;
		IL_0058:
		int num = -1147301404;
		goto IL_008c;
		IL_008c:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -938941599)) % 6)
			{
			case 4u:
				form4_0.button_3.Text = "Resume";
				num = ((int)num2 * -667996033) ^ 0x3EDCEFF9;
				continue;
			case 3u:
				break;
			case 1u:
				num = ((@class.struct40_0.enum23_0 != Class124.Enum23.const_5) ? 1812338164 : 1483751917) ^ ((int)num2 * -577221706);
				continue;
			default:
				return;
			case 5u:
				goto IL_00b5;
			case 0u:
				return;
			case 2u:
				return;
			}
			break;
		}
		goto IL_0058;
		IL_00b5:
		form4_0.button_3.Text = "Suspend";
		num = -109253225;
		goto IL_008c;
	}

	internal static bool smethod_89(Class137 class137_0)
	{
		return !smethod_387(class137_0);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool AdjustTokenPrivileges(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, ref Class121.Struct34 struct34_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	internal static string smethod_90(int int_0, Class166 class166_0)
	{
		if (!smethod_262(class166_0, int_0))
		{
			goto IL_0044;
		}
		goto IL_0080;
		IL_0044:
		int num = 1531123208;
		goto IL_0049;
		IL_0049:
		int int_1 = default(int);
		while (true)
		{
			switch ((uint)(num ^ 0x605E7009) % 7u)
			{
			case 5u:
				break;
			case 2u:
				goto end_IL_0049;
			case 3u:
				goto IL_0080;
			case 0u:
				return null;
			case 1u:
				return null;
			default:
			{
				byte[] bytes = smethod_144(class166_0, int_1);
				try
				{
					return Encoding.Unicode.GetString(bytes);
				}
				catch
				{
					return null;
				}
			}
			case 6u:
				return null;
			}
			int_1 = smethod_370(class166_0) * 2;
			num = ((!smethod_176(class166_0, int_1)) ? 462461945 : 9507030);
			continue;
			end_IL_0049:
			break;
		}
		goto IL_0044;
		IL_0080:
		num = ((!smethod_176(class166_0, 2)) ? 673229954 : 401419180);
		goto IL_0049;
	}

	internal static void smethod_91(Class58 class58_0, Enum12 enum12_0, Class53 class53_0)
	{
		smethod_149(Enum7.const_240, class58_0, class53_0, enum12_0);
	}

	internal static Class143 smethod_92(Class5 class5_0, Class154 class154_0)
	{
		Class157 @class = class154_0.method_6().method_3().imethod_49()[10];
		long num3 = default(long);
		while (true)
		{
			int num = 1626571605;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x49CCA07F)) % 11)
				{
				case 8u:
					num = (class5_0.imethod_0(num3) ? 1127392671 : 1564690107) ^ ((int)num2 * -917787358);
					continue;
				case 7u:
					num = ((num3 == -1L) ? (-150406441) : (-1264037439)) ^ ((int)num2 * -1658718608);
					continue;
				case 6u:
					num = ((@class.method_0() != 0) ? 132131702 : 1864030419) ^ (int)(num2 * 2056369660);
					continue;
				case 5u:
					num = ((@class.method_2() == 0) ? (-1279481049) : (-981612614)) ^ (int)(num2 * 274703084);
					continue;
				case 4u:
					num = ((!class5_0.imethod_0(num3 + @class.method_2())) ? 1338331955 : 2004073118);
					continue;
				case 1u:
					num3 = smethod_135(class154_0, @class.method_0());
					num = 1863516466;
					continue;
				case 10u:
					break;
				default:
					smethod_157(class5_0, num3);
					return new Class143(class5_0, class154_0);
				case 2u:
					return null;
				case 3u:
					return null;
				case 9u:
					return null;
				}
				break;
			}
		}
	}

	internal static void smethod_93(IEnumerable<GClass4.Class132> ienumerable_0, GClass4 gclass4_0)
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

	internal static void smethod_94(Class53 class53_0)
	{
		if (!class53_0.method_0())
		{
			while (true)
			{
				int num = -1187826456;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -348140675)) % 4)
					{
					case 1u:
						num = ((!Class49.bool_0) ? (-91515736) : (-1073536982)) ^ (int)(num2 * 1891261021);
						continue;
					case 3u:
						break;
					case 2u:
						throw new InvalidOperationException("This instruction is only available in x86 mode.");
					default:
						goto end_IL_0051;
					}
					break;
				}
				continue;
				end_IL_0051:
				break;
			}
		}
		smethod_31(class53_0, Enum7.const_465);
	}

	internal static void smethod_95(GClass4 gclass4_0)
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

	internal static int smethod_96(Class179.Class183 class183_0, Class179.Class181 class181_0)
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

	internal static bool smethod_97(Class75 class75_0)
	{
		IntPtr intPtr = OpenThread(Class124.Enum31.flag_1, bool_0: false, class75_0.method_0());
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		int num = ResumeThread(intPtr);
		CloseHandle(intPtr);
		return num != -1;
	}

	internal static void smethod_98(Class53 class53_0, ulong ulong_0)
	{
		smethod_308(8L, ulong_0, class53_0);
	}

	internal static byte[] smethod_99()
	{
		return (byte[])smethod_124().GetObject("BeaEnginex64", Class68.cultureInfo_0);
	}

	internal static Bitmap smethod_100(Icon icon_0)
	{
		Bitmap bitmap = icon_0.ToBitmap();
		try
		{
			Bitmap bitmap2 = new Bitmap(22, 22);
			Graphics graphics = Graphics.FromImage(bitmap2);
			try
			{
				graphics.InterpolationMode = InterpolationMode.High;
				while (true)
				{
					IL_0062:
					int num = -470118680;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1553791507)) % 3)
						{
						case 1u:
							goto IL_0021;
						default:
							goto end_IL_0044;
						case 2u:
							break;
						case 0u:
							goto end_IL_0044;
						}
						goto IL_0062;
						IL_0021:
						graphics.DrawImage(bitmap, 0, 0, bitmap2.Width, bitmap2.Height);
						num = ((int)num2 * -1194039218) ^ 0x130BC080;
						continue;
						end_IL_0044:
						break;
					}
					break;
				}
			}
			finally
			{
				if (graphics != null)
				{
					while (true)
					{
						IL_00a2:
						int num3 = -2021700286;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num3 ^ -1553791507)) % 3)
							{
							case 2u:
								goto IL_0070;
							default:
								goto end_IL_0084;
							case 0u:
								break;
							case 1u:
								goto end_IL_0084;
							}
							goto IL_00a2;
							IL_0070:
							((IDisposable)graphics).Dispose();
							num3 = ((int)num2 * -1161977881) ^ 0x7718A73B;
							continue;
							end_IL_0084:
							break;
						}
						break;
					}
				}
			}
			return bitmap2;
		}
		finally
		{
			if (bitmap != null)
			{
				while (true)
				{
					IL_00e5:
					int num4 = -333268470;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num4 ^ -1553791507)) % 3)
						{
						case 2u:
							goto IL_00b3;
						default:
							goto end_IL_00c7;
						case 0u:
							break;
						case 1u:
							goto end_IL_00c7;
						}
						goto IL_00e5;
						IL_00b3:
						((IDisposable)bitmap).Dispose();
						num4 = (int)((num2 * 802224640) ^ 0x2B271A66);
						continue;
						end_IL_00c7:
						break;
					}
					break;
				}
			}
		}
	}

	internal static void smethod_101(long long_0, Class166 class166_0, Class138 class138_0)
	{
		class138_0.method_5(new List<Class139>());
		class138_0.method_7(new List<Class138>());
		class138_0.class166_0 = class166_0;
		class138_0.long_0 = long_0;
		smethod_414(class138_0);
	}

	internal static bool smethod_102(GClass2 gclass2_0)
	{
		if (!smethod_87(gclass2_0))
		{
			goto IL_0038;
		}
		goto IL_0074;
		IL_0038:
		int num = -757083136;
		goto IL_003d;
		IL_003d:
		while (true)
		{
			switch ((uint)(num ^ -631056001) % 7u)
			{
			case 2u:
				break;
			case 0u:
				goto end_IL_003d;
			case 6u:
				goto IL_0074;
			default:
				return true;
			case 3u:
				return false;
			case 4u:
				return false;
			case 5u:
				return false;
			}
			num = (smethod_260(gclass2_0) ? (-1727402089) : (-1957794087));
			continue;
			end_IL_003d:
			break;
		}
		goto IL_0038;
		IL_0074:
		num = ((!smethod_2(gclass2_0)) ? (-18596145) : (-554709095));
		goto IL_003d;
	}

	internal static bool smethod_103(GClass1 gclass1_0, Class93 class93_0)
	{
		Class93.Class120 @class = new Class93.Class120();
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		uint uint_ = default(uint);
		while (true)
		{
			int num = 111241506;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2B7E122B)) % 15)
				{
				case 11u:
					smethod_153(class93_0, intPtr, -1);
					num = 899517699;
					continue;
				case 10u:
					@class.gclass1_0 = gclass1_0;
					num = ((smethod_385(class93_0, @class.gclass1_0) <= 0) ? (-825638444) : (-878217952)) ^ ((int)num2 * -700172841);
					continue;
				case 7u:
				{
					GClass1 gClass = smethod_42(class93_0.method_19()).FirstOrDefault(@class.method_0);
					if (gClass != null)
					{
						intPtr2 = smethod_225(gClass, "LdrUnloadDll", bool_0: false);
						num = ((!(intPtr2 == IntPtr.Zero)) ? 1744170323 : 470399402);
						continue;
					}
					throw new FileNotFoundException("Unable to find ntdll.dll in the specified process.");
				}
				case 6u:
					GetExitCodeThread(intPtr, out uint_);
					num = ((int)num2 * -638592711) ^ 0x4914EB80;
					continue;
				case 5u:
					intPtr = smethod_321(class93_0, intPtr2, @class.gclass1_0.method_0());
					num = 1706188068;
					continue;
				case 4u:
					smethod_108(class93_0, intPtr);
					num = ((uint_ != 0) ? 1334523807 : 100454095) ^ (int)(num2 * 323425302);
					continue;
				case 3u:
					num = ((!class93_0.method_8(class93_0.method_19().method_0())) ? 1422638295 : 2124295937);
					continue;
				case 1u:
					num = ((intPtr == IntPtr.Zero) ? 329242723 : 1906672512) ^ (int)(num2 * 56786663);
					continue;
				case 0u:
					break;
				case 2u:
					return false;
				default:
					return false;
				case 9u:
					throw new MissingMethodException("Unable to find the LdrUnloadDll function inside the specified process.");
				case 13u:
					throw new AccessViolationException("Unable to create thread in the specified process.");
				case 14u:
					throw new UnauthorizedAccessException("Unable to open the specified process for injection.");
				case 12u:
					return smethod_42(class93_0.method_19()).All(@class.method_1);
				}
				break;
			}
		}
	}

	internal static void smethod_104(AdvancedScrambleSettingsForm gform1_0, IEnumerable<AdvancedScrambleSettingsForm.Class32> ienumerable_0)
	{
		IEnumerator<AdvancedScrambleSettingsForm.Class32> enumerator = ienumerable_0.GetEnumerator();
		try
		{
			AdvancedScrambleSettingsForm.Class32 current = default(AdvancedScrambleSettingsForm.Class32);
			while (true)
			{
				int num = (enumerator.MoveNext() ? 852654070 : 898221549);
				while (true)
				{
					switch ((uint)(num ^ 0x5F1D1881) % 5u)
					{
					case 4u:
						num = 852654070;
						continue;
					case 2u:
						current.method_0().CheckedChanged += AdvancedScrambleSettingsForm.Class34._003C_003E9.method_0;
						current.method_0().Checked = (bool)current.method_2().GetValue(ApplicationSettings.Current.Options.Scramble);
						num = 900190036;
						continue;
					case 1u:
						current = enumerator.Current;
						current.method_0().Tag = current.method_2();
						num = 478735554;
						continue;
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
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_0111:
					int num2 = 70538159;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ 0x5F1D1881)) % 3)
						{
						case 1u:
							goto IL_00e1;
						default:
							goto end_IL_00f4;
						case 2u:
							break;
						case 0u:
							goto end_IL_00f4;
						}
						goto IL_0111;
						IL_00e1:
						enumerator.Dispose();
						num2 = ((int)num3 * -1851722162) ^ 0x3A5E1378;
						continue;
						end_IL_00f4:
						break;
					}
					break;
				}
			}
		}
	}

	internal static void smethod_105(ushort ushort_0, Class53 class53_0)
	{
		smethod_308(2L, ushort_0, class53_0);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool TerminateProcess(IntPtr intptr_0, int int_0);

	[DllImport("user32.dll")]
	internal static extern uint GetClassLong(IntPtr intptr_0, int int_0);

	internal static bool smethod_106(Class179.Class181 class181_0)
	{
		return class181_0.int_0 == class181_0.int_1;
	}

	internal static void smethod_107(GClass4 gclass4_0)
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

	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationProcess", SetLastError = true)]
	internal static extern uint NtQueryInformationProcess_1(IntPtr intptr_0, Class124.Enum26 enum26_0, out IntPtr intptr_1, int int_0, out int int_1);

	[DllImport("kernel32")]
	internal static extern bool MoveFileEx(string string_0, string string_1, int int_0);

	[DllImport("kernel32.dll")]
	internal static extern bool GetThreadContext(IntPtr intptr_0, ref Class124.Struct54 struct54_0);

	[DllImport("shell32.dll")]
	internal static extern void DragFinish(IntPtr intptr_0);

	internal static void smethod_108(Class83 class83_0, IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	internal static bool smethod_109(GClass1 gclass1_0)
	{
		return !gclass1_0.method_10();
	}

	internal static void smethod_110(Class57 class57_0, Class59 class59_0, Class53 class53_0)
	{
		smethod_137(class53_0, Enum7.const_64, class59_0, class57_0);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetExitCodeProcess(IntPtr intptr_0, out uint uint_0);

	internal static void ToggleModuleEnabled(MainForm mainForm, int int_0)
	{
		if (int_0 < 0 || int_0 >= mainForm.moduleGrid.Rows.Count)
		{
			return;
		}

		DataGridViewRow row = mainForm.moduleGrid.Rows[int_0];
		bool enabled = !(bool)row.Cells[0].Value;
		row.Cells[0].Value = enabled;
		((MainForm.ModuleRow)row.Tag).Entry.Enabled = enabled;
		ApplicationSettings.Save();
	}

	internal static void smethod_112(Class47.Enum6 enum6_0, Class57 class57_0, Class47 class47_0)
	{
		Class63[] array = new Class63[2]
		{
			Class49.class63_38,
			Class49.class63_39
		};
		while (true)
		{
			int num = -571977475;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1910256609)) % 7)
				{
				case 3u:
					num = ((smethod_219(class57_0).intptr_0 == IntPtr.Zero) ? 759899138 : 245411398) ^ (int)(num2 * 1099436875);
					continue;
				case 2u:
					num = ((enum6_0 >= Class47.Enum6.const_2) ? 1260589441 : 1124186668) ^ ((int)num2 * -76952853);
					continue;
				case 1u:
					smethod_298(class47_0.class53_0, class57_0);
					num = -1271876836;
					continue;
				default:
					return;
				case 0u:
					break;
				case 4u:
					smethod_306(class47_0.class53_0, array[(int)enum6_0], class57_0);
					return;
				case 5u:
					return;
				case 6u:
					smethod_164(class47_0.class53_0, array[(int)enum6_0], array[(int)enum6_0]);
					return;
				}
				break;
			}
		}
	}

	internal static Class154 smethod_113(GClass4 gclass4_0)
	{
		return gclass4_0.class154_0;
	}

	internal static void smethod_114(DependencyInstallerForm form3_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DependencyInstallerForm));
		while (true)
		{
			int num = -1329755379;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -979035706)) % 21)
				{
				case 20u:
					form3_0.label_0.Location = new Point(9, 9);
					num = (int)((num2 * 2009780718) ^ 0x3867E425);
					continue;
				case 19u:
					form3_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = ((int)num2 * -1282692137) ^ -1303994145;
					continue;
				case 18u:
					form3_0.label_0.Size = new Size(170, 15);
					num = ((int)num2 * -471455698) ^ -900809572;
					continue;
				case 17u:
					form3_0.progressBar_0.TabIndex = 1;
					form3_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)(num2 * 1873902164) ^ -1065956977;
					continue;
				case 15u:
					form3_0.progressBar_0.Size = new Size(448, 23);
					num = ((int)num2 * -1120037884) ^ 0x1E20C1EA;
					continue;
				case 14u:
					form3_0.PerformLayout();
					num = ((int)num2 * -839804707) ^ 0x7407FEFB;
					continue;
				case 13u:
					form3_0.progressBar_0.Location = new Point(12, 29);
					form3_0.progressBar_0.Name = "mainProgressBar";
					num = (int)(num2 * 1727692378) ^ -1613471598;
					continue;
				case 12u:
					form3_0.label_0.Text = "Connecting to download link...";
					num = ((int)num2 * -1941043425) ^ 0x3A311E50;
					continue;
				case 11u:
					form3_0.MinimizeBox = false;
					form3_0.Name = "DepedencyDownloadForm";
					form3_0.Text = "Dependency Downloader";
					form3_0.FormClosing += form3_0.method_1;
					form3_0.Load += form3_0.method_0;
					num = ((int)num2 * -996366165) ^ -1124440156;
					continue;
				case 10u:
					form3_0.MaximizeBox = false;
					num = ((int)num2 * -1277922607) ^ 0x5514545F;
					continue;
				case 9u:
					form3_0.label_0.Name = "statusLabel";
					num = (int)(num2 * 1490536726) ^ -73512116;
					continue;
				case 8u:
					form3_0.AutoScaleMode = AutoScaleMode.Dpi;
					form3_0.ClientSize = new Size(472, 64);
					num = (int)(num2 * 2026145018) ^ -834500992;
					continue;
				case 7u:
					form3_0.label_0 = new System.Windows.Forms.Label();
					form3_0.progressBar_0 = new ProgressBar();
					num = ((int)num2 * -521283938) ^ -1814046910;
					continue;
				case 6u:
					form3_0.Controls.Add(form3_0.progressBar_0);
					num = (int)(num2 * 1548199136) ^ -1005340260;
					continue;
				case 5u:
					form3_0.label_0.Font = new Font("Segoe UI", 8.75f);
					num = ((int)num2 * -2034362869) ^ -847167609;
					continue;
				case 4u:
					form3_0.SuspendLayout();
					form3_0.label_0.AutoSize = true;
					num = (int)(num2 * 790717315) ^ -791956659;
					continue;
				case 3u:
					form3_0.label_0.TabIndex = 0;
					num = ((int)num2 * -1388110398) ^ -103091094;
					continue;
				case 2u:
					form3_0.ResumeLayout(performLayout: false);
					num = (int)(num2 * 1735870118) ^ -1375312663;
					continue;
				case 1u:
					form3_0.Controls.Add(form3_0.label_0);
					form3_0.Font = new Font("Segoe UI", 8.25f);
					form3_0.FormBorderStyle = FormBorderStyle.FixedSingle;
					num = ((int)num2 * -1309327633) ^ 0x5C2BF26C;
					continue;
				default:
					return;
				case 0u:
					break;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_115(Class53 class53_0)
	{
		class53_0.struct19_0.struct15_0.method_0();
		while (true)
		{
			int num = 1798072902;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2656FB73)) % 3)
				{
				case 1u:
					goto IL_0012;
				case 0u:
					break;
				default:
					class53_0.struct19_0.struct18_0.method_0();
					class53_0.struct19_0.uint_0 = 0u;
					return;
				}
				break;
				IL_0012:
				class53_0.struct19_0.struct17_0.method_0();
				class53_0.struct19_0.struct18_1.method_0();
				num = (int)((num2 * 883304366) ^ 0x5FC29636);
			}
		}
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsWindow(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern int SuspendThread(IntPtr intptr_0);

	internal static Class59 smethod_116(Class58 class58_0, long long_0, Class47 class47_0)
	{
		if (class47_0.bool_0)
		{
			while (true)
			{
				int num = -1243577564;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1205310931)) % 3)
					{
					case 2u:
						class47_0.class53_0.struct19_0.uint_2 |= 8u;
						num = (int)((num2 * 1185718550) ^ 0x48D00187);
						continue;
					case 0u:
						break;
					default:
						goto end_IL_0049;
					}
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
		return smethod_364(class58_0, long_0);
	}

	internal static int smethod_117(Type type_0)
	{
		if (!Class96.dictionary_0.TryGetValue(type_0, out var value))
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
						num = ((Class96.dictionary_0.Count == count2) ? 1408843307 : 389450692) ^ (int)(num2 * 2046695968);
						continue;
					case 3u:
						num = ((!Class96.dictionary_1.TryGetValue(type_0, out value)) ? 480763582 : 392920140) ^ (int)(num2 * 1794690250);
						continue;
					case 2u:
						count2 = Class96.dictionary_0.Count;
						count = Class96.dictionary_1.Count;
						RuntimeHelpers.RunClassConstructor(type_0.TypeHandle);
						num = ((int)num2 * -730663630) ^ -1029810517;
						continue;
					case 1u:
						num = ((Class96.dictionary_1.Count == count) ? 1835531670 : 358723004) ^ ((int)num2 * -2081947112);
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

	internal static void smethod_118(Class53 class53_0, IntPtr intptr_0)
	{
		smethod_308(IntPtr.Size, intptr_0, class53_0);
	}

	internal static void smethod_119(Class100 class100_0)
	{
		Class100 @class = class100_0.method_07D3();
		Class100 class2 = class100_0.method_07D2();
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

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, Class124.Enum28 enum28_0);

	internal static void smethod_120(IntPtr intptr_0)
	{
		Class169.Struct68[] array = Class169.smethod_0<Class169.Struct69, Class169.Struct68>(intptr_0);
		Class169.Struct68 struct2 = default(Class169.Struct68);
		int num4 = default(int);
		List<string> list = default(List<string>);
		string key = default(string);
		Class169.Struct66[] array2 = default(Class169.Struct66[]);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			int num = -585717459;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1270855648)) % 14)
				{
				case 13u:
					struct2 = array[num4];
					list = new List<string>();
					key = Marshal.PtrToStringUni(intptr_0.smethod_9(struct2.uint_0), (int)(struct2.uint_1 / 2)).ToLowerInvariant();
					num = -1115535436;
					continue;
				case 12u:
					num4++;
					num = ((int)num2 * -684277217) ^ -1465673307;
					continue;
				case 11u:
					num = (int)((num2 * 222551695) ^ 0x7A21D216);
					continue;
				case 10u:
					array2 = Class169.smethod_0<Class169.Struct67, Class169.Struct66>(intptr_0.smethod_9(struct2.uint_2));
					num3 = 0;
					num = ((int)num2 * -1842341550) ^ -177703831;
					continue;
				case 8u:
					list.Add(text);
					num = (int)((num2 * 1098606816) ^ 0x192C8D23);
					continue;
				case 7u:
					num4 = 0;
					num = ((int)num2 * -947305) ^ -1455671676;
					continue;
				case 6u:
					Class169.dictionary_0.Add(key, list);
					num = ((int)num2 * -1148062503) ^ -1068654486;
					continue;
				case 5u:
					num = ((num4 < array.Length) ? (-1695066901) : (-1748821778));
					continue;
				case 3u:
					num3++;
					num = -1027644468;
					continue;
				case 2u:
				{
					Class169.Struct66 @struct = array2[num3];
					text = Marshal.PtrToStringUni(intptr_0.smethod_9(@struct.uint_2), (int)(@struct.uint_3 / 2));
					num = (string.IsNullOrEmpty(text) ? (-975932701) : (-605064398));
					continue;
				}
				case 1u:
					num = (int)(num2 * 1753798652) ^ -616709968;
					continue;
				case 0u:
					num = ((num3 < array2.Length) ? (-1215215184) : (-1171686556));
					continue;
				default:
					return;
				case 9u:
					break;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_121(Class47 class47_0, Class57 class57_0, int int_0, bool bool_0)
	{
		Class63[] array = new Class63[4]
		{
			Class49.class63_54,
			Class49.class63_55,
			Class49.class63_61,
			Class49.class63_62
		};
		Class65[] array2 = new Class65[4]
		{
			Class49.class65_0,
			Class49.class65_1,
			Class49.class65_2,
			Class49.class65_3
		};
		bool flag = smethod_219(class57_0).intptr_0 == IntPtr.Zero;
		while (true)
		{
			int num = -644702325;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1514443797)) % 17)
				{
				case 16u:
					smethod_164(class47_0.class53_0, array[int_0], array[int_0]);
					num = (int)((num2 * 834807351) ^ 0x3CDF5A3F);
					continue;
				case 14u:
					smethod_306(class47_0.class53_0, Class49.class63_53, class57_0);
					num = -352165479;
					continue;
				case 12u:
					num = ((int_0 >= 4) ? (-124176856) : (-1661161595)) ^ (int)(num2 * 158674543);
					continue;
				case 11u:
					smethod_306(class47_0.class53_0, array[int_0], class57_0);
					num = -1795795489;
					continue;
				case 10u:
					num = (flag ? (-1905073565) : (-443665538));
					continue;
				case 8u:
					num = (bool_0 ? 1110974086 : 737571191) ^ ((int)num2 * -1589946831);
					continue;
				case 7u:
					smethod_164(class47_0.class53_0, Class49.class63_53, Class49.class63_53);
					num = (int)((num2 * 1717565688) ^ 0xAF29A59);
					continue;
				case 6u:
					num = ((!flag) ? (-1110369353) : (-1878756229)) ^ ((int)num2 * -1841662369);
					continue;
				case 5u:
					smethod_164(class47_0.class53_0, Class49.class63_53, Class49.class63_53);
					num = -1049273267;
					continue;
				case 4u:
					num = ((!flag) ? (-332630357) : (-63223526));
					continue;
				case 3u:
					smethod_306(class47_0.class53_0, Class49.class63_53, class57_0);
					num = (int)(num2 * 1089930465) ^ -389581548;
					continue;
				case 1u:
					num = ((int)num2 * -728698216) ^ 0x22BCA2FD;
					continue;
				case 15u:
					break;
				case 0u:
					smethod_68(class47_0.class53_0, array2[int_0], Class49.class63_53);
					return;
				case 2u:
					return;
				case 9u:
					return;
				default:
					smethod_75(class47_0.class53_0, smethod_238(Class49.class63_57, int_0 * 8), Class49.class63_53);
					return;
				}
				break;
			}
		}
	}

	internal static Enum13 smethod_122(Class76 class76_0)
	{
		return (Enum13)class76_0.struct40_0.enum23_0;
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

	[DllImport("psapi.dll", SetLastError = true)]
	internal static extern bool EnumProcessModulesEx(IntPtr intptr_0, IntPtr[] intptr_1, uint uint_0, out uint uint_1, uint uint_2);

	internal static ResourceManager smethod_124()
	{
		if (Class68.resourceManager_0 == null)
		{
			while (true)
			{
				int num = -137199806;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1265328685)) % 3)
					{
					case 1u:
						Class68.resourceManager_0 = new ResourceManager("\u0002.\u0005", typeof(Class68).Assembly);
						num = (int)((num2 * 1968674529) ^ 0x58308CB6);
						continue;
					case 0u:
						break;
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
		return Class68.resourceManager_0;
	}

	internal static Class57 smethod_125(ulong ulong_0)
	{
		if (!Class127.bool_0)
		{
			return new Class57((IntPtr)(int)ulong_0);
		}
		return new Class57((IntPtr)(long)ulong_0);
	}

	internal static Class59 smethod_126(Class58 class58_0, long long_0)
	{
		return smethod_161(4u, (IntPtr)long_0, class58_0);
	}

	internal static void smethod_127(Class57 class57_0, Class59 class59_0, Class53 class53_0)
	{
		smethod_137(class53_0, Enum7.const_266, class59_0, class57_0);
	}

	internal static bool smethod_128(Class89 class89_0, Exception exception_0)
	{
		class89_0.method_35(exception_0);
		return false;
	}

	internal static int smethod_129(Class93 class93_0, Class117 class117_0, IntPtr intptr_0)
	{
		Class106 @class = class117_0.method_0823().method_080D().method_07DF();
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
					num = ((!Class127.bool_5) ? (-1501176021) : (-376529140)) ^ ((int)num2 * -201121100);
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

	internal static int smethod_130(byte[] byte_0, int int_0, int int_1, Class179.Class180 class180_0)
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

	internal static List<Class152> smethod_131(GClass1 gclass1_0)
	{
		List<Class152> result = default(List<Class152>);
		if (gclass1_0.list_0 == null)
		{
			Stream0 stream = new Stream0(gclass1_0.gclass2_0, gclass1_0.method_0(), Enum15.const_0, gclass1_0.method_4());
			try
			{
				Class154 @class = Class6.smethod_2<Class8>(stream, bool_0: false, Enum39.const_1);
				try
				{
					if (@class.method_14() != null)
					{
						goto IL_0078;
					}
					while (true)
					{
						int num = -895623178;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ -866161837)) % 4)
							{
							case 1u:
								result = new List<Class152>();
								num = (int)((num2 * 36783674) ^ 0x67D99247);
								continue;
							case 0u:
								break;
							case 2u:
								goto end_IL_006c;
							default:
								goto IL_0078;
							}
							break;
						}
						continue;
						end_IL_006c:
						break;
					}
					goto end_IL_002e;
					IL_0078:
					gclass1_0.list_0 = new List<Class152>(@class.method_14().list_1);
					goto IL_010a;
					end_IL_002e:;
				}
				finally
				{
					if (@class != null)
					{
						while (true)
						{
							IL_00c5:
							int num3 = -408093656;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num3 ^ -866161837)) % 3)
								{
								case 2u:
									goto IL_0095;
								default:
									goto end_IL_00a8;
								case 0u:
									break;
								case 1u:
									goto end_IL_00a8;
								}
								goto IL_00c5;
								IL_0095:
								((IDisposable)@class).Dispose();
								num3 = (int)((num2 * 488368625) ^ 0x7C1C473);
								continue;
								end_IL_00a8:
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
						IL_0102:
						int num4 = -1670227128;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num4 ^ -866161837)) % 3)
							{
							case 2u:
								goto IL_00d2;
							default:
								goto end_IL_00e5;
							case 0u:
								break;
							case 1u:
								goto end_IL_00e5;
							}
							goto IL_0102;
							IL_00d2:
							((IDisposable)stream).Dispose();
							num4 = ((int)num2 * -882439963) ^ 0xF27D980;
							continue;
							end_IL_00e5:
							break;
						}
						break;
					}
				}
			}
			goto IL_016b;
		}
		goto IL_016d;
		IL_016d:
		return gclass1_0.list_0;
		IL_010a:
		if (!gclass1_0.gclass2_0.dictionary_0.ContainsKey(gclass1_0))
		{
			while (true)
			{
				int num5 = -713425170;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num5 ^ -866161837)) % 4)
					{
					case 1u:
						gclass1_0.gclass2_0.dictionary_0.Add(gclass1_0, gclass1_0.list_0);
						num5 = ((int)num2 * -312428016) ^ 0x455B1;
						continue;
					case 0u:
						break;
					default:
						goto end_IL_0164;
					case 2u:
						goto IL_016d;
					}
					break;
				}
				continue;
				end_IL_0164:
				break;
			}
			goto IL_016b;
		}
		goto IL_016d;
		IL_016b:
		return result;
	}

	internal static void smethod_132(Class179.Class182 class182_0, int int_0, int int_1)
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

	internal static bool smethod_133(Class129 class129_0, Class117 class117_0, IntPtr intptr_0)
	{
		Class106 @class = class117_0.method_0823().method_080D().method_07DF();
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

	internal static bool smethod_134(Class62 class62_0, Class62 class62_1)
	{
		if (class62_1 == null)
		{
			goto IL_0036;
		}
		goto IL_0070;
		IL_0036:
		int num = -1249018911;
		goto IL_003b;
		IL_003b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1006511978)) % 6)
			{
			case 1u:
				num = ((class62_0 != null) ? (-2137661679) : (-1684772406)) ^ ((int)num2 * -1567517001);
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0070;
			default:
				return class62_1.Equals(class62_0);
			case 4u:
				return false;
			case 5u:
				return true;
			}
			break;
		}
		goto IL_0036;
		IL_0070:
		num = ((class62_1 == null) ? (-1598677240) : (-825412133));
		goto IL_003b;
	}

	internal static long smethod_135(Class154 class154_0, uint uint_0)
	{
		return class154_0.interface3_0.imethod_0(class154_0, uint_0);
	}

	internal static bool smethod_136(ref string string_0, IntPtr intptr_0)
	{
		if (string_0.EndsWith(".dll"))
		{
			goto IL_0128;
		}
		goto IL_023d;
		IL_0128:
		int num = -1687434913;
		goto IL_01ee;
		IL_01ee:
		Class124.Struct43 struct43_ = default(Class124.Struct43);
		Class124.Struct43 struct43_4 = default(Class124.Struct43);
		Class124.Struct43 struct43_3 = default(Class124.Struct43);
		Class124.Struct43 struct43_2 = default(Class124.Struct43);
		IntPtr intptr_2 = default(IntPtr);
		IntPtr intptr_1 = default(IntPtr);
		IntPtr intPtr = default(IntPtr);
		Class124.Struct43 @struct = default(Class124.Struct43);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1561278483)) % 15)
			{
			case 14u:
				string_0 = string_0.Substring(0, string_0.Length - 4);
				num = ((int)num2 * -1191010174) ^ 0x5B8D9174;
				continue;
			case 12u:
			{
				uint num3 = RtlDosApplyFileIsolationRedirection_Ustr(1u, ref struct43_, ref struct43_4, ref struct43_3, ref struct43_2, ref intptr_2, IntPtr.Zero, UIntPtr.Zero, UIntPtr.Zero);
				if (intptr_1 != IntPtr.Zero && intptr_0 != Class124.intptr_0)
				{
					DeactivateActCtx(0, intptr_1);
				}
				if (num3 == 0)
				{
					num = -1071638081;
					continue;
				}
				goto case 2u;
			}
			case 2u:
				RtlFreeUnicodeString(ref struct43_2);
				num = -434694695;
				continue;
			case 11u:
				Marshal.FreeHGlobal(intPtr);
				num = -662153495;
				continue;
			case 10u:
				string_0 = ((Class124.Struct43)Marshal.PtrToStructure(intptr_2, typeof(Class124.Struct43))/*cast due to constrained. prefix*/).ToString();
				num = ((int)num2 * -1053629383) ^ -403682609;
				continue;
			case 9u:
				struct43_3 = @struct;
				intptr_1 = IntPtr.Zero;
				num = ((!(intptr_0 != Class124.intptr_0)) ? (-790145851) : (-867222926)) ^ (int)(num2 * 34226057);
				continue;
			case 8u:
				break;
			case 7u:
				intPtr = Marshal.AllocHGlobal(255);
				num = ((int)num2 * -1730467390) ^ -814694156;
				continue;
			case 6u:
				string_0 += ".dll";
				num = (int)(num2 * 766421706) ^ -257120379;
				continue;
			case 5u:
				intptr_2 = IntPtr.Zero;
				num = -1054105669;
				continue;
			case 4u:
				RtlInitUnicodeString(out struct43_, string_0);
				RtlInitUnicodeString(out struct43_2, "");
				num = (int)((num2 * 1557584949) ^ 0x4AFDE9FA);
				continue;
			case 3u:
				@struct = new Class124.Struct43
				{
					intptr_0 = intPtr,
					ushort_1 = 255
				};
				num = (int)(num2 * 1420723249) ^ -1926440808;
				continue;
			case 0u:
				ActivateActCtx(intptr_0, out intptr_1);
				num = (int)((num2 * 626244533) ^ 0x3369D96);
				continue;
			case 13u:
				goto IL_023d;
			default:
				return false;
			}
			break;
		}
		goto IL_0128;
		IL_023d:
		RtlInitUnicodeString(out struct43_4, ".dll");
		num = -555189863;
		goto IL_01ee;
	}

	internal static void smethod_137(Class53 class53_0, Enum7 enum7_0, Class56 class56_0, Class56 class56_1)
	{
		if (Class49.bool_0)
		{
			goto IL_0007;
		}
		goto IL_002b;
		IL_0007:
		int num = 595926341;
		goto IL_000c;
		IL_000c:
		switch ((uint)(num ^ 0x2BD36C38) % 4u)
		{
		case 3u:
			break;
		default:
			return;
		case 2u:
			goto IL_002b;
		case 0u:
			return;
		case 1u:
			Class52.smethod_15()(ref class53_0.struct19_0, enum7_0, class56_0, class56_1);
			return;
		}
		goto IL_0007;
		IL_002b:
		Class52.smethod_8()(ref class53_0.struct19_0, enum7_0, class56_0, class56_1);
		num = 1496366956;
		goto IL_000c;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool TerminateThread(IntPtr intptr_0, int int_0);

	internal static object smethod_138(ExportParameter class17_0)
	{
		if (class17_0.Type != Enum5.LPCSTR)
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
						num = ((class17_0.Type == Enum5.LPCWSTR) ? (-1735061705) : (-489017136)) ^ (int)(num2 * 25929941);
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
					num = ((class17_0.Type == Enum5.BYTE) ? (-156496262) : (-401896299));
					continue;
					IL_0032:
					num = ((class17_0.Type != Enum5.FLOAT) ? (-1524535812) : (-1745716555));
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

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr LoadLibrary(string string_0);

	internal static bool smethod_139(ref string string_0, [Out] ModuleOptionsForm form0_0, string string_1)
	{
		if (!string_1.StartsWith("0x"))
		{
			while (true)
			{
				int num = 63086030;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x6D48C3FC)) % 4)
					{
					case 2u:
						num = ((!string_1.StartsWith("&H")) ? (-1365823868) : (-2030242627)) ^ ((int)num2 * -1865959600);
						continue;
					case 3u:
						break;
					default:
						string_0 = string_1;
						return false;
					case 1u:
						goto end_IL_0066;
					}
					break;
				}
				continue;
				end_IL_0066:
				break;
			}
		}
		string_0 = string_1.Substring(2);
		return true;
	}

	internal static bool smethod_140(Class91 class91_0, Class53 class53_0)
	{
		return smethod_239(class53_0, class91_0);
	}

	internal static void smethod_141(Class179.Class181 class181_0)
	{
		class181_0.uint_0 >>= class181_0.int_2 & 7;
		class181_0.int_2 &= -8;
	}

	[DllImport("ntdll.dll")]
	internal static extern void RtlFreeUnicodeString(ref Class124.Struct43 struct43_0);

	internal static IntPtr smethod_142(Class90 class90_0, IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, out Class124.Struct54 struct54_0, out int int_0, out int int_1, ref int int_2)
	{
		struct54_0 = default(Class124.Struct54);
		int_0 = 0;
		int_1 = 0;
		Class53 @class = new Class53();
		@class.method_1(bool_1: true);
		Class53 class2 = @class;
		Class58 class58_ = smethod_48(class2);
		Class63 class63_ = default(Class63);
		Class63[] array = default(Class63[]);
		Class58 class58_4 = default(Class58);
		Class63 class63_2 = default(Class63);
		Class63 class63_3 = default(Class63);
		Class58 class58_5 = default(Class58);
		Class59 class59_ = default(Class59);
		int num3 = default(int);
		Class63[] array2 = default(Class63[]);
		Class58 class58_3 = default(Class58);
		Class58 class58_2 = default(Class58);
		while (true)
		{
			int num = -2048418765;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2057354372)) % 30)
				{
				case 29u:
					smethod_173(class2);
					num = ((int)num2 * -1435349910) ^ -1852544493;
					continue;
				case 28u:
					class63_ = array.smethod_2();
					num = ((int)num2 * -1394858336) ^ -1624765270;
					continue;
				case 27u:
					smethod_298(class2, smethod_374(struct54_0.uint_17));
					num = (int)((num2 * 2085609091) ^ 0x6D5AFA4B);
					continue;
				case 25u:
					smethod_53(class2);
					smethod_347(class2);
					smethod_200(class2, 4u);
					num = (int)(num2 * 611504890) ^ -533582899;
					continue;
				case 24u:
					class2.struct19_0.uint_2 |= 8u;
					num = (int)((num2 * 1478971600) ^ 0x14C4C891);
					continue;
				case 23u:
					smethod_36(class2, class58_);
					num = ((int)num2 * -398182065) ^ -1867424194;
					continue;
				case 22u:
					smethod_82(class2, class63_);
					num = ((int)num2 * -2038543312) ^ -1998734664;
					continue;
				case 21u:
					class58_4 = smethod_48(class2);
					num = ((int)num2 * -615381917) ^ -719376932;
					continue;
				case 20u:
					smethod_310(class63_2, class63_3, class2);
					smethod_91(class58_5, Enum12.const_0, class2);
					num = (int)(num2 * 69512701) ^ -287439830;
					continue;
				case 19u:
					class59_ = smethod_126(class58_4, 0L);
					num = ((int)num2 * -1534160978) ^ 0x5B3D3D8A;
					continue;
				case 18u:
					smethod_306(class2, array[num3], new Class57(intptr_1));
					num = ((int)num2 * -202348127) ^ -612259958;
					continue;
				case 17u:
					smethod_372(array2[num3], class2);
					class2.struct19_0.uint_2 |= 8u;
					smethod_75(class2, smethod_126(class58_3, 0L), Class49.class63_37);
					class63_2 = Class49.class63_37;
					class63_3 = Class49.class63_37;
					num = ((int)num2 * -560529742) ^ 0x4AD43C96;
					continue;
				case 16u:
					class2.struct19_0.uint_2 |= 8u;
					smethod_75(class2, smethod_126(class58_2, 0L), Class49.class63_37);
					num = (int)((num2 * 339217226) ^ 0x796D8914);
					continue;
				case 15u:
					smethod_320(class2, byte_0);
					num = (int)(num2 * 1936125983) ^ -482241611;
					continue;
				case 14u:
					smethod_36(class2, class58_5);
					num = (int)((num2 * 344720032) ^ 0x70A3F4D);
					continue;
				case 13u:
					class2.struct19_0.uint_2 |= 8u;
					num = ((int)num2 * -2043439191) ^ 0x6DBB7510;
					continue;
				case 12u:
					smethod_372(array2[num3], class2);
					num = ((int)num2 * -213602687) ^ 0x60F4A12E;
					continue;
				case 11u:
					class58_3 = smethod_48(class2);
					class58_2 = smethod_48(class2);
					class58_5 = smethod_48(class2);
					num = ((int)num2 * -722958491) ^ -1086788480;
					continue;
				case 10u:
					num3 = array.smethod_3();
					num = ((int)num2 * -597646032) ^ -617822571;
					continue;
				case 8u:
					int_1 = smethod_252(class2);
					smethod_439(class2, 0u);
					smethod_36(class2, class58_4);
					num = (int)(num2 * 1086304263) ^ -523408708;
					continue;
				case 7u:
					array2 = new Class63[7]
					{
						Class49.class63_69,
						Class49.class63_72,
						Class49.class63_71,
						Class49.class63_70,
						Class49.class63_76,
						Class49.class63_74,
						Class49.class63_60
					};
					num = (int)((num2 * 627800004) ^ 0x1B91A11C);
					continue;
				case 6u:
					smethod_94(class2);
					num = (int)(num2 * 499716291) ^ -150531643;
					continue;
				case 5u:
					smethod_306(class2, array[num3], new Class57(intptr_0));
					num = (int)(num2 * 1433490231) ^ -1859193754;
					continue;
				case 4u:
					int_0 = smethod_252(class2);
					num = (int)(num2 * 550792982) ^ -124544148;
					continue;
				case 3u:
					smethod_263(class2, class63_, smethod_126(class58_, 0L));
					num = ((int)num2 * -410680118) ^ 0x3E272308;
					continue;
				case 2u:
				{
					Class57 class57_ = smethod_167(1);
					smethod_127(class57_, class59_, class2);
					smethod_55(class2);
					num = ((int)num2 * -2063622367) ^ -2002027075;
					continue;
				}
				case 1u:
					array = new Class63[7]
					{
						Class49.class63_37,
						Class49.class63_40,
						Class49.class63_39,
						Class49.class63_38,
						Class49.class63_44,
						Class49.class63_42,
						Class49.class63_59
					};
					num = ((int)num2 * -2011828964) ^ 0x4B25FBAD;
					continue;
				case 0u:
					smethod_200(class2, 4u);
					smethod_36(class2, class58_2);
					int_2 = smethod_252(class2);
					smethod_439(class2, 0u);
					smethod_200(class2, 4u);
					smethod_36(class2, class58_3);
					num = (int)((num2 * 1761900705) ^ 0x32B12E56);
					continue;
				case 9u:
					break;
				default:
					smethod_439(class2, 0u);
					return smethod_61(class2, class90_0);
				}
				break;
			}
		}
	}

	internal static void smethod_143(byte[] byte_0, byte[] byte_1, GClass4 gclass4_0)
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

	internal static byte[] smethod_144(Class166 class166_0, int int_0)
	{
		return class166_0.class5_0.ReadBytes(int_0);
	}

	internal static void smethod_145(ProcessSelectorForm form5_0)
	{
		form5_0.dataGridView_0.Rows.Clear();
		GClass2 gClass = default(GClass2);
		Class77 @class = default(Class77);
		Class77[] array = default(Class77[]);
		int num3 = default(int);
		int index = default(int);
		string text = default(string);
		Icon icon = default(Icon);
		Bitmap bitmap = default(Bitmap);
		while (true)
		{
			int num = 1363494530;
			while (true)
			{
				uint num2;
				Bitmap bitmap2;
				switch ((num2 = (uint)(num ^ 0x7F2B8557)) % 15)
				{
				case 14u:
					gClass = smethod_47(@class.method_2());
					num = ((gClass != null) ? 138933608 : 1386967852) ^ ((int)num2 * -1913677816);
					continue;
				case 13u:
					@class = array[num3];
					num = 904475238;
					continue;
				case 12u:
					num = (int)((num2 * 407335046) ^ 0x7809DD94);
					continue;
				case 10u:
					form5_0.dataGridView_0.Rows[index].Tag = gClass;
					num = (int)(num2 * 795412755) ^ -1266468621;
					continue;
				case 9u:
					array = smethod_413();
					num = ((int)num2 * -302315363) ^ 0x63399414;
					continue;
				case 7u:
					num = ((text.Length == 0) ? (-1643091981) : (-548535499)) ^ (int)(num2 * 1158990031);
					continue;
				case 6u:
					num = ((num3 >= array.Length) ? 2133218206 : 584770980);
					continue;
				case 5u:
					text = smethod_331(@class);
					num = (smethod_287(@class) ? (-502967497) : (-958519747)) ^ ((int)num2 * -1951646455);
					continue;
				case 4u:
					num3++;
					num = 1104253328;
					continue;
				case 3u:
					bitmap2 = smethod_100(icon);
					goto IL_0149;
				case 2u:
					num3 = 0;
					num = (int)((num2 * 930748759) ^ 0x41F7014F);
					continue;
				case 1u:
					icon = smethod_274(@class);
					if (icon != null)
					{
						num = (int)((num2 * 1603632467) ^ 0x7548CF7A);
						continue;
					}
					bitmap2 = new Bitmap(22, 22);
					goto IL_0149;
				case 0u:
					index = form5_0.dataGridView_0.Rows.Add(bitmap, string.Format("{0:X8}-{1}", @class.method_2(), text));
					num = ((int)num2 * -12646959) ^ 0x702D7BC;
					continue;
				default:
					return;
				case 11u:
					break;
				case 8u:
					return;
					IL_0149:
					bitmap = bitmap2;
					num = 487409361;
					continue;
				}
				break;
			}
		}
	}

	internal static IntPtr smethod_146(IntPtr intptr_0, IntPtr intptr_1, bool bool_0, Class83 class83_0)
	{
		if (Class127.bool_1)
		{
			goto IL_003d;
		}
		goto IL_01b2;
		IL_003d:
		int num = -113995873;
		goto IL_0161;
		IL_0161:
		IntPtr intptr_2 = default(IntPtr);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -425249148)) % 12)
			{
			case 11u:
				NtSetInformationThread(intptr_2, Class124.Enum25.const_17, IntPtr.Zero, 0);
				num = ((int)num2 * -1356163893) ^ -1196351519;
				continue;
			case 10u:
				break;
			case 8u:
				intptr_2 = CreateRemoteThread(class83_0.method_2(), IntPtr.Zero, UIntPtr.Zero, intptr_1, intptr_0, 0u, IntPtr.Zero);
				num = -71825487;
				continue;
			case 6u:
				num = (int)((num2 * 1973600605) ^ 0xD113F33);
				continue;
			case 4u:
				ResumeThread(intptr_2);
				num = (int)((num2 * 1549463048) ^ 0x7168FE2E);
				continue;
			case 3u:
				goto IL_009a;
			case 2u:
				num = ((!Class127.bool_3) ? (-717832740) : (-1540611496)) ^ (int)(num2 * 1623421764);
				continue;
			case 1u:
				num = ((!(intptr_2 != IntPtr.Zero)) ? (-477428475) : (-1222377497)) ^ (int)(num2 * 525971060);
				continue;
			case 0u:
				intptr_2 = CreateRemoteThread(class83_0.method_2(), IntPtr.Zero, UIntPtr.Zero, intptr_1, intptr_0, 4u, IntPtr.Zero);
				num = ((int)num2 * -1425589997) ^ 0xE8D4299;
				continue;
			case 7u:
				goto IL_01b2;
			case 5u:
				return intptr_2;
			default:
				return intptr_2;
			}
			break;
			IL_009a:
			num = ((NtCreateThreadEx(out intptr_2, 2097151u, IntPtr.Zero, class83_0.method_2(), intptr_1, intptr_0, bool_0 ? 4u : 0u, 0u, 0u, 0u, IntPtr.Zero) == 0) ? (-583039335) : (-2138671661));
		}
		goto IL_003d;
		IL_01b2:
		num = (bool_0 ? (-1064599342) : (-2005029628));
		goto IL_0161;
	}

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern int GetWindowThreadProcessId(IntPtr intptr_0, out int int_0);

	internal static string smethod_147(string string_0)
	{
		string path = default(string);
		while (true)
		{
			string text = Path.GetTempPath();
			Guid guid = Guid.NewGuid();
			while (true)
			{
				int num = 1511678773;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x76B67B7C)) % 4)
					{
					case 3u:
						goto IL_0006;
					case 1u:
						path = guid.ToString().Replace("-", "").Substring(0, Class127.random_0.Next(5, 10)) + string_0;
						num = ((int)num2 * -881411269) ^ 0x66511EA0;
						continue;
					case 2u:
						break;
					default:
						return text;
					}
					break;
					IL_0006:
					if (File.Exists(text = Path.Combine(text, path)))
					{
						goto end_IL_0096;
					}
					num = (int)(num2 * 1223951643) ^ -1475314967;
				}
				continue;
				end_IL_0096:
				break;
			}
		}
	}

	internal static GClass2[] smethod_148(string string_0, bool bool_0)
	{
		List<GClass2> list = new List<GClass2>();
		int num3 = default(int);
		GClass2[] array = default(GClass2[]);
		string text = default(string);
		GClass2 gClass = default(GClass2);
		while (true)
		{
			int num = -1797034305;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -384576450)) % 14)
				{
				case 13u:
					num = ((num3 < array.Length) ? (-344784802) : (-1824232147));
					continue;
				case 12u:
					num = (text.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) ? (-1778225723) : (-513210659)) ^ ((int)num2 * -296238362);
					continue;
				case 11u:
					num = (bool_0 ? (-455249756) : (-1808222077)) ^ ((int)num2 * -598137637);
					continue;
				case 10u:
					num = (int)((num2 * 653959725) ^ 0x7D353A8B);
					continue;
				case 9u:
					num = ((!text.Equals(string_0, StringComparison.OrdinalIgnoreCase)) ? (-1243497508) : (-1488624278));
					continue;
				case 8u:
					num3 = 0;
					num = (int)((num2 * 17857332) ^ 0x77DA5924);
					continue;
				case 7u:
					text = gClass.method_2();
					num = (int)(num2 * 484229070) ^ -1986312089;
					continue;
				case 6u:
					list.Add(gClass);
					num = ((int)num2 * -1850663936) ^ 0x1F988BDC;
					continue;
				case 4u:
					gClass = array[num3];
					num = -49339547;
					continue;
				case 3u:
					text = text.Substring(0, text.Length - 4);
					num = ((int)num2 * -1406809422) ^ 0x1021363;
					continue;
				case 1u:
					array = smethod_155();
					num = (int)(num2 * 737029593) ^ -559464653;
					continue;
				case 0u:
					num3++;
					num = -287538359;
					continue;
				case 2u:
					break;
				default:
					return list.ToArray();
				}
				break;
			}
		}
	}

	internal static void smethod_149(Enum7 enum7_0, Class58 class58_0, Class53 class53_0, Enum12 enum12_0)
	{
		if (Class49.bool_0)
		{
			goto IL_002b;
		}
		goto IL_0055;
		IL_002b:
		int num = 597276120;
		goto IL_0030;
		IL_0030:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x728D9C89)) % 5)
			{
			case 3u:
				Class52.smethod_41()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
				num = (int)(num2 * 756304326) ^ -2006243969;
				continue;
			case 2u:
				break;
			default:
				return;
			case 1u:
				goto IL_0055;
			case 0u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_002b;
		IL_0055:
		Class52.smethod_39()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
		num = 287275651;
		goto IL_0030;
	}

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	[DllImport("psapi.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EnumProcessModules(IntPtr intptr_0, [Out][MarshalAs(UnmanagedType.LPArray)] IntPtr[] intptr_1, uint uint_0, out uint uint_1);

	internal static void smethod_150(Class56 class56_0, Class56.Struct12 struct12_0)
	{
		class56_0.method_1(Class56.smethod_0<Class56.Struct12, Class56.Struct7>(struct12_0));
	}

	internal static bool smethod_151(Class77 class77_0)
	{
		if (!(class77_0.method_0() == IntPtr.Zero))
		{
			int int_ = default(int);
			while (true)
			{
				int num = 317222210;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7A4AFE37)) % 6)
					{
					case 5u:
						num = ((!IsWindow(class77_0.method_0())) ? (-1888454681) : (-1210580712)) ^ (int)(num2 * 997723809);
						continue;
					case 2u:
						class77_0.method_4(GetWindowThreadProcessId(class77_0.method_0(), out int_));
						num = 1704812998;
						continue;
					case 1u:
						class77_0.method_3(int_);
						num = (int)((num2 * 1420060104) ^ 0x424A36F1);
						continue;
					case 0u:
						break;
					default:
						return true;
					case 3u:
						goto end_IL_009f;
					}
					break;
				}
				continue;
				end_IL_009f:
				break;
			}
		}
		return false;
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

	internal static bool smethod_153(Class83 class83_0, IntPtr intptr_0, int int_0)
	{
		return WaitForSingleObject(intptr_0, (int_0 == -1) ? uint.MaxValue : ((uint)int_0)) == 0;
	}

	[DllImport("shell32.dll")]
	internal static extern uint DragQueryFile(IntPtr intptr_0, uint uint_0, [Out] StringBuilder stringBuilder_0, uint uint_1);

	internal static MainForm.ModuleRow[] GetEnabledModuleRows(MainForm mainForm)
	{
		return mainForm.moduleGrid.Rows
			.Cast<DataGridViewRow>()
			.Select(row => (MainForm.ModuleRow)row.Tag)
			.Where(module => module.Entry.Enabled)
			.ToArray();
	}

	internal static GClass2[] smethod_155()
	{
		uint num = 0u;
		uint num5 = default(uint);
		uint num6 = default(uint);
		GClass2 gClass = default(GClass2);
		uint[] array = default(uint[]);
		uint num4 = default(uint);
		List<GClass2> list = default(List<GClass2>);
		uint uint_ = default(uint);
		while (true)
		{
			int num2 = -916512996;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1275962191)) % 15)
				{
				case 14u:
					num2 = ((num5 < num6) ? (-226235777) : (-367053465));
					continue;
				case 13u:
					num5++;
					num2 = -387749309;
					continue;
				case 12u:
					num2 = ((int)num3 * -1716113736) ^ 0x47080EB3;
					continue;
				case 11u:
					gClass = new GClass2(array[num5]);
					num2 = -1933701878;
					continue;
				case 10u:
					num4 = 0u;
					list = new List<GClass2>
					{
						Capacity = 0
					};
					num2 = ((int)num3 * -1430066918) ^ -784867021;
					continue;
				case 9u:
					num6 = uint_ / 4;
					num2 = ((int)num3 * -503568540) ^ 0x45B35F2D;
					continue;
				case 8u:
					EnumProcesses(array, num4, out uint_);
					num2 = (int)(num3 * 1565712766) ^ -1773526658;
					continue;
				case 7u:
					num5 = num - 1024;
					num2 = (int)((num3 * 1730369987) ^ 0x79EAC26C);
					continue;
				case 5u:
					num += 1024;
					array = new uint[num];
					num4 = (uint)(array.Length * 4);
					num2 = -431663925;
					continue;
				case 4u:
					list.Add(gClass);
					num2 = ((int)num3 * -997331693) ^ -24072470;
					continue;
				case 2u:
					num2 = (smethod_102(gClass) ? 868553410 : 833166873) ^ (int)(num3 * 1444445929);
					continue;
				case 1u:
					list.Capacity += (int)num6;
					num2 = ((int)num3 * -458021860) ^ -1089709196;
					continue;
				case 0u:
					num2 = ((num4 == uint_) ? (-497993605) : (-210126297)) ^ ((int)num3 * -842244729);
					continue;
				case 3u:
					break;
				default:
					return list.ToArray();
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll")]
	internal static extern bool Thread32First(IntPtr intptr_0, ref Class124.Struct44 struct44_0);

	internal static void smethod_156(Stream0 stream0_0)
	{
		if (!stream0_0.bool_0)
		{
			throw new ObjectDisposedException(null, "Can not access a closed Stream.");
		}
	}

	internal static void smethod_157(Class5 class5_0, long long_0)
	{
		class5_0.BaseStream.Position = long_0;
	}

	internal static void ShowInjectionError(MainForm mainForm, string message, Exception exception)
	{
		mainForm.Invoke((MethodInvoker)delegate
		{
			MessageBox.Show(
				mainForm,
				smethod_345(message, exception, bool_0: true),
				"Extreme Injector v3",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation);
		});
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern uint WaitForSingleObject(IntPtr intptr_0, uint uint_0);

	internal static void smethod_159(Class165 class165_0)
	{
		Class159 @class = class165_0.class154_0.method_6().method_1();
		while (true)
		{
			int num = -11103572;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -951192336)) % 7)
				{
				case 6u:
					class165_0.binaryWriter_0.Write(@class.method_4());
					num = (int)((num2 * 41769899) ^ 0x4143AB9C);
					continue;
				case 4u:
					class165_0.binaryWriter_0.Write(@class.method_2());
					num = ((int)num2 * -1654486217) ^ 0x4D6475D4;
					continue;
				case 3u:
					class165_0.binaryWriter_0.Write(@class.method_8());
					class165_0.binaryWriter_0.Write(@class.method_10());
					num = (int)((num2 * 114485687) ^ 0x4A5D6A2C);
					continue;
				case 1u:
					class165_0.binaryWriter_0.Write((ushort)@class.method_0());
					@class.method_3((ushort)class165_0.class154_0.method_8().Count);
					num = ((int)num2 * -321670666) ^ -1852362774;
					continue;
				case 0u:
					class165_0.binaryWriter_0.Write(@class.method_6());
					num = ((int)num2 * -1543656515) ^ 0x64D75037;
					continue;
				case 2u:
					break;
				default:
					class165_0.binaryWriter_0.Write((ushort)@class.method_12());
					return;
				}
				break;
			}
		}
	}

	internal static Class167 smethod_160(Class154 class154_0, Class5 class5_0)
	{
		Class157 @class = class154_0.method_6().method_3().imethod_49()[9];
		if (@class.method_0() != 0)
		{
			long num3 = default(long);
			while (true)
			{
				int num = -1969361044;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -778437864)) % 10)
					{
					case 7u:
						num = ((num3 != -1L) ? 1382265114 : 728438419) ^ ((int)num2 * -2077078811);
						continue;
					case 6u:
						num = ((@class.method_2() != 0) ? 32689746 : 616889365) ^ (int)(num2 * 268919682);
						continue;
					case 4u:
						num3 = smethod_135(class154_0, @class.method_0());
						num = -323609743;
						continue;
					case 1u:
						num = (class5_0.imethod_0(num3) ? (-1954671987) : (-1700156455)) ^ (int)(num2 * 1061795529);
						continue;
					case 0u:
						break;
					case 2u:
						goto end_IL_00e3;
					case 5u:
						return null;
					case 8u:
						return null;
					default:
						smethod_157(class5_0, num3);
						return new Class167(class5_0, class154_0);
					case 3u:
						goto end_IL_011d;
					}
					num = (class5_0.imethod_0(num3 + @class.method_2()) ? (-216356153) : (-1294962737));
					continue;
					end_IL_00e3:
					break;
				}
				continue;
				end_IL_011d:
				break;
			}
		}
		return null;
	}

	internal static Class59 smethod_161(uint uint_0, IntPtr intptr_0, Class58 class58_0)
	{
		Class59 @class = new Class59();
		Class52.smethod_51()(@class, class58_0, intptr_0, uint_0);
		return @class;
	}

	[DllImport("kernel32.dll")]
	internal static extern bool SetThreadContext(IntPtr intptr_0, IntPtr intptr_1);

	internal static List<Class164> smethod_162(Class5 class5_0, Class148 class148_0, Class154 class154_0)
	{
		List<Class164> list = new List<Class164>();
		ulong ulong_ = default(ulong);
		Class164 @class = default(Class164);
		long num4 = default(long);
		long position = default(long);
		while (true)
		{
			IL_022e:
			long num;
			if (smethod_19(class154_0))
			{
				num = class5_0.ReadUInt32();
				goto IL_021e;
			}
			int num2 = 349227263;
			goto IL_01b8;
			IL_021e:
			ulong_ = (ulong)num;
			num2 = ((num == 0L) ? 508034706 : 776340766);
			goto IL_01b8;
			IL_01b8:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x5D3863A1)) % 15)
				{
				case 14u:
					@class.method_8((@class.method_0() & (ulong)(smethod_19(class154_0) ? 2147483648L : long.MinValue)) > 0L);
					num2 = 82630643;
					continue;
				case 13u:
					num2 = 776340766;
					continue;
				case 10u:
					break;
				case 9u:
				{
					Class164 class2 = new Class164();
					class2.method_1(ulong_);
					@class = class2;
					num2 = 875083338;
					continue;
				}
				case 8u:
					num2 = (@class.method_7() ? 1434587224 : 618987481) ^ (int)(num3 * 1331639034);
					continue;
				case 7u:
					num2 = (class5_0.imethod_0(num4) ? (-1753774204) : (-87263071)) ^ ((int)num3 * -111140187);
					continue;
				case 6u:
					num2 = ((int)num3 * -1209214295) ^ 0x7E523D88;
					continue;
				case 5u:
					smethod_157(class5_0, num4);
					@class.method_6(class5_0.ReadUInt16());
					num2 = ((int)num3 * -1838402414) ^ -993675798;
					continue;
				case 4u:
					list.Add(@class);
					num2 = 1617367704;
					continue;
				case 3u:
					@class.method_3((ushort)(@class.method_0() & 0xFFFFL));
					num2 = ((int)num3 * -1143329219) ^ -1093811936;
					continue;
				case 2u:
					smethod_157(class5_0, position);
					num2 = 896373552;
					continue;
				case 1u:
					@class.method_5(smethod_404(class5_0));
					num2 = (int)(num3 * 331792779) ^ -1102987839;
					continue;
				case 0u:
					goto end_IL_01b8;
				case 11u:
					goto IL_022e;
				default:
					return list;
				}
				num4 = smethod_135(class154_0, (uint)@class.method_0());
				position = class5_0.BaseStream.Position;
				num2 = ((num4 != -1L) ? 1414193164 : 149397536);
				continue;
				end_IL_01b8:
				break;
			}
			num = (long)class5_0.ReadUInt64();
			goto IL_021e;
		}
	}

	internal static void smethod_163(Class165 class165_0)
	{
		Interface2 @interface = class165_0.class154_0.method_6().method_3();
		class165_0.binaryWriter_0.Write(@interface.imethod_0());
		if (smethod_19(class165_0.class154_0))
		{
			goto IL_0167;
		}
		goto IL_0880;
		IL_0167:
		int num = 1585451590;
		goto IL_07a1;
		IL_07a1:
		Class157 @class = default(Class157);
		Class157[] array = default(Class157[]);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x69A3DFF9)) % 51)
			{
			case 50u:
				class165_0.binaryWriter_0.Write((ushort)@interface.imethod_34());
				num = (int)((num2 * 593508747) ^ 0xFEC38AA);
				continue;
			case 49u:
				class165_0.binaryWriter_0.Write(@interface.imethod_45());
				num = (int)(num2 * 1368992320) ^ -2126707751;
				continue;
			case 48u:
				class165_0.binaryWriter_0.Write(@interface.imethod_22());
				num = (int)(num2 * 411278587) ^ -1243200568;
				continue;
			case 47u:
				class165_0.binaryWriter_0.Write(@interface.imethod_27());
				class165_0.binaryWriter_0.Write(@interface.imethod_28());
				num = ((int)num2 * -367567761) ^ 0x1DCA663;
				continue;
			case 46u:
				class165_0.binaryWriter_0.Write(@interface.imethod_29());
				num = (int)(num2 * 1178225318) ^ -2115100843;
				continue;
			case 45u:
				class165_0.binaryWriter_0.Write(@interface.imethod_43());
				num = ((int)num2 * -1187036265) ^ -955846974;
				continue;
			case 44u:
				class165_0.binaryWriter_0.Write((uint)@interface.imethod_43());
				class165_0.binaryWriter_0.Write(@interface.imethod_45());
				class165_0.binaryWriter_0.Write(@interface.imethod_47());
				num = ((int)num2 * -1123984887) ^ 0xD5F98E5;
				continue;
			case 43u:
				break;
			case 42u:
				class165_0.binaryWriter_0.Write(@interface.imethod_17());
				class165_0.binaryWriter_0.Write(@interface.imethod_18());
				num = (int)((num2 * 723129526) ^ 0x6FAEE9E8);
				continue;
			case 41u:
				class165_0.binaryWriter_0.Write(@interface.imethod_41());
				num = (int)((num2 * 1990579644) ^ 0x21E2F870);
				continue;
			case 40u:
				class165_0.binaryWriter_0.Write(@interface.imethod_7());
				num = ((int)num2 * -462127733) ^ 0x4A8C7515;
				continue;
			case 39u:
				class165_0.binaryWriter_0.Write((uint)@interface.imethod_39());
				num = ((int)num2 * -67482074) ^ 0x566B73A8;
				continue;
			case 38u:
				class165_0.binaryWriter_0.Write(@interface.imethod_22());
				num = ((int)num2 * -912603324) ^ 0x421C339A;
				continue;
			case 37u:
				class165_0.binaryWriter_0.Write((uint)@interface.imethod_41());
				num = (int)(num2 * 1640527425) ^ -1491227095;
				continue;
			case 36u:
				goto IL_025c;
			case 35u:
				class165_0.binaryWriter_0.Write(@interface.imethod_31());
				num = (int)(num2 * 1837562381) ^ -149266983;
				continue;
			case 34u:
				class165_0.binaryWriter_0.Write(@interface.imethod_32());
				num = ((int)num2 * -974082496) ^ 0x2240FF7E;
				continue;
			case 33u:
				@class = array[num3];
				num = 1509465831;
				continue;
			case 31u:
				class165_0.binaryWriter_0.Write(@interface.imethod_26());
				num = ((int)num2 * -1774634896) ^ -1925902590;
				continue;
			case 30u:
				class165_0.binaryWriter_0.Write(@class.method_0());
				class165_0.binaryWriter_0.Write(@class.method_2());
				num = (int)((num2 * 1080186114) ^ 0x1A2231BB);
				continue;
			case 29u:
				class165_0.binaryWriter_0.Write((ushort)@interface.imethod_35());
				class165_0.binaryWriter_0.Write((uint)@interface.imethod_37());
				num = (int)(num2 * 1963406374) ^ -1432444795;
				continue;
			case 28u:
				class165_0.binaryWriter_0.Write((uint)@interface.imethod_17());
				num = ((int)num2 * -1862238666) ^ -1740693451;
				continue;
			case 27u:
				class165_0.binaryWriter_0.Write(@interface.imethod_1());
				num = ((int)num2 * -94461500) ^ -1289489728;
				continue;
			case 25u:
				class165_0.binaryWriter_0.Write(@interface.imethod_13());
				class165_0.binaryWriter_0.Write(@interface.imethod_15());
				num = ((int)num2 * -2131041605) ^ -1075029938;
				continue;
			case 24u:
				class165_0.binaryWriter_0.Write(@interface.imethod_24());
				num = (int)((num2 * 876076062) ^ 0xA18CF58);
				continue;
			case 23u:
				class165_0.binaryWriter_0.Write(@interface.imethod_37());
				class165_0.binaryWriter_0.Write(@interface.imethod_39());
				num = ((int)num2 * -1250094360) ^ 0x5180C1CD;
				continue;
			case 22u:
				class165_0.binaryWriter_0.Write(@interface.imethod_20());
				num = (int)(num2 * 149637219) ^ -1683141213;
				continue;
			case 21u:
				class165_0.binaryWriter_0.Write(@interface.imethod_3());
				num = ((int)num2 * -864582228) ^ 0x1CE35C63;
				continue;
			case 20u:
				array = @interface.imethod_49();
				num3 = 0;
				num = 1632085619;
				continue;
			case 19u:
				class165_0.binaryWriter_0.Write(@interface.imethod_32());
				num = ((int)num2 * -1994936969) ^ 0x10A174F0;
				continue;
			case 18u:
				class165_0.binaryWriter_0.Write(@interface.imethod_31());
				num = ((int)num2 * -1997437539) ^ 0x24843846;
				continue;
			case 17u:
				class165_0.binaryWriter_0.Write(@interface.imethod_11());
				num = (int)(num2 * 898087749) ^ -1489199782;
				continue;
			case 16u:
				class165_0.binaryWriter_0.Write(@interface.imethod_47());
				num = ((int)num2 * -1665732561) ^ -1951856644;
				continue;
			case 15u:
				class165_0.binaryWriter_0.Write(@interface.imethod_5());
				num = (int)((num2 * 241060048) ^ 0x5783FC63);
				continue;
			case 14u:
				class165_0.binaryWriter_0.Write(@interface.imethod_9());
				num = ((int)num2 * -938820760) ^ 0x509725F6;
				continue;
			case 13u:
				class165_0.binaryWriter_0.Write(@interface.imethod_19());
				num = (int)((num2 * 628276) ^ 0x4579A4CC);
				continue;
			case 12u:
				class165_0.binaryWriter_0.Write(@interface.imethod_21());
				num = ((int)num2 * -428505566) ^ -1423167702;
				continue;
			case 11u:
				class165_0.binaryWriter_0.Write(@interface.imethod_13());
				num = ((int)num2 * -997252785) ^ -2075669073;
				continue;
			case 10u:
				class165_0.binaryWriter_0.Write(@interface.imethod_28());
				class165_0.binaryWriter_0.Write(@interface.imethod_29());
				num = ((int)num2 * -591526744) ^ 0x6E0B9C78;
				continue;
			case 9u:
				class165_0.binaryWriter_0.Write((ushort)@interface.imethod_35());
				num = (int)((num2 * 1785867546) ^ 0xACE36CD);
				continue;
			case 8u:
				class165_0.binaryWriter_0.Write(@interface.imethod_20());
				num = ((int)num2 * -2078447524) ^ 0x147E4FC1;
				continue;
			case 7u:
				class165_0.binaryWriter_0.Write((ushort)@interface.imethod_34());
				num = (int)((num2 * 682789992) ^ 0x7E81230D);
				continue;
			case 6u:
				class165_0.binaryWriter_0.Write(@interface.imethod_9());
				class165_0.binaryWriter_0.Write(@interface.imethod_11());
				num = ((int)num2 * -810361972) ^ -1928406851;
				continue;
			case 5u:
				class165_0.binaryWriter_0.Write(@interface.imethod_5());
				class165_0.binaryWriter_0.Write(@interface.imethod_7());
				num = ((int)num2 * -2010825938) ^ 0x712327FA;
				continue;
			case 4u:
				class165_0.binaryWriter_0.Write(@interface.imethod_26());
				class165_0.binaryWriter_0.Write(@interface.imethod_27());
				num = ((int)num2 * -864622139) ^ -882827660;
				continue;
			case 3u:
				class165_0.binaryWriter_0.Write(@interface.imethod_24());
				num = (int)((num2 * 933531428) ^ 0x569530BC);
				continue;
			case 2u:
				num3++;
				num = (int)((num2 * 1185251618) ^ 0x6AF8DCCF);
				continue;
			case 1u:
				class165_0.binaryWriter_0.Write(@interface.imethod_21());
				num = ((int)num2 * -1841880505) ^ 0x6B9D817D;
				continue;
			case 0u:
				class165_0.binaryWriter_0.Write(@interface.imethod_18());
				class165_0.binaryWriter_0.Write(@interface.imethod_19());
				num = (int)((num2 * 807695130) ^ 0x2791A9E5);
				continue;
			default:
				return;
			case 26u:
				goto IL_0880;
			case 32u:
				return;
			}
			break;
			IL_025c:
			num = ((num3 >= array.Length) ? 593774735 : 978895543);
		}
		goto IL_0167;
		IL_0880:
		class165_0.binaryWriter_0.Write(@interface.imethod_1());
		class165_0.binaryWriter_0.Write(@interface.imethod_3());
		num = 1160779843;
		goto IL_07a1;
	}

	internal static void smethod_164(Class53 class53_0, Class63 class63_0, Class63 class63_1)
	{
		smethod_137(class53_0, Enum7.const_575, class63_0, class63_1);
	}

	internal static Class113[] smethod_165(Class112 class112_0)
	{
		Class113[] array = new Class113[smethod_277(class112_0)];
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
					num5 = smethod_362(typeof(Class113));
					num4 = 0;
					num = ((int)num2 * -878627032) ^ 0x3979DC75;
					continue;
				case 2u:
				{
					int num3 = num4;
					Class113 @class = new Class113(intptr_.smethod_8(num4 * num5), class112_0.method_2());
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
			byte b = Class127.random_0.smethod_3();
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

	internal static Class57 smethod_167(int int_0)
	{
		return new Class57((IntPtr)int_0);
	}

	internal static void smethod_168(Class179.Class182 class182_0, int int_0, int int_1, int int_2)
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

	internal static void smethod_169(Class59 class59_0, Class63 class63_0, Class53 class53_0)
	{
		smethod_137(class53_0, Enum7.const_1, class63_0, class59_0);
	}

	internal static int smethod_170(Class179.Class182 class182_0, Class179.Class181 class181_0, int int_0)
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

	internal static void smethod_171(Class53 class53_0, Class63 class63_0)
	{
		smethod_352(class63_0, Enum7.const_419, class53_0);
	}

	internal static void smethod_172(ModuleEntry class16_0)
	{
		if (!File.Exists(class16_0.Path))
		{
			return;
		}
		Class154 @class = null;
		try
		{
			FileStream fileStream = new FileStream(class16_0.Path, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				@class = Class6.smethod_3<Class8>(fileStream, class16_0.Path, bool_0: false, Enum39.const_0);
				while (true)
				{
					IL_0079:
					int num = 775880384;
					while (true)
					{
						uint num2;
						int num3;
						switch ((num2 = (uint)(num ^ 0x5C35901D)) % 4)
						{
						case 1u:
							num3 = ((@class == null) ? 422722883 : 1041870194);
							goto IL_004f;
						default:
							goto end_IL_0058;
						case 0u:
							break;
						case 2u:
							goto end_IL_0058;
						case 3u:
							return;
						}
						goto IL_0079;
						IL_004f:
						num = num3 ^ (int)(num2 * 1837221785);
						continue;
						end_IL_0058:
						break;
					}
					break;
				}
			}
			finally
			{
				if (fileStream != null)
				{
					while (true)
					{
						IL_00bc:
						int num4 = 544381015;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num4 ^ 0x5C35901D)) % 3)
							{
							case 1u:
								goto IL_008c;
							default:
								goto end_IL_009f;
							case 0u:
								break;
							case 2u:
								goto end_IL_009f;
							}
							goto IL_00bc;
							IL_008c:
							((IDisposable)fileStream).Dispose();
							num4 = ((int)num2 * -1666731322) ^ 0x39A80842;
							continue;
							end_IL_009f:
							break;
						}
						break;
					}
				}
			}
		}
		catch
		{
			return;
		}
		finally
		{
			if (@class != null)
			{
				while (true)
				{
					IL_00fe:
					int num5 = 1330094482;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num5 ^ 0x5C35901D)) % 3)
						{
						case 1u:
							goto IL_00ce;
						default:
							goto end_IL_00e1;
						case 0u:
							break;
						case 2u:
							goto end_IL_00e1;
						}
						goto IL_00fe;
						IL_00ce:
						@class.System_002EIDisposable_002EDispose();
						num5 = (int)((num2 * 1530459447) ^ 0x3910D768);
						continue;
						end_IL_00e1:
						break;
					}
					break;
				}
			}
		}
		ModuleOptionsForm form = new ModuleOptionsForm();
		form.method_1(class16_0);
		form.method_3(@class);
		form.ShowDialog();
	}

	internal static void smethod_173(Class53 class53_0)
	{
		if (!class53_0.method_0())
		{
			goto IL_0032;
		}
		goto IL_005c;
		IL_0032:
		int num = 1447506176;
		goto IL_0037;
		IL_0037:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6D10EC64)) % 5)
			{
			case 2u:
				num = (Class49.bool_0 ? 1184734117 : 594743410) ^ ((int)num2 * -1612408583);
				continue;
			case 0u:
				break;
			default:
				return;
			case 3u:
				goto IL_005c;
			case 4u:
				throw new InvalidOperationException("This instruction is only available in x86 mode.");
			case 1u:
				return;
			}
			break;
		}
		goto IL_0032;
		IL_005c:
		smethod_31(class53_0, Enum7.const_464);
		num = 1160325670;
		goto IL_0037;
	}

	internal static Stream smethod_174(Class154 class154_0)
	{
		Stream result = default(Stream);
		lock (class154_0.method_28())
		{
			if (class154_0.method_28() is FileStream)
			{
				goto IL_005a;
			}
			goto IL_0088;
			IL_005a:
			int num = 1453266469;
			goto IL_005f;
			IL_005f:
			MemoryStream memoryStream = default(MemoryStream);
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x79F02DB)) % 6)
				{
				case 4u:
					result = new FileStream(class154_0.method_28().smethod_4(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					num = (int)((num2 * 935477354) ^ 0x9A4F6CA);
					continue;
				case 2u:
					class154_0.method_28().smethod_6(memoryStream);
					num = ((int)num2 * -1961812357) ^ 0x2D95C3DA;
					continue;
				case 0u:
					break;
				case 3u:
					goto IL_0088;
				case 1u:
					goto end_IL_000d;
				default:
					memoryStream.Position = 0L;
					result = memoryStream;
					goto end_IL_000d;
				}
				break;
			}
			goto IL_005a;
			IL_0088:
			class154_0.method_28().Position = 0L;
			memoryStream = new MemoryStream();
			num = 1713584963;
			goto IL_005f;
			end_IL_000d:;
		}
		return result;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr VirtualAlloc(IntPtr intptr_0, UIntPtr uintptr_0, Class124.Enum33 enum33_0, Class124.Enum34 enum34_0);

	internal static IntPtr smethod_175(Class82 class82_0, long long_0, Class124.Enum34 enum34_0)
	{
		return class82_0.method_15(IntPtr.Zero, long_0, enum34_0);
	}

	internal static bool smethod_176(Class166 class166_0, int int_0)
	{
		return smethod_282(class166_0, (int)(class166_0.class5_0.BaseStream.Position - class166_0.long_0), int_0);
	}

	internal static void smethod_177(string string_0, MainForm mainForm, string string_1)
	{
		MessageBox.Show(mainForm, "The DLL you have selected, \"" + string_1 + "\" requires \"" + string_0 + "\" in order to work properly, but you are running Windows XP which does not support it. Please notify the creator of the DLL to build in Release mode with XP compatibility.", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}

	internal static IntPtr smethod_178(Class90 class90_0, IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, out Class124.Struct55 struct55_0, out int int_0, out int int_1, ref int int_2)
	{
		struct55_0 = default(Class124.Struct55);
		int_0 = 0;
		int_1 = 0;
		Class53 class53_ = new Class53();
		Class58 class58_ = smethod_48(class53_);
		int num4 = default(int);
		Class63[] array = default(Class63[]);
		ulong num3 = default(ulong);
		Class63 class63_3 = default(Class63);
		Class58 class58_3 = default(Class58);
		Class59 class59_ = default(Class59);
		Class58 class58_6 = default(Class58);
		Class57 class57_2 = default(Class57);
		Class58 class58_2 = default(Class58);
		Class58 class58_5 = default(Class58);
		Class63[] array2 = default(Class63[]);
		Class58 class58_4 = default(Class58);
		Class63 class63_2 = default(Class63);
		while (true)
		{
			int num = -2111155643;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1265218909)) % 45)
				{
				case 44u:
					num = ((num4 >= array.Length) ? (-2064250982) : (-416337602));
					continue;
				case 43u:
					num = ((num3 == 0L) ? (-360469638) : (-1060070033)) ^ (int)(num2 * 1000903636);
					continue;
				case 42u:
					num4++;
					num = ((int)num2 * -1572151555) ^ -1777887503;
					continue;
				case 41u:
					smethod_36(class53_, class58_);
					num = (int)(num2 * 359887414) ^ -82057740;
					continue;
				case 40u:
					smethod_372(class63_3, class53_);
					num = (int)(num2 * 1112202912) ^ -55717196;
					continue;
				case 39u:
					int_2 = smethod_252(class53_);
					smethod_36(class53_, class58_3);
					smethod_439(class53_, 0u);
					smethod_200(class53_, 8u);
					num = ((int)num2 * -1332537631) ^ -633990160;
					continue;
				case 38u:
				{
					Class63 class63_6 = array[num4];
					smethod_82(class53_, class63_6);
					num = -2004827943;
					continue;
				}
				case 37u:
					class59_ = smethod_126(class58_6, 0L);
					class57_2 = smethod_167(1);
					num = ((int)num2 * -1224324970) ^ 0x225F7D51;
					continue;
				case 36u:
					smethod_36(class53_, class58_2);
					num = ((int)num2 * -1656207294) ^ -1651162520;
					continue;
				case 34u:
					smethod_200(class53_, 8u);
					num = (int)(num2 * 1110028581) ^ -997294892;
					continue;
				case 33u:
					smethod_36(class53_, class58_5);
					int_1 = smethod_252(class53_);
					smethod_118(class53_, IntPtr.Zero);
					num = ((int)num2 * -2141142957) ^ -1026693771;
					continue;
				case 32u:
					smethod_36(class53_, class58_6);
					num = ((int)num2 * -888341313) ^ 0x517E6E99;
					continue;
				case 31u:
					class58_6 = smethod_48(class53_);
					num = (int)(num2 * 642084513) ^ -1412265932;
					continue;
				case 30u:
					smethod_127(class57_2, class59_, class53_);
					num = ((int)num2 * -664381764) ^ -741070242;
					continue;
				case 28u:
					num4 = 0;
					num = ((int)num2 * -1495698515) ^ 0x7B8BB2B3;
					continue;
				case 27u:
					Array.Reverse(array2);
					num = -1540210179;
					continue;
				case 26u:
					smethod_297(class53_);
					num = ((int)num2 * -1481077302) ^ -1817840574;
					continue;
				case 25u:
					class58_5 = smethod_48(class53_);
					num = (int)(num2 * 405472283) ^ -437875733;
					continue;
				case 24u:
					smethod_91(class58_2, Enum12.const_0, class53_);
					num = (int)(num2 * 1025717141) ^ -196938389;
					continue;
				case 23u:
					num3 = (ulong)((long)struct55_0.ulong_16 - (long)(IntPtr.Size * (2 + array2.Length))) % 16uL;
					num = ((num3 != 0L) ? (-1717241392) : (-26593848)) ^ ((int)num2 * -960528037);
					continue;
				case 22u:
					class58_3 = smethod_48(class53_);
					smethod_371(class53_, smethod_329(class58_4, 0L));
					array2 = new Class63[15]
					{
						Class49.class63_53,
						Class49.class63_54,
						Class49.class63_55,
						Class49.class63_56,
						Class49.class63_58,
						Class49.class63_59,
						Class49.class63_60,
						Class49.class63_61,
						Class49.class63_62,
						Class49.class63_63,
						Class49.class63_64,
						Class49.class63_65,
						Class49.class63_66,
						Class49.class63_67,
						Class49.class63_68
					};
					array2.smethod_4();
					num = (int)(num2 * 429527046) ^ -1738194259;
					continue;
				case 21u:
					array = array2;
					num = ((int)num2 * -248591880) ^ -1161013293;
					continue;
				case 20u:
					smethod_75(class53_, smethod_329(class58_5, 0L), Class49.class63_53);
					class63_2 = Class49.class63_53;
					num = ((int)num2 * -630075215) ^ 0x5EF8EAA1;
					continue;
				case 19u:
					num4 = 0;
					num = (int)((num2 * 993330166) ^ 0x17F40A9A);
					continue;
				case 18u:
					smethod_306(class53_, class63_3, new Class57(intptr_1));
					num = ((int)num2 * -1914529697) ^ 0x2C5F4A90;
					continue;
				case 17u:
				{
					Class63 class63_5 = array[num4];
					smethod_171(class53_, class63_5);
					num4++;
					num = -1998586996;
					continue;
				}
				case 16u:
					smethod_263(class53_, Class49.class63_54, smethod_329(class58_, 0L));
					class63_3 = new Class63[6]
					{
						Class49.class63_53,
						Class49.class63_55,
						Class49.class63_56,
						Class49.class63_58,
						Class49.class63_59,
						Class49.class63_60
					}.smethod_2();
					smethod_306(class53_, class63_3, new Class57(intptr_0));
					num = -995664462;
					continue;
				case 15u:
					array = array2;
					num = (int)((num2 * 1971146982) ^ 0x1AC6F266);
					continue;
				case 14u:
					int_0 = smethod_252(class53_);
					smethod_439(class53_, 0u);
					num = ((int)num2 * -1622213535) ^ 0x6ED5CAD4;
					continue;
				case 13u:
					class58_4 = smethod_48(class53_);
					num = (int)((num2 * 633806371) ^ 0x3F424ADD);
					continue;
				case 12u:
					num = ((num4 < array.Length) ? (-630125802) : (-1517491092));
					continue;
				case 11u:
					smethod_20(class53_);
					num = (int)((num2 * 968758232) ^ 0x19246797);
					continue;
				case 10u:
				{
					Class63 class63_4 = Class49.class63_57;
					Class57 class57_ = smethod_125(num3);
					smethod_190(class63_4, class57_, class53_);
					num = ((int)num2 * -1982796345) ^ 0x706B37DB;
					continue;
				}
				case 9u:
					smethod_200(class53_, 8u);
					num = (int)((num2 * 478389072) ^ 0x5F70E722);
					continue;
				case 8u:
					smethod_347(class53_);
					num = ((int)num2 * -438977605) ^ 0x13730D40;
					continue;
				case 7u:
					smethod_363(class53_, Class49.class63_57, smethod_125(num3));
					num = (int)(num2 * 1940763118) ^ -1691503986;
					continue;
				case 6u:
					smethod_372(class63_3, class53_);
					num = ((int)num2 * -1091271359) ^ 0x76687A17;
					continue;
				case 5u:
				{
					Class63 class63_ = Class49.class63_53;
					smethod_310(class63_2, class63_, class53_);
					num = (int)((num2 * 411221918) ^ 0x3EFE3296);
					continue;
				}
				case 4u:
					smethod_36(class53_, class58_4);
					smethod_98(class53_, struct55_0.ulong_28);
					num = ((int)num2 * -130908194) ^ -1439769193;
					continue;
				case 3u:
					smethod_75(class53_, smethod_126(class58_3, 0L), Class49.class63_37);
					num = (int)((num2 * 765112438) ^ 0x2357FAB);
					continue;
				case 2u:
					smethod_200(class53_, 8u);
					num = (int)(num2 * 2113779622) ^ -2067404525;
					continue;
				case 1u:
					class58_2 = smethod_48(class53_);
					num = (int)((num2 * 620110552) ^ 0x71F59B1C);
					continue;
				case 0u:
					smethod_320(class53_, byte_0);
					num = ((int)num2 * -2090987103) ^ 0xCABB3DC;
					continue;
				case 35u:
					break;
				default:
					return smethod_61(class53_, class90_0);
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll")]
	internal static extern int VirtualQuery(IntPtr intptr_0, out Class124.Struct47 struct47_0, uint uint_0);

	internal static List<Class75> smethod_179(GClass2 gclass2_0)
	{
		List<Class75> list = new List<Class75>();
		IEnumerator<int> enumerator = smethod_66(gclass2_0).GetEnumerator();
		try
		{
			Class75 @class = default(Class75);
			int current = default(int);
			while (true)
			{
				IL_00ce:
				int num = (enumerator.MoveNext() ? (-220082529) : (-1654316114));
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -780643675)) % 7)
					{
					case 6u:
						list.Add(@class);
						num = (int)((num2 * 1572174479) ^ 0x44717921);
						continue;
					case 5u:
						num = -220082529;
						continue;
					case 4u:
						@class = new Class75(gclass2_0, current);
						num = (int)(num2 * 542129054) ^ -1296490314;
						continue;
					case 1u:
						current = enumerator.Current;
						num = -1953046908;
						continue;
					case 0u:
						num = (smethod_70(@class) ? 137711753 : 1285514769) ^ ((int)num2 * -1104536626);
						continue;
					default:
						goto end_IL_0091;
					case 3u:
						break;
					case 2u:
						goto end_IL_0091;
					}
					goto IL_00ce;
					continue;
					end_IL_0091:
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
					IL_0114:
					int num3 = -168540479;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num3 ^ -780643675)) % 3)
						{
						case 2u:
							goto IL_00e2;
						default:
							goto end_IL_00f6;
						case 0u:
							break;
						case 1u:
							goto end_IL_00f6;
						}
						goto IL_0114;
						IL_00e2:
						enumerator.Dispose();
						num3 = (int)(num2 * 644218183) ^ -1176034497;
						continue;
						end_IL_00f6:
						break;
					}
					break;
				}
			}
		}
		return list;
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool VirtualProtect(IntPtr intptr_0, UIntPtr uintptr_0, Class124.Enum34 enum34_0, out Class124.Enum34 enum34_1);

	internal static byte[] smethod_180()
	{
		return (byte[])smethod_124().GetObject("BeaEnginex86", Class68.cultureInfo_0);
	}

	internal static void smethod_181(object object_0, Class47 class47_0, Class47.Enum6 enum6_0)
	{
		Class47.Class48 @class = object_0 as Class47.Class48;
		Class59 class59_ = default(Class59);
		Class57 class2 = default(Class57);
		Class63 class3 = default(Class63);
		while (true)
		{
			int num = -307481787;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1943350127)) % 13)
				{
				case 8u:
					num = ((@class == null) ? 624897134 : 74775435) ^ ((int)num2 * -770862114);
					continue;
				case 7u:
					smethod_263(class47_0.class53_0, Class49.class63_37, smethod_221(class47_0, @class.method_0(), 0L));
					smethod_39(Class49.class63_37, class47_0, enum6_0);
					num = ((int)num2 * -1577482625) ^ 0x43E1400F;
					continue;
				case 6u:
					class59_ = object_0 as Class59;
					num = -1314020461;
					continue;
				case 5u:
					num = (smethod_278(class59_, null) ? (-497940270) : (-1967569884)) ^ (int)(num2 * 212262744);
					continue;
				case 2u:
					class2 = object_0.smethod_0();
					num = -981871488;
					continue;
				case 1u:
					num = (smethod_49(class2, null) ? (-2139150582) : (-1423917370)) ^ ((int)num2 * -401374236);
					continue;
				case 0u:
					class3 = object_0 as Class63;
					num = ((!smethod_392(null, class3)) ? (-1653079716) : (-1109504707));
					continue;
				case 12u:
					break;
				case 3u:
					smethod_39(class3, class47_0, enum6_0);
					return;
				case 4u:
					smethod_431(enum6_0, class47_0, class59_);
					return;
				default:
					throw new InvalidOperationException("Unknown object type.");
				case 10u:
					return;
				case 11u:
					smethod_112(enum6_0, class2, class47_0);
					return;
				}
				break;
			}
		}
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

	internal static GClass2 smethod_183(IntPtr intptr_0, int int_0)
	{
		GClass2 gClass = new GClass2((uint)int_0);
		gClass.method_11(intptr_0);
		GClass2 gClass2 = gClass;
		while (true)
		{
			int num = 1566458528;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0xF373082)) % 4)
				{
				case 2u:
					num3 = ((!smethod_102(gClass2)) ? (-1457748859) : (-813358121));
					goto IL_002e;
				case 0u:
					break;
				case 1u:
					return null;
				default:
					return gClass2;
				}
				break;
				IL_002e:
				num = num3 ^ ((int)num2 * -2097154587);
			}
		}
	}

	internal static bool smethod_184(IntPtr intptr_0)
	{
		if (VirtualQuery(intptr_0, out var struct47_, (uint)typeof(Class124.Struct47).smethod_7()) == 0)
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
				num = (((struct47_.enum34_1 & Class124.Enum34.flag_1) == 0) ? (-683618116) : (-2131935236)) ^ (int)(num2 * 585212972);
				continue;
			case 5u:
				goto IL_008e;
			case 0u:
				return (struct47_.enum34_1 & Class124.Enum34.flag_2) != 0;
			case 1u:
				return false;
			default:
				return true;
			}
			break;
		}
		goto IL_0028;
		IL_008e:
		num = (((struct47_.enum34_1 & Class124.Enum34.flag_5) == 0) ? 1054596244 : 1535139980);
		goto IL_0059;
	}

	internal static void smethod_185(Encoding encoding_0, GClass4 gclass4_0, string string_0)
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

	internal static Class96.Class168 smethod_187(Type type_0, int int_0)
	{
		return new Class96.Class168
		{
			int_0 = smethod_245(type_0) + int_0,
			bool_0 = true
		};
	}

	internal static Class56.Struct9 smethod_188(Class56 class56_0)
	{
		return Class56.smethod_0<Class56.Struct7, Class56.Struct9>(class56_0.method_0());
	}

	internal static void smethod_189(IntPtr intptr_0)
	{
		if (Class49.delegate0_0 == null)
		{
			goto IL_0022;
		}
		goto IL_0048;
		IL_0022:
		int num = 1600419388;
		goto IL_0027;
		IL_0027:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3A9982CF)) % 4)
			{
			case 3u:
				Class49.delegate0_0 = smethod_207();
				num = ((int)num2 * -1778335261) ^ 0x16E06B3E;
				continue;
			case 2u:
				break;
			default:
				return;
			case 0u:
				goto IL_0048;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0022;
		IL_0048:
		Class49.delegate0_0(intptr_0);
		num = 1346836210;
		goto IL_0027;
	}

	internal static void smethod_190(Class63 class63_0, Class57 class57_0, Class53 class53_0)
	{
		smethod_137(class53_0, Enum7.const_560, class63_0, class57_0);
	}

	internal static Class53 smethod_191(Class47 class47_0)
	{
		return class47_0.class53_0;
	}

	internal static void smethod_192()
	{
		try
		{
			Class177.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	internal static bool smethod_193(out string string_0)
	{
		string_0 = null;
		bool result = default(bool);
		try
		{
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				while (true)
				{
					int num = -900629723;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -786395264)) % 4)
						{
						case 1u:
							result = false;
							num = (int)(num2 * 2104451442) ^ -2104411406;
							continue;
						case 2u:
							break;
						default:
							goto end_IL_003e;
						case 0u:
							goto end_IL_0003;
						}
						break;
					}
					continue;
					end_IL_003e:
					break;
				}
			}
			Class20 @class = new Class20();
			try
			{
				string_0 = @class.DownloadString("https://raw.githubusercontent.com/master131/ExtremeInjector/master/version");
				Version version = Assembly.GetExecutingAssembly().GetName().Version;
				string text = default(string);
				while (true)
				{
					IL_0122:
					int num3 = -612244095;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num3 ^ -786395264)) % 5)
						{
						case 4u:
							text = text + "." + version.Build;
							num3 = (int)((num2 * 1245975072) ^ 0x1B48FC83);
							continue;
						case 3u:
							text = string.Format("{0}.{1}", version.Major, version.Minor);
							num3 = ((version.Build == 0) ? 1541240008 : 405934392) ^ (int)(num2 * 1635701291);
							continue;
						case 2u:
							result = string_0 != text;
							num3 = -1191878222;
							continue;
						default:
							goto end_IL_00fc;
						case 0u:
							break;
						case 1u:
							goto end_IL_00fc;
						}
						goto IL_0122;
						continue;
						end_IL_00fc:
						break;
					}
					break;
				}
			}
			finally
			{
				if (@class != null)
				{
					while (true)
					{
						IL_0162:
						int num4 = -1502142866;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num4 ^ -786395264)) % 3)
							{
							case 1u:
								goto IL_0130;
							default:
								goto end_IL_0144;
							case 0u:
								break;
							case 2u:
								goto end_IL_0144;
							}
							goto IL_0162;
							IL_0130:
							((IDisposable)@class).Dispose();
							num4 = ((int)num2 * -1599204246) ^ -2091821135;
							continue;
							end_IL_0144:
							break;
						}
						break;
					}
				}
			}
			end_IL_0003:;
		}
		catch
		{
			while (true)
			{
				IL_019d:
				int num5 = -909520466;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num5 ^ -786395264)) % 3)
					{
					case 1u:
						goto IL_016f;
					default:
						goto end_IL_017f;
					case 0u:
						break;
					case 2u:
						goto end_IL_017f;
					}
					goto IL_019d;
					IL_016f:
					result = false;
					num5 = ((int)num2 * -1151164846) ^ 0x44F311A0;
					continue;
					end_IL_017f:
					break;
				}
				break;
			}
		}
		return result;
	}

	internal static Class96.Class168 smethod_194(Type type_0, int int_0)
	{
		return new Class96.Class168
		{
			int_0 = smethod_245(type_0) * int_0
		};
	}

	internal static Class57 smethod_195(long long_0)
	{
		if (!Class127.bool_0)
		{
			return new Class57((IntPtr)(int)long_0);
		}
		return new Class57((IntPtr)long_0);
	}

	internal static GClass1 smethod_196(Class69 class69_0, IntPtr intptr_0)
	{
		Class69.Class71 @class = new Class69.Class71();
		@class.intptr_0 = intptr_0;
		return class69_0.Find(@class.method_0);
	}

	internal unsafe static IntPtr smethod_197(Class86 class86_0, IntPtr intptr_0, GClass1 gclass1_0)
	{
		//The blocks IL_004a, IL_005e, IL_007e, IL_008b, IL_0097, IL_00a1, IL_00b0, IL_00d5, IL_00e1, IL_00eb, IL_00fa, IL_0111, IL_0127, IL_0133, IL_013d, IL_014c, IL_0162, IL_016e, IL_0178, IL_0187, IL_01aa, IL_01c0, IL_01cc, IL_01d6, IL_01e5, IL_01f8, IL_0204, IL_020e, IL_021d, IL_023a, IL_0246, IL_0256, IL_025d, IL_0269, IL_0273, IL_0282, IL_0288, IL_0294, IL_029e, IL_02ad, IL_02b3, IL_02bf, IL_02cf, IL_02e1, IL_02ec, IL_02f8, IL_0305, IL_0320, IL_0349, IL_0361, IL_036e, IL_03f9, IL_0403, IL_0413, IL_0423, IL_0433, IL_0443, IL_0453 are reachable both inside and outside the pinned region starting at IL_003e. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		byte[] array = class86_0.method_10<byte>(intptr_0, 512);
		byte referenceStorage = 0;
		ref byte reference = ref referenceStorage;
		int num4 = default(int);
		byte[] array3 = default(byte[]);
		IntPtr intPtr = default(IntPtr);
		int num10 = default(int);
		Struct31 struct31_ = default(Struct31);
		byte* ptr = default(byte*);
		Struct31 @struct = default(Struct31);
		while (true)
		{
			int num = -434742910;
			while (true)
			{
				uint num3;
				uint num2 = (num3 = (uint)(num ^ -868245406));
				int num9;
				int num11;
				int num8;
				ref byte* pByte_ = ref struct31_.pByte_0;
				int num5;
				int num13;
				int num6;
				int num14;
				int num12;
				int num7;
				byte[] array2;
				switch (num2 % 30)
				{
				case 29u:
					reference = ref *(byte*)null;
					num = ((num4 == -1) ? (-898327583) : (-109086173));
					continue;
				case 27u:
					while (true)
					{
						IL_0036:
						fixed (byte* ptr2 = &array3[0])
						{
							num = -1801241708;
							while (true)
							{
								num2 = (num3 = (uint)(num ^ -868245406));
								switch (num2 % 30)
								{
								case 29u:
									break;
								case 27u:
									goto IL_0036;
								case 26u:
									array = class86_0.method_10<byte>(intPtr, 15);
									num = -222138447;
									continue;
								case 25u:
								{
									int num15 = BitConverter.ToInt32(array, num4 + 1);
									intPtr = intptr_0.smethod_8(num4 + 5 + num15);
									num = -181273287;
									continue;
								}
								case 24u:
									num9 = (num10 = smethod_224(ref struct31_));
									num11 = ((num9 <= 0) ? 788743707 : 1770834186);
									num = num11 ^ ((int)num3 * -349977012);
									continue;
								case 23u:
								{
									string string_ = "h\0\0\0\0h\0\0\0\0è";
									string string_2 = "x????x????x";
									num8 = (smethod_40(0, string_, array, string_2) ? 1204606268 : 2059884722);
									num = num8 ^ ((int)num3 * -1104139123);
									continue;
								}
								case 22u:
									pByte_ = ref struct31_.pByte_0;
									pByte_ += num10;
									num = -682302182;
									continue;
								case 20u:
									num5 = (((ulong)(long)intPtr >= (ulong)((long)intPtr + gclass1_0.method_4())) ? 188985037 : 1264292352);
									num = num5 ^ (int)(num3 * 300569485);
									continue;
								case 19u:
									num4 = smethod_378(array, "j\u0001", 0);
									num13 = ((num4 != -1) ? (-520168972) : (-342354620));
									num = num13 ^ (int)(num3 * 829113150);
									continue;
								case 18u:
									num4 = (int)(struct31_.pByte_0 - ptr2);
									num = ((int)num3 * -1366876534) ^ -622215185;
									continue;
								case 16u:
									num4 = smethod_378(array, "Â\u0010\0", 0);
									num6 = ((num4 != -1) ? 924948785 : 403664903);
									num = num6 ^ (int)(num3 * 225315374);
									continue;
								case 15u:
									num14 = (((ulong)(long)intPtr < (ulong)(long)gclass1_0.method_0()) ? (-1185537316) : (-1981051253));
									num = num14 ^ (int)(num3 * 1503913541);
									continue;
								case 14u:
									num = ((struct31_.struct27_0.method_0() == "call ") ? (-1069048020) : (-1651216740));
									continue;
								case 13u:
									num12 = ((!Class127.bool_7) ? (-201253133) : (-1891877039));
									num = num12 ^ (int)(num3 * 2027098178);
									continue;
								case 12u:
									num7 = ((array3.Length == 0) ? (-999760709) : (-1151907387));
									num = num7 ^ ((int)num3 * -2104651953);
									continue;
								case 10u:
									array2 = (array3 = array);
									num = ((array2 != null) ? (-2089302806) : (-1844567741));
									continue;
								case 9u:
									Array.Resize(ref array, num4);
									num = -720497681;
									continue;
								case 8u:
									num = ((struct31_.pByte_0 >= ptr) ? (-323552285) : (-791054040));
									continue;
								case 6u:
									num = (int)((num3 * 1718509531) ^ 0x6697BB64);
									continue;
								case 5u:
									goto end_IL_0036;
								case 4u:
									@struct.pByte_0 = ptr2 + num4;
									struct31_ = @struct;
									ptr = ptr2 + array.Length;
									num = (int)(num3 * 1634112372) ^ -78365312;
									continue;
								case 3u:
									@struct.uint_1 = 0u;
									num = (int)((num3 * 1856669281) ^ 0x67DFCBBB);
									continue;
								case 0u:
									@struct = default(Struct31);
									num = -1242932931;
									continue;
								case 2u:
									num = -434742910;
									continue;
								case 1u:
									throw new MissingMethodException("Unable to find call to LdrpLoadDll function inside LdrLoadDll.");
								case 7u:
									throw new MissingMethodException("Unable to verify the guessed function is LdrpLoadDll.");
								case 11u:
									throw new MissingMethodException("The function thought to be LdrpLoadDll is outside ntdll.dll.");
								case 17u:
									throw new InvalidOperationException("Unable to find function end of LdrLoadDll.");
								case 28u:
									throw new InvalidOperationException("Unable to detect signature for LdrpLoadDll.");
								default:
									return intPtr;
								}
								break;
							}
						}
						goto case 29u;
						continue;
						end_IL_0036:
						break;
					}
					goto case 5u;
				case 26u:
					array = class86_0.method_10<byte>(intPtr, 15);
					num = -222138447;
					continue;
				case 25u:
				{
					int num15 = BitConverter.ToInt32(array, num4 + 1);
					intPtr = intptr_0.smethod_8(num4 + 5 + num15);
					num = -181273287;
					continue;
				}
				case 24u:
					num9 = (num10 = smethod_224(ref struct31_));
					num11 = ((num9 <= 0) ? 788743707 : 1770834186);
					num = num11 ^ ((int)num3 * -349977012);
					continue;
				case 23u:
				{
					string string_ = "h\0\0\0\0h\0\0\0\0è";
					string string_2 = "x????x????x";
					num8 = (smethod_40(0, string_, array, string_2) ? 1204606268 : 2059884722);
					num = num8 ^ ((int)num3 * -1104139123);
					continue;
				}
				case 22u:
					pByte_ = ref struct31_.pByte_0;
					pByte_ += num10;
					num = -682302182;
					continue;
				case 20u:
					num5 = (((ulong)(long)intPtr >= (ulong)((long)intPtr + gclass1_0.method_4())) ? 188985037 : 1264292352);
					num = num5 ^ (int)(num3 * 300569485);
					continue;
				case 19u:
					num4 = smethod_378(array, "j\u0001", 0);
					num13 = ((num4 != -1) ? (-520168972) : (-342354620));
					num = num13 ^ (int)(num3 * 829113150);
					continue;
				case 18u:
					num4 = (int)(struct31_.pByte_0 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
					num = ((int)num3 * -1366876534) ^ -622215185;
					continue;
				case 16u:
					num4 = smethod_378(array, "Â\u0010\0", 0);
					num6 = ((num4 != -1) ? 924948785 : 403664903);
					num = num6 ^ (int)(num3 * 225315374);
					continue;
				case 15u:
					num14 = (((ulong)(long)intPtr < (ulong)(long)gclass1_0.method_0()) ? (-1185537316) : (-1981051253));
					num = num14 ^ (int)(num3 * 1503913541);
					continue;
				case 14u:
					num = ((struct31_.struct27_0.method_0() == "call ") ? (-1069048020) : (-1651216740));
					continue;
				case 13u:
					num12 = ((!Class127.bool_7) ? (-201253133) : (-1891877039));
					num = num12 ^ (int)(num3 * 2027098178);
					continue;
				case 12u:
					num7 = ((array3.Length == 0) ? (-999760709) : (-1151907387));
					num = num7 ^ ((int)num3 * -2104651953);
					continue;
				case 10u:
					array2 = (array3 = array);
					num = ((array2 != null) ? (-2089302806) : (-1844567741));
					continue;
				case 9u:
					Array.Resize(ref array, num4);
					num = -720497681;
					continue;
				case 8u:
					num = ((struct31_.pByte_0 >= ptr) ? (-323552285) : (-791054040));
					continue;
				case 6u:
					num = (int)((num3 * 1718509531) ^ 0x6697BB64);
					continue;
				case 5u:
					reference = ref *(byte*)null;
					num = -1801241708;
					continue;
				case 4u:
					@struct.pByte_0 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + num4;
					struct31_ = @struct;
					ptr = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + array.Length;
					num = (int)(num3 * 1634112372) ^ -78365312;
					continue;
				case 3u:
					@struct.uint_1 = 0u;
					num = (int)((num3 * 1856669281) ^ 0x67DFCBBB);
					continue;
				case 0u:
					@struct = default(Struct31);
					num = -1242932931;
					continue;
				case 2u:
					break;
				case 1u:
					throw new MissingMethodException("Unable to find call to LdrpLoadDll function inside LdrLoadDll.");
				case 7u:
					throw new MissingMethodException("Unable to verify the guessed function is LdrpLoadDll.");
				case 11u:
					throw new MissingMethodException("The function thought to be LdrpLoadDll is outside ntdll.dll.");
				case 17u:
					throw new InvalidOperationException("Unable to find function end of LdrLoadDll.");
				case 28u:
					throw new InvalidOperationException("Unable to detect signature for LdrpLoadDll.");
				default:
					return intPtr;
				}
				break;
			}
		}
	}

	internal static ICryptoTransform smethod_198(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		ICryptoTransform result = default(ICryptoTransform);
		try
		{
			if (!bool_0)
			{
				goto IL_0013;
			}
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0);
			goto IL_003d;
			IL_0035:
			cryptoTransform = dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
			goto IL_003d;
			IL_003d:
			result = cryptoTransform;
			int num = 1722183892;
			goto IL_0018;
			IL_0018:
			switch ((uint)(num ^ 0x43654EEC) % 3u)
			{
			case 0u:
				break;
			default:
				goto end_IL_0006;
			case 1u:
				goto IL_0035;
			case 2u:
				goto end_IL_0006;
			}
			goto IL_0013;
			IL_0013:
			num = 549100885;
			goto IL_0018;
			end_IL_0006:;
		}
		finally
		{
			if (dESCryptoServiceProvider != null)
			{
				while (true)
				{
					IL_007c:
					int num2 = 1076862558;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num2 ^ 0x43654EEC)) % 3)
						{
						case 1u:
							goto IL_004c;
						default:
							goto end_IL_005f;
						case 2u:
							break;
						case 0u:
							goto end_IL_005f;
						}
						goto IL_007c;
						IL_004c:
						((IDisposable)dESCryptoServiceProvider).Dispose();
						num2 = ((int)num3 * -1319166980) ^ -1177397839;
						continue;
						end_IL_005f:
						break;
					}
					break;
				}
			}
		}
		return result;
	}

	internal static void smethod_199(int int_0, Class47 class47_0, Class63 class63_0)
	{
		Class63[] array = new Class63[4]
		{
			Class49.class63_54,
			Class49.class63_55,
			Class49.class63_61,
			Class49.class63_62
		};
		if (int_0 < 4)
		{
			goto IL_002b;
		}
		goto IL_0082;
		IL_002b:
		int num = -874063077;
		goto IL_005d;
		IL_005d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -48508189)) % 5)
			{
			case 2u:
				break;
			case 0u:
				smethod_75(class47_0.class53_0, smethod_238(Class49.class63_57, int_0 * 8), Class49.class63_53);
				num = ((int)num2 * -1557266712) ^ -112569558;
				continue;
			default:
				return;
			case 3u:
				goto IL_0082;
			case 1u:
				return;
			case 4u:
				smethod_318(class47_0.class53_0, array[int_0], class63_0);
				return;
			}
			break;
		}
		goto IL_002b;
		IL_0082:
		smethod_318(class47_0.class53_0, Class49.class63_53, class63_0);
		num = -657653372;
		goto IL_005d;
	}

	internal static void smethod_200(Class53 class53_0, uint uint_0)
	{
		if (Class49.bool_0)
		{
			while (true)
			{
				int num = 121528500;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x175D0C0F)) % 4)
					{
					case 3u:
						Class52.smethod_65()(ref class53_0.struct19_0, uint_0);
						num = ((int)num2 * -1668988340) ^ -2101865998;
						continue;
					case 0u:
						break;
					case 1u:
						return;
					default:
						goto end_IL_0048;
					}
					break;
				}
				continue;
				end_IL_0048:
				break;
			}
		}
		Class52.smethod_63()(ref class53_0.struct19_0, uint_0);
	}

	internal static uint smethod_201(uint uint_0, uint uint_1)
	{
		if (uint_1 % uint_0 != 0)
		{
			return uint_1 + uint_0 - uint_1 % uint_0;
		}
		return uint_1;
	}

	[DllImport("kernel32.dll", EntryPoint = "SetThreadContext")]
	internal static extern bool SetThreadContext_1(IntPtr intptr_0, ref Class124.Struct54 struct54_0);

	internal static void smethod_202(Class5 class5_0, uint uint_0)
	{
		class5_0.BaseStream.Position = uint_0;
	}

	internal static void smethod_203(string string_0, string string_1, string string_2, Class154 class154_0, string string_3, MainForm mainForm, string string_4, bool bool_0, string string_5, bool bool_1, string string_6)
	{
		if (bool_0)
		{
			goto IL_00f9;
		}
		goto IL_014f;
		IL_00f9:
		int num = -1987986550;
		goto IL_00fe;
		IL_00fe:
		string string_7 = default(string);
		while (true)
		{
			uint num2;
			string text;
			switch ((num2 = (uint)(num ^ -1895653345)) % 12)
			{
			case 11u:
			{
				DependencyInstallerForm form = new DependencyInstallerForm();
				smethod_29(form, string_0, string_1, "vcredist_" + (smethod_19(class154_0) ? "x86" : "x64") + ".exe");
				form.ShowDialog();
				num = -223346627;
				continue;
			}
			case 10u:
				if (!smethod_19(class154_0))
				{
					num = (int)((num2 * 1464400382) ^ 0x496C19CE);
					continue;
				}
				text = string_4;
				goto IL_0086;
			case 9u:
				smethod_405(class154_0.method_2(), mainForm, string_1, string_7, string_2);
				num = (int)(num2 * 2025920650) ^ -323971473;
				continue;
			case 7u:
				break;
			case 5u:
				text = string_5;
				goto IL_0086;
			case 1u:
				num = ((!Class127.bool_1) ? 48887343 : 763773503) ^ ((int)num2 * -726703909);
				continue;
			case 0u:
				goto end_IL_00fe;
			default:
				return;
			case 4u:
				goto IL_014f;
			case 2u:
				return;
			case 3u:
				smethod_177(string_2, mainForm, class154_0.method_2());
				return;
			case 6u:
				return;
			case 8u:
				return;
				IL_0086:
				string_7 = text;
				num = -1972545494;
				continue;
			}
			num = (Class127.bool_1 ? (-1053013471) : (-223346627));
			continue;
			end_IL_00fe:
			break;
		}
		goto IL_00f9;
		IL_014f:
		num = (smethod_337(mainForm, class154_0.method_2(), string_2, string_3, bool_1, string.Format("Microsoft Visual C++ {0} Runtime", string_6)) ? (-94053324) : (-627536497));
		goto IL_00fe;
	}

	internal static Class11 smethod_204(TabControl tabControl_0)
	{
		return new Class11(tabControl_0);
	}

	internal static void smethod_205(Class63 class63_0, Class53 class53_0, Class63 class63_1)
	{
		smethod_137(class53_0, Enum7.const_64, class63_0, class63_1);
	}

	internal static Class89.Enum44 smethod_206(Class89 class89_0)
	{
		Class89.Enum44 @enum = (Class89.Enum44)0;
		while (true)
		{
			int num = 1854214070;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4707AFE7)) % 12)
				{
				case 11u:
					@enum |= Class89.Enum44.flag_4;
					num = ((int)num2 * -1520174881) ^ -852355327;
					continue;
				case 9u:
					@enum |= Class89.Enum44.flag_1;
					num = ((int)num2 * -2001017929) ^ -1916017482;
					continue;
				case 8u:
					num = (class89_0.method_30() ? 1136704172 : 1413423956);
					continue;
				case 7u:
					num = ((!class89_0.method_32()) ? 953982681 : 1340603571);
					continue;
				case 6u:
					num = ((!class89_0.method_26()) ? 1263587133 : 1006590223);
					continue;
				case 4u:
					@enum |= Class89.Enum44.flag_2;
					num = (int)((num2 * 561684884) ^ 0x2E96691D);
					continue;
				case 3u:
					@enum |= Class89.Enum44.flag_3;
					num = ((int)num2 * -450798947) ^ -406828320;
					continue;
				case 2u:
					num = ((!class89_0.method_28()) ? 725963719 : 422226548);
					continue;
				case 1u:
					num = (class89_0.method_24() ? (-1226952485) : (-62108980)) ^ (int)(num2 * 455416225);
					continue;
				case 0u:
					@enum |= Class89.Enum44.flag_0;
					num = (int)((num2 * 285533461) ^ 0x7E9C673D);
					continue;
				case 5u:
					break;
				default:
					return @enum;
				}
				break;
			}
		}
	}

	[DllImport("psapi.dll", SetLastError = true)]
	internal static extern bool EnumProcesses(uint[] uint_0, uint uint_1, out uint uint_2);

	[DllImport("shell32.dll")]
	internal static extern void DragAcceptFiles(IntPtr intptr_0, bool bool_0);

	internal static Class49.Delegate0 smethod_207()
	{
		IntPtr intPtr = Marshal.ReadIntPtr(Marshal.ReadIntPtr(((Class55)smethod_51()).intptr_0), 4 * IntPtr.Size);
		if (Class49.bool_0)
		{
			goto IL_0118;
		}
		goto IL_020d;
		IL_0118:
		int num = 146084594;
		goto IL_01ba;
		IL_01ba:
		int num3 = default(int);
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		byte[] array = default(byte[]);
		int num5 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		int num4 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x1C5256E8)) % 16)
			{
			case 15u:
				num3 = smethod_419(array2, "è\0\0\0\0H\u008BËè", "x????xxxx", 0);
				num = ((num3 != -1) ? (-94460459) : (-64714969)) ^ (int)(num2 * 1572366844);
				continue;
			case 14u:
				num6 = BitConverter.ToInt32(array, num5 + 3);
				intPtr2 = intPtr.smethod_8(num5 + 2 + num6 + 5);
				array = new byte[100];
				num = 1239470229;
				continue;
			case 13u:
				Marshal.Copy(intPtr2, array, 0, array.Length);
				num = ((int)num2 * -1554020668) ^ -756453442;
				continue;
			case 12u:
				num6 = BitConverter.ToInt32(array, num5 + 1);
				num = 2858573;
				continue;
			case 10u:
				array2 = new byte[100];
				Marshal.Copy(intPtr, array2, 0, array2.Length);
				num = (int)((num2 * 1972141925) ^ 0x5F09AF55);
				continue;
			case 9u:
				num4 = BitConverter.ToInt32(array2, num3 + 1);
				num = 1165531760;
				continue;
			case 7u:
				break;
			case 2u:
				num5 = smethod_419(array, "è\0\0\0\0Vè\0\0\0\0\u0083Ä\b", "x????xx????xxx", 0);
				num = ((num5 != -1) ? 830833092 : 1079343950) ^ (int)(num2 * 1178614576);
				continue;
			case 1u:
				num = ((num5 != -1) ? (-2037255687) : (-600563405)) ^ ((int)num2 * -1288864625);
				continue;
			case 0u:
				num5 = smethod_419(array, "j\0è", "xxx", 0);
				num = (int)((num2 * 1624723693) ^ 0x5F35D519);
				continue;
			case 3u:
				goto IL_020d;
			case 4u:
				return null;
			default:
				return (Class49.Delegate0)Marshal.GetDelegateForFunctionPointer(intPtr2.smethod_8(num5 + num6 + 5), typeof(Class49.Delegate0));
			case 6u:
				return null;
			case 8u:
				return (Class49.Delegate0)Marshal.GetDelegateForFunctionPointer(intPtr.smethod_8(num3 + num4 + 5), typeof(Class49.Delegate0));
			case 11u:
				return null;
			}
			break;
		}
		goto IL_0118;
		IL_020d:
		array = new byte[20];
		Marshal.Copy(intPtr, array, 0, array.Length);
		num = 1286306376;
		goto IL_01ba;
	}

	internal static void smethod_208(GClass4 gclass4_0)
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
		List<GClass4.Class132> list = default(List<GClass4.Class132>);
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

	internal static bool smethod_209(Assembly assembly_0, Assembly assembly_1)
	{
		return true;
	}

	internal static int smethod_210(Class179.Class182 class182_0)
	{
		return class182_0.int_1;
	}

	internal static GClass2 smethod_211()
	{
		return smethod_183(GetCurrentProcess(), (int)GetCurrentProcessId());
	}

	internal static void WaitWithStatus(MainForm mainForm, int int_0, string string_0)
	{
		for (int elapsedMilliseconds = 0; elapsedMilliseconds < int_0; elapsedMilliseconds += 100)
		{
			float remainingSeconds = (float)(int_0 - elapsedMilliseconds) / 1000f;
			mainForm.BeginInvoke((Action)(() =>
			{
				mainForm.processDescriptionLabel.Text = string.Format(string_0, remainingSeconds);
			}));
			Thread.Sleep(100);
		}
	}

	internal static Win32Exception smethod_213(uint uint_0, Class84 class84_0)
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

	internal static void ShowProcessInspector(GClass2 gclass2_0)
	{
		ProcessInspectorForm form = new ProcessInspectorForm();
		form.method_1(gclass2_0);
		form.ShowDialog();
	}

	internal static Class154 smethod_215(GClass1 gclass1_0)
	{
		Stream0 stream = new Stream0(gclass1_0.gclass2_0, gclass1_0.method_0(), Enum15.const_0, gclass1_0.method_4());
		try
		{
			return Class6.smethod_4(stream, bool_0: false, Enum39.const_1);
		}
		finally
		{
			if (stream != null)
			{
				while (true)
				{
					IL_005a:
					int num = 14819409;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x192C7112)) % 3)
						{
						case 1u:
							goto IL_002a;
						default:
							goto end_IL_003d;
						case 2u:
							break;
						case 0u:
							goto end_IL_003d;
						}
						goto IL_005a;
						IL_002a:
						((IDisposable)stream).Dispose();
						num = ((int)num2 * -1708580224) ^ -2062428185;
						continue;
						end_IL_003d:
						break;
					}
					break;
				}
			}
		}
	}

	internal static bool InjectModule(ref IntPtr intptr_0, MainForm mainForm, [Out] ScramblePreset enum3_0, string string_0)
	{
		string modulePath = string_0;
		intptr_0 = IntPtr.Zero;
		FileStream fileStream = new FileStream(modulePath, FileMode.Open, FileAccess.Read, FileShare.Read);
		bool result = default(bool);
		try
		{
			Class154 class154_ = Class7.smethod_13(fileStream, modulePath, bool_0: false, Enum39.const_0);
			bool moduleIs32Bit = smethod_19(class154_);
			bool processIs32Bit = smethod_427(mainForm.selectedProcess);
			if (moduleIs32Bit != processIs32Bit)
			{
				mainForm.Invoke((MethodInvoker)delegate
				{
					string modulePlatform = moduleIs32Bit ? "32-bit" : "64-bit";
					string processPlatform = processIs32Bit ? "32-bit" : "64-bit";
					MessageBox.Show(mainForm, "Platform mismatch detected. You are trying to inject a " + modulePlatform + " DLL (" + Path.GetFileName(modulePath) + ") into a " + processPlatform + " process (" + mainForm.selectedProcess.method_2() + ") which is not supported.", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				});
				result = false;
				goto IL_072f;
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0110:
					int num = 1014200609;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x7007E065)) % 3)
						{
						case 2u:
							goto IL_00dd;
						default:
							goto end_IL_00f2;
						case 0u:
							break;
						case 1u:
							goto end_IL_00f2;
						}
						goto IL_0110;
						IL_00dd:
						((IDisposable)fileStream).Dispose();
						num = ((int)num2 * -1430391361) ^ -252574851;
						continue;
						end_IL_00f2:
						break;
					}
					break;
				}
			}
		}
		InjectionOptions class14_ = ApplicationSettings.Current.Options;
		string text2 = default(string);
		string text = default(string);
		string path = default(string);
		while (true)
		{
			int num3 = 1481290001;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num3 ^ 0x7007E065)) % 8)
				{
				case 7u:
					text2 = Path.Combine(Path.GetDirectoryName(modulePath), Path.GetFileNameWithoutExtension(modulePath) + "_Scrambled");
					num3 = (int)((num2 * 2095241435) ^ 0x27DE295E);
					continue;
				case 5u:
					break;
				case 4u:
					text = modulePath;
					num3 = ((int)num2 * -646710067) ^ 0x277534FB;
					continue;
				case 3u:
					modulePath = smethod_147(".dll");
					num3 = ((int)num2 * -1611286360) ^ 0x15D10E84;
					continue;
				case 2u:
					num3 = (class14_.StealthInject ? 1887908592 : 1097553202) ^ ((int)num2 * -801763565);
					continue;
				case 1u:
					goto IL_01ee;
				case 0u:
					goto end_IL_01f9;
				default:
					goto IL_02a1;
				}
				if (text == modulePath)
				{
					num3 = (int)((num2 * 715549268) ^ 0x27A7E93E);
					continue;
				}
				goto IL_03cd;
				IL_02a1:
				string extension = Path.GetExtension(modulePath);
				modulePath = text2 + extension;
				try
				{
					if (File.Exists(modulePath))
					{
						while (true)
						{
							IL_0303:
							int num4 = 175693255;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x7007E065)) % 3)
								{
								case 1u:
									goto IL_02cc;
								default:
									goto end_IL_02e5;
								case 2u:
									break;
								case 0u:
									goto end_IL_02e5;
								}
								goto IL_0303;
								IL_02cc:
								File.Delete(modulePath);
								num4 = (int)(num2 * 692291241) ^ -638726554;
								continue;
								end_IL_02e5:
								break;
							}
							break;
						}
					}
				}
				catch
				{
					int num5 = 1;
					while (true)
					{
						IL_03c4:
						int num6 = 690991702;
						while (true)
						{
							switch ((num2 = (uint)(num6 ^ 0x7007E065)) % 6)
							{
							case 5u:
								num5++;
								num6 = 929048651;
								continue;
							case 4u:
								num6 = ((!File.Exists(path)) ? (-277627350) : (-1407187072)) ^ ((int)num2 * -1010120620);
								continue;
							case 1u:
								num6 = (int)(num2 * 722033706) ^ -1517094891;
								continue;
							case 0u:
								path = (modulePath = text2 + "_" + num5 + extension);
								num6 = 1608583659;
								continue;
							default:
								goto end_IL_039a;
							case 2u:
								break;
							case 3u:
								goto end_IL_039a;
							}
							goto IL_03c4;
							continue;
							end_IL_039a:
							break;
						}
						break;
					}
				}
				goto IL_03cd;
				IL_01ee:
				if (enum3_0 != ScramblePreset.None)
				{
					num3 = 1616631776;
					continue;
				}
				while (true)
				{
					int num7 = ((!(text != modulePath)) ? 1063043804 : 624167310);
					while (true)
					{
						switch ((num2 = (uint)(num7 ^ 0x7007E065)) % 4)
						{
						case 3u:
							File.Copy(text, modulePath);
							num7 = (int)(num2 * 1223685243) ^ -636052171;
							continue;
						case 0u:
							num7 = 1141830131;
							continue;
						case 2u:
							break;
						default:
							goto end_IL_0291;
						}
						break;
					}
					continue;
					end_IL_0291:
					break;
				}
				goto IL_03da;
				IL_03cd:
				smethod_325(mainForm, text, modulePath);
				goto IL_03da;
				IL_03da:
				InjectionMethod enum4_ = class14_.Method;
				try
				{
					if (enum4_ == InjectionMethod.ManualMap)
					{
						AdvancedInjectionOptions class13_ = class14_.Advanced;
						Class89 class3 = new Class89(mainForm.selectedProcess);
						try
						{
							class3.method_18(class13_.HideFromDebugger);
							class3.method_25(class13_.DisableExceptionSupport);
							while (true)
							{
								IL_04a1:
								int num8 = 2077823332;
								while (true)
								{
									int num9;
									switch ((num2 = (uint)(num8 ^ 0x7007E065)) % 4)
									{
									case 1u:
										class3.method_31(class13_.ManualResolveImports);
										class3.method_27(class14_.ErasePeHeaders);
										class3.method_33(class13_.DisableSehValidation);
							intptr_0 = class3.method_0BA6(modulePath);
										num9 = ((class3.method_34() != null) ? 1628520009 : 932593972);
										goto IL_0475;
									default:
										goto end_IL_047f;
									case 0u:
										break;
									case 3u:
										throw class3.method_34();
									case 2u:
										goto end_IL_047f;
									}
									goto IL_04a1;
									IL_0475:
									num8 = num9 ^ (int)(num2 * 1769376855);
									continue;
									end_IL_047f:
									break;
								}
								break;
							}
						}
						finally
						{
							if (class3 != null)
							{
								while (true)
								{
									IL_04ee:
									int num10 = 981285000;
									while (true)
									{
										switch ((num2 = (uint)(num10 ^ 0x7007E065)) % 3)
										{
										case 1u:
											goto IL_04bb;
										default:
											goto end_IL_04d0;
										case 2u:
											break;
										case 0u:
											goto end_IL_04d0;
										}
										goto IL_04ee;
										IL_04bb:
										((IDisposable)class3).Dispose();
										num10 = ((int)num2 * -934255860) ^ -977679286;
										continue;
										end_IL_04d0:
										break;
									}
									break;
								}
							}
						}
					}
					else
					{
						Class85 class4 = (Class85)Activator.CreateInstance(MainForm.dictionary_0[enum4_], mainForm.selectedProcess);
						class4.method_18(class14_.Advanced.HideFromDebugger);
						while (true)
						{
							int num11 = 1553830076;
							while (true)
							{
								switch ((num2 = (uint)(num11 ^ 0x7007E065)) % 3)
								{
								case 2u:
									intptr_0 = class4.method_0BA6(modulePath);
									num11 = ((int)num2 * -1040866324) ^ 0x102DE663;
									continue;
								case 0u:
									break;
								default:
									goto end_IL_056b;
								}
								break;
							}
							continue;
							end_IL_056b:
							break;
						}
						if (class14_.ErasePeHeaders)
						{
							try
							{
								Class94 class5 = new Class94(mainForm.selectedProcess);
								try
								{
									class5.method_19(intptr_0);
								}
								finally
								{
									if (class5 != null)
									{
										while (true)
										{
											IL_05ce:
											int num12 = 1288609482;
											while (true)
											{
												switch ((num2 = (uint)(num12 ^ 0x7007E065)) % 3)
												{
												case 1u:
													goto IL_059b;
												default:
													goto end_IL_05b0;
												case 2u:
													break;
												case 0u:
													goto end_IL_05b0;
												}
												goto IL_05ce;
												IL_059b:
												((IDisposable)class5).Dispose();
												num12 = ((int)num2 * -1012506106) ^ 0x577DA4AC;
												continue;
												end_IL_05b0:
												break;
											}
											break;
										}
									}
								}
							}
							catch (Exception exception_)
							{
								ShowInjectionError(mainForm, "An error occurred while erasing the PE for \"" + Path.GetFileName(text) + "\"", exception_);
							}
						}
						if (class14_.HideModule)
						{
							try
							{
								smethod_327(new Class129(mainForm.selectedProcess), intptr_0);
							}
							catch (Exception exception_2)
							{
								ShowInjectionError(mainForm, "An error occurred while hiding the module (" + Path.GetFileName(text) + ").", exception_2);
							}
						}
					}
					if (intptr_0 == IntPtr.Zero)
					{
						goto IL_0659;
					}
					goto IL_0680;
					IL_0680:
					result = true;
					int num13 = 726568866;
					goto IL_065e;
					IL_0659:
					num13 = 1978625527;
					goto IL_065e;
					IL_065e:
					switch ((uint)(num13 ^ 0x7007E065) % 4u)
					{
					case 0u:
						break;
					default:
						goto end_IL_03e1;
					case 1u:
						goto IL_0680;
					case 2u:
						throw new Exception("The injection method used returned NULL (injection failed).");
					case 3u:
						goto end_IL_03e1;
					}
					goto IL_0659;
					end_IL_03e1:;
				}
				catch (Exception exception_3)
				{
					while (true)
					{
						IL_0726:
						int num14 = 407330830;
						while (true)
						{
							switch ((num2 = (uint)(num14 ^ 0x7007E065)) % 3)
							{
							case 1u:
								goto IL_06a6;
							default:
								goto end_IL_0708;
							case 0u:
								break;
							case 2u:
								goto end_IL_0708;
							}
							goto IL_0726;
							IL_06a6:
							ShowInjectionError(mainForm, "An error occurred while injecting \"" + Path.GetFileName(text) + "\" into \"" + mainForm.selectedProcess.method_2() + "\".", exception_3);
							result = false;
							num14 = (int)(num2 * 649623379) ^ -1756034482;
							continue;
							end_IL_0708:
							break;
						}
						break;
					}
				}
				goto end_IL_022b;
				continue;
				end_IL_01f9:
				break;
			}
			continue;
			end_IL_022b:
			break;
		}
		goto IL_072f;
		IL_072f:
		return result;
	}

	internal static void smethod_217(Class5 class5_0, int int_0)
	{
		class5_0.BaseStream.Position += int_0;
	}

	internal static Class56.Struct8 smethod_218(Class56 class56_0)
	{
		return Class56.smethod_0<Class56.Struct7, Class56.Struct8>(class56_0.method_0());
	}

	internal static Class56.Struct12 smethod_219(Class56 class56_0)
	{
		return Class56.smethod_0<Class56.Struct7, Class56.Struct12>(class56_0.method_0());
	}

	internal static void smethod_220(Enum12 enum12_0, Class58 class58_0, Class53 class53_0)
	{
		smethod_256(class58_0, enum12_0, class53_0, Enum7.const_223);
	}

	internal static Class59 smethod_221(Class47 class47_0, Class58 class58_0, long long_0)
	{
		if (class47_0.bool_0)
		{
			class47_0.class53_0.struct19_0.uint_2 |= 8u;
			return smethod_126(class58_0, long_0);
		}
		return smethod_329(class58_0, long_0);
	}

	[DllImport("psapi.dll")]
	internal static extern uint GetProcessImageFileName(IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, uint uint_0);

	internal static void smethod_222(Class53 class53_0, int int_0)
	{
		smethod_308(4L, int_0, class53_0);
	}

	internal static IntPtr smethod_223(Class96 class96_0, int int_0)
	{
		return class96_0.method_17().smethod_8(class96_0.int_1[int_0]);
	}

	internal static int smethod_224(ref Struct31 struct31_0)
	{
		return Class67.delegate44_0(ref struct31_0);
	}

	internal static IntPtr smethod_225(GClass1 gclass1_0, string string_0, bool bool_0)
	{
		return gclass1_0.method_14(string_0, bool_0);
	}

	internal static void smethod_226(Class47 class47_0, int int_0)
	{
		if (class47_0.bool_0)
		{
			goto IL_0175;
		}
		goto IL_04bf;
		IL_0175:
		int num = 1189979764;
		goto IL_0435;
		IL_0435:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2A5C47ED)) % 30)
			{
			case 29u:
				smethod_418(13, class47_0.class53_0);
				num = (int)((num2 * 1729407365) ^ 0x53F0594C);
				continue;
			case 28u:
				smethod_418(232, class47_0.class53_0);
				num = (int)((num2 * 1474013262) ^ 0x2EE43B2F);
				continue;
			case 27u:
				num = (int)((num2 * 744374997) ^ 0x7B48A303);
				continue;
			case 26u:
				smethod_360(class47_0.class53_0, smethod_167((int_0 == -1) ? 4 : int_0));
				smethod_227(class47_0);
				num = 1126171423;
				continue;
			case 24u:
				smethod_171(class47_0.class53_0, Class49.class63_42);
				num = (int)(num2 * 906442768) ^ -1189727333;
				continue;
			case 22u:
				class47_0.method_3(smethod_252(class47_0.class53_0));
				num = ((int)num2 * -1394908335) ^ -437876051;
				continue;
			case 21u:
				smethod_429(class47_0.class53_0, Class49.class63_41, smethod_126(class47_0.class58_1, 0L));
				num = ((int)num2 * -569134392) ^ 0x11EF1979;
				continue;
			case 20u:
				smethod_439(class47_0.class53_0, 0u);
				smethod_418(199, class47_0.class53_0);
				smethod_418(68, class47_0.class53_0);
				num = ((int)num2 * -2048412739) ^ 0x572A5D58;
				continue;
			case 19u:
				smethod_418(36, class47_0.class53_0);
				num = ((int)num2 * -1184774464) ^ 0x422D2851;
				continue;
			case 18u:
				smethod_347(class47_0.class53_0);
				num = 1817863374;
				continue;
			case 17u:
				break;
			case 16u:
				smethod_429(class47_0.class53_0, Class49.class63_55, smethod_238(Class49.class63_57, 16L));
				num = (int)(num2 * 718733664) ^ -738810777;
				continue;
			case 15u:
				smethod_227(class47_0);
				smethod_36(class47_0.class53_0, class47_0.class58_0);
				num = (int)((num2 * 274840067) ^ 0x456F7748);
				continue;
			case 14u:
				smethod_36(class47_0.class53_0, class47_0.class58_1);
				num = (int)(num2 * 874890200) ^ -328666880;
				continue;
			case 13u:
				smethod_418(0, class47_0.class53_0);
				smethod_418(0, class47_0.class53_0);
				smethod_418(0, class47_0.class53_0);
				num = ((int)num2 * -1220556248) ^ -360329765;
				continue;
			case 12u:
				smethod_360(class47_0.class53_0, smethod_167((int_0 == -1) ? 4 : int_0));
				num = 1996083784;
				continue;
			case 11u:
				goto IL_0258;
			case 10u:
				class47_0.class53_0.struct19_0.uint_2 |= 8u;
				num = ((int)num2 * -139110068) ^ -1940251412;
				continue;
			case 9u:
				num = ((!class47_0.bool_1) ? 1938258210 : 2103563978) ^ ((int)num2 * -871427367);
				continue;
			case 8u:
				smethod_320(class47_0.class53_0, new byte[class47_0.int_0]);
				num = (int)(num2 * 280379461) ^ -229724170;
				continue;
			case 7u:
				smethod_429(class47_0.class53_0, Class49.class63_62, smethod_238(Class49.class63_57, 32L));
				num = ((int)num2 * -888350539) ^ 0x7F181E17;
				continue;
			case 6u:
				smethod_418(131, class47_0.class53_0);
				smethod_418(4, class47_0.class53_0);
				smethod_418(36, class47_0.class53_0);
				num = ((int)num2 * -1211377801) ^ 0x18DBC4D2;
				continue;
			case 5u:
				smethod_439(class47_0.class53_0, 0u);
				num = (int)((num2 * 1288639036) ^ 0x70711738);
				continue;
			case 4u:
				smethod_429(class47_0.class53_0, Class49.class63_61, smethod_238(Class49.class63_57, 24L));
				num = ((int)num2 * -2091822961) ^ -1277348170;
				continue;
			case 3u:
				smethod_318(class47_0.class53_0, Class49.class63_41, Class49.class63_42);
				num = ((int)num2 * -562338653) ^ -666257430;
				continue;
			case 2u:
				smethod_418(4, class47_0.class53_0);
				smethod_418(35, class47_0.class53_0);
				num = ((int)num2 * -1008665874) ^ -1379574234;
				continue;
			case 1u:
				num = ((int)num2 * -377100248) ^ 0x196F8D06;
				continue;
			case 0u:
				smethod_418(203, class47_0.class53_0);
				num = ((int)num2 * -231773239) ^ 0x1B90B079;
				continue;
			default:
				return;
			case 25u:
				goto IL_04bf;
			case 23u:
				return;
			}
			break;
			IL_0258:
			num = ((!smethod_49(class47_0.class58_0, null)) ? 206547758 : 295699762);
		}
		goto IL_0175;
		IL_04bf:
		smethod_429(class47_0.class53_0, Class49.class63_54, smethod_238(Class49.class63_57, 8L));
		num = 113233291;
		goto IL_0435;
	}

	internal static void smethod_227(Class47 class47_0)
	{
		smethod_200(class47_0.class53_0, class47_0.bool_0 ? 4u : 8u);
	}

	internal static long smethod_228(Class138 class138_0)
	{
		return class138_0.long_0;
	}

	internal static bool smethod_229(Class129 class129_0, GClass1 gclass1_0)
	{
		return smethod_133(class129_0, gclass1_0.method_10() ? ((Class117)smethod_255(class129_0.method_0())) : ((Class117)smethod_369(class129_0.method_0())), gclass1_0.method_0());
	}

	internal static Class146 smethod_230(Class154 class154_0, Class5 class5_0)
	{
		Class157 @class = class154_0.method_6().method_3().imethod_49()[5];
		long num3 = default(long);
		while (true)
		{
			int num = -986286837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -89417837)) % 12)
				{
				case 11u:
					num3 = smethod_135(class154_0, @class.method_0());
					num = -904342158;
					continue;
				case 10u:
					num = ((!class5_0.imethod_0(num3)) ? 1897255325 : 1795174784) ^ ((int)num2 * -528952732);
					continue;
				case 7u:
					num = ((num3 + @class.method_2() <= class5_0.BaseStream.Length) ? (-1935543753) : (-947981668));
					continue;
				case 6u:
					num = ((@class.method_2() == 0) ? 212981327 : 1056417020) ^ (int)(num2 * 2022940474);
					continue;
				case 5u:
					num = ((num3 != -1L) ? 1357502099 : 260166383) ^ ((int)num2 * -1258185318);
					continue;
				case 4u:
					num = ((@class.method_0() == 0) ? 874644619 : 1370116925) ^ ((int)num2 * -394709219);
					continue;
				case 0u:
					smethod_157(class5_0, num3);
					num = -593310486;
					continue;
				case 9u:
					break;
				default:
					return new Class146(class5_0, class154_0);
				case 2u:
					return null;
				case 3u:
					return null;
				case 8u:
					return null;
				}
				break;
			}
		}
	}

	internal static GClass1 smethod_231(GClass1 gclass1_0, string string_0)
	{
		string text = smethod_440(string_0, null, null, (Enum43)(2 | (smethod_379(gclass1_0.gclass2_0) ? 8 : 0)), 0, IntPtr.Zero);
		GClass1 result = default(GClass1);
		while (true)
		{
			int num = 1991169265;
			while (true)
			{
				int num5;
				uint num2;
				switch ((num2 = (uint)(num ^ 0x73180430)) % 4)
				{
				case 1u:
					num5 = ((!string.IsNullOrEmpty(text)) ? 1149833949 : 1014053732);
					goto IL_0042;
				case 0u:
					break;
				case 2u:
					return null;
				default:
					try
					{
						if (!(FileVersionInfo.GetVersionInfo(text).CompanyName != "Microsoft Corporation"))
						{
							Class87 @class = new Class87(gclass1_0.gclass2_0);
							try
							{
								IntPtr intPtr = @class.method_0BA6(text);
								if (!(intPtr == IntPtr.Zero))
								{
									goto IL_00bb;
								}
								object obj = null;
								goto IL_00ef;
								IL_00de:
								obj = smethod_196(smethod_42(gclass1_0.gclass2_0), intPtr);
								goto IL_00ef;
								IL_00ef:
								result = (GClass1)obj;
								int num3 = 693599755;
								goto IL_00c0;
								IL_00c0:
								switch ((uint)(num3 ^ 0x73180430) % 3u)
								{
								case 0u:
									break;
								default:
									goto end_IL_00a3;
								case 1u:
									goto IL_00de;
								case 2u:
									goto end_IL_00a3;
								}
								goto IL_00bb;
								IL_00bb:
								num3 = 1761742619;
								goto IL_00c0;
								end_IL_00a3:;
							}
							finally
							{
								if (@class != null)
								{
									while (true)
									{
										IL_0130:
										int num4 = 837427947;
										while (true)
										{
											switch ((num2 = (uint)(num4 ^ 0x73180430)) % 3)
											{
											case 1u:
												goto IL_00fe;
											default:
												goto end_IL_0112;
											case 2u:
												break;
											case 0u:
												goto end_IL_0112;
											}
											goto IL_0130;
											IL_00fe:
											((IDisposable)@class).Dispose();
											num4 = (int)((num2 * 1222569326) ^ 0x1B7806DD);
											continue;
											end_IL_0112:
											break;
										}
										break;
									}
								}
							}
						}
						else
						{
							result = null;
						}
					}
					catch
					{
						result = null;
					}
					return result;
				}
				break;
				IL_0042:
				num = num5 ^ ((int)num2 * -557636338);
			}
		}
	}

	internal static int smethod_232(Type type_0)
	{
		if (!Class127.dictionary_0.TryGetValue(type_0, out var value))
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
						Class127.dictionary_0.Add(type_0, value = smethod_18(type_0));
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

	internal static void smethod_233(ManualMapOptionsForm form2_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ManualMapOptionsForm));
		while (true)
		{
			int num = 1286435599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3DF4862C)) % 47)
				{
				case 46u:
					form2_0.checkBox_3.AutoSize = true;
					form2_0.checkBox_3.Location = new Point(10, 67);
					form2_0.checkBox_3.Name = "disableHandlerValidationCheckBox";
					form2_0.checkBox_3.Size = new Size(184, 17);
					form2_0.checkBox_3.TabIndex = 2;
					num = ((int)num2 * -1841048426) ^ 0x447E8E3B;
					continue;
				case 45u:
					form2_0.groupBox_0.Size = new Size(199, 93);
					num = ((int)num2 * -558020846) ^ 0x4BCCC31B;
					continue;
				case 43u:
					form2_0.groupBox_0.Controls.Add(form2_0.checkBox_3);
					num = ((int)num2 * -1682726095) ^ -2050862917;
					continue;
				case 42u:
					form2_0.checkBox_2.Size = new Size(173, 17);
					num = (int)((num2 * 2143584893) ^ 0x4FC7E0A3);
					continue;
				case 41u:
					form2_0.AutoScaleMode = AutoScaleMode.Dpi;
					num = ((int)num2 * -1480903020) ^ -919384540;
					continue;
				case 40u:
					form2_0.groupBox_1.Name = "generalOptions";
					form2_0.groupBox_1.Size = new Size(199, 47);
					form2_0.groupBox_1.TabIndex = 2;
					num = (int)((num2 * 1615262741) ^ 0x2879C19E);
					continue;
				case 39u:
					form2_0.checkBox_1.Name = "manuallyResolveCheckBox";
					num = (int)((num2 * 730982378) ^ 0x565AE362);
					continue;
				case 38u:
					form2_0.checkBox_2.Name = "hideFromDebuggerCheckBox";
					num = ((int)num2 * -316615933) ^ 0x5274D75A;
					continue;
				case 37u:
					form2_0.checkBox_2.Text = "Hide threads from debugger";
					form2_0.checkBox_2.UseVisualStyleBackColor = true;
					form2_0.checkBox_2.CheckedChanged += form2_0.method_0;
					num = ((int)num2 * -485035542) ^ -804350330;
					continue;
				case 36u:
					form2_0.checkBox_1 = new CheckBox();
					num = (int)(num2 * 1622681415) ^ -154911134;
					continue;
				case 35u:
					form2_0.groupBox_1.PerformLayout();
					num = (int)(num2 * 1758641446) ^ -1026621650;
					continue;
				case 34u:
					form2_0.checkBox_1.Size = new Size(140, 17);
					form2_0.checkBox_1.TabIndex = 0;
					form2_0.checkBox_1.Text = "Manually map imports";
					num = ((int)num2 * -832232227) ^ -1423454085;
					continue;
				case 33u:
					form2_0.groupBox_0.TabIndex = 1;
					form2_0.groupBox_0.TabStop = false;
					num = (int)((num2 * 1973525920) ^ 0x2F1F7FF4);
					continue;
				case 32u:
					form2_0.checkBox_3 = new CheckBox();
					form2_0.checkBox_0 = new CheckBox();
					num = (int)((num2 * 366590973) ^ 0x34B8E0);
					continue;
				case 31u:
					form2_0.checkBox_3.Text = "Disable SEH handler validation";
					num = (int)(num2 * 2076113155) ^ -1960891467;
					continue;
				case 30u:
					form2_0.groupBox_0.Location = new Point(12, 65);
					num = ((int)num2 * -853582256) ^ -985537447;
					continue;
				case 29u:
					form2_0.checkBox_0.CheckedChanged += form2_0.method_2;
					num = (int)((num2 * 1755340225) ^ 0x5663EBD);
					continue;
				case 28u:
					form2_0.groupBox_0.SuspendLayout();
					num = (int)((num2 * 1252007216) ^ 0x6DE0FBFC);
					continue;
				case 27u:
					form2_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = (int)(num2 * 623997504) ^ -441492064;
					continue;
				case 26u:
					form2_0.checkBox_0.TabIndex = 1;
					form2_0.checkBox_0.Text = "Disable exception support";
					form2_0.checkBox_0.UseVisualStyleBackColor = true;
					num = (int)(num2 * 918020437) ^ -2118819917;
					continue;
				case 25u:
					form2_0.Name = "AdvancedSettingsForm";
					form2_0.StartPosition = FormStartPosition.CenterParent;
					form2_0.Text = "Advanced Settings";
					num = (int)(num2 * 1465955018) ^ -1411775573;
					continue;
				case 24u:
					form2_0.groupBox_1.TabStop = false;
					form2_0.groupBox_1.Text = "General";
					form2_0.checkBox_2.AutoSize = true;
					form2_0.checkBox_2.Location = new Point(10, 21);
					num = ((int)num2 * -1357569558) ^ 0x1FD4E4E6;
					continue;
				case 23u:
					form2_0.groupBox_1.SuspendLayout();
					num = ((int)num2 * -1772395188) ^ 0x48FBA94B;
					continue;
				case 22u:
					form2_0.groupBox_0.Name = "manualMapGroupBox";
					num = ((int)num2 * -549904218) ^ -1974310541;
					continue;
				case 21u:
					form2_0.groupBox_1.ResumeLayout(performLayout: false);
					num = (int)((num2 * 1722255766) ^ 0x2D7EE2DA);
					continue;
				case 20u:
					form2_0.groupBox_1.Controls.Add(form2_0.checkBox_2);
					form2_0.groupBox_1.Location = new Point(12, 12);
					num = (int)((num2 * 610097106) ^ 0x235ABEA7);
					continue;
				case 19u:
					form2_0.groupBox_0.PerformLayout();
					num = (int)(num2 * 336119588) ^ -771375962;
					continue;
				case 18u:
					form2_0.Controls.Add(form2_0.groupBox_1);
					form2_0.Controls.Add(form2_0.groupBox_0);
					form2_0.Font = new Font("Segoe UI", 8.25f);
					num = (int)((num2 * 592057581) ^ 0x26EDD48F);
					continue;
				case 17u:
					form2_0.groupBox_0.Controls.Add(form2_0.checkBox_1);
					num = ((int)num2 * -177578953) ^ -341059023;
					continue;
				case 16u:
					form2_0.checkBox_2 = new CheckBox();
					num = ((int)num2 * -1827111395) ^ 0x31A1FD9;
					continue;
				case 15u:
					form2_0.ResumeLayout(performLayout: false);
					num = (int)((num2 * 2121185601) ^ 0x649D8C0D);
					continue;
				case 14u:
					form2_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
					num = ((int)num2 * -1660421897) ^ 0x5D3FA4C9;
					continue;
				case 13u:
					form2_0.checkBox_3.UseVisualStyleBackColor = true;
					form2_0.checkBox_3.CheckedChanged += form2_0.method_3;
					num = (int)(num2 * 663739557) ^ -1036692927;
					continue;
				case 12u:
					form2_0.checkBox_1.AutoSize = true;
					form2_0.checkBox_1.Location = new Point(10, 21);
					num = ((int)num2 * -1491262952) ^ 0x47A6F5B9;
					continue;
				case 11u:
					form2_0.ClientSize = new Size(223, 170);
					num = (int)((num2 * 2020291074) ^ 0x6F88B133);
					continue;
				case 10u:
					form2_0.checkBox_2.TabIndex = 1;
					num = (int)(num2 * 1552761091) ^ -94033333;
					continue;
				case 9u:
					form2_0.SuspendLayout();
					num = (int)(num2 * 559428801) ^ -1289776847;
					continue;
				case 8u:
					form2_0.groupBox_0.ResumeLayout(performLayout: false);
					num = (int)((num2 * 785730876) ^ 0x107C7CD0);
					continue;
				case 7u:
					form2_0.groupBox_0.Text = "Manual Map Options";
					num = ((int)num2 * -954614082) ^ 0x3044D2D3;
					continue;
				case 6u:
					form2_0.groupBox_1 = new GroupBox();
					num = (int)(num2 * 1835330303) ^ -1831319753;
					continue;
				case 5u:
					form2_0.groupBox_0 = new GroupBox();
					num = ((int)num2 * -1246417789) ^ -731880736;
					continue;
				case 4u:
					form2_0.groupBox_0.Controls.Add(form2_0.checkBox_0);
					num = ((int)num2 * -909554621) ^ -1512998362;
					continue;
				case 2u:
					form2_0.checkBox_0.AutoSize = true;
					form2_0.checkBox_0.Location = new Point(10, 44);
					form2_0.checkBox_0.Name = "disableExceptionsCheckBox";
					form2_0.checkBox_0.Size = new Size(161, 17);
					num = ((int)num2 * -440801927) ^ -884944355;
					continue;
				case 1u:
					form2_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)((num2 * 260883508) ^ 0xC1DFABA);
					continue;
				case 0u:
					form2_0.checkBox_1.UseVisualStyleBackColor = true;
					form2_0.checkBox_1.CheckedChanged += form2_0.method_1;
					num = ((int)num2 * -1415902137) ^ -1232925945;
					continue;
				default:
					return;
				case 3u:
					break;
				case 44u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_234(AdvancedScrambleSettingsForm gform1_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AdvancedScrambleSettingsForm));
		while (true)
		{
			int num = -621873833;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -273116904)) % 86)
				{
				case 85u:
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_2);
					num = (int)(num2 * 23674641) ^ -1662600352;
					continue;
				case 84u:
					gform1_0.groupBox_0.Controls.Add(gform1_0.checkBox_1);
					gform1_0.groupBox_0.Controls.Add(gform1_0.checkBox_0);
					gform1_0.groupBox_0.Location = new Point(12, 12);
					num = ((int)num2 * -2052000843) ^ -901015183;
					continue;
				case 83u:
					gform1_0.groupBox_2.PerformLayout();
					num = (int)(num2 * 661226880) ^ -143114380;
					continue;
				case 82u:
					gform1_0.checkBox_8.AutoSize = true;
					num = ((int)num2 * -389949115) ^ 0x38D66359;
					continue;
				case 81u:
					gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_9);
					num = (int)((num2 * 550708044) ^ 0x3AD190A8);
					continue;
				case 80u:
					gform1_0.checkBox_12 = new CheckBox();
					num = ((int)num2 * -1354268964) ^ 0x1C3AE87D;
					continue;
				case 79u:
					gform1_0.checkBox_6.Location = new Point(9, 159);
					gform1_0.checkBox_6.Name = "createEntryPointCheckBox";
					gform1_0.checkBox_6.Size = new Size(141, 17);
					num = (int)(num2 * 343817644) ^ -897658996;
					continue;
				case 78u:
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_4);
					num = ((int)num2 * -1716003977) ^ 0x463B6FAF;
					continue;
				case 76u:
					gform1_0.ResumeLayout(performLayout: false);
					num = ((int)num2 * -889697329) ^ -1509094071;
					continue;
				case 75u:
					gform1_0.checkBox_1.UseVisualStyleBackColor = true;
					gform1_0.checkBox_0.AutoSize = true;
					num = ((int)num2 * -762260694) ^ -2042309300;
					continue;
				case 74u:
					gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_7);
					num = ((int)num2 * -260042164) ^ -866076368;
					continue;
				case 73u:
					gform1_0.checkBox_11.AutoSize = true;
					gform1_0.checkBox_11.Location = new Point(9, 136);
					num = (int)((num2 * 1750289060) ^ 0x686C64F8);
					continue;
				case 72u:
					gform1_0.checkBox_1.Size = new Size(132, 17);
					gform1_0.checkBox_1.TabIndex = 1;
					gform1_0.checkBox_1.Text = "Remove useless data";
					num = (int)(num2 * 1027668513) ^ -1894667495;
					continue;
				case 71u:
					gform1_0.checkBox_2.Name = "shiftSectionDataCheckBox";
					gform1_0.checkBox_2.Size = new Size(116, 17);
					gform1_0.checkBox_2.TabIndex = 1;
					gform1_0.checkBox_2.Text = "Shift section data";
					num = (int)((num2 * 1281399823) ^ 0x1C69A605);
					continue;
				case 70u:
					gform1_0.groupBox_2.TabIndex = 2;
					gform1_0.groupBox_2.TabStop = false;
					num = (int)(num2 * 945715193) ^ -1007988016;
					continue;
				case 69u:
					gform1_0.checkBox_8.Name = "modifyImportTableCheckBox";
					gform1_0.checkBox_8.Size = new Size(128, 17);
					num = (int)((num2 * 1434085307) ^ 0x37C9571F);
					continue;
				case 68u:
					gform1_0.checkBox_2.Location = new Point(9, 44);
					num = ((int)num2 * -1997802922) ^ 0x4FC78E9;
					continue;
				case 67u:
					gform1_0.checkBox_4.AutoSize = true;
					num = ((int)num2 * -829989855) ^ -1753772205;
					continue;
				case 66u:
					gform1_0.Controls.Add(gform1_0.groupBox_2);
					gform1_0.Controls.Add(gform1_0.groupBox_1);
					gform1_0.Controls.Add(gform1_0.groupBox_0);
					gform1_0.Font = new Font("Segoe UI", 8.25f);
					gform1_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
					gform1_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					gform1_0.Name = "AdvancedScrambleForm";
					gform1_0.StartPosition = FormStartPosition.CenterParent;
					num = (int)(num2 * 282615022) ^ -1464069882;
					continue;
				case 65u:
					gform1_0.groupBox_1.ResumeLayout(performLayout: false);
					num = (int)(num2 * 931311091) ^ -270631796;
					continue;
				case 64u:
					gform1_0.groupBox_0.Text = "Header Options";
					num = (int)((num2 * 172260938) ^ 0x55803483);
					continue;
				case 63u:
					gform1_0.checkBox_9.TabIndex = 5;
					gform1_0.checkBox_9.Text = "Create fake debug directory";
					gform1_0.checkBox_9.UseVisualStyleBackColor = true;
					num = ((int)num2 * -2066208409) ^ 0x1D1BB77F;
					continue;
				case 62u:
					gform1_0.checkBox_6.UseVisualStyleBackColor = true;
					num = ((int)num2 * -52808147) ^ 0x70958A8B;
					continue;
				case 61u:
					gform1_0.checkBox_9 = new CheckBox();
					gform1_0.checkBox_7 = new CheckBox();
					gform1_0.checkBox_8 = new CheckBox();
					num = (int)((num2 * 52638954) ^ 0x29BF9E0);
					continue;
				case 60u:
					gform1_0.checkBox_0.Location = new Point(9, 21);
					gform1_0.checkBox_0.Name = "scrambleFieldsCheckBox";
					gform1_0.checkBox_0.Size = new Size(142, 17);
					gform1_0.checkBox_0.TabIndex = 0;
					num = ((int)num2 * -1557670625) ^ 0x6D60DA7;
					continue;
				case 59u:
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_3);
					gform1_0.groupBox_1.Location = new Point(12, 86);
					gform1_0.groupBox_1.Name = "sectionsGroupBox";
					num = ((int)num2 * -789973812) ^ 0x5390D8C4;
					continue;
				case 58u:
					gform1_0.checkBox_8.TabIndex = 3;
					gform1_0.checkBox_8.Text = "Modify import table";
					gform1_0.checkBox_8.UseVisualStyleBackColor = true;
					gform1_0.checkBox_12.AutoSize = true;
					gform1_0.checkBox_12.Location = new Point(9, 113);
					gform1_0.checkBox_12.Name = "shiftSectionMemoryCheckBox";
					gform1_0.checkBox_12.Size = new Size(133, 17);
					num = (int)(num2 * 1731256801) ^ -61465073;
					continue;
				case 57u:
					gform1_0.groupBox_0 = new GroupBox();
					gform1_0.checkBox_1 = new CheckBox();
					num = ((int)num2 * -1426794440) ^ 0x1CD319DD;
					continue;
				case 56u:
					gform1_0.checkBox_1.Name = "removeUselessDataCheckBox";
					num = (int)(num2 * 1156660406) ^ -952432516;
					continue;
				case 55u:
					gform1_0.checkBox_11.UseVisualStyleBackColor = true;
					num = (int)(num2 * 450366620) ^ -1604948202;
					continue;
				case 54u:
					gform1_0.checkBox_11.Text = "Strip section characteristics";
					num = (int)((num2 * 1518420147) ^ 0x45D43D9D);
					continue;
				case 53u:
					gform1_0.checkBox_7.UseVisualStyleBackColor = true;
					num = (int)(num2 * 735441325) ^ -968378271;
					continue;
				case 52u:
					gform1_0.checkBox_3.TabIndex = 0;
					gform1_0.checkBox_3.Text = "Insert extra sections";
					num = ((int)num2 * -176693677) ^ -525561867;
					continue;
				case 51u:
					gform1_0.checkBox_11.Size = new Size(165, 17);
					gform1_0.checkBox_11.TabIndex = 6;
					num = (int)(num2 * 265089394) ^ -1552524730;
					continue;
				case 50u:
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_11);
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_12);
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_6);
					gform1_0.groupBox_1.Controls.Add(gform1_0.checkBox_5);
					num = (int)(num2 * 1321130338) ^ -1142964998;
					continue;
				case 49u:
					gform1_0.checkBox_4.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1910310273) ^ -467854554;
					continue;
				case 48u:
					gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_8);
					num = (int)(num2 * 1328389104) ^ -1102836592;
					continue;
				case 47u:
					gform1_0.checkBox_4 = new CheckBox();
					gform1_0.checkBox_2 = new CheckBox();
					gform1_0.checkBox_3 = new CheckBox();
					gform1_0.groupBox_2 = new GroupBox();
					gform1_0.checkBox_10 = new CheckBox();
					num = ((int)num2 * -400900666) ^ 0x45EDF053;
					continue;
				case 46u:
					gform1_0.groupBox_2.Location = new Point(12, 278);
					gform1_0.groupBox_2.Name = "directoryOptionsGroupBox";
					gform1_0.groupBox_2.Size = new Size(187, 120);
					num = (int)(num2 * 539921534) ^ -2069265074;
					continue;
				case 45u:
					gform1_0.checkBox_5.UseVisualStyleBackColor = true;
					num = (int)((num2 * 576759512) ^ 0x186FB66D);
					continue;
				case 44u:
					gform1_0.checkBox_12.UseVisualStyleBackColor = true;
					num = ((int)num2 * -832710069) ^ -1476546483;
					continue;
				case 42u:
					gform1_0.checkBox_9.Name = "createFakeDebugDirectoryCheckBox";
					gform1_0.checkBox_9.Size = new Size(169, 17);
					num = ((int)num2 * -587681899) ^ 0x2C98DD7F;
					continue;
				case 41u:
					gform1_0.checkBox_8.Location = new Point(9, 21);
					num = (int)((num2 * 2066908818) ^ 0x2019A273);
					continue;
				case 40u:
					gform1_0.checkBox_11.Name = "stripCharacteristicsCheckBox";
					num = (int)((num2 * 1776968976) ^ 0x1EE73E0D);
					continue;
				case 39u:
					gform1_0.checkBox_0.Text = "Scramble header fields";
					gform1_0.checkBox_0.UseVisualStyleBackColor = true;
					num = (int)((num2 * 589438285) ^ 0x126A6B87);
					continue;
				case 38u:
					gform1_0.groupBox_0.TabStop = false;
					num = ((int)num2 * -1758220505) ^ 0x699B028;
					continue;
				case 37u:
					gform1_0.AutoScaleMode = AutoScaleMode.Dpi;
					num = (int)(num2 * 1323938635) ^ -2082167424;
					continue;
				case 36u:
					gform1_0.checkBox_2.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1116541063) ^ 0x3DDDEADE;
					continue;
				case 35u:
					gform1_0.checkBox_0 = new CheckBox();
					gform1_0.groupBox_1 = new GroupBox();
					gform1_0.checkBox_6 = new CheckBox();
					num = ((int)num2 * -2069691687) ^ -1689728988;
					continue;
				case 34u:
					gform1_0.checkBox_7.TabIndex = 4;
					gform1_0.checkBox_7.Text = "Move relocation table";
					num = (int)(num2 * 382154377) ^ -1181653091;
					continue;
				case 33u:
					gform1_0.groupBox_0.Name = "headersGroupBox";
					gform1_0.groupBox_0.Size = new Size(187, 68);
					num = (int)((num2 * 990017972) ^ 0x1B1CBE08);
					continue;
				case 32u:
					gform1_0.checkBox_5.Size = new Size(112, 17);
					gform1_0.checkBox_5.TabIndex = 3;
					num = (int)((num2 * 1651923130) ^ 0x3EC0C88E);
					continue;
				case 31u:
					gform1_0.checkBox_11 = new CheckBox();
					gform1_0.groupBox_0.SuspendLayout();
					gform1_0.groupBox_1.SuspendLayout();
					num = ((int)num2 * -2094414304) ^ -1137650583;
					continue;
				case 30u:
					gform1_0.checkBox_7.AutoSize = true;
					num = (int)((num2 * 1781786021) ^ 0x6D6C0017);
					continue;
				case 29u:
					gform1_0.checkBox_5.AutoSize = true;
					num = ((int)num2 * -7468495) ^ -722762334;
					continue;
				case 28u:
					gform1_0.checkBox_6.TabIndex = 4;
					num = ((int)num2 * -40940598) ^ -1602723134;
					continue;
				case 27u:
					gform1_0.groupBox_1.PerformLayout();
					gform1_0.groupBox_2.ResumeLayout(performLayout: false);
					num = ((int)num2 * -1205413814) ^ 0x6D41F1FD;
					continue;
				case 26u:
					gform1_0.groupBox_2.Text = "Directory Options";
					gform1_0.checkBox_10.AutoSize = true;
					gform1_0.checkBox_10.Location = new Point(9, 44);
					num = (int)((num2 * 119579196) ^ 0x20FCBA34);
					continue;
				case 25u:
					gform1_0.checkBox_9.AutoSize = true;
					gform1_0.checkBox_9.Location = new Point(9, 90);
					num = (int)(num2 * 1049986877) ^ -1197577751;
					continue;
				case 24u:
					gform1_0.Text = "Advanced Scramble Settings";
					gform1_0.groupBox_0.ResumeLayout(performLayout: false);
					num = (int)(num2 * 1960018299) ^ -2026772792;
					continue;
				case 23u:
					gform1_0.checkBox_12.TabIndex = 5;
					gform1_0.checkBox_12.Text = "Shift section memory";
					num = ((int)num2 * -572279095) ^ -325043327;
					continue;
				case 22u:
					gform1_0.checkBox_3.AutoSize = true;
					gform1_0.checkBox_3.Location = new Point(9, 21);
					gform1_0.checkBox_3.Name = "insertSectionsCheckBox";
					gform1_0.checkBox_3.Size = new Size(128, 17);
					num = (int)(num2 * 1836177835) ^ -1719086732;
					continue;
				case 21u:
					gform1_0.groupBox_2.SuspendLayout();
					gform1_0.SuspendLayout();
					num = ((int)num2 * -279731497) ^ -1008234747;
					continue;
				case 20u:
					gform1_0.checkBox_4.Location = new Point(9, 67);
					num = (int)((num2 * 1635198877) ^ 0xB4EC7C5);
					continue;
				case 19u:
					gform1_0.checkBox_1.AutoSize = true;
					gform1_0.checkBox_1.Location = new Point(9, 44);
					num = (int)((num2 * 286154601) ^ 0x1F5EFD0B);
					continue;
				case 18u:
					gform1_0.checkBox_4.Text = "Modify assembly code";
					num = ((int)num2 * -117621193) ^ -1502094739;
					continue;
				case 17u:
					gform1_0.checkBox_5.Location = new Point(9, 90);
					num = ((int)num2 * -1388664512) ^ -417446515;
					continue;
				case 16u:
					gform1_0.checkBox_6.Text = "Create new entrypoint";
					num = (int)((num2 * 303090442) ^ 0x44932EFA);
					continue;
				case 15u:
					gform1_0.checkBox_5 = new CheckBox();
					num = ((int)num2 * -830965724) ^ 0x1B862E67;
					continue;
				case 14u:
					gform1_0.checkBox_7.Size = new Size(138, 17);
					num = (int)((num2 * 1165210078) ^ 0x1E958152);
					continue;
				case 13u:
					gform1_0.checkBox_2.AutoSize = true;
					num = ((int)num2 * -349899331) ^ -1201832273;
					continue;
				case 12u:
					gform1_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)(num2 * 1249709979) ^ -1997932449;
					continue;
				case 11u:
					gform1_0.groupBox_2.Controls.Add(gform1_0.checkBox_10);
					num = ((int)num2 * -1343994367) ^ 0x643F55E0;
					continue;
				case 10u:
					gform1_0.checkBox_10.TabIndex = 6;
					gform1_0.checkBox_10.Text = "Remove debug data";
					gform1_0.checkBox_10.UseVisualStyleBackColor = true;
					num = (int)(num2 * 477898099) ^ -615185821;
					continue;
				case 9u:
					gform1_0.checkBox_3.UseVisualStyleBackColor = true;
					num = (int)((num2 * 1668033962) ^ 0x4587ADBB);
					continue;
				case 8u:
					gform1_0.groupBox_0.PerformLayout();
					num = (int)(num2 * 1911016424) ^ -1192049013;
					continue;
				case 7u:
					gform1_0.checkBox_4.Name = "modifyCodeCheckBox";
					gform1_0.checkBox_4.Size = new Size(139, 17);
					gform1_0.checkBox_4.TabIndex = 2;
					num = ((int)num2 * -1081688659) ^ -1037095281;
					continue;
				case 6u:
					gform1_0.checkBox_5.Text = "Rename sections";
					num = ((int)num2 * -1096633799) ^ -1348949827;
					continue;
				case 5u:
					gform1_0.ClientSize = new Size(213, 411);
					num = (int)((num2 * 1795035616) ^ 0x7567EBA8);
					continue;
				case 4u:
					gform1_0.groupBox_1.Size = new Size(187, 186);
					gform1_0.groupBox_1.TabIndex = 1;
					gform1_0.groupBox_1.TabStop = false;
					gform1_0.groupBox_1.Text = "Section Options";
					gform1_0.checkBox_6.AutoSize = true;
					num = (int)(num2 * 636471069) ^ -528562159;
					continue;
				case 3u:
					gform1_0.checkBox_7.Location = new Point(9, 67);
					gform1_0.checkBox_7.Name = "moveRelocationTableCheckBox";
					num = ((int)num2 * -2129944110) ^ 0x76D3175C;
					continue;
				case 2u:
					gform1_0.checkBox_10.Name = "removeDebugDataCheckBox";
					gform1_0.checkBox_10.Size = new Size(129, 17);
					num = (int)((num2 * 1671308631) ^ 0x3F40D032);
					continue;
				case 1u:
					gform1_0.checkBox_5.Name = "renameSectionsCheckBox";
					num = ((int)num2 * -315961578) ^ -23914572;
					continue;
				case 0u:
					gform1_0.groupBox_0.TabIndex = 0;
					num = ((int)num2 * -787275316) ^ 0x3DA697BE;
					continue;
				default:
					return;
				case 43u:
					break;
				case 77u:
					return;
				}
				break;
			}
		}
	}

	internal static bool smethod_235(GClass4 gclass4_0)
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

	internal static void smethod_236(int int_0, Class58 class58_0, Class47 class47_0)
	{
		Class63[] array = new Class63[4]
		{
			Class49.class63_54,
			Class49.class63_55,
			Class49.class63_61,
			Class49.class63_62
		};
		while (true)
		{
			int num = 1210646683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1605827C)) % 6)
				{
				case 3u:
					smethod_263(class47_0.class53_0, array[int_0], smethod_221(class47_0, class58_0, 0L));
					num = (int)(num2 * 563434055) ^ -464546206;
					continue;
				case 2u:
					smethod_263(class47_0.class53_0, Class49.class63_53, smethod_221(class47_0, class58_0, 0L));
					smethod_75(class47_0.class53_0, smethod_238(Class49.class63_57, int_0 * 8), Class49.class63_53);
					num = 1484663116;
					continue;
				case 1u:
					num = ((int_0 >= 4) ? (-62745234) : (-1004842189)) ^ (int)(num2 * 2052989890);
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool QueryFullProcessImageName([In] IntPtr intptr_0, [In] int int_0, [Out] StringBuilder stringBuilder_0, ref int int_1);

	internal static void smethod_237(AdvancedScrambleSettingsForm gform1_0)
	{
		bool enabled = gform1_0.checkBox_3.Checked;
		gform1_0.checkBox_9.Enabled = enabled;
		gform1_0.checkBox_7.Enabled = enabled;
		gform1_0.checkBox_6.Enabled = enabled;
	}

	internal static Class59 smethod_238(Class63 class63_0, long long_0)
	{
		return smethod_433((IntPtr)long_0, 8u, class63_0);
	}

	internal static bool smethod_239(Class53 class53_0, Class84 class84_0)
	{
		IntPtr intPtr = smethod_61(class53_0, class84_0);
		IntPtr intPtr2 = default(IntPtr);
		while (true)
		{
			int num = 434890484;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x278A99D7)) % 9)
				{
				case 8u:
					smethod_108(class84_0, intPtr2);
					num = (int)(num2 * 231443116) ^ -722933073;
					continue;
				case 6u:
					num = ((intPtr == IntPtr.Zero) ? 625401272 : 703035029) ^ ((int)num2 * -1881636175);
					continue;
				case 5u:
					intPtr2 = smethod_321(class84_0, intPtr, IntPtr.Zero);
					num = 538867479;
					continue;
				case 3u:
					smethod_153(class84_0, intPtr2, -1);
					num = 863530444;
					continue;
				case 0u:
					num = ((intPtr2 == IntPtr.Zero) ? 899592985 : 1108878760) ^ (int)(num2 * 42281777);
					continue;
				case 4u:
					break;
				case 1u:
					return false;
				default:
					return true;
				case 7u:
					return false;
				}
				break;
			}
		}
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ChangeWindowMessageFilter(uint uint_0, Class10.Enum2 enum2_0);

	internal static void smethod_240(Class154 class154_0, string string_0, MainForm mainForm)
	{
		bool flag2 = false;
		if (!string_0.StartsWith("msvc", StringComparison.OrdinalIgnoreCase))
		{
			goto IL_0032;
		}
		goto IL_005d;
		IL_0032:
		int num = -1781397143;
		goto IL_0037;
		IL_0037:
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1402335039)) % 5)
			{
			case 3u:
				break;
			case 0u:
				goto end_IL_0037;
			case 2u:
				goto IL_005d;
			default:
				goto IL_006c;
			case 4u:
				return;
			}
			flag = false;
			if (!string.IsNullOrEmpty(text))
			{
				num = ((int)num2 * -1389369515) ^ -1898394505;
				continue;
			}
			goto IL_0550;
			continue;
			end_IL_0037:
			break;
		}
		goto IL_0032;
		IL_005d:
		text = smethod_353(class154_0, string_0);
		num = -1608867157;
		goto IL_0037;
		IL_0550:
		flag2 = string_0.EndsWith("d.dll", StringComparison.OrdinalIgnoreCase);
		int num3 = ((!Class127.bool_0) ? (-1018977624) : (-9692213));
		goto IL_04b2;
		IL_04b2:
		string string_5 = default(string);
		string string_4 = default(string);
		string string_2 = default(string);
		string string_3 = default(string);
		string string_1 = default(string);
		while (true)
		{
			uint num2;
			string text2;
			string string_6;
			switch ((num2 = (uint)(num3 ^ -1402335039)) % 31)
			{
			case 29u:
				if (!smethod_19(class154_0))
				{
					num3 = (int)((num2 * 1226008074) ^ 0x1CA774DF);
					continue;
				}
				text2 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202010%20x86%20(Debug).zip";
				goto IL_05ab;
			case 27u:
				string_5 = "2013";
				string_4 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202013%20x86%20(Debug).zip";
				num3 = ((int)num2 * -1918884445) ^ -866666153;
				continue;
			case 25u:
				string_5 = "2012";
				num3 = (int)(num2 * 1940252670) ^ -33320410;
				continue;
			case 24u:
				string_4 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202012%20x86%20(Debug).zip";
				string_2 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202012%20x64%20(Debug).zip";
				string_3 = "http://www.microsoft.com/download/details.aspx?id=30679";
				smethod_203(string_3, string_1, string_0, class154_0, text, mainForm, string_4, flag2, string_2, flag, string_5);
				num3 = (int)(num2 * 1229063295) ^ -805821474;
				continue;
			case 22u:
				string_4 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202015%20x86%20(Debug).zip";
				num3 = (int)((num2 * 1309028008) ^ 0x2412B5B1);
				continue;
			case 20u:
				num3 = (flag2 ? 170669938 : 700320521) ^ ((int)num2 * -1136219596);
				continue;
			case 19u:
				break;
			case 18u:
				string_2 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202015%20x64%20(Debug).zip";
				string_3 = "https://www.microsoft.com/download/details.aspx?id=53840";
				num3 = (int)(num2 * 997741652) ^ -1439617287;
				continue;
			case 17u:
				goto IL_02ac;
			case 15u:
				num3 = (int)((num2 * 536199463) ^ 0x5441B12);
				continue;
			case 14u:
				smethod_203(string_3, string_1, string_0, class154_0, text, mainForm, string_4, flag2, string_2, flag2, string_5);
				num3 = (int)(num2 * 1294788388) ^ -122959201;
				continue;
			case 13u:
				goto IL_031d;
			case 12u:
				num3 = (smethod_19(class154_0) ? (-881593969) : (-223998686)) ^ (int)(num2 * 963837249);
				continue;
			case 11u:
				string_5 = "2015";
				num3 = (int)((num2 * 435508830) ^ 0x24C86BEC);
				continue;
			case 10u:
				goto IL_0397;
			case 9u:
				string_3 = "http://www.microsoft.com/download/details.aspx?id=40784";
				smethod_203(string_3, string_1, string_0, class154_0, text, mainForm, string_4, flag2, string_2, flag, string_5);
				num3 = (int)(num2 * 1297993915) ^ -1752498774;
				continue;
			case 8u:
				string_1 = Class127.string_1;
				num3 = -2080748112;
				continue;
			case 7u:
				goto IL_03fe;
			case 6u:
				goto IL_042c;
			case 4u:
				string_2 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202013%20x64%20(Debug).zip";
				num3 = ((int)num2 * -1560068227) ^ -1691341806;
				continue;
			case 3u:
				string_1 = Class127.string_2;
				num3 = ((int)num2 * -1513590725) ^ -1791827357;
				continue;
			case 0u:
				goto IL_0489;
			default:
				return;
			case 16u:
				goto IL_0550;
			case 1u:
				Process.Start("http://www.microsoft.com/download/details.aspx?id=8328");
				return;
			case 2u:
				return;
			case 5u:
				Process.Start("http://www.microsoft.com/download/details.aspx?id=13523");
				return;
			case 21u:
				return;
			case 23u:
				return;
			case 26u:
				return;
			case 28u:
				return;
			case 30u:
				{
					text2 = "https://cdn.rawgit.com/master131/ExtremeInjector/398da9b1/VC/Microsoft%20Visual%20C%2B%2B%202010%20x64%20(Debug).zip";
					goto IL_05ab;
				}
				IL_05ab:
				string_6 = text2;
				smethod_405(class154_0.method_2(), mainForm, string_1, string_6, string_0);
				return;
			}
			break;
			IL_0489:
			num3 = ((!smethod_434(string_0, "140")) ? (-675176961) : (-1669463194));
			continue;
			IL_03fe:
			num3 = ((!smethod_434(string_0, "110")) ? (-794947190) : (-590898738));
			continue;
			IL_031d:
			num3 = ((!smethod_434(string_0, "120")) ? (-1272127945) : (-69454099));
			continue;
			IL_042c:
			num3 = (smethod_434(string_0, "100") ? (-1168170587) : (-849012758));
			continue;
			IL_02ac:
			num3 = (smethod_337(mainForm, class154_0.method_2(), string_0, text, flag, "Microsoft Visual C++ 2010 Runtime") ? (-1410142964) : (-82041023));
			continue;
			IL_0397:
			num3 = (smethod_19(class154_0) ? (-1233975278) : (-1045191890));
		}
		goto IL_0277;
		IL_006c:
		FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
		try
		{
			Class154 @class = Class7.smethod_13(fileStream, text, bool_0: false, Enum39.const_0);
			while (true)
			{
				IL_0115:
				int num4 = -790734913;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num4 ^ -1402335039)) % 5)
					{
					case 2u:
						num4 = ((smethod_19(@class) != smethod_19(class154_0)) ? (-729517767) : (-1992703194)) ^ ((int)num2 * -1264109307);
						continue;
					case 1u:
						num4 = ((@class != null) ? (-1731337321) : (-528649616)) ^ ((int)num2 * -528007083);
						continue;
					case 0u:
						flag = true;
						num4 = ((int)num2 * -92557931) ^ -1363019906;
						continue;
					default:
						goto end_IL_00ef;
					case 4u:
						break;
					case 3u:
						goto end_IL_00ef;
					}
					goto IL_0115;
					continue;
					end_IL_00ef:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_015a:
					int num5 = -821711553;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num5 ^ -1402335039)) % 3)
						{
						case 2u:
							goto IL_0127;
						default:
							goto end_IL_013c;
						case 0u:
							break;
						case 1u:
							goto end_IL_013c;
						}
						goto IL_015a;
						IL_0127:
						((IDisposable)fileStream).Dispose();
						num5 = ((int)num2 * -892779052) ^ -1868747642;
						continue;
						end_IL_013c:
						break;
					}
					break;
				}
			}
		}
		if (!flag)
		{
			goto IL_0277;
		}
		goto IL_0550;
		IL_0277:
		num3 = -1046144651;
		goto IL_04b2;
	}

	internal static void smethod_241(IntPtr intptr_0)
	{
		Class169.Struct61 @struct = (Class169.Struct61)Marshal.PtrToStructure(intptr_0, typeof(Class169.Struct61));
		int num = 0;
		IntPtr intPtr4 = default(IntPtr);
		Class169.Struct59 struct3 = default(Class169.Struct59);
		string key = default(string);
		Class169.Struct62 struct4 = default(Class169.Struct62);
		IntPtr intPtr2 = default(IntPtr);
		IntPtr intPtr3 = default(IntPtr);
		int num4 = default(int);
		IntPtr intPtr = default(IntPtr);
		IntPtr ptr = default(IntPtr);
		string text = default(string);
		List<string> list = default(List<string>);
		while (true)
		{
			int num2 = 742087013;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x607A5483)) % 26)
				{
				case 25u:
					intPtr4 = intptr_0.smethod_9(struct3.uint_1);
					num2 = (int)(num3 * 1117864027) ^ -1156146508;
					continue;
				case 24u:
					key = Marshal.PtrToStringUni(intPtr4, (int)(struct3.uint_3 / 2)).ToLowerInvariant();
					num2 = 711647293;
					continue;
				case 23u:
					num2 = ((num < @struct.uint_3) ? 1445084661 : 55077943);
					continue;
				case 22u:
					struct4 = (Class169.Struct62)Marshal.PtrToStructure(intPtr2, typeof(Class169.Struct62));
					intPtr3 = intptr_0.smethod_9(struct4.uint_3);
					num2 = ((!smethod_184(intPtr3)) ? 1830733229 : 1905089965);
					continue;
				case 20u:
					num2 = (int)(num3 * 338874188) ^ -1875756666;
					continue;
				case 19u:
					intPtr2 = intptr_0.smethod_9(struct3.uint_4 + num4 * typeof(Class169.Struct62).smethod_7());
					num2 = ((!smethod_184(intPtr2)) ? 1322593216 : 39878801);
					continue;
				case 18u:
					num2 = ((num4 >= struct3.uint_5) ? 1768704576 : 1809963994);
					continue;
				case 17u:
					num4++;
					num2 = 1586730079;
					continue;
				case 16u:
					intPtr = intptr_0.smethod_9(@struct.uint_5 + num * typeof(Class169.Struct60).smethod_7());
					num2 = 1386755637;
					continue;
				case 15u:
				{
					Class169.Struct60 struct2 = (Class169.Struct60)Marshal.PtrToStructure(intPtr, typeof(Class169.Struct60));
					ptr = intptr_0.smethod_9(@struct.uint_4 + typeof(Class169.Struct59).smethod_7() * struct2.uint_1);
					num2 = 1464036764;
					continue;
				}
				case 14u:
					text = Marshal.PtrToStringUni(intPtr3, (int)(struct4.uint_4 / 2));
					num2 = ((!string.IsNullOrEmpty(text)) ? 1746809500 : 1725408206);
					continue;
				case 11u:
					struct3 = (Class169.Struct59)Marshal.PtrToStructure(ptr, typeof(Class169.Struct59));
					num2 = 158216088;
					continue;
				case 9u:
					list.Add(text);
					num2 = (int)((num3 * 1779497568) ^ 0xF87326E);
					continue;
				case 8u:
					list = new List<string>();
					num4 = 0;
					num2 = (int)((num3 * 2087154473) ^ 0x67A122F0);
					continue;
				case 7u:
					Class169.dictionary_0.Add(key, list);
					num++;
					num2 = (int)((num3 * 2092717873) ^ 0x30AF0B9D);
					continue;
				case 5u:
					num2 = ((int)num3 * -830115844) ^ 0x54C353D3;
					continue;
				case 4u:
					num2 = (smethod_184(intPtr4) ? (-1000462149) : (-525760491)) ^ (int)(num3 * 1223629963);
					continue;
				case 3u:
					num2 = ((!smethod_184(intPtr)) ? (-1108701115) : (-1930584702)) ^ (int)(num3 * 1502133720);
					continue;
				case 2u:
					num2 = ((!smethod_184(intPtr)) ? (-634396564) : (-1625234068)) ^ ((int)num3 * -1453482708);
					continue;
				default:
					return;
				case 21u:
					break;
				case 0u:
					return;
				case 1u:
					return;
				case 6u:
					return;
				case 10u:
					return;
				case 12u:
					return;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_242(Class89 class89_0, Class89.Class172 class172_0)
	{
		byte[] array = Class89.smethod_7(class172_0.method_0());
		Class124.Struct50 @struct = default(Class124.Struct50);
		string tempFileName = default(string);
		Class124.Struct50 struct50_ = default(Class124.Struct50);
		while (true)
		{
			int num = -306815367;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1862415398)) % 8)
				{
				case 7u:
					@struct.string_0 = tempFileName;
					num = (int)(num2 * 1775869119) ^ -1759317750;
					continue;
				case 6u:
					tempFileName = Path.GetTempFileName();
					File.WriteAllBytes(tempFileName, array);
					@struct = default(Class124.Struct50);
					num = -1984870842;
					continue;
				case 4u:
					@struct.int_0 = typeof(Class124.Struct50).smethod_7();
					num = (int)(num2 * 1078367355) ^ -1797749071;
					continue;
				case 3u:
					num = ((array != null) ? 1633666709 : 1470329281) ^ ((int)num2 * -1368651093);
					continue;
				case 1u:
					struct50_ = @struct;
					num = ((int)num2 * -1681076010) ^ -1657278495;
					continue;
				case 0u:
					break;
				case 2u:
					return;
				default:
					class172_0.method_11(CreateActCtx(ref struct50_));
					File.Delete(tempFileName);
					return;
				}
				break;
			}
		}
	}

	[DllImport("shell32.dll")]
	internal static extern bool DragQueryPoint(IntPtr intptr_0, out Class10.Struct5 struct5_0);

	[DllImport("kernel32.dll")]
	internal static extern ulong VerSetConditionMask(ulong ulong_0, uint uint_0, byte byte_0);

	internal static string GetModulePath(MainForm.ModuleRow class21_0)
	{
		return class21_0.Entry.Path;
	}

	internal static void ShowSettings(GClass2 gclass2_0)
	{
		SettingsForm gForm = new SettingsForm();
		gForm.method_1(gclass2_0);
		gForm.button_6.Enabled = gclass2_0 != null;
		gForm.ShowDialog();
	}

	internal static int smethod_245(Type type_0)
	{
		if (!type_0.IsSubclassOf(typeof(Class96)))
		{
			return smethod_232(type_0);
		}
		return smethod_117(type_0);
	}

	internal static bool smethod_246(GClass1 gclass1_0)
	{
		IntPtr intPtr = smethod_250(gclass1_0.gclass2_0, Class124.Enum32.flag_4 | Class124.Enum32.flag_9, bool_0: false, gclass1_0.gclass2_0.method_0());
		StringBuilder stringBuilder = default(StringBuilder);
		Class124.Struct46 struct46_ = default(Class124.Struct46);
		while (true)
		{
			int num = -2136729239;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -127140649)) % 15)
				{
				case 12u:
					gclass1_0.method_7(stringBuilder.ToString());
					num = ((GetModuleBaseName(intPtr, gclass1_0.method_0(), stringBuilder, stringBuilder.Capacity) == 0) ? (-727661816) : (-880688301));
					continue;
				case 11u:
					num = ((intPtr == IntPtr.Zero) ? (-802655388) : (-459723165)) ^ ((int)num2 * -1639283245);
					continue;
				case 10u:
					num = (GetModuleInformation(intPtr, gclass1_0.method_0(), out struct46_, typeof(Class124.Struct46).smethod_7()) ? (-830289858) : (-1757415651));
					continue;
				case 9u:
					stringBuilder = new StringBuilder(255);
					num = ((GetModuleFileNameEx(intPtr, gclass1_0.method_0(), stringBuilder, stringBuilder.Capacity) == 0) ? 1993322590 : 269386978) ^ (int)(num2 * 340438428);
					continue;
				case 8u:
					smethod_27(gclass1_0.gclass2_0, intPtr);
					num = ((int)num2 * -1274770309) ^ -1814361568;
					continue;
				case 4u:
					gclass1_0.method_1(struct46_.intptr_0);
					num = (int)((num2 * 107175750) ^ 0x3269A255);
					continue;
				case 3u:
					smethod_27(gclass1_0.gclass2_0, intPtr);
					num = (int)(num2 * 1170926132) ^ -771540066;
					continue;
				case 2u:
					gclass1_0.method_3(struct46_.intptr_1);
					gclass1_0.method_5(struct46_.uint_0);
					num = -1334528545;
					continue;
				case 0u:
					gclass1_0.method_9(stringBuilder.ToString());
					num = -1172327067;
					continue;
				case 14u:
					break;
				case 1u:
					return false;
				case 5u:
					return false;
				case 6u:
					smethod_27(gclass1_0.gclass2_0, intPtr);
					return false;
				case 7u:
					return false;
				default:
					smethod_27(gclass1_0.gclass2_0, intPtr);
					return true;
				}
				break;
			}
		}
	}

	internal static void smethod_247(Class53 class53_0, Class58 class58_0)
	{
		smethod_352(class58_0, Enum7.const_247, class53_0);
	}

	internal static IntPtr smethod_248(GClass1 gclass1_0, ushort ushort_0, bool bool_0)
	{
		return gclass1_0.method_14(ushort_0, bool_0);
	}

	internal static void smethod_249(byte[] byte_0, Class179.Class183 class183_0)
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

	internal static IntPtr smethod_250(GClass2 gclass2_0, Class124.Enum32 enum32_0, bool bool_0, int int_0)
	{
		if (gclass2_0.method_10() != IntPtr.Zero)
		{
			return gclass2_0.method_10();
		}
		return OpenProcess(enum32_0, bool_0, int_0);
	}

	internal static void smethod_251(int int_0, byte[] byte_0, int int_1, Class179.Class181 class181_0)
	{
		if (class181_0.int_0 < class181_0.int_1)
		{
			goto IL_0127;
		}
		goto IL_0181;
		IL_0127:
		int num = -204073274;
		goto IL_012c;
		IL_012c:
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -833974792)) % 13)
			{
			case 12u:
				num = ((int_1 <= num3) ? 1851636686 : 783636969) ^ (int)(num2 * 1456899440);
				continue;
			case 8u:
				break;
			case 7u:
				class181_0.byte_0 = byte_0;
				num = -1578514549;
				continue;
			case 6u:
				num = ((num3 <= byte_0.Length) ? (-979265642) : (-594132859)) ^ (int)(num2 * 984425746);
				continue;
			case 5u:
				class181_0.int_2 += 8;
				num = (int)(num2 * 2087814200) ^ -249297488;
				continue;
			case 4u:
				class181_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class181_0.int_2);
				num = ((int)num2 * -69655551) ^ -1029613726;
				continue;
			case 3u:
				class181_0.int_0 = int_1;
				num = (int)((num2 * 1620944909) ^ 0x7F9C05D1);
				continue;
			case 1u:
				class181_0.int_1 = num3;
				num = ((int)num2 * -643396109) ^ 0x24995E13;
				continue;
			case 0u:
				goto end_IL_012c;
			default:
				return;
			case 2u:
				goto IL_0181;
			case 9u:
				throw new ArgumentOutOfRangeException();
			case 10u:
				throw new InvalidOperationException();
			case 11u:
				return;
			}
			num = (((int_0 & 1) != 0) ? (-828817170) : (-1415441648));
			continue;
			end_IL_012c:
			break;
		}
		goto IL_0127;
		IL_0181:
		num3 = int_1 + int_0;
		num = ((0 <= int_1) ? (-433463550) : (-1338411383));
		goto IL_012c;
	}

	internal static int smethod_252(Class53 class53_0)
	{
		return (int)(class53_0.struct19_0.struct17_0.intptr_1.ToInt64() - class53_0.struct19_0.struct17_0.intptr_0.ToInt64() + class53_0.struct19_0.intptr_3.ToInt64());
	}

	internal static IntPtr smethod_253(int int_0, Enum15 enum15_0)
	{
		if (enum15_0 == Enum15.const_0)
		{
			goto IL_004f;
		}
		goto IL_00a6;
		IL_004f:
		int num = -1492687271;
		goto IL_0066;
		IL_0066:
		Class124.Enum32 @enum = default(Class124.Enum32);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -112940600)) % 8)
			{
			case 7u:
				num = ((int)num2 * -1836325901) ^ -1242989383;
				continue;
			case 5u:
				@enum = Class124.Enum32.flag_3 | Class124.Enum32.flag_5;
				num = -565761348;
				continue;
			case 4u:
				@enum |= Class124.Enum32.flag_9;
				num = -989861536;
				continue;
			case 3u:
				@enum = Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5;
				num = ((int)num2 * -854360926) ^ -503782774;
				continue;
			case 2u:
				break;
			case 1u:
				@enum = Class124.Enum32.flag_4;
				num = (int)(num2 * 1541353853) ^ -748992734;
				continue;
			case 6u:
				goto IL_00a6;
			default:
				return OpenProcess(@enum, bool_0: false, int_0);
			}
			break;
		}
		goto IL_004f;
		IL_00a6:
		num = ((enum15_0 != Enum15.const_2) ? (-209039675) : (-38261405));
		goto IL_0066;
	}

	internal static void smethod_254(Class10 class10_0, Message message_0)
	{
		StringBuilder stringBuilder = new StringBuilder(260);
		uint num3 = default(uint);
		Class10.Struct5 struct5_ = default(Class10.Struct5);
		List<string> list = default(List<string>);
		uint num4 = default(uint);
		EventArgs0 e = default(EventArgs0);
		while (true)
		{
			int num = -14438100;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -723138968)) % 12)
				{
				case 11u:
					num3++;
					num = -1126807068;
					continue;
				case 10u:
					DragQueryPoint(message_0.WParam, out struct5_);
					DragFinish(message_0.WParam);
					num = (int)(num2 * 641475378) ^ -80843295;
					continue;
				case 9u:
					list = new List<string>();
					num = ((int)num2 * -1516380883) ^ -2081603339;
					continue;
				case 8u:
					num4 = DragQueryFile(message_0.WParam, uint.MaxValue, stringBuilder, 0u);
					num = ((int)num2 * -679041813) ^ 0x3D181CCD;
					continue;
				case 6u:
					num = ((DragQueryFile(message_0.WParam, num3, stringBuilder, Convert.ToUInt32(stringBuilder.Capacity) * 2) != 0) ? (-1957786797) : (-260167221));
					continue;
				case 5u:
				{
					EventArgs0 eventArgs = new EventArgs0();
					eventArgs.method_0(message_0.HWnd);
					eventArgs.method_2(list);
					eventArgs.method_3(struct5_.int_0);
					eventArgs.method_4(struct5_.int_1);
					e = eventArgs;
					num = ((class10_0.eventHandler_0 == null) ? 197205043 : 367233280) ^ ((int)num2 * -1478029599);
					continue;
				}
				case 4u:
					num3 = 0u;
					num = ((int)num2 * -2020196420) ^ -669305084;
					continue;
				case 3u:
					list.Add(stringBuilder.ToString());
					num = ((int)num2 * -1410647425) ^ 0x63DD878E;
					continue;
				case 1u:
					class10_0.eventHandler_0(class10_0, e);
					num = (int)((num2 * 319709075) ^ 0x4D37D401);
					continue;
				case 0u:
					num = ((num3 > num4 - 1) ? (-959252862) : (-1034118814));
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal static Class119 smethod_255(GClass2 gclass2_0)
	{
		if (Class127.bool_0)
		{
			goto IL_00a5;
		}
		goto IL_00f5;
		IL_00a5:
		int num = 1978106553;
		goto IL_00aa;
		IL_00aa:
		Class119 @class = default(Class119);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6AD39705)) % 9)
			{
			case 7u:
				num = ((!smethod_409(@class)) ? (-1440016353) : (-1128519321)) ^ (int)(num2 * 301388504);
				continue;
			case 5u:
				num = ((smethod_270(@class) != IntPtr.Zero) ? 690128447 : 1113153845) ^ ((int)num2 * -220634323);
				continue;
			case 1u:
				num = ((!gclass2_0.method_6()) ? 446886717 : 1299284044) ^ (int)(num2 * 1150804737);
				continue;
			case 0u:
				break;
			case 8u:
				goto IL_00e0;
			case 4u:
				goto IL_00f5;
			default:
				return gclass2_0.method_12(@class);
			case 3u:
				return null;
			case 6u:
				return null;
			}
			break;
		}
		goto IL_00a5;
		IL_00f5:
		Class119 class2;
		if (gclass2_0.method_10() != IntPtr.Zero)
		{
			class2 = new Class119(gclass2_0, gclass2_0.method_10());
			goto IL_00e6;
		}
		num = 493614286;
		goto IL_00aa;
		IL_00e6:
		@class = class2;
		num = 445208270;
		goto IL_00aa;
		IL_00e0:
		class2 = new Class119(gclass2_0);
		goto IL_00e6;
	}

	internal static void smethod_256(Class58 class58_0, Enum12 enum12_0, Class53 class53_0, Enum7 enum7_0)
	{
		if (Class49.bool_0)
		{
			goto IL_002b;
		}
		goto IL_0055;
		IL_002b:
		int num = -341225826;
		goto IL_0030;
		IL_0030:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1652406805)) % 5)
			{
			case 4u:
				Class52.smethod_37()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
				num = ((int)num2 * -587851590) ^ -2102072399;
				continue;
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_0055;
			case 2u:
				return;
			case 3u:
				return;
			}
			break;
		}
		goto IL_002b;
		IL_0055:
		Class52.smethod_35()(ref class53_0.struct19_0, enum7_0, class58_0, enum12_0);
		num = -2069125753;
		goto IL_0030;
	}

	internal static Class59 smethod_257(Class58 class58_0, long long_0)
	{
		return smethod_161(1u, (IntPtr)long_0, class58_0);
	}

	internal static void smethod_258(SettingsForm gform2_0)
	{
		InjectionOptions class14_ = ApplicationSettings.Current.Options;
		while (true)
		{
			int num = 336446219;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x21E75A13)) % 10)
				{
				case 9u:
					gform2_0.panel_0.BackColor = class14_.BackgroundColor2;
					num = ((int)num2 * -713785333) ^ 0x3796121E;
					continue;
				case 8u:
					gform2_0.checkBox_4.Checked = class14_.ErasePeHeaders;
					num = ((int)num2 * -179221261) ^ 0x7709B898;
					continue;
				case 7u:
					gform2_0.numericUpDown_0.Value = class14_.DelayBetweenModules;
					num = ((int)num2 * -590752730) ^ 0x5F67E55B;
					continue;
				case 6u:
					gform2_0.numericUpDown_1.Value = class14_.DelayBeforeInjection;
					num = (int)(num2 * 1873854063) ^ -1436503997;
					continue;
				case 4u:
					gform2_0.comboBox_0.SelectedIndex = (int)class14_.Method;
					gform2_0.panel_2.BackColor = class14_.TextColor;
					gform2_0.panel_1.BackColor = class14_.BackgroundColor1;
					num = (int)((num2 * 540263552) ^ 0x3670B412);
					continue;
				case 3u:
					gform2_0.checkBox_1.Checked = class14_.CloseOnInject;
					num = ((int)num2 * -450971630) ^ 0x1ACB9788;
					continue;
				case 2u:
					gform2_0.checkBox_2.Checked = class14_.AutoInject;
					num = (int)(num2 * 1371463133) ^ -1356489936;
					continue;
				case 1u:
					gform2_0.checkBox_0.Checked = class14_.StealthInject;
					num = (int)((num2 * 1677704227) ^ 0xE9EAACB);
					continue;
				case 0u:
					break;
				default:
					gform2_0.checkBox_3.Checked = class14_.HideModule;
					smethod_421(gform2_0);
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_259(Class89 class89_0)
	{
		class89_0.method_31(bool_7: false);
		class89_0.method_29(bool_7: false);
		class89_0.method_27(bool_7: false);
		class89_0.method_25(bool_7: false);
		class89_0.method_18(bool_2: false);
	}

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenProcess(Class124.Enum32 enum32_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, int int_0);

	internal static bool smethod_260(GClass2 gclass2_0)
	{
		if (Class127.bool_0)
		{
			goto IL_00d8;
		}
		goto IL_012e;
		IL_00d8:
		int num = -849872108;
		goto IL_00dd;
		IL_00dd:
		IntPtr intPtr = default(IntPtr);
		uint uint_ = default(uint);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -24526846)) % 12)
			{
			case 11u:
				intPtr = smethod_250(gclass2_0, Class124.Enum32.flag_9, bool_0: false, gclass2_0.method_0());
				num = ((!(intPtr == IntPtr.Zero)) ? (-608033379) : (-662107286)) ^ ((int)num2 * -506787402);
				continue;
			case 6u:
				num = ((!gclass2_0.method_6()) ? 553229817 : 1638943364) ^ ((int)num2 * -498208378);
				continue;
			case 5u:
				break;
			case 4u:
				smethod_27(gclass2_0, intPtr);
				num = (int)(num2 * 1999703407) ^ -1992290343;
				continue;
			case 1u:
				gclass2_0.method_9((uint_ & 1) != 0);
				num = -493749486;
				continue;
			case 0u:
				goto end_IL_00dd;
			case 7u:
				goto IL_012e;
			case 2u:
				gclass2_0.method_9(bool_6: true);
				return true;
			case 3u:
				return true;
			case 8u:
				smethod_27(gclass2_0, intPtr);
				return false;
			default:
				gclass2_0.method_9(bool_6: false);
				return true;
			case 10u:
				return false;
			}
			num = (GetProcessDEPPolicy(intPtr, out uint_, out var _) ? (-1700153137) : (-1533967634));
			continue;
			end_IL_00dd:
			break;
		}
		goto IL_00d8;
		IL_012e:
		num = ((!GClass2.bool_5) ? (-69344553) : (-581835979));
		goto IL_00dd;
	}

	internal static void smethod_261(Class154 class154_0, MainForm mainForm)
	{
		if (class154_0.method_10() == null)
		{
			return;
		}
		IEnumerator<KeyValuePair<string, List<string>>> enumerator = class154_0.method_10().gclass0_0.imethod_8();
		try
		{
			string key = default(string);
			while (true)
			{
				int num = ((!enumerator.MoveNext()) ? 275879052 : 474212495);
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x13C45758)) % 6)
					{
					case 5u:
						num = (string.IsNullOrEmpty(key) ? (-2087396708) : (-745053135)) ^ (int)(num2 * 1219299494);
						continue;
					case 3u:
						smethod_240(class154_0, key, mainForm);
						smethod_351(class154_0, key, mainForm);
						num = (int)((num2 * 1092998434) ^ 0x63703B8);
						continue;
					case 2u:
						num = 474212495;
						continue;
					case 1u:
						key = enumerator.Current.Key;
						num = 2035192635;
						continue;
					default:
						return;
					case 4u:
						break;
					case 0u:
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
					IL_0112:
					int num3 = 1477513241;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num3 ^ 0x13C45758)) % 3)
						{
						case 1u:
							goto IL_00e2;
						default:
							goto end_IL_00f5;
						case 2u:
							break;
						case 0u:
							goto end_IL_00f5;
						}
						goto IL_0112;
						IL_00e2:
						enumerator.Dispose();
						num3 = ((int)num2 * -1515806521) ^ 0x96F3EC8;
						continue;
						end_IL_00f5:
						break;
					}
					break;
				}
			}
		}
	}

	internal static bool smethod_262(Class166 class166_0, long long_0)
	{
		if (!smethod_282(class166_0, long_0, 0))
		{
			return false;
		}
		class166_0.class5_0.BaseStream.Position = class166_0.long_0 + long_0;
		return true;
	}

	internal static void smethod_263(Class53 class53_0, Class63 class63_0, Class59 class59_0)
	{
		smethod_137(class53_0, Enum7.const_251, class63_0, class59_0);
	}

	internal static Stream smethod_264(Class154 class154_0, long long_0, int int_0)
	{
		Stream result = default(Stream);
		lock (class154_0.method_28())
		{
			long position = class154_0.method_28().Position;
			class154_0.method_28().Position = long_0;
			MemoryStream memoryStream = new MemoryStream();
			while (true)
			{
				IL_00ab:
				int num = 192671807;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x304DD467)) % 5)
					{
					case 2u:
						class154_0.method_28().smethod_5(memoryStream, int_0);
						num = (int)((num2 * 117971427) ^ 0x1351C677);
						continue;
					case 1u:
						class154_0.method_28().Position = position;
						num = (int)(num2 * 1227241566) ^ -986844259;
						continue;
					case 0u:
						memoryStream.Position = 0L;
						result = memoryStream;
						num = (int)(num2 * 919051529) ^ -322841799;
						continue;
					default:
						goto end_IL_0085;
					case 3u:
						break;
					case 4u:
						goto end_IL_0085;
					}
					goto IL_00ab;
					continue;
					end_IL_0085:
					break;
				}
				break;
			}
		}
		return result;
	}

	internal static int smethod_265(int int_0, Class179.Class182 class182_0, int int_1, byte[] byte_0)
	{
		int num = class182_0.int_0;
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = 674811611;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x6A97B667)) % 15)
				{
				case 14u:
					int_1 = num;
					num2 = ((int)num3 * -1107127011) ^ -1828353081;
					continue;
				case 13u:
					num2 = ((class182_0.int_1 >= 0) ? (-512031932) : (-1831976275)) ^ (int)(num3 * 942018344);
					continue;
				case 11u:
					num2 = (int)((num3 * 1325297385) ^ 0x29575F1D);
					continue;
				case 9u:
					num2 = ((int_1 > class182_0.int_1) ? 221782340 : 1903097625) ^ (int)(num3 * 820606100);
					continue;
				case 8u:
					num4 = int_1;
					num5 = int_1 - num;
					num2 = 493256555;
					continue;
				case 7u:
					num = (class182_0.int_0 - class182_0.int_1 + int_1) & 0x7FFF;
					num2 = 72709629;
					continue;
				case 6u:
					int_0 += num5;
					num2 = (int)(num3 * 890364682) ^ -1354569738;
					continue;
				case 5u:
					int_1 = class182_0.int_1;
					num2 = (int)((num3 * 365104785) ^ 0x225989C4);
					continue;
				case 4u:
					class182_0.int_1 -= num4;
					num2 = (int)(num3 * 1309442035) ^ -1860903927;
					continue;
				case 3u:
					num2 = ((num5 > 0) ? (-57948017) : (-188750426)) ^ (int)(num3 * 1354547983);
					continue;
				case 2u:
					Array.Copy(class182_0.byte_0, 32768 - num5, byte_0, int_0, num5);
					num2 = (int)(num3 * 1675330505) ^ -812816721;
					continue;
				case 1u:
					Array.Copy(class182_0.byte_0, num - int_1, byte_0, int_0, int_1);
					num2 = 1150515527;
					continue;
				case 0u:
					break;
				case 10u:
					throw new InvalidOperationException();
				default:
					return num4;
				}
				break;
			}
		}
	}

	internal static void smethod_266(Class69 class69_0, Class154 class154_0, IntPtr intptr_0, bool bool_0)
	{
		GClass1 gClass = new GClass1(class69_0.gclass2_0, null, intptr_0, bool_0, bool_3: true);
		while (true)
		{
			int num = -630079707;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2014581677)) % 3)
				{
				case 1u:
					goto IL_0012;
				case 2u:
					break;
				default:
					class69_0.gclass2_0.list_1.Add(gClass);
					return;
				}
				break;
				IL_0012:
				string string_ = class154_0.method_0();
				string fileName = Path.GetFileName(class154_0.method_0());
				IntPtr intptr_1 = intptr_0.smethod_9(class154_0.method_6().method_3().imethod_11());
				uint uint_ = class154_0.method_6().method_3().imethod_29();
				smethod_313(string_, fileName, intptr_1, gClass, uint_);
				num = (int)((num2 * 1506359811) ^ 0x31EDE7E8);
			}
		}
	}

	internal static void smethod_267(Encoding encoding_0, GClass4 gclass4_0, string string_0)
	{
		byte[] bytes = encoding_0.GetBytes(string_0);
		byte[] bytes2 = encoding_0.GetBytes(smethod_275(string_0.Length));
		smethod_143(bytes2, bytes, gclass4_0);
	}

	internal static string smethod_268()
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		while (true)
		{
			int num = 982721856;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)(num ^ 0x548442D9)) % 4)
				{
				case 1u:
					num3 = ((GetWindowsDirectory(stringBuilder, stringBuilder.Capacity) == 0) ? 1778679026 : 1984353705);
					goto IL_0031;
				case 2u:
					break;
				default:
					return Environment.GetEnvironmentVariable("windir");
				case 3u:
					return stringBuilder.ToString();
				}
				break;
				IL_0031:
				num = num3 ^ (int)(num2 * 410135563);
			}
		}
	}

	internal static void smethod_269(Class53 class53_0, long long_0)
	{
		smethod_308(8L, long_0, class53_0);
	}

	internal static IntPtr smethod_270(Class117 class117_0)
	{
		return class117_0.method_17();
	}

	internal static bool smethod_271(ref Class161 class161_0, [Out] Class5 class5_0)
	{
		class161_0 = null;
		uint uint_;
		if ((uint_ = class5_0.ReadUInt32()) != 17744)
		{
			goto IL_0058;
		}
		goto IL_01ad;
		IL_0058:
		int num = 1688974706;
		goto IL_0156;
		IL_0156:
		ushort num3 = default(ushort);
		Class163 class163_ = default(Class163);
		Class162 class162_ = default(Class162);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x7857422E)) % 17)
			{
			case 15u:
				num = (int)((num2 * 635450078) ^ 0x2FC91B1A);
				continue;
			case 13u:
				class5_0.BaseStream.Position -= 2L;
				num = ((int)num2 * -285694538) ^ 0xD394115;
				continue;
			case 12u:
				break;
			case 11u:
				goto IL_0062;
			case 10u:
				goto IL_0094;
			case 9u:
				num = ((num3 == 267) ? (-1875376947) : (-1369991470)) ^ (int)(num2 * 656171232);
				continue;
			case 8u:
				num = ((int)num2 * -1621665294) ^ 0x73615F72;
				continue;
			case 6u:
				num = (int)((num2 * 1101070803) ^ 0x1038E216);
				continue;
			case 5u:
				num = ((num3 == 523) ? (-1376238563) : (-514345551)) ^ (int)(num2 * 1117640243);
				continue;
			case 4u:
				class161_0.method_4(class163_);
				num = 282820132;
				continue;
			case 1u:
				class161_0.method_4(class162_);
				num = 633259132;
				continue;
			case 0u:
				goto IL_01ad;
			default:
				return true;
			case 3u:
				return false;
			case 7u:
				return false;
			case 14u:
				return false;
			case 16u:
				return false;
			}
			break;
			IL_0094:
			num = ((!smethod_398(class5_0, class161_0.method_1().method_10(), out class163_)) ? 1530016688 : 668019768);
			continue;
			IL_0062:
			num = (smethod_7(class5_0, class161_0.method_1().method_10(), out class162_) ? 471202614 : 1729124149);
		}
		goto IL_0058;
		IL_01ad:
		Class161 @class = new Class161();
		@class.method_0(uint_);
		@class.method_2(new Class159(class5_0));
		class161_0 = @class;
		num3 = class5_0.ReadUInt16();
		num = 122690536;
		goto IL_0156;
	}

	internal static bool smethod_272()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	internal static string smethod_273(GClass4 gclass4_0)
	{
		StringBuilder stringBuilder = new StringBuilder(".");
		int num3 = default(int);
		while (true)
		{
			int num = -539653346;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -770911694)) % 5)
				{
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1725949177) ^ 0x3C71706C;
					continue;
				case 2u:
					num = ((num3 >= gclass4_0.random_0.Next(4, 8)) ? (-1989363767) : (-82926332));
					continue;
				case 1u:
					stringBuilder.Append("abcdefghijklmnopqrstuvwxyz0123456789"[gclass4_0.random_0.Next("abcdefghijklmnopqrstuvwxyz0123456789".Length)]);
					num3++;
					num = -2102893480;
					continue;
				case 0u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	internal static Icon smethod_274(Class77 class77_0)
	{
		SendMessageTimeout(class77_0.method_0(), 127u, (UIntPtr)1uL, IntPtr.Zero, Class124.Enum20.flag_2, 250u, out var intptr_);
		if (intptr_ != IntPtr.Zero)
		{
			goto IL_0045;
		}
		goto IL_0079;
		IL_0045:
		int num = -1852905715;
		goto IL_004a;
		IL_004a:
		switch ((uint)(num ^ -1596148236) % 5u)
		{
		case 4u:
			break;
		case 1u:
			goto IL_0079;
		default:
			return null;
		case 2u:
			return Icon.FromHandle(intptr_);
		case 3u:
			return Icon.FromHandle(intptr_);
		}
		goto IL_0045;
		IL_0079:
		intptr_ = smethod_445(class77_0.method_0(), -14);
		num = ((!(intptr_ != IntPtr.Zero)) ? (-1351201187) : (-1754428798));
		goto IL_004a;
	}

	internal static string smethod_275(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num3 = default(int);
		while (true)
		{
			int num = -975845276;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -460401423)) % 5)
				{
				case 3u:
					num = ((num3 < int_0) ? (-1321583561) : (-1041946180));
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -557386287) ^ 0x55933A7B;
					continue;
				case 0u:
				{
					char c = "abcdefghijklmnopqrstuvwxyz0123456789"[Class127.random_0.Next("abcdefghijklmnopqrstuvwxyz0123456789".Length)];
					stringBuilder.Append((Class127.random_0.Next(2) == 1) ? c : char.ToUpper(c));
					num3++;
					num = -345385762;
					continue;
				}
				case 2u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	internal static Class127.Delegate47 smethod_276(int int_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("Memcpy", typeof(void), new Type[3]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(uint)
		}, typeof(Class127));
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		if (int_0 != -1)
		{
			iLGenerator.Emit(OpCodes.Unaligned, (byte)int_0);
		}
		iLGenerator.Emit(OpCodes.Cpblk);
		iLGenerator.Emit(OpCodes.Ret);
		return (Class127.Delegate47)dynamicMethod.CreateDelegate(typeof(Class127.Delegate47));
	}

	internal static uint smethod_277(Class112 class112_0)
	{
		return class112_0.method_21<uint>(1);
	}

	internal static bool smethod_278(Class59 class59_0, Class59 class59_1)
	{
		return !smethod_319(class59_0, class59_1);
	}

	internal static void smethod_279(Class56 class56_0, Class56.Struct8 struct8_0)
	{
		class56_0.method_1(Class56.smethod_0<Class56.Struct8, Class56.Struct7>(struct8_0));
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr CreateToolhelp32Snapshot(Class124.Enum27 enum27_0, int int_0);

	internal static void smethod_280(Class56 class56_0, Class56.Struct9 struct9_0)
	{
		class56_0.method_1(Class56.smethod_0<Class56.Struct9, Class56.Struct7>(struct9_0));
	}

	internal static bool smethod_281(Class118 class118_0)
	{
		if (Class127.bool_0)
		{
			IntPtr intPtr = default(IntPtr);
			Class124.Struct45 struct45_ = default(Class124.Struct45);
			while (true)
			{
				int num = 1467455355;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x233E6FD9)) % 11)
					{
					case 10u:
						num = ((intPtr == IntPtr.Zero) ? (-1018909171) : (-1351058720)) ^ (int)(num2 * 646622078);
						continue;
					case 9u:
						intPtr = OpenProcess(Class124.Enum32.flag_4 | Class124.Enum32.flag_9, bool_0: false, class118_0.gclass2_0.method_0());
						num = (int)(num2 * 1204011911) ^ -163764910;
						continue;
					case 7u:
						CloseHandle(intPtr);
						num = ((int)num2 * -2132803047) ^ -961408650;
						continue;
					case 6u:
						break;
					case 1u:
						CloseHandle(intPtr);
						num = ((int)num2 * -1354762312) ^ 0x4BA09160;
						continue;
					case 0u:
						smethod_86(class118_0, struct45_.intptr_1);
						num = 970785537;
						continue;
					case 4u:
						goto end_IL_00d8;
					case 2u:
						return true;
					case 3u:
						return false;
					case 8u:
						return false;
					default:
						goto end_IL_0116;
					}
					num = ((NtQueryInformationProcess(intPtr, Class124.Enum26.const_4, out struct45_, typeof(Class124.Struct45).smethod_7(), out var _) == 0) ? 1453037481 : 1830189235);
					continue;
					end_IL_00d8:
					break;
				}
				continue;
				end_IL_0116:
				break;
			}
		}
		return false;
	}

	internal static bool smethod_282(Class166 class166_0, long long_0, int int_0)
	{
		if (long_0 >= 0L)
		{
			while (true)
			{
				int num = 1141989307;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x700887EE)) % 4)
					{
					case 1u:
						num = ((long_0 + int_0 < long_0) ? 1171330542 : 179811636) ^ (int)(num2 * 1544526648);
						continue;
					case 3u:
						break;
					default:
						return (uint)(long_0 + int_0) <= class166_0.uint_0;
					case 0u:
						goto end_IL_0055;
					}
					break;
				}
				continue;
				end_IL_0055:
				break;
			}
		}
		return false;
	}

	internal static void smethod_283(IntPtr intptr_0, Class69 class69_0)
	{
		int num = class69_0.gclass2_0.list_1.Count - 1;
		while (true)
		{
			int num2 = ((num >= 0) ? 1965510689 : 319296093);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x198697BB)) % 7)
				{
				case 4u:
					num2 = 1965510689;
					continue;
				case 2u:
					class69_0.gclass2_0.list_1.RemoveAt(num);
					num2 = ((int)num3 * -1936119763) ^ -1633136007;
					continue;
				case 1u:
					num2 = ((!(class69_0.gclass2_0.list_1[num].method_0() == intptr_0)) ? 89802423 : 82506468);
					continue;
				case 0u:
					num--;
					num2 = 2140263822;
					continue;
				default:
					return;
				case 3u:
					break;
				case 5u:
					return;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_284(GClass4 gclass4_0, GClass5 gclass5_0)
	{
		gclass5_0.method_19(Enum41.flag_32 | Enum41.flag_33 | Enum41.flag_34);
		gclass4_0.class154_0.method_28().Position = gclass5_0.method_8();
		int num3 = default(int);
		bool flag = default(bool);
		uint num9 = default(uint);
		int num13 = default(int);
		long num7 = default(long);
		long position2 = default(long);
		int num4 = default(int);
		int num5 = default(int);
		byte[] buffer = default(byte[]);
		int num8 = default(int);
		int num10 = default(int);
		int num15 = default(int);
		int num11 = default(int);
		long num6 = default(long);
		int num16 = default(int);
		int num12 = default(int);
		long position = default(long);
		while (true)
		{
			int num = 305058695;
			while (true)
			{
				uint num2;
				int num14;
				switch ((num2 = (uint)(num ^ 0x2EC38574)) % 221)
				{
				case 220u:
					num = ((num3 < 15) ? 1686229034 : 1229093046);
					continue;
				case 219u:
					num = (int)((num2 * 378020019) ^ 0x646AEAA6);
					continue;
				case 218u:
					gclass4_0.binaryWriter_0.Write(flag ? GClass4.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 516586338;
					continue;
				case 216u:
					gclass4_0.binaryWriter_0.Write((byte)61);
					gclass4_0.binaryWriter_0.Write(flag ? GClass4.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 352292013;
					continue;
				case 215u:
					gclass4_0.binaryWriter_0.Write((byte)81);
					num = 1733674643;
					continue;
				case 214u:
					num = ((int)num2 * -595445714) ^ 0x6A7E3523;
					continue;
				case 213u:
					goto IL_00f2;
				case 212u:
					gclass4_0.binaryWriter_0.Write((byte)93);
					num = ((int)num2 * -1889548336) ^ -640656859;
					continue;
				case 211u:
					gclass4_0.binaryWriter_0.Write(GClass4.smethod_0((byte)96, (GClass4.Delegate48<byte>)smethod_166));
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 199, 7 });
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 7, 233 });
					num = ((int)num2 * -1224632176) ^ -105429906;
					continue;
				case 210u:
					gclass4_0.binaryWriter_0.Write((byte)233);
					num = (int)((num2 * 1074061146) ^ 0x3AA5D369);
					continue;
				case 209u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 192, 6 });
					num = 1899535561;
					continue;
				case 208u:
					gclass4_0.binaryWriter_0.Write((byte)117);
					num = 2085162869;
					continue;
				case 207u:
					num = (int)(num2 * 967311111) ^ -203969100;
					continue;
				case 206u:
					goto IL_022f;
				case 205u:
					goto IL_024f;
				case 204u:
					goto IL_0275;
				case 203u:
					goto IL_0295;
				case 202u:
					gclass4_0.class154_0.method_6().method_3().imethod_12(gclass5_0.method_4());
					num = (int)((num2 * 627548287) ^ 0x640E422E);
					continue;
				case 201u:
					num14 = gclass4_0.random_0.Next(1, num13);
					goto IL_02f1;
				case 200u:
					gclass4_0.class154_0.method_28().Position -= num7 + 1L;
					num = (int)((num2 * 1727907532) ^ 0x4E057183);
					continue;
				case 199u:
					num = ((num3 <= 30) ? (-6535356) : (-787062281)) ^ (int)(num2 * 862239932);
					continue;
				case 198u:
					goto IL_037d;
				case 197u:
					gclass4_0.binaryWriter_0.Write((byte)190);
					gclass4_0.binaryWriter_0.Write(num9);
					num = (int)((num2 * 14813109) ^ 0x2BF1E0F2);
					continue;
				case 196u:
					num = ((int)num2 * -884719291) ^ 0x154FBB58;
					continue;
				case 195u:
					num = (int)((num2 * 1173518897) ^ 0x72467F99);
					continue;
				case 194u:
					gclass4_0.binaryWriter_0.Write(num9);
					num = (int)((num2 * 1936693761) ^ 0x74C6ACA);
					continue;
				case 193u:
					goto IL_040a;
				case 192u:
					goto IL_0424;
				case 191u:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 255 });
					num = (int)((num2 * 349300742) ^ 0x57007858);
					continue;
				case 190u:
					goto IL_0478;
				case 189u:
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = (int)(num2 * 1815301175) ^ -485293696;
					continue;
				case 188u:
					gclass4_0.binaryWriter_0.Write((byte)233);
					num13 = (int)(gclass4_0.class154_0.method_28().Position - position2 - 30L);
					num = ((int)num2 * -227216085) ^ 0x660856DD;
					continue;
				case 187u:
					goto IL_0503;
				case 186u:
					num = ((int)num2 * -530719548) ^ 0x264E10A6;
					continue;
				case 185u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 7, 96 });
					num = (int)(num2 * 1708650183) ^ -21216774;
					continue;
				case 184u:
					num = ((num4 < 15) ? (-770264460) : (-1738635243)) ^ (int)(num2 * 1046728068);
					continue;
				case 183u:
					num = (int)((num2 * 390353747) ^ 0x1CF2201A);
					continue;
				case 182u:
					goto IL_05ab;
				case 181u:
					num5 = 0;
					num = ((int)num2 * -1045951476) ^ 0x2CBFA7E3;
					continue;
				case 180u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 2, 233 });
					num = ((int)num2 * -2096866926) ^ -420189005;
					continue;
				case 179u:
					goto IL_0610;
				case 178u:
					gclass4_0.binaryWriter_0.Write(flag ? GClass4.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 516586338;
					continue;
				case 177u:
					goto IL_066b;
				case 176u:
					goto IL_068b;
				case 175u:
					goto IL_06ab;
				case 174u:
					gclass4_0.binaryWriter_0.Write(buffer);
					num = (int)(num2 * 1704521744) ^ -1963012049;
					continue;
				case 173u:
					num = ((int)num2 * -2089321290) ^ -1551517659;
					continue;
				case 172u:
					goto IL_0708;
				case 171u:
					num = ((int)num2 * -881437792) ^ -1699535389;
					continue;
				case 170u:
					num = ((num3 < 15) ? 1363434541 : 1452231447) ^ (int)(num2 * 1046200270);
					continue;
				case 169u:
					flag = gclass4_0.random_0.Next(2) == 1;
					num = ((int)num2 * -64570790) ^ -590354875;
					continue;
				case 168u:
					num9 = gclass4_0.random_0.smethod_0();
					num = 1359180453;
					continue;
				case 167u:
					num = ((int)num2 * -1103271214) ^ 0x7495465D;
					continue;
				case 166u:
					num = (int)((num2 * 1453342971) ^ 0xC8DE6DD);
					continue;
				case 165u:
					goto IL_07c6;
				case 164u:
					num8 = gclass4_0.random_0.Next(7);
					num = ((int)num2 * -1995143659) ^ -251124306;
					continue;
				case 163u:
					goto IL_0807;
				case 162u:
					goto IL_083b;
				case 161u:
					goto IL_085b;
				case 160u:
					num = (int)(num2 * 1258101779) ^ -185532408;
					continue;
				case 159u:
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = ((int)num2 * -1452208755) ^ 0x37025D3A;
					continue;
				case 158u:
					goto IL_08b1;
				case 157u:
					num = ((int)num2 * -1907795451) ^ 0x67E97B16;
					continue;
				case 156u:
					gclass4_0.binaryWriter_0.Write((byte)189);
					num = (int)(num2 * 802842557) ^ -165762734;
					continue;
				case 155u:
					num = (int)(num2 * 559511136) ^ -1361062333;
					continue;
				case 154u:
					gclass4_0.binaryWriter_0.Write((byte)num7);
					gclass4_0.class154_0.method_28().Position += num7;
					num = ((int)num2 * -676465071) ^ -632224180;
					continue;
				case 153u:
					gclass4_0.binaryWriter_0.Write((byte)195);
					num = (int)((num2 * 644856095) ^ 0x79321AC5);
					continue;
				case 152u:
					num = ((int)num2 * -424415677) ^ 0xD865AD1;
					continue;
				case 151u:
					num = ((int)num2 * -1291021938) ^ -677498445;
					continue;
				case 150u:
					position2 = gclass4_0.class154_0.method_28().Position;
					gclass4_0.binaryWriter_0.Write((byte)233);
					gclass4_0.binaryWriter_0.Write(0);
					num = ((int)num2 * -1962027042) ^ -1005481196;
					continue;
				case 149u:
					gclass4_0.binaryWriter_0.Write((int)(gclass4_0.class154_0.method_6().method_3().imethod_11() - gclass5_0.method_4() - 5 - num10));
					num13 = (int)(gclass5_0.method_2() - (gclass4_0.class154_0.method_28().Position - position2) - 30L);
					num = (int)(num2 * 1969700806) ^ -131591895;
					continue;
				case 148u:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 251 });
					num = (int)((num2 * 2021970831) ^ 0x7356BC62);
					continue;
				case 147u:
					num = ((int)num2 * -382986518) ^ -296715301;
					continue;
				case 146u:
					num3 = num4;
					num5++;
					num = 1063215034;
					continue;
				case 145u:
					goto IL_0aa7;
				case 144u:
					num = ((int)num2 * -764754816) ^ 0x6FBD4E43;
					continue;
				case 143u:
					goto IL_0ade;
				case 142u:
					num15 = gclass4_0.random_0.Next(1, num13);
					gclass4_0.binaryWriter_0.Write(num15);
					num = 1056626222;
					continue;
				case 141u:
					num10 = (int)(gclass4_0.class154_0.method_28().Position - position2);
					gclass4_0.binaryWriter_0.Write(GClass4.smethod_0((byte)233, (GClass4.Delegate48<byte>)smethod_166));
					num = 2089643215;
					continue;
				case 140u:
					num = (int)((num2 * 1159913728) ^ 0x7365CEC3);
					continue;
				case 139u:
					num = ((int)num2 * -1498274518) ^ -766816087;
					continue;
				case 138u:
					num11 = gclass4_0.random_0.Next(18, (int)(gclass5_0.method_2() - num6 + 18L));
					num = (int)(num2 * 6921156) ^ -101081110;
					continue;
				case 137u:
					goto IL_0be3;
				case 136u:
					num = (int)(num2 * 542166685) ^ -1465015129;
					continue;
				case 135u:
					num = ((int)num2 * -529483792) ^ 0x2279C0D3;
					continue;
				case 134u:
					goto IL_0c29;
				case 133u:
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = (int)(num2 * 2002970017) ^ -661440136;
					continue;
				case 132u:
					gclass4_0.class154_0.method_28().Position = position2 + 1L;
					gclass4_0.binaryWriter_0.Write(num10 - 23);
					num = 988831160;
					continue;
				case 131u:
					goto IL_0caf;
				case 130u:
					goto IL_0cc6;
				case 129u:
					num16 = gclass4_0.random_0.Next((int)gclass5_0.method_2() / 50, (int)gclass5_0.method_2() / 25);
					buffer = new byte[num16];
					gclass4_0.random_0.NextBytes(buffer);
					num = ((int)num2 * -2102074103) ^ -716178468;
					continue;
				case 128u:
					num = (int)(num2 * 1939669207) ^ -1448921687;
					continue;
				case 127u:
					buffer = new byte[num15];
					num = ((int)num2 * -241734486) ^ -726035502;
					continue;
				case 126u:
					num = (int)(num2 * 1968336229) ^ -755438860;
					continue;
				case 125u:
					goto IL_0d73;
				case 124u:
					gclass4_0.binaryWriter_0.Write(GClass4.smethod_0((byte)96, (GClass4.Delegate48<byte>)smethod_166));
					num = ((int)num2 * -815560105) ^ 0x664E03E5;
					continue;
				case 123u:
					gclass4_0.binaryWriter_0.Write(num9);
					num = ((int)num2 * -264521640) ^ -755865030;
					continue;
				case 122u:
					goto IL_0dec;
				case 121u:
					goto IL_0e06;
				case 120u:
					num = ((int)num2 * -1077335159) ^ -1281048182;
					continue;
				case 119u:
					goto IL_0e39;
				case 118u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 0, 96 });
					gclass4_0.binaryWriter_0.Write(GClass4.smethod_0((byte)96, (GClass4.Delegate48<byte>)smethod_166));
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 192, 7 });
					num = ((int)num2 * -603294904) ^ 0x603C1A07;
					continue;
				case 117u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 3, 96 });
					num = ((int)num2 * -2016482386) ^ -454935534;
					continue;
				case 116u:
					num = (int)(num2 * 1758685134) ^ -1160381176;
					continue;
				case 115u:
					gclass4_0.binaryWriter_0.Write(num9);
					num = ((int)num2 * -128756104) ^ 0x44457E5D;
					continue;
				case 114u:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 254 });
					num = (int)(num2 * 1925997889) ^ -1741353795;
					continue;
				case 113u:
					num = (int)((num2 * 1102082436) ^ 0x8FE11BF);
					continue;
				case 112u:
					goto IL_0f7d;
				case 111u:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 253 });
					num = ((int)num2 * -334565549) ^ -166286659;
					continue;
				case 110u:
					goto IL_0fdc;
				case 109u:
					num = ((int)num2 * -1179464546) ^ 0x2F8E1182;
					continue;
				case 108u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 2, 96 });
					gclass4_0.binaryWriter_0.Write(GClass4.smethod_0((byte)96, (GClass4.Delegate48<byte>)smethod_166));
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 194, 7 });
					num = ((int)num2 * -306576431) ^ 0x32BE898C;
					continue;
				case 107u:
					num = (int)((num2 * 1911873910) ^ 0x3C85AF5B);
					continue;
				case 106u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 139, 20, 36 });
					num = 482868246;
					continue;
				case 105u:
					num = (int)((num2 * 637971787) ^ 0x2F564C3A);
					continue;
				case 104u:
					gclass4_0.binaryWriter_0.Write((int)(gclass5_0.method_4() + 5 + num16 - (gclass5_0.method_4() + num10 + 5L)));
					gclass4_0.class154_0.method_28().Position += num11 - 18;
					switch (num12)
					{
					case 2:
						break;
					default:
						goto IL_1135;
					case 0:
						goto IL_1148;
					case 1:
						goto IL_116e;
					case 3:
						goto IL_1194;
					case 4:
						goto IL_11ba;
					}
					goto case 106u;
				case 46u:
					goto IL_1148;
				case 48u:
					goto IL_116e;
				case 32u:
					goto IL_1194;
				case 93u:
					goto IL_11ba;
				case 103u:
					num = (int)(num2 * 978092314) ^ -313458219;
					continue;
				case 102u:
					gclass4_0.binaryWriter_0.Write((byte)88);
					num = (int)((num2 * 135953848) ^ 0xC1E9B6A);
					continue;
				case 101u:
					num = ((num3 > 30) ? 1842268660 : 245437001) ^ ((int)num2 * -506391089);
					continue;
				case 100u:
					goto IL_124d;
				case 99u:
					num = ((int)num2 * -1104150545) ^ -1458267190;
					continue;
				case 98u:
					num4 = gclass4_0.random_0.Next(15, 31);
					num = ((int)num2 * -936797130) ^ -1742564989;
					continue;
				case 97u:
					if (num13 >= 0)
					{
						num = ((int)num2 * -1923346361) ^ 0xF98F672;
						continue;
					}
					num14 = 0;
					goto IL_02f1;
				case 96u:
					gclass4_0.binaryWriter_0.Write((byte)89);
					num = (int)(num2 * 484663467) ^ -1183175794;
					continue;
				case 95u:
					num = (flag ? 519778500 : 1302648361);
					continue;
				case 94u:
					num = ((int)num2 * -1146368755) ^ -613784753;
					continue;
				case 92u:
					goto IL_1325;
				case 91u:
					gclass4_0.binaryWriter_0.Write((byte)195);
					num = ((int)num2 * -90060275) ^ 0x1A740585;
					continue;
				case 90u:
					goto IL_136c;
				case 89u:
					goto IL_1392;
				case 88u:
					gclass4_0.binaryWriter_0.Write(flag ? GClass4.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 1120404196;
					continue;
				case 87u:
					num = (int)(num2 * 359654114) ^ -915876332;
					continue;
				case 86u:
					num = ((int)num2 * -176775374) ^ -158793163;
					continue;
				case 85u:
					num = (int)(num2 * 670289437) ^ -271968048;
					continue;
				case 84u:
					num = ((int)num2 * -781214535) ^ 0x6BF54CDD;
					continue;
				case 83u:
					num = ((int)num2 * -1498924529) ^ -318244760;
					continue;
				case 82u:
					num = ((int)num2 * -1838916759) ^ -271813513;
					continue;
				case 81u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 1, 233 });
					num = ((int)num2 * -70816932) ^ -1983179234;
					continue;
				case 80u:
					num = ((num4 <= 45) ? (-534896338) : (-2107584804)) ^ (int)(num2 * 913917175);
					continue;
				case 79u:
					goto IL_14a5;
				case 78u:
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 1009670288) ^ 0x4D6A81B2);
					continue;
				case 77u:
					num = ((num3 > 45) ? (-439038158) : (-2078598137)) ^ (int)(num2 * 1739698323);
					continue;
				case 76u:
					gclass4_0.binaryWriter_0.Write(num9);
					num = (int)((num2 * 772551642) ^ 0x171794D6);
					continue;
				case 75u:
					num = ((int)num2 * -79949315) ^ -224515549;
					continue;
				case 74u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 195, 7 });
					num = (int)((num2 * 1136029018) ^ 0x3CB1CAE6);
					continue;
				case 73u:
					num = (int)((num2 * 780591959) ^ 0x26B099D1);
					continue;
				case 72u:
					goto IL_1595;
				case 71u:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 249 });
					gclass4_0.binaryWriter_0.Write(flag ? GClass4.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 161606325;
					continue;
				case 70u:
					goto IL_1611;
				case 69u:
					gclass4_0.binaryWriter_0.Write((byte)94);
					num = ((int)num2 * -230312221) ^ 0xD99A396;
					continue;
				case 68u:
					gclass4_0.binaryWriter_0.Write(num9);
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 250 });
					gclass4_0.binaryWriter_0.Write(flag ? GClass4.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 457319644;
					continue;
				case 67u:
					goto IL_16b7;
				case 66u:
					goto IL_16f8;
				case 65u:
					goto IL_1723;
				case 64u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 0, 233 });
					num = (int)((num2 * 1193206714) ^ 0x77CEEDC6);
					continue;
				case 63u:
					gclass4_0.binaryWriter_0.Write(flag ? GClass4.smethod_0(num9, () => gclass4_0.random_0.smethod_0()) : num9);
					num = 516586338;
					continue;
				case 62u:
					goto IL_179d;
				case 61u:
					num = ((num13 < 0) ? (-164001094) : (-959208304)) ^ (int)(num2 * 604857919);
					continue;
				case 60u:
					gclass4_0.binaryWriter_0.Write((byte)184);
					num = ((int)num2 * -1886643111) ^ -1130372139;
					continue;
				case 59u:
					gclass4_0.binaryWriter_0.Write((byte)95);
					num = ((int)num2 * -1826285317) ^ -1436682269;
					continue;
				case 58u:
					goto IL_1835;
				case 57u:
					num = ((int)num2 * -289767636) ^ 0x7F4A7343;
					continue;
				case 56u:
					num = ((int)num2 * -213756742) ^ 0x1AD823B7;
					continue;
				case 55u:
					num = (int)((num2 * 1924600756) ^ 0xDDB7CF6);
					continue;
				case 54u:
					num = ((int)num2 * -1946070003) ^ 0x196BD72E;
					continue;
				case 53u:
					num = ((num5 < gclass4_0.random_0.Next((int)(gclass5_0.method_2() / 10), (int)(gclass5_0.method_2() / 8))) ? 700303845 : 1735233297);
					continue;
				case 52u:
					num3 = -1;
					num = ((int)num2 * -84917066) ^ 0x177AD86E;
					continue;
				case 51u:
					gclass4_0.binaryWriter_0.Write((byte)232);
					num = ((int)num2 * -379217128) ^ 0x79214FD4;
					continue;
				case 50u:
					num13 = 2;
					num = (int)(num2 * 1598022106) ^ -1947642038;
					continue;
				case 49u:
					goto IL_1936;
				case 47u:
					num = (int)(num2 * 1460566507) ^ -929350941;
					continue;
				case 45u:
					num = ((num4 >= 39) ? 1316240462 : 1686229034);
					continue;
				case 44u:
					gclass4_0.binaryWriter_0.Write((byte)195);
					num = (int)((num2 * 766263518) ^ 0x158E34CD);
					continue;
				case 43u:
					gclass4_0.random_0.NextBytes(buffer);
					num = ((int)num2 * -48200879) ^ 0x7EF37F5C;
					continue;
				case 42u:
					num = ((int)num2 * -1923694133) ^ -226312361;
					continue;
				case 41u:
					gclass4_0.binaryWriter_0.Write(num11);
					num12 = gclass4_0.random_0.Next(5);
					switch (num12)
					{
					case 0:
						break;
					case 4:
						goto IL_024f;
					case 3:
						goto IL_136c;
					default:
						goto IL_1a16;
					case 1:
						goto IL_1a29;
					case 2:
						goto IL_1aa5;
					}
					goto case 209u;
				case 4u:
					goto IL_1a29;
				case 9u:
					goto IL_1aa5;
				case 40u:
					goto IL_1acb;
				case 39u:
					goto IL_1afb;
				case 38u:
					num = (int)((num2 * 527836293) ^ 0x169EBA1E);
					continue;
				case 37u:
					num = ((int)num2 * -1822041019) ^ -453979335;
					continue;
				case 36u:
					gclass4_0.binaryWriter_0.Write((byte)gclass4_0.random_0.Next(2, 128));
					gclass4_0.binaryWriter_0.Write((byte)97);
					num10 = (int)(gclass4_0.class154_0.method_28().Position - position2);
					num = 1838090966;
					continue;
				case 35u:
					gclass4_0.binaryWriter_0.Write(buffer);
					num = ((int)num2 * -1791121218) ^ 0x15563351;
					continue;
				case 34u:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 3, 233 });
					num = ((int)num2 * -494382531) ^ 0x28C0E326;
					continue;
				case 33u:
					gclass4_0.binaryWriter_0.Write((byte)186);
					num = (int)(num2 * 621253200) ^ -433800949;
					continue;
				case 31u:
					num4 = GClass4.smethod_0(num3, () => gclass4_0.random_0.Next(53));
					num = 497918434;
					continue;
				case 30u:
					num4 = gclass4_0.random_0.Next(53);
					num = 1005466653;
					continue;
				case 29u:
					position = gclass4_0.class154_0.method_28().Position;
					switch (num4)
					{
					case 32:
						break;
					case 50:
						goto IL_00f2;
					case 19:
						goto IL_022f;
					case 21:
						goto IL_0275;
					case 25:
						goto IL_0295;
					case 36:
						goto IL_037d;
					case 7:
						goto IL_040a;
					case 18:
						goto IL_0424;
					case 30:
						goto IL_0478;
					case 11:
						goto IL_0503;
					case 17:
						goto IL_05ab;
					case 48:
						goto IL_0610;
					case 15:
						goto IL_066b;
					case 16:
						goto IL_068b;
					case 43:
						goto IL_06ab;
					case 29:
						goto IL_0708;
					case 23:
						goto IL_07c6;
					case 24:
						goto IL_083b;
					case 0:
						goto IL_085b;
					case 33:
						goto IL_0aa7;
					case 52:
						goto IL_0ade;
					case 22:
						goto IL_0be3;
					case 12:
						goto IL_0c29;
					case 31:
						goto IL_0caf;
					case 10:
						goto IL_0cc6;
					case 8:
						goto IL_0d73;
					case 2:
						goto IL_0dec;
					case 26:
						goto IL_0e06;
					case 6:
						goto IL_0e39;
					case 44:
						goto IL_0f7d;
					case 45:
						goto IL_0fdc;
					case 3:
						goto IL_124d;
					case 35:
						goto IL_1325;
					case 13:
						goto IL_14a5;
					case 39:
						goto IL_1595;
					case 9:
						goto IL_1611;
					case 49:
						goto IL_16b7;
					case 51:
						goto IL_16f8;
					case 46:
						goto IL_1723;
					case 41:
						goto IL_179d;
					case 40:
						goto IL_1835;
					case 20:
						goto IL_1936;
					case 1:
						goto IL_1acb;
					case 4:
						goto IL_1afb;
					default:
						goto IL_1d2f;
					case 5:
						goto IL_1d39;
					case 14:
						goto IL_1d69;
					case 27:
						goto IL_1d91;
					case 28:
						goto IL_1db1;
					case 34:
						goto IL_1dd1;
					case 37:
						goto IL_1df5;
					case 38:
						goto IL_1e0c;
					case 42:
						goto IL_1e23;
					case 47:
						goto IL_1e4e;
					}
					goto case 215u;
				case 27u:
					goto IL_1d39;
				case 5u:
					goto IL_1d69;
				case 11u:
					goto IL_1d91;
				case 6u:
					goto IL_1db1;
				case 28u:
					goto IL_1dd1;
				case 7u:
					goto IL_1df5;
				case 16u:
					goto IL_1e0c;
				case 18u:
					goto IL_1e23;
				case 23u:
					goto IL_1e4e;
				case 26u:
					num = ((int)num2 * -273305275) ^ 0x6DBEAA44;
					continue;
				case 25u:
					switch (num8)
					{
					case 5:
						break;
					case 6:
						goto IL_0807;
					case 1:
						goto IL_08b1;
					case 2:
						goto IL_1392;
					default:
						goto IL_1ec5;
					case 0:
						goto IL_1ed8;
					case 3:
						goto IL_1eef;
					case 4:
						goto IL_1f16;
					}
					goto case 168u;
				case 10u:
					goto IL_1ed8;
				case 14u:
					goto IL_1eef;
				case 0u:
					goto IL_1f16;
				case 24u:
					num = (int)((num2 * 1175045322) ^ 0x7A30F98B);
					continue;
				case 22u:
					num7 = gclass4_0.class154_0.method_28().Position - position;
					num = 855152025;
					continue;
				case 21u:
					num = ((int)num2 * -1447756720) ^ -2139990349;
					continue;
				case 20u:
					num = (int)(num2 * 589469835) ^ -21083709;
					continue;
				case 19u:
					gclass4_0.binaryWriter_0.Write((byte)116);
					num = ((int)num2 * -615290808) ^ 0x7A93658E;
					continue;
				case 17u:
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = ((int)num2 * -1038425756) ^ -1522088395;
					continue;
				case 15u:
					num6 = gclass4_0.class154_0.method_28().Position - gclass5_0.method_8();
					num = ((int)num2 * -174527814) ^ 0x4BA48288;
					continue;
				case 13u:
					num = ((num3 >= 39) ? 744360995 : 551314375);
					continue;
				case 12u:
					num = ((num4 > 30) ? (-1446200345) : (-1859856553)) ^ (int)(num2 * 1631605499);
					continue;
				case 8u:
					num = ((num3 != -1) ? 1976152531 : 1686229034);
					continue;
				case 3u:
					num = (int)(num2 * 1884568933) ^ -924737143;
					continue;
				case 1u:
					gclass4_0.binaryWriter_0.Write((byte)195);
					num = (int)(num2 * 1950835675) ^ -806446463;
					continue;
				default:
					return;
				case 217u:
					break;
				case 2u:
					return;
					IL_00f2:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 197 });
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1462547698;
					continue;
					IL_0610:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 194 });
					num = 1346854063;
					continue;
					IL_05ab:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 114, 0 });
					num = 410557396;
					continue;
					IL_1f16:
					num9 = gclass4_0.random_0.smethod_0();
					num = 3561116;
					continue;
					IL_1eef:
					num9 = gclass4_0.random_0.smethod_0();
					gclass4_0.binaryWriter_0.Write((byte)187);
					num = 3376223;
					continue;
					IL_1ed8:
					num9 = gclass4_0.random_0.smethod_0();
					num = 305096990;
					continue;
					IL_1ec5:
					num = ((int)num2 * -643469374) ^ 0x71CA4C75;
					continue;
					IL_1e4e:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 193 });
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1958555918;
					continue;
					IL_1e23:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 219 });
					num = 436537672;
					continue;
					IL_1e0c:
					gclass4_0.binaryWriter_0.Write((byte)87);
					num = 1546059053;
					continue;
					IL_1df5:
					gclass4_0.binaryWriter_0.Write((byte)86);
					num = 1471824075;
					continue;
					IL_1dd1:
					gclass4_0.binaryWriter_0.Write((byte)83);
					gclass4_0.binaryWriter_0.Write((byte)91);
					num = 1137758403;
					continue;
					IL_1db1:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 125, 0 });
					num = 1964534240;
					continue;
					IL_1d91:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 124, 0 });
					num = 1792764093;
					continue;
					IL_1d69:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 255 });
					num = 1412264438;
					continue;
					IL_1d39:
					gclass4_0.binaryWriter_0.Write((byte)189);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1188458100;
					continue;
					IL_1d2f:
					num = 456428813;
					continue;
					IL_1afb:
					gclass4_0.binaryWriter_0.Write((byte)187);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1263548425;
					continue;
					IL_1acb:
					gclass4_0.binaryWriter_0.Write((byte)184);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1137758403;
					continue;
					IL_1aa5:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 194, 6 });
					num = 31990827;
					continue;
					IL_1a29:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 193, 6 });
					gclass4_0.binaryWriter_0.Write(new byte[3] { 198, 1, 96 });
					gclass4_0.binaryWriter_0.Write(GClass4.smethod_0((byte)96, (GClass4.Delegate48<byte>)smethod_166));
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 193, 7 });
					num = 215853252;
					continue;
					IL_1a16:
					num = (int)(num2 * 919280634) ^ -717987036;
					continue;
					IL_1936:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 117, 0 });
					num = 1137758403;
					continue;
					IL_1835:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 201 });
					num = 1412008783;
					continue;
					IL_179d:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 210 });
					num = 798553809;
					continue;
					IL_0503:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 219 });
					num = 1623874145;
					continue;
					IL_1723:
					gclass4_0.binaryWriter_0.Write((byte)5);
					num = 1784154990;
					continue;
					IL_16f8:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 198 });
					num = 449174633;
					continue;
					IL_16b7:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 195 });
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 51231112;
					continue;
					IL_0424:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 115, 0 });
					num = 904988517;
					continue;
					IL_0478:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 127, 0 });
					num = 1107002620;
					continue;
					IL_1611:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 201 });
					num = 1137758403;
					continue;
					IL_040a:
					gclass4_0.binaryWriter_0.Write((byte)191);
					num = 1280905986;
					continue;
					IL_1595:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 192 });
					num = 97560293;
					continue;
					IL_037d:
					gclass4_0.binaryWriter_0.Write((byte)85);
					num = 1805410727;
					continue;
					IL_14a5:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 246 });
					num = 2012189460;
					continue;
					IL_1392:
					num9 = gclass4_0.random_0.smethod_0();
					num = 2127398237;
					continue;
					IL_136c:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 195, 6 });
					num = 1032748925;
					continue;
					IL_1325:
					gclass4_0.binaryWriter_0.Write((byte)84);
					gclass4_0.binaryWriter_0.Write((byte)92);
					num = 1987388939;
					continue;
					IL_02f1:
					num15 = num14;
					buffer = new byte[num15];
					gclass4_0.random_0.NextBytes(buffer);
					gclass4_0.binaryWriter_0.Write(buffer);
					num = 74389284;
					continue;
					IL_0295:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 122, 0 });
					num = 1489154986;
					continue;
					IL_0275:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 118, 0 });
					num = 1696512839;
					continue;
					IL_124d:
					gclass4_0.binaryWriter_0.Write((byte)186);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 243166376;
					continue;
					IL_022f:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 116, 0 });
					num = 1146262003;
					continue;
					IL_024f:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 131, 199, 6 });
					num = 515504599;
					continue;
					IL_11ba:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 139, 60, 36 });
					gclass4_0.binaryWriter_0.Write((byte)195);
					num = 1495017047;
					continue;
					IL_1194:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 139, 28, 36 });
					num = 150413617;
					continue;
					IL_116e:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 139, 12, 36 });
					num = 1932517367;
					continue;
					IL_1148:
					gclass4_0.binaryWriter_0.Write(new byte[3] { 139, 4, 36 });
					num = 1512137255;
					continue;
					IL_1135:
					num = ((int)num2 * -226357130) ^ 0x6D288831;
					continue;
					IL_0fdc:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 255 });
					num = 1874612891;
					continue;
					IL_0f7d:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 246 });
					num = 1697160656;
					continue;
					IL_0e39:
					gclass4_0.binaryWriter_0.Write((byte)190);
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1908395651;
					continue;
					IL_0e06:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 123, 0 });
					num = 1546110467;
					continue;
					IL_0dec:
					gclass4_0.binaryWriter_0.Write((byte)185);
					num = 1701317269;
					continue;
					IL_0d73:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 192 });
					num = 1387697096;
					continue;
					IL_0cc6:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 210 });
					num = 1137758403;
					continue;
					IL_0caf:
					gclass4_0.binaryWriter_0.Write((byte)80);
					num = 464933626;
					continue;
					IL_0c29:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 51, 237 });
					num = 1137758403;
					continue;
					IL_0be3:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 119, 0 });
					num = 1137758403;
					continue;
					IL_0ade:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 129, 199 });
					gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
					num = 1137758403;
					continue;
					IL_0aa7:
					gclass4_0.binaryWriter_0.Write((byte)82);
					gclass4_0.binaryWriter_0.Write((byte)90);
					num = 1137758403;
					continue;
					IL_08b1:
					num9 = gclass4_0.random_0.smethod_0();
					gclass4_0.binaryWriter_0.Write((byte)185);
					num = 1697763964;
					continue;
					IL_085b:
					gclass4_0.binaryWriter_0.Write((byte)144);
					num = 2055170547;
					continue;
					IL_083b:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 121, 0 });
					num = 1612015647;
					continue;
					IL_0807:
					num9 = gclass4_0.random_0.smethod_0();
					gclass4_0.binaryWriter_0.Write((byte)191);
					gclass4_0.binaryWriter_0.Write(num9);
					num = 152124170;
					continue;
					IL_07c6:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 120, 0 });
					num = 318679494;
					continue;
					IL_0708:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 126, 0 });
					num = 1137758403;
					continue;
					IL_06ab:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 133, 237 });
					num = 1317661814;
					continue;
					IL_068b:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 113, 0 });
					num = 1137758403;
					continue;
					IL_066b:
					gclass4_0.binaryWriter_0.Write(new byte[2] { 112, 0 });
					num = 1137758403;
					continue;
				}
				break;
			}
		}
	}

	internal static GClass3 smethod_285(GClass2 gclass2_0)
	{
		return gclass2_0.gclass3_0 ?? (gclass2_0.gclass3_0 = new GClass3(gclass2_0));
	}

	[DllImport("user32.dll")]
	internal static extern IntPtr GetClassLongPtr(IntPtr intptr_0, int int_0);

	internal static void smethod_286(Class47 class47_0, IntPtr intptr_0)
	{
		if (class47_0.bool_0)
		{
			goto IL_002b;
		}
		goto IL_0055;
		IL_002b:
		int num = 1410379729;
		goto IL_0030;
		IL_0030:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x57B7743E)) % 5)
			{
			case 3u:
				smethod_222(class47_0.class53_0, intptr_0.ToInt32());
				num = (int)((num2 * 544993288) ^ 0x31CEECDD);
				continue;
			case 2u:
				break;
			default:
				return;
			case 1u:
				goto IL_0055;
			case 0u:
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_002b;
		IL_0055:
		smethod_118(class47_0.class53_0, intptr_0);
		num = 1606717740;
		goto IL_0030;
	}

	internal static bool smethod_287(Class77 class77_0)
	{
		return IsWindowVisible(class77_0.method_0());
	}

	internal static void smethod_288(Class53 class53_0)
	{
		class53_0.struct19_0.uint_2 |= 8u;
	}

	internal static void ApplyMainFormTheme(MainForm mainForm)
	{
		Color color_ = ApplicationSettings.Current.Options.TextColor;
		while (true)
		{
			int num = 358457720;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x455D6409)) % 4)
				{
				case 1u:
					mainForm.processNameLabel.ForeColor = color_;
					mainForm.processDescriptionLabel.ForeColor = color_;
					num = (int)((num2 * 1745266509) ^ 0x4AFF30C8);
					continue;
				case 0u:
					mainForm.injectionListLabel.ForeColor = color_;
					num = (int)((num2 * 1814288441) ^ 0x48AB0AB3);
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal static Class59 smethod_290(Class58 class58_0, long long_0, Class47 class47_0)
	{
		if (class47_0.bool_0)
		{
			while (true)
			{
				int num = -747650810;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1979585359)) % 3)
					{
					case 1u:
						class47_0.class53_0.struct19_0.uint_2 |= 8u;
						num = (int)(num2 * 962352465) ^ -1883202530;
						continue;
					case 2u:
						break;
					default:
						goto end_IL_0049;
					}
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
		return smethod_257(class58_0, long_0);
	}

	internal static void smethod_291(string string_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
		try
		{
			BinaryReader binaryReader = new BinaryReader(fileStream);
			try
			{
				BinaryWriter binaryWriter = new BinaryWriter(fileStream);
				try
				{
					fileStream.Position = 0L;
					int num4 = default(int);
					short num5 = default(short);
					SHA512 sHA = default(SHA512);
					byte[] array = default(byte[]);
					int num3 = default(int);
					byte[] array2 = default(byte[]);
					long position = default(long);
					while (true)
					{
						int num = -1104893384;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num ^ -1556812185)) % 24)
							{
							case 23u:
								num4 += 4;
								num = ((int)num2 * -1619675033) ^ 0x3654E1D8;
								continue;
							case 22u:
								fileStream.Position = binaryReader.ReadInt32();
								num = ((int)num2 * -878168491) ^ -1840919627;
								continue;
							case 21u:
								num5 = binaryReader.ReadInt16();
								num = (int)(num2 * 983116168) ^ -109614910;
								continue;
							case 20u:
								num = ((binaryReader.ReadInt32() != 17744) ? 1578440202 : 1833684567) ^ (int)(num2 * 925709865);
								continue;
							case 18u:
								sHA.TransformFinalBlock(array, 0, array.Length);
								num3 = 0;
								num4 = 0;
								num = ((int)num2 * -1636582091) ^ 0x338F0FC3;
								continue;
							case 17u:
								array2 = binaryReader.ReadBytes((int)position);
								num = (int)((num2 * 1724062415) ^ 0x7D66A4D5);
								continue;
							case 16u:
								fileStream.Position += 4L;
								num = (int)(num2 * 2069283185) ^ -660047511;
								continue;
							case 15u:
								position = fileStream.Position;
								fileStream.Position = 0L;
								num = (int)(num2 * 118219838) ^ -218772817;
								continue;
							case 14u:
								num = ((fileStream.Length - fileStream.Position < 1024L) ? (-874426530) : (-149312557));
								continue;
							case 13u:
								sHA.TransformBlock(array2, 0, array2.Length, array2, 0);
								num = ((int)num2 * -649205026) ^ 0x6CD77401;
								continue;
							case 12u:
								array2 = binaryReader.ReadBytes(1024);
								sHA.TransformBlock(array2, 0, 1024, array2, 0);
								num = -1488033447;
								continue;
							case 11u:
								fileStream.Position = 60L;
								num = -1346904703;
								continue;
							case 8u:
								fileStream.Position = position;
								num = (int)((num2 * 107580618) ^ 0x59E7104D);
								continue;
							case 7u:
								num = ((binaryReader.ReadInt16() == 23117) ? (-559332014) : (-1140524942)) ^ ((int)num2 * -1255516942);
								continue;
							case 6u:
								num = ((num4 >= sHA.Hash.Length) ? (-1047201753) : (-1229601185));
								continue;
							case 5u:
								fileStream.Position += ((num5 == 267) ? 86 : 102);
								num = -843505128;
								continue;
							case 4u:
								fileStream.Position += 20L;
								num = -1569336134;
								continue;
							case 2u:
								sHA = SHA512.Create();
								num = ((int)num2 * -744895028) ^ 0x625EB986;
								continue;
							case 1u:
								array = binaryReader.ReadBytes((int)(fileStream.Length - fileStream.Position));
								num = ((int)num2 * -2083278319) ^ 0x3154A1C4;
								continue;
							case 0u:
								num3 += BitConverter.ToInt32(sHA.Hash, num4);
								num = -1578623416;
								continue;
							case 3u:
								break;
							case 9u:
								return;
							default:
								binaryWriter.Write(num3);
								return;
							case 19u:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					if (binaryWriter != null)
					{
						while (true)
						{
							IL_03b9:
							int num6 = -685880318;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num6 ^ -1556812185)) % 3)
								{
								case 1u:
									goto IL_0387;
								default:
									goto end_IL_039b;
								case 2u:
									break;
								case 0u:
									goto end_IL_039b;
								}
								goto IL_03b9;
								IL_0387:
								((IDisposable)binaryWriter).Dispose();
								num6 = (int)((num2 * 366828839) ^ 0x6CD59282);
								continue;
								end_IL_039b:
								break;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (binaryReader != null)
				{
					while (true)
					{
						IL_03f8:
						int num7 = -1047100269;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num7 ^ -1556812185)) % 3)
							{
							case 1u:
								goto IL_03c6;
							default:
								goto end_IL_03da;
							case 2u:
								break;
							case 0u:
								goto end_IL_03da;
							}
							goto IL_03f8;
							IL_03c6:
							((IDisposable)binaryReader).Dispose();
							num7 = ((int)num2 * -158643272) ^ -1878450792;
							continue;
							end_IL_03da:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0437:
					int num8 = -932043862;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num8 ^ -1556812185)) % 3)
						{
						case 2u:
							goto IL_0405;
						default:
							goto end_IL_0419;
						case 0u:
							break;
						case 1u:
							goto end_IL_0419;
						}
						goto IL_0437;
						IL_0405:
						((IDisposable)fileStream).Dispose();
						num8 = ((int)num2 * -648494257) ^ 0x61B0F55E;
						continue;
						end_IL_0419:
						break;
					}
					break;
				}
			}
		}
	}

	internal static byte[] smethod_292()
	{
		return (byte[])smethod_124().GetObject("AsmJitx86", Class68.cultureInfo_0);
	}

	[DllImport("shell32.dll")]
	internal static extern IntPtr SHGetFileInfo(string string_0, uint uint_0, ref Class122.Struct36 struct36_0, uint uint_1, Class122.Enum19 enum19_0);

	internal static Class149 smethod_293(Class5 class5_0, Class154 class154_0)
	{
		Class157 @class = class154_0.method_6().method_3().imethod_49()[13];
		long num3 = default(long);
		while (true)
		{
			int num = 1105769676;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x646B2F26)) % 11)
				{
				case 7u:
					num = (class5_0.imethod_0(num3) ? 216788385 : 711710922) ^ (int)(num2 * 370115479);
					continue;
				case 6u:
					num = ((@class.method_0() != 0) ? (-2067324191) : (-860182254)) ^ (int)(num2 * 50459695);
					continue;
				case 5u:
					num = ((@class.method_2() == 0) ? 581536003 : 1338120806) ^ (int)(num2 * 236926359);
					continue;
				case 4u:
					num3 = smethod_135(class154_0, @class.method_0());
					num = ((num3 != -1L) ? 1539903923 : 757067817);
					continue;
				case 1u:
					smethod_157(class5_0, num3);
					num = 943535746;
					continue;
				case 0u:
					num = ((!class5_0.imethod_0(num3 + @class.method_2())) ? 1341497845 : 1965542859);
					continue;
				case 2u:
					break;
				case 3u:
					return null;
				case 8u:
					return null;
				case 9u:
					return null;
				default:
					return new Class149(class5_0, class154_0);
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetExitCodeThread(IntPtr intptr_0, out uint uint_0);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenThread(Class124.Enum31 enum31_0, bool bool_0, int int_0);

	[DllImport("ntdll.dll", SetLastError = true)]
	internal static extern uint NtQueryInformationThread(IntPtr intptr_0, Class124.Enum25 enum25_0, out Class124.Struct49 struct49_0, int int_0, out int int_1);

	internal static void smethod_294(SettingsForm gform2_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SettingsForm));
		while (true)
		{
			int num = -1705853563;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -928649106)) % 183)
				{
				case 182u:
					gform2_0.button_0.Location = new Point(9, 48);
					num = ((int)num2 * -1759761155) ^ -1929881329;
					continue;
				case 181u:
					gform2_0.checkBox_4.AutoSize = true;
					gform2_0.checkBox_4.Location = new Point(9, 21);
					gform2_0.checkBox_4.Name = "erasePECheckBox";
					gform2_0.checkBox_4.Size = new Size(68, 17);
					gform2_0.checkBox_4.TabIndex = 0;
					num = ((int)num2 * -919923682) ^ 0x1167733E;
					continue;
				case 180u:
					gform2_0.button_1 = new Button();
					num = ((int)num2 * -1229043392) ^ 0x72BCE751;
					continue;
				case 179u:
					gform2_0.groupBox_3.TabStop = false;
					gform2_0.groupBox_3.Text = "Post-Inject Options:";
					num = ((int)num2 * -239965145) ^ -211201171;
					continue;
				case 178u:
					gform2_0.groupBox_1.Name = "injectionOptionsGroupBox";
					num = (int)((num2 * 1842782672) ^ 0x79EF6CD6);
					continue;
				case 177u:
					gform2_0.groupBox_5.Name = "toolsGroupBox";
					num = (int)(num2 * 200348384) ^ -808239276;
					continue;
				case 176u:
					gform2_0.Controls.Add(gform2_0.groupBox_4);
					num = (int)(num2 * 1402666409) ^ -1340790443;
					continue;
				case 175u:
					gform2_0.panel_2.Location = new Point(152, 21);
					num = (int)((num2 * 1733435972) ^ 0x7C2367A4);
					continue;
				case 174u:
					gform2_0.button_4.Click += gform2_0.method_12;
					gform2_0.button_5.Location = new Point(9, 41);
					num = ((int)num2 * -2119591525) ^ -1190375878;
					continue;
				case 173u:
					gform2_0.button_5.Text = "Scramble DLL";
					gform2_0.button_5.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1680119209) ^ 0x3B34FB72;
					continue;
				case 172u:
					gform2_0.button_3.Size = new Size(110, 23);
					num = ((int)num2 * -1816139661) ^ 0x1E1CB16;
					continue;
				case 171u:
					gform2_0.button_2.Name = "resetButton";
					num = ((int)num2 * -1799554654) ^ -1236190075;
					continue;
				case 170u:
					gform2_0.button_1.UseVisualStyleBackColor = true;
					gform2_0.button_1.Click += gform2_0.method_3;
					gform2_0.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
					gform2_0.comboBox_1.FormattingEnabled = true;
					gform2_0.comboBox_1.Items.AddRange(new object[5]
					{
						"None",
						"Basic",
						"Standard",
						"Extreme",
						"Custom"
					});
					num = (int)(num2 * 1682174863) ^ -382272157;
					continue;
				case 169u:
					gform2_0.comboBox_1 = new ComboBox();
					gform2_0.groupBox_3 = new GroupBox();
					num = ((int)num2 * -1860990723) ^ -1332269552;
					continue;
				case 168u:
					gform2_0.numericUpDown_1.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
					gform2_0.numericUpDown_1.Name = "injectDelayNumericUpDown";
					num = (int)(num2 * 764823054) ^ -197853236;
					continue;
				case 167u:
					gform2_0.button_1.Size = new Size(162, 23);
					num = ((int)num2 * -1260734447) ^ -1932294355;
					continue;
				case 166u:
					gform2_0.button_2.Size = new Size(110, 23);
					num = (int)(num2 * 256661961) ^ -1817396875;
					continue;
				case 165u:
					gform2_0.checkBox_2.TabIndex = 0;
					num = (int)(num2 * 1689544951) ^ -205810235;
					continue;
				case 164u:
					gform2_0.checkBox_1.AutoSize = true;
					num = (int)(num2 * 1918017406) ^ -27597368;
					continue;
				case 163u:
					gform2_0.groupBox_1 = new GroupBox();
					num = (int)((num2 * 1900349460) ^ 0x6DDA9455);
					continue;
				case 162u:
					gform2_0.groupBox_5.Controls.Add(gform2_0.button_5);
					num = ((int)num2 * -455841995) ^ 0x186E7C5B;
					continue;
				case 161u:
					gform2_0.panel_1.Size = new Size(20, 20);
					num = ((int)num2 * -682958284) ^ 0xEE8CC08;
					continue;
				case 160u:
					gform2_0.groupBox_1.Location = new Point(12, 102);
					num = (int)(num2 * 1842834998) ^ -1837354693;
					continue;
				case 159u:
					gform2_0.numericUpDown_0.Location = new Point(98, 115);
					num = (int)((num2 * 161787125) ^ 0x973BDAE);
					continue;
				case 158u:
					gform2_0.groupBox_4.Controls.Add(gform2_0.panel_2);
					gform2_0.groupBox_4.Location = new Point(202, 102);
					gform2_0.groupBox_4.Name = "themeOptionsGroupBox";
					num = ((int)num2 * -1411050158) ^ -154067549;
					continue;
				case 157u:
					gform2_0.button_2 = new Button();
					num = ((int)num2 * -510801429) ^ -1333693052;
					continue;
				case 156u:
					gform2_0.label_0.Name = "delayBetweenLabel";
					num = (int)((num2 * 268053826) ^ 0x68DFBC1D);
					continue;
				case 155u:
					gform2_0.panel_2.Size = new Size(20, 20);
					num = (int)((num2 * 852726921) ^ 0x5DA0E3D1);
					continue;
				case 154u:
					gform2_0.checkBox_0.Text = "Stealth Inject";
					num = ((int)num2 * -1680241984) ^ -1051479027;
					continue;
				case 153u:
					gform2_0.button_4.Text = "Start in Secure Mode";
					gform2_0.button_4.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1121812860) ^ -1523937389;
					continue;
				case 152u:
					gform2_0.label_0 = new System.Windows.Forms.Label();
					num = (int)(num2 * 1672103714) ^ -1726146184;
					continue;
				case 151u:
					gform2_0.label_2.TabIndex = 5;
					num = (int)((num2 * 720283123) ^ 0x1F9D662B);
					continue;
				case 150u:
					gform2_0.comboBox_1.TabIndex = 3;
					num = (int)(num2 * 1938840562) ^ -1289074794;
					continue;
				case 149u:
					gform2_0.groupBox_4.TabIndex = 4;
					num = (int)((num2 * 786973134) ^ 0x276A8682);
					continue;
				case 148u:
					gform2_0.groupBox_5.SuspendLayout();
					num = ((int)num2 * -1346111595) ^ -828293886;
					continue;
				case 147u:
					gform2_0.button_6.Name = "viewProcessInformationButton";
					gform2_0.button_6.Size = new Size(162, 23);
					num = ((int)num2 * -931689210) ^ -1825377260;
					continue;
				case 146u:
					gform2_0.button_0.Name = "advancedInjectOptions";
					num = (int)((num2 * 409551097) ^ 0x24AF0746);
					continue;
				case 145u:
					gform2_0.checkBox_4.Text = "Erase PE";
					gform2_0.checkBox_4.UseVisualStyleBackColor = true;
					gform2_0.groupBox_4.Controls.Add(gform2_0.label_2);
					gform2_0.groupBox_4.Controls.Add(gform2_0.panel_0);
					gform2_0.groupBox_4.Controls.Add(gform2_0.panel_1);
					num = (int)((num2 * 1464604345) ^ 0x4C9B1C3E);
					continue;
				case 144u:
					gform2_0.panel_0.Location = new Point(152, 67);
					num = ((int)num2 * -1417472839) ^ 0x187493F0;
					continue;
				case 143u:
					gform2_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					gform2_0.MaximizeBox = false;
					gform2_0.MinimizeBox = false;
					gform2_0.Name = "SettingsForm";
					gform2_0.Text = "Settings";
					gform2_0.FormClosing += gform2_0.method_9;
					gform2_0.groupBox_0.ResumeLayout(performLayout: false);
					gform2_0.groupBox_1.ResumeLayout(performLayout: false);
					gform2_0.groupBox_1.PerformLayout();
					num = (int)((num2 * 803699503) ^ 0x5CF4AD92);
					continue;
				case 142u:
					gform2_0.button_0.TabIndex = 1;
					gform2_0.button_0.Text = "Advanced";
					gform2_0.button_0.UseVisualStyleBackColor = true;
					num = (int)(num2 * 599319832) ^ -818623083;
					continue;
				case 141u:
					gform2_0.groupBox_3.Controls.Add(gform2_0.checkBox_4);
					num = (int)(num2 * 247168585) ^ -1460118827;
					continue;
				case 140u:
					gform2_0.label_1.TabIndex = 3;
					num = ((int)num2 * -127562948) ^ -1696392535;
					continue;
				case 139u:
					gform2_0.label_0.Size = new Size(86, 13);
					num = (int)((num2 * 44475132) ^ 0x413071D8);
					continue;
				case 138u:
					gform2_0.groupBox_3.Size = new Size(180, 48);
					num = (int)((num2 * 923602142) ^ 0x1125F99D);
					continue;
				case 137u:
					gform2_0.label_2.AutoSize = true;
					num = (int)(num2 * 1055347567) ^ -667938492;
					continue;
				case 136u:
					gform2_0.button_3.Click += gform2_0.method_8;
					gform2_0.groupBox_5.Controls.Add(gform2_0.button_4);
					num = (int)(num2 * 1101356652) ^ -1061207841;
					continue;
				case 135u:
					gform2_0.checkBox_3.AutoSize = true;
					num = ((int)num2 * -656757500) ^ 0x701E449A;
					continue;
				case 134u:
					gform2_0.checkBox_1.Name = "closeOnInjectCheckBox";
					gform2_0.checkBox_1.Size = new Size(102, 17);
					num = (int)(num2 * 1991297696) ^ -151477556;
					continue;
				case 133u:
					gform2_0.checkBox_1.Text = "Close on inject";
					gform2_0.checkBox_1.UseVisualStyleBackColor = true;
					num = (int)((num2 * 114144290) ^ 0x16D65E45);
					continue;
				case 132u:
					gform2_0.checkBox_1 = new CheckBox();
					num = (int)(num2 * 1853696398) ^ -210739268;
					continue;
				case 131u:
					gform2_0.checkBox_0.Location = new Point(9, 67);
					gform2_0.checkBox_0.Name = "stealthInjectCheckBox";
					gform2_0.checkBox_0.Size = new Size(93, 17);
					gform2_0.checkBox_0.TabIndex = 2;
					num = (int)(num2 * 1098242939) ^ -73656747;
					continue;
				case 130u:
					gform2_0.button_5.Size = new Size(162, 23);
					num = ((int)num2 * -2137561089) ^ -1402084636;
					continue;
				case 129u:
					gform2_0.panel_1.Click += gform2_0.method_14;
					num = (int)(num2 * 424977412) ^ -783288835;
					continue;
				case 128u:
					gform2_0.checkBox_2.CheckedChanged += gform2_0.method_2;
					num = ((int)num2 * -915766768) ^ -1593498246;
					continue;
				case 127u:
					gform2_0.checkBox_1.TabIndex = 1;
					num = (int)((num2 * 1414232083) ^ 0x6BA34E6B);
					continue;
				case 126u:
					gform2_0.button_3 = new Button();
					num = ((int)num2 * -1889820343) ^ -891581904;
					continue;
				case 125u:
					gform2_0.button_6 = new Button();
					gform2_0.colorDialog_0 = new ColorDialog();
					num = ((int)num2 * -1744745214) ^ 0x4E0820CA;
					continue;
				case 124u:
					gform2_0.comboBox_1.Size = new Size(162, 21);
					num = ((int)num2 * -1108374785) ^ 0x6584D4F7;
					continue;
				case 123u:
					gform2_0.button_3.Text = "OK";
					num = ((int)num2 * -1435986023) ^ 0x380CC975;
					continue;
				case 122u:
					gform2_0.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
					gform2_0.comboBox_0.FormattingEnabled = true;
					gform2_0.comboBox_0.Items.AddRange(new object[5]
					{
						"Standard Injection",
						"Thread Hijacking",
						"LdrLoadDll Stub",
						"LdrpLoadDll Stub",
						"Manual Map"
					});
					num = (int)((num2 * 1971766879) ^ 0x75DE5166);
					continue;
				case 121u:
					gform2_0.groupBox_4.PerformLayout();
					gform2_0.groupBox_5.ResumeLayout(performLayout: false);
					num = (int)((num2 * 1426385494) ^ 0x45F7B14E);
					continue;
				case 120u:
					gform2_0.AutoScaleMode = AutoScaleMode.Dpi;
					num = (int)((num2 * 1517399758) ^ 0x6C0CF700);
					continue;
				case 119u:
					gform2_0.checkBox_2 = new CheckBox();
					gform2_0.groupBox_2 = new GroupBox();
					num = (int)((num2 * 764274511) ^ 0x510C3D12);
					continue;
				case 118u:
					gform2_0.groupBox_1.Controls.Add(gform2_0.numericUpDown_0);
					num = ((int)num2 * -1425068352) ^ -860432022;
					continue;
				case 117u:
					gform2_0.button_3.TabIndex = 7;
					num = ((int)num2 * -982113597) ^ 0x7B6FC7C0;
					continue;
				case 116u:
					gform2_0.label_4.AutoSize = true;
					gform2_0.label_4.Location = new Point(7, 25);
					num = (int)((num2 * 2138641410) ^ 0x19294D43);
					continue;
				case 115u:
					gform2_0.groupBox_5.Size = new Size(180, 95);
					num = (int)(num2 * 1881158135) ^ -2004896723;
					continue;
				case 114u:
					gform2_0.comboBox_0.Location = new Point(9, 21);
					gform2_0.comboBox_0.Name = "injectionMethodComboBox";
					gform2_0.comboBox_0.Size = new Size(162, 21);
					num = (int)(num2 * 1110422403) ^ -629204183;
					continue;
				case 113u:
					gform2_0.groupBox_1.Controls.Add(gform2_0.label_0);
					gform2_0.groupBox_1.Controls.Add(gform2_0.numericUpDown_1);
					gform2_0.groupBox_1.Controls.Add(gform2_0.label_1);
					num = ((int)num2 * -528281226) ^ -909765005;
					continue;
				case 112u:
					gform2_0.button_0.Size = new Size(162, 23);
					num = (int)((num2 * 1835374057) ^ 0x2D146DF5);
					continue;
				case 111u:
					gform2_0.checkBox_3.TabIndex = 1;
					gform2_0.checkBox_3.Text = "Hide Module";
					gform2_0.checkBox_3.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1893466107) ^ 0x2ADCD6AE;
					continue;
				case 110u:
					gform2_0.panel_2.Name = "textColorBox";
					num = (int)(num2 * 849263786) ^ -1948895361;
					continue;
				case 109u:
					gform2_0.groupBox_3.Location = new Point(12, 257);
					num = (int)((num2 * 1770984958) ^ 0x4428B9D8);
					continue;
				case 108u:
					gform2_0.groupBox_4.Controls.Add(gform2_0.label_3);
					num = (int)((num2 * 162111896) ^ 0x56F1B289);
					continue;
				case 107u:
					gform2_0.label_1.Text = "Inject delay:";
					num = ((int)num2 * -300611719) ^ -1512168135;
					continue;
				case 106u:
					gform2_0.groupBox_0.Size = new Size(180, 84);
					gform2_0.groupBox_0.TabIndex = 0;
					num = ((int)num2 * -84141935) ^ -587237939;
					continue;
				case 105u:
					gform2_0.groupBox_4.ResumeLayout(performLayout: false);
					num = ((int)num2 * -470560664) ^ -244736908;
					continue;
				case 104u:
					gform2_0.groupBox_0.TabStop = false;
					num = ((int)num2 * -300083950) ^ -1639726315;
					continue;
				case 103u:
					gform2_0.checkBox_3.Name = "hideModuleCheckBox";
					gform2_0.checkBox_3.Size = new Size(93, 17);
					num = ((int)num2 * -969119992) ^ 0x5EA16AFD;
					continue;
				case 102u:
					gform2_0.button_6.UseVisualStyleBackColor = true;
					gform2_0.button_6.Click += gform2_0.method_10;
					gform2_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = ((int)num2 * -1775427697) ^ 0x68A9D935;
					continue;
				case 101u:
					gform2_0.numericUpDown_0.TabIndex = 6;
					num = ((int)num2 * -1296678026) ^ -1083204196;
					continue;
				case 100u:
					gform2_0.button_2.Click += gform2_0.method_7;
					gform2_0.button_3.Location = new Point(273, 315);
					num = (int)((num2 * 441552836) ^ 0xF0FEFF8);
					continue;
				case 99u:
					gform2_0.groupBox_4.TabStop = false;
					num = (int)(num2 * 1953473678) ^ -1716190711;
					continue;
				case 98u:
					gform2_0.Controls.Add(gform2_0.groupBox_3);
					gform2_0.Controls.Add(gform2_0.groupBox_2);
					num = ((int)num2 * -1841680759) ^ 0x6574DA;
					continue;
				case 97u:
					gform2_0.panel_2.Click += gform2_0.method_13;
					num = ((int)num2 * -1953414657) ^ -89683309;
					continue;
				case 96u:
					gform2_0.comboBox_1.Location = new Point(9, 21);
					num = ((int)num2 * -481355542) ^ -1617966988;
					continue;
				case 95u:
					gform2_0.checkBox_0.AutoSize = true;
					num = (int)(num2 * 312810258) ^ -244152340;
					continue;
				case 94u:
					gform2_0.Controls.Add(gform2_0.groupBox_1);
					num = ((int)num2 * -385831777) ^ 0x42B032F1;
					continue;
				case 93u:
					gform2_0.groupBox_3.Name = "postInjectGroupBox";
					num = (int)((num2 * 1888025264) ^ 0x5C5E8A54);
					continue;
				case 92u:
					gform2_0.checkBox_0.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1605420969) ^ 0x5D80A815;
					continue;
				case 91u:
					gform2_0.label_4.Name = "textColorLabel";
					num = (int)(num2 * 60051400) ^ -1022146585;
					continue;
				case 90u:
					gform2_0.groupBox_2.Controls.Add(gform2_0.comboBox_1);
					num = ((int)num2 * -1189043289) ^ 0x100D4DAE;
					continue;
				case 89u:
					gform2_0.groupBox_5 = new GroupBox();
					gform2_0.button_4 = new Button();
					gform2_0.button_5 = new Button();
					num = ((int)num2 * -1771542883) ^ -1402056416;
					continue;
				case 88u:
					gform2_0.label_4 = new System.Windows.Forms.Label();
					num = ((int)num2 * -859800146) ^ -2009653411;
					continue;
				case 87u:
					gform2_0.panel_0.Name = "backgroundColor2Box";
					gform2_0.panel_0.Size = new Size(20, 20);
					gform2_0.panel_0.TabIndex = 4;
					gform2_0.panel_0.Click += gform2_0.method_15;
					num = (int)(num2 * 1488372860) ^ -1207072453;
					continue;
				case 86u:
					gform2_0.ClientSize = new Size(396, 347);
					num = ((int)num2 * -1525424288) ^ -174112198;
					continue;
				case 85u:
					gform2_0.numericUpDown_1.Location = new Point(98, 90);
					num = ((int)num2 * -1995935368) ^ 0x1C240136;
					continue;
				case 84u:
					gform2_0.button_6.TabIndex = 0;
					num = (int)((num2 * 667019363) ^ 0x1948B1BC);
					continue;
				case 83u:
					gform2_0.checkBox_1.Location = new Point(9, 44);
					num = (int)(num2 * 314508367) ^ -1520265514;
					continue;
				case 82u:
					gform2_0.button_5.TabIndex = 1;
					num = ((int)num2 * -959217249) ^ -63229709;
					continue;
				case 81u:
					gform2_0.label_0.TabIndex = 5;
					gform2_0.label_0.Text = "Delay between:";
					num = (int)(num2 * 100035645) ^ -576261038;
					continue;
				case 80u:
					gform2_0.label_4.TabIndex = 1;
					num = ((int)num2 * -57954872) ^ -2135226614;
					continue;
				case 79u:
					gform2_0.comboBox_0.TabIndex = 0;
					num = ((int)num2 * -425049992) ^ -1536749328;
					continue;
				case 78u:
					gform2_0.button_6.Text = "View Process Information";
					num = (int)(num2 * 83058863) ^ -1651661353;
					continue;
				case 77u:
					gform2_0.label_3.Location = new Point(7, 48);
					num = (int)(num2 * 651707463) ^ -1158182476;
					continue;
				case 76u:
					gform2_0.checkBox_2.Text = "Auto Inject";
					gform2_0.checkBox_2.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1492198581) ^ 0x2F92B1CB;
					continue;
				case 75u:
					gform2_0.button_3.UseVisualStyleBackColor = true;
					num = (int)(num2 * 717293402) ^ -1623797971;
					continue;
				case 74u:
					gform2_0.label_4.Text = "Text Color:";
					gform2_0.panel_2.BorderStyle = BorderStyle.FixedSingle;
					num = (int)(num2 * 1508877135) ^ -232209066;
					continue;
				case 73u:
					gform2_0.label_2.Text = "Background Color #2:";
					gform2_0.panel_0.BorderStyle = BorderStyle.FixedSingle;
					num = (int)(num2 * 1646328371) ^ -130906542;
					continue;
				case 72u:
					gform2_0.groupBox_3.SuspendLayout();
					num = ((int)num2 * -1082079) ^ 0x3AB6AB34;
					continue;
				case 71u:
					gform2_0.groupBox_0.Text = "Injection Method:";
					num = (int)(num2 * 1258531918) ^ -1146556521;
					continue;
				case 70u:
					gform2_0.Controls.Add(gform2_0.button_2);
					num = ((int)num2 * -1513215670) ^ 0x167BDFBF;
					continue;
				case 69u:
					gform2_0.SuspendLayout();
					gform2_0.groupBox_0.Controls.Add(gform2_0.button_0);
					gform2_0.groupBox_0.Controls.Add(gform2_0.comboBox_0);
					gform2_0.groupBox_0.Location = new Point(12, 12);
					gform2_0.groupBox_0.Name = "injectionMethodGroupBox";
					num = ((int)num2 * -2021217969) ^ 0x3F8C3518;
					continue;
				case 68u:
					gform2_0.checkBox_3.Location = new Point(83, 21);
					num = ((int)num2 * -38643171) ^ 0xC67D88E;
					continue;
				case 67u:
					gform2_0.panel_2.TabIndex = 0;
					num = ((int)num2 * -614556199) ^ 0x223F40B2;
					continue;
				case 66u:
					gform2_0.numericUpDown_1.TabIndex = 4;
					gform2_0.label_1.AutoSize = true;
					gform2_0.label_1.Location = new Point(6, 92);
					gform2_0.label_1.Name = "injectDelayLabel";
					gform2_0.label_1.Size = new Size(68, 13);
					num = (int)((num2 * 844572949) ^ 0x63EC8B47);
					continue;
				case 65u:
					gform2_0.groupBox_5.Controls.Add(gform2_0.button_6);
					gform2_0.groupBox_5.Location = new Point(203, 210);
					num = ((int)num2 * -880268576) ^ -1692775314;
					continue;
				case 64u:
					gform2_0.groupBox_1.Size = new Size(180, 149);
					gform2_0.groupBox_1.TabIndex = 1;
					gform2_0.groupBox_1.TabStop = false;
					num = ((int)num2 * -133084430) ^ -1996238017;
					continue;
				case 63u:
					gform2_0.panel_2 = new Panel();
					num = ((int)num2 * -1208662241) ^ 0x5145ECB5;
					continue;
				case 62u:
					gform2_0.checkBox_2.AutoSize = true;
					gform2_0.checkBox_2.Location = new Point(9, 21);
					num = ((int)num2 * -1953982742) ^ -1787356595;
					continue;
				case 61u:
					gform2_0.numericUpDown_0.Increment = new decimal(new int[4] { 100, 0, 0, 0 });
					num = ((int)num2 * -216663688) ^ -42023610;
					continue;
				case 60u:
					gform2_0.groupBox_4.SuspendLayout();
					num = ((int)num2 * -732654394) ^ -1442463994;
					continue;
				case 59u:
					gform2_0.groupBox_0 = new GroupBox();
					num = ((int)num2 * -858001066) ^ 0x6641E9B3;
					continue;
				case 58u:
					gform2_0.button_0 = new Button();
					num = ((int)num2 * -635074520) ^ 0x1CD1180C;
					continue;
				case 57u:
					gform2_0.groupBox_1.Text = "Injection Options:";
					num = (int)(num2 * 1705913247) ^ -1066752638;
					continue;
				case 56u:
					gform2_0.panel_2.Cursor = Cursors.Hand;
					num = ((int)num2 * -1410646213) ^ 0x543004F3;
					continue;
				case 55u:
					gform2_0.label_3.Name = "backgroundColor1Label";
					gform2_0.label_3.Size = new Size(120, 13);
					gform2_0.label_3.TabIndex = 2;
					num = ((int)num2 * -686526002) ^ -485679540;
					continue;
				case 54u:
					gform2_0.panel_1.Location = new Point(152, 44);
					gform2_0.panel_1.Name = "backgroundColor1Box";
					num = (int)((num2 * 2141057814) ^ 0x37C7C311);
					continue;
				case 53u:
					gform2_0.numericUpDown_0.Size = new Size(73, 22);
					num = ((int)num2 * -1627378003) ^ -556650304;
					continue;
				case 52u:
					gform2_0.groupBox_5.Text = "Tools:";
					gform2_0.button_4.Location = new Point(9, 65);
					gform2_0.button_4.Name = "startInSecureModeButton";
					gform2_0.button_4.Size = new Size(162, 23);
					gform2_0.button_4.TabIndex = 2;
					num = ((int)num2 * -543077981) ^ 0x7F2FC780;
					continue;
				case 51u:
					gform2_0.Controls.Add(gform2_0.groupBox_5);
					gform2_0.Controls.Add(gform2_0.button_3);
					num = ((int)num2 * -1736658880) ^ 0x7AF0A583;
					continue;
				case 50u:
					gform2_0.label_3.AutoSize = true;
					num = (int)(num2 * 1776307351) ^ -651388740;
					continue;
				case 49u:
					gform2_0.label_2.Location = new Point(7, 71);
					gform2_0.label_2.Name = "backgroundColor2Label";
					gform2_0.label_2.Size = new Size(120, 13);
					num = ((int)num2 * -1379487104) ^ 0x4C64C91A;
					continue;
				case 48u:
					gform2_0.groupBox_5.TabIndex = 8;
					gform2_0.groupBox_5.TabStop = false;
					num = (int)((num2 * 1552973733) ^ 0x4D3761A2);
					continue;
				case 47u:
					gform2_0.groupBox_2.Location = new Point(203, 12);
					gform2_0.groupBox_2.Name = "scrambleGroupBox";
					gform2_0.groupBox_2.Size = new Size(180, 84);
					gform2_0.groupBox_2.TabIndex = 2;
					gform2_0.groupBox_2.TabStop = false;
					gform2_0.groupBox_2.Text = "Scrambling Options:";
					num = ((int)num2 * -1738138535) ^ -763755152;
					continue;
				case 45u:
					gform2_0.button_1.Location = new Point(9, 48);
					gform2_0.button_1.Name = "advancedScramblingOptions";
					num = (int)((num2 * 1300305928) ^ 0x39A2A41F);
					continue;
				case 44u:
					gform2_0.button_1.Text = "Advanced";
					num = (int)((num2 * 104117610) ^ 0x4E2C57DB);
					continue;
				case 43u:
					gform2_0.comboBox_0 = new ComboBox();
					num = ((int)num2 * -2054983239) ^ 0x6FAE3ECC;
					continue;
				case 42u:
					gform2_0.comboBox_1.Name = "scramblePresetCheckBox";
					num = (int)((num2 * 878068039) ^ 0x3B0E7B7);
					continue;
				case 41u:
					gform2_0.groupBox_2.SuspendLayout();
					num = (int)((num2 * 946625981) ^ 0x3A49E1A6);
					continue;
				case 40u:
					gform2_0.button_2.Text = "Reset";
					num = ((int)num2 * -2063498107) ^ -425840925;
					continue;
				case 39u:
					gform2_0.label_0.Location = new Point(6, 117);
					num = (int)((num2 * 41396785) ^ 0x3698B59B);
					continue;
				case 38u:
					gform2_0.label_4.Size = new Size(61, 13);
					num = (int)((num2 * 565883422) ^ 0x19FA530E);
					continue;
				case 37u:
					((ISupportInitialize)gform2_0.numericUpDown_0).EndInit();
					((ISupportInitialize)gform2_0.numericUpDown_1).EndInit();
					gform2_0.groupBox_2.ResumeLayout(performLayout: false);
					gform2_0.groupBox_3.ResumeLayout(performLayout: false);
					num = ((int)num2 * -1597863313) ^ -1000097276;
					continue;
				case 36u:
					gform2_0.button_2.TabIndex = 5;
					num = (int)((num2 * 692903669) ^ 0x3172A2FF);
					continue;
				case 35u:
					gform2_0.groupBox_4.Text = "Theme Options:";
					num = (int)((num2 * 765100405) ^ 0xF905A1B);
					continue;
				case 34u:
					gform2_0.panel_1 = new Panel();
					gform2_0.label_3 = new System.Windows.Forms.Label();
					num = (int)((num2 * 2045708045) ^ 0x71F885E7);
					continue;
				case 33u:
					gform2_0.label_2 = new System.Windows.Forms.Label();
					gform2_0.panel_0 = new Panel();
					num = ((int)num2 * -935719697) ^ -677260451;
					continue;
				case 32u:
					gform2_0.button_5.Name = "scrambleDLLButton";
					num = (int)(num2 * 1833616186) ^ -1346424999;
					continue;
				case 31u:
					gform2_0.button_6.Location = new Point(9, 17);
					num = (int)((num2 * 290824226) ^ 0x1AB4A874);
					continue;
				case 30u:
					gform2_0.button_2.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1415193449) ^ -837768528;
					continue;
				case 29u:
					gform2_0.comboBox_1.SelectedIndexChanged += gform2_0.method_6;
					gform2_0.groupBox_3.Controls.Add(gform2_0.checkBox_3);
					num = (int)((num2 * 60884723) ^ 0xD301FFC);
					continue;
				case 28u:
					gform2_0.button_2.Location = new Point(12, 315);
					num = (int)((num2 * 1606827284) ^ 0x2B9D3773);
					continue;
				case 27u:
					gform2_0.groupBox_3.TabIndex = 3;
					num = ((int)num2 * -978088827) ^ -355103241;
					continue;
				case 26u:
					gform2_0.numericUpDown_0 = new NumericUpDown();
					num = (int)(num2 * 772235592) ^ -1068228246;
					continue;
				case 25u:
					gform2_0.groupBox_4.Size = new Size(181, 102);
					num = ((int)num2 * -144019996) ^ 0x2522A86C;
					continue;
				case 24u:
					gform2_0.groupBox_0.SuspendLayout();
					gform2_0.groupBox_1.SuspendLayout();
					num = (int)((num2 * 638804735) ^ 0x43D67D89);
					continue;
				case 23u:
					gform2_0.Controls.Add(gform2_0.groupBox_0);
					gform2_0.Font = new Font("Segoe UI", 8.25f);
					gform2_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
					num = ((int)num2 * -2012857834) ^ -93567473;
					continue;
				case 22u:
					gform2_0.label_3.Text = "Background Color #1:";
					num = ((int)num2 * -1675504492) ^ -929453098;
					continue;
				case 21u:
					gform2_0.numericUpDown_0.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
					gform2_0.numericUpDown_0.Name = "delayBetweenNumericUpDown";
					num = (int)((num2 * 32595147) ^ 0x6FBBD187);
					continue;
				case 20u:
					gform2_0.button_1.TabIndex = 3;
					num = ((int)num2 * -991577024) ^ 0x30B0091E;
					continue;
				case 19u:
					gform2_0.groupBox_1.Controls.Add(gform2_0.checkBox_0);
					gform2_0.groupBox_1.Controls.Add(gform2_0.checkBox_1);
					gform2_0.groupBox_1.Controls.Add(gform2_0.checkBox_2);
					num = (int)((num2 * 1431455018) ^ 0x712B49B1);
					continue;
				case 18u:
					gform2_0.checkBox_2.Size = new Size(82, 17);
					num = ((int)num2 * -1672037320) ^ -1328730899;
					continue;
				case 17u:
					((ISupportInitialize)gform2_0.numericUpDown_0).BeginInit();
					num = (int)((num2 * 205811180) ^ 0x633C0CE3);
					continue;
				case 16u:
					gform2_0.button_0.Click += gform2_0.method_4;
					num = ((int)num2 * -296051188) ^ -694000671;
					continue;
				case 15u:
					gform2_0.groupBox_3.PerformLayout();
					num = (int)((num2 * 1004176377) ^ 0x741F2339);
					continue;
				case 14u:
					gform2_0.groupBox_4.Controls.Add(gform2_0.label_4);
					num = (int)(num2 * 1214085597) ^ -585298907;
					continue;
				case 13u:
					((ISupportInitialize)gform2_0.numericUpDown_1).BeginInit();
					num = ((int)num2 * -1703498273) ^ 0x63B1E65F;
					continue;
				case 12u:
					gform2_0.numericUpDown_1 = new NumericUpDown();
					gform2_0.label_1 = new System.Windows.Forms.Label();
					gform2_0.checkBox_0 = new CheckBox();
					num = ((int)num2 * -1579160828) ^ 0x19E91DEB;
					continue;
				case 11u:
					gform2_0.button_5.Click += gform2_0.method_11;
					num = (int)((num2 * 1028526430) ^ 0x785708BD);
					continue;
				case 9u:
					gform2_0.label_0.AutoSize = true;
					num = (int)((num2 * 1425742731) ^ 0x418219CD);
					continue;
				case 8u:
					gform2_0.checkBox_3 = new CheckBox();
					gform2_0.checkBox_4 = new CheckBox();
					gform2_0.groupBox_4 = new GroupBox();
					num = (int)((num2 * 1797852206) ^ 0x861229C);
					continue;
				case 7u:
					gform2_0.panel_1.TabIndex = 3;
					num = ((int)num2 * -249761401) ^ -1650872974;
					continue;
				case 6u:
					gform2_0.numericUpDown_1.Size = new Size(73, 22);
					num = (int)(num2 * 333357971) ^ -1989230013;
					continue;
				case 5u:
					gform2_0.numericUpDown_1.Increment = new decimal(new int[4] { 100, 0, 0, 0 });
					num = ((int)num2 * -2113593143) ^ 0x4467412;
					continue;
				case 4u:
					gform2_0.panel_0.Cursor = Cursors.Hand;
					num = (int)(num2 * 130142555) ^ -1335865918;
					continue;
				case 3u:
					gform2_0.button_3.Name = "okButton";
					num = ((int)num2 * -422395361) ^ 0x17847060;
					continue;
				case 2u:
					gform2_0.groupBox_2.Controls.Add(gform2_0.button_1);
					num = (int)(num2 * 1200106085) ^ -1952566121;
					continue;
				case 1u:
					gform2_0.checkBox_2.Name = "autoInjectCheckBox";
					num = (int)(num2 * 596162948) ^ -1276677487;
					continue;
				case 0u:
					gform2_0.panel_1.BorderStyle = BorderStyle.FixedSingle;
					gform2_0.panel_1.Cursor = Cursors.Hand;
					num = ((int)num2 * -939287170) ^ -684707784;
					continue;
				case 10u:
					break;
				default:
					gform2_0.ResumeLayout(performLayout: false);
					return;
				}
				break;
			}
		}
	}

	internal static bool smethod_295(int int_0, ushort ushort_0, int int_1, int int_2)
	{
		if (GetProcAddress(GetModuleHandle("ntdll.dll"), "RtlGetVersion") != IntPtr.Zero)
		{
			goto IL_011c;
		}
		goto IL_02f7;
		IL_011c:
		int num = 1584740921;
		goto IL_027c;
		IL_027c:
		Class124.Struct38 struct38_ = default(Class124.Struct38);
		Class124.Struct38 struct38_2 = default(Class124.Struct38);
		Class124.Struct38 @struct = default(Class124.Struct38);
		ulong ulong_ = default(ulong);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x6047B3AD)) % 26)
			{
			case 25u:
				break;
			case 24u:
				num = ((struct38_.int_1 > int_1) ? (-834489083) : (-1423346720)) ^ ((int)num2 * -1727269489);
				continue;
			case 23u:
				struct38_2.int_1 = int_1;
				num = ((int)num2 * -1418537763) ^ 0x6240583A;
				continue;
			case 22u:
				struct38_2 = @struct;
				num = ((int)num2 * -958104869) ^ -2031607089;
				continue;
			case 21u:
				struct38_2.int_3 = int_2;
				num = (int)(num2 * 1595617324) ^ -478282882;
				continue;
			case 20u:
				@struct = new Class124.Struct38
				{
					int_0 = typeof(Class124.Struct38).smethod_7()
				};
				num = ((int)num2 * -1851377860) ^ 0x27533A49;
				continue;
			case 18u:
				struct38_2.ushort_0 = ushort_0;
				num = (int)((num2 * 692479553) ^ 0xE6EDAE0);
				continue;
			case 17u:
				goto end_IL_027c;
			case 16u:
				struct38_ = @struct;
				num = ((RtlGetVersion(ref struct38_) != 0) ? (-984489119) : (-1988292229)) ^ (int)(num2 * 1207908146);
				continue;
			case 14u:
				struct38_2.int_2 = int_0;
				num = ((int)num2 * -1614048655) ^ 0x68F4B389;
				continue;
			case 13u:
				goto IL_0171;
			case 10u:
				num = ((struct38_.int_3 > int_2) ? (-631404816) : (-1351097330)) ^ ((int)num2 * -1410281571);
				continue;
			case 8u:
				ulong_ = VerSetConditionMask(VerSetConditionMask(VerSetConditionMask(0uL, 2u, 3), 1u, 3), 32u, 3);
				num = (int)(num2 * 1166176452) ^ -413852372;
				continue;
			case 7u:
				goto IL_01f7;
			case 4u:
				goto IL_0219;
			case 3u:
				num = ((int_2 != -1) ? 1147933632 : 619897540) ^ ((int)num2 * -697459862);
				continue;
			case 1u:
				goto IL_025c;
			case 6u:
				goto IL_02f7;
			case 0u:
				return true;
			case 2u:
				return false;
			default:
				return VerifyVersionInfo(ref struct38_2, 35u, ulong_);
			case 9u:
				return false;
			case 11u:
				return false;
			case 12u:
				return true;
			case 15u:
				return true;
			case 19u:
				return struct38_.ushort_0 >= ushort_0;
			}
			num = ((struct38_.int_2 > int_0) ? 391818675 : 403618096);
			continue;
			IL_025c:
			num = ((struct38_.int_2 < int_0) ? 1297410717 : 226007735);
			continue;
			IL_01f7:
			num = ((struct38_.int_3 >= int_2) ? 108067654 : 1630356440);
			continue;
			IL_0171:
			num = ((struct38_.int_1 < int_1) ? 1624885040 : 151568648);
			continue;
			IL_0219:
			num = ((int_2 != -1) ? 1847967105 : 108067654);
			continue;
			end_IL_027c:
			break;
		}
		goto IL_011c;
		IL_02f7:
		@struct = new Class124.Struct38
		{
			int_0 = typeof(Class124.Struct38).smethod_7()
		};
		num = 153685219;
		goto IL_027c;
	}

	internal static void SetModulePath(MainForm.ModuleRow class21_0, string string_0)
	{
		class21_0.Entry.Path = string_0;
	}

	internal static void smethod_297(Class53 class53_0)
	{
		if (!class53_0.method_0())
		{
			while (true)
			{
				int num = 1767148883;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x21D62CEC)) % 4)
					{
					case 3u:
						num = (Class49.bool_0 ? 398489940 : 67701927) ^ ((int)num2 * -1131913682);
						continue;
					case 0u:
						break;
					case 1u:
						throw new InvalidOperationException("This instruction is only available in x64 mode.");
					default:
						goto end_IL_0051;
					}
					break;
				}
				continue;
				end_IL_0051:
				break;
			}
		}
		smethod_31(class53_0, Enum7.const_423);
	}

	internal static void smethod_298(Class53 class53_0, Class57 class57_0)
	{
		smethod_352(class57_0, Enum7.const_463, class53_0);
	}

	internal static void smethod_299(string string_0, Class154 class154_0)
	{
		FileStream fileStream = File.OpenWrite(string_0);
		try
		{
			fileStream.SetLength(0L);
			smethod_315(fileStream, class154_0);
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					IL_0054:
					int num = -1819976338;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -1676823146)) % 3)
						{
						case 1u:
							goto IL_0024;
						default:
							goto end_IL_0037;
						case 0u:
							break;
						case 2u:
							goto end_IL_0037;
						}
						goto IL_0054;
						IL_0024:
						((IDisposable)fileStream).Dispose();
						num = (int)((num2 * 1955297604) ^ 0x42B2FA9D);
						continue;
						end_IL_0037:
						break;
					}
					break;
				}
			}
		}
	}

	internal static bool smethod_300(Class75 class75_0)
	{
		IntPtr intPtr = OpenThread(Class124.Enum31.flag_1, bool_0: false, class75_0.method_0());
		if (intPtr == IntPtr.Zero)
		{
			goto IL_001b;
		}
		goto IL_005b;
		IL_001b:
		int num = 1568985078;
		goto IL_0036;
		IL_0036:
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xEAF4109)) % 5)
			{
			case 4u:
				break;
			case 1u:
				CloseHandle(intPtr);
				num = ((int)num2 * -1178281959) ^ -802970622;
				continue;
			case 2u:
				goto IL_005b;
			default:
				return num3 != -1;
			case 3u:
				return false;
			}
			break;
		}
		goto IL_001b;
		IL_005b:
		num3 = SuspendThread(intPtr);
		num = 1674778241;
		goto IL_0036;
	}

	internal static Class57 smethod_301(UIntPtr uintptr_0)
	{
		return new Class57((IntPtr)(long)(ulong)uintptr_0, bool_0: true);
	}

	internal static bool HasProcessExited(GClass2 gclass2_0)
	{
		if (gclass2_0.bool_4)
		{
			goto IL_00a0;
		}
		goto IL_0105;
		IL_00a0:
		int num = -1463933434;
		goto IL_00bc;
		IL_00bc:
		IntPtr intPtr = default(IntPtr);
		uint uint_ = default(uint);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2042076637)) % 10)
			{
			case 8u:
				break;
			case 7u:
				num = ((!gclass2_0.bool_3) ? (-1209576991) : (-731424082)) ^ (int)(num2 * 1686629331);
				continue;
			case 3u:
				GetExitCodeProcess(intPtr, out uint_);
				num = -1866404106;
				continue;
			case 2u:
				goto end_IL_00bc;
			case 1u:
				smethod_27(gclass2_0, intPtr);
				num = (int)((num2 * 1409327358) ^ 0x6A306AED);
				continue;
			case 6u:
				goto IL_0105;
			default:
			{
				uint num3 = WaitForSingleObject(intPtr, 0u);
				smethod_27(gclass2_0, intPtr);
				return num3 != 258;
			}
			case 4u:
				return uint_ != 259;
			case 5u:
				return true;
			case 9u:
				return true;
			}
			intPtr = smethod_250(gclass2_0, Class127.bool_1 ? Class124.Enum32.flag_10 : Class124.Enum32.flag_9, bool_0: false, gclass2_0.method_0());
			num = ((!(intPtr == IntPtr.Zero)) ? (-1399956404) : (-1042910522));
			continue;
			end_IL_00bc:
			break;
		}
		goto IL_00a0;
		IL_0105:
		intPtr = smethod_250(gclass2_0, Class124.Enum32.flag_11, bool_0: false, gclass2_0.method_0());
		num = ((intPtr == IntPtr.Zero) ? (-862091211) : (-427289265));
		goto IL_00bc;
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ChangeWindowMessageFilterEx(IntPtr intptr_0, uint uint_0, Class10.Enum1 enum1_0, ref Class10.Struct6 struct6_0);

	internal static Class141 smethod_303(Class154 class154_0, Class5 class5_0)
	{
		Class157 @class = class154_0.method_6().method_3().imethod_49()[3];
		if (@class.method_0() != 0)
		{
			long num3 = default(long);
			while (true)
			{
				int num = -467057641;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -152289335)) % 11)
					{
					case 10u:
						num = (class5_0.imethod_0(num3) ? 124199343 : 1491147542) ^ ((int)num2 * -1373069411);
						continue;
					case 9u:
						num = ((num3 == -1L) ? (-1236182841) : (-268214864)) ^ ((int)num2 * -1771252321);
						continue;
					case 6u:
						smethod_157(class5_0, num3);
						num = -126246791;
						continue;
					case 4u:
						num3 = smethod_135(class154_0, @class.method_0());
						num = -570129132;
						continue;
					case 3u:
						break;
					case 1u:
						num = ((@class.method_2() == 0) ? (-1003845395) : (-344224114)) ^ ((int)num2 * -638297019);
						continue;
					case 2u:
						goto end_IL_00f0;
					case 0u:
						return null;
					case 5u:
						return null;
					default:
						return new Class141(class5_0, @class);
					case 8u:
						goto end_IL_012e;
					}
					num = ((!class5_0.imethod_0(num3 + @class.method_2())) ? (-61759745) : (-1563533534));
					continue;
					end_IL_00f0:
					break;
				}
				continue;
				end_IL_012e:
				break;
			}
		}
		return null;
	}

	internal static void smethod_304(GClass4 gclass4_0, GClass5 gclass5_0)
	{
		Class157 @class = gclass4_0.class154_0.method_6().method_3().imethod_49()[5];
		long num3 = default(long);
		while (true)
		{
			int num = -152657987;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -899836390)) % 8)
				{
				case 7u:
					num3 = smethod_135(gclass4_0.class154_0, @class.method_0());
					num = ((num3 != -1L) ? (-906701358) : (-2103103676)) ^ (int)(num2 * 414575614);
					continue;
				case 6u:
					num = ((gclass5_0.method_6() >= @class.method_2()) ? (-1344455681) : (-1572494749));
					continue;
				case 2u:
					num = ((gclass5_0.method_2() < @class.method_2()) ? (-773437646) : (-101927620));
					continue;
				case 0u:
					gclass5_0.method_3(@class.method_2());
					num = ((int)num2 * -1737160970) ^ -1656399540;
					continue;
				case 3u:
					break;
				case 1u:
					return;
				case 4u:
					return;
				default:
				{
					Stream stream = smethod_264(gclass4_0.class154_0, num3, (int)@class.method_2());
					byte[] buffer;
					try
					{
						BinaryReader binaryReader = new BinaryReader(stream);
						try
						{
							buffer = binaryReader.ReadBytes((int)@class.method_2());
						}
						finally
						{
							if (binaryReader != null)
							{
								while (true)
								{
									IL_0167:
									int num4 = -395880518;
									while (true)
									{
										switch ((num2 = (uint)(num4 ^ -899836390)) % 3)
										{
										case 1u:
											goto IL_0134;
										default:
											goto end_IL_0149;
										case 0u:
											break;
										case 2u:
											goto end_IL_0149;
										}
										goto IL_0167;
										IL_0134:
										((IDisposable)binaryReader).Dispose();
										num4 = (int)(num2 * 8803862) ^ -1497674065;
										continue;
										end_IL_0149:
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
								IL_01a6:
								int num5 = -83504449;
								while (true)
								{
									switch ((num2 = (uint)(num5 ^ -899836390)) % 3)
									{
									case 1u:
										goto IL_0174;
									default:
										goto end_IL_0188;
									case 0u:
										break;
									case 2u:
										goto end_IL_0188;
									}
									goto IL_01a6;
									IL_0174:
									((IDisposable)stream).Dispose();
									num5 = (int)((num2 * 1188710185) ^ 0x50009237);
									continue;
									end_IL_0188:
									break;
								}
								break;
							}
						}
					}
					smethod_437(gclass4_0, num3, @class.method_2());
					while (true)
					{
						int num6 = -861841388;
						while (true)
						{
							switch ((num2 = (uint)(num6 ^ -899836390)) % 5)
							{
							case 3u:
								gclass4_0.class154_0.method_28().Position = gclass5_0.method_8();
								num6 = (int)((num2 * 1693851815) ^ 0x14A5EE35);
								continue;
							case 2u:
								@class.method_1(gclass5_0.method_4());
								num6 = ((int)num2 * -861353426) ^ 0x28DB0D24;
								continue;
							case 1u:
								gclass4_0.binaryWriter_0.Write(buffer);
								num6 = (int)(num2 * 1831048437) ^ -1144824703;
								continue;
							default:
								return;
							case 0u:
								break;
							case 4u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	internal static bool smethod_305(Class179.Class184 class184_0, Class179.Class181 class181_0)
	{
		int num3 = default(int);
		int int_2 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int int_ = class184_0.int_2;
			while (true)
			{
				int num = -205037803;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1464743051)) % 49)
					{
					case 48u:
						class184_0.int_8 = 0;
						class184_0.int_2 = 3;
						num = ((int)num2 * -1531072887) ^ -1463986808;
						continue;
					case 47u:
						num = (int)((num2 * 1370971646) ^ 0x2D5FB54B);
						continue;
					case 46u:
						class184_0.int_7 = num3 - 16;
						class184_0.int_2 = 5;
						num = -802068148;
						continue;
					case 45u:
						class184_0.int_2 = 4;
						num = ((int)num2 * -1606276774) ^ -825198848;
						continue;
					case 44u:
						class184_0.class183_0 = new Class179.Class183(class184_0.byte_0);
						class184_0.byte_0 = null;
						num = ((int)num2 * -659417241) ^ -1699470478;
						continue;
					case 43u:
						class184_0.int_8++;
						num = ((int)num2 * -28701636) ^ -1560173628;
						continue;
					case 41u:
						smethod_396(class181_0, 3);
						num = -753151462;
						continue;
					case 40u:
						break;
					case 39u:
						smethod_396(class181_0, int_2);
						num = -1666420432;
						continue;
					case 38u:
						goto IL_010f;
					case 37u:
						class184_0.byte_0[Class179.Class184.int_9[class184_0.int_8]] = (byte)num4;
						num = (int)((num2 * 1248976421) ^ 0x1D1ECE63);
						continue;
					case 35u:
						class184_0.byte_1 = new byte[class184_0.int_6];
						num = (int)((num2 * 501187212) ^ 0x6266AEA2);
						continue;
					case 34u:
						goto IL_01ac;
					case 33u:
						goto IL_01d6;
					case 32u:
						class184_0.int_3 += 257;
						smethod_396(class181_0, 5);
						class184_0.int_2 = 1;
						num = -567893540;
						continue;
					case 31u:
						class184_0.int_5 += 4;
						num = -36548358;
						continue;
					case 30u:
						goto IL_023c;
					case 28u:
						class184_0.int_8 = 0;
						num = (int)((num2 * 50099360) ^ 0x350CB99C);
						continue;
					case 27u:
						goto IL_0277;
					case 26u:
						smethod_396(class181_0, 5);
						class184_0.int_6 = class184_0.int_3 + class184_0.int_4;
						num = (int)((num2 * 1616270737) ^ 0x20CFF787);
						continue;
					case 25u:
						num5 = smethod_60(class181_0, int_2);
						num = ((int)num2 * -884389621) ^ -2041200537;
						continue;
					case 24u:
						class184_0.byte_2 = 0;
						num = (int)(num2 * 1105868822) ^ -1519478838;
						continue;
					case 23u:
						num = ((class184_0.int_4 >= 0) ? 270235194 : 478520174) ^ ((int)num2 * -1444950561);
						continue;
					case 21u:
						switch (int_)
						{
						case 0:
							break;
						case 3:
							goto IL_01ac;
						case 4:
							goto IL_0277;
						default:
							goto IL_0355;
						case 1:
							goto IL_0368;
						case 2:
							goto IL_037f;
						case 5:
							goto IL_03b1;
						}
						break;
					case 19u:
						goto IL_0368;
					case 12u:
						goto IL_037f;
					case 10u:
						goto IL_03b1;
					case 20u:
						num = (int)(num2 * 928060664) ^ -2010697741;
						continue;
					case 17u:
						num = ((num5 < 0) ? 459182128 : 285255978) ^ (int)(num2 * 349434518);
						continue;
					case 16u:
						goto IL_0404;
					case 15u:
						class184_0.byte_1[class184_0.int_8++] = class184_0.byte_2;
						num = -1084085445;
						continue;
					case 13u:
						num5 += Class179.Class184.int_0[class184_0.int_7];
						num = ((int)num2 * -1733238663) ^ 0x54D14920;
						continue;
					case 8u:
						class184_0.int_2 = 4;
						num = -1848980503;
						continue;
					case 6u:
						num = ((num3 < 0) ? 658194272 : 283353340) ^ (int)(num2 * 448235678);
						continue;
					case 5u:
						class184_0.int_2 = 2;
						num = (int)((num2 * 518695990) ^ 0x3C2B406C);
						continue;
					case 4u:
						num = ((class184_0.int_8 == class184_0.int_6) ? 1186420544 : 1116382683) ^ ((int)num2 * -1442392868);
						continue;
					case 3u:
						smethod_396(class181_0, 4);
						class184_0.byte_0 = new byte[19];
						num = ((int)num2 * -1047420500) ^ 0x163CF0E1;
						continue;
					case 2u:
						class184_0.int_4++;
						num = -1120050513;
						continue;
					case 14u:
						goto end_IL_052d;
					default:
						goto end_IL_0604;
					case 0u:
						return true;
					case 1u:
						return false;
					case 7u:
						return false;
					case 9u:
						return false;
					case 18u:
						return false;
					case 22u:
						return false;
					case 36u:
						return true;
					case 42u:
						{
							return false;
						}
						IL_03b1:
						int_2 = Class179.Class184.int_1[class184_0.int_7];
						num = -1281597031;
						continue;
						IL_0368:
						class184_0.int_4 = smethod_60(class181_0, 5);
						num = -873981485;
						continue;
						IL_0355:
						num = ((int)num2 * -1158835886) ^ 0x47D3B055;
						continue;
					}
					class184_0.int_3 = smethod_60(class181_0, 5);
					num = ((class184_0.int_3 >= 0) ? (-789277596) : (-1264944343));
					continue;
					IL_0404:
					num4 = smethod_60(class181_0, 3);
					num = ((num4 < 0) ? (-242503294) : (-1761383781));
					continue;
					IL_023c:
					num = ((num3 < 17) ? (-249196530) : (-1539441261));
					continue;
					IL_01ac:
					num = ((class184_0.int_8 < class184_0.int_5) ? (-1885650475) : (-1469767028));
					continue;
					IL_037f:
					class184_0.int_5 = smethod_60(class181_0, 4);
					num = ((class184_0.int_5 < 0) ? (-157109144) : (-1721851069));
					continue;
					IL_01d6:
					num = ((num5-- > 0) ? (-415170131) : (-1890786856));
					continue;
					IL_010f:
					class184_0.byte_1[class184_0.int_8++] = (class184_0.byte_2 = (byte)num3);
					num = ((class184_0.int_8 != class184_0.int_6) ? (-10941957) : (-515204015));
					continue;
					IL_0277:
					num = ((((num3 = smethod_96(class184_0.class183_0, class181_0)) & -16) == 0) ? (-1303576432) : (-194562666));
					continue;
					end_IL_052d:
					break;
				}
				continue;
				end_IL_0604:
				break;
			}
		}
	}

	internal static void smethod_306(Class53 class53_0, Class63 class63_0, Class57 class57_0)
	{
		smethod_137(class53_0, Enum7.const_266, class63_0, class57_0);
	}

	internal static void smethod_307(AboutForm form1_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AboutForm));
		while (true)
		{
			int num = 239988398;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x33155B2F)) % 48)
				{
				case 47u:
					form1_0.label_3 = new System.Windows.Forms.Label();
					num = ((int)num2 * -400832647) ^ -1743982760;
					continue;
				case 46u:
					form1_0.panel_0.Controls.Add(form1_0.label_0);
					form1_0.panel_0.Controls.Add(form1_0.label_1);
					form1_0.panel_0.Location = new Point(-3, -1);
					form1_0.panel_0.Name = "whiteBackPanel";
					num = (int)(num2 * 506880124) ^ -1282499419;
					continue;
				case 45u:
					form1_0.label_2.TabIndex = 1;
					form1_0.label_2.Text = "A powerful and advanced injector in a simple GUI!";
					num = (int)((num2 * 1117676918) ^ 0x2D92ECBC);
					continue;
				case 44u:
					form1_0.label_3.Size = new Size(254, 18);
					form1_0.label_3.TabIndex = 2;
					num = (int)(num2 * 1122888279) ^ -642575333;
					continue;
				case 43u:
					form1_0.pictureBox_0.BackgroundImage = (Image)componentResourceManager.GetObject("logoPictureBox.BackgroundImage");
					form1_0.pictureBox_0.Location = new Point(15, 16);
					num = (int)(num2 * 1932842368) ^ -1764471064;
					continue;
				case 42u:
					form1_0.label_4 = new System.Windows.Forms.Label();
					form1_0.panel_0.SuspendLayout();
					((ISupportInitialize)form1_0.pictureBox_0).BeginInit();
					num = (int)((num2 * 812203041) ^ 0x3CF264C1);
					continue;
				case 41u:
					form1_0.AutoScaleMode = AutoScaleMode.Dpi;
					num = (int)(num2 * 1255926440) ^ -1668414471;
					continue;
				case 40u:
					form1_0.panel_0.PerformLayout();
					((ISupportInitialize)form1_0.pictureBox_0).EndInit();
					num = (int)((num2 * 1580092310) ^ 0x207410DD);
					continue;
				case 39u:
					form1_0.label_0.Font = new Font("Segoe UI", 11.25f);
					num = ((int)num2 * -2032935781) ^ -461061599;
					continue;
				case 38u:
					form1_0.label_1.Size = new Size(171, 30);
					form1_0.label_1.TabIndex = 0;
					form1_0.label_1.Text = "Extreme Injector";
					form1_0.label_2.Font = new Font("Segoe UI", 9f, FontStyle.Italic, GraphicsUnit.Point, 0);
					form1_0.label_2.Location = new Point(24, 96);
					num = (int)((num2 * 1574155168) ^ 0x20C1B688);
					continue;
				case 37u:
					form1_0.panel_0.ResumeLayout(performLayout: false);
					num = ((int)num2 * -1634100079) ^ -8387422;
					continue;
				case 36u:
					form1_0.SuspendLayout();
					form1_0.panel_0.BackColor = Color.White;
					form1_0.panel_0.BorderStyle = BorderStyle.FixedSingle;
					form1_0.panel_0.Controls.Add(form1_0.pictureBox_0);
					num = (int)(num2 * 1680596734) ^ -253796295;
					continue;
				case 35u:
					form1_0.label_0.Location = new Point(80, 45);
					num = (int)((num2 * 44775943) ^ 0x2CA5E801);
					continue;
				case 34u:
					form1_0.panel_0.Size = new Size(346, 89);
					form1_0.panel_0.TabIndex = 0;
					num = ((int)num2 * -1046831591) ^ 0x2C4954E6;
					continue;
				case 33u:
					form1_0.panel_0 = new Panel();
					num = (int)(num2 * 210247447) ^ -1540387460;
					continue;
				case 32u:
					form1_0.Controls.Add(form1_0.label_4);
					num = (int)(num2 * 1509675658) ^ -1323551691;
					continue;
				case 31u:
					form1_0.label_3.Location = new Point(44, 120);
					form1_0.label_3.Name = "thanksLabel";
					num = (int)(num2 * 450386619) ^ -35689482;
					continue;
				case 30u:
					form1_0.ClientSize = new Size(342, 192);
					num = ((int)num2 * -77034139) ^ -199280279;
					continue;
				case 29u:
					form1_0.label_2.TextAlign = ContentAlignment.TopCenter;
					form1_0.label_3.Font = new Font("Segoe UI", 8.75f);
					num = (int)(num2 * 1753767711) ^ -1201070237;
					continue;
				case 28u:
					form1_0.StartPosition = FormStartPosition.CenterParent;
					num = ((int)num2 * -478457215) ^ 0x21EEC1A6;
					continue;
				case 26u:
					form1_0.Controls.Add(form1_0.linkLabel_0);
					num = ((int)num2 * -1100673775) ^ -830344124;
					continue;
				case 25u:
					form1_0.label_4.Name = "copyrightLabel";
					form1_0.label_4.Size = new Size(254, 18);
					num = ((int)num2 * -50207233) ^ 0x4777B992;
					continue;
				case 24u:
					form1_0.label_0.Size = new Size(0, 20);
					num = ((int)num2 * -1738097338) ^ -1949710398;
					continue;
				case 23u:
					form1_0.label_2.Name = "descriptionLabel";
					form1_0.label_2.Size = new Size(294, 24);
					num = (int)((num2 * 454622560) ^ 0x3D1C9DB2);
					continue;
				case 22u:
					form1_0.linkLabel_0.TextAlign = ContentAlignment.MiddleCenter;
					form1_0.linkLabel_0.LinkClicked += form1_0.method_0;
					form1_0.label_4.Font = new Font("Segoe UI", 8.75f);
					num = (int)(num2 * 1246140221) ^ -150795864;
					continue;
				case 21u:
					form1_0.Text = "About Extreme Injector";
					num = ((int)num2 * -817814990) ^ -769432112;
					continue;
				case 20u:
					form1_0.pictureBox_0 = new PictureBox();
					form1_0.label_0 = new System.Windows.Forms.Label();
					form1_0.label_1 = new System.Windows.Forms.Label();
					num = (int)((num2 * 974790494) ^ 0x1CE4EFF4);
					continue;
				case 19u:
					form1_0.label_2 = new System.Windows.Forms.Label();
					num = (int)((num2 * 58419151) ^ 0x53ECF0BD);
					continue;
				case 17u:
					form1_0.label_1.Location = new Point(79, 12);
					form1_0.label_1.Name = "extremeInjectorLabel";
					num = ((int)num2 * -84377402) ^ -1735938753;
					continue;
				case 16u:
					form1_0.label_3.Text = "Special thanks to Darawk and DarthTon.";
					form1_0.label_3.TextAlign = ContentAlignment.TopCenter;
					form1_0.linkLabel_0.Location = new Point(19, 140);
					num = ((int)num2 * -920431653) ^ -722645965;
					continue;
				case 15u:
					form1_0.label_4.TextAlign = ContentAlignment.TopCenter;
					form1_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = ((int)num2 * -1507909688) ^ 0x3A831E;
					continue;
				case 14u:
					form1_0.MaximizeBox = false;
					num = ((int)num2 * -2070699105) ^ -2132672113;
					continue;
				case 13u:
					form1_0.label_0.TabIndex = 1;
					form1_0.label_1.AutoSize = true;
					form1_0.label_1.Font = new Font("Segoe UI Semibold", 15.75f, FontStyle.Bold);
					num = (int)(num2 * 861981770) ^ -479767012;
					continue;
				case 12u:
					form1_0.linkLabel_0.Name = "githubLabel";
					num = ((int)num2 * -922519901) ^ 0xCC803BD;
					continue;
				case 11u:
					form1_0.label_0.Name = "versionLabel";
					num = (int)(num2 * 301866594) ^ -159800895;
					continue;
				case 10u:
					form1_0.label_4.TabIndex = 5;
					num = ((int)num2 * -1643282713) ^ 0x2004A01D;
					continue;
				case 9u:
					form1_0.label_4.Location = new Point(44, 167);
					num = ((int)num2 * -1008049267) ^ -1434830013;
					continue;
				case 8u:
					form1_0.FormBorderStyle = FormBorderStyle.FixedDialog;
					num = (int)((num2 * 1721042647) ^ 0x29CD6519);
					continue;
				case 7u:
					form1_0.pictureBox_0.Name = "logoPictureBox";
					form1_0.pictureBox_0.Size = new Size(48, 48);
					form1_0.pictureBox_0.TabIndex = 2;
					form1_0.pictureBox_0.TabStop = false;
					form1_0.label_0.AutoSize = true;
					num = (int)((num2 * 1113656847) ^ 0x6AA34921);
					continue;
				case 6u:
					form1_0.linkLabel_0.Size = new Size(305, 21);
					form1_0.linkLabel_0.TabIndex = 4;
					form1_0.linkLabel_0.TabStop = true;
					num = ((int)num2 * -1595834807) ^ 0x2833597C;
					continue;
				case 5u:
					form1_0.linkLabel_0.Text = "Report Issues && Donate";
					num = (int)((num2 * 907376716) ^ 0x7E9E9185);
					continue;
				case 4u:
					form1_0.label_4.Text = "Copyright © 2011-2017 master131";
					num = (int)(num2 * 1552576005) ^ -315237340;
					continue;
				case 3u:
					form1_0.Controls.Add(form1_0.label_2);
					form1_0.Controls.Add(form1_0.panel_0);
					form1_0.Font = new Font("Segoe UI", 8.25f);
					num = ((int)num2 * -379595661) ^ -883238962;
					continue;
				case 2u:
					form1_0.MinimizeBox = false;
					form1_0.Name = "AboutForm";
					num = (int)(num2 * 1618150679) ^ -759886643;
					continue;
				case 1u:
					form1_0.Controls.Add(form1_0.label_3);
					num = (int)(num2 * 459915414) ^ -1169605862;
					continue;
				case 0u:
					form1_0.linkLabel_0 = new LinkLabel();
					num = ((int)num2 * -711552648) ^ -487514587;
					continue;
				case 27u:
					break;
				default:
					form1_0.ResumeLayout(performLayout: false);
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_308(long long_0, object object_0, Class53 class53_0)
	{
		if (Class49.bool_0)
		{
			goto IL_0007;
		}
		goto IL_0057;
		IL_0007:
		int num = -1592849599;
		goto IL_0032;
		IL_0032:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1588862186)) % 5)
			{
			case 3u:
				break;
			case 2u:
				Class52.smethod_30()(ref class53_0.struct19_0, object_0, (IntPtr)long_0);
				num = (int)(num2 * 1585359362) ^ -2133610936;
				continue;
			default:
				return;
			case 4u:
				goto IL_0057;
			case 0u:
				return;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0007;
		IL_0057:
		Class52.smethod_28()(ref class53_0.struct19_0, object_0, (IntPtr)long_0);
		num = -1460730178;
		goto IL_0032;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern uint GetWindowsDirectory(StringBuilder stringBuilder_0, int int_0);

	internal static byte[] smethod_309()
	{
		return (byte[])smethod_124().GetObject("AsmJitx64", Class68.cultureInfo_0);
	}

	internal static void smethod_310(Class63 class63_0, Class63 class63_1, Class53 class53_0)
	{
		smethod_137(class53_0, Enum7.const_565, class63_0, class63_1);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetProcessDEPPolicy(IntPtr intptr_0, out uint uint_0, out bool bool_0);

	internal static void smethod_311()
	{
		Class49.class63_0 = Class51.smethod_1<Class63>("?no_reg@AsmJit@@3UGPReg@1@B");
		Class49.class63_1 = Class51.smethod_1<Class63>("?al@AsmJit@@3UGPReg@1@B");
		Class49.class63_2 = Class51.smethod_1<Class63>("?cl@AsmJit@@3UGPReg@1@B");
		Class49.class63_3 = Class51.smethod_1<Class63>("?dl@AsmJit@@3UGPReg@1@B");
		Class49.class63_4 = Class51.smethod_1<Class63>("?bl@AsmJit@@3UGPReg@1@B");
		while (true)
		{
			int num = -1283845303;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -745550669)) % 66)
				{
				case 65u:
					Class49.class64_1 = Class51.smethod_1<Class64>("?mm1@AsmJit@@3UMMReg@1@B");
					num = ((int)num2 * -466661698) ^ -1500152714;
					continue;
				case 64u:
					num = (Class49.bool_0 ? 1732533020 : 582164788) ^ ((int)num2 * -2026130458);
					continue;
				case 63u:
					Class49.class63_63 = Class51.smethod_1<Class63>("?r10@AsmJit@@3UGPReg@1@B");
					Class49.class63_64 = Class51.smethod_1<Class63>("?r11@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1538640193) ^ -1998856575;
					continue;
				case 62u:
					Class49.class63_12 = Class51.smethod_1<Class63>("?r11b@AsmJit@@3UGPReg@1@B");
					Class49.class63_13 = Class51.smethod_1<Class63>("?r12b@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 1494029670) ^ 0x76582B57);
					continue;
				case 61u:
					Class49.class63_40 = Class51.smethod_1<Class63>("?ebx@AsmJit@@3UGPReg@1@B");
					Class49.class63_41 = Class51.smethod_1<Class63>("?esp@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1281604944) ^ -1155684980;
					continue;
				case 60u:
					Class49.class65_1 = Class51.smethod_1<Class65>("?xmm1@AsmJit@@3UXMMReg@1@B");
					num = (int)((num2 * 610647561) ^ 0x10D4C856);
					continue;
				case 59u:
					Class49.class63_45 = Class51.smethod_1<Class63>("?r8d@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1601657306) ^ -1012507797;
					continue;
				case 58u:
					Class49.class63_18 = Class51.smethod_1<Class63>("?ch@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -758428795) ^ 0x1634376F;
					continue;
				case 57u:
					Class49.class63_67 = Class51.smethod_1<Class63>("?r14@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 997384931) ^ 0x199684A3);
					continue;
				case 56u:
					Class49.class63_25 = Class51.smethod_1<Class63>("?sp@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 293983785) ^ -829145779;
					continue;
				case 55u:
					Class49.class63_37 = Class51.smethod_1<Class63>("?eax@AsmJit@@3UGPReg@1@B");
					num = -681590305;
					continue;
				case 54u:
					Class49.class63_76 = Class51.smethod_1<Class63>("?ndi@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1725322453) ^ -936912316;
					continue;
				case 53u:
					Class49.class63_28 = Class51.smethod_1<Class63>("?di@AsmJit@@3UGPReg@1@B");
					num = ((!Class49.bool_0) ? (-1763829185) : (-1751907634)) ^ (int)(num2 * 1994870339);
					continue;
				case 52u:
					Class49.class63_11 = Class51.smethod_1<Class63>("?r10b@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 626389340) ^ -536714753;
					continue;
				case 51u:
					Class49.class63_17 = Class51.smethod_1<Class63>("?ah@AsmJit@@3UGPReg@1@B");
					num = -362153323;
					continue;
				case 50u:
					num = ((!Class49.bool_0) ? (-1148443142) : (-1736399571)) ^ ((int)num2 * -1092756559);
					continue;
				case 49u:
					Class49.class65_12 = Class51.smethod_1<Class65>("?xmm12@AsmJit@@3UXMMReg@1@B");
					Class49.class65_13 = Class51.smethod_1<Class65>("?xmm13@AsmJit@@3UXMMReg@1@B");
					Class49.class65_14 = Class51.smethod_1<Class65>("?xmm14@AsmJit@@3UXMMReg@1@B");
					num = ((int)num2 * -1457726638) ^ -206486949;
					continue;
				case 48u:
					Class49.class63_38 = Class51.smethod_1<Class63>("?ecx@AsmJit@@3UGPReg@1@B");
					Class49.class63_39 = Class51.smethod_1<Class63>("?edx@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1017133357) ^ -1090476654;
					continue;
				case 47u:
					Class49.class65_2 = Class51.smethod_1<Class65>("?xmm2@AsmJit@@3UXMMReg@1@B");
					num = ((int)num2 * -1255189193) ^ 0x546D0A28;
					continue;
				case 46u:
					Class49.class65_3 = Class51.smethod_1<Class65>("?xmm3@AsmJit@@3UXMMReg@1@B");
					Class49.class65_4 = Class51.smethod_1<Class65>("?xmm4@AsmJit@@3UXMMReg@1@B");
					num = (int)(num2 * 2013354066) ^ -2010149920;
					continue;
				case 45u:
					Class49.class63_65 = Class51.smethod_1<Class63>("?r12@AsmJit@@3UGPReg@1@B");
					Class49.class63_66 = Class51.smethod_1<Class63>("?r13@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 1829066171) ^ 0x29D030BB);
					continue;
				case 44u:
					Class49.class63_14 = Class51.smethod_1<Class63>("?r13b@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 110752486) ^ -968289311;
					continue;
				case 43u:
					Class49.class63_68 = Class51.smethod_1<Class63>("?r15@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 780983877) ^ 0x487DFABB);
					continue;
				case 42u:
					Class49.class64_4 = Class51.smethod_1<Class64>("?mm4@AsmJit@@3UMMReg@1@B");
					Class49.class64_5 = Class51.smethod_1<Class64>("?mm5@AsmJit@@3UMMReg@1@B");
					num = ((int)num2 * -1183122166) ^ 0x109AB482;
					continue;
				case 40u:
					num = ((!Class49.bool_0) ? 2006744194 : 1315136026) ^ (int)(num2 * 663419238);
					continue;
				case 39u:
					Class49.class64_3 = Class51.smethod_1<Class64>("?mm3@AsmJit@@3UMMReg@1@B");
					num = ((int)num2 * -1453290581) ^ -1059147444;
					continue;
				case 38u:
					Class49.class63_27 = Class51.smethod_1<Class63>("?si@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -771711138) ^ 0x20A04880;
					continue;
				case 37u:
					Class49.class63_20 = Class51.smethod_1<Class63>("?bh@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1657904912) ^ 0x467F9334;
					continue;
				case 36u:
					Class49.class63_48 = Class51.smethod_1<Class63>("?r11d@AsmJit@@3UGPReg@1@B");
					Class49.class63_49 = Class51.smethod_1<Class63>("?r12d@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1946566820) ^ -1057948391;
					continue;
				case 35u:
					Class49.class63_21 = Class51.smethod_1<Class63>("?ax@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -662123244) ^ 0x36C1FAD7;
					continue;
				case 34u:
					Class49.class63_8 = Class51.smethod_1<Class63>("?dil@AsmJit@@3UGPReg@1@B");
					Class49.class63_9 = Class51.smethod_1<Class63>("?r8b@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1657014651) ^ 0x1E7A924B;
					continue;
				case 33u:
					Class49.class63_16 = Class51.smethod_1<Class63>("?r15b@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 1486420893) ^ -688755115;
					continue;
				case 32u:
					Class49.class63_50 = Class51.smethod_1<Class63>("?r13d@AsmJit@@3UGPReg@1@B");
					Class49.class63_51 = Class51.smethod_1<Class63>("?r14d@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -277882469) ^ 0x481AA04A;
					continue;
				case 31u:
					Class49.class63_7 = Class51.smethod_1<Class63>("?sil@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 831205666) ^ -271856685;
					continue;
				case 30u:
					Class49.class63_29 = Class51.smethod_1<Class63>("?r8w@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 521540610) ^ -1918085345;
					continue;
				case 29u:
					Class49.class63_58 = Class51.smethod_1<Class63>("?rbp@AsmJit@@3UGPReg@1@B");
					Class49.class63_59 = Class51.smethod_1<Class63>("?rsi@AsmJit@@3UGPReg@1@B");
					Class49.class63_60 = Class51.smethod_1<Class63>("?rdi@AsmJit@@3UGPReg@1@B");
					Class49.class63_61 = Class51.smethod_1<Class63>("?r8@AsmJit@@3UGPReg@1@B");
					Class49.class63_62 = Class51.smethod_1<Class63>("?r9@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 1224603143) ^ 0x38CF5E73);
					continue;
				case 28u:
					Class49.class63_30 = Class51.smethod_1<Class63>("?r9w@AsmJit@@3UGPReg@1@B");
					Class49.class63_31 = Class51.smethod_1<Class63>("?r10w@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1744612974) ^ -2059969359;
					continue;
				case 27u:
					Class49.class63_42 = Class51.smethod_1<Class63>("?ebp@AsmJit@@3UGPReg@1@B");
					Class49.class63_43 = Class51.smethod_1<Class63>("?esi@AsmJit@@3UGPReg@1@B");
					Class49.class63_44 = Class51.smethod_1<Class63>("?edi@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 20207133) ^ 0x3F5854B0);
					continue;
				case 26u:
					Class49.class63_26 = Class51.smethod_1<Class63>("?bp@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 978948368) ^ 0x5852390B);
					continue;
				case 25u:
					Class49.class63_69 = Class51.smethod_1<Class63>("?nax@AsmJit@@3UGPReg@1@B");
					Class49.class63_70 = Class51.smethod_1<Class63>("?ncx@AsmJit@@3UGPReg@1@B");
					Class49.class63_71 = Class51.smethod_1<Class63>("?ndx@AsmJit@@3UGPReg@1@B");
					Class49.class63_72 = Class51.smethod_1<Class63>("?nbx@AsmJit@@3UGPReg@1@B");
					Class49.class63_73 = Class51.smethod_1<Class63>("?nsp@AsmJit@@3UGPReg@1@B");
					num = -200302434;
					continue;
				case 24u:
					Class49.class63_23 = Class51.smethod_1<Class63>("?dx@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 74115907) ^ 0x63A77EBD);
					continue;
				case 23u:
					Class49.class65_5 = Class51.smethod_1<Class65>("?xmm5@AsmJit@@3UXMMReg@1@B");
					Class49.class65_6 = Class51.smethod_1<Class65>("?xmm6@AsmJit@@3UXMMReg@1@B");
					Class49.class65_7 = Class51.smethod_1<Class65>("?xmm7@AsmJit@@3UXMMReg@1@B");
					num = (int)(num2 * 275208838) ^ -2115116905;
					continue;
				case 22u:
					Class49.class65_15 = Class51.smethod_1<Class65>("?xmm15@AsmJit@@3UXMMReg@1@B");
					num = (int)(num2 * 1275018715) ^ -1958866906;
					continue;
				case 21u:
					Class49.class63_53 = Class51.smethod_1<Class63>("?rax@AsmJit@@3UGPReg@1@B");
					Class49.class63_54 = Class51.smethod_1<Class63>("?rcx@AsmJit@@3UGPReg@1@B");
					Class49.class63_55 = Class51.smethod_1<Class63>("?rdx@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 544958900) ^ -1300822138;
					continue;
				case 20u:
					Class49.class65_8 = Class51.smethod_1<Class65>("?xmm8@AsmJit@@3UXMMReg@1@B");
					num = ((int)num2 * -1506031424) ^ 0x6D720EE6;
					continue;
				case 19u:
					Class49.class64_0 = Class51.smethod_1<Class64>("?mm0@AsmJit@@3UMMReg@1@B");
					num = ((int)num2 * -1205074054) ^ 0x4F3CF9FC;
					continue;
				case 18u:
					Class49.class63_10 = Class51.smethod_1<Class63>("?r9b@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -583163015) ^ -1946115339;
					continue;
				case 17u:
					Class49.class64_6 = Class51.smethod_1<Class64>("?mm6@AsmJit@@3UMMReg@1@B");
					num = (int)(num2 * 801123639) ^ -809538179;
					continue;
				case 16u:
					Class49.class63_46 = Class51.smethod_1<Class63>("?r9d@AsmJit@@3UGPReg@1@B");
					Class49.class63_47 = Class51.smethod_1<Class63>("?r10d@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -132552288) ^ -912122865;
					continue;
				case 15u:
					Class49.class63_5 = Class51.smethod_1<Class63>("?spl@AsmJit@@3UGPReg@1@B");
					Class49.class63_6 = Class51.smethod_1<Class63>("?bpl@AsmJit@@3UGPReg@1@B");
					num = (int)((num2 * 1432119236) ^ 0x73932726);
					continue;
				case 13u:
					Class49.class63_56 = Class51.smethod_1<Class63>("?rbx@AsmJit@@3UGPReg@1@B");
					Class49.class63_57 = Class51.smethod_1<Class63>("?rsp@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1092165702) ^ 0x2BAE48BC;
					continue;
				case 12u:
					Class49.class63_24 = Class51.smethod_1<Class63>("?bx@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1367969840) ^ 0x2504999B;
					continue;
				case 11u:
					Class49.class63_74 = Class51.smethod_1<Class63>("?nbp@AsmJit@@3UGPReg@1@B");
					Class49.class63_75 = Class51.smethod_1<Class63>("?nsi@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -61123922) ^ 0x2A02357;
					continue;
				case 10u:
					Class49.class63_15 = Class51.smethod_1<Class63>("?r14b@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 1153734781) ^ -190802298;
					continue;
				case 9u:
					Class49.class64_2 = Class51.smethod_1<Class64>("?mm2@AsmJit@@3UMMReg@1@B");
					num = (int)(num2 * 1623998899) ^ -1384848669;
					continue;
				case 8u:
					Class49.class63_19 = Class51.smethod_1<Class63>("?dh@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 1962295877) ^ -1905397064;
					continue;
				case 7u:
					Class49.class65_9 = Class51.smethod_1<Class65>("?xmm9@AsmJit@@3UXMMReg@1@B");
					Class49.class65_10 = Class51.smethod_1<Class65>("?xmm10@AsmJit@@3UXMMReg@1@B");
					Class49.class65_11 = Class51.smethod_1<Class65>("?xmm11@AsmJit@@3UXMMReg@1@B");
					num = ((int)num2 * -406590269) ^ -1319426861;
					continue;
				case 6u:
					Class49.class63_36 = Class51.smethod_1<Class63>("?r15w@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -652550803) ^ -606441300;
					continue;
				case 5u:
					Class49.class63_52 = Class51.smethod_1<Class63>("?r15d@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -353759196) ^ -1811908888;
					continue;
				case 4u:
					Class49.class63_32 = Class51.smethod_1<Class63>("?r11w@AsmJit@@3UGPReg@1@B");
					num = (int)(num2 * 79547584) ^ -1713755935;
					continue;
				case 3u:
					num = (Class49.bool_0 ? (-2106226974) : (-1457313144));
					continue;
				case 2u:
					Class49.class63_33 = Class51.smethod_1<Class63>("?r12w@AsmJit@@3UGPReg@1@B");
					Class49.class63_34 = Class51.smethod_1<Class63>("?r13w@AsmJit@@3UGPReg@1@B");
					Class49.class63_35 = Class51.smethod_1<Class63>("?r14w@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -156990361) ^ -1453361169;
					continue;
				case 1u:
					Class49.class64_7 = Class51.smethod_1<Class64>("?mm7@AsmJit@@3UMMReg@1@B");
					Class49.class65_0 = Class51.smethod_1<Class65>("?xmm0@AsmJit@@3UXMMReg@1@B");
					num = ((int)num2 * -1142924980) ^ -1724479487;
					continue;
				case 0u:
					Class49.class63_22 = Class51.smethod_1<Class63>("?cx@AsmJit@@3UGPReg@1@B");
					num = ((int)num2 * -1218021946) ^ -79457047;
					continue;
				default:
					return;
				case 14u:
					break;
				case 41u:
					return;
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll")]
	internal static extern bool Wow64SetThreadContext(IntPtr intptr_0, ref Class124.Struct54 struct54_0);

	internal static Class142 smethod_312(Class154 class154_0, Class5 class5_0)
	{
		Class157 @class = class154_0.method_6().method_3().imethod_49()[14];
		if (@class.method_0() != 0)
		{
			long num3 = default(long);
			Class142 class2 = default(Class142);
			while (true)
			{
				int num = -880956597;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1024140605)) % 12)
					{
					case 10u:
						num = ((num3 != -1L) ? 438485269 : 807005922) ^ (int)(num2 * 1268579210);
						continue;
					case 8u:
						num = ((@class.method_2() == 0) ? 1423101048 : 698370342) ^ (int)(num2 * 1503502788);
						continue;
					case 6u:
						num = (class5_0.imethod_0(num3) ? 898834489 : 1401334154) ^ (int)(num2 * 324214650);
						continue;
					case 2u:
						break;
					case 1u:
						num3 = smethod_135(class154_0, @class.method_0());
						num = -471873075;
						continue;
					case 0u:
						goto IL_00e8;
					case 4u:
						goto end_IL_0117;
					case 5u:
						return class2;
					case 7u:
						return null;
					case 9u:
						return null;
					default:
						return null;
					case 3u:
						goto end_IL_0159;
					}
					num = (class5_0.imethod_0(num3 + @class.method_2()) ? (-607341605) : (-1717547100));
					continue;
					IL_00e8:
					smethod_157(class5_0, num3);
					class2 = new Class142(class5_0);
					num = ((class2.method_0() >= 72) ? (-982574482) : (-396135420));
					continue;
					end_IL_0117:
					break;
				}
				continue;
				end_IL_0159:
				break;
			}
		}
		return null;
	}

	internal static void smethod_313(string string_0, string string_1, IntPtr intptr_0, GClass1 gclass1_0, uint uint_0)
	{
		gclass1_0.method_7(string_0);
		gclass1_0.method_9(string_1);
		gclass1_0.method_3(intptr_0);
		while (true)
		{
			int num = -2135046550;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1333916164)) % 3)
				{
				case 2u:
					goto IL_0017;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0017:
				gclass1_0.method_5(uint_0);
				num = (int)(num2 * 50272429) ^ -1657704505;
			}
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool VirtualProtectEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, Class124.Enum34 enum34_0, out Class124.Enum34 enum34_1);

	internal static uint smethod_314(Class166 class166_0)
	{
		return class166_0.class5_0.ReadUInt32();
	}

	internal static void smethod_315(Stream stream_0, Class154 class154_0)
	{
		smethod_76(stream_0, new Class165(class154_0));
	}

	internal static Class96.Class168 smethod_316(Type type_0)
	{
		int int_ = smethod_245(type_0);
		return new Class96.Class168
		{
			int_0 = int_
		};
	}

	internal static string smethod_317()
	{
		string s = Path.Combine(Assembly.GetExecutingAssembly().Location, "settings.xml");
		char[] array = Convert.ToBase64String(Encoding.UTF8.GetBytes(s)).ToCharArray();
		Array.Reverse(array);
		return new string(array);
	}

	internal static void smethod_318(Class53 class53_0, Class63 class63_0, Class63 class63_1)
	{
		smethod_137(class53_0, Enum7.const_266, class63_0, class63_1);
	}

	internal static bool smethod_319(Class59 class59_0, Class59 class59_1)
	{
		if (class59_0 == null)
		{
			goto IL_0036;
		}
		goto IL_0070;
		IL_0036:
		int num = 1320019907;
		goto IL_003b;
		IL_003b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xC7CF7E2)) % 6)
			{
			case 3u:
				num = ((class59_1 == null) ? 1133296777 : 1359623839) ^ (int)(num2 * 478980359);
				continue;
			case 2u:
				break;
			case 4u:
				goto IL_0070;
			case 0u:
				return true;
			case 1u:
				return false;
			default:
				return class59_0.Equals(class59_1);
			}
			break;
		}
		goto IL_0036;
		IL_0070:
		num = ((class59_0 == null) ? 1311145371 : 242735013);
		goto IL_003b;
	}

	[DllImport("kernel32.dll")]
	internal static extern uint GetCurrentProcessId();

	internal static void smethod_320(Class53 class53_0, byte[] byte_0)
	{
		smethod_308(byte_0.Length, byte_0, class53_0);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int GetWindowText(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	internal static IntPtr smethod_321(Class83 class83_0, IntPtr intptr_0, IntPtr intptr_1)
	{
		return smethod_146(intptr_1, intptr_0, class83_0.method_17(), class83_0);
	}

	internal static short smethod_322(int int_0)
	{
		return (short)((Class179.Class185.byte_0[int_0 & 0xF] << 12) | (Class179.Class185.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class179.Class185.byte_0[(int_0 >> 8) & 0xF] << 4) | Class179.Class185.byte_0[int_0 >> 12]);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern int ResumeThread(IntPtr intptr_0);

	internal static IntPtr smethod_323(Class113 class113_0)
	{
		return (IntPtr)class113_0.method_21<uint>(1);
	}

	internal static void smethod_324(Class59 class59_0, Class47 class47_0, int int_0)
	{
		Class63[] array = new Class63[4]
		{
			Class49.class63_54,
			Class49.class63_55,
			Class49.class63_61,
			Class49.class63_62
		};
		if (int_0 < 4)
		{
			goto IL_004b;
		}
		goto IL_0075;
		IL_004b:
		int num = -565262347;
		goto IL_0050;
		IL_0050:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1861397863)) % 5)
			{
			case 3u:
				smethod_429(class47_0.class53_0, array[int_0], class59_0);
				num = (int)(num2 * 715875784) ^ -393629077;
				continue;
			case 0u:
				break;
			case 2u:
				goto IL_0075;
			case 1u:
				return;
			default:
				smethod_75(class47_0.class53_0, smethod_238(Class49.class63_57, int_0 * 8), Class49.class63_53);
				return;
			}
			break;
		}
		goto IL_004b;
		IL_0075:
		smethod_429(class47_0.class53_0, Class49.class63_53, class59_0);
		num = -1836502537;
		goto IL_0050;
	}

	internal static void smethod_325(MainForm mainForm, string string_0, string string_1)
	{
		InjectorScrambleOptions injectorScrambleOptions_ = ApplicationSettings.Current.Options.Scramble;
		Class131 @class = new Class131();
		@class.method_21(injectorScrambleOptions_.CreateNewEntryPoint);
		@class.method_3(injectorScrambleOptions_.InsertExtraSections);
		@class.method_11(injectorScrambleOptions_.ModifyAssemblyCode);
		@class.method_1(injectorScrambleOptions_.ScrambleHeaderFields);
		@class.method_19(injectorScrambleOptions_.ModifyImportTable);
		@class.method_17(injectorScrambleOptions_.RenameSections);
		@class.method_15(injectorScrambleOptions_.MoveRelocationTable);
		@class.method_5(injectorScrambleOptions_.RemoveDebugData);
		@class.method_9(injectorScrambleOptions_.ShiftSectionData);
		@class.method_13(injectorScrambleOptions_.RemoveUselessData);
		@class.method_7(injectorScrambleOptions_.CreateFakeDebugDirectory);
		@class.method_24(injectorScrambleOptions_.ShiftSectionMemory);
		@class.method_26(injectorScrambleOptions_.StripSectionCharacteristics);
		Class131 class131_ = @class;
		try
		{
			Class154 class2 = smethod_81(Enum39.const_0, string_0);
			try
			{
				GClass4 gClass = new GClass4(class2, class131_);
				try
				{
					smethod_95(gClass);
					smethod_367(string_1, gClass);
				}
				finally
				{
					if (gClass != null)
					{
						while (true)
						{
							IL_0108:
							int num = -1702995827;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)(num ^ -661244873)) % 3)
								{
								case 1u:
									goto IL_00d6;
								default:
									goto end_IL_00ea;
								case 2u:
									break;
								case 0u:
									goto end_IL_00ea;
								}
								goto IL_0108;
								IL_00d6:
								((IDisposable)gClass).Dispose();
								num = (int)((num2 * 1123292838) ^ 0xAC1692F);
								continue;
								end_IL_00ea:
								break;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (class2 != null)
				{
					while (true)
					{
						IL_0149:
						int num3 = -1031046145;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)(num3 ^ -661244873)) % 3)
							{
							case 1u:
								goto IL_0117;
							default:
								goto end_IL_012b;
							case 2u:
								break;
							case 0u:
								goto end_IL_012b;
							}
							goto IL_0149;
							IL_0117:
							((IDisposable)class2).Dispose();
							num3 = (int)((num2 * 1680942954) ^ 0x33F36594);
							continue;
							end_IL_012b:
							break;
						}
						break;
					}
				}
			}
		}
		catch (Exception)
		{
			while (true)
			{
				int num4 = -608229753;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num4 ^ -661244873)) % 3)
					{
					case 1u:
						goto IL_0156;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0156:
					File.Copy(string_0, string_1, overwrite: true);
					num4 = (int)((num2 * 583417003) ^ 0x74F9F439);
				}
			}
		}
	}

	internal static void smethod_326()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += smethod_416;
		}
		catch
		{
		}
	}

	internal static bool smethod_327(Class129 class129_0, IntPtr intptr_0)
	{
		Class129.Class130 @class = new Class129.Class130();
		GClass1 gClass = default(GClass1);
		while (true)
		{
			int num = 916096859;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x558C464C)) % 6)
				{
				case 2u:
					num = ((gClass == null) ? 698416911 : 1558461311) ^ (int)(num2 * 435940279);
					continue;
				case 1u:
					@class.intptr_0 = intptr_0;
					num = (int)(num2 * 195198426) ^ -1823967228;
					continue;
				case 0u:
					gClass = smethod_42(class129_0.method_0()).FirstOrDefault(@class.method_0);
					num = (int)((num2 * 967830023) ^ 0x17C9D700);
					continue;
				case 4u:
					break;
				case 5u:
					throw new InvalidOperationException("Unable to find the specified module in the process.");
				default:
					return smethod_229(class129_0, gClass);
				}
				break;
			}
		}
	}

	internal static bool smethod_328(Class56 class56_0, Class56 class56_1)
	{
		if (class56_0 == null)
		{
			goto IL_0036;
		}
		goto IL_0070;
		IL_0036:
		int num = -798089757;
		goto IL_003b;
		IL_003b:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1923596835)) % 6)
			{
			case 4u:
				num = ((class56_1 != null) ? (-1035514944) : (-881180818)) ^ (int)(num2 * 348935868);
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_0070;
			default:
				return class56_0.Equals(class56_1);
			case 2u:
				return false;
			case 5u:
				return true;
			}
			break;
		}
		goto IL_0036;
		IL_0070:
		num = ((class56_0 == null) ? (-894972497) : (-1859074298));
		goto IL_003b;
	}

	[DllImport("kernel32.dll")]
	internal static extern bool Thread32Next(IntPtr intptr_0, ref Class124.Struct44 struct44_0);

	internal static Class59 smethod_329(Class58 class58_0, long long_0)
	{
		return smethod_161(8u, (IntPtr)long_0, class58_0);
	}

	internal static void smethod_330(SettingsForm gform2_0)
	{
		InjectionOptions class14_ = ApplicationSettings.Current.Options;
		class14_.Method = (InjectionMethod)gform2_0.comboBox_0.SelectedIndex;
		class14_.TextColor = gform2_0.panel_2.BackColor;
		class14_.BackgroundColor1 = gform2_0.panel_1.BackColor;
		class14_.BackgroundColor2 = gform2_0.panel_0.BackColor;
		class14_.AutoInject = gform2_0.checkBox_2.Checked;
		class14_.StealthInject = gform2_0.checkBox_0.Checked;
		class14_.CloseOnInject = gform2_0.checkBox_1.Checked;
		class14_.DelayBetweenModules = (int)gform2_0.numericUpDown_0.Value;
		class14_.DelayBeforeInjection = (int)gform2_0.numericUpDown_1.Value;
		class14_.ErasePeHeaders = gform2_0.checkBox_4.Checked;
		class14_.HideModule = gform2_0.checkBox_3.Checked;
		while (true)
		{
			int num = -1681404562;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1580424416)) % 3)
				{
				case 2u:
					goto IL_00d0;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_00d0:
				ApplicationSettings.Save();
				num = (int)((num2 * 1317291613) ^ 0x79221AD5);
			}
		}
	}

	internal static string smethod_331(Class77 class77_0)
	{
		int windowTextLength = GetWindowTextLength(class77_0.method_0());
		if (windowTextLength == 0)
		{
			goto IL_001e;
		}
		goto IL_0052;
		IL_001e:
		int num = 1373384318;
		goto IL_0023;
		IL_0023:
		StringBuilder stringBuilder = default(StringBuilder);
		switch ((uint)(num ^ 0x26C020BD) % 5u)
		{
		case 4u:
			break;
		case 0u:
			goto IL_0052;
		case 1u:
			return string.Empty;
		case 2u:
			return stringBuilder.ToString();
		default:
			return string.Empty;
		}
		goto IL_001e;
		IL_0052:
		stringBuilder = new StringBuilder(windowTextLength + 1);
		num = ((GetWindowText(class77_0.method_0(), stringBuilder, stringBuilder.Capacity) == 0) ? 90177617 : 1258583095);
		goto IL_0023;
	}

	internal static void smethod_332(Enum12 enum12_0, Class53 class53_0, Class58 class58_0)
	{
		smethod_256(class58_0, enum12_0, class53_0, Enum7.const_232);
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	internal static extern void ReleaseActCtx(IntPtr intptr_0);

	internal static void smethod_333(Class165 class165_0)
	{
		class165_0.stream_0.Position = 60L;
		class165_0.binaryWriter_0.Write(class165_0.class154_0.method_4().method_0());
	}

	internal static void smethod_334(ProcessSelectorForm form5_0)
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProcessSelectorForm));
		while (true)
		{
			int num = -2065578591;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2022571101)) % 52)
				{
				case 51u:
					form5_0.Controls.Add(form5_0.button_0);
					form5_0.Controls.Add(form5_0.dataGridView_0);
					form5_0.Font = new Font("Segoe UI", 8.25f);
					num = ((int)num2 * -803629189) ^ -1223527194;
					continue;
				case 50u:
					form5_0.dataGridView_0.CellContentDoubleClick += form5_0.method_5;
					form5_0.dataGridViewImageColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
					num = ((int)num2 * -966559062) ^ -1868056723;
					continue;
				case 49u:
					form5_0.dataGridView_0.ColumnHeadersVisible = false;
					num = (int)((num2 * 1285860555) ^ 0xE715635);
					continue;
				case 48u:
					form5_0.button_3.Size = new Size(122, 23);
					form5_0.button_3.TabIndex = 4;
					form5_0.button_3.Text = "Close";
					form5_0.button_3.UseVisualStyleBackColor = true;
					num = ((int)num2 * -768709894) ^ -691705746;
					continue;
				case 47u:
					form5_0.MaximizeBox = false;
					form5_0.MinimizeBox = false;
					num = ((int)num2 * -1683533116) ^ 0x25CC5834;
					continue;
				case 46u:
					form5_0.button_1.TabIndex = 2;
					num = (int)(num2 * 212623809) ^ -808915532;
					continue;
				case 45u:
					form5_0.button_1.Location = new Point(138, 223);
					form5_0.button_1.Name = "windowListButton";
					num = ((int)num2 * -1315850481) ^ -655111121;
					continue;
				case 44u:
					form5_0.dataGridView_0.EditMode = DataGridViewEditMode.EditProgrammatically;
					form5_0.dataGridView_0.Location = new Point(11, 13);
					num = (int)(num2 * 1718375585) ^ -1701513294;
					continue;
				case 42u:
					form5_0.dataGridView_0.ReadOnly = true;
					form5_0.dataGridView_0.RowHeadersVisible = false;
					form5_0.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
					num = (int)((num2 * 1110555285) ^ 0x6F98941F);
					continue;
				case 41u:
					form5_0.dataGridView_0.MultiSelect = false;
					num = ((int)num2 * -1843021452) ^ -251247046;
					continue;
				case 40u:
					form5_0.button_2.Click += form5_0.method_3;
					num = (int)((num2 * 663908027) ^ 0x2229AE07);
					continue;
				case 39u:
					form5_0.button_0.UseVisualStyleBackColor = true;
					form5_0.button_0.Click += form5_0.method_4;
					num = ((int)num2 * -455335248) ^ -670186518;
					continue;
				case 38u:
					form5_0.dataGridViewImageColumn_0.HeaderText = "";
					num = ((int)num2 * -1275976711) ^ -388785097;
					continue;
				case 37u:
					form5_0.button_2 = new Button();
					form5_0.button_3 = new Button();
					num = ((int)num2 * -111954435) ^ 0x26FD2525;
					continue;
				case 36u:
					form5_0.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					num = (int)(num2 * 1044046171) ^ -1315679614;
					continue;
				case 35u:
					form5_0.Name = "ProcessSelectForm";
					form5_0.Text = "Process List";
					num = (int)(num2 * 618651243) ^ -275190735;
					continue;
				case 34u:
					form5_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = ((int)num2 * -1879597) ^ -360716422;
					continue;
				case 33u:
					form5_0.Controls.Add(form5_0.button_3);
					num = ((int)num2 * -1584076976) ^ -1361580172;
					continue;
				case 32u:
					form5_0.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
					form5_0.button_0 = new Button();
					num = (int)((num2 * 882900905) ^ 0x45F3250);
					continue;
				case 31u:
					form5_0.button_1.Size = new Size(122, 23);
					num = ((int)num2 * -2072702047) ^ -1617388622;
					continue;
				case 30u:
					form5_0.dataGridViewImageColumn_0.ReadOnly = true;
					num = (int)(num2 * 11690481) ^ -1975027776;
					continue;
				case 29u:
					form5_0.dataGridView_0.Columns.AddRange(form5_0.dataGridViewImageColumn_0, form5_0.dataGridViewTextBoxColumn_0);
					num = (int)((num2 * 1509726236) ^ 0x1DC2D44B);
					continue;
				case 28u:
					form5_0.dataGridView_0.AllowUserToResizeRows = false;
					form5_0.dataGridView_0.BackgroundColor = Color.White;
					form5_0.dataGridView_0.CellBorderStyle = DataGridViewCellBorderStyle.None;
					num = (int)(num2 * 270550795) ^ -999588789;
					continue;
				case 27u:
					form5_0.AutoScaleMode = AutoScaleMode.Dpi;
					num = (int)(num2 * 316309052) ^ -2059665591;
					continue;
				case 26u:
					form5_0.dataGridViewImageColumn_0.Name = "ProcessWindowIcon";
					num = ((int)num2 * -445815404) ^ 0x5421F815;
					continue;
				case 25u:
					form5_0.button_1.Text = "Window List";
					num = ((int)num2 * -1714145420) ^ -1343087227;
					continue;
				case 24u:
					form5_0.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = (int)((num2 * 208601208) ^ 0x2450828A);
					continue;
				case 23u:
					form5_0.button_1 = new Button();
					num = (int)((num2 * 145353532) ^ 0x370AD3E6);
					continue;
				case 22u:
					form5_0.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)(num2 * 1502987124) ^ -1036461324;
					continue;
				case 21u:
					form5_0.dataGridViewImageColumn_0.Width = 32;
					num = (int)((num2 * 840969501) ^ 0x3A511BCE);
					continue;
				case 20u:
					form5_0.button_0.Size = new Size(122, 23);
					num = (int)((num2 * 1470725205) ^ 0x7D0799B9);
					continue;
				case 19u:
					form5_0.Controls.Add(form5_0.button_2);
					num = (int)(num2 * 1619510871) ^ -960083355;
					continue;
				case 18u:
					form5_0.dataGridView_0 = new DataGridView();
					form5_0.dataGridViewImageColumn_0 = new DataGridViewImageColumn();
					num = (int)((num2 * 1547751821) ^ 0x4FFB8C5);
					continue;
				case 16u:
					form5_0.dataGridViewTextBoxColumn_0.Name = "ProcessWindowName";
					form5_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
					num = (int)(num2 * 119325311) ^ -278591921;
					continue;
				case 15u:
					form5_0.Controls.Add(form5_0.button_1);
					num = ((int)num2 * -662221619) ^ -1022249465;
					continue;
				case 14u:
					form5_0.ClientSize = new Size(270, 283);
					num = ((int)num2 * -1688560752) ^ 0x58DFDF16;
					continue;
				case 13u:
					form5_0.dataGridView_0.AllowUserToResizeColumns = false;
					num = ((int)num2 * -1284064473) ^ 0x119AC8A8;
					continue;
				case 12u:
					form5_0.button_0.Location = new Point(10, 223);
					form5_0.button_0.Name = "processListButton";
					num = ((int)num2 * -922859942) ^ 0x5222985F;
					continue;
				case 11u:
					form5_0.button_2.Location = new Point(10, 252);
					form5_0.button_2.Name = "selectButton";
					form5_0.button_2.Size = new Size(122, 23);
					form5_0.button_2.TabIndex = 3;
					form5_0.button_2.Text = "Select";
					num = (int)(num2 * 1787356769) ^ -2051678009;
					continue;
				case 10u:
					form5_0.button_0.TabIndex = 1;
					num = ((int)num2 * -1254973592) ^ -16408253;
					continue;
				case 9u:
					form5_0.button_3.Click += form5_0.method_2;
					num = (int)(num2 * 335084122) ^ -1750722957;
					continue;
				case 8u:
					form5_0.button_3.Location = new Point(138, 252);
					form5_0.button_3.Name = "closeButton";
					num = ((int)num2 * -259186355) ^ -1318514193;
					continue;
				case 7u:
					form5_0.button_2.UseVisualStyleBackColor = true;
					num = (int)(num2 * 1019075875) ^ -1350666366;
					continue;
				case 6u:
					form5_0.dataGridView_0.RowTemplate.Resizable = DataGridViewTriState.False;
					form5_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					form5_0.dataGridView_0.Size = new Size(248, 204);
					form5_0.dataGridView_0.TabIndex = 0;
					num = ((int)num2 * -455543726) ^ 0x331FE025;
					continue;
				case 5u:
					form5_0.dataGridViewTextBoxColumn_0.HeaderText = "";
					num = (int)((num2 * 1860751607) ^ 0x226EFCD8);
					continue;
				case 4u:
					form5_0.button_0.Text = "Process List";
					num = ((int)num2 * -371993339) ^ 0x7DE2F620;
					continue;
				case 3u:
					((ISupportInitialize)form5_0.dataGridView_0).BeginInit();
					form5_0.SuspendLayout();
					form5_0.dataGridView_0.AllowUserToAddRows = false;
					form5_0.dataGridView_0.AllowUserToDeleteRows = false;
					num = ((int)num2 * -1585033242) ^ -1779456760;
					continue;
				case 2u:
					form5_0.button_1.UseVisualStyleBackColor = true;
					form5_0.button_1.Click += form5_0.method_6;
					num = ((int)num2 * -1521203077) ^ -299851566;
					continue;
				case 1u:
					form5_0.dataGridView_0.Name = "processWindowDataGridView";
					num = (int)(num2 * 392976815) ^ -2042898414;
					continue;
				case 0u:
					form5_0.FormBorderStyle = FormBorderStyle.FixedToolWindow;
					num = (int)(num2 * 223249023) ^ -97876431;
					continue;
				case 17u:
					break;
				default:
					((ISupportInitialize)form5_0.dataGridView_0).EndInit();
					form5_0.ResumeLayout(performLayout: false);
					return;
				}
				break;
			}
		}
	}

	internal unsafe static IntPtr smethod_335(IntPtr intptr_0, Class86 class86_0, GClass1 gclass1_0)
	{
		//The blocks IL_0012, IL_0016, IL_0022, IL_002c, IL_0049, IL_005c, IL_0073, IL_0096, IL_00b5, IL_00c1, IL_00cb, IL_00da, IL_011d, IL_012a, IL_0136, IL_0140, IL_014f, IL_0155, IL_0161, IL_0171, IL_0185, IL_01a0, IL_01cd, IL_01d9, IL_01e9, IL_0206, IL_0212, IL_0222, IL_0226, IL_0232, IL_0242, IL_0267, IL_026d, IL_0279, IL_0283, IL_0292, IL_029d, IL_02a9, IL_02b9, IL_02bd, IL_02c9, IL_02d3, IL_02e2, IL_02fe, IL_0314, IL_0320, IL_032a, IL_0341, IL_0361, IL_0365, IL_0371, IL_037b, IL_0385, IL_0410, IL_041a, IL_042a, IL_043a, IL_044a, IL_045a are reachable both inside and outside the pinned region starting at IL_0111. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		byte[] array = class86_0.method_10<byte>(intptr_0, 512);
		int num5 = default(int);
		byte referenceStorage = 0;
		ref byte reference = ref referenceStorage;
		Struct31 struct31_ = default(Struct31);
		int num7 = default(int);
		Struct31 @struct = default(Struct31);
		IntPtr intPtr = default(IntPtr);
		int num13 = default(int);
		byte[] array2 = default(byte[]);
		byte* ptr2 = default(byte*);
		while (true)
		{
			int num = 956025620;
			while (true)
			{
				uint num3;
				uint num2 = (num3 = (uint)(num ^ 0xDD03A59));
				int num11;
				ref byte* pByte_ = ref struct31_.pByte_0;
				int num14;
				int num8;
				int num9;
				byte[] array3;
				int num12;
				int num10;
				int num6;
				int num4;
				switch (num2 % 30)
				{
				case 28u:
					num11 = ((num5 == -1) ? (-1452599920) : (-1163030483));
					num = num11 ^ ((int)num3 * -29733925);
					continue;
				case 26u:
					reference = ref *(byte*)null;
					num = 2011256951;
					continue;
				case 25u:
					num = (int)((num3 * 284789633) ^ 0x6FB5EED3);
					continue;
				case 24u:
					pByte_ = ref struct31_.pByte_0;
					pByte_ += num7;
					num = 1651710050;
					continue;
				case 23u:
					@struct.pByte_0 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + num5;
					struct31_ = @struct;
					num = (int)(num3 * 1567968214) ^ -924991132;
					continue;
				case 22u:
					intPtr = intptr_0.smethod_8(num5 + 5 + num13);
					num14 = (((ulong)(long)intPtr >= (ulong)(long)gclass1_0.method_0()) ? 1866652416 : 1300935600);
					num = num14 ^ ((int)num3 * -1824422125);
					continue;
				case 20u:
					num5 = smethod_419(array, "L\u008DD\0\u0001", "xxx?x", 0);
					num = ((int)num3 * -2033959918) ^ 0x7089751;
					continue;
				case 19u:
					while (true)
					{
						IL_0109:
						fixed (byte* ptr = &array2[0])
						{
							num = 605535980;
							while (true)
							{
								num2 = (num3 = (uint)(num ^ 0xDD03A59));
								switch (num2 % 30)
								{
								case 26u:
									break;
								case 28u:
									num11 = ((num5 == -1) ? (-1452599920) : (-1163030483));
									num = num11 ^ ((int)num3 * -29733925);
									continue;
								case 25u:
									num = (int)((num3 * 284789633) ^ 0x6FB5EED3);
									continue;
								case 24u:
									pByte_ = ref struct31_.pByte_0;
									pByte_ += num7;
									num = 1651710050;
									continue;
								case 23u:
									@struct.pByte_0 = ptr + num5;
									struct31_ = @struct;
									num = (int)(num3 * 1567968214) ^ -924991132;
									continue;
								case 22u:
									intPtr = intptr_0.smethod_8(num5 + 5 + num13);
									num14 = (((ulong)(long)intPtr >= (ulong)(long)gclass1_0.method_0()) ? 1866652416 : 1300935600);
									num = num14 ^ ((int)num3 * -1824422125);
									continue;
								case 20u:
									num5 = smethod_419(array, "L\u008DD\0\u0001", "xxx?x", 0);
									num = ((int)num3 * -2033959918) ^ 0x7089751;
									continue;
								case 19u:
									goto IL_0109;
								case 18u:
									num8 = (num7 = smethod_224(ref struct31_));
									num9 = ((num8 <= 0) ? (-1380556961) : (-1929564752));
									num = num9 ^ ((int)num3 * -1469459848);
									continue;
								case 16u:
									array3 = (array2 = array);
									num = ((array3 != null) ? 1561284411 : 1837341141);
									continue;
								case 15u:
									num13 = BitConverter.ToInt32(array, num5 + 1);
									num = 1294299805;
									continue;
								case 13u:
									@struct = new Struct31
									{
										uint_1 = 64u
									};
									num = 1127138750;
									continue;
								case 12u:
									array = class86_0.method_10<byte>(intPtr, 48);
									num5 = smethod_419(array, "WATAUAVAWH\u0081ì\0\0\0\0H\u008B\u0005", "xxxxxxxxxxxx????xxx", 0);
									num = (Class127.bool_7 ? 1177915201 : 602401373);
									continue;
								case 11u:
									num = ((!(struct31_.struct27_0.method_0() == "call ")) ? 1480824025 : 1159400702);
									continue;
								case 10u:
									num = ((num5 == -1) ? 1788914984 : 2022509579);
									continue;
								case 9u:
									num5 = smethod_378(array, "A±\u0001", 0);
									num = ((int)num3 * -407541822) ^ 0x215460ED;
									continue;
								case 8u:
									num12 = ((array2.Length != 0) ? (-273900134) : (-138484547));
									num = num12 ^ (int)(num3 * 1269116660);
									continue;
								case 7u:
									num = ((struct31_.pByte_0 >= ptr2) ? 2132406143 : 57255653);
									continue;
								case 6u:
									num10 = ((num5 != -1) ? 1069380215 : 980083529);
									num = num10 ^ (int)(num3 * 1659249783);
									continue;
								case 5u:
									ptr2 = ptr + array.Length;
									num = ((int)num3 * -571244627) ^ 0x23C0A333;
									continue;
								case 3u:
									num6 = (((ulong)(long)intPtr < (ulong)((long)intPtr + gclass1_0.method_4())) ? 928936981 : 1819509570);
									num = num6 ^ ((int)num3 * -1828000378);
									continue;
								case 2u:
									goto end_IL_0109;
								case 1u:
									num5 = (int)(struct31_.pByte_0 - ptr);
									num = (int)(num3 * 294035196) ^ -1187565285;
									continue;
								case 0u:
									num4 = ((num5 == -1) ? 2114420497 : 1045825226);
									num = num4 ^ (int)(num3 * 1032595841);
									continue;
								case 27u:
									num = 956025620;
									continue;
								case 4u:
									throw new MissingMethodException("Unable to find call to LdrpLoadDll function inside LdrLoadDll.");
								case 17u:
									throw new MissingMethodException("The function thought to be LdrpLoadDll is outside ntdll.dll.");
								case 21u:
									throw new MissingMethodException("Unable to verify the guessed function is LdrpLoadDll.");
								case 29u:
									throw new InvalidOperationException("Unable to find signature for LdrpLoadDll.");
								default:
									return intPtr;
								}
								break;
							}
						}
						goto case 26u;
						continue;
						end_IL_0109:
						break;
					}
					goto case 2u;
				case 18u:
					num8 = (num7 = smethod_224(ref struct31_));
					num9 = ((num8 <= 0) ? (-1380556961) : (-1929564752));
					num = num9 ^ ((int)num3 * -1469459848);
					continue;
				case 16u:
					array3 = (array2 = array);
					num = ((array3 != null) ? 1561284411 : 1837341141);
					continue;
				case 15u:
					num13 = BitConverter.ToInt32(array, num5 + 1);
					num = 1294299805;
					continue;
				case 13u:
					@struct = new Struct31
					{
						uint_1 = 64u
					};
					num = 1127138750;
					continue;
				case 12u:
					array = class86_0.method_10<byte>(intPtr, 48);
					num5 = smethod_419(array, "WATAUAVAWH\u0081ì\0\0\0\0H\u008B\u0005", "xxxxxxxxxxxx????xxx", 0);
					num = (Class127.bool_7 ? 1177915201 : 602401373);
					continue;
				case 11u:
					num = ((!(struct31_.struct27_0.method_0() == "call ")) ? 1480824025 : 1159400702);
					continue;
				case 10u:
					num = ((num5 == -1) ? 1788914984 : 2022509579);
					continue;
				case 9u:
					num5 = smethod_378(array, "A±\u0001", 0);
					num = ((int)num3 * -407541822) ^ 0x215460ED;
					continue;
				case 8u:
					num12 = ((array2.Length != 0) ? (-273900134) : (-138484547));
					num = num12 ^ (int)(num3 * 1269116660);
					continue;
				case 7u:
					num = ((struct31_.pByte_0 >= ptr2) ? 2132406143 : 57255653);
					continue;
				case 6u:
					num10 = ((num5 != -1) ? 1069380215 : 980083529);
					num = num10 ^ (int)(num3 * 1659249783);
					continue;
				case 5u:
					ptr2 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + array.Length;
					num = ((int)num3 * -571244627) ^ 0x23C0A333;
					continue;
				case 3u:
					num6 = (((ulong)(long)intPtr < (ulong)((long)intPtr + gclass1_0.method_4())) ? 928936981 : 1819509570);
					num = num6 ^ ((int)num3 * -1828000378);
					continue;
				case 2u:
					reference = ref *(byte*)null;
					num = 605535980;
					continue;
				case 1u:
					num5 = (int)(struct31_.pByte_0 - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
					num = (int)(num3 * 294035196) ^ -1187565285;
					continue;
				case 0u:
					num4 = ((num5 == -1) ? 2114420497 : 1045825226);
					num = num4 ^ (int)(num3 * 1032595841);
					continue;
				case 27u:
					break;
				case 4u:
					throw new MissingMethodException("Unable to find call to LdrpLoadDll function inside LdrLoadDll.");
				case 17u:
					throw new MissingMethodException("The function thought to be LdrpLoadDll is outside ntdll.dll.");
				case 21u:
					throw new MissingMethodException("Unable to verify the guessed function is LdrpLoadDll.");
				case 29u:
					throw new InvalidOperationException("Unable to find signature for LdrpLoadDll.");
				default:
					return intPtr;
				}
				break;
			}
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int GetWindowTextLength(IntPtr intptr_0);

	internal static void smethod_336(Class47 class47_0)
	{
		if (class47_0.bool_0)
		{
			goto IL_0025;
		}
		goto IL_004f;
		IL_0025:
		int num = -1459123326;
		goto IL_002a;
		IL_002a:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -323810449)) % 5)
			{
			case 4u:
				smethod_439(class47_0.class53_0, 0u);
				num = ((int)num2 * -1087769558) ^ 0x5D3F4CC2;
				continue;
			case 2u:
				break;
			default:
				return;
			case 1u:
				goto IL_004f;
			case 0u:
				return;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0025;
		IL_004f:
		smethod_269(class47_0.class53_0, 0L);
		num = -1589330783;
		goto IL_002a;
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	internal static extern uint NtQuerySystemInformation(Class124.Enum24 enum24_0, IntPtr intptr_0, int int_0, out int int_1);

	internal static bool smethod_337(MainForm mainForm, string string_0, string string_1, string string_2, bool bool_0, string string_3)
	{
		if (bool_0)
		{
			goto IL_00c5;
		}
		goto IL_0102;
		IL_00c5:
		int num = 84938991;
		goto IL_00ca;
		IL_00ca:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0xCF75D19)) % 6)
			{
			case 2u:
				num = ((MessageBox.Show(mainForm, "The DLL you have selected, \"" + string_0 + "\" requires \"" + string_1 + "\" in order to work properly but it appears you have an incorrect version installed. In order to fix this, you need to delete \"" + string_2 + "\" (check carefully) and then re-install the " + string_3 + ". Would you like to install the " + string_3 + " now?", "Extreme Injector v3", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes) ? (-972875680) : (-1020958494)) ^ ((int)num2 * -275383844);
				continue;
			case 0u:
				break;
			case 4u:
				goto IL_0102;
			default:
				return true;
			case 3u:
				return false;
			case 5u:
				return false;
			}
			break;
		}
		goto IL_00c5;
		IL_0102:
		num = ((MessageBox.Show(mainForm, "The DLL you have selected, \"" + string_0 + "\" requires \"" + string_1 + "\" in order to work properly but it appears you have not installed the required files. Would you like to install the " + string_3 + "?", "Extreme Injector v3", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes) ? 1866094268 : 1156328842);
		goto IL_00ca;
	}

	internal static uint smethod_338(Class62 class62_0)
	{
		return smethod_188(class62_0).uint_1;
	}

	internal static void smethod_339(Class20 class20_0, WebResponse webResponse_0)
	{
		HttpWebResponse httpWebResponse = webResponse_0 as HttpWebResponse;
		if (httpWebResponse == null)
		{
			goto IL_000a;
		}
		goto IL_002e;
		IL_000a:
		int num = 387608055;
		goto IL_000f;
		IL_000f:
		CookieCollection cookies = default(CookieCollection);
		switch ((uint)(num ^ 0x477F8669) % 4u)
		{
		case 3u:
			break;
		case 1u:
			goto IL_002e;
		default:
			class20_0.method_0().Add(cookies);
			return;
		case 2u:
			return;
		}
		goto IL_000a;
		IL_002e:
		cookies = httpWebResponse.Cookies;
		num = 1216624305;
		goto IL_000f;
	}

	internal static bool smethod_340(string string_0, int int_0, byte[] byte_0)
	{
		if (int_0 + string_0.Length > byte_0.Length)
		{
			goto IL_0010;
		}
		goto IL_0098;
		IL_0010:
		int num = 1936663603;
		goto IL_0069;
		IL_0069:
		int num2 = default(int);
		while (true)
		{
			switch ((uint)(num ^ 0x5F7229D) % 8u)
			{
			case 5u:
				break;
			case 3u:
				num2++;
				num = 356993700;
				continue;
			case 1u:
				goto IL_0022;
			case 0u:
				goto IL_0044;
			case 7u:
				goto IL_0098;
			default:
				return true;
			case 4u:
				return false;
			case 6u:
				return false;
			}
			break;
			IL_0044:
			num = ((byte_0[int_0 + num2] == string_0[num2]) ? 426322790 : 1810114433);
			continue;
			IL_0022:
			num = ((num2 >= string_0.Length) ? 1015790159 : 1957325589);
		}
		goto IL_0010;
		IL_0098:
		num2 = 0;
		num = 356993700;
		goto IL_0069;
	}

	internal static void smethod_341()
	{
		smethod_34("SeDebugPrivilege");
	}

	internal static bool smethod_342(ModuleOptionsForm form0_0, string string_0, Enum5 enum5_0, bool bool_0)
	{
		string string_1 = default(string);
		int num;
		string string_3 = default(string);
		string string_4 = default(string);
		string string_2 = default(string);
		bool flag2 = default(bool);
		bool flag3;
		uint result9;
		bool flag4;
		ushort result10;
		switch (enum5_0)
		{
		case Enum5.QWORD:
			string_1 = string_0;
			num = 617349255;
			goto IL_002b;
		default:
			goto IL_0113;
		case Enum5.BYTE:
			goto IL_0154;
		case Enum5.DWORD:
			goto IL_0235;
		case Enum5.WORD:
			goto IL_0347;
		case Enum5.LPCSTR:
		case Enum5.LPCWSTR:
			goto IL_038a;
			IL_002b:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3D90D2E3)) % 24)
				{
				case 23u:
					break;
				case 21u:
				{
					num = (sbyte.TryParse(string_3, out var _) ? (-694853176) : (-1073503255)) ^ (int)(num2 * 371918870);
					continue;
				}
				case 20u:
					num = (int)((num2 * 858045942) ^ 0x3EA9D554);
					continue;
				case 19u:
				{
					num = ((!long.TryParse(string_1, out var _)) ? (-2111857770) : (-1480684005)) ^ (int)(num2 * 169385271);
					continue;
				}
				case 18u:
					goto IL_0113;
				case 17u:
					form0_0.method_0().Parameters.Add(new ExportParameter
					{
						Type = (Enum5)form0_0.comboBox_2.SelectedIndex,
						Value = string_0
					});
					num = 660552184;
					continue;
				case 16u:
					goto IL_0154;
				case 15u:
					goto IL_016b;
				case 14u:
					form0_0.method_0().Parameters = new List<ExportParameter>();
					num = (int)((num2 * 746177784) ^ 0xF0A0ECA);
					continue;
				case 11u:
					goto IL_01d0;
				case 10u:
					num = ((form0_0.method_0().Parameters != null) ? (-322189534) : (-1727077499)) ^ ((int)num2 * -684848276);
					continue;
				case 9u:
					goto IL_0235;
				case 8u:
				{
					num = ((!int.TryParse(string_4, out var _)) ? 1746011596 : 2052809590) ^ ((int)num2 * -790560600);
					continue;
				}
				case 6u:
				{
					num = (short.TryParse(string_2, out var _) ? 1145038720 : 1891523568) ^ (int)(num2 * 1198967497);
					continue;
				}
				case 4u:
					goto IL_02d8;
				case 2u:
				{
					num = ((!char.TryParse(string_0, out var _)) ? (-2054104040) : (-967780434)) ^ (int)(num2 * 1293683084);
					continue;
				}
				case 1u:
					goto IL_0347;
				case 13u:
					goto IL_038a;
				case 0u:
					return false;
				default:
					return true;
				case 5u:
					return false;
				case 7u:
					return false;
				case 12u:
					return false;
				case 22u:
					return false;
				}
				break;
				IL_02d8:
				bool flag = smethod_139(ref string_1, form0_0, string_1);
				num = ((!ulong.TryParse(string_1, flag ? NumberStyles.HexNumber : NumberStyles.None, null, out var _)) ? 990579736 : 528111862);
				continue;
				IL_01d0:
				num = (byte.TryParse(string_3, flag2 ? NumberStyles.HexNumber : NumberStyles.None, null, out var _) ? 528111862 : 936894686);
				continue;
				IL_016b:
				num = (float.TryParse(string_0, out var _) ? 528111862 : 2020286037);
			}
			goto case Enum5.QWORD;
			IL_038a:
			form0_0.dataGridView_0.Rows.Add(null, form0_0.comboBox_2.Items[(int)enum5_0].ToString(), string_0);
			num = ((!bool_0) ? 660552184 : 402604281);
			goto IL_002b;
			IL_0235:
			string_4 = string_0;
			flag3 = smethod_139(ref string_4, form0_0, string_4);
			num = ((!uint.TryParse(string_4, flag3 ? NumberStyles.HexNumber : NumberStyles.None, null, out result9)) ? 1025648467 : 528111862);
			goto IL_002b;
			IL_0154:
			string_3 = string_0;
			flag2 = smethod_139(ref string_3, form0_0, string_3);
			num = 463231825;
			goto IL_002b;
			IL_0347:
			string_2 = string_0;
			flag4 = smethod_139(ref string_2, form0_0, string_2);
			num = (ushort.TryParse(string_2, flag4 ? NumberStyles.HexNumber : NumberStyles.None, null, out result10) ? 528111862 : 1490647589);
			goto IL_002b;
			IL_0113:
			num = 179109175;
			goto IL_002b;
		}
	}

	internal unsafe static int smethod_343(byte[] byte_0, string string_0, int int_0)
	{
		return IndexOfByteString(byte_0, string_0, int_0);
#if false
		//The blocks IL_0015, IL_0025, IL_002b, IL_0037, IL_0041, IL_0050, IL_0070, IL_0072, IL_007c, IL_0092, IL_0097, IL_00a3, IL_00ad, IL_00bc, IL_00e7, IL_00f1, IL_00f7, IL_0103, IL_0113, IL_012e, IL_0136, IL_0142, IL_0152, IL_0158, IL_0164, IL_0174, IL_0183, IL_0186, IL_019a, IL_019d, IL_01a9, IL_01b3, IL_01bf, IL_01ca, IL_01ef, IL_0200, IL_0273, IL_0282, IL_028c, IL_0293, IL_029d are reachable both inside and outside the pinned region starting at IL_00dc. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0015, IL_0025, IL_002b, IL_0037, IL_0041, IL_0050, IL_007c, IL_0092, IL_0097, IL_00a3, IL_00ad, IL_00bc, IL_00e7, IL_00f1, IL_00f7, IL_0103, IL_0113, IL_012e, IL_0136, IL_0142, IL_0152, IL_0158, IL_0164, IL_0186, IL_019a, IL_019d, IL_01a9, IL_01b3, IL_01bf, IL_01ca, IL_01ef, IL_0200, IL_0273, IL_0282, IL_028c, IL_0293, IL_029d are reachable both inside and outside the pinned region starting at IL_0071. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if (int_0 + string_0.Length > byte_0.Length)
		{
			goto IL_00e7;
		}
		goto IL_0282;
		IL_00e7:
		int num = -1537406695;
		goto IL_0200;
		IL_0200:
		byte* ptr3 = default(byte*);
		byte* ptr7 = default(byte*);
		ref byte reference = default(ref byte);
		char* ptr6 = default(char*);
		byte[] array = default(byte[]);
		byte* ptr = default(byte*);
		byte* ptr2 = default(byte*);
		byte* ptr4 = default(byte*);
		byte* ptr5 = default(byte*);
		byte[] array2;
		while (true)
		{
			uint num3;
			uint num2 = (num3 = (uint)(num ^ -759416851));
			int num5;
			int num6;
			int num4;
			switch (num2 % 24)
			{
			case 23u:
				num5 = ((ptr3 == ptr7) ? 1832194556 : 1376663040);
				num = num5 ^ (int)(num3 * 638597496);
				continue;
			case 22u:
				num = ((int)num3 * -183013126) ^ -1743205869;
				continue;
			case 21u:
				reference = ref *(byte*)null;
				num = -1872760679;
				continue;
			case 20u:
				text = string_0;
				num = -751094330;
				continue;
			case 19u:
				ptr6 = (char*)(nint)text;
				num = (int)(num3 * 647211380) ^ -1127220318;
				continue;
			case 18u:
				num6 = ((array.Length == 0) ? 1128946194 : 1830948792);
				num = num6 ^ ((int)num3 * -1120293511);
				continue;
			case 17u:
				ptr++;
				num = (int)(num3 * 1675944968) ^ -1857139166;
				continue;
			case 15u:
				while (true)
				{
					IL_00d5:
					fixed (byte* ptr8 = &array[0])
					{
						num = -1872760679;
						while (true)
						{
							num2 = (num3 = (uint)(num ^ -759416851));
							switch (num2 % 24)
							{
							case 21u:
								break;
							case 23u:
								num5 = ((ptr3 == ptr7) ? 1832194556 : 1376663040);
								num = num5 ^ (int)(num3 * 638597496);
								continue;
							case 22u:
								num = ((int)num3 * -183013126) ^ -1743205869;
								continue;
							case 20u:
								while (true)
								{
									IL_0070:
									fixed (string text = string_0)
									{
										num = -751094330;
										while (true)
										{
											num2 = (num3 = (uint)(num ^ -759416851));
											switch (num2 % 24)
											{
											case 21u:
												break;
											case 23u:
												num5 = ((ptr3 == ptr7) ? 1832194556 : 1376663040);
												num = num5 ^ (int)(num3 * 638597496);
												continue;
											case 22u:
												num = ((int)num3 * -183013126) ^ -1743205869;
												continue;
											case 20u:
												goto IL_0070;
											case 19u:
												ptr6 = (char*)(nint)text;
												num = (int)(num3 * 647211380) ^ -1127220318;
												continue;
											case 18u:
												num6 = ((array.Length == 0) ? 1128946194 : 1830948792);
												num = num6 ^ ((int)num3 * -1120293511);
												continue;
											case 17u:
												ptr++;
												num = (int)(num3 * 1675944968) ^ -1857139166;
												continue;
											case 15u:
												goto end_IL_0070;
											case 14u:
												num = -1537406695;
												continue;
											case 13u:
												num = ((ptr2 == ptr4) ? (-1308023867) : (-1706889121));
												continue;
											case 12u:
												ptr6 = (char*)((byte*)ptr6 + RuntimeHelpers.OffsetToStringData);
												num = ((int)num3 * -836340733) ^ -2115463072;
												continue;
											case 10u:
												num = ((*ptr2 != *ptr3) ? (-1476676076) : (-1049738427));
												continue;
											case 7u:
												num = ((ptr == ptr4) ? (-421979101) : (-893132001));
												continue;
											case 6u:
												goto IL_0174;
											case 5u:
												ptr3 = ptr5;
												num = ((int)num3 * -1736285284) ^ 0x256E601F;
												continue;
											case 3u:
												num4 = ((ptr6 != null) ? 1837604076 : 131795305);
												num = num4 ^ ((int)num3 * -376893721);
												continue;
											case 2u:
												ptr2 = ptr;
												num = -1506476288;
												continue;
											case 1u:
												ptr = ptr8 + int_0;
												ptr4 = ptr8 + byte_0.Length;
												ptr5 = (byte*)ptr6;
												ptr7 = (byte*)ptr6 + (nint)string_0.Length * (nint)2;
												num = -141582870;
												continue;
											case 0u:
												ptr2++;
												ptr3 += 2;
												num = -2082197718;
												continue;
											case 11u:
												array2 = (array = byte_0);
												num = ((array2 != null) ? (-95372641) : (-1735606544));
												continue;
											case 4u:
												return -1;
											default:
												goto end_IL_00d5;
											case 9u:
												return (int)(ptr - ptr8);
											case 16u:
												return -1;
											}
											break;
										}
									}
									goto end_IL_020c;
									continue;
									end_IL_0070:
									break;
								}
								goto IL_00d5;
							case 19u:
								ptr6 = (char*)(nint)text;
								num = (int)(num3 * 647211380) ^ -1127220318;
								continue;
							case 18u:
								num6 = ((array.Length == 0) ? 1128946194 : 1830948792);
								num = num6 ^ ((int)num3 * -1120293511);
								continue;
							case 17u:
								ptr++;
								num = (int)(num3 * 1675944968) ^ -1857139166;
								continue;
							case 15u:
								goto IL_00d5;
							case 14u:
								num = -1537406695;
								continue;
							case 13u:
								num = ((ptr2 == ptr4) ? (-1308023867) : (-1706889121));
								continue;
							case 12u:
								ptr6 = (char*)((byte*)ptr6 + RuntimeHelpers.OffsetToStringData);
								num = ((int)num3 * -836340733) ^ -2115463072;
								continue;
							case 10u:
								num = ((*ptr2 != *ptr3) ? (-1476676076) : (-1049738427));
								continue;
							case 7u:
								num = ((ptr == ptr4) ? (-421979101) : (-893132001));
								continue;
							case 6u:
								goto IL_0174;
							case 5u:
								ptr3 = ptr5;
								num = ((int)num3 * -1736285284) ^ 0x256E601F;
								continue;
							case 3u:
								num4 = ((ptr6 != null) ? 1837604076 : 131795305);
								num = num4 ^ ((int)num3 * -376893721);
								continue;
							case 2u:
								ptr2 = ptr;
								num = -1506476288;
								continue;
							case 1u:
								ptr = ptr8 + int_0;
								ptr4 = ptr8 + byte_0.Length;
								ptr5 = (byte*)ptr6;
								ptr7 = (byte*)ptr6 + (nint)string_0.Length * (nint)2;
								num = -141582870;
								continue;
							case 0u:
								ptr2++;
								ptr3 += 2;
								num = -2082197718;
								continue;
							case 11u:
								array2 = (array = byte_0);
								num = ((array2 != null) ? (-95372641) : (-1735606544));
								continue;
							case 4u:
								return -1;
							default:
								goto end_IL_00d5;
							case 9u:
								return (int)(ptr - ptr8);
							case 16u:
								{
									return -1;
								}
								IL_0174:
								text = null;
								num = ((int)num3 * -1078758850) ^ -823171879;
								continue;
								end_IL_020c:
								break;
							}
							break;
						}
					}
					goto case 21u;
					continue;
					end_IL_00d5:
					break;
				}
				goto default;
			case 14u:
				break;
			case 13u:
				goto IL_00f1;
			case 12u:
				ptr6 = (char*)((byte*)ptr6 + RuntimeHelpers.OffsetToStringData);
				num = ((int)num3 * -836340733) ^ -2115463072;
				continue;
			case 10u:
				goto IL_012e;
			case 7u:
				goto IL_0152;
			case 6u:
				text = null;
				num = ((int)num3 * -1078758850) ^ -823171879;
				continue;
			case 5u:
				ptr3 = ptr5;
				num = ((int)num3 * -1736285284) ^ 0x256E601F;
				continue;
			case 3u:
				num4 = ((ptr6 != null) ? 1837604076 : 131795305);
				num = num4 ^ ((int)num3 * -376893721);
				continue;
			case 2u:
				ptr2 = ptr;
				num = -1506476288;
				continue;
			case 1u:
				ptr = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + int_0;
				ptr4 = (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference) + byte_0.Length;
				ptr5 = (byte*)ptr6;
				ptr7 = (byte*)ptr6 + (nint)string_0.Length * (nint)2;
				num = -141582870;
				continue;
			case 0u:
				ptr2++;
				ptr3 += 2;
				num = -2082197718;
				continue;
			case 11u:
				goto IL_0282;
			case 4u:
				return -1;
			default:
				reference = ref *(byte*)null;
				return -1;
			case 9u:
				return (int)(ptr - (byte*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			case 16u:
				return -1;
			}
			break;
			IL_0152:
			num = ((ptr == ptr4) ? (-421979101) : (-893132001));
			continue;
			IL_012e:
			num = ((*ptr2 != *ptr3) ? (-1476676076) : (-1049738427));
			continue;
			IL_00f1:
			num = ((ptr2 == ptr4) ? (-1308023867) : (-1706889121));
		}
		goto IL_00e7;
		IL_0282:
		array2 = (array = byte_0);
		num = ((array2 != null) ? (-95372641) : (-1735606544));
		goto IL_0200;
#endif
	}

	internal static Class57 smethod_344(short short_0)
	{
		return new Class57((IntPtr)short_0);
	}

	internal static string smethod_345(string string_0, Exception exception_0, bool bool_0)
	{
		Type type = exception_0.GetType();
		string text = default(string);
		while (true)
		{
			int num = -1755716187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -996110060)) % 9)
				{
				case 7u:
					text = text + type.FullName + ": " + exception_0.Message;
					num = -842379024;
					continue;
				case 5u:
					num = ((!text.EndsWith(".")) ? 1804667958 : 765113376) ^ ((int)num2 * -1012018073);
					continue;
				case 3u:
					text += ".";
					num = ((int)num2 * -589952584) ^ 0x3B93A10C;
					continue;
				case 2u:
					num = ((exception_0.InnerException == null) ? (-1413268292) : (-991308870));
					continue;
				case 1u:
					text = string_0;
					num = (bool_0 ? 697253933 : 1460972286) ^ (int)(num2 * 385945033);
					continue;
				case 0u:
					text += "\n\n";
					num = ((int)num2 * -1982244131) ^ -1194903865;
					continue;
				case 6u:
					break;
				default:
					return smethod_345(text + "\n\n", exception_0.InnerException, bool_0: false);
				case 8u:
					return text;
				}
				break;
			}
		}
	}

	internal static void smethod_346(IntPtr intptr_0)
	{
		Class169.Struct64[] array = Class169.smethod_0<Class169.Struct65, Class169.Struct64>(intptr_0);
		int num4 = default(int);
		string key = default(string);
		List<string> list = default(List<string>);
		string text = default(string);
		int num3 = default(int);
		Class169.Struct62[] array2 = default(Class169.Struct62[]);
		Class169.Struct62 struct2 = default(Class169.Struct62);
		Class169.Struct64 @struct = default(Class169.Struct64);
		while (true)
		{
			int num = -228169995;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -269218673)) % 17)
				{
				case 16u:
					num4++;
					num = (int)(num2 * 1695917076) ^ -969580007;
					continue;
				case 15u:
					Class169.dictionary_0.Add(key, list);
					num = (int)(num2 * 1116886859) ^ -2145043140;
					continue;
				case 14u:
					num = (string.IsNullOrEmpty(text) ? (-2139125076) : (-946683873)) ^ ((int)num2 * -700612590);
					continue;
				case 13u:
					list.Add(text);
					num = (int)(num2 * 509548331) ^ -890690412;
					continue;
				case 12u:
					num4 = 0;
					num = ((int)num2 * -1033921483) ^ -728719377;
					continue;
				case 11u:
					num = ((num3 >= array2.Length) ? (-1613212191) : (-1701311274));
					continue;
				case 10u:
					num = ((num4 < array.Length) ? (-490908214) : (-191437907));
					continue;
				case 9u:
					text = Marshal.PtrToStringUni(intptr_0.smethod_9(struct2.uint_3), (int)(struct2.uint_4 / 2));
					num = (int)((num2 * 221661978) ^ 0x6B0FF991);
					continue;
				case 8u:
					struct2 = array2[num3];
					num = -1564266221;
					continue;
				case 6u:
					@struct = array[num4];
					num = -189715202;
					continue;
				case 5u:
					num3 = 0;
					num = ((int)num2 * -1747981098) ^ 0x18C701CC;
					continue;
				case 3u:
					list = new List<string>();
					num = (int)((num2 * 1613305807) ^ 0x4400BF51);
					continue;
				case 2u:
					num = ((int)num2 * -6844630) ^ 0x23E17EEE;
					continue;
				case 1u:
					num3++;
					num = -1465335944;
					continue;
				case 0u:
					key = Marshal.PtrToStringUni(intptr_0.smethod_9(@struct.uint_1), (int)(@struct.uint_2 / 2)).ToLowerInvariant();
					array2 = Class169.smethod_0<Class169.Struct63, Class169.Struct62>(intptr_0.smethod_9(@struct.uint_5));
					num = (int)((num2 * 493902270) ^ 0xF2106DB);
					continue;
				default:
					return;
				case 4u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_347(Class53 class53_0)
	{
		smethod_31(class53_0, Enum7.const_502);
	}

	[DllImport("ntdll.dll")]
	internal static extern uint RtlGetVersion(ref Class124.Struct38 struct38_0);

	internal static bool smethod_348(Class179.Class180 class180_0)
	{
		int num = smethod_14(class180_0.class182_0);
		int num4 = default(int);
		int num6 = default(int);
		int int_ = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = ((num < 258) ? 763319921 : 1160327810);
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0xFD9D10E)) % 34)
				{
				case 33u:
					class180_0.class183_1 = null;
					num2 = 577513338;
					continue;
				case 32u:
					class180_0.int_4 = 9;
					num2 = 1743734130;
					continue;
				case 31u:
					num2 = ((num4 >= 0) ? 627331638 : 1661256961) ^ (int)(num3 * 327633403);
					continue;
				case 30u:
					class180_0.int_6 = Class179.Class180.int_0[num4 - 257];
					class180_0.int_5 = Class179.Class180.int_1[num4 - 257];
					num2 = 557491619;
					continue;
				case 29u:
					num6 = smethod_60(class180_0.class181_0, class180_0.int_5);
					num2 = ((num6 < 0) ? (-2142351955) : (-1087205975)) ^ (int)(num3 * 57578442);
					continue;
				case 27u:
					class180_0.int_4 = 10;
					num2 = (int)((num3 * 1631180901) ^ 0x237934E8);
					continue;
				case 26u:
					num2 = ((((num4 = smethod_96(class180_0.class183_0, class180_0.class181_0)) & -256) != 0) ? 443705541 : 1681283153);
					continue;
				case 25u:
					num2 = 1160327810;
					continue;
				case 24u:
					smethod_132(class180_0.class182_0, class180_0.int_6, class180_0.int_7);
					num -= class180_0.int_6;
					num2 = 585707809;
					continue;
				case 23u:
					class180_0.int_7 += num6;
					num2 = ((int)num3 * -710629906) ^ -1825613888;
					continue;
				case 22u:
					goto IL_017f;
				case 21u:
					switch (int_)
					{
					case 7:
						break;
					case 9:
						goto IL_017f;
					default:
						goto IL_01b4;
					case 8:
						goto IL_01c7;
					case 10:
						goto IL_01ec;
					}
					goto case 26u;
				case 1u:
					goto IL_01c7;
				case 16u:
					goto IL_01ec;
				case 20u:
					class180_0.int_7 = Class179.Class180.int_2[num4];
					class180_0.int_5 = Class179.Class180.int_3[num4];
					num2 = 1737455134;
					continue;
				case 19u:
					num2 = ((num4 < 257) ? 1923460237 : 1404177172) ^ ((int)num3 * -1944184838);
					continue;
				case 18u:
					int_ = class180_0.int_4;
					num2 = 536257933;
					continue;
				case 17u:
					smethod_77(class180_0.class182_0, num4);
					num2 = ((--num < 258) ? 2136181693 : 1521823804);
					continue;
				case 14u:
					class180_0.int_6 += num5;
					num2 = (int)((num3 * 361324795) ^ 0x1DEFBD26);
					continue;
				case 13u:
					smethod_396(class180_0.class181_0, class180_0.int_5);
					num2 = 1212664481;
					continue;
				case 12u:
					smethod_396(class180_0.class181_0, class180_0.int_5);
					num2 = 1026482512;
					continue;
				case 11u:
					num5 = smethod_60(class180_0.class181_0, class180_0.int_5);
					num2 = ((num5 >= 0) ? (-1673683693) : (-1861683763)) ^ ((int)num3 * -2014024301);
					continue;
				case 7u:
					class180_0.int_4 = 7;
					num2 = (int)((num3 * 820425283) ^ 0x38B854BD);
					continue;
				case 6u:
					num2 = ((int)num3 * -1080952740) ^ 0x308BEE0;
					continue;
				case 4u:
					class180_0.int_4 = 8;
					num2 = (int)((num3 * 813207140) ^ 0x47CE7C87);
					continue;
				case 2u:
					num2 = ((num4 < 0) ? (-1833661905) : (-404843388)) ^ (int)(num3 * 849433045);
					continue;
				case 8u:
					break;
				case 0u:
					return false;
				default:
					return true;
				case 5u:
					return false;
				case 9u:
					return true;
				case 10u:
					class180_0.class183_0 = null;
					class180_0.int_4 = 2;
					return true;
				case 15u:
					return false;
				case 28u:
					{
						return false;
					}
					IL_01c7:
					num2 = ((class180_0.int_5 > 0) ? 886495452 : 1596068108);
					continue;
					IL_017f:
					num4 = smethod_96(class180_0.class183_1, class180_0.class181_0);
					num2 = 856621872;
					continue;
					IL_01b4:
					num2 = (int)(num3 * 854322245) ^ -71163683;
					continue;
					IL_01ec:
					num2 = ((class180_0.int_5 <= 0) ? 1088344178 : 220059203);
					continue;
				}
				break;
			}
		}
	}

	[DllImport("ntdll.dll")]
	internal static extern uint NtCreateThreadEx(out IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3, uint uint_4, IntPtr intptr_5);

	[DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
	internal static extern long StrFormatByteSize(long long_0, StringBuilder stringBuilder_0, int int_0);

	internal static void AddModuleToGrid(bool bool_0, ModuleEntry class16_0, bool bool_1, MainForm mainForm, string string_0)
	{
		if (!File.Exists(string_0))
		{
			return;
		}
		try
		{
			string_0 = Path.GetFullPath(string_0);
			IEnumerator enumerator = ((IEnumerable)mainForm.moduleGrid.Rows).GetEnumerator();
			try
			{
				while (true)
				{
					IL_00b3:
					int num = ((!enumerator.MoveNext()) ? 1805172656 : 1770609057);
					while (true)
					{
						switch ((uint)(num ^ 0x866414E) % 5u)
						{
						case 4u:
							num = ((!GetModulePath((MainForm.ModuleRow)((DataGridViewRow)enumerator.Current).Tag).Equals(string_0, StringComparison.OrdinalIgnoreCase)) ? 799792168 : 2026028820);
							continue;
						case 2u:
							num = 1770609057;
							continue;
						default:
							goto end_IL_0081;
						case 3u:
							break;
						case 0u:
							return;
						case 1u:
							goto end_IL_0081;
						}
						goto IL_00b3;
						continue;
						end_IL_0081:
						break;
					}
					break;
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					while (true)
					{
						IL_0105:
						int num2 = 672721271;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num2 ^ 0x866414E)) % 3)
							{
							case 2u:
								goto IL_00d3;
							default:
								goto end_IL_00e7;
							case 0u:
								break;
							case 1u:
								goto end_IL_00e7;
							}
							goto IL_0105;
							IL_00d3:
							disposable.Dispose();
							num2 = ((int)num3 * -2088883914) ^ 0x7C4CD845;
							continue;
							end_IL_00e7:
							break;
						}
						break;
					}
				}
			}
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				Class154 @class = Class7.smethod_13(fileStream, string_0, bool_0: false, Enum39.const_0);
				while (true)
				{
					int num4 = 238007801;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num4 ^ 0x866414E)) % 5)
						{
						case 2u:
							num4 = (((@class.method_6().method_1().method_12() & Enum36.flag_12) == 0) ? 50222542 : 1402057418) ^ ((int)num3 * -1580869357);
							continue;
						case 1u:
							num4 = ((@class != null) ? (-2016711633) : (-1977205797)) ^ (int)(num3 * 1911030097);
							continue;
						case 0u:
							break;
						default:
						{
							try
							{
								smethod_261(@class, mainForm);
							}
							catch
							{
							}
							int index = mainForm.moduleGrid.Rows.Add(bool_0, Path.GetFileName(string_0));
							MainForm.ModuleRow class2 = new MainForm.ModuleRow(class16_0);
							SetModulePath(class2, string_0);
							MainForm.ModuleRow class3 = class2;
							while (true)
							{
								int num5 = 1051019898;
								while (true)
								{
									switch ((num3 = (uint)(num5 ^ 0x866414E)) % 7)
									{
									case 6u:
									ApplicationSettings.Current.Modules.Add(class3.Entry);
										num5 = (int)(num3 * 215100400) ^ -1017146116;
										continue;
									case 4u:
										mainForm.moduleGrid.Rows[index].Cells[1].ToolTipText = string_0;
										num5 = ((int)num3 * -2092943264) ^ 0x6D42C324;
										continue;
									case 2u:
										mainForm.moduleGrid.Rows[index].Cells[2].ToolTipText = "Advanced Options";
										num5 = (int)(num3 * 1574833161) ^ -1295596495;
										continue;
									case 1u:
										mainForm.moduleGrid.Rows[index].Tag = class3;
										num5 = ((int)num3 * -582582098) ^ -1659388458;
										continue;
									case 0u:
										num5 = ((class16_0 != null) ? 624043475 : 1252711972) ^ ((int)num3 * -1268485357);
										continue;
									default:
										return;
									case 5u:
										break;
									case 3u:
										return;
									}
									break;
								}
							}
						}
						case 4u:
							throw new Exception();
						}
						break;
					}
				}
			}
			finally
			{
				if (fileStream != null)
				{
					while (true)
					{
						IL_035b:
						int num6 = 1354921154;
						while (true)
						{
							uint num3;
							switch ((num3 = (uint)(num6 ^ 0x866414E)) % 3)
							{
							case 1u:
								goto IL_0329;
							default:
								goto end_IL_033d;
							case 0u:
								break;
							case 2u:
								goto end_IL_033d;
							}
							goto IL_035b;
							IL_0329:
							((IDisposable)fileStream).Dispose();
							num6 = ((int)num3 * -1141373183) ^ -1625511716;
							continue;
							end_IL_033d:
							break;
						}
						break;
					}
				}
			}
		}
		catch (Exception)
		{
			if (!bool_1)
			{
				return;
			}
			while (true)
			{
				int num7 = 2073976462;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num7 ^ 0x866414E)) % 3)
					{
					case 1u:
						goto IL_036b;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_036b:
					MessageBox.Show(mainForm, "The file specified (" + Path.GetFileName(string_0) + ") is not a valid DLL.", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					num7 = (int)((num3 * 1653663462) ^ 0xFD3EC92);
				}
			}
		}
	}

	internal static void CompleteInjection(bool bool_0, MainForm mainForm)
	{
		if (ApplicationSettings.Current.Options.CloseOnInject)
		{
			mainForm.Close();
			return;
		}

		if (bool_0)
		{
			MessageBox.Show("Injection has completed successfully!", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		if (mainForm.selectedProcess != null && HasProcessExited(mainForm.selectedProcess))
		{
			SetSelectedProcess(mainForm, null);
		}

		mainForm.settingsButton.Enabled = true;
		mainForm.injectButton.Enabled = mainForm.selectedProcess != null && !ApplicationSettings.Current.Options.AutoInject;
		mainForm.processRefreshTimer.Start();
	}

	internal static void smethod_351(Class154 class154_0, string string_0, MainForm mainForm)
	{
		if (!string_0.StartsWith("d3dx9_", StringComparison.OrdinalIgnoreCase))
		{
			goto IL_0013;
		}
		goto IL_005b;
		IL_0013:
		int num = 27987631;
		goto IL_0035;
		IL_0035:
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			uint num2;
			int num5;
			switch ((num2 = (uint)(num ^ 0x1D1C86DA)) % 5)
			{
			case 2u:
				break;
			case 1u:
				flag = false;
				if (!string.IsNullOrEmpty(text))
				{
					num = (int)(num2 * 1832645345) ^ -489196750;
					continue;
				}
				goto IL_01af;
			case 0u:
				goto IL_005b;
			default:
			{
				FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
				try
				{
					Class154 @class = Class7.smethod_13(fileStream, text, bool_0: false, Enum39.const_0);
					if (@class != null)
					{
						while (true)
						{
							IL_00e5:
							int num3 = 1351701593;
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x1D1C86DA)) % 4)
								{
								case 3u:
									num3 = ((smethod_19(@class) == smethod_19(class154_0)) ? 1380639935 : 1780575410) ^ (int)(num2 * 1533017144);
									continue;
								case 0u:
									flag = true;
									num3 = (int)(num2 * 1607094741) ^ -1289095721;
									continue;
								default:
									goto end_IL_00c3;
								case 2u:
									break;
								case 1u:
									goto end_IL_00c3;
								}
								goto IL_00e5;
								continue;
								end_IL_00c3:
								break;
							}
							break;
						}
					}
				}
				catch
				{
				}
				finally
				{
					if (fileStream != null)
					{
						while (true)
						{
							IL_0128:
							int num4 = 1346330096;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x1D1C86DA)) % 3)
								{
								case 1u:
									goto IL_00f6;
								default:
									goto end_IL_010a;
								case 2u:
									break;
								case 0u:
									goto end_IL_010a;
								}
								goto IL_0128;
								IL_00f6:
								((IDisposable)fileStream).Dispose();
								num4 = ((int)num2 * -1449903721) ^ -1939687126;
								continue;
								end_IL_010a:
								break;
							}
							break;
						}
					}
				}
				if (!flag)
				{
					goto IL_0142;
				}
				goto IL_01af;
			}
			case 4u:
				return;
				IL_017d:
				while (true)
				{
					switch ((num2 = (uint)(num5 ^ 0x1D1C86DA)) % 5)
					{
					case 3u:
						break;
					case 2u:
					{
						DependencyInstallerForm form = new DependencyInstallerForm();
						smethod_29(form, "https://www.microsoft.com/download/details.aspx?id=35", null, "dxwebsetup.exe");
						form.ShowDialog();
						num5 = ((int)num2 * -1141238744) ^ -883323518;
						continue;
					}
					default:
						return;
					case 4u:
						goto IL_01af;
					case 0u:
						return;
					case 1u:
						return;
					}
					break;
				}
				goto IL_0142;
				IL_0142:
				num5 = 1385465660;
				goto IL_017d;
				IL_01af:
				num5 = ((!smethod_337(mainForm, class154_0.method_2(), string_0, text, bool_0: false, "DirectX 9 Runtime")) ? 48219170 : 313244286);
				goto IL_017d;
			}
			break;
		}
		goto IL_0013;
		IL_005b:
		text = smethod_353(class154_0, string_0);
		num = 1524527465;
		goto IL_0035;
	}

	internal static void smethod_352(Class56 class56_0, Enum7 enum7_0, Class53 class53_0)
	{
		if (Class49.bool_0)
		{
			goto IL_0007;
		}
		goto IL_0052;
		IL_0007:
		int num = 1203289807;
		goto IL_002d;
		IL_002d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x73B4642F)) % 5)
			{
			case 2u:
				break;
			case 1u:
				Class52.smethod_13()(ref class53_0.struct19_0, enum7_0, class56_0);
				num = ((int)num2 * -2109173394) ^ -2113571889;
				continue;
			default:
				return;
			case 4u:
				goto IL_0052;
			case 0u:
				return;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0007;
		IL_0052:
		Class52.smethod_6()(ref class53_0.struct19_0, enum7_0, class56_0);
		num = 853696725;
		goto IL_002d;
	}

	internal static string smethod_353(Class154 class154_0, string string_0)
	{
		Enum43 @enum = Enum43.flag_2;
		while (true)
		{
			int num = 1175017275;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6D4493FF)) % 5)
				{
				case 4u:
					num = ((!smethod_19(class154_0)) ? (-1419343748) : (-1837335309)) ^ ((int)num2 * -1788736988);
					continue;
				case 2u:
					num = (Class127.bool_0 ? 655891556 : 538708284) ^ ((int)num2 * -1864979649);
					continue;
				case 0u:
					@enum |= Enum43.flag_4;
					num = ((int)num2 * -1830141192) ^ 0x612BCD80;
					continue;
				case 3u:
					break;
				default:
					return smethod_440(string_0, class154_0.method_0(), Path.GetDirectoryName(class154_0.method_0()), @enum, 0, Class124.intptr_0);
				}
				break;
			}
		}
	}

	internal static void smethod_354(string[] string_0)
	{
		Program.UsesExternalSettings = true;
		char[] array = string_0[0].ToCharArray();
		Array.Reverse(array);
		try
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(new string(array)));
			while (true)
			{
				int num = 74296150;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x1C527C35)) % 4)
					{
					case 3u:
						num = ((!File.Exists(text)) ? (-1984382835) : (-7205414)) ^ (int)(num2 * 1554585898);
						continue;
					case 1u:
						ApplicationSettings.Current = ApplicationSettings.Load(text);
						num = ((int)num2 * -1023680343) ^ 0x2574E04A;
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
		catch
		{
		}
	}

	internal static Class151 smethod_355(Class154 class154_0, Class5 class5_0)
	{
		Class157 @class = class154_0.method_6().method_3().imethod_49()[0];
		long num3 = default(long);
		while (true)
		{
			int num = -274187130;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -120413867)) % 11)
				{
				case 8u:
					num = ((@class.method_2() != 0) ? (-806693079) : (-187132842)) ^ ((int)num2 * -470844222);
					continue;
				case 7u:
					num = ((!class5_0.imethod_0(num3)) ? (-861703003) : (-1435815887)) ^ ((int)num2 * -1802387263);
					continue;
				case 4u:
					num3 = smethod_135(class154_0, @class.method_0());
					num = ((num3 == -1L) ? (-337136209) : (-734873377));
					continue;
				case 3u:
					num = ((@class.method_0() == 0) ? 2102982174 : 401629721) ^ (int)(num2 * 864765072);
					continue;
				case 1u:
					smethod_157(class5_0, num3);
					num = -1390291925;
					continue;
				case 0u:
					num = (class5_0.imethod_0(num3 + @class.method_2()) ? (-440098115) : (-354068212));
					continue;
				case 5u:
					break;
				case 2u:
					return null;
				case 6u:
					return null;
				default:
					return new Class151(class5_0, class154_0, @class);
				case 10u:
					return null;
				}
				break;
			}
		}
	}

	internal static Class154 smethod_356(byte[] byte_0, Enum39 enum39_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(byte_0, 0, byte_0.Length);
		memoryStream.Position = 0L;
		return Class6.smethod_4(memoryStream, bool_0: true, enum39_0);
	}

	internal static void smethod_357(GClass3 gclass3_0)
	{
		GClass1 obj = smethod_42(gclass3_0.method_19())["ntdll.dll"] ?? throw new FileNotFoundException("Unable to find ntdll.dll in the specified process.");
		GClass5 gClass = smethod_215(obj).method_8().FirstOrDefault(GClass3.Class81._003C_003E9.method_0);
		if (gClass == null)
		{
			throw new InvalidOperationException("Unable to find .text section in ntdll.dll.");
		}
		IntPtr intPtr = obj.method_0().smethod_9(gClass.method_4());
		int num3 = default(int);
		int num6 = default(int);
		byte[] array = default(byte[]);
		int num9 = default(int);
		int num7 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num = 851219918;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3490C0D2)) % 55)
				{
				case 54u:
					gclass3_0.method_25(intPtr.smethod_8(num3 - 11));
					num = (int)((num2 * 227321854) ^ 0x7A574A73);
					continue;
				case 52u:
					num = (((num6 = smethod_378(array, "3öF;Æt8", 0)) != -1) ? 1923214703 : 2092156269);
					continue;
				case 51u:
					num = ((!Class127.bool_5) ? 936006074 : 837290064);
					continue;
				case 50u:
					num = (Class127.bool_10 ? 434688131 : 1389502858) ^ (int)(num2 * 1527842253);
					continue;
				case 49u:
					gclass3_0.method_25(intPtr.smethod_8(num3 - 11));
					num = ((int)num2 * -349505268) ^ 0x51C15C8A;
					continue;
				case 48u:
					num9 = smethod_378(array, "\u008BÎ3uü\u0083á\u001F", 0);
					num = (int)((num2 * 1889273624) ^ 0x729A14E9);
					continue;
				case 47u:
					num7 = smethod_419(array, "ÿv ÿv\u0018h\0\0\0\0è", "xxxxxxx????x", 0);
					num = 1071567378;
					continue;
				case 46u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num3 + 34));
					num = ((int)num2 * -64888673) ^ -1370265380;
					continue;
				case 45u:
					gclass3_0.method_25(intPtr.smethod_8(num7));
					num = ((int)num2 * -1726273584) ^ -2034604416;
					continue;
				case 44u:
					gclass3_0.method_29(intPtr.smethod_8(num6 - 28));
					num = (int)(num2 * 356566862) ^ -1601499525;
					continue;
				case 43u:
					num3 = smethod_378(array, "\u0083}\b\0\u008B5", 0);
					num = 1373680172;
					continue;
				case 41u:
					num = ((num3 != -1) ? 1835698538 : 564180149) ^ ((int)num2 * -1572475500);
					continue;
				case 40u:
					num3 = smethod_378(array, "SVW\u008BÚ\u008BùP", 0);
					num = ((num3 != -1) ? (-1129492958) : (-2074163028)) ^ (int)(num2 * 764350436);
					continue;
				case 39u:
					num = ((num6 == -1) ? 2126440277 : 1267128781) ^ (int)(num2 * 1385862655);
					continue;
				case 38u:
					array = gclass3_0.method_10<byte>(intPtr, (int)gClass.method_2());
					num = (int)((num2 * 1127789992) ^ 0x6C426FFF);
					continue;
				case 37u:
					num = ((num4 != -1) ? (-1054690571) : (-1526407274)) ^ ((int)num2 * -1011254638);
					continue;
				case 36u:
					gclass3_0.method_25(intPtr.smethod_8(num9 - 33));
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num6 - 27));
					num = (int)((num2 * 1137226933) ^ 0x167A4F5C);
					continue;
				case 35u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num5 + 7));
					num = ((int)num2 * -1760841405) ^ 0x6DC339A9;
					continue;
				case 34u:
					num5 = smethod_419(array, "ÿv ÿv\u0018h\0\0\0\0è", "xxxxxxx????x", 0);
					num = ((num5 == -1) ? 1481446509 : 1615714529);
					continue;
				case 33u:
					num4 = smethod_378(array, "u$\u0085öu\b", 0);
					num = ((num4 != -1) ? 2069075449 : 1481446509);
					continue;
				case 32u:
					num7 = smethod_378(array, "\u008BÿU\u008BìVj\u0001", 0);
					num = ((num7 != -1) ? (-1519574589) : (-1391973668)) ^ (int)(num2 * 1660718010);
					continue;
				case 31u:
					num4 = smethod_378(array, "SVW\u008DEø\u008Bú", 0);
					num = (int)(num2 * 524217384) ^ -1186105186;
					continue;
				case 30u:
					num = ((!Class127.bool_6) ? 120978087 : 1538451030);
					continue;
				case 28u:
					gclass3_0.method_25(intPtr.smethod_8(num8));
					num = ((int)num2 * -228798737) ^ 0x65F32C8C;
					continue;
				case 27u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num6 + 76));
					num = (int)(num2 * 62208088) ^ -341760323;
					continue;
				case 26u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num3 + 35));
					num = 1179705983;
					continue;
				case 24u:
					num = ((num7 != -1) ? (-1479015943) : (-9594515)) ^ (int)(num2 * 73059868);
					continue;
				case 23u:
					num6 = smethod_378(array, "u$\u0085öu\b", 0);
					num = ((num6 != -1) ? 1954067657 : 1481446509);
					continue;
				case 22u:
					num = (Class127.bool_1 ? 1419513255 : 814239343);
					continue;
				case 21u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num3 + 29));
					num = ((int)num2 * -239791782) ^ 0x659DF115;
					continue;
				case 20u:
					num8 = smethod_378(array, "\u008BÿU\u008BìQQSW\u008B}\b\u008DEø", 0);
					num = ((int)num2 * -1752328663) ^ -1119223462;
					continue;
				case 19u:
					num = (Class127.bool_7 ? (-479868745) : (-897251406)) ^ (int)(num2 * 1135005401);
					continue;
				case 18u:
					num4 = smethod_378(array, "3öF;Æ", 0);
					num = ((num4 != -1) ? 280915289 : 1766567068);
					continue;
				case 16u:
					num = ((num8 != -1) ? (-1838771688) : (-532949945)) ^ (int)(num2 * 1773374985);
					continue;
				case 15u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num7 + 7));
					num = ((int)num2 * -715443621) ^ -2106495708;
					continue;
				case 14u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num8 + 38));
					num = (int)(num2 * 2066392950) ^ -308319497;
					continue;
				case 13u:
					num = ((!smethod_427(gclass3_0.method_19())) ? 1928972409 : 410146951) ^ (int)(num2 * 223421028);
					continue;
				case 11u:
					gclass3_0.method_25(intPtr.smethod_8(num6 - 11));
					num = ((int)num2 * -1495254023) ^ -1532682233;
					continue;
				case 10u:
					num6 = smethod_378(array, "\u008DEð\u0089UøP\u008DUô", 0);
					num = ((int)num2 * -1280152801) ^ -745343995;
					continue;
				case 9u:
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num4 - 27));
					num = (int)((num2 * 938562021) ^ 0x36CE94CB);
					continue;
				case 8u:
					gclass3_0.method_25(intPtr.smethod_8(num4 - 8));
					num = ((int)num2 * -1977044827) ^ 0x41974115;
					continue;
				case 7u:
					num3 = smethod_378(array, "\u008DEô\u0089UøP\u008DUü", 0);
					num = ((num3 != -1) ? 1485944174 : 1179705983);
					continue;
				case 6u:
					num = ((num9 != -1) ? (-582515898) : (-966619148)) ^ (int)(num2 * 710772147);
					continue;
				case 5u:
					num = (Class127.bool_0 ? 2131262248 : 1027690505) ^ (int)(num2 * 616521830);
					continue;
				case 4u:
					num = ((!Class127.bool_3) ? 1481446509 : 837958612);
					continue;
				case 3u:
					num = (Class127.bool_9 ? 1192923823 : 1366852313);
					continue;
				case 1u:
					gclass3_0.method_25(intPtr.smethod_8(num5));
					num = ((int)num2 * -1547794217) ^ -636468245;
					continue;
				case 0u:
					num5 = smethod_378(array, "\u008BÿU\u008BìVh", 0);
					num = ((num5 != -1) ? (-1268597137) : (-1428386662)) ^ ((int)num2 * -551098937);
					continue;
				default:
					return;
				case 42u:
					break;
				case 2u:
					return;
				case 12u:
					return;
				case 17u:
					gclass3_0.method_29(intPtr.smethod_8(num4 - 28));
					return;
				case 25u:
					return;
				case 29u:
					gclass3_0.method_29(intPtr.smethod_8(num3 - 18));
					return;
				case 53u:
					return;
				}
				break;
			}
		}
	}

	[DllImport("psapi.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetModuleInformation(IntPtr intptr_0, IntPtr intptr_1, out Class124.Struct46 struct46_0, int int_0);

	internal static void smethod_358(Class56 class56_0, object[] object_0, CallingConvention callingConvention_0, Class47 class47_0)
	{
		bool[] array = new bool[object_0.Length];
		if (callingConvention_0 != CallingConvention.ThisCall)
		{
			goto IL_019b;
		}
		goto IL_04b8;
		IL_019b:
		int num = -1288428068;
		goto IL_03f3;
		IL_03f3:
		int num5 = default(int);
		object obj = default(object);
		object[] array2 = default(object[]);
		int num4 = default(int);
		Class63 @class = default(Class63);
		int num6 = default(int);
		Class57 class2 = default(Class57);
		int num8 = default(int);
		int num3 = default(int);
		int num7 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1211465069)) % 38)
			{
			case 37u:
				smethod_181(object_0[num5], class47_0, Class47.Enum6.const_2);
				num = ((int)num2 * -1211331439) ^ 0x4954EC25;
				continue;
			case 36u:
				obj = array2[num4];
				num = -264081910;
				continue;
			case 35u:
				num5--;
				num = -1207532562;
				continue;
			case 33u:
				@class = class56_0 as Class63;
				num = -1534324660;
				continue;
			case 32u:
				num6++;
				num = (int)(num2 * 1301699255) ^ -882691877;
				continue;
			case 31u:
				num = ((int)num2 * -1505907566) ^ 0x6CFE61C;
				continue;
			case 30u:
			{
				smethod_306(class47_0.class53_0, Class49.class63_37, class2);
				Class53 class53_ = class47_0.class53_0;
				Class63 class63_ = Class49.class63_69;
				smethod_372(class63_, class53_);
				num = ((int)num2 * -1167270270) ^ -2069930302;
				continue;
			}
			case 29u:
				num6 = 0;
				num = ((int)num2 * -913040919) ^ -1152539133;
				continue;
			case 28u:
				num5 = object_0.Length - 1;
				num = -450972254;
				continue;
			case 27u:
				class2 = class56_0 as Class57;
				num = (int)((num2 * 1787599892) ^ 0x7CB010D9);
				continue;
			case 26u:
				num = ((num6 >= num8) ? (-1547506509) : (-1074467715)) ^ (int)(num2 * 676800022);
				continue;
			case 25u:
				num = ((!smethod_392(null, @class)) ? 1789842968 : 615849675) ^ (int)(num2 * 1262489841);
				continue;
			case 23u:
				num = ((!smethod_134(null, @class)) ? 307116507 : 865603960) ^ (int)(num2 * 1187578848);
				continue;
			case 22u:
				break;
			case 21u:
				goto IL_01a5;
			case 20u:
				goto IL_01c8;
			case 19u:
				goto IL_01ec;
			case 18u:
				num4 = 0;
				num = (int)((num2 * 920670584) ^ 0x2299CBE1);
				continue;
			case 16u:
				num3 = 0;
				array2 = object_0;
				num = -607909471;
				continue;
			case 15u:
				num = ((obj is IntPtr) ? 682700618 : 981396693) ^ (int)(num2 * 2024373347);
				continue;
			case 14u:
				num3 += 4;
				num = -926967529;
				continue;
			case 12u:
				array[num7] = true;
				smethod_181(object_0[num7], class47_0, (Class47.Enum6)num6);
				num = -343652087;
				continue;
			case 11u:
				num = ((callingConvention_0 != CallingConvention.FastCall) ? 719818976 : 1652913666) ^ ((int)num2 * -1423876759);
				continue;
			case 10u:
				goto IL_02b3;
			case 8u:
				num7++;
				num = ((int)num2 * -582436032) ^ 0x348B208;
				continue;
			case 7u:
				num = ((!(obj is UIntPtr)) ? (-1138941855) : (-1568969845)) ^ (int)(num2 * 148402002);
				continue;
			case 6u:
				num4++;
				num = -1174021487;
				continue;
			case 5u:
				goto IL_032a;
			case 4u:
				num = ((!smethod_49(class2, null)) ? 91968244 : 423993175) ^ (int)(num2 * 1319061799);
				continue;
			case 3u:
				smethod_372(@class, class47_0.class53_0);
				num = (int)(num2 * 1861575084) ^ -139886589;
				continue;
			case 2u:
				goto IL_0392;
			case 1u:
				num3 += obj.GetType().smethod_7();
				num = -926967529;
				continue;
			case 0u:
				num = ((obj is Class47.Class48) ? (-1101741943) : (-245433692)) ^ ((int)num2 * -1386902337);
				continue;
			case 9u:
				goto IL_049e;
			case 24u:
				goto IL_04b8;
			case 13u:
				throw new InvalidOperationException("Unknown function pointer type");
			default:
				smethod_363(class47_0.class53_0, Class49.class63_41, smethod_167(num3));
				return;
			case 34u:
				return;
			}
			break;
			IL_0392:
			num = (smethod_328(class2, null) ? (-480363574) : (-1889468101));
			continue;
			IL_02b3:
			num = ((callingConvention_0 != CallingConvention.Cdecl) ? (-185002849) : (-787291443));
			continue;
			IL_01c8:
			num = ((num4 < array2.Length) ? (-1513483141) : (-160967592));
			continue;
			IL_032a:
			num = ((num5 < 0) ? (-640849980) : (-1372807174));
			continue;
			IL_01a5:
			num = ((num7 < object_0.Length) ? (-928418019) : (-812727673));
			continue;
			IL_01ec:
			num = ((!array[num5]) ? (-1952261536) : (-1757959802));
		}
		goto IL_019b;
		IL_04b8:
		int num9;
		if (callingConvention_0 == CallingConvention.FastCall)
		{
			num9 = 2;
			goto IL_049f;
		}
		num = -762306292;
		goto IL_03f3;
		IL_049f:
		num8 = num9;
		num7 = 0;
		num = -87730752;
		goto IL_03f3;
		IL_049e:
		num9 = 1;
		goto IL_049f;
	}

	internal static void smethod_359()
	{
		try
		{
			if (Environment.OSVersion.Platform != PlatformID.Win32NT)
			{
				return;
			}
			while (true)
			{
				int num = 1403186211;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x3DD9FE26)) % 3)
					{
					case 1u:
						goto IL_0010;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0010:
					GClass6.gclass6_0 = new GClass6();
					num = (int)((num2 * 297737197) ^ 0x24163AC5);
				}
			}
		}
		catch
		{
		}
	}

	internal static void smethod_360(Class53 class53_0, Class57 class57_0)
	{
		smethod_352(class57_0, Enum7.const_502, class53_0);
	}

	internal unsafe static void smethod_361(long long_0, IntPtr intptr_0, byte byte_0)
	{
		byte* ptr = (byte*)(void*)intptr_0;
		byte* ptr2 = default(byte*);
		long num3 = default(long);
		while (true)
		{
			int num = 1699662745;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1DD28092)) % 12)
				{
				case 11u:
					ptr2 = ptr + long_0;
					num = ((int)num2 * -1414931965) ^ 0x3254CD6D;
					continue;
				case 10u:
					num3 = ptr2 - ptr;
					num = 1485180467;
					continue;
				case 9u:
					num = ((num3 >= 8L) ? (-1260486489) : (-1538773396)) ^ ((int)num2 * -950699635);
					continue;
				case 8u:
					num = ((num3 < 2L) ? 952437844 : 1194389455);
					continue;
				case 7u:
					num = ((num3 >= 4L) ? 641997871 : 2110625374);
					continue;
				case 6u:
					num = ((int)num2 * -902919817) ^ -384522794;
					continue;
				case 5u:
					*(int*)ptr = byte_0;
					ptr += 4;
					num = (int)((num2 * 1631417547) ^ 0x23D71F93);
					continue;
				case 4u:
					ptr += 8;
					num = ((int)num2 * -1209299499) ^ -1762388028;
					continue;
				case 1u:
					*(short*)ptr = byte_0;
					ptr += 2;
					num = (int)(num2 * 1694458221) ^ -1768598059;
					continue;
				case 0u:
					*(long*)ptr = byte_0;
					num = ((int)num2 * -670467657) ^ -798253990;
					continue;
				case 3u:
					break;
				default:
					*ptr = byte_0;
					return;
				}
				break;
			}
		}
	}

	internal static int smethod_362(Type type_0)
	{
		if (type_0.IsSubclassOf(typeof(Class96)))
		{
			int count = default(int);
			int count2 = default(int);
			while (true)
			{
				int num = 1954533698;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x218DFF1F)) % 11)
					{
					case 10u:
						break;
					case 8u:
						count = Class96.dictionary_0.Count;
						count2 = Class96.dictionary_1.Count;
						RuntimeHelpers.RunClassConstructor(type_0.TypeHandle);
						num = 1366969982;
						continue;
					case 7u:
						num = (Class96.dictionary_0.ContainsKey(type_0) ? (-1970454478) : (-854377611)) ^ ((int)num2 * -1061427865);
						continue;
					case 3u:
						num = ((Class96.dictionary_1.Count != count2) ? 2037727753 : 155529082) ^ (int)(num2 * 663721599);
						continue;
					case 1u:
						num = ((Class96.dictionary_0.Count != count) ? (-193483585) : (-2070102187)) ^ ((int)num2 * -998035680);
						continue;
					case 0u:
						goto end_IL_00f6;
					case 2u:
						return Class96.dictionary_1[type_0].Last();
					case 4u:
						throw new InvalidOperationException(string.Concat("Unregistered PlatformStruct detected. (", type_0, ")"));
					case 5u:
						return Class96.dictionary_0[type_0].Last();
					default:
						goto end_IL_0134;
					case 9u:
						return smethod_362(type_0);
					}
					num = ((!Class96.dictionary_1.ContainsKey(type_0)) ? 2130066399 : 889016104);
					continue;
					end_IL_00f6:
					break;
				}
				continue;
				end_IL_0134:
				break;
			}
		}
		throw new InvalidOperationException("The type must be a PlatformStruct.");
	}

	internal static void smethod_363(Class53 class53_0, Class63 class63_0, Class57 class57_0)
	{
		smethod_137(class53_0, Enum7.const_1, class63_0, class57_0);
	}

	internal static Class59 smethod_364(Class58 class58_0, long long_0)
	{
		return smethod_161(2u, (IntPtr)long_0, class58_0);
	}

	internal static void smethod_365(Class47 class47_0, Class56 class56_0, object[] object_0)
	{
		int num2 = 0;
		Class57 @class = null;
		if (object_0.Length <= 4)
		{
			goto IL_02a8;
		}
		int num = object_0.Length * 8;
		goto IL_0326;
		IL_0324:
		num = 40;
		goto IL_0326;
		IL_0326:
		num2 = num;
		@class = class56_0 as Class57;
		num2 -= num2 % 16;
		int num3 = -477424628;
		goto IL_02ad;
		IL_02ad:
		int[] array = default(int[]);
		Class53 class53_2 = default(Class53);
		Class63 class2 = default(Class63);
		int num6 = default(int);
		Class53 class53_ = default(Class53);
		int num5 = default(int);
		while (true)
		{
			uint num4;
			switch ((num4 = (uint)(num3 ^ -1654128794)) % 25)
			{
			case 24u:
			{
				int[] array2 = Enumerable.Range(0, object_0.Length).ToArray();
				array2.smethod_4();
				array = array2;
				num3 = (int)(num4 * 351147968) ^ -2060633881;
				continue;
			}
			case 23u:
			{
				Class63 class63_2 = Class49.class63_53;
				smethod_372(class63_2, class53_2);
				num3 = (int)(num4 * 1596945902) ^ -1676622225;
				continue;
			}
			case 22u:
				num3 = ((!smethod_134(null, class2)) ? 1347721345 : 648917204) ^ ((int)num4 * -2090724803);
				continue;
			case 20u:
				class2 = class56_0 as Class63;
				num3 = -803227643;
				continue;
			case 19u:
				break;
			case 18u:
				num6 = 0;
				num3 = -865413926;
				continue;
			case 17u:
			{
				Class63 class63_ = Class49.class63_57;
				Class57 class57_ = smethod_167(num2 + 8);
				smethod_190(class63_, class57_, class53_);
				num3 = ((int)num4 * -1296944756) ^ -1791562437;
				continue;
			}
			case 16u:
				smethod_306(class47_0.class53_0, Class49.class63_53, @class);
				num3 = ((int)num4 * -1177294428) ^ -1243670742;
				continue;
			case 15u:
				num3 = (class47_0.method_0() ? 343031415 : 2064726918) ^ ((int)num4 * -19714018);
				continue;
			case 13u:
			{
				int num7 = array[num5];
				smethod_391(class47_0, object_0[num7], num7);
				num3 = -950295674;
				continue;
			}
			case 12u:
				num3 = (int)(num4 * 722407968) ^ -132880285;
				continue;
			case 11u:
				smethod_391(class47_0, object_0[num6], num6);
				num6++;
				num3 = -865413926;
				continue;
			case 10u:
				goto IL_0198;
			case 8u:
				goto IL_01bb;
			case 7u:
				num5 = 0;
				num3 = ((int)num4 * -1338254048) ^ 0x2B340EAE;
				continue;
			case 6u:
				goto IL_01f6;
			case 5u:
				smethod_372(class2, class47_0.class53_0);
				num3 = ((int)num4 * -1822982286) ^ 0x5288A71A;
				continue;
			case 4u:
				class53_2 = class47_0.class53_0;
				num3 = ((int)num4 * -798009677) ^ -1654502301;
				continue;
			case 3u:
				class53_ = class47_0.class53_0;
				num3 = (int)((num4 * 1754161637) ^ 0xFF19062);
				continue;
			case 2u:
				num3 = ((!smethod_392(null, class2)) ? (-1442595508) : (-1712354238)) ^ ((int)num4 * -45601394);
				continue;
			case 1u:
				num5++;
				num3 = (int)((num4 * 196827592) ^ 0x74DB48E);
				continue;
			case 0u:
				goto end_IL_02ad;
			case 14u:
				goto IL_0324;
			case 21u:
				throw new InvalidOperationException("Unknown function pointer type");
			default:
				smethod_363(class47_0.class53_0, Class49.class63_57, smethod_167(num2 + 8));
				return;
			}
			num3 = ((num5 >= array.Length) ? (-807006229) : (-1220298295));
			continue;
			IL_01f6:
			num3 = ((!smethod_328(@class, null)) ? (-1331588779) : (-542520062));
			continue;
			IL_0198:
			num3 = ((num6 >= object_0.Length) ? (-1031892029) : (-1946655624));
			continue;
			IL_01bb:
			num3 = (smethod_49(@class, null) ? (-15732939) : (-986202871));
			continue;
			end_IL_02ad:
			break;
		}
		goto IL_02a8;
		IL_02a8:
		num3 = -1750269952;
		goto IL_02ad;
	}

	internal static uint smethod_366(Class112 class112_0)
	{
		return class112_0.method_21<uint>(0);
	}

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, UIntPtr uintptr_0, Class124.Enum33 enum33_0, Class124.Enum34 enum34_0);

	internal static void smethod_367(string string_0, GClass4 gclass4_0)
	{
		smethod_299(string_0, gclass4_0.class154_0);
	}

	internal static void smethod_368(Class89.Class172 class172_0)
	{
		if (class172_0.method_0() != null)
		{
			goto IL_006f;
		}
		goto IL_00ac;
		IL_006f:
		int num = 1500114108;
		goto IL_0074;
		IL_0074:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3AB426BB)) % 6)
			{
			case 5u:
				class172_0.method_11(Class124.intptr_0);
				num = ((int)num2 * -564228611) ^ -1326974839;
				continue;
			case 2u:
				ReleaseActCtx(class172_0.method_10());
				num = ((int)num2 * -2033650173) ^ 0x28CE4D76;
				continue;
			case 1u:
				class172_0.method_0().System_002EIDisposable_002EDispose();
				class172_0.method_1(null);
				num = (int)((num2 * 2020730459) ^ 0x18DAAB98);
				continue;
			case 0u:
				break;
			default:
				return;
			case 4u:
				goto IL_00ac;
			case 3u:
				return;
			}
			break;
		}
		goto IL_006f;
		IL_00ac:
		num = ((!(class172_0.method_10() != Class124.intptr_0)) ? 767526302 : 808903105);
		goto IL_0074;
	}

	internal static Class118 smethod_369(GClass2 gclass2_0)
	{
		if (!Class127.bool_0)
		{
			goto IL_0086;
		}
		goto IL_00e8;
		IL_0086:
		int num = -1220482538;
		goto IL_008b;
		IL_008b:
		Class118 @class = default(Class118);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -124340677)) % 8)
			{
			case 5u:
				num = ((!smethod_427(gclass2_0)) ? 1781939524 : 1950522238) ^ ((int)num2 * -1960146539);
				continue;
			case 2u:
				num = ((smethod_270(@class) != IntPtr.Zero) ? 1353923320 : 1682319214) ^ (int)(num2 * 160012274);
				continue;
			case 0u:
				break;
			case 3u:
				goto IL_00bc;
			case 6u:
				goto IL_00e8;
			case 1u:
				return null;
			case 4u:
				return null;
			default:
				return gclass2_0.method_12(@class);
			}
			break;
		}
		goto IL_0086;
		IL_00bc:
		Class118 class2 = new Class118(gclass2_0);
		goto IL_00d3;
		IL_00d3:
		@class = class2;
		num = ((!smethod_281(@class)) ? (-766285094) : (-1197472239));
		goto IL_008b;
		IL_00e8:
		if (gclass2_0.method_10() != IntPtr.Zero)
		{
			class2 = new Class118(gclass2_0, gclass2_0.method_10());
			goto IL_00d3;
		}
		num = -1979089664;
		goto IL_008b;
	}

	internal static ushort smethod_370(Class166 class166_0)
	{
		return class166_0.class5_0.ReadUInt16();
	}

	internal static void smethod_371(Class53 class53_0, Class59 class59_0)
	{
		smethod_352(class59_0, Enum7.const_463, class53_0);
	}

	internal static void smethod_372(Class63 class63_0, Class53 class53_0)
	{
		smethod_352(class63_0, Enum7.const_26, class53_0);
	}

	internal static bool smethod_373(ref Class124.Struct55 struct55_0, IntPtr intptr_0)
	{
		IntPtr intPtr = smethod_13(ref struct55_0);
		bool result = SetThreadContext(intptr_0, intPtr);
		struct55_0 = (Class124.Struct55)Marshal.PtrToStructure(intPtr, typeof(Class124.Struct55));
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	internal static Class57 smethod_374(uint uint_0)
	{
		return new Class57((IntPtr)(int)uint_0, bool_0: true);
	}

	internal unsafe static bool smethod_375(char* pChar_0, byte* pByte_0, char* pChar_1)
	{
		byte* ptr = (byte*)pChar_1;
		byte* ptr2 = default(byte*);
		while (true)
		{
			int num = -1792574972;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1764546018)) % 10)
				{
				case 9u:
					num = ((int)num2 * -1976049927) ^ 0x48DC3D37;
					continue;
				case 8u:
					ptr2 = (byte*)pChar_0;
					num = (int)((num2 * 1130431397) ^ 0x438E0FAF);
					continue;
				case 7u:
					num = ((*ptr2 != 120) ? (-1939384998) : (-362095551));
					continue;
				case 6u:
					ptr2 += 2;
					pByte_0++;
					num = -1597492465;
					continue;
				case 5u:
					num = ((*pByte_0 != *ptr) ? 645752570 : 252858347) ^ ((int)num2 * -1431377681);
					continue;
				case 4u:
					num = ((*ptr2 != 0) ? (-2085956741) : (-300785992));
					continue;
				case 3u:
					ptr += 2;
					num = (int)((num2 * 1582455632) ^ 0x6B2A41BC);
					continue;
				case 2u:
					break;
				default:
					return *ptr2 == 0;
				case 1u:
					return false;
				}
				break;
			}
		}
	}

	internal static void smethod_376(GClass4 gclass4_0)
	{
		List<GClass5> list = gclass4_0.class154_0.method_8();
		GClass5 gClass = default(GClass5);
		int num3 = default(int);
		while (true)
		{
			int num = 1558284299;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5DFEA358)) % 11)
				{
				case 10u:
					gClass.method_3(list[num3 + 1].method_4() - gClass.method_4());
					num = (int)(num2 * 2113012642) ^ -1591758169;
					continue;
				case 9u:
				{
					GClass5 gClass2 = gClass;
					uint uint_ = gClass.method_2();
					uint uint_2 = gclass4_0.class154_0.method_6().method_3().imethod_18();
					gClass2.method_3(smethod_201(uint_2, uint_));
					num = ((int)num2 * -1697498223) ^ 0x754DC144;
					continue;
				}
				case 8u:
					num3++;
					num = 1843147128;
					continue;
				case 6u:
					num = ((gClass.method_4() + gClass.method_2() > list[num3 + 1].method_4()) ? (-1095057371) : (-1169030035)) ^ (int)(num2 * 1523433520);
					continue;
				case 4u:
					num = ((num3 >= list.Count) ? 2005377368 : 134943772);
					continue;
				case 3u:
					num = (int)(num2 * 584251732) ^ -1588287768;
					continue;
				case 2u:
					gClass = list[num3];
					num = 591226640;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1189916463) ^ -1482094641;
					continue;
				case 0u:
					num = ((num3 >= list.Count - 1) ? (-308845427) : (-686485939)) ^ ((int)num2 * -334268812);
					continue;
				default:
					return;
				case 5u:
					break;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_377(GClass4 gclass4_0, long long_0, long long_1)
	{
		byte[] buffer = new byte[long_1];
		while (true)
		{
			int num = -836880045;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1784234244)) % 4)
				{
				case 3u:
					gclass4_0.class154_0.method_28().Position = long_0;
					num = ((int)num2 * -471602024) ^ -63907403;
					continue;
				case 1u:
					gclass4_0.binaryWriter_0.Write(buffer);
					num = (int)((num2 * 1354479059) ^ 0x67EF169D);
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

	internal static int smethod_378(byte[] byte_0, string string_0, int int_0)
	{
		if (int_0 + string_0.Length > byte_0.Length)
		{
			goto IL_0081;
		}
		goto IL_0135;
		IL_0081:
		int num = -594057257;
		goto IL_00e0;
		IL_00e0:
		int num3 = default(int);
		byte[] array = default(byte[]);
		int length = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1572129997)) % 13)
			{
			case 12u:
				num = (int)((num2 * 1557213288) ^ 0xD1AFE95);
				continue;
			case 11u:
				num3 = 0;
				num = (int)(num2 * 1223115804) ^ -1033244178;
				continue;
			case 10u:
				array[num3] = (byte)string_0[num3];
				num = -1456216870;
				continue;
			case 8u:
				array = new byte[length];
				num = (int)(num2 * 1472680885) ^ -758293758;
				continue;
			case 7u:
				length = string_0.Length;
				num = -336851990;
				continue;
			case 5u:
				break;
			case 4u:
				num3++;
				num = (int)(num2 * 1619575105) ^ -1958246668;
				continue;
			case 1u:
				num = ((string_0.Length >= 5) ? (-860857234) : (-563254696)) ^ (int)(num2 * 442627558);
				continue;
			case 0u:
				goto IL_00c5;
			case 6u:
				goto IL_0135;
			case 2u:
				return -1;
			default:
				return smethod_12(byte_0, array, int_0);
			case 9u:
				return smethod_343(byte_0, string_0, int_0);
			}
			break;
			IL_00c5:
			num = ((num3 >= length) ? (-30094545) : (-970385153));
		}
		goto IL_0081;
		IL_0135:
		num = ((byte_0.Length - int_0 < 20000) ? (-1509323608) : (-198238309));
		goto IL_00e0;
	}

	internal static bool smethod_379(GClass2 gclass2_0)
	{
		if (smethod_427(gclass2_0))
		{
			return Class127.bool_0;
		}
		return false;
	}

	internal static void SetSelectedProcess(MainForm mainForm, GClass2 gclass2_0)
	{
		Image previousImage = mainForm.processIconPictureBox.BackgroundImage;
		mainForm.processIconPictureBox.BackgroundImage = null;
		previousImage?.Dispose();

		mainForm.selectedProcess = gclass2_0;
		mainForm.processDescriptionLabel.ResetText();

		if (gclass2_0 == null)
		{
			mainForm.processIconPictureBox.Cursor = Cursors.Default;
			mainForm.injectButton.Enabled = false;
			return;
		}

		mainForm.processIconPictureBox.Cursor = Cursors.Hand;
		try
		{
			using (Icon icon = smethod_11(gclass2_0.method_4(), Enum18.const_1))
			{
				mainForm.processIconPictureBox.BackgroundImage = icon?.ToBitmap();
			}
		}
		catch
		{
			mainForm.processIconPictureBox.BackgroundImage = null;
		}

		string description = "No description";
		try
		{
			FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(gclass2_0.method_4());
			if (!string.IsNullOrEmpty(versionInfo.FileDescription))
			{
				description = versionInfo.FileDescription;
			}
		}
		catch
		{
		}

		if (description.Length > 50)
		{
			description = description.Substring(0, 50) + "...";
		}

		mainForm.processDescriptionLabel.Text = string.Format("{0}\nProcess ID: 0x{1:X} ({1})", description, gclass2_0.method_0());
		ApplicationSettings.Current.ProcessName = mainForm.processNameTextBox.Text;
		ApplicationSettings.Save();
		mainForm.injectButton.Enabled = !ApplicationSettings.Current.Options.AutoInject;
	}

	internal static void smethod_381(Class56.Struct13 struct13_0, Class56 class56_0)
	{
		class56_0.method_1(Class56.smethod_0<Class56.Struct13, Class56.Struct7>(struct13_0));
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ActivateActCtx(IntPtr intptr_0, out IntPtr intptr_1);

	internal static void smethod_382(GClass4 gclass4_0)
	{
		smethod_437(gclass4_0, 2L, 58L);
		gclass4_0.class154_0.method_6().method_1().method_7(gclass4_0.random_0.smethod_0());
		gclass4_0.class154_0.method_6().method_1().method_9(gclass4_0.random_0.smethod_0());
		uint[] array = default(uint[]);
		uint num3 = default(uint);
		int num4 = default(int);
		while (true)
		{
			int num = -1299007203;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1434317088)) % 31)
				{
				case 30u:
					gclass4_0.class154_0.method_6().method_3().imethod_25(gclass4_0.random_0.smethod_2());
					gclass4_0.class154_0.method_6().method_3().imethod_6(gclass4_0.random_0.smethod_0());
					gclass4_0.class154_0.method_6().method_3().imethod_8(gclass4_0.random_0.smethod_0());
					num = (int)(num2 * 1083667578) ^ -295606493;
					continue;
				case 29u:
					num = ((gclass4_0.class154_0.method_6().method_1().method_10() == 240) ? (-1241739389) : (-75834312)) ^ (int)(num2 * 607226421);
					continue;
				case 28u:
					gclass4_0.class154_0.method_6().method_3().imethod_23(gclass4_0.random_0.smethod_2());
					num = ((int)num2 * -790302517) ^ -1202805667;
					continue;
				case 27u:
					gclass4_0.class154_0.method_6().method_3().imethod_38(gclass4_0.random_0.smethod_0());
					num = (int)(num2 * 1545773803) ^ -1210247788;
					continue;
				case 26u:
					array = new uint[5] { 1u, 2u, 4u, 8u, 16384u };
					num = -312329292;
					continue;
				case 25u:
				{
					Class159 @class = gclass4_0.class154_0.method_6().method_1();
					@class.method_13(@class.method_12() | (Enum36.flag_4 | Enum36.flag_6 | Enum36.flag_14));
					gclass4_0.class154_0.method_6().method_3().imethod_2(0);
					num = ((int)num2 * -1848355930) ^ 0x1585490F;
					continue;
				}
				case 24u:
					num = (smethod_19(gclass4_0.class154_0) ? (-911722814) : (-348777830)) ^ (int)(num2 * 955067557);
					continue;
				case 22u:
					num3 = array[gclass4_0.random_0.Next(array.Length)];
					num = -199494738;
					continue;
				case 21u:
					gclass4_0.class154_0.method_6().method_3().imethod_40(gclass4_0.random_0.smethod_0());
					num = ((int)num2 * -1053912724) ^ 0x6B6DCF89;
					continue;
				case 20u:
					gclass4_0.class154_0.method_6().method_3().imethod_10(gclass4_0.random_0.smethod_0());
					gclass4_0.class154_0.method_6().method_3().imethod_14(gclass4_0.random_0.smethod_0());
					num = ((int)num2 * -235018941) ^ 0x5E783B8E;
					continue;
				case 19u:
					gclass4_0.class154_0.method_6().method_3().imethod_48(gclass4_0.random_0.smethod_1(10u, 17u));
					num = ((int)num2 * -878366889) ^ -665122718;
					continue;
				case 18u:
					num = (smethod_235(gclass4_0) ? (-1437512395) : (-418544195));
					continue;
				case 17u:
					gclass4_0.class154_0.method_6().method_3().imethod_46(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 735301873) ^ 0x66D7FDCA);
					continue;
				case 15u:
					num4 = 0;
					num = ((int)num2 * -521476824) ^ -1048210322;
					continue;
				case 14u:
					gclass4_0.class154_0.method_6().method_3().imethod_4(0);
					num = ((int)num2 * -1337422160) ^ -1693273374;
					continue;
				case 13u:
					gclass4_0.class154_0.method_6().method_3().imethod_44(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 23268398) ^ 0x49843285);
					continue;
				case 12u:
					gclass4_0.class154_0.method_6().method_3().imethod_16(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 374712267) ^ 0x336DCCD8);
					continue;
				case 11u:
					num4++;
					num = -939397810;
					continue;
				case 10u:
					num = ((gclass4_0.class154_0.method_6().method_1().method_10() != 224) ? 709855760 : 1856947121) ^ ((int)num2 * -957139191);
					continue;
				case 9u:
					gclass4_0.class154_0.method_6().method_3().imethod_48(15u);
					num = ((int)num2 * -1232029053) ^ -603153393;
					continue;
				case 8u:
					num4--;
					num = -1312661524;
					continue;
				case 7u:
					num = ((num4 >= gclass4_0.random_0.Next(1, array.Length)) ? (-173224425) : (-1214782869));
					continue;
				case 6u:
					num = ((((uint)gclass4_0.class154_0.method_6().method_3().imethod_35() & num3) == num3) ? (-911423502) : (-305799945)) ^ (int)(num2 * 819580154);
					continue;
				case 5u:
				{
					Interface2 @interface = gclass4_0.class154_0.method_6().method_3();
					@interface.imethod_36((Enum38)((int)@interface.imethod_35() | (int)num3));
					num = ((int)num2 * -1970128942) ^ -178414966;
					continue;
				}
				case 4u:
					num = (((gclass4_0.class154_0.method_6().method_1().method_12() & Enum36.flag_12) == Enum36.flag_12) ? 592724392 : 2073821414) ^ (int)(num2 * 1302161583);
					continue;
				case 3u:
					num = (smethod_19(gclass4_0.class154_0) ? (-418544195) : (-499125519));
					continue;
				case 2u:
					num = (int)(num2 * 981966488) ^ -1525064419;
					continue;
				case 1u:
					gclass4_0.class154_0.method_6().method_3().imethod_42(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 323379280) ^ 0x78367205);
					continue;
				case 0u:
					gclass4_0.class154_0.method_6().method_1().method_5(gclass4_0.random_0.smethod_0());
					num = (int)((num2 * 1255285139) ^ 0x3036C4DE);
					continue;
				default:
					return;
				case 23u:
					break;
				case 16u:
					return;
				}
				break;
			}
		}
	}

	internal static void InitializeMainFormComponents(MainForm mainForm)
	{
		mainForm.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		DataGridViewCellStyle dataGridViewCellStyle = default(DataGridViewCellStyle);
		while (true)
		{
			int num = -1795078856;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -487753370)) % 125)
				{
				case 124u:
					mainForm.processNameTextBox.TextChanged += mainForm.OnProcessNameChanged;
					mainForm.selectProcessButton.BackColor = Color.Transparent;
					mainForm.selectProcessButton.Location = new Point(281, 25);
					num = (int)((num2 * 1169526931) ^ 0x7AAB1BE5);
					continue;
				case 123u:
					mainForm.moduleGrid.TabIndex = 4;
					num = ((int)num2 * -337538765) ^ 0x3C5AA310;
					continue;
				case 122u:
					mainForm.mainPanel = new Panel();
					num = (int)((num2 * 1636137315) ^ 0x36EDAB8);
					continue;
				case 121u:
					mainForm.Name = "MainForm";
					num = (int)((num2 * 118520750) ^ 0x4E60BF24);
					continue;
				case 120u:
					mainForm.mainPanel.Name = "mainPanel";
					num = (int)(num2 * 1702526366) ^ -1361416995;
					continue;
				case 119u:
					mainForm.exportOptionsColumn = new DataGridViewButtonColumn();
					num = ((int)num2 * -1530116333) ^ 0x27B8A11F;
					continue;
				case 118u:
					mainForm.selectProcessButton.Name = "selectProcessButton";
					num = (int)(num2 * 536041281) ^ -334805787;
					continue;
				case 117u:
					mainForm.injectionListLabel.Location = new Point(20, 82);
					num = (int)(num2 * 1558443897) ^ -1419661379;
					continue;
				case 116u:
					mainForm.enabledColumn.Name = "enableColumn";
					num = ((int)num2 * -1814186898) ^ 0x410C0C6D;
					continue;
				case 115u:
					mainForm.moduleGrid.Name = "injectDataGridView";
					num = (int)((num2 * 336482190) ^ 0x51D57DF9);
					continue;
				case 114u:
					mainForm.moduleGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					num = ((int)num2 * -224278721) ^ -1898663764;
					continue;
				case 113u:
					mainForm.selectProcessButton.Text = "Select";
					num = ((int)num2 * -449972781) ^ 0x4CB6A29;
					continue;
				case 112u:
					mainForm.addDllButton = new Button();
					num = (int)(num2 * 1238264043) ^ -489936994;
					continue;
				case 111u:
					mainForm.addDllButton.Text = "Add DLL";
					mainForm.addDllButton.UseVisualStyleBackColor = true;
					mainForm.addDllButton.Click += mainForm.OnAddDllClicked;
					mainForm.injectionListLabel.AutoSize = true;
					mainForm.injectionListLabel.BackColor = Color.Transparent;
					num = (int)(num2 * 1636686051) ^ -2021245646;
					continue;
				case 110u:
					mainForm.toggleButton.Size = new Size(98, 22);
					mainForm.toggleButton.TabIndex = 1;
					mainForm.toggleButton.Text = "Enable/Disable";
					num = ((int)num2 * -1309309817) ^ 0x1952E8EA;
					continue;
				case 109u:
					mainForm.injectButton.Click += mainForm.OnInjectClicked;
					mainForm.aboutButton.Location = new Point(11, 221);
					num = ((int)num2 * -1759659640) ^ 0x25B80A4F;
					continue;
				case 108u:
					mainForm.FormBorderStyle = FormBorderStyle.FixedSingle;
					num = (int)(num2 * 1334129414) ^ -702505184;
					continue;
				case 107u:
					((ISupportInitialize)mainForm.moduleGrid).EndInit();
					mainForm.ResumeLayout(performLayout: false);
					num = (int)(num2 * 1971276451) ^ -1366413249;
					continue;
				case 106u:
					mainForm.processNameLabel.Size = new Size(80, 13);
					num = (int)((num2 * 1017727412) ^ 0x694CC432);
					continue;
				case 105u:
					mainForm.processDescriptionLabel.Location = new Point(50, 51);
					num = ((int)num2 * -1041617983) ^ 0x3EAF2233;
					continue;
				case 104u:
					mainForm.processDescriptionLabel.Size = new Size(300, 30);
					num = (int)((num2 * 543612945) ^ 0x27377957);
					continue;
				case 103u:
					mainForm.Resize += mainForm.OnResize;
					num = (int)(num2 * 69849576) ^ -150696988;
					continue;
				case 102u:
					mainForm.Paint += mainForm.OnBackgroundPaint;
					mainForm.MouseUp += mainForm.OnMouseUp;
					num = (int)((num2 * 1878504212) ^ 0x71E41140);
					continue;
				case 101u:
					mainForm.processRefreshTimer.Interval = 250;
					mainForm.processRefreshTimer.Tick += mainForm.OnProcessRefreshTick;
					num = (int)(num2 * 877144372) ^ -395416859;
					continue;
				case 100u:
					((ISupportInitialize)mainForm.processIconPictureBox).EndInit();
					num = (int)((num2 * 286574111) ^ 0x79895100);
					continue;
				case 99u:
					mainForm.selectProcessButton.TabIndex = 2;
					num = ((int)num2 * -1197925703) ^ 0x408D3887;
					continue;
				case 98u:
					mainForm.dllNameColumn.ReadOnly = true;
					mainForm.dllNameColumn.Resizable = DataGridViewTriState.True;
					num = (int)((num2 * 281090728) ^ 0x236D4BD5);
					continue;
				case 97u:
					mainForm.settingsButton.Text = "Settings";
					num = (int)(num2 * 104557800) ^ -579189757;
					continue;
				case 96u:
					mainForm.settingsButton.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1172967689) ^ -1876549448;
					continue;
				case 95u:
					mainForm.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)((num2 * 1810803090) ^ 0x379F72DE);
					continue;
				case 94u:
					mainForm.Font = new Font("Segoe UI", 8.25f);
					num = (int)(num2 * 1185142676) ^ -99868280;
					continue;
				case 93u:
					mainForm.processNameLabel.Text = "Process Name:";
					num = ((int)num2 * -266080850) ^ -1966587284;
					continue;
				case 92u:
					mainForm.toggleButton.UseVisualStyleBackColor = true;
					num = ((int)num2 * -836644726) ^ -676596960;
					continue;
				case 91u:
					mainForm.clearButton.Text = "Clear";
					mainForm.clearButton.UseVisualStyleBackColor = true;
					num = ((int)num2 * -649768545) ^ -352538409;
					continue;
				case 90u:
					mainForm.exportOptionsColumn.Name = "ExportOptions";
					num = ((int)num2 * -1241442092) ^ 0x1202E48;
					continue;
				case 89u:
					mainForm.MaximizeBox = false;
					num = ((int)num2 * -1142072064) ^ -1506149057;
					continue;
				case 88u:
					mainForm.processDescriptionLabel.BackColor = Color.Transparent;
					mainForm.processDescriptionLabel.Font = new Font("Segoe UI", 8.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
					num = (int)((num2 * 1521513386) ^ 0x412AB872);
					continue;
				case 87u:
					mainForm.exportOptionsColumn.HeaderText = "";
					num = (int)(num2 * 751653332) ^ -1524278533;
					continue;
				case 86u:
					mainForm.selectProcessButton.UseVisualStyleBackColor = false;
					num = (int)(num2 * 159244853) ^ -1053628369;
					continue;
				case 85u:
					mainForm.processDescriptionLabel.TabIndex = 4;
					num = ((int)num2 * -49461798) ^ -1251843324;
					continue;
				case 84u:
					mainForm.enabledColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
					num = (int)((num2 * 222543055) ^ 0x7830A661);
					continue;
				case 83u:
					mainForm.toggleButton.Click += mainForm.OnToggleModuleClicked;
					num = ((int)num2 * -46025346) ^ -1904582948;
					continue;
				case 82u:
					mainForm.moduleGrid = new DataGridView();
					mainForm.enabledColumn = new DataGridViewCheckBoxColumn();
					num = ((int)num2 * -1989388591) ^ 0x12F22F0D;
					continue;
				case 81u:
					mainForm.enabledColumn.HeaderText = "";
					num = (int)((num2 * 1711939356) ^ 0x355A262C);
					continue;
				case 80u:
					mainForm.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = ((int)num2 * -2106505726) ^ 0x641E64C;
					continue;
				case 78u:
					mainForm.mainPanel.ResumeLayout(performLayout: false);
					num = (int)((num2 * 1377260926) ^ 0xC8267CD);
					continue;
				case 77u:
					mainForm.moduleGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
					mainForm.moduleGrid.Location = new Point(119, 9);
					mainForm.moduleGrid.MultiSelect = false;
					num = (int)(num2 * 1894785235) ^ -242957968;
					continue;
				case 76u:
					mainForm.removeButton.Click += mainForm.OnRemoveModuleClicked;
					num = ((int)num2 * -2024800412) ^ -1816474049;
					continue;
				case 75u:
					mainForm.dllNameColumn.HeaderText = "DLL Name";
					num = (int)((num2 * 537448966) ^ 0x2A6E261E);
					continue;
				case 74u:
					mainForm.moduleGrid.ColumnHeadersHeight = 22;
					num = (int)(num2 * 1290642526) ^ -2081961831;
					continue;
				case 73u:
					mainForm.clearButton.Location = new Point(11, 93);
					num = ((int)num2 * -220739375) ^ -2079783493;
					continue;
				case 72u:
					mainForm.processDescriptionLabel = new System.Windows.Forms.Label();
					mainForm.processRefreshTimer = new System.Windows.Forms.Timer(mainForm.icontainer_0);
					num = (int)(num2 * 339032192) ^ -819606509;
					continue;
				case 71u:
					mainForm.processNameLabel.TabIndex = 0;
					num = ((int)num2 * -429640179) ^ 0x1AD3822B;
					continue;
				case 70u:
					mainForm.toggleButton.Name = "toggleButton";
					num = (int)(num2 * 61620285) ^ -459257672;
					continue;
				case 69u:
					mainForm.addDllButton.Location = new Point(11, 9);
					mainForm.addDllButton.Name = "addDLLButton";
					mainForm.addDllButton.Size = new Size(98, 22);
					num = (int)((num2 * 1250992992) ^ 0x5D530741);
					continue;
				case 68u:
					mainForm.aboutButton.Text = "About";
					mainForm.aboutButton.UseVisualStyleBackColor = true;
					mainForm.aboutButton.Click += mainForm.OnAboutClicked;
					num = (int)((num2 * 826312611) ^ 0x49D43F52);
					continue;
				case 67u:
					mainForm.processNameLabel.Name = "processNameLabel";
					num = (int)((num2 * 1210373950) ^ 0x33D7471D);
					continue;
				case 66u:
					mainForm.moduleGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
					mainForm.moduleGrid.Columns.AddRange(mainForm.enabledColumn, mainForm.dllNameColumn, mainForm.exportOptionsColumn);
					num = ((int)num2 * -636549150) ^ 0x2F5A9022;
					continue;
				case 65u:
					mainForm.dllNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = ((int)num2 * -1875909539) ^ -512448777;
					continue;
				case 64u:
					mainForm.settingsButton.Name = "settingsButton";
					num = ((int)num2 * -1325099373) ^ 0x2F0FB988;
					continue;
				case 63u:
					mainForm.Controls.Add(mainForm.selectProcessButton);
					num = (int)((num2 * 2038003765) ^ 0x342AE98A);
					continue;
				case 62u:
					mainForm.moduleGrid.RowHeadersVisible = false;
					num = (int)((num2 * 495800954) ^ 0x16365F21);
					continue;
				case 61u:
					mainForm.processIconPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
					mainForm.processIconPictureBox.Location = new Point(11, 16);
					num = ((int)num2 * -1126656535) ^ 0x74DA8AEC;
					continue;
				case 60u:
					mainForm.settingsButton.Location = new Point(131, 221);
					num = (int)((num2 * 2109780093) ^ 0x4A56445);
					continue;
				case 59u:
					mainForm.enabledColumn.Resizable = DataGridViewTriState.False;
					num = (int)((num2 * 1723399399) ^ 0x37852BC9);
					continue;
				case 58u:
					mainForm.mainPanel.Controls.Add(mainForm.moduleGrid);
					num = (int)(num2 * 1705364264) ^ -1682926174;
					continue;
				case 57u:
					mainForm.clearButton.Name = "clearButton";
					num = ((int)num2 * -110341248) ^ -805913985;
					continue;
				case 56u:
					mainForm.processNameTextBox.TabIndex = 1;
					num = ((int)num2 * -1951217459) ^ 0x22C280B9;
					continue;
				case 55u:
					mainForm.clearButton.Size = new Size(98, 22);
					num = (int)((num2 * 433137900) ^ 0x6A077DF6);
					continue;
				case 54u:
					mainForm.processDescriptionLabel.Name = "processDescriptionLabel";
					num = (int)(num2 * 1060800260) ^ -545659172;
					continue;
				case 53u:
					mainForm.mainPanel.Size = new Size(340, 125);
					mainForm.mainPanel.TabIndex = 5;
					mainForm.moduleGrid.AllowUserToAddRows = false;
					num = (int)((num2 * 887031043) ^ 0x77A0D135);
					continue;
				case 52u:
					mainForm.exportOptionsColumn.Text = "";
					mainForm.exportOptionsColumn.Width = 20;
					num = ((int)num2 * -1437773533) ^ 0x244A0A4F;
					continue;
				case 51u:
					mainForm.processNameTextBox.Location = new Point(53, 26);
					mainForm.processNameTextBox.Name = "processNameTextBox";
					mainForm.processNameTextBox.Size = new Size(223, 22);
					num = (int)(num2 * 1926685097) ^ -1288261024;
					continue;
				case 50u:
					mainForm.clearButton.TabIndex = 3;
					num = (int)(num2 * 240719639) ^ -1596572797;
					continue;
				case 49u:
					mainForm.Controls.Add(mainForm.injectionListLabel);
					num = (int)(num2 * 279691398) ^ -211899105;
					continue;
				case 48u:
					mainForm.selectProcessButton.Size = new Size(71, 24);
					num = (int)(num2 * 717372729) ^ -133262046;
					continue;
				case 47u:
					mainForm.injectionListLabel.Name = "injectListLabel";
					mainForm.injectionListLabel.Size = new Size(55, 13);
					num = (int)(num2 * 1250769651) ^ -1427032670;
					continue;
				case 46u:
					componentResourceManager = new ComponentResourceManager(typeof(MainForm));
					mainForm.processNameLabel = new System.Windows.Forms.Label();
					mainForm.processNameTextBox = new TextBox();
					num = ((int)num2 * -799717845) ^ -1093906566;
					continue;
				case 44u:
					mainForm.Text = "Extreme Injector by master131";
					num = (int)(num2 * 1742251337) ^ -1258516507;
					continue;
				case 43u:
					mainForm.removeButton.Size = new Size(98, 22);
					mainForm.removeButton.TabIndex = 2;
					mainForm.removeButton.Text = "Remove";
					mainForm.removeButton.UseVisualStyleBackColor = true;
					num = ((int)num2 * -778116563) ^ 0x10C68A57;
					continue;
				case 42u:
					mainForm.clearButton.Click += mainForm.OnClearModulesClicked;
					num = (int)((num2 * 517360911) ^ 0x6F3D9ED0);
					continue;
				case 41u:
					mainForm.Load += mainForm.OnLoad;
					num = ((int)num2 * -1910028124) ^ -189451995;
					continue;
				case 40u:
					mainForm.Controls.Add(mainForm.processNameTextBox);
					mainForm.Controls.Add(mainForm.processNameLabel);
					num = ((int)num2 * -2006877740) ^ -635111888;
					continue;
				case 39u:
					mainForm.injectionListLabel = new System.Windows.Forms.Label();
					mainForm.injectButton = new Button();
					mainForm.aboutButton = new Button();
					num = (int)((num2 * 952216241) ^ 0x781818F9);
					continue;
				case 38u:
					mainForm.injectionListLabel.TabIndex = 6;
					num = (int)((num2 * 943615260) ^ 0x452DBD58);
					continue;
				case 37u:
					mainForm.AutoScaleMode = AutoScaleMode.Dpi;
					mainForm.ClientSize = new Size(364, 252);
					mainForm.Controls.Add(mainForm.settingsButton);
					mainForm.Controls.Add(mainForm.aboutButton);
					num = (int)(num2 * 1071131732) ^ -1770215914;
					continue;
				case 36u:
					dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
					num = ((int)num2 * -871050817) ^ 0x2925C755;
					continue;
				case 35u:
					mainForm.settingsButton.Click += mainForm.OnSettingsClicked;
					num = ((int)num2 * -873032880) ^ 0x57B47107;
					continue;
				case 34u:
					mainForm.selectProcessButton.Click += mainForm.OnSelectProcessClicked;
					mainForm.processIconPictureBox.BackColor = Color.Transparent;
					num = (int)(num2 * 984849266) ^ -1211573368;
					continue;
				case 33u:
					mainForm.SuspendLayout();
					mainForm.processNameLabel.AutoSize = true;
					mainForm.processNameLabel.BackColor = Color.Transparent;
					mainForm.processNameLabel.Location = new Point(50, 10);
					num = (int)(num2 * 1647120472) ^ -317389358;
					continue;
				case 32u:
					mainForm.removeButton.Location = new Point(11, 65);
					mainForm.removeButton.Name = "removeButton";
					num = ((int)num2 * -1394985991) ^ 0x700C0B72;
					continue;
				case 31u:
					dataGridViewCellStyle.NullValue = "...";
					mainForm.exportOptionsColumn.DefaultCellStyle = dataGridViewCellStyle;
					num = ((int)num2 * -403142616) ^ -1747671080;
					continue;
				case 30u:
					mainForm.moduleGrid.CellMouseUp += mainForm.OnModuleGridCellMouseUp;
					num = ((int)num2 * -2049060302) ^ 0x1814BDF2;
					continue;
				case 29u:
					dataGridViewCellStyle = new DataGridViewCellStyle();
					num = (int)((num2 * 1428776072) ^ 0x1CDB6A71);
					continue;
				case 28u:
					mainForm.mainPanel.Location = new Point(11, 90);
					num = (int)((num2 * 1049078316) ^ 0x592DDA91);
					continue;
				case 27u:
					mainForm.moduleGrid.AllowUserToResizeRows = false;
					num = ((int)num2 * -853181404) ^ 0x586BCA1;
					continue;
				case 26u:
					mainForm.mainPanel.SuspendLayout();
					((ISupportInitialize)mainForm.moduleGrid).BeginInit();
					num = (int)((num2 * 1394959317) ^ 0x30BA2A3);
					continue;
				case 25u:
					mainForm.aboutButton.Name = "aboutButton";
					mainForm.aboutButton.Size = new Size(98, 22);
					num = (int)(num2 * 1185907387) ^ -1832533828;
					continue;
				case 24u:
					mainForm.dllNameColumn.Name = "dllNameColumn";
					num = ((int)num2 * -209981007) ^ -1669725918;
					continue;
				case 23u:
					mainForm.moduleGrid.Size = new Size(211, 106);
					num = ((int)num2 * -1346110853) ^ 0x267DF98F;
					continue;
				case 22u:
					mainForm.moduleGrid.AllowUserToResizeColumns = false;
					num = ((int)num2 * -649631206) ^ -69605369;
					continue;
				case 21u:
					mainForm.settingsButton.TabIndex = 9;
					num = (int)((num2 * 256320581) ^ 0x4C128465);
					continue;
				case 20u:
					mainForm.settingsButton = new Button();
					((ISupportInitialize)mainForm.processIconPictureBox).BeginInit();
					num = (int)(num2 * 350471039) ^ -1004869829;
					continue;
				case 19u:
					mainForm.selectProcessButton = new Button();
					mainForm.processIconPictureBox = new PictureBox();
					num = ((int)num2 * -2005377218) ^ 0x464B473C;
					continue;
				case 18u:
					mainForm.injectButton.Location = new Point(252, 221);
					mainForm.injectButton.Name = "injectButton";
					mainForm.injectButton.Size = new Size(98, 22);
					mainForm.injectButton.TabIndex = 7;
					mainForm.injectButton.Text = "Inject";
					mainForm.injectButton.UseVisualStyleBackColor = true;
					num = (int)(num2 * 1984263502) ^ -344618080;
					continue;
				case 17u:
					mainForm.toggleButton.Location = new Point(11, 37);
					num = (int)(num2 * 696365457) ^ -1217799413;
					continue;
				case 16u:
					mainForm.mainPanel.Controls.Add(mainForm.toggleButton);
					mainForm.mainPanel.Controls.Add(mainForm.addDllButton);
					num = (int)(num2 * 129786574) ^ -1326733635;
					continue;
				case 15u:
					mainForm.mainPanel.Controls.Add(mainForm.clearButton);
					mainForm.mainPanel.Controls.Add(mainForm.removeButton);
					num = ((int)num2 * -1428873082) ^ -1705136680;
					continue;
				case 14u:
					mainForm.settingsButton.Size = new Size(98, 22);
					num = (int)(num2 * 418635406) ^ -1965366387;
					continue;
				case 13u:
					mainForm.processIconPictureBox.TabStop = false;
					mainForm.processIconPictureBox.Click += mainForm.OnProcessIconClicked;
					num = ((int)num2 * -952180804) ^ 0x70F0B458;
					continue;
				case 12u:
					mainForm.Controls.Add(mainForm.injectButton);
					num = (int)(num2 * 1729769580) ^ -1741575655;
					continue;
				case 11u:
					mainForm.injectionListLabel.Text = "Inject List";
					num = (int)(num2 * 880623451) ^ -1747488314;
					continue;
				case 10u:
					mainForm.enabledColumn.Width = 25;
					num = ((int)num2 * -160419026) ^ -98625526;
					continue;
				case 9u:
					mainForm.injectButton.Enabled = false;
					num = (int)(num2 * 122884449) ^ -383463268;
					continue;
				case 8u:
					mainForm.moduleGrid.BackgroundColor = Color.White;
					num = ((int)num2 * -1572573105) ^ 0x6C118803;
					continue;
				case 7u:
					mainForm.clearButton = new Button();
					mainForm.removeButton = new Button();
					mainForm.toggleButton = new Button();
					num = (int)(num2 * 1492730795) ^ -1934313241;
					continue;
				case 6u:
					mainForm.aboutButton.TabIndex = 8;
					num = (int)((num2 * 911259770) ^ 0x612A369B);
					continue;
				case 5u:
					mainForm.dllNameColumn = new DataGridViewTextBoxColumn();
					num = (int)((num2 * 164256153) ^ 0x3CC32369);
					continue;
				case 4u:
					mainForm.Controls.Add(mainForm.mainPanel);
					mainForm.Controls.Add(mainForm.processDescriptionLabel);
					mainForm.Controls.Add(mainForm.processIconPictureBox);
					num = ((int)num2 * -724676943) ^ 0xBA080AA;
					continue;
				case 3u:
					mainForm.moduleGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
					num = (int)(num2 * 750328631) ^ -1387328543;
					continue;
				case 2u:
					mainForm.processIconPictureBox.Name = "processIconPictureBox";
					mainForm.processIconPictureBox.Size = new Size(32, 32);
					mainForm.processIconPictureBox.TabIndex = 3;
					num = (int)(num2 * 710830107) ^ -1010093594;
					continue;
				case 1u:
					mainForm.mainPanel.BackColor = Color.Transparent;
					mainForm.mainPanel.BorderStyle = BorderStyle.FixedSingle;
					num = (int)((num2 * 2018472647) ^ 0x19439367);
					continue;
				case 0u:
					mainForm.addDllButton.TabIndex = 0;
					num = (int)((num2 * 1010534171) ^ 0x1AD0F955);
					continue;
				case 79u:
					break;
				default:
					mainForm.PerformLayout();
					return;
				}
				break;
			}
		}
	}

	internal static Class57 smethod_384(ushort ushort_0)
	{
		return new Class57((IntPtr)ushort_0);
	}

	internal static int smethod_385(Class93 class93_0, GClass1 gclass1_0)
	{
		if (gclass1_0.method_10())
		{
			return smethod_129(class93_0, smethod_255(class93_0.method_19()), gclass1_0.method_0());
		}
		return smethod_129(class93_0, smethod_369(class93_0.method_19()), gclass1_0.method_0());
	}

	[DllImport("kernel32.dll")]
	internal static extern int GetThreadPriority(IntPtr intptr_0);

	internal static Class56.Struct11 smethod_386(Class56 class56_0)
	{
		return Class56.smethod_0<Class56.Struct7, Class56.Struct11>(class56_0.method_0());
	}

	internal static bool smethod_387(Class137 class137_0)
	{
		return class137_0.method_0() != null;
	}

	internal static void smethod_388(Class82 class82_0)
	{
		if (class82_0.method_6() != null)
		{
			goto IL_001a;
		}
		goto IL_00b0;
		IL_001a:
		int num = 2024457989;
		goto IL_0074;
		IL_0074:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x28A5DB30)) % 7)
			{
			case 6u:
				break;
			case 4u:
				CloseHandle(class82_0.method_2());
				num = (int)((num2 * 375033129) ^ 0x1395D966);
				continue;
			case 2u:
				class82_0.method_6().imethod_6(class82_0.method_2());
				num = (int)(num2 * 404934870) ^ -545109904;
				continue;
			case 0u:
				class82_0.method_3(IntPtr.Zero);
				num = (int)((num2 * 127881160) ^ 0x34661AF4);
				continue;
			default:
				return;
			case 5u:
				goto IL_00b0;
			case 1u:
				return;
			case 3u:
				return;
			}
			break;
		}
		goto IL_001a;
		IL_00b0:
		num = ((class82_0.method_2() != IntPtr.Zero) ? 1654359615 : 1861459900);
		goto IL_0074;
	}

	internal static Class166 smethod_389(Class154 class154_0, Class5 class5_0)
	{
		Class157 @class = class154_0.method_6().method_3().imethod_49()[2];
		if (@class.method_0() != 0)
		{
			long num3 = default(long);
			while (true)
			{
				int num = 859986465;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x37794B80)) % 9)
					{
					case 8u:
						break;
					case 7u:
						num = ((@class.method_2() != 0) ? 48567019 : 710211152) ^ ((int)num2 * -164523125);
						continue;
					case 3u:
						goto IL_007e;
					case 0u:
						num = ((!class5_0.imethod_0(num3)) ? 1263054894 : 1881548291) ^ ((int)num2 * -402477833);
						continue;
					case 5u:
						goto end_IL_00c8;
					default:
						return new Class166(class5_0, num3, @class.method_2());
					case 4u:
						return null;
					case 6u:
						return null;
					case 2u:
						goto end_IL_00fe;
					}
					num3 = smethod_135(class154_0, @class.method_0());
					num = ((num3 != -1L) ? 981242901 : 21259501);
					continue;
					IL_007e:
					num = (class5_0.imethod_0(num3) ? 78853978 : 371388783);
					continue;
					end_IL_00c8:
					break;
				}
				continue;
				end_IL_00fe:
				break;
			}
		}
		return null;
	}

	internal static Class57 smethod_390(IntPtr intptr_0)
	{
		return new Class57(intptr_0);
	}

	internal static void smethod_391(Class47 class47_0, object object_0, int int_0)
	{
		Class47.Class48 @class = object_0 as Class47.Class48;
		Class63 class3 = default(Class63);
		Class59 class59_ = default(Class59);
		Class57 class2 = default(Class57);
		while (true)
		{
			int num = -129526793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -166401786)) % 15)
				{
				case 14u:
					class3 = object_0 as Class63;
					num = -1657962017;
					continue;
				case 11u:
					smethod_324(class59_, class47_0, int_0);
					num = ((int)num2 * -71044171) ^ 0x16DFE349;
					continue;
				case 10u:
					num = ((@class == null) ? 1752018050 : 909060028) ^ ((int)num2 * -91658263);
					continue;
				case 8u:
					num = ((!smethod_278(class59_, null)) ? 1786717269 : 1409204151) ^ (int)(num2 * 1633103399);
					continue;
				case 5u:
					num = ((!smethod_392(null, class3)) ? (-474050390) : (-1884301972)) ^ (int)(num2 * 965553881);
					continue;
				case 4u:
					class2 = object_0.smethod_0();
					num = ((!smethod_49(class2, null)) ? (-2028432363) : (-1323049905));
					continue;
				case 2u:
					class59_ = object_0 as Class59;
					num = -1075158410;
					continue;
				case 1u:
					smethod_236(int_0, @class.method_0(), class47_0);
					num = (int)((num2 * 1251070644) ^ 0x73377B37);
					continue;
				case 0u:
					smethod_199(int_0, class47_0, class3);
					num = ((int)num2 * -1813522895) ^ 0x18025E0B;
					continue;
				case 13u:
					break;
				case 3u:
					return;
				case 6u:
					return;
				case 7u:
					return;
				default:
					throw new InvalidOperationException("Unknown object type.");
				case 12u:
					smethod_121(class47_0, class2, int_0, object_0 is float || object_0 is double);
					return;
				}
				break;
			}
		}
	}

	internal static bool smethod_392(Class62 class62_0, Class62 class62_1)
	{
		return !smethod_134(class62_0, class62_1);
	}

	internal static bool smethod_393(ref Class124.Struct55 struct55_0, IntPtr intptr_0)
	{
		IntPtr intPtr = smethod_13(ref struct55_0);
		bool threadContext_ = GetThreadContext_1(intptr_0, intPtr);
		struct55_0 = (Class124.Struct55)Marshal.PtrToStructure(intPtr, typeof(Class124.Struct55));
		Marshal.FreeHGlobal(intPtr);
		return threadContext_;
	}

	internal static byte[] smethod_394(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		int num15 = default(int);
		byte[] array = default(byte[]);
		int num10 = default(int);
		Class179.Class180 class180_ = default(Class179.Class180);
		int num17 = default(int);
		Class179.Stream1 stream = default(Class179.Stream1);
		Assembly executingAssembly = default(Assembly);
		byte[] array2 = default(byte[]);
		byte[] buffer2 = default(byte[]);
		int num7 = default(int);
		int num4 = default(int);
		int num14 = default(int);
		int num5 = default(int);
		int num16 = default(int);
		byte[] array3 = default(byte[]);
		int num8 = default(int);
		byte[] byte_2 = default(byte[]);
		byte[] byte_1 = default(byte[]);
		int num13 = default(int);
		short num12 = default(short);
		int num6 = default(int);
		while (true)
		{
			int num = 2084661810;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1927AF85)) % 43)
				{
				case 42u:
					if (num15 == 8223355)
					{
						num = ((int)num2 * -1423958588) ^ 0x4C99C694;
						continue;
					}
					throw new FormatException(global::_003CModule_003E.smethod_6<string>(652446713u));
				case 41u:
					array = new byte[num10];
					smethod_130(array, 0, array.Length, class180_);
					num = ((int)num2 * -1951450026) ^ 0x1BA608A9;
					continue;
				case 40u:
					num17 = smethod_44(stream);
					num = 1584765976;
					continue;
				case 39u:
					num = (((object)callingAssembly == executingAssembly) ? 450498189 : 333576264) ^ ((int)num2 * -1557891625);
					continue;
				case 37u:
					array2 = null;
					num = ((int)num2 * -988193461) ^ -2087407615;
					continue;
				case 36u:
					stream.Read(buffer2, 0, num7);
					num = (int)(num2 * 1662088055) ^ -1844953627;
					continue;
				case 35u:
					num4 = smethod_438(stream);
					num = (int)(num2 * 687267926) ^ -256706861;
					continue;
				case 34u:
					executingAssembly = Assembly.GetExecutingAssembly();
					num = ((int)num2 * -1341153411) ^ -170705251;
					continue;
				case 33u:
					num = ((num14 == 8) ? (-1235297755) : (-436906431)) ^ ((int)num2 * -162892323);
					continue;
				case 32u:
					num5 += num16;
					num = ((int)num2 * -1447097608) ^ 0xB65E8B1;
					continue;
				case 31u:
				{
					Class179.Class180 class180_2 = new Class179.Class180(array3);
					smethod_130(array, num5, num16, class180_2);
					num = (int)((num2 * 1646846372) ^ 0x5A98D1F1);
					continue;
				}
				case 30u:
					num16 = smethod_44(stream);
					num = (int)(num2 * 1338174329) ^ -1695356140;
					continue;
				case 29u:
					array2 = new byte[stream.Length - stream.Position];
					num = 285917028;
					continue;
				case 27u:
					num = ((num8 == 1) ? 1962410568 : 1510670623) ^ (int)(num2 * 33805074);
					continue;
				case 26u:
					byte_2 = new byte[8] { 245, 35, 118, 82, 159, 2, 179, 67 };
					byte_1 = new byte[8] { 149, 124, 101, 201, 198, 183, 16, 200 };
					num = ((int)num2 * -1807682236) ^ -2063206412;
					continue;
				case 24u:
					num5 = 0;
					num = (int)(num2 * 647388997) ^ -1279447323;
					continue;
				case 22u:
					num = ((num7 <= 0) ? 1889133095 : 1621947028) ^ ((int)num2 * -47246172);
					continue;
				case 21u:
					num = ((num4 > 0) ? 1434514464 : 1802782173);
					continue;
				case 20u:
					smethod_44(stream);
					num = 2073493279;
					continue;
				case 19u:
					num7 = smethod_438(stream);
					num = (int)(num2 * 583068184) ^ -445344040;
					continue;
				case 18u:
					stream = new Class179.Stream1(byte_0);
					array = new byte[0];
					num15 = smethod_44(stream);
					num = ((num15 != 67324752) ? 233147962 : 150849871);
					continue;
				case 17u:
					class180_ = new Class179.Class180(array2);
					num = (int)(num2 * 2070202676) ^ -577676857;
					continue;
				case 16u:
					num = ((int)num2 * -987621096) ^ 0x75628419;
					continue;
				case 15u:
					num = -1551367080 ^ (int)(num2 * 1482078290);
					continue;
				case 14u:
					buffer2 = new byte[num7];
					num = ((int)num2 * -376626958) ^ 0x74EE63B9;
					continue;
				case 13u:
					array3 = new byte[num17];
					stream.Read(array3, 0, array3.Length);
					num = ((int)num2 * -1215556530) ^ 0x79C62F6B;
					continue;
				case 12u:
					num = ((num13 != 0) ? (-380144132) : (-44838044)) ^ (int)(num2 * 2134181347);
					continue;
				case 10u:
					num8 = num15 >> 24;
					num15 -= num8 << 24;
					num = 1798620140;
					continue;
				case 9u:
					num10 = smethod_44(stream);
					num = (int)(num2 * 639585838) ^ -2110098754;
					continue;
				case 8u:
					stream.Read(array2, 0, array2.Length);
					num = ((int)num2 * -940203326) ^ -832736534;
					continue;
				case 7u:
					num = ((num12 == 20) ? 1254399058 : 1457564415) ^ ((int)num2 * -861250007);
					continue;
				case 6u:
					num = ((num15 == 67324752) ? (-2047857318) : (-380821144)) ^ (int)(num2 * 781412546);
					continue;
				case 5u:
					num6 = smethod_44(stream);
					array = new byte[num6];
					num = (int)(num2 * 1828164250) ^ -1342128900;
					continue;
				case 4u:
					smethod_44(stream);
					smethod_44(stream);
					num = ((int)num2 * -2065173792) ^ 0x36D4A21B;
					continue;
				case 3u:
					num12 = (short)smethod_438(stream);
					num13 = smethod_438(stream);
					num14 = smethod_438(stream);
					num = (int)(num2 * 1556549725) ^ -1615850910;
					continue;
				case 2u:
					if (num8 == 2)
					{
						num = 1138628349;
						continue;
					}
					goto IL_0624;
				case 1u:
					num = ((num5 >= num6) ? 278285861 : 2117242782);
					continue;
				case 0u:
				{
					byte[] buffer = new byte[num4];
					stream.Read(buffer, 0, num4);
					num = ((int)num2 * -297450029) ^ 0x8694422;
					continue;
				}
				case 38u:
					break;
				case 11u:
					throw new FormatException(global::_003CModule_003E.smethod_5<string>(1515669233u));
				default:
				{
					ICryptoTransform cryptoTransform = smethod_198(bool_0: true, byte_1, byte_2);
					try
					{
						byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
						array = smethod_394(byte_3);
					}
					finally
					{
						if (cryptoTransform != null)
						{
							while (true)
							{
								IL_061c:
								int num3 = 760046348;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x1927AF85)) % 3)
									{
									case 1u:
										goto IL_05e9;
									default:
										goto end_IL_05fe;
									case 0u:
										break;
									case 2u:
										goto end_IL_05fe;
									}
									goto IL_061c;
									IL_05e9:
									cryptoTransform.Dispose();
									num3 = (int)((num2 * 520876455) ^ 0x1E067734);
									continue;
									end_IL_05fe:
									break;
								}
								break;
							}
						}
					}
					goto IL_0624;
				}
				case 25u:
					return null;
				case 28u:
					{
						while (true)
						{
							stream.Close();
							stream = null;
							int num11 = 594419060;
							while (true)
							{
								switch ((uint)(num11 ^ 0x1927AF85) % 3u)
								{
								case 0u:
									goto IL_06bd;
								case 2u:
									break;
								default:
									return array;
								}
								break;
								IL_06bd:
								num11 = 1936454571;
							}
						}
					}
					IL_0624:
					if (num8 == 3)
					{
						byte[] byte_4 = new byte[16]
						{
							1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
							1, 1, 1, 1, 1, 1
						};
						byte[] byte_5 = new byte[16]
						{
							2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
							2, 2, 2, 2, 2, 2
						};
						ICryptoTransform cryptoTransform2 = smethod_435(bool_0: true, byte_4, byte_5);
						try
						{
							byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
							array = smethod_394(byte_6);
						}
						finally
						{
							if (cryptoTransform2 != null)
							{
								while (true)
								{
									IL_06b3:
									int num9 = 1503041174;
									while (true)
									{
										switch ((num2 = (uint)(num9 ^ 0x1927AF85)) % 3)
										{
										case 2u:
											goto IL_0680;
										default:
											goto end_IL_0695;
										case 0u:
											break;
										case 1u:
											goto end_IL_0695;
										}
										goto IL_06b3;
										IL_0680:
										cryptoTransform2.Dispose();
										num9 = (int)(num2 * 923059477) ^ -1924769889;
										continue;
										end_IL_0695:
										break;
									}
									break;
								}
							}
						}
					}
					goto case 28u;
				}
				break;
			}
		}
	}

	internal static Class59 smethod_395(long long_0, Class63 class63_0)
	{
		return smethod_433((IntPtr)long_0, 4u, class63_0);
	}

	[DllImport("ntdll.dll")]
	internal static extern int RtlNtStatusToDosError(uint uint_0);

	internal static void smethod_396(Class179.Class181 class181_0, int int_0)
	{
		class181_0.uint_0 >>= int_0;
		class181_0.int_2 -= int_0;
	}

	internal static IntPtr smethod_397(Class53 class53_0)
	{
		if (!Class49.bool_0)
		{
			return Class52.smethod_18()(ref class53_0.struct19_0);
		}
		return Class52.smethod_20()(ref class53_0.struct19_0);
	}

	internal static bool smethod_398(Class5 class5_0, uint uint_0, out Class163 class163_0)
	{
		class163_0 = null;
		int num3 = default(int);
		long position = default(long);
		while (true)
		{
			int num = 1634651316;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x412F1542)) % 15)
				{
				case 14u:
					num = ((int)num2 * -360191035) ^ -1683521346;
					continue;
				case 13u:
					num = (int)(num2 * 1580822766) ^ -1087349522;
					continue;
				case 12u:
					class163_0.imethod_49()[num3] = new Class157(class5_0);
					num = ((int)num2 * -347717711) ^ -911602243;
					continue;
				case 10u:
				{
					Class163 @class = new Class163();
					@class.vmethod_0(class5_0.ReadUInt16());
					@class.imethod_2(class5_0.ReadByte());
					@class.imethod_4(class5_0.ReadByte());
					@class.imethod_6(class5_0.ReadUInt32());
					@class.imethod_8(class5_0.ReadUInt32());
					@class.imethod_10(class5_0.ReadUInt32());
					@class.imethod_12(class5_0.ReadUInt32());
					@class.imethod_14(class5_0.ReadUInt32());
					@class.vmethod_1(class5_0.ReadUInt64());
					@class.vmethod_2(class5_0.ReadUInt32());
					@class.vmethod_3(class5_0.ReadUInt32());
					@class.vmethod_4(class5_0.ReadUInt16());
					@class.vmethod_5(class5_0.ReadUInt16());
					@class.imethod_23(class5_0.ReadUInt16());
					@class.imethod_25(class5_0.ReadUInt16());
					@class.vmethod_6(class5_0.ReadUInt16());
					@class.vmethod_7(class5_0.ReadUInt16());
					@class.vmethod_8(class5_0.ReadUInt32());
					@class.imethod_30(class5_0.ReadUInt32());
					@class.vmethod_9(class5_0.ReadUInt32());
					@class.imethod_33(class5_0.ReadUInt32());
					@class.vmethod_10((Enum42)class5_0.ReadUInt16());
					@class.imethod_36((Enum38)class5_0.ReadUInt16());
					@class.imethod_38(class5_0.ReadUInt64());
					@class.imethod_40(class5_0.ReadUInt64());
					@class.imethod_42(class5_0.ReadUInt64());
					@class.imethod_44(class5_0.ReadUInt64());
					@class.imethod_46(class5_0.ReadUInt32());
					@class.imethod_48(class5_0.ReadUInt32());
					class163_0 = @class;
					num = ((int)num2 * -1296555871) ^ -1699984736;
					continue;
				}
				case 9u:
					num = ((num3 < class163_0.imethod_49().Length) ? 687295106 : 677159218);
					continue;
				case 8u:
					num = (((uint)((int)(class5_0.BaseStream.Position - position) + 8) > uint_0) ? 1636693032 : 1615526116);
					continue;
				case 7u:
					position = class5_0.BaseStream.Position;
					num = 1330097401;
					continue;
				case 5u:
					num = ((uint_0 < 112) ? 185596435 : 146696778) ^ ((int)num2 * -1994459585);
					continue;
				case 4u:
					num3++;
					num = 2041306743;
					continue;
				case 2u:
					class5_0.BaseStream.Position = position + uint_0;
					num = (int)(num2 * 1881403685) ^ -326380630;
					continue;
				case 1u:
					num3 = 0;
					num = (int)((num2 * 1435773665) ^ 0xA9FC32E);
					continue;
				case 0u:
					class163_0.imethod_49()[num3] = new Class157();
					num = 1591733776;
					continue;
				case 11u:
					break;
				default:
					return true;
				case 6u:
					return false;
				}
				break;
			}
		}
	}

	internal static bool smethod_399(GClass2 gclass2_0)
	{
		return gclass2_0.bool_2;
	}

	[DllImport("kernel32.dll", EntryPoint = "GetThreadContext")]
	internal static extern bool GetThreadContext_1(IntPtr intptr_0, IntPtr intptr_1);

	internal static void smethod_400(IntPtr intptr_0, Class109 class109_0)
	{
		class109_0.method_18(intptr_0);
	}

	internal static int smethod_401(Class179.Class181 class181_0)
	{
		return class181_0.int_1 - class181_0.int_0 + (class181_0.int_2 >> 3);
	}

	internal static Enum14 smethod_402(Class76 class76_0)
	{
		return (Enum14)class76_0.struct40_0.uint_3;
	}

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	internal unsafe static extern bool WriteProcessMemory_1(IntPtr intptr_0, IntPtr intptr_1, byte* pByte_0, UIntPtr uintptr_0, UIntPtr* pUintPtr_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr SendMessageTimeout(IntPtr intptr_0, uint uint_0, UIntPtr uintptr_0, IntPtr intptr_1, Class124.Enum20 enum20_0, uint uint_1, out IntPtr intptr_2);

	internal static Class56.Struct14 smethod_403(Class56 class56_0)
	{
		return Class56.smethod_0<Class56.Struct7, Class56.Struct14>(class56_0.method_0());
	}

	internal static string smethod_404(Class5 class5_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			bool flag = true;
			int num3 = default(int);
			byte b = default(byte);
			byte[] array = default(byte[]);
			while (true)
			{
				int num = ((!flag) ? 1716743178 : 631100482);
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x52F71297)) % 13)
					{
					case 12u:
						num = ((num3 < 16) ? 1537929263 : 689050140);
						continue;
					case 11u:
						num3 = 0;
						num = (int)((num2 * 519083441) ^ 0x49EC9EF8);
						continue;
					case 10u:
						b = array[num3];
						num = 1830812451;
						continue;
					case 9u:
						class5_0.BaseStream.Position -= 15 - num3;
						num = (int)(num2 * 881359187) ^ -1047748261;
						continue;
					case 8u:
						num = ((int)num2 * -479388399) ^ -997211451;
						continue;
					case 7u:
						num = ((b != 0) ? (-1146135692) : (-1451420060)) ^ ((int)num2 * -949210825);
						continue;
					case 6u:
						num = 631100482;
						continue;
					case 5u:
						flag = false;
						num = ((int)num2 * -674214030) ^ 0x6E9438AC;
						continue;
					case 4u:
						stringBuilder.Append((char)b);
						num = 1549077182;
						continue;
					case 3u:
						num3++;
						num = ((int)num2 * -1832289219) ^ 0x633E4C12;
						continue;
					case 1u:
						array = class5_0.ReadBytes(16);
						num = 1672222792;
						continue;
					case 0u:
						break;
					default:
						return stringBuilder.ToString();
					}
					break;
				}
			}
		}
		catch
		{
			return stringBuilder.ToString();
		}
	}

	internal static void smethod_405(string string_0, MainForm mainForm, string string_1, string string_2, string string_3)
	{
		DialogResult dialogResult = MessageBox.Show(mainForm, "The DLL you have selected, \"" + string_0 + "\" requires \"" + string_3 + "\" in order to work properly, but it appears you do not have this file on the system or have installed it incorrectly. Extreme Injector can download this file automatically for you. Click 'Yes' to do it automatically, 'No' to do it manually or 'Cancel' to ignore.", "Extreme Injector v3", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
		if (dialogResult == DialogResult.Yes)
		{
			goto IL_00bf;
		}
		goto IL_0147;
		IL_00bf:
		int num = -2077519238;
		goto IL_0102;
		IL_0102:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1204839189)) % 9)
			{
			case 8u:
				MessageBox.Show(mainForm, "When the page appears, download and extract the DLL files inside the ZIP file to \"" + string_1 + "\" (look at the path carefully).", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				num = ((int)num2 * -1180998039) ^ -766772100;
				continue;
			case 7u:
			{
				DependencyInstallerForm form = new DependencyInstallerForm();
				smethod_50(form, string_2, string_1);
				form.ShowDialog();
				num = -1712413616;
				continue;
			}
			case 5u:
				break;
			case 2u:
				Process.Start(string_2);
				num = (int)((num2 * 185510003) ^ 0x1DBAA607);
				continue;
			case 1u:
				num = ((!smethod_272()) ? 510315496 : 33659344) ^ ((int)num2 * -1135787917);
				continue;
			default:
				return;
			case 6u:
				goto IL_0147;
			case 0u:
				return;
			case 3u:
				MessageBox.Show(mainForm, "You must restart Extreme Injector as an administrator in order to do this otherwise it will not be able to save the files properly.", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			case 4u:
				return;
			}
			break;
		}
		goto IL_00bf;
		IL_0147:
		num = ((dialogResult != DialogResult.No) ? (-1900042582) : (-1842604189));
		goto IL_0102;
	}

	internal static void smethod_406(ProcessInspectorForm form4_0)
	{
		form4_0.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		while (true)
		{
			int num = 1492183839;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x63FE30A9)) % 119)
				{
				case 118u:
					form4_0.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
					form4_0.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
					num = (int)(num2 * 1124877414) ^ -1802278058;
					continue;
				case 117u:
					form4_0.button_2.Name = "closeButton";
					num = (int)((num2 * 516890950) ^ 0x52EB762);
					continue;
				case 116u:
					form4_0.groupBox_0.ResumeLayout(performLayout: false);
					num = (int)(num2 * 1800037052) ^ -986107357;
					continue;
				case 115u:
					form4_0.dataGridViewTextBoxColumn_1.Name = "moduleBaseColumn";
					form4_0.dataGridViewTextBoxColumn_1.ReadOnly = true;
					form4_0.dataGridViewTextBoxColumn_1.Width = 120;
					num = (int)(num2 * 678514833) ^ -2021011883;
					continue;
				case 114u:
					form4_0.groupBox_0.Size = new Size(387, 154);
					num = ((int)num2 * -1806196393) ^ -1305373541;
					continue;
				case 113u:
					form4_0.tabPage_1.Controls.Add(form4_0.button_3);
					form4_0.tabPage_1.Controls.Add(form4_0.dataGridView_1);
					num = ((int)num2 * -2053778814) ^ 0x60100D28;
					continue;
				case 112u:
					form4_0.dataGridViewTextBoxColumn_3.Name = "threadIDColumn";
					form4_0.dataGridViewTextBoxColumn_3.ReadOnly = true;
					num = (int)((num2 * 126284135) ^ 0x26FAA06E);
					continue;
				case 111u:
					form4_0.groupBox_0.SuspendLayout();
					num = (int)(num2 * 685889998) ^ -621253256;
					continue;
				case 110u:
					form4_0.SuspendLayout();
					form4_0.button_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					num = ((int)num2 * -1222856088) ^ -754095682;
					continue;
				case 109u:
					form4_0.label_0.Location = new Point(47, 21);
					num = ((int)num2 * -1662144353) ^ 0x6B3A0129;
					continue;
				case 108u:
					form4_0.Text = "Process Information";
					form4_0.Load += form4_0.method_8;
					num = ((int)num2 * -1915030955) ^ -1304656414;
					continue;
				case 107u:
					form4_0.button_2.TabIndex = 12;
					num = (int)(num2 * 738674761) ^ -1603169623;
					continue;
				case 106u:
					form4_0.dataGridViewTextBoxColumn_4.Name = "threadStartAddressColumn";
					num = ((int)num2 * -1757421603) ^ 0x37CCD6DB;
					continue;
				case 105u:
					form4_0.button_3.Name = "resumeSuspendButton";
					num = (int)((num2 * 546010240) ^ 0x4D5EB1DE);
					continue;
				case 104u:
					((ISupportInitialize)form4_0.dataGridView_1).BeginInit();
					num = ((int)num2 * -2038056785) ^ -166752477;
					continue;
				case 103u:
					form4_0.dataGridView_0.SelectionChanged += form4_0.method_6;
					num = (int)((num2 * 266197842) ^ 0xBF6A3D6);
					continue;
				case 102u:
					form4_0.button_1.Click += form4_0.method_9;
					num = ((int)num2 * -232926698) ^ 0x7370333D;
					continue;
				case 101u:
					form4_0.pictureBox_0.BackColor = Color.Transparent;
					num = (int)((num2 * 1227468866) ^ 0x5833D78E);
					continue;
				case 100u:
					form4_0.pictureBox_0.Name = "processPictureBox";
					num = (int)(num2 * 1304826556) ^ -356742038;
					continue;
				case 99u:
					form4_0.button_1.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1113096251) ^ -1073347928;
					continue;
				case 97u:
					form4_0.dataGridViewTextBoxColumn_0.ReadOnly = true;
					num = (int)((num2 * 868330073) ^ 0x59D77B0A);
					continue;
				case 96u:
					form4_0.dataGridView_0.Size = new Size(379, 209);
					form4_0.dataGridView_0.TabIndex = 11;
					num = (int)((num2 * 1125691275) ^ 0x7536D43);
					continue;
				case 95u:
					form4_0.dataGridView_1 = new DataGridView();
					num = (int)((num2 * 1573467732) ^ 0x17D5F085);
					continue;
				case 94u:
					form4_0.dataGridView_0.ReadOnly = true;
					form4_0.dataGridView_0.RowHeadersVisible = false;
					form4_0.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					num = (int)((num2 * 635603845) ^ 0x513136A2);
					continue;
				case 93u:
					form4_0.MaximizeBox = false;
					form4_0.MinimizeBox = false;
					num = (int)(num2 * 1332529162) ^ -1781430736;
					continue;
				case 92u:
					form4_0.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
					num = (int)((num2 * 899714683) ^ 0x7653ACA2);
					continue;
				case 91u:
					form4_0.tabPage_1.Size = new Size(379, 240);
					form4_0.tabPage_1.TabIndex = 1;
					num = ((int)num2 * -1276110064) ^ -1088871325;
					continue;
				case 90u:
					form4_0.Controls.Add(form4_0.groupBox_0);
					num = (int)((num2 * 826979221) ^ 0x1D4E7E6C);
					continue;
				case 89u:
					form4_0.dataGridView_0.Location = new Point(0, 0);
					num = ((int)num2 * -115037066) ^ 0xC5D39C5;
					continue;
				case 88u:
					form4_0.tabPage_1.ResumeLayout(performLayout: false);
					((ISupportInitialize)form4_0.dataGridView_1).EndInit();
					num = ((int)num2 * -1077379614) ^ -1113381826;
					continue;
				case 87u:
					form4_0.pictureBox_0.Size = new Size(32, 32);
					num = (int)(num2 * 626272854) ^ -786755609;
					continue;
				case 86u:
					form4_0.button_2.Location = new Point(302, 442);
					num = ((int)num2 * -1118313406) ^ -1736549970;
					continue;
				case 85u:
					((ISupportInitialize)form4_0.pictureBox_0).EndInit();
					num = ((int)num2 * -558872750) ^ -1135206156;
					continue;
				case 84u:
					form4_0.groupBox_0.Name = "processGroupBox";
					num = ((int)num2 * -1149068105) ^ -1061866957;
					continue;
				case 83u:
					form4_0.button_1 = new Button();
					num = (int)((num2 * 1308665203) ^ 0x397F3468);
					continue;
				case 82u:
					form4_0.tabPage_0.TabIndex = 0;
					form4_0.tabPage_0.Text = "Modules";
					form4_0.tabPage_0.UseVisualStyleBackColor = true;
					num = ((int)num2 * -704552755) ^ 0xB1B455B;
					continue;
				case 81u:
					form4_0.dataGridView_0.AllowUserToDeleteRows = false;
					num = (int)((num2 * 616231219) ^ 0x68720078);
					continue;
				case 80u:
					form4_0.label_0.Name = "processDetailsLabel";
					form4_0.label_0.Size = new Size(334, 123);
					num = ((int)num2 * -1839246135) ^ -1655881458;
					continue;
				case 79u:
					form4_0.tabControl_0.ResumeLayout(performLayout: false);
					num = (int)(num2 * 5593930) ^ -489349702;
					continue;
				case 78u:
					form4_0.dataGridViewTextBoxColumn_0.Width = 150;
					form4_0.dataGridViewTextBoxColumn_1.HeaderText = "Module Base";
					num = ((int)num2 * -627271498) ^ -453027333;
					continue;
				case 77u:
					form4_0.pictureBox_0.TabIndex = 4;
					form4_0.pictureBox_0.TabStop = false;
					num = (int)((num2 * 575197394) ^ 0x7C6C653C);
					continue;
				case 76u:
					form4_0.dataGridViewTextBoxColumn_2.Name = "moduleSizeColumn";
					num = (int)(num2 * 1150989671) ^ -984335465;
					continue;
				case 75u:
					form4_0.button_0.UseVisualStyleBackColor = true;
					num = ((int)num2 * -1839120619) ^ -224645727;
					continue;
				case 74u:
					form4_0.dataGridView_1.MultiSelect = false;
					form4_0.dataGridView_1.Name = "threadsDataGridView";
					form4_0.dataGridView_1.ReadOnly = true;
					num = ((int)num2 * -522734500) ^ -1417891544;
					continue;
				case 73u:
					form4_0.dataGridView_0.AllowUserToResizeRows = false;
					form4_0.dataGridView_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = (int)(num2 * 1116552455) ^ -1850935632;
					continue;
				case 72u:
					form4_0.button_3.TabIndex = 15;
					form4_0.button_3.Text = "Suspend";
					num = ((int)num2 * -2012751643) ^ 0x71E45379;
					continue;
				case 71u:
					form4_0.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = ((int)num2 * -916768898) ^ -1675268683;
					continue;
				case 70u:
					form4_0.tabControl_0.Size = new Size(387, 266);
					form4_0.tabControl_0.TabIndex = 15;
					form4_0.tabPage_0.Controls.Add(form4_0.dataGridView_0);
					form4_0.tabPage_0.Controls.Add(form4_0.button_1);
					form4_0.tabPage_0.Location = new Point(4, 22);
					form4_0.tabPage_0.Name = "modulesTabPage";
					form4_0.tabPage_0.Size = new Size(379, 240);
					num = ((int)num2 * -820701765) ^ 0x7900772D;
					continue;
				case 69u:
					form4_0.dataGridView_1.AllowUserToAddRows = false;
					form4_0.dataGridView_1.AllowUserToDeleteRows = false;
					form4_0.dataGridView_1.AllowUserToResizeRows = false;
					form4_0.dataGridView_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = (int)(num2 * 161592687) ^ -595772479;
					continue;
				case 68u:
					form4_0.button_1.Location = new Point(279, 215);
					form4_0.button_1.Name = "unloadButton";
					num = ((int)num2 * -1645207230) ^ -137170787;
					continue;
				case 67u:
					form4_0.dataGridView_0.SortCompare += form4_0.method_7;
					num = (int)((num2 * 1330864667) ^ 0x700FD12E);
					continue;
				case 66u:
					form4_0.button_3.Enabled = false;
					form4_0.button_3.Location = new Point(279, 215);
					num = (int)(num2 * 1371478191) ^ -1203268546;
					continue;
				case 65u:
					form4_0.button_2.Size = new Size(97, 22);
					num = ((int)num2 * -1039482067) ^ 0x43F2B95E;
					continue;
				case 63u:
					form4_0.dataGridView_0.Name = "modulesDataGridView";
					num = ((int)num2 * -2067419219) ^ 0x673198DF;
					continue;
				case 62u:
					form4_0.pictureBox_0.Location = new Point(9, 21);
					num = (int)((num2 * 948978901) ^ 0x4D6C8CB7);
					continue;
				case 61u:
					form4_0.timer_0.Interval = 250;
					form4_0.timer_0.Tick += form4_0.method_5;
					num = (int)((num2 * 1569841658) ^ 0x1AF328A8);
					continue;
				case 60u:
					form4_0.button_3.Click += form4_0.method_11;
					num = ((int)num2 * -881506109) ^ 0x476F2135;
					continue;
				case 59u:
					form4_0.tabPage_1.Controls.Add(form4_0.button_4);
					num = (int)(num2 * 1988707896) ^ -518722822;
					continue;
				case 58u:
					form4_0.dataGridViewTextBoxColumn_4.ReadOnly = true;
					form4_0.dataGridViewTextBoxColumn_5.HeaderText = "Priority";
					form4_0.dataGridViewTextBoxColumn_5.Name = "threadStateColumn";
					num = (int)((num2 * 999546692) ^ 0x26FBE465);
					continue;
				case 57u:
					form4_0.groupBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
					form4_0.groupBox_0.Controls.Add(form4_0.label_0);
					form4_0.groupBox_0.Controls.Add(form4_0.pictureBox_0);
					num = (int)(num2 * 1478561824) ^ -1687204159;
					continue;
				case 56u:
					form4_0.button_0.Click += form4_0.method_4;
					form4_0.dataGridView_0.AllowUserToAddRows = false;
					num = ((int)num2 * -189976035) ^ -1051190262;
					continue;
				case 55u:
					form4_0.tabPage_1.SuspendLayout();
					num = (int)((num2 * 418906612) ^ 0x4E0FBAC7);
					continue;
				case 54u:
					form4_0.dataGridViewTextBoxColumn_2.ReadOnly = true;
					num = (int)((num2 * 9393747) ^ 0x66D13BBA);
					continue;
				case 53u:
					form4_0.groupBox_0.TabStop = false;
					num = ((int)num2 * -950236462) ^ 0x7833970B;
					continue;
				case 52u:
					form4_0.tabControl_0 = new TabControl();
					form4_0.tabPage_0 = new TabPage();
					num = (int)((num2 * 1578810192) ^ 0x681D1D9E);
					continue;
				case 51u:
					form4_0.button_0 = new Button();
					num = (int)(num2 * 1407908096) ^ -1027878506;
					continue;
				case 50u:
					form4_0.dataGridViewTextBoxColumn_2.HeaderText = "Module Size";
					num = (int)(num2 * 1672614920) ^ -1298649630;
					continue;
				case 49u:
					form4_0.button_1.Size = new Size(97, 22);
					form4_0.button_1.TabIndex = 14;
					form4_0.button_1.Text = "Unload Module";
					num = (int)((num2 * 1071731497) ^ 0x51E9761E);
					continue;
				case 48u:
					form4_0.Controls.Add(form4_0.button_2);
					num = ((int)num2 * -704493046) ^ -1660156403;
					continue;
				case 47u:
					form4_0.button_3.UseVisualStyleBackColor = true;
					num = (int)(num2 * 677183425) ^ -971028231;
					continue;
				case 46u:
					form4_0.button_0.TabIndex = 13;
					form4_0.button_0.Text = "Kill Process";
					num = ((int)num2 * -1896737684) ^ -702008778;
					continue;
				case 45u:
					form4_0.tabPage_1.Text = "Threads";
					form4_0.tabPage_1.UseVisualStyleBackColor = true;
					num = (int)(num2 * 1425762367) ^ -422594718;
					continue;
				case 44u:
					form4_0.dataGridView_0.BackgroundColor = Color.White;
					num = ((int)num2 * -784030222) ^ 0x3BB1010F;
					continue;
				case 43u:
					form4_0.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					form4_0.dataGridViewTextBoxColumn_4.HeaderText = "Start Address";
					num = ((int)num2 * -391774442) ^ -214321483;
					continue;
				case 42u:
					((ISupportInitialize)form4_0.pictureBox_0).BeginInit();
					num = (int)(num2 * 306477978) ^ -921963825;
					continue;
				case 41u:
					form4_0.button_4.Size = new Size(97, 22);
					num = ((int)num2 * -1678307562) ^ -2037180615;
					continue;
				case 40u:
					form4_0.Name = "ProcessInfoForm";
					num = (int)(num2 * 2021781618) ^ -942642779;
					continue;
				case 39u:
					form4_0.label_0 = new System.Windows.Forms.Label();
					form4_0.pictureBox_0 = new PictureBox();
					form4_0.timer_0 = new System.Windows.Forms.Timer(form4_0.icontainer_0);
					num = ((int)num2 * -443293442) ^ -1815871773;
					continue;
				case 38u:
					form4_0.button_3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					num = (int)((num2 * 425949892) ^ 0x46FC13EE);
					continue;
				case 37u:
					((ISupportInitialize)form4_0.dataGridView_0).EndInit();
					num = (int)(num2 * 658783111) ^ -691368026;
					continue;
				case 36u:
					form4_0.button_4.Location = new Point(176, 215);
					num = ((int)num2 * -180340077) ^ 0x5B988496;
					continue;
				case 35u:
					form4_0.dataGridView_1.RowHeadersVisible = false;
					num = (int)(num2 * 1560831611) ^ -1030759883;
					continue;
				case 34u:
					form4_0.label_0.Text = "Process Name";
					num = ((int)num2 * -279299136) ^ 0x1365B4B7;
					continue;
				case 33u:
					form4_0.button_1.Enabled = false;
					num = (int)(num2 * 1612143251) ^ -1018879073;
					continue;
				case 32u:
					componentResourceManager = new ComponentResourceManager(typeof(ProcessInspectorForm));
					num = ((int)num2 * -1936636729) ^ -1851659438;
					continue;
				case 31u:
					form4_0.tabPage_1 = new TabPage();
					num = (int)(num2 * 646911602) ^ -12611303;
					continue;
				case 30u:
					form4_0.dataGridView_1.Location = new Point(0, 0);
					num = (int)(num2 * 1053164096) ^ -928959558;
					continue;
				case 29u:
					form4_0.button_4.Text = "Kill";
					form4_0.button_4.UseVisualStyleBackColor = true;
					form4_0.button_4.Click += form4_0.method_12;
					num = (int)(num2 * 1326306197) ^ -2098700400;
					continue;
				case 28u:
					form4_0.dataGridViewTextBoxColumn_5.ReadOnly = true;
					num = (int)((num2 * 2103636455) ^ 0x4FBE1031);
					continue;
				case 27u:
					form4_0.button_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					form4_0.button_0.Location = new Point(199, 442);
					form4_0.button_0.Name = "killButton";
					form4_0.button_0.Size = new Size(97, 22);
					num = ((int)num2 * -582996159) ^ -1625269320;
					continue;
				case 26u:
					form4_0.button_3.Size = new Size(97, 22);
					num = (int)(num2 * 1400608749) ^ -1236526714;
					continue;
				case 25u:
					form4_0.button_3 = new Button();
					form4_0.button_4 = new Button();
					((ISupportInitialize)form4_0.dataGridView_0).BeginInit();
					num = ((int)num2 * -1143745786) ^ 0x568BEE15;
					continue;
				case 24u:
					form4_0.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
					form4_0.groupBox_0 = new GroupBox();
					num = (int)(num2 * 1644058102) ^ -726715906;
					continue;
				case 23u:
					form4_0.tabPage_1.Location = new Point(4, 22);
					form4_0.tabPage_1.Name = "threadsTabPage";
					num = ((int)num2 * -296412965) ^ 0x19EDBF27;
					continue;
				case 22u:
					form4_0.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					form4_0.dataGridView_0.Columns.AddRange(form4_0.dataGridViewTextBoxColumn_0, form4_0.dataGridViewTextBoxColumn_1, form4_0.dataGridViewTextBoxColumn_2);
					num = ((int)num2 * -320111316) ^ -757753653;
					continue;
				case 21u:
					form4_0.button_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					num = ((int)num2 * -2038913893) ^ -324222483;
					continue;
				case 20u:
					form4_0.dataGridView_1.BackgroundColor = Color.White;
					form4_0.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					form4_0.dataGridView_1.Columns.AddRange(form4_0.dataGridViewTextBoxColumn_3, form4_0.dataGridViewTextBoxColumn_4, form4_0.dataGridViewTextBoxColumn_5);
					num = (int)(num2 * 95765469) ^ -1558921475;
					continue;
				case 19u:
					form4_0.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					form4_0.dataGridView_1.Size = new Size(379, 209);
					form4_0.dataGridView_1.TabIndex = 12;
					form4_0.dataGridView_1.SelectionChanged += form4_0.method_10;
					form4_0.dataGridView_1.SortCompare += form4_0.method_7;
					form4_0.dataGridViewTextBoxColumn_3.HeaderText = "Thread ID";
					num = ((int)num2 * -2136049403) ^ -1524411868;
					continue;
				case 18u:
					form4_0.groupBox_0.TabIndex = 10;
					num = (int)(num2 * 1544125282) ^ -1573801816;
					continue;
				case 17u:
					form4_0.tabControl_0.Name = "mainTabControl";
					form4_0.tabControl_0.SelectedIndex = 0;
					num = (int)((num2 * 1052512932) ^ 0x20E9DB51);
					continue;
				case 16u:
					form4_0.dataGridViewTextBoxColumn_0.HeaderText = "Module Name";
					form4_0.dataGridViewTextBoxColumn_0.Name = "moduleNameColumn";
					num = (int)(num2 * 144185050) ^ -511044056;
					continue;
				case 15u:
					form4_0.label_0.TabIndex = 5;
					num = ((int)num2 * -568932589) ^ -1728036158;
					continue;
				case 14u:
					form4_0.AutoScaleDimensions = new SizeF(96f, 96f);
					form4_0.AutoScaleMode = AutoScaleMode.Dpi;
					form4_0.ClientSize = new Size(410, 469);
					form4_0.Controls.Add(form4_0.tabControl_0);
					form4_0.Controls.Add(form4_0.button_0);
					num = (int)((num2 * 195882119) ^ 0x10519D78);
					continue;
				case 13u:
					form4_0.tabControl_0.SuspendLayout();
					form4_0.tabPage_0.SuspendLayout();
					num = ((int)num2 * -1866918174) ^ 0x817EFF8;
					continue;
				case 12u:
					form4_0.groupBox_0.Text = "Process";
					form4_0.label_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
					num = ((int)num2 * -2011165707) ^ -338311936;
					continue;
				case 11u:
					form4_0.button_2.Text = "Close";
					num = ((int)num2 * -940598734) ^ -1436476336;
					continue;
				case 10u:
					form4_0.FormBorderStyle = FormBorderStyle.SizableToolWindow;
					form4_0.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = ((int)num2 * -1346165877) ^ 0x6F04C688;
					continue;
				case 9u:
					form4_0.button_4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					form4_0.button_4.Enabled = false;
					num = ((int)num2 * -453855962) ^ -2054557291;
					continue;
				case 8u:
					form4_0.button_4.TabIndex = 16;
					num = ((int)num2 * -966712865) ^ 0x282A72F8;
					continue;
				case 7u:
					form4_0.dataGridView_0.MultiSelect = false;
					num = (int)((num2 * 2027399700) ^ 0x36FFFB7);
					continue;
				case 6u:
					form4_0.button_2.UseVisualStyleBackColor = true;
					form4_0.button_2.Click += form4_0.method_3;
					form4_0.tabControl_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					form4_0.tabControl_0.Controls.Add(form4_0.tabPage_0);
					form4_0.tabControl_0.Controls.Add(form4_0.tabPage_1);
					form4_0.tabControl_0.Location = new Point(12, 172);
					num = ((int)num2 * -1287982852) ^ -1804477627;
					continue;
				case 5u:
					form4_0.dataGridView_0 = new DataGridView();
					form4_0.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
					form4_0.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
					num = ((int)num2 * -1785432504) ^ -746671375;
					continue;
				case 4u:
					form4_0.groupBox_0.Location = new Point(12, 12);
					num = (int)((num2 * 830681275) ^ 0x5BE229F0);
					continue;
				case 3u:
					form4_0.button_4.Name = "killThreadButton";
					num = ((int)num2 * -90509380) ^ -1015389013;
					continue;
				case 2u:
					form4_0.tabPage_0.ResumeLayout(performLayout: false);
					num = (int)((num2 * 2037820977) ^ 0x579FF33);
					continue;
				case 1u:
					form4_0.button_2 = new Button();
					num = (int)((num2 * 1492214568) ^ 0x6B4DBFAC);
					continue;
				case 0u:
					form4_0.Font = new Font("Segoe UI", 8.25f);
					num = (int)((num2 * 648637052) ^ 0x6678435D);
					continue;
				case 64u:
					break;
				default:
					form4_0.ResumeLayout(performLayout: false);
					return;
				}
				break;
			}
		}
	}

	internal static long smethod_407(Stream0 stream0_0, IntPtr intptr_0)
	{
		long num = 0L;
		IntPtr intptr_1 = default(IntPtr);
		Class124.Struct47 struct47_ = default(Class124.Struct47);
		while (true)
		{
			int num2 = 1543152558;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x5A64279)) % 9)
				{
				case 8u:
					intptr_1 = intptr_0;
					num2 = (int)((num3 * 1838851553) ^ 0x522BBBD1);
					continue;
				case 6u:
					num2 = (((struct47_.enum34_1 & Class124.Enum34.flag_1) == 0) ? 2139404433 : 602391557) ^ ((int)num3 * -761333466);
					continue;
				case 5u:
					num2 = (((struct47_.enum34_1 & Class124.Enum34.flag_6) != 0) ? (-1068121381) : (-1208183802)) ^ ((int)num3 * -360828908);
					continue;
				case 4u:
					num2 = (((struct47_.enum34_1 & Class124.Enum34.flag_5) == 0) ? 956824082 : 1639299719);
					continue;
				case 3u:
					num += struct47_.intptr_2.ToInt64();
					intptr_1 = struct47_.intptr_0.smethod_10(struct47_.intptr_2);
					num2 = 1638116134;
					continue;
				case 1u:
					num2 = ((Class124.VirtualQueryEx(stream0_0.intptr_0, intptr_1, out struct47_, (uint)Class124.int_0) == 0) ? 2108600720 : 1037485587);
					continue;
				case 0u:
					num2 = (((struct47_.enum34_1 & Class124.Enum34.flag_2) == 0) ? (-1441023172) : (-396243303)) ^ (int)(num3 * 1725450826);
					continue;
				case 2u:
					break;
				default:
					return num;
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
	internal static extern IntPtr GetCurrentProcess_1();

	internal static void smethod_408()
	{
		if (!smethod_193(out var string_))
		{
			goto IL_0009;
		}
		goto IL_002d;
		IL_0009:
		int num = -1388352169;
		goto IL_000e;
		IL_000e:
		switch ((uint)(num ^ -2075905034) % 4u)
		{
		case 2u:
			break;
		default:
			return;
		case 3u:
			goto IL_002d;
		case 0u:
			return;
		case 1u:
			return;
		}
		goto IL_0009;
		IL_002d:
		MessageBox.Show("A new version of Extreme Injector has been detected (v" + string_ + ").\n\nTo obtain the latest version either visit the place where you downloaded the injector or head over to Github:\n\nhttps://github.com/master131/ExtremeInjector", "Extreme Injector v3", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		num = -1339150522;
		goto IL_000e;
	}

	internal static bool smethod_409(Class119 class119_0)
	{
		if (smethod_379(class119_0.gclass2_0))
		{
			goto IL_0054;
		}
		goto IL_020b;
		IL_0054:
		int num = -534106453;
		goto IL_019d;
		IL_019d:
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		Class124.Struct45 struct45_ = default(Class124.Struct45);
		IntPtr intptr_ = default(IntPtr);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1450601091)) % 19)
			{
			case 18u:
				num = ((intPtr == IntPtr.Zero) ? 2135096789 : 895207490) ^ (int)(num2 * 198239614);
				continue;
			case 16u:
				break;
			case 14u:
				CloseHandle(intPtr2);
				num = (int)(num2 * 1273488161) ^ -877692768;
				continue;
			case 13u:
				goto IL_0078;
			case 12u:
				intPtr2 = OpenProcess(Class124.Enum32.flag_4 | Class124.Enum32.flag_9, bool_0: false, class119_0.gclass2_0.method_0());
				num = ((!(intPtr2 == IntPtr.Zero)) ? (-1507649381) : (-990940690)) ^ (int)(num2 * 257908533);
				continue;
			case 11u:
				CloseHandle(intPtr);
				num = (int)(num2 * 332830065) ^ -162665467;
				continue;
			case 8u:
				CloseHandle(intPtr2);
				num = ((int)num2 * -22350589) ^ -325300029;
				continue;
			case 7u:
				smethod_86(class119_0, struct45_.intptr_1);
				num = -962768521;
				continue;
			case 5u:
				goto IL_0135;
			case 4u:
				smethod_86(class119_0, intptr_);
				num = -705260852;
				continue;
			case 3u:
				intPtr = OpenProcess(Class124.Enum32.flag_4 | Class124.Enum32.flag_9, bool_0: false, class119_0.gclass2_0.method_0());
				num = (int)(num2 * 1294523756) ^ -1554815762;
				continue;
			case 17u:
				goto IL_020b;
			default:
				return false;
			case 1u:
				return false;
			case 2u:
				return false;
			case 6u:
				return false;
			case 9u:
				return false;
			case 10u:
				CloseHandle(intPtr);
				return true;
			case 15u:
				return true;
			}
			break;
			IL_0135:
			num = ((NtQueryInformationProcess(intPtr, Class124.Enum26.const_4, out struct45_, typeof(Class124.Struct45).smethod_7(), out var _) == 0) ? (-1766581978) : (-431562695));
			continue;
			IL_0078:
			num = ((NtQueryInformationProcess_1(intPtr2, Class124.Enum26.const_24, out intptr_, IntPtr.Size, out var _) != 0) ? (-1623485353) : (-141542084));
		}
		goto IL_0054;
		IL_020b:
		num = ((!smethod_427(class119_0.gclass2_0)) ? (-1356599508) : (-846150103));
		goto IL_019d;
	}

	internal static bool smethod_410(bool bool_0, ulong ulong_0, Class92 class92_0, IntPtr intptr_0)
	{
		GClass1 gClass = smethod_42(class92_0.method_19())["ntdll.dll"];
		Class63 class63_ = default(Class63);
		Class53 @class = default(Class53);
		Class63 class63_3 = default(Class63);
		Class59 class59_ = default(Class59);
		Class57 class57_ = default(Class57);
		uint num5 = default(uint);
		int num3 = default(int);
		Class92.Struct71 gparam_ = default(Class92.Struct71);
		long num4 = default(long);
		IntPtr intPtr = default(IntPtr);
		Class58 class58_4 = default(Class58);
		IntPtr intPtr2 = default(IntPtr);
		Class63 class63_2 = default(Class63);
		Class47 class2 = default(Class47);
		Class58 class58_3 = default(Class58);
		Class58 class58_ = default(Class58);
		Class58 class58_2 = default(Class58);
		while (true)
		{
			int num = 2124793361;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x789016F9)) % 71)
				{
				case 70u:
					smethod_205(class63_, @class, class63_3);
					num = ((int)num2 * -202104059) ^ -2085167891;
					continue;
				case 69u:
					class59_ = smethod_395(0L, Class49.class63_53);
					class57_ = smethod_374(3765269347u);
					smethod_110(class57_, class59_, @class);
					num = ((int)num2 * -786739640) ^ -504654311;
					continue;
				case 67u:
					num5 = BitConverter.ToUInt32(class92_0.byte_0, num3);
					num = ((num5 == 3735935610u) ? 827292592 : 764475565);
					continue;
				case 66u:
					num = ((num3 >= class92_0.byte_0.Length - 4) ? 520534705 : 210201124);
					continue;
				case 65u:
					num = ((int)num2 * -1497846063) ^ 0x737E5F75;
					continue;
				case 64u:
					gparam_ = class92_0.method_11<Class92.Struct71>(class92_0.intptr_1);
					num4 = gparam_.intptr_0.ToInt64();
					num = 738694385;
					continue;
				case 63u:
					class63_3 = Class49.class63_55;
					num = ((int)num2 * -1003963183) ^ -1959147897;
					continue;
				case 62u:
					intPtr = smethod_285(class92_0.method_19()).method_28();
					BitConverter.GetBytes(intPtr.ToInt32()).CopyTo(class92_0.byte_0, num3);
					num = (int)((num2 * 1389643800) ^ 0x1CAC63F3);
					continue;
				case 61u:
					smethod_332(Enum12.const_0, @class, class58_4);
					class59_ = smethod_238(Class49.class63_53, 32L);
					num = ((int)num2 * -1692758582) ^ -687735026;
					continue;
				case 60u:
					gparam_.struct70_0[num4].intptr_0 = intptr_0;
					num = (int)((num2 * 1403587108) ^ 0x50B32679);
					continue;
				case 59u:
					smethod_332(Enum12.const_0, @class, class58_4);
					num = ((int)num2 * -1149696274) ^ -975212268;
					continue;
				case 58u:
					smethod_332(Enum12.const_0, @class, class58_4);
					num = ((int)num2 * -564449262) ^ -2084703681;
					continue;
				case 57u:
					BitConverter.GetBytes(intPtr.ToInt32()).CopyTo(class92_0.byte_0, num3);
					num = ((int)num2 * -834342897) ^ 0x4B273AA7;
					continue;
				case 56u:
					intPtr2 = smethod_225(gClass, "RtlDecodeSystemPointer", bool_0: false);
					num = 24344764;
					continue;
				case 55u:
					num = ((!(class92_0.intptr_1 == IntPtr.Zero)) ? 2033965669 : 1041281663) ^ ((int)num2 * -553800921);
					continue;
				case 54u:
					num = ((num5 != 3735929054u) ? 1095077730 : 30532957);
					continue;
				case 53u:
				{
					Class59 class59_3 = smethod_238(Class49.class63_62, IntPtr.Size);
					smethod_169(class59_3, class63_2, @class);
					num = ((int)num2 * -1194536231) ^ -2142556560;
					continue;
				}
				case 52u:
					smethod_164(@class, Class49.class63_63, Class49.class63_63);
					num = (int)((num2 * 1512829021) ^ 0x152DF6D);
					continue;
				case 51u:
					num = (int)((num2 * 509529213) ^ 0x669B32E3);
					continue;
				case 50u:
					smethod_429(@class, Class49.class63_55, smethod_238(Class49.class63_62, 0L));
					num = (int)((num2 * 1966281933) ^ 0x78F5FBEF);
					continue;
				case 49u:
					class2.method_4<IntPtr>();
					smethod_226(class2, -1);
					num = ((int)num2 * -84778706) ^ -40418380;
					continue;
				case 48u:
				{
					Class59 class59_2 = smethod_238(Class49.class63_53, 32L);
					Class57 class57_2 = smethod_374(429065504u);
					smethod_127(class57_2, class59_2, @class);
					num = (int)(num2 * 1036423967) ^ -1911781498;
					continue;
				}
				case 47u:
					class92_0.intptr_2 = smethod_175(class92_0, class92_0.byte_0.Length, Class124.Enum34.flag_2);
					num = ((!(class92_0.intptr_2 == IntPtr.Zero)) ? 1724333493 : 569166740);
					continue;
				case 46u:
					smethod_306(@class, Class49.class63_62, new Class57(class92_0.intptr_1));
					smethod_429(@class, Class49.class63_55, smethod_238(Class49.class63_62, 0L));
					num = (int)((num2 * 2141000902) ^ 0x6B3752D);
					continue;
				case 44u:
					smethod_205(class63_, @class, class63_3);
					num = (int)(num2 * 1293983261) ^ -1744408913;
					continue;
				case 43u:
					class59_ = smethod_238(Class49.class63_53, 56L);
					num = (int)((num2 * 1473774393) ^ 0x41756877);
					continue;
				case 42u:
					class57_ = smethod_374(26820608u);
					num = ((int)num2 * -1132276667) ^ 0x3C9DAFC0;
					continue;
				case 40u:
					gparam_.intptr_0 = gparam_.intptr_0.smethod_8(1);
					num = ((int)num2 * -1932217139) ^ 0x6873C295;
					continue;
				case 39u:
					smethod_75(@class, smethod_238(Class49.class63_53, 56L), Class49.class63_55);
					num = (int)((num2 * 1586931031) ^ 0x12CABA15);
					continue;
				case 38u:
					smethod_363(@class, Class49.class63_62, smethod_167(IntPtr.Size));
					num = ((int)num2 * -721373078) ^ 0x512CFDA9;
					continue;
				case 37u:
					class2 = new Class47(@class, class92_0.method_19());
					smethod_15(class2);
					smethod_54(class2, new Class57(smethod_225(gClass, "RtlAddVectoredExceptionHandler", bool_0: false)), CallingConvention.StdCall, new object[2] { 0, class92_0.intptr_2 });
					num = 2129636980;
					continue;
				case 36u:
					class92_0.method_13(class92_0.intptr_1, gparam_);
					class58_4 = smethod_48(@class);
					class58_3 = smethod_48(@class);
					num = (int)(num2 * 46063604) ^ -97241406;
					continue;
				case 35u:
					num3++;
					num = 315035395;
					continue;
				case 34u:
					smethod_36(@class, class58_4);
					num = (int)(num2 * 1614786777) ^ -389953731;
					continue;
				case 33u:
					smethod_363(@class, Class49.class63_63, smethod_167(1));
					num = ((int)num2 * -2048095374) ^ -1190774931;
					continue;
				case 32u:
					class63_ = Class49.class63_63;
					num = ((int)num2 * -875597638) ^ -1337065233;
					continue;
				case 31u:
					smethod_220(Enum12.const_0, class58_, @class);
					smethod_247(@class, class58_2);
					num = ((int)num2 * -35662981) ^ 0x53695AD9;
					continue;
				case 30u:
					class63_3 = Class49.class63_64;
					num = ((int)num2 * -286126351) ^ 0x736CD622;
					continue;
				case 29u:
					num = ((num5 == 3735929042u) ? 2087398 : 801390875);
					continue;
				case 28u:
					class92_0.intptr_2 = smethod_61(@class, class92_0);
					smethod_115(@class);
					num = (int)((num2 * 1690773023) ^ 0x30BA4605);
					continue;
				case 27u:
					num = ((gClass != null) ? 727311944 : 1157901590) ^ ((int)num2 * -1041048921);
					continue;
				case 26u:
					class57_ = smethod_167(0);
					num = ((int)num2 * -1052007470) ^ -1247933243;
					continue;
				case 25u:
					smethod_332(Enum12.const_0, @class, class58_3);
					smethod_247(@class, class58_4);
					smethod_36(@class, class58_2);
					num = (int)((num2 * 1538207082) ^ 0x4C3752B3);
					continue;
				case 24u:
					smethod_36(@class, class58_3);
					smethod_429(@class, Class49.class63_61, smethod_238(Class49.class63_53, 48L));
					smethod_429(@class, Class49.class63_64, smethod_238(Class49.class63_62, 0L));
					num = ((int)num2 * -324398711) ^ 0x4653B182;
					continue;
				case 22u:
					class63_ = Class49.class63_61;
					class63_3 = Class49.class63_64;
					num = (int)((num2 * 34924507) ^ 0x3E941045);
					continue;
				case 21u:
					num = ((!class92_0.method_16(class92_0.intptr_2, class92_0.byte_0)) ? 1238233527 : 888158518);
					continue;
				case 20u:
					smethod_110(class57_, class59_, @class);
					num = (int)((num2 * 1121192180) ^ 0x72EE9328);
					continue;
				case 19u:
					num = (class92_0.method_19().method_6() ? 1520727512 : 401250852) ^ (int)(num2 * 1334665265);
					continue;
				case 18u:
					smethod_164(@class, Class49.class63_53, Class49.class63_53);
					num = ((int)num2 * -855016202) ^ 0x1B499319;
					continue;
				case 16u:
					intPtr = (class92_0.intptr_3 = class92_0.method_21<IntPtr>(class2));
					num = (int)((num2 * 787716627) ^ 0x35B1721F);
					continue;
				case 15u:
					smethod_205(class63_, @class, class63_3);
					num = ((int)num2 * -1760668733) ^ 0x3F833ED0;
					continue;
				case 14u:
					class58_ = smethod_48(@class);
					class58_2 = smethod_48(@class);
					smethod_429(@class, Class49.class63_53, smethod_238(Class49.class63_54, 0L));
					num = (int)((num2 * 951599599) ^ 0xA2B83BD);
					continue;
				case 13u:
					gparam_.struct70_0[num4].intptr_1 = (IntPtr)(long)ulong_0;
					num = ((int)num2 * -693079858) ^ -205896791;
					continue;
				case 12u:
					smethod_110(class57_, class59_, @class);
					num = ((int)num2 * -140789703) ^ -1181042394;
					continue;
				case 11u:
					@class = new Class53();
					num = 1715510004;
					continue;
				case 10u:
					smethod_32(Enum12.const_0, class58_, @class);
					class63_2 = Class49.class63_64;
					num = (int)(num2 * 640230484) ^ -2073980872;
					continue;
				case 9u:
					smethod_36(@class, class58_);
					smethod_363(@class, Class49.class63_62, smethod_167(typeof(Class92.Struct70).smethod_7()));
					num = (int)((num2 * 890256792) ^ 0x55306306);
					continue;
				case 8u:
					class92_0.intptr_1 = smethod_175(class92_0, 4096L, Class124.Enum34.flag_6);
					num = ((!(class92_0.intptr_1 == IntPtr.Zero)) ? 182465141 : 1494122010) ^ (int)(num2 * 1726769930);
					continue;
				case 7u:
					intPtr = smethod_285(class92_0.method_19()).method_26();
					num = (int)(num2 * 1759082266) ^ -424275433;
					continue;
				case 6u:
					smethod_347(@class);
					num = ((int)num2 * -1741308699) ^ 0x4936511C;
					continue;
				case 5u:
					BitConverter.GetBytes(intPtr2.ToInt32()).CopyTo(class92_0.byte_0, num3);
					num = ((int)num2 * -1457549804) ^ -869352863;
					continue;
				case 4u:
					smethod_418(204, @class);
					smethod_418(204, @class);
					smethod_418(204, @class);
					num = ((int)num2 * -1518214786) ^ -1021901746;
					continue;
				case 3u:
					class63_ = Class49.class63_61;
					num = ((int)num2 * -91358633) ^ 0x6605F4A4;
					continue;
				case 2u:
					num3 = 0;
					num = ((int)num2 * -427718184) ^ 0x61591AA1;
					continue;
				case 0u:
					smethod_429(@class, Class49.class63_54, smethod_238(Class49.class63_54, 0L));
					num = (int)(num2 * 1650601673) ^ -415035518;
					continue;
				case 41u:
					break;
				case 17u:
					throw new AccessViolationException("Unable to allocate memory for VEH handler.");
				case 23u:
					throw new AccessViolationException("Unable to allocate memory for the VEH.");
				case 45u:
					throw new FileNotFoundException("Unable to find ntdll.dll in the specified process.");
				case 68u:
					throw new AccessViolationException("Unable to write memory for the VEH.");
				default:
					return intPtr != IntPtr.Zero;
				}
				break;
			}
		}
	}

	internal static void smethod_411(GClass2 gclass2_0)
	{
		IntPtr intPtr = smethod_250(gclass2_0, Class124.Enum32.flag_1, bool_0: false, gclass2_0.method_0());
		while (true)
		{
			int num = 459084344;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3033F39D)) % 6)
				{
				case 4u:
				{
					bool num3 = TerminateProcess(intPtr, -1);
					smethod_27(gclass2_0, intPtr);
					num = ((!num3) ? 470475232 : 1793443999);
					continue;
				}
				case 3u:
					num = ((intPtr == IntPtr.Zero) ? 596482349 : 1114648150) ^ ((int)num2 * -1115381483);
					continue;
				default:
					return;
				case 0u:
					break;
				case 1u:
					throw new Win32Exception("TerminateProcess returned FALSE.");
				case 5u:
					throw new InvalidOperationException("OpenProcess returned NULL.");
				case 2u:
					return;
				}
				break;
			}
		}
	}

	internal static IEnumerable<string> smethod_412(string string_0, IEnumerable<Class164> ienumerable_0, Class148 class148_0)
	{
		return new Class148.Class150(-2)
		{
			string_2 = string_0,
			ienumerable_1 = ienumerable_0
		};
	}

	internal static Class77[] smethod_413()
	{
		Class77.Class78 obj = new Class77.Class78
		{
			list_0 = new List<Class77>()
		};
		EnumWindows(obj.method_0, IntPtr.Zero);
		return obj.list_0.ToArray();
	}

	internal static void smethod_414(Class138 class138_0)
	{
		if (class138_0.long_0 < 0L)
		{
			goto IL_02a6;
		}
		goto IL_05bc;
		IL_02a6:
		int num = -1775434932;
		goto IL_04f6;
		IL_04f6:
		int int_ = default(int);
		int num6 = default(int);
		string text = default(string);
		long num9 = default(long);
		uint num5 = default(uint);
		int num8 = default(int);
		uint num7 = default(uint);
		uint num4 = default(uint);
		uint uint_ = default(uint);
		long num3 = default(long);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1303306011)) % 41)
			{
			case 40u:
				break;
			case 39u:
				class138_0.method_6().Add(new Class138(int_, class138_0.class166_0, num6));
				num = (int)(num2 * 1321182643) ^ -1048202268;
				continue;
			case 38u:
				num = ((int)num2 * -1835096247) ^ -933917880;
				continue;
			case 37u:
				num = ((text != null) ? (-1036189665) : (-1956645628)) ^ (int)(num2 * 557030566);
				continue;
			case 36u:
				num9++;
				num = -151372826;
				continue;
			case 35u:
				goto IL_00d8;
			case 34u:
				int_ = (int)num5;
				num = -338677743;
				continue;
			case 29u:
				num = ((text != null) ? 2145434809 : 48614946) ^ ((int)num2 * -1365308690);
				continue;
			case 28u:
				text = null;
				num = ((int)num2 * -802271296) ^ -911414576;
				continue;
			case 27u:
				num = ((num6 == class138_0.long_0) ? (-1222783056) : (-415526062)) ^ ((int)num2 * -232818203);
				continue;
			case 26u:
				num9 = 0L;
				num = -1622600243;
				continue;
			case 24u:
				num = ((num6 != 0) ? 320528572 : 292799433) ^ (int)(num2 * 40777389);
				continue;
			case 23u:
				num = ((!smethod_176(class138_0.class166_0, num8 * 8)) ? 2028871081 : 1708715661) ^ ((int)num2 * -1328621998);
				continue;
			case 22u:
				num = ((text != null) ? 513541114 : 268636129) ^ ((int)num2 * -1977901315);
				continue;
			case 21u:
			{
				class138_0.method_11(smethod_370(class138_0.class166_0));
				ushort num10 = smethod_370(class138_0.class166_0);
				int num11 = smethod_370(class138_0.class166_0);
				num8 = num10 + num11;
				num = (int)(num2 * 12522394) ^ -1181235280;
				continue;
			}
			case 20u:
				int_ = -1;
				num = (((num5 & 0x80000000u) != 0) ? 417965382 : 1086051584) ^ ((int)num2 * -606048333);
				continue;
			case 19u:
				class138_0.method_6().Add(new Class138(text, class138_0.class166_0, num6));
				num = -1587287256;
				continue;
			case 18u:
				goto end_IL_04f6;
			case 17u:
				num6 = (int)(num7 & 0x7FFFFFFF);
				num = -381106848;
				continue;
			case 16u:
				num5 = smethod_314(class138_0.class166_0);
				num7 = smethod_314(class138_0.class166_0);
				num = (int)(num2 * 586410116) ^ -879507152;
				continue;
			case 15u:
				class138_0.method_4().Add(new Class139(int_, num4, uint_));
				num = (int)((num2 * 702623672) ^ 0x28AB256D);
				continue;
			case 14u:
				num = (int)(num2 * 164921784) ^ -522482136;
				continue;
			case 13u:
				smethod_262(class138_0.class166_0, num3);
				num = -500688815;
				continue;
			case 12u:
				num = ((num4 == 0) ? 2101121866 : 1456711581) ^ ((int)num2 * -193837778);
				continue;
			case 11u:
				num3 += 8L;
				num = (int)((num2 * 1820035801) ^ 0x5FCA5F7C);
				continue;
			case 10u:
				num = ((!smethod_262(class138_0.class166_0, (int)num7)) ? 1594330112 : 1870379850) ^ (int)(num2 * 987591257);
				continue;
			case 9u:
				goto IL_03c1;
			case 8u:
				uint_ = smethod_314(class138_0.class166_0);
				num = (int)(num2 * 1542480390) ^ -1193326078;
				continue;
			case 7u:
				num = ((!smethod_176(class138_0.class166_0, 16)) ? (-1285822201) : (-1006128669)) ^ ((int)num2 * -1946128439);
				continue;
			case 5u:
				text = smethod_90((int)(num5 & 0x7FFFFFFF), class138_0.class166_0);
				num = (int)(num2 * 138576926) ^ -1142511030;
				continue;
			case 3u:
				num4 = smethod_314(class138_0.class166_0);
				num = (int)((num2 * 1651893016) ^ 0x211B5985);
				continue;
			case 2u:
				class138_0.method_8(smethod_314(class138_0.class166_0));
				class138_0.method_9(smethod_314(class138_0.class166_0));
				class138_0.method_10(smethod_370(class138_0.class166_0));
				num = -574411015;
				continue;
			case 1u:
				class138_0.method_4().Add(new Class139(text, num4, uint_));
				num = -1587287256;
				continue;
			case 0u:
				num3 = class138_0.long_0 + 16L;
				num = ((int)num2 * -425286253) ^ 0x8D9910F;
				continue;
			default:
				return;
			case 4u:
				goto IL_05bc;
			case 6u:
				return;
			case 25u:
				return;
			case 30u:
				return;
			case 31u:
				return;
			case 32u:
				return;
			case 33u:
				return;
			}
			num = (smethod_262(class138_0.class166_0, class138_0.long_0) ? (-478104458) : (-709056625));
			continue;
			IL_03c1:
			num = (((num7 & 0x80000000u) != 0) ? (-1159667969) : (-1146342367));
			continue;
			IL_00d8:
			num = ((num9 >= num8) ? (-563606492) : (-1507146908));
			continue;
			end_IL_04f6:
			break;
		}
		goto IL_02a6;
		IL_05bc:
		num = ((!smethod_282(class138_0.class166_0, class138_0.long_0, 16)) ? (-57534421) : (-1434323077));
		goto IL_04f6;
	}

	internal static void smethod_415(GClass4 gclass4_0)
	{
		if (gclass4_0.class154_0.method_18() == null)
		{
			goto IL_0022;
		}
		goto IL_0119;
		IL_0022:
		int num = 896468174;
		goto IL_00d0;
		IL_00d0:
		Class157 @class = default(Class157);
		long long_ = default(long);
		long num3 = default(long);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x34491F95)) % 10)
			{
			case 9u:
				break;
			case 5u:
				@class.method_3(0u);
				num = ((int)num2 * -612143623) ^ 0x15C3A58C;
				continue;
			case 4u:
				smethod_437(gclass4_0, long_, 28L);
				num = (int)(num2 * 207459978) ^ -1819665512;
				continue;
			case 2u:
				smethod_437(gclass4_0, num3, gclass4_0.class154_0.method_18().method_5());
				num = 467334697;
				continue;
			case 1u:
				@class.method_1(0u);
				num = (int)(num2 * 2090806702) ^ -865100096;
				continue;
			case 0u:
				@class = gclass4_0.class154_0.method_6().method_3().imethod_49()[6];
				long_ = smethod_135(gclass4_0.class154_0, @class.method_0());
				num = ((int)num2 * -1841234019) ^ 0x7DC134F9;
				continue;
			default:
				return;
			case 8u:
				goto IL_0119;
			case 3u:
				return;
			case 6u:
				return;
			case 7u:
				return;
			}
			break;
		}
		goto IL_0022;
		IL_0119:
		num3 = smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_18().method_7());
		num = ((num3 == -1L) ? 1506590824 : 1465303589);
		goto IL_00d0;
	}

	internal static Assembly smethod_416(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Class175.Struct79 @struct = new Class175.Struct79(resolveEventArgs_0.Name);
		int num7 = default(int);
		string text4 = default(string);
		string text = default(string);
		string[] array2 = default(string[]);
		int num8 = default(int);
		string s = default(string);
		bool flag2 = default(bool);
		string text5 = default(string);
		bool flag = default(bool);
		int num9 = default(int);
		Stream manifestResourceStream = default(Stream);
		byte[] array = default(byte[]);
		int num6 = default(int);
		Assembly result = default(Assembly);
		Assembly assembly = default(Assembly);
		FileStream fileStream = default(FileStream);
		string text3 = default(string);
		while (true)
		{
			int num = 812011942;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2DD9A8FD)) % 27)
				{
				case 26u:
					num7 += 2;
					num = 530572277;
					continue;
				case 25u:
					text4 = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
					num = (int)(num2 * 1971677574) ^ -1429245879;
					continue;
				case 24u:
					num = ((text[0] == '[') ? 1389351401 : 1936620581) ^ (int)(num2 * 987582273);
					continue;
				case 23u:
					num = ((@struct.string_2.Length == 0) ? 1772562629 : 1209782707) ^ ((int)num2 * -95308379);
					continue;
				case 22u:
					text = string.Empty;
					num = ((int)num2 * -1768387966) ^ 0x39BCB9C;
					continue;
				case 21u:
					text = array2[num7 + 1];
					num = (int)(num2 * 1571688399) ^ -1157796802;
					continue;
				case 19u:
					num8 += 2;
					num = 1365903366;
					continue;
				case 18u:
					num = ((num8 < array2.Length - 1) ? 1447718318 : 211558817);
					continue;
				case 17u:
					num7 = 0;
					num = ((int)num2 * -1489229283) ^ 0x415C485B;
					continue;
				case 16u:
					num = ((array2[num8] == text4) ? 2085962477 : 1165782514);
					continue;
				case 15u:
					text = array2[num8 + 1];
					num = (int)(num2 * 190746212) ^ -1436782623;
					continue;
				case 14u:
					s = @struct.method_0(bool_0: false);
					num = ((int)num2 * -346725818) ^ -871203457;
					continue;
				case 13u:
					num = ((text.Length == 0) ? 1063532562 : 358462648);
					continue;
				case 12u:
					flag2 = text5.IndexOf('z') >= 0;
					flag = text5.IndexOf('t') >= 0;
					num = ((int)num2 * -1623992077) ^ -848207185;
					continue;
				case 11u:
					text = text.Substring(num9 + 1);
					num = (int)((num2 * 289346854) ^ 0x63A57FDC);
					continue;
				case 10u:
					text5 = text.Substring(1, num9 - 1);
					num = (int)(num2 * 930559122) ^ -712651008;
					continue;
				case 9u:
					num = ((!(array2[num7] == text4)) ? 19100308 : 406912009);
					continue;
				case 8u:
					text4 = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
					array2 = global::_003CModule_003E.smethod_4<string>(3764124672u).Split(',');
					num = (int)(num2 * 945464666) ^ -1167070682;
					continue;
				case 7u:
					num9 = text.IndexOf(']');
					num = ((int)num2 * -39050749) ^ -1695334576;
					continue;
				case 6u:
					num8 = 0;
					num = (int)(num2 * 284860470) ^ -1312668440;
					continue;
				case 5u:
					flag = false;
					num = (int)((num2 * 774388279) ^ 0xCE7683A);
					continue;
				case 4u:
					flag2 = false;
					num = ((int)num2 * -1635751668) ^ -18520425;
					continue;
				case 3u:
					num = ((int)num2 * -1560094189) ^ -802373851;
					continue;
				case 2u:
					num = ((num7 >= array2.Length - 1) ? 358462648 : 1984745642);
					continue;
				case 0u:
					if (text.Length > 0)
					{
						num = 1466622218;
						continue;
					}
					goto IL_06d8;
				case 20u:
					break;
				default:
					{
						lock (Class175.dictionary_0)
						{
							if (Class175.dictionary_0.ContainsKey(text))
							{
								goto IL_04a7;
							}
							goto IL_04f9;
							IL_04a7:
							int num3 = 1254998384;
							goto IL_04b6;
							IL_04b6:
							while (true)
							{
								switch ((num2 = (uint)(num3 ^ 0x2DD9A8FD)) % 12)
								{
								case 10u:
									manifestResourceStream.Read(array, 0, num6);
									num3 = ((int)num2 * -1709115074) ^ 0x302FF6C6;
									continue;
								case 9u:
									result = Class175.dictionary_0[text];
									num3 = ((int)num2 * -1764865418) ^ -1678027237;
									continue;
								case 8u:
									if (manifestResourceStream != null)
									{
										num3 = (int)((num2 * 2006650459) ^ 0x4C242C45);
										continue;
									}
									goto IL_06d8;
								case 7u:
									num3 = (flag2 ? (-920223481) : (-887206232)) ^ ((int)num2 * -2041499244);
									continue;
								case 6u:
									array = smethod_394(array);
									num3 = (int)((num2 * 1106511958) ^ 0x1B781460);
									continue;
								case 5u:
									array = new byte[num6];
									num3 = (int)(num2 * 1763792491) ^ -2089956532;
									continue;
								case 4u:
									num6 = (int)manifestResourceStream.Length;
									num3 = ((int)num2 * -820829470) ^ -800848424;
									continue;
								case 2u:
									break;
								case 1u:
									assembly = null;
									num3 = 1876622558;
									continue;
								case 3u:
									goto IL_04f9;
								case 0u:
									goto end_IL_03c4;
								default:
									if (!flag)
									{
										try
										{
											assembly = Assembly.Load(array);
										}
										catch (FileLoadException)
										{
											flag = true;
										}
										catch (BadImageFormatException)
										{
											flag = true;
										}
									}
									if (flag)
									{
										try
										{
											string text2 = string.Format(global::_003CModule_003E.smethod_3<string>(875068114u), Path.GetTempPath(), text);
											Directory.CreateDirectory(text2);
											while (true)
											{
												IL_066c:
												int num4 = 455211782;
												while (true)
												{
													switch ((num2 = (uint)(num4 ^ 0x2DD9A8FD)) % 9)
													{
													case 8u:
														fileStream.Close();
														num4 = ((int)num2 * -573369790) ^ 0x6D910DEB;
														continue;
													case 6u:
														text3 = text2 + @struct.string_0 + global::_003CModule_003E.smethod_3<string>(4162067015u);
														num4 = (int)((num2 * 1396931732) ^ 0x36326015);
														continue;
													case 5u:
														fileStream.Write(array, 0, array.Length);
														num4 = (int)(num2 * 792578640) ^ -1942777925;
														continue;
													case 3u:
														MoveFileEx(text3, null, 4);
														num4 = ((int)num2 * -534819216) ^ 0x21032C33;
														continue;
													case 2u:
														num4 = (File.Exists(text3) ? 1208519532 : 915147999) ^ ((int)num2 * -959005789);
														continue;
													case 1u:
														fileStream = File.OpenWrite(text3);
														num4 = ((int)num2 * -1118448617) ^ -1630672646;
														continue;
													case 0u:
														MoveFileEx(text2, null, 4);
														num4 = ((int)num2 * -1120152272) ^ -313610352;
														continue;
													case 7u:
														break;
													default:
														assembly = Assembly.LoadFile(text3);
														goto end_IL_0635;
													}
													goto IL_066c;
													continue;
													end_IL_0635:
													break;
												}
												break;
											}
										}
										catch
										{
										}
									}
									Class175.dictionary_0[text] = assembly;
									while (true)
									{
										IL_06c5:
										int num5 = 1462678052;
										while (true)
										{
											switch ((num2 = (uint)(num5 ^ 0x2DD9A8FD)) % 4)
											{
											case 1u:
												goto IL_0691;
											case 2u:
												break;
											case 3u:
												goto end_IL_06a3;
											default:
												goto IL_06d8;
											}
											goto IL_06c5;
											IL_0691:
											result = assembly;
											num5 = (int)((num2 * 528150215) ^ 0x2685A5E1);
											continue;
											end_IL_06a3:
											break;
										}
										break;
									}
									goto end_IL_03c4;
								}
								break;
							}
							goto IL_04a7;
							IL_04f9:
							manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
							num3 = 1404862989;
							goto IL_04b6;
							end_IL_03c4:;
						}
						return result;
					}
					IL_06d8:
					return null;
				}
				break;
			}
		}
	}

	internal static Class59 smethod_417(Class63 class63_0, long long_0, Class47 class47_0)
	{
		if (class47_0.bool_0)
		{
			class47_0.class53_0.struct19_0.uint_2 |= 8u;
			return smethod_395(long_0, class63_0);
		}
		return smethod_238(class63_0, long_0);
	}

	internal static void smethod_418(byte byte_0, Class53 class53_0)
	{
		smethod_308(1L, byte_0, class53_0);
	}

	internal static int smethod_419(byte[] byte_0, string string_0, string string_1, int int_0)
	{
		if (int_0 < byte_0.Length)
		{
			while (true)
			{
				int num = -1634227725;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -682606134)) % 8)
					{
					case 6u:
						break;
					case 4u:
						num = ((string_0.Length >= 4) ? (-1746713829) : (-516347775)) ^ (int)(num2 * 669219861);
						continue;
					case 3u:
						num = ((int_0 + string_0.Length <= byte_0.Length) ? 1389075937 : 839933303) ^ ((int)num2 * -657585009);
						continue;
					case 1u:
						num = ((string_0.Length != string_1.Length) ? 621275278 : 1065365533) ^ (int)(num2 * 1137282492);
						continue;
					case 2u:
						goto end_IL_00b7;
					case 5u:
						return smethod_17(int_0, string_0, string_1, byte_0);
					default:
						return smethod_35(byte_0, string_0, string_1, int_0);
					case 0u:
						goto end_IL_00e8;
					}
					num = ((byte_0.Length - int_0 >= 4) ? (-2049305042) : (-1842442955));
					continue;
					end_IL_00b7:
					break;
				}
				continue;
				end_IL_00e8:
				break;
			}
		}
		return -1;
	}

	internal static void smethod_420(List<GClass4.Class132> list_0, GClass4 gclass4_0)
	{
		Interface2 @interface = gclass4_0.class154_0.method_6().method_3();
		GClass4.Class132 class2 = default(GClass4.Class132);
		int num4 = default(int);
		BinaryWriter binaryWriter = default(BinaryWriter);
		byte[] buffer2 = default(byte[]);
		Class157 @class = default(Class157);
		Class154 class154_ = default(Class154);
		long long_2 = default(long);
		byte[] buffer = default(byte[]);
		Class157[] array = default(Class157[]);
		int num3 = default(int);
		GClass4.Class132 class3 = default(GClass4.Class132);
		while (true)
		{
			int num = -1980561080;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -774756408)) % 30)
				{
				case 29u:
					class2 = list_0[num4];
					num = ((class2.method_5().method_6() != 0) ? (-1843705321) : (-1038856157));
					continue;
				case 28u:
					num = ((@interface.imethod_11() == 0) ? (-1839953667) : (-1237628823));
					continue;
				case 27u:
					binaryWriter.Write(buffer2);
					num = (int)((num2 * 816257153) ^ 0x61C5CCC0);
					continue;
				case 26u:
					num = ((@class.method_0() == 0) ? (-1400829966) : (-1558057830)) ^ (int)(num2 * 2021526257);
					continue;
				case 25u:
					binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
					num4 = list_0.Count - 1;
					num = (int)(num2 * 1958191617) ^ -909672725;
					continue;
				case 23u:
					@interface.imethod_12(smethod_33(list_0, @interface.imethod_11()));
					num = ((int)num2 * -1592269532) ^ 0x24713F59;
					continue;
				case 22u:
				{
					long long_ = class2.method_5().method_6();
					buffer2 = smethod_8(long_, class154_, long_2);
					gclass4_0.class154_0.method_28().Position = class2.method_5().method_8();
					buffer = new byte[class2.method_5().method_6()];
					num = ((int)num2 * -493662001) ^ -441296928;
					continue;
				}
				case 21u:
					@class = array[num3];
					num = -925901808;
					continue;
				case 20u:
					@interface.imethod_16(smethod_33(list_0, @interface.imethod_15()));
					num = (int)(num2 * 1167791939) ^ -1338095310;
					continue;
				case 19u:
					binaryWriter.Write(buffer);
					num = (int)(num2 * 519586440) ^ -689152113;
					continue;
				case 18u:
					num = ((int)num2 * -496881695) ^ -894225868;
					continue;
				case 16u:
					array = @interface.imethod_49();
					num3 = 0;
					num = ((int)num2 * -139698581) ^ -632302168;
					continue;
				case 15u:
					class154_ = gclass4_0.class154_0;
					num = ((int)num2 * -1147650423) ^ -1458182813;
					continue;
				case 14u:
					long_2 = class2.method_5().method_8();
					num = (int)(num2 * 150433868) ^ -602061966;
					continue;
				case 13u:
				{
					uint uint_ = class3.method_3().method_4() + class3.method_3().method_2();
					uint uint_2 = @interface.imethod_18();
					@interface.imethod_30(smethod_201(uint_2, uint_));
					num = ((int)num2 * -857950790) ^ 0x3145DB76;
					continue;
				}
				case 12u:
					gclass4_0.random_0.NextBytes(buffer);
					num = ((int)num2 * -1806807504) ^ 0x892CF57;
					continue;
				case 11u:
					num = ((@interface.imethod_15() == 0) ? (-899804182) : (-851191936));
					continue;
				case 10u:
					num = ((@interface.imethod_13() != 0) ? (-496216951) : (-565610941)) ^ (int)(num2 * 1980255938);
					continue;
				case 9u:
					class3 = list_0.Last();
					num = -997280841;
					continue;
				case 8u:
					@class.method_1(smethod_33(list_0, @class.method_0()));
					num = ((int)num2 * -682934549) ^ -1053842044;
					continue;
				case 7u:
					@interface.imethod_14(smethod_33(list_0, @interface.imethod_13()));
					num = (int)(num2 * 1260050670) ^ -30092499;
					continue;
				case 6u:
					num = (int)(num2 * 1581547319) ^ -1417852195;
					continue;
				case 5u:
					gclass4_0.class154_0.method_28().Position = class2.method_3().method_8() + class2.method_0();
					num = ((int)num2 * -241555325) ^ -262827626;
					continue;
				case 4u:
					gclass4_0.class154_0.method_28().SetLength(class3.method_3().method_8() + class3.method_3().method_6());
					num = ((int)num2 * -36291185) ^ -1042720319;
					continue;
				case 3u:
					num = ((num4 < 0) ? (-1707549190) : (-1507950011));
					continue;
				case 2u:
					num = ((num3 >= array.Length) ? (-1225408072) : (-821638215));
					continue;
				case 1u:
					num4--;
					num = -1164100053;
					continue;
				case 0u:
					num3++;
					num = -812829700;
					continue;
				case 17u:
					break;
				default:
					gclass4_0.class154_0.method_9(list_0.Select(GClass4.Class135._003C_003E9.method_1).ToList());
					return;
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	internal unsafe static extern bool ReadProcessMemory_1(IntPtr intptr_0, IntPtr intptr_1, byte* pByte_0, UIntPtr uintptr_0, UIntPtr* pUintPtr_0);

	internal static void smethod_421(SettingsForm gform2_0)
	{
		ScramblePreset @enum = ApplicationSettings.Current.Options.Scramble.Detect();
		while (true)
		{
			int num = 1333184472;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xB247207)) % 9)
				{
				case 6u:
					num = ((@enum == ScramblePreset.Custom) ? 1483050419 : 371770663);
					continue;
				case 5u:
					num = ((@enum == ScramblePreset.None) ? (-695007426) : (-1407516889)) ^ (int)(num2 * 1622403653);
					continue;
				case 4u:
					gform2_0.comboBox_1.SelectedIndex = (int)(@enum - 1);
					num = 2003090427;
					continue;
				case 1u:
					gform2_0.comboBox_1.SelectedIndex = gform2_0.comboBox_1.Items.Count - 1;
					num = ((int)num2 * -1136136869) ^ -1030355687;
					continue;
				case 0u:
					gform2_0.comboBox_1.SelectedIndex = 0;
					num = (int)((num2 * 1754092774) ^ 0x512C2D35);
					continue;
				default:
					return;
				case 7u:
					break;
				case 2u:
					return;
				case 3u:
					return;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	internal static int smethod_422(Class179.Class181 class181_0)
	{
		return class181_0.int_2;
	}

	internal static Class57 smethod_423(float float_0)
	{
		return new Class57((IntPtr)BitConverter.ToInt32(BitConverter.GetBytes(float_0), 0));
	}

	internal static bool smethod_424(Class89 class89_0, Class89.Class172 class172_0)
	{
		bool bool_ = (class172_0.method_8() & Class89.Enum44.flag_5) != 0;
		GClass1 gClass = default(GClass1);
		IntPtr intptr_2 = default(IntPtr);
		Class47 @class = default(Class47);
		Class157 class2 = default(Class157);
		uint num7 = default(uint);
		bool result = default(bool);
		IntPtr intptr_ = default(IntPtr);
		while (true)
		{
			int num = 747753993;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6133B4B7)) % 12)
				{
				case 11u:
					num = ((gClass != null) ? 1617806714 : 342505977) ^ (int)(num2 * 1384534457);
					continue;
				case 10u:
					intptr_2 = smethod_225(gClass, "RtlAddFunctionTable", bool_0: false);
					@class = new Class47(new Class53(), class89_0.method_19());
					smethod_15(@class);
					num = 1916041087;
					continue;
				case 9u:
					class2 = class172_0.method_0().method_6().method_3()
						.imethod_49()[3];
					num = ((int)num2 * -738077742) ^ 0x4F5D13EF;
					continue;
				case 6u:
					if (class89_0.method_19().method_6())
					{
						num = ((int)num2 * -845766627) ^ -1299211156;
						continue;
					}
					if ((class172_0.method_8() & Class89.Enum44.flag_0) == 0)
					{
						while (true)
						{
							int num6 = 171845372;
							while (true)
							{
								switch ((num2 = (uint)(num6 ^ 0x6133B4B7)) % 6)
								{
								case 5u:
									break;
								case 1u:
									num7 = class172_0.method_0().method_6().method_3()
										.imethod_29();
									num6 = (int)(num2 * 1859109924) ^ -656951645;
									continue;
								case 0u:
								{
									smethod_285(class89_0.method_19()).method_30(class172_0.method_2(), num7, out var bool_2);
									num6 = (bool_2 ? (-1516088331) : (-512947761)) ^ ((int)num2 * -157170035);
									continue;
								}
								case 3u:
									goto end_IL_045f;
								default:
									goto end_IL_0489;
								case 4u:
									return true;
								}
								if (smethod_285(class89_0.method_19()).method_24() != IntPtr.Zero)
								{
									num6 = ((int)num2 * -530202924) ^ 0x36CB85E0;
									continue;
								}
								goto IL_050e;
								continue;
								end_IL_045f:
								break;
							}
							continue;
							end_IL_0489:
							break;
						}
						try
						{
							Class92 class92_ = new Class92(class89_0.method_19());
							while (true)
							{
								IL_04e3:
								int num8 = 859009516;
								while (true)
								{
									switch ((num2 = (uint)(num8 ^ 0x6133B4B7)) % 3)
									{
									case 1u:
										goto IL_04a0;
									default:
										goto end_IL_04c5;
									case 0u:
										break;
									case 2u:
										goto end_IL_04c5;
									}
									goto IL_04e3;
									IL_04a0:
									intptr_ = class172_0.method_2();
									result = smethod_410(bool_, num7, class92_, intptr_);
									num8 = ((int)num2 * -1808432043) ^ 0x651632BC;
									continue;
									end_IL_04c5:
									break;
								}
								break;
							}
						}
						catch (Exception innerException3)
						{
							result = smethod_128(class89_0, new Exception("Unable to create VEH for exception handling.", innerException3));
						}
						goto IL_0509;
					}
					goto IL_050e;
				case 4u:
					smethod_54(@class, new Class57(intptr_2), CallingConvention.StdCall, new object[3]
					{
						class172_0.method_2().smethod_9(class2.method_0()),
						class2.method_2() / 12,
						class172_0.method_2()
					});
					num = (int)(num2 * 1860968546) ^ -38117065;
					continue;
				case 3u:
					num = ((class2.method_2() != 0) ? (-2043721373) : (-273699586)) ^ ((int)num2 * -1367162961);
					continue;
				case 2u:
					num = ((class2.method_0() == 0) ? (-1293876121) : (-1743957216)) ^ (int)(num2 * 2063953214);
					continue;
				case 1u:
					gClass = smethod_42(class89_0.method_19())["ntdll.dll"];
					num = 467160976;
					continue;
				case 7u:
					break;
				default:
					@class.method_4<uint>();
					smethod_226(@class, -1);
					try
					{
						if (!class89_0.method_21<bool>(@class))
						{
							while (true)
							{
								IL_023a:
								int num3 = 159156274;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ 0x6133B4B7)) % 4)
									{
									case 1u:
										goto IL_01f3;
									default:
										goto end_IL_0218;
									case 3u:
										break;
									case 2u:
										goto end_IL_0218;
									case 0u:
										goto IL_0509;
									}
									goto IL_023a;
									IL_01f3:
									result = smethod_128(class89_0, new Exception("RtlAddFunctionTable returned NULL."));
									num3 = ((int)num2 * -799601569) ^ 0x6A7E37A8;
									continue;
									end_IL_0218:
									break;
								}
								break;
							}
						}
					}
					catch (Exception innerException)
					{
						while (true)
						{
							IL_0291:
							int num4 = 1687069713;
							while (true)
							{
								switch ((num2 = (uint)(num4 ^ 0x6133B4B7)) % 3)
								{
								case 1u:
									goto IL_024c;
								case 0u:
									break;
								default:
									goto end_IL_0273;
								}
								goto IL_0291;
								IL_024c:
								result = smethod_128(class89_0, new AccessViolationException("Unable to add function table.", innerException));
								num4 = ((int)num2 * -1807800379) ^ 0x69F0A16A;
								continue;
								end_IL_0273:
								break;
							}
							break;
						}
						goto IL_0509;
					}
					try
					{
						Class92 class92_ = new Class92(class89_0.method_19());
						while (true)
						{
							IL_0370:
							int num5 = 1692987240;
							while (true)
							{
								switch ((num2 = (uint)(num5 ^ 0x6133B4B7)) % 7)
								{
								case 6u:
									result = true;
									num5 = 1001193383;
									continue;
								case 5u:
								{
									ulong ulong_ = class172_0.method_0().method_6().method_3()
										.imethod_29();
									num5 = (smethod_410(bool_, ulong_, class92_, intptr_) ? (-1079463147) : (-155605072)) ^ (int)(num2 * 157283344);
									continue;
								}
								case 4u:
									result = smethod_128(class89_0, new Exception("AddVectoredExceptionHandler returned NULL."));
									num5 = (int)(num2 * 1565327577) ^ -1558342489;
									continue;
								case 1u:
									intptr_ = class172_0.method_2();
									num5 = (int)((num2 * 1663965224) ^ 0x6C4B7B15);
									continue;
								default:
									goto end_IL_0342;
								case 2u:
									break;
								case 0u:
									goto end_IL_0342;
								case 3u:
									goto end_IL_0342;
								}
								goto IL_0370;
								continue;
								end_IL_0342:
								break;
							}
							break;
						}
					}
					catch (Exception innerException2)
					{
						result = smethod_128(class89_0, new Exception("Unable to create VEH for exception handling.", innerException2));
					}
					goto IL_0509;
				case 5u:
					return smethod_128(class89_0, new FileNotFoundException("Unable to find ntdll.dll in the specified process."));
				case 8u:
					{
						return true;
					}
					IL_050e:
					return class89_0.method_40();
					IL_0509:
					return result;
				}
				break;
			}
		}
	}

	internal static uint smethod_425(Class113 class113_0)
	{
		return class113_0.method_21<uint>(3);
	}

	internal static string smethod_426()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1214701600;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x59DFA929)) % 7)
				{
				case 6u:
					num4++;
					num = ((int)num2 * -2043740366) ^ -1210613553;
					continue;
				case 5u:
					stringBuilder.Append((Class9.random_0.Next(2) == 1) ? char.ToUpper("abcdefghijklmnopqrstuvwxyz0123456789"[Class9.random_0.Next("abcdefghijklmnopqrstuvwxyz0123456789".Length)]) : "abcdefghijklmnopqrstuvwxyz0123456789"[Class9.random_0.Next("abcdefghijklmnopqrstuvwxyz0123456789".Length)]);
					num = 362027199;
					continue;
				case 4u:
					num = (int)((num2 * 2058249138) ^ 0x60266B4F);
					continue;
				case 3u:
					num = ((num4 >= num3) ? 126734586 : 975612514);
					continue;
				case 2u:
					num3 = Class9.random_0.Next(5, 30);
					num4 = 0;
					num = (int)((num2 * 814251286) ^ 0x409E7C39);
					continue;
				case 0u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	[DllImport("ntdll.dll", EntryPoint = "NtQueryInformationThread", SetLastError = true)]
	internal static extern uint NtQueryInformationThread_1(IntPtr intptr_0, Class124.Enum25 enum25_0, out IntPtr intptr_1, int int_0, out int int_1);

	internal static bool smethod_427(GClass2 gclass2_0)
	{
		return !gclass2_0.method_6();
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool DeactivateActCtx(int int_0, IntPtr intptr_0);

	internal static string smethod_428(GClass4 gclass4_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -2009811485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2002537020)) % 11)
				{
				case 10u:
					stringBuilder.Append("abcdefghijklmnopqrstuvwxyz0123456789"[gclass4_0.random_0.Next("abcdefghijklmnopqrstuvwxyz0123456789".Length)]);
					num = -17987200;
					continue;
				case 9u:
					stringBuilder.Append("\\");
					num3 = 0;
					num = -1883849846;
					continue;
				case 8u:
					num = (int)((num2 * 1870334238) ^ 0x358837BF);
					continue;
				case 7u:
					num = ((num4 >= gclass4_0.random_0.Next(4, 8)) ? (-1443008879) : (-1580977083));
					continue;
				case 6u:
					num4++;
					num = ((int)num2 * -1882946318) ^ 0x437B6363;
					continue;
				case 5u:
					num4 = 0;
					num = ((int)num2 * -2122666048) ^ 0x2E0C9529;
					continue;
				case 3u:
					num = ((num3 >= gclass4_0.random_0.Next(4, 20)) ? (-1024140687) : (-1312626104));
					continue;
				case 1u:
					stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ"[gclass4_0.random_0.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Length)]).Append(':');
					num = ((int)num2 * -721303528) ^ -463269694;
					continue;
				case 0u:
					num3++;
					num = (int)(num2 * 2008923895) ^ -539220458;
					continue;
				case 2u:
					break;
				default:
					return stringBuilder.Append(".pdb").ToString();
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr CreateActCtx(ref Class124.Struct50 struct50_0);

	internal static void smethod_429(Class53 class53_0, Class63 class63_0, Class59 class59_0)
	{
		smethod_137(class53_0, Enum7.const_266, class63_0, class59_0);
	}

	internal static void ResolveSelectedProcess(MainForm mainForm)
	{
		string processName = mainForm.processNameTextBox.Text;
		if (!processName.Contains("."))
		{
			SetSelectedProcess(mainForm, null);
			return;
		}

		GClass2 process = smethod_148(processName, bool_0: true).FirstOrDefault();
		SetSelectedProcess(mainForm, process);
	}

	[DllImport("ntdll.dll")]
	internal static extern void RtlInitUnicodeString(out Class124.Struct43 struct43_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0);

	internal static void smethod_431(Class47.Enum6 enum6_0, Class47 class47_0, Class59 class59_0)
	{
		Class63[] array = new Class63[2]
		{
			Class49.class63_38,
			Class49.class63_39
		};
		while (true)
		{
			int num = 659726129;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1C28A858)) % 6)
				{
				case 5u:
					num = ((enum6_0 >= Class47.Enum6.const_2) ? (-477592048) : (-1342125189)) ^ (int)(num2 * 459966993);
					continue;
				case 3u:
					smethod_371(class47_0.class53_0, class59_0);
					num = 1868990529;
					continue;
				case 0u:
					smethod_429(class47_0.class53_0, array[(int)enum6_0], class59_0);
					num = (int)(num2 * 749078584) ^ -1505451904;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_432(Class56.Struct11 struct11_0, Class56 class56_0)
	{
		class56_0.method_1(Class56.smethod_0<Class56.Struct11, Class56.Struct7>(struct11_0));
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CloseHandle(IntPtr intptr_0);

	internal static Class59 smethod_433(IntPtr intptr_0, uint uint_0, Class63 class63_0)
	{
		Class59 @class = new Class59();
		while (true)
		{
			int num = 1024338629;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4F8009B9)) % 3)
				{
				case 1u:
					goto IL_0008;
				case 2u:
					break;
				default:
					return @class;
				}
				break;
				IL_0008:
				Class52.smethod_60()(@class, class63_0, intptr_0, uint_0);
				num = ((int)num2 * -2143689129) ^ -351832783;
			}
		}
	}

	internal static bool smethod_434(string string_0, string string_1)
	{
		if (!string_0.StartsWith("msvcr" + string_1, StringComparison.OrdinalIgnoreCase))
		{
			goto IL_0065;
		}
		goto IL_009f;
		IL_0065:
		int num = -807695399;
		goto IL_006a;
		IL_006a:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -2049228342)) % 6)
			{
			case 1u:
				num = (string_0.StartsWith("msvcp" + string_1, StringComparison.OrdinalIgnoreCase) ? 1516025877 : 1408513057) ^ (int)(num2 * 2000435714);
				continue;
			case 0u:
				break;
			case 5u:
				goto IL_009f;
			case 2u:
				return string_0.EndsWith(".dll", StringComparison.OrdinalIgnoreCase);
			default:
				return false;
			case 4u:
				return true;
			}
			break;
		}
		goto IL_0065;
		IL_009f:
		num = (string_0.EndsWith("d.dll", StringComparison.OrdinalIgnoreCase) ? (-1996802280) : (-430113638));
		goto IL_006a;
	}

	internal static ICryptoTransform smethod_435(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		try
		{
			return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_0, byte_1) : symmetricAlgorithm.CreateEncryptor(byte_0, byte_1);
		}
		finally
		{
			if (symmetricAlgorithm != null)
			{
				while (true)
				{
					IL_0053:
					int num = 661097860;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ 0x19A5CF39)) % 3)
						{
						case 1u:
							goto IL_0023;
						default:
							goto end_IL_0036;
						case 2u:
							break;
						case 0u:
							goto end_IL_0036;
						}
						goto IL_0053;
						IL_0023:
						((IDisposable)symmetricAlgorithm).Dispose();
						num = ((int)num2 * -1781071528) ^ 0x4B483DB0;
						continue;
						end_IL_0036:
						break;
					}
					break;
				}
			}
		}
	}

	internal static bool smethod_436(Class179.Class180 class180_0)
	{
		int int_ = class180_0.int_4;
		int num6 = default(int);
		int num4 = default(int);
		int num7 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 362105484;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x37F368BA)) % 47)
				{
				case 45u:
					num = (int)(num2 * 219656286) ^ -205718148;
					continue;
				case 44u:
					class180_0.class183_1 = Class179.Class183.class183_1;
					num = ((int)num2 * -516349916) ^ -1432668625;
					continue;
				case 43u:
					class180_0.int_8 -= num6;
					num = ((int)num2 * -1447246017) ^ -1595423273;
					continue;
				case 42u:
					num = (int)((num2 * 430371484) ^ 0x604A9DE2);
					continue;
				case 41u:
					num = ((class180_0.int_8 == 0) ? (-859630807) : (-879228617)) ^ ((int)num2 * -576239764);
					continue;
				case 40u:
					switch (int_)
					{
					case 2:
						goto IL_00e5;
					case 3:
						goto IL_0109;
					case 4:
						goto IL_0129;
					case 5:
						goto IL_0141;
					case 6:
						goto IL_0163;
					case 7:
					case 8:
					case 9:
					case 10:
						goto IL_0511;
					case 11:
						goto IL_0518;
					case 12:
						goto IL_051a;
					}
					num = (int)(num2 * 1805354572) ^ -1452677852;
					continue;
				case 30u:
					goto IL_00e5;
				case 39u:
					goto IL_0109;
				case 22u:
					goto IL_0129;
				case 29u:
					goto IL_0141;
				case 32u:
					goto IL_0163;
				case 37u:
					num = (((num4 & 1) != 0) ? 1407922705 : 101904180) ^ ((int)num2 * -391803759);
					continue;
				case 35u:
					class180_0.bool_0 = true;
					num = ((int)num2 * -1254971918) ^ 0x728823F0;
					continue;
				case 33u:
					class180_0.class183_0 = smethod_63(class180_0.class184_0);
					class180_0.class183_1 = smethod_62(class180_0.class184_0);
					num = 571084027;
					continue;
				case 28u:
					smethod_396(class180_0.class181_0, 3);
					num = 1452282308;
					continue;
				case 27u:
					class180_0.int_4 = 3;
					num = ((int)num2 * -1711257174) ^ -335702806;
					continue;
				case 26u:
					num = (int)((num2 * 534117641) ^ 0xB815BCD);
					continue;
				case 25u:
					num = ((num7 >= 0) ? 663913588 : 616067339) ^ (int)(num2 * 1267762008);
					continue;
				case 24u:
					smethod_141(class180_0.class181_0);
					num = 872832251;
					continue;
				case 23u:
					smethod_396(class180_0.class181_0, 16);
					num = 2099790088;
					continue;
				case 21u:
					goto IL_029b;
				case 20u:
					num = ((int)num2 * -251196449) ^ 0x230ECC11;
					continue;
				case 19u:
					class180_0.int_4 = 12;
					num = (int)((num2 * 2053654318) ^ 0x11263FC6);
					continue;
				case 17u:
					num = ((num5 >= 0) ? 1044340518 : 602371600) ^ (int)(num2 * 2134745621);
					continue;
				case 16u:
					class180_0.int_4 = 5;
					num = (int)(num2 * 495332007) ^ -611196955;
					continue;
				case 15u:
					class180_0.int_4 = 7;
					num = ((int)num2 * -1977439502) ^ -1390434363;
					continue;
				case 14u:
					switch (num3)
					{
					case 0:
						break;
					case 1:
						goto IL_029b;
					default:
						goto IL_034e;
					case 2:
						goto IL_0361;
					}
					goto case 24u;
				case 7u:
					goto IL_0361;
				case 11u:
					class180_0.int_4 = 2;
					num = ((int)num2 * -1492236967) ^ -1833135498;
					continue;
				case 9u:
					class180_0.int_4 = 7;
					num = (int)((num2 * 23252645) ^ 0x52BBE03C);
					continue;
				case 6u:
					class180_0.int_4 = 4;
					num = (int)((num2 * 1582771635) ^ 0x681A642D);
					continue;
				case 5u:
					num = ((num4 < 0) ? (-615466750) : (-1043804967)) ^ ((int)num2 * -2093761634);
					continue;
				case 3u:
					num4 = smethod_60(class180_0.class181_0, 3);
					num = 79393671;
					continue;
				case 1u:
					smethod_396(class180_0.class181_0, 16);
					num = 1562120;
					continue;
				case 0u:
					num3 = num4 >> 1;
					num = 194433039;
					continue;
				case 38u:
					break;
				case 2u:
					return true;
				case 4u:
					return false;
				case 8u:
					return false;
				case 10u:
					return false;
				case 12u:
					return false;
				case 18u:
					return true;
				case 34u:
					return !smethod_106(class180_0.class181_0);
				case 36u:
					goto IL_0511;
				default:
					goto IL_0518;
				case 13u:
					goto IL_051a;
				case 46u:
					{
						return false;
					}
					IL_0511:
					return smethod_348(class180_0);
					IL_0163:
					num = ((!smethod_305(class180_0.class184_0, class180_0.class181_0)) ? 693771016 : 850802448);
					continue;
					IL_0518:
					return false;
					IL_0361:
					class180_0.class184_0 = new Class179.Class184();
					class180_0.int_4 = 6;
					num = 798622650;
					continue;
					IL_034e:
					num = ((int)num2 * -1373167525) ^ 0x2FC9ABE0;
					continue;
					IL_0141:
					num6 = smethod_170(class180_0.class182_0, class180_0.class181_0, class180_0.int_8);
					num = 1476275907;
					continue;
					IL_029b:
					class180_0.class183_0 = Class179.Class183.class183_0;
					num = 398999694;
					continue;
					IL_0109:
					num7 = (class180_0.int_8 = smethod_60(class180_0.class181_0, 16));
					num = 2070007949;
					continue;
					IL_00e5:
					num = (class180_0.bool_0 ? 1988500195 : 763869425);
					continue;
					IL_0129:
					num5 = smethod_60(class180_0.class181_0, 16);
					num = 2030736736;
					continue;
					IL_051a:
					return false;
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool VerifyVersionInfo([In] ref Class124.Struct38 struct38_0, uint uint_0, ulong ulong_0);

	internal static void smethod_437(GClass4 gclass4_0, long long_0, long long_1)
	{
		byte[] buffer = new byte[long_1];
		gclass4_0.random_0.NextBytes(buffer);
		gclass4_0.class154_0.method_28().Position = long_0;
		gclass4_0.binaryWriter_0.Write(buffer);
	}

	[DllImport("kernel32.dll")]
	internal static extern bool Wow64GetThreadContext(IntPtr intptr_0, ref Class124.Struct54 struct54_0);

	internal static int smethod_438(Class179.Stream1 stream1_0)
	{
		return stream1_0.ReadByte() | (stream1_0.ReadByte() << 8);
	}

	[DllImport("ntdll.dll")]
	internal static extern uint NtSetInformationThread(IntPtr intptr_0, Class124.Enum25 enum25_0, IntPtr intptr_1, int int_0);

	internal static void smethod_439(Class53 class53_0, uint uint_0)
	{
		smethod_308(4L, uint_0, class53_0);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool GetTokenInformation(IntPtr intptr_0, Class121.Enum16 enum16_0, out uint uint_0, uint uint_1, out uint uint_2);

	internal static string smethod_440(string string_0, string string_1, string string_2, Enum43 enum43_0, int int_0, IntPtr intptr_0)
	{
		Class169.Class170 @class = new Class169.Class170();
		KeyValuePair<string, List<string>> keyValuePair = default(KeyValuePair<string, List<string>>);
		List<string> value = default(List<string>);
		string[] array = default(string[]);
		string text = default(string);
		string text2 = default(string);
		int num4 = default(int);
		string result = default(string);
		string text4 = default(string);
		string text3 = default(string);
		string environmentVariable = default(string);
		while (true)
		{
			int num = -650662351;
			while (true)
			{
				string text5;
				string text6;
				int num6;
				uint num2;
				switch ((num2 = (uint)(num ^ -1981681091)) % 31)
				{
				case 29u:
					@class.string_0 = Path.GetFileName(string_0);
					num = (Class127.bool_7 ? (-1364913063) : (-737535499)) ^ ((int)num2 * -1561389723);
					continue;
				case 28u:
					num = ((!Path.IsPathRooted(string_0)) ? (-1788888497) : (-646515600));
					continue;
				case 27u:
					num = (((enum43_0 & Enum43.flag_4) == 0) ? (-1335227476) : (-1426697291)) ^ ((int)num2 * -1189229907);
					continue;
				case 26u:
					keyValuePair = Class169.dictionary_0.FirstOrDefault(@class.method_0);
					num = -161131984;
					continue;
				case 25u:
					num = (smethod_136(ref string_0, intptr_0) ? (-1804593245) : (-38205909)) ^ ((int)num2 * -476063702);
					continue;
				case 24u:
					num = ((string_1.Length <= 0) ? (-1457353625) : (-87594712)) ^ ((int)num2 * -730463411);
					continue;
				case 21u:
					@class.string_0 = @class.string_0.Substring(4);
					num = ((int)num2 * -894624248) ^ -845003557;
					continue;
				case 20u:
					num = (((enum43_0 & Enum43.flag_3) == 0) ? (-1828595556) : (-483456755));
					continue;
				case 18u:
					num = (((enum43_0 & Enum43.flag_1) == 0) ? (-1681691906) : (-1065504100));
					continue;
				case 17u:
					num = (@class.string_0.StartsWith("ext-ms-") ? 1389390605 : 1196899425) ^ (int)(num2 * 1578652169);
					continue;
				case 16u:
					text5 = value.Last();
					goto IL_01ba;
				case 15u:
					if (!(value.First() != string_1))
					{
						num = ((int)num2 * -327969056) ^ 0x41A41313;
						continue;
					}
					text5 = value.First();
					goto IL_01ba;
				case 12u:
					value = keyValuePair.Value;
					num = ((int)num2 * -1660292329) ^ 0x18A1378F;
					continue;
				case 11u:
					num = (((enum43_0 & Enum43.flag_2) == 0) ? (-2030513069) : (-1026820125));
					continue;
				case 9u:
					num = ((keyValuePair.Key == null) ? (-353454714) : (-770617207)) ^ ((int)num2 * -2039735746);
					continue;
				case 8u:
					text6 = string_1.ToLowerInvariant();
					goto IL_0262;
				case 7u:
					string_0 = string_0.ToLowerInvariant();
					if (!string.IsNullOrEmpty(string_1))
					{
						num = ((int)num2 * -1964382031) ^ -1651181957;
						continue;
					}
					text6 = string.Empty;
					goto IL_0262;
				case 5u:
					num = ((keyValuePair.Value.Count < 1) ? (-1379572966) : (-171819431)) ^ ((int)num2 * -807529292);
					continue;
				case 3u:
					num = ((keyValuePair.Value == null) ? (-759757346) : (-818792076)) ^ ((int)num2 * -851161492);
					continue;
				case 2u:
					num = ((!File.Exists(string_0)) ? 156468471 : 64656344) ^ ((int)num2 * -825948776);
					continue;
				case 0u:
					num = ((!smethod_136(ref string_0, intptr_0)) ? (-1330248542) : (-983201955));
					continue;
				case 19u:
					break;
				case 1u:
					return string_0;
				case 4u:
					return Path.Combine(Class127.string_2, string_0);
				case 6u:
					return Path.Combine(Class127.string_1, string_0);
				case 10u:
					return null;
				case 13u:
					return string_0;
				case 14u:
					return null;
				case 22u:
					return string_0;
				case 23u:
					return string_0;
				default:
					{
						RegistryKey registryKey = null;
						try
						{
							registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\KnownDLLs");
							while (true)
							{
								IL_05e9:
								int num3 = -1328324977;
								while (true)
								{
									switch ((num2 = (uint)(num3 ^ -1981681091)) % 15)
									{
									case 13u:
										array = registryKey.GetValueNames();
										num3 = (int)(num2 * 898882130) ^ -1116507635;
										continue;
									case 12u:
										registryKey.Close();
										num3 = (int)((num2 * 697106196) ^ 0x6B3AC8CD);
										continue;
									case 11u:
										num3 = ((int)num2 * -125852992) ^ 0x60C1CDFB;
										continue;
									case 10u:
										text = registryKey.GetValue(((enum43_0 & Enum43.flag_4) != Enum43.flag_0) ? "DllDirectory32" : "DllDirectory") as string;
										num3 = -1716291897;
										continue;
									case 9u:
										num3 = ((text2 == null) ? (-800190501) : (-1507198816)) ^ (int)(num2 * 1511004368);
										continue;
									case 8u:
									{
										string name = array[num4];
										text2 = registryKey.GetValue(name) as string;
										num3 = -502192251;
										continue;
									}
									case 7u:
										num3 = ((registryKey != null) ? (-141465939) : (-1289806511)) ^ ((int)num2 * -1455511396);
										continue;
									case 6u:
										num3 = ((num4 >= array.Length) ? (-347979496) : (-1588393580));
										continue;
									case 4u:
										num4++;
										num3 = -417206725;
										continue;
									case 3u:
										num4 = 0;
										num3 = ((int)num2 * -1703178435) ^ 0x34C54050;
										continue;
									case 1u:
										num3 = ((!text2.Equals(@class.string_0, StringComparison.OrdinalIgnoreCase)) ? 112847159 : 27758244) ^ (int)(num2 * 594172252);
										continue;
									case 0u:
										num3 = ((text == null) ? 576481995 : 1854774867) ^ (int)(num2 * 1434397672);
										continue;
									default:
										goto end_IL_059a;
									case 5u:
										break;
									case 2u:
										registryKey.Close();
										result = Path.Combine(text, text2);
										return result;
									case 14u:
										goto end_IL_059a;
									}
									goto IL_05e9;
									continue;
									end_IL_059a:
									break;
								}
								break;
							}
						}
						catch
						{
						}
						finally
						{
							if (registryKey != null)
							{
								while (true)
								{
									IL_0642:
									int num5 = -102725329;
									while (true)
									{
										switch ((num2 = (uint)(num5 ^ -1981681091)) % 3)
										{
										case 2u:
											goto IL_0610;
										default:
											goto end_IL_0624;
										case 0u:
											break;
										case 1u:
											goto end_IL_0624;
										}
										goto IL_0642;
										IL_0610:
										registryKey.Close();
										num5 = ((int)num2 * -1125825718) ^ -298467781;
										continue;
										end_IL_0624:
										break;
									}
									break;
								}
							}
						}
						if (!string.IsNullOrEmpty(string_2))
						{
							goto IL_0707;
						}
						goto IL_09b0;
					}
					IL_09b0:
					num6 = ((int_0 != 0) ? (-1423674231) : (-503829033));
					goto IL_091e;
					IL_091e:
					while (true)
					{
						string path;
						switch ((num2 = (uint)(num6 ^ -1981681091)) % 28)
						{
						case 25u:
							text4 = array[num4];
							num6 = -495439490;
							continue;
						case 24u:
							text3 = Path.Combine(Path.GetDirectoryName(smethod_47(int_0).method_4()), @class.string_0);
							num6 = ((int)num2 * -135185338) ^ -1880361875;
							continue;
						case 23u:
							break;
						case 22u:
							array = environmentVariable.Split(';');
							num4 = 0;
							num6 = ((int)num2 * -508002088) ^ -1055264709;
							continue;
						case 21u:
							goto end_IL_091e;
						case 19u:
							goto IL_0711;
						case 14u:
							num6 = ((int)num2 * -987523071) ^ -1793302756;
							continue;
						case 13u:
							text3 = Path.Combine(Environment.CurrentDirectory, @class.string_0);
							num6 = -1831864875;
							continue;
						case 12u:
							num6 = (File.Exists(text3) ? 1220954646 : 411545295) ^ ((int)num2 * -1981206001);
							continue;
						case 11u:
							num6 = ((!text4.Equals(Class127.string_1, StringComparison.OrdinalIgnoreCase)) ? (-1921698981) : (-1021550079)) ^ (int)(num2 * 1634420511);
							continue;
						case 9u:
							num4++;
							num6 = -1683112374;
							continue;
						case 8u:
							num6 = ((!File.Exists(text3)) ? 1345052954 : 1373808812) ^ (int)(num2 * 1960578900);
							continue;
						case 7u:
							num6 = (((enum43_0 & Enum43.flag_4) == 0) ? 252168476 : 50377060) ^ (int)(num2 * 1026803198);
							continue;
						case 6u:
							if ((enum43_0 & Enum43.flag_4) == 0)
							{
								num6 = -512145623;
								continue;
							}
							path = Class127.string_2;
							goto IL_083f;
						case 5u:
							num6 = ((!File.Exists(text3)) ? (-368187429) : (-2021062277)) ^ (int)(num2 * 850977140);
							continue;
						case 4u:
							path = Class127.string_1;
							goto IL_083f;
						case 3u:
							goto IL_0889;
						case 2u:
							goto IL_08b7;
						case 1u:
							text3 = Path.Combine(string_2, @class.string_0);
							num6 = ((!File.Exists(text3)) ? 749925931 : 1229213245) ^ (int)(num2 * 836721340);
							continue;
						case 10u:
							goto IL_09b0;
						case 0u:
							return null;
						case 15u:
							return text3;
						case 16u:
							return text3;
						case 17u:
							return text3;
						case 18u:
							return text3;
						case 20u:
							return text3;
						case 26u:
							return text3;
						default:
							{
								return result;
							}
							IL_083f:
							text3 = Path.Combine(path, @class.string_0);
							num6 = -533040600;
							continue;
						}
						text3 = Path.Combine(text4, @class.string_0);
						num6 = ((!File.Exists(text3)) ? (-1304046788) : (-1106451249));
						continue;
						IL_08b7:
						text3 = Path.Combine(Class127.string_0, @class.string_0);
						num6 = ((!File.Exists(text3)) ? (-1845936252) : (-111863759));
						continue;
						IL_0711:
						num6 = ((num4 < array.Length) ? (-1586074812) : (-1464990319));
						continue;
						IL_0889:
						environmentVariable = Environment.GetEnvironmentVariable("PATH");
						num6 = ((environmentVariable != null) ? (-1099240477) : (-1464990319));
						continue;
						end_IL_091e:
						break;
					}
					goto IL_0707;
					IL_0707:
					num6 = -799320596;
					goto IL_091e;
					IL_01ba:
					string_0 = text5;
					num = -755327658;
					continue;
					IL_0262:
					string_1 = text6;
					num = -466642217;
					continue;
				}
				break;
			}
		}
	}

	internal static int smethod_441(Class53 class53_0, IntPtr intptr_0, IntPtr intptr_1)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			goto IL_0023;
		}
		goto IL_006c;
		IL_0023:
		int num = 358328795;
		goto IL_0028;
		IL_0028:
		IntPtr intPtr = default(IntPtr);
		switch ((uint)(num ^ 0x4BAB216B) % 5u)
		{
		case 4u:
			break;
		case 2u:
			goto IL_004b;
		case 0u:
			goto IL_006c;
		case 1u:
			throw new ArgumentException("The value cannot be IntPtr.Zero.", "dst");
		default:
			return intPtr.ToInt32();
		}
		goto IL_0023;
		IL_006c:
		IntPtr intPtr2;
		if (Class49.bool_0)
		{
			intPtr2 = Class52.smethod_26()(ref class53_0.struct19_0, intptr_0, intptr_1);
			goto IL_005d;
		}
		num = 581705563;
		goto IL_0028;
		IL_004b:
		intPtr2 = Class52.smethod_24()(ref class53_0.struct19_0, intptr_0, intptr_1);
		goto IL_005d;
		IL_005d:
		intPtr = intPtr2;
		num = 878799475;
		goto IL_0028;
	}

	internal static string smethod_442(long long_0)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		while (true)
		{
			int num = -1932533864;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -689469890)) % 3)
				{
				case 1u:
					goto IL_000d;
				case 0u:
					break;
				default:
					return stringBuilder.ToString();
				}
				break;
				IL_000d:
				StrFormatByteSize(long_0, stringBuilder, stringBuilder.Capacity);
				num = ((int)num2 * -1723419399) ^ 0x35B68A52;
			}
		}
	}

	internal static IntPtr smethod_443(IntPtr intptr_0, Class53 class53_0, Class84 class84_0)
	{
		IntPtr intPtr = smethod_397(class53_0);
		if (intPtr == IntPtr.Zero)
		{
			goto IL_0029;
		}
		goto IL_00ed;
		IL_0029:
		int num = 1310917854;
		goto IL_00ad;
		IL_00ad:
		byte[] array = default(byte[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x2B412A0C)) % 8)
			{
			case 7u:
				break;
			case 4u:
				smethod_51().method_03FF(intPtr);
				smethod_115(class53_0);
				num = ((int)num2 * -584882684) ^ -361535214;
				continue;
			case 3u:
			{
				int num3 = smethod_441(class53_0, intPtr, intptr_0);
				array = new byte[num3];
				Marshal.Copy(intPtr, array, 0, num3);
				num = 573603616;
				continue;
			}
			case 1u:
				intptr_0 = smethod_175(class84_0, smethod_252(class53_0), Class124.Enum34.flag_2);
				num = ((intptr_0 == IntPtr.Zero) ? 1060938478 : 1673520685) ^ (int)(num2 * 921516514);
				continue;
			case 5u:
				goto IL_00ed;
			case 0u:
				return IntPtr.Zero;
			case 2u:
				return IntPtr.Zero;
			default:
				class84_0.method_16(intptr_0, array);
				return intptr_0;
			}
			break;
		}
		goto IL_0029;
		IL_00ed:
		num = ((!(intptr_0 == IntPtr.Zero)) ? 398598959 : 1881601181);
		goto IL_00ad;
	}

	internal static bool smethod_444(ref Class158 class158_0, [Out] Class5 class5_0)
	{
		class158_0 = null;
		while (true)
		{
			int num = -1854229931;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1723750453)) % 8)
				{
				case 7u:
					class158_0 = new Class158();
					num = ((class5_0.ReadUInt16() != 23117) ? (-472599502) : (-1032085040));
					continue;
				case 6u:
					num = ((class5_0.BaseStream.Length >= 128L) ? (-1638458688) : (-2045615157)) ^ ((int)num2 * -805455514);
					continue;
				case 5u:
					class158_0.method_1(class5_0.ReadUInt32());
					num = (int)((num2 * 719228764) ^ 0x49171FB5);
					continue;
				case 3u:
					smethod_217(class5_0, 58);
					num = -436551962;
					continue;
				case 0u:
					break;
				case 1u:
					return false;
				default:
					return true;
				case 4u:
					return false;
				}
				break;
			}
		}
	}

	internal static IntPtr smethod_445(IntPtr intptr_0, int int_0)
	{
		if (Class127.bool_0)
		{
			return GetClassLongPtr(intptr_0, int_0);
		}
		return (IntPtr)GetClassLong(intptr_0, int_0);
	}

	internal static Class57 smethod_446(double double_0)
	{
		return new Class57((IntPtr)BitConverter.ToInt64(BitConverter.GetBytes(double_0), 0));
	}

	internal static BinaryReader smethod_447(Stream stream_0)
	{
		return new BinaryReader(stream_0);
	}

	internal static void smethod_448(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

	internal static uint smethod_449(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static long smethod_450(Stream stream_0)
	{
		return stream_0.Position;
	}

	internal static int smethod_451(Random random_0, int int_0)
	{
		return random_0.Next(int_0);
	}

	internal static void smethod_452(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	internal static byte smethod_453(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadByte();
	}

	internal static void smethod_454(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static long smethod_455(Stream stream_0)
	{
		return stream_0.Length;
	}

	internal static byte[] smethod_456(BinaryReader binaryReader_0, int int_0)
	{
		return binaryReader_0.ReadBytes(int_0);
	}

	internal static Type smethod_457(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int smethod_458(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	internal static string smethod_459(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	internal static TypeBuilder smethod_460(ModuleBuilder moduleBuilder_0, string string_0, TypeAttributes typeAttributes_0)
	{
		return moduleBuilder_0.DefineType(string_0, typeAttributes_0);
	}

	internal static int smethod_461(Random random_0, int int_0, int int_1)
	{
		return random_0.Next(int_0, int_1);
	}

	internal static MethodBuilder smethod_462(TypeBuilder typeBuilder_0, string string_0, MethodAttributes methodAttributes_0, Type type_0, Type[] type_1)
	{
		return typeBuilder_0.DefineMethod(string_0, methodAttributes_0, type_0, type_1);
	}

	internal static ILGenerator smethod_463(MethodBuilder methodBuilder_0)
	{
		return methodBuilder_0.GetILGenerator();
	}

	internal static bool smethod_464(Type type_0, Type type_1)
	{
		return type_0 != type_1;
	}

	internal static LocalBuilder smethod_465(ILGenerator ilgenerator_0, Type type_0)
	{
		return ilgenerator_0.DeclareLocal(type_0);
	}

	internal static void smethod_466(ILGenerator ilgenerator_0, OpCode opCode_0, LocalBuilder localBuilder_0)
	{
		ilgenerator_0.Emit(opCode_0, localBuilder_0);
	}

	internal static void smethod_467(ILGenerator ilgenerator_0, OpCode opCode_0, Type type_0)
	{
		ilgenerator_0.Emit(opCode_0, type_0);
	}

	internal static void smethod_468(ILGenerator ilgenerator_0, OpCode opCode_0)
	{
		ilgenerator_0.Emit(opCode_0);
	}

	internal static bool smethod_469(Type type_0, Type type_1)
	{
		return type_0 == type_1;
	}

	internal static FieldBuilder smethod_470(TypeBuilder typeBuilder_0, string string_0, Type type_0, FieldAttributes fieldAttributes_0)
	{
		return typeBuilder_0.DefineField(string_0, type_0, fieldAttributes_0);
	}

	internal static Stream smethod_471(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static ushort smethod_472(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt16();
	}

	internal static MemoryStream smethod_473()
	{
		return new MemoryStream();
	}

	internal static byte[] smethod_474(MemoryStream memoryStream_0)
	{
		return memoryStream_0.ToArray();
	}

	internal static void smethod_475(System.Windows.Forms.Timer timer_0)
	{
		timer_0.Stop();
	}

	internal static void smethod_476(Control control_0, bool bool_0)
	{
		control_0.Enabled = bool_0;
	}

	internal static DialogResult smethod_477(IWin32Window iwin32Window_0, string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(iwin32Window_0, string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static bool smethod_478(WaitCallback waitCallback_0)
	{
		return ThreadPool.QueueUserWorkItem(waitCallback_0);
	}

	internal static int smethod_479(object object_0)
	{
		return Marshal.SizeOf(object_0);
	}

	internal static Icon smethod_480(IntPtr intptr_0)
	{
		return Icon.FromHandle(intptr_0);
	}

	internal static object smethod_481(Icon icon_0)
	{
		return icon_0.Clone();
	}

	internal static IntPtr smethod_482(int int_0)
	{
		return Marshal.AllocHGlobal(int_0);
	}

	internal static int smethod_483()
	{
		return RuntimeHelpers.OffsetToStringData;
	}

	internal static int smethod_484(string string_0)
	{
		return string_0.Length;
	}

	internal static bool smethod_485(Type type_0, Type type_1)
	{
		return type_0.IsAssignableFrom(type_1);
	}

	internal static Type smethod_486(Type type_0)
	{
		return Enum.GetUnderlyingType(type_0);
	}

	internal static InvalidOperationException smethod_487(string string_0)
	{
		return new InvalidOperationException(string_0);
	}

	internal static void smethod_488(IntPtr intptr_0)
	{
		Marshal.FreeHGlobal(intptr_0);
	}

	internal static object smethod_489(IntPtr intptr_0, Type type_0)
	{
		return Marshal.PtrToStructure(intptr_0, type_0);
	}

	internal static GroupBox smethod_490()
	{
		return new GroupBox();
	}

	internal static Button smethod_491()
	{
		return new Button();
	}

	internal static TextBox smethod_492()
	{
		return new TextBox();
	}

	internal static ComboBox smethod_493()
	{
		return new ComboBox();
	}

	internal static DataGridView smethod_494()
	{
		return new DataGridView();
	}

	internal static DataGridViewTextBoxColumn smethod_495()
	{
		return new DataGridViewTextBoxColumn();
	}

	internal static System.Windows.Forms.Label smethod_496()
	{
		return new System.Windows.Forms.Label();
	}

	internal static void smethod_497(Control control_0)
	{
		control_0.SuspendLayout();
	}

	internal static void smethod_498(ISupportInitialize isupportInitialize_0)
	{
		isupportInitialize_0.BeginInit();
	}

	internal static void smethod_499(Control control_0)
	{
		control_0.SuspendLayout();
	}

	internal static Control.ControlCollection smethod_500(Control control_0)
	{
		return control_0.Controls;
	}

	internal static void smethod_501(Control.ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	internal static DataGridViewRowCollection smethod_502(DataGridView dataGridView_0)
	{
		return dataGridView_0.Rows;
	}

	internal static void smethod_503(DataGridViewRowCollection dataGridViewRowCollection_0)
	{
		dataGridViewRowCollection_0.Clear();
	}

	internal static Bitmap smethod_504(int int_0, int int_1)
	{
		return new Bitmap(int_0, int_1);
	}

	internal static string smethod_505(string string_0, object object_0, object object_1)
	{
		return string.Format(string_0, object_0, object_1);
	}

	internal static int smethod_506(DataGridViewRowCollection dataGridViewRowCollection_0, object[] object_0)
	{
		return dataGridViewRowCollection_0.Add(object_0);
	}

	internal static DataGridViewRow smethod_507(DataGridViewRowCollection dataGridViewRowCollection_0, int int_0)
	{
		return dataGridViewRowCollection_0[int_0];
	}

	internal static void smethod_508(DataGridViewBand dataGridViewBand_0, object object_0)
	{
		dataGridViewBand_0.Tag = object_0;
	}

	internal static int smethod_509(DataGridViewRowCollection dataGridViewRowCollection_0)
	{
		return dataGridViewRowCollection_0.Count;
	}

	internal static void smethod_510(DataGridViewBand dataGridViewBand_0, bool bool_0)
	{
		dataGridViewBand_0.Selected = bool_0;
	}

	internal static MissingMethodException smethod_511(string string_0)
	{
		return new MissingMethodException(string_0);
	}

	internal static string smethod_512()
	{
		return Path.GetTempFileName();
	}

	internal static void smethod_513(string string_0, byte[] byte_0)
	{
		File.WriteAllBytes(string_0, byte_0);
	}

	internal static void smethod_514(string string_0)
	{
		File.Delete(string_0);
	}

	internal static AccessViolationException smethod_515(string string_0)
	{
		return new AccessViolationException(string_0);
	}

	internal static Encoding smethod_516()
	{
		return Encoding.Unicode;
	}

	internal static string smethod_517(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static byte[] smethod_518(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	internal static bool smethod_519(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	internal static FileStream smethod_520(string string_0, FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0)
	{
		return new FileStream(string_0, fileMode_0, fileAccess_0, fileShare_0);
	}

	internal static MissingFieldException smethod_521(string string_0)
	{
		return new MissingFieldException(string_0);
	}

	internal static Encoding smethod_522()
	{
		return Encoding.ASCII;
	}

	internal static BinaryWriter smethod_523(Stream stream_0)
	{
		return new BinaryWriter(stream_0);
	}

	internal static void smethod_524(BinaryWriter binaryWriter_0, uint uint_0)
	{
		binaryWriter_0.Write(uint_0);
	}

	internal static char smethod_525(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	internal static void smethod_526(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}

	internal static int smethod_527(Random random_0)
	{
		return random_0.Next();
	}

	internal static void smethod_528(BinaryWriter binaryWriter_0, byte[] byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	internal static DialogResult smethod_529(Form form_0)
	{
		return form_0.ShowDialog();
	}

	internal static void smethod_530(Array array_0, int int_0, Array array_1, int int_1, int int_2)
	{
		Array.Copy(array_0, int_0, array_1, int_1, int_2);
	}

	internal static string smethod_531(string string_0)
	{
		return Path.GetDirectoryName(string_0);
	}

	internal static FileNotFoundException smethod_532(string string_0)
	{
		return new FileNotFoundException(string_0);
	}

	internal static Exception smethod_533(string string_0, Exception exception_0)
	{
		return new Exception(string_0, exception_0);
	}

	internal static void smethod_534(Stream stream_0, long long_0)
	{
		stream_0.SetLength(long_0);
	}

	internal static InvalidOperationException smethod_535()
	{
		return new InvalidOperationException();
	}

	internal static StringBuilder smethod_536(string string_0)
	{
		return new StringBuilder(string_0);
	}

	internal static Assembly smethod_537(Type type_0)
	{
		return type_0.Assembly;
	}

	internal static AssemblyName smethod_538(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	internal static Version smethod_539(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Version;
	}

	internal static int smethod_540(Version version_0)
	{
		return version_0.Major;
	}

	internal static StringBuilder smethod_541(StringBuilder stringBuilder_0, int int_0)
	{
		return stringBuilder_0.Append(int_0);
	}

	internal static StringBuilder smethod_542(StringBuilder stringBuilder_0, char char_0)
	{
		return stringBuilder_0.Append(char_0);
	}

	internal static int smethod_543(Version version_0)
	{
		return version_0.Minor;
	}

	internal static int smethod_544(Version version_0)
	{
		return version_0.Build;
	}

	internal static StringBuilder smethod_545(StringBuilder stringBuilder_0, string string_0)
	{
		return stringBuilder_0.Append(string_0);
	}

	internal static string smethod_546(object object_0)
	{
		return object_0.ToString();
	}

	internal static void smethod_547(Control control_0, string string_0)
	{
		control_0.Text = string_0;
	}

	internal static StringBuilder smethod_548(int int_0)
	{
		return new StringBuilder(int_0);
	}

	internal static int smethod_549(StringBuilder stringBuilder_0)
	{
		return stringBuilder_0.Capacity;
	}

	internal static string smethod_550(string string_0)
	{
		return Path.GetFileName(string_0);
	}

	internal static bool smethod_551(string string_0)
	{
		return string.IsNullOrEmpty(string_0);
	}

	internal static DataGridViewSelectedRowCollection smethod_552(DataGridView dataGridView_0)
	{
		return dataGridView_0.SelectedRows;
	}

	internal static DataGridViewRow smethod_553(DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection_0, int int_0)
	{
		return dataGridViewSelectedRowCollection_0[int_0];
	}

	internal static object smethod_554(DataGridViewBand dataGridViewBand_0)
	{
		return dataGridViewBand_0.Tag;
	}

	internal static string smethod_555(Encoding encoding_0, byte[] byte_0)
	{
		return encoding_0.GetString(byte_0);
	}

	internal static object smethod_556(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetObject(string_0, cultureInfo_0);
	}

	internal static Bitmap smethod_557(Icon icon_0)
	{
		return icon_0.ToBitmap();
	}

	internal static Graphics smethod_558(Image image_0)
	{
		return Graphics.FromImage(image_0);
	}

	internal static void smethod_559(Graphics graphics_0, InterpolationMode interpolationMode_0)
	{
		graphics_0.InterpolationMode = interpolationMode_0;
	}

	internal static int smethod_560(Image image_0)
	{
		return image_0.Width;
	}

	internal static int smethod_561(Image image_0)
	{
		return image_0.Height;
	}

	internal static void smethod_562(Graphics graphics_0, Image image_0, int int_0, int int_1, int int_2, int int_3)
	{
		graphics_0.DrawImage(image_0, int_0, int_1, int_2, int_3);
	}

	internal static UnauthorizedAccessException smethod_563(string string_0)
	{
		return new UnauthorizedAccessException(string_0);
	}

	internal static void smethod_564(Control control_0, object object_0)
	{
		control_0.Tag = object_0;
	}

	internal static void smethod_565(CheckBox checkBox_0, EventHandler eventHandler_0)
	{
		checkBox_0.CheckedChanged += eventHandler_0;
	}

	internal static object smethod_566(FieldInfo fieldInfo_0, object object_0)
	{
		return fieldInfo_0.GetValue(object_0);
	}

	internal static void smethod_567(CheckBox checkBox_0, bool bool_0)
	{
		checkBox_0.Checked = bool_0;
	}

	internal static DataGridViewCellCollection smethod_568(DataGridViewRow dataGridViewRow_0)
	{
		return dataGridViewRow_0.Cells;
	}

	internal static DataGridViewCell smethod_569(DataGridViewCellCollection dataGridViewCellCollection_0, int int_0)
	{
		return dataGridViewCellCollection_0[int_0];
	}

	internal static object smethod_570(DataGridViewCell dataGridViewCell_0)
	{
		return dataGridViewCell_0.Value;
	}

	internal static void smethod_571(DataGridViewCell dataGridViewCell_0, object object_0)
	{
		dataGridViewCell_0.Value = object_0;
	}

	internal static ComponentResourceManager smethod_572(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	internal static ProgressBar smethod_573()
	{
		return new ProgressBar();
	}

	internal static void smethod_574(Control control_0, bool bool_0)
	{
		control_0.AutoSize = bool_0;
	}

	internal static Font smethod_575(string string_0, float float_0)
	{
		return new Font(string_0, float_0);
	}

	internal static void smethod_576(Control control_0, Font font_0)
	{
		control_0.Font = font_0;
	}

	internal static RuntimeTypeHandle smethod_577(Type type_0)
	{
		return type_0.TypeHandle;
	}

	internal static void smethod_578(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		RuntimeHelpers.RunClassConstructor(runtimeTypeHandle_0);
	}

	internal static string smethod_579(object object_0, object object_1, object object_2)
	{
		return string.Concat(object_0, object_1, object_2);
	}

	internal static string smethod_580(IntPtr intptr_0, int int_0)
	{
		return Marshal.PtrToStringUni(intptr_0, int_0);
	}

	internal static string smethod_581(string string_0)
	{
		return string_0.ToLowerInvariant();
	}

	internal static ResourceManager smethod_582(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}

	internal static bool smethod_583(object object_0, object object_1)
	{
		return object_0.Equals(object_1);
	}

	internal static bool smethod_584(string string_0, string string_1)
	{
		return string_0.EndsWith(string_1);
	}

	internal static string smethod_585(string string_0, int int_0, int int_1)
	{
		return string_0.Substring(int_0, int_1);
	}

	internal static Int64Converter smethod_586()
	{
		return new Int64Converter();
	}

	internal static object smethod_587(TypeConverter typeConverter_0, string string_0)
	{
		return typeConverter_0.ConvertFromString(string_0);
	}

	internal static bool smethod_588(string string_0, string string_1)
	{
		return string_0.StartsWith(string_1);
	}

	internal static string smethod_589(string string_0, int int_0)
	{
		return string_0.Substring(int_0);
	}

	internal static string smethod_590()
	{
		return Path.GetTempPath();
	}

	internal static string smethod_591(string string_0, string string_1, string string_2)
	{
		return string_0.Replace(string_1, string_2);
	}

	internal static string smethod_592(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	internal static bool smethod_593(string string_0)
	{
		return File.Exists(string_0);
	}

	internal static bool smethod_594(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string_0.EndsWith(string_1, stringComparison_0);
	}

	internal static bool smethod_595(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string_0.Equals(string_1, stringComparison_0);
	}

	internal static ObjectDisposedException smethod_596(string string_0, string string_1)
	{
		return new ObjectDisposedException(string_0, string_1);
	}

	internal static object smethod_597(Control control_0, Delegate delegate_0)
	{
		return control_0.Invoke(delegate_0);
	}

	internal static void smethod_598(BinaryWriter binaryWriter_0, ushort ushort_0)
	{
		binaryWriter_0.Write(ushort_0);
	}

	internal static ulong smethod_599(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt64();
	}

	internal static void smethod_600(BinaryWriter binaryWriter_0, ulong ulong_0)
	{
		binaryWriter_0.Write(ulong_0);
	}

	internal static int smethod_601(int int_0, int int_1)
	{
		return Math.Min(int_0, int_1);
	}

	internal static void smethod_602(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static void smethod_603(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static string smethod_604(string[] string_0)
	{
		return string.Concat(string_0);
	}

	internal static void smethod_605(Array array_0)
	{
		Array.Reverse(array_0);
	}

	internal static string smethod_606(string string_0, int int_0, string string_1)
	{
		return string_0.Insert(int_0, string_1);
	}

	internal static StringBuilder smethod_607()
	{
		return new StringBuilder();
	}

	internal static bool smethod_608()
	{
		return NetworkInterface.GetIsNetworkAvailable();
	}

	internal static string smethod_609(WebClient webClient_0, string string_0)
	{
		return webClient_0.DownloadString(string_0);
	}

	internal static Assembly smethod_610()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static bool smethod_611(string string_0, string string_1)
	{
		return string_0 != string_1;
	}

	internal static bool smethod_612(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	internal static int smethod_613(byte[] byte_0, int int_0)
	{
		return BitConverter.ToInt32(byte_0, int_0);
	}

	internal static DESCryptoServiceProvider smethod_614()
	{
		return new DESCryptoServiceProvider();
	}

	internal static ICryptoTransform smethod_615(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		return symmetricAlgorithm_0.CreateEncryptor(byte_0, byte_1);
	}

	internal static ICryptoTransform smethod_616(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		return symmetricAlgorithm_0.CreateDecryptor(byte_0, byte_1);
	}

	internal static string smethod_617(string string_0, object object_0)
	{
		return string.Format(string_0, object_0);
	}

	internal static IntPtr smethod_618(IntPtr intptr_0)
	{
		return Marshal.ReadIntPtr(intptr_0);
	}

	internal static IntPtr smethod_619(IntPtr intptr_0, int int_0)
	{
		return Marshal.ReadIntPtr(intptr_0, int_0);
	}

	internal static void smethod_620(IntPtr intptr_0, byte[] byte_0, int int_0, int int_1)
	{
		Marshal.Copy(intptr_0, byte_0, int_0, int_1);
	}

	internal static Delegate smethod_621(IntPtr intptr_0, Type type_0)
	{
		return Marshal.GetDelegateForFunctionPointer(intptr_0, type_0);
	}

	internal static void smethod_622(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}

	internal static IAsyncResult smethod_623(Control control_0, Delegate delegate_0)
	{
		return control_0.BeginInvoke(delegate_0);
	}

	internal static void smethod_624(int int_0)
	{
		Thread.Sleep(int_0);
	}

	internal static Win32Exception smethod_625(int int_0)
	{
		return new Win32Exception(int_0);
	}

	internal static string smethod_626(Exception exception_0)
	{
		return exception_0.Message;
	}

	internal static string smethod_627(string string_0)
	{
		return Path.GetFileNameWithoutExtension(string_0);
	}

	internal static string smethod_628(string string_0)
	{
		return Path.GetExtension(string_0);
	}

	internal static string smethod_629(object[] object_0)
	{
		return string.Concat(object_0);
	}

	internal static void smethod_630(string string_0, string string_1)
	{
		File.Copy(string_0, string_1);
	}

	internal static object smethod_631(Type type_0, object[] object_0)
	{
		return Activator.CreateInstance(type_0, object_0);
	}

	internal static Exception smethod_632(string string_0)
	{
		return new Exception(string_0);
	}

	internal static FileVersionInfo smethod_633(string string_0)
	{
		return FileVersionInfo.GetVersionInfo(string_0);
	}

	internal static string smethod_634(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.CompanyName;
	}

	internal static CheckBox smethod_635()
	{
		return new CheckBox();
	}

	internal static bool smethod_636(CheckBox checkBox_0)
	{
		return checkBox_0.Checked;
	}

	internal static bool smethod_637(string string_0, string string_1, StringComparison stringComparison_0)
	{
		return string_0.StartsWith(string_1, stringComparison_0);
	}

	internal static Process smethod_638(string string_0)
	{
		return Process.Start(string_0);
	}

	internal static bool smethod_639(Type type_0, Type type_1)
	{
		return type_0.IsSubclassOf(type_1);
	}

	internal static ArgumentOutOfRangeException smethod_640()
	{
		return new ArgumentOutOfRangeException();
	}

	internal static void smethod_641(ListControl listControl_0, int int_0)
	{
		listControl_0.SelectedIndex = int_0;
	}

	internal static void smethod_642(Control control_0, Color color_0)
	{
		control_0.BackColor = color_0;
	}

	internal static void smethod_643(NumericUpDown numericUpDown_0, decimal decimal_0)
	{
		numericUpDown_0.Value = decimal_0;
	}

	internal static string smethod_644(string string_0)
	{
		return Environment.GetEnvironmentVariable(string_0);
	}

	internal static WindowsIdentity smethod_645()
	{
		return WindowsIdentity.GetCurrent();
	}

	internal static WindowsPrincipal smethod_646(WindowsIdentity windowsIdentity_0)
	{
		return new WindowsPrincipal(windowsIdentity_0);
	}

	internal static bool smethod_647(WindowsPrincipal windowsPrincipal_0, WindowsBuiltInRole windowsBuiltInRole_0)
	{
		return windowsPrincipal_0.IsInRole(windowsBuiltInRole_0);
	}

	internal static int smethod_648(string string_0)
	{
		return string_0.Length;
	}

	internal static char smethod_649(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	internal static DynamicMethod smethod_650(string string_0, Type type_0, Type[] type_1, Type type_2)
	{
		return new DynamicMethod(string_0, type_0, type_1, type_2);
	}

	internal static ILGenerator smethod_651(DynamicMethod dynamicMethod_0)
	{
		return dynamicMethod_0.GetILGenerator();
	}

	internal static void smethod_652(ILGenerator ilgenerator_0, OpCode opCode_0, byte byte_0)
	{
		ilgenerator_0.Emit(opCode_0, byte_0);
	}

	internal static Delegate smethod_653(DynamicMethod dynamicMethod_0, Type type_0)
	{
		return dynamicMethod_0.CreateDelegate(type_0);
	}

	internal static void smethod_654(Random random_0, byte[] byte_0)
	{
		random_0.NextBytes(byte_0);
	}

	internal static void smethod_655(Control control_0, Color color_0)
	{
		control_0.ForeColor = color_0;
	}

	internal static short smethod_656(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadInt16();
	}

	internal static int smethod_657(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadInt32();
	}

	internal static SHA512 smethod_658()
	{
		return SHA512.Create();
	}

	internal static int smethod_659(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1, byte[] byte_1, int int_2)
	{
		return hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_1, int_2);
	}

	internal static byte[] smethod_660(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		return hashAlgorithm_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	internal static byte[] smethod_661(HashAlgorithm hashAlgorithm_0)
	{
		return hashAlgorithm_0.Hash;
	}

	internal static NumericUpDown smethod_662()
	{
		return new NumericUpDown();
	}

	internal static Panel smethod_663()
	{
		return new Panel();
	}

	internal static ColorDialog smethod_664()
	{
		return new ColorDialog();
	}

	internal static FileStream smethod_665(string string_0)
	{
		return File.OpenWrite(string_0);
	}

	internal static PictureBox smethod_666()
	{
		return new PictureBox();
	}

	internal static LinkLabel smethod_667()
	{
		return new LinkLabel();
	}

	internal static void smethod_668(Panel panel_0, BorderStyle borderStyle_0)
	{
		panel_0.BorderStyle = borderStyle_0;
	}

	internal static string smethod_669(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	internal static Encoding smethod_670()
	{
		return Encoding.UTF8;
	}

	internal static string smethod_671(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	internal static char[] smethod_672(string string_0)
	{
		return string_0.ToCharArray();
	}

	internal static string smethod_673(char[] char_0)
	{
		return new string(char_0);
	}

	internal static void smethod_674(string string_0, string string_1, bool bool_0)
	{
		File.Copy(string_0, string_1, bool_0);
	}

	internal static AppDomain smethod_675()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void smethod_676(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0)
	{
		appDomain_0.AssemblyResolve += resolveEventHandler_0;
	}

	internal static int smethod_677(ListControl listControl_0)
	{
		return listControl_0.SelectedIndex;
	}

	internal static Color smethod_678(Control control_0)
	{
		return control_0.BackColor;
	}

	internal static decimal smethod_679(NumericUpDown numericUpDown_0)
	{
		return numericUpDown_0.Value;
	}

	internal static DataGridViewImageColumn smethod_680()
	{
		return new DataGridViewImageColumn();
	}

	internal static void smethod_681(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.AllowUserToAddRows = bool_0;
	}

	internal static void smethod_682(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.AllowUserToDeleteRows = bool_0;
	}

	internal static void smethod_683(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.AllowUserToResizeColumns = bool_0;
	}

	internal static void smethod_684(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.AllowUserToResizeRows = bool_0;
	}

	internal static void smethod_685(DataGridView dataGridView_0, Color color_0)
	{
		dataGridView_0.BackgroundColor = color_0;
	}

	internal static void smethod_686(DataGridView dataGridView_0, DataGridViewCellBorderStyle dataGridViewCellBorderStyle_0)
	{
		dataGridView_0.CellBorderStyle = dataGridViewCellBorderStyle_0;
	}

	internal static void smethod_687(DataGridView dataGridView_0, DataGridViewColumnHeadersHeightSizeMode dataGridViewColumnHeadersHeightSizeMode_0)
	{
		dataGridView_0.ColumnHeadersHeightSizeMode = dataGridViewColumnHeadersHeightSizeMode_0;
	}

	internal static void smethod_688(DataGridView dataGridView_0, bool bool_0)
	{
		dataGridView_0.ColumnHeadersVisible = bool_0;
	}

	internal static DataGridViewColumnCollection smethod_689(DataGridView dataGridView_0)
	{
		return dataGridView_0.Columns;
	}

	internal static void smethod_690(DataGridViewColumnCollection dataGridViewColumnCollection_0, DataGridViewColumn[] dataGridViewColumn_0)
	{
		dataGridViewColumnCollection_0.AddRange(dataGridViewColumn_0);
	}

	internal static void smethod_691(DataGridView dataGridView_0, DataGridViewEditMode dataGridViewEditMode_0)
	{
		dataGridView_0.EditMode = dataGridViewEditMode_0;
	}

	internal static CookieCollection smethod_692(HttpWebResponse httpWebResponse_0)
	{
		return httpWebResponse_0.Cookies;
	}

	internal static void smethod_693(CookieContainer cookieContainer_0, CookieCollection cookieCollection_0)
	{
		cookieContainer_0.Add(cookieCollection_0);
	}

	internal static ComboBox.ObjectCollection smethod_694(ComboBox comboBox_0)
	{
		return comboBox_0.Items;
	}

	internal static object smethod_695(ComboBox.ObjectCollection objectCollection_0, int int_0)
	{
		return objectCollection_0[int_0];
	}

	internal static Type smethod_696(Exception exception_0)
	{
		return exception_0.GetType();
	}

	internal static string smethod_697(Type type_0)
	{
		return type_0.FullName;
	}

	internal static string smethod_698(string string_0, string string_1, string string_2, string string_3)
	{
		return string_0 + string_1 + string_2 + string_3;
	}

	internal static Exception smethod_699(Exception exception_0)
	{
		return exception_0.InnerException;
	}

	internal static string smethod_700(string string_0)
	{
		return Path.GetFullPath(string_0);
	}

	internal static IEnumerator smethod_701(IEnumerable ienumerable_0)
	{
		return ienumerable_0.GetEnumerator();
	}

	internal static object smethod_702(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	internal static Exception smethod_703()
	{
		return new Exception();
	}

	internal static void smethod_704(DataGridViewCell dataGridViewCell_0, string string_0)
	{
		dataGridViewCell_0.ToolTipText = string_0;
	}

	internal static void smethod_705(Form form_0)
	{
		form_0.Close();
	}

	internal static DialogResult smethod_706(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
	{
		return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
	}

	internal static void smethod_707(System.Windows.Forms.Timer timer_0)
	{
		timer_0.Start();
	}

	internal static byte[] smethod_708(string string_0)
	{
		return Convert.FromBase64String(string_0);
	}

	internal static void smethod_709(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		stream_0.Write(byte_0, int_0, int_1);
	}

	internal static Type smethod_710(object object_0)
	{
		return object_0.GetType();
	}

	internal static OperatingSystem smethod_711()
	{
		return Environment.OSVersion;
	}

	internal static PlatformID smethod_712(OperatingSystem operatingSystem_0)
	{
		return operatingSystem_0.Platform;
	}

	internal static IEnumerable<int> smethod_713(int int_0, int int_1)
	{
		return Enumerable.Range(int_0, int_1);
	}

	internal static Image smethod_714(Control control_0)
	{
		return control_0.BackgroundImage;
	}

	internal static void smethod_715(Control control_0, Image image_0)
	{
		control_0.BackgroundImage = image_0;
	}

	internal static void smethod_716(Image image_0)
	{
		image_0.Dispose();
	}

	internal static void smethod_717(Control control_0)
	{
		control_0.ResetText();
	}

	internal static Cursor smethod_718()
	{
		return Cursors.Default;
	}

	internal static void smethod_719(Control control_0, Cursor cursor_0)
	{
		control_0.Cursor = cursor_0;
	}

	internal static Cursor smethod_720()
	{
		return Cursors.Hand;
	}

	internal static string smethod_721(FileVersionInfo fileVersionInfo_0)
	{
		return fileVersionInfo_0.FileDescription;
	}

	internal static string smethod_722(Control control_0)
	{
		return control_0.Text;
	}

	internal static Container smethod_723()
	{
		return new Container();
	}

	internal static DataGridViewCellStyle smethod_724()
	{
		return new DataGridViewCellStyle();
	}

	internal static System.Windows.Forms.Timer smethod_725(IContainer icontainer_0)
	{
		return new System.Windows.Forms.Timer(icontainer_0);
	}

	internal static DataGridViewCheckBoxColumn smethod_726()
	{
		return new DataGridViewCheckBoxColumn();
	}

	internal static DataGridViewButtonColumn smethod_727()
	{
		return new DataGridViewButtonColumn();
	}

	internal static Assembly smethod_728()
	{
		return Assembly.GetCallingAssembly();
	}

	internal static FormatException smethod_729(string string_0)
	{
		return new FormatException(string_0);
	}

	internal static int smethod_730(Stream stream_0, byte[] byte_0, int int_0, int int_1)
	{
		return stream_0.Read(byte_0, int_0, int_1);
	}

	internal static byte[] smethod_731(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		return icryptoTransform_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	internal static void smethod_732(Stream stream_0)
	{
		stream_0.Close();
	}

	internal static TabControl smethod_733()
	{
		return new TabControl();
	}

	internal static TabPage smethod_734()
	{
		return new TabPage();
	}

	internal static void smethod_735(Control control_0, AnchorStyles anchorStyles_0)
	{
		control_0.Anchor = anchorStyles_0;
	}

	internal static Win32Exception smethod_736(string string_0)
	{
		return new Win32Exception(string_0);
	}

	internal static string smethod_737(ResolveEventArgs resolveEventArgs_0)
	{
		return resolveEventArgs_0.Name;
	}

	internal static string[] smethod_738(string string_0, char[] char_0)
	{
		return string_0.Split(char_0);
	}

	internal static int smethod_739(string string_0, char char_0)
	{
		return string_0.IndexOf(char_0);
	}

	internal static Stream smethod_740(Assembly assembly_0, string string_0)
	{
		return assembly_0.GetManifestResourceStream(string_0);
	}

	internal static Assembly smethod_741(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	internal static DirectoryInfo smethod_742(string string_0)
	{
		return Directory.CreateDirectory(string_0);
	}

	internal static Assembly smethod_743(string string_0)
	{
		return Assembly.LoadFile(string_0);
	}

	internal static int smethod_744(ComboBox.ObjectCollection objectCollection_0)
	{
		return objectCollection_0.Count;
	}

	internal static byte[] smethod_745(float float_0)
	{
		return BitConverter.GetBytes(float_0);
	}

	internal static AccessViolationException smethod_746(string string_0, Exception exception_0)
	{
		return new AccessViolationException(string_0, exception_0);
	}

	internal static bool smethod_747(string string_0, string string_1)
	{
		return string_0.Contains(string_1);
	}

	internal static RijndaelManaged smethod_748()
	{
		return new RijndaelManaged();
	}

	internal static int smethod_749(Stream stream_0)
	{
		return stream_0.ReadByte();
	}

	internal static bool smethod_750(string string_0)
	{
		return Path.IsPathRooted(string_0);
	}

	internal static RegistryKey smethod_751(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.OpenSubKey(string_0);
	}

	internal static string[] smethod_752(RegistryKey registryKey_0)
	{
		return registryKey_0.GetValueNames();
	}

	internal static object smethod_753(RegistryKey registryKey_0, string string_0)
	{
		return registryKey_0.GetValue(string_0);
	}

	internal static void smethod_754(RegistryKey registryKey_0)
	{
		registryKey_0.Close();
	}

	internal static string smethod_755()
	{
		return Environment.CurrentDirectory;
	}

	internal static ArgumentException smethod_756(string string_0, string string_1)
	{
		return new ArgumentException(string_0, string_1);
	}

	internal static byte[] smethod_757(double double_0)
	{
		return BitConverter.GetBytes(double_0);
	}

	internal static long smethod_758(byte[] byte_0, int int_0)
	{
		return BitConverter.ToInt64(byte_0, int_0);
	}
}
