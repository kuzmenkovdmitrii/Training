using System;

namespace task12
{
    class GameCube
    {
        public int Value { get; set; }

        public void Drop()
        {
            Random rand = new Random();
            Value = rand.Next(1, 7);
        }
    }
}
