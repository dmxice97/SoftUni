using System;

namespace _02._Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int max = GetMax(one, two, three);
            Console.WriteLine(max);
        }



        static int GetMax (int one, int two,int three)
        {
            int max = Math.Max(Math.Max(one, two), three);
            return max;
        }
    }

}
