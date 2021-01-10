using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int badGradesCounter = 0;
            int tasksSolved = 0;
            double gradesSum = 0;
            string lastTask = "";
            bool isFailed = true;

            while (badGradesCounter < badGrades)
            {
                string taskName = Console.ReadLine();
                if ("Enough" == taskName)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGradesCounter++;
                }
                gradesSum += grade;
                tasksSolved++;
                lastTask = taskName;

            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / tasksSolved:f2}");
                Console.WriteLine($"Number of problems: {tasksSolved}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
