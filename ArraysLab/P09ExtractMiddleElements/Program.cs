using System;
using System.Linq;

namespace P09ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrayOfNumbersString = Console.ReadLine();
            int[] numbersArray = arrayOfNumbersString.Split(' ').Select(int.Parse).ToArray();

            int[] newArray;

            if (numbersArray.Length == 1)
            {
                newArray = numbersArray;
            }
            else if (numbersArray.Length % 2 == 0)
            {
                newArray = new int[2];
                newArray[0] = numbersArray[numbersArray.Length / 2 - 1];
                newArray[1] = numbersArray[numbersArray.Length / 2];
            }
            else
            {
                newArray = new int[3];
                newArray[0] = numbersArray[numbersArray.Length / 2 - 1];
                newArray[1] = numbersArray[numbersArray.Length / 2];
                newArray[2] = numbersArray[numbersArray.Length / 2 + 1];
            }

            string answer = string.Join(", ", newArray);
            Console.WriteLine($"{{ {answer} }}");

            //main ends here
        }
    }
}
