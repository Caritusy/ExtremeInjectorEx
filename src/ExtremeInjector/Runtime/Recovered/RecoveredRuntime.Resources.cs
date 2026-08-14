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
		TypeBuilder typeBuilder = moduleBuilder_0.DefineType(RecoveredRuntime.smethod_426() + EncodedStringTable.smethod_0(952) + RecoveredRuntime.smethod_426(), TypeAttributes.NotPublic);
		int num = DynamicIlEmitter.random_0.Next(2, 20);
		for (int i = 0; i < num; i++)
		{
			Type type = DynamicIlEmitter.type_0[DynamicIlEmitter.random_0.Next(DynamicIlEmitter.type_0.Length)];
			ILGenerator ilgenerator = typeBuilder.DefineMethod(RecoveredRuntime.smethod_426(), MethodAttributes.Private | MethodAttributes.FamANDAssem | MethodAttributes.Static, type, new Type[0]).GetILGenerator();
			if (type != typeof(void))
			{
				LocalBuilder local = ilgenerator.DeclareLocal(type);
				ilgenerator.Emit(OpCodes.Ldloca_S, local);
				ilgenerator.Emit(OpCodes.Initobj, type);
				ilgenerator.Emit(OpCodes.Ldloc_0);
			}
			int num2 = DynamicIlEmitter.random_0.Next(5);
			for (int j = 0; j < num2; j++)
			{
				ilgenerator.Emit(OpCodes.Nop);
			}
			ilgenerator.Emit(OpCodes.Ret);
		}
		num = DynamicIlEmitter.random_0.Next(2, 20);
		for (int k = 0; k < num; k++)
		{
			Type type2 = DynamicIlEmitter.type_0[DynamicIlEmitter.random_0.Next(DynamicIlEmitter.type_0.Length)];
			if (!(type2 == typeof(void)))
			{
				typeBuilder.DefineField(RecoveredRuntime.smethod_426(), type2, FieldAttributes.Private | FieldAttributes.FamANDAssem | FieldAttributes.Static);
			}
			else
			{
				k--;
			}
		}
		return typeBuilder;
	}

	internal static string smethod_90(int int_0, ResourceDirectory class166_0)
	{
		if (!RecoveredRuntime.smethod_262(class166_0, (long)int_0))
		{
			return null;
		}
		if (!RecoveredRuntime.smethod_176(class166_0, 2))
		{
			return null;
		}
		int int_ = (int)(RecoveredRuntime.smethod_370(class166_0) * 2);
		if (RecoveredRuntime.smethod_176(class166_0, int_))
		{
			byte[] bytes = RecoveredRuntime.smethod_144(class166_0, int_);
			string result;
			try
			{
				result = Encoding.Unicode.GetString(bytes);
			}
			catch
			{
				result = null;
			}
			return result;
		}
		return null;
	}

	internal static ResourceManager smethod_124()
	{
		if (EmbeddedResources.resourceManager_0 == null)
		{
			EmbeddedResources.resourceManager_0 = new ResourceManager(EncodedStringTable.smethod_0(13190), typeof(EmbeddedResources).Assembly);
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
		bool result;
		try
		{
			if (!NetworkInterface.GetIsNetworkAvailable())
			{
				result = false;
			}
			else
			{
				using (CookieAwareWebClient @class = new CookieAwareWebClient())
				{
					string_0 = @class.DownloadString(EncodedStringTable.smethod_0(13589));
					Version version = Assembly.GetExecutingAssembly().GetName().Version;
					string text = string.Format(EncodedStringTable.smethod_0(13690), version.Major, version.Minor);
					if (version.Build != 0)
					{
						text = text + EncodedStringTable.smethod_0(952) + version.Build;
					}
					result = (string_0 != text);
				}
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	internal static ICryptoTransform smethod_198(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		ICryptoTransform result;
		using (DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider())
		{
			result = ((!bool_0) ? descryptoServiceProvider.CreateEncryptor(byte_1, byte_0) : descryptoServiceProvider.CreateDecryptor(byte_1, byte_0));
		}
		return result;
	}

	internal static bool smethod_209(Assembly assembly_0, Assembly assembly_1)
	{
		return true;
	}

	internal static void smethod_291(string string_0)
	{
		using (FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
		{
			using (BinaryReader binaryReader = new BinaryReader(fileStream))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
				{
					fileStream.Position = 0L;
					if (binaryReader.ReadInt16() == 23117)
					{
						fileStream.Position = 60L;
						fileStream.Position = (long)binaryReader.ReadInt32();
						if (binaryReader.ReadInt32() == 17744)
						{
							fileStream.Position += 20L;
							short num = binaryReader.ReadInt16();
							fileStream.Position += ((num == 267) ? 86L : 102L);
							long position = fileStream.Position;
							fileStream.Position = 0L;
							SHA512 sha = SHA512.Create();
							byte[] array = binaryReader.ReadBytes((int)position);
							sha.TransformBlock(array, 0, array.Length, array, 0);
							fileStream.Position += 4L;
							while (fileStream.Length - fileStream.Position >= 1024L)
							{
								array = binaryReader.ReadBytes(1024);
								sha.TransformBlock(array, 0, 1024, array, 0);
							}
							byte[] array2 = binaryReader.ReadBytes((int)(fileStream.Length - fileStream.Position));
							sha.TransformFinalBlock(array2, 0, array2.Length);
							int num2 = 0;
							for (int i = 0; i < sha.Hash.Length; i += 4)
							{
								num2 += BitConverter.ToInt32(sha.Hash, i);
							}
							fileStream.Position = position;
							binaryWriter.Write(num2);
						}
					}
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
		ExternalSettingsLoader.LoadLegacyArgument(string_0);
	}

	internal static byte[] smethod_394(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (callingAssembly != executingAssembly)
		{
		}
		DeflateDecoder.Stream1 stream = new DeflateDecoder.Stream1(byte_0);
		byte[] array = new byte[0];
		int num = RecoveredRuntime.smethod_44(stream);
		if (num == 67324752)
		{
			short num2 = (short)RecoveredRuntime.smethod_438(stream);
			int num3 = RecoveredRuntime.smethod_438(stream);
			int num4 = RecoveredRuntime.smethod_438(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException(_003CModule_003E.smethod_5<string>(1515669233u));
			}
			RecoveredRuntime.smethod_44(stream);
			RecoveredRuntime.smethod_44(stream);
			RecoveredRuntime.smethod_44(stream);
			int num5 = RecoveredRuntime.smethod_44(stream);
			int num6 = RecoveredRuntime.smethod_438(stream);
			int num7 = RecoveredRuntime.smethod_438(stream);
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				stream.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				stream.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			DeflateDecoder.Class180 class180_ = new DeflateDecoder.Class180(array2);
			array = new byte[num5];
			RecoveredRuntime.smethod_130(array, 0, array.Length, class180_);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException(_003CModule_003E.smethod_6<string>(652446713u));
			}
			if (num8 == 1)
			{
				int num9 = RecoveredRuntime.smethod_44(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = RecoveredRuntime.smethod_44(stream);
					num11 = RecoveredRuntime.smethod_44(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					DeflateDecoder.Class180 class180_2 = new DeflateDecoder.Class180(array3);
					RecoveredRuntime.smethod_130(array, i, num11, class180_2);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[]
				{
					245,
					35,
					118,
					82,
					159,
					2,
					179,
					67
				};
				byte[] byte_2 = new byte[]
				{
					149,
					124,
					101,
					201,
					198,
					183,
					16,
					200
				};
				using (ICryptoTransform cryptoTransform = RecoveredRuntime.smethod_198(true, byte_2, byte_))
				{
					byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
					array = RecoveredRuntime.smethod_394(byte_3);
				}
			}
			if (num8 == 3)
			{
				byte[] byte_4 = new byte[]
				{
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1,
					1
				};
				byte[] byte_5 = new byte[]
				{
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2,
					2
				};
				using (ICryptoTransform cryptoTransform2 = RecoveredRuntime.smethod_435(true, byte_4, byte_5))
				{
					byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
					array = RecoveredRuntime.smethod_394(byte_6);
				}
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	internal static Assembly smethod_416(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		EmbeddedAssemblyResolver.Struct79 @struct = new EmbeddedAssemblyResolver.Struct79(resolveEventArgs_0.Name);
		string s = @struct.method_0(false);
		string b = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = _003CModule_003E.smethod_4<string>(3764124672u).Split(new char[]
		{
			','
		});
		string text = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == b)
			{
				text = array[i + 1];
				break;
			}
		}
		if (text.Length == 0 && @struct.string_2.Length == 0)
		{
			b = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == b)
				{
					text = array[j + 1];
					break;
				}
			}
		}
		if (text.Length > 0)
		{
			if (text[0] == '[')
			{
				int num = text.IndexOf(']');
				string text2 = text.Substring(1, num - 1);
				flag = (text2.IndexOf('z') >= 0);
				flag2 = (text2.IndexOf('t') >= 0);
				text = text.Substring(num + 1);
			}
			lock (EmbeddedAssemblyResolver.dictionary_0)
			{
				if (EmbeddedAssemblyResolver.dictionary_0.ContainsKey(text))
				{
					return EmbeddedAssemblyResolver.dictionary_0[text];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = RecoveredRuntime.smethod_394(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text3 = string.Format(_003CModule_003E.smethod_3<string>(875068114u), Path.GetTempPath(), text);
							Directory.CreateDirectory(text3);
							string text4 = text3 + @struct.string_0 + _003CModule_003E.smethod_3<string>(4162067015u);
							if (!File.Exists(text4))
							{
								FileStream fileStream = File.OpenWrite(text4);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								RecoveredRuntime.MoveFileEx(text4, null, 4);
								RecoveredRuntime.MoveFileEx(text3, null, 4);
							}
							assembly = Assembly.LoadFile(text4);
						}
						catch
						{
						}
					}
					EmbeddedAssemblyResolver.dictionary_0[text] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	internal static ICryptoTransform smethod_435(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		ICryptoTransform result;
		using (SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged())
		{
			result = (bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_0, byte_1) : symmetricAlgorithm.CreateEncryptor(byte_0, byte_1));
		}
		return result;
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
