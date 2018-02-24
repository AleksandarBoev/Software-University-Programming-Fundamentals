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
            Members = new List<string>();
        }

        public static List<string> TeamNames { get; set; } = new List<string>();
        public static List<string> Creators { get; set; } = new List<string>();
        public static List<string> AllMembers { get; set; } = new List<string>();

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> nameTeam = new Dictionary<string, Team>();

            int numberOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                string creator = input[0];
                string teamName = input[1];

                if (Team.TeamNames.Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (Team.Creators.Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team currentTeam = new Team(creator);
                nameTeam.Add(teamName, currentTeam);
                Team.Creators.Add(creator);
                Team.TeamNames.Add(teamName);
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

                if (Team.TeamNames.Contains(teamName) == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (Team.AllMembers.Contains(name) || Team.Creators.Contains(name))
                {
                    Console.WriteLine($"Member {name} cannot join team {teamName}!");
                    continue;
                }

                nameTeam[teamName].Members.Add(name);
                Team.AllMembers.Add(name);
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
