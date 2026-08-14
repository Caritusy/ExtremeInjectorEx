public abstract class LzmaCodecConstants
{
	public struct Struct88
	{
		public uint uint_0;

		public void Initialize()
		{
			uint_0 = 0u;
		}

		public void UpdateLiteral()
		{
			if (uint_0 < 4)
			{
				uint_0 = 0u;
			}
			else if (uint_0 < 10)
			{
				uint_0 -= 3u;
			}
			else
			{
				uint_0 -= 6u;
			}
		}

		public void UpdateMatch()
		{
			uint_0 = ((uint_0 < 7) ? 7u : 10u);
		}

		public void UpdateRepeatedMatch()
		{
			uint_0 = ((uint_0 < 7) ? 8u : 11u);
		}

		public void UpdateShortRepeatedMatch()
		{
			uint_0 = ((uint_0 < 7) ? 9u : 11u);
		}

		public bool IsLiteralState()
		{
			return uint_0 < 7;
		}
	}

	public const uint uint_0 = default(uint);

	public const uint uint_1 = default(uint);

	public const int int_0 = default(int);

	public const int int_1 = default(int);

	public const uint uint_2 = default(uint);

	public const uint uint_3 = default(uint);

	public const int int_2 = default(int);

	public const uint uint_4 = default(uint);

	public const uint uint_5 = default(uint);

	public const uint uint_6 = default(uint);

	public const uint uint_7 = default(uint);

	public const uint uint_8 = default(uint);

	public const int int_3 = default(int);

	public const uint uint_9 = default(uint);

	public const int int_4 = default(int);

	public const uint uint_10 = default(uint);

	public const int int_5 = default(int);

	public const int int_6 = default(int);

	public const int int_7 = default(int);

	public const uint uint_11 = default(uint);

	public const uint uint_12 = default(uint);

	public const uint uint_13 = default(uint);

	public const uint uint_14 = default(uint);

	public static uint GetLengthToPositionState(uint uint_15)
	{
		uint_15 -= 2;
		if (uint_15 < 4)
		{
			return uint_15;
		}
		return 3u;
	}
}
