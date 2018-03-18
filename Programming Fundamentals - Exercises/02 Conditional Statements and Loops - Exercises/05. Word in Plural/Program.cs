using System;

namespace _05._Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputword = Console.ReadLine();


            if (inputword.EndsWith("y"))
            {
                inputword = inputword.Remove(inputword.Length - 1);
                inputword += "ies";
            }
            else if (inputword.EndsWith("o") || inputword.EndsWith("x") || inputword.EndsWith("z") 
                || inputword.EndsWith("x") || inputword.EndsWith("sh") || inputword.EndsWith("ch"))
            {
              
                inputword += "es";
            }
           
            else
            {
                inputword += "s";
            }
            Console.WriteLine(inputword);

           
            
        }
    }
}
