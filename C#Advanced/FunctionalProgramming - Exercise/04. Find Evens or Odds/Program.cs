using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = ranges[0];
            int end = ranges[1];
            string criteria = Console.ReadLine();


            Func<int, int, List<int>> generateRangeOfNums = (s, e) =>
            {
                List<int> nums = new List<int>();

                for (int i = s; i <= e; i++)
                {
                    nums.Add(i);

                }
                return nums;
            };


            List<int> numbers = generateRangeOfNums(start, end);
            Predicate<int> predicate = n => true;


            if (criteria == "odd")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
            }
            else if (criteria == "even")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
            }
        }
    }
}
