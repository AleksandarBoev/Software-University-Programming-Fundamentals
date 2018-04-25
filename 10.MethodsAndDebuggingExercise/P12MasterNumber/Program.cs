using System;

namespace P12MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInteger = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberInteger; i++)
            {
                string currentNumberString = i.ToString();
                if (IsSymetric(currentNumberString) && SumOfDigitsIsDivisibleBySeven(currentNumberString) && HasAnEvenDigit(currentNumberString))
                {
                    Console.WriteLine(currentNumberString);
                }
            }

            //main ends here
        }

        static bool IsSymetric(string number)
        {
            int count = 0;

            for (int i = number.Length - 1; i >= number.Length / 2; i--)
            {
                if (number[i] != number[count])
                {
                    return false;
                }
                count++;
            }

            return true;
        }

        static bool SumOfDigitsIsDivisibleBySeven(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                sum += int.Parse(digit + "");
            }

            if (sum % 7 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static bool HasAnEvenDigit(string number)
        {
            foreach (var item in number)
            {
                if (int.Parse(item + "") % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        //class ends here
    }
}
