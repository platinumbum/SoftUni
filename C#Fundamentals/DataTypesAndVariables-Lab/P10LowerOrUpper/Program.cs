using System;

namespace P10LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char element = char.Parse(Console.ReadLine());

            if (Char.IsUpper(element))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
