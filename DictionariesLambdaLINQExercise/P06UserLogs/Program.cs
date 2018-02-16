using System;
using System.Collections.Generic;
using System.Linq;

namespace P06UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userNameIp = new Dictionary<string, Dictionary<string, int>>();
            //key1=username ^|value1/key2 = IP ^ | ^ IP count = value2

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "end")
                {
                    break;
                }

                string userName = string.Join("", input[2].Skip(5)); // skipping "user="

                
                string ip = string.Join("", input[0].Skip(3)); // skipping "IP="

                if (userNameIp.ContainsKey(userName) == false) // ako nqma takuv potrebitel
                {
                    Dictionary<string, int> ipCount = new Dictionary<string, int>(); // new instance
                    ipCount.Add(ip, 1); // purvo ip i broika za tozi nov "user"
                    userNameIp.Add(userName, ipCount); // zapameti imeto na user-a, kakto i ip-to koeto e polzval vednuj
                }
                else // ako userName-ut ne e nov
                {
                    if (userNameIp[userName].ContainsKey(ip) == false) // ako tova ip ne e polzvano predi
                    {
                        userNameIp[userName].Add(ip, 1); // dobavi novoto ip na user-ut i dai broika 1 za puti polzvano
                    }
                    else //ako e polzvano tova ip
                    {
                        userNameIp[userName][ip]++;
                        // userNameIp ==  Dictionary<string, Dictionary<string, int>>
                        // userNameIp[userName] == Dictionary<string, int>
                        //userNameIp[userName][ip] == int
                    }
                }

            }

            //KeyValuePair<string, int> currentIp = new KeyValuePair<string, int>();
            //currentIp = userNameIp.Value;

            foreach (var kvp in userNameIp.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: ");
                int index = 0;
                int length = kvp.Value.Count;

                foreach (var kvp2 in kvp.Value)
                {
                    if (index < length - 1)
                    {
                        Console.Write($"{kvp2.Key} => {kvp2.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{kvp2.Key} => {kvp2.Value}.");
                    }
                    index++;
                }
            }
            //main ends here
        }
    }
}
