using System;
using System.Linq;

namespace P08MostFrequentNumber
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // davat se stoinosti ot [0..65535]

            int mostFrequentValue = numbers[0];
            int currentValue = 0;
            int currentTimesOccured = 0;
            int maxTimesOccured = 1;

            for (int uniqueNumber = 0; uniqueNumber < numbers.Length - 1; uniqueNumber++)
            {
                if (numbers[uniqueNumber] == -1) // proverenite chisla bivat markirani kato "-1" i nqma nujda da budat provereni otnovo
                {
                    continue;
                }

                currentValue = numbers[uniqueNumber];
                numbers[uniqueNumber] = -1; //shte bude provereno
                currentTimesOccured = 1;

                for (int index = uniqueNumber + 1; index < numbers.Length; index++)
                {
                    if (numbers[index] == -1)
                    {
                        continue;
                    }

                    if (currentValue == numbers[index])
                    {
                        currentTimesOccured++;
                        numbers[index] = -1; // markira se kato otcheteno
                    }

                }

                if (currentTimesOccured > maxTimesOccured)
                {
                    maxTimesOccured = currentTimesOccured;
                    mostFrequentValue = currentValue;
                }

            }

            Console.WriteLine(mostFrequentValue);

            //main ends here
        }
    }
}
