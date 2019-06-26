using System;
using System.Collections.Generic;
using System.Text;

namespace Reloading_cast
{
    class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public int Miliseconds { get; set; }

        public Time(int h, int m, int s = 0, int mil = 0)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
            Miliseconds = mil;
        }
        static public implicit operator TimeSpan(Time t)
        {
            int Amount_of_sec = (t.Hours * 60 + t.Minutes) * 60 + t.Seconds;
            return new TimeSpan(Amount_of_sec, t.Miliseconds);
        }
        public void Show()
        {
            Console.WriteLine("Time : {0}:{1}:{2}.{3}",Hours, Minutes, Seconds, Miliseconds);
        }
    }
}
