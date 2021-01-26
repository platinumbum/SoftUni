﻿using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jaggedMatrix = new double[n][];

            for (int row = 0; row < n; row++)
            {
                double[] currentRow = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jaggedMatrix[row] = currentRow;
            }

            for (int row = 0; row < n - 1; row++)
            {
                double[] firstArr = jaggedMatrix[row];
                double[] secondArr = jaggedMatrix[row + 1];
                if (firstArr.Length == secondArr.Length)
                {
                    jaggedMatrix[row] = firstArr.Select(e => e * 2).ToArray();
                    jaggedMatrix[row + 1] = secondArr.Select(e => e * 2).ToArray();
                }
                else
                {
                    jaggedMatrix[row] = firstArr.Select(e => e / 2).ToArray();
                    jaggedMatrix[row + 1] = secondArr.Select(e => e / 2).ToArray();
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdArg = command.Split(" ");
                int rowIndex = int.Parse(cmdArg[1]);
                int colIndex = int.Parse(cmdArg[2]);
                int value = int.Parse(cmdArg[3]);

                bool isValid = rowIndex >= 0 && rowIndex < n && colIndex >= 0 && colIndex < jaggedMatrix[rowIndex].Length;
                if (!isValid)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (cmdArg[0] == "Add")
                {

                    jaggedMatrix[rowIndex][colIndex] += value;
                }
                else if (cmdArg[0] == "Subtract")
                {
                    jaggedMatrix[rowIndex][colIndex] -= value;
                }

                command = Console.ReadLine();
            }
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ",jaggedMatrix[row]));
            }
        }
    }
}
