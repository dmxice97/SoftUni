using System;

namespace _09._Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            Math.Round(celsius, 2);
            Console.WriteLine((celsius * 1.8) + 32);
        }
    }
}
