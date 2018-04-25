using System;
using System.Linq;

namespace P01LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray1 = Console.ReadLine().Split(' ').ToArray();
            string[] stringArray2 = Console.ReadLine().Split(' ').ToArray();

            int smallerLength = Math.Min(stringArray1.Length, stringArray2.Length);

            int count = 0;
            for (int i = 0; i < smallerLength; i++)
            {
                if (stringArray1[i] == stringArray2[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            //sega otzad napred

            Array.Reverse(stringArray1);
            Array.Reverse(stringArray2);

            int reverseCount = 0;
            for (int i = 0; i < smallerLength; i++)
            {
                if (stringArray1[i] == stringArray2[i])
                {
                    reverseCount++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(count, reverseCount));

            //main ends here
        }
    }
}
