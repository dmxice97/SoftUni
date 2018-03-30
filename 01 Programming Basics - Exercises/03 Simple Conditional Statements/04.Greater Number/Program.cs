using System;

namespace _04.Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            var grade1 = double.Parse(Console.ReadLine());
            if (grade >= grade1)
                Console.WriteLine(grade);
            else
                Console.WriteLine(grade1);
        }
    }
}
