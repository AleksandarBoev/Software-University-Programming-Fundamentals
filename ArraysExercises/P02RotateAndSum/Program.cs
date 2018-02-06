using System;
using System.Linq;

namespace P02RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOfNumbers = Console.ReadLine();
            int rotate = int.Parse(Console.ReadLine());

            int[] numbersArr = stringOfNumbers.Split(' ').Select(int.Parse).ToArray();
            int[] sumArr = new int[numbersArr.Length];

            //for (int i = 0; i < numbersArr.Length; i++) //ne znam kak se klonira
            //{
            //    sumArr[i] = numbersArr[i];
            //}

            for (int rotations = 0; rotations < rotate; rotations++)
            {
                RotateElements(numbersArr);
                SumArrays(numbersArr, sumArr);
            }

            Console.WriteLine(string.Join(" ", sumArr));

            //main ends here
        }

        static void RotateElements(int[] arrayOfNumbers)
        {
            int lastElement = arrayOfNumbers[arrayOfNumbers.Length - 1];

            for (int index = arrayOfNumbers.Length - 1; index >= 1; index--)
            {
                arrayOfNumbers[index] = arrayOfNumbers[index - 1];
            }

            arrayOfNumbers[0] = lastElement;
        }

        static void SumArrays(int[] arrayOfNumbers, int[] sumArray)
        {
            for (int index = 0; index < arrayOfNumbers.Length; index++)
            {
                sumArray[index] += arrayOfNumbers[index];
            }
        }

        //class ends here
    }
}
