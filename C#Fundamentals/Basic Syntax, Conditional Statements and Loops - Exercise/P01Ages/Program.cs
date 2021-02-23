using System;

namespace P01Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string typeOfHuman = "";
            if (age >=0 && age <= 2)
            {
                typeOfHuman = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                typeOfHuman = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                typeOfHuman = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                typeOfHuman = "adult";
            }
            else
            {
                typeOfHuman = "elder";
            }
            Console.WriteLine(typeOfHuman);
        }
    }
}
