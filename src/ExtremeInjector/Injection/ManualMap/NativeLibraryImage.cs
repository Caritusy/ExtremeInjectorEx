using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public sealed class NativeLibraryImage
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public delegate bool Delegate45(IntPtr intptr_0, uint uint_0, IntPtr intptr_1);

	internal readonly PeImage class154_0;

	internal byte[] byte_0;

	internal Delegate45 delegate45_0;

	internal readonly List<Delegate45> list_0 = new List<Delegate45>();

	internal readonly List<IntPtr> list_1 = new List<IntPtr>();

	[CompilerGenerated]
	internal IntPtr intptr_0;

	internal static readonly NativeTypes.Enum34[][][] enum34_0 = new NativeTypes.Enum34[2][][]
	{
		new NativeTypes.Enum34[2][]
		{
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_4,
				NativeTypes.Enum34.flag_7
			},
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_5,
				NativeTypes.Enum34.flag_6
			}
		},
		new NativeTypes.Enum34[2][]
		{
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_0,
				NativeTypes.Enum34.flag_3
			},
			new NativeTypes.Enum34[2]
			{
				NativeTypes.Enum34.flag_1,
				NativeTypes.Enum34.flag_2
			}
		}
	};

	[SpecialName]
	[CompilerGenerated]
	public IntPtr method_0()
	{
		return intptr_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(IntPtr intptr_1)
	{
		intptr_0 = intptr_1;
	}

	public NativeLibraryImage(PeImage class154_1, bool bool_0)
	{
		class154_0 = class154_1;
		if (class154_0 == null)
		{
			throw new BadImageFormatException("The module bytes do not represent a valid portable executable image.");
		}
		if ((RecoveredRuntime.smethod_19(class154_0) && IntPtr.Size != 4) || (!RecoveredRuntime.smethod_19(class154_0) && IntPtr.Size != 8))
		{
			throw new BadImageFormatException("The image format of the module bytes does not match the process.");
		}
		method_3(bool_0);
	}

	public NativeLibraryImage(byte[] byte_1, bool bool_0)
		: this(RecoveredRuntime.smethod_356(byte_1, PeImageLayout.const_0), bool_0)
	{
		class154_0.System_002EIDisposable_002EDispose();
	}

	public IntPtr method_2(string string_0)
	{
		if (this.class154_0.method_14() != null && !(this.method_0() == IntPtr.Zero))
		{
			foreach (ExportedSymbol @class in this.class154_0.method_14().list_1)
			{
				if (@class.method_0() && @class.method_4() == string_0)
				{
					return this.method_0().smethod_9((long)((ulong)@class.method_6()));
				}
			}
			return IntPtr.Zero;
		}
		return IntPtr.Zero;
	}

	internal void method_3(bool bool_0)
	{
		this.method_1(RecoveredRuntime.VirtualAlloc((IntPtr)((long)this.class154_0.method_6().method_3().imethod_17()), (UIntPtr)this.class154_0.method_6().method_3().imethod_29(), NativeTypes.Enum33.flag_0 | NativeTypes.Enum33.flag_1, NativeTypes.Enum34.flag_6));
		if (this.method_0() == IntPtr.Zero)
		{
			this.method_1(RecoveredRuntime.VirtualAlloc(IntPtr.Zero, (UIntPtr)this.class154_0.method_6().method_3().imethod_29(), NativeTypes.Enum33.flag_0 | NativeTypes.Enum33.flag_1, NativeTypes.Enum34.flag_6));
		}
		if (bool_0)
		{
			int num = (int)(this.class154_0.method_4().method_0() + this.class154_0.method_6().method_3().imethod_31());
			using (Stream stream = RecoveredRuntime.smethod_264(this.class154_0, 0L, num))
			{
				byte[] array = new byte[num];
				stream.Read(array, 0, num);
				Marshal.Copy(array, 0, this.method_0(), array.Length);
			}
		}
		this.method_8();
		if (this.class154_0.method_16() != null)
		{
			IntPtr intPtr = this.method_0().smethod_11((IntPtr)((long)this.class154_0.method_6().method_3().imethod_17()));
			if (intPtr != IntPtr.Zero)
			{
				this.method_7(intPtr);
			}
		}
		this.method_5(this.class154_0.method_10());
		if (this.class154_0.method_12() != null)
		{
			this.method_5(this.class154_0.method_12());
		}
		this.method_4();
		if (this.class154_0.method_20() != null)
		{
			foreach (ulong num2 in this.class154_0.method_20().list_0)
			{
				long long_ = (long)(num2 - this.class154_0.method_6().method_3().imethod_17());
				IntPtr ptr = this.method_0().smethod_9(long_);
				NativeLibraryImage.Delegate45 @delegate = (NativeLibraryImage.Delegate45)Marshal.GetDelegateForFunctionPointer(ptr, typeof(NativeLibraryImage.Delegate45));
				if (!@delegate(this.method_0(), 1u, IntPtr.Zero))
				{
					throw new Exception(EncodedStringTable.smethod_0(9232) + ptr.ToString(EncodedStringTable.smethod_0(2077)) + EncodedStringTable.smethod_0(9277));
				}
				this.list_0.Add(@delegate);
			}
		}
		if (this.class154_0.method_6().method_3().imethod_11() != 0u)
		{
			IntPtr ptr2 = this.method_0().smethod_9((long)((ulong)this.class154_0.method_6().method_3().imethod_11()));
			this.delegate45_0 = (NativeLibraryImage.Delegate45)Marshal.GetDelegateForFunctionPointer(ptr2, typeof(NativeLibraryImage.Delegate45));
			if (!this.delegate45_0(this.method_0(), 1u, IntPtr.Zero))
			{
				throw new Exception(EncodedStringTable.smethod_0(9302));
			}
		}
	}

	internal void method_4()
	{
		foreach (PeSectionHeader section in class154_0.method_8())
		{
			IntPtr address = method_0().smethod_9(section.method_4());
			SectionCharacteristics characteristics = section.method_18();
			if ((characteristics & SectionCharacteristics.flag_28) != 0)
			{
				RecoveredRuntime.VirtualFree(address, (UIntPtr)section.method_2(), NativeTypes.Enum28.const_0);
				continue;
			}

			bool executable = (characteristics & SectionCharacteristics.flag_32) != 0;
			bool readable = (characteristics & SectionCharacteristics.flag_33) != 0;
			bool writable = (characteristics & SectionCharacteristics.flag_34) != 0;
			NativeTypes.Enum34 protection = enum34_0[executable ? 1 : 0][readable ? 1 : 0][writable ? 1 : 0];
			if ((characteristics & SectionCharacteristics.flag_29) != 0)
			{
				protection |= NativeTypes.Enum34.flag_9;
			}

			if (!RecoveredRuntime.VirtualProtect(address, (UIntPtr)section.method_2(), protection, out _))
			{
				throw new AccessViolationException("Unable to change the protection of the section, '" + section.method_0() + "'.");
			}
		}
	}

	internal void method_5(ImportDirectory class148_0)
	{
		if (this.byte_0 == null)
		{
			this.byte_0 = this.method_6();
		}
		IntPtr value = NativeTypes.intptr_0;
		IntPtr zero = IntPtr.Zero;
		if (this.byte_0 != null)
		{
			string tempFileName = Path.GetTempFileName();
			File.WriteAllBytes(tempFileName, this.byte_0);
			NativeTypes.Struct50 @struct = default(NativeTypes.Struct50);
			@struct.int_0 = Marshal.SizeOf(typeof(NativeTypes.Struct50));
			@struct.string_0 = tempFileName;
			NativeTypes.Struct50 struct2 = @struct;
			value = RecoveredRuntime.CreateActCtx(ref struct2);
			RecoveredRuntime.ActivateActCtx(value, out zero);
			File.Delete(tempFileName);
		}
		for (int i = 0; i < class148_0.list_0.Count; i++)
		{
			ImportDescriptor @class = class148_0.list_0[i];
			IntPtr ptr = this.method_0().smethod_9((long)((ulong)@class.method_6()));
			string text = @class.method_12();
			IntPtr intPtr = RecoveredRuntime.LoadLibrary(text);
			if (intPtr == IntPtr.Zero)
			{
				throw new DllNotFoundException(EncodedStringTable.smethod_0(9433) + text + EncodedStringTable.smethod_0(9470));
			}
			this.list_1.Add(intPtr);
			foreach (ImportedSymbol class2 in @class.method_8())
			{
				string text2 = class2.method_7() ? ((char)class2.method_2()).ToString() : class2.method_4();
				IntPtr procAddress = RecoveredRuntime.GetProcAddress(intPtr, text2);
				if (procAddress == IntPtr.Zero && !class2.method_7())
				{
					throw new MissingMethodException(string.Concat(new string[]
					{
						EncodedStringTable.smethod_0(9531),
						text2,
						EncodedStringTable.smethod_0(9572),
						text,
						EncodedStringTable.smethod_0(9428)
					}));
				}
				Marshal.WriteIntPtr(ptr, procAddress);
				ptr = ptr.smethod_8(IntPtr.Size);
			}
		}
		if (value != NativeTypes.intptr_0)
		{
			RecoveredRuntime.DeactivateActCtx(0, zero);
			RecoveredRuntime.ReleaseActCtx(value);
		}
	}

	internal byte[] method_6()
	{
		if (this.class154_0.method_23() == null)
		{
			return null;
		}
		foreach (ResourceDirectoryNode @class in this.class154_0.method_23().method_0().method_6())
		{
			if (RecoveredRuntime.smethod_89(@class) && @class.method_2() == 24 && @class.method_6().Count == 1 && @class.method_6()[0].method_4().Count == 1)
			{
				ResourceDataEntry class2 = @class.method_6()[0].method_4()[0];
				long num = RecoveredRuntime.smethod_135(this.class154_0, class2.method_4());
				if (num != -1L)
				{
					byte[] array = new byte[class2.method_6()];
					using (Stream stream = RecoveredRuntime.smethod_264(this.class154_0, num, (int)class2.method_6()))
					{
						stream.Read(array, 0, array.Length);
					}
					return array;
				}
			}
		}
		return null;
	}

	internal void method_7(IntPtr intptr_1)
	{
		foreach (BaseRelocationBlock @class in this.class154_0.method_16().list_0)
		{
			foreach (BaseRelocationEntry class2 in @class.list_0)
			{
				if (class2.method_2() == BaseRelocationType.Dir64 || class2.method_2() == BaseRelocationType.HighLow)
				{
					IntPtr ptr = this.method_0().smethod_9((long)((ulong)(@class.method_0() + class2.method_0())));
					IntPtr intPtr = Marshal.ReadIntPtr(ptr);
					Marshal.WriteIntPtr(ptr, intPtr.smethod_10(intptr_1));
				}
			}
		}
	}

	internal void method_8()
	{
		foreach (PeSectionHeader gclass in this.class154_0.method_8())
		{
			IntPtr intPtr;
			if (gclass.method_6() != 0u)
			{
				IntPtr destination = RecoveredRuntime.VirtualAlloc(this.method_0().smethod_9((long)((ulong)gclass.method_4())), (UIntPtr)gclass.method_6(), NativeTypes.Enum33.flag_0, NativeTypes.Enum34.flag_6);
				using (Stream stream = RecoveredRuntime.smethod_264(this.class154_0, (long)((ulong)gclass.method_8()), (int)gclass.method_6()))
				{
					byte[] array = new byte[gclass.method_6()];
					stream.Read(array, 0, array.Length);
					Marshal.Copy(array, 0, destination, array.Length);
					continue;
				}
			}
			else
			{
				intPtr = RecoveredRuntime.VirtualAlloc(this.method_0().smethod_9((long)((ulong)gclass.method_4())), (UIntPtr)gclass.method_2(), NativeTypes.Enum33.flag_0, NativeTypes.Enum34.flag_6);
			}
			long long_ = (long)((ulong)gclass.method_2());
			RecoveredRuntime.smethod_361(long_, intPtr, 0);
		}
	}

	internal static BadImageFormatException smethod_0(string string_0)
	{
		return new BadImageFormatException(string_0);
	}

	internal static bool smethod_1(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	internal static int smethod_2(Stream stream_0, byte[] byte_1, int int_0, int int_1)
	{
		return stream_0.Read(byte_1, int_0, int_1);
	}

	internal static void smethod_3(byte[] byte_1, int int_0, IntPtr intptr_1, int int_1)
	{
		Marshal.Copy(byte_1, int_0, intptr_1, int_1);
	}

	internal static void smethod_4(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	internal static Type smethod_5(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static Delegate smethod_6(IntPtr intptr_1, Type type_0)
	{
		return Marshal.GetDelegateForFunctionPointer(intptr_1, type_0);
	}

	internal static string smethod_7(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	internal static AccessViolationException smethod_8(string string_0)
	{
		return new AccessViolationException(string_0);
	}

	internal static string smethod_9()
	{
		return Path.GetTempFileName();
	}

	internal static void smethod_10(string string_0, byte[] byte_1)
	{
		File.WriteAllBytes(string_0, byte_1);
	}

	internal static int smethod_11(Type type_0)
	{
		return Marshal.SizeOf(type_0);
	}

	internal static void smethod_12(string string_0)
	{
		File.Delete(string_0);
	}

	internal static DllNotFoundException smethod_13(string string_0)
	{
		return new DllNotFoundException(string_0);
	}

	internal static IntPtr smethod_14(IntPtr intptr_1)
	{
		return Marshal.ReadIntPtr(intptr_1);
	}

	internal static void smethod_15(IntPtr intptr_1, IntPtr intptr_2)
	{
		Marshal.WriteIntPtr(intptr_1, intptr_2);
	}
}
