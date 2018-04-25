using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04Weather
{
    class Town
    {
        public string Name { get; set; }
        public double Temperature { get; set; }
        public string Weather { get; set; }

        public Town(string townName, double averageTemperature, string weather)
        {
            Name = townName;
            Temperature = averageTemperature;
            Weather = weather;
        }

        public static bool IsUniqueTown(List<Town> cities, string townName)
        {
            for (int i = 0; i < cities.Count; i++)
            {
                if (townName == cities[i].Name)
                {
                    return false;
                }
            }
            return true;
        }

        public static int GetIndexOfTown(List<Town> cities, string townName)
        {
            for (int index = 0; index < cities.Count; index++)
            {
                if (townName == cities[index].Name)
                {
                    return index;
                }
            }
            return -1;
        }
        //town class ends here
    }

    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<town>[A-Z]{2})(?<temperature>[0-9]{1,}\.[0-9]{1,})(?<weather>[A-Za-z]+)(?=\|)");
            List<Town> cities = new List<Town>();
            
            while (true)
            {
                string currentInput = Console.ReadLine();
                if (currentInput == "end")
                {
                    break;
                }

                if (regex.IsMatch(currentInput))
                {
                    Match match = regex.Match(currentInput);
                    string townName = match.Groups["town"].ToString();
                    double temperature = double.Parse(match.Groups["temperature"].ToString());
                    string weather = match.Groups["weather"].ToString();

                    if (Town.IsUniqueTown(cities, townName))
                    {
                        Town currentTown = new Town(townName, temperature, weather);
                        cities.Add(currentTown);
                    }
                    else
                    {
                        int index = Town.GetIndexOfTown(cities, townName);
                        cities[index].Temperature = temperature;
                        cities[index].Weather = weather;
                    }
                }

            }

            foreach (var city in cities.OrderBy(t => t.Temperature))
            {
                Console.WriteLine($"{city.Name} => {city.Temperature:F2} => {city.Weather}");
            }
            //main ends here
        }
    }
}
