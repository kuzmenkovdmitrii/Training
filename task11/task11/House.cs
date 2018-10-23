using System;

namespace task11
{
    delegate void FlameEnvetHandler(object sender, FlameEventArgs args);

    class House
    { 
        public int Number { get; set; }

        public event FlameEnvetHandler Flame;

        public House(int number)
        {
            Number = number;
        }

        protected virtual void OnFlame(FlameEventArgs args)
        {
            if (Flame != null)
            {
                Flame(this, args);
            }
        }

        public void Fire()
        {
            Random rand = new Random();
            byte level = (byte) rand.Next(1, 3);
            OnFlame(new FlameEventArgs() {Message = "Fire-fire",NumberOfHouse = Number, Level = level});
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
