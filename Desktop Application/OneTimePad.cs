using System;
using System.Security.Cryptography;


namespace OneTimePad
{
    class OneTimePadAlgorithm : SymmetricAlgorithm
    {
        override public int BlockSize { get; set; }
        override public byte[] Key { get; set; }
        override public int KeySize { get; set; }

        private string StringSeed;
        private int InputLength;

        public void setInputLength(int i)
        {
            InputLength = i;
        }
        public void setStringSeed(string seed)
        {
            this.StringSeed = seed;
        }
        public void setStringSeed(int seed)
        {
            this.StringSeed = seed.ToString();
        }

        public string getStringSeed()
        {
            return this.StringSeed;
        }

        public static OneTimePadAlgorithm Create()
        {
            return new OneTimePadAlgorithm();
        }


        override public ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV)
        {
            CryptoTransform t = new CryptoTransform();
            t.Otp = rgbKey;
            return t;
        }

        override public ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV)
        {
            CryptoTransform t = new CryptoTransform();
            t.Otp = rgbKey;
            return t;
        }

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

        public override void GenerateIV()
        {
            throw new NotImplementedException();
        }
        override public void GenerateKey()
        {
            int seed;
            try
            {
                seed = (int)UInt64.Parse(this.StringSeed);
            }
            catch (FormatException)
            {
                seed = (int)Adler32(this.StringSeed);
            }

            var random = new Random(Seed: seed);
            var OTP = new byte[this.InputLength];
            random.NextBytes(OTP);
            this.Key = OTP;
            this.KeySize = OTP.Length;
        }
    }
}
