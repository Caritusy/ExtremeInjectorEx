using System;

public class LzmaInvalidParameterException : ApplicationException
{
	public LzmaInvalidParameterException()
		: base("Invalid Parameter")
	{
	}
}
