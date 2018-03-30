using System;

namespace _13._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            char particle = ' ';
            string decript = "";
            int currentChar = 0;

            for (int i = 1; i <= count; i++)
            {
                particle = char.Parse(Console.ReadLine());
                currentChar = Convert.ToInt32(particle) + Convert.ToInt32(key);
                decript += Convert.ToChar(currentChar);
            }
            Console.WriteLine(decript);



        }
    }
}
