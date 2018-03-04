using System;
using System.Collections.Generic;
using System.Linq;

namespace P04ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //name of forceUser mmust be UNIQUE
            //name of force must be Unique too i guess
            Dictionary<string, List<string>> forceSideForceUsers = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains(" | ")) // {forceSide} | {forceUser}
                {
                    string[] info = input.Split(" | "); // raboti na .NET Core
                    string forceSide = info[0];
                    string forceUser = info[1];
                    Remove(forceUser, forceSideForceUsers); // nqma nujda da se gleda dali e nov tuk

                    if (!forceSideForceUsers.ContainsKey(forceSide))
                    {
                        List<string> currentForseUsers = new List<string>();
                        currentForseUsers.Add(forceUser);
                        forceSideForceUsers.Add(forceSide, currentForseUsers);
                    }
                    else
                    {
                        forceSideForceUsers[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains(" -> ")) // {forceUser} -> {forceSide}
                {
                    string[] info = input.Split(" -> ");
                    string forceUser = info[0];
                    string forceSide = info[1];
                    bool printMessage = true;

                    if (forceSideForceUsers.ContainsKey(forceSide))
                    {
                        if (!forceSideForceUsers[forceSide].Contains(forceUser)) // ako nqma chovek s takova ime v tazi force-sila
                        {
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                            printMessage = false;
                        }
                    }

                    Remove(forceUser, forceSideForceUsers);

                    if (!forceSideForceUsers.ContainsKey(forceSide))
                    {
                        List<string> currentForseUsers = new List<string>();
                        currentForseUsers.Add(forceUser);
                        forceSideForceUsers.Add(forceSide, currentForseUsers);
                        if (printMessage)
                        {
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                    }
                    else
                    {
                        forceSideForceUsers[forceSide].Add(forceUser);
                    }
                }
            }

            foreach (var kvp in forceSideForceUsers.OrderByDescending(c => c.Value.Count).ThenBy(n => n.Key))
            {
                if (kvp.Value.Count == 0)
                {
                    continue;
                }
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
                foreach (var forceUser in kvp.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"! {forceUser}");
                }
            }
            //main ends here
        }

        static void Remove(string forceUser, Dictionary<string, List<string>> forceSideForceUsers)
        { // obhojda celiq rechnik i vsichki list-ove na rechnika i tursi imeto na choveka
            foreach (var kvp in forceSideForceUsers)
            {
                for (int i = 0; i < kvp.Value.Count; i++)
                {
                    if (forceUser == kvp.Value[i])
                    {
                        kvp.Value.RemoveAt(i); // dali nqma da grumne ako pri samoto iterirane se promeni rechnika
                        return;
                        //return true; ; //ako grumne prosto moga da zapazq indeksa i posle da go premahna
                    }
                }
            }
            // return false;
        }

        //class ends here
    }
}
