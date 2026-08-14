using System.Collections.Generic;
using System.IO;

public sealed class DelayImportDirectory : ImportDirectory
{
	internal DelayImportDirectory(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		for (;;)
		{
			bool flag = class5_0.ReadUInt32() != 0u;
			uint uint_ = class5_0.ReadUInt32();
			RecoveredRuntime.smethod_217(class5_0, 8);
			uint num = class5_0.ReadUInt32();
			num = ((!flag) ? ((uint)((ulong)num - class154_0.method_6().method_3().imethod_17())) : num);
			if (num == 0u)
			{
				break;
			}
			long num2 = RecoveredRuntime.smethod_135(class154_0, num);
			long num3 = RecoveredRuntime.smethod_135(class154_0, uint_);
			RecoveredRuntime.smethod_217(class5_0, 12);
			long position = class5_0.BaseStream.Position;
			if (num2 == -1L || num3 == -1L || !class5_0.imethod_0(num2) || !class5_0.imethod_0(num3))
			{
				break;
			}
			RecoveredRuntime.smethod_157(class5_0, num3);
			string text = RecoveredRuntime.smethod_404(class5_0);
			RecoveredRuntime.smethod_157(class5_0, num2);
			List<ImportedSymbol> ienumerable_ = RecoveredRuntime.smethod_162(class5_0, this, class154_0);
			if (this.gclass0_0.imethod_6(text))
			{
				this.gclass0_0[text].AddRange(RecoveredRuntime.smethod_412(text, ienumerable_, this));
			}
			else
			{
				this.gclass0_0.imethod_0(text, new List<string>(RecoveredRuntime.smethod_412(text, ienumerable_, this)));
			}
			RecoveredRuntime.smethod_157(class5_0, position);
		}
	}

	internal static uint smethod_4(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static Stream smethod_5(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static long smethod_6(Stream stream_0)
	{
		return stream_0.Position;
	}
}
