using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter max rank for first polynomial: ");
            int sizeForFirstPolynomial = Convert.ToInt32(Console.ReadLine());
            int[] firstPolynomial = new int[sizeForFirstPolynomial];
            for (int i = 0; i < sizeForFirstPolynomial; i++)
            {
                firstPolynomial[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            Console.Write("Enter max rank for second polynomial: ");
            int sizeForsecondPolynomial = Convert.ToInt32(Console.ReadLine());
            int[] secondPolynomial = new int[sizeForsecondPolynomial];
            for (int i = 0; i < sizeForsecondPolynomial; i++)
            {
                secondPolynomial[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            Console.Write("First polunomial: ");
            Console.WriteLine(Polynomial.ToString(firstPolynomial));
            Console.Write("\nSecond polunomial: ");
            Console.WriteLine(Polynomial.ToString(secondPolynomial));
            Console.Write("\nSum of polunomials: ");
            Console.WriteLine(Polynomial.ToString(Polynomial.GetSum(firstPolynomial, secondPolynomial)));
            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
