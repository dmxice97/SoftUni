using System;

namespace _09._Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            string word = "";
            char current = ' ';

            for (int i = 0; i < counter; i++)
            {
                current = char.Parse(Console.ReadLine());
                word += current;
            }

            Console.WriteLine($"The word is: {word}");


        }
    }
}
