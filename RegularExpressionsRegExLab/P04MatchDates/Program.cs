using System;
using System.Text.RegularExpressions;

namespace P04MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<theDay>\d{2})(.|\/|-)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b";
            string text = Console.ReadLine();

            MatchCollection dates = Regex.Matches(text, regex);

            foreach (Match date in dates)
            {
                string day = date.Groups["theDay"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
            //main ends here
        }
    }
}
