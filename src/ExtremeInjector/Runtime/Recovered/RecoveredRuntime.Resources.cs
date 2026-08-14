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

	internal static TypeBuilder DefineDecoyType(ModuleBuilder moduleBuilder)
	{
		TypeBuilder typeBuilder = moduleBuilder.DefineType(RecoveredRuntime.GenerateRandomIdentifier() + EncodedStringTable.DecodeString(952) + RecoveredRuntime.GenerateRandomIdentifier(), TypeAttributes.NotPublic);
		int num = DynamicIlEmitter.random.Next(2, 20);
		for (int i = 0; i < num; i++)
		{
			Type type = DynamicIlEmitter.typeArray[DynamicIlEmitter.random.Next(DynamicIlEmitter.typeArray.Length)];
			ILGenerator ilgenerator = typeBuilder.DefineMethod(RecoveredRuntime.GenerateRandomIdentifier(), MethodAttributes.Private | MethodAttributes.FamANDAssem | MethodAttributes.Static, type, new Type[0]).GetILGenerator();
			if (type != typeof(void))
			{
				LocalBuilder local = ilgenerator.DeclareLocal(type);
				ilgenerator.Emit(OpCodes.Ldloca_S, local);
				ilgenerator.Emit(OpCodes.Initobj, type);
				ilgenerator.Emit(OpCodes.Ldloc_0);
			}
			int num2 = DynamicIlEmitter.random.Next(5);
			for (int j = 0; j < num2; j++)
			{
				ilgenerator.Emit(OpCodes.Nop);
			}
			ilgenerator.Emit(OpCodes.Ret);
		}
		num = DynamicIlEmitter.random.Next(2, 20);
		for (int k = 0; k < num; k++)
		{
			Type type2 = DynamicIlEmitter.typeArray[DynamicIlEmitter.random.Next(DynamicIlEmitter.typeArray.Length)];
			if (!(type2 == typeof(void)))
			{
				typeBuilder.DefineField(RecoveredRuntime.GenerateRandomIdentifier(), type2, FieldAttributes.Private | FieldAttributes.FamANDAssem | FieldAttributes.Static);
			}
			else
			{
				k--;
			}
		}
		return typeBuilder;
	}

	internal static string ReadResourceDirectoryString(int intValue, ResourceDirectory resourceDirectory)
	{
		if (!RecoveredRuntime.SeekResourceOffset(resourceDirectory, (long)intValue))
		{
			return null;
		}
		if (!RecoveredRuntime.IsCurrentResourceRangeValid(resourceDirectory, 2))
		{
			return null;
		}
		int int_ = (int)(RecoveredRuntime.ReadResourceUInt16(resourceDirectory) * 2);
		if (RecoveredRuntime.IsCurrentResourceRangeValid(resourceDirectory, int_))
		{
			byte[] bytes = RecoveredRuntime.ReadResourceBytes(resourceDirectory, int_);
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

	internal static ResourceManager GetEmbeddedResourceManager()
	{
		if (EmbeddedResources.resourceManager == null)
		{
			EmbeddedResources.resourceManager = new ResourceManager(EncodedStringTable.DecodeString(13190), typeof(EmbeddedResources).Assembly);
		}
		return EmbeddedResources.resourceManager;
	}

	internal static void InitializeResourceResolver()
	{
		try
		{
			ResourceAssemblyResolver.Initialize();
		}
		catch (Exception)
		{
		}
	}

	internal static bool TryCheckForUpdate(out string text2)
	{
		text2 = null;
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
					text2 = @class.DownloadString(EncodedStringTable.DecodeString(13589));
					Version version = Assembly.GetExecutingAssembly().GetName().Version;
					string text = string.Format(EncodedStringTable.DecodeString(13690), version.Major, version.Minor);
					if (version.Build != 0)
					{
						text = text + EncodedStringTable.DecodeString(952) + version.Build;
					}
					result = (text2 != text);
				}
			}
		}
		catch
		{
			result = false;
		}
		return result;
	}

	internal static ICryptoTransform CreateDesTransform(bool flag, byte[] bytes, byte[] bytes2)
	{
		ICryptoTransform result;
		using (DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider())
		{
			result = ((!flag) ? descryptoServiceProvider.CreateEncryptor(bytes2, bytes) : descryptoServiceProvider.CreateDecryptor(bytes2, bytes));
		}
		return result;
	}

	internal static void WriteIntegrityChecksum(string filePath)
	{
		using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read))
		using (BinaryReader binaryReader = new BinaryReader(fileStream))
		using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
		{
			fileStream.Position = 0L;
			if (binaryReader.ReadInt16() != 23117)
			{
				return;
			}

			fileStream.Position = 60L;
			fileStream.Position = binaryReader.ReadInt32();
			if (binaryReader.ReadInt32() != 17744)
			{
				return;
			}

			fileStream.Position += 20L;
			short optionalHeaderMagic = binaryReader.ReadInt16();
			fileStream.Position += optionalHeaderMagic == 267 ? 86L : 102L;
			long checksumPosition = fileStream.Position;
			fileStream.Position = 0L;
			using (SHA512 sha = SHA512.Create())
			{
				byte[] block = binaryReader.ReadBytes((int)checksumPosition);
				sha.TransformBlock(block, 0, block.Length, block, 0);
				fileStream.Position += 4L;
				while (fileStream.Length - fileStream.Position >= 1024L)
				{
					block = binaryReader.ReadBytes(1024);
					sha.TransformBlock(block, 0, block.Length, block, 0);
				}

				byte[] finalBlock = binaryReader.ReadBytes((int)(fileStream.Length - fileStream.Position));
				sha.TransformFinalBlock(finalBlock, 0, finalBlock.Length);
				int checksum = 0;
				for (int i = 0; i < sha.Hash.Length; i += sizeof(int))
				{
					checksum += BitConverter.ToInt32(sha.Hash, i);
				}

				fileStream.Position = checksumPosition;
				binaryWriter.Write(checksum);
			}
		}
	}

	internal static void InitializeEmbeddedAssemblyResolver()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += ResolveEmbeddedAssembly;
		}
		catch
		{
		}
	}

	internal static byte[] DecompressEmbeddedData(byte[] bytes)
	{
		DeflateDecoder.ReadOnlyMemoryStream stream = new DeflateDecoder.ReadOnlyMemoryStream(bytes);
		byte[] array = new byte[0];
		int num = RecoveredRuntime.ReadDeflateInt32(stream);
		if (num == 67324752)
		{
			short num2 = (short)RecoveredRuntime.ReadUInt16LittleEndian(stream);
			int num3 = RecoveredRuntime.ReadUInt16LittleEndian(stream);
			int num4 = RecoveredRuntime.ReadUInt16LittleEndian(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException(_003CModule_003E.DecodeConstantWithKeyD<string>(1515669233u));
			}
			RecoveredRuntime.ReadDeflateInt32(stream);
			RecoveredRuntime.ReadDeflateInt32(stream);
			RecoveredRuntime.ReadDeflateInt32(stream);
			int num5 = RecoveredRuntime.ReadDeflateInt32(stream);
			int num6 = RecoveredRuntime.ReadUInt16LittleEndian(stream);
			int num7 = RecoveredRuntime.ReadUInt16LittleEndian(stream);
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
			DeflateDecoder.Inflater class180_ = new DeflateDecoder.Inflater(array2);
			array = new byte[num5];
			RecoveredRuntime.InflateBytes(array, 0, array.Length, class180_);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException(_003CModule_003E.DecodeConstantWithKeyE<string>(652446713u));
			}
			if (num8 == 1)
			{
				int num9 = RecoveredRuntime.ReadDeflateInt32(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = RecoveredRuntime.ReadDeflateInt32(stream);
					num11 = RecoveredRuntime.ReadDeflateInt32(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					DeflateDecoder.Inflater inflater = new DeflateDecoder.Inflater(array3);
					RecoveredRuntime.InflateBytes(array, i, num11, inflater);
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
				byte[] bytes2 = new byte[]
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
				using (ICryptoTransform cryptoTransform = RecoveredRuntime.CreateDesTransform(true, bytes2, byte_))
				{
					byte[] bytes3 = cryptoTransform.TransformFinalBlock(bytes, 4, bytes.Length - 4);
					array = RecoveredRuntime.DecompressEmbeddedData(bytes3);
				}
			}
			if (num8 == 3)
			{
				byte[] bytes4 = new byte[]
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
				byte[] bytes5 = new byte[]
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
				using (ICryptoTransform cryptoTransform2 = RecoveredRuntime.CreateRijndaelTransform(true, bytes4, bytes5))
				{
					byte[] bytes6 = cryptoTransform2.TransformFinalBlock(bytes, 4, bytes.Length - 4);
					array = RecoveredRuntime.DecompressEmbeddedData(bytes6);
				}
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	internal static Assembly ResolveEmbeddedAssembly(object instance, ResolveEventArgs resolveEventArgs)
	{
		EmbeddedAssemblyResolver.AssemblyIdentity @struct = new EmbeddedAssemblyResolver.AssemblyIdentity(resolveEventArgs.Name);
		string s = @struct.ToDisplayName(false);
		string b = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = _003CModule_003E.DecodeConstantWithKeyC<string>(3764124672u).Split(new char[]
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
		if (text.Length == 0 && @struct.publicKeyToken.Length == 0)
		{
			b = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.name));
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
			lock (EmbeddedAssemblyResolver.dictionary)
			{
				if (EmbeddedAssemblyResolver.dictionary.ContainsKey(text))
				{
					return EmbeddedAssemblyResolver.dictionary[text];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = RecoveredRuntime.DecompressEmbeddedData(array2);
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
							string text3 = string.Format(_003CModule_003E.DecodeConstantWithKeyB<string>(875068114u), Path.GetTempPath(), text);
							Directory.CreateDirectory(text3);
							string text4 = text3 + @struct.name + _003CModule_003E.DecodeConstantWithKeyB<string>(4162067015u);
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
					EmbeddedAssemblyResolver.dictionary[text] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	internal static ICryptoTransform CreateRijndaelTransform(bool flag, byte[] bytes, byte[] bytes2)
	{
		ICryptoTransform result;
		using (SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged())
		{
			result = (flag ? symmetricAlgorithm.CreateDecryptor(bytes, bytes2) : symmetricAlgorithm.CreateEncryptor(bytes, bytes2));
		}
		return result;
	}

}
