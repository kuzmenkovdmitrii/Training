using System;

namespace hw6
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInt firstBI = new BigInt("153215215312521352152141412412352135321508");
            BigInt secondBI = new BigInt();
            secondBI.SetValue(42142141412119786);
            BigInt addition = firstBI + secondBI;
            Console.WriteLine("First value: " + firstBI.Value);
            Console.WriteLine("Second value: " + secondBI.Value);
            Console.WriteLine("Addition = " + addition.Value);
            BigInt substraction = firstBI - secondBI;
            Console.WriteLine("Substraction = " + substraction.Value);
            BigInt multiplication = firstBI * secondBI;
            Console.WriteLine("Multiplication = " + multiplication.Value);
            Console.ReadKey();
        }
    }
}
