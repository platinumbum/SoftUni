using System;

namespace P09GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            string theBest = GetMax(type, first, second);
            Console.WriteLine(theBest);
        }

        private static string GetMax(string type, string first, string second)
        {
            string theBest = "";
            if (type == "int")
            {
                int firstNum = int.Parse(first);
                int secondNum = int.Parse(second);
                if (firstNum > secondNum)
                {
                    theBest = first;
                }
                else
                {
                    theBest = second;
                }
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(first);
                char secondChar = char.Parse(second);
                if (firstChar > secondChar)
                {
                    theBest = first;
                }
                else
                {
                    theBest = second;
                }
            }
            else if (type == "string")
            {
                if (string.Compare(first, second ) < 0)
                {
                    theBest = second;
                }
                else
                {
                    theBest = first;
                }
            }

            return theBest;
        }
    }
}
