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
			return base.CanConvertFrom(context, sourceType);
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
			return RecoveredRuntime.CreateImmediate((UIntPtr)value);
		}
		if (value is sbyte)
		{
			return RecoveredRuntime.CreateImmediate((sbyte)value);
		}
		if (value is byte)
		{
			return RecoveredRuntime.CreateImmediate((byte)value);
		}
		if (value is short)
		{
			return RecoveredRuntime.CreateImmediate((short)value);
		}
		if (value is ushort)
		{
			return RecoveredRuntime.CreateImmediate((ushort)value);
		}
		if (value is int)
		{
			return RecoveredRuntime.CreateImmediate((int)value);
		}
		if (value is uint)
		{
			return RecoveredRuntime.CreateImmediate((uint)value);
		}
		if (value is long)
		{
			return RecoveredRuntime.CreateImmediate((long)value);
		}
		if (value is ulong)
		{
			return RecoveredRuntime.CreateImmediate((ulong)value);
		}
		if (value is float)
		{
			return RecoveredRuntime.CreateImmediate((float)value);
		}
		if (value is double)
		{
			return RecoveredRuntime.CreateImmediate((double)value);
		}
		if (value is bool)
		{
			return new AsmJitImmediate((IntPtr)(((bool)value) ? 1 : 0));
		}
		return null;
	}
}
