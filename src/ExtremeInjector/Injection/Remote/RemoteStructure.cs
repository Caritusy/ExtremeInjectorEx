using System;
using System.Runtime.CompilerServices;

public abstract class RemoteStructure : RemoteMemoryAccessor
{
	[CompilerGenerated]
	internal IntPtr intptr_1;

	[SpecialName]
	[CompilerGenerated]
	public IntPtr GetAddress()
	{
		return intptr_1;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal void SetAddress(IntPtr intptr_2)
	{
		intptr_1 = intptr_2;
	}

	protected RemoteStructure(int int_1)
		: base(int_1)
	{
	}

	protected RemoteStructure(IntPtr intptr_2)
		: base(intptr_2)
	{
	}

	protected T ReadFieldAtOffset<T>(int int_1)
	{
		return Read<T>(GetAddress().Add(int_1));
	}

	protected void WriteFieldAtOffset<T>(T gparam_0, int int_1)
	{
		Write(GetAddress().Add(int_1), gparam_0);
	}
}
