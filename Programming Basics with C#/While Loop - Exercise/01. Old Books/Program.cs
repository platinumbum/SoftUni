using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            bool isFound = false;
            int bookCounter = 0;
            string nextBook = Console.ReadLine();


            while (nextBook != "No More Books")
            {


                if (nextBook == favouriteBook)
                {
                    isFound = true;
                    break;
                }
                bookCounter++;
                nextBook = Console.ReadLine();

            }
            if (isFound)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
        }
    }
}
