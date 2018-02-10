using System;
using System.Linq;

namespace P09JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jumpLengths = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int totalSum = jumpLengths[0];
            int currentIndex = 0;

            while (true)
            {
                if (currentIndex + jumpLengths[currentIndex] < jumpLengths.Length)
                {
                    currentIndex += jumpLengths[currentIndex]; // jump right
                    totalSum += jumpLengths[currentIndex];
                }
                else if (currentIndex - jumpLengths[currentIndex] >= 0)
                {
                    currentIndex -= jumpLengths[currentIndex]; // jump left
                    totalSum += jumpLengths[currentIndex];
                }
                else // if a jump to the left or right is impossible stop
                {
                    break;
                }
            }

            Console.WriteLine(totalSum);

            //main ends here
        }

        //class ends here
    }
}
