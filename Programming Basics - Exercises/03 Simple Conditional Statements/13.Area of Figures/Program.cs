using System;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double side1 = side * side;
                Console.WriteLine("{0:F3}", side1);
            }
            else if (type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double whole = sideA * sideB;
                Console.WriteLine("{0:F3}", whole);
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = (radius * radius) * Math.PI;
                Console.WriteLine("{0:F3}", area);
            }
            else if (type == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double area = (sideA * sideB) / 2;

                Console.WriteLine("{0:F3}", area);
            }
        }
    }
}
