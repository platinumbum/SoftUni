using System;
using System.Linq;

namespace P05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int counter = 1;
            bool isNotValid = false;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string input = Console.ReadLine();
            while (input != password)
            {
                if (counter == 4)
                {
                    isNotValid = true;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                counter++;

            }
            if (isNotValid)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }

            
        }
    }
}
