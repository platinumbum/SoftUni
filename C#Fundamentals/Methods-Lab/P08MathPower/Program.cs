using System;

namespace P08MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            
            double result =  CalculatePower(number, power);
            Console.WriteLine(result);
        }

        private static double CalculatePower(double number, int power)
        {
            double result = 0;
            result = Math.Pow(number, power);
            return result;
        }
    }
}
