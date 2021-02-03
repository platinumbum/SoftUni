using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            Func<int, int> arithmeticFunc = n => n;
            Action<List<int>> print = nums => Console.WriteLine(string.Join(" ", nums));

            while (command != "end")
            {
                if (command == "add")
                {
                    arithmeticFunc = n => n + 1;
                    numbers = numbers.Select(arithmeticFunc).ToList();
                }
                else if (command == "multiply")
                {
                    arithmeticFunc = n => n * 2;
                    numbers = numbers.Select(arithmeticFunc).ToList();
                }
                else if (command == "subtract")
                {
                    arithmeticFunc = n => n - 1;
                    numbers = numbers.Select(arithmeticFunc).ToList();
                }
                else if (command == "print")
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
