using System;

namespace P02GaussTrick // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            

            int halfIndex = numbers.Count / 2;

            for (int i = 0; i < halfIndex; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.Remove(numbers[numbers.Count - 1]);
            }
            Console.WriteLine(String.Join(" ", numbers));   
        }
    }
}