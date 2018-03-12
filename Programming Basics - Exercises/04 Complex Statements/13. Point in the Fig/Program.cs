using System;

namespace _13._Point_in_the_Fig
{
    class Program
    {
        static void Main(string[] args)
        {
            double bordA = double.Parse(Console.ReadLine());
            double pointA = double.Parse(Console.ReadLine());
            double pointB = double.Parse(Console.ReadLine());
            double bordB = bordA / 2;
            double bordC = bordA / 2;
            double bordD = bordA * 2;

            double bordE = bordA / 2;
            double bordF = 0;
            double bordH = 0;
            double bordG = bordA + (bordA / 2);
            if (pointA >= bordA && pointA <= bordB || pointA >= bordE && pointA <= bordF)
            {
                if (pointB >= bordC && pointB<= bordD || pointB >= bordH && pointB <= bordG)
                {
                    Console.WriteLine("inside");
                }
            }
            else
            {
                Console.WriteLine("outside");
            }
            


        }
    }
}
