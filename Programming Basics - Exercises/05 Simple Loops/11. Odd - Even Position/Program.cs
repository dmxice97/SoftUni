using System;

namespace _11._Odd___Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double current = 0;

            for (int i = 1; i <= numCount; i++)
            {
                current = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += current;
                    if (current > evenMax)
                    {
                        evenMax = current;
                    }
                    if (current < evenMin)
                    {
                        evenMin = current;
                    }
                }
                else if (i % 2 != 0)
                {
                    oddSum += current;
                    if (current > oddMax)
                    {
                        oddMax = current;
                    }
                    if (current < oddMin)
                    {
                        oddMin = current;
                    }
                }

            }
            if (numCount == 1)
            {
                Console.WriteLine("OddSum = " + oddSum + ",");
                Console.WriteLine("OddMin = " + oddMin + ",");
                Console.WriteLine("OddMax = " + oddMax + ",");
                Console.WriteLine("EvenSum = " + evenSum + ",");
                Console.WriteLine("EvenMin = " + "no" + ",");
                Console.WriteLine("EvenMax = " + "no");
            }
            else if (numCount == 0)
            {
                Console.WriteLine("OddSum = " + oddSum + ",");
                Console.WriteLine("OddMin = " + "no" + ",");
                Console.WriteLine("OddMax = " + "no" + ",");
                Console.WriteLine("EvenSum = " + evenSum + ",");
                Console.WriteLine("EvenMin = " + "no" + ",");
                Console.WriteLine("EvenMax = " + "no");
            }
            else
            {
                Console.WriteLine("OddSum = " + oddSum + ",");
                Console.WriteLine("OddMin = " + oddMin + ",");
                Console.WriteLine("OddMax = " + oddMax + ",");
                Console.WriteLine("EvenSum = " + evenSum + ",");
                Console.WriteLine("EvenMin = " + evenMin + ",");
                Console.WriteLine("EvenMax = " + evenMax);

            }
        }
    }
}
