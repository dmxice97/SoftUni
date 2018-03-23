using System;

namespace _07._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {   
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double power = GetPower(num1, num2);
            Console.WriteLine(power);
        }

        static double GetPower(double num1, double num2)
        {

            return Math.Pow(num1, num2);

        }
    }
}
