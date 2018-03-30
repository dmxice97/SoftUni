using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startStars = 2 - n % 2;
            int topRows = (n + 1) / 2;
            //int topRows = (int)Math.Ceiling(n / 2.0);
            int lowRows = n - topRows;

            //top row
            int startDashes = (n - startStars) / 2;
            Console.Write(new string('-', startDashes));
            Console.Write(new string('*', startStars));
            Console.WriteLine(new string('-', startDashes));

            //top other rows
            for (int i = 0; i < topRows - 1; i++)
            {
                int insideDashes = startStars + i * 2;
                int outerDashes = (n - 2 - insideDashes) / 2;
                Console.Write(new string('-', outerDashes));
                Console.Write('*');
                Console.Write(new string('-', insideDashes));
                Console.Write('*');
                Console.WriteLine(new string('-', outerDashes));

            }

            //low rows


            for (int j = 0; j < lowRows - 1; j++)
            {
                int insideDashes = n - 4 - 2 * j;
                int outerDashes = (n - 2 - insideDashes) / 2;

                Console.Write(new string('-', outerDashes));
                Console.Write('*');
                Console.Write(new string('-', insideDashes));
                Console.Write('*');
                Console.WriteLine(new string('-', outerDashes));

            }

            if (n > 2 && n % 2 != 0)
            {
                Console.Write(new string('-', startDashes));
                Console.Write(new string('*', startStars));
                Console.WriteLine(new string('-', startDashes));

            }
        }
    }
}