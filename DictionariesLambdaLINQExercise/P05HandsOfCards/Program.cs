using System;
using System.Collections.Generic;
using System.Linq;

namespace P05HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> nameCards = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(':').ToArray();
                string name = input[0];
                if (name == "JOKER")
                {
                    break;
                }
                string cards = input[1];

                cards = cards.Trim();
                List<string> cardsList = new List<string>();
                cardsList = cards.Split(",".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Distinct().ToList(); // sigurno moje i po po-dobur nachin

                if (nameCards.ContainsKey(name) == false)
                {
                    nameCards.Add(name, cardsList);
                }
                else
                {
                    nameCards[name] = ConcatenateLists(nameCards[name], cardsList).Distinct().ToList(); // subira gi i posle premahva duplikatite
                }

            }

            foreach (var kvp in nameCards)
            {
                Console.WriteLine($"{kvp.Key}: {GetMaxScore(kvp.Value)}");
            }

            //main ends here
        }

        static List<string> ConcatenateLists(List<string> list1, List<string> list2) // works
        {
            List<string> result = new List<string>();
            result = list1;
            for (int i = 0; i < list2.Count; i++)
            {
                result.Add(list2[i]);
            }
            return result;
        }

        static int GetCardPoints(string card) //works
        {
            int multiplier = 0;
            if (card.EndsWith("C")) // greshka pri kompilaciq, dori ako e daden string kato parametur
            {
                multiplier = 1;
            }
            else if (card.EndsWith("D"))
            {
                multiplier = 2;
            }
            else if (card.EndsWith("H"))
            {
                multiplier = 3;
            }
            else if (card.EndsWith("S"))
            {
                multiplier = 4;
            }

            card = card.Remove(card.Length - 1);
            int power = 0;

            try
            {
                power = int.Parse(card);
            }
            catch
            {
                switch (card)
                {
                    case "J":
                        power = 11;
                        break;
                    case "Q":
                        power = 12;
                        break;
                    case "K":
                        power = 13;
                        break;
                    case "A":
                        power = 14;
                        break;
                }
            }

            return power * multiplier;
        }

        static int GetMaxScore(List<string> cardsList)
        {
            int totalScore = 0;
            foreach (var card in cardsList)
            {
                totalScore += GetCardPoints(card);
            }

            return totalScore;
        }

        //class ends here
    }
}
