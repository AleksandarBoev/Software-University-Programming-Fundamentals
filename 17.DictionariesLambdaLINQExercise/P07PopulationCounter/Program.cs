using System;
using System.Collections.Generic;
using System.Linq;

namespace P07PopulationCounter
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countryCity = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('|');

                if (input[0] == "report")
                {
                    break;
                }

                string country = input[1];
                string city = input[0];
                long population = long.Parse(input[2]);

                if (countryCity.ContainsKey(country) == false)
                {
                    Dictionary<string, long> cityPopulation = new Dictionary<string, long>();
                    cityPopulation.Add(city, population);
                    countryCity.Add(country, cityPopulation);
                }
                else
                {
                    if (countryCity[country].ContainsKey(city) == false)
                    {
                        countryCity[country].Add(city, population);
                    }
                    else
                    {
                        countryCity[country][city] += population;
                    }
                }
            }

            Dictionary<string, long> countryTotalPopulation = new Dictionary<string, long>(); 

            foreach (var kvp in countryCity)
            {
                long temporaryTotalPopulation = GetTotalPopulationForCountry(kvp.Value);
                countryTotalPopulation.Add(kvp.Key, temporaryTotalPopulation);
            }

            foreach (var kvp in countryTotalPopulation.OrderByDescending(p => p.Value)) // drugoto dictionary e podredeno
            {
                string countryName = kvp.Key;
                Console.WriteLine($"{countryName} (total population: {kvp.Value})");

                foreach (var city in countryCity[countryName].OrderByDescending(p => p.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

            //main ends here
        }

        static long GetTotalPopulationForCountry(Dictionary<string, long> cityPopulation)
        {
            long totalPopulation = 0;

            foreach (var kvp in cityPopulation)
            {
                totalPopulation += kvp.Value;
            }

            return totalPopulation;
        }

        //class ends here
    }
}
