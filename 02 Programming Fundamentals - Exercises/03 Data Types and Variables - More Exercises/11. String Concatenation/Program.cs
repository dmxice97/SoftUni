using System;

namespace _11._String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char separator = char.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string word = "";
            string ouputWord = ""; 


            for (int i = 1; i <= count; i++)
            {
                word = Console.ReadLine();


                if (type == "even")
                {
                    if (i % 2 == 0)
                    {
                        ouputWord += word + separator;
                    }
                }
                else if (type == "odd")
                {
                    if (i % 2 != 0)
                    {
                        ouputWord += word + separator;
                    }
                }
            }
            Console.WriteLine(ouputWord.Remove(ouputWord.Length - 1));









        }
    }
}
