using System;

namespace _09._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int total = 0;
            int current = 0;
            bool value = false;

            for (int i = 1; i <= count; i++)
            {
                current = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                value = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{current} -> {value}");
                total = 0;
                i = current;
            }







        }
    }
}
