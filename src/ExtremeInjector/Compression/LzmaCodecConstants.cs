public abstract class LzmaCodecConstants
{
	public struct LzmaState
	{
		public uint isLiteralState;

		public void Initialize()
		{
			isLiteralState = 0u;
		}

		public void UpdateLiteral()
		{
			if (isLiteralState < 4)
			{
				isLiteralState = 0u;
			}
			else if (isLiteralState < 10)
			{
				isLiteralState -= 3u;
			}
			else
			{
				isLiteralState -= 6u;
			}
		}

		public void UpdateMatch()
		{
			isLiteralState = ((isLiteralState < 7) ? 7u : 10u);
		}

		public void UpdateRepeatedMatch()
		{
			isLiteralState = ((isLiteralState < 7) ? 8u : 11u);
		}

		public void UpdateShortRepeatedMatch()
		{
			isLiteralState = ((isLiteralState < 7) ? 9u : 11u);
		}

		public bool IsLiteralState()
		{
			return isLiteralState < 7;
		}
	}

	public const uint uintValue = default(uint);

	public const uint uintValue2 = default(uint);

	public const int intValue = default(int);

	public const int intValue2 = default(int);

	public const uint uintValue3 = default(uint);

	public const uint uintValue4 = default(uint);

	public const int intValue3 = default(int);

	public const uint uintValue5 = default(uint);

	public const uint uintValue6 = default(uint);

	public const uint uintValue7 = default(uint);

	public const uint uintValue8 = default(uint);

	public const uint uintValue9 = default(uint);

	public const int intValue4 = default(int);

	public const uint uintValue10 = default(uint);

	public const int intValue5 = default(int);

	public const uint uintValue11 = default(uint);

	public const int intValue6 = default(int);

	public const int intValue7 = default(int);

	public const int intValue8 = default(int);

	public const uint uintValue12 = default(uint);

	public const uint uintValue13 = default(uint);

	public const uint uintValue14 = default(uint);

	public const uint uintValue15 = default(uint);

	public static uint GetLengthToPositionState(uint uintValue16)
	{
		uintValue16 -= 2;
		if (uintValue16 < 4)
		{
			return uintValue16;
		}
		return 3u;
	}
}
