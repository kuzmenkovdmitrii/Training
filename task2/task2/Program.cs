using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //{ //first task
            //    int n = 4;
            //    Console.Write("Enter " + n + " numbers: \n");
            //    int[] rowArray = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        rowArray[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine("Pair sum = " + Numbers.PairSum(Numbers.PairAmounts(rowArray)));
            //    Console.Write("Pair: ");
            //    PrintArray(Numbers.PairAmounts(rowArray));
            //}
            //{ //second task
            //    Console.WriteLine("\n********************");
            //    Console.Write("Enter limit for five digit natural number:");
            //    int limit = Convert.ToInt32(Console.ReadLine());
            //    PrintArray(Numbers.FiveDigitNaturalNumbers(limit));
            //}
            //{ //third task
            //    Console.WriteLine("\n********************");
            //    Console.Write("\nEnter year: ");
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    Date date = new Date(year);
            //    Console.WriteLine("Numbers of days per year = " + date.NumberOfDays());
            //}
            { //fourth task
                Console.WriteLine("\n********************");
                Console.Write("\nEnter factorial limit: ");
                int factorialLimit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Factorial = " + Numbers.CalculateFactorial(factorialLimit));
            }
            //{ //fifth task
            //    Console.WriteLine("\n********************");
            //    Console.Write("\nEnter start value: ");
            //    int start = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter end value: ");
            //    int end = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Numbers of prime numbers = " + Numbers.NumberOfPrime(start, end));
            //}
            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            for(int i = 0;i<array.Length;i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
