using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "stop")
            {
                int input = int.Parse(command);

                if (input < 0)
                {
                    Console.WriteLine("Number is negative");
                    continue;
                }

            }
        }
    }
}
