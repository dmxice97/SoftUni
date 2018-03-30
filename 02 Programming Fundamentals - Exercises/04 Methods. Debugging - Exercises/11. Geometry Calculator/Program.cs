using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "triangle":
                    PrintTriangle();
                    break;
                case "square":
                    PrintSquare();
                    break;
                case "rectangle":
                    PrintRectangle();
                    break;
                case "circle":
                    PrintCircle();
                    break;
                default:
                    break;
            }
        }
        static void PrintTriangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{((side * height)/2):f2}");
        }
        static void PrintSquare()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(side * side):f2}");
        }
        static void PrintRectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(width * height):f2}");
        }
        static void PrintCircle()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{((radius * radius) * Math.PI):f2}");
        }
    }
}
