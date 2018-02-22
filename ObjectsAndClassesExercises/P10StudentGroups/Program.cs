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
        //public string RegistrationDate { get; set; }
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
        public List<StudentInfo> Students { get; set; } = new List<StudentInfo>();
        static public int GroupsCount { get; set; }
    }

    class City
    {
        public string CityName { get; set; }
        public int GroupSize { get; set; }
        public List<Group> Groups { get; set; } = new List<Group>();
        // ne e static, zashtoto iskam vsichki studenti za edin grad da si gi imam, za da moga posle da gi razpredelq po grupi SLED kato gi sortiram kakto trqbva
        public List<StudentInfo> AllStudents { get; set; } = new List<StudentInfo>();

        public City(string cityName, int groupSize)
        {
            CityName = cityName;
            GroupSize = groupSize;
        }

        static public int CitiesCount { get; set; } = 0; // ne samo shte go polzvam nakraq za da iznesa broikata na gradovete, no i za indexirane na 
    } // listut ot gradove. No prosto moje i s List<City> cities.Count...

    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
           
            Regex regexCityName = new Regex(@"[A-Z][a-z]+(\s[A-Z][a-z]+)?"); // sumnqva me da ima grad s tri imena...
            Match matchCityName;
            Regex regexGroupSize = new Regex(@"\d+"); // tursi poredica ot chisla
            Match matchGroupSize;

            List<City> cities = new List<City>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                if (input.Contains("=>")) // oznachava che e vuveden grad i mesta
                {//ne pokrivam sluchaqt, v koito moje edin grad da bude vuveden vtori put. Ako bude vuveden ima 2 varianta: infoto da se ignorira ili da se obnovi
                    matchCityName = regexCityName.Match(input);
                    matchGroupSize = regexGroupSize.Match(input);
                    City.CitiesCount++;
                    City currentCity = new City(matchCityName.ToString(), int.Parse(matchGroupSize.ToString()));
                    cities.Add(currentCity);
                }
                else
                { // ako sme v segashniq grad
                    string[] studentInfo = input.Split('|');
                    string name = studentInfo[0].Trim();
                    string email = studentInfo[1].Trim();
                    string date = studentInfo[2].Trim();
                    DateTime registrationDate = DateTime.Parse(date, CultureInfo.InvariantCulture);
                    StudentInfo currentStudent = new StudentInfo(name, email, registrationDate);
                    cities[cities.Count - 1].AllStudents.Add(currentStudent); // cities[cities.Count - 1] vinagi shte vrushta posledniq vuveden grad kakto si e redut
                }

            }

            

            //main ends here
        }
    }
}
