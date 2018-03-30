using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
           
            int allSec = seconds + (minutes * 60) + ((hours * 60) *  60);

            float metersPerSec = (float)meters / allSec;
            float kmPerHour = ((float)meters / 1000) / ((float)allSec / 3600);
            float mpPerHour = ((float)meters / 1609) / ((float)allSec / 3600);

            Console.WriteLine($"{metersPerSec:0.#######}");
            Console.WriteLine($"{kmPerHour:0.#######}");
            Console.WriteLine($"{mpPerHour:0.#######}");






        }
    }
}
