using System;

namespace hw4
{
    public static class IntExtension
    {
        public static byte[] ToByteArray(this int number)
        {
            char[] charNumber = number.ToString().ToCharArray();
            byte[] numbers = new byte[charNumber.Length];
            for (int i = 0; i < charNumber.Length; i++)
            {
                numbers[i] = Convert.ToByte(charNumber[i].ToString());
            }
            return numbers;
        }
    }
}