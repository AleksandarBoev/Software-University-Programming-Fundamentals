using System;

namespace P04NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            PrintReverse(number);

            //main ends here
        }

        static void PrintReverse(string number)
        {
            for (int i = number.Length - 1;  i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            

        }

        //class ends here
    }
}
