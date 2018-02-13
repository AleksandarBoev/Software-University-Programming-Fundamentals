using System;
using System.Collections.Generic;

namespace P03AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceQuantity = new Dictionary<string, int>();

            string resource = "";
            int quantity = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                try 
                {
                    quantity = int.Parse(input);
                    resourceQuantity[resource] += quantity;
                }
                catch // ako ne e vuvedeno chislo, to togava e resurs
                {
                    resource = input;
                    if (resourceQuantity.ContainsKey(resource) == false)
                    {
                        resourceQuantity.Add(resource, 0);
                    }
                }

            }

            foreach (var kvp in resourceQuantity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            //main ends here
        }
    }
}
