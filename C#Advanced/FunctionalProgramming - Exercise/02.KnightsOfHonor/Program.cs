using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().Select(n => $"Sir {n}").ToList();

            Action<List<string>> printNames = n => Console.WriteLine(string.Join(Environment.NewLine, n));

            printNames(names);

        }


    }
}


