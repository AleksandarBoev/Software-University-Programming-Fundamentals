using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P04WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex winningRegex = new Regex(@"(@{6,10}|#{6,10}|\${6,10}|\^{6,10})");

            string[] inputs = Console.ReadLine()
                .Split(new char[] {',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            for (int i = 0; i < inputs.Length; i++) // za vseki input
            {
                if (inputs[i].Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string firstHalf = String.Concat(inputs[i].Take(10));
                string secondHalf = String.Concat(inputs[i].Skip(10));

                if (winningRegex.IsMatch(firstHalf) && winningRegex.IsMatch(secondHalf)) // ako ima suvpadenie i v dvete polovini
                {
                    Match matchFirstHalf = winningRegex.Match(firstHalf);
                    char winningCharacter1 = matchFirstHalf.Value[0]; // vzemi pechelivshata bukva, koqto se e povtorila 6 do 10 puti
                    int firstHalfMatchCount = matchFirstHalf.Value.Length;

                    Match matchSecondHalf = winningRegex.Match(secondHalf);
                    char winningCharacter2 = matchSecondHalf.Value[0];
                    int secondHalfMatchCount = matchSecondHalf.Value.Length;

                    if (winningCharacter1 == winningCharacter2) // ako znacite sa ednakvi i v dvete polovini
                    {
                        if (firstHalfMatchCount == 10)
                        {
                            Console.WriteLine($"ticket \"{inputs[i]}\" - {10}{winningCharacter1} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{inputs[i]}\" - {Math.Min(firstHalfMatchCount, secondHalfMatchCount)}{winningCharacter1}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{inputs[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{inputs[i]}\" - no match");
                }

            }

            //main ends here
        }
    }
}
