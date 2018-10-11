using System;

namespace hw6
{
    class BigInt
    {
        byte[] value;

        public string Value
        {
            get { return ToString(value); }
            set { this.value = ToArray(value); }
        }

        public BigInt()
        {
            value = new byte[1];
            value[0] = 0;
        }

        public BigInt(byte value)
        {
            SetValue(value);
        }

        public BigInt(int value)
        {
            SetValue(value);
        }

        public BigInt(long value)
        {
            SetValue(value);
        }

        public BigInt(string value)
        {
            SetValue(value);
        }

        public BigInt(BigInt value)
        {
            this.value = value.value;
        }

        public void SetValue(byte value)
        {
            this.value = ToArray(value);
        }

        public void SetValue(int value)
        {
            this.value = ToArray(value);
        }

        public void SetValue(long value)
        {
            this.value = ToArray(value);
        }

        public void SetValue(string value)
        {
            this.value = ToArray(value);
        }

        public void SetValue(BigInt value)
        {
            this.value = value.value;
        }

        #region Addition operator
        public static BigInt operator +(BigInt firstNumber, BigInt secondNumber)
        {
            return new BigInt { value = Math.Addition(firstNumber.value, secondNumber.value) };
        }

        public static BigInt operator +(BigInt firstNumber, long secondNumber)
        {
            return new BigInt { value = Math.Addition(firstNumber.value, ToArray(secondNumber)) };
        }

        public static BigInt operator +(long firstNumber, BigInt secondNumber)
        {
            return new BigInt { value = Math.Addition(ToArray(firstNumber), secondNumber.value) };
        }

        public static BigInt operator +(BigInt firstNumber, string secondNumber)
        {
            return new BigInt { value = Math.Addition(firstNumber.value, ToArray(secondNumber)) };
        }

        public static BigInt operator +(string firstNumber, BigInt secondNumber)
        {
            return new BigInt { value = Math.Addition(ToArray(firstNumber), secondNumber.value) };
        }
        #endregion

        #region Subtraction operator
        public static BigInt operator -(BigInt firstNumber, BigInt secondNumber)
        {
            return new BigInt { value = Math.Subtraction(firstNumber.value, secondNumber.value) };
        }

        public static BigInt operator -(BigInt firstNumber, long secondNumber)
        {
            return new BigInt { value = Math.Subtraction(firstNumber.value, ToArray(secondNumber)) };
        }

        public static BigInt operator -(long firstNumber, BigInt secondNumber)
        {
            return new BigInt { value = Math.Subtraction(ToArray(firstNumber), secondNumber.value) };
        }

        public static BigInt operator -(BigInt firstNumber, string secondNumber)
        {
            return new BigInt { value = Math.Subtraction(firstNumber.value, ToArray(secondNumber)) };
        }

        public static BigInt operator -(string firstNumber, BigInt secondNumber)
        {
            return new BigInt { value = Math.Subtraction(ToArray(firstNumber), secondNumber.value) };
        }
        #endregion

        #region Multiplication operator
        public static BigInt operator *(BigInt firstNumber, BigInt secondNumber)
        {
            return new BigInt { value = Math.Multiplication(firstNumber.value, secondNumber.value) };
        }

        public static BigInt operator *(BigInt firstNumber, long secondNumber)
        {
            return new BigInt { value = Math.Multiplication(firstNumber.value, ToArray(secondNumber)) };
        }

        public static BigInt operator *(long firstNumber, BigInt secondNumber)
        {
            return new BigInt { value = Math.Multiplication(ToArray(firstNumber), secondNumber.value) };
        }

        public static BigInt operator *(BigInt firstNumber, string secondNumber)
        {
            return new BigInt { value = Math.Multiplication(firstNumber.value, ToArray(secondNumber)) };
        }

        public static BigInt operator *(string firstNumber, BigInt secondNumber)
        {
            return new BigInt { value = Math.Multiplication(ToArray(firstNumber), secondNumber.value) };
        }
        #endregion 

        private string ToString(byte[] array)
        {
            string number = "";
            for (int i = 0; i < array.Length; i++)
            {
                number += array[i];
            }
            return number;
        }

        public static byte[] ToArray(long number)
        {
            return ToArray(number.ToString());
        }

        public static byte[] ToArray(string number)
        {
            char[] charNumber = number.ToCharArray();
            byte[] numbers = new byte[charNumber.Length];
            for (int i = 0; i < charNumber.Length; i++)
            {
                numbers[i] = Convert.ToByte(charNumber[i].ToString());
            }
            return numbers;
        }
    }
}