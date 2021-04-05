using System;

namespace P09CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "";
            for (int i = 0; i < 3; i++)
            {
                char singleChar = char.Parse(Console.ReadLine());
                sentence += singleChar;
            }
            Console.WriteLine(sentence);
        }
    }
}
