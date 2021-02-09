using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.Name = "Djoki";
            personOne.Age = 25;

            Person personTwo = new Person()
            {
                Name = "Ema",
                Age = 31
            };
        }
    }
}
