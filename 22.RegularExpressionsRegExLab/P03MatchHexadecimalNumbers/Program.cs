using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?:0x)?[A-F0-9]+\b";

            string input = Console.ReadLine();

            string[] hexNumbers = Regex.Matches(input, regex).Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", hexNumbers));

            //main ends here
        }
    }
}
