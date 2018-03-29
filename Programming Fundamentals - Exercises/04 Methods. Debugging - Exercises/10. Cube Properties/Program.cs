using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            string get = Console.ReadLine();

            switch (get)
            {
                case "face":
                    GetFace(lenght);
                    break;
                case "space":
                    GetSpace(lenght);
                    break;
                case "volume":
                    GetVolume(lenght);
                    break;
                case "area":
                    GetArea(lenght);
                    break;

                default:
                    break;
            }

        }
        static void GetFace(double lenght)
        {
            double volume = (Math.Sqrt(2 * Math.Pow(lenght, 2)));
            Console.WriteLine($"{(volume):f2}");
        }
        static void GetSpace(double lenght)
        {
            double volume = (Math.Sqrt(3 * Math.Pow(lenght, 2)));
            Console.WriteLine($"{(volume):f2}");
        }
        static void GetVolume(double lenght)
        {
            double volume = (lenght * lenght) * lenght;
            Console.WriteLine($"{(volume):f2}");
        }
        static void GetArea(double lenght)
        {
            double volume = (lenght * lenght) * 6;
            Console.WriteLine($"{(volume):f2}");
        }
    }
}
