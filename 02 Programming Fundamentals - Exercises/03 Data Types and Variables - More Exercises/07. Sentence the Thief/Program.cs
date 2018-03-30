using System;


namespace _06._Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            //finding Prisoner ID
            string type = Console.ReadLine();
            int numberIDs = int.Parse(Console.ReadLine());
            long id = 0;
            long maxValue = 0;
            long PrisonerID = long.MinValue;

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

                if (id > PrisonerID && id <= maxValue)
                {
                    PrisonerID = id;
                }

            }

            //calculating sentense
            long saveID = PrisonerID;
            double sentense = 0.0;
            if (PrisonerID > 0)
            {
                sentense = Math.Ceiling((double)PrisonerID / 127);
                
               
            }
            else if (PrisonerID == 0)
            {
                sentense = 1;
            }
            else if (PrisonerID < 0)
            {
                sentense = Math.Ceiling((double)PrisonerID / -128);
            }

            if (PrisonerID == 1)
            {
                Console.WriteLine($"Prisoner with id {PrisonerID} is sentenced to {sentense} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {PrisonerID} is sentenced to {sentense} years");
            }
            
        }
    }
}
