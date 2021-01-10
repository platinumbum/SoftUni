using System;

namespace _08._Number_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int imputNumber = int.Parse(Console.ReadLine());

                if (max < imputNumber)
                {
                    max = imputNumber;
                }

                if (min > imputNumber)
                {
                    min = imputNumber;
                }
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
