using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_And_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> queries = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {
                int[] currentQuery = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int cmd = currentQuery[0];
                
                if (cmd == 1)
                {
                    int num = currentQuery[1];
                    queries.Push(num);
                }
                if (queries.Count > 0)
                {
                    if (cmd == 2)
                    {
                        queries.Pop();
                    }
                    else if (cmd == 3)
                    {
                        Console.WriteLine(queries.Max());
                    }
                    else if (cmd == 4)
                    {
                        Console.WriteLine(queries.Min());
                    }
                }


            }
            Console.WriteLine(string.Join(", ", queries));
        }
    }
}
