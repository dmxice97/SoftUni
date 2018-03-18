using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double pCount = double.Parse(Console.ReadLine());
            string service = Console.ReadLine();

            double price = 0;
            string hall = "";
            double discount = 0;

            if (pCount <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (pCount <=100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (pCount <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }


            switch (service)
            {
                case "Normal":
                    discount = 0.05;
                    price += 500;
                    price = price - (discount * price);
                    break;
                case "Gold":
                    discount = 0.1;
                    price += 750;
                    price = price - (discount * price);
                    break;
                case "Platinum":
                    discount = 0.15;
                    price += 1000;
                    price = price - (discount * price);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {(price / pCount):f2}$");










        }
    }
}
