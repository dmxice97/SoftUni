using System;

namespace _12._Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (IsPalindrome(i) == true &&
                    SumOfDigits(i) == true &&
                    ContainsEvenDigit(i) == true )
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPalindrome(int num)
        {
            string num2 = Convert.ToString(num);
            for (int i = 0; i < num2.Length / 2; i++)
            {
                if (num2[i] != num2[num2.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
        static bool SumOfDigits(int number)
        {

            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }

            return false;
        }
        static bool ContainsEvenDigit(int num)
        {

            while (num > 0)
            {
                int digitToCheck = num % 10;

                if (digitToCheck % 2 == 0)
                {
                    return true;
                }

                num /= 10;
            }

            return false;
        }
    }
}
