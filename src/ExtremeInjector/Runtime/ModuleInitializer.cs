using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

internal class _003CModule_003E
{
	public struct BitDecoder
	{
		internal uint uintValue;

		internal void Initialize()
		{
			uintValue = 1024u;
		}

		internal uint Decode(RangeDecoder rangeDecoder)
		{
			uint num = (rangeDecoder.uintValue2 >> 11) * this.uintValue;
			if (rangeDecoder.uintValue >= num)
			{
				rangeDecoder.uintValue2 -= num;
				rangeDecoder.uintValue -= num;
				this.uintValue -= this.uintValue >> 5;
				if (rangeDecoder.uintValue2 < 16777216u)
				{
					rangeDecoder.uintValue = (rangeDecoder.uintValue << 8 | (uint)((byte)rangeDecoder.stream.ReadByte()));
					rangeDecoder.uintValue2 <<= 8;
				}
				return 1u;
			}
			rangeDecoder.uintValue2 = num;
			this.uintValue += 2048u - this.uintValue >> 5;
			if (rangeDecoder.uintValue2 < 16777216u)
			{
				rangeDecoder.uintValue = (rangeDecoder.uintValue << 8 | (uint)((byte)rangeDecoder.stream.ReadByte()));
				rangeDecoder.uintValue2 <<= 8;
			}
			return 0u;
		}
	}

	public struct BitTreeDecoder
	{
		internal readonly BitDecoder[] bitDecoderArray;

		internal readonly int intValue;

		internal BitTreeDecoder(int intValue2)
		{
			intValue = intValue2;
			bitDecoderArray = new BitDecoder[1 << intValue2];
		}

		internal void Initialize()
		{
			uint num = 1u;
			while ((ulong)num < (ulong)(1L << (this.intValue & 31)))
			{
				this.bitDecoderArray[(int)((UIntPtr)num)].Initialize();
				num += 1u;
			}
		}

		internal uint Decode(RangeDecoder rangeDecoder)
		{
			uint num = 1u;
			for (int i = this.intValue; i > 0; i--)
			{
				num = (num << 1) + this.bitDecoderArray[(int)((UIntPtr)num)].Decode(rangeDecoder);
			}
			return num - (1u << this.intValue);
		}

