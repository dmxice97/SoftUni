using System;

namespace _10._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalType = Console.ReadLine();

            if (animalType == "dog")
                Console.WriteLine("mammal");
            else if (animalType == "tortoise" || animalType == "crocodile" || animalType == "snake")
                Console.WriteLine("reptile");
            else
                Console.WriteLine("unknown");

        }
    }
}
