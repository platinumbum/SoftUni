using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] command = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int n = command[0];
            int s = command[1];
            int x = command[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queuedNumbers = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                queuedNumbers.Enqueue(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queuedNumbers.Dequeue();
            }
            if (queuedNumbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (!queuedNumbers.Contains(x))
            {
                Console.WriteLine(queuedNumbers.Min());
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
