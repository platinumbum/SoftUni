using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
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

            Stack<int> stackNumbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                stackNumbers.Push(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stackNumbers.Pop();
            }

            if (stackNumbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (!stackNumbers.Contains(x))
            {
                Console.WriteLine(stackNumbers.Min());
            }
            else
            {
                Console.WriteLine("true");
            }
        }

    }
}
