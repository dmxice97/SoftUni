using System;

namespace _14.Time_plus_15Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;

            if (minutes >= 60)
            {
                hours++;
                if (hours >= 24)
                {
                    hours = 0;
                }
                minutes -= 60;
            }

            Console.WriteLine("{0}:{1:D2}", hours, minutes);




        }
    }
}
