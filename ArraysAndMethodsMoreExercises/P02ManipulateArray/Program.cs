using System;
using System.Linq;

namespace P02ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberWords = Console.ReadLine().Split(' ').ToArray();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                switch (command[0])
                {
                    case "Distinct":
                        numberWords = Distinct(numberWords); // ne znam zashto ne iska da se promeni, kato e podadeno kato vhoden parametur
                        //numberWords = numberWords.Distinct().ToArray();
                        break;

                    case "Reverse":
                        Reverse(numberWords);
                        break;

                    case "Replace":
                        Replace(numberWords, int.Parse(command[1]), command[2]);
                        break;
                }

            }

            Console.WriteLine(string.Join(", ", numberWords));

            //main ends here
        }

        static void Replace(string[] arrayOfStrings, int index, string newValue) //works
        {
            arrayOfStrings[index] = newValue;
        }

        static void Reverse(string[] arrayOfStrings) //works
        {
            int count = 0;
            for (int index = arrayOfStrings.Length - 1; index >= arrayOfStrings.Length / 2; index--)
            {
                string swapValue = arrayOfStrings[count];
                arrayOfStrings[count] = arrayOfStrings[index];
                arrayOfStrings[index] = swapValue;
                count++;
            }
        }

        static string[] Distinct(string[] arrayOfStrings) // works
        {
            string[] newArray = new string[arrayOfStrings.Length];
            int newArrayIndex = 0;

            for (int index = 0; index < arrayOfStrings.Length; index++)
            {
                if (CheckForOccurence(newArray, arrayOfStrings[index]) == false)
                {
                    newArray[newArrayIndex] = arrayOfStrings[index];
                    newArrayIndex++;
                }
            }

            string[] answerArray = new string[newArrayIndex];

            for (int index = 0; index < answerArray.Length; index++)
            {
                answerArray[index] = newArray[index];
            }

            return answerArray;
        }

        static bool CheckForOccurence(string[] arrayOfStrings, string value)
        {
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                if (arrayOfStrings[i] == value)
                {
                    return true;
                }
            }

            return false;
        }

        //class ends here
    }
}
