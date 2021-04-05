using System;

namespace P03ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal result = 0;

            for (int i = 0; i < n; i++)
            {
                decimal currentNum = decimal.Parse(Console.ReadLine());
                result += currentNum;
            }
            Console.WriteLine(result);
        }
    }
}
