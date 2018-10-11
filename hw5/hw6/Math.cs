namespace hw6
{
    class Math
    {
        public static byte[] Addition(byte[] firstNumber, byte[] secondNumber)
        {
            byte[] outArray = new byte[0];
            byte carry = 0;
            byte diff = 0;

            int max = System.Math.Max(firstNumber.Length, secondNumber.Length);
            if (firstNumber.Length < secondNumber.Length)
            {
                firstNumber = Array.PadLeft(firstNumber, max);
            }
            else
            {
                if (firstNumber.Length > secondNumber.Length)
                {
                    secondNumber = Array.PadLeft(secondNumber, max);
                }
            }

            for (int i = max - 1; i >= 0; i--)
            {
                carry = (byte)((diff + firstNumber[i] + secondNumber[i]) % 10);
                System.Array.Resize(ref outArray, outArray.Length + 1);
                outArray[outArray.Length - 1] = carry;
                diff = (byte)((diff + firstNumber[i] + secondNumber[i]) / 10);
            }

            System.Array.Reverse(outArray);
            return outArray;
        }

        public static byte[] Subtraction(byte[] firstNumber, byte[] secondNumber)
        {
            int max = System.Math.Max(firstNumber.Length, secondNumber.Length);
            byte[] outArray = new byte[max];
            if (firstNumber.Length > secondNumber.Length)
            {
                if (firstNumber.Length != secondNumber.Length)
                {
                    secondNumber = Array.PadLeft(secondNumber, max);
                }
            }

            for (int i = max - 1; i >= 0; i--)
            {
                int diff = firstNumber[i] - secondNumber[i];
                if (diff < 0)
                {
                    firstNumber[i - 1]--;
                    diff += 10;
                }
                outArray[i] = (byte)diff;
            }
            return outArray;
        }

        public static byte[] Multiplication(byte[] firstNumber, byte[] secondNumber)
        {
            System.Array.Reverse(firstNumber);
            System.Array.Reverse(secondNumber);
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
            System.Array.Reverse(calculatedNumber);
            return calculatedNumber;
        }

        private static byte[] RemoveExcess(byte[] array)
        {
            while (true)
            {
                if (array.Length > 1)
                {
                    if (array[array.Length - 1] == 0)
                    {
                        System.Array.Resize(ref array, array.Length - 1);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return array;
        }

        
    }
}
