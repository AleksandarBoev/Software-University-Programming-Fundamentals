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
                        //Distinct(numberWords); //doesn't work
                        numberWords = numberWords.Distinct().ToArray();
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

        static void Distinct(string[] arrayOfStrings)
        {
            int numberOfUniqueElements = 1;
            bool[] isUnique = new bool[arrayOfStrings.Length]; // dulgo kolkoto string[]. vseki true indeks na bool[] se otnasq za unikalnite elementi na string[]

            for (int index = 0; index < isUnique.Length; index++) // vsichki v nachaloto sa unikalni
            {
                isUnique[index] = true;
            }

            for (int index = 0; index < arrayOfStrings.Length - 1; index++)
            {
                if (isUnique[index] == false)
                {
                    continue;
                }
                else
                {
                    numberOfUniqueElements++;
                }

                for (int index2 = index + 1; index2 < arrayOfStrings.Length; index2++) // ako se povtarq stava false
                {
                    if (arrayOfStrings[index] == arrayOfStrings[index2])
                    {
                        isUnique[index2] = false;
                    }
                }
            }

            string[] newArray = new string[numberOfUniqueElements];
            int iterator = 0;

            for (int index = 0; index < arrayOfStrings.Length; index++)
            {
                if (isUnique[index])
                {
                    newArray[iterator] = arrayOfStrings[index];
                    iterator++;
                }
            }

            arrayOfStrings = newArray;

            Console.ReadLine();

        }

            //class ends here
    }
}
