using System;
using System.Collections.Generic;
using System.Text;

namespace Sig
{
    class OneTimePad
    {
        private static uint Adler32(string str)
        {
            const int mod = 65521;
            uint a = 1, b = 0;
            foreach (char c in str)
            {
                a = (a + c) % mod;
                b = (b + a) % mod;
            }
            return (b << 16) | a;
        }
        public static byte[] GenerateOTP(int seed, int size)
        {
            var random = new Random(Seed: seed);
            var OTP = new byte[size];
            random.NextBytes(OTP);
            return OTP;
        }
        public static byte[] GenerateOTP(string strSeed, int size)
        {
            int seed = (int)Adler32(strSeed);
            var random = new Random(Seed: seed);
            var OTP = new byte[size];
            random.NextBytes(OTP);
            return OTP;
        }
        public static byte[] Encrypt(byte[] plainTxt, byte[] otp)
        {
            var cipherTxt = new byte[plainTxt.Length];
            for (int i = 0; i < plainTxt.Length; i++)
            {
                cipherTxt[i] = (byte)(plainTxt[i] ^ otp[i]);
            }
            return cipherTxt;
        }
        public static byte[] Decrypt(byte[] encryptedTxt, byte[] otp)
        {
            var decryptedTxt = new byte[encryptedTxt.Length];
            for (int i = 0; i < encryptedTxt.Length; i++)
            {
                decryptedTxt[i] = (byte)(encryptedTxt[i] ^ otp[i]);
            }
            return decryptedTxt;
        }
    }
}
