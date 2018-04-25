using System;

namespace P02VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double moneySpent = 0;
            string gameTitle = "";

            while (gameTitle != "Game Time" && budget > 0)
            {
                gameTitle = Console.ReadLine();
                double price = 0;

                switch (gameTitle)
                {
                    case "OutFall 4":
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;

                    case "CS: OG":
                        price = 15.99;
                        break;

                    case "Zplinter Zell":
                        price = 19.99;
                        break;

                    case "Honored 2":
                        price = 59.99;
                        break;

                    case "RoverWatch":
                        price = 29.99;
                        break;

                    case "Game Time":
                        continue;
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        continue;
                        break;
                }

                if (price <= budget)
                {
                    budget -= price;
                    moneySpent += price;
                    Console.WriteLine($"Bought {gameTitle}");
                }
                else if (price > budget)
                {
                    Console.WriteLine("Too Expensive");
                }

            }

            if (budget != 0)
            {
                Console.WriteLine($"Total spent: ${moneySpent:F2}. Remaining: ${budget:F2}");
            } else
            {
                Console.WriteLine("Out of money!");
            }

            //main ends here
        }
    }
}
