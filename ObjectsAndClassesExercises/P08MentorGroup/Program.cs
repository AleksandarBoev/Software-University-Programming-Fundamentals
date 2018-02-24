using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P08MentorGroup
{
    class StudentInfo
    {
        public List<string> Comments { get; set; }
        public List<DateTime> DatesAttended { get; set; } 

        public StudentInfo()
        {
            Comments = new List<string>();
            DatesAttended = new List<DateTime>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, StudentInfo> nameInfo = new Dictionary<string, StudentInfo>();
            string dateFormat = "dd/MM/yyyy";

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
                        DateTime temporaryDate = DateTime.ParseExact(input[i], dateFormat, CultureInfo.InvariantCulture);
                        currentStudentInfo.DatesAttended.Add(temporaryDate);
                    }

                    nameInfo.Add(name, currentStudentInfo);
                }
                else
                {
                    StudentInfo currentStudentInfo = new StudentInfo();
                    for (int i = 1; i < input.Length; i++)
                    {
                        DateTime temporaryDate = DateTime.ParseExact(input[i], dateFormat, CultureInfo.InvariantCulture);
                        nameInfo[name].DatesAttended.Add(temporaryDate);
                    }
                    
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

            foreach (var kvp in nameInfo.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{kvp.Key}" + System.Environment.NewLine + "Comments:");
                foreach (var kvp2 in kvp.Value.Comments)
                {
                    Console.WriteLine($"- {kvp2}");
                }
                Console.WriteLine("Dates attended: ");
                foreach (var kvp3 in kvp.Value.DatesAttended.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {kvp3.Day}/{kvp3.Month:D2}/{kvp3.Year}");
                }
            }
            //main ends here
        }
    }
}
