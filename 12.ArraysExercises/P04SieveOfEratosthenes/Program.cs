using System;

namespace P04SieveOfEratosthenes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()) + 1;
            bool[] arePrimes = new bool[n]; // ako e dadeno 25, kletkite shte budat ot [0..24]

            for (int index = 2; index < n; index++) //po default vsichki kletki sa false => 0 , 1 ostavat false
            {
                arePrimes[index] = true;
            }

            for (int index = 2; index < n; index++) //po default vsichki kletki sa false => 0 , 1 ostavat false
            {
                int count = 2;
                while (count * index < n)
                {
                    arePrimes[count * index] = false;
                    count++;
                }
            }

            for (int index = 2; index < n; index++)
            {
                if (arePrimes[index])
                {
                    Console.Write(index + " ");
                }

            }

            //main ends here
        }

        //class ends here
    }
}
