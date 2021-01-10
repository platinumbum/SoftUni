using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceOfWashingmachine = double.Parse(Console.ReadLine());
            double pricePerToy = double.Parse(Console.ReadLine());

            int toysCount = 0;
            double moneySaved = 0;
            int temp = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toysCount++;
                }
                else
                {
                    moneySaved += temp;
                    temp += 10;
                }
            }
            moneySaved -= age / 2;

            moneySaved += toysCount * pricePerToy;
            double leftMoney = Math.Abs(moneySaved - priceOfWashingmachine);

            if (moneySaved >= priceOfWashingmachine)
            {
                Console.WriteLine($"Yes! {leftMoney:f2}");
            }
            else
            {
                Console.WriteLine($"No! {leftMoney:f2}");
            }
        }
    }
}
