using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P10SrubskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> placeSinger = new Dictionary<string, Dictionary<string, decimal>>();


            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                int index = 0;
                string singer = "";
                while (input[index].Contains("@") == false) // dokato ne se stigne do "@", produljavai da chetesh imeto na pevecut
                {
                    singer += input[index] + ' ';
                    index++;
                }
                singer = singer.Trim();

                int ticketsSold = 0;
                decimal ticketPrice = 0m;
                try
                { 
                ticketsSold = int.Parse(input[input.Length - 1]); // cena na bilet i prodadeni sa vinagi na posledno i predposledno mqsto
                ticketPrice = decimal.Parse(input[input.Length - 2]); // parite se smqtat v decimal
                }
                catch
                {
                    continue;
                }

                string place = "";
                for (int i = index; i <= input.Length - 3; i++) // vsichko mejdu imeto na pevecut i infoto za biletite e mqstoto
                {
                    place += input[i] + ' ';
                }
                place = place.Replace('@', ' '); // zamesti go i posle Trim, sigurno ima i po-dobur nachin
                place = place.Trim();

                if (placeSinger.ContainsKey(place) == false)
                {
                    Dictionary<string, decimal> singerMoneyMade = new Dictionary<string, decimal>();
                    singerMoneyMade.Add(singer, ticketPrice * ticketsSold);
                    placeSinger.Add(place, singerMoneyMade);
                }
                else // ako mqstoto veche e bilo dobaveno
                {
                    if (placeSinger[place].ContainsKey(singer) == false) // ako pevecut e nov
                    {
                        placeSinger[place].Add(singer, ticketPrice * ticketsSold);
                    }
                    else // ako pevecut ne e nov za mqstoto
                    {
                        placeSinger[place][singer] += ticketPrice * ticketsSold;
                    }
                }

            }

            foreach (var kvp in placeSinger)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var kvp2 in kvp.Value.OrderByDescending(m => m.Value)) // kvp.Value mnojestvoto e vutreshniqt rechnik => kvp2 e vsqka kletka na tozi rechnik
                {
                    Console.WriteLine($"#  {kvp2.Key} -> {kvp2.Value}");
                }
            }

            //main ends here
        }
    }
}
