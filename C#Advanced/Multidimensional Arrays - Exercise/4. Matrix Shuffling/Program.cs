using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                
                string[] commands = command.Split().ToArray();
                if (command.Length == 5 && commands[0] == "swap" 
                    && int.Parse(commands[1]) <= rows 
                    && int.Parse(commands[2]) <= cols
                    && int.Parse(commands[3]) <= rows
                    && int.Parse(commands[4]) <= cols)
                {
                    int rowIndexOne = int.Parse(commands[1]);
                    int colIndexOne = int.Parse(commands[2]);
                    int rowIndexTwo = int.Parse(commands[3]);
                    int colIndexTwo = int.Parse(commands[4]);

                    string firstElement = matrix[rowIndexOne, colIndexOne];
                    string secondElement = matrix[rowIndexTwo, colIndexTwo];

                    matrix[rowIndexTwo, colIndexTwo] = firstElement;
                    matrix[rowIndexOne, colIndexOne] = secondElement;
                }

                else
                {
                    Console.WriteLine("Input invalid!");
                    continue;
                   
                }

            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
