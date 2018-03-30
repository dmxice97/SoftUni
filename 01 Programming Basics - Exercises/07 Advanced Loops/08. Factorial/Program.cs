using System;

namespace _08._Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = 1;
            do
            {
                result = result * n;
                n--;
            }
            while (n > 1);
            Console.WriteLine(result);
        }
    }
}
