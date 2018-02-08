using System;
using System.Collections.Generic;
using System.Linq;

namespace P01MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>();
            listOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bestStart = 0;
            int currentStart = 0;
            int currentLength = 1;
            int bestLength = 1;

            for (int index = 0; index < listOfNumbers.Count - 1; index++)
            {
                if (listOfNumbers[index] == listOfNumbers[index + 1])
                {
                    currentLength++;

                    if (currentLength > bestLength)
                    {
                        bestStart = currentStart; // currentStart ne se promenq, tui che bestStart se prisvoqva nqkolko puti
                        bestLength = currentLength; 
                    }
                }
                else
                {
                    currentLength = 1; // vinagi shte e 1. Nqma kak edin elemnt da se povtarq 0 puti sthom go ima
                    currentStart = index + 1; //shtom segashniq indeks ne stava, zapomnq se sledvashtiq
                }

            }

            for (int index = bestStart; index < bestStart + bestLength; index++)
            {
                Console.Write(listOfNumbers[index] + " ");
            }

            //main ends here
        }
    }
}
