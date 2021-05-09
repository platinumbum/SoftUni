using System;
using System.Linq;

namespace P03RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{(decimal)nums[i]} => {Math.Round((decimal)nums[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
