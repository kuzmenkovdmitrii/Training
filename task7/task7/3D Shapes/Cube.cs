using System;

namespace task7
{
    class Cube : Shape3D
    {
        private readonly Rectangle rectangle;

        public Cube()
        {
            rectangle = new Rectangle(1, 1);
        }

        public Cube(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }

        public override double GetSquare()
        {
            return rectangle.GetSquare();
        }

        public override double GetVolume()
        {
            return rectangle.GetSquare() * rectangle.FirstSide;
        }

        public override double GetSurfaceSquare()
        {
            return rectangle.GetSquare() * 6;
        }

        public override string GetName()
        {
            return "Cube";
        }
    }
}
