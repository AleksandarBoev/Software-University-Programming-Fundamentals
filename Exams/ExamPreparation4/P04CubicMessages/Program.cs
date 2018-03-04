using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace P04CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string potencialMessage = Console.ReadLine();
                if (potencialMessage == "Over!")
                {
                    break;
                }
                int validMessageLength = int.Parse(Console.ReadLine()); // the "m" characters

                Regex messageEncription = new Regex(@"^(?<code>[0-9])+(?<message>[A-Za-z]{" + validMessageLength + @"})(?<potentialCode>[^A-Za-z]*)\b");
                Match match = messageEncription.Match(potencialMessage);

                if (!messageEncription.IsMatch(potencialMessage))
                {
                    continue;
                }

                //string integerParts = match.Groups["code"].Value + match.Groups["potencialCode"].Value;
                List<int> indexes = ExtractIndexes(potencialMessage, validMessageLength);

                string message = match.Groups["message"].Value;

                StringBuilder decryptedMessage = new StringBuilder();
                for (int i = 0; i < indexes.Count; i++)
                {
                    if (indexes[i] == -1)
                    {
                        decryptedMessage.Append(' ');
                    }
                    else
                    {
                        decryptedMessage.Append(message[indexes[i]]);
                    }
                }

                Console.WriteLine($"{message} == {decryptedMessage.ToString()}");
            }

            //main ends here chrez masiv ot char-ove da si napravq dekriptiranoto suobshtenie
        }

        static List<int> ExtractIndexes(string code, int validMessageLength)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < code.Length; i++)
            {
                try
                {
                    int currentIndex = int.Parse("" + code[i]);
                    if (currentIndex < 0 || currentIndex >= validMessageLength)
                    {
                        currentIndex = -1; // v takuv sluchai trqbva da se printira whitespace
                    }
                    result.Add(currentIndex);
                }
                catch
                {
                    continue;
                }
            }
            return result;
        }

        //class ends here
    }
}
