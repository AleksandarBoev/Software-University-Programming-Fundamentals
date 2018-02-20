using System;
using System.Collections.Generic;

namespace P09TeamworkProjects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; } = new List<string>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeamsToRegister = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < numberOfTeamsToRegister; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creatorName = input[0];
                string teamName = input[1];

                
            }
            //main ends here
        }
    }
}
