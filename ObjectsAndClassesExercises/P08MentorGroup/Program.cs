using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P08MentorGroup
{
    class StudentInfo
    {
        public List<string> Comments { get; set; } = new List<string>();
        //List<DateTime> DatesAttended { get; set; } = new List<DateTime>(); // ako neshto ne se poluchi moje prosto kato stringove da go zapazq
        public List<string> DatesAttended { get; set; } = new List<string>();
        //public void ReadDate(string date)
        //{
        //    string dateFormat = "dd/MM/yyyy";
        //    DateTime temporaryDate = DateTime.ParseExact(date, dateFormat, CultureInfo.InvariantCulture);
        //    DatesAttended.Add(temporaryDate);
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, StudentInfo> nameInfo = new Dictionary<string, StudentInfo>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { ',', ' ' });
                if (string.Join(" ", input) == "end of dates")
                {
                    break;
                }

                string name = input[0];
                if (nameInfo.ContainsKey(name) == false)
                {
                    StudentInfo currentStudentInfo = new StudentInfo();
                    for (int i = 1; i < input.Length; i++)
                    {
                        currentStudentInfo.DatesAttended.Add(input[i]);
                    }

                    nameInfo.Add(name, currentStudentInfo);
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split('-');
                if (string.Join(" ", input) == "end of comments")
                {
                    break;
                }

                string name = input[0];
                string comment = input[1];

                if (nameInfo.ContainsKey(name) == false) // ako ne e imal prisustviq dosega se preskacha
                {
                    continue;
                }
                else
                {
                    nameInfo[name].Comments.Add(comment);
                }

            }

            foreach (var kvp in nameInfo)
            {
                Console.WriteLine($"{kvp.Key}" + System.Environment.NewLine + "Comments:");
                foreach (var kvp2 in kvp.Value.Comments)
                {
                    Console.WriteLine($"- {kvp2}");
                }
                Console.WriteLine("Dates attended: ");
                foreach (var kvp3 in kvp.Value.DatesAttended.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {kvp3}");
                }
            }
            //main ends here
        }
    }
}
