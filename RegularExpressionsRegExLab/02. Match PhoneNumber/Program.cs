using System;
using System.Text.RegularExpressions;

namespace P02MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359( |-)2\1[0-9]{3}\b\1[0-9]{4}\b";

            string phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            for (int i = 0; i < phoneMatches.Count; i++)
            {
                if (i != phoneMatches.Count - 1)
                {
                    Console.Write(phoneMatches[i] + ", ");
                }
                else
                {
                    Console.WriteLine(phoneMatches[i]);
                }
            }

            //main ends here
        }
    }
}
