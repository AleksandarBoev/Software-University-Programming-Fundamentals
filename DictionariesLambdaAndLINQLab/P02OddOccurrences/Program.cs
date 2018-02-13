using System;
using System.Collections.Generic;
using System.Linq;

namespace P02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string[] words = Console.ReadLine().Split(' ').ToArray();

            foreach (string word in words)
            {
                string lowerCaseWord = word.ToLower();
                if (wordCount.ContainsKey(lowerCaseWord) == false)
                {
                    wordCount.Add(lowerCaseWord, 1);
                }
                else
                {
                    wordCount[lowerCaseWord]++;
                }
            }

            List<string> oddOccurenceWords = new List<string>();

            foreach (string word in wordCount.Keys)
            {
                if (wordCount[word] % 2 == 1)
                {
                    oddOccurenceWords.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", oddOccurenceWords));

            //main ends here
        }
    }
}
