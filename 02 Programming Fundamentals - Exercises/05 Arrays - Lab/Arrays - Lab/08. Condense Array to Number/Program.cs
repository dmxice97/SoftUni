using System;
using System.Linq;
namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
            }

            else
            {
                int lastIndex = arr.Length - 1;
                while (lastIndex != 0)
                {
                    for (int i = 0; i < lastIndex; i++)
                    {
                        arr[i] += arr[i + 1];
                    }
                    arr[lastIndex] = 0;
                    lastIndex--;
                }
                Console.WriteLine(arr[0]);


            }



        }
    }
}
