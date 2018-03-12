using System;

namespace _06._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int biggest = int.MaxValue;
            for (int i = 1; i <= numbersCount; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current < biggest)
                {
                    biggest = current;
                }

            }
            Console.WriteLine(biggest);
        }
    }
}
