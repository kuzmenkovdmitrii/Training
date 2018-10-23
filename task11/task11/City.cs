using System.Collections.Generic;

namespace task11
{
    class City
    {
        public List<House> Houses { get; }

        public City()
        {
            Houses = new List<House>();
        }

        public void AddHouse(House house)
        {
            Houses.Add(house);
        }
    }
}
