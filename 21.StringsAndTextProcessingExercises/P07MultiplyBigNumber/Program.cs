using System;
using System.Linq;
using System.Text;

namespace P07MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine().TrimStart('0');
            string input2 = Console.ReadLine().TrimStart('0');
            if (input1 == "" || input2 == "")
            {
                Console.WriteLine(0);
                return;
            }

            string bigNumber = '0' + input1;
            int multiplier = int.Parse(input2);
            int remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int multiplicationResult = int.Parse("" + bigNumber[i]) * multiplier + remainder;
                int digitResult = multiplicationResult % 10;
                remainder = multiplicationResult / 10;
                result.Append(digitResult);
            }

            Console.WriteLine(String.Concat(result.ToString().TrimEnd('0').Reverse()));
            //main ends here
        }
    }
}
