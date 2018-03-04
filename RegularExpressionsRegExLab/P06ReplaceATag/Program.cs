using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P06ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"<a(?<thisStays>.+)<\/a>";
            List<string> text = new List<string>();

            while (true)
            {
                string currentInput = Console.ReadLine();
                if (currentInput == "end")
                {
                    break;
                }
                text.Add(currentInput);
            }

            for (int i = 0; i < text.Count; i++)
            {
                if (Regex.IsMatch(text[i], regex))
                {
                    Match match = Regex.Match(text[i], regex);
                    //Console.WriteLine(Regex.Replace(text[i], regex, ma));
                    Console.WriteLine(text[i].Replace($"<a{match.Groups["thisStays"]}</a>", $"[URL {match.Groups["thisStays"]}[/URL]"));
                }
                else
                {
                    Console.WriteLine(text[i]);
                }

            }
            //main ends here
        }
    }
}
