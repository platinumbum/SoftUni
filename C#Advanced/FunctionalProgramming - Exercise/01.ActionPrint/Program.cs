using System;

namespace Functional_Programming___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string> action = Print;
            for (int i = 0; i < names.Length; i++)
            {
                action(names[i]);
            }
        }

        static void Print(string name)
        {
            Console.WriteLine(name);
        }
    }
}
