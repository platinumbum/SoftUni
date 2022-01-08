using System;
using System.Collections.Generic;
using System.Linq;
namespace P06ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                string cmdArg = tokens[0];

                if (cmdArg == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                else if (cmdArg == "Remove")
                {
                    numbers.Remove(int.Parse(tokens[1]));
                }
                else if (cmdArg == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(tokens[1]));
                }
                else if (cmdArg == "Insert")
                {
                    numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}