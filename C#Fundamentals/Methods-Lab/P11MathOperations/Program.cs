using System;

namespace P11MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            double result = Calculate(a, mathOperator, b);
            Console.WriteLine(result);
        }

        private static double Calculate(int a, string mathOperator, int b)
        {
            double result = 0;

            switch (mathOperator)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }

            return result;
        }
    }
}
