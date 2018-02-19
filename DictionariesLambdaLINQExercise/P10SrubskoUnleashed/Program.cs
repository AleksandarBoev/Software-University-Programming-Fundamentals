using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P10SrubskoUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, ulong>> placeSinger = new Dictionary<string, Dictionary<string, ulong>>(); // i s decimal dava 70/100


            while (true)
            {
                int ticketPrice = 0;
                int ticketsSold = 0;
                string singer = "";
                string place = "";
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                //validate data start_________________________________

                int index = 0;
                while (input[index].Contains('@') == false) // kato svurshi '@' shte go ima na poziciq "index"
                {
                    singer += input[index] + ' ';
                    index++;
                }
                if (singer == "" || IsWord(singer) == false)
                {
                    continue;
                }

                if (input[index][0] != '@')
                {
                    continue;
                }
                else
                {
                    input[index] = string.Join("", input[index].Skip(1)); // preskochi purviq znak i zapishi vsichko ostanalo
                }
                singer = singer.Trim();

                while (IsWord(input[index]))
                {
                    place += input[index] + ' ';
                    index++;
                }
                place = place.Trim();
                if (place == "")
                {
                    continue;
                }

                try
                {
                    ticketPrice = int.Parse(input[index]);
                    ticketsSold = int.Parse(input[index + 1]);
                }
                catch
                {
                    continue;
                }
                // validate data end_______________________________________________

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

        // TODO make a method, which validates that there are ONLY letters in the names of singers and place

        static bool IsWord(string word)
        {
            char[] alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz ".ToArray();
            for (int i = 0; i < word.Length; i++)
            {
                if (alphabet.Contains(word[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
