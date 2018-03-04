using System;
using System.Collections.Generic;
using System.Linq;

namespace P02SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> participantAwards = new Dictionary<string, List<string>>(); // neshto ne mi dava da napisha SortedList<string>

            string[] participants = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] songs = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x = x.Trim())
                .ToArray();

            bool atLeastOneAward = false;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "dawn")
                {
                    break;
                }

                string[] information = input.Split(',')
                .Select(x => x = x.Trim())
                .ToArray();

                string participantName = information[0];
                string song = information[1];
                string award = information[2];

                if (!participants.Contains(participantName) || !songs.Contains(song)) // samo zapisalite se hora i zapisanite pesni sa validni danni
                {
                    continue;
                }

                atLeastOneAward = true;

                if (!participantAwards.ContainsKey(participantName)) // zapisaliqt se kachva na scenata za purvi put
                {
                    List<string> firstAward = new List<string>();
                    firstAward.Add(award);
                    participantAwards.Add(participantName, firstAward);
                }
                else // za n-ti put se kachva na scenata
                {
                    participantAwards[participantName].Add(award);
                    participantAwards[participantName] = participantAwards[participantName].Distinct().ToList();
                }
            }

            if (!atLeastOneAward)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var participant in participantAwards.OrderByDescending(c => c.Value.Count).ThenBy(n => n.Key)) // podredi gi po broi nagradi i po ime sled tova
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                foreach (var song in participant.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"--{song}");
                }
            }
            //main ends here
        }
    }
}
