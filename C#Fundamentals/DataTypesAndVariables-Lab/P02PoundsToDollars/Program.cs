using System;

namespace P02PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = pounds * 1.31M;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
