using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class TlsDirectory
{
	[CompilerGenerated]
	internal ulong ulong_0;

	[CompilerGenerated]
	internal ulong ulong_1;

	[CompilerGenerated]
	internal ulong ulong_2;

	[CompilerGenerated]
	internal ulong ulong_3;

	[CompilerGenerated]
	internal uint uint_0;

	[CompilerGenerated]
	internal uint uint_1;

	public List<ulong> list_0 = new List<ulong>();

	[SpecialName]
	[CompilerGenerated]
	public ulong method_0()
	{
		return ulong_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(ulong ulong_4)
	{
		ulong_0 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong method_2()
	{
		return ulong_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(ulong ulong_4)
	{
		ulong_1 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong method_4()
	{
		return ulong_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(ulong ulong_4)
	{
		ulong_2 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public ulong method_6()
	{
		return ulong_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_7(ulong ulong_4)
	{
		ulong_3 = ulong_4;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_8()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_9(uint uint_2)
	{
		uint_0 = uint_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_10()
	{
		return uint_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_11(uint uint_2)
	{
		uint_1 = uint_2;
	}

	internal TlsDirectory(BoundsCheckedBinaryReader class5_0, PeImage class154_0)
	{
		method_1(RecoveredRuntime.smethod_19(class154_0) ? class5_0.ReadUInt32() : class5_0.ReadUInt64());
		method_3(RecoveredRuntime.smethod_19(class154_0) ? class5_0.ReadUInt32() : class5_0.ReadUInt64());
		method_5(RecoveredRuntime.smethod_19(class154_0) ? class5_0.ReadUInt32() : class5_0.ReadUInt64());
		method_7(RecoveredRuntime.smethod_19(class154_0) ? class5_0.ReadUInt32() : class5_0.ReadUInt64());
		method_9(class5_0.ReadUInt32());
		method_11(class5_0.ReadUInt32());
		long num = RecoveredRuntime.smethod_64(class154_0, method_6());
		if (num != -1L)
		{
			RecoveredRuntime.smethod_157(class5_0, num);
			ulong item;
			while ((item = ((!RecoveredRuntime.smethod_19(class154_0)) ? class5_0.ReadUInt64() : class5_0.ReadUInt32())) != 0L)
			{
				list_0.Add(item);
			}
		}
	}

	internal static ulong smethod_0(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt64();
	}

	internal static uint smethod_1(BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadUInt32();
	}
}
