using System;

namespace hash_md5
{


	public class MyMD5
	{
		public static void GetHash(List<byte> bytes)
		{
			UInt32 A, B, C, D;
			A = 0x67452301;

			B = 0xEFCDAB89;

			C = 0x98BADCFE;

			D = 0x10325476;


			int dataLen = bytes.Count * 8;
			AppendZiro(bytes);
			AppendLength(bytes, dataLen);
			UInt32[] ans = processMsgIn16WordBlocks(byteArrToUint32(bytes), A, B, C, D);






		}

		public static UInt32[] byteArrToUint32(List<byte> buf)
		{
			UInt32[] ans = new UInt32[buf.Count];
			for (int i = 0; i < buf.Count; i++)
			{
				ans[i] = (UInt32)buf[i];
			}
			return ans;
		}
		public static uint rotateLeft(this uint value, int count)
		{
			return (value << count) | (value >> (32 - count));
		}

		public static uint RotateRight(this uint value, int count)
		{
			return (value >> count) | (value << (32 - count));
		}

		public static void AppendZiro(List<byte> bytes)
		{
			bytes.Add(128);
			while (bytes.Count % 64 != 56)
			{
				bytes.Add(0);
			}
		}
		public static void AppendLength(List<byte> bytes, int dataLen)
		{
			byte[] buffer = new byte[4];
			buffer = BitConverter.GetBytes(dataLen);
			Array.Reverse(buffer);
			for (int i = 0; i < 4; i++)
			{
				bytes.Add(buffer[i]);
			}
		}

		public static UInt32 F(UInt32 X, UInt32 Y, UInt32 Z)
		{
			return (X & Y) | (~X & Z);
		}
		public static UInt32 G(UInt32 X, UInt32 Y, UInt32 Z)
		{
			return (X & Z) | (Y & ~Z);
		}
		public static UInt32 H(UInt32 X, UInt32 Y, UInt32 Z)
		{
			return X ^ Y ^ Z;
		}
		public static UInt32 I(UInt32 X, UInt32 Y, UInt32 Z)
		{
			return Y ^ (X | ~Z);
		}


