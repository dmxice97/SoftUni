﻿using System;

namespace _06._Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateArea(width, height);

            Console.WriteLine(area);


        }


        static double CalculateArea(double width, double height)
        {
            return (width * height) / 2;
        }


    }
}
