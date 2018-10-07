using System;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 100;
            for (int i = 0; i < limit; i++)
            {
                string[] factorialArray = Math.FactorialArray(limit);
                Console.WriteLine("Factorial of " + (i + 1) + ":");
                Console.WriteLine(factorialArray[i]);
            }
            Console.ReadKey();
        }
    }
}
