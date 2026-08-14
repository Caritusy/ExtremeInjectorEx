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
				RecoveredRuntime.smethod_43(this);
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
					if (this.class164_0.method_7())
					{
						int num = this.string_1.LastIndexOf(EncodedStringTable.smethod_0(10075), StringComparison.OrdinalIgnoreCase);
						if (num != -1)
						{
							this.string_1 = this.string_1.Substring(0, num);
						}
						this.string_0 = this.string_1 + EncodedStringTable.smethod_0(952) + this.class164_0.method_2();
						this.int_0 = 1;
						result = true;
					}
					else
					{
						this.string_0 = this.class164_0.method_4();
						this.int_0 = 2;
						result = true;
					}
				}
				else
				{
					RecoveredRuntime.smethod_43(this);
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

		internal static Thread smethod_0()
		{
			return Thread.CurrentThread;
		}

		internal static int smethod_1(Thread thread_0)
		{
			return thread_0.ManagedThreadId;
		}

		internal static int smethod_2(string string_3, string string_4, StringComparison stringComparison_0)
		{
			return string_3.LastIndexOf(string_4, stringComparison_0);
		}

		internal static string smethod_3(string string_3, int int_2, int int_3)
		{
			return string_3.Substring(int_2, int_3);
		}

		internal static string smethod_4(object object_0, object object_1, object object_2)
		{
			return string.Concat(object_0, object_1, object_2);
		}

		internal static bool smethod_5(IEnumerator ienumerator_1)
		{
			return ienumerator_1.MoveNext();
		}

		internal static NotSupportedException smethod_6()
		{
			return new NotSupportedException();
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
			@class.method_1(class5_0.ReadUInt32());
			@class.method_2(class5_0.ReadUInt32());
			@class.method_3(class5_0.ReadUInt32());
			@class.method_5(class5_0.ReadUInt32());
			@class.method_7(class5_0.ReadUInt32());
			if (@class.method_0() == 0u)
			{
				@class.method_1(@class.method_6());
			}
			if (@class.method_0() == 0u)
			{
				break;
			}
			long num = RecoveredRuntime.smethod_135(class154_0, @class.method_0());
			long num2 = RecoveredRuntime.smethod_135(class154_0, @class.method_4());
			long position = class5_0.BaseStream.Position;
			if (num == -1L || num2 == -1L || !class5_0.imethod_0(num) || !class5_0.imethod_0(num2))
			{
				break;
			}
			RecoveredRuntime.smethod_157(class5_0, num2);
			string text = RecoveredRuntime.smethod_404(class5_0);
			@class.method_13(text);
			RecoveredRuntime.smethod_157(class5_0, num);
			List<ImportedSymbol> collection = RecoveredRuntime.smethod_162(class5_0, this, class154_0);
			@class.method_8().AddRange(collection);
			if (@class.method_0() == @class.method_6())
			{
				@class.method_10().AddRange(collection);
			}
			else
			{
				num = RecoveredRuntime.smethod_135(class154_0, @class.method_6());
				RecoveredRuntime.smethod_157(class5_0, num);
				if (num != -1L)
				{
					@class.method_10().AddRange(RecoveredRuntime.smethod_162(class5_0, this, class154_0));
				}
			}
			if (!this.gclass0_0.imethod_6(text))
			{
				this.gclass0_0.imethod_0(text, new List<string>(RecoveredRuntime.smethod_412(text, @class.method_8(), this)));
			}
			else
			{
				this.gclass0_0[text].AddRange(RecoveredRuntime.smethod_412(text, @class.method_8(), this));
			}
			this.list_0.Add(@class);
			RecoveredRuntime.smethod_157(class5_0, position);
		}
	}

	internal static StringComparer smethod_0()
	{
		return StringComparer.OrdinalIgnoreCase;
	}

	internal static uint smethod_1(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}

	internal static Stream smethod_2(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static long smethod_3(Stream stream_0)
	{
		return stream_0.Position;
	}
}
