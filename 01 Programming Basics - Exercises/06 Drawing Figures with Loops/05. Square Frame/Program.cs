using System;

namespace _05._Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+ ");
            Console.WriteLine();



            //mid
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.Write("| ");
                Console.WriteLine();
            }

            //bot

            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+ ");
        }
    }
}
