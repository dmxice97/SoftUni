using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celcius = Value(fahrenheit);
            Console.WriteLine($"{(celcius):f2}");


        }

        static double Value(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
