namespace task7
{
    class Rectangle : Shape2D
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }

        public Rectangle(double firstSide, double secondSide)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
        }

        public override double GetSquare()
        {
            return FirstSide * SecondSide;
        }
    }
}