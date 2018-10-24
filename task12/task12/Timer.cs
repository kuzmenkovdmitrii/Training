using System;
using System.Threading;

namespace task12
{
    public delegate void TimerEventHandler();

    class Timer
    {
        public event TimerEventHandler Tick;

        public int Interval { get; set; }
        public bool Infinity { get; set; }

        public Timer(int interval, bool infinity)
        {
            if (interval <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Interval = interval;
            Infinity = infinity;
        }

        public void Start()
        {
            if (Tick != null)
            {
                if (Infinity)
                {
                    while (true)
                    {
                        Tick();
                        Thread.Sleep(Interval);
                    }
                }
                else
                {
                    Tick();
                    Thread.Sleep(Interval);
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
