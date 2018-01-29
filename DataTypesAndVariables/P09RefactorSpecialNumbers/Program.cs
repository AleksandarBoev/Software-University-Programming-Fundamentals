using System;

namespace P09RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            bool isSpecialNumber = false;

            for (int i = 1; i <= number; i++)
            {
                currentNumber = i;
                int sum = 0;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNumber} -> {isSpecialNumber}");
                i = currentNumber; //principno ne e dobre da se promenq stoinostta na iteratora

            }


            //main ends here
        }
    }
}
