using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            bool none = true;

            for (int a = 0; a < arr.Length - 1; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (arr[a] + arr[b] == arr[c])
                        {
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {arr[c]}");
                            none = false;
                            break;
                        }
                    }
                }
            }
            if (none)
            {
                Console.WriteLine("No");
            }
        }
    }
}