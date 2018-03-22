using System;

namespace _12._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string model = "";
            double radius = 0.0;
            int height = 0;
            double sum = 0.0;
            double biggestSum = 0.0;


            string biggest = "";

            for (int i = 1; i <= count; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());

                sum = (Math.PI * (radius * radius)) * height;

                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    biggest = model;
                }


            }
            Console.WriteLine(biggest);





        }
    }
}
