using System;

namespace P03CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            CharsInbetween(one, two);
        }

        private static void CharsInbetween(char one, char two)
        {
            if (one > two)
            {
                char first = one;
                one = two;
                two = first;
            }
            for (int i = one + 1; i < two; i++)
            {
                Console.Write((char)i +" ");
            }
        }
    }
}
