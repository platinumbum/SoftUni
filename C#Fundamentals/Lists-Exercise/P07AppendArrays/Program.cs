using System;
using System.Collections.Generic;
using System.Linq;

namespace P07AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|").ToList();

            List<string> result = new List<string>();

            items.Reverse();

            foreach (var currentItem in items)
            {
                string[] numbers = currentItem.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}