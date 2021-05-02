using System;

namespace P03Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int coursesCounter = 0;

            while (numberOfPeople > 0)
            {
                numberOfPeople -= elevatorCapacity;
                coursesCounter++;
            }
            Console.WriteLine(coursesCounter);
        }
    }
}
