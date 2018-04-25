using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(",;:.!()\"'\\/[] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> lowerCaseStrings = new List<string>();
            List<string> upperCaseStrings = new List<string>();
            List<string> mixedCaseStrings = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                int caseWord = DetermineCaseLetters(input[i]);

                if (caseWord == 1)
                {
                    lowerCaseStrings.Add(input[i]);
                } 
                else if (caseWord == 2)
                {
                    upperCaseStrings.Add(input[i]);
                }
                else if (caseWord == 3)
                {
                    mixedCaseStrings.Add(input[i]);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseStrings));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseStrings));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCaseStrings));
            

            //main ends here
        }

        static int DetermineCaseLetters(string word) // 1 == lowercase, 2 == uppercase, 3 == mixedCase
        {
            int lowerCaseLettersCount = 0;
            int upperCaseLettersCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                bool isLowerCase = 97 <= (int)word[i] && (int)word[i] <= 122;
                bool isUpperCase = 65 <= (int)word[i] && (int)word[i] <= 90;
                if (isLowerCase)
                {
                    lowerCaseLettersCount++;
                }
                else if (isUpperCase)
                {
                    upperCaseLettersCount++;
                }
            }

            if (lowerCaseLettersCount == word.Length)
            {
                return 1;
            }
            else if (upperCaseLettersCount == word.Length)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        //static string ReturnOnlyLettersAndSpaces(string input) //shte raboti ako se napravi string[] array = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int letter = 0; letter < input.Length; letter++)
        //    {
        //        int currentAsciicode = (int)input[letter];
        //        bool isAcceptable = currentAsciicode == 32 || (65 <= currentAsciicode && currentAsciicode <= 90) ||
        //            (97 <= currentAsciicode && currentAsciicode <= 122);
        //        if (isAcceptable)
        //        {
        //            sb.Append(input[letter]);
        //        }

        //    }

        //    return sb.ToString();

        //}

        //class ends here
    }
}
