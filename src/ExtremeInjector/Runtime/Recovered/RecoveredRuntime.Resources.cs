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
					num5 = DynamicIlEmitter.random_0.Next(5);
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
					num6 = DynamicIlEmitter.random_0.Next(2, 20);
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
					num6 = DynamicIlEmitter.random_0.Next(2, 20);
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
					type = DynamicIlEmitter.type_0[DynamicIlEmitter.random_0.Next(DynamicIlEmitter.type_0.Length)];
					num = ((type == typeof(void)) ? 115753001 : 634291345);
					continue;
				case 5u:
					type2 = DynamicIlEmitter.type_0[DynamicIlEmitter.random_0.Next(DynamicIlEmitter.type_0.Length)];
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

	internal static string smethod_90(int int_0, ResourceDirectory class166_0)
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

	internal static ResourceManager smethod_124()
	{
		if (EmbeddedResources.resourceManager_0 == null)
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
						EmbeddedResources.resourceManager_0 = new ResourceManager("\u0002.\u0005", typeof(EmbeddedResources).Assembly);
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
		return EmbeddedResources.resourceManager_0;
	}

	internal static void smethod_192()
	{
		try
		{
			ResourceAssemblyResolver.smethod_0();
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
			CookieAwareWebClient @class = new CookieAwareWebClient();
			try
			{
				string_0 = @class.DownloadString("https://raw.githubusercontent.com/Caritusy/ExtremeInjectorEx/main/version").Trim();
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

	internal static bool smethod_209(Assembly assembly_0, Assembly assembly_1)
	{
		return true;
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

	internal static byte[] smethod_394(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		int num15 = default(int);
		byte[] array = default(byte[]);
		int num10 = default(int);
		DeflateDecoder.Class180 class180_ = default(DeflateDecoder.Class180);
		int num17 = default(int);
		DeflateDecoder.Stream1 stream = default(DeflateDecoder.Stream1);
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
					DeflateDecoder.Class180 class180_2 = new DeflateDecoder.Class180(array3);
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
					stream = new DeflateDecoder.Stream1(byte_0);
					array = new byte[0];
					num15 = smethod_44(stream);
					num = ((num15 != 67324752) ? 233147962 : 150849871);
					continue;
				case 17u:
					class180_ = new DeflateDecoder.Class180(array2);
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

	internal static Assembly smethod_416(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		EmbeddedAssemblyResolver.Struct79 @struct = new EmbeddedAssemblyResolver.Struct79(resolveEventArgs_0.Name);
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
						lock (EmbeddedAssemblyResolver.dictionary_0)
						{
							if (EmbeddedAssemblyResolver.dictionary_0.ContainsKey(text))
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
									result = EmbeddedAssemblyResolver.dictionary_0[text];
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
									EmbeddedAssemblyResolver.dictionary_0[text] = assembly;
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

	internal static string smethod_555(Encoding encoding_0, byte[] byte_0)
	{
		return encoding_0.GetString(byte_0);
	}

	internal static object smethod_556(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0)
	{
		return resourceManager_0.GetObject(string_0, cultureInfo_0);
	}

	internal static ComponentResourceManager smethod_572(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	internal static ResourceManager smethod_582(string string_0, Assembly assembly_0)
	{
		return new ResourceManager(string_0, assembly_0);
	}

	internal static Assembly smethod_610()
	{
		return Assembly.GetExecutingAssembly();
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

	internal static SHA512 smethod_658()
	{
		return SHA512.Create();
	}

	internal static string smethod_669(Assembly assembly_0)
	{
		return assembly_0.Location;
	}

	internal static void smethod_676(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0)
	{
		appDomain_0.AssemblyResolve += resolveEventHandler_0;
	}

	internal static Assembly smethod_728()
	{
		return Assembly.GetCallingAssembly();
	}

	internal static byte[] smethod_731(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		return icryptoTransform_0.TransformFinalBlock(byte_0, int_0, int_1);
	}

	internal static string smethod_737(ResolveEventArgs resolveEventArgs_0)
	{
		return resolveEventArgs_0.Name;
	}

	internal static Stream smethod_740(Assembly assembly_0, string string_0)
	{
		return assembly_0.GetManifestResourceStream(string_0);
	}

	internal static Assembly smethod_741(byte[] byte_0)
	{
		return Assembly.Load(byte_0);
	}

	internal static Assembly smethod_743(string string_0)
	{
		return Assembly.LoadFile(string_0);
	}

	internal static RijndaelManaged smethod_748()
	{
		return new RijndaelManaged();
	}
}
