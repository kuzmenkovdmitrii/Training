using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Polynomial
    {
        public static int[] GetSum(int[] firstPolynomial, int[] secondPolynomial)
        {
            int[] sumPolynomial;

            if (firstPolynomial.Length > secondPolynomial.Length)
            {
                sumPolynomial = new int[firstPolynomial.Length];
                Array.Resize(ref secondPolynomial, sumPolynomial.Length);
            }
            else
            {
                sumPolynomial = new int[secondPolynomial.Length];
                Array.Resize(ref firstPolynomial, sumPolynomial.Length);
            }

            for (int i = 0; i < sumPolynomial.Length; i++)
            {
                sumPolynomial[i] = firstPolynomial[i] + secondPolynomial[i];
            }

            return sumPolynomial;
        }

        public static string ToString(int[] polynomial)
        {
            string outString = "";
            for (int i = 0; i < polynomial.Length; i++)
            {
                if (i != 0)
                {
                    string operation;
                    if (polynomial[i] >= 0)
                    {
                        operation = "+";
                    }
                    else
                    {
                        operation = "-";
                    }
                    outString += " " + operation + " " + polynomial[i] + "x^" + i;
                }
                else
                {
                    outString += polynomial[i] + "x^" + i;
                }
            }
            return outString;
        }
    }
}
