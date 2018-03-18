using System;

namespace _01._Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {

            string proffesion = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price = 0;

            switch (proffesion)
            {
                case "Athlete":
                    price = 0.70;
                    Console.WriteLine($"The {proffesion} has to pay {(count * price):f2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = 1.00;
                    Console.WriteLine($"The {proffesion} has to pay {(count * price):f2}.");
                    break;
                case "SoftUni Student":
                    price = 1.70;
                    Console.WriteLine($"The {proffesion} has to pay {(count * price):f2}.");
                    break;
                default:
                    price = 1.20;
                    Console.WriteLine($"The {proffesion} has to pay {(count * price):f2}.");
                    break;
            }


        }
    }
}
