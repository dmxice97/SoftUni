using System;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string message = "";
            bool canFit = false;

            try
            {
                sbyte num = sbyte.Parse(input);
                message += "* sbyte\r\n";
                canFit = true;

            }
            catch { }
            try
            {
                byte num = byte.Parse(input);
                message += "* byte\r\n";
                canFit = true;

            }
            catch { }
            try
            {
                short num = short.Parse(input);
                message += "* short\r\n";
                canFit = true;

            }
            catch { }
            try
            {
                ushort num = ushort.Parse(input);
                message += "* ushort\r\n";
                canFit = true;

            }
            catch { }
            try
            {
                int num = int.Parse(input);
                message += "* int\r\n";
                canFit = true;

            }
            catch { }
            try
            {
                uint num = uint.Parse(input);
                message += "* uint\r\n";
                canFit = true;

            }
            catch { }

            try
            {
                long num = long.Parse(input);
                message += "* long\r\n";
                canFit = true;

            }
            catch { }

            if (canFit)
            {
                Console.WriteLine($"{input} can fit in:");
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine($"{input} can't fit in any type");
            }



        }

    }
}