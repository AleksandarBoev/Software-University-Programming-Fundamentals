using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P03StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            //ascii code of "@" is 64
            //ascii code of "C" - count of letters 's' 't' 'a' 'r' in message = 'C' - 3 = 67 - 3 = 64 = '@'
            //purvo se chete broikata na bukvite, posle se izvajda ot vsichki char-ove (moje s char masiv)
            //posle se veche moje da zapochna da izvajdam ime na planeta, broika na hora, atack/defence i t.n.

            int numberOfMessages = int.Parse(Console.ReadLine());
            string[] messages = new string[numberOfMessages];
            Regex regexSTAR = new Regex(@"[SsTtAaRr]"); // works
            Regex informationRegex = new Regex
                (@"[^@\-!:>]*@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<population>[0-9]+)[^@\-!:>]*!(?<AD>(A|D))![^@\-!:>]*->(?<soldiers>[0-9]+)");
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < numberOfMessages; i++)
            {
                messages[i] = Console.ReadLine();
                MatchCollection matches = regexSTAR.Matches(messages[i]);
                int decryptionKey = matches.Count;
                StringBuilder buildDectyptedMessage = new StringBuilder();
                for (int j = 0; j < messages[i].Length; j++)
                {
                    buildDectyptedMessage.Append((char)(messages[i][j] - decryptionKey));
                }
                messages[i] = buildDectyptedMessage.ToString();
                if (!informationRegex.IsMatch(messages[i]))
                { // important info is only about name and A/D, other info is just to verify if the message is valid
                    continue;
                }
                Match match = informationRegex.Match(messages[i]);
                char AD = char.Parse(match.Groups["AD"].Value);
                string planetName = match.Groups["name"].Value;
                if (AD == 'A')
                {
                    attackedPlanets.Add(planetName);
                }
                else if (AD == 'D')
                {
                    destroyedPlanets.Add(planetName);
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string planetName in attackedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planetName}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (string planetName in destroyedPlanets.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planetName}");
            }
            //main ends here
        }
    }
}
