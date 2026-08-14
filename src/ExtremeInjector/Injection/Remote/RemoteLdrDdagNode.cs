using System;
using System.Runtime.CompilerServices;

public abstract class RemoteLdrDdagNode : RemotePlatformStructure
{
	protected RemoteLdrDdagNode(IntPtr intptr_2, IntPtr intptr_3, bool bool_2)
		: base(intptr_3, bool_2)
	{
		SetAddress(intptr_2);
	}

	[SpecialName]
	public virtual uint GetLoadCount()
	{
		return ReadField<uint>(2);
	}
}
