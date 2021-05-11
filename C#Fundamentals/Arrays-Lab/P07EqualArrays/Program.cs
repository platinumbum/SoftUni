using System;
using System.Linq;

namespace P07EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = arr1.Sum();
            bool isDifferent = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isDifferent = true;
                    break;
                }

            }
            if (!isDifferent)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }


        }
    }
}
