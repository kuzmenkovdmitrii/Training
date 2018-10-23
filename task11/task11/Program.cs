using System;
using System.Threading;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            city.AddHouse(new House(1));
            city.AddHouse(new House(2));
            city.AddHouse(new House(3));
            city.AddHouse(new House(4));
            city.AddHouse(new House(5));
            city.AddHouse(new House(6));
            city.AddHouse(new House(7));
            city.AddHouse(new House(8));
            city.AddHouse(new House(9));
            city.AddHouse(new House(10));

            FireService fireService = new FireService();
            fireService.AddCar(new Car("firstCar"));
            fireService.AddCar(new Car("secondCar"));
            fireService.ListenCity(city);
            Random rand = new Random();

            while (true)
            {
                city.Houses[rand.Next(0, city.Houses.Count)].Fire();
                Thread.Sleep(1000);
            }
        }
    }
}
