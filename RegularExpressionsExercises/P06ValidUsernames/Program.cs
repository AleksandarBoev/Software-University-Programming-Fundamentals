using System;
using System.Text.RegularExpressions;

namespace P06ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex userNameRegex = new Regex(@"\b[A-Za-z][A-Za-z0-9_]{2,24}\b"); // vmesto \b -> (^| |\/|\\|\(|\))
            string input = Console.ReadLine();

            MatchCollection matches = userNameRegex.Matches(input);

            int maxSumLengths = -1;
            int word1Index = -1;
            int word2Index = -1;
            for (int i = 0; i < matches.Count - 1; i++)
            {
                if (matches[i].Value.Length + matches[i + 1].Value.Length > maxSumLengths)
                {
                    word1Index = i;
                    word2Index = i + 1;
                    maxSumLengths = matches[i].Value.Length + matches[i + 1].Value.Length;
                }
            }

            Console.WriteLine(matches[word1Index].Value + Environment.NewLine + matches[word2Index].Value);

            //main ends here
        }
    }
}
