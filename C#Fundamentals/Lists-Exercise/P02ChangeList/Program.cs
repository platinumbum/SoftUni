using System;
using System.Collections.Generic;
using System.Linq;

namespace P02ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();
                string cmdArg = command[0];
                if (cmdArg == "Delete")
                {
                    int numberToRemove = int.Parse(command[1]);
                    numbers.RemoveAll(x => x == numberToRemove);
                }
                else if (cmdArg == "Insert")
                {
                    int numberToInsert = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    numbers.Insert(index, numberToInsert);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}