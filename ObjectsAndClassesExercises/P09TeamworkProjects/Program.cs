using System;
using System.Collections.Generic;
using System.Linq;

namespace P09TeamworkProjects
{
    class Team
    {
        //public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team(string creator)
        {
            //TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }

        public Team()
        {

        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> teamNames = new List<string>();
            List<string> creators = new List<string>();
            List<string> allMembers = new List<string>();
            Dictionary<string, Team> nameTeam = new Dictionary<string, Team>();

            int numberOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                string creator = input[0];
                string teamName = input[1];

                if (teamNames.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (creators.Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team currentTeam = new Team(creator);
                nameTeam.Add(teamName, currentTeam);
                creators.Add(creator);
                teamNames.Add(teamName);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end of assignment")
                {
                    break;
                }

                string name = input[0];
                string teamName = input[1];

                if (teamNames.Contains(teamName) == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (allMembers.Contains(name) || creators.Contains(name))
                {
                    Console.WriteLine($"Member {name} cannot join team {teamName}!");
                    continue;
                }

                nameTeam[teamName].Members.Add(name);
                allMembers.Add(name);
            }


            foreach (var kvp in nameTeam.OrderByDescending(m => m.Value.Members.Count).ThenBy(n => n.Key))
            {
                if (kvp.Value.Members.Count == 0)
                {
                    continue;
                }

                Console.Write($"{kvp.Key}" + Environment.NewLine + $"- {kvp.Value.Creator}" + Environment.NewLine);
                foreach (var kvp2 in kvp.Value.Members.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {kvp2}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var kvp in nameTeam.Where(m => m.Value.Members.Count == 0).OrderBy(n => n.Key))
            {
                Console.WriteLine($"{kvp.Key}");
            }
            //main ends here
        }
    }
}
