using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

public class ImportDirectory
{
	[CompilerGenerated]
	public sealed class ImportedNameIterator : IEnumerable<string>, IEnumerator<string>, IDisposable, IEnumerator, IEnumerable
	{
		internal int intValue;

		internal string text;

		internal int intValue2;

		internal IEnumerable<ImportedSymbol> items;

		public IEnumerable<ImportedSymbol> items2;

		internal string text2;

		public string text3;

		internal ImportedSymbol importedSymbol;

		internal IEnumerator<ImportedSymbol> enumerator;

		string IEnumerator<string>.Current => text;

		object IEnumerator.Current => text;

		public ImportedNameIterator(int intValue3)
		{
			this.intValue = intValue3;
			this.intValue2 = Thread.CurrentThread.ManagedThreadId;
		}

		void IDisposable.Dispose()
		{
			int num = this.intValue;
			if (num != -3 && num != 1)
			{
				if (num != 2)
				{
					return;
				}
			}
			try
			{
			}
			finally
			{
				RecoveredRuntime.DisposeImportNameIterator(this);
			}
		}

		bool IEnumerator.MoveNext()
		{
			bool result;
			try
			{
				switch (this.intValue)
				{
				case 0:
					this.intValue = -1;
					this.enumerator = this.items.GetEnumerator();
					this.intValue = -3;
					break;
				case 1:
				case 2:
					this.intValue = -3;
					this.importedSymbol = null;
					break;
				default:
					return false;
				}
				if (this.enumerator.MoveNext())
				{
					this.importedSymbol = this.enumerator.Current;
					if (this.importedSymbol.GetIsOrdinal())
					{
						int num = this.text2.LastIndexOf(EncodedStringTable.DecodeString(10075), StringComparison.OrdinalIgnoreCase);
						if (num != -1)
						{
							this.text2 = this.text2.Substring(0, num);
						}
						this.text = this.text2 + EncodedStringTable.DecodeString(952) + this.importedSymbol.GetOrdinal();
						this.intValue = 1;
						result = true;
					}
					else
					{
						this.text = this.importedSymbol.GetName();
						this.intValue = 2;
						result = true;
					}
				}
				else
				{
					RecoveredRuntime.DisposeImportNameIterator(this);
					this.enumerator = null;
					result = false;
				}
			}
			catch
			{
				((IDisposable)this).Dispose();
				throw;
			}
			return result;
		}

		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			ImportedNameIterator enumerator;
			if (this.intValue == -2 && this.intValue2 == Thread.CurrentThread.ManagedThreadId)
			{
				this.intValue = 0;
				enumerator = this;
			}
			else
			{
				enumerator = new ImportedNameIterator(0);
			}

			enumerator.text2 = this.text3;
			enumerator.items = this.items2;
			return enumerator;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}
	}

	public OrderedDictionary<string, List<string>> dictionary = new OrderedDictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

	public List<ImportDescriptor> items = new List<ImportDescriptor>();

	protected List<string> this[string text] => dictionary[text];

	public ImportDirectory()
	{
	}

	internal ImportDirectory(BoundsCheckedBinaryReader boundsCheckedBinaryReader, PeImage peImage)
	{
		for (;;)
		{
			ImportDescriptor @class = new ImportDescriptor();
			@class.SetOriginalFirstThunk(boundsCheckedBinaryReader.ReadUInt32());
			@class.SetTimeDateStamp(boundsCheckedBinaryReader.ReadUInt32());
			@class.SetForwarderChain(boundsCheckedBinaryReader.ReadUInt32());
			@class.SetNameRva(boundsCheckedBinaryReader.ReadUInt32());
			@class.SetFirstThunk(boundsCheckedBinaryReader.ReadUInt32());
			if (@class.GetOriginalFirstThunk() == 0u)
			{
				@class.SetOriginalFirstThunk(@class.GetFirstThunk());
			}
			if (@class.GetOriginalFirstThunk() == 0u)
			{
				break;
			}
			long num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetOriginalFirstThunk());
			long num2 = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetNameRva());
			long position = boundsCheckedBinaryReader.BaseStream.Position;
			if (num == -1L || num2 == -1L || !boundsCheckedBinaryReader.IsValidOffset(num) || !boundsCheckedBinaryReader.IsValidOffset(num2))
			{
				break;
			}
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num2);
			string text = RecoveredRuntime.ReadNullTerminatedAsciiString(boundsCheckedBinaryReader);
			@class.SetModuleName(text);
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
			List<ImportedSymbol> collection = RecoveredRuntime.ReadImportedSymbols(boundsCheckedBinaryReader, this, peImage);
			@class.GetOriginalThunkSymbols().AddRange(collection);
			if (@class.GetOriginalFirstThunk() == @class.GetFirstThunk())
			{
				@class.GetFirstThunkSymbols().AddRange(collection);
			}
			else
			{
				num = RecoveredRuntime.MapRvaToFileOffset(peImage, @class.GetFirstThunk());
				RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, num);
				if (num != -1L)
				{
					@class.GetFirstThunkSymbols().AddRange(RecoveredRuntime.ReadImportedSymbols(boundsCheckedBinaryReader, this, peImage));
				}
			}
			if (!this.dictionary.ContainsKey(text))
			{
				this.dictionary.Add(text, new List<string>(RecoveredRuntime.EnumerateImportedSymbolNames(text, @class.GetOriginalThunkSymbols(), this)));
			}
			else
			{
				this.dictionary[text].AddRange(RecoveredRuntime.EnumerateImportedSymbolNames(text, @class.GetOriginalThunkSymbols(), this));
			}
			this.items.Add(@class);
			RecoveredRuntime.SeekReader(boundsCheckedBinaryReader, position);
		}
	}
}
