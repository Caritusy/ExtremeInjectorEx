public sealed class NativeThreadInfo
{
	internal NativeTypes.SystemThreadInformation systemThreadInformation;

	internal NativeThreadInfo(NativeTypes.SystemThreadInformation systemThreadInformation2)
	{
		this.systemThreadInformation = systemThreadInformation2;
	}
}
