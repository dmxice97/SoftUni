using System;


namespace _06._Catch_the_Thief
    {
        class Program
        {
            static void Main(string[] args)
            {
            
                string type = Console.ReadLine();
                int numberIDs = int.Parse(Console.ReadLine());
                long id = 0;
                long maxValue = 0;
                long currentMax = long.MinValue;

            switch (type)
            {
                case "sbyte":
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    maxValue = int.MaxValue;
                    break;
                default:
                    maxValue = long.MaxValue;
                    break;
            }

            for (int i = 0; i < numberIDs; i++)
                {
                    id = long.Parse(Console.ReadLine());

                    if (id > currentMax && id <= maxValue)
                    {
                        currentMax = id;
                    }

                }

                Console.WriteLine(currentMax);






            }
        }
    }
