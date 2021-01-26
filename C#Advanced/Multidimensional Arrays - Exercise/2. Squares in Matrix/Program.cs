﻿using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            

            char[,] matrix = new char[rows, cols];
            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int row = 0; row < rows  - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char element = matrix[row, col];
                    if (matrix[row, col + 1] == element &&
                        matrix[row + 1, col] == element &&
                        matrix[row + 1, col + 1] == element)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
