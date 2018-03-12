using System;

namespace _12._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double special = int.Parse(Console.ReadLine());
            double home = int.Parse(Console.ReadLine());

            double games = 0;
            double weeknds = 48;

            weeknds = weeknds - home;
            weeknds = weeknds - (weeknds / 4);
            special = special - (special / 3);
            games += home;
            games += weeknds;
            games += special;
            if (year == "leap")
            {
                games = games + (games * 0.15);
            }

            Console.WriteLine(Math.Truncate(games));










        }
    }
}
