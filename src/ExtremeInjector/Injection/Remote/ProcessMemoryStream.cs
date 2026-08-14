using System;
using System.IO;

public sealed class ProcessMemoryStream : Stream, ILengthValidator
{
	internal ProcessMemoryAccess processMemoryAccess;

	internal long length;

	internal long longValue;

	internal IntPtr address;

	internal IntPtr address2;

	internal bool flag;

	internal bool flag2 = true;

	public override bool CanRead
	{
		get
		{
			return this.flag && (this.processMemoryAccess == ProcessMemoryAccess.Read || this.processMemoryAccess == ProcessMemoryAccess.ReadWrite);
		}
	}

	public override bool CanSeek => flag;

	public override bool CanWrite
	{
		get
		{
			return this.flag && (this.processMemoryAccess == ProcessMemoryAccess.Write || this.processMemoryAccess == ProcessMemoryAccess.ReadWrite);
		}
	}

	public override long Length
	{
		get
		{
			RecoveredRuntime.EnsureStreamOpen(this);
			return length;
		}
	}

	public override long Position
	{
		get
		{
			RecoveredRuntime.EnsureStreamOpen(this);
			return longValue;
		}
		set
		{
			RecoveredRuntime.EnsureStreamOpen(this);
			longValue = value;
		}
	}

	public ProcessMemoryStream(RemoteProcess remoteProcess, IntPtr address3, ProcessMemoryAccess processMemoryAccess2, long longValue2)
		: this((remoteProcess.Handle != IntPtr.Zero) ? remoteProcess.Handle : RecoveredRuntime.OpenProcessMemoryHandle(remoteProcess.ProcessId, processMemoryAccess2), address3, processMemoryAccess2, longValue2)
	{
		if (remoteProcess.Handle != IntPtr.Zero)
		{
			this.flag2 = false;
		}
	}

	public ProcessMemoryStream(IntPtr address3, IntPtr address4, ProcessMemoryAccess processMemoryAccess2, long longValue2)
	{
		if (address3 == IntPtr.Zero)
		{
			throw new ArgumentException("hProcess cannot be IntPtr.Zero. Ensure the process or handle is valid.", "hProcess");
		}
		if (longValue2 < -1L)
		{
			throw new ArgumentException("length cannot be less than -1.", "length");
		}
		processMemoryAccess = processMemoryAccess2;
		length = ((longValue2 == -1L) ? RecoveredRuntime.CalculateProcessMemoryLength(this, address4) : longValue2);
		address = address3;
		address2 = address4;
		flag = true;
	}

	protected override void Dispose(bool disposing)
	{
		if (this.address != IntPtr.Zero && this.flag2)
		{
			RecoveredRuntime.CloseHandle(this.address);
			this.address = IntPtr.Zero;
		}
		this.flag = false;
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
			this.longValue = offset;
			break;
		case SeekOrigin.Current:
			if (this.longValue + offset < 0L)
			{
				throw new IOException(EncodedStringTable.DecodeString(8755));
			}
			this.longValue += offset;
			break;
		case SeekOrigin.End:
			if (this.length + offset < 0L)
			{
				throw new IOException(EncodedStringTable.DecodeString(8755));
			}
			this.longValue = this.length + offset;
			break;
		}
		return this.longValue;
	}

	public override void SetLength(long value)
	{
		RecoveredRuntime.EnsureStreamOpen(this);
		this.length = value;
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
		if (count == 0 || longValue >= length)
		{
			return 0;
		}

		int bytesToRead = (int)Math.Min((long)count, length - longValue);
		UIntPtr bytesRead = UIntPtr.Zero;
		bool succeeded;
		fixed (byte* pointer = buffer)
		{
			succeeded = RecoveredRuntime.ReadProcessMemoryBuffer(address, address2.Add(longValue), pointer + offset,
				(UIntPtr)(ulong)bytesToRead, &bytesRead);
		}
		int result = (int)bytesRead.ToUInt64();
		if (!succeeded && result == 0)
		{
			return 0;
		}
		longValue += result;
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
			succeeded = RecoveredRuntime.WriteProcessMemoryBuffer(address, address2.Add(longValue), pointer + offset,
				(UIntPtr)(ulong)count, &bytesWritten);
		}
		if (!succeeded)
		{
			throw new AccessViolationException();
		}
		longValue += (long)bytesWritten.ToUInt64();
}

	public bool IsValidOffset(long longValue2)
	{
		if (longValue2 >= 0L)
		{
			return longValue2 <= length;
		}
		return false;
	}
}
