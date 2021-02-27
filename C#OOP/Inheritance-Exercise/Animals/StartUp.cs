﻿using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Beast!")
                {
                    break;
                }
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int age = int.Parse(data[1]);
                string gender = data[2];
                if (string.IsNullOrEmpty(name) || age < 0 || string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (input == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    Console.WriteLine(cat.ProduceSound());
                }
                else if (input == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    Console.WriteLine(dog.ProduceSound()); 
                }
                else if (input == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    Console.WriteLine(frog.ProduceSound()); 
                }
                else if (input == "Kitten")
                {
                    Kittens kitten = new Kittens(name, age);
                    Console.WriteLine(kitten.ProduceSound()); 
                }
                else if (input == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    Console.WriteLine(tomcat.ProduceSound()); 
                }

                
            }
        }
    }
}
