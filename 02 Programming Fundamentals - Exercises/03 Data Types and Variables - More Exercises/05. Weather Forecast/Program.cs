﻿using System;

namespace _05._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {

            long number;

            try
            {
                number = long.Parse(Console.ReadLine());

                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    Console.WriteLine("Sunny");
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    Console.WriteLine("Windy");
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Rainy");
            }



        }
    }
}
