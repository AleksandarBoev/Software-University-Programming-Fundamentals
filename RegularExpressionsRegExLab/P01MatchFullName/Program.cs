using System;
using System.Text.RegularExpressions;

namespace P01MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string takeNames = (@"\b([A-Z][a-z]+ [A-Z][a-z]+)");

            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, takeNames);

            foreach (var item in matchedNames)
            {
                Console.Write(item + " ");
            }

            //main ends here
        }
    }
}
