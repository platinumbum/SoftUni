using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackNumbers = new Stack<int>(numbers);
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {

                if (command.Contains("add"))
                {
                    var numToAdd = command.Split();
                    stackNumbers.Push(int.Parse(numToAdd[1]));
                    stackNumbers.Push(int.Parse(numToAdd[2]));
                }
                if (command.Contains("remove"))
                {
                    var numToRemove = command.Split();
                    var count = int.Parse(numToRemove[1]);
                    if (count <= stackNumbers.Count)
                    {


                        for (int i = 0; i < count; i++)
                        {
                            stackNumbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Sum: " + stackNumbers.Sum());

        }
    }
}
