using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            { //task1
                Console.Write("Enter array size: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter " + i + " element:");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Max element = " + Array.Max(array));
            }

            { //task2
                Console.WriteLine("***************************");
                Console.Write("Enter year: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter month: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter day: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Date date = new Date(day, month, year);
                Console.WriteLine("Ordinal day = " + date.OrdinalDay());
            }

            { //task3 (Ответ на вопрос: Свести к нулю при многократных преобразованиях нельзя)
                Console.WriteLine("***************************");
                Console.Write("Enter array size: ");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number of loop: ");
                int loop = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[size];
                Random rand = new Random((int)DateTime.Now.Ticks);
                for (int i = 0; i < size; i++)
                {
                    array[i] = rand.Next(1, 100);
                }
                PrintArray(array);

                int[] updatedArray = array;
                Console.WriteLine("\nTransformations:");
                for (int i = 0; i < loop; i++)
                {
                    updatedArray = Array.AbsolutePairDifference(updatedArray);
                    PrintArray(updatedArray);
                    Console.WriteLine();
                }
                Console.WriteLine("\nRepeated application of the transformations will not allow the array to accept all zeros");
            }

            { //task4
                Console.WriteLine("\n***************************");
                Console.Write("Enter limit for perfect numbers: ");
                int limit = Convert.ToInt32(Console.ReadLine());
                int[] array = Numbers.PerfectNumbers(limit);
                PrintArray(array);
            }

            { //task5
                Console.WriteLine("\n***************************");
                Random rand = new Random();
                Console.Write("Enter line size: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter column size: ");
                int m = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        array[i, j] = rand.Next(0, 100);
                    }
                }
                Console.WriteLine("Row array:");
                PrintArray(array);
                Console.WriteLine("Sorted array:");
                PrintArray(Array.SortLine(array));
            }


            { //task6
                Console.WriteLine("***************************");
                Console.Write("Enter array size: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[size, size];
                Console.WriteLine("Snake array:");
                PrintArray(Array.Snake(array));
            }

            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            for(int i = 0;i<array.Length;i++)
            {
                Console.Write(array[i] + "\t");
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
