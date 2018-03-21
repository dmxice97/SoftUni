using System;

namespace _02._Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());

            double sum = num * num * Math.PI;
            Console.WriteLine($"{sum:f12}");


        }
    }
}
