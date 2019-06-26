using System;

namespace Reloading_cast
{
    class Program
    {
        static void Main(string[] args)
        {
            Time d = new Time(4,15,20,200);                     // 15320.200
            TimeSpan ts = d;
            ts.Show();

            TimeSpan times = new TimeSpan(55245);        // 15 : 20 : 45.0
            Time t2 = (Time)times;
            t2.Show();

            Console.ReadLine();
        }
    }
}