		internal uint ReverseDecode(RangeDecoder rangeDecoder)
		{
			uint num = 1u;
			uint num2 = 0u;
			for (int i = 0; i < this.intValue; i++)
			{
				uint num3 = this.bitDecoderArray[(int)((UIntPtr)num)].Decode(rangeDecoder);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		internal static uint ReverseDecode(BitDecoder[] bitDecoderArray2, uint uintValue, RangeDecoder rangeDecoder, int intValue2)
		{
			uint num = 1u;
			uint num2 = 0u;
			for (int i = 0; i < intValue2; i++)
			{
				uint num3 = bitDecoderArray2[(int)((UIntPtr)(uintValue + num))].Decode(rangeDecoder);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}
	}

	public class RangeDecoder
	{
		internal uint uintValue;

		internal uint uintValue2;

		internal Stream stream;

		internal void Initialize(Stream stream2)
		{
			this.stream = stream2;
			this.uintValue = 0u;
			this.uintValue2 = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.uintValue = (this.uintValue << 8 | (uint)((byte)this.stream.ReadByte()));
			}
		}

		internal void ReleaseStream()
		{
			stream = null;
		}

		internal void Normalize()
		{
			while (this.uintValue2 < 16777216u)
			{
				this.uintValue = (this.uintValue << 8 | (uint)((byte)this.stream.ReadByte()));
				this.uintValue2 <<= 8;
			}
		}

		internal uint DecodeDirectBits(int intValue)
		{
			uint num = this.uintValue2;
			uint num2 = this.uintValue;
			uint num3 = 0u;
			for (int i = intValue; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= (num & num4 - 1u);
				num3 = (num3 << 1 | 1u - num4);
				if (num < 16777216u)
				{
					num2 = (num2 << 8 | (uint)((byte)this.stream.ReadByte()));
					num <<= 8;
				}
			}
			this.uintValue2 = num;
			this.uintValue = num2;
			return num3;
		}

		internal RangeDecoder()
		{
		}
	}

	public class EmbeddedLzmaDecoder
	{
		public class LengthDecoder
		{
			internal readonly BitTreeDecoder[] bitTreeDecoderArray = new BitTreeDecoder[16];

			internal readonly BitTreeDecoder[] bitTreeDecoderArray2 = new BitTreeDecoder[16];

			internal BitDecoder bitDecoder = default(BitDecoder);

			internal BitDecoder bitDecoder2 = default(BitDecoder);

			internal BitTreeDecoder bitTreeDecoder = new BitTreeDecoder(8);

			internal uint uintValue;

			internal void Create(uint uintValue2)
			{
				for (uint num = this.uintValue; num < uintValue2; num += 1u)
				{
					this.bitTreeDecoderArray[(int)((UIntPtr)num)] = new _003CModule_003E.BitTreeDecoder(3);
					this.bitTreeDecoderArray2[(int)((UIntPtr)num)] = new _003CModule_003E.BitTreeDecoder(3);
				}
				this.uintValue = uintValue2;
			}

			internal void Initialize()
			{
				this.bitDecoder.Initialize();
				for (uint num = 0u; num < this.uintValue; num += 1u)
				{
					this.bitTreeDecoderArray[(int)((UIntPtr)num)].Initialize();
					this.bitTreeDecoderArray2[(int)((UIntPtr)num)].Initialize();
				}
				this.bitDecoder2.Initialize();
				this.bitTreeDecoder.Initialize();
			}

			internal uint Decode(RangeDecoder rangeDecoder, uint uintValue2)
			{
				if (this.bitDecoder.Decode(rangeDecoder) == 0u)
				{
					return this.bitTreeDecoderArray[(int)((UIntPtr)uintValue2)].Decode(rangeDecoder);
				}
				uint num = 8u;
				if (this.bitDecoder2.Decode(rangeDecoder) != 0u)
				{
					num += 8u;
					num += this.bitTreeDecoder.Decode(rangeDecoder);
				}
				else
				{
					num += this.bitTreeDecoderArray2[(int)((UIntPtr)uintValue2)].Decode(rangeDecoder);
				}
				return num;
			}

			internal LengthDecoder()
			{
			}
		}

		public class LiteralDecoder
		{
			public struct LiteralSubdecoder
			{
				internal BitDecoder[] bitDecoderArray;

				internal void Create()
				{
					bitDecoderArray = new BitDecoder[768];
				}

				internal void Initialize()
				{
					for (int i = 0; i < 768; i++)
					{
						this.bitDecoderArray[i].Initialize();
					}
				}

				internal byte DecodeNormal(RangeDecoder rangeDecoder)
				{
					uint num = 1u;
					do
					{
						num = (num << 1 | this.bitDecoderArray[(int)((UIntPtr)num)].Decode(rangeDecoder));
					}
					while (num < 256u);
					return (byte)num;
				}

				internal byte DecodeWithMatchByte(RangeDecoder rangeDecoder, byte byteValue)
				{
					uint num = 1u;
					while (num < 256u)
					{
						uint num2 = (uint)(byteValue >> 7 & 1);
						byteValue = (byte)(byteValue << 1);
						uint num3 = this.bitDecoderArray[(int)((UIntPtr)((1u + num2 << 8) + num))].Decode(rangeDecoder);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							while (num < 256u)
							{
								num = (num << 1 | this.bitDecoderArray[(int)((UIntPtr)num)].Decode(rangeDecoder));
							}
							return (byte)num;
						}
					}
					return (byte)num;
				}
			}

			internal LiteralSubdecoder[] literalSubdecoderArray;

			internal int intValue;

			internal int intValue2;

			internal uint uintValue;

			internal void Create(int intValue3, int intValue4)
			{
				if (this.literalSubdecoderArray == null || this.intValue2 != intValue4 || this.intValue != intValue3)
				{
					this.intValue = intValue3;
					this.uintValue = (1u << intValue3) - 1u;
					this.intValue2 = intValue4;
					uint num = 1u << this.intValue2 + this.intValue;
					this.literalSubdecoderArray = new _003CModule_003E.EmbeddedLzmaDecoder.LiteralDecoder.LiteralSubdecoder[num];
					for (uint num2 = 0u; num2 < num; num2 += 1u)
					{
						this.literalSubdecoderArray[(int)((UIntPtr)num2)].Create();
					}
					return;
				}
			}

			internal void Initialize()
			{
				uint num = 1u << this.intValue2 + this.intValue;
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					this.literalSubdecoderArray[(int)((UIntPtr)num2)].Initialize();
				}
			}

			internal uint GetDecoderIndex(uint uintValue2, byte byteValue)
			{
				return ((uintValue2 & uintValue) << intValue2) + (uint)(byteValue >> 8 - intValue2);
			}

			internal byte DecodeNormal(RangeDecoder rangeDecoder, uint uintValue2, byte byteValue)
			{
				return literalSubdecoderArray[GetDecoderIndex(uintValue2, byteValue)].DecodeNormal(rangeDecoder);
			}

			internal byte DecodeWithMatchByte(RangeDecoder rangeDecoder, uint uintValue2, byte byteValue, byte byteValue2)
			{
				return literalSubdecoderArray[GetDecoderIndex(uintValue2, byteValue)].DecodeWithMatchByte(rangeDecoder, byteValue2);
			}

			internal LiteralDecoder()
			{
			}
		}

