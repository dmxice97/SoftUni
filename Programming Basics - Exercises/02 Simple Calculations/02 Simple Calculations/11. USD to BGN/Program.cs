using System;

namespace _11._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var usdTolev = 1.79549;
            var lev = usd * usdTolev;
            Console.WriteLine(lev.ToString("f2") + " BGN");
        }
    }
}
