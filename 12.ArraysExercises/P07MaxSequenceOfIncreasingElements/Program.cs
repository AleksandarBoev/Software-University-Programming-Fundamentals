using System;
using System.Linq;

namespace P07MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main()
        {
            int[] sequenceOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxSequence = 1;
            int maxSequenceStartIndex = 0;
            //int maxSequenceEndIndex = 1;

            int currentSequence = 1;
            int currentSequenceStartIndex = 0;
            //int currentSequenceEndIndex = 1;

            bool isNewIndex = true;

            for (int index = 0; index < sequenceOfIntegers.Length - 1; index++)
            {
                if (sequenceOfIntegers[index] < sequenceOfIntegers[index + 1])
                {
                    currentSequence++;

                    if (isNewIndex)
                    {
                        currentSequenceStartIndex = index;
                        isNewIndex = false;
                    }

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        maxSequenceStartIndex = currentSequenceStartIndex;
                    }
                }
                else
                {
                    currentSequence = 1;
                    isNewIndex = true;
                }
            }

            for (int index = maxSequenceStartIndex; index < maxSequenceStartIndex + maxSequence; index++)
            {
                Console.Write(sequenceOfIntegers[index] + " ");
            }

            //main ends here
        }
    }
}
