using System;

namespace _10._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            int numSum = 0;
            int biggest = int.MinValue;
            int current = int.MinValue;
            for (int i = 1; i <= numCount; i++)
            {

                current = int.Parse(Console.ReadLine());
                numSum += current;
                if (current > biggest)
                {
                    biggest = current;
                }
            }

            if (numSum - biggest == biggest)
            {
                Console.WriteLine($"Yes \r\n" +
                $"Sum = {biggest}");
            }

            else
            {
                Console.WriteLine($"No \r\n" +
                $"Diff = {Math.Abs(biggest - Math.Abs(numSum - biggest))}");

            }
        }
    }
}
