using System;
using System.Collections.Generic;
using System.Linq;

namespace P03HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                string person = command[0];
                if (command.Length > 3)
                {
                    if (guests.Contains(person))
                    {
                        guests.Remove(person);
                    }
                    else
                    {
                        Console.WriteLine($"{person} is not in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(person))
                    {
                        Console.WriteLine($"{person} is already in the list!");
                    }
                    else
                    {
                        guests.Add(person);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}