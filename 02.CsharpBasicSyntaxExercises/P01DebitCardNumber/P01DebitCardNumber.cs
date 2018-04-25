using System;

namespace P01DebitCardNumber
{
    class P01DebitCardNumber
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());


            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", number1, number2, number3, number4);

            //main ends here
        }
    }
}
