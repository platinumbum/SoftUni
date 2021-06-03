using System;

namespace P07NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            WriteAMatrix(n);
        }

        private static void WriteAMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(n + " ");
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
