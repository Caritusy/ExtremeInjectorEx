using System;
using System.Runtime.InteropServices;

public struct Struct15
{
	public IntPtr intptr_0;

	public IntPtr intptr_1;

	public IntPtr intptr_2;

	public void method_0()
	{
		IntPtr intPtr = intptr_0;
		intptr_0 = (intptr_1 = IntPtr.Zero);
		while (true)
		{
			int num = -1542306736;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1394241239)) % 5)
				{
				case 4u:
					num = (int)((num2 * 1000345364) ^ 0x32038619);
					continue;
				case 2u:
				{
					IntPtr intPtr2 = ((Struct16)smethod_1(intPtr, smethod_0(typeof(Struct16).TypeHandle))).intptr_0;
					Class171.smethod_189(intPtr);
					intPtr = intPtr2;
					num = -1250082195;
					continue;
				}
				case 1u:
					num = ((intPtr != IntPtr.Zero) ? (-1533576378) : (-1809871864));
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object smethod_1(IntPtr intptr_3, Type type_0)
	{
		return Marshal.PtrToStructure(intptr_3, type_0);
	}
}
