using System;

namespace P07ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {num1}");
            Console.WriteLine($"b = {num2}");

            //int temporaryNum = num1;
            //num1 = num2;
            //num2 = temporaryNum;
            SwapIntegerValues(ref num1, ref num2);

            Console.WriteLine("After:");
            Console.WriteLine($"a = {num1}");
            Console.WriteLine($"b = {num2}");

            //main ends here
        }

        static void SwapIntegerValues(ref int integer1, ref int integer2)
        {
            int tempNum = integer1;
            integer1 = integer2;
            integer2 = tempNum;
        }

        //class ends here
    }
}
