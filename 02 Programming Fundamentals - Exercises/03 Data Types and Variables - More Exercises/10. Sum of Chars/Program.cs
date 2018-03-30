using System;

namespace _10._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            char symbol = ' ';

            for (int i = 0; i < count; i++)
            {
                symbol = char.Parse(Console.ReadLine());

                sum += Convert.ToInt32(symbol);
            }

            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
