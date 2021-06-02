using System;

namespace P07RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            string final = RepeatString(input, repeatCount);
            Console.WriteLine(final);
        }

        private static string RepeatString(string input, int repeatCount)
        {
            string result = "";

            for (int i = 0; i < repeatCount; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
