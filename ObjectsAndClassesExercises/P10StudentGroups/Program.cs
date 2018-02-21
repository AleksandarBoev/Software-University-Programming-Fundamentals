using System;
using System.Collections.Generic;

namespace P10StudentGroups
{
    class StudentInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegistationDate { get; set; }
    }
    class GroupInfo
    {
        public int TakenSpots { get; set; }
        public int MaxSpots { get; set; }
        public List<StudentInfo> Students { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            

            //main ends here
        }
    }
}
