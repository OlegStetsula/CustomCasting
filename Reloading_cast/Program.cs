using System;

namespace Reloading_cast
{
    class Program
    {
        static void Main(string[] args)
        {
            Time d = new Time(4,6);                     // 14760
            TimeSpan ts = d;
            ts.Show();

            TimeSpan times = new TimeSpan(3855);        // 1 : 4 : 15 . 0
            Time t2 = (Time)times;
            t2.Show();

            Console.ReadLine();
        }
    }
}
