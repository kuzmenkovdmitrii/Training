using System;
using System.Threading;

namespace task12
{
    class Program
    {
        private static GameCube gameCube;

        static void Main(string[] args)
        {
            gameCube = new GameCube();
            Timer timer = new Timer(1000,true);

            timer.Tick += Timer_Tick;

            Thread th1 = new Thread(timer.Start);
            th1.Start();
        }

        private static void Timer_Tick()
        {
            gameCube.Drop();
            Console.WriteLine(gameCube.Value);
        }
    }
}
