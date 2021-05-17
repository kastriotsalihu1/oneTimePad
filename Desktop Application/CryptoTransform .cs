using System.Security.Cryptography;

namespace OneTimePad
{
    class CryptoTransform : ICryptoTransform
    {
        public byte[] Otp { get; set; }

        public bool CanReuseTransform => false;

        public bool CanTransformMultipleBlocks => false;

        public int InputBlockSize => 256;

        public int OutputBlockSize => 256;

        public void Dispose()
        {
            // Summary:
            //     Performs application-defined tasks associated with freeing, releasing, or resetting
            //     unmanaged resources.
        }

        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
        {
            return 0;
        }

        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
            var outputTxt = new byte[inputCount];
            for (int i = 0; i < inputCount; i++)
            {
                outputTxt[i] = (byte)(inputBuffer[i] ^ this.Otp[i]);
            }
            return outputTxt;
        }
    }
}