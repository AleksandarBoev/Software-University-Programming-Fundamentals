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
            Dictionary<string, Dictionary<string, ulong>> placeSinger = new Dictionary<string, Dictionary<string, ulong>>();


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

                if (index > 3 || index == 0) // pevecut ne moje da ima poveche ot 3 imena ili nito edno
                {
                    continue;
                }



                int ticketsSold = 0;
                int ticketPrice = 0;
                try
                { 
                ticketsSold = int.Parse(input[input.Length - 1]); // cena na bilet i prodadeni sa vinagi na posledno i predposledno mqsto
                ticketPrice = int.Parse(input[input.Length - 2]);
                }
                catch
                {
                    continue; // incorrect input => next iteration
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
                    Dictionary<string, ulong> singerMoneyMade = new Dictionary<string, ulong>();
                    singerMoneyMade.Add(singer, (ulong)ticketPrice * (ulong)ticketsSold);
                    placeSinger.Add(place, singerMoneyMade);
                }
                else // ako mqstoto veche e bilo dobaveno
                {
                    if (placeSinger[place].ContainsKey(singer) == false) // ako pevecut e nov
                    {
                        placeSinger[place].Add(singer, (ulong)ticketPrice * (ulong)ticketsSold);
                    }
                    else // ako pevecut ne e nov za mqstoto
                    {
                        placeSinger[place][singer] += (ulong)ticketPrice * (ulong)ticketsSold;
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
