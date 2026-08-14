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

		internal bool MatchesContract(KeyValuePair<string, List<string>> keyValuePair_0)
		{
			return string_0.IndexOf(keyValuePair_0.Key) != -1;
		}
	}

	internal static Dictionary<string, List<string>> dictionary_0;

	static ApiSetSchema()
	{
		try
		{
			if (PlatformInfo.bool_2)
			{
				RemoteProcess gclass2_ = RecoveredRuntime.GetCurrentRemoteProcess();
				RemotePeb peb = RecoveredRuntime.Is32BitProcess(gclass2_)
					? (RemotePeb)RecoveredRuntime.GetPeb32(gclass2_)
					: RecoveredRuntime.GetPeb64(gclass2_);
				IntPtr intPtr = peb.GetApiSetMapAddress();
				if (!(intPtr == IntPtr.Zero) && RecoveredRuntime.IsReadableMemoryAddress(intPtr))
				{
					if (PlatformInfo.bool_7)
					{
						RecoveredRuntime.ReadApiSetSchemaV2(intPtr);
					}
					else if (!PlatformInfo.bool_6)
					{
						if (PlatformInfo.bool_2)
						{
							RecoveredRuntime.ReadApiSetSchemaV6(intPtr);
						}
					}
					else
					{
						RecoveredRuntime.ReadApiSetSchemaV4(intPtr);
					}
				}
			}
		}
		catch
		{
		}
	}

	internal static U[] ReadEntries<T, U>(IntPtr intptr_0) where T : struct where U : struct
	{
		int num = typeof(T).SizeOf();
		IntPtr intPtr = intptr_0.Add(num - 4);
		if (RecoveredRuntime.IsReadableMemoryAddress(intPtr))
		{
			int num2 = Marshal.ReadInt32(intPtr);
			intptr_0 = intptr_0.Add(num);
			int num3 = typeof(U).SizeOf();
			U[] array = new U[num2];
			for (int i = 0; i < num2; i++)
			{
				IntPtr intPtr2 = intptr_0.Add(num3 * i);
				if (!RecoveredRuntime.IsReadableMemoryAddress(intPtr2))
				{
					return new U[0];
				}
				array[i] = (U)((object)Marshal.PtrToStructure(intPtr2, typeof(U)));
			}
			return array;
		}
		return new U[0];
	}
}
