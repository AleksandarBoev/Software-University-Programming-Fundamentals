using System;
using System.Text.RegularExpressions;

namespace P05KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex keyRegex = new Regex(@"(?<start>\w+(?=<|\||\\))(<|\||\\)(\w+(<|\||\\))+(?<end>\w+)");
            string keyInput = Console.ReadLine();
            MatchCollection keyMatches = keyRegex.Matches(keyInput);
            string start = keyMatches[0].Groups["start"].ToString();
            string end = keyMatches[0].Groups["end"].ToString();

            string textInput = Console.ReadLine();
            Regex wordRegex = new Regex(start + @"(?<word>.*?)" + end);
            MatchCollection wordMatches = wordRegex.Matches(textInput);

            string result = "";
            foreach (Match wordMatch in wordMatches)
            {
                result += wordMatch.Groups["word"].Value;
            }
            if (result == "")
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }

            //main ends here
        }
    }
}
