using System;

namespace _17._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            char current;

            for (int i = start; i <= end; i++)
            {
                current = Convert.ToChar(i);
                Console.Write(current + " ");

            }




        }
    }
}
