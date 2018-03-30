
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture).AddDays(999);

        Console.WriteLine(date.ToString("dd-MM-yyyy"));
    }
}