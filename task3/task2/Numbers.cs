namespace task3
{
    class Numbers
    {
        public static int[] PerfectNumbers(int limit) //task4
        {
            int[] outArray = new int[0];
            int sum;
            for (int i = 1; i <= limit; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == i)
                {
                    System.Array.Resize(ref outArray, outArray.Length + 1);
                    outArray[outArray.Length - 1] = sum;
                }
            }
            return outArray;
        }
    }
}
