using System;

namespace P05FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumber(n));

            //main ends here
        }

        static int FibonacciNumber(int number)
        {
           if (number == 0 || number == 1)
            {
                return 1;
            }

            int tempNumber = 1;
            int result = 0;
            int tempNumber2 = 1;

            for (int i = 2; i <= number; i++)
            {
                result = tempNumber + tempNumber2;
                tempNumber2 = tempNumber;
                tempNumber = result;
            }

            return result;

        }

        //class ends here
    }
}
