using System;

namespace P01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int currentWagon = int.Parse(Console.ReadLine());
                wagons[i] += currentWagon;
                sum += currentWagon;
            }
            Console.WriteLine(string.Join(' ', wagons));
            Console.WriteLine(sum);
        }
    }
}
