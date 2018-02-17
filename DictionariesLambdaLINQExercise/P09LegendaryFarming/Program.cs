using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P09LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> importantResources = new Dictionary<string, long>();
            importantResources.Add("shards", 0);
            importantResources.Add("fragments", 0);
            importantResources.Add("motes", 0);

            Dictionary<string, long> junk = new Dictionary<string, long>();

            string gatheredEnoughResourcesOf = "";

            //vuzmojen problem: ako nqkakuv legendary predmet bude izfarmen vsichko se spira ili se dobavqt i drugite resursi i posle se spira
            //sushto trqbva da izmislq kak da razbera koi legendary item e bil izfarmen
            bool legendaryItemFarmed = false;
            while (!legendaryItemFarmed)
            {
                string[] input = Console.ReadLine().Split();

                for (long i = 0; i < input.Length; i += 2)
                {
                    long quantity = long.Parse(input[i]);
                    string currentResource = input[i + 1].ToLower();

                    bool isJunk = currentResource != "fragments" && currentResource != "shards" && currentResource != "motes"; // ako ne e nito edin ot vajnite resursi => e bokluk
                    if (isJunk)
                    {
                        if (junk.ContainsKey(currentResource) == false)
                        {
                            junk.Add(currentResource, quantity);
                        }
                        else
                        {
                            junk[currentResource] += quantity;
                        }
                    }
                    else // ako ne e bokluk
                    {
                        importantResources[currentResource] += quantity;

                        if (importantResources[currentResource] >= 250)
                        {
                            legendaryItemFarmed = true;
                            gatheredEnoughResourcesOf = currentResource;
                            break;
                        }
                    }
                }
            }

            switch (gatheredEnoughResourcesOf)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    importantResources["shards"] -= 250;
                    break;

                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    importantResources["fragments"] -= 250;
                    break;

                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    importantResources["motes"] -= 250;
                    break;
            }

            foreach (var kvp in importantResources.OrderByDescending(q => q.Value).ThenBy(r => r.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junk.OrderBy(r => r.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            //main ends here
        }
    }
}
