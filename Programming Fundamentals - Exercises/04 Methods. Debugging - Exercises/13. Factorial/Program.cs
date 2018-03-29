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
            Console.WriteLine(factorial);
            
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
    }
}
