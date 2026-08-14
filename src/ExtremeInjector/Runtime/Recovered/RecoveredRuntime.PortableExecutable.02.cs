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

	internal static void CreateDecoyEntryPoint(PeScrambler peScrambler, PeSectionHeader peSectionHeader)
	{
		peSectionHeader.SetCharacteristics((SectionCharacteristics)3758096384u);
		peScrambler.peImage.GetStream().Position = (long)((ulong)peSectionHeader.GetPointerToRawData());
		long position = peScrambler.peImage.GetStream().Position;
		peScrambler.binaryWriter.Write(233);
		peScrambler.binaryWriter.Write(0);
		int num = peScrambler.random.Next((int)(peSectionHeader.GetVirtualSize() / 50u), (int)(peSectionHeader.GetVirtualSize() / 25u));
		byte[] buffer = new byte[num];
		peScrambler.random.NextBytes(buffer);
		peScrambler.binaryWriter.Write(buffer);
		int num2 = -1;
		for (int i = 0; i < peScrambler.random.Next((int)(peSectionHeader.GetVirtualSize() / 10u), (int)(peSectionHeader.GetVirtualSize() / 8u)); i++)
		{
			int num3 = PeScrambler.GenerateDifferentValue<int>(num2, () => peScrambler.random.Next(53));
			while (num2 != -1 && ((num3 >= 15 && num3 <= 30) || (num3 >= 39 && num3 <= 45)) && num2 >= 15 && num2 <= 30)
			{
				num3 = peScrambler.random.Next(53);
			}
			if (num2 >= 39 && num2 <= 45)
			{
				num3 = peScrambler.random.Next(15, 31);
			}
			long position2 = peScrambler.peImage.GetStream().Position;
			switch (num3)
			{
			case 0:
				peScrambler.binaryWriter.Write(144);
				break;
			case 1:
				peScrambler.binaryWriter.Write(184);
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 2:
				peScrambler.binaryWriter.Write(185);
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 3:
				peScrambler.binaryWriter.Write(186);
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 4:
				peScrambler.binaryWriter.Write(187);
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 5:
				peScrambler.binaryWriter.Write(189);
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 6:
				peScrambler.binaryWriter.Write(190);
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 7:
				peScrambler.binaryWriter.Write(191);
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 8:
				peScrambler.binaryWriter.Write(new byte[]
				{
					51,
					192
				});
				break;
			case 9:
				peScrambler.binaryWriter.Write(new byte[]
				{
					51,
					201
				});
				break;
			case 10:
				peScrambler.binaryWriter.Write(new byte[]
				{
					51,
					210
				});
				break;
			case 11:
				peScrambler.binaryWriter.Write(new byte[]
				{
					51,
					219
				});
				break;
			case 12:
				peScrambler.binaryWriter.Write(new byte[]
				{
					51,
					237
				});
				break;
			case 13:
				peScrambler.binaryWriter.Write(new byte[]
				{
					51,
					246
				});
				break;
			case 14:
				peScrambler.binaryWriter.Write(new byte[]
				{
					51,
					byte.MaxValue
				});
				break;
			case 15:
			{
				BinaryWriter binaryWriter_ = peScrambler.binaryWriter;
				byte[] array = new byte[2];
				array[0] = 112;
				binaryWriter_.Write(array);
				break;
			}
			case 16:
			{
				BinaryWriter binaryWriter = peScrambler.binaryWriter;
				byte[] array2 = new byte[2];
				array2[0] = 113;
				binaryWriter.Write(array2);
				break;
			}
			case 17:
			{
				BinaryWriter binaryWriter2 = peScrambler.binaryWriter;
				byte[] array3 = new byte[2];
				array3[0] = 114;
				binaryWriter2.Write(array3);
				break;
			}
			case 18:
			{
				BinaryWriter binaryWriter3 = peScrambler.binaryWriter;
				byte[] array4 = new byte[2];
				array4[0] = 115;
				binaryWriter3.Write(array4);
				break;
			}
			case 19:
			{
				BinaryWriter binaryWriter4 = peScrambler.binaryWriter;
				byte[] array5 = new byte[2];
				array5[0] = 116;
				binaryWriter4.Write(array5);
				break;
			}
			case 20:
			{
				BinaryWriter binaryWriter5 = peScrambler.binaryWriter;
				byte[] array6 = new byte[2];
				array6[0] = 117;
				binaryWriter5.Write(array6);
				break;
			}
			case 21:
			{
				BinaryWriter binaryWriter6 = peScrambler.binaryWriter;
				byte[] array7 = new byte[2];
				array7[0] = 118;
				binaryWriter6.Write(array7);
				break;
			}
			case 22:
			{
				BinaryWriter binaryWriter7 = peScrambler.binaryWriter;
				byte[] array8 = new byte[2];
				array8[0] = 119;
				binaryWriter7.Write(array8);
				break;
			}
			case 23:
			{
				BinaryWriter binaryWriter8 = peScrambler.binaryWriter;
				byte[] array9 = new byte[2];
				array9[0] = 120;
				binaryWriter8.Write(array9);
				break;
			}
			case 24:
			{
				BinaryWriter binaryWriter9 = peScrambler.binaryWriter;
				byte[] array10 = new byte[2];
				array10[0] = 121;
				binaryWriter9.Write(array10);
				break;
			}
			case 25:
			{
				BinaryWriter binaryWriter10 = peScrambler.binaryWriter;
				byte[] array11 = new byte[2];
				array11[0] = 122;
				binaryWriter10.Write(array11);
				break;
			}
			case 26:
			{
				BinaryWriter binaryWriter11 = peScrambler.binaryWriter;
				byte[] array12 = new byte[2];
				array12[0] = 123;
				binaryWriter11.Write(array12);
				break;
			}
			case 27:
			{
				BinaryWriter binaryWriter12 = peScrambler.binaryWriter;
				byte[] array13 = new byte[2];
				array13[0] = 124;
				binaryWriter12.Write(array13);
				break;
			}
			case 28:
			{
				BinaryWriter binaryWriter13 = peScrambler.binaryWriter;
				byte[] array14 = new byte[2];
				array14[0] = 125;
				binaryWriter13.Write(array14);
				break;
			}
			case 29:
			{
				BinaryWriter binaryWriter14 = peScrambler.binaryWriter;
				byte[] array15 = new byte[2];
				array15[0] = 126;
				binaryWriter14.Write(array15);
				break;
			}
			case 30:
			{
				BinaryWriter binaryWriter15 = peScrambler.binaryWriter;
				byte[] array16 = new byte[2];
				array16[0] = 127;
				binaryWriter15.Write(array16);
				break;
			}
			case 31:
				peScrambler.binaryWriter.Write(80);
				peScrambler.binaryWriter.Write(88);
				break;
			case 32:
				peScrambler.binaryWriter.Write(81);
				peScrambler.binaryWriter.Write(89);
				break;
			case 33:
				peScrambler.binaryWriter.Write(82);
				peScrambler.binaryWriter.Write(90);
				break;
			case 34:
				peScrambler.binaryWriter.Write(83);
				peScrambler.binaryWriter.Write(91);
				break;
			case 35:
				peScrambler.binaryWriter.Write(84);
				peScrambler.binaryWriter.Write(92);
				break;
			case 36:
				peScrambler.binaryWriter.Write(85);
				peScrambler.binaryWriter.Write(93);
				break;
			case 37:
				peScrambler.binaryWriter.Write(86);
				peScrambler.binaryWriter.Write(94);
				break;
			case 38:
				peScrambler.binaryWriter.Write(87);
				peScrambler.binaryWriter.Write(95);
				break;
			case 39:
				peScrambler.binaryWriter.Write(new byte[]
				{
					133,
					192
				});
				break;
			case 40:
				peScrambler.binaryWriter.Write(new byte[]
				{
					133,
					201
				});
				break;
			case 41:
				peScrambler.binaryWriter.Write(new byte[]
				{
					133,
					210
				});
				break;
			case 42:
				peScrambler.binaryWriter.Write(new byte[]
				{
					133,
					219
				});
				break;
			case 43:
				peScrambler.binaryWriter.Write(new byte[]
				{
					133,
					237
				});
				break;
			case 44:
				peScrambler.binaryWriter.Write(new byte[]
				{
					133,
					246
				});
				break;
			case 45:
				peScrambler.binaryWriter.Write(new byte[]
				{
					133,
					byte.MaxValue
				});
				break;
			case 46:
				peScrambler.binaryWriter.Write(5);
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 47:
				peScrambler.binaryWriter.Write(new byte[]
				{
					129,
					193
				});
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 48:
				peScrambler.binaryWriter.Write(new byte[]
				{
					129,
					194
				});
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 49:
				peScrambler.binaryWriter.Write(new byte[]
				{
					129,
					195
				});
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 50:
				peScrambler.binaryWriter.Write(new byte[]
				{
					129,
					197
				});
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 51:
				peScrambler.binaryWriter.Write(new byte[]
				{
					129,
					198
				});
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			case 52:
				peScrambler.binaryWriter.Write(new byte[]
				{
					129,
					199
				});
				peScrambler.binaryWriter.Write(peScrambler.random.NextUInt32());
				break;
			}
			long num4 = peScrambler.peImage.GetStream().Position - position2;
			if (num2 >= 15 && num2 <= 30)
			{
				peScrambler.peImage.GetStream().Position -= num4 + 1L;
				peScrambler.binaryWriter.Write((byte)num4);
				peScrambler.peImage.GetStream().Position += num4;
			}
			num2 = num3;
		}
		peScrambler.binaryWriter.Write(233);
		int num5 = (int)(peScrambler.peImage.GetStream().Position - position - 30L);
		if (num5 < 0)
		{
			num5 = 2;
		}
		int num6 = peScrambler.random.Next(1, num5);
		peScrambler.binaryWriter.Write(num6);
		buffer = new byte[num6];
		peScrambler.random.NextBytes(buffer);
		peScrambler.binaryWriter.Write(buffer);
		bool flag = peScrambler.random.Next(2) == 1;
		switch (peScrambler.random.Next(7))
		{
		case 0:
		{
			uint num7 = peScrambler.random.NextUInt32();
			peScrambler.binaryWriter.Write(184);
			peScrambler.binaryWriter.Write(num7);
			peScrambler.binaryWriter.Write(61);
			peScrambler.binaryWriter.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => peScrambler.random.NextUInt32()) : num7);
			break;
		}
		case 1:
		{
			uint num7 = peScrambler.random.NextUInt32();
			peScrambler.binaryWriter.Write(185);
			peScrambler.binaryWriter.Write(num7);
			peScrambler.binaryWriter.Write(new byte[]
			{
				129,
				249
			});
			peScrambler.binaryWriter.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => peScrambler.random.NextUInt32()) : num7);
			break;
		}
		case 2:
		{
			uint num7 = peScrambler.random.NextUInt32();
			peScrambler.binaryWriter.Write(186);
			peScrambler.binaryWriter.Write(num7);
			peScrambler.binaryWriter.Write(new byte[]
			{
				129,
				250
			});
			peScrambler.binaryWriter.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => peScrambler.random.NextUInt32()) : num7);
			break;
		}
		case 3:
		{
			uint num7 = peScrambler.random.NextUInt32();
			peScrambler.binaryWriter.Write(187);
			peScrambler.binaryWriter.Write(num7);
			peScrambler.binaryWriter.Write(new byte[]
			{
				129,
				251
			});
			peScrambler.binaryWriter.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => peScrambler.random.NextUInt32()) : num7);
			break;
		}
		case 4:
		{
			uint num7 = peScrambler.random.NextUInt32();
			peScrambler.binaryWriter.Write(189);
			peScrambler.binaryWriter.Write(num7);
			peScrambler.binaryWriter.Write(new byte[]
			{
				129,
				253
			});
			peScrambler.binaryWriter.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => peScrambler.random.NextUInt32()) : num7);
			break;
		}
		case 5:
		{
			uint num7 = peScrambler.random.NextUInt32();
			peScrambler.binaryWriter.Write(190);
			peScrambler.binaryWriter.Write(num7);
			peScrambler.binaryWriter.Write(new byte[]
			{
				129,
				254
			});
			peScrambler.binaryWriter.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => peScrambler.random.NextUInt32()) : num7);
			break;
		}
		case 6:
		{
			uint num7 = peScrambler.random.NextUInt32();
			peScrambler.binaryWriter.Write(191);
			peScrambler.binaryWriter.Write(num7);
			peScrambler.binaryWriter.Write(new byte[]
			{
				129,
				byte.MaxValue
			});
			peScrambler.binaryWriter.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => peScrambler.random.NextUInt32()) : num7);
			break;
		}
		}
		if (!flag)
		{
			peScrambler.binaryWriter.Write(117);
		}
		else
		{
			peScrambler.binaryWriter.Write(116);
		}
		peScrambler.binaryWriter.Write((byte)peScrambler.random.Next(2, 128));
		peScrambler.binaryWriter.Write(97);
		int num8 = (int)(peScrambler.peImage.GetStream().Position - position);
		peScrambler.binaryWriter.Write(233);
		peScrambler.binaryWriter.Write((int)((ulong)(peScrambler.peImage.GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint() - peSectionHeader.GetVirtualAddress() - 5u) - (ulong)((long)num8)));
		num5 = (int)((ulong)peSectionHeader.GetVirtualSize() - (ulong)(peScrambler.peImage.GetStream().Position - position) - 30UL);
		num6 = ((num5 < 0) ? 0 : peScrambler.random.Next(1, num5));
		buffer = new byte[num6];
		peScrambler.random.NextBytes(buffer);
		peScrambler.binaryWriter.Write(buffer);
		long num9 = peScrambler.peImage.GetStream().Position - (long)((ulong)peSectionHeader.GetPointerToRawData());
		int num10 = peScrambler.random.Next(18, (int)((ulong)peSectionHeader.GetVirtualSize() - (ulong)num9 + 18UL));
		peScrambler.binaryWriter.Write(232);
		peScrambler.binaryWriter.Write(num10);
		int num11 = peScrambler.random.Next(5);
		switch (num11)
		{
		case 0:
			peScrambler.binaryWriter.Write(new byte[]
			{
				131,
				192,
				6
			});
			peScrambler.binaryWriter.Write(new byte[]
			{
				198,
				0,
				96
			});
			peScrambler.binaryWriter.Write(PeScrambler.GenerateDifferentValue<byte>(96, new PeScrambler.ValueFactory<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
			peScrambler.binaryWriter.Write(new byte[]
			{
				131,
				192,
				7
			});
			peScrambler.binaryWriter.Write(new byte[]
			{
				198,
				0,
				233
			});
			break;
		case 1:
			peScrambler.binaryWriter.Write(new byte[]
			{
				131,
				193,
				6
			});
			peScrambler.binaryWriter.Write(new byte[]
			{
				198,
				1,
				96
			});
			peScrambler.binaryWriter.Write(PeScrambler.GenerateDifferentValue<byte>(96, new PeScrambler.ValueFactory<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
			peScrambler.binaryWriter.Write(new byte[]
			{
				131,
				193,
				7
			});
			peScrambler.binaryWriter.Write(new byte[]
			{
				198,
				1,
				233
			});
			break;
		case 2:
			peScrambler.binaryWriter.Write(new byte[]
			{
				131,
				194,
				6
			});
			peScrambler.binaryWriter.Write(new byte[]
			{
				198,
				2,
				96
			});
			peScrambler.binaryWriter.Write(PeScrambler.GenerateDifferentValue<byte>(96, new PeScrambler.ValueFactory<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
			peScrambler.binaryWriter.Write(new byte[]
			{
				131,
				194,
				7
			});
			peScrambler.binaryWriter.Write(new byte[]
			{
				198,
				2,
				233
			});
			break;
		case 3:
			peScrambler.binaryWriter.Write(new byte[]
			{
				131,
				195,
				6
			});
			peScrambler.binaryWriter.Write(new byte[]
			{
				198,
				3,
				96
			});
			peScrambler.binaryWriter.Write(PeScrambler.GenerateDifferentValue<byte>(96, new PeScrambler.ValueFactory<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
			peScrambler.binaryWriter.Write(new byte[]
			{
				131,
				195,
				7
			});
			peScrambler.binaryWriter.Write(new byte[]
			{
				198,
				3,
				233
			});
			break;
		case 4:
			peScrambler.binaryWriter.Write(new byte[]
			{
				131,
				199,
				6
			});
			peScrambler.binaryWriter.Write(new byte[]
			{
				198,
				7,
				96
			});
			peScrambler.binaryWriter.Write(PeScrambler.GenerateDifferentValue<byte>(96, new PeScrambler.ValueFactory<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
			peScrambler.binaryWriter.Write(new byte[]
			{
				131,
				199,
				7
			});
			peScrambler.binaryWriter.Write(new byte[]
			{
				198,
				7,
				233
			});
			break;
		}
		num8 = (int)(peScrambler.peImage.GetStream().Position - position);
		peScrambler.binaryWriter.Write(PeScrambler.GenerateDifferentValue<byte>(233, new PeScrambler.ValueFactory<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
		peScrambler.binaryWriter.Write((int)((ulong)(peSectionHeader.GetVirtualAddress() + 5u) + (ulong)((long)num) - ((ulong)peSectionHeader.GetVirtualAddress() + (ulong)((long)num8) + 5UL)));
		peScrambler.peImage.GetStream().Position += (long)(num10 - 18);
		switch (num11)
		{
		case 0:
			peScrambler.binaryWriter.Write(new byte[]
			{
				139,
				4,
				36
			});
			peScrambler.binaryWriter.Write(195);
			break;
		case 1:
			peScrambler.binaryWriter.Write(new byte[]
			{
				139,
				12,
				36
			});
			peScrambler.binaryWriter.Write(195);
			break;
		case 2:
			peScrambler.binaryWriter.Write(new byte[]
			{
				139,
				20,
				36
			});
			peScrambler.binaryWriter.Write(195);
			break;
		case 3:
			peScrambler.binaryWriter.Write(new byte[]
			{
				139,
				28,
				36
			});
			peScrambler.binaryWriter.Write(195);
			break;
		case 4:
			peScrambler.binaryWriter.Write(new byte[]
			{
				139,
				60,
				36
			});
			peScrambler.binaryWriter.Write(195);
			break;
		}
		peScrambler.peImage.GetStream().Position = position + 1L;
		peScrambler.binaryWriter.Write(num8 - 23);
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetAddressOfEntryPoint(peSectionHeader.GetVirtualAddress());
	}

	internal static DelayImportDirectory ReadDelayImportDirectory(BoundsCheckedBinaryReader boundsCheckedBinaryReader, PeImage peImage)
	{
		DataDirectory @class = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[13];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetVirtualAddress());
		if (num == -1L || !boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		if (boundsCheckedBinaryReader.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
			return new DelayImportDirectory(boundsCheckedBinaryReader, peImage);
		}
		return null;
	}

	internal static void SavePeImage(string text, PeImage peImage)
	{
		using (FileStream fileStream = File.OpenWrite(text))
		{
			fileStream.SetLength(0L);
			RecoveredRuntime.WritePeImage(fileStream, peImage);
		}
	}

	internal static ExceptionDirectory ReadExceptionDirectory(PeImage peImage, BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		DataDirectory @class = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[3];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetVirtualAddress());
		if (num == -1L || !boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		if (boundsCheckedBinaryReader.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
			return new ExceptionDirectory(boundsCheckedBinaryReader, @class);
		}
		return null;
	}

	internal static void MoveBaseRelocationDirectory(PeScrambler peScrambler, PeSectionHeader peSectionHeader)
	{
		DataDirectory @class = peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[5];
		long num = RecoveredRuntime.MapRvaToFileOffset(peScrambler.peImage, @class.GetVirtualAddress());
		if (num == -1L)
		{
			return;
		}
		if (peSectionHeader.GetVirtualSize() < @class.GetSize())
		{
			peSectionHeader.SetVirtualSize(@class.GetSize());
		}
		if (peSectionHeader.GetSizeOfRawData() < @class.GetSize())
		{
			return;
		}
		byte[] buffer;
		using (Stream stream = RecoveredRuntime.CopyImageRange(peScrambler.peImage, num, (int)@class.GetSize()))
		{
			using (BinaryReader binaryReader = new BinaryReader(stream))
			{
				buffer = binaryReader.ReadBytes((int)@class.GetSize());
			}
		}
		RecoveredRuntime.FillImageRangeWithRandomBytes(peScrambler, num, (long)((ulong)@class.GetSize()));
		peScrambler.peImage.GetStream().Position = (long)((ulong)peSectionHeader.GetPointerToRawData());
		peScrambler.binaryWriter.Write(buffer);
		@class.SetVirtualAddress(peSectionHeader.GetVirtualAddress());
	}

	internal static ClrHeader ReadClrHeader(PeImage peImage, BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		DataDirectory @class = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[14];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetVirtualAddress());
		if (num == -1L || !boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		if (!boundsCheckedBinaryReader.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			return null;
		}
		RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
		ClrHeader class2 = new ClrHeader(boundsCheckedBinaryReader);
		if (class2.GetHeaderSize() < 72u)
		{
			return null;
		}
		return class2;
	}

	internal static void WritePeImage(Stream stream, PeImage peImage)
	{
		WritePeImage(stream, new PeImageWriter(peImage));
	}

	internal static void ScrambleModule(string sourcePath, string destinationPath)
	{
		InjectorScrambleOptions options = ApplicationSettings.Current.Options.Scramble;
		PeScrambleOptions transformOptions = new PeScrambleOptions();
		transformOptions.CreateNewEntryPoint = options.CreateNewEntryPoint;
		transformOptions.InsertExtraSections = options.InsertExtraSections;
		transformOptions.ModifyAssemblyCode = options.ModifyAssemblyCode;
		transformOptions.ScrambleHeaderFields = options.ScrambleHeaderFields;
		transformOptions.ModifyImportTable = options.ModifyImportTable;
		transformOptions.RenameSections = options.RenameSections;
		transformOptions.MoveRelocationTable = options.MoveRelocationTable;
		transformOptions.RemoveDebugData = options.RemoveDebugData;
		transformOptions.ShiftSectionData = options.ShiftSectionData;
		transformOptions.RemoveUselessData = options.RemoveUselessData;
		transformOptions.CreateFakeDebugDirectory = options.CreateFakeDebugDirectory;
		transformOptions.ShiftSectionMemory = options.ShiftSectionMemory;
		transformOptions.StripSectionCharacteristics = options.StripSectionCharacteristics;

		try
		{
			using (PeImage module = LoadPeImageFromFile(PeImageLayout.File, sourcePath))
			using (PeScrambler scrambler = new PeScrambler(module, transformOptions))
			{
				ScramblePeImage(scrambler);
				SaveScrambledImage(destinationPath, scrambler);
			}
		}
		catch
		{
			File.Copy(sourcePath, destinationPath, overwrite: true);
		}
	}

	internal static void SaveSettingsFromForm(SettingsForm settingsForm)
	{
		InjectionOptions class14_ = ApplicationSettings.Current.Options;
		class14_.Method = (InjectionMethod)settingsForm.comboBox.SelectedIndex;
		class14_.TextColor = settingsForm.panel3.BackColor;
		class14_.BackgroundColor1 = settingsForm.panel2.BackColor;
		class14_.BackgroundColor2 = settingsForm.panel.BackColor;
		class14_.AutoInject = settingsForm.checkBox3.Checked;
		class14_.StealthInject = settingsForm.checkBox.Checked;
		class14_.CloseOnInject = settingsForm.checkBox2.Checked;
		class14_.DelayBetweenModules = (int)settingsForm.numericUpDown.Value;
		class14_.DelayBeforeInjection = (int)settingsForm.numericUpDown2.Value;
		class14_.ErasePeHeaders = settingsForm.checkBox5.Checked;
		class14_.HideModule = settingsForm.checkBox4.Checked;
		ApplicationSettings.Save();
	}

	internal static void WriteDosHeaderPeOffset(PeImageWriter peImageWriter)
	{
		peImageWriter.stream.Position = 60L;
		peImageWriter.binaryWriter.Write(peImageWriter.peImage.GetDosHeader().GetPeHeaderOffset());
	}

	internal static void AddModuleToGrid(bool flag, ModuleEntry moduleEntry, bool flag2, MainForm mainForm, string text)
	{
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			text = Path.GetFullPath(text);
			foreach (DataGridViewRow row in mainForm.moduleGrid.Rows)
			{
				MainForm.ModuleRow existing = row.Tag as MainForm.ModuleRow;
				if (existing != null && GetModulePath(existing).Equals(text, StringComparison.OrdinalIgnoreCase))
				{
					return;
				}
			}

			using (FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (PeImage image = PeImportReader.ReadImports(fileStream, text, flag: false, PeImageLayout.File))
			{
				if (image == null || (image.GetHeaders().GetCoffHeader().GetCharacteristics() & CoffCharacteristics.Dll) == 0)
				{
					throw new Exception();
				}

				try
				{
					CheckImportedDependencies(image, mainForm);
				}
				catch
				{
				}
			}

			int index = mainForm.moduleGrid.Rows.Add(flag, Path.GetFileName(text));
			MainForm.ModuleRow moduleRow = new MainForm.ModuleRow(moduleEntry);
			SetModulePath(moduleRow, text);
			mainForm.moduleGrid.Rows[index].Tag = moduleRow;
			mainForm.moduleGrid.Rows[index].Cells[1].ToolTipText = text;
			mainForm.moduleGrid.Rows[index].Cells[2].ToolTipText = UiText.Get("Main.AdvancedOptionsTooltip");

			if (moduleEntry == null)
			{
				ApplicationSettings.Current.Modules.Add(moduleRow.Entry);
			}
		}
		catch (Exception)
		{
			if (!flag2)
			{
				return;
			}
			MessageBox.Show(mainForm, UiText.Format("Message.InvalidDll", Path.GetFileName(text)), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal static void HandleLegacyManagedDependency(PeImage peImage, string text2, MainForm mainForm)
	{
		if (!text2.StartsWith(EncodedStringTable.DecodeString(24517), StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		string text = RecoveredRuntime.ResolveImageDependencyPath(peImage, text2);
		bool flag = false;
		if (!string.IsNullOrEmpty(text))
		{
			using (FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				try
				{
					PeImage @class = PeImportReader.ReadImports(fileStream, text, false, PeImageLayout.File);
					if (@class != null && RecoveredRuntime.Is32BitImage(@class) != RecoveredRuntime.Is32BitImage(peImage))
					{
						flag = true;
					}
				}
				catch
				{
				}
			}
			if (!flag)
			{
				return;
			}
		}
		if (RecoveredRuntime.ConfirmDependencyInstallation(mainForm, peImage.GetFileName(), text2, text, false, EncodedStringTable.DecodeString(24526)))
		{
			DependencyInstallerForm form = new DependencyInstallerForm();
			RecoveredRuntime.ConfigureInstallerDownload(form, EncodedStringTable.DecodeString(24551), null, EncodedStringTable.DecodeString(24624));
			form.ShowDialog();
		}
	}

	internal static string ResolveImageDependencyPath(PeImage peImage, string text)
	{
		DependencySearchFlags @enum = DependencySearchFlags.ResolveApiSetToSystemDirectory;
		if (PlatformInfo.flag && RecoveredRuntime.Is32BitImage(peImage))
		{
			@enum |= DependencySearchFlags.UseWow64SystemDirectory;
		}
		return RecoveredRuntime.ResolveDependencyPath(text, peImage.GetFilePath(), Path.GetDirectoryName(peImage.GetFilePath()), @enum, 0, NativeTypes.address);
	}

	internal static ExportDirectory ReadExportDirectory(PeImage peImage, BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		DataDirectory @class = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[0];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetVirtualAddress());
		if (num == -1L || !boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		if (!boundsCheckedBinaryReader.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			return null;
		}
		RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
		return new ExportDirectory(boundsCheckedBinaryReader, peImage, @class);
	}

	internal static PeImage LoadPeImageFromBytes(byte[] bytes, PeImageLayout peImageLayout)
	{
		MemoryStream memoryStream = new MemoryStream(bytes, writable: false);
		return PeImageReader.ReadFullImage(memoryStream, flag: true, peImageLayout);
	}

	internal static void LocateNativeLoaderHooks(NativeLoaderHooks nativeLoaderHooks)
	{
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(nativeLoaderHooks.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(12731));
		}
		PeSectionHeader gclass2 = RecoveredRuntime.ReadRemoteModuleImage(gclass).GetSections().FirstOrDefault(new Func<PeSectionHeader, bool>(NativeLoaderHooks.TextSectionPredicateCache._003C_003E9.IsTextSection));
		if (gclass2 == null)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(24645));
		}
		IntPtr intPtr = gclass.GetModuleBase().Add((long)((ulong)gclass2.GetVirtualAddress()));
		byte[] array = nativeLoaderHooks.ReadArray<byte>(intPtr, (int)gclass2.GetVirtualSize());
		if (RecoveredRuntime.Is32BitProcess(nativeLoaderHooks.GetRemoteProcess()))
		{
			if (!PlatformInfo.flag11)
			{
				if (!PlatformInfo.flag10)
				{
					if (PlatformInfo.flag7)
					{
						int num = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24804), 0);
						if (num == -1)
						{
							num = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24821), 0);
							if (num != -1)
							{
								nativeLoaderHooks.SetInsertInvertedFunctionTableAddress(intPtr.Add(num - 11));
								nativeLoaderHooks.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num + 29));
							}
						}
						else
						{
							nativeLoaderHooks.SetInsertInvertedFunctionTableAddress(intPtr.Add(num - 11));
							if (!PlatformInfo.flag8)
							{
								nativeLoaderHooks.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num + 35));
							}
							else
							{
								nativeLoaderHooks.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num + 34));
							}
						}
						num = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24846), 0);
						if (num != -1)
						{
							nativeLoaderHooks.SetRemoveInvertedFunctionTableAddress(intPtr.Add(num - 18));
							return;
						}
					}
					else if (PlatformInfo.flag6)
					{
						int num2 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24859), 0);
						if (num2 != -1)
						{
							nativeLoaderHooks.SetInsertInvertedFunctionTableAddress(intPtr.Add(num2));
							nativeLoaderHooks.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num2 + 38));
							return;
						}
					}
					else if (!PlatformInfo.flag2)
					{
						if (PlatformInfo.flag4 && PlatformInfo.flag)
						{
							int num3 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24947), 0);
							if (num3 != -1)
							{
								nativeLoaderHooks.SetInsertInvertedFunctionTableAddress(intPtr.Add(num3));
							}
							num3 = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(24909), EncodedStringTable.DecodeString(24930), 0);
							if (num3 != -1)
							{
								nativeLoaderHooks.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num3 + 7));
							}
						}
					}
					else
					{
						int num4 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24892), 0);
						if (num4 != -1)
						{
							nativeLoaderHooks.SetInsertInvertedFunctionTableAddress(intPtr.Add(num4));
						}
						num4 = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(24909), EncodedStringTable.DecodeString(24930), 0);
						if (num4 != -1)
						{
							nativeLoaderHooks.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num4 + 7));
							return;
						}
					}
				}
				else
				{
					int num5 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24745), 0);
					if (num5 != -1)
					{
						nativeLoaderHooks.SetInsertInvertedFunctionTableAddress(intPtr.Add(num5 - 11));
						nativeLoaderHooks.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num5 + 76));
					}
					else if ((num5 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24770), 0)) != -1)
					{
						int num6 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24783), 0);
						if (num6 != -1)
						{
							nativeLoaderHooks.SetInsertInvertedFunctionTableAddress(intPtr.Add(num6 - 33));
							nativeLoaderHooks.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num5 - 27));
						}
					}
					num5 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24732), 0);
					if (num5 != -1)
					{
						nativeLoaderHooks.SetRemoveInvertedFunctionTableAddress(intPtr.Add(num5 - 28));
						return;
					}
				}
			}
			else
			{
				int num7 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24702), 0);
				if (num7 != -1)
				{
					nativeLoaderHooks.SetInsertInvertedFunctionTableAddress(intPtr.Add(num7 - 8));
				}
				num7 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24719), 0);
				if (num7 != -1)
				{
					nativeLoaderHooks.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num7 - 27));
				}
				num7 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24732), 0);
				if (num7 != -1)
				{
					nativeLoaderHooks.SetRemoveInvertedFunctionTableAddress(intPtr.Add(num7 - 28));
					return;
				}
			}
		}
	}

	internal static void DisposeManualMapContext(ManualMapInjector.MappingContext mappingContext)
	{
		PeImage image = mappingContext.GetImage();
		if (image != null)
		{
			image.Dispose();
			mappingContext.SetImage(null);
		}

		IntPtr activationContextHandle = mappingContext.GetActivationContextHandle();
		if (activationContextHandle != NativeTypes.address)
		{
			RecoveredRuntime.ReleaseActCtx(activationContextHandle);
			mappingContext.SetActivationContextHandle(NativeTypes.address);
		}
	}

	internal static void NormalizeSectionVirtualSizes(PeScrambler peScrambler)
	{
		List<PeSectionHeader> sections = peScrambler.peImage.GetSections();
		uint sectionAlignment = peScrambler.peImage.GetHeaders().GetOptionalHeader().GetSectionAlignment();
		for (int index = 0; index < sections.Count; index++)
		{
			PeSectionHeader section = sections[index];
			section.SetVirtualSize(RecoveredRuntime.AlignUp(sectionAlignment, section.GetVirtualSize()));
			if (index < sections.Count - 1 && section.GetVirtualAddress() + section.GetVirtualSize() > sections[index + 1].GetVirtualAddress())
			{
				section.SetVirtualSize(sections[index + 1].GetVirtualAddress() - section.GetVirtualAddress());
			}
		}
	}

	internal static void ScramblePeHeaderFields(PeScrambler peScrambler)
	{
		RecoveredRuntime.FillImageRangeWithRandomBytes(peScrambler, 2L, 58L);
		peScrambler.peImage.GetHeaders().GetCoffHeader().SetPointerToSymbolTable(peScrambler.random.NextUInt32());
		peScrambler.peImage.GetHeaders().GetCoffHeader().SetNumberOfSymbols(peScrambler.random.NextUInt32());
		CoffHeader @class = peScrambler.peImage.GetHeaders().GetCoffHeader();
		@class.SetCharacteristics(@class.GetCharacteristics() | (CoffCharacteristics.AggressiveWorkingSetTrim | CoffCharacteristics.BytesReversedLow | CoffCharacteristics.BytesReversedHigh));
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetMajorLinkerVersion(0);
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetMinorLinkerVersion(0);
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetMajorImageVersion(peScrambler.random.NextUInt16());
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetMinorImageVersion(peScrambler.random.NextUInt16());
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetSizeOfCode(peScrambler.random.NextUInt32());
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetSizeOfInitializedData(peScrambler.random.NextUInt32());
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetSizeOfUninitializedData(peScrambler.random.NextUInt32());
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetBaseOfCode(peScrambler.random.NextUInt32());
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetBaseOfData(peScrambler.random.NextUInt32());
		peScrambler.peImage.GetHeaders().GetOptionalHeader().SetLoaderFlags(peScrambler.random.NextUInt32());
		peScrambler.peImage.GetHeaders().GetCoffHeader().SetTimeDateStamp(peScrambler.random.NextUInt32());
		if ((peScrambler.peImage.GetHeaders().GetCoffHeader().GetCharacteristics() & CoffCharacteristics.Dll) == CoffCharacteristics.Dll)
		{
			peScrambler.peImage.GetHeaders().GetOptionalHeader().SetSizeOfStackCommit((ulong)peScrambler.random.NextUInt32());
			peScrambler.peImage.GetHeaders().GetOptionalHeader().SetSizeOfStackReserve((ulong)peScrambler.random.NextUInt32());
			peScrambler.peImage.GetHeaders().GetOptionalHeader().SetSizeOfHeapCommit((ulong)peScrambler.random.NextUInt32());
			peScrambler.peImage.GetHeaders().GetOptionalHeader().SetSizeOfHeapReserve((ulong)peScrambler.random.NextUInt32());
		}
		if (RecoveredRuntime.CanScrambleDataDirectoryCount(peScrambler))
		{
			if (RecoveredRuntime.Is32BitImage(peScrambler.peImage) && peScrambler.peImage.GetHeaders().GetCoffHeader().GetSizeOfOptionalHeader() == 224)
			{
				peScrambler.peImage.GetHeaders().GetOptionalHeader().SetNumberOfRvaAndSizes(peScrambler.random.NextUInt32(10u, 17u));
			}
			else if (!RecoveredRuntime.Is32BitImage(peScrambler.peImage) && peScrambler.peImage.GetHeaders().GetCoffHeader().GetSizeOfOptionalHeader() == 240)
			{
				peScrambler.peImage.GetHeaders().GetOptionalHeader().SetNumberOfRvaAndSizes(15u);
			}
		}
		uint[] array = new uint[]
		{
			1u,
			2u,
			4u,
			8u,
			16384u
		};
		for (int i = 0; i < peScrambler.random.Next(1, array.Length); i++)
		{
			uint num = array[peScrambler.random.Next(array.Length)];
			if ((peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDllCharacteristics() & (DllCharacteristics)num) != (DllCharacteristics)num)
			{
				IPeOptionalHeader @interface = peScrambler.peImage.GetHeaders().GetOptionalHeader();
				@interface.SetDllCharacteristics(@interface.GetDllCharacteristics() | (DllCharacteristics)num);
			}
			else
			{
				i--;
			}
		}
	}

	internal static ResourceDirectory ReadResourceDirectory(PeImage peImage, BoundsCheckedBinaryReader boundsCheckedBinaryReader)
	{
		DataDirectory @class = peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[2];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetVirtualAddress());
		if (num == -1L || !boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		if (!boundsCheckedBinaryReader.IsValidOffset(num))
		{
			return null;
		}
		return new ResourceDirectory(boundsCheckedBinaryReader, num, @class.GetSize());
	}

	internal static bool TryReadPe64OptionalHeader(BoundsCheckedBinaryReader boundsCheckedBinaryReader, uint uintValue, out Pe64OptionalHeader pe64OptionalHeader)
	{
		pe64OptionalHeader = null;
		const uint fixedHeaderSize = 112;
		long start = boundsCheckedBinaryReader.BaseStream.Position;
		if (uintValue < fixedHeaderSize || start < 0 || start + uintValue > boundsCheckedBinaryReader.BaseStream.Length)
		{
			return false;
		}

		var header = new Pe64OptionalHeader();
		header.SetMagic(boundsCheckedBinaryReader.ReadUInt16());
		if (header.GetMagic() != 0x020B)
		{
			return false;
		}

		header.SetMajorLinkerVersion(boundsCheckedBinaryReader.ReadByte());
		header.SetMinorLinkerVersion(boundsCheckedBinaryReader.ReadByte());
		header.SetSizeOfCode(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfInitializedData(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfUninitializedData(boundsCheckedBinaryReader.ReadUInt32());
		header.SetAddressOfEntryPoint(boundsCheckedBinaryReader.ReadUInt32());
		header.SetBaseOfCode(boundsCheckedBinaryReader.ReadUInt32());
		header.SetImageBase(boundsCheckedBinaryReader.ReadUInt64());
		header.SetSectionAlignment(boundsCheckedBinaryReader.ReadUInt32());
		header.SetFileAlignment(boundsCheckedBinaryReader.ReadUInt32());
		header.SetMajorOperatingSystemVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetMinorOperatingSystemVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetMajorImageVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetMinorImageVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetMajorSubsystemVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetMinorSubsystemVersion(boundsCheckedBinaryReader.ReadUInt16());
		header.SetWin32VersionValue(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfImage(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSizeOfHeaders(boundsCheckedBinaryReader.ReadUInt32());
		header.SetChecksum(boundsCheckedBinaryReader.ReadUInt32());
		header.SetSubsystem((Subsystem)boundsCheckedBinaryReader.ReadUInt16());
		header.SetDllCharacteristics((DllCharacteristics)boundsCheckedBinaryReader.ReadUInt16());
		header.SetSizeOfStackReserve(boundsCheckedBinaryReader.ReadUInt64());
		header.SetSizeOfStackCommit(boundsCheckedBinaryReader.ReadUInt64());
		header.SetSizeOfHeapReserve(boundsCheckedBinaryReader.ReadUInt64());
		header.SetSizeOfHeapCommit(boundsCheckedBinaryReader.ReadUInt64());
		header.SetLoaderFlags(boundsCheckedBinaryReader.ReadUInt32());
		header.SetNumberOfRvaAndSizes(boundsCheckedBinaryReader.ReadUInt32());

		DataDirectory[] directories = header.GetDataDirectories();
		uint availableDirectoryCount = (uintValue - fixedHeaderSize) / 8U;
		int directoryCount = (int)Math.Min((uint)directories.Length, Math.Min(header.GetNumberOfRvaAndSizes(), availableDirectoryCount));
		for (int index = 0; index < directories.Length; index++)
		{
			directories[index] = index < directoryCount ? new DataDirectory(boundsCheckedBinaryReader) : new DataDirectory();
		}

		boundsCheckedBinaryReader.BaseStream.Position = start + uintValue;
		pe64OptionalHeader = header;
		return true;
	}

	internal static IEnumerable<string> EnumerateImportedSymbolNames(string text, IEnumerable<ImportedSymbol> items, ImportDirectory importDirectory)
	{
		return new ImportDirectory.ImportedNameIterator(-2)
		{
			text3 = text,
			items2 = items
		};
	}

	internal static void RemoveDebugDirectory(PeScrambler peScrambler)
	{
		if (peScrambler.peImage.GetDebugDirectory() == null)
		{
			return;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(peScrambler.peImage, peScrambler.peImage.GetDebugDirectory().GetAddressOfRawData());
		if (num == -1L)
		{
			return;
		}
		RecoveredRuntime.FillImageRangeWithRandomBytes(peScrambler, num, (long)((ulong)peScrambler.peImage.GetDebugDirectory().GetSizeOfData()));
		DataDirectory @class = peScrambler.peImage.GetHeaders().GetOptionalHeader().GetDataDirectories()[6];
		long long_ = RecoveredRuntime.MapRvaToFileOffset(peScrambler.peImage, @class.GetVirtualAddress());
		RecoveredRuntime.FillImageRangeWithRandomBytes(peScrambler, long_, 28L);
		@class.SetVirtualAddress(0u);
		@class.SetSize(0u);
	}

	internal static void ApplySectionRemap(List<PeScrambler.SectionRemap> items, PeScrambler peScrambler)
	{
		IPeOptionalHeader @interface = peScrambler.peImage.GetHeaders().GetOptionalHeader();
		if (@interface.GetBaseOfCode() != 0u)
		{
			@interface.SetBaseOfCode(RecoveredRuntime.RemapRva(items, @interface.GetBaseOfCode()));
		}
		if (@interface.GetBaseOfData() != 0u)
		{
			@interface.SetBaseOfData(RecoveredRuntime.RemapRva(items, @interface.GetBaseOfData()));
		}
		if (@interface.GetAddressOfEntryPoint() != 0u)
		{
			@interface.SetAddressOfEntryPoint(RecoveredRuntime.RemapRva(items, @interface.GetAddressOfEntryPoint()));
		}
		PeScrambler.SectionRemap @class = items.Last<PeScrambler.SectionRemap>();
		IPeOptionalHeader interface2 = @interface;
		uint uint_ = @class.GetModifiedSection().GetVirtualAddress() + @class.GetModifiedSection().GetVirtualSize();
		uint uintValue = @interface.GetSectionAlignment();
		interface2.SetSizeOfImage(RecoveredRuntime.AlignUp(uintValue, uint_));
		foreach (DataDirectory class2 in @interface.GetDataDirectories())
		{
			if (class2.GetVirtualAddress() != 0u)
			{
				class2.SetVirtualAddress(RecoveredRuntime.RemapRva(items, class2.GetVirtualAddress()));
			}
		}
		peScrambler.peImage.GetStream().SetLength((long)((ulong)(@class.GetModifiedSection().GetPointerToRawData() + @class.GetModifiedSection().GetSizeOfRawData())));
		BinaryWriter binaryWriter = new BinaryWriter(peScrambler.peImage.GetStream());
		for (int j = items.Count - 1; j >= 0; j--)
		{
			PeScrambler.SectionRemap class3 = items[j];
			if (class3.GetOriginalSection().GetSizeOfRawData() != 0u)
			{
				PeImage class154_ = peScrambler.peImage;
				long long_ = (long)((ulong)class3.GetOriginalSection().GetPointerToRawData());
				long longValue = (long)((ulong)class3.GetOriginalSection().GetSizeOfRawData());
				byte[] buffer = RecoveredRuntime.ReadImageBytes(longValue, class154_, long_);
				peScrambler.peImage.GetStream().Position = (long)((ulong)class3.GetOriginalSection().GetPointerToRawData());
				byte[] buffer2 = new byte[class3.GetOriginalSection().GetSizeOfRawData()];
				peScrambler.random.NextBytes(buffer2);
				binaryWriter.Write(buffer2);
				peScrambler.peImage.GetStream().Position = (long)((ulong)(class3.GetModifiedSection().GetPointerToRawData() + class3.GetContentOffset()));
				binaryWriter.Write(buffer);
			}
		}
		peScrambler.peImage.SetSections(items.Select(new Func<PeScrambler.SectionRemap, PeSectionHeader>(PeScrambler.ScramblerCallbackCache._003C_003E9.GetModifiedSection)).ToList<PeSectionHeader>());
	}
}
