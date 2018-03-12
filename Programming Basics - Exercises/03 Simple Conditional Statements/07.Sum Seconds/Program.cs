using System;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());

            var seconds = first + second + third;
            var minutes = seconds / 60;
            var leftsecs = seconds % 60;

            Console.WriteLine("{0}:{1:00}", minutes, leftsecs);
        }
    }
}