		internal readonly BitDecoder[] bitDecoderArray = new BitDecoder[192];

		internal readonly BitDecoder[] bitDecoderArray2 = new BitDecoder[192];

		internal readonly BitDecoder[] bitDecoderArray3 = new BitDecoder[12];

		internal readonly BitDecoder[] bitDecoderArray4 = new BitDecoder[12];

		internal readonly BitDecoder[] bitDecoderArray5 = new BitDecoder[12];

		internal readonly BitDecoder[] bitDecoderArray6 = new BitDecoder[12];

		internal readonly LengthDecoder lengthDecoder = new LengthDecoder();

		internal readonly LiteralDecoder literalProperties = new LiteralDecoder();

		internal readonly OutputWindow outputWindow = new OutputWindow();

		internal readonly BitDecoder[] bitDecoderArray7 = new BitDecoder[114];

		internal readonly BitTreeDecoder[] bitTreeDecoderArray = new BitTreeDecoder[4];

		internal readonly RangeDecoder rangeDecoder = new RangeDecoder();

		internal readonly LengthDecoder lengthDecoder2 = new LengthDecoder();

		internal bool flag;

		internal uint uintValue;

		internal uint uintValue2;

		internal BitTreeDecoder bitTreeDecoder = new BitTreeDecoder(4);

		internal uint uintValue3;

		internal EmbeddedLzmaDecoder()
		{
			this.uintValue = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.bitTreeDecoderArray[num] = new _003CModule_003E.BitTreeDecoder(6);
				num++;
			}
		}

		internal void SetDictionarySize(uint uintValue4)
		{
			if (this.uintValue != uintValue4)
			{
				this.uintValue = uintValue4;
				this.uintValue2 = Math.Max(this.uintValue, 1u);
				uint uintValue5 = Math.Max(this.uintValue2, 4096u);
				this.outputWindow.Create(uintValue5);
			}
		}

		internal void SetLiteralProperties(int intValue, int intValue2)
		{
			literalProperties.Create(intValue, intValue2);
		}

		internal void SetPositionBits(int intValue)
		{
			uint num = 1u << intValue;
			this.lengthDecoder.Create(num);
			this.lengthDecoder2.Create(num);
			this.uintValue3 = num - 1u;
		}

		internal void Initialize(Stream stream, Stream stream2)
		{
			this.rangeDecoder.Initialize(stream);
			this.outputWindow.SetStream(stream2, this.flag);
			for (uint num = 0u; num < 12u; num += 1u)
			{
				for (uint num2 = 0u; num2 <= this.uintValue3; num2 += 1u)
				{
					uint num3 = (num << 4) + num2;
					this.bitDecoderArray[(int)((UIntPtr)num3)].Initialize();
					this.bitDecoderArray2[(int)((UIntPtr)num3)].Initialize();
				}
				this.bitDecoderArray3[(int)((UIntPtr)num)].Initialize();
				this.bitDecoderArray4[(int)((UIntPtr)num)].Initialize();
				this.bitDecoderArray5[(int)((UIntPtr)num)].Initialize();
				this.bitDecoderArray6[(int)((UIntPtr)num)].Initialize();
			}
			this.literalProperties.Initialize();
			for (uint num = 0u; num < 4u; num += 1u)
			{
				this.bitTreeDecoderArray[(int)((UIntPtr)num)].Initialize();
			}
			for (uint num = 0u; num < 114u; num += 1u)
			{
				this.bitDecoderArray7[(int)((UIntPtr)num)].Initialize();
			}
			this.lengthDecoder.Initialize();
			this.lengthDecoder2.Initialize();
			this.bitTreeDecoder.Initialize();
		}

