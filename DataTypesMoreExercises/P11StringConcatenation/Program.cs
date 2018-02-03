using System;

namespace P11StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string oddEven = Console.ReadLine();
            int numberOfWords = int.Parse(Console.ReadLine());

            string concatenatedString = "";

            for (int word = 1; word <= numberOfWords; word++)
            {
                string currentWord = Console.ReadLine();
                if (oddEven == "even")
                {
                    if (word % 2 == 0)
                    {
                        concatenatedString += currentWord + delimeter;
                    }
                } else if (oddEven == "odd")
                {
                    if (word % 2 == 1)
                    {
                        concatenatedString += currentWord + delimeter;
                    }
                }
            }

            concatenatedString = concatenatedString.Remove(concatenatedString.Length - 1);
            Console.WriteLine(concatenatedString);

            //main ends here
        }
    }
}
