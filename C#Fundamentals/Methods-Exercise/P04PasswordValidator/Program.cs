using System;

namespace P04PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isTrue =  ValidateLength(password) 
                        && ValidateLetterOrDigit(password) 
                        && PasswordHasTwoDigits(password);

            if (isTrue)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!ValidateLength(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!ValidateLetterOrDigit(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!PasswordHasTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        private static bool PasswordHasTwoDigits(string password)
        {
            int count = 0;

            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            return false;
        }

        private static bool ValidateLetterOrDigit(string password)
        {
            foreach (char item in password)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidateLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                bool isTrue = true;
                return isTrue;
            }

            return false;
        }
    }
}
