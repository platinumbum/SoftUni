using System;

namespace P05AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            int sumOfTwo = SumOfTwo(one, two);
            int finalSum = Subtract(sumOfTwo, three);
            Console.WriteLine(finalSum);
        }

        private static int Subtract(int sumOfTwo, int three)
        {
            int finalSum = sumOfTwo - three;
            return finalSum;
        }

        private static int SumOfTwo(int one, int two)
        {
            int sum = one + two;
            return sum;
        }
    }
}
