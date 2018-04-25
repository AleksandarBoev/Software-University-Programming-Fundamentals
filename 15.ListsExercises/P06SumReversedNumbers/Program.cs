using System;
using System.Linq;
using System.Text;

namespace P06SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersStr = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < numbersStr.Length; i++)
            {
                numbersStr[i] = ReverseStr(numbersStr[i]);
            }

            double[] numbers = new double[numbersStr.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(numbersStr[i]);
            }

            double totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                totalSum += numbers[i];
            }

            //Console.WriteLine(string.Join(" + ", numbers) + " = " + totalSum);
            Console.WriteLine(totalSum);
          
            //main ends here
        }

        static string ReverseStr(string str) // works
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        //class ends here
    }
}
