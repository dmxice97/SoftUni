using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string sum = GetSum(input);
            Console.WriteLine(sum);


        }
        static string GetSum(string input)
        {
            int count = input.Length;
            int sumOdd = GetOdd(int.Parse(input),count);
            int sumEven = GetEven(int.Parse(input), count);
            int sum = sumEven * sumOdd;
            
            return sum.ToString();
        }

        static int GetOdd (int number, int count)
        {
            int sum = 0;
            for (int i = 1; i <= count; i++)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetEven(int number, int count)
        {
            int sum = 0;
            for (int i = 1; i <= count; i++)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
