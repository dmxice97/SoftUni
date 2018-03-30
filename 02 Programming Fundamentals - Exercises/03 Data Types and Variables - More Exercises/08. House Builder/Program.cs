using System;

namespace _08._House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long priceByte = long.Parse(Console.ReadLine());
            long priceInt = long.Parse(Console.ReadLine());

            long sum = (long)(Math.Min(priceByte, priceInt) * 4) + (long)(Math.Max(priceByte, priceInt) * 10);
            Console.WriteLine(sum);






        }
    }
}
