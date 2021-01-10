using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            int cakeSize = cakeWidth * cakeLength;
            int piecesEaten = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{cakeSize - piecesEaten} pieces are left.");
                    break;
                }
                int cakePieces = int.Parse(input);
                piecesEaten += cakePieces;
                if (piecesEaten > cakeSize)
                {

                    Console.WriteLine($"No more cake left! You need {piecesEaten - cakeSize} pieces more.");
                    break;
                }
            }
            

        }
    }
}
