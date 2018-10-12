using System;
using System.Net.Http.Headers;

namespace task7
{
    class Parallelepiped : Shape3D
    {
        private readonly Rectangle rectangle;
        private readonly double height;

        public Parallelepiped()
        {
            rectangle = new Rectangle(1,1);
            height = 1;
        }

        public Parallelepiped(Rectangle rectangle, double height)
        {
            this.rectangle = rectangle;
            this.height = height;
        }

        public override double GetSquare()
        {
            return rectangle.GetSquare();
        }

        public override double GetVolume()
        {
            return rectangle.GetSquare() * height;
        }

        public override double GetSurfaceSquare()
        {
            double surfaceSquare = 0;
            surfaceSquare += rectangle.GetSquare() * 2;
            surfaceSquare += rectangle.FirstSide * height * 2;
            surfaceSquare += rectangle.SecondSide * height * 2;
            return surfaceSquare;
        }

        public override string GetName()
        {
            return "Parallelepiped";
        }
    }
}
