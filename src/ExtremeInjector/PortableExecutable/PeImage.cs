using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class PeImage : IDisposable
{
	public interface Interface3
	{
		long imethod_0(PeImage class154_0, uint uint_0);
	}

	public sealed class Class155 : Interface3
	{
		public long imethod_0(PeImage class154_0, uint uint_0)
		{
			using (List<PeSectionHeader>.Enumerator enumerator = class154_0.method_8().GetEnumerator())
			{
				PeSectionHeader current = default(PeSectionHeader);
				long result = default(long);
				while (true)
				{
					IL_00f1:
					int num = ((!enumerator.MoveNext()) ? (-1572770025) : (-669986976));
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num ^ -813529743)) % 8)
						{
						case 7u:
							num = ((uint_0 >= current.method_4() + current.method_6()) ? 1661393667 : 1961237498) ^ (int)(num2 * 840203914);
							continue;
						case 5u:
							result = uint_0 - current.method_4() + current.method_8();
							num = (int)((num2 * 312627368) ^ 0x285EE639);
							continue;
						case 3u:
							num = ((uint_0 < current.method_4()) ? 304465364 : 81893455) ^ ((int)num2 * -993563573);
							continue;
						case 2u:
							num = -669986976;
							continue;
						case 1u:
							current = enumerator.Current;
							num = -137276558;
							continue;
						default:
							goto end_IL_00b1;
						case 4u:
							break;
						case 6u:
							goto end_IL_00b1;
						case 0u:
							return result;
						}
						goto IL_00f1;
						continue;
						end_IL_00b1:
						break;
					}
					break;
				}
			}
			return -1L;
		}
	}

	public sealed class Class156 : Interface3
	{
		public long imethod_0(PeImage class154_0, uint uint_0)
		{
			return uint_0;
		}
	}

	[CompilerGenerated]
	internal string string_0;

	[CompilerGenerated]
	internal string string_1;

	[CompilerGenerated]
	internal DosHeader class158_0;

	[CompilerGenerated]
	internal PeHeaders class161_0;

	[CompilerGenerated]
	internal List<PeSectionHeader> list_0;

	[CompilerGenerated]
	internal ImportDirectory class148_0;

	[CompilerGenerated]
	internal DelayImportDirectory class149_0;

	[CompilerGenerated]
	internal ExportDirectory class151_0;

	[CompilerGenerated]
	internal BaseRelocationDirectory class146_0;

	[CompilerGenerated]
	internal DebugDirectoryEntry class147_0;

	[CompilerGenerated]
	internal TlsDirectory class167_0;

	[CompilerGenerated]
	internal LoadConfigurationDirectory class143_0;

	[CompilerGenerated]
	internal ResourceDirectory class166_0;

	[CompilerGenerated]
	internal ExceptionDirectory class141_0;

	[CompilerGenerated]
	internal ClrHeader class142_0;

	[CompilerGenerated]
	internal Stream stream_0;

	[CompilerGenerated]
	internal PeImageLayout enum39_0;

	internal readonly bool bool_0;

	internal readonly Interface3 interface3_0;

	[SpecialName]
	[CompilerGenerated]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(string string_2)
	{
		string_0 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public string method_2()
	{
		return string_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(string string_2)
	{
		string_1 = string_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public DosHeader method_4()
	{
		return class158_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(DosHeader class158_1)
	{
		class158_0 = class158_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public PeHeaders method_6()
	{
		return class161_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(PeHeaders class161_1)
	{
		class161_0 = class161_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public List<PeSectionHeader> method_8()
	{
		return list_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(List<PeSectionHeader> list_1)
	{
		list_0 = list_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ImportDirectory method_10()
	{
		return class148_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(ImportDirectory class148_1)
	{
		class148_0 = class148_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public DelayImportDirectory method_12()
	{
		return class149_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_13(DelayImportDirectory class149_1)
	{
		class149_0 = class149_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ExportDirectory method_14()
	{
		return class151_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_15(ExportDirectory class151_1)
	{
		class151_0 = class151_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public BaseRelocationDirectory method_16()
	{
		return class146_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_17(BaseRelocationDirectory class146_1)
	{
		class146_0 = class146_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public DebugDirectoryEntry method_18()
	{
		return class147_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_19(DebugDirectoryEntry class147_1)
	{
		class147_0 = class147_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public TlsDirectory method_20()
	{
		return class167_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_21(TlsDirectory class167_1)
	{
		class167_0 = class167_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_22(LoadConfigurationDirectory class143_1)
	{
		class143_0 = class143_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ResourceDirectory method_23()
	{
		return class166_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_24(ResourceDirectory class166_1)
	{
		class166_0 = class166_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public ExceptionDirectory method_25()
	{
		return class141_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_26(ExceptionDirectory class141_1)
	{
		class141_0 = class141_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_27(ClrHeader class142_1)
	{
		class142_0 = class142_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public Stream method_28()
	{
		return stream_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_29(Stream stream_1)
	{
		stream_0 = stream_1;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_30(PeImageLayout enum39_1)
	{
		enum39_0 = enum39_1;
	}

	public PeImage(Stream stream_1, PeImageLayout enum39_1)
	{
		while (true)
		{
			int num = -1679192658;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -433066232)) % 7)
				{
				case 5u:
					interface3_0 = new Class155();
					num = ((int)num2 * -1506842910) ^ -723329806;
					continue;
				case 3u:
					num = ((enum39_1 == PeImageLayout.const_0) ? (-847196778) : (-13216941)) ^ (int)(num2 * 290839860);
					continue;
				case 2u:
					interface3_0 = new Class156();
					num = -265587503;
					continue;
				case 1u:
					method_30(enum39_1);
					method_29(stream_1);
					num = ((int)num2 * -1146167102) ^ -1392579271;
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public PeImage(Stream stream_1, bool bool_1, PeImageLayout enum39_1)
		: this(stream_1, enum39_1)
	{
		bool_0 = bool_1;
	}

	~PeImage()
	{
		if (!bool_0)
		{
			return;
		}
		while (true)
		{
			int num = -1241300689;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1031244942)) % 3)
				{
				case 2u:
					goto IL_000b;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_000b:
				((IDisposable)this).Dispose();
				num = ((int)num2 * -755813774) ^ -244268752;
			}
		}
	}

	public void System_002EIDisposable_002EDispose()
	{
		((IDisposable)this).Dispose();
	}

	void IDisposable.Dispose()
	{
		if (!bool_0)
		{
			return;
		}
		while (true)
		{
			int num = 36478713;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1274D5EE)) % 5)
				{
				case 3u:
					method_28().Dispose();
					num = (int)(num2 * 1805078712) ^ -290425668;
					continue;
				case 2u:
					num = ((method_28() == null) ? 567030699 : 247700802) ^ (int)(num2 * 1981427340);
					continue;
				case 1u:
					method_29(null);
					num = (int)((num2 * 1801503697) ^ 0x78880C8D);
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_0(Stream stream_1)
	{
		stream_1.Dispose();
	}
}
