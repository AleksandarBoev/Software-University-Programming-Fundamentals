using System;

namespace P09MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(MultiplyEvensByOdds(number));
            //main ends here
        }

        static int MultiplyEvensByOdds(int number)
        {
            byte count = 1;
            int evenSum = 0;
            int oddSum = 0;
            while (number != 0)
            {
                if (count % 2 == 1)
                {
                    evenSum += number % 10;
                } else
                {
                    oddSum += number % 10;
                }
                count++;
                number /= 10;
            }

            return evenSum * oddSum;
        }

        //class ends here
    }
}
