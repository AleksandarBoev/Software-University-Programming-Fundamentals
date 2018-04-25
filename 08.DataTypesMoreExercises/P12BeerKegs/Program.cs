using System;

namespace P12BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfKegs = byte.Parse(Console.ReadLine());

            double biggestVolume = -1.0;
            string modelOfBiggestKeg = "";

            for (byte kegNumber = 0; kegNumber < numberOfKegs; kegNumber++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > biggestVolume)
                {
                    modelOfBiggestKeg = kegModel;
                    biggestVolume = volume;
                }
            }

            Console.WriteLine(modelOfBiggestKeg);

            //main ends here
        }
    }
}
