﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;


        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { 
            get 
            { 
                return this.firstName; 
            } 
            private set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                else
                {
                    this.firstName = value;
                }
                
            } 
        }
        public string LastName {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                else
                {
                    this.lastName = value;
                }
                
            }
        }
        public int Age {
            get
            {
                return this.age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                else
                {
                    this.age = value;
                }
                
            }
        }
        public decimal Salary {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                else
                {
                    this.salary = value;
                }
                
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                percentage = percentage / 2;
                Salary = Salary + Salary * percentage / 100;
            }
            else
            {
                Salary = Salary + Salary * percentage / 100;
            }
        }
    }
}
