using System;

namespace _04._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= numbersCount; i++)
            {
                counter += int.Parse(Console.ReadLine());

            }
            Console.WriteLine(counter);
        }
    }
}
