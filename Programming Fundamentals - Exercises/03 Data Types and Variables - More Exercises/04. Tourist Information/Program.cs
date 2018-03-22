using System;

namespace _04._Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            switch (unit)
            {
                case "miles":
                    Console.WriteLine($"{value} miles = {(value * 1.6):f2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{value} inches = {(value * 2.54):f2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{value} feet = {(value * 30):f2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{value} yards = {(value * 0.91):f2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{value} gallons = {(value * 3.8):f2} liters");
                    break;
                default:
                    break;
            }




        }
    }
}
