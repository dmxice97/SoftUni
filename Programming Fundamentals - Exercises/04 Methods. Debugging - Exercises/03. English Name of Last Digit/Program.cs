using System;

namespace _03._English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            GetDiggit(number);
           
        }


        static void GetDiggit(string number)
        {
            char lastDiggit = number[number.Length - 1];
            Print(lastDiggit);
            
        }
        static void Print(char diggit)
        {
            switch (diggit)
            {
                case '1':
                    Console.WriteLine("one");
                    break;
                case '2':
                    Console.WriteLine("two");
                    break;
                case '3':
                    Console.WriteLine("three");
                    break;
                case '4':
                    Console.WriteLine("four");
                    break;
                case '5':
                    Console.WriteLine("five");
                    break;
                case '6':
                    Console.WriteLine("six");
                    break;
                case '7':
                    Console.WriteLine("seven");
                    break;
                case '8':
                    Console.WriteLine("eight");
                    break;
                case '9':
                    Console.WriteLine("nine");
                    break;
                case '0':
                    Console.WriteLine("zero");
                    break;

                default:
                    break;
            }
            
        }
    }
}
