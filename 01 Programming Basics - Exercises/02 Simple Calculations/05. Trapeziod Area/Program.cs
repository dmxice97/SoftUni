﻿using System;

namespace _05._Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var lice = (b1 + b2) * h / 2;
            Console.WriteLine("Trapezoid area = " + lice);
        }
    }
}