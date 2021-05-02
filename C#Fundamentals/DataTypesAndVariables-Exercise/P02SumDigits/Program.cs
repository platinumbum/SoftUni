using System;

namespace P02SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            while (n > 0)
            {
                sumOfDigits += n % 10;
                n = n / 10;
            }
            Console.WriteLine(sumOfDigits);

        }
    }
}
