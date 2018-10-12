using System;

namespace task7
{ 
    class Triangle : Shape2D
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        private double CalculateP()
        {
            return (FirstSide + SecondSide + ThirdSide) / 2;
        }

        public override double GetSquare()
        {
            double p = CalculateP();
            return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }
    }
}
