using System;
using System.Collections.Generic;
using System.Linq;

namespace P04AverageGrades
{
    class Student
    {
        public string StudentName { get; set; }
        public List<double> StudentGrades { get; set; } = new List<double>();
        public double StudentAverageGrade { get; set; }

        public void SetStudentAverageGrade()
        {
            double sum = 0;
            for (int index = 0; index < StudentGrades.Count; index++)
            {
                sum += StudentGrades[index];
            }

            StudentAverageGrade = sum / StudentGrades.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> listOfStudents = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] inputData = Console.ReadLine().Trim().Split(); // nulev element e imeto, vseki drug e otdelna ocenka na studenta
                Student currentStudent = new Student();
                currentStudent.StudentName = inputData[0];

                for (int gradeNumber = 1; gradeNumber < inputData.Length; gradeNumber++)
                {
                    currentStudent.StudentGrades.Add(double.Parse(inputData[gradeNumber]));
                }

                currentStudent.SetStudentAverageGrade();
                listOfStudents.Add(currentStudent);
            }

            listOfStudents = listOfStudents
                .Where(item => item.StudentAverageGrade >= 5.0)
                .OrderBy(n => n.StudentName)
                .ThenByDescending(a => a.StudentAverageGrade)
                .ToList();

            foreach (Student student in listOfStudents)
            {
                Console.WriteLine($"{student.StudentName} -> {student.StudentAverageGrade:F2}");
            }

            //main ends here
        }

        //class ends here
    }
}
