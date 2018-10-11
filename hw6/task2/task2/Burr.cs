namespace task2
{
    class Burr : Flower
    {
        public static string Name { get; set; }

        public Burr(double price) : base(price)
        {
        }

        public override string GetName()
        {
            return "Burr";
        }
    }
}
