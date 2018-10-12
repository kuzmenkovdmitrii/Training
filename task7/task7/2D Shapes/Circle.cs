using System;

namespace task7
{
    class Circle : Shape2D
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
