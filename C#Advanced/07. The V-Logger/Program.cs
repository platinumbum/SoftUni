using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> app = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string commandInput = Console.ReadLine();

            while (commandInput != "Statistics")
            {
                string[] cmdArg = commandInput.Split(" ");
                string vloggerName = cmdArg[0];
                string command = cmdArg[1];

                if (command == "joined")
                {
                    if (!app.ContainsKey(vloggerName))
                    {
                        app.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                        app[vloggerName].Add("following", new SortedSet<string>());
                        app[vloggerName].Add("followers", new SortedSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    string vloggerTwoName = cmdArg[2];

                    if (app.ContainsKey(vloggerName) && app.ContainsKey(vloggerTwoName) && vloggerName != vloggerTwoName)
                    {
                        app[vloggerName]["following"].Add(vloggerTwoName);
                        app[vloggerTwoName]["followers"].Add(vloggerName);

                    }
                }
                commandInput = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, SortedSet<string>>> sortedApp = 
                app.OrderByDescending(kvp => kvp.Value["followers"].Count)
                .ThenBy(kvp => kvp.Value["following"].Count)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Console.WriteLine($"The V-Logger has a total of {app.Count} vloggers in its logs.");

            int counter = 0;
            foreach (KeyValuePair<string, Dictionary<string, SortedSet<string>>> item in sortedApp)
            {
                int followersCount = item.Value["followers"].Count;
                int followingCount = item.Value["following"].Count;

                Console.WriteLine($"{++counter}. {item.Key} : {followersCount} followers, {followingCount} following");

                if (counter == 1)
                {
                    foreach (string follower in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

            }
        }
    }
}
