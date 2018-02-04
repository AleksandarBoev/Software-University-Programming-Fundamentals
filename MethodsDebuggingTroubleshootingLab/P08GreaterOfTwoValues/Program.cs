using System;

namespace P08GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(num1, num2));
                    break;

                case "char":
                    char character1 = char.Parse(Console.ReadLine());
                    char character2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(character1, character2));
                    break;

                case "string":
                    string word1 = Console.ReadLine();
                    string word2 = Console.ReadLine();
                    Console.WriteLine(GetMax(word1, word2));
                    break;
            }

            //main ends here
        }

        static int GetMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            } else
            {
                return number2;
            }
        }

        static char GetMax(char character1, char character2)
        {
            if (character1 > character2)
            {
                return character1;
            } else
            {
                return character2;
            }
        }

        static string GetMax(string word1, string word2)
        {
            byte answer = (byte)word1.CompareTo(word2);  

            if (answer == 1)
            {
                return word1;
            } else 
            {
                return word2;
            } 

        }

        //class ends here
    }
}
