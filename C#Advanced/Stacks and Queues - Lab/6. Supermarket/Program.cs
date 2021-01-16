using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> names = new Queue<string>();

            while (name != "End")
            {
                if (name != "Paid")
                {
                    names.Enqueue(name);
                }
                else if (name == "Paid")
                {
                    int count = names.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
