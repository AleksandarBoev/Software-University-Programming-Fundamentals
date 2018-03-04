using System;
using System.Collections.Generic;
using System.Linq;

namespace P02KaminoFactory
{
    class DNA
    {
        public int[] Code { get; set; }
        public int Sum { get; set; }
        public int BestStart { get; set; } // of biggest sequence
        public int BiggestSequence { get; set; }

        public DNA(int[] dnaCode)
        {
            int biggestSequence = 0;
            int currentSequence = 0;
            int bestStart = 0;
            int currentStart = 0;
            int sum = 0;
            bool start = true;
            for (int i = 0; i < dnaCode.Length; i++)
            {
                if (dnaCode[i] == 1)
                {
                    if (start)
                    {
                        currentStart = i;
                        start = false;
                    }
                    sum++;
                    currentSequence++;
                }
                else // if (dna[i] == 0)
                {
                    start = true;
                    if (currentSequence > biggestSequence)
                    {
                        biggestSequence = currentSequence;
                        bestStart = currentStart;
                        currentSequence = 0;
                    }
                }
            }
            Code = dnaCode;
            Sum = sum;
            BestStart = bestStart;
            BiggestSequence = biggestSequence;
            //Constructor ends here   
        }

        //dna class ends here
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<DNA> dnaList = new List<DNA>();
            int dnaLength = int.Parse(Console.ReadLine()); //integer in range[1..100] --> data needs to be evaluated?
            if (dnaLength < 1 || dnaLength > 100) // this is NOT the problem
            {
                return;
            }
            //print the sequence with the most consecutive 1's. If there are sequences with consecutive ones
            //print the one with the leftmost starting index. If they are similar again print the one with
            //the bigger sum of dna info

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] currentDnaCode = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .Where(x => x == 1 || x == 0) // this is NOT the problem
                    .ToArray();

                DNA currentDnaData = new DNA(currentDnaCode);
                dnaList.Add(currentDnaData);
            }

            foreach (var dna in dnaList.OrderByDescending(b => b.BiggestSequence).ThenBy(i => i.BestStart).ThenByDescending(s => s.Sum))
            {
                Console.WriteLine($"Best DNA sample {dnaList.IndexOf(dna) + 1} with sum: {dna.Sum}.");
                Console.WriteLine(string.Join(" ", dna.Code));
                break;
            }

            //main ends here
        }
        //class ends here
    }
}
