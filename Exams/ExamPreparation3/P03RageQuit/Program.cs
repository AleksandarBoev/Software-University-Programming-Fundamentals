using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P03RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex lettersRepeat = new Regex(@"(?<letters>[^0-9]+)(?<repeat>[0-9]+)");

            string input = Console.ReadLine();
            MatchCollection matches = lettersRepeat.Matches(input);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                string letters = match.Groups["letters"].Value;
                int count = int.Parse(match.Groups["repeat"].Value);
                result.Append(RepeatString(letters, count));
            }
            string uniqueChars = String.Concat(result.ToString().ToUpper().Distinct());
            Console.WriteLine($"Unique symbols used: {uniqueChars.Length}");

            Console.WriteLine(result.ToString().ToUpper());
            //main ends here
        }

        static string RepeatString(string letters, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(letters);
            }

            return sb.ToString();
        }
    }
}
