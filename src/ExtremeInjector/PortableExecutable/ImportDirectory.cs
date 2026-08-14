using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

public class ImportDirectory
{
	[CompilerGenerated]
	public sealed class Class150 : IEnumerable<string>, IEnumerator<string>, IDisposable, IEnumerator, IEnumerable
	{
		internal int int_0;

		internal string string_0;

		internal int int_1;

		internal IEnumerable<ImportedSymbol> ienumerable_0;

		public IEnumerable<ImportedSymbol> ienumerable_1;

		internal string string_1;

		public string string_2;

		internal ImportedSymbol class164_0;

		internal IEnumerator<ImportedSymbol> ienumerator_0;

		string IEnumerator<string>.Current => string_0;

		object IEnumerator.Current => string_0;

		public Class150(int int_2)
		{
			this.int_0 = int_2;
			this.int_1 = Thread.CurrentThread.ManagedThreadId;
		}

		void IDisposable.Dispose()
		{
			int num = this.int_0;
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
				switch (this.int_0)
				{
				case 0:
					this.int_0 = -1;
					this.ienumerator_0 = this.ienumerable_0.GetEnumerator();
					this.int_0 = -3;
					break;
				case 1:
				case 2:
					this.int_0 = -3;
					this.class164_0 = null;
					break;
				default:
					return false;
				}
				if (this.ienumerator_0.MoveNext())
				{
					this.class164_0 = this.ienumerator_0.Current;
					if (this.class164_0.GetIsOrdinal())
					{
						int num = this.string_1.LastIndexOf(EncodedStringTable.DecodeString(10075), StringComparison.OrdinalIgnoreCase);
						if (num != -1)
						{
							this.string_1 = this.string_1.Substring(0, num);
						}
						this.string_0 = this.string_1 + EncodedStringTable.DecodeString(952) + this.class164_0.GetOrdinal();
						this.int_0 = 1;
						result = true;
					}
					else
					{
						this.string_0 = this.class164_0.GetName();
						this.int_0 = 2;
						result = true;
					}
				}
				else
				{
					RecoveredRuntime.DisposeImportNameIterator(this);
					this.ienumerator_0 = null;
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
			Class150 enumerator;
			if (this.int_0 == -2 && this.int_1 == Thread.CurrentThread.ManagedThreadId)
			{
				this.int_0 = 0;
				enumerator = this;
			}
			else
			{
				enumerator = new Class150(0);
			}

			enumerator.string_1 = this.string_2;
			enumerator.ienumerable_0 = this.ienumerable_1;
			return enumerator;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<string>)this).GetEnumerator();
		}
	}

	public OrderedDictionary<string, List<string>> gclass0_0 = new OrderedDictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

	public List<ImportDescriptor> list_0 = new List<ImportDescriptor>();

	protected List<string> this[string string_0] => gclass0_0[string_0];

	public ImportDirectory()
	{
	}

	internal ImportDirectory(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		for (;;)
		{
			ImportDescriptor @class = new ImportDescriptor();
			@class.SetOriginalFirstThunk(class5_0.ReadUInt32());
			@class.SetTimeDateStamp(class5_0.ReadUInt32());
			@class.SetForwarderChain(class5_0.ReadUInt32());
			@class.SetNameRva(class5_0.ReadUInt32());
			@class.SetFirstThunk(class5_0.ReadUInt32());
			if (@class.GetOriginalFirstThunk() == 0u)
			{
				@class.SetOriginalFirstThunk(@class.GetFirstThunk());
			}
			if (@class.GetOriginalFirstThunk() == 0u)
			{
				break;
			}
			long num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetOriginalFirstThunk());
			long num2 = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetNameRva());
			long position = class5_0.BaseStream.Position;
			if (num == -1L || num2 == -1L || !class5_0.IsValidOffset(num) || !class5_0.IsValidOffset(num2))
			{
				break;
			}
			RecoveredRuntime.SeekReader(class5_0, num2);
			string text = RecoveredRuntime.ReadNullTerminatedAsciiString(class5_0);
			@class.SetModuleName(text);
			RecoveredRuntime.SeekReader(class5_0, num);
			List<ImportedSymbol> collection = RecoveredRuntime.ReadImportedSymbols(class5_0, this, class154_0);
			@class.GetOriginalThunkSymbols().AddRange(collection);
			if (@class.GetOriginalFirstThunk() == @class.GetFirstThunk())
			{
				@class.GetFirstThunkSymbols().AddRange(collection);
			}
			else
			{
				num = RecoveredRuntime.MapRvaToFileOffset(class154_0, @class.GetFirstThunk());
				RecoveredRuntime.SeekReader(class5_0, num);
				if (num != -1L)
				{
					@class.GetFirstThunkSymbols().AddRange(RecoveredRuntime.ReadImportedSymbols(class5_0, this, class154_0));
				}
			}
			if (!this.gclass0_0.ContainsKey(text))
			{
				this.gclass0_0.Add(text, new List<string>(RecoveredRuntime.EnumerateImportedSymbolNames(text, @class.GetOriginalThunkSymbols(), this)));
			}
			else
			{
				this.gclass0_0[text].AddRange(RecoveredRuntime.EnumerateImportedSymbolNames(text, @class.GetOriginalThunkSymbols(), this));
			}
			this.list_0.Add(@class);
			RecoveredRuntime.SeekReader(class5_0, position);
		}
	}
}
