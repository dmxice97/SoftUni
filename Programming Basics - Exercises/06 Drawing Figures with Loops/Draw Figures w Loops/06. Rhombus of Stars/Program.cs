using System;

namespace _06._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top
            for (int rows = 1; rows <= n; rows++)
            {
                for (int spc = 0; spc < n - rows; spc++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int stars = 0; stars < rows - 1; stars++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();

            }


            for (int row = n - 1; row >= 0; row--)
            {
                for (int spc = 0; spc < n - row; spc++)
                {
                    Console.Write(" ");
                }

                for (int sts = 0; sts < row; sts++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
