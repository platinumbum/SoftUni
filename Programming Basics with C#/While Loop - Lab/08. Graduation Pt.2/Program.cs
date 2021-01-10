using System;

namespace _08._Graduation_Pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int grades = 1;
            int excluded = 0;
            double total = 0;
            bool isExcluded = false;

            while (grades <= 12)
            {

                if (excluded == 2)
                {
                    Console.WriteLine($"{studentName} has been excluded at {grades} grade");
                    isExcluded = true;
                    break;
                }

                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    excluded++;

                    continue;

                }
                total += grade;
                grades++;
            }
            if (!isExcluded)
            {
                double averge = total / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averge:f2}");
            }
        }
    }
}
