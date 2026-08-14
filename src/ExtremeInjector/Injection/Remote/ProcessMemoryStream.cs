using System;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class ProcessMemoryStream : Stream, ILengthValidator
{
	internal ProcessMemoryAccess enum15_0;

	internal long long_0;

	internal long long_1;

	internal IntPtr intptr_0;

	internal IntPtr intptr_1;

	internal bool bool_0;

	internal bool bool_1 = true;

	[CompilerGenerated]
	internal bool bool_2;

	public override bool CanRead
	{
		get
		{
			return this.bool_0 && (this.enum15_0 == ProcessMemoryAccess.const_0 || this.enum15_0 == ProcessMemoryAccess.const_2);
		}
	}

	public override bool CanSeek => bool_0;

	public override bool CanWrite
	{
		get
		{
			return this.bool_0 && (this.enum15_0 == ProcessMemoryAccess.const_1 || this.enum15_0 == ProcessMemoryAccess.const_2);
		}
	}

	public override long Length
	{
		get
		{
			RecoveredRuntime.smethod_156(this);
			return long_0;
		}
	}

	public override long Position
	{
		get
		{
			RecoveredRuntime.smethod_156(this);
			return long_1;
		}
		set
		{
			RecoveredRuntime.smethod_156(this);
			long_1 = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_0()
	{
		return bool_2;
	}

	public ProcessMemoryStream(RemoteProcess gclass2_0, IntPtr intptr_2, ProcessMemoryAccess enum15_1, long long_2)
		: this((gclass2_0.Handle != IntPtr.Zero) ? gclass2_0.Handle : RecoveredRuntime.smethod_253(gclass2_0.ProcessId, enum15_1), intptr_2, enum15_1, long_2)
	{
		if (gclass2_0.Handle != IntPtr.Zero)
		{
			this.bool_1 = false;
		}
	}

	public ProcessMemoryStream(IntPtr intptr_2, IntPtr intptr_3, ProcessMemoryAccess enum15_1, long long_2)
	{
		if (intptr_2 == IntPtr.Zero)
		{
			throw new ArgumentException("hProcess cannot be IntPtr.Zero. Ensure the process or handle is valid.", "hProcess");
		}
		if (long_2 < -1L)
		{
			throw new ArgumentException("length cannot be less than -1.", "length");
		}
		enum15_0 = enum15_1;
		long_0 = ((long_2 == -1L) ? RecoveredRuntime.smethod_407(this, intptr_3) : long_2);
		intptr_0 = intptr_2;
		intptr_1 = intptr_3;
		bool_0 = true;
	}

	protected override void Dispose(bool disposing)
	{
		if (this.intptr_0 != IntPtr.Zero && this.bool_1)
		{
			RecoveredRuntime.CloseHandle(this.intptr_0);
			this.intptr_0 = IntPtr.Zero;
		}
		this.bool_0 = false;
		base.Dispose(disposing);
	}

	public override void Flush()
	{
		RecoveredRuntime.smethod_156(this);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		RecoveredRuntime.smethod_156(this);
		switch (origin)
		{
		case SeekOrigin.Begin:
			if (offset < 0L)
			{
				throw new IOException(EncodedStringTable.smethod_0(8755));
			}
			this.long_1 = offset;
			break;
		case SeekOrigin.Current:
			if (this.long_1 + offset < 0L)
			{
				throw new IOException(EncodedStringTable.smethod_0(8755));
			}
			this.long_1 += offset;
			break;
		case SeekOrigin.End:
			if (this.long_0 + offset < 0L)
			{
				throw new IOException(EncodedStringTable.smethod_0(8755));
			}
			this.long_1 = this.long_0 + offset;
			break;
		}
		return this.long_1;
	}

	public override void SetLength(long value)
	{
		RecoveredRuntime.smethod_156(this);
		this.long_0 = value;
	}

	public unsafe override int Read(byte[] buffer, int offset, int count)
	{
		RecoveredRuntime.smethod_156(this);
		if (buffer == null)
		{
			throw new ArgumentNullException(nameof(buffer));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(offset));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(count));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException("The buffer is too small for the requested range.", nameof(buffer));
		}
		if (!CanRead)
		{
			throw new InvalidOperationException("The stream does not support reading.");
		}
		if (count == 0 || long_1 >= long_0)
		{
			return 0;
		}

		int bytesToRead = (int)Math.Min((long)count, long_0 - long_1);
		UIntPtr bytesRead = UIntPtr.Zero;
		bool succeeded;
		fixed (byte* pointer = buffer)
		{
			succeeded = RecoveredRuntime.ReadProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), pointer + offset,
				(UIntPtr)(ulong)bytesToRead, &bytesRead);
		}
		int result = (int)bytesRead.ToUInt64();
		if (!succeeded && result == 0)
		{
			return 0;
		}
		long_1 += result;
		return result;
}

	public unsafe override void Write(byte[] buffer, int offset, int count)
	{
		RecoveredRuntime.smethod_156(this);
		if (buffer == null)
		{
			throw new ArgumentNullException(nameof(buffer));
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(offset));
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(count));
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException("The buffer is too small for the requested range.", nameof(buffer));
		}
		if (!CanWrite)
		{
			throw new InvalidOperationException("The stream does not support writing.");
		}
		if (count == 0)
		{
			return;
		}

		NativeTypes.Enum34 oldProtection = default(NativeTypes.Enum34);
		bool protectionChanged = false;
		if (method_0())
		{
			protectionChanged = RecoveredRuntime.VirtualProtectEx(intptr_0, intptr_1.smethod_9(long_1),
				(UIntPtr)(ulong)count, NativeTypes.Enum34.flag_2, out oldProtection);
			if (!protectionChanged)
			{
				throw new AccessViolationException();
			}
		}

		UIntPtr bytesWritten = UIntPtr.Zero;
		bool succeeded;
		fixed (byte* pointer = buffer)
		{
			succeeded = RecoveredRuntime.WriteProcessMemory_1(intptr_0, intptr_1.smethod_9(long_1), pointer + offset,
				(UIntPtr)(ulong)count, &bytesWritten);
		}
		if (protectionChanged)
		{
			RecoveredRuntime.VirtualProtectEx(intptr_0, intptr_1.smethod_9(long_1), (UIntPtr)(ulong)count,
				oldProtection, out oldProtection);
		}
		if (!succeeded)
		{
			throw new AccessViolationException();
		}
		long_1 += (long)bytesWritten.ToUInt64();
}

	public bool imethod_0(long long_2)
	{
		if (long_2 >= 0L)
		{
			return long_2 <= long_0;
		}
		return false;
	}

	internal static ArgumentException smethod_0(string string_0, string string_1)
	{
		return new ArgumentException(string_0, string_1);
	}

	internal static IOException smethod_1(string string_0)
	{
		return new IOException(string_0);
	}

	internal static ArgumentNullException smethod_2(string string_0)
	{
		return new ArgumentNullException(string_0);
	}

	internal static ArgumentOutOfRangeException smethod_3(string string_0)
	{
		return new ArgumentOutOfRangeException(string_0);
	}

	internal static ArgumentException smethod_4(string string_0)
	{
		return new ArgumentException(string_0);
	}

	internal static bool smethod_5(Stream stream_0)
	{
		return stream_0.CanRead;
	}

	internal static InvalidOperationException smethod_6(string string_0)
	{
		return new InvalidOperationException(string_0);
	}

	internal static bool smethod_7(Stream stream_0)
	{
		return stream_0.CanWrite;
	}

	internal static AccessViolationException smethod_8()
	{
		return new AccessViolationException();
	}
}
