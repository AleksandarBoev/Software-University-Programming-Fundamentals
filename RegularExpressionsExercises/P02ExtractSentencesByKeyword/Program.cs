using System;
using System.Text.RegularExpressions;

namespace P02ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            Regex regex = new Regex(@"(\w*[ \,/-]*)*" + keyWord + @"([ \,/-]*\w*)*(?=(\.|!|\?))");
            string text = Console.ReadLine();
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }

            //main ends here
        }
    }
}
