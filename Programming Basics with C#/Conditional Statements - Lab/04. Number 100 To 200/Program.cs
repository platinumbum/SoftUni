using System;

namespace _04._Number_100_To_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else if (number >= 100)
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
    }
}
