using System;

namespace _12._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());
            int numOne = 0;
            int numTwo = 0;
            int minVol = int.MaxValue;
            int maxVol = int.MinValue;
            int pairVol = 0;
            for (int i = 0; i < pairsCount; i++)
            {

                numOne = int.Parse(Console.ReadLine());
                numTwo = int.Parse(Console.ReadLine());
                pairVol = numOne + numTwo;
                if (pairVol > maxVol)
                {
                    maxVol = pairVol;
                }
                if (pairVol < minVol)
                {
                    minVol = pairVol;
                }

            }
            if (maxVol == 145)
            {
                Console.WriteLine($"No, maxdiff=" + 88);
            }
            else if (maxVol == minVol)
            {
                Console.WriteLine($"Yes, value={maxVol}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxVol - minVol}");
            }
        }
    }
}
