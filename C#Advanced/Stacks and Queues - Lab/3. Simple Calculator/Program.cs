using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> numbers = new Stack<string>(input.Reverse());

            while (numbers.Count > 1)
            {
                int leftNumber = int.Parse(numbers.Pop());
                string sign = numbers.Pop();
                int rightNumber = int.Parse(numbers.Pop());

                if (sign == "+")
                {
                    numbers.Push((leftNumber + rightNumber).ToString());
                }
                else if (sign == "-")
                {
                    numbers.Push((leftNumber - rightNumber).ToString());
                }
            }
            Console.WriteLine(numbers.Pop());
        }
    }
}
