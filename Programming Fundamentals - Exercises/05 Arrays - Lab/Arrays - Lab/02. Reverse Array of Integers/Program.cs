using System;

namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] arr = new string[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = Console.ReadLine();
            }

            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }





        }
    }
}
