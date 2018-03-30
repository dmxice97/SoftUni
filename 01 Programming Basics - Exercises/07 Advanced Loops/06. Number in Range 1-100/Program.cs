using System;

namespace _06._Number_in_Range_1_100
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number.Type number again: ");
                num = int.Parse(Console.ReadLine());
            }
            while (num >= 1 && num <= 100)
            {
                Console.WriteLine("Correct number.Your number is:{0}", num);
                break;

            }
        }
    }
}
