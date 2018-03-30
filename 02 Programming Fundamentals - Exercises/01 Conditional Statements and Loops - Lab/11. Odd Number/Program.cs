using System;

namespace _11._Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;


            try
            {
                 num = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input!");
                return;
            }
            Console.WriteLine("It is a number.");

        }
    }
}
