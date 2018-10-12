namespace task7
{
    class Prism : Shape3D
    {
        private readonly Triangle triangle;
        private readonly double height;

        public Prism()
        {
            triangle = new Triangle(1, 1, 1);
            height = 1;
        }

        public Prism(Triangle triangle, double height)
        {
            this.triangle = triangle;
            this.height = height;
        }

        public override double GetSquare()
        {
            return triangle.GetSquare();
        }

        public override double GetVolume()
        {
            return triangle.GetSquare() * height;
        }

        public override double GetSurfaceSquare()
        {
            return (triangle.FirstSide + triangle.SecondSide + triangle.ThirdSide) * height + 2 * triangle.GetSquare();
        }

        public override string GetName()
        {
            return "Prism";
        }
    }
}
