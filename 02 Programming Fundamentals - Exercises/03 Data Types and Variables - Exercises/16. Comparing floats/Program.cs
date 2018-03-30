using System;

namespace _16._Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            bool answer;
            double sum = 0.000001;


            if (Math.Abs(numOne - numTwo) > sum)
            {
                answer = false;
                Console.WriteLine(answer);
            }
            else
            {
                answer = true;
                Console.WriteLine(answer);
            }











        }
    }
}
