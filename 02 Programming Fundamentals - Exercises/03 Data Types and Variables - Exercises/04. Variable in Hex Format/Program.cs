﻿using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            decimal output = Convert.ToInt32(input, 16);
            Console.WriteLine(output);


        }
    }
}
