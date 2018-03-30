using System;

namespace _05._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            for (int i = 1; i <= numbersCount; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current > biggest)
                {
                    biggest = current;
                }

            }
            Console.WriteLine(biggest);
        }
    }
}
