using System;

namespace _12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());

            int m = int.Parse(Console.ReadLine());

            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    sum = i + j;
                    counter++;
                    if (sum == number)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {sum}");
                        return;
                    }
                    
                    else
                    {
                        sum = 0;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {number}");


        }
    }
}
