using System;
using System.Linq;

namespace P03FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbersString = Console.ReadLine();
            int[] numbersArr = numbersString.Split(' ').Select(int.Parse).ToArray();

            int k = numbersArr.Length / 4; //vinagi shte e kratno na 4

            int[] leftArr = new int[k];
            int[] rightArr = new int[k];
            int[] middleArr = new int[2 * k];

            leftArr = numbersArr.Take(k).ToArray();
            middleArr = numbersArr.Skip(k).Take(2 * k).ToArray();
            rightArr = numbersArr.Skip(3 * k).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr); // do tuk vqrno

            for (int i = 0; i < k; i++)
            {
                middleArr[i] += leftArr[i];
                middleArr[i + k] += rightArr[i]; // tuk dava error ako go pravq [2 * k]
            }

            Console.WriteLine(string.Join(" ", middleArr));

            //main ends here
        }

        //class ends here
    }
}
