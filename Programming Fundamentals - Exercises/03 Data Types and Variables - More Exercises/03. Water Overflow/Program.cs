using System;

namespace _03._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankValue = 255;
            int current;
            int whole = 0;
            int counter = int.Parse(Console.ReadLine());


            for (int i = 0; i < counter; i++)
            {
                current = int.Parse(Console.ReadLine());
                
                if (current + whole > tankValue)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    whole += current;
                }
            }
            Console.WriteLine(whole);


        }
    }
}
