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
            string[] input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string lowerCase = input[i].ToLower();
                if (wordCount.ContainsKey(lowerCase) == false)
                {
                    wordCount.Add(lowerCase, 1);
                }
                else
                {
                    wordCount[lowerCase]++;
                }
            }

            string answer = "";
            foreach (var kvp in wordCount)
            {
                if (kvp.Value % 2 == 1)
                {
                    answer += kvp.Key + ", ";
                }
            }

            answer = answer.Trim(',', ' ');
            Console.WriteLine(answer);

            //main ends here
        }
    }
}
