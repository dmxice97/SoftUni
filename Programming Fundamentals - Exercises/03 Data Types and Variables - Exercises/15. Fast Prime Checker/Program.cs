using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            for (int i = 2; i <= first; i++)
            {
                bool checknumber = true;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        checknumber = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {checknumber}");
            }

        }
    }
}
