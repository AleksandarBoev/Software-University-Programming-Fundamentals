using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').ToList();

            for (int index = 0; index < numbers.Count; index++) // mahane na nenujnite space-ove
            {
                numbers[index] = RemoveAdjacentWhiteSpaces(numbers[index]);
            }

            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
            
            //main ends here
        }

        static string RemoveAdjacentWhiteSpaces(string str) // works
        {
            StringBuilder sb = new StringBuilder();

            str = str.Trim();
            bool whiteSpace = false;

            for (int letter = 0; letter < str.Length; letter++)
            {
                if (str[letter] == ' ' && whiteSpace == false) // dobavqne na space
                {
                    sb.Append(str[letter]);
                    whiteSpace = true;
                }
                else if (str[letter] != ' ')
                {
                    sb.Append(str[letter]);
                    whiteSpace = false;
                }
            }

            return sb.ToString().Trim();

        }

        //class ends here
    }
}
