﻿using System;

namespace _02._Rectangle_of_N_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }

        }
    }
}
