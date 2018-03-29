using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] weekDays = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine(weekDays[0]);
                    return;
                case 2:
                    Console.WriteLine(weekDays[1]);
                    return;
                case 3:
                    Console.WriteLine(weekDays[2]);
                    return;
                case 4:
                    Console.WriteLine(weekDays[3]);
                    return;
                case 5:
                    Console.WriteLine(weekDays[4]);
                    return;
                case 6:
                    Console.WriteLine(weekDays[5]);
                    return;
                case 7:
                    Console.WriteLine(weekDays[6]);
                    return;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }



        }
    }
}
