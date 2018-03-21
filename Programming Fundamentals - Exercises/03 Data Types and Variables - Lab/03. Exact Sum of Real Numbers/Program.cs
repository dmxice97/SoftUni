using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputNum = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 0; i < inputNum; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);

        }
    }
}
