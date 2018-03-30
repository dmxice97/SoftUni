using System;

namespace _07._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;

            for (int i = 1; i <= n; i++)
            {
                firstSum += int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                secondSum += int.Parse(Console.ReadLine());
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum}");

            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(firstSum - secondSum)} ");
            }
        }
    }
}
