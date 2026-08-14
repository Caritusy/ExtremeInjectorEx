using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static class ApiSetSchema
{
	public struct Struct59
	{
		public uint uint_0;

		public uint uint_1;

		internal uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;
	}

	public struct Struct60
	{
		public uint uint_0;

		public uint uint_1;
	}

	public struct Struct61
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		internal uint uint_6;

		internal uint uint_7;
	}

	public struct Struct62
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;
	}

	public struct Struct63
	{
		public uint uint_0;

		public uint uint_1;
	}

	public struct Struct64
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;
	}

	public struct Struct65
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	public struct Struct66
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	public struct Struct67
	{
		public uint uint_0;
	}

	public struct Struct68
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;
	}

	public struct Struct69
	{
		public uint uint_0;

		public uint uint_1;
	}

	[CompilerGenerated]
	public sealed class Class170
	{
		public string string_0;

		internal bool method_0(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return string_0.IndexOf(keyValuePair_0.Key) != -1;
		}

		internal static int smethod_0(string string_1, string string_2)
		{
			return string_1.IndexOf(string_2);
		}
	}

	internal static Dictionary<string, List<string>> dictionary_0;

	static ApiSetSchema()
	{
		try
		{
			if (PlatformInfo.bool_2)
			{
				RemoteProcess gclass2_ = RecoveredRuntime.smethod_211();
				RemotePeb peb = RecoveredRuntime.smethod_427(gclass2_)
					? (RemotePeb)RecoveredRuntime.smethod_255(gclass2_)
					: RecoveredRuntime.smethod_369(gclass2_);
				IntPtr intPtr = peb.method_0822();
				if (!(intPtr == IntPtr.Zero) && RecoveredRuntime.smethod_184(intPtr))
				{
					if (PlatformInfo.bool_7)
					{
						RecoveredRuntime.smethod_241(intPtr);
					}
					else if (!PlatformInfo.bool_6)
					{
						if (PlatformInfo.bool_2)
						{
							RecoveredRuntime.smethod_120(intPtr);
						}
					}
					else
					{
						RecoveredRuntime.smethod_346(intPtr);
					}
				}
			}
		}
		catch
		{
		}
	}

	internal static U[] smethod_0<T, U>(IntPtr intptr_0) where T : struct where U : struct
	{
		int num = typeof(T).smethod_7();
		IntPtr intPtr = intptr_0.smethod_8(num - 4);
		if (RecoveredRuntime.smethod_184(intPtr))
		{
			int num2 = Marshal.ReadInt32(intPtr);
			intptr_0 = intptr_0.smethod_8(num);
			int num3 = typeof(U).smethod_7();
			U[] array = new U[num2];
			for (int i = 0; i < num2; i++)
			{
				IntPtr intPtr2 = intptr_0.smethod_8(num3 * i);
				if (!RecoveredRuntime.smethod_184(intPtr2))
				{
					return new U[0];
				}
				array[i] = (U)((object)Marshal.PtrToStructure(intPtr2, typeof(U)));
			}
			return array;
		}
		return new U[0];
	}

	internal static Type smethod_1(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static int smethod_2(IntPtr intptr_0)
	{
		return Marshal.ReadInt32(intptr_0);
	}

	internal static object smethod_3(IntPtr intptr_0, Type type_0)
	{
		return Marshal.PtrToStructure(intptr_0, type_0);
	}
}
