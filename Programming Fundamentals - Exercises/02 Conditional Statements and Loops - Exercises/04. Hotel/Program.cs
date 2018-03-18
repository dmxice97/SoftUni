using System;

namespace p04Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double smallStudio = 0.0;
            double mediumStudio = 0.0;
            double largeStudio = 0.0;

            switch (month)
            {
                case "May":
                    mediumStudio = 65 * nightsCount;
                    largeStudio = 75 * nightsCount;
                    if (nightsCount > 7)
                    {
                        smallStudio = 50 * 0.95 * nightsCount;
                    }
                    else
                    {
                        smallStudio = 50 * nightsCount;
                    }

                    break;
                case "October":
                    mediumStudio = 65 * nightsCount;
                    largeStudio = 75 * nightsCount;
                    if (nightsCount > 7)
                    {
                        smallStudio = (50 * 0.95 * nightsCount) - (50 * 0.95);
                    }
                    else smallStudio = 50 * nightsCount;
                    break;
                case "June":
                    smallStudio = 60 * nightsCount;
                    largeStudio = 82 * nightsCount;
                    if (nightsCount > 14)
                    {
                        mediumStudio = 72 * 0.9 * nightsCount;
                    }
                    else mediumStudio = 72 * nightsCount;
                    break;
                case "September":
                    smallStudio = 60 * nightsCount;
                    mediumStudio = 72 * nightsCount;
                    largeStudio = 82 * nightsCount;
                    if (nightsCount > 7)
                    {
                        smallStudio = 60 * nightsCount - 60;
                    }
                    if (nightsCount > 14)
                    {
                        mediumStudio = 72 * 0.9 * nightsCount;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    smallStudio = 68 * nightsCount;
                    mediumStudio = 77 * nightsCount;
                    if (nightsCount > 14)
                    {
                        largeStudio = 0.85 * 89 * nightsCount;
                    }
                    else
                    {
                        largeStudio = 89 * nightsCount;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Studio: {smallStudio:f2} lv.");
            Console.WriteLine($"Double: {mediumStudio:f2} lv.");
            Console.WriteLine($"Suite: {largeStudio:f2} lv.");
        }
    }
}