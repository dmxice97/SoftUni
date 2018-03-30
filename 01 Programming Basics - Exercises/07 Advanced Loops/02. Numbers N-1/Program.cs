using System;

namespace _02._Numbers_N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i -= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
