using System;
using System.Collections.Generic;
using System.Linq;
namespace P07ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();
            int originalCount = numbers.Count;
            List <int> originalNumbers = numbers.ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                string cmdArg = tokens[0];

                if (cmdArg == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                else if (cmdArg == "Remove")
                {
                    numbers.Remove(int.Parse(tokens[1]));
                }
                else if (cmdArg == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(tokens[1]));
                }
                else if (cmdArg == "Insert")
                {
                    numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                }
                else if (cmdArg == "Contains")
                {
                    int number = int.Parse(tokens[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                        
                    }
                }
                else if (cmdArg == "PrintEven")
                {
                    Console.WriteLine(String.Join(" ", numbers.FindAll(n => n % 2 == 0)));
                    
                }
                else if (cmdArg == "PrintOdd")
                {
                    Console.WriteLine(String.Join(" ", numbers.FindAll(n => n % 2 != 0)));
                }
                else if (cmdArg == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (cmdArg == "Filter")
                {
                    string condition = tokens[1];
                    int number = int.Parse(tokens[2]);

                    if (condition == "<")
                    {
                        Console.WriteLine(String.Join(" ", numbers.FindAll(n => n < number)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(String.Join(" ", numbers.FindAll(n => n > number)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(String.Join(" ", numbers.FindAll(n => n >= number)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(String.Join(" ", numbers.FindAll(n => n <= number)));
                    }
                }
                command = Console.ReadLine();
            }
            if (originalNumbers != numbers)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
            
        }
    }
}