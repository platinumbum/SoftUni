using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());
            double socialScholarship = Math.Floor(0.35 * minimalSalary);
            double excellenceScholarship = Math.Floor(25 * averageGrade);

            if (income >= minimalSalary && averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellenceScholarship} BGN");
            }
            else if (income >= minimalSalary && averageGrade < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimalSalary && averageGrade >= 5.5 && socialScholarship <= excellenceScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellenceScholarship} BGN");
            }
            else if (income < minimalSalary && averageGrade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (income < minimalSalary && averageGrade <= 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
