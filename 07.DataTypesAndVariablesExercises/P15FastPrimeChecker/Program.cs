using System;

namespace P15FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= number; currentNumber++)
            {
                bool isPrime = true;
                for (int check = 2; check <= Math.Sqrt(currentNumber); check++)
                {
                    if (currentNumber % check == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }


            //main ends here
        }
    }
}
