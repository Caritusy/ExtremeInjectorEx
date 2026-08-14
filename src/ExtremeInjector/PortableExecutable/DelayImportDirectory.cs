using System.Collections.Generic;
using System.IO;

public sealed class DelayImportDirectory : ImportDirectory
{
	internal DelayImportDirectory(BoundsCheckedBinaryReader boundsCheckedBinaryReader, PeImage peImage)
	{
		for (;;)
		{
			bool flag = boundsCheckedBinaryReader.ReadUInt32() != 0u;
			uint uint_ = boundsCheckedBinaryReader.ReadUInt32();
			RecoveredRuntime.SkipBytes(boundsCheckedBinaryReader, 8);
			uint num = boundsCheckedBinaryReader.ReadUInt32();
			num = ((!flag) ? ((uint)((ulong)num - peImage.GetHeaders().GetOptionalHeader().GetImageBase())) : num);
			if (num == 0u)
			{
				break;
			}
			long num2 = RecoveredRuntime.MapRvaToFileOffset(peImage, num);
			long num3 = RecoveredRuntime.MapRvaToFileOffset(peImage, uint_);
			RecoveredRuntime.SkipBytes(boundsCheckedBinaryReader, 12);
			long position = boundsCheckedBinaryReader.BaseStream.Position;
			if (num2 == -1L || num3 == -1L || !boundsCheckedBinaryReader.IsValidOffset(num2) || !boundsCheckedBinaryReader.IsValidOffset(num3))
			{
				break;
			}
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num3);
			string text = RecoveredRuntime.ReadNullTerminatedAsciiString(boundsCheckedBinaryReader);
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num2);
			List<ImportedSymbol> ienumerable_ = RecoveredRuntime.ReadImportedSymbols(boundsCheckedBinaryReader, this, peImage);
			if (this.dictionary.ContainsKey(text))
			{
				this.dictionary[text].AddRange(RecoveredRuntime.EnumerateImportedSymbolNames(text, ienumerable_, this));
			}
			else
			{
				this.dictionary.Add(text, new List<string>(RecoveredRuntime.EnumerateImportedSymbolNames(text, ienumerable_, this)));
			}
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, position);
		}
	}
}
