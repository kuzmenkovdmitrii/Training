namespace task2
{
    class Flower
    {
        public double Price { get; set; }
        public static string Name { get; set; }

        public Flower(double price)
        {
            Price = price;
        }

        public virtual string GetName()
        {
            return "Flower";
        }
    }
}
