﻿using System;

namespace P06MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                string evenOutput = GetMiddleFromEven(input);
                Console.WriteLine(evenOutput);
            }
            else
            {
                string oddOutput = GetMiddleFromOdd(input);
                Console.WriteLine(oddOutput);
            }
        }

        private static string GetMiddleFromOdd(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);
            return chars;
        }

        private static string GetMiddleFromEven(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1, 2);
            return chars;
        }
    }
}
