using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;
            int totalSteps = 0;
            while (totalSteps < stepsGoal)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    totalSteps += stepsLeft;
                    break;
                }
                else
                {
                    int steps = int.Parse(input);
                    totalSteps += steps;
                }

            }
            if (totalSteps >= stepsGoal)
            {
                int overTheGoal = totalSteps - stepsGoal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{overTheGoal} steps over the goal!");
            }
            else
            {
                int underTheGoal = stepsGoal - totalSteps;
                Console.WriteLine($"{underTheGoal} more steps to reach goal.");
            }
        }
    }
}
