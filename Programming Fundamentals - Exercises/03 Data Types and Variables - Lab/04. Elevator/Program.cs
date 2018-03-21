using System;

namespace _04._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int cources = 0;

            if (count % capacity == 0)
            {
                cources = count / capacity;
            }
            else 
            {
                cources = (count / capacity) + 1;
            }

            Console.WriteLine(cources);

        }
    }
}
