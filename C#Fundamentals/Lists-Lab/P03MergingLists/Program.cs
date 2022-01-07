using System;
using System.Collections.Generic;
using System.Linq;
namespace P03MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> final = new List<int>();

            if (firstNumbers.Count > secondNumbers.Count)
            {
                for (int i = 0; i < firstNumbers.Count; i++)
                {
                    final.Add(firstNumbers[i]);
                    if (secondNumbers.Count > i)
                    {
                        final.Add(secondNumbers[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < secondNumbers.Count; i++)
                {
                    if (firstNumbers.Count > i)
                    {
                        final.Add(firstNumbers[i]);
                    }
                    final.Add(secondNumbers[i]);
                }
            }


            Console.WriteLine(String.Join(" ", final));
        }
    }
}