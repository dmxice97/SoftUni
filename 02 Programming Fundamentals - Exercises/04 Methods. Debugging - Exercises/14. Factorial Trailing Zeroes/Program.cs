using System;
using System.Numerics;

namespace _13._Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(num);
            PrintZeroes(factorial);

        }

        static BigInteger Factorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        static void PrintZeroes(BigInteger factorial)
        {
            string number = factorial.ToString();
            int counter = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] == '0')
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
