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

		internal int method_006A(int int_0)
		{
			return int_0;
		}

		internal bool method_006B(object object_0)
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
			int num6 = default(int);
			FieldInfo[] array2 = default(FieldInfo[]);
			int current = default(int);
			bool flag3 = default(bool);
			bool flag2 = default(bool);
			object obj = default(object);
			FieldInfo fieldInfo = default(FieldInfo);
			int num4 = default(int);
			while (true)
			{
				IL_0303:
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -272941128;
					num2 = -272941128;
				}
				else
				{
					num = -880559836;
					num2 = -880559836;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)(num ^ -1048341681)) % 21)
					{
					case 20u:
					{
						int num14;
						if (num6 < array2.Length)
						{
							num = -213098872;
							num14 = -213098872;
						}
						else
						{
							num = -2063972843;
							num14 = -2063972843;
						}
						continue;
					}
					case 19u:
					{
						int num18;
						int num19;
						if (current >= 2)
						{
							num18 = -475619816;
							num19 = -475619816;
						}
						else
						{
							num18 = -1876240554;
							num19 = -1876240554;
						}
						num = num18 ^ (int)(num3 * 124618431);
						continue;
					}
					case 18u:
						flag3 = true;
						array2 = array;
						num = (int)(num3 * 1411657261) ^ -848849604;
						continue;
					case 17u:
					{
						int num10;
						int num11;
						if (!flag2)
						{
							num10 = -486047419;
							num11 = -486047419;
						}
						else
						{
							num10 = -1911703408;
							num11 = -1911703408;
						}
						num = num10 ^ (int)(num3 * 1630261993);
						continue;
					}
					case 16u:
						flag = false;
						num = (int)(num3 * 2137368016) ^ -416651767;
						continue;
					case 15u:
						num = (int)((num3 * 524632246) ^ 0x4337FCD5);
						continue;
					case 14u:
					{
						int num15;
						int num16;
						if (obj != null)
						{
							num15 = 273086553;
							num16 = 273086553;
						}
						else
						{
							num15 = 1037803945;
							num16 = 1037803945;
						}
						num = num15 ^ (int)(num3 * 1139524902);
						continue;
					}
					case 13u:
						fieldInfo = array2[num6];
						obj = fieldInfo.GetCustomAttributes(inherit: false).FirstOrDefault((object object_0) => object_0.GetType() == typeof(Attribute0));
						num = -1672854913;
						continue;
					case 11u:
						num = -272941128;
						continue;
					case 10u:
					{
						int num17;
						if ((current < num4) & flag2)
						{
							num = -848424260;
							num17 = -848424260;
						}
						else
						{
							num = -316318583;
							num17 = -316318583;
						}
						continue;
					}
					case 9u:
						num6++;
						num = -1225667949;
						continue;
					case 8u:
						current = enumerator.Current;
						num = -716035394;
						continue;
					case 7u:
					{
						int num12;
						int num13;
						if (!flag3)
						{
							num12 = 575434159;
							num13 = 575434159;
						}
						else
						{
							num12 = 282754695;
							num13 = 282754695;
						}
						num = num12 ^ ((int)num3 * -950503449);
						continue;
					}
					case 6u:
						flag3 = false;
						num = -316318583;
						continue;
					case 5u:
					{
						bool num7 = (bool)fieldInfo.GetValue(this);
						flag2 = num7;
						int num8;
						int num9;
						if (!num7)
						{
							num8 = 1432386280;
							num9 = 1432386280;
						}
						else
						{
							num8 = 549745939;
							num9 = 549745939;
						}
						num = num8 ^ (int)(num3 * 1999827297);
						continue;
					}
					case 3u:
						num4 = (int)((Attribute0)obj).method_0();
						num = (int)(num3 * 717751291) ^ -235538004;
						continue;
					case 1u:
						num6 = 0;
						num = (int)(num3 * 516538929) ^ -150702003;
						continue;
					case 0u:
					{
						int num5;
						if (current < num4)
						{
							num = -1604048023;
							num5 = -1604048023;
						}
						else
						{
							num = -1101201954;
							num5 = -1101201954;
						}
						continue;
					}
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
					int num20 = -392213604;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)(num20 ^ -1048341681)) % 3)
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
						num20 = (int)(num3 * 80300205) ^ -997919053;
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
			uint num3 = 704156642u;
			return Enum3.const_1;
		}
		return Enum3.const_0;
	}

	FieldInfo[] method_0()
	{
		return ((Type)this).GetFields();
	}
}
