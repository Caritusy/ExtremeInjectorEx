using System;
using System.Runtime.Serialization;

[Serializable]
public sealed class RemoteExecutionTimeoutException : TimeoutException
{
	public RemoteExecutionTimeoutException(string message)
		: base(message)
	{
	}

	public RemoteExecutionTimeoutException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	private RemoteExecutionTimeoutException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
