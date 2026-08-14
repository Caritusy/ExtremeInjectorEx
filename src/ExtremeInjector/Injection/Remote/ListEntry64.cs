using System;

public sealed class ListEntry64 : RemoteListEntry
{
	static ListEntry64()
	{
		RemotePlatformStructure.smethod_7<ListEntry64>(new RemoteFieldLayout[2]
		{
			RecoveredRuntime.smethod_316(typeof(IntPtr)),
			RecoveredRuntime.smethod_316(typeof(IntPtr))
		});
	}

	internal ListEntry64(IntPtr intptr_2, IntPtr intptr_3)
		: base(intptr_2, intptr_3, bool_2: false)
	{
	}

	public override RemoteListEntry method_07D2()
	{
		if (!(vmethod_7() != IntPtr.Zero))
		{
			return null;
		}
		return new ListEntry64(vmethod_7(), method_2());
	}

	public override RemoteListEntry method_07D3()
	{
		if (!(vmethod_9() != IntPtr.Zero))
		{
			return null;
		}
		return new ListEntry64(vmethod_9(), method_2());
	}

	internal static Type smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
