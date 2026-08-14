using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using ns1;

public static class Class187
{
	internal static byte[] byte_0;

	internal static Func<int, MethodBase> func_0;

	internal static Delegate49 delegate49_0;

	static Class187()
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GClass10.smethod_0("\u0094", 128, 48));
		using MemoryStream memoryStream = new MemoryStream();
		GClass8 gClass = new GClass8();
		byte[] array = new byte[5];
		stream.Read(array, 0, array.Length);
		gClass.method_5(array);
		array = new byte[8];
		stream.Read(array, 0, array.Length);
		long long_ = BitConverter.ToInt64(array, 0);
		gClass.method_4(stream, memoryStream, long_);
		byte_0 = memoryStream.ToArray();
	}

	internal static int smethod_0(this BinaryReader binaryReader_0)
	{
		return binaryReader_0.ReadInt32() ^ 0x28B4E8A0;
	}

	internal static byte[] smethod_1(this BinaryReader binaryReader_0, int int_0)
	{
		byte[] array = binaryReader_0.ReadBytes(int_0);
		for (int i = 0; i < int_0; i++)
		{
			array[i] ^= 60;
		}
		return array;
	}

	internal static DynamicMethod smethod_2(int int_0)
	{
		using MemoryStream memoryStream = new MemoryStream(byte_0, writable: false);
		using BinaryReader binaryReader_ = new BinaryReader(memoryStream);
		memoryStream.Position = int_0;
		return smethod_3(binaryReader_);
	}

	internal static DynamicMethod smethod_3(BinaryReader binaryReader_0)
	{
		if (delegate49_0 == null)
		{
			DynamicMethod dynamicMethod = new DynamicMethod(GClass10.smethod_0(GClass10.smethod_0("jlll\u001f\u001d\u0019", 145, 49), 205, 0), typeof(DynamicMethod), new Type[1] { typeof(BinaryReader) }, restrictedSkipVisibility: true);
			dynamicMethod.InitLocals = true;
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			Label[] array = new Label[21]
			{
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel(),
				iLGenerator.DefineLabel()
			};
			LocalBuilder[] array2 = new LocalBuilder[35]
			{
				iLGenerator.DeclareLocal(typeof(string)),
				iLGenerator.DeclareLocal(typeof(Type)),
				iLGenerator.DeclareLocal(typeof(ushort)),
				iLGenerator.DeclareLocal(typeof(bool)),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(Type[])),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(Type[])),
				iLGenerator.DeclareLocal(typeof(Type)),
				iLGenerator.DeclareLocal(typeof(DynamicMethod)),
				iLGenerator.DeclareLocal(typeof(DynamicILInfo)),
				iLGenerator.DeclareLocal(typeof(SignatureHelper)),
				iLGenerator.DeclareLocal(typeof(byte[])),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(byte[])),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(Type)),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(byte)),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(string)),
				iLGenerator.DeclareLocal(typeof(Type)),
				iLGenerator.DeclareLocal(typeof(Type)),
				iLGenerator.DeclareLocal(typeof(MethodBase)),
				iLGenerator.DeclareLocal(typeof(Type)),
				iLGenerator.DeclareLocal(typeof(MethodBase)),
				iLGenerator.DeclareLocal(typeof(int)),
				iLGenerator.DeclareLocal(typeof(Type[])),
				iLGenerator.DeclareLocal(typeof(Type)),
				iLGenerator.DeclareLocal(typeof(int))
			};
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666486));
			iLGenerator.Emit(OpCodes.Stloc_0);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666487));
			iLGenerator.Emit(OpCodes.Stloc_1);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(BinaryReader), GClass10.smethod_0(GClass10.smethod_0("©\u009e\u009a\u009f®²\u0095\u008fÊÍ", 33, 50), 218, 1), new Type[0]));
			iLGenerator.Emit(OpCodes.Stloc_2);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(BinaryReader), GClass10.smethod_0(GClass10.smethod_0("cTPUs^^]TP_", 129, 51), 176, 2), new Type[0]));
			iLGenerator.Emit(OpCodes.Stloc_3);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666482));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[4]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[4]);
			iLGenerator.Emit(OpCodes.Newarr, typeof(Type));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[5]);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[14]);
			iLGenerator.Emit(OpCodes.Br_S, array[0]);
			iLGenerator.MarkLabel(array[1]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[5]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[14]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666487));
			iLGenerator.Emit(OpCodes.Stelem_Ref);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[14]);
			iLGenerator.Emit(OpCodes.Ldc_I4_1);
			iLGenerator.Emit(OpCodes.Add);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[14]);
			iLGenerator.MarkLabel(array[0]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[14]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[4]);
			iLGenerator.Emit(OpCodes.Blt_S, array[1]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666482));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[6]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[6]);
			iLGenerator.Emit(OpCodes.Newarr, typeof(Type));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[7]);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[15]);
			iLGenerator.Emit(OpCodes.Br_S, array[2]);
			iLGenerator.MarkLabel(array[3]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[7]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[15]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666487));
			iLGenerator.Emit(OpCodes.Stelem_Ref);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[15]);
			iLGenerator.Emit(OpCodes.Ldc_I4_1);
			iLGenerator.Emit(OpCodes.Add);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[15]);
			iLGenerator.MarkLabel(array[2]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[15]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[6]);
			iLGenerator.Emit(OpCodes.Blt_S, array[3]);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666490));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[8]);
			iLGenerator.Emit(OpCodes.Ldloc_0);
			iLGenerator.Emit(OpCodes.Ldloc_1);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[5]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[8]);
			iLGenerator.Emit(OpCodes.Ldc_I4_1);
			iLGenerator.Emit(OpCodes.Newobj, typeof(DynamicMethod).GetConstructor(new Type[5]
			{
				typeof(string),
				typeof(Type),
				typeof(Type[]),
				typeof(Type),
				typeof(bool)
			}));
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldloc_3);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicMethod), GClass10.smethod_0(GClass10.smethod_0("\u0088\u009e\u008f¤²\u0095\u0092\u008f·\u0094\u0098\u009a\u0097\u0088", 18, 52), 233, 3), new Type[1] { typeof(bool) }));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[9]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[9]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicMethod), GClass10.smethod_0(GClass10.smethod_0("\u0018:+\u001b&1>26<\u0016\u0013\u0016190", 238, 53), 177, 4), new Type[0]));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Call, Class192.smethod_0(typeof(SignatureHelper), GClass10.smethod_0(GClass10.smethod_0("ûÙÈðÓßÝÐêÝÎïÕÛôÙÐÌÙÎ", 135, 54), 59, 5), new Type[0]));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[11]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[11]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[7]);
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(SignatureHelper), GClass10.smethod_0(GClass10.smethod_0("ÃææÃðå÷ïçìöñ", 39, 55), 165, 6), new Type[3]
			{
				typeof(Type[]),
				typeof(Type[][]),
				typeof(Type[][])
			}));
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[11]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(SignatureHelper), GClass10.smethod_0(GClass10.smethod_0("º\u0098\u0089®\u0094\u009a\u0093\u009c\u0089\u0088\u008f\u0098", 199, 56), 58, 7), new Type[0]));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0(")\u001f\u000e6\u0015\u0019\u001b\u0016)\u0013\u001d\u0014\u001b\u000e\u000f\b\u001f", 143, 57), 245, 8), new Type[1] { typeof(byte[]) }));
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(BinaryReader), GClass10.smethod_0(GClass10.smethod_0("÷ÀÄÁçÊÊÉÀÄË", 27, 58), 190, 9), new Type[0]));
			iLGenerator.Emit(OpCodes.Brfalse_S, array[4]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666482));
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666483));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[16]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666482));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[17]);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[18]);
			iLGenerator.Emit(OpCodes.Br_S, array[5]);
			iLGenerator.MarkLabel(array[6]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666482));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[19]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666487));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[20]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[20]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(Type), GClass10.smethod_0(GClass10.smethod_0("\u008e\u008c\u009d¶½\u0090\u0099\u008c¡\u0088\u0087\u008d\u0085\u008c", 46, 59), 199, 10), new Type[0]));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("àÂÓóÈÌÂÉáÈÕ", 73, 60), 238, 11), new Type[1] { typeof(RuntimeTypeHandle) }));
			iLGenerator.Emit(OpCodes.Call, Class192.smethod_0(typeof(BitConverter), GClass10.smethod_0(GClass10.smethod_0("\u007f]LzAL]K", 14, 61), 54, 12), new Type[1] { typeof(int) }));
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[16]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[19]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(Array), GClass10.smethod_0(GClass10.smethod_0("\u008e¢½\u00b4\u0099¢", 212, 62), 25, 13), new Type[2]
			{
				typeof(Array),
				typeof(int)
			}));
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[18]);
			iLGenerator.Emit(OpCodes.Ldc_I4_1);
			iLGenerator.Emit(OpCodes.Add);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[18]);
			iLGenerator.MarkLabel(array[5]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[18]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[17]);
			iLGenerator.Emit(OpCodes.Blt_S, array[6]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[16]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("ýËÚëÖÍËÞÚÇÁÀÝ", 90, 63), 244, 14), new Type[1] { typeof(byte[]) }));
			iLGenerator.MarkLabel(array[4]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666482));
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666483));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[12]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666482));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[13]);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[21]);
			iLGenerator.Emit(OpCodes.Br, array[7]);
			iLGenerator.MarkLabel(array[20]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(BinaryReader), GClass10.smethod_0(GClass10.smethod_0("\u0093¤\u00a0¥\u0083\u00b8µ¤", 198, 64), 7, 15), new Type[0]));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[22]);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[23]);
			iLGenerator.Emit(OpCodes.Ldc_I4_M1);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[24]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[22]);
			iLGenerator.Emit(OpCodes.Switch, new Label[8]
			{
				array[8],
				array[8],
				array[9],
				array[9],
				array[10],
				array[11],
				array[12],
				array[13]
			});
			iLGenerator.Emit(OpCodes.Br, array[14]);
			iLGenerator.MarkLabel(array[8]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[22]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666488));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[27]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[27]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(Type), GClass10.smethod_0(GClass10.smethod_0("\u009e\u009c\u008d¦\u00ad\u0080\u0089\u009c±\u0098\u0097\u009d\u0095\u009c", 77, 65), 180, 16), new Type[0]));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("º\u0098\u0089©\u0092\u0096\u0098\u0093»\u0092\u008f", 106, 66), 151, 17), new Type[1] { typeof(RuntimeTypeHandle) }));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[23]);
			iLGenerator.Emit(OpCodes.Br, array[15]);
			iLGenerator.MarkLabel(array[9]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[22]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666491));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[28]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[28]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(MemberInfo), GClass10.smethod_0(GClass10.smethod_0("kixSHio`m~ebkXu|i", 33, 67), 45, 18), new Type[0]));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[29]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[29]);
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Call, Class192.smethod_0(typeof(Type), GClass10.smethod_0(GClass10.smethod_0("±®\u0081\u0097°»\u00af«¿²·ª§", 27, 68), 197, 19), new Type[2]
			{
				typeof(Type),
				typeof(Type)
			}));
			iLGenerator.Emit(OpCodes.Brfalse_S, array[16]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[28]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(MethodBase), GClass10.smethod_0(GClass10.smethod_0("\u00b4¶§\u008c\u009e¶§»¼·\u009b²½·¿¶", 184, 69), 107, 20), new Type[0]));
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[29]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(Type), GClass10.smethod_0(GClass10.smethod_0("ýÿîÅÎãêÿÒûôþöÿ", 60, 70), 166, 21), new Type[0]));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("\u0080¢³\u0093\u00a8¬¢©\u0081\u00a8µ", 211, 71), 20, 22), new Type[2]
			{
				typeof(RuntimeMethodHandle),
				typeof(RuntimeTypeHandle)
			}));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[23]);
			iLGenerator.Emit(OpCodes.Br, array[15]);
			iLGenerator.MarkLabel(array[16]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[28]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(MethodBase), GClass10.smethod_0(GClass10.smethod_0("tvgL^vg{|w[r}w\u007fv", 50, 72), 33, 23), new Type[0]));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("\u0005'6\u0016-)',\u0004-0", 141, 73), 207, 24), new Type[1] { typeof(RuntimeMethodHandle) }));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[23]);
			iLGenerator.Emit(OpCodes.Br, array[15]);
			iLGenerator.MarkLabel(array[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666486));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("\u000f-<\u001c'#-&\u000e':", 203, 74), 131, 25), new Type[1] { typeof(string) }));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[23]);
			iLGenerator.Emit(OpCodes.Br, array[15]);
			iLGenerator.MarkLabel(array[11]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666486));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[25]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666487));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[26]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[26]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[25]);
			iLGenerator.Emit(OpCodes.Ldc_I4_S, (sbyte)102);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(Type), GClass10.smethod_0(GClass10.smethod_0("ÙûêØ÷ûòú", 108, 75), 242, 26), new Type[2]
			{
				typeof(string),
				typeof(BindingFlags)
			}));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(FieldInfo), GClass10.smethod_0(GClass10.smethod_0("\u008a\u0088\u0099²«\u0084\u0088\u0081\u0089¥\u008c\u0083\u0089\u0081\u0088", 122, 76), 151, 27), new Type[0]));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("ûÙÈèÓ×ÙÒúÓÎ", 217, 77), 101, 28), new Type[1] { typeof(RuntimeFieldHandle) }));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[23]);
			iLGenerator.Emit(OpCodes.Br, array[15]);
			iLGenerator.MarkLabel(array[12]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldtoken, typeof(Class187));
			iLGenerator.Emit(OpCodes.Call, Class192.smethod_0(typeof(Type), GClass10.smethod_0(GClass10.smethod_0("\u0082\u00a0±\u0091¼µ\u00a0\u0083·ª\u00a8\u008d¤«¡©\u00a0", 94, 78), 155, 29), new Type[1] { typeof(RuntimeTypeHandle) }));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(Type), GClass10.smethod_0(GClass10.smethod_0("éëúÑÃáêûâë", 121, 79), 247, 30), new Type[0]));
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666482));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(Module), GClass10.smethod_0(GClass10.smethod_0("°\u0087\u0091\u008d\u008e\u0094\u0087¤\u008b\u0087\u008e\u0086", 153, 80), 123, 31), new Type[1] { typeof(int) }));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(FieldInfo), GClass10.smethod_0(GClass10.smethod_0("\u00b8º«\u0080\u0099¶º³»\u0097¾±»³º", 91, 81), 132, 32), new Type[0]));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("IkzZaek`Ha|", 24, 82), 22, 33), new Type[1] { typeof(RuntimeFieldHandle) }));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[23]);
			iLGenerator.Emit(OpCodes.Br, array[15]);
			iLGenerator.MarkLabel(array[13]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666493));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[30]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666482));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[31]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[31]);
			iLGenerator.Emit(OpCodes.Newarr, typeof(Type));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[32]);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[34]);
			iLGenerator.Emit(OpCodes.Br_S, array[17]);
			iLGenerator.MarkLabel(array[18]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[32]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[34]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666487));
			iLGenerator.Emit(OpCodes.Stelem_Ref);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[34]);
			iLGenerator.Emit(OpCodes.Ldc_I4_1);
			iLGenerator.Emit(OpCodes.Add);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[34]);
			iLGenerator.MarkLabel(array[17]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[34]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[31]);
			iLGenerator.Emit(OpCodes.Blt_S, array[18]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[30]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(MemberInfo), GClass10.smethod_0(GClass10.smethod_0("MO^unOIFKXCDM~SZO", 212, 83), 254, 34), new Type[0]));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[33]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[33]);
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Call, Class192.smethod_0(typeof(Type), GClass10.smethod_0(GClass10.smethod_0("(7\u0018\u000e)\"62&+.3>", 123, 84), 60, 35), new Type[2]
			{
				typeof(Type),
				typeof(Type)
			}));
			iLGenerator.Emit(OpCodes.Brfalse_S, array[19]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[30]);
			iLGenerator.Emit(OpCodes.Castclass, typeof(MethodInfo));
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[32]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(MethodInfo), GClass10.smethod_0(GClass10.smethod_0("ðÜÖØúØÓØÏÔÞðØÉÕÒÙ", 118, 85), 203, 36), new Type[1] { typeof(Type[]) }));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(MethodBase), GClass10.smethod_0(GClass10.smethod_0("ìîÿÔÆîÿãäïÃêåïçî", 106, 86), 225, 37), new Type[0]));
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[33]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(Type), GClass10.smethod_0(GClass10.smethod_0("\u0094\u0096\u0087¬§\u008a\u0083\u0096»\u0092\u009d\u0097\u009f\u0096", 149, 87), 102, 38), new Type[0]));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("WudD\u007f{u~V\u007fb", 143, 88), 159, 39), new Type[2]
			{
				typeof(RuntimeMethodHandle),
				typeof(RuntimeTypeHandle)
			}));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[23]);
			iLGenerator.Emit(OpCodes.Br_S, array[15]);
			iLGenerator.MarkLabel(array[19]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[30]);
			iLGenerator.Emit(OpCodes.Castclass, typeof(MethodInfo));
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[32]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(MethodInfo), GClass10.smethod_0(GClass10.smethod_0("oCIGeGLGPKAoGVJMF", 216, 89), 250, 40), new Type[1] { typeof(Type[]) }));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(MethodBase), GClass10.smethod_0(GClass10.smethod_0("ìîÿÔÆîÿãäïÃêåïçî", 117, 90), 254, 41), new Type[0]));
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("VteE~zt\u007fW~c", 60, 91), 45, 42), new Type[1] { typeof(RuntimeMethodHandle) }));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[23]);
			iLGenerator.Emit(OpCodes.Br_S, array[15]);
			iLGenerator.MarkLabel(array[14]);
			iLGenerator.Emit(OpCodes.Ldstr, GClass10.smethod_0(GClass10.smethod_0("©\u0092\u0097\u0092\u0093\u008b\u0092Ü\u0099\u008e\u008e\u0093\u008eÒ", 198, 92), 58, 43));
			iLGenerator.Emit(OpCodes.Call, Class192.smethod_0(typeof(Environment), GClass10.smethod_0(GClass10.smethod_0("½\u009a\u0092\u0097½\u009a\u0088\u008f", 56, 93), 195, 44), new Type[1] { typeof(string) }));
			iLGenerator.MarkLabel(array[15]);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			iLGenerator.Emit(OpCodes.Call, (MethodInfo)typeof(Class187).Module.ResolveMethod(100666482));
			iLGenerator.Emit(OpCodes.Stloc_S, array2[24]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[23]);
			iLGenerator.Emit(OpCodes.Call, Class192.smethod_0(typeof(BitConverter), GClass10.smethod_0(GClass10.smethod_0("FduCxudr", 87, 94), 86, 45), new Type[1] { typeof(int) }));
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[12]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[24]);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(Array), GClass10.smethod_0(GClass10.smethod_0("Dhw~Sh", 237, 95), 234, 46), new Type[2]
			{
				typeof(Array),
				typeof(int)
			}));
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[21]);
			iLGenerator.Emit(OpCodes.Ldc_I4_1);
			iLGenerator.Emit(OpCodes.Add);
			iLGenerator.Emit(OpCodes.Stloc_S, array2[21]);
			iLGenerator.MarkLabel(array[7]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[21]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[13]);
			iLGenerator.Emit(OpCodes.Blt, array[20]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[10]);
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[12]);
			iLGenerator.Emit(OpCodes.Ldloc_2);
			iLGenerator.Emit(OpCodes.Callvirt, Class192.smethod_0(typeof(DynamicILInfo), GClass10.smethod_0(GClass10.smethod_0("ïÙÈÿÓØÙ", 43, 96), 151, 47), new Type[2]
			{
				typeof(byte[]),
				typeof(int)
			}));
			iLGenerator.Emit(OpCodes.Ldloc_S, array2[9]);
			iLGenerator.Emit(OpCodes.Ret);
			delegate49_0 = (Delegate49)dynamicMethod.CreateDelegate(typeof(Delegate49));
		}
		return delegate49_0(binaryReader_0);
	}

	internal static string smethod_4(this BinaryReader binaryReader_0)
	{
		return Encoding.UTF8.GetString(smethod_1(binaryReader_0, smethod_0(binaryReader_0)));
	}

	internal static Type smethod_5(BinaryReader binaryReader_0)
	{
		return smethod_6(binaryReader_0.ReadByte(), binaryReader_0);
	}

	internal static Type smethod_6(byte byte_1, BinaryReader binaryReader_0)
	{
		if (byte_1 == 1)
		{
			int metadataToken = smethod_0(binaryReader_0);
			bool num = binaryReader_0.ReadBoolean();
			Type type = typeof(Class187).Module.ResolveType(metadataToken);
			if (!num)
			{
				return type;
			}
			return smethod_7(binaryReader_0, type);
		}
		string typeName = smethod_4(binaryReader_0);
		bool num2 = binaryReader_0.ReadBoolean();
		Type type2 = Type.GetType(typeName);
		if (!num2)
		{
			return type2;
		}
		return smethod_7(binaryReader_0, type2);
	}

	internal static Type smethod_7(BinaryReader binaryReader_0, Type type_0)
	{
		int num = smethod_0(binaryReader_0);
		Type[] array = new Type[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = smethod_5(binaryReader_0);
		}
		return type_0.MakeGenericType(array);
	}

	internal static Type smethod_8()
	{
		if (func_0 == null)
		{
			Type type = Type.GetType(GClass10.smethod_0("\u0081«¡¦·¿ü\u0096»³µ¼½¡¦»±¡ü\u0081¦³±¹\u0094\u00a0³¿·\u009a·¾¢·\u00a0", 210, 97));
			if (type == null)
			{
				return new StackTrace(5).GetFrame(0).GetMethod().DeclaringType;
			}
			MethodInfo method = typeof(StackTrace).GetMethod(GClass10.smethod_0("3\u0011\0'\0\u0015\u0017\u001f2\u0006\u0015\u0019\u0011\a=\u001a\0\u0011\u0006\u001a\u0015\u0018", 116, 98), BindingFlags.Static | BindingFlags.NonPublic);
			if (method == null)
			{
				return new StackTrace(5).GetFrame(0).GetMethod().DeclaringType;
			}
			DynamicMethod dynamicMethod = new DynamicMethod(GClass10.smethod_0("0\u0012\u0003$\u0003\u0016\u0014\u001c#\u0005\u0016\u0014\u00121\u0016\u0004\u0003", 119, 99), typeof(MethodBase), new Type[1] { typeof(int) }, typeof(StackTrace), skipVisibility: true);
			ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
			iLGenerator.DeclareLocal(type);
			ConstructorInfo constructor = type.GetConstructor(new Type[2]
			{
				typeof(bool),
				typeof(Thread)
			});
			if (constructor != null)
			{
				iLGenerator.Emit(OpCodes.Ldc_I4_0);
				iLGenerator.Emit(OpCodes.Ldnull);
			}
			else if ((constructor = type.GetConstructor(new Type[1] { typeof(Thread) })) != null)
			{
				iLGenerator.Emit(OpCodes.Ldnull);
			}
			iLGenerator.Emit(OpCodes.Newobj, constructor);
			iLGenerator.Emit(OpCodes.Stloc_0);
			iLGenerator.Emit(OpCodes.Ldloc_0);
			iLGenerator.Emit(OpCodes.Ldarg_0);
			if (method.GetParameters()[2].ParameterType == typeof(bool))
			{
				iLGenerator.Emit(OpCodes.Ldc_I4_0);
			}
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Call, method);
			iLGenerator.Emit(OpCodes.Ldloc_0);
			iLGenerator.Emit(OpCodes.Ldc_I4_0);
			iLGenerator.Emit(OpCodes.Callvirt, type.GetMethod(GClass10.smethod_0("¬\u008e\u009f¦\u008e\u009f\u0083\u0084\u008f©\u008a\u0098\u008e", 235, 100)));
			iLGenerator.Emit(OpCodes.Ret);
			func_0 = (Func<int, MethodBase>)dynamicMethod.CreateDelegate(typeof(Func<int, MethodBase>));
		}
		return func_0(5).DeclaringType;
	}

	internal static MethodBase smethod_9(byte byte_1, BinaryReader binaryReader_0)
	{
		Type type;
		Type[] array;
		string text;
		if (byte_1 == 3)
		{
			int metadataToken = smethod_0(binaryReader_0);
			bool num = binaryReader_0.ReadBoolean();
			MethodBase methodBase = typeof(Class187).Module.ResolveMethod(metadataToken);
			if (!num)
			{
				return methodBase;
			}
			type = smethod_5(binaryReader_0);
			int num2 = smethod_0(binaryReader_0);
			array = new Type[num2];
			for (int i = 0; i < num2; i++)
			{
				array[i] = smethod_5(binaryReader_0);
			}
			text = methodBase.Name;
			if (methodBase.Name != GClass10.smethod_0("ä©¾¥\u00b8", 202, 101))
			{
				return smethod_10(methodBase.Name, methodBase.GetGenericArguments().Length, type, array);
			}
		}
		else
		{
			text = smethod_4(binaryReader_0);
			type = smethod_5(binaryReader_0);
			int num3 = smethod_0(binaryReader_0);
			array = new Type[num3];
			for (int j = 0; j < num3; j++)
			{
				array[j] = smethod_5(binaryReader_0);
			}
			bool num4 = binaryReader_0.ReadBoolean();
			int int_ = 0;
			if (num4)
			{
				int_ = smethod_0(binaryReader_0);
			}
			if (num4 && text != GClass10.smethod_0("S\u001e\t\u0012\u000f", 125, 102))
			{
				MethodBase methodBase2 = smethod_10(text, int_, type, array);
				if (methodBase2 != null)
				{
					return methodBase2;
				}
			}
		}
		if (text == GClass10.smethod_0("é¤³\u00a8µ", 199, 103))
		{
			return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, array, null);
		}
		return type.GetMethod(text, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, array, null);
	}

	internal static MethodBase smethod_10(string string_0, int int_0, Type type_0, Type[] type_1)
	{
		MethodInfo[] methods = type_0.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		int num = 0;
		MethodInfo methodInfo;
		while (true)
		{
			if (num < methods.Length)
			{
				methodInfo = methods[num];
				if (!(string_0 != methodInfo.Name))
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (parameters.Length == type_1.Length)
					{
						bool flag = true;
						for (int i = 0; i < parameters.Length; i++)
						{
							Type parameterType = parameters[i].ParameterType;
							Type type = type_1[i];
							if (parameterType.IsGenericType && type.IsGenericType)
							{
								if (parameterType.GetGenericTypeDefinition() != type.GetGenericTypeDefinition())
								{
									flag = false;
								}
							}
							else if (parameterType != type)
							{
								flag = false;
							}
						}
						if (flag && methodInfo.GetGenericArguments().Length == int_0)
						{
							break;
						}
					}
				}
				num++;
				continue;
			}
			return null;
		}
		return methodInfo;
	}

	internal static MethodBase smethod_11(BinaryReader binaryReader_0)
	{
		return smethod_9(binaryReader_0.ReadByte(), binaryReader_0);
	}
}
