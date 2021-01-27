﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> counter = new Dictionary<double, int>();

            foreach (var num in numbers)
            {
                if (counter.ContainsKey(num))
                {
                    counter[num]++;
                }
                else
                {
                    counter[num] = 1;
                }
            }
            foreach (var num in counter)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }

        }
    }
}
