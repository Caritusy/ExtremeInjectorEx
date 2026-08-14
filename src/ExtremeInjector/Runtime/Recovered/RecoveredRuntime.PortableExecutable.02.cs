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

	internal static void smethod_284(PeScrambler gclass4_0, PeSectionHeader gclass5_0)
	{
		gclass5_0.method_19((SectionCharacteristics)3758096384u);
		gclass4_0.class154_0.method_28().Position = (long)((ulong)gclass5_0.method_8());
		long position = gclass4_0.class154_0.method_28().Position;
		gclass4_0.binaryWriter_0.Write(233);
		gclass4_0.binaryWriter_0.Write(0);
		int num = gclass4_0.random_0.Next((int)(gclass5_0.method_2() / 50u), (int)(gclass5_0.method_2() / 25u));
		byte[] buffer = new byte[num];
		gclass4_0.random_0.NextBytes(buffer);
		gclass4_0.binaryWriter_0.Write(buffer);
		int num2 = -1;
		for (int i = 0; i < gclass4_0.random_0.Next((int)(gclass5_0.method_2() / 10u), (int)(gclass5_0.method_2() / 8u)); i++)
		{
			int num3 = PeScrambler.smethod_0<int>(num2, () => gclass4_0.random_0.Next(53));
			while (num2 != -1 && ((num3 >= 15 && num3 <= 30) || (num3 >= 39 && num3 <= 45)) && num2 >= 15 && num2 <= 30)
			{
				num3 = gclass4_0.random_0.Next(53);
			}
			if (num2 >= 39 && num2 <= 45)
			{
				num3 = gclass4_0.random_0.Next(15, 31);
			}
			long position2 = gclass4_0.class154_0.method_28().Position;
			switch (num3)
			{
			case 0:
				gclass4_0.binaryWriter_0.Write(144);
				break;
			case 1:
				gclass4_0.binaryWriter_0.Write(184);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 2:
				gclass4_0.binaryWriter_0.Write(185);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 3:
				gclass4_0.binaryWriter_0.Write(186);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 4:
				gclass4_0.binaryWriter_0.Write(187);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 5:
				gclass4_0.binaryWriter_0.Write(189);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 6:
				gclass4_0.binaryWriter_0.Write(190);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 7:
				gclass4_0.binaryWriter_0.Write(191);
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
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
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 47:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					193
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 48:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					194
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 49:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					195
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 50:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					197
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 51:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					198
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			case 52:
				gclass4_0.binaryWriter_0.Write(new byte[]
				{
					129,
					199
				});
				gclass4_0.binaryWriter_0.Write(gclass4_0.random_0.smethod_0());
				break;
			}
			long num4 = gclass4_0.class154_0.method_28().Position - position2;
			if (num2 >= 15 && num2 <= 30)
			{
				gclass4_0.class154_0.method_28().Position -= num4 + 1L;
				gclass4_0.binaryWriter_0.Write((byte)num4);
				gclass4_0.class154_0.method_28().Position += num4;
			}
			num2 = num3;
		}
		gclass4_0.binaryWriter_0.Write(233);
		int num5 = (int)(gclass4_0.class154_0.method_28().Position - position - 30L);
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
			uint num7 = gclass4_0.random_0.smethod_0();
			gclass4_0.binaryWriter_0.Write(184);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(61);
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0<uint>(num7, () => gclass4_0.random_0.smethod_0()) : num7);
			break;
		}
		case 1:
		{
			uint num7 = gclass4_0.random_0.smethod_0();
			gclass4_0.binaryWriter_0.Write(185);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				249
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0<uint>(num7, () => gclass4_0.random_0.smethod_0()) : num7);
			break;
		}
		case 2:
		{
			uint num7 = gclass4_0.random_0.smethod_0();
			gclass4_0.binaryWriter_0.Write(186);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				250
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0<uint>(num7, () => gclass4_0.random_0.smethod_0()) : num7);
			break;
		}
		case 3:
		{
			uint num7 = gclass4_0.random_0.smethod_0();
			gclass4_0.binaryWriter_0.Write(187);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				251
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0<uint>(num7, () => gclass4_0.random_0.smethod_0()) : num7);
			break;
		}
		case 4:
		{
			uint num7 = gclass4_0.random_0.smethod_0();
			gclass4_0.binaryWriter_0.Write(189);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				253
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0<uint>(num7, () => gclass4_0.random_0.smethod_0()) : num7);
			break;
		}
		case 5:
		{
			uint num7 = gclass4_0.random_0.smethod_0();
			gclass4_0.binaryWriter_0.Write(190);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				254
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0<uint>(num7, () => gclass4_0.random_0.smethod_0()) : num7);
			break;
		}
		case 6:
		{
			uint num7 = gclass4_0.random_0.smethod_0();
			gclass4_0.binaryWriter_0.Write(191);
			gclass4_0.binaryWriter_0.Write(num7);
			gclass4_0.binaryWriter_0.Write(new byte[]
			{
				129,
				byte.MaxValue
			});
			gclass4_0.binaryWriter_0.Write(flag ? PeScrambler.smethod_0<uint>(num7, () => gclass4_0.random_0.smethod_0()) : num7);
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
		int num8 = (int)(gclass4_0.class154_0.method_28().Position - position);
		gclass4_0.binaryWriter_0.Write(233);
		gclass4_0.binaryWriter_0.Write((int)((ulong)(gclass4_0.class154_0.method_6().method_3().imethod_11() - gclass5_0.method_4() - 5u) - (ulong)((long)num8)));
		num5 = (int)((ulong)gclass5_0.method_2() - (ulong)(gclass4_0.class154_0.method_28().Position - position) - 30UL);
		num6 = ((num5 < 0) ? 0 : gclass4_0.random_0.Next(1, num5));
		buffer = new byte[num6];
		gclass4_0.random_0.NextBytes(buffer);
		gclass4_0.binaryWriter_0.Write(buffer);
		long num9 = gclass4_0.class154_0.method_28().Position - (long)((ulong)gclass5_0.method_8());
		int num10 = gclass4_0.random_0.Next(18, (int)((ulong)gclass5_0.method_2() - (ulong)num9 + 18UL));
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
			gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0<byte>(96, new PeScrambler.Delegate48<byte>(RecoveredRuntime.smethod_166)));
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
			gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0<byte>(96, new PeScrambler.Delegate48<byte>(RecoveredRuntime.smethod_166)));
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
			gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0<byte>(96, new PeScrambler.Delegate48<byte>(RecoveredRuntime.smethod_166)));
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
			gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0<byte>(96, new PeScrambler.Delegate48<byte>(RecoveredRuntime.smethod_166)));
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
			gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0<byte>(96, new PeScrambler.Delegate48<byte>(RecoveredRuntime.smethod_166)));
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
		num8 = (int)(gclass4_0.class154_0.method_28().Position - position);
		gclass4_0.binaryWriter_0.Write(PeScrambler.smethod_0<byte>(233, new PeScrambler.Delegate48<byte>(RecoveredRuntime.smethod_166)));
		gclass4_0.binaryWriter_0.Write((int)((ulong)(gclass5_0.method_4() + 5u) + (ulong)((long)num) - ((ulong)gclass5_0.method_4() + (ulong)((long)num8) + 5UL)));
		gclass4_0.class154_0.method_28().Position += (long)(num10 - 18);
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
		gclass4_0.class154_0.method_28().Position = position + 1L;
		gclass4_0.binaryWriter_0.Write(num8 - 23);
		gclass4_0.class154_0.method_6().method_3().imethod_12(gclass5_0.method_4());
	}

	internal static DelayImportDirectory smethod_293(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[13];
		if (@class.method_0() == 0u || @class.method_2() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
		if (num == -1L || !class5_0.imethod_0(num))
		{
			return null;
		}
		if (class5_0.imethod_0(num + (long)((ulong)@class.method_2())))
		{
			RecoveredRuntime.smethod_157(class5_0, num);
			return new DelayImportDirectory(class5_0, class154_0);
		}
		return null;
	}

	internal static void smethod_299(string string_0, PeImage class154_0)
	{
		using (FileStream fileStream = File.OpenWrite(string_0))
		{
			fileStream.SetLength(0L);
			RecoveredRuntime.smethod_315(fileStream, class154_0);
		}
	}

	internal static ExceptionDirectory smethod_303(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[3];
		if (@class.method_0() == 0u || @class.method_2() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
		if (num == -1L || !class5_0.imethod_0(num))
		{
			return null;
		}
		if (class5_0.imethod_0(num + (long)((ulong)@class.method_2())))
		{
			RecoveredRuntime.smethod_157(class5_0, num);
			return new ExceptionDirectory(class5_0, @class);
		}
		return null;
	}

	internal static void smethod_304(PeScrambler gclass4_0, PeSectionHeader gclass5_0)
	{
		DataDirectory @class = gclass4_0.class154_0.method_6().method_3().imethod_49()[5];
		long num = RecoveredRuntime.smethod_135(gclass4_0.class154_0, @class.method_0());
		if (num == -1L)
		{
			return;
		}
		if (gclass5_0.method_2() < @class.method_2())
		{
			gclass5_0.method_3(@class.method_2());
		}
		if (gclass5_0.method_6() < @class.method_2())
		{
			return;
		}
		byte[] buffer;
		using (Stream stream = RecoveredRuntime.smethod_264(gclass4_0.class154_0, num, (int)@class.method_2()))
		{
			using (BinaryReader binaryReader = new BinaryReader(stream))
			{
				buffer = binaryReader.ReadBytes((int)@class.method_2());
			}
		}
		RecoveredRuntime.smethod_437(gclass4_0, num, (long)((ulong)@class.method_2()));
		gclass4_0.class154_0.method_28().Position = (long)((ulong)gclass5_0.method_8());
		gclass4_0.binaryWriter_0.Write(buffer);
		@class.method_1(gclass5_0.method_4());
	}

	internal static ClrHeader smethod_312(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[14];
		if (@class.method_0() == 0u || @class.method_2() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
		if (num == -1L || !class5_0.imethod_0(num))
		{
			return null;
		}
		if (!class5_0.imethod_0(num + (long)((ulong)@class.method_2())))
		{
			return null;
		}
		RecoveredRuntime.smethod_157(class5_0, num);
		ClrHeader class2 = new ClrHeader(class5_0);
		if (class2.method_0() < 72u)
		{
			return null;
		}
		return class2;
	}

	internal static void smethod_315(Stream stream_0, PeImage class154_0)
	{
		smethod_76(stream_0, new PeImageWriter(class154_0));
	}

	internal static void ScrambleModule(string sourcePath, string destinationPath)
	{
		InjectorScrambleOptions options = ApplicationSettings.Current.Options.Scramble;
		PeScrambleOptions transformOptions = new PeScrambleOptions();
		transformOptions.method_21(options.CreateNewEntryPoint);
		transformOptions.method_3(options.InsertExtraSections);
		transformOptions.method_11(options.ModifyAssemblyCode);
		transformOptions.method_1(options.ScrambleHeaderFields);
		transformOptions.method_19(options.ModifyImportTable);
		transformOptions.method_17(options.RenameSections);
		transformOptions.method_15(options.MoveRelocationTable);
		transformOptions.method_5(options.RemoveDebugData);
		transformOptions.method_9(options.ShiftSectionData);
		transformOptions.method_13(options.RemoveUselessData);
		transformOptions.method_7(options.CreateFakeDebugDirectory);
		transformOptions.method_24(options.ShiftSectionMemory);
		transformOptions.method_26(options.StripSectionCharacteristics);

		try
		{
			using (PeImage module = smethod_81(PeImageLayout.const_0, sourcePath))
			using (PeScrambler scrambler = new PeScrambler(module, transformOptions))
			{
				smethod_95(scrambler);
				smethod_367(destinationPath, scrambler);
			}
		}
		catch
		{
			File.Copy(sourcePath, destinationPath, overwrite: true);
		}
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
		ApplicationSettings.Save();
	}

	internal static void smethod_333(PeImageWriter class165_0)
	{
		class165_0.stream_0.Position = 60L;
		class165_0.binaryWriter_0.Write(class165_0.class154_0.method_4().method_0());
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
			using (PeImage image = PeImportReader.smethod_13(fileStream, string_0, bool_0: false, PeImageLayout.const_0))
			{
				if (image == null || (image.method_6().method_1().method_12() & CoffCharacteristics.flag_12) == 0)
				{
					throw new Exception();
				}

				try
				{
					smethod_261(image, mainForm);
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

	internal static void smethod_351(PeImage class154_0, string string_0, MainForm mainForm)
	{
		if (!string_0.StartsWith(EncodedStringTable.smethod_0(24517), StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		string text = RecoveredRuntime.smethod_353(class154_0, string_0);
		bool flag = false;
		if (!string.IsNullOrEmpty(text))
		{
			using (FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				try
				{
					PeImage @class = PeImportReader.smethod_13(fileStream, text, false, PeImageLayout.const_0);
					if (@class != null && RecoveredRuntime.smethod_19(@class) != RecoveredRuntime.smethod_19(class154_0))
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
		if (RecoveredRuntime.smethod_337(mainForm, class154_0.method_2(), string_0, text, false, EncodedStringTable.smethod_0(24526)))
		{
			DependencyInstallerForm form = new DependencyInstallerForm();
			RecoveredRuntime.smethod_29(form, EncodedStringTable.smethod_0(24551), null, EncodedStringTable.smethod_0(24624));
			form.ShowDialog();
		}
	}

	internal static string smethod_353(PeImage class154_0, string string_0)
	{
		DependencySearchFlags @enum = DependencySearchFlags.flag_2;
		if (PlatformInfo.bool_0 && RecoveredRuntime.smethod_19(class154_0))
		{
			@enum |= DependencySearchFlags.flag_4;
		}
		return RecoveredRuntime.smethod_440(string_0, class154_0.method_0(), Path.GetDirectoryName(class154_0.method_0()), @enum, 0, NativeTypes.intptr_0);
	}

	internal static ExportDirectory smethod_355(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[0];
		if (@class.method_0() == 0u || @class.method_2() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
		if (num == -1L || !class5_0.imethod_0(num))
		{
			return null;
		}
		if (!class5_0.imethod_0(num + (long)((ulong)@class.method_2())))
		{
			return null;
		}
		RecoveredRuntime.smethod_157(class5_0, num);
		return new ExportDirectory(class5_0, class154_0, @class);
	}

	internal static PeImage smethod_356(byte[] byte_0, PeImageLayout enum39_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(byte_0, 0, byte_0.Length);
		memoryStream.Position = 0L;
		return PeImageReader.smethod_4(memoryStream, bool_0: true, enum39_0);
	}

	internal static void smethod_357(NativeLoaderHooks gclass3_0)
	{
		ProcessModuleInfo gclass = RecoveredRuntime.smethod_42(gclass3_0.method_19())[EncodedStringTable.smethod_0(8549)];
		if (gclass == null)
		{
			throw new FileNotFoundException(EncodedStringTable.smethod_0(12731));
		}
		PeSectionHeader gclass2 = RecoveredRuntime.smethod_215(gclass).method_8().FirstOrDefault(new Func<PeSectionHeader, bool>(NativeLoaderHooks.Class81._003C_003E9.method_0));
		if (gclass2 == null)
		{
			throw new InvalidOperationException(EncodedStringTable.smethod_0(24645));
		}
		IntPtr intPtr = gclass.method_0().smethod_9((long)((ulong)gclass2.method_4()));
		byte[] array = gclass3_0.method_10<byte>(intPtr, (int)gclass2.method_2());
		if (RecoveredRuntime.smethod_427(gclass3_0.method_19()))
		{
			if (!PlatformInfo.bool_10)
			{
				if (!PlatformInfo.bool_9)
				{
					if (PlatformInfo.bool_6)
					{
						int num = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24804), 0);
						if (num == -1)
						{
							num = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24821), 0);
							if (num != -1)
							{
								gclass3_0.method_25(intPtr.smethod_8(num - 11));
								gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num + 29));
							}
						}
						else
						{
							gclass3_0.method_25(intPtr.smethod_8(num - 11));
							if (!PlatformInfo.bool_7)
							{
								gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num + 35));
							}
							else
							{
								gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num + 34));
							}
						}
						num = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24846), 0);
						if (num != -1)
						{
							gclass3_0.method_29(intPtr.smethod_8(num - 18));
							return;
						}
					}
					else if (PlatformInfo.bool_5)
					{
						int num2 = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24859), 0);
						if (num2 != -1)
						{
							gclass3_0.method_25(intPtr.smethod_8(num2));
							gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num2 + 38));
							return;
						}
					}
					else if (!PlatformInfo.bool_1)
					{
						if (PlatformInfo.bool_3 && PlatformInfo.bool_0)
						{
							int num3 = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24947), 0);
							if (num3 != -1)
							{
								gclass3_0.method_25(intPtr.smethod_8(num3));
							}
							num3 = RecoveredRuntime.smethod_419(array, EncodedStringTable.smethod_0(24909), EncodedStringTable.smethod_0(24930), 0);
							if (num3 != -1)
							{
								gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num3 + 7));
							}
						}
					}
					else
					{
						int num4 = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24892), 0);
						if (num4 != -1)
						{
							gclass3_0.method_25(intPtr.smethod_8(num4));
						}
						num4 = RecoveredRuntime.smethod_419(array, EncodedStringTable.smethod_0(24909), EncodedStringTable.smethod_0(24930), 0);
						if (num4 != -1)
						{
							gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num4 + 7));
							return;
						}
					}
				}
				else
				{
					int num5 = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24745), 0);
					if (num5 != -1)
					{
						gclass3_0.method_25(intPtr.smethod_8(num5 - 11));
						gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num5 + 76));
					}
					else if ((num5 = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24770), 0)) != -1)
					{
						int num6 = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24783), 0);
						if (num6 != -1)
						{
							gclass3_0.method_25(intPtr.smethod_8(num6 - 33));
							gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num5 - 27));
						}
					}
					num5 = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24732), 0);
					if (num5 != -1)
					{
						gclass3_0.method_29(intPtr.smethod_8(num5 - 28));
						return;
					}
				}
			}
			else
			{
				int num7 = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24702), 0);
				if (num7 != -1)
				{
					gclass3_0.method_25(intPtr.smethod_8(num7 - 8));
				}
				num7 = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24719), 0);
				if (num7 != -1)
				{
					gclass3_0.method_27((IntPtr)BitConverter.ToInt32(array, num7 - 27));
				}
				num7 = RecoveredRuntime.smethod_378(array, EncodedStringTable.smethod_0(24732), 0);
				if (num7 != -1)
				{
					gclass3_0.method_29(intPtr.smethod_8(num7 - 28));
					return;
				}
			}
		}
	}

	internal static void smethod_368(ManualMapInjector.Class172 class172_0)
	{
		if (class172_0.method_0() != null)
		{
			((IDisposable)class172_0.method_0()).Dispose();
			class172_0.method_1(null);
		}
		if (class172_0.method_10() != NativeTypes.intptr_0)
		{
			RecoveredRuntime.ReleaseActCtx(class172_0.method_10());
			class172_0.method_11(NativeTypes.intptr_0);
		}
	}

	internal static void smethod_376(PeScrambler gclass4_0)
	{
		List<PeSectionHeader> list = gclass4_0.class154_0.method_8();
		for (int i = 0; i < list.Count; i++)
		{
			PeSectionHeader gclass = list[i];
			PeSectionHeader gclass2 = gclass;
			uint uint_ = gclass.method_2();
			uint uint_2 = gclass4_0.class154_0.method_6().method_3().imethod_18();
			gclass2.method_3(RecoveredRuntime.smethod_201(uint_2, uint_));
			if (i < list.Count - 1 && gclass.method_4() + gclass.method_2() > list[i + 1].method_4())
			{
				gclass.method_3(list[i + 1].method_4() - gclass.method_4());
			}
		}
	}

	internal static void smethod_382(PeScrambler gclass4_0)
	{
		RecoveredRuntime.smethod_437(gclass4_0, 2L, 58L);
		gclass4_0.class154_0.method_6().method_1().method_7(gclass4_0.random_0.smethod_0());
		gclass4_0.class154_0.method_6().method_1().method_9(gclass4_0.random_0.smethod_0());
		CoffHeader @class = gclass4_0.class154_0.method_6().method_1();
		@class.method_13(@class.method_12() | (CoffCharacteristics.flag_4 | CoffCharacteristics.flag_6 | CoffCharacteristics.flag_14));
		gclass4_0.class154_0.method_6().method_3().imethod_2(0);
		gclass4_0.class154_0.method_6().method_3().imethod_4(0);
		gclass4_0.class154_0.method_6().method_3().imethod_23(gclass4_0.random_0.smethod_2());
		gclass4_0.class154_0.method_6().method_3().imethod_25(gclass4_0.random_0.smethod_2());
		gclass4_0.class154_0.method_6().method_3().imethod_6(gclass4_0.random_0.smethod_0());
		gclass4_0.class154_0.method_6().method_3().imethod_8(gclass4_0.random_0.smethod_0());
		gclass4_0.class154_0.method_6().method_3().imethod_10(gclass4_0.random_0.smethod_0());
		gclass4_0.class154_0.method_6().method_3().imethod_14(gclass4_0.random_0.smethod_0());
		gclass4_0.class154_0.method_6().method_3().imethod_16(gclass4_0.random_0.smethod_0());
		gclass4_0.class154_0.method_6().method_3().imethod_46(gclass4_0.random_0.smethod_0());
		gclass4_0.class154_0.method_6().method_1().method_5(gclass4_0.random_0.smethod_0());
		if ((gclass4_0.class154_0.method_6().method_1().method_12() & CoffCharacteristics.flag_12) == CoffCharacteristics.flag_12)
		{
			gclass4_0.class154_0.method_6().method_3().imethod_40((ulong)gclass4_0.random_0.smethod_0());
			gclass4_0.class154_0.method_6().method_3().imethod_38((ulong)gclass4_0.random_0.smethod_0());
			gclass4_0.class154_0.method_6().method_3().imethod_44((ulong)gclass4_0.random_0.smethod_0());
			gclass4_0.class154_0.method_6().method_3().imethod_42((ulong)gclass4_0.random_0.smethod_0());
		}
		if (RecoveredRuntime.smethod_235(gclass4_0))
		{
			if (RecoveredRuntime.smethod_19(gclass4_0.class154_0) && gclass4_0.class154_0.method_6().method_1().method_10() == 224)
			{
				gclass4_0.class154_0.method_6().method_3().imethod_48(gclass4_0.random_0.smethod_1(10u, 17u));
			}
			else if (!RecoveredRuntime.smethod_19(gclass4_0.class154_0) && gclass4_0.class154_0.method_6().method_1().method_10() == 240)
			{
				gclass4_0.class154_0.method_6().method_3().imethod_48(15u);
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
			if ((gclass4_0.class154_0.method_6().method_3().imethod_35() & (DllCharacteristics)num) != (DllCharacteristics)num)
			{
				IPeOptionalHeader @interface = gclass4_0.class154_0.method_6().method_3();
				@interface.imethod_36(@interface.imethod_35() | (DllCharacteristics)num);
			}
			else
			{
				i--;
			}
		}
	}

	internal static ResourceDirectory smethod_389(PeImage class154_0, BoundsCheckedBinaryReader class5_0)
	{
		DataDirectory @class = class154_0.method_6().method_3().imethod_49()[2];
		if (@class.method_0() == 0u || @class.method_2() == 0u)
		{
			return null;
		}
		long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
		if (num == -1L || !class5_0.imethod_0(num))
		{
			return null;
		}
		if (!class5_0.imethod_0(num))
		{
			return null;
		}
		return new ResourceDirectory(class5_0, num, @class.method_2());
	}

	internal static bool smethod_398(BoundsCheckedBinaryReader class5_0, uint uint_0, out Pe64OptionalHeader class163_0)
	{
		class163_0 = null;
		const uint fixedHeaderSize = 112;
		long start = class5_0.BaseStream.Position;
		if (uint_0 < fixedHeaderSize || start < 0 || start + uint_0 > class5_0.BaseStream.Length)
		{
			return false;
		}

		var header = new Pe64OptionalHeader();
		header.vmethod_0(class5_0.ReadUInt16());
		if (header.imethod_0() != 0x020B)
		{
			return false;
		}

		header.imethod_2(class5_0.ReadByte());
		header.imethod_4(class5_0.ReadByte());
		header.imethod_6(class5_0.ReadUInt32());
		header.imethod_8(class5_0.ReadUInt32());
		header.imethod_10(class5_0.ReadUInt32());
		header.imethod_12(class5_0.ReadUInt32());
		header.imethod_14(class5_0.ReadUInt32());
		header.vmethod_1(class5_0.ReadUInt64());
		header.vmethod_2(class5_0.ReadUInt32());
		header.vmethod_3(class5_0.ReadUInt32());
		header.vmethod_4(class5_0.ReadUInt16());
		header.vmethod_5(class5_0.ReadUInt16());
		header.imethod_23(class5_0.ReadUInt16());
		header.imethod_25(class5_0.ReadUInt16());
		header.vmethod_6(class5_0.ReadUInt16());
		header.vmethod_7(class5_0.ReadUInt16());
		header.vmethod_8(class5_0.ReadUInt32());
		header.imethod_30(class5_0.ReadUInt32());
		header.vmethod_9(class5_0.ReadUInt32());
		header.imethod_33(class5_0.ReadUInt32());
		header.vmethod_10((Subsystem)class5_0.ReadUInt16());
		header.imethod_36((DllCharacteristics)class5_0.ReadUInt16());
		header.imethod_38(class5_0.ReadUInt64());
		header.imethod_40(class5_0.ReadUInt64());
		header.imethod_42(class5_0.ReadUInt64());
		header.imethod_44(class5_0.ReadUInt64());
		header.imethod_46(class5_0.ReadUInt32());
		header.imethod_48(class5_0.ReadUInt32());

		DataDirectory[] directories = header.imethod_49();
		uint availableDirectoryCount = (uint_0 - fixedHeaderSize) / 8U;
		int directoryCount = (int)Math.Min((uint)directories.Length, Math.Min(header.imethod_47(), availableDirectoryCount));
		for (int index = 0; index < directories.Length; index++)
		{
			directories[index] = index < directoryCount ? new DataDirectory(class5_0) : new DataDirectory();
		}

		class5_0.BaseStream.Position = start + uint_0;
		class163_0 = header;
		return true;
	}

	internal static IEnumerable<string> smethod_412(string string_0, IEnumerable<ImportedSymbol> ienumerable_0, ImportDirectory class148_0)
	{
		return new ImportDirectory.Class150(-2)
		{
			string_2 = string_0,
			ienumerable_1 = ienumerable_0
		};
	}

	internal static void smethod_415(PeScrambler gclass4_0)
	{
		if (gclass4_0.class154_0.method_18() == null)
		{
			return;
		}
		long num = RecoveredRuntime.smethod_135(gclass4_0.class154_0, gclass4_0.class154_0.method_18().method_7());
		if (num == -1L)
		{
			return;
		}
		RecoveredRuntime.smethod_437(gclass4_0, num, (long)((ulong)gclass4_0.class154_0.method_18().method_5()));
		DataDirectory @class = gclass4_0.class154_0.method_6().method_3().imethod_49()[6];
		long long_ = RecoveredRuntime.smethod_135(gclass4_0.class154_0, @class.method_0());
		RecoveredRuntime.smethod_437(gclass4_0, long_, 28L);
		@class.method_1(0u);
		@class.method_3(0u);
	}

	internal static void smethod_420(List<PeScrambler.Class132> list_0, PeScrambler gclass4_0)
	{
		IPeOptionalHeader @interface = gclass4_0.class154_0.method_6().method_3();
		if (@interface.imethod_13() != 0u)
		{
			@interface.imethod_14(RecoveredRuntime.smethod_33(list_0, @interface.imethod_13()));
		}
		if (@interface.imethod_15() != 0u)
		{
			@interface.imethod_16(RecoveredRuntime.smethod_33(list_0, @interface.imethod_15()));
		}
		if (@interface.imethod_11() != 0u)
		{
			@interface.imethod_12(RecoveredRuntime.smethod_33(list_0, @interface.imethod_11()));
		}
		PeScrambler.Class132 @class = list_0.Last<PeScrambler.Class132>();
		IPeOptionalHeader interface2 = @interface;
		uint uint_ = @class.method_3().method_4() + @class.method_3().method_2();
		uint uint_2 = @interface.imethod_18();
		interface2.imethod_30(RecoveredRuntime.smethod_201(uint_2, uint_));
		foreach (DataDirectory class2 in @interface.imethod_49())
		{
			if (class2.method_0() != 0u)
			{
				class2.method_1(RecoveredRuntime.smethod_33(list_0, class2.method_0()));
			}
		}
		gclass4_0.class154_0.method_28().SetLength((long)((ulong)(@class.method_3().method_8() + @class.method_3().method_6())));
		BinaryWriter binaryWriter = new BinaryWriter(gclass4_0.class154_0.method_28());
		for (int j = list_0.Count - 1; j >= 0; j--)
		{
			PeScrambler.Class132 class3 = list_0[j];
			if (class3.method_5().method_6() != 0u)
			{
				PeImage class154_ = gclass4_0.class154_0;
				long long_ = (long)((ulong)class3.method_5().method_8());
				long long_2 = (long)((ulong)class3.method_5().method_6());
				byte[] buffer = RecoveredRuntime.smethod_8(long_2, class154_, long_);
				gclass4_0.class154_0.method_28().Position = (long)((ulong)class3.method_5().method_8());
				byte[] buffer2 = new byte[class3.method_5().method_6()];
				gclass4_0.random_0.NextBytes(buffer2);
				binaryWriter.Write(buffer2);
				gclass4_0.class154_0.method_28().Position = (long)((ulong)(class3.method_3().method_8() + class3.method_0()));
				binaryWriter.Write(buffer);
			}
		}
		gclass4_0.class154_0.method_9(list_0.Select(new Func<PeScrambler.Class132, PeSectionHeader>(PeScrambler.Class135._003C_003E9.method_1)).ToList<PeSectionHeader>());
	}
}
