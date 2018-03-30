using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before: \r\n a = {a} \r\n b = {b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After: \r\n a = {a} \r\n b = {b}");
            





        }
    }
}
