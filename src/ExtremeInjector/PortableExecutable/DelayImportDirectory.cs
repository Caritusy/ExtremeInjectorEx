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
			RecoveredRuntime.SkipBytes(class5_0, 8);
			uint num = class5_0.ReadUInt32();
			num = ((!flag) ? ((uint)((ulong)num - class154_0.GetHeaders().GetOptionalHeader().GetImageBase())) : num);
			if (num == 0u)
			{
				break;
			}
			long num2 = RecoveredRuntime.MapRvaToFileOffset(class154_0, num);
			long num3 = RecoveredRuntime.MapRvaToFileOffset(class154_0, uint_);
			RecoveredRuntime.SkipBytes(class5_0, 12);
			long position = class5_0.BaseStream.Position;
			if (num2 == -1L || num3 == -1L || !class5_0.IsValidOffset(num2) || !class5_0.IsValidOffset(num3))
			{
				break;
			}
			RecoveredRuntime.SeekReader(class5_0, num3);
			string text = RecoveredRuntime.ReadNullTerminatedAsciiString(class5_0);
			RecoveredRuntime.SeekReader(class5_0, num2);
			List<ImportedSymbol> ienumerable_ = RecoveredRuntime.ReadImportedSymbols(class5_0, this, class154_0);
			if (this.gclass0_0.ContainsKey(text))
			{
				this.gclass0_0[text].AddRange(RecoveredRuntime.EnumerateImportedSymbolNames(text, ienumerable_, this));
			}
			else
			{
				this.gclass0_0.Add(text, new List<string>(RecoveredRuntime.EnumerateImportedSymbolNames(text, ienumerable_, this)));
			}
			RecoveredRuntime.SeekReader(class5_0, position);
		}
	}
}
