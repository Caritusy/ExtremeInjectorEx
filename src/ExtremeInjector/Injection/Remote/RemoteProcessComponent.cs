using System;
using System.Runtime.CompilerServices;

public abstract class RemoteProcessComponent : RemoteMemoryAccessor, IDisposable
{
	[CompilerGenerated]
	internal bool bool_1;

	[CompilerGenerated]
	internal RemoteProcess gclass2_0;

	[SpecialName]
	[CompilerGenerated]
	public bool method_17()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_18(bool bool_2)
	{
		bool_1 = bool_2;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal RemoteProcess method_19()
	{
		return gclass2_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected internal void method_20(RemoteProcess gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}

	protected RemoteProcessComponent(RemoteProcess gclass2_1)
	{
		this.method_20(gclass2_1);
		base.method_5(false);
	}

	void IDisposable.Dispose()
	{
		RecoveredRuntime.smethod_388(this);
	}
}
