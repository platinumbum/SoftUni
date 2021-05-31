using System;

namespace P03Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                count++;
                string[] currentNumbers = Console.ReadLine().Split();

                if (count % 2 != 0)
                {
                    arr1[i] = currentNumbers[0];
                    arr2[i] = currentNumbers[1];
                }
                else
                {
                    arr1[i] = currentNumbers[1];
                    arr2[i] = currentNumbers[0];
                }
            }
            Console.WriteLine(string.Join(' ', arr1));
            Console.WriteLine(string.Join(' ', arr2));
        }
    }
}
