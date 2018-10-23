using System;
using System.Collections.Generic;

namespace task11
{
    class FireService
    {
        public List<Car> Cars { get; }

        public FireService()
        {
            Cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void ListenCity(City city)
        {
            foreach (var house in city.Houses)
            {
                house.Flame += House_Flame;
            }
        }

        private void House_Flame(object sender, FlameEventArgs args)
        {
            if (args.Level == 1)
            {
                if (Cars.Count >= 1)
                {
                    Console.WriteLine(args.Message+", house number - " + args.NumberOfHouse + ", number of cars - " + args.Level);
                }
            }
            else if(args.Level == 2)
            {
                if (Cars.Count >= 2)
                {
                    Console.WriteLine(args.Message + ", house number - " + args.NumberOfHouse + ", number of cars - " + args.Level);
                }
            }
        }
    }
}
