using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Numbers
{
    public static int[] PairAmounts(int[] numbers)
    {
        int[] outPair = new int[2];
        int[] pairSum = new int[numbers.Length / 2];
        for (int i = 0; i < pairSum.Length; i++)
        {
            pairSum[i] = numbers[i * 2] + numbers[i * 2 + 1];
        }

        int maxIndex = 0;
        int max = 0;
        for (int i = 0; i < pairSum.Length; i++)
        {
            if (max < pairSum[i])
            {
                max = pairSum[i];
                maxIndex = i;
            }
        }

        outPair[0] = numbers[maxIndex * 2];
        outPair[1] = numbers[maxIndex * 2 + 1];
        return outPair;
    }

    public static int PairSum(int[] numbers)
    {
        if (numbers.Length == 2)
        {
            return numbers[0] + numbers[1];
        }
        else
        {
            return -1;
        }
    }

    public static int[] FiveDigitNaturalNumbers(int limit)
    {
        if (limit > 10000)
        {
            int[] outArray = new int[0];
            int counter = 0;
            for (int i = 10000; i < limit; i++)
            {
                int firstSign = i.ToString()[0];
                if ((i % firstSign) == 0)
                {
                    Array.Resize(ref outArray, counter + 1);
                    outArray[counter] = i;
                    counter++;
                }
            }

            return outArray;
        }
        else
        {
            return null;
        }
    }

    public static decimal CalculateFactorial(int limit)
    {
        if (limit > 0)
        {
            decimal factorialValue;

            if (limit == 1)
            {
                return 1;
            }
            factorialValue = CalculateFactorial(limit - 1) * limit;
            return factorialValue;
        }
        else
        {
            return -1;
        }
    }

    public static int NumberOfPrime(int start, int end)
    {
        int numberOfPrimeNumbers = 0;
        bool isPrime = true;
        if (start < 2)
        {
            start = 2;
        }
        for (int i = start; i <= end; i++)
        {
            for(int j = start;j<=end;j++)
            {
                if(i != j && i%j==0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                numberOfPrimeNumbers++;
            }
            isPrime = true;
        }
        
        return numberOfPrimeNumbers;
    }
}