using System;

namespace _11._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var Type = Console.ReadLine();
            var rows = double.Parse(Console.ReadLine());
            var cows = double.Parse(Console.ReadLine());
            var cost = 0.00;

            if (Type == "Premiere")
            {
                cost = 12;
            }
            else if (Type == "Normal")
            {
                cost = 7.5;
            }
            else if (Type == "Discount")
            {
                cost = 5;
            }

            var total = cost * (rows * cows);

            Console.WriteLine("{0:f2}", total);B
        }
    }
}
