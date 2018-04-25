using System;
using System.Collections.Generic;
using System.Linq;

namespace P04Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ,.!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == String.Concat(words[i].Reverse()))
                {
                    palindromes.Add(words[i]);
                }
            }

            palindromes = palindromes.Distinct().ToList();
            Console.WriteLine(string.Join(", ", palindromes.OrderBy(w => w)));

            //main ends here
        }
    }
}
