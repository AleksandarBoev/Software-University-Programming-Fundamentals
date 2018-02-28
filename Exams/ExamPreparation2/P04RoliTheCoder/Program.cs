using System;
using System.Collections.Generic;
using System.Linq;

namespace P04RoliTheCoder
{
    class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
        public Event(string name, List<string> participants)
        {
            Name = name;
            Participants = participants;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Event> IdEvent = new Dictionary<int, Event>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                if (string.Join(" ", input) == "Time for Code")
                {
                    break;
                }

                //zapazvane na dannite
                int id = int.Parse(input[0]);
                string eventName = input[1]; // potencialen problem: eventName-ut moje da bude sustaven ot dve imena, ne samo edno
                List<string> currentParticipants = new List<string>();
                //currentParticipants = input
                //    .Where(x => x.StartsWith("@")) // && IsValidName(x.TrimStart('@')) //dali ne trqbva da se napravi "continue "
                //    .ToList(); // ne zabravqi da napravish Distinct posle

                //validirane na dannite
                bool invalidData = false;
                for (int i = 2;  i< input.Length; i++)
                {
                    if (input[i].StartsWith("@") == false)
                    {
                        invalidData = true; 
                        break;
                    }
                    else
                    {
                        currentParticipants.Add(input[i]);
                    }
                }
                if (invalidData)
                {
                    continue;
                }

                if (eventName.StartsWith("#") == false)
                {
                    continue;
                }

                if (IdEvent.ContainsKey(id) == false)
                {
                    Event currentEvent = new Event(eventName, currentParticipants);
                    IdEvent.Add(id, currentEvent);
                }
                else //ako veche ima takova "id"
                {
                    if (IdEvent[id].Name != eventName) // za edno "id" moje da ima samo edin "eventName". Ako imenata ne suvpadat -> preskochi tazi iteraciq
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < currentParticipants.Count; i++)
                        {
                            IdEvent[id].Participants.Add(currentParticipants[i]);
                        }
                    }

                }
                //while ends here
            }

            foreach (var kvp in IdEvent) // mahane na horata s ednakvi imena
            {
                kvp.Value.Participants = kvp.Value.Participants.Distinct().ToList();
            }

            foreach (var kvp in IdEvent.OrderByDescending(c => c.Value.Participants.Count).ThenBy(n => n.Value.Name))
            {
                Console.WriteLine($"{kvp.Value.Name.TrimStart('#')} - {kvp.Value.Participants.Count}");
                Console.WriteLine(string.Join(Environment.NewLine, kvp.Value.Participants.OrderBy(n => n)));
            }

            //main ends here
        }

        static bool IsValidName(string name)
        {
            string validLetters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890'-";
            for (int i = 0; i < name.Length; i++)
            {
                if (validLetters.Contains("" + name[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //class ends here
    }
}
