using System;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)

        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 + 5 > num2)
            {
                Console.WriteLine("No");
            }

            for (int i = num1; i <= num2 - 4; i++)
            {
                for (int k = num1 + 1; k <= num2 - 3; k++)
                {
                    for (int l = num1 + 2; l <= num2 - 2; l++)
                    {
                        for (int m = num1 + 3; m <= num2 - 1; m++)
                        {
                            for (int n = num1 + 4; n <= num2; n++)
                            {
                                if (i<k && k<l && l<m && m<n)
                                {
                                    Console.WriteLine($"{i} {k} {l} {m} {n}");
                                }
                            }
                        }
                    }
                }
                
            }


        }
    }
}
