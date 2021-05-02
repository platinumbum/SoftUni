using System;

namespace P01IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());

            int total = (numOne + numTwo) / numThree * numFour;
            Console.WriteLine(total);
        }
    }
}
