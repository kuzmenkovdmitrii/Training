using System;

namespace task14_2.Models
{
    public class QuadraticEquation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public string FirstRoot { get; set; }
        public string SecondRoot { get; set; }

        public void CalculateRoots()
        {
            double discriminant = CalculateDiscriminant();
            if (discriminant >= 0)
            {
                FirstRoot = (((-1) * B + Math.Sqrt(discriminant)) / (2 * A)).ToString();
                SecondRoot = (((-1) * B - Math.Sqrt(discriminant)) / (2 * A)).ToString();
            }
            else
            {
                FirstRoot = ((-1) * B / 2 * A) + "+" + (Math.Sqrt(CalculateDiscriminant() * -1)) + "i/" + 2 * A;
                SecondRoot = ((-1) * B / 2 * A) + "-" + (Math.Sqrt(CalculateDiscriminant() * -1)) + "i/" + 2 * A;
            }
        }

        public double CalculateDiscriminant()
        {
            return System.Math.Pow(B, 2) - (4 * A * C);
        }
    }
}