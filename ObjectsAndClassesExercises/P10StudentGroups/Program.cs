using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace P10StudentGroups
{
    class StudentInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; } 

        public StudentInfo(string name, string email, DateTime registrationDate)
        {
            Name = name;
            Email = email;
            RegistrationDate = registrationDate;
        }
    }
    class Group
    {
        public List<StudentInfo> Students { get; set; }
        static public int AllGroupsCount { get; set; }

        public Group()
        {
            Students = new List<StudentInfo>();
        }
    }

    class City
    {
        public string CityName { get; set; }
        public int GroupSize { get; set; }
        public List<Group> Groups { get; set; }
        // ne e static, zashtoto iskam vsichki studenti za edin grad da si gi imam, za da moga posle da gi razpredelq po grupi SLED kato gi sortiram kakto trqbva
        public List<StudentInfo> AllStudents { get; set; }

        public City(string cityName, int groupSize)
        {
            CityName = cityName;
            GroupSize = groupSize;
            Groups = new List<Group>();
            AllStudents = new List<StudentInfo>();
        }

        static public int CitiesCount { get; set; } = 0; // ne samo shte go polzvam nakraq za da iznesa broikata na gradovete, no i za indexirane na 
    } // listut ot gradove. No prosto moje i s List<City> cities.Count...

    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string dateFormat = "d-MMM-yyyy";

            //Regex regexCityName = new Regex(@"[A-Z][a-z]+(\s[A-Z][a-z]+)?"); // sumnqva me da ima grad s tri imena...
            //Match matchCityName;
            Regex regexGroupSize = new Regex(@"\d+"); // tursi poredica ot chisla
            Match matchGroupSize;

            List<City> cities = new List<City>();

            while (true) // vuvejdane na danni
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                if (input.Contains("=>")) // oznachava che e vuveden grad i mesta
                {//ne pokrivam sluchaqt, v koito moje edin grad da bude vuveden vtori put. Ako bude vuveden ima 2 varianta: infoto da se ignorira ili da se obnovi
                    string[] cityInformation = input.Split("=>".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                    string currentCityName = cityInformation[0].Trim();

                    matchGroupSize = regexGroupSize.Match(cityInformation[1]);
                    int currentCityGroupSize = int.Parse(matchGroupSize.ToString());

                    if (CityNameIsUnique(currentCityName.ToString(), cities))
                    {
                        City.CitiesCount++;
                    }
                    else
                    {
                        continue;
                    }

                    City currentCity = new City(currentCityName, currentCityGroupSize);
                    cities.Add(currentCity);
                }
                else
                { // ako sme v segashniq grad
                    string[] studentInfo = input.Split('|');

                    string name = studentInfo[0].Trim();
                    string email = studentInfo[1].Trim();
                    string date = studentInfo[2].Trim();
                    DateTime registrationDate = DateTime.ParseExact(date, dateFormat, CultureInfo.InvariantCulture);
                    StudentInfo currentStudent = new StudentInfo(name, email, registrationDate);
                    cities[cities.Count - 1].AllStudents.Add(currentStudent); // cities[cities.Count - 1] vinagi shte vrushta posledniq vuveden grad kakto si e redut
                }
            } // works

            //razpredelqne na studenti po grupi kato bivat podrejdani po data na zapisvane (ascending), ime (ascending), email(ascending)
            foreach (City city in cities.OrderBy(n => n.CityName))
            {
                int groupCounter = -1; // nomer na grupata v segashniq grad
                int studentCounter = 0;
                foreach (StudentInfo student in city.AllStudents.OrderBy(r => r.RegistrationDate).ThenBy(n => n.Name).ThenBy(e => e.Email)) //podredeni sa i trqbva da se razpredelqt v List<Group> groups
                {
                    if (studentCounter % city.GroupSize == 0) // 
                    {
                        Group currentGroup = new Group();
                        currentGroup.Students.Add(student);
                        groupCounter++;
                        city.Groups.Add(currentGroup);
                        Group.AllGroupsCount++;
                    }
                    else
                    {
                        city.Groups[groupCounter].Students.Add(student);
                    }
                    studentCounter++;
                }
            }

            Console.WriteLine($"Created {Group.AllGroupsCount} groups in {cities.Count} towns:");
            foreach (City city in cities.OrderBy(n => n.CityName))
            {
                foreach (var group in city.Groups)
                {
                    Console.Write($"{city.CityName} => ");
                    for (int i = 0; i < group.Students.Count; i++)
                    {
                        if (i != group.Students.Count - 1)
                        {
                            Console.Write(group.Students[i].Email + ", ");
                        }
                        else
                        {
                            Console.WriteLine(group.Students[i].Email);
                        }
                    }
                }
            }

            //main ends here
        }

        static bool CityNameIsUnique(string cityName, List<City> cities)
        {
            for (int i = 0; i < cities.Count; i++)
            {
                if (cityName == cities[i].CityName)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
