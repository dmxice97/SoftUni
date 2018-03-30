using System;

namespace _14._Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boatOne = char.Parse(Console.ReadLine());
            char boatTwo = char.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int current = 0;
            string tilesWord = "";
            int bt1distance = 0;
            int bt2distance = 0;

            for (int i = 1; i <= count; i++)
            {
                tilesWord = Console.ReadLine();


                if (tilesWord == "UPGRADE")
                {
                    current = (Convert.ToInt32(boatOne) + 3);
                    boatOne = Convert.ToChar(current);
                    current = (Convert.ToInt32(boatTwo) + 3);
                    boatTwo = Convert.ToChar(current);
                    
                }
                else if (i % 2 != 0)
                {
                    bt1distance += tilesWord.Length;
                }
                else if (i % 2 == 0)
                {
                    bt2distance += tilesWord.Length;
                }
                if (bt2distance >= 50 || bt1distance >= 50)
                {
                    if (bt1distance > bt2distance)
                    {
                        Console.WriteLine(boatOne);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(boatTwo);
                        return;
                    }
                }

            }
            if (bt1distance > bt2distance)
            {
                Console.WriteLine(boatOne);
                
            }
            else
            {
                Console.WriteLine(boatTwo);
                
            }
        }
    }
}
