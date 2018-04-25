using System;

namespace P02SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintIntegerSign(num);

            //main ends here
        }

        static void PrintIntegerSign(int number) //moje da se napravi metod otdelno samo za znakut
        {
            string sign = "";
            if (number < 0)
            {
                sign = "negative";
            } else if (number == 0)
            {
                sign = "zero";
            } else
            {
                sign = "positive";
            }

            Console.WriteLine($"The number {number} is {sign}.");

        }

        //class ends here
    }
}
