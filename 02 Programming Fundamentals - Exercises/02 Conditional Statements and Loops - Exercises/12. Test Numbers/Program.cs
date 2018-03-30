using System;

namespace _12._Test_Numbers
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());
            
int m = int.Parse(Console.ReadLine());

            int max = int.Parse(Console.ReadLine());
            int combo = 0;
            int counter = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (max > combo)
                    { 
                        counter++;
                        combo += 3 * (i * j);
                    }
                }
            }

            Console.WriteLine($"{counter} combinations");
            if (combo >= max)
            {
                Console.WriteLine($"Sum: {combo} >= {max}");
            }
            else
            {
                Console.WriteLine($"Sum: {combo}");
            }
           
        }
    }
}
