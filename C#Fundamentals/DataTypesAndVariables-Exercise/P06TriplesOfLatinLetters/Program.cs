using System;

namespace P06TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char firstSymbol = (char)(97 + i);
                        char secondSymbol = (char)(97 + j);
                        char thirdSymbol = (char)(97 + k);

                        Console.WriteLine($"{firstSymbol}{secondSymbol}{thirdSymbol}");
                    }
                }
            }
        }
    }
}
