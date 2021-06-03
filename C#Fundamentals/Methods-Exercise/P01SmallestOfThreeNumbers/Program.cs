using System;

namespace P01SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int smallestNumber = PrintTheSmallestNumber(firstNum, secondNum, thirdNum);
            Console.WriteLine(smallestNumber);

        }

        private static int PrintTheSmallestNumber(int firstNum, int secondNum, int thirdNum)
        {
            int smallestNum = 0;
            if (firstNum < secondNum && firstNum < thirdNum)
            {
                smallestNum = firstNum;
            }
            else if (secondNum < firstNum && secondNum < thirdNum)
            {
                smallestNum = secondNum;
            }
            else
            {
                smallestNum = thirdNum;
            }

            return smallestNum;
        }
    }
}
