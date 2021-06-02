using System;

namespace P03Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                AddNumbers(a, b);
            }
            else if (command == "multiply")
            {
                MultiplyNumbers(a, b);
            }
            else if (command == "subtract")
            {
                SubtractNumbers(a, b);
            }
            else if (command == "divide")
            {
                DivideNumbers(a, b);
            }
        }

        private static void DivideNumbers(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        private static void SubtractNumbers(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        private static void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        private static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
