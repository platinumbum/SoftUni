using System;

namespace P04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            string firstPosition = string.Empty;

            for (int i = 0; i < n; i++)
            {
                firstPosition = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length - 1] = firstPosition;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
