using System;

namespace _08._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCount = int.Parse(Console.ReadLine());

            int evens = 0;
            int odds = 0;
            int tempNumber = 0;
            for (int i = 1; i <= nCount; i++)
            {
                tempNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evens += tempNumber;
                }
                else
                {
                    odds += tempNumber;
                }
            }
            if (odds == evens)
            {
                Console.WriteLine($"Yes \r\n" +
                    $"Sum = {odds}");

            }
            else
            {
                Console.WriteLine($"No \r\n" +
                    $"Diff = {Math.Abs(odds - evens)}");
            }
        }
    }
}
