using System;

namespace _13._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 0; i < inputNum; i++)
            {

                for (int j = 0; j <= i; j++)
                {

                    if (counter <= inputNum)
                    {
                        Console.Write(counter + " ");

                    }
                    counter++;

                }

                Console.WriteLine();


            }
        }
    }
}
