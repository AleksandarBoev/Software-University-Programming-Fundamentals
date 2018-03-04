using System;
using System.Text.RegularExpressions;

namespace P03Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex surfaceRegex = new Regex(@"^[^A-Za-z0-9]+$");
            Regex mantleRegex = new Regex(@"^[0-9_]+$");
            Regex coreRegex = new Regex(@"^[A-Za-z]+$");
            Regex middleRegex = new Regex(@"^[^A-Za-z0-9]+[0-9_]+(?<core>[A-Za-z]+)[0-9_]+[^A-Za-z0-9]+$");

            int coreRedexLength = 0;
            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();
                if (i == 0 || i == 4)
                {
                    if (!surfaceRegex.IsMatch(input))
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                }
                else if (i == 1 || i == 3)
                {
                    if (!mantleRegex.IsMatch(input))
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                }
                else
                {
                    if (!middleRegex.IsMatch(input))
                    {
                        Console.WriteLine("Invalid");
                        return;
                    }
                    else
                    {
                        coreRedexLength = middleRegex.Match(input).Groups["core"].Length;
                    }
                }
                   
            }

            Console.WriteLine("Valid" + Environment.NewLine + coreRedexLength);

            //main ends here
        }
    }
}
