using System;

namespace _02._Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            double balance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine(); ;
            double counter = 0;

            while (input != "Game Time")
            {

                if (counter > balance)
                {
                    Console.WriteLine("Out of Money!");
                    return;
                }

                switch (input)
                {
                    
                    case "OutFall 4":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            counter += 39.99;
                            Console.WriteLine($"Bought {input}");
                        }
                        break;
                    case "CS: OG":
                        if (balance < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;

                        }
                        else
                        {
                            counter += 15.99;
                            Console.WriteLine($"Bought {input}");
                            
                        }
                        break;
                    case "Zplinter Zell":
                        if (balance < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            counter += 19.99;
                            Console.WriteLine($"Bought {input}");

                        }
                        
                        break;
                    case "Honored 2":
                        if (balance < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            counter += 59.99;
                            Console.WriteLine($"Bought {input}");

                        }
                      
                        break;
                    case "RoverWatch":
                        if (balance < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            counter += 29.99;
                            Console.WriteLine($"Bought {input}");

                        }
                    
                        break;
                    case "RoverWatch Origins Edition":
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Bought {input}");
                            counter += 39.99;
                        }
                        
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;

                }
                if (counter > balance)
                {
                    Console.WriteLine("Out of Money!");
                    return;
                }

                input = Console.ReadLine();



            }
            if (counter == balance)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${(counter):f2}. Remaining: ${(balance - counter):f2}");
            }
           


           








        }
    }
}
