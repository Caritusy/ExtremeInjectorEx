using System;
using System.IO;

public sealed class ProcessMemoryStream : Stream, ILengthValidator
{
	internal ProcessMemoryAccess enum15_0;

	internal long long_0;

	internal long long_1;

	internal IntPtr intptr_0;

	internal IntPtr intptr_1;

	internal bool bool_0;

	internal bool bool_1 = true;

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
			RecoveredRuntime.EnsureStreamOpen(this);
			return long_0;
		}
	}

	public override long Position
	{
		get
		{
			RecoveredRuntime.EnsureStreamOpen(this);
			return long_1;
		}
		set
		{
			RecoveredRuntime.EnsureStreamOpen(this);
			long_1 = value;
		}
	}

	public ProcessMemoryStream(RemoteProcess gclass2_0, IntPtr intptr_2, ProcessMemoryAccess enum15_1, long long_2)
		: this((gclass2_0.Handle != IntPtr.Zero) ? gclass2_0.Handle : RecoveredRuntime.OpenProcessMemoryHandle(gclass2_0.ProcessId, enum15_1), intptr_2, enum15_1, long_2)
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
		long_0 = ((long_2 == -1L) ? RecoveredRuntime.CalculateProcessMemoryLength(this, intptr_3) : long_2);
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
		RecoveredRuntime.EnsureStreamOpen(this);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		RecoveredRuntime.EnsureStreamOpen(this);
		switch (origin)
		{
		case SeekOrigin.Begin:
			if (offset < 0L)
			{
				throw new IOException(EncodedStringTable.DecodeString(8755));
			}
			this.long_1 = offset;
			break;
		case SeekOrigin.Current:
			if (this.long_1 + offset < 0L)
			{
				throw new IOException(EncodedStringTable.DecodeString(8755));
			}
			this.long_1 += offset;
			break;
		case SeekOrigin.End:
			if (this.long_0 + offset < 0L)
			{
				throw new IOException(EncodedStringTable.DecodeString(8755));
			}
			this.long_1 = this.long_0 + offset;
			break;
		}
		return this.long_1;
	}

	public override void SetLength(long value)
	{
		RecoveredRuntime.EnsureStreamOpen(this);
		this.long_0 = value;
	}

	public unsafe override int Read(byte[] buffer, int offset, int count)
	{
		RecoveredRuntime.EnsureStreamOpen(this);
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
			succeeded = RecoveredRuntime.ReadProcessMemoryBuffer(intptr_0, intptr_1.Add(long_1), pointer + offset,
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
		RecoveredRuntime.EnsureStreamOpen(this);
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

		UIntPtr bytesWritten = UIntPtr.Zero;
		bool succeeded;
		fixed (byte* pointer = buffer)
		{
			succeeded = RecoveredRuntime.WriteProcessMemoryBuffer(intptr_0, intptr_1.Add(long_1), pointer + offset,
				(UIntPtr)(ulong)count, &bytesWritten);
		}
		if (!succeeded)
		{
			throw new AccessViolationException();
		}
		long_1 += (long)bytesWritten.ToUInt64();
}

	public bool IsValidOffset(long long_2)
	{
		if (long_2 >= 0L)
		{
			return long_2 <= long_0;
		}
		return false;
	}
}
