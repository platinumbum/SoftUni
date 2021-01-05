using System;

namespace _01._USD_To_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = 1.79549;

            double result = usd * bgn;

            Console.WriteLine($"{result:f2}");
        }
    }
}
