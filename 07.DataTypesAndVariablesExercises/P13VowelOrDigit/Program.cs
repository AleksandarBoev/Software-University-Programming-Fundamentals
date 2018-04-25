using System;

namespace P13VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = Console.ReadLine().ToLower(); //moje sus switch() case, no tova e skuchno..
            
            try
            {
                int digit = Convert.ToInt32(symbol); //ako ne grumne tuk, shte se izpechata sledvashtia red
                Console.WriteLine("digit");
            }
            catch
            {
                char checkCharacter = char.Parse(symbol);
                string vowels = "aeiou";
                foreach (char character in vowels)
                {
                    if (checkCharacter == character)
                    {
                        Console.WriteLine("vowel");
                        return;
                    }
                }
                Console.WriteLine("other");
            }

            //main ends here
        }
    }
}
