using System;

namespace task7
{
    class Cylinder : Shape3D
    {
        private readonly Circle circle;
        private readonly double height;

        public Cylinder()
        {
            circle = new Circle(1);
            height = 1;
        }

        public Cylinder(Circle circle, double height)
        {
            this.circle = circle;
            this.height = height;
        }

        public override double GetSquare()
        {
            return circle.GetSquare();
        }

        public override double GetVolume()
        {
            return circle.GetSquare() * height;
        }

        public override double GetSurfaceSquare()
        {
            return 2 * Math.PI * circle.Radius * (circle.Radius + height);
        }

        public override string GetName()
        {
            return "Cylinder";
        }
    }
}
