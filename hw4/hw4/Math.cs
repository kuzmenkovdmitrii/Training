using System;

namespace hw4
{
    class Math
    {
        public static string[] FactorialArray(int limit)
        {
            if (limit > 0)
            {
                string[] factorialArray = new string[limit];

                byte[] firstNumber = { 1 };
                for (int i = 1; i <= limit; i++)
                {
                    firstNumber = Multiplication(firstNumber, i.ToByteArray());
                    factorialArray[i - 1] = ToString(firstNumber);
                }

                return factorialArray;
            }
            else
            {
                return null;
            }
        }

        private static byte[] Multiplication(byte[] firstNumber, byte[] secondNumber)
        {
            Array.Reverse(firstNumber);
            Array.Reverse(secondNumber);
            byte[] calculatedNumber = new byte[firstNumber.Length + secondNumber.Length];
            for (int i = 0; i < calculatedNumber.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < firstNumber.Length; j++)
                {
                    int k = i - j;
                    if (k >= 0 && k < secondNumber.Length)
                    {
                        sum += firstNumber[j] * secondNumber[k];
                    }
                }
                calculatedNumber[i] = (byte)sum;
            }
            for (int i = 0; i < calculatedNumber.Length - 1; i++)
            {
                int p = calculatedNumber[i] % 10;
                int q = calculatedNumber[i] / 10;
                calculatedNumber[i] = (byte)p;
                calculatedNumber[i + 1] += (byte)q;
            }
            calculatedNumber = RemoveExcess(calculatedNumber);
            Array.Reverse(calculatedNumber);
            return calculatedNumber;
        }

        private static byte[] RemoveExcess(byte[] array)
        {
            while (true)
            {
                if (array[array.Length - 1] == 0)
                {
                    Array.Resize(ref array, array.Length - 1);
                }
                else
                {
                    break;
                }
            }
            return array;
        }

        private static string ToString(byte[] array)
        {
            string number = "";
            for (int i = 0; i < array.Length; i++)
            {
                number += array[i];
            }
            return number;
        }
    }
}
