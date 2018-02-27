using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] notDemonHealthCharacters = @"0123456789+-/*.".ToCharArray();
            //sum ascii codes for letters [^\.+\-*\\0-9]
            // real numbers: -?\d+\.\d+
            // all numbers: -?\d+\.?\d* copy-pasted ot lektora, no pri 123. i .23 gi namira za vqrni...?
            // multiplying and division \/|\*
            List<string> demonNames = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .OrderBy(x => x)
                .ToList();

            for (int i = 0; i < demonNames.Count; i++)
            {
                Console.WriteLine($"{demonNames[i]} - {GetDemonHealth(demonNames[i])} health, {GetDemonDamage(demonNames[i]):F2} damage");
            }

            //main ends here
        }

        static int GetDemonHealth(string demonName)
        {
            Regex hpRegex = new Regex(@"[^\.+\-*\/0-9]");
            MatchCollection matches = hpRegex.Matches(demonName);

            int totalSum = 0;
            foreach (Match match in matches)
            {
                char currentChar = char.Parse(match.Value);
                totalSum += currentChar;
            }
            return totalSum;
        }

        static double GetDemonDamage(string demonName)
        {
            Regex numbersRegex = new Regex(@"-?\d+\.?\d*");
            MatchCollection numberMatches = numbersRegex.Matches(demonName);
            double damage = 0.0;
            foreach (Match number in numberMatches)
            {
                damage += double.Parse(number.Value);
            }

            Regex operationsRegex = new Regex(@"\/|\*");
            MatchCollection operationsMatches = operationsRegex.Matches(demonName);
            foreach (Match match in operationsMatches)
            {
                switch (match.Value)
                {
                    case "/":
                        damage /= 2;
                        break;
                    case "*":
                        damage *= 2;
                        break;
                }
            }

            return damage;
        }

        //class ends here
    }
}
