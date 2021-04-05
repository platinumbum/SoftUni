using System;

namespace P08TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double squareKm = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {city} has population of {population} and area {squareKm} square km.");
        }
    }
}
