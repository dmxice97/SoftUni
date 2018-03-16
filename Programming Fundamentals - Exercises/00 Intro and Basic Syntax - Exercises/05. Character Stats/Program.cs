using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {

            string charName = Console.ReadLine();
            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());


            Console.WriteLine($"Name: {charName}");

            Console.WriteLine($"Health: |{(new string('|', currHealth))}{(new string('.',maxHealth - currHealth))}|");
            Console.WriteLine($"Energy: |{(new string('|', currEnergy))}{(new string('.', maxEnergy - currEnergy))}|");



        }
    }
}
