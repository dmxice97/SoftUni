using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)

        {

            int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            if (inputNums.Length == 1)
            {
                Console.WriteLine(inputNums[0]);

            }
            else if (inputNums.Length % 2 == 0)
            {
                num1 = inputNums[inputNums.Length / 2 - 1];
                num2 = inputNums[inputNums.Length / 2];
                Console.WriteLine($"{{ {num1}, {num2} }}");
            }
            else if (inputNums.Length % 2 != 0)
            {
                num1 = inputNums[inputNums.Length / 2 - 1];
                num2 = inputNums[inputNums.Length / 2];
                num3 = inputNums[inputNums.Length / 2 + 1];
                Console.WriteLine($"{{ {num1}, {num2}, {num3} }}");
            }


        }
    }
}
