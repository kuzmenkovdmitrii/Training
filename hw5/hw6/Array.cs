namespace hw6
{
    class Array
    {
        public static byte[] PadLeft(byte[] array, int length)
        {
            byte[] outArray = new byte[length];
            for (int i = 0; i < array.Length; i++)
            {
                outArray[i + (length - array.Length)] = array[i];
            }
            return outArray;
        }
    }
}
