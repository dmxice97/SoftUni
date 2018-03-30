using System;

namespace ex._02
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());

            double perimeter = (sideA + sideA) + (sideB + sideB);
            double area = sideA * sideB;

            double sqrt = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(sqrt);

        }
    }
}
