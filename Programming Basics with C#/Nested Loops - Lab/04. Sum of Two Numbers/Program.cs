using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;

            bool isFound = false;

            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    combinations++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
                        isFound = true;
                        break;
                    }


                }
                if (isFound)
                {
                    break;
                }


            }
            if (!isFound)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }

        }
    }
}
