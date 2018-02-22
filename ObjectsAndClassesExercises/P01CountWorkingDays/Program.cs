using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace P01CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] holidays = {new DateTime(4, 1, 1), new DateTime(4, 3, 3), new DateTime(4, 5, 1), new DateTime(4, 5, 6)
            , new DateTime(4, 5, 24), new DateTime(4, 9, 6), new DateTime(4, 9, 22), new DateTime(4, 11, 1), new DateTime(4, 12, 24)
            , new DateTime(4, 12, 25), new DateTime(4, 12, 26)}; // godina, mesec, den (za godina e izbrana visokosna)

            DayOfWeek saturday = DayOfWeek.Saturday; // malko nenujno, no nqma losho
            DayOfWeek sunday = DayOfWeek.Sunday;

            string dateFormat = "dd-MM-yyyy"; // format na denq

            string inputDate1 = Console.ReadLine().Trim(); // .Trim() za copy-pastevaneto
            DateTime startDate = DateTime.ParseExact(inputDate1, dateFormat, CultureInfo.InvariantCulture);
            //Console.WriteLine(startDate.ToString(dateFormat)); // po takuv nachin se pravi na string, za krasiva vizualizaciq

            //_______________________________________________________________________________
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); // [alt] + [enter] za da dobavish Thread
            //string dateFormat2 = "dd-MMM-yyyy";
            //DateTime currentDate = DateTime.ParseExact("12-May-2016", dateFormat2, CultureInfo.InvariantCulture);
            //string result = (currentDate.ToString(dateFormat2)); // --> vadi rezultat 12-May-2016
            //_______________________________________________________________________________

            string inputDate2 = Console.ReadLine().Trim();
            DateTime endDate = DateTime.ParseExact(inputDate2, dateFormat, CultureInfo.InvariantCulture);

            int countWorkDays = 0;

            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                DateTime temporaryDate = new DateTime(4, day.Month, day.Day);


                bool isNotWorkday = day.DayOfWeek == saturday || day.DayOfWeek == sunday ||
                    holidays.Contains(temporaryDate);

                if (!isNotWorkday)
                {
                    countWorkDays++;
                }
            }

            Console.WriteLine(countWorkDays);

            //main ends here
        }
    }
}

