using System;

namespace P06StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            int currentDigit = 0;
            int factoriel = 1;
            int sum = 0;

            for (int i = 0; i < numberString.Length; i++)
            {
                currentDigit = int.Parse(numberString[i].ToString());
                for (int j = 1; j <= currentDigit; j++)
                {
                    factoriel *= j;
                }
                sum += factoriel;
                factoriel = 1;
            }
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
