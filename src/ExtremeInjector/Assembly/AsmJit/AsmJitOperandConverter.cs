using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

public sealed class AsmJitOperandConverter : TypeConverter
{
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		if (!new Type[14]
		{
			typeof(IntPtr),
			typeof(UIntPtr),
			typeof(int),
			typeof(uint),
			typeof(long),
			typeof(ulong),
			typeof(ushort),
			typeof(short),
			typeof(float),
			typeof(double),
			typeof(bool),
			typeof(byte),
			typeof(sbyte),
			typeof(AsmJitImmediate)
		}.Contains(sourceType))
		{
			return method_0(context, sourceType);
		}
		return true;
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is AsmJitImmediate)
		{
			return value;
		}
		if (value is IntPtr)
		{
			return new AsmJitImmediate((IntPtr)value);
		}
		if (value is UIntPtr)
		{
			return RecoveredRuntime.smethod_301((UIntPtr)value);
		}
		if (value is sbyte)
		{
			return RecoveredRuntime.smethod_59((sbyte)value);
		}
		if (value is byte)
		{
			return RecoveredRuntime.smethod_72((byte)value);
		}
		if (value is short)
		{
			return RecoveredRuntime.smethod_344((short)value);
		}
		if (value is ushort)
		{
			return RecoveredRuntime.smethod_384((ushort)value);
		}
		if (value is int)
		{
			return RecoveredRuntime.smethod_167((int)value);
		}
		if (value is uint)
		{
			return RecoveredRuntime.smethod_374((uint)value);
		}
		if (value is long)
		{
			return RecoveredRuntime.smethod_195((long)value);
		}
		if (value is ulong)
		{
			return RecoveredRuntime.smethod_125((ulong)value);
		}
		if (value is float)
		{
			return RecoveredRuntime.smethod_423((float)value);
		}
		if (value is double)
		{
			return RecoveredRuntime.smethod_446((double)value);
		}
		if (value is bool)
		{
			return new AsmJitImmediate((IntPtr)(((bool)value) ? 1 : 0));
		}
		return null;
	}

	internal static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal bool method_0(ITypeDescriptorContext itypeDescriptorContext_0, Type type_0)
	{
		return base.CanConvertFrom(itypeDescriptorContext_0, type_0);
	}
}
