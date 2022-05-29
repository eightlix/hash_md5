using System;
using System.Collections.Generic;



namespace MyHash
{
    public static class MyMD5
	{

		/// <summary>
		/// Takes string and returns hash.
		/// </summary>
		/// <param name="text">string which will be changed into hash</param>
		/// <returns>hash made by MD5</returns>
		public static string GetHash(string text)
		{
			byte[] textInByte = System.Text.Encoding.UTF8.GetBytes(text);

			List<byte> bytes = new List<byte>();
			foreach (byte b in textInByte)
			{
				bytes.Add(b);
			}
			UInt32 A, B, C, D;
			A = 0x67452301;

			B = 0xEFCDAB89;

			C = 0x98BADCFE;

			D = 0x10325476;


			UInt64 dataLen = Convert.ToUInt64(bytes.Count * 8);

			AppendZiro(bytes);

			AppendLength(bytes, dataLen);

			string ans = processMsgIn16WordBlocks(byteListToUint32(bytes), A, B, C, D);
			return ans;


		}

		/// <summary>
		/// Converts a list of bytes to a UInt32 array
		/// </summary>
		/// <param name="buf">List of bytes</param>
		/// <returns></returns>
		public static UInt32[] byteListToUint32(List<byte> buf)
		{
			UInt32[] ans = new UInt32[buf.Count];
			for (int i = 0; i < buf.Count; i++)
			{
				ans[i] = (UInt32)buf[i];
			}
			return ans;
		}

		private static uint rotateLeft(this uint value, int count)
		{
			return (value << count) | (value >> (32 - count));
		}

		private static uint RotateRight(this uint value, int count)
		{
			return (value >> count) | (value << (32 - count));
		}

		/// <summary>
		/// Appends one and ziroes
		/// </summary>
		/// <param name="bytes"></param>
		public static void AppendZiro(List<byte> bytes)
		{
			bytes.Add(128);
			while (bytes.Count % 64 != 56)
			{
				bytes.Add(0);
			}
		}

		/// <summary>
		/// adds to a list of bytes its length in bytes
		/// </summary>
		/// <param name="bytes"></param>
		/// <param name="dataLen"></param>
		private static void AppendLength(List<byte> bytes, UInt64 dataLen)
		{
			
			byte[] buffer = BitConverter.GetBytes(dataLen);
			Array.Reverse(buffer);
			for (int i = 0; i < buffer.Length; i++)
			{
				bytes.Add(buffer[i]);
			}
		}

		private static UInt32 F(UInt32 X, UInt32 Y, UInt32 Z)
		{
			return (X & Y) | (~X & Z);
		}
		private static UInt32 G(UInt32 X, UInt32 Y, UInt32 Z)
		{
			return (X & Z) | (Y & ~Z);
		}
		private static UInt32 H(UInt32 X, UInt32 Y, UInt32 Z)
		{
			return X ^ Y ^ Z;
		}
		private static UInt32 I(UInt32 X, UInt32 Y, UInt32 Z)
		{
			return Y ^ (X | ~Z);
		}


		private static string processMsgIn16WordBlocks(UInt32[] buf, UInt32 A, UInt32 B, UInt32 C, UInt32 D)
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
			
			string ans = Convert.ToString(A, 16) + Convert.ToString(B, 16) + Convert.ToString(C, 16) + Convert.ToString(D, 16);
			return ans;
		}
	}
}

