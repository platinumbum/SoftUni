using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double yearlyInterest = double.Parse(Console.ReadLine());

            double interestAmount = (depositSum * yearlyInterest) / 100;
            double interestPerMonth = interestAmount / 12;
            double totalSum = depositSum + depositTerm * interestPerMonth;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
