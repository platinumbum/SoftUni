using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<double> evenNumber = new HashSet<double>();
            double theNumber = 0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (evenNumber.Contains(number))
                {
                    theNumber = number;
                }
                evenNumber.Add(number);

            }
            Console.WriteLine(theNumber);
        }
    }
}
