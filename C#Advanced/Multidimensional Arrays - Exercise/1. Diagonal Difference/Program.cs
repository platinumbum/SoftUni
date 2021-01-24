using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int sumOne = 0;
            int sumTwo = 0;
            int count = n - 1;

            for (int row = 0; row < n; row++)
            {
                sumOne += matrix[row, row];
                sumTwo += matrix[row, count];
                count--;
            }

            int totalSum = Math.Abs(sumOne - sumTwo);
            Console.WriteLine(totalSum);
        }
    }
}
