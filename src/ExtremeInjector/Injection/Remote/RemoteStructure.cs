using System;
using System.Runtime.CompilerServices;

public abstract class RemoteStructure : RemoteMemoryAccessor
{
	[CompilerGenerated]
	internal IntPtr address;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetAddress()
	{
		return address;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal void SetAddress(IntPtr address2)
	{
		address = address2;
	}

	protected RemoteStructure(int intValue)
		: base(intValue)
	{
	}

	protected RemoteStructure(IntPtr address2)
		: base(address2)
	{
	}

	protected T ReadFieldAtOffset<T>(int intValue)
	{
		return Read<T>(GetAddress().Add(intValue));
	}

	protected void WriteFieldAtOffset<T>(T value, int intValue)
	{
		Write(GetAddress().Add(intValue), value);
	}
}
