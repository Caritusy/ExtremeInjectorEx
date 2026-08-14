using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static class ApiSetSchema
{
	public struct ApiSetNamespaceEntryV2
	{
		public uint uintValue;

		public uint uintValue2;

		internal uint uintValue3;

		public uint uintValue4;

		public uint uintValue5;

		public uint uintValue6;
	}

	public struct ApiSetEntryIndexV2
	{
		public uint uintValue;

		public uint uintValue2;
	}

	public struct ApiSetNamespaceHeaderV2
	{
		public uint uintValue;

		public uint uintValue2;

		public uint uintValue3;

		public uint uintValue4;

		public uint uintValue5;

		public uint uintValue6;

		internal uint uintValue7;

		internal uint uintValue8;
	}

	public struct ApiSetValueEntryV2
	{
		public uint uintValue;

		public uint uintValue2;

		public uint uintValue3;

		public uint uintValue4;

		public uint uintValue5;
	}

	public struct ApiSetValueArrayV4
	{
		public uint uintValue;

		public uint uintValue2;
	}

	public struct ApiSetNamespaceEntryV4
	{
		public uint uintValue;

		public uint uintValue2;

		public uint uintValue3;

		public uint uintValue4;

		public uint uintValue5;

		public uint uintValue6;
	}

	public struct ApiSetNamespaceHeaderV4
	{
		public uint uintValue;

		public uint uintValue2;

		public uint uintValue3;

		public uint uintValue4;
	}

	public struct ApiSetValueEntryV6
	{
		public uint uintValue;

		public uint uintValue2;

		public uint uintValue3;

		public uint uintValue4;
	}

	public struct ApiSetValueArrayV6
	{
		public uint uintValue;
	}

	public struct ApiSetNamespaceEntryV6
	{
		public uint uintValue;

		public uint uintValue2;

		public uint uintValue3;
	}

	public struct ApiSetNamespaceHeaderV6
	{
		public uint uintValue;

		public uint uintValue2;
	}

	[CompilerGenerated]
	public sealed class ApiSetContractMatcher
	{
		public string text;

		internal bool MatchesContract(KeyValuePair<string, List<string>> keyValuePair)
		{
			return text.IndexOf(keyValuePair.Key) != -1;
		}
	}

	internal static Dictionary<string, List<string>> dictionary;

	static ApiSetSchema()
	{
		try
		{
			if (PlatformInfo.flag3)
			{
				RemoteProcess gclass2_ = RecoveredRuntime.GetCurrentRemoteProcess();
				RemotePeb peb = RecoveredRuntime.Is32BitProcess(gclass2_)
					? (RemotePeb)RecoveredRuntime.GetPeb32(gclass2_)
					: RecoveredRuntime.GetPeb64(gclass2_);
				IntPtr intPtr = peb.GetApiSetMapAddress();
				if (!(intPtr == IntPtr.Zero) && RecoveredRuntime.IsReadableMemoryAddress(intPtr))
				{
					if (PlatformInfo.flag8)
					{
						RecoveredRuntime.ReadApiSetSchemaV2(intPtr);
					}
					else if (!PlatformInfo.flag7)
					{
						if (PlatformInfo.flag3)
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

	internal static U[] ReadEntries<T, U>(IntPtr address) where T : struct where U : struct
	{
		int num = typeof(T).SizeOf();
		IntPtr intPtr = address.Add(num - 4);
		if (RecoveredRuntime.IsReadableMemoryAddress(intPtr))
		{
			int num2 = Marshal.ReadInt32(intPtr);
			address = address.Add(num);
			int num3 = typeof(U).SizeOf();
			U[] array = new U[num2];
			for (int i = 0; i < num2; i++)
			{
				IntPtr intPtr2 = address.Add(num3 * i);
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
