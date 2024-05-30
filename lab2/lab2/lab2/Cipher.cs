using System;

namespace lab2
{
    public static class Cipher
    {
        public static byte[] PlainByteArr { get; set; }

        public static byte[] CipherByteArr { get; private set; }

        public static byte[] KeyByteArr { get; private set; }

        private static void _genKey(uint initKey)
        {
            var length = PlainByteArr.Length;
            KeyByteArr = new byte[length];

            var tempKey = initKey;

            var byteShift = 4;
            for (var i = 0; i < length; i += 4)
            {
                if (KeyByteArr.Length - i < 4)
                    byteShift = length - i;
                
                byte[] tempKeyArr = BitConverter.GetBytes(tempKey);
                Array.Reverse(tempKeyArr);
                for (var j = 0; j < byteShift; j++)
                {
                    KeyByteArr[i + j] = tempKeyArr[j];
                }

                for (var j = 0; j < 32; j++)
                {
                    uint lastBit = (tempKey >> 31) ^ (tempKey >> 27) ^ (tempKey >> 26) ^ tempKey;
                    tempKey = (tempKey << 1) | (lastBit & 0x00000001);
                }
            }
        }

        private static void _genCipherByteArr()
        {
            CipherByteArr = new byte[PlainByteArr.Length];
            for (var i = 0; i < PlainByteArr.Length; i++)
            {
                CipherByteArr[i] = (byte)(PlainByteArr[i] ^ KeyByteArr[i]);
            }
        }

        public static void Code(uint initKey)
        {
            _genKey(initKey);
            _genCipherByteArr();
        }
    }
}