		public static UInt32[] processMsgIn16WordBlocks(UInt32[] buf, UInt32 A, UInt32 B, UInt32 C, UInt32 D)
		{
			UInt32 AA, BB, CC, DD;

			UInt32[] T = new UInt32[64];
			for (int i = 0; i < 64; i++)
			{
				T[i] = Convert.ToUInt32(Math.Pow(2, 32) * Math.Abs(Math.Sin(i + 1)));
			}

			for (int n = 0; n < buf.Length; n += 16)
			{
				AA = A;
				BB = B;
				CC = C;
				DD = D;


				// Round 1
				A = B + rotateLeft((A + F(B, C, D) + buf[n + 0] + T[0]), 7);
				D = A + rotateLeft((D + F(A, B, C) + buf[n + 1] + T[1]), 12);
				C = D + rotateLeft((C + F(D, A, B) + buf[n + 2] + T[2]), 17);
				B = C + rotateLeft((B + F(C, D, A) + buf[n + 3] + T[3]), 22);

				A = B + rotateLeft((A + F(B, C, D) + buf[n + 4] + T[4]), 7);
				D = A + rotateLeft((D + F(A, B, C) + buf[n + 5] + T[5]), 12);
				C = D + rotateLeft((C + F(D, A, B) + buf[n + 6] + T[6]), 17);
				B = C + rotateLeft((B + F(C, D, A) + buf[n + 7] + T[7]), 22);

				A = B + rotateLeft((A + F(B, C, D) + buf[n + 8] + T[8]), 7);
				D = A + rotateLeft((D + F(A, B, C) + buf[n + 9] + T[9]), 12);
				C = D + rotateLeft((C + F(D, A, B) + buf[n + 10] + T[10]), 17);
				B = C + rotateLeft((B + F(C, D, A) + buf[n + 11] + T[11]), 22);

				A = B + rotateLeft((A + F(B, C, D) + buf[n + 12] + T[12]), 7);
				D = A + rotateLeft((D + F(A, B, C) + buf[n + 13] + T[13]), 12);
				C = D + rotateLeft((C + F(D, A, B) + buf[n + 14] + T[14]), 17);
				B = C + rotateLeft((B + F(C, D, A) + buf[n + 15] + T[15]), 22);

				// Round 2

				A = B + rotateLeft((A + G(B, C, D) + buf[n + 1] + T[16]), 5);
				D = A + rotateLeft((D + G(A, B, C) + buf[n + 6] + T[17]), 9);
				C = D + rotateLeft((C + G(D, A, B) + buf[n + 11] + T[18]), 14);
				B = C + rotateLeft((B + G(C, D, A) + buf[n + 0] + T[19]), 20);
				A = B + rotateLeft((A + G(B, C, D) + buf[n + 5] + T[20]), 5);
				D = A + rotateLeft((D + G(A, B, C) + buf[n + 10] + T[21]), 9);
				C = D + rotateLeft((C + G(D, A, B) + buf[n + 15] + T[22]), 14);
				B = C + rotateLeft((B + G(C, D, A) + buf[n + 4] + T[23]), 20);

				A = B + rotateLeft((A + G(B, C, D) + buf[n + 9] + T[24]), 5);
				D = A + rotateLeft((D + G(A, B, C) + buf[n + 14] + T[25]), 9);
				C = D + rotateLeft((C + G(D, A, B) + buf[n + 3] + T[26]), 14);
				B = C + rotateLeft((B + G(C, D, A) + buf[n + 8] + T[27]), 20);

				A = B + rotateLeft((A + G(B, C, D) + buf[n + 13] + T[28]), 5);
				D = A + rotateLeft((D + G(A, B, C) + buf[n + 2] + T[29]), 9);
				C = D + rotateLeft((C + G(D, A, B) + buf[n + 7] + T[30]), 14);
				B = C + rotateLeft((B + G(C, D, A) + buf[n + 12] + T[31]), 20);

				// Round 3

				A = B + rotateLeft((A + H(B, C, D) + buf[n + 5] + T[32]), 4);
				D = A + rotateLeft((D + H(A, B, C) + buf[n + 8] + T[33]), 11);
				C = D + rotateLeft((C + H(D, A, B) + buf[n + 11] + T[34]), 16);
				B = C + rotateLeft((B + H(C, D, A) + buf[n + 14] + T[35]), 23);

				A = B + rotateLeft((A + H(B, C, D) + buf[n + 1] + T[36]), 4);
				D = A + rotateLeft((D + H(A, B, C) + buf[n + 4] + T[37]), 11);
				C = D + rotateLeft((C + H(D, A, B) + buf[n + 7] + T[38]), 16);
				B = C + rotateLeft((B + H(C, D, A) + buf[n + 10] + T[39]), 23);

				A = B + rotateLeft((A + H(B, C, D) + buf[n + 13] + T[40]), 4);
				D = A + rotateLeft((D + H(A, B, C) + buf[n + 0] + T[41]), 11);
				C = D + rotateLeft((C + H(D, A, B) + buf[n + 3] + T[42]), 16);
				B = C + rotateLeft((B + H(C, D, A) + buf[n + 6] + T[43]), 23);

				A = B + rotateLeft((A + H(B, C, D) + buf[n + 9] + T[44]), 4);
				D = A + rotateLeft((D + H(A, B, C) + buf[n + 12] + T[45]), 11);
				C = D + rotateLeft((C + H(D, A, B) + buf[n + 15] + T[46]), 16);
				B = C + rotateLeft((B + H(C, D, A) + buf[n + 2] + T[47]), 23);

				// Round 4

				A = B + rotateLeft((A + I(B, C, D) + buf[n + 0] + T[48]), 6);
				D = A + rotateLeft((D + I(A, B, C) + buf[n + 7] + T[49]), 10);
				C = D + rotateLeft((C + I(D, A, B) + buf[n + 14] + T[50]), 15);
				B = C + rotateLeft((B + I(C, D, A) + buf[n + 5] + T[51]), 21);

				A = B + rotateLeft((A + I(B, C, D) + buf[n + 12] + T[52]), 6);
				D = A + rotateLeft((D + I(A, B, C) + buf[n + 3] + T[53]), 10);
				C = D + rotateLeft((C + I(D, A, B) + buf[n + 10] + T[54]), 15);
				B = C + rotateLeft((B + I(C, D, A) + buf[n + 1] + T[55]), 21);

				A = B + rotateLeft((A + I(B, C, D) + buf[n + 8] + T[56]), 6);
				D = A + rotateLeft((D + I(A, B, C) + buf[n + 15] + T[57]), 10);
				C = D + rotateLeft((C + I(D, A, B) + buf[n + 6] + T[58]), 15);
				B = C + rotateLeft((B + I(C, D, A) + buf[n + 13] + T[59]), 21);

				A = B + rotateLeft((A + I(B, C, D) + buf[n + 4] + T[60]), 6);
				D = A + rotateLeft((D + I(A, B, C) + buf[n + 11] + T[61]), 10);
				C = D + rotateLeft((C + I(D, A, B) + buf[n + 2] + T[62]), 15);
				B = C + rotateLeft((B + I(C, D, A) + buf[n + 9] + T[63]), 21);

				A += AA;
				B += BB;
				C += CC;
				D += DD;
			}
			UInt32[] ansUint = new UInt32[4] { A, B, C, D };
			return ansUint;
		}
	}
}