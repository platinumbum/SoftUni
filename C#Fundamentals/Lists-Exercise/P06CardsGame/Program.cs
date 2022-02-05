using System;
using System.Collections.Generic;
using System.Linq;

namespace P06CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> playerTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (playerOne.Count != 0 && playerTwo.Count != 0)
            {

                int firstCard = playerOne[0];
                int secondCard = playerTwo[0];

                if (firstCard > secondCard)
                {
                    playerOne.Add(firstCard);
                    playerOne.Add(secondCard);

                    playerOne.Remove(firstCard);
                    playerTwo.Remove(secondCard);
                }
                else if (firstCard < secondCard)
                {
                    playerTwo.Add(secondCard);
                    playerTwo.Add(firstCard);

                    playerTwo.Remove(secondCard);
                    playerOne.Remove(firstCard);
                }
                else if (firstCard == secondCard)
                {
                    playerOne.Remove(firstCard);
                    playerTwo.Remove(secondCard);
                }
            }

            if (playerOne.Count > playerTwo.Count)
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }
        }
    }
}