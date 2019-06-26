using System;
using System.Collections.Generic;
using System.Text;

namespace Reloading_cast
{
    class TimeSpan
    {
        public int Seconds { get; set; }
        public int Miliseconds { get; set; }
        public TimeSpan(int s, int m = 0)
        {
            Seconds = s;
            Miliseconds = m;
        }
        public void Show()
        {
            Console.WriteLine("Timespan : {0}.{1}", Seconds, Miliseconds);
        }
        public static explicit operator Time(TimeSpan ts)
        {
            int seconds = ts.Seconds % 60;
            int All_minutes = ts.Seconds / 60;
            int minutes = All_minutes % 60;
            int hours = All_minutes / 60;
            return new Time(hours, minutes, seconds, ts.Miliseconds);
                
        }
    }
}
