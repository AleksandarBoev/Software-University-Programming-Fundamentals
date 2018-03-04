using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03FootballLeague
{
    class Team
    {
        public string Name { get; set; }
        public long Points { get; set; }
        public long GoalCount { get; set; }

        public Team(string name, long points, long goalCount)
        {
            Name = name;
            Points = points;
            GoalCount = goalCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string key = Regex.Escape(Console.ReadLine());
            Regex regex = new Regex($@"{key}(?<team1>\w+){key}.*{key}(?<team2>\w+){key}.*(?<score1>\d+):(?<score2>\d+)");

            List<Team> teams = new List<Team>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }

                if (!regex.IsMatch(input))
                {
                    continue;
                }

                Match match = regex.Match(input);

                string team1Name = String.Concat(match.Groups["team1"].Value.ToUpper().Reverse());
                string team2Name = String.Concat(match.Groups["team2"].Value.ToUpper().Reverse());
                long team1Score = long.Parse(String.Concat(match.Groups["score1"].Value));
                long team2Score = long.Parse(String.Concat(match.Groups["score2"].Value));

                long team1CurrentPoints;
                long team2CurrentPoints;
                if (team1Score == team2Score)
                {
                    team1CurrentPoints = 1;
                    team2CurrentPoints = 1;
                }
                else if (team1Score > team2Score)
                {
                    team1CurrentPoints = 3;
                    team2CurrentPoints = 0;
                }
                else
                {
                    team1CurrentPoints = 0;
                    team2CurrentPoints = 3;
                }

                if (GetTeamIndex(team1Name, teams) == -1)
                {
                    Team newTeam1 = new Team(team1Name, team1CurrentPoints, team1Score);
                    teams.Add(newTeam1);
                }
                else
                {
                    int teamIndex = GetTeamIndex(team1Name, teams);
                    teams[teamIndex].Points += team1CurrentPoints;
                    teams[teamIndex].GoalCount += team1Score;
                }

                if (GetTeamIndex(team2Name, teams) == -1)
                {
                    Team newTeam2 = new Team(team2Name, team2CurrentPoints, team2Score);
                    teams.Add(newTeam2);
                }
                else
                {
                    int teamIndex = GetTeamIndex(team2Name, teams);
                    teams[teamIndex].Points += team2CurrentPoints;
                    teams[teamIndex].GoalCount += team2Score;
                }
            }

            Console.WriteLine("League standings:");
            long counter = 1;
            foreach (Team team in teams.OrderByDescending(p => p.Points).ThenBy(n => n.Name))
            {
                Console.WriteLine($"{counter}. {team.Name} {team.Points}");
                counter++;
            }

            counter = 0;
            Console.WriteLine("Top 3 scored goals:"); // daje ako sa po-malko ot 3 otbora pak trqbva da se otpechata "Top 3 scored goals:"
            foreach (Team team in teams.OrderByDescending(g => g.GoalCount).ThenBy(n => n.Name))
            {
                Console.WriteLine($"- {team.Name} -> {team.GoalCount}");
                counter++;
                if (counter == 3)
                {
                    break;
                }
            }
            //main ends here
        }

        static int GetTeamIndex(string name, List<Team> teams)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        //class ends here
    }
}
