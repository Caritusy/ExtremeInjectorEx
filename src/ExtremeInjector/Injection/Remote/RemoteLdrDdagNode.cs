using System;
using System.Runtime.CompilerServices;

public abstract class RemoteLdrDdagNode : RemotePlatformStructure
{
	protected RemoteLdrDdagNode(IntPtr address, IntPtr address2, bool flag)
		: base(address2, flag)
	{
		SetAddress(address);
	}

	[SpecialName]
	public virtual uint GetLoadCount()
	{
		return ReadField<uint>(2);
	}
}
