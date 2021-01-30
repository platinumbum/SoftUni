using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_Of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> numbersInN = new HashSet<int>();
            HashSet<int> numbersInM = new HashSet<int>();
            HashSet<int> finalNumbers = new HashSet<int>();

            int n = input[0];
            int m = input[1];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbersInN.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbersInM.Add(number);
            }

            foreach (var number in numbersInN)
            {
                if (numbersInM.Contains(number))
                {
                    finalNumbers.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ",finalNumbers));
            

        }
    }
}
