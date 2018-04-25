using System;

namespace P04Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double studioTotalPrice = 0;
            double doublePrice = 0;
            double doubleTotalPrice = 0;
            double suitePrice = 0;
            double suiteTotalPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (nightsCount > 7)
                {
                    studioPrice *= 0.95;
                    if (month == "October")
                    {
                        studioTotalPrice = (nightsCount - 1) * studioPrice;
                    }
                }
            } else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;

                if (nightsCount > 14)
                {
                    doublePrice *= 0.90;
                }

                if (nightsCount > 7 && month == "September")
                {
                    studioTotalPrice = (nightsCount - 1) * studioPrice;
                }
            } else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;

                if (nightsCount > 14)
                {
                    suitePrice *= 0.85;
                }
            }

            if (studioTotalPrice == 0)
            {
                studioTotalPrice = studioPrice * nightsCount;
            }

            doubleTotalPrice = doublePrice * nightsCount;
            suiteTotalPrice = suitePrice * nightsCount;

            Console.WriteLine($"Studio: {studioTotalPrice:F2} lv.");
            Console.WriteLine($"Double: {doubleTotalPrice:F2} lv.");
            Console.WriteLine($"Suite: {suiteTotalPrice:F2} lv.");

            //main ends here
        }
    }
}
