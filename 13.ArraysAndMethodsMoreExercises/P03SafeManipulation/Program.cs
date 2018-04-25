using System;
using System.Linq;

namespace P03SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numberWords = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "END")
                {
                    break;
                }

                switch (command[0])
                {
                    case "Distinct":
                        numberWords = numberWords.Distinct().ToArray();
                        break;

                    case "Reverse":
                        Reverse(numberWords);
                        break;

                    case "Replace":
                        if(!Replace(numberWords, int.Parse(command[1]), command[2]))
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;

                }

            }

            Console.WriteLine(string.Join(", ", numberWords));

            //main ends here
        }

        static bool Replace(string[] arrayOfStrings, int index, string newValue) //works
        {
            if (index < 0 || index >= arrayOfStrings.Length)
            {
                return false;
            }
            arrayOfStrings[index] = newValue;
            return true;
        }

        static void Reverse(string[] arrayOfStrings) //works
        {
            int count = 0;
            for (int index = arrayOfStrings.Length - 1; index >= arrayOfStrings.Length / 2; index--)
            {
                string swapValue = arrayOfStrings[count];
                arrayOfStrings[count] = arrayOfStrings[index];
                arrayOfStrings[index] = swapValue;
                count++;
            }
        }

        //class ends here
    }
}
