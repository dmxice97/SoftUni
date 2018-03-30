using System;

namespace _02._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var productName = Console.ReadLine();
            var city = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (productName == "coffee")
                    Console.WriteLine(quantity * 0.5);
                else if (productName == "water")
                    Console.WriteLine(quantity * 0.8);
                else if (productName == "beer")
                    Console.WriteLine(quantity * 1.2);
                else if (productName == "sweets")
                    Console.WriteLine(quantity * 1.45);
                else if (productName == "peanuts")
                    Console.WriteLine(quantity * 1.60);
            }
            else if (city == "Plovdiv")
            {
                if (productName == "coffee")
                    Console.WriteLine(quantity * 0.4);
                else if (productName == "water")
                    Console.WriteLine(quantity * 0.7);
                else if (productName == "beer")
                    Console.WriteLine(quantity * 1.15);
                else if (productName == "sweets")
                    Console.WriteLine(quantity * 1.3);
                else if (productName == "peanuts")
                    Console.WriteLine(quantity * 1.50);
            }
            else if (city == "Varna")
            {
                if (productName == "coffee")
                    Console.WriteLine(quantity * 0.45);
                else if (productName == "water")
                    Console.WriteLine(quantity * 0.7);
                else if (productName == "beer")
                    Console.WriteLine(quantity * 1.1);
                else if (productName == "sweets")
                    Console.WriteLine(quantity * 1.35);
                else if (productName == "peanuts")
                    Console.WriteLine(quantity * 1.55);
            }
        }
    }
}
