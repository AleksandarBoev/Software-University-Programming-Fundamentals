using System;
using System.Linq;
using System.Text;

namespace P06SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string biggerNumber = Console.ReadLine().TrimStart('0');
            string smallerNumber = Console.ReadLine().TrimStart('0');
            if (biggerNumber.Length < smallerNumber.Length)
            {
                string temporaryNumber = biggerNumber;
                biggerNumber = smallerNumber;
                smallerNumber = temporaryNumber;
            }

            biggerNumber = '0' + biggerNumber;
            smallerNumber = new string('0', biggerNumber.Length - smallerNumber.Length) + smallerNumber;

            StringBuilder sum = new StringBuilder();
            
            int remainder = 0;

            for (int i = biggerNumber.Length - 1; i >= 0; i--)
            {
                int currentSum = int.Parse("" + biggerNumber[i]) + int.Parse("" + smallerNumber[i]) + remainder;
                int resultDigit = currentSum % 10;
                sum.Append(resultDigit);
                remainder = currentSum / 10;
            }

            if (remainder != 0)
            {
                sum[sum.Length - 1] = char.Parse("" + remainder); // ili prosto = '1';
            }

            if (sum[sum.Length - 1] == '0') // proverqva se poslednata cifra, zashtoto oshte ne e oburnat. T.e. v momenta poslednata cifra vsushtnost e purva
            {
                sum.Remove(sum.Length - 1, 1);
            }

            string result = String.Concat(sum.ToString().Reverse());
            Console.WriteLine(result);
            //main ends here
        }
    }
}
