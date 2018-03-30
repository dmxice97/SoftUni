using System;

namespace _02._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.WriteLine("Centimeters = {0}", centimeters);

        }
    }
}
