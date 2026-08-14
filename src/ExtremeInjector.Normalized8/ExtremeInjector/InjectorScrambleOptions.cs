using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace ExtremeInjector;

[DataContract(Namespace = "")]
public sealed class InjectorScrambleOptions
{
	[Serializable]
	[CompilerGenerated]
	public sealed class Type001E
	{
		public static readonly Type001E field_0066 = new Type001E();

		public static Func<int, int> field_0067;

		public static Func<object, bool> field_0068;

		internal int _003CDetect_003Eb__13_0(int int_0)
		{
			return int_0;
		}

		internal bool _003CDetect_003Eb__13_1(object object_0)
		{
			return object_0.GetType() == typeof(Attribute0);
		}
	}

	[DataMember(Name = "ScrambleHeaderFields")]
	[Attribute0(Enum3.const_2)]
	public bool ScrambleHeaderFields;

	[Attribute0(Enum3.const_2)]
	[DataMember(Name = "RemoveUselessData")]
	public bool RemoveUselessData;

	[Attribute0(Enum3.const_4)]
	[DataMember(Name = "InsertExtraSections")]
	public bool InsertExtraSections;

	[Attribute0(Enum3.const_3)]
	[DataMember(Name = "ShiftSectionData")]
	public bool ShiftSectionData;

	[Attribute0(Enum3.const_3)]
	[DataMember(Name = "ModifyAssemblyCode")]
	public bool ModifyAssemblyCode;

	[Attribute0(Enum3.const_3)]
	[DataMember(Name = "RenameSections")]
	public bool RenameSections;

	[DataMember(Name = "CreateNewEntryPoint")]
	[Attribute0(Enum3.const_4)]
	public bool CreateNewEntryPoint;

	[Attribute0(Enum3.const_2)]
	[DataMember(Name = "ModifyImportTable")]
	public bool ModifyImportTable;

	[DataMember(Name = "RemoveDebugData")]
	[Attribute0(Enum3.const_2)]
	public bool RemoveDebugData;

	[Attribute0(Enum3.const_4)]
	[DataMember(Name = "MoveRelocationTable")]
	public bool MoveRelocationTable;

	[DataMember(Name = "CreateFakeDebugDirectory")]
	[Attribute0(Enum3.const_4)]
	public bool CreateFakeDebugDirectory;

	[Attribute0(Enum3.const_4)]
	[DataMember(Name = "StripSectionCharacteristics")]
	public bool StripSectionCharacteristics;

	[Attribute0(Enum3.const_4)]
	[DataMember(Name = "ShiftSectionMemory")]
	public bool ShiftSectionMemory;

	public Enum3 Detect()
	{
		FieldInfo[] array = ((InjectorScrambleOptions)(object)typeof(InjectorScrambleOptions)).method_0();
		bool flag = true;
		IEnumerator<int> enumerator = ((int[])Enum.GetValues(typeof(Enum3))).OrderByDescending((int int_0) => int_0).GetEnumerator();
		try
		{
			int num4 = default(int);
			FieldInfo[] array2 = default(FieldInfo[]);
			int current = default(int);
			bool flag3 = default(bool);
			bool flag2 = default(bool);
			object obj = default(object);
			FieldInfo fieldInfo = default(FieldInfo);
			int num3 = default(int);
			while (true)
			{
				IL_0303:
				int num = ((!enumerator.MoveNext()) ? (-880559836) : (-272941128));
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -1048341681)) % 21)
					{
					case 20u:
						num = ((num4 >= array2.Length) ? (-2063972843) : (-213098872));
						continue;
					case 19u:
						num = ((current < 2) ? (-1876240554) : (-475619816)) ^ (int)(num2 * 124618431);
						continue;
					case 18u:
						flag3 = true;
						array2 = array;
						num = (int)(num2 * 1411657261) ^ -848849604;
						continue;
					case 17u:
						num = (flag2 ? (-1911703408) : (-486047419)) ^ (int)(num2 * 1630261993);
						continue;
					case 16u:
						flag = false;
						num = (int)(num2 * 2137368016) ^ -416651767;
						continue;
					case 15u:
						num = (int)((num2 * 524632246) ^ 0x4337FCD5);
						continue;
					case 14u:
						num = ((obj == null) ? 1037803945 : 273086553) ^ (int)(num2 * 1139524902);
						continue;
					case 13u:
						fieldInfo = array2[num4];
						obj = fieldInfo.GetCustomAttributes(inherit: false).FirstOrDefault((object object_0) => object_0.GetType() == typeof(Attribute0));
						num = -1672854913;
						continue;
					case 11u:
						num = -272941128;
						continue;
					case 10u:
						num = ((!((current < num3) & flag2)) ? (-316318583) : (-848424260));
						continue;
					case 9u:
						num4++;
						num = -1225667949;
						continue;
					case 8u:
						current = enumerator.Current;
						num = -716035394;
						continue;
					case 7u:
						num = (flag3 ? 282754695 : 575434159) ^ ((int)num2 * -950503449);
						continue;
					case 6u:
						flag3 = false;
						num = -316318583;
						continue;
					case 5u:
					{
						bool num5 = (bool)fieldInfo.GetValue(this);
						flag2 = num5;
						num = (num5 ? 549745939 : 1432386280) ^ (int)(num2 * 1999827297);
						continue;
					}
					case 3u:
						num3 = (int)((Attribute0)obj).method_0();
						num = (int)(num2 * 717751291) ^ -235538004;
						continue;
					case 1u:
						num4 = 0;
						num = (int)(num2 * 516538929) ^ -150702003;
						continue;
					case 0u:
						num = ((current >= num3) ? (-1101201954) : (-1604048023));
						continue;
					default:
						goto end_IL_028d;
					case 4u:
						break;
					case 2u:
						return (Enum3)current;
					case 12u:
						goto end_IL_028d;
					}
					goto IL_0303;
					continue;
					end_IL_028d:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_034e:
					int num6 = -392213604;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)(num6 ^ -1048341681)) % 3)
						{
						case 1u:
							goto IL_031c;
						default:
							goto end_IL_0330;
						case 2u:
							break;
						case 0u:
							goto end_IL_0330;
						}
						goto IL_034e;
						IL_031c:
						enumerator.Dispose();
						num6 = (int)(num2 * 80300205) ^ -997919053;
						continue;
						end_IL_0330:
						break;
					}
					break;
				}
			}
		}
		if (!flag)
		{
			return Enum3.const_1;
		}
		return Enum3.const_0;
	}

	internal FieldInfo[] method_0()
	{
		return ((Type)this).GetFields();
	}
}
