using System;

namespace P01PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            decimal pricePerLightsaber = decimal.Parse(Console.ReadLine());
            decimal pricePerRobe = decimal.Parse(Console.ReadLine());
            decimal pricePerBelt = decimal.Parse(Console.ReadLine());

            int lightSabresCount = numberOfStudents + (int)Math.Ceiling(numberOfStudents * 0.1);
            int beltsCount = numberOfStudents - numberOfStudents / 6;
            decimal totalPrice = pricePerLightsaber * lightSabresCount + pricePerRobe * numberOfStudents
                + pricePerBelt * beltsCount;

            decimal moneyLeft = budget - totalPrice;
            if (moneyLeft < 0)
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(moneyLeft):F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
                //6th belt is free --> 42 / 6 = 7 41 / 6 = 6
            //main ends here
        }
    }
}
