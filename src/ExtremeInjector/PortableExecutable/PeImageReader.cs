using System;
using System.Collections.Generic;
using System.IO;

public class PeImageReader : BoundsCheckedBinaryReader
{
	protected readonly PeImage class154_0;

	protected PeImageReader(Stream stream_0, bool bool_0, PeImageLayout enum39_0)
		: base(stream_0)
	{
		class154_0 = new PeImage(stream_0, bool_0, enum39_0);
	}

	protected PeImageReader(Stream stream_0, string string_0, bool bool_0, PeImageLayout enum39_0)
		: base(stream_0)
	{
		PeImage @class = new PeImage(stream_0, bool_0, enum39_0);
		@class.method_1(Path.GetFullPath(string_0));
		@class.method_3(Path.GetFileName(string_0));
		class154_0 = @class;
	}

	protected virtual bool vmethod_0()
	{
		if (this.vmethod_1())
		{
			this.method_0040();
			return true;
		}
		return false;
	}

	protected virtual bool vmethod_1()
	{
		long imageStart = BaseStream.Position;
		DosHeader dosHeader = null;
		if (!RecoveredRuntime.smethod_444(ref dosHeader, this))
		{
			return false;
		}

		class154_0.method_5(dosHeader);
		BaseStream.Position = imageStart + dosHeader.method_0();

		PeHeaders peHeaders = null;
		if (!RecoveredRuntime.smethod_271(ref peHeaders, this))
		{
			return false;
		}

		class154_0.method_7(peHeaders);
		var sections = new List<PeSectionHeader>(peHeaders.method_1().method_2());
		class154_0.method_9(sections);
		for (int index = 0; index < peHeaders.method_1().method_2(); index++)
		{
			sections.Add(new PeSectionHeader(this));
		}

		return true;
	}

	protected virtual void method_0040()
	{
		this.class154_0.method_11(RecoveredRuntime.smethod_24(this.class154_0, this));
		this.class154_0.method_13(RecoveredRuntime.smethod_293(this, this.class154_0));
		this.class154_0.method_15(RecoveredRuntime.smethod_355(this.class154_0, this));
		this.class154_0.method_17(RecoveredRuntime.smethod_230(this.class154_0, this));
		this.class154_0.method_24(RecoveredRuntime.smethod_389(this.class154_0, this));
		this.class154_0.method_19(RecoveredRuntime.smethod_3(this.class154_0, this));
		this.class154_0.method_21(RecoveredRuntime.smethod_160(this.class154_0, this));
		this.class154_0.method_22(RecoveredRuntime.smethod_92(this, this.class154_0));
		this.class154_0.method_26(RecoveredRuntime.smethod_303(this.class154_0, this));
		this.class154_0.method_27(RecoveredRuntime.smethod_312(this.class154_0, this));
	}

	public static PeImage smethod_4(Stream stream_0, bool bool_0, PeImageLayout enum39_0)
	{
		PeImageReader @class = new PeImageReader(stream_0, bool_0, enum39_0);
		if (!@class.vmethod_0())
		{
			return null;
		}
		return @class.class154_0;
	}

	public static PeImage smethod_5(Stream stream_0, string string_0, bool bool_0, PeImageLayout enum39_0)
	{
		PeImageReader @class = new PeImageReader(stream_0, string_0, bool_0, enum39_0);
		if (!@class.vmethod_0())
		{
			return null;
		}
		return @class.class154_0;
	}

	internal static string smethod_6(string string_0)
	{
		return Path.GetFullPath(string_0);
	}

	internal static string smethod_7(string string_0)
	{
		return Path.GetFileName(string_0);
	}

	internal static Stream smethod_8(BinaryReader binaryReader_0)
	{
		return binaryReader_0.BaseStream;
	}

	internal static long smethod_9(Stream stream_0)
	{
		return stream_0.Position;
	}

	internal static void smethod_10(Stream stream_0, long long_0)
	{
		stream_0.Position = long_0;
	}

}
