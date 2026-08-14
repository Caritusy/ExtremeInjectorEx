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

	internal static void CreateDecoyEntryPoint(PeScrambler gclass4_0, PeSectionHeader gclass5_0)
	{
		gclass5_0.SetCharacteristics((SectionCharacteristics)3758096384u);
		gclass4_0.class154_0.GetStream().Position = (long)((ulong)gclass5_0.GetPointerToRawData());
		long position = gclass4_0.class154_0.GetStream().Position;
		gclass4_0.binaryWriter_0.Write(233);
		gclass4_0.binaryWriter_0.Write(0);
		int num = gclass4_0.random_0.Next((int)(gclass5_0.GetVirtualSize() / 50u), (int)(gclass5_0.GetVirtualSize() / 25u));
		byte[] buffer = new byte[num];
		gclass4_0.random_0.NextBytes(buffer);
		gclass4_0.binaryWriter_0.Write(buffer);
		int num2 = -1;
		for (int i = 0; i < gclass4_0.random_0.Next((int)(gclass5_0.GetVirtualSize() / 10u), (int)(gclass5_0.GetVirtualSize() / 8u)); i++)
		{
			int num3 = PeScrambler.GenerateDifferentValue<int>(num2, () => gclass4_0.random_0.Next(53));
			while (num2 != -1 && ((num3 >= 15 && num3 <= 30) || (num3 >= 39 && num3 <= 45)) && num2 >= 15 && num2 <= 30)
			{
				num3 = gclass4_0.random_0.Next(53);
			}
			if (num2 >= 39 && num2 <= 45)
			{
				num3 = gclass4_0.random_0.Next(15, 31);
			}
			long position2 = gclass4_0.class154_0.GetStream().Position;
			switch (num3)
			{
			case 0:
				gclass4_0.binaryWriter_0.Write(144);
				break;
			case 1:
				gclass4_0.binaryWriter_0.Write(184);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 2:
				gclass4_0.binaryWriter_0.Write(185);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 3:
				gclass4_0.binaryWriter_0.Write(186);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 4:
				gclass4_0.binaryWriter_0.Write(187);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 5:
				gclass4_0.binaryWriter_0.Write(189);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 6:
				gclass4_0.binaryWriter_0.Write(190);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 7:
				gclass4_0.binaryWriter_0.Write(191);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 8:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					51,
					192
				});
				break;
			case 9:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					51,
					201
				});
				break;
			case 10:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					51,
					210
				});
				break;
			case 11:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					51,
					219
				});
				break;
			case 12:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					51,
					237
				});
				break;
			case 13:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					51,
					246
				});
				break;
			case 14:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					51,
					byte.MaxValue
				});
				break;
			case 15:
			{
				BinaryWriter binaryWriter_ = gclass4_0.binaryWriter_0;
				byte[] array = new byte[2];
				array[0] = 112;
				binaryWriter_.Write(array);
				break;
			}
			case 16:
			{
				BinaryWriter binaryWriter_2 = gclass4_0.binaryWriter_0;
				byte[] array2 = new byte[2];
				array2[0] = 113;
				binaryWriter_2.Write(array2);
				break;
			}
			case 17:
			{
				BinaryWriter binaryWriter_3 = gclass4_0.binaryWriter_0;
				byte[] array3 = new byte[2];
				array3[0] = 114;
				binaryWriter_3.Write(array3);
				break;
			}
			case 18:
			{
				BinaryWriter binaryWriter_4 = gclass4_0.binaryWriter_0;
				byte[] array4 = new byte[2];
				array4[0] = 115;
				binaryWriter_4.Write(array4);
				break;
			}
			case 19:
			{
				BinaryWriter binaryWriter_5 = gclass4_0.binaryWriter_0;
				byte[] array5 = new byte[2];
				array5[0] = 116;
				binaryWriter_5.Write(array5);
				break;
			}
			case 20:
			{
				BinaryWriter binaryWriter_6 = gclass4_0.binaryWriter_0;
				byte[] array6 = new byte[2];
				array6[0] = 117;
				binaryWriter_6.Write(array6);
				break;
			}
			case 21:
			{
				BinaryWriter binaryWriter_7 = gclass4_0.binaryWriter_0;
				byte[] array7 = new byte[2];
				array7[0] = 118;
				binaryWriter_7.Write(array7);
				break;
			}
			case 22:
			{
				BinaryWriter binaryWriter_8 = gclass4_0.binaryWriter_0;
				byte[] array8 = new byte[2];
				array8[0] = 119;
				binaryWriter_8.Write(array8);
				break;
			}
			case 23:
			{
				BinaryWriter binaryWriter_9 = gclass4_0.binaryWriter_0;
				byte[] array9 = new byte[2];
				array9[0] = 120;
				binaryWriter_9.Write(array9);
				break;
			}
			case 24:
			{
				BinaryWriter binaryWriter_10 = gclass4_0.binaryWriter_0;
				byte[] array10 = new byte[2];
				array10[0] = 121;
				binaryWriter_10.Write(array10);
				break;
			}
			case 25:
			{
				BinaryWriter binaryWriter_11 = gclass4_0.binaryWriter_0;
				byte[] array11 = new byte[2];
				array11[0] = 122;
				binaryWriter_11.Write(array11);
				break;
			}
			case 26:
			{
				BinaryWriter binaryWriter_12 = gclass4_0.binaryWriter_0;
				byte[] array12 = new byte[2];
				array12[0] = 123;
				binaryWriter_12.Write(array12);
				break;
			}
			case 27:
			{
				BinaryWriter binaryWriter_13 = gclass4_0.binaryWriter_0;
				byte[] array13 = new byte[2];
				array13[0] = 124;
				binaryWriter_13.Write(array13);
				break;
			}
			case 28:
			{
				BinaryWriter binaryWriter_14 = gclass4_0.binaryWriter_0;
				byte[] array14 = new byte[2];
				array14[0] = 125;
				binaryWriter_14.Write(array14);
				break;
			}
			case 29:
			{
				BinaryWriter binaryWriter_15 = gclass4_0.binaryWriter_0;
				byte[] array15 = new byte[2];
				array15[0] = 126;
				binaryWriter_15.Write(array15);
				break;
			}
			case 30:
			{
				BinaryWriter binaryWriter_16 = gclass4_0.binaryWriter_0;
				byte[] array16 = new byte[2];
				array16[0] = 127;
				binaryWriter_16.Write(array16);
				break;
			}
			case 31:
				gclass4_0.binaryWriter_0.Write(80);
				gclass4_0.binaryWriter_0.Write(88);
				break;
			case 32:
				gclass4_0.binaryWriter_0.Write(81);
				gclass4_0.binaryWriter_0.Write(89);
				break;
			case 33:
				gclass4_0.binaryWriter_0.Write(82);
				gclass4_0.binaryWriter_0.Write(90);
				break;
			case 34:
				gclass4_0.binaryWriter_0.Write(83);
				gclass4_0.binaryWriter_0.Write(91);
				break;
			case 35:
				gclass4_0.binaryWriter_0.Write(84);
				gclass4_0.binaryWriter_0.Write(92);
				break;
			case 36:
				gclass4_0.binaryWriter_0.Write(85);
				gclass4_0.binaryWriter_0.Write(93);
				break;
			case 37:
				gclass4_0.binaryWriter_0.Write(86);
				gclass4_0.binaryWriter_0.Write(94);
				break;
			case 38:
				gclass4_0.binaryWriter_0.Write(87);
				gclass4_0.binaryWriter_0.Write(95);
				break;
			case 39:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					133,
					192
				});
				break;
			case 40:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					133,
					201
				});
				break;
			case 41:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					133,
					210
				});
				break;
			case 42:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					133,
					219
				});
				break;
			case 43:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					133,
					237
				});
				break;
			case 44:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					133,
					246
				});
				break;
			case 45:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					133,
					byte.MaxValue
				});
				break;
			case 46:
				gclass4_0.binaryWriter_0.Write(5);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 47:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					193
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 48:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					194
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 49:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					195
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 50:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					197
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 51:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					198
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			case 52:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					199
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.NextUInt32());
				break;
			}
			long num4 = gclass4_0.class154_0.GetStream().Position - position2;
			if (num2 >= 15 && num2 <= 30)
			{
				gclass4_0.class154_0.GetStream().Position -= num4 + 1L;
				gclass4_0.binaryWriter_0.Write((byte)num4);
				gclass4_0.class154_0.GetStream().Position += num4;
			}
			num2 = num3;
		}
		gclass4_0.binaryWriter_0.Write(233);
		int num5 = (int)(gclass4_0.class154_0.GetStream().Position - position - 30L);
		if (num5 < 0)
		{
			num5 = 2;
		}
		int num6 = gclass4_0.random_0.Next(1, num5);
		gclass4_0.binaryWriter_0.Write(num6);
		buffer = new byte[num6];
		gclass4_0.random_0.NextBytes(buffer);
		gclass4_0.binaryWriter_0.Write(buffer);
		bool flag = gclass4_0.random_0.Next(2) == 1;
		switch (gclass4_0.random_0.Next(7))
		{
		case 0:
		{
			uint num7 = gclass4_0.random_0.NextUInt32();
			gclass4_0.binaryWriter_0.Write(184);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(61);
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => gclass4_0.random_0.NextUInt32()) : num7);
			break;
		}
		case 1:
		{
			uint num7 = gclass4_0.random_0.NextUInt32();
			gclass4_0.binaryWriter_0.Write(185);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				249
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => gclass4_0.random_0.NextUInt32()) : num7);
			break;
		}
		case 2:
		{
			uint num7 = gclass4_0.random_0.NextUInt32();
			gclass4_0.binaryWriter_0.Write(186);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				250
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => gclass4_0.random_0.NextUInt32()) : num7);
			break;
		}
		case 3:
		{
			uint num7 = gclass4_0.random_0.NextUInt32();
			gclass4_0.binaryWriter_0.Write(187);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				251
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => gclass4_0.random_0.NextUInt32()) : num7);
			break;
		}
		case 4:
		{
			uint num7 = gclass4_0.random_0.NextUInt32();
			gclass4_0.binaryWriter_0.Write(189);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				253
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => gclass4_0.random_0.NextUInt32()) : num7);
			break;
		}
		case 5:
		{
			uint num7 = gclass4_0.random_0.NextUInt32();
			gclass4_0.binaryWriter_0.Write(190);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				254
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => gclass4_0.random_0.NextUInt32()) : num7);
			break;
		}
		case 6:
		{
			uint num7 = gclass4_0.random_0.NextUInt32();
			gclass4_0.binaryWriter_0.Write(191);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				byte.MaxValue
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.GenerateDifferentValue<uint>(num7, () => gclass4_0.random_0.NextUInt32()) : num7);
			break;
		}
		}
		if (!flag)
		{
			gclass4_0.binaryWriter_0.Write(117);
		}
		else
		{
			gclass4_0.binaryWriter_0.Write(116);
		}
		gclass4_0.binaryWriter_0.Write((byte)gclass4_0.random_0.Next(2, 128));
		gclass4_0.binaryWriter_0.Write(97);
		int num8 = (int)(gclass4_0.class154_0.GetStream().Position - position);
		gclass4_0.binaryWriter_0.Write(233);
		gclass4_0.binaryWriter_0.Write((int)((ulong)(gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetAddressOfEntryPoint() - gclass5_0.GetVirtualAddress() - 5u) - (ulong)((long)num8)));
		num5 = (int)((ulong)gclass5_0.GetVirtualSize() - (ulong)(gclass4_0.class154_0.GetStream().Position - position) - 30UL);
		num6 = ((num5 < 0) ? 0 : gclass4_0.random_0.Next(1, num5));
		buffer = new byte[num6];
		gclass4_0.random_0.NextBytes(buffer);
		gclass4_0.binaryWriter_0.Write(buffer);
		long num9 = gclass4_0.class154_0.GetStream().Position - (long)((ulong)gclass5_0.GetPointerToRawData());
		int num10 = gclass4_0.random_0.Next(18, (int)((ulong)gclass5_0.GetVirtualSize() - (ulong)num9 + 18UL));
		gclass4_0.binaryWriter_0.Write(232);
		gclass4_0.binaryWriter_0.Write(num10);
		int num11 = gclass4_0.random_0.Next(5);
		switch (num11)
		{
		case 0:
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				131,
				192,
				6
			});
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				198,
				0,
				96
			});
			gclass4_0.binaryWriter_0.Write(PeScrambler.GenerateDifferentValue<byte>(96, new PeScrambler.Delegate48<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				131,
				192,
				7
			});
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				198,
				0,
				233
			});
			break;
		case 1:
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				131,
				193,
				6
			});
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				198,
				1,
				96
			});
			gclass4_0.binaryWriter_0.Write(PeScrambler.GenerateDifferentValue<byte>(96, new PeScrambler.Delegate48<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				131,
				193,
				7
			});
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				198,
				1,
				233
			});
			break;
		case 2:
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				131,
				194,
				6
			});
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				198,
				2,
				96
			});
			gclass4_0.binaryWriter_0.Write(PeScrambler.GenerateDifferentValue<byte>(96, new PeScrambler.Delegate48<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				131,
				194,
				7
			});
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				198,
				2,
				233
			});
			break;
		case 3:
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				131,
				195,
				6
			});
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				198,
				3,
				96
			});
			gclass4_0.binaryWriter_0.Write(PeScrambler.GenerateDifferentValue<byte>(96, new PeScrambler.Delegate48<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				131,
				195,
				7
			});
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				198,
				3,
				233
			});
			break;
		case 4:
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				131,
				199,
				6
			});
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				198,
				7,
				96
			});
			gclass4_0.binaryWriter_0.Write(PeScrambler.GenerateDifferentValue<byte>(96, new PeScrambler.Delegate48<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				131,
				199,
				7
			});
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				198,
				7,
				233
			});
			break;
		}
		num8 = (int)(gclass4_0.class154_0.GetStream().Position - position);
		gclass4_0.binaryWriter_0.Write(PeScrambler.GenerateDifferentValue<byte>(233, new PeScrambler.Delegate48<byte>(RecoveredRuntime.GenerateSafeRandomInstructionByte)));
		gclass4_0.binaryWriter_0.Write((int)((ulong)(gclass5_0.GetVirtualAddress() + 5u) + (ulong)((long)num) - ((ulong)gclass5_0.GetVirtualAddress() + (ulong)((long)num8) + 5UL)));
		gclass4_0.class154_0.GetStream().Position += (long)(num10 - 18);
		switch (num11)
		{
		case 0:
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				139,
				4,
				36
			});
			gclass4_0.binaryWriter_0.Write(195);
			break;
		case 1:
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				139,
				12,
				36
			});
			gclass4_0.binaryWriter_0.Write(195);
			break;
		case 2:
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				139,
				20,
				36
			});
			gclass4_0.binaryWriter_0.Write(195);
			break;
		case 3:
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				139,
				28,
				36
			});
			gclass4_0.binaryWriter_0.Write(195);
			break;
		case 4:
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				139,
				60,
				36
			});
			gclass4_0.binaryWriter_0.Write(195);
			break;
		}
		gclass4_0.class154_0.GetStream().Position = position + 1L;
		gclass4_0.binaryWriter_0.Write(num8 - 23);
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetAddressOfEntryPoint(gclass5_0.GetVirtualAddress());
	}

	internal static DelayImportDirectory ReadDelayImportDirectory(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		DataDirectory @class = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[13];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetVirtualAddress());
		if (num == -1L || !class5_0.IsValidOffset(num))
		{
			return null;
		}
		if (class5_0.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			RecoveredRuntime.SeekReader(class5_0, num);
			return new DelayImportDirectory(class5_0, class154_0);
		}
		return null;
	}

	internal static void SavePeImage(string string_0, PeImage class154_0)
	{
		using (FileStream fileStream = File.OpenWrite(string_0))
		{
			fileStream.SetLength(0L);
			RecoveredRuntime.WritePeImage(fileStream, class154_0);
		}
	}

	internal static ExceptionDirectory ReadExceptionDirectory(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[3];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetVirtualAddress());
		if (num == -1L || !class5_0.IsValidOffset(num))
		{
			return null;
		}
		if (class5_0.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			RecoveredRuntime.SeekReader(class5_0, num);
			return new ExceptionDirectory(class5_0, @class);
		}
		return null;
	}

	internal static void MoveBaseRelocationDirectory(PeScrambler gclass4_0, PeSectionHeader gclass5_0)
	{
		DataDirectory @class = gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[5];
		long num = RecoveredRuntime.MapRvaToFileOffset(gclass4_0.class154_0, @class.GetVirtualAddress());
		if (num == -1L)
		{
			return;
		}
		if (gclass5_0.GetVirtualSize() < @class.GetSize())
		{
			gclass5_0.SetVirtualSize(@class.GetSize());
		}
		if (gclass5_0.GetSizeOfRawData() < @class.GetSize())
		{
			return;
		}
		byte[] buffer;
		using (Stream stream = RecoveredRuntime.CopyImageRange(gclass4_0.class154_0, num, (int)@class.GetSize()))
		{
			using (BinaryReader binaryReader = new BinaryReader(stream))
			{
				buffer = binaryReader.ReadBytes((int)@class.GetSize());
			}
		}
		RecoveredRuntime.FillImageRangeWithRandomBytes(gclass4_0, num, (long)((ulong)@class.GetSize()));
		gclass4_0.class154_0.GetStream().Position = (long)((ulong)gclass5_0.GetPointerToRawData());
		gclass4_0.binaryWriter_0.Write(buffer);
		@class.SetVirtualAddress(gclass5_0.GetVirtualAddress());
	}

	internal static ClrHeader ReadClrHeader(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[14];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetVirtualAddress());
		if (num == -1L || !class5_0.IsValidOffset(num))
		{
			return null;
		}
		if (!class5_0.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			return null;
		}
		RecoveredRuntime.SeekReader(class5_0, num);
		ClrHeader class2 = new ClrHeader(class5_0);
		if (class2.GetHeaderSize() < 72u)
		{
			return null;
		}
		return class2;
	}

	internal static void WritePeImage(Stream stream_0, PeImage class154_0)
	{
		WritePeImage(stream_0, new PeImageWriter(class154_0));
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
			using (PeImage module = LoadPeImageFromFile(PeImageLayout.const_0, sourcePath))
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

	internal static void SaveSettingsFromForm(SettingsForm gform2_0)
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
		ApplicationSettings.Save();
	}

	internal static void WriteDosHeaderPeOffset(PeImageWriter class165_0)
	{
		class165_0.stream_0.Position = 60L;
		class165_0.binaryWriter_0.Write(class165_0.class154_0.GetDosHeader().GetPeHeaderOffset());
	}

	internal static void AddModuleToGrid(bool bool_0, ModuleEntry class16_0, bool bool_1, MainForm mainForm, string string_0)
	{
		if (!File.Exists(string_0))
		{
			return;
		}
		try
		{
			string_0 = Path.GetFullPath(string_0);
			foreach (DataGridViewRow row in mainForm.moduleGrid.Rows)
			{
				MainForm.ModuleRow existing = row.Tag as MainForm.ModuleRow;
				if (existing != null && GetModulePath(existing).Equals(string_0, StringComparison.OrdinalIgnoreCase))
				{
					return;
				}
			}

			using (FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read))
			using (PeImage image = PeImportReader.ReadImports(fileStream, string_0, bool_0: false, PeImageLayout.const_0))
			{
				if (image == null || (image.GetHeaders().GetCoffHeader().GetCharacteristics() & CoffCharacteristics.flag_12) == 0)
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

			int index = mainForm.moduleGrid.Rows.Add(bool_0, Path.GetFileName(string_0));
			MainForm.ModuleRow moduleRow = new MainForm.ModuleRow(class16_0);
			SetModulePath(moduleRow, string_0);
			mainForm.moduleGrid.Rows[index].Tag = moduleRow;
			mainForm.moduleGrid.Rows[index].Cells[1].ToolTipText = string_0;
			mainForm.moduleGrid.Rows[index].Cells[2].ToolTipText = UiText.Get("Main.AdvancedOptionsTooltip");

			if (class16_0 == null)
			{
				ApplicationSettings.Current.Modules.Add(moduleRow.Entry);
			}
		}
		catch (Exception)
		{
			if (!bool_1)
			{
				return;
			}
			MessageBox.Show(mainForm, UiText.Format("Message.InvalidDll", Path.GetFileName(string_0)), UiText.Get("App.Title"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}

	internal static void HandleLegacyManagedDependency(PeImage class154_0, string string_0, MainForm mainForm)
	{
		if (!string_0.StartsWith(EncodedStringTable.DecodeString(24517), StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		string text = RecoveredRuntime.ResolveImageDependencyPath(class154_0, string_0);
		bool flag = false;
		if (!string.IsNullOrEmpty(text))
		{
			using (FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				try
				{
					PeImage @class = PeImportReader.ReadImports(fileStream, text, false, PeImageLayout.const_0);
					if (@class != null && RecoveredRuntime.Is32BitImage(@class) != RecoveredRuntime.Is32BitImage(class154_0))
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
		if (RecoveredRuntime.ConfirmDependencyInstallation(mainForm, class154_0.GetFileName(), string_0, text, false, EncodedStringTable.DecodeString(24526)))
		{
			DependencyInstallerForm form = new DependencyInstallerForm();
			RecoveredRuntime.ConfigureInstallerDownload(form, EncodedStringTable.DecodeString(24551), null, EncodedStringTable.DecodeString(24624));
			form.ShowDialog();
		}
	}

	internal static string ResolveImageDependencyPath(PeImage class154_0, string string_0)
	{
		DependencySearchFlags @enum = DependencySearchFlags.flag_2;
		if (PlatformInfo.bool_0 && RecoveredRuntime.Is32BitImage(class154_0))
		{
			@enum |= DependencySearchFlags.flag_4;
		}
		return RecoveredRuntime.ResolveDependencyPath(string_0, class154_0.GetFilePath(), Path.GetDirectoryName(class154_0.GetFilePath()), @enum, 0, NativeTypes.intptr_0);
	}

	internal static ExportDirectory ReadExportDirectory(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[0];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetVirtualAddress());
		if (num == -1L || !class5_0.IsValidOffset(num))
		{
			return null;
		}
		if (!class5_0.IsValidOffset(num + (long)((ulong)@class.GetSize())))
		{
			return null;
		}
		RecoveredRuntime.SeekReader(class5_0, num);
		return new ExportDirectory(class5_0, class154_0, @class);
	}

	internal static PeImage LoadPeImageFromBytes(byte[] byte_0, PeImageLayout enum39_0)
	{
		MemoryStream memoryStream = new MemoryStream(byte_0, writable: false);
		return PeImageReader.ReadFullImage(memoryStream, bool_0: true, enum39_0);
	}

	internal static void LocateNativeLoaderHooks(NativeLoaderHooks gclass3_0)
	{
		ProcessModuleInfo gclass = RecoveredRuntime.CaptureProcessModules(gclass3_0.GetRemoteProcess())[EncodedStringTable.DecodeString(8549)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.DecodeString(12731));
		}
		PeSectionHeader gclass2 = RecoveredRuntime.ReadRemoteModuleImage(gclass).GetSections().FirstOrDefault(new Func<PeSectionHeader, bool>(NativeLoaderHooks.Class81._003C_003E9.IsTextSection));
		if (gclass2 == null)
		{
			throw new InvalidOperationException(EncodedStringTable.DecodeString(24645));
		}
		IntPtr intPtr = gclass.GetModuleBase().Add((long)((ulong)gclass2.GetVirtualAddress()));
		byte[] array = gclass3_0.ReadArray<byte>(intPtr, (int)gclass2.GetVirtualSize());
		if (RecoveredRuntime.Is32BitProcess(gclass3_0.GetRemoteProcess()))
		{
			if (!PlatformInfo.bool_10)
			{
				if (!PlatformInfo.bool_9)
				{
					if (PlatformInfo.bool_6)
					{
						int num = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24804), 0);
						if (num == -1)
						{
							num = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24821), 0);
							if (num != -1)
							{
								gclass3_0.SetInsertInvertedFunctionTableAddress(intPtr.Add(num - 11));
								gclass3_0.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num + 29));
							}
						}
						else
						{
							gclass3_0.SetInsertInvertedFunctionTableAddress(intPtr.Add(num - 11));
							if (!PlatformInfo.bool_7)
							{
								gclass3_0.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num + 35));
							}
							else
							{
								gclass3_0.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num + 34));
							}
						}
						num = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24846), 0);
						if (num != -1)
						{
							gclass3_0.SetRemoveInvertedFunctionTableAddress(intPtr.Add(num - 18));
							return;
						}
					}
					else if (PlatformInfo.bool_5)
					{
						int num2 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24859), 0);
						if (num2 != -1)
						{
							gclass3_0.SetInsertInvertedFunctionTableAddress(intPtr.Add(num2));
							gclass3_0.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num2 + 38));
							return;
						}
					}
					else if (!PlatformInfo.bool_1)
					{
						if (PlatformInfo.bool_3 && PlatformInfo.bool_0)
						{
							int num3 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24947), 0);
							if (num3 != -1)
							{
								gclass3_0.SetInsertInvertedFunctionTableAddress(intPtr.Add(num3));
							}
							num3 = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(24909), EncodedStringTable.DecodeString(24930), 0);
							if (num3 != -1)
							{
								gclass3_0.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num3 + 7));
							}
						}
					}
					else
					{
						int num4 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24892), 0);
						if (num4 != -1)
						{
							gclass3_0.SetInsertInvertedFunctionTableAddress(intPtr.Add(num4));
						}
						num4 = RecoveredRuntime.FindMaskedPattern(array, EncodedStringTable.DecodeString(24909), EncodedStringTable.DecodeString(24930), 0);
						if (num4 != -1)
						{
							gclass3_0.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num4 + 7));
							return;
						}
					}
				}
				else
				{
					int num5 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24745), 0);
					if (num5 != -1)
					{
						gclass3_0.SetInsertInvertedFunctionTableAddress(intPtr.Add(num5 - 11));
						gclass3_0.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num5 + 76));
					}
					else if ((num5 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24770), 0)) != -1)
					{
						int num6 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24783), 0);
						if (num6 != -1)
						{
							gclass3_0.SetInsertInvertedFunctionTableAddress(intPtr.Add(num6 - 33));
							gclass3_0.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num5 - 27));
						}
					}
					num5 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24732), 0);
					if (num5 != -1)
					{
						gclass3_0.SetRemoveInvertedFunctionTableAddress(intPtr.Add(num5 - 28));
						return;
					}
				}
			}
			else
			{
				int num7 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24702), 0);
				if (num7 != -1)
				{
					gclass3_0.SetInsertInvertedFunctionTableAddress(intPtr.Add(num7 - 8));
				}
				num7 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24719), 0);
				if (num7 != -1)
				{
					gclass3_0.SetInvertedFunctionTableAddress((IntPtr)BitConverter.ToInt32(array, num7 - 27));
				}
				num7 = RecoveredRuntime.FindAsciiPattern(array, EncodedStringTable.DecodeString(24732), 0);
				if (num7 != -1)
				{
					gclass3_0.SetRemoveInvertedFunctionTableAddress(intPtr.Add(num7 - 28));
					return;
				}
			}
		}
	}

	internal static void DisposeManualMapContext(ManualMapInjector.Class172 class172_0)
	{
		PeImage image = class172_0.GetImage();
		if (image != null)
		{
			image.Dispose();
			class172_0.SetImage(null);
		}

		IntPtr activationContextHandle = class172_0.GetActivationContextHandle();
		if (activationContextHandle != NativeTypes.intptr_0)
		{
			RecoveredRuntime.ReleaseActCtx(activationContextHandle);
			class172_0.SetActivationContextHandle(NativeTypes.intptr_0);
		}
	}

	internal static void NormalizeSectionVirtualSizes(PeScrambler gclass4_0)
	{
		List<PeSectionHeader> sections = gclass4_0.class154_0.GetSections();
		uint sectionAlignment = gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetSectionAlignment();
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

	internal static void ScramblePeHeaderFields(PeScrambler gclass4_0)
	{
		RecoveredRuntime.FillImageRangeWithRandomBytes(gclass4_0, 2L, 58L);
		gclass4_0.class154_0.GetHeaders().GetCoffHeader().SetPointerToSymbolTable(gclass4_0.random_0.NextUInt32());
		gclass4_0.class154_0.GetHeaders().GetCoffHeader().SetNumberOfSymbols(gclass4_0.random_0.NextUInt32());
		CoffHeader @class = gclass4_0.class154_0.GetHeaders().GetCoffHeader();
		@class.SetCharacteristics(@class.GetCharacteristics() | (CoffCharacteristics.flag_4 | CoffCharacteristics.flag_6 | CoffCharacteristics.flag_14));
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetMajorLinkerVersion(0);
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetMinorLinkerVersion(0);
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetMajorImageVersion(gclass4_0.random_0.NextUInt16());
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetMinorImageVersion(gclass4_0.random_0.NextUInt16());
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetSizeOfCode(gclass4_0.random_0.NextUInt32());
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetSizeOfInitializedData(gclass4_0.random_0.NextUInt32());
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetSizeOfUninitializedData(gclass4_0.random_0.NextUInt32());
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetBaseOfCode(gclass4_0.random_0.NextUInt32());
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetBaseOfData(gclass4_0.random_0.NextUInt32());
		gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetLoaderFlags(gclass4_0.random_0.NextUInt32());
		gclass4_0.class154_0.GetHeaders().GetCoffHeader().SetTimeDateStamp(gclass4_0.random_0.NextUInt32());
		if ((gclass4_0.class154_0.GetHeaders().GetCoffHeader().GetCharacteristics() & CoffCharacteristics.flag_12) == CoffCharacteristics.flag_12)
		{
			gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetSizeOfStackCommit((ulong)gclass4_0.random_0.NextUInt32());
			gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetSizeOfStackReserve((ulong)gclass4_0.random_0.NextUInt32());
			gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetSizeOfHeapCommit((ulong)gclass4_0.random_0.NextUInt32());
			gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetSizeOfHeapReserve((ulong)gclass4_0.random_0.NextUInt32());
		}
		if (RecoveredRuntime.CanScrambleDataDirectoryCount(gclass4_0))
		{
			if (RecoveredRuntime.Is32BitImage(gclass4_0.class154_0) && gclass4_0.class154_0.GetHeaders().GetCoffHeader().GetSizeOfOptionalHeader() == 224)
			{
				gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetNumberOfRvaAndSizes(gclass4_0.random_0.NextUInt32(10u, 17u));
			}
			else if (!RecoveredRuntime.Is32BitImage(gclass4_0.class154_0) && gclass4_0.class154_0.GetHeaders().GetCoffHeader().GetSizeOfOptionalHeader() == 240)
			{
				gclass4_0.class154_0.GetHeaders().GetOptionalHeader().SetNumberOfRvaAndSizes(15u);
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
		for (int i = 0; i < gclass4_0.random_0.Next(1, array.Length); i++)
		{
			uint num = array[gclass4_0.random_0.Next(array.Length)];
			if ((gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDllCharacteristics() & (DllCharacteristics)num) != (DllCharacteristics)num)
			{
				IPeOptionalHeader @interface = gclass4_0.class154_0.GetHeaders().GetOptionalHeader();
				@interface.SetDllCharacteristics(@interface.GetDllCharacteristics() | (DllCharacteristics)num);
			}
			else
			{
				i--;
			}
		}
	}

	internal static ResourceDirectory ReadResourceDirectory(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[2];
		if (@class.GetVirtualAddress() == 0u || @class.GetSize() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetVirtualAddress());
		if (num == -1L || !class5_0.IsValidOffset(num))
		{
			return null;
		}
		if (!class5_0.IsValidOffset(num))
		{
			return null;
		}
		return new ResourceDirectory(class5_0, num, @class.GetSize());
	}

	internal static bool TryReadPe64OptionalHeader(BoundsCheckedBinaryReader class5_0, uint uint_0, out Pe64OptionalHeader class163_0)
	{
		class163_0 = null;
		const uint fixedHeaderSize = 112;
		long start = class5_0.BaseStream.Position;
		if (uint_0 < fixedHeaderSize || start < 0 || start + uint_0 > class5_0.BaseStream.Length)
		{
			return false;
		}

		var header = new Pe64OptionalHeader();
		header.SetMagic(class5_0.ReadUInt16());
		if (header.GetMagic() != 0x020B)
		{
			return false;
		}

		header.SetMajorLinkerVersion(class5_0.ReadByte());
		header.SetMinorLinkerVersion(class5_0.ReadByte());
		header.SetSizeOfCode(class5_0.ReadUInt32());
		header.SetSizeOfInitializedData(class5_0.ReadUInt32());
		header.SetSizeOfUninitializedData(class5_0.ReadUInt32());
		header.SetAddressOfEntryPoint(class5_0.ReadUInt32());
		header.SetBaseOfCode(class5_0.ReadUInt32());
		header.SetImageBase(class5_0.ReadUInt64());
		header.SetSectionAlignment(class5_0.ReadUInt32());
		header.SetFileAlignment(class5_0.ReadUInt32());
		header.SetMajorOperatingSystemVersion(class5_0.ReadUInt16());
		header.SetMinorOperatingSystemVersion(class5_0.ReadUInt16());
		header.SetMajorImageVersion(class5_0.ReadUInt16());
		header.SetMinorImageVersion(class5_0.ReadUInt16());
		header.SetMajorSubsystemVersion(class5_0.ReadUInt16());
		header.SetMinorSubsystemVersion(class5_0.ReadUInt16());
		header.SetWin32VersionValue(class5_0.ReadUInt32());
		header.SetSizeOfImage(class5_0.ReadUInt32());
		header.SetSizeOfHeaders(class5_0.ReadUInt32());
		header.SetChecksum(class5_0.ReadUInt32());
		header.SetSubsystem((Subsystem)class5_0.ReadUInt16());
		header.SetDllCharacteristics((DllCharacteristics)class5_0.ReadUInt16());
		header.SetSizeOfStackReserve(class5_0.ReadUInt64());
		header.SetSizeOfStackCommit(class5_0.ReadUInt64());
		header.SetSizeOfHeapReserve(class5_0.ReadUInt64());
		header.SetSizeOfHeapCommit(class5_0.ReadUInt64());
		header.SetLoaderFlags(class5_0.ReadUInt32());
		header.SetNumberOfRvaAndSizes(class5_0.ReadUInt32());

		DataDirectory[] directories = header.GetDataDirectories();
		uint availableDirectoryCount = (uint_0 - fixedHeaderSize) / 8U;
		int directoryCount = (int)Math.Min((uint)directories.Length, Math.Min(header.GetNumberOfRvaAndSizes(), availableDirectoryCount));
		for (int index = 0; index < directories.Length; index++)
		{
			directories[index] = index < directoryCount ? new DataDirectory(class5_0) : new DataDirectory();
		}

		class5_0.BaseStream.Position = start + uint_0;
		class163_0 = header;
		return true;
	}

	internal static IEnumerable<string> EnumerateImportedSymbolNames(string string_0, IEnumerable<ImportedSymbol> ienumerable_0, ImportDirectory class148_0)
	{
		return new ImportDirectory.Class150(-2)
		{
			string_2 = string_0,
			ienumerable_1 = ienumerable_0
		};
	}

	internal static void RemoveDebugDirectory(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.GetDebugDirectory() == null)
		{
			return;
		}
		long num = RecoveredRuntime.MapRvaToFileOffset(gclass4_0.class154_0, gclass4_0.class154_0.GetDebugDirectory().GetAddressOfRawData());
		if (num == -1L)
		{
			return;
		}
		RecoveredRuntime.FillImageRangeWithRandomBytes(gclass4_0, num, (long)((ulong)gclass4_0.class154_0.GetDebugDirectory().GetSizeOfData()));
		DataDirectory @class = gclass4_0.class154_0.GetHeaders().GetOptionalHeader().GetDataDirectories()[6];
		long long_ = RecoveredRuntime.MapRvaToFileOffset(gclass4_0.class154_0, @class.GetVirtualAddress());
		RecoveredRuntime.FillImageRangeWithRandomBytes(gclass4_0, long_, 28L);
		@class.SetVirtualAddress(0u);
		@class.SetSize(0u);
	}

	internal static void ApplySectionRemap(List<PeScrambler.Class132> list_0, PeScrambler gclass4_0)
	{
		IPeOptionalHeader @interface = gclass4_0.class154_0.GetHeaders().GetOptionalHeader();
		if (@interface.GetBaseOfCode() != 0u)
		{
			@interface.SetBaseOfCode(RecoveredRuntime.RemapRva(list_0, @interface.GetBaseOfCode()));
		}
		if (@interface.GetBaseOfData() != 0u)
		{
			@interface.SetBaseOfData(RecoveredRuntime.RemapRva(list_0, @interface.GetBaseOfData()));
		}
		if (@interface.GetAddressOfEntryPoint() != 0u)
		{
			@interface.SetAddressOfEntryPoint(RecoveredRuntime.RemapRva(list_0, @interface.GetAddressOfEntryPoint()));
		}
		PeScrambler.Class132 @class = list_0.Last<PeScrambler.Class132>();
		IPeOptionalHeader interface2 = @interface;
		uint uint_ = @class.GetModifiedSection().GetVirtualAddress() + @class.GetModifiedSection().GetVirtualSize();
		uint uint_2 = @interface.GetSectionAlignment();
		interface2.SetSizeOfImage(RecoveredRuntime.AlignUp(uint_2, uint_));
		foreach (DataDirectory class2 in @interface.GetDataDirectories())
		{
			if (class2.GetVirtualAddress() != 0u)
			{
				class2.SetVirtualAddress(RecoveredRuntime.RemapRva(list_0, class2.GetVirtualAddress()));
			}
		}
		gclass4_0.class154_0.GetStream().SetLength((long)((ulong)(@class.GetModifiedSection().GetPointerToRawData() + @class.GetModifiedSection().GetSizeOfRawData())));
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.GetStream());
		for (int j = list_0.Count - 1; j >= 0; j--)
		{
			PeScrambler.Class132 class3 = list_0[j];
			if (class3.GetOriginalSection().GetSizeOfRawData() != 0u)
			{
				PeImage class154_ = gclass4_0.class154_0;
				long long_ = (long)((ulong)class3.GetOriginalSection().GetPointerToRawData());
				long long_2 = (long)((ulong)class3.GetOriginalSection().GetSizeOfRawData());
				byte[] buffer = RecoveredRuntime.ReadImageBytes(long_2, class154_, long_);
				gclass4_0.class154_0.GetStream().Position = (long)((ulong)class3.GetOriginalSection().GetPointerToRawData());
				byte[] buffer2 = new byte[class3.GetOriginalSection().GetSizeOfRawData()];
				gclass4_0.random_0.NextBytes(buffer2);
				binaryWriter.Write(buffer2);
				gclass4_0.class154_0.GetStream().Position = (long)((ulong)(class3.GetModifiedSection().GetPointerToRawData() + class3.GetContentOffset()));
				binaryWriter.Write(buffer);
			}
		}
		gclass4_0.class154_0.SetSections(list_0.Select(new Func<PeScrambler.Class132, PeSectionHeader>(PeScrambler.Class135._003C_003E9.GetModifiedSection)).ToList<PeSectionHeader>());
	}
}
