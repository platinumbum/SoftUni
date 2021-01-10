using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Facebook = 150;
            const int Instagram = 100;
            const int Reddit = 50;

            int openedTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < openedTabs; i++)
            {

                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= Facebook;
                }
                else if (website == "Instagram")
                {
                    salary -= Instagram;
                }
                else if (website == "Reddit")
                {
                    salary -= Reddit;
                }


            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
                
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
