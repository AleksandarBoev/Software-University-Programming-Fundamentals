using System;

namespace P04CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string input1 = input[0];
            string input2 = input[1];

            int result = 0;
            for (int i = 0; i < Math.Min(input1.Length, input2.Length); i++)
            {
                result += input1[i] * input2[i];
            }

            string longerWord;
            if (input1.Length == input2.Length)
            {
                Console.WriteLine(result);
                return;
            }
            else if (input1.Length > input2.Length)
            {
                longerWord = input1;
            }
            else
            {
                longerWord = input2;
            }

            for (int i = Math.Min(input1.Length, input2.Length); i < Math.Max(input1.Length, input2.Length); i++)
            {
                result += longerWord[i];
            }
            Console.WriteLine(result);
            //main ends here
        }
    }
}
