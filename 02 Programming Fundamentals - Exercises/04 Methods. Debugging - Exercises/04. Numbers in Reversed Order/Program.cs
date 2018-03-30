using System;

namespace _04._Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Print(number);
        }


        static void Print(string number)
        {
            char current = ' ';
            string output = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                current = number[i];
                output += current;
            }
            Console.WriteLine(output);
        }
    }
}
