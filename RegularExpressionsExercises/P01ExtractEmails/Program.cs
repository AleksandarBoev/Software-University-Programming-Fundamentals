using System;
using System.Text.RegularExpressions;

namespace P01ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^| )[A-Za-z0-9][A-Za-z0-9.\-_]*@[A-Za-z\-]+(\.[a-z]+)+";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, regex);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.ToString().Trim());
            }
            //main ends here
        }
    }
}
