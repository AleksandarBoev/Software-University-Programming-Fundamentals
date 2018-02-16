using System;
using System.Linq;

namespace P06FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int k = input.Length / 4;

            string[] leftPart = input.Take(k).ToArray();
            string[] middlePart = input.Skip(k).Take(2 * k).ToArray();
            string[] rightPart = input.Skip(3 * k).Take(k).ToArray();

            leftPart = leftPart.Reverse().ToArray();
            rightPart = rightPart.Reverse().ToArray();
            string[] addArray = (string.Join(" ", leftPart) + " " + string.Join(" ", rightPart)).Split();

            Console.WriteLine(string.Join(" ", middlePart.Select((x, index) => int.Parse(x) + int.Parse(addArray[index]))));//c# samo se doseshta che index e iterator?

            //main ends here
        }
    }
}
