using System;

namespace P06ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ');

            int startIndex = 0;
            for (int i = arrayOfStrings.Length - 1; i >= arrayOfStrings.Length / 2; i--)
            {
                string temporaryString = arrayOfStrings[startIndex];
                arrayOfStrings[startIndex] = arrayOfStrings[i];
                arrayOfStrings[i] = temporaryString;
                startIndex++;
            }

            Console.WriteLine(string.Join(" ", arrayOfStrings));

            //main ends here
        }
    }
}
