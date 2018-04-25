using System;

namespace P02AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int result = number1 + number2;

            Console.WriteLine("{0} + {1} = {2}", number1, number2, result);

            //main ends here
        }
    }
}
