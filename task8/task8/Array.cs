namespace task8
{
    class Array
    {
        public static string[] DeleteNull(string[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == "")
                {
                    System.Array.Resize(ref array, array.Length - 1);
                }
                else
                {
                    break;
                }
            }

            return array;
        }

        public static string MoveLeft(string array)
        {
            char[] charArray = array.ToCharArray();
            for (int i = 0; i < array.Length - 1; i++)
            {
                char buffer = charArray[i];
                charArray[i] = array[i + 1];
                charArray[i + 1] = buffer;
            }
            System.Array.Resize(ref charArray, array.Length - 1);
            return new string(charArray);
        }
    }
}