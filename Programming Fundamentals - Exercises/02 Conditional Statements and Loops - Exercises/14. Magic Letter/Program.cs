using System;

namespace _14._Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char exception = char.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    for (int k = first; k <= second; k++)
                    {
                        if (exception == i  || exception == j || exception == k)
                        {

                        }
                        else
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                        }
                    }

                }
            }


        }
    }
}
