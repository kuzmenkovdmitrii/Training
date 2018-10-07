using System;

namespace task3
{
    class Array
    {
        public static int Max(int[] array) //task1
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int[] AbsolutePairDifference(int[] array) //task5
        {
            int[] outArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    outArray[i] = Math.Abs(array[i] - array[i + 1]);
                }
                else
                {
                    outArray[array.Length - 1] = Math.Abs(array[0] - array[array.Length - 1]);
                }
            }
            return outArray;
        }

        public static int[,] SortLine(int[,] array) //task5
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0) - 1; j++)
                {
                    if (array[j,0] > array[j + 1,0])
                    {
                        for(int k = 0;k<array.GetLength(1);k++)
                        {
                            int buffer = array[j,k];
                            array[j,k] = array[j + 1,k];
                            array[j + 1,k] = buffer;
                        }
                    }
                }
            }
            return array;
        }

        public static int[,] Snake(int[,] array) //task6
        {
            int side = 0;
            int step = 0;
            int counter = 1;
            while (true)
            {
                if (side == 0)
                {
                    for (int i = array.GetLength(0) - step - 1; i > step; i--)
                    {
                        array[array.GetLength(0) - step - 1, i] = counter;
                        counter++;
                    }
                    side++;
                }
                if (side == 1)
                {
                    for (int i = array.GetLength(0) - step - 1; i > step; i--)
                    {
                        array[i, step] = counter;
                        counter++;
                    }
                    side++;
                }
                if (side == 2)
                {
                    for (int i = step; i < array.GetLength(0) - step - 1; i++)
                    {
                        array[step, i] = counter;
                        counter++;
                    }
                    side++;
                }
                if (side == 3)
                {
                    for (int i = step; i < array.GetLength(0) - step - 1; i++)
                    {
                        array[i, array.GetLength(0) - step - 1] = counter;
                        counter++;
                    }
                    side = 0;
                    step++;
                }
                if (step == array.GetLength(0) - 1 && array.GetLength(0) % 2 != 0)
                {
                    array[(array.GetLength(0)- 1)/2, (array.GetLength(1)- 1)/2] = counter;
                    break;
                }
                else if (step == array.GetLength(0) - 1)
                {
                    break;
                }
            }
            return array;
        }
    }
}
