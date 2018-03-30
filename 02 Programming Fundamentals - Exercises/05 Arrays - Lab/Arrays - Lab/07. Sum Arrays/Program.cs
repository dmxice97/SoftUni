using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            int[] result = new int[Math.Max(first.Length, second.Length)];

            for (int i = 0; i < result.Length; i++)
            {
                if (first.Length > second.Length)
                {
                    result[i] = first[i] + second[i % second.Length];

                }
                else if (first.Length < second.Length)
                {
                    result[i] = first[i % first.Length] + second[i];
                }
                else
                {
                    result[i] = first[i] + second[i];
                }
            }
            Console.WriteLine(string.Join(" ", result));


        }
    }
}
