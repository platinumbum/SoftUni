using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();

            double result = 0;
            string oddOrEven = "";

            switch (action)
            {
                case "+":
                    result = n + n2;
                    if (result % 2 == 0)
                    {
                        oddOrEven = "even";
                        Console.WriteLine($"{n} {action} {n2} = {result} - {oddOrEven}");
                    }
                    else
                    {
                        oddOrEven = "odd";
                        Console.WriteLine($"{n} {action} {n2} = {result} - {oddOrEven}");
                    }
                    break;
                case "-":
                    result = n - n2;
                    if (result % 2 == 0)
                    {
                        oddOrEven = "even";
                        Console.WriteLine($"{n} {action} {n2} = {result} - {oddOrEven}");
                    }
                    else
                    {
                        oddOrEven = "odd";
                        Console.WriteLine($"{n} {action} {n2} = {result} - {oddOrEven}");
                    }
                    break;
                case "*":
                    result = n * n2;
                    if (result % 2 == 0)
                    {
                        oddOrEven = "even";
                        Console.WriteLine($"{n} {action} {n2} = {result} - {oddOrEven}");
                    }
                    else
                    {
                        oddOrEven = "odd";
                        Console.WriteLine($"{n} {action} {n2} = {result} - {oddOrEven}");
                    }
                    break;

                case "/":

                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n} by zero");
                    }
                    else
                    {
                        result = (n / n2);
                        Console.WriteLine($"{n} / {n2} = {result:f2}");
                    }

                    break;
                case "%":
                    result = n % n2;
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n} by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{n} % {n2} = {result}");
                    }

                    break;
            }
        }
    }
}
