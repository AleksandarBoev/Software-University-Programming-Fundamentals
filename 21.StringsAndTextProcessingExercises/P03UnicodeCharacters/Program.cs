using System;

namespace P03UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(GetEscapeSequence(input[i]));
            }

            //main ends here
        }

        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4").ToLower();
        }
    }
}
