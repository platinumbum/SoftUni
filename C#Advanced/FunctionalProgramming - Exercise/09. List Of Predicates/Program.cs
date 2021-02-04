using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> outputNumbers = new List<int>();
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

            Func<int[], bool> func = numbers => { }

            for (int i = 1; i <= n; i++)
            {
                bool isDevisible = true;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i % numbers[j] != 0)
                    {
                        isDevisible = false;
                        break;
                    }
                }
                if (isDevisible)
                {
                    outputNumbers.Add(i);
                }
            }
            print(outputNumbers);

        }
    }
}
