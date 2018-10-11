using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouquet bouquet = new Bouquet();

            bouquet.AddFlower(new Burr(1));
            bouquet.AddFlower(new Burdock(2.5));
            bouquet.AddFlower(new Dandelion(3));
            bouquet.AddFlower(new Burdock(5.2));
            bouquet.AddFlower(new Burr(1.3));
            bouquet.AddFlower(new Dandelion(3.3));

            Console.WriteLine(bouquet.ToString());
            Console.WriteLine("Full price: " + bouquet.GetPrice());
        }
    }
}
