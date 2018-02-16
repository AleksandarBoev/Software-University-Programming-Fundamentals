using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P01CountWorkingDays
{
    class Program
    {
        private static string input1;
        private static string input2;
        private static string format;
        private static DateTime startDate;
        private static DateTime endDate;
        private static DateTime[] holidays = new DateTime[]
            {
                new DateTime(1, 12, 24),
                new DateTime(1, 12, 25),
                new DateTime(1, 12, 26),
                new DateTime(1, 01, 01),
                new DateTime(1, 03, 03),
                new DateTime(1, 05, 01),
                new DateTime(1, 05, 06),
                new DateTime(1, 05, 24),
                new DateTime(1, 09, 06),
                new DateTime(1, 09, 22),
                new DateTime(1, 11, 01),
            };

        static void Main(string[] args)
        {
            input1 = Console.ReadLine().Trim();
            input2 = Console.ReadLine().Trim();
            format = "dd-MM-yyyy";

            startDate = DateTime.ParseExact(input1, format, CultureInfo.InvariantCulture);
            endDate = DateTime.ParseExact(input2, format, CultureInfo.InvariantCulture);
            //RunWithErrors();

            int workindDays = 0;

            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                DayOfWeek dayOfWeek = day.DayOfWeek;
                DateTime tempDate = new DateTime(1, day.Month, day.Day);
                if (!holidays.Contains(tempDate) && !dayOfWeek.Equals(DayOfWeek.Sunday) && !dayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    workindDays += 1;
                }
            }
            Console.WriteLine(workindDays);
        }

        private static void RunWithErrors()
        {

            int countWorkDays = 0;
            DateTime day = new DateTime();
            for (day = startDate; day <= endDate; day = day.AddDays(1))
            {
                bool isWorkDay = string.Join("", day.DayOfWeek) != "Saturday"
                    && string.Join("", day.DayOfWeek) != "Sunday"
                    && IsHoliday(string.Join("", day)) == true
                    ;

                if (isWorkDay)
                {
                    countWorkDays++;
                }
            }

            Console.WriteLine(countWorkDays);
            //main ends here
        }

        static bool IsHoliday(string date)
        {
            string[] dateInfo = date.Split('-').ToArray();

            string dayAndMonth = dateInfo[0] + '-' + dateInfo[1];

            switch (dayAndMonth)
            {
                case "01-Jan":
                case "03-Mar":
                case "01-May":
                case "06-May":
                case "24-May":
                case "06-Sep":
                case "22-Sep":
                case "01-Nov":
                case "24-Dec":
                case "25-Dec":
                case "26-Dec":
                    return false;
                    break;
            }

            return true;
            }

            //class ends here
        }
    }
