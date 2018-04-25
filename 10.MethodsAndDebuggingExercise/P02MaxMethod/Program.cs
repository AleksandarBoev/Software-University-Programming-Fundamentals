using System;

namespace P02MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(number1, GetMax(number2, number3)));

            //main ends here
        }

        static int GetMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            } else
            {
                return number2;
            }
        }

        //class ends here
    }
}