		internal void Decode(Stream stream, Stream stream2, long longValue, long longValue2)
		{
			this.Initialize(stream, stream2);
			_003CModule_003E.DecoderState @struct = default(_003CModule_003E.DecoderState);
			@struct.Initialize();
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			ulong num5 = 0UL;
			if (num5 < (ulong)longValue2)
			{
				this.bitDecoderArray[(int)((UIntPtr)(@struct.isLiteralState << 4))].Decode(this.rangeDecoder);
				@struct.UpdateLiteral();
				byte byte_ = this.literalProperties.DecodeNormal(this.rangeDecoder, 0u, 0);
				this.outputWindow.PutByte(byte_);
				num5 += 1UL;
			}
			while (num5 < (ulong)longValue2)
			{
				uint num6 = (uint)num5 & this.uintValue3;
				if (this.bitDecoderArray[(int)((UIntPtr)((@struct.isLiteralState << 4) + num6))].Decode(this.rangeDecoder) != 0u)
				{
					uint num7;
					if (this.bitDecoderArray3[(int)((UIntPtr)@struct.isLiteralState)].Decode(this.rangeDecoder) != 1u)
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num7 = 2u + this.lengthDecoder.Decode(this.rangeDecoder, num6);
						@struct.UpdateMatch();
						uint num8 = this.bitTreeDecoderArray[(int)((UIntPtr)_003CModule_003E.EmbeddedLzmaDecoder.GetLengthToPositionState(num7))].Decode(this.rangeDecoder);
						if (num8 < 4u)
						{
							num = num8;
						}
						else
						{
							int num9 = (int)((num8 >> 1) - 1u);
							num = (2u | (num8 & 1u)) << num9;
							if (num8 < 14u)
							{
								num += _003CModule_003E.BitTreeDecoder.ReverseDecode(this.bitDecoderArray7, num - num8 - 1u, this.rangeDecoder, num9);
							}
							else
							{
								num += this.rangeDecoder.DecodeDirectBits(num9 - 4) << 4;
								num += this.bitTreeDecoder.ReverseDecode(this.rangeDecoder);
							}
						}
					}
					else
					{
						if (this.bitDecoderArray4[(int)((UIntPtr)@struct.isLiteralState)].Decode(this.rangeDecoder) == 0u)
						{
							if (this.bitDecoderArray2[(int)((UIntPtr)((@struct.isLiteralState << 4) + num6))].Decode(this.rangeDecoder) == 0u)
							{
								@struct.UpdateShortRepeatedMatch();
								this.outputWindow.PutByte(this.outputWindow.GetByte(num));
								num5 += 1UL;
								continue;
							}
						}
						else
						{
							uint num10;
							if (this.bitDecoderArray5[(int)((UIntPtr)@struct.isLiteralState)].Decode(this.rangeDecoder) != 0u)
							{
								if (this.bitDecoderArray6[(int)((UIntPtr)@struct.isLiteralState)].Decode(this.rangeDecoder) != 0u)
								{
									num10 = num4;
									num4 = num3;
								}
								else
								{
									num10 = num3;
								}
								num3 = num2;
							}
							else
							{
								num10 = num2;
							}
							num2 = num;
							num = num10;
						}
						num7 = this.lengthDecoder2.Decode(this.rangeDecoder, num6) + 2u;
						@struct.UpdateRepeatedMatch();
					}
					if (((ulong)num >= num5 || num >= this.uintValue2) && num == 4294967295u)
					{
						break;
					}
					this.outputWindow.CopyBlock(num, num7);
					num5 += (ulong)num7;
				}
				else
				{
					byte byteValue = this.outputWindow.GetByte(0u);
					byte byteValue2;
					if (!@struct.IsLiteralState())
					{
						byteValue2 = this.literalProperties.DecodeWithMatchByte(this.rangeDecoder, (uint)num5, byteValue, this.outputWindow.GetByte(num));
					}
					else
					{
						byteValue2 = this.literalProperties.DecodeNormal(this.rangeDecoder, (uint)num5, byteValue);
					}
					this.outputWindow.PutByte(byteValue2);
					@struct.UpdateLiteral();
					num5 += 1UL;
				}
			}
			this.outputWindow.Flush();
			this.outputWindow.ReleaseStream();
			this.rangeDecoder.ReleaseStream();
		}

		internal void SetDecoderProperties(byte[] bytes)
		{
			int int_ = (int)(bytes[0] % 9);
			int num = (int)(bytes[0] / 9);
			int intValue = num % 5;
			int intValue2 = num / 5;
			uint num2 = 0u;
			for (int i = 0; i < 4; i++)
			{
				num2 += (uint)((uint)bytes[1 + i] << i * 8);
			}
			this.SetDictionarySize(num2);
			this.SetLiteralProperties(intValue, int_);
			this.SetPositionBits(intValue2);
		}

		internal static uint GetLengthToPositionState(uint uintValue4)
		{
			uintValue4 -= 2;
			if (uintValue4 < 4)
			{
				return uintValue4;
			}
			return 3u;
		}
	}

	public class OutputWindow
	{
		internal byte[] bytes;

		internal uint uintValue;

		internal Stream stream;

		internal uint uintValue2;

		internal uint uintValue3;

		internal void Create(uint uintValue4)
		{
			if (this.uintValue3 != uintValue4)
			{
				this.bytes = new byte[uintValue4];
			}
			this.uintValue3 = uintValue4;
			this.uintValue = 0u;
			this.uintValue2 = 0u;
		}

		internal void SetStream(Stream stream2, bool flag)
		{
			this.ReleaseStream();
			this.stream = stream2;
			if (!flag)
			{
				this.uintValue2 = 0u;
				this.uintValue = 0u;
			}
		}

		internal void ReleaseStream()
		{
			this.Flush();
			this.stream = null;
			Buffer.BlockCopy(new byte[this.bytes.Length], 0, this.bytes, 0, this.bytes.Length);
		}

		internal void Flush()
		{
			uint num = this.uintValue - this.uintValue2;
			if (num == 0u)
			{
				return;
			}
			this.stream.Write(this.bytes, (int)this.uintValue2, (int)num);
			if (this.uintValue >= this.uintValue3)
			{
				this.uintValue = 0u;
			}
			this.uintValue2 = this.uintValue;
		}

		internal void CopyBlock(uint uintValue4, uint uintValue5)
		{
			uint num = this.uintValue - uintValue4 - 1u;
			if (num >= this.uintValue3)
			{
				num += this.uintValue3;
			}
			while (uintValue5 > 0u)
			{
				if (num >= this.uintValue3)
				{
					num = 0u;
				}
				this.bytes[(int)((UIntPtr)(this.uintValue++))] = this.bytes[(int)((UIntPtr)(num++))];
				if (this.uintValue >= this.uintValue3)
				{
					this.Flush();
				}
				uintValue5 -= 1u;
			}
		}

		internal void PutByte(byte byteValue)
		{
			this.bytes[(int)((UIntPtr)(this.uintValue++))] = byteValue;
			if (this.uintValue >= this.uintValue3)
			{
				this.Flush();
			}
		}

		internal byte GetByte(uint uintValue4)
		{
			uint num = this.uintValue - uintValue4 - 1u;
			if (num >= this.uintValue3)
			{
				num += this.uintValue3;
			}
			return this.bytes[(int)((UIntPtr)num)];
		}

		internal OutputWindow()
		{
		}
	}

	public struct DecoderState
	{
		internal uint isLiteralState;

		internal void Initialize()
		{
			isLiteralState = 0u;
		}

		internal void UpdateLiteral()
		{
			if (this.isLiteralState < 4u)
			{
				this.isLiteralState = 0u;
				return;
			}
			if (this.isLiteralState < 10u)
			{
				this.isLiteralState -= 3u;
				return;
			}
			this.isLiteralState -= 6u;
		}

		internal void UpdateMatch()
		{
			isLiteralState = ((isLiteralState < 7) ? 7u : 10u);
		}

		internal void UpdateRepeatedMatch()
		{
			isLiteralState = ((isLiteralState < 7) ? 8u : 11u);
		}

		internal void UpdateShortRepeatedMatch()
		{
			isLiteralState = ((isLiteralState < 7) ? 9u : 11u);
		}

		internal bool IsLiteralState()
		{
			return isLiteralState < 7;
		}
	}

	[StructLayout(LayoutKind.Explicit, Size = 512)]
	public struct EmbeddedPayloadData
	{
	}

	internal static byte[] bytes;

	internal static EmbeddedPayloadData embeddedPayloadData/* Not supported: data(A8 85 AA 74 54 FB A6 4E 03 25 A1 5E 1E CF AF 7C 7A 4C 56 E6 04 CC D2 05 4A A0 59 62 34 FC AA 8C 48 29 1D F6 A9 59 37 B3 D6 B4 81 3D 60 2F 18 D2 8C D3 60 CB 5D 70 B3 64 2B 93 DE 94 63 FB AA CA E9 02 77 6B DD E1 DA 30 A7 84 33 F2 87 B1 25 EE CC 36 62 D1 E3 54 D4 76 3A A3 B9 EA F5 40 57 E6 82 9B A8 50 3F 91 34 8C 01 78 C5 7E DE 90 E4 82 03 64 27 B9 70 2B E2 97 34 FA B9 76 AC F3 C9 EC B2 C6 DC 45 D1 D8 59 ED 41 3E 7B B1 99 AE B4 F3 92 DE A6 97 AC E8 CA 87 68 4F BC 4D 3F 13 31 F8 68 07 F6 71 37 A5 CA 84 A9 FB 67 C7 EF FA 93 49 4B 7C 1C 1C ED 40 E9 C6 7A 83 A9 89 0B DD FC DF 44 F6 F2 5D C1 51 8B 8A 8C 11 36 F7 E0 E4 C7 B2 6E AD 78 14 FC DF 6D 6A 62 80 30 85 84 F9 0A 83 7E F8 F2 4E F8 3B 23 61 B7 47 48 5E E3 4E 2E 45 83 D9 75 DB 3F C8 2D ED 02 A0 F4 C5 88 00 C4 39 88 07 3A 82 2D 55 7C 19 2A D4 EB 0D 1E 95 9D D8 55 29 EF 8A FD E1 E6 6F 1B DE 60 37 BB 90 E5 56 C1 5F 2A C3 34 37 F3 8F 8F 87 E3 0D D8 BF 9D CF 36 7B FE E7 5C 73 7D 27 8B C9 BB 42 46 D6 17 46 61 57 D5 D1 1F DF 8D 7A 4A 62 7F 04 1C 80 21 D7 14 85 72 88 68 3C 20 CA EE 8D 6E AE 43 09 8E 13 16 37 38 4A 72 7B 11 C2 FF 84 F0 F5 79 C7 4E B6 42 35 E8 F2 7C 30 9E 79 F4 EF 61 48 5A 89 97 DC EF F4 5D 94 AB 46 9B AA F8 59 F7 3E 0C 20 10 78 96 05 44 47 23 C4 5A 69 EB 88 B0 C5 EE 6A 9E 20 FC 15 AA BF 5E 24 55 79 20 C3 9B F6 7A 91 05 A7 53 47 1B 05 3C 7B F4 C2 80 F5 34 A8 BD 3C E7 25 83 CD 7F AF B6 E0 86 56 9B 0F AA 8B 46 06 DA 60 BF 23 5C 0D 55 40 11 5F E4 8E 2D 65 5F 99 69 64 1F 6E 87 33 9F 63 9B 81 52 E2 9B F6 7A 91 05 A7 53 47 1B 05 3C 7B F4 C2 80 F5 34 A8 BD 3C E7 25) */;

	static _003CModule_003E()
	{
		_003CModule_003E.InitializeConstantTable();
		RecoveredRuntime.InitializeRuntimeResolvers();
		RecoveredRuntime.InitializeResourceResolver();
	}

	internal static byte[] DecompressLzmaPayload(byte[] bytes2)
	{
		MemoryStream memoryStream = new MemoryStream(bytes2);
		_003CModule_003E.EmbeddedLzmaDecoder @class = new _003CModule_003E.EmbeddedLzmaDecoder();
		byte[] buffer = new byte[5];
		memoryStream.Read(buffer, 0, 5);
		@class.SetDecoderProperties(buffer);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array, true);
		long long_ = memoryStream.Length - 13L;
		@class.Decode(memoryStream, stream_, long_, num);
		return array;
	}

	internal static void InitializeConstantTable()
	{
		uint num = 128u;
		uint[] array = new uint[]
		{
			1957332392u,
			1319566164u,
			1587619075u,
			2091896606u,
			3864415354u,
			97700868u,
			1650040906u,
			2360015924u,
			4129106248u,
			3006749097u,
			1031910614u,
			3524800352u,
			3412120460u,
			1689481309u,
			2497614635u,
			3400203107u,
			1802961641u,
			819651037u,
			4063462567u,
			3995447687u,
			3512874700u,
			1993626851u,
			3938034490u,
			3864477941u,
			1353227138u,
			2352255295u,
			2126870529u,
			2196017374u,
			3106366467u,
			2548181872u,
			1991899700u,
			3972658092u,
			1172096690u,
			3982088401u,
			2977644097u,
			4088704665u,
			2544295570u,
			2278221996u,
			1304186728u,
			4163965759u,
			1911949160u,
			2227873079u,
			3345480617u,
			1234434799u,
			471628875u,
			3337175277u,
			2309587834u,
			3757890827u,
			1576203844u,
			2324386241u,
			4147515788u,
			2999444704u,
			343453038u,
			1785585660u,
			2234548322u,
			2198534532u,
			1324546174u,
			1629699064u,
			1581795255u,
			1160662755u,
			3681933699u,
			3979200575u,
			3321143298u,
			969146504u,
			2184841096u,
			427578669u,
			233559082u,
			3634205982u,
			2330929493u,
			1877402109u,
			929095195u,
			1457885371u,
			3274334145u,
			2415081268u,
			233015183u,
			3483221976u,
			3892214582u,
			662532956u,
			1119603083u,
			1175967302u,
			3520419681u,
			2056118047u,
			75457098u,
			3609296924u,
			2289206548u,
			3391110248u,
			2926480878u,
			328075587u,
			1245198102u,
			3255925618u,
			4126180607u,
			3058616185u,
			4075304258u,
			2040410236u,
			1214377972u,
			3700918618u,
			2489185519u,
			2862302891u,
			1056397816u,
			2014322700u,
			1195640214u,
			1767556131u,
			3316680939u,
			547252974u,
			3215595004u,
			2035623006u,
			4137403168u,
			2802159994u,
			85673811u,
			3270802236u,
			2822043008u,
			635911357u,
			2944388483u,
			1451679926u,
			2343178139u,
			1624901190u,
			224142271u,
			1594966101u,
			1697484516u,
			1684642143u,
			864513567u,
			2174444447u,
			4137411154u,
			2802159994u,
			85673811u,
			3270802236u,
			2822043008u,
			635911357u
		};
		uint[] array2 = new uint[16];
		uint num2 = 581480289u;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 12;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4u];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = (array3[0] ^ array2[0]);
			array3[1] = (array3[1] ^ array2[1]);
			array3[2] = (array3[2] ^ array2[2]);
			array3[3] = (array3[3] ^ array2[3]);
			array3[4] = (array3[4] ^ array2[4]);
			array3[5] = (array3[5] ^ array2[5]);
			array3[6] = (array3[6] ^ array2[6]);
			array3[7] = (array3[7] ^ array2[7]);
			array3[8] = (array3[8] ^ array2[8]);
			array3[9] = (array3[9] ^ array2[9]);
			array3[10] = (array3[10] ^ array2[10]);
			array3[11] = (array3[11] ^ array2[11]);
			array3[12] = (array3[12] ^ array2[12]);
			array3[13] = (array3[13] ^ array2[13]);
			array3[14] = (array3[14] ^ array2[14]);
			array3[15] = (array3[15] ^ array2[15]);
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		_003CModule_003E.bytes = _003CModule_003E.DecompressLzmaPayload(array4);
	}

	internal static T DecodeConstantWithKeyA<T>(uint uintValue)
	{
		uintValue = (uintValue * 319591615u ^ 1651505086u);
		uint num = uintValue >> 30;
		T result = default(T);
		uintValue &= 1073741823u;
		uintValue <<= 2;
		if ((ulong)num != 0UL)
		{
			if ((ulong)num == 2UL)
			{
				T[] array = new T[1];
				Buffer.BlockCopy(_003CModule_003E.bytes, (int)uintValue, array, 0, Marshal.SizeOf(typeof(T)));
				result = array[0];
			}
			else if ((ulong)num == 1UL)
			{
				int num2 = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
				int length = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
				Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(_003CModule_003E.bytes, (int)uintValue, array2, 0, num2 - 4);
				result = (T)((object)array2);
			}
		}
		else
		{
			int count = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(_003CModule_003E.bytes, (int)uintValue, count)));
		}
		return result;
	}

	internal static T DecodeConstantWithKeyB<T>(uint uintValue)
	{
		uintValue = (uintValue * 119080739u ^ 3110504502u);
		uint num = uintValue >> 30;
		T result = default(T);
		uintValue &= 1073741823u;
		uintValue <<= 2;
		if ((ulong)num != 1UL)
		{
			if ((ulong)num == 2UL)
			{
				T[] array = new T[1];
				Buffer.BlockCopy(_003CModule_003E.bytes, (int)uintValue, array, 0, Marshal.SizeOf(typeof(T)));
				result = array[0];
			}
			else if ((ulong)num == 3UL)
			{
				int num2 = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
				int length = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
				Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(_003CModule_003E.bytes, (int)uintValue, array2, 0, num2 - 4);
				result = (T)((object)array2);
			}
		}
		else
		{
			int count = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(_003CModule_003E.bytes, (int)uintValue, count)));
		}
		return result;
	}

	internal static T DecodeConstantWithKeyC<T>(uint uintValue)
	{
		uintValue = (uintValue * 4058603021u ^ 1194576908u);
		uint num = uintValue >> 30;
		T result = default(T);
		uintValue &= 1073741823u;
		uintValue <<= 2;
		if ((ulong)num != 3UL)
		{
			if ((ulong)num != 1UL)
			{
				if ((ulong)num == 0UL)
				{
					int num2 = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
					int length = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
					Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
					Buffer.BlockCopy(_003CModule_003E.bytes, (int)uintValue, array, 0, num2 - 4);
					result = (T)((object)array);
				}
			}
			else
			{
				T[] array2 = new T[1];
				Buffer.BlockCopy(_003CModule_003E.bytes, (int)uintValue, array2, 0, Marshal.SizeOf(typeof(T)));
				result = array2[0];
			}
		}
		else
		{
			int count = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(_003CModule_003E.bytes, (int)uintValue, count)));
		}
		return result;
	}

	internal static T DecodeConstantWithKeyD<T>(uint uintValue)
	{
		uintValue = (uintValue * 938235797u ^ 1796485445u);
		uint num = uintValue >> 30;
		T result = default(T);
		uintValue &= 1073741823u;
		uintValue <<= 2;
		if ((ulong)num == 0UL)
		{
			int count = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(_003CModule_003E.bytes, (int)uintValue, count)));
		}
		else if ((ulong)num != 3UL)
		{
			if ((ulong)num == 2UL)
			{
				int num2 = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
				int length = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
				Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(_003CModule_003E.bytes, (int)uintValue, array, 0, num2 - 4);
				result = (T)((object)array);
			}
		}
		else
		{
			T[] array2 = new T[1];
			Buffer.BlockCopy(_003CModule_003E.bytes, (int)uintValue, array2, 0, Marshal.SizeOf(typeof(T)));
			result = array2[0];
		}
		return result;
	}

	internal static T DecodeConstantWithKeyE<T>(uint uintValue)
	{
		uintValue = (uintValue * 1979878659u ^ 1723123948u);
		uint num = uintValue >> 30;
		T result = default(T);
		uintValue &= 1073741823u;
		uintValue <<= 2;
		if ((ulong)num != 3UL)
		{
			if ((ulong)num == 1UL)
			{
				T[] array = new T[1];
				Buffer.BlockCopy(_003CModule_003E.bytes, (int)uintValue, array, 0, Marshal.SizeOf(typeof(T)));
				result = array[0];
			}
			else if ((ulong)num == 2UL)
			{
				int num2 = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
				int length = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
				Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(_003CModule_003E.bytes, (int)uintValue, array2, 0, num2 - 4);
				result = (T)((object)array2);
			}
		}
		else
		{
			int count = (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 8 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 16 | (int)_003CModule_003E.bytes[(int)((UIntPtr)(uintValue++))] << 24;
			result = (T)((object)string.Intern(Encoding.UTF8.GetString(_003CModule_003E.bytes, (int)uintValue, count)));
		}
		return result;
	}
}
