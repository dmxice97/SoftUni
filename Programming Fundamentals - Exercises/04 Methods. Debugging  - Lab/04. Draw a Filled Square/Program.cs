using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Line(n);
            Middle(n);
            Line(n);

        }


        static void Line(int number)
        {
            for (int i = 1; i <= number * 2; i++)
            {
                Console.Write("-");
                
            }
            Console.WriteLine();
        }
        static void Middle(int number)
        {
            for (int i = 1; i <= number - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j <= number - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
                
            }
            
        }
    }
}
