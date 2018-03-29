using System;
using System.Linq;
using System.Numerics;
using System.Globalization;
using System.Collections;

namespace _05._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] input = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();
            int[] output = new int[input.Length];



            for (int i = 0; i < input.Length; i++)
            {
                output[i] = (int) Math.Round(input[i],MidpointRounding.AwayFromZero);

            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {output[i]}");
            }


        }
    }
}
