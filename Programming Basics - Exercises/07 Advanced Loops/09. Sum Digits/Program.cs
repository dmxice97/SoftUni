using System;

namespace _09._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);

            var sum = 0;
            while (n > 0)
            {
                var digit = n % 10;
                sum = sum + digit;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
