﻿using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string pass = Console.ReadLine();

            string pass2 = Console.ReadLine();
            while (pass2 != pass)
            {


                pass2 = Console.ReadLine();

            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
