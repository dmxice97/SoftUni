using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string drinkName = Console.ReadLine();
            int mils = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());


            Console.WriteLine($"{mils}ml {drinkName}:");
            Console.WriteLine($"{(mils * energy) * 0.01}kcal, {(mils * sugar) * 0.01}g sugars");
               
        }
    }
}
