using System.Collections.Generic;

namespace task2
{
    class Bouquet
    {
        private List<Flower> bouquet;

        public Bouquet()
        {
            bouquet = new List<Flower>();
        }

        public void AddFlower(Flower flower)
        {
            bouquet.Add(flower);
        }

        public double GetPrice()
        {
            double sum = 0;
            foreach (var flower in bouquet)
            {
                sum += flower.Price;
            }

            return sum;
        }

        public override string ToString()
        {
            string outString = "";
            foreach (var flower in bouquet)
            {
                outString += flower.GetName() + " " + flower.Price + "\n";
            }

            return outString;
        }
    }
}
