using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P08LogsAggregator
{
    class User
    {
        public List<string> IpAdresses { get; set; } = new List<string>();
        public int TotalDuration { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> userData = new Dictionary<string, User>();
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] input = Console.ReadLine().Split();

                string ip = input[0];
                string userName = input[1];
                int duration = int.Parse(input[2]);

                if (userData.ContainsKey(userName) == false)
                {
                    User currentUser = new User();
                    currentUser.TotalDuration = duration;
                    currentUser.IpAdresses.Add(ip);
                    userData.Add(userName, currentUser);
                }
                else
                {
                    if (userData[userName].IpAdresses.Contains(ip) == false) // userData[userName] == User
                    {
                        userData[userName].IpAdresses.Add(ip);
                        userData[userName].TotalDuration += duration;
                    }
                    else
                    {
                        userData[userName].TotalDuration += duration;
                    }
                }

            }

            foreach (var kvp in userData.OrderBy(u => u.Key))
            {
                kvp.Value.IpAdresses.Sort();
                Console.WriteLine($"{kvp.Key}: {kvp.Value.TotalDuration} [{ string.Join(", ", kvp.Value.IpAdresses) }]");
            }

            //main ends here
        }
    }
}
