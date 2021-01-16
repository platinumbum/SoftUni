using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int tosses = int.Parse(Console.ReadLine());
            Queue<string> potatoeQueue = new Queue<string>(kids);
            int countTosses = 0;

            while (potatoeQueue.Count > 1)
            {
                countTosses++;
                string currentKid = potatoeQueue.Dequeue();
                
                if (countTosses == tosses)
                {
                    countTosses = 0;
                    Console.WriteLine("Removed " + currentKid);
                }
                else
                {
                    potatoeQueue.Enqueue(currentKid);
                }
            }
            Console.WriteLine("Last is " + potatoeQueue.Dequeue());
        }
    }
}
