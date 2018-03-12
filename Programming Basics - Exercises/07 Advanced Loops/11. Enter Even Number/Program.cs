using System;

namespace _11._Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                try
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Thank you.");
                        Console.WriteLine("n = " + n);
                    }

                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    n = int.Parse(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("Not number.");
                    return;
                }
            }
        }

        }
}
