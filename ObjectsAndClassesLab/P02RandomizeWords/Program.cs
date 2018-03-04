using System;

namespace P02RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                int randomNumber = random.Next(0, input.Length);
                string temporaryString = input[i];
                input[i] = input[randomNumber];
                input[randomNumber] = temporaryString;
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }

            //main ends here
        }
    }
}
