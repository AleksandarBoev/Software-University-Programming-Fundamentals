using System;
using System.Linq;

namespace P09IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lowerCaseAlphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z".Split(' ').Select(char.Parse).ToArray();
            string word = Console.ReadLine();

            for (int index = 0; index < word.Length; index++)
            {
                int letterIndex = GetIndex(word[index], lowerCaseAlphabet);
                Console.WriteLine($"{word[index]} -> {letterIndex}");
            }

            //main ends here
        }

        static int GetIndex(char character, char[] alphabet)
        {
            for (int index = 0; index < alphabet.Length; index++)
            {
                if (character == alphabet[index])
                {
                    return index;
                }
            }

            return -1; // bukvata ne e razpoznata i se vrushta index, koito nqma kak da sushtesvuva

        }

        //class ends here
    }
}
