using System;

namespace _15._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string current = "";
            string openBr = "(";
            string closeBr = ")";
            int opened = 0;
            int closed = 0;
            

            
            for (int i = 1; i <= count; i++)
            {
                current = Console.ReadLine();
                if (current == openBr)
                    opened++;
                else if (current == closeBr)
                    closed++;
                if (closed > opened)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }

            if (opened == closed)
                Console.WriteLine("BALANCED");
            else
                Console.WriteLine("UNBALANCED");





        }
    }
}